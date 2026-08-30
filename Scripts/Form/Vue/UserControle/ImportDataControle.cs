using MapToolV2.Scripts.Form.Presenter;
using MapToolV2.Scripts.Form.Traces;
using MapToolV2.Scripts.Form.Vue.intefaces;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MapToolV2.Scripts.Form.Vue.UserControle
{
    public partial class ImportDataControle : UserControl, IImportDataView
    {
        public ImportDataControle()
        {
            InitializeComponent();
        }

        public event EventHandler ComputeClicked;

        private void btnSelectFile_Click(object sender, EventArgs e)
        {
            
            FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();

            folderBrowserDialog.ShowDialog();
            textBoxFileName.Text = folderBrowserDialog.SelectedPath;

            string[] scenarios = ScenarioDiscovery.GetScenarios(folderBrowserDialog.SelectedPath);
            comboBoxScenario.Items.Clear();
            if (scenarios.Length > 0)
            {
                foreach (string scenario in scenarios)
                {
                    comboBoxScenario.Items.Add(scenario);
                }
            }
            else
            {
                comboBoxScenario.Items.Add("No scenario found");
            }
            comboBoxScenario.SelectedIndex = 0;
        }

        private void CheckBoxGetNeighbore_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxGetNeighbore.Checked)
            {
                //Enable
                radioNeighboreAll.Enabled = true;
                radioNeighboreDefault.Enabled = true;
                checkBoxTopBottom.Enabled = true;
                checkBoxRightLeft.Enabled = true;
            }
            else
            {
                radioNeighboreAll.Enabled = false;
                radioNeighboreDefault.Enabled = false;
                checkBoxTopBottom.Enabled = false;
                checkBoxRightLeft.Enabled = false;
            }
        }

        private void CheckBoxComputePivot_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxComputePivot.Checked)
            {
                //Enable
                radioPivotAll.Enabled = true;
                radioPivotDefault.Enabled = true;
            }
            else
            {
                radioPivotAll.Enabled = false;
                radioPivotDefault.Enabled = false;
            }
        }
        private void buttonSelectOutputFile_Click(object sender, EventArgs e)
        {
            //folderBrowserDialog.ShowDialog();
            //textBoxOutputFile.Text = folderBrowserDialog.SelectedPath;
        }

        private void checkBoxComputeSurface_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxComputeSurface.Checked)
            {
                //Enable
                radioBtnSurfaceAll.Enabled = true;
                radioBtnSurfaceDefault.Enabled = true;
            }
            else
            {
                radioBtnSurfaceAll.Enabled = false;
                radioBtnSurfaceDefault.Enabled = false;
            }
        }


        private void btnCompute_Click(object sender, EventArgs e)
        {
           ComputeClicked?.Invoke(this, EventArgs.Empty);

        }

        public  IDeserializeTrace GetTrace()
        {
            return new TraceDeserialize(TbTrace);
        }

        public ComputeChoiceData GetComputeChoices()
        {
            ComputeChoiceData ccd = new ComputeChoiceData();
            ccd.fileRoot = textBoxFileName.Text;
            ccd.scenarioName = comboBoxScenario.Text;
            ccd.horizontal = checkBoxRightLeft.Checked;
            ccd.vertical = checkBoxTopBottom.Checked;
            ccd.createTileForOrphanColor = cbcreateTileOrphanColor.Checked;
            ccd.removeTileWithNotAppearingColor = cbRemoveTileWithoutAppColor.Checked;
            return ccd;
        }
    }

}
