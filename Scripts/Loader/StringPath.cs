using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MapToolV2.Scripts.Loader
{
    public class StringPath
    {
        public StringPath(string rootfile, string _scenario)
        {
            rootfile = rootfile;
            gameData = Path.Combine(rootfile, "GameData");
            scenario = Path.Combine(rootfile, "Scenarios", _scenario);
        }
        public string gameData { get; }
        public string scenario { get; }
        public string rootfile { get; }

    }
}
