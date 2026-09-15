using VDBA.GameDataGetter.DTO;

namespace MapToolV2.Scripts.Form.Vue.intefaces
{
    internal interface IStaticDataView
    {
        public void RefreshTerrainType(IEnumerable<DTOTerrainType>listTerrainType);
        public void RefreshClimateType(IEnumerable<DTOClimateDef> listClimateType);
        public void RefreshPopJob();
        public void InitializeBinding(); //On enter check if repo not null bind if needed
        public string GetTypedInfoTerrain();
        public DTOTerrainType GetSelectedTerrain();
        public string GetTypedInfoClimate();

        public DTOClimateDef GetSelectedClimate();


        event EventHandler TerrainAddClicked;
        event EventHandler TerrainRemoveClicked;
        event EventHandler ClimateAddClicked;
        event EventHandler ClimateRemovelicked;
        event EventHandler RefreshView;
    }
}
