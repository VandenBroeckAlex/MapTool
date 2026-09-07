using MapAnalysis;
using MapToolV2.Scripts.Form;
using MapToolV2.Scripts.Form.Controler;
using MapToolV2.Scripts.Form.Controller;
using MapToolV2.Scripts.Form.Presenter;
using MapToolV2.Scripts.Form.Traces;
using MapToolV2.Scripts.Generators;
using MapToolV2.Scripts.Loader;

namespace MapToolV2
{
    public partial class MapTool : Form
    {
        public MapTool()
        {
            InitializeComponent();
            Repository _repo = new Repository();

            ExportDataPresenter exportDataController = new ExportDataPresenter(exportDataControle,_repo);

            ImportDataPresenter importDataPresenter = new ImportDataPresenter(importDataControle, _repo);

            StaticDataPresenter staticDataPresenter = new StaticDataPresenter(staticDataControl2, _repo);
        }
    }
}
