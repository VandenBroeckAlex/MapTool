using MapToolV2.Scripts.Form.Vue.intefaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MapToolV2.Scripts.Form.Controler
{
    internal class StaticDataController
    {
        IStaticDataView _view;
        Repository _repository;
        event EventHandler SaveClicked;

        public StaticDataController(IStaticDataView view, Repository repository) 
        {
            _view = view;
            _repository = repository;
        }
    }
}
