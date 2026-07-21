using MapAnalysis;
using MapToolV2.Scripts.Form;
using MapToolV2.Scripts.Form.Traces;
using MapToolV2.Scripts.Generators;
using MapToolV2.Scripts.Loader;

namespace MapToolV2
{
    public partial class MapTool : Form
    {
        public MapTool()
        {
            InitializeComponent();
        }

        private void btnSelectFile_Click(object sender, EventArgs e)
        {
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


        private void button3_Click(object sender, EventArgs e)
        {
            colorDialog1.ShowDialog();
        }

        private void buttonSelectOutputFile_Click(object sender, EventArgs e)
        {
            folderBrowserDialog.ShowDialog();
            textBoxOutputFile.Text = folderBrowserDialog.SelectedPath;
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
            //Load
            string fileRoot = textBoxFileName.Text;
            string scenarioName = comboBoxScenario.Text;
            DeserializerBootstrap deserializer = new DeserializerBootstrap(fileRoot, scenarioName);
            IDeserializeTrace trace = new TraceDeserialize(TbTrace);
            deserializer.Deserialize(trace);


            bool horizontal = checkBoxRightLeft.Checked;
            bool vertical = checkBoxTopBottom.Checked;
            MapAnalysisResult mapResult = MapAnalyzer.Analyze(Path.Combine(fileRoot, "Province_Map.png"), horizontal, vertical);
            //Compute

            trace.Log($"number of detected color: {mapResult.Colors.Count()}", MesssageType.info);

            //RefreshView

        }

        private void btnCreateroot_Click(object sender, EventArgs e)
        {
            string root = textBoxOutputFile.Text;

            if(root != "")
            {
              CreateRoot cr = new CreateRoot(root);
              cr.Create();
            }

        }
    }
}
