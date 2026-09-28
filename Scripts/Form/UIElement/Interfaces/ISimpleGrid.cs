using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MapToolV2.Scripts.Form.UIElement.Interfaces
{
    public interface ISimpleGrid
    {
        public void InitializeBinding<T>(List<T>data, string gridName);
        public T GetSelected<T>() where T : class;

        event EventHandler ButtonAddClicked;
        event EventHandler ButtonRemoveCliked;
        
        public void ChangeBackgroundColor(Color color);

    }
}
