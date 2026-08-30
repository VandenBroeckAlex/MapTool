using MapToolV2.Scripts.Form.Presenter;
using MapToolV2.Scripts.Form.Traces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MapToolV2.Scripts.Form.Vue.intefaces
{
    public interface IImportDataView
    {
        public ComputeChoiceData GetComputeChoices();
        public IDeserializeTrace GetTrace();

        public event EventHandler ComputeClicked;
    }
}
