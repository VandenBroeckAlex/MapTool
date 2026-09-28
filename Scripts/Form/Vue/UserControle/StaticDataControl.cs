using MapToolV2.Scripts.Form.UIElement.Interfaces;
using MapToolV2.Scripts.Form.Vue.intefaces;
using Microsoft.VisualBasic.ApplicationServices;
using System.ComponentModel;
using System.Windows.Forms;
using VDBA.GameDataGetter.DTO;

namespace MapToolV2.Scripts.Form.Vue
{
    public partial class StaticDataControl : UserControl, IStaticDataView
    {
        private DTORepository _repo;
        public event EventHandler RefreshView;


        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public ISimpleGrid simpleTerrainGrid { get; set; }
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public ISimpleGrid climateGrid { get; set; }
        public StaticDataControl()
        {
            InitializeComponent();
            simpleTerrainGrid = simpleGridTerrain;
            climateGrid = ClimateGrid;
        }

        private void OnVisibleChange(object sender, EventArgs e)
        {
            RefreshView?.Invoke(this, EventArgs.Empty);
        }


        public void InitializeRepository(DTORepository repository)
        {
            _repo = repository;

        }
    
    
    
    }
}
