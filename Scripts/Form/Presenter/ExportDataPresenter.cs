using MapToolV2.Scripts.Form.Vue.intefaces;
using MapToolV2.Scripts.Generators;
using VDBA.GameDataGetter;
using VDBA.GameDataGetter.DTO;


namespace MapToolV2.Scripts.Form.Controller
{
    public class ExportDataPresenter
    {
        IExportview _view;
        DTORepository _repository;

        public ExportDataPresenter(IExportview view, DTORepository repository)
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
                MessageBox.Show("Please enter a valid path");
            }
            CreateRoot cr = new CreateRoot(root);
            cr.Create();
            _view.ShowMessage("Successfully saved!");
        }
        private void ExportData(object sender, EventArgs e)
        {
            //Data export function here
            string root = _view.GetRootPath();

           

            

            Serializer.SerializeStaticAndScenario(_repository, root, _view.GetScenario());
        }

        private void ChooseRootFile(object sender, EventArgs e)
        {

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
