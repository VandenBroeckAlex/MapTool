using MapToolV2.Scripts.DTO;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Security.Principal;
using System.Text.Json;
using System.Threading.Tasks;

namespace MapToolV2.Scripts.Loader.Deserializers
{
    class DataDeserializer
    {
        //List<DTOClimateDef> climates = DataDeserializer.LoadListFromJson<DTOClimateDef>("climates.json");
        public static List<T> LoadListFromJson<T>(string path)
        {
            if (!File.Exists(path))
            {
                throw new FileNotFoundException($" file missing at: {path}");
            }
            string json = File.ReadAllText(path);

            // --- VALIDATION ZONE ---
            try
            {
                // Parse into a generic JSON token to validate syntax
                JToken token = JToken.Parse(json);

                // Explicitly check if the root is an array, method requires List<T>
                if (token.Type != JTokenType.Array)
                {
                    throw new JsonReaderException(
                        $"Data structure error: Expected a JSON Array '[...]' at the root, " +
                        $"but found a {token.Type}. Check if you forgot the wrapping brackets '[ ]'!"
                    );
                }
            }
            catch (JsonReaderException ex)
            {
                // Catch syntax errors (missing commas, broken brackets, bad types)
                throw new FormatException(
                    $"Invalid JSON layout detected in file '{Path.GetFileName(path)}'. \nDetails: {ex.Message}",
                    ex
                );
            }

            List<T>? data = JsonConvert.DeserializeObject<List<T>>(json);

            return data ?? new List<T>();
        }

        public static T LoadObjectFromJson<T>(string path) where T : new()
        {

            if (!File.Exists(path))
            {
                throw new FileNotFoundException($" file missing at: {path}");
            }
            string json = File.ReadAllText(path);

            // --- VALIDATION ZONE ---
            try
            {
                // Parse into a generic JSON token to validate syntax
                JToken token = JToken.Parse(json);

             
            }
            catch (JsonReaderException ex)
            {
                // Catch syntax errors (missing commas, broken brackets, bad types)
                throw new FormatException(
                    $"Invalid JSON layout detected in file '{Path.GetFileName(path)}'. \nDetails: {ex.Message}",
                    ex
                );
            }

            var settings = new JsonSerializerSettings
            {
                // This handler intercepts schema mismatches 
                Error = delegate (object? sender, Newtonsoft.Json.Serialization.ErrorEventArgs args)
                {
                    string errorMessage = $"Data Type Mismatch in file '{Path.GetFileName(path)}'!\n" +
                                          $"Location: {args.ErrorContext.Path}\n" +
                                          $"Problem: {args.ErrorContext.Error.Message}\n\n" +
                                          $"Please make sure you didn't accidentally type text where a number belongs.";


                    throw new InvalidCastException(errorMessage, args.ErrorContext.Error);
                }
            };

            // Deserialisizing
            T? data = JsonConvert.DeserializeObject<T>(json);

            return data ?? new T();
        }

    


    public static DeserializerBootstrap LoadProvincesData(string path, DeserializerBootstrap bootstrap)
    {
            //Chemin du scénario
            string[] directories = Directory.GetDirectories(Path.Combine(path,"Provinces"));
            
            //Pour chaque fichier
            foreach (string d in directories)
            {
                string folderName = Path.GetFileName(d);
                if (folderName != "ZZZ_OrphanTiles")
                {


                    //Lire province.json data
                    string provinceJsonPath = Path.Combine(d, "Province.json");
                    if (!File.Exists(provinceJsonPath))
                    {
                        throw new FileNotFoundException($" file missing at: {provinceJsonPath}");
                    }
                    //Deserialize Province
                    DTOProvince province = LoadObjectFromJson<DTOProvince>(provinceJsonPath);

                    if (province != null)
                    {
                        bootstrap.AddProvince(province);
                    }
                    //Deserializer Population
                    string popJsonPath = Path.Combine(d, "Population.json");
                    if (!File.Exists(popJsonPath))
                    {
                        throw new FileNotFoundException($" file missing at: {popJsonPath}");
                    }
                    List<DTOPopulation> poplist = LoadObjectFromJson<List<DTOPopulation>>(popJsonPath);

                    //Deserializer Workplace
                    string workplaceJsonPath = Path.Combine(d, "Workplaces.json");
                    if (!File.Exists(workplaceJsonPath))
                    {
                        throw new FileNotFoundException($" file missing at: {workplaceJsonPath}");
                    }
                    List<DTOWorkplaceInstance> workplaces = LoadListFromJson<DTOWorkplaceInstance>(workplaceJsonPath);
                    bootstrap.AddWorkplaceList(workplaces);
                    //Pour chaque fichier dans Tile
                    string[] jsonFiles = Directory.GetFiles(path, "*.json");
                    foreach (string file in jsonFiles)
                    {
                        //Lire json déserializer Tile
                        DTOTile.TileDTO tile = TileLoader.LoadTile(file);

                        // it automatically casts it and names the variable 'landTile'
                        if (tile is DTOTile.LandTileDTO landTile)
                        {
                            // Now you can safely reach workplaces!
                            if (landTile.workplaces != null)
                            {
                                bootstrap.AddWorkplaceList(landTile.workplaces);
                            }
                        }
                    }

                }
                // File is ZZZ_OrphanTiles
                else
                {
                    // 1. Combine the path once and store it
                    string filePath = Path.Combine(d, "OrphanTiles.json");
                  
                    if (!File.Exists(filePath))
                    {
                        continue;
                    }

                    string orphanTiles = File.ReadAllText(filePath);

                    List<DTOTile> orphanTile = LoadListFromJson<DTOTile>(orphanTiles);
                    bootstrap.AddTileList(orphanTile);
                }
            }
            return bootstrap;
        }
  }

    public static class TileLoader
    {
        public static DTOTile.TileDTO LoadTile(string filePath)
        {
            if (!File.Exists(filePath))
            {
                throw new FileNotFoundException($"File missing at: {filePath}");
            }

            string json = File.ReadAllText(filePath).Trim();

            JObject tileJson;

            // 1. Detect if the file starts as an Array [ ... ] or an Object { ... }
            if (json.StartsWith("["))
            {
                // If it's an array, parse it as a JArray and grab the first object inside it
                JArray array = JArray.Parse(json);
                if (array.Count == 0)
                {
                    throw new System.InvalidOperationException($"The JSON array in '{Path.GetFileName(filePath)}' is empty!");
                }
                tileJson = (JObject)array[0];
            }
            else
            {
                // If it's a standard object, parse it directly
                tileJson = JObject.Parse(json);
            }

            // 2. Read the "isLand" property safely
            bool isLand = tileJson["isLand"]?.Value<bool>() ?? false;

            // 3. Deserialize into the correct DTO class
            if (isLand)
            {
                return tileJson.ToObject<DTOTile.LandTileDTO>()
                    ?? throw new System.NullReferenceException("Failed to deserialize LandTileDTO");
            }
            else
            {
                return tileJson.ToObject<DTOTile.WaterTileDTO>()
                    ?? throw new System.NullReferenceException("Failed to deserialize WaterTileDTO");
            }
        }
    }
}
