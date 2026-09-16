using MapToolV2.Scripts.Form.Vue.intefaces;
using Microsoft.VisualBasic.ApplicationServices;
using System.ComponentModel;
using System.Windows.Forms;
using VDBA.GameDataGetter.DTO;

namespace MapToolV2.Scripts.Form.Vue
{
    public partial class StaticDataControl : UserControl, IStaticDataView
    {

        public StaticDataControl()
        {
            InitializeComponent();

            listViewClimateType.View = View.Details;
            listViewClimateType.Columns.Add("Climate Name", -2, HorizontalAlignment.Left); // -2 auto-sizes to width

            //listViewTerrain.View = View.Details;
            //listViewTerrain.Columns.Add("Terrain Name", -2, HorizontalAlignment.Left);
            //listViewTerrain.Columns.Add("Terrain Tag", -2, HorizontalAlignment.Left);
            //listViewTerrain.Columns.Add("IsLand", -2, HorizontalAlignment.Left);
            
        }

        private DTORepository _repo;

        private BindingList<DTOTerrainType> _bindingListTerrainType;
        private BindingSource _bindingSource;

        public event EventHandler TerrainAddClicked;
        public event EventHandler TerrainRemoveClicked;
        public event EventHandler ClimateAddClicked;
        public event EventHandler ClimateRemovelicked;
        public event EventHandler RefreshView;

        

        private void btnAddTerrain_Click(object sender, EventArgs e)
        {
            TerrainAddClicked?.Invoke(this, EventArgs.Empty);
        }

        private void btnRemoveTerrain_Click(Object sender, EventArgs e)
        {
            TerrainRemoveClicked.Invoke(this, EventArgs.Empty);
        }

        private void btnAddClimate_Click(object sender, EventArgs e)
        {
            ClimateAddClicked?.Invoke(this, EventArgs.Empty);
        }
        private void btnRemoveClimate_Click(Object sender, EventArgs e)
        {
            ClimateRemovelicked?.Invoke(this, EventArgs.Empty);
        }


        private void OnVisibleChange(object sender, EventArgs e)
        {
            RefreshView?.Invoke(this, EventArgs.Empty);
        }

        private void InitializeBinding()
        {
           if(_repo is not null)
            {
                List<DTOTerrainType> rawTerrainType = _repo.terrainTypes.GetAll();
                _bindingListTerrainType = new BindingList<DTOTerrainType>(rawTerrainType);

                
                // Initialize the BindingSource
                _bindingSource = new BindingSource();
                _bindingSource.DataSource = _bindingListTerrainType;
                dGTerrainType.DataSource = _bindingSource;
            }
        }

        public void InitializeRepository(DTORepository repository)
        {
            _repo = repository;
            //enable controle
            //InitializeBinding
            InitializeBinding();
        }
    }
}
