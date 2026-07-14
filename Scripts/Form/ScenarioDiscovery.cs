using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace MapToolV2.Scripts.Form
{
    using System;
    using System.IO;
    using System.Linq;

    public static class ScenarioDiscovery
    {
        public static string[] GetScenarios(string rootfile)
        {
            try
            {
                string path = Path.Combine(rootfile, "Scenarios");
                //MessageBox.Show("Looking for files in: " + path);
                if (!Directory.Exists(path))
                {
                    Console.WriteLine($"Directory not found: {path}");
                    return Array.Empty<string>();
                }
                return Directory.GetDirectories(path)
                                .Select(file => Path.GetFileName(file))
                                .ToArray();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error discovering scenarios: {ex.Message}");
                return Array.Empty<string>();
            }
        }
    }
}
