using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MapToolV2.Scripts.Form.Traces
{
    public interface IDeserializeTrace
    {
        public void Log(string message, MesssageType type);
    }

    public enum MesssageType
    { 
        info,
        warning,
        error
    }
}
