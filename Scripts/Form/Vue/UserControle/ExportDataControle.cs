using MapToolV2.Scripts.Form.Vue.intefaces;
using MapToolV2.Scripts.Generators;
using System.Windows.Forms;


namespace MapToolV2.Scripts.Form.Vue.UserControle
{
    public partial class ExportDataPresenter : UserControl, IExportview
    {
        public ExportDataPresenter()
        {
            InitializeComponent();
        }

        public event EventHandler CreateRootClicked;
        public event EventHandler ExportDataClicked;
        public event EventHandler ChooseRootFileClicked;
        public void btnCreateroot_Click(object sender, EventArgs e)
        {
            CreateRootClicked?.Invoke(this, EventArgs.Empty);
        }

        public string GetRootPath()
        {
            string root = textBoxOutputFile.Text;
            return root;
        }

        public string GetScenario()
        {
            return comboBoxScenario.Text;
        }

        public void SetPath(string path)
        {
            textBoxOutputFile.Text = path;

            SetScenario(path);
        }

        public void ShowMessage(string message)
        {
            MessageBox.Show(message);
        }

        private void buttonSelectOutputFile_Click_1(object sender, EventArgs e)
        {
            ChooseRootFileClicked?.Invoke(this, EventArgs.Empty);
        }

        private void SetScenario(string path)
        {
            string[] scenarios = ScenarioDiscovery.GetScenarios(path);
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

        private void button8_Click(object sender, EventArgs e)
        {
            ExportDataClicked?.Invoke(this, EventArgs.Empty);
        }
    }
}
