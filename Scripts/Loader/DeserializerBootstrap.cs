using MapToolV2.Scripts.Form.Controler;
using MapToolV2.Scripts.Form.Models;
using MapToolV2.Scripts.Form.Traces;
using MapToolV2.Scripts.Loader.Deserializers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MapToolV2.Scripts.Loader
{
    public class DeserializerBootstrap
    {
        

        private StringPath path;
        private List<DTOStrataNeed> needList;
        private List<DTOClimateDef> climateList;
        private List<DefGood> goodsList;
        private List<DTOTerrainType> listTerrainType;

        // Dynamic Data
        private List<DTOCountry> countryList = new List<DTOCountry>();
        private List<DTOProvince> provinceList = new List<DTOProvince>();
        private List<DTOTile.TileDTO> tileList = new List<DTOTile.TileDTO>();
        private List<DTOPopulation> populationList = new List<DTOPopulation>();
        private List<DTOWorkplaceInstance> workplacesInstance = new List<DTOWorkplaceInstance>();
       
       

        public DeserializerBootstrap(string rootfile, string _scenario) 
        {
            path = new StringPath(rootfile, _scenario);
        }

        public Repository Deserialize(IDeserializeTrace trace)
        {

            trace.Log("--- Begin deserialization ---", MesssageType.info);
            //try catch here
            //Get static data
            //Need
            trace.Log("Deserialize: " + Path.Combine(path.gameData, "StrataNeedDef.json"), MesssageType.info);
            needList = DataDeserializer
               .LoadListFromJson<DTOStrataNeed>(
               Path.Combine(path.gameData, "StrataNeedDef.json"), 
               trace
               );
            trace.Log("Deserialize: " + Path.Combine(path.gameData, "ClimateType.json"), MesssageType.info);
            climateList = DataDeserializer
               .LoadListFromJson<DTOClimateDef>(
               Path.Combine(path.gameData, "ClimateType.json"),
               trace
               );

            try
            {
                trace.Log("Deserialize: " + Path.Combine(path.gameData, "GoodDef.json"), MesssageType.info);
                goodsList = DataDeserializer
                   .LoadListFromJson<DefGood>(
                   Path.Combine(path.gameData, "GoodDef.json"),
                   trace
                   );
            }
            catch (Exception ex) 
            {
                trace.Log(ex.Message, MesssageType.error);
            }
            trace.Log("Deserialize: " + Path.Combine(path.gameData, "TerrainTypes.json"), MesssageType.info);
            listTerrainType = DataDeserializer
                .LoadListFromJson<DTOTerrainType>(
                Path.Combine(path.gameData,"TerrainTypes.json"),
                trace
                );

            //Get Scenario data

            //Get countries
            trace.Log("Deserialize: " + "Countries.json", MesssageType.info);
            countryList = DataDeserializer
               .LoadListFromJson<DTOCountry>(
               Path.Combine(path.scenario, "Countries.json"),
               trace
               );

            DataDeserializer.LoadProvincesData(path.scenario,this, trace);

            Repository registery = new Repository(
               needList,
               climateList,
               goodsList,
               listTerrainType,
               countryList,
               provinceList,
               tileList,
               populationList,
               workplacesInstance
              );

            return registery;
        }
   
    
        public void AddProvince(DTOProvince province)
        {
            provinceList.Add(province);
        }
        public void AddTile(DTOTile.TileDTO tile)
        {
            tileList.Add(tile);
        }
        public void AddTileList(List<DTOTile.TileDTO> tiles)
        {
            tileList.AddRange(tiles);
        }
        
        public void AddWorkplaceList(List<DTOWorkplaceInstance> workplaceList)
        {
            workplacesInstance.AddRange(workplaceList);
        }
        public void AddPopList(List<DTOPopulation> popList) 
        {
            populationList.AddRange(popList);
        }
    }
}
