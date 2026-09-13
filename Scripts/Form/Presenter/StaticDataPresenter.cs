using MapToolV2.Scripts.Form.Vue.intefaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VDBA.GameDataGetter.DTO;



namespace MapToolV2.Scripts.Form.Controler
{
    internal class StaticDataPresenter
    {
        IStaticDataView _view;
        DTORepository _repository;
        event EventHandler SaveClicked;

        public StaticDataPresenter(IStaticDataView view, DTORepository repository) 
        {
            _view = view;
            _repository = repository;
            _view.ClimateAddClicked += AddClimateType;
            _view.TerrainAddClicked += AddTerrainType;
            _view.TerrainRemoveClicked += RemoveTerraintype;
            _view.ClimateRemovelicked += RemoveClimateType;
            _view.RefreshView += RefreshViewsEvent;
        }

        public void RefreshViews()
        {
           
            _view.RefreshTerrainType(_repository.listTerrainType);
            _view.RefreshClimateType(_repository.climateList);
            //_view.RefreshPopJob();
        }
        public void RefreshViewsEvent(object sender, EventArgs e)
        {

            _view.RefreshTerrainType(_repository.listTerrainType);
            _view.RefreshClimateType(_repository.climateList);
            //_view.RefreshPopJob();
        }

        public void AddTerrainType(object sender, EventArgs e)
        {
            
            DTOTerrainType terrainType = new DTOTerrainType();
            terrainType.name = _view.GetTypedInfoTerrain(); ;
            _repository.listTerrainType.Add(terrainType);
            RefreshViews();
        }
        public void AddClimateType(object sender, EventArgs e)
        {
            DTOClimateDef climateType = new DTOClimateDef();
            climateType.name = _view.GetTypedInfoClimate();
            _repository.climateList.Add(climateType);
            RefreshViews();
        }
   
        public void RemoveTerraintype(object sender, EventArgs e)
        {
            MessageBox.Show($"Terrain = {_view.GetSelectedTerrain().name}");
            _repository.listTerrainType.Remove(_view.GetSelectedTerrain());
            RefreshViews();
        }
        public void RemoveClimateType(object sender, EventArgs e)
        {
            MessageBox.Show($"Remove climate");
            _repository.climateList.Remove(_view.GetSelectedClimate());
            RefreshViews();
        }
    }
}
