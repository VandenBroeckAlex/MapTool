using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MapToolV2.Scripts.Form.Vue.intefaces
{
    public interface IExportview
    {
        public string GetRootPath();
        void ShowMessage(string message);
        void SetPath(string path);

        public event EventHandler CreateRootClicked;
        public event EventHandler ExportDataClicked;
        public event EventHandler ChooseRootFileClicked;

    }
}
