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
        }

        private void CheckBoxGetNeighbore_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxGetNeighbore.Checked)
            {
                //Enable
                radioNeighboreAll.Enabled = true;
                radioNeighboreDefault.Enabled = true;
            }
            else
            {
                radioNeighboreAll.Enabled = false;
                radioNeighboreDefault.Enabled = false;
            }
        }

        private void checkBoxComputePivot_CheckedChanged(object sender, EventArgs e)
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

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

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
    }
}
