using MapToolV2.Scripts.Form.UIElement.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace MapToolV2.Scripts.Form.UIElement
{
    public partial class SimpleGridUserControle : UserControl, ISimpleGrid
    {
        private BindingSource _bindingSource;
        private IBindingList _bindingList;


        public SimpleGridUserControle()
        {
            InitializeComponent();

        }

        public event EventHandler ButtonAddClicked;
        public event EventHandler ButtonRemoveCliked;

        public void ChangeBackgroundColor(Color color)
        {
            GroupBoxSimpleGrid.BackColor = color;
        }

        public T GetSelected<T>() where T : class
        {
            if (DataGrid.SelectedRows.Count == 0)
            {
                return null;
            }
            return DataGrid.SelectedRows[0].DataBoundItem as T;
        }

        public void InitializeBinding<T>(List<T> data, string gridName)
        {
            GroupBoxSimpleGrid.Text = gridName;

            _bindingList = new BindingList<T>(data);

            _bindingSource = new BindingSource();
            _bindingSource.DataSource = _bindingList;
            
            DataGrid.DataSource = _bindingSource;
        }

      
        private void BtnAdd_Click(object sender, EventArgs e)
        {
            ButtonAddClicked?.Invoke(this, EventArgs.Empty);
        }

        private void BtnRemove_Click(object sender, EventArgs e)
        {
            ButtonRemoveCliked?.Invoke(this, EventArgs.Empty);

            //DataGrid.Rows.RemoveAt(DataGrid.SelectedRows[0].Index);
        }
    }
}
