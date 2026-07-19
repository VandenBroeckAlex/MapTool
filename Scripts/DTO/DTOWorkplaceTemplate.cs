using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MapToolV2.Scripts.DTO
{
    internal class DTOWorkplaceTemplate
    {
        public string tag;
        public int id { get; set; }
        public string name { get; set; }
        public int upgradeTemplateId { get; set; } // ID of what this can upgrade into (or null)
        public int downgradeTemplateId { get; set; }
        public List<ResourceRequirement> constructionInput; //upgrade cost = Uptemplate - this.
        public int ICConstructionCost;
        public List<ResourceRequirement> maintenanceGoods;

        public Dictionary<int, int> workerRequirements { get; set; } = new(); // e.g., "Craftsman": 100, "Clerk": 10
        public List<ResourceRequirement> inputs { get; set; } = new();           // Empty for extraction (RGOs)    
        public List<ProductionEffect> outputs { get; set; } = new();
        public List<ResourceRequirement> efficiencyInput { get; set; } = new();
    }
    public struct ResourceRequirement
    {
        public int goodId { get; set; }
        public int baseAmount { get; set; } // Consumed per Size level at 100% throughput
    }
    public struct ProductionEffect
    {
        public OutputDomain type { get; set; }
        public int targetId { get; set; } // "steel", "admin_points", etc.
        public float baseAmount { get; set; } // Produced per Size level at 100% efficiency
    }
    public enum OutputDomain
    {
        Market,         // Goes to the trade system
        Tile,           //Goes to the tile               
        Province,       // Infrastructure, local buffs
        Country,        // Research points, Admin points, Prestige
        Internal,      // Goods stored inside the building (Work-in-progress)
    }
}
