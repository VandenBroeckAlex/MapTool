using MapToolV2.Scripts.Form.Presenter;
using VDBA.GameDataGetter.Interfaces;
namespace MapToolV2.Scripts.Form.Vue.intefaces
{
    public interface IImportDataView
    {
        public ComputeChoiceData GetComputeChoices();
        public IDeserializeTrace GetTrace();

        public event EventHandler ComputeClicked;
    }
}
