using MapToolV2.Scripts.Loader;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace MapToolV2.Scripts.Generators
{
    public class CreateRoot
    {
        StringPath sp;

       public CreateRoot(string rootPath)
        {
            sp = new StringPath(rootPath,"Default");
        }


        public void Create()
        {
            Directory.CreateDirectory(sp.gameData);
            Directory.CreateDirectory(Path.Combine(sp.scenario,"Provinces"));



            string path = Path.Combine(sp.gameData, "ClimateType.json");
            string content = "[]";
            File.WriteAllText(path, content);


            path = Path.Combine(sp.gameData, "CultureDef.json");
            content = "[]";
            File.WriteAllText(path, content);

            path = Path.Combine(sp.gameData, "GoodType.json");
            content = "[]";
            File.WriteAllText(path, content);

            path = Path.Combine(sp.gameData, "PopJobDef.json");
            content = "[]";
            File.WriteAllText(path, content);

            path = Path.Combine(sp.gameData, "PopStrataDef.json");
            content = "[]";
            File.WriteAllText(path, content);

            path = Path.Combine(sp.gameData, "ReligionDef.json");
            content = "[]";
            File.WriteAllText(path, content);
            path = Path.Combine(sp.gameData, "StrataNeedDef.json");
            content = "[]";
            File.WriteAllText(path, content);
            path = Path.Combine(sp.gameData, "TerrainTypes.json");
            content = "[]";
            File.WriteAllText(path, content);
            path = Path.Combine(sp.gameData, "TileColors.json");
            content = "[]";
            File.WriteAllText(path, content);
            path = Path.Combine(sp.gameData, "TileGraph.json");
            content = "[]";
            File.WriteAllText(path, content);
            path = Path.Combine(sp.gameData, "workplacesDef.json");
            content = "[]";
            File.WriteAllText(path, content);

            path = Path.Combine(sp.scenario, "countries.json");
            content = "[]";
            File.WriteAllText(path, content);

            path = Path.Combine(sp.scenario, "meta.json");
            content = "{\r\n  \"save_name\": \"\",\r\n  \"real_timestamp\": \"\",\r\n  \r\n  \"game_state\": {\r\n    \"current_turn\": 0,\r\n    \"current_date\": \"\",\r\n    \"player_country_id\": \"\"\r\n  },\r\n  \r\n  \"compatibility\": {\r\n    \"game_version\": \"\",\r\n    \"map_id\": \"\",\r\n    \"active_mods\": []\r\n  }\r\n}";
            File.WriteAllText(path, content);
        }
      

        //Scenarios
        //countries.json
        //meta.json
    }
}
