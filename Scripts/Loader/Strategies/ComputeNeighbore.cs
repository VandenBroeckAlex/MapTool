using MapToolV2.Scripts.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MapToolV2.Scripts.Loader.Strategies
{
    internal class ComputeNeighbore : IComputeNeighbore
    {
        private readonly NeighborOptions _options;
        
        public ComputeNeighbore(NeighborOptions options)
        {
            _options = options;
        }
        public void Compute()
        {

            if (!_options.Enabled) return;

            //compute data
        }
    }
    

    public class NeighborOptions()
    {
        public bool Enabled { get; set; } 
        public bool OnlyForDefaultValues { get; set; }
        public bool WrapHorizontal { get; set; } 
        public bool WrapVertical { get; set; }
    }

}


