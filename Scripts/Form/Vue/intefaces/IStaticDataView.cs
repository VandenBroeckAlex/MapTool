using MapToolV2.Scripts.Form.UIElement.Interfaces;
using VDBA.GameDataGetter.DTO;

namespace MapToolV2.Scripts.Form.Vue.intefaces
{
    internal interface IStaticDataView
    {
        public void InitializeRepository(DTORepository repository);

        event EventHandler RefreshView;

        public ISimpleGrid simpleTerrainGrid {  get; set; }
        public ISimpleGrid climateGrid { get; set; }
    }
}
