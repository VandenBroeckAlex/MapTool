using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VDBA.GameDataGetter.DTO;

namespace MapToolV2.Scripts.Interface.Presenter
{
    internal interface IPresenterRepo
    {
        public void InitializeRepo(DTORepository repo);
    }
}
