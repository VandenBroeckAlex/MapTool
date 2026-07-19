using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MapToolV2.Scripts.DTO
{
    public class DTOWorkplaceInstance
    {
        private int id;
        public int TemplateId { get; private set; }
        public int tileId { get; private set; }
        public int provinceId { get; private set; }
        public int countryId { get; private set; }
        public int marketId { get; private set; }
        //keep trak of profit

        // Dynamic State
        public bool canProduce;
        public bool isDamaged;
        public bool isOpen;

        public int size { get; set; } = 1;
        public float efficiency { get; private set; } = 1.0f;
        public int cashPool;
        public int companyId;
        public int wages;
        //public int poorStrataWage = 100;
        //public int middleStrataWage = 200;

        //Stockpile (input and output)?
        public List<IdNum> inputGoodsStockpile;
        public List<IdNum> maintenanceGoodsStockpile;
        // Tracks current employment: JobType -> Current Count
        // id current
        public List<IdNum> currentWorkers { get; set; } = new();
        public List<IdNum> owners;
    }
    public class IdNum
    {
        public int id;
        public int num;

        public IdNum(int id, int num)
        {
            this.id = id;
            this.num = num;
        }
    }
}
