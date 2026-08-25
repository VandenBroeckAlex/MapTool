namespace MapToolV2
{
    partial class MapTool
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            folderBrowserDialog = new FolderBrowserDialog();
            TabControleLoad = new TabPage();
            groupBox10 = new GroupBox();
            TbTrace = new RichTextBox();
            groupBox2 = new GroupBox();
            btnCompute = new Button();
            label18 = new Label();
            comboBoxScenario = new ComboBox();
            panel4 = new Panel();
            radioBtnSurfaceDefault = new RadioButton();
            checkBoxComputeSurface = new CheckBox();
            radioBtnSurfaceAll = new RadioButton();
            checkBox4 = new CheckBox();
            checkBox3 = new CheckBox();
            panel2 = new Panel();
            radioPivotDefault = new RadioButton();
            checkBoxComputePivot = new CheckBox();
            radioPivotAll = new RadioButton();
            panel1 = new Panel();
            checkBoxTopBottom = new CheckBox();
            checkBoxRightLeft = new CheckBox();
            radioNeighboreDefault = new RadioButton();
            checkBoxGetNeighbore = new CheckBox();
            radioNeighboreAll = new RadioButton();
            groupBox1 = new GroupBox();
            textBoxFileName = new TextBox();
            btnSelectFile = new Button();
            TabControl = new TabControl();
            tabPage2 = new TabPage();
            TabControleTile = new TabPage();
            tabCountry = new TabPage();
            tabPopulation = new TabPage();
            tabPage1 = new TabPage();
            exportDataControle = new MapToolV2.Scripts.Form.Vue.UserControle.ExportDataPresenter();
            colorDialog1 = new ColorDialog();
            TabControleLoad.SuspendLayout();
            groupBox10.SuspendLayout();
            groupBox2.SuspendLayout();
            panel4.SuspendLayout();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            groupBox1.SuspendLayout();
            TabControl.SuspendLayout();
            tabPage1.SuspendLayout();
            SuspendLayout();
            // 
            // TabControleLoad
            // 
            TabControleLoad.Controls.Add(groupBox10);
            TabControleLoad.Controls.Add(groupBox2);
            TabControleLoad.Controls.Add(groupBox1);
            TabControleLoad.Location = new Point(4, 24);
            TabControleLoad.Name = "TabControleLoad";
            TabControleLoad.Padding = new Padding(3);
            TabControleLoad.Size = new Size(1069, 854);
            TabControleLoad.TabIndex = 0;
            TabControleLoad.Text = "Load data";
            TabControleLoad.UseVisualStyleBackColor = true;
            // 
            // groupBox10
            // 
            groupBox10.Controls.Add(TbTrace);
            groupBox10.Location = new Point(522, 124);
            groupBox10.Margin = new Padding(3, 2, 3, 2);
            groupBox10.Name = "groupBox10";
            groupBox10.Padding = new Padding(3, 2, 3, 2);
            groupBox10.Size = new Size(332, 384);
            groupBox10.TabIndex = 5;
            groupBox10.TabStop = false;
            groupBox10.Text = "groupBoxTrace";
            // 
            // TbTrace
            // 
            TbTrace.Location = new Point(16, 22);
            TbTrace.Margin = new Padding(3, 2, 3, 2);
            TbTrace.Name = "TbTrace";
            TbTrace.Size = new Size(301, 350);
            TbTrace.TabIndex = 0;
            TbTrace.Text = "";
            // 
            // groupBox2
            // 
            groupBox2.BackColor = Color.WhiteSmoke;
            groupBox2.Controls.Add(btnCompute);
            groupBox2.Controls.Add(label18);
            groupBox2.Controls.Add(comboBoxScenario);
            groupBox2.Controls.Add(panel4);
            groupBox2.Controls.Add(checkBox4);
            groupBox2.Controls.Add(checkBox3);
            groupBox2.Controls.Add(panel2);
            groupBox2.Controls.Add(panel1);
            groupBox2.Location = new Point(19, 124);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(446, 384);
            groupBox2.TabIndex = 4;
            groupBox2.TabStop = false;
            groupBox2.Text = "Loading Options";
            // 
            // btnCompute
            // 
            btnCompute.Location = new Point(172, 348);
            btnCompute.Name = "btnCompute";
            btnCompute.Size = new Size(75, 23);
            btnCompute.TabIndex = 9;
            btnCompute.Text = "Compute";
            btnCompute.UseVisualStyleBackColor = true;
            btnCompute.Click += btnCompute_Click;
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Location = new Point(16, 330);
            label18.Name = "label18";
            label18.Size = new Size(85, 15);
            label18.TabIndex = 8;
            label18.Text = "Select scenario";
            // 
            // comboBoxScenario
            // 
            comboBoxScenario.FormattingEnabled = true;
            comboBoxScenario.Location = new Point(16, 348);
            comboBoxScenario.Name = "comboBoxScenario";
            comboBoxScenario.Size = new Size(121, 23);
            comboBoxScenario.TabIndex = 7;
            // 
            // panel4
            // 
            panel4.BackColor = Color.White;
            panel4.BorderStyle = BorderStyle.FixedSingle;
            panel4.Controls.Add(radioBtnSurfaceDefault);
            panel4.Controls.Add(checkBoxComputeSurface);
            panel4.Controls.Add(radioBtnSurfaceAll);
            panel4.Location = new Point(16, 170);
            panel4.Name = "panel4";
            panel4.Size = new Size(380, 68);
            panel4.TabIndex = 5;
            // 
            // radioBtnSurfaceDefault
            // 
            radioBtnSurfaceDefault.AutoSize = true;
            radioBtnSurfaceDefault.Enabled = false;
            radioBtnSurfaceDefault.Location = new Point(75, 37);
            radioBtnSurfaceDefault.Name = "radioBtnSurfaceDefault";
            radioBtnSurfaceDefault.Size = new Size(90, 19);
            radioBtnSurfaceDefault.TabIndex = 2;
            radioBtnSurfaceDefault.TabStop = true;
            radioBtnSurfaceDefault.Text = "Only default";
            radioBtnSurfaceDefault.UseVisualStyleBackColor = true;
            // 
            // checkBoxComputeSurface
            // 
            checkBoxComputeSurface.AutoSize = true;
            checkBoxComputeSurface.Location = new Point(10, 12);
            checkBoxComputeSurface.Name = "checkBoxComputeSurface";
            checkBoxComputeSurface.Size = new Size(118, 19);
            checkBoxComputeSurface.TabIndex = 0;
            checkBoxComputeSurface.Text = "Compute Surface";
            checkBoxComputeSurface.UseVisualStyleBackColor = true;
            checkBoxComputeSurface.CheckedChanged += checkBoxComputeSurface_CheckedChanged;
            // 
            // radioBtnSurfaceAll
            // 
            radioBtnSurfaceAll.AutoSize = true;
            radioBtnSurfaceAll.Enabled = false;
            radioBtnSurfaceAll.Location = new Point(30, 38);
            radioBtnSurfaceAll.Name = "radioBtnSurfaceAll";
            radioBtnSurfaceAll.Size = new Size(39, 19);
            radioBtnSurfaceAll.TabIndex = 1;
            radioBtnSurfaceAll.TabStop = true;
            radioBtnSurfaceAll.Text = "All";
            radioBtnSurfaceAll.UseVisualStyleBackColor = true;
            // 
            // checkBox4
            // 
            checkBox4.AutoSize = true;
            checkBox4.Location = new Point(16, 296);
            checkBox4.Name = "checkBox4";
            checkBox4.Size = new Size(266, 19);
            checkBox4.TabIndex = 6;
            checkBox4.Text = "Remove tile data whose color is not on image";
            checkBox4.UseVisualStyleBackColor = true;
            // 
            // checkBox3
            // 
            checkBox3.AutoSize = true;
            checkBox3.Location = new Point(16, 271);
            checkBox3.Name = "checkBox3";
            checkBox3.Size = new Size(194, 19);
            checkBox3.TabIndex = 5;
            checkBox3.Text = "Create tile data for orphan color";
            checkBox3.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(radioPivotDefault);
            panel2.Controls.Add(checkBoxComputePivot);
            panel2.Controls.Add(radioPivotAll);
            panel2.Location = new Point(16, 96);
            panel2.Name = "panel2";
            panel2.Size = new Size(380, 68);
            panel2.TabIndex = 4;
            // 
            // radioPivotDefault
            // 
            radioPivotDefault.AutoSize = true;
            radioPivotDefault.Enabled = false;
            radioPivotDefault.Location = new Point(75, 37);
            radioPivotDefault.Name = "radioPivotDefault";
            radioPivotDefault.Size = new Size(90, 19);
            radioPivotDefault.TabIndex = 2;
            radioPivotDefault.TabStop = true;
            radioPivotDefault.Text = "Only default";
            radioPivotDefault.UseVisualStyleBackColor = true;
            // 
            // checkBoxComputePivot
            // 
            checkBoxComputePivot.AutoSize = true;
            checkBoxComputePivot.Location = new Point(10, 12);
            checkBoxComputePivot.Name = "checkBoxComputePivot";
            checkBoxComputePivot.Size = new Size(106, 19);
            checkBoxComputePivot.TabIndex = 0;
            checkBoxComputePivot.Text = "Compute Pivot";
            checkBoxComputePivot.UseVisualStyleBackColor = true;
            checkBoxComputePivot.CheckedChanged += CheckBoxComputePivot_CheckedChanged;
            // 
            // radioPivotAll
            // 
            radioPivotAll.AutoSize = true;
            radioPivotAll.Enabled = false;
            radioPivotAll.Location = new Point(30, 38);
            radioPivotAll.Name = "radioPivotAll";
            radioPivotAll.Size = new Size(39, 19);
            radioPivotAll.TabIndex = 1;
            radioPivotAll.TabStop = true;
            radioPivotAll.Text = "All";
            radioPivotAll.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(checkBoxTopBottom);
            panel1.Controls.Add(checkBoxRightLeft);
            panel1.Controls.Add(radioNeighboreDefault);
            panel1.Controls.Add(checkBoxGetNeighbore);
            panel1.Controls.Add(radioNeighboreAll);
            panel1.Location = new Point(16, 22);
            panel1.Name = "panel1";
            panel1.Size = new Size(380, 68);
            panel1.TabIndex = 3;
            // 
            // checkBoxTopBottom
            // 
            checkBoxTopBottom.AutoSize = true;
            checkBoxTopBottom.Enabled = false;
            checkBoxTopBottom.Location = new Point(217, 37);
            checkBoxTopBottom.Name = "checkBoxTopBottom";
            checkBoxTopBottom.Size = new Size(141, 19);
            checkBoxTopBottom.TabIndex = 4;
            checkBoxTopBottom.Text = "Wrap top and bottom";
            checkBoxTopBottom.UseVisualStyleBackColor = true;
            // 
            // checkBoxRightLeft
            // 
            checkBoxRightLeft.AutoSize = true;
            checkBoxRightLeft.Enabled = false;
            checkBoxRightLeft.Location = new Point(219, 12);
            checkBoxRightLeft.Name = "checkBoxRightLeft";
            checkBoxRightLeft.Size = new Size(131, 19);
            checkBoxRightLeft.TabIndex = 3;
            checkBoxRightLeft.Text = "Wrap Right and Left";
            checkBoxRightLeft.UseVisualStyleBackColor = true;
            // 
            // radioNeighboreDefault
            // 
            radioNeighboreDefault.AutoSize = true;
            radioNeighboreDefault.Enabled = false;
            radioNeighboreDefault.Location = new Point(75, 37);
            radioNeighboreDefault.Name = "radioNeighboreDefault";
            radioNeighboreDefault.Size = new Size(126, 19);
            radioNeighboreDefault.TabIndex = 2;
            radioNeighboreDefault.TabStop = true;
            radioNeighboreDefault.Text = "Only default values";
            radioNeighboreDefault.UseVisualStyleBackColor = true;
            // 
            // checkBoxGetNeighbore
            // 
            checkBoxGetNeighbore.AutoSize = true;
            checkBoxGetNeighbore.Location = new Point(10, 12);
            checkBoxGetNeighbore.Name = "checkBoxGetNeighbore";
            checkBoxGetNeighbore.Size = new Size(166, 19);
            checkBoxGetNeighbore.TabIndex = 0;
            checkBoxGetNeighbore.Text = "Get neighbore from image";
            checkBoxGetNeighbore.UseVisualStyleBackColor = true;
            checkBoxGetNeighbore.CheckedChanged += CheckBoxGetNeighbore_CheckedChanged;
            // 
            // radioNeighboreAll
            // 
            radioNeighboreAll.AutoSize = true;
            radioNeighboreAll.Enabled = false;
            radioNeighboreAll.Location = new Point(30, 38);
            radioNeighboreAll.Name = "radioNeighboreAll";
            radioNeighboreAll.Size = new Size(39, 19);
            radioNeighboreAll.TabIndex = 1;
            radioNeighboreAll.TabStop = true;
            radioNeighboreAll.Text = "All";
            radioNeighboreAll.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(textBoxFileName);
            groupBox1.Controls.Add(btnSelectFile);
            groupBox1.Location = new Point(20, 32);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(246, 77);
            groupBox1.TabIndex = 3;
            groupBox1.TabStop = false;
            groupBox1.Text = "Select Root Fiile";
            // 
            // textBoxFileName
            // 
            textBoxFileName.BorderStyle = BorderStyle.FixedSingle;
            textBoxFileName.Location = new Point(6, 31);
            textBoxFileName.Name = "textBoxFileName";
            textBoxFileName.Size = new Size(170, 23);
            textBoxFileName.TabIndex = 1;
            // 
            // btnSelectFile
            // 
            btnSelectFile.FlatStyle = FlatStyle.Flat;
            btnSelectFile.Location = new Point(182, 31);
            btnSelectFile.Name = "btnSelectFile";
            btnSelectFile.Size = new Size(41, 23);
            btnSelectFile.TabIndex = 2;
            btnSelectFile.Text = "...";
            btnSelectFile.UseVisualStyleBackColor = true;
            btnSelectFile.Click += btnSelectFile_Click;
            // 
            // TabControl
            // 
            TabControl.Controls.Add(TabControleLoad);
            TabControl.Controls.Add(tabPage2);
            TabControl.Controls.Add(TabControleTile);
            TabControl.Controls.Add(tabCountry);
            TabControl.Controls.Add(tabPopulation);
            TabControl.Controls.Add(tabPage1);
            TabControl.Dock = DockStyle.Fill;
            TabControl.Location = new Point(0, 0);
            TabControl.Name = "TabControl";
            TabControl.SelectedIndex = 0;
            TabControl.Size = new Size(1077, 882);
            TabControl.TabIndex = 0;
            // 
            // tabPage2
            // 
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(1069, 854);
            tabPage2.TabIndex = 6;
            tabPage2.Text = "Static Data";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // TabControleTile
            // 
            TabControleTile.Location = new Point(4, 24);
            TabControleTile.Name = "TabControleTile";
            TabControleTile.Padding = new Padding(3);
            TabControleTile.Size = new Size(1069, 854);
            TabControleTile.TabIndex = 1;
            TabControleTile.Text = "Tile data";
            TabControleTile.UseVisualStyleBackColor = true;
            // 
            // tabCountry
            // 
            tabCountry.Location = new Point(4, 24);
            tabCountry.Name = "tabCountry";
            tabCountry.Padding = new Padding(3);
            tabCountry.Size = new Size(1069, 854);
            tabCountry.TabIndex = 4;
            tabCountry.Text = "Countries";
            tabCountry.UseVisualStyleBackColor = true;
            // 
            // tabPopulation
            // 
            tabPopulation.Location = new Point(4, 24);
            tabPopulation.Name = "tabPopulation";
            tabPopulation.Padding = new Padding(3);
            tabPopulation.Size = new Size(1069, 854);
            tabPopulation.TabIndex = 5;
            tabPopulation.Text = "Population";
            tabPopulation.UseVisualStyleBackColor = true;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(exportDataControle);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(1069, 854);
            tabPage1.TabIndex = 3;
            tabPage1.Text = "Export data";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // exportDataControle
            // 
            exportDataControle.Dock = DockStyle.Fill;
            exportDataControle.Location = new Point(3, 3);
            exportDataControle.Name = "exportDataControle";
            exportDataControle.Size = new Size(1063, 848);
            exportDataControle.TabIndex = 0;
            // 
            // MapTool
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1077, 882);
            Controls.Add(TabControl);
            Name = "MapTool";
            Text = "Map Tool";
            TabControleLoad.ResumeLayout(false);
            groupBox10.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            TabControl.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private FolderBrowserDialog folderBrowserDialog;
        private TabPage TabControleLoad;
        private GroupBox groupBox2;
        private CheckBox checkBox4;
        private CheckBox checkBox3;
        private Panel panel2;
        private RadioButton radioPivotDefault;
        private CheckBox checkBoxComputePivot;
        private RadioButton radioPivotAll;
        private Panel panel1;
        private RadioButton radioNeighboreDefault;
        private CheckBox checkBoxGetNeighbore;
        private RadioButton radioNeighboreAll;
        private GroupBox groupBox1;
        private TextBox textBoxFileName;
        private Button btnSelectFile;
        private TabControl TabControl;
        private TabPage TabControleTile;
        private Panel panel4;
        private RadioButton radioBtnSurfaceDefault;
        private CheckBox checkBoxComputeSurface;
        private RadioButton radioBtnSurfaceAll;
        private ColorDialog colorDialog1;
        private TabPage tabPage1;
        private Label label18;
        private ComboBox comboBoxScenario;
        private Button btnCompute;
        private CheckBox checkBoxTopBottom;
        private CheckBox checkBoxRightLeft;
        private GroupBox groupBox10;
        private RichTextBox TbTrace;
        private TabPage tabCountry;
        private TabPage tabPopulation;
        private TabPage tabPage2;
        private Scripts.Form.Vue.StaticDataControl staticDataControl1;
        private Scripts.Form.Vue.UserControle.TileDataControl tileDataControl1;
        private Scripts.Form.Vue.UserControle.ExportDataPresenter exportDataControle;
    }
}
