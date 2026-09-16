using VDBA.GameDataGetter.DTO;

namespace MapToolV2.Scripts.Form.Vue.intefaces
{
    internal interface IStaticDataView
    {
        public void InitializeRepository(DTORepository repository);


        event EventHandler TerrainAddClicked;
        event EventHandler TerrainRemoveClicked;
        event EventHandler ClimateAddClicked;
        event EventHandler ClimateRemovelicked;
        event EventHandler RefreshView;
    }
}
