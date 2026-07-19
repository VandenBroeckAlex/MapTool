using A_VDB.Definition;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Collections.Generic;
using MapToolV2.Scripts.DTO;

namespace MapToolV2.Scripts
{
    public class Registery
    {
        // Static/Definitions
        public List<DTOStrataNeed> needList { get; private set; }
        public List<DTOClimateDef> climateList { get; private set; }
        public List<DefGood> goodsList { get; private set; }
        public List<DTOTerrainType> listTerrainType { get; private set; }

        // Dynamic Data
        public List<DTOCountry> countryList { get; private set; }
        public List<DTOProvince> provinceList { get; private set; }
        public List<DTOTile> tileList { get; private set; }
        public List<DTOPopulation> populationList { get; private set; }
        public List<DTOWorkplaceInstance> dTOWorkplaces { get; private set; }
  
        public Registery(
            List<DTOStrataNeed> needs,
            List<DTOClimateDef> climates,
            List<DefGood> goods,
            List<DTOTerrainType> terrainTypes,
            List<DTOCountry> countries,
            List<DTOProvince> provinces,
            List<DTOTile> tiles,
            List<DTOPopulation> populations,
            List<DTOWorkplaceInstance> workplaces
            )
        {
            needList = needs;
            climateList = climates;
            goodsList = goods;
            listTerrainType = terrainTypes;

            countryList = countries;
            provinceList = provinces;
            tileList = tiles;
            populationList = populations;
            dTOWorkplaces = workplaces;
        }
    }
}
