using MapToolV2.Scripts.Form.Vue.intefaces;
using MapToolV2.Scripts.Interface.Presenter;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VDBA.GameDataGetter.DTO;



namespace MapToolV2.Scripts.Form.Controler
{
    internal class StaticDataPresenter : IPresenterRepo
    {
        IStaticDataView _view;
        DTORepository _repository;
        event EventHandler SaveClicked;

        public StaticDataPresenter(IStaticDataView view) 
        {
            _view = view;
            //_repository = repository;
            //_view.ClimateAddClicked += AddClimateType;
            //_view.TerrainAddClicked += AddTerrainType;
            //_view.TerrainRemoveClicked += RemoveTerraintype;
            //_view.ClimateRemovelicked += RemoveClimateType;
            //_view.RefreshView += RefreshViewsEvent;
        }

        public void InitializeRepo(DTORepository repo)
        {
            _repository = repo;
            _view.InitializeRepository(repo);
        }

       
    }
}
