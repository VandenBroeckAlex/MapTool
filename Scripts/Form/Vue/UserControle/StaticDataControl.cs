using MapToolV2.Scripts.Form.Vue.intefaces;
using Microsoft.VisualBasic.ApplicationServices;
using System.ComponentModel;
using System.Windows.Forms;
using VDBA.GameDataGetter.DTO;

namespace MapToolV2.Scripts.Form.Vue
{
    public partial class StaticDataControl : UserControl, IStaticDataView
    {

        public StaticDataControl(DTORepository repo)
        {
            InitializeComponent();

            listViewClimateType.View = View.Details;
            listViewClimateType.Columns.Add("Climate Name", -2, HorizontalAlignment.Left); // -2 auto-sizes to width

            //listViewTerrain.View = View.Details;
            //listViewTerrain.Columns.Add("Terrain Name", -2, HorizontalAlignment.Left);
            //listViewTerrain.Columns.Add("Terrain Tag", -2, HorizontalAlignment.Left);
            //listViewTerrain.Columns.Add("IsLand", -2, HorizontalAlignment.Left);
            _repo = repo;
            SetupTerrainTypeBinding();
        }

        private readonly DTORepository _repo;

        private BindingList<DTOTerrainType> _bindingListTerrainType;
        private BindingSource _bindingSource;

        public event EventHandler TerrainAddClicked;
        public event EventHandler TerrainRemoveClicked;
        public event EventHandler ClimateAddClicked;
        public event EventHandler ClimateRemovelicked;
        public event EventHandler RefreshView;

        public string GetTypedInfoClimate()
        {
            return textBoxClimateType.Text;
        }

        public string GetTypedInfoTerrain()
        {
            return textBoxTerrainType.Text;
        }

        public void RefreshClimateType(IEnumerable<DTOClimateDef> listClimateType)
        {
            listViewClimateType.Items.Clear();


            if (listClimateType.Count() <= 0)
            {
                var listViewItem = new ListViewItem("Nothing");
                listViewClimateType.Items.Add(listViewItem);
                return;
            }



            foreach (DTOClimateDef dto in listClimateType)
            {
                var listViewItem = new ListViewItem(dto.name);
                listViewItem.Tag = dto;
                listViewClimateType.Items.Add(listViewItem);
            }
            listViewClimateType.Refresh();
            textBoxClimateType.Clear();
        }
        public void RefreshTerrainType(IEnumerable<DTOTerrainType> listTerrainType)
        {

            dGTerrainType.DataSource = listTerrainType?.ToList();

            textBoxTerrainType.Clear();
            textBoxTerrainType.Focus();
        }

        public void RefreshPopJob()
        {
            TerrainAddClicked?.Invoke(this, EventArgs.Empty);
        }

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
        public DTOTerrainType GetSelectedTerrain()
        {
            DTOTerrainType result =  (DTOTerrainType)dGTerrainType.CurrentRow.DataBoundItem;

            if (result is not null)
            {
                return result;
            }
            else
            {
                return new DTOTerrainType();
            }
        }

        public DTOClimateDef GetSelectedClimate()
        {
            var result = listViewClimateType.SelectedItems[0].Tag as DTOClimateDef;

            if (result is not null)
            {
                return result;
            }
            else
            {
                return new DTOClimateDef();
            }
        }

        public void SetupTerrainTypeBinding()
        {
            List<DTOTerrainType> listTerrainType = _repo.terrainTypes.GetAll();
            _bindingListTerrainType = new BindingList<DTOTerrainType>(listTerrainType);

            _bindingSource = new BindingSource();
            _bindingSource.DataSource = _bindingListTerrainType;

            dGTerrainType.DataSource = _bindingSource;
        }



        private void OnVisibleChange(object sender, EventArgs e)
        {
            RefreshView?.Invoke(this, EventArgs.Empty);
        }
    
    
    
    
    }
}
