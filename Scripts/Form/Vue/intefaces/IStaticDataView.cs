using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MapToolV2.Scripts.Form.Vue.intefaces
{
    internal interface IStaticDataView
    {
        public void RefreshTerrainType();
        public void RefreshClimateType();
        public void RefreshPopJob();

        public void GetTypedInfoTerrain(string info);
        public void GetTypedInfoClimate(string info);

        event EventHandler TerrainAddlicked;
        string terrainInput {  get; set; }
    }
}
