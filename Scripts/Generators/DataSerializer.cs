using MapToolV2.Scripts.Form.Controler;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MapToolV2.Scripts.Generators
{
    public class DataSerializer
    {
        Repository _repo;
        string _rootfile;
        string _scenarioName; 
        DataSerializer(Repository repo, string rootfile, string scenario)
        {
            _repo = repo;
            _rootfile = rootfile;
            _scenarioName = scenario;
        }

        public void Deserialize()
        {
            //check for GameData folder
            //if not create it
            string gameDataDirPath = Path.Combine(_rootfile, "GameData");
            string scenariosDir = Path.Combine(_rootfile, "Scenarios");
            string ScenarioDir = Path.Combine(scenariosDir, _scenarioName);
            string provincesDir = Path.Combine(ScenarioDir,"Provinces");
            Directory.CreateDirectory(Path.Combine(gameDataDirPath));


            //export all static data
            //climate
            CreateJson(gameDataDirPath, "ClimateType",_repo.climateList);

            //culturedef
            //CreateJson(gameDataDirPath, "CultureDef", _repo.cultures);

            //gooddef
            CreateJson(gameDataDirPath, "GoodDef", _repo.goodsList);
            //goodType
            //popJobDef
            //PopStrataDef
            //ReligionDef
            //strataNeedDef
            //terrainType
            CreateJson(gameDataDirPath, "TerrainTypes", _repo.listTerrainType);

            //tilecolor
            //tilegraph
            //workplacesDef

            //check for scenarios folder
            //if not create it
            Directory.CreateDirectory(Path.Combine(scenariosDir));
            //check for selected date folder
            //if not create it
            Directory.CreateDirectory(Path.Combine(scenariosDir));


            //check for Provinces folder
            Directory.CreateDirectory(Path.Combine(scenariosDir));
            //if not create it
            //provinces
            foreach (DTOProvince province in _repo.provinceList) 
            {
                //create province directory
                Directory.CreateDirectory(Path.Combine(provincesDir,province.name));
                //create province json in it
                CreateJson(gameDataDirPath, "Province", province);

                //create population json in it
                List<DTOPopulation> provincePop = _repo.populationList.Where(p => p.provinceTag == province.tag).ToList();
                CreateJson(gameDataDirPath, "Population", provincePop);

                //Create workplace json in it
                CreateJson(gameDataDirPath, "Workplaces", "[]");
            }

            //foreach tile
            foreach (DTOTile.TileDTO tile in _repo.tileList) 
            {
                //get province name by tag
                string tileDirectory = Path.Combine(provincesDir, _repo.GetProvinceNameByTag(tile.provinceTag), "Tiles");
                Directory.CreateDirectory(tileDirectory);

                CreateJson(tileDirectory, tile.name, tile);
            }

        

            //zzz_orphanTiles


            //countries json
            //meta json
        }

        private void CreateJson<T>(string path, string filename,T data)
        {
            string _path = Path.Combine(path, filename);
            string jsonOutput = JsonConvert.SerializeObject(_repo.listTerrainType, Formatting.Indented);
            File.WriteAllText(_path, jsonOutput);
        }
    }
}
