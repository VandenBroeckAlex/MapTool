using MapToolV2.Scripts.Form.Vue.intefaces;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace MapToolV2.Scripts.Form.Vue
{
    public partial class StaticDataControl : UserControl, IStaticDataView
    {
        public StaticDataControl()
        {
            InitializeComponent();

            listViewClimateType.View = View.Details;
            listViewClimateType.Columns.Add("Climate Name", -2, HorizontalAlignment.Left); // -2 auto-sizes to width

            listViewTerrain.View = View.Details;
            listViewTerrain.Columns.Add("Terrain Name", -2, HorizontalAlignment.Left);


            ListViewItem listViewItem = new ListViewItem("Test terrain");
            // Add the item to the ListView control
            listViewTerrain.Items.Add(listViewItem);

        }

        public event EventHandler TerrainAddClicked;
        public event EventHandler TerrainRemoveClicked;
        public event EventHandler ClimateAddClicked;
        public event EventHandler ClimateRemovelicked;

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
            listViewTerrain.Items.Clear();

            if (listTerrainType.Count() <= 0)
            {
                var listViewItem = new ListViewItem("Nothing");
                listViewTerrain.Items.Add(listViewItem);
                return;
            }


            foreach (DTOTerrainType dto in listTerrainType)
            {
                // Create the main list item (this goes into the first column)
                ListViewItem listViewItem = new ListViewItem(dto.name);

                //// Add subitems for the subsequent columns
                //listViewItem.SubItems.Add(emp.Name);
                //listViewItem.SubItems.Add(emp.Role);

                // Optionally, store the original object in the Tag property for easy retrieval later
                listViewItem.Tag = dto;

                // Add the item to the ListView control
                listViewTerrain.Items.Add(listViewItem);
            }
            listViewTerrain.Refresh();

            textBoxTerrainType.Clear();
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
            ClimateRemovelicked.Invoke(this, EventArgs.Empty);
        }
        public DTOTerrainType GetSelectedTerrain()
        {
            var result = listViewTerrain.SelectedItems[0].Tag as DTOTerrainType;

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
    }
}
