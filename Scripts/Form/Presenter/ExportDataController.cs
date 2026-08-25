using MapToolV2.Scripts.Form.Controler;
using MapToolV2.Scripts.Form.Vue.intefaces;
using MapToolV2.Scripts.Generators;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MapToolV2.Scripts.Form.Controller
{
    public class ExportDataController
    {
        IExportview _view;
        Repository _repository;

        public ExportDataController(IExportview view, Repository repository)
        {
            _view = view;
            _repository = repository;

            _view.ExportDataClicked += ExportData;
            _view.CreateRootClicked += CreateRootFile;
            _view.ChooseRootFileClicked += ChooseRootFile;
        }

        private void CreateRootFile(object sender, EventArgs e)
        {
            string root = _view.GetRootPath();
            if (root == "")
            {
                MessageBox.Show("Enter a valid path");
            }
            CreateRoot cr = new CreateRoot(root);
            cr.Create();
            _view.ShowMessage("Successfully saved!");
        }
        private void ExportData(object sender, EventArgs e)
        {
            _view.ShowMessage("Successfully saved!");
        }

        private void ChooseRootFile(object sender, EventArgs e)
        {
            _view.ShowMessage("Rootfile choice cliked");

            FolderBrowserDialog folderDialog = new FolderBrowserDialog();
            folderDialog.Description = "Please select a folder for your project files:";

            if (folderDialog.ShowDialog() == DialogResult.OK)
            {
                string selectedPath = folderDialog.SelectedPath;

                _view.SetPath(selectedPath);
            }
        }
    }
}
