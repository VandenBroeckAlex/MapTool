using MapAnalysis;
using MapToolV2.Scripts.Form;
using MapToolV2.Scripts.Form.Controler;
using MapToolV2.Scripts.Form.Controller;
using MapToolV2.Scripts.Form.Presenter;
using MapToolV2.Scripts.Form.Traces;
using MapToolV2.Scripts.Generators;
using MapToolV2.Scripts.Interface.Presenter;
using MapToolV2.Scripts.Loader;
using VDBA.GameDataGetter.DTO;

namespace MapToolV2
{
    public partial class MapTool : Form
    {
        public MapTool()
        {
            InitializeComponent();
            DTORepository _repo = new DTORepository();
            List<IPresenterRepo> presenterRepos = new List<IPresenterRepo>();


            ExportDataPresenter exportDataController = new ExportDataPresenter(exportDataControle,_repo); 
            
            StaticDataPresenter staticDataPresenter = new StaticDataPresenter(staticDataControl2);
            presenterRepos.Add(staticDataPresenter);



            ImportDataPresenter importDataPresenter = new ImportDataPresenter(importDataControle, _repo, presenterRepos);
        }
    }
}
