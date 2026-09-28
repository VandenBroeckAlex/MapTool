using MapToolV2.Scripts.Form.UIElement.Interfaces;
using MapToolV2.Scripts.Form.Vue.intefaces;
using MapToolV2.Scripts.Interface.Presenter;

using VDBA.GameDataGetter.DTO;



namespace MapToolV2.Scripts.Form.Controler
{
    internal class StaticDataPresenter : IPresenterRepo
    {
        IStaticDataView _view;
        DTORepository _repository;
        event EventHandler RemoveClicked;

        public StaticDataPresenter(IStaticDataView view) 
        {
            _view = view;
            _view.simpleTerrainGrid.ButtonAddClicked += AddTerrain;
            _view.simpleTerrainGrid.ButtonRemoveCliked += RemoveSelectedTerrain;
            _view.simpleTerrainGrid.ChangeBackgroundColor(Color.FromArgb(242, 172, 87));
            _view.climateGrid.ButtonAddClicked += AddClimate;
            _view.climateGrid.ButtonRemoveCliked += RemoveSelectedClimate;
            _view.climateGrid.ChangeBackgroundColor(Color.LightSkyBlue);
        }

        public void InitializeRepo(DTORepository repo)
        {
            _repository = repo;
            _view.InitializeRepository(repo);

            RefreshGridData();
        }

       private void AddTerrain(object sender, EventArgs e)
        {
            _repository.terrainTypes.AddBlankTerrain();
            RefreshGridData();
        }

        private void RemoveSelectedTerrain(object sender, EventArgs e)
        {
            DTOTerrainType selectedTerrain = _view.simpleTerrainGrid.GetSelected<DTOTerrainType>();

            _repository.terrainTypes.Remove(selectedTerrain);
            RefreshGridData();
        }

        private void AddClimate(object sender, EventArgs e)
        {
            _repository.climateTypes.AddBlankClimate();
            RefreshGridData();
        }

        private void RemoveSelectedClimate(object sender, EventArgs e)
        {
            DTOClimateType selectedClimateType = _view.climateGrid.GetSelected<DTOClimateType>();

            _repository.climateTypes.Remove(selectedClimateType);
            RefreshGridData();
        }


        private void RefreshGridData()
        {
            if (_repository != null)
            {
                var allTerrains = _repository.terrainTypes.GetAll();
                var allClimate = _repository.climateTypes.GetAll();
                _view.simpleTerrainGrid.InitializeBinding<DTOTerrainType>(allTerrains, "Terrain List");
                _view.climateGrid.InitializeBinding<DTOClimateType>(allClimate, "Climate List");
            }
        }

    }
}
