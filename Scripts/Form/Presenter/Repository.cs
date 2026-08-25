using MapToolV2.Scripts.Form.Models;

namespace MapToolV2.Scripts.Form.Controler
{
    public class Repository
    {
        // Static/Definitions
        public List<DTOStrataNeed> needList { get; private set; }
        public List<DTOClimateDef> climateList { get; private set; }
        public List<DefGood> goodsList { get; private set; }
        public List<DTOTerrainType> listTerrainType { get; private set; }

        // Dynamic Data
        public List<DTOCountry> countryList { get; private set; }
        public List<DTOProvince> provinceList { get; private set; }
        public List<DTOTile.TileDTO> tileList { get; private set; }
        public List<DTOPopulation> populationList { get; private set; }
        public List<DTOWorkplaceInstance> dTOWorkplaces { get; private set; }
        public List<string> tileColor { get; private set; }
        //colors

        public Repository()
        {
            needList = new List<DTOStrataNeed>();
            climateList = new List<DTOClimateDef>();
            goodsList = new List<DefGood>();
            listTerrainType = new List<DTOTerrainType>();

            countryList = new List<DTOCountry>();
            provinceList = new List<DTOProvince>();
            tileList = new List<DTOTile.TileDTO>();
            populationList = new List<DTOPopulation>();
            dTOWorkplaces = new List<DTOWorkplaceInstance>();
        }

        public Repository(
            List<DTOStrataNeed> needs,
            List<DTOClimateDef> climates,
            List<DefGood> goods,
            List<DTOTerrainType> terrainTypes,
            List<DTOCountry> countries,
            List<DTOProvince> provinces,
            List<DTOTile.TileDTO> tiles,
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

        public string GetProvinceNameByTag(string tag)
        {
            DTOProvince province = provinceList.Where(p => p.tag == tag).FirstOrDefault();
            if (province != null) 
            {
                return province.name;
            }
            else
            {
                return "";
            }
        }
    }
}
