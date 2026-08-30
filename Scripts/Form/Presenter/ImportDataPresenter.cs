using MapAnalysis;
using MapToolV2.Scripts.Form.Controler;
using MapToolV2.Scripts.Form.Traces;
using MapToolV2.Scripts.Form.Vue.intefaces;
using MapToolV2.Scripts.Loader;
using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
        Repository _repo;

        public ImportDataPresenter(IImportDataView dataView,Repository repo)
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
            deserializer.Deserialize(trace);


            bool horizontal = ccd.horizontal;
            bool vertical = ccd.vertical;
            MapAnalysisResult mapResult = MapAnalyzer.Analyze(Path.Combine(fileRoot, "Province_Map.png"), horizontal, vertical);
            //Compute

            trace.Log($"number of detected color: {mapResult.Colors.Count()}", MesssageType.info);

            //RefreshView

        }

    }
}
