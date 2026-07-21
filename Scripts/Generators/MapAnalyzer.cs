using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.Runtime.InteropServices;

namespace MapAnalysis
{
    // <summary>
    // Result of analyzing a color-coded tile map image.
    // </summary>
    public class MapAnalysisResult
    {
        /// <summary>All distinct colors found in the image.</summary>
        public List<Color> Colors { get; } = new List<Color>();

        /// <summary>Pixel count (surface area) for each color.</summary>
        public Dictionary<Color, long> Surface { get; } = new Dictionary<Color, long>();

        /// <summary>For each color, the set of colors that touch it (share at least one edge).</summary>
        public Dictionary<Color, HashSet<Color>> Neighbors { get; } = new Dictionary<Color, HashSet<Color>>();

        /// <summary>For each color, the pivot / centroid: the average X,Y position of all its pixels.</summary>
        public Dictionary<Color, PointF> Pivot { get; } = new Dictionary<Color, PointF>();
    }

    public static class MapAnalyzer
    {
        /// <summary>
        /// Analyzes a tile-map image where each region/tile is a solid color.
        /// </summary>
        /// <param name="imagePath">Path to the image file (png, bmp, etc.).</param>
        /// <param name="wrapHorizontal">If true, the right edge of the map is considered adjacent to the left edge.</param>
        /// <param name="wrapVertical">If true, the bottom edge of the map is considered adjacent to the top edge.</param>
        public static MapAnalysisResult Analyze(string imagePath, bool wrapHorizontal, bool wrapVertical)
        {
            using var bitmap = new Bitmap(imagePath);
            return Analyze(bitmap, wrapHorizontal, wrapVertical);
        }

        /// <summary>
        /// Analyzes an already-loaded bitmap. Ignores the alpha channel is NOT assumed:
        /// two pixels with the same RGB but different alpha are treated as different colors.
        /// If you want alpha ignored, convert your bitmap to 24bpp before calling this.
        /// </summary>
        public static MapAnalysisResult Analyze(Bitmap bitmap, bool wrapHorizontal, bool wrapVertical)
        {
            int width = bitmap.Width;
            int height = bitmap.Height;

            // Read all pixels up-front (much faster than repeated GetPixel calls).
            Color[,] pixels = ReadPixels(bitmap);

            var result = new MapAnalysisResult();
            var sumX = new Dictionary<Color, double>();
            var sumY = new Dictionary<Color, double>();

            for (int y = 0; y < height; y++)
            {
                for (int x = 0; x < width; x++)
                {
                    Color c = pixels[x, y];

                    if (!result.Surface.ContainsKey(c))
                    {
                        result.Colors.Add(c);
                        result.Surface[c] = 0;
                        result.Neighbors[c] = new HashSet<Color>();
                        sumX[c] = 0;
                        sumY[c] = 0;
                    }

                    result.Surface[c]++;
                    sumX[c] += x;
                    sumY[c] += y;

                    // Right neighbor (handles horizontal wrap)
                    int rx = x + 1;
                    bool rightValid = true;
                    if (rx >= width)
                    {
                        if (wrapHorizontal) rx = 0;
                        else rightValid = false;
                    }
                    if (rightValid)
                    {
                        Color rc = pixels[rx, y];
                        if (!rc.Equals(c)) AddNeighborPair(result, c, rc);
                    }

                    // Down neighbor (handles vertical wrap)
                    int dy = y + 1;
                    bool downValid = true;
                    if (dy >= height)
                    {
                        if (wrapVertical) dy = 0;
                        else downValid = false;
                    }
                    if (downValid)
                    {
                        Color dc = pixels[x, dy];
                        if (!dc.Equals(c)) AddNeighborPair(result, c, dc);
                    }
                }
            }

            foreach (var c in result.Colors)
            {
                long n = result.Surface[c];
                result.Pivot[c] = new PointF((float)(sumX[c] / n), (float)(sumY[c] / n));
            }

            return result;
        }

        private static void AddNeighborPair(MapAnalysisResult result, Color a, Color b)
        {
            if (!result.Neighbors.ContainsKey(b))
                result.Neighbors[b] = new HashSet<Color>();

            result.Neighbors[a].Add(b);
            result.Neighbors[b].Add(a);
        }

        private static Color[,] ReadPixels(Bitmap bitmap)
        {
            int width = bitmap.Width;
            int height = bitmap.Height;
            var pixels = new Color[width, height];

            BitmapData data = bitmap.LockBits(
                new Rectangle(0, 0, width, height),
                ImageLockMode.ReadOnly,
                PixelFormat.Format32bppArgb);

            try
            {
                int bytesPerPixel = 4;
                int stride = data.Stride;
                byte[] buffer = new byte[stride * height];
                Marshal.Copy(data.Scan0, buffer, 0, buffer.Length);

                for (int y = 0; y < height; y++)
                {
                    int rowOffset = y * stride;
                    for (int x = 0; x < width; x++)
                    {
                        int offset = rowOffset + x * bytesPerPixel;
                        byte b = buffer[offset];
                        byte g = buffer[offset + 1];
                        byte r = buffer[offset + 2];
                        byte a = buffer[offset + 3];
                        pixels[x, y] = Color.FromArgb(a, r, g, b);
                    }
                }
            }
            finally
            {
                bitmap.UnlockBits(data);
            }

            return pixels;
        }
    }
}
