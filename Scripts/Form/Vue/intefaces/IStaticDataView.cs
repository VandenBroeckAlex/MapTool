using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MapToolV2.Scripts.Form.Vue.intefaces
{
    internal interface IStaticDataView
    {
        public void RefreshTerrainType(IEnumerable<DTOTerrainType>listTerrainType);
        public void RefreshClimateType(IEnumerable<DTOClimateDef> listClimateType);
        public void RefreshPopJob();

        public string GetTypedInfoTerrain();
        public DTOTerrainType GetSelectedTerrain();
        public string GetTypedInfoClimate();



        event EventHandler TerrainAddClicked;
        event EventHandler ClimateAddClicked;
        event EventHandler TerrainRemoveClicked;
    }
}
