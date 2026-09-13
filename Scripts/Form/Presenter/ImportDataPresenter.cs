using MapAnalysis;
using MapToolV2.Scripts.Form.Controler;
using MapToolV2.Scripts.Form.Traces;
using MapToolV2.Scripts.Form.Vue.intefaces;
using MapToolV2.Scripts.Loader;
using VDBA.GameDataGetter;
using VDBA.GameDataGetter.DTO;
using VDBA.GameDataGetter.Interfaces;



namespace MapToolV2.Scripts.Form.Presenter
{

    public class ComputeChoiceData
    {
        public string fileRoot;
        public string scenarioName;
        public bool horizontal;
        public bool vertical;
        public bool createTileForOrphanColor;
        public bool removeTileWithNotAppearingColor;
    }


    internal class ImportDataPresenter
    {
        IImportDataView _view;
        DTORepository _repo;


        public ImportDataPresenter(IImportDataView dataView,DTORepository repo)
        {
            _view = dataView;
            _repo = repo;

            _view.ComputeClicked += DeserializeData;
        }

        private void DeserializeData(object sender, EventArgs e)
        {
            IDeserializeTrace trace = _view.GetTrace();
            ComputeChoiceData ccd = _view.GetComputeChoices();


            //Load
            string fileRoot = ccd.fileRoot;
            string scenarioName = ccd.scenarioName;
            DeserializerBootstrap deserializer = new DeserializerBootstrap(fileRoot, scenarioName);
            //deserializer.Deserialize(trace);
            Deserializer.RootDeserialize(fileRoot, scenarioName, _repo, trace);

            bool horizontal = ccd.horizontal;
            bool vertical = ccd.vertical;
            MapAnalysisResult mapResult = MapAnalyzer.Analyze(Path.Combine(fileRoot, "Province_Map.png"), horizontal, vertical);
            //Compute

            trace.Log($"number of detected color: {mapResult.Colors.Count()}", MesssageType.Info);

        }
    }
}
