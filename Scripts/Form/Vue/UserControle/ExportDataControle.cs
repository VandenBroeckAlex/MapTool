using MapToolV2.Scripts.Form.Vue.intefaces;
using MapToolV2.Scripts.Generators;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MapToolV2.Scripts.Form.Vue.UserControle
{
    public partial class ExportDataPresenter : UserControl, IExportview
    {
        public ExportDataPresenter()
        {
            InitializeComponent();
        }

        public event EventHandler CreateRootClicked;
        public event EventHandler ExportDataClicked;
        public event EventHandler ChooseRootFileClicked;
        public void btnCreateroot_Click(object sender, EventArgs e)
        {
            CreateRootClicked?.Invoke(this, EventArgs.Empty);
        }

        public string GetRootPath()
        {
            string root = textBoxOutputFile.Text;
            return root;
        }

        public void SetPath(string path)
        {
            textBoxOutputFile.Text = path;
        }

        public void ShowMessage(string message)
        {
            MessageBox.Show(message);
        }

        private void buttonSelectOutputFile_Click_1(object sender, EventArgs e)
        {
            ChooseRootFileClicked?.Invoke(this, EventArgs.Empty);
        }
    }
}
