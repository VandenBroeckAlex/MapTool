namespace MapToolV2.Scripts.Form.Vue
{
    partial class StaticDataControl
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            groupBox14 = new GroupBox();
            gbClimate = new GroupBox();
            button1 = new Button();
            btnAddClimate = new Button();
            textBoxClimateType = new TextBox();
            listViewClimateType = new ListView();
            groupBox11 = new GroupBox();
            dGTerrainType = new DataGridView();
            TerrainName = new DataGridViewTextBoxColumn();
            TerrainTag = new DataGridViewTextBoxColumn();
            IsLand = new DataGridViewCheckBoxColumn();
            cbIsLand = new CheckBox();
            groupBoxTag = new GroupBox();
            textBox1 = new TextBox();
            groupBox1 = new GroupBox();
            textBoxTerrainType = new TextBox();
            BtnTerrainRemoveSelect = new Button();
            btnAddTerrain = new Button();
            flowLayoutPanel1 = new FlowLayoutPanel();
            groupBox14.SuspendLayout();
            gbClimate.SuspendLayout();
            groupBox11.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dGTerrainType).BeginInit();
            groupBoxTag.SuspendLayout();
            groupBox1.SuspendLayout();
            flowLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox14
            // 
            groupBox14.Controls.Add(gbClimate);
            groupBox14.Controls.Add(groupBox11);
            groupBox14.Location = new Point(3, 2);
            groupBox14.Margin = new Padding(3, 2, 3, 2);
            groupBox14.Name = "groupBox14";
            groupBox14.Padding = new Padding(3, 2, 3, 2);
            groupBox14.Size = new Size(1011, 543);
            groupBox14.TabIndex = 6;
            groupBox14.TabStop = false;
            groupBox14.Text = "Tile Data";
            // 
            // gbClimate
            // 
            gbClimate.Controls.Add(button1);
            gbClimate.Controls.Add(btnAddClimate);
            gbClimate.Controls.Add(textBoxClimateType);
            gbClimate.Controls.Add(listViewClimateType);
            gbClimate.Location = new Point(573, 40);
            gbClimate.Margin = new Padding(3, 2, 3, 2);
            gbClimate.Name = "gbClimate";
            gbClimate.Padding = new Padding(3, 2, 3, 2);
            gbClimate.Size = new Size(212, 279);
            gbClimate.TabIndex = 4;
            gbClimate.TabStop = false;
            gbClimate.Text = "Climate Types";
            // 
            // button1
            // 
            button1.Location = new Point(20, 180);
            button1.Margin = new Padding(3, 2, 3, 2);
            button1.Name = "button1";
            button1.Size = new Size(59, 20);
            button1.TabIndex = 3;
            button1.Text = "Remove";
            button1.UseVisualStyleBackColor = true;
            button1.Click += btnRemoveClimate_Click;
            // 
            // btnAddClimate
            // 
            btnAddClimate.Location = new Point(148, 239);
            btnAddClimate.Margin = new Padding(3, 2, 3, 2);
            btnAddClimate.Name = "btnAddClimate";
            btnAddClimate.Size = new Size(59, 20);
            btnAddClimate.TabIndex = 2;
            btnAddClimate.Text = "Add";
            btnAddClimate.UseVisualStyleBackColor = true;
            btnAddClimate.Click += btnAddClimate_Click;
            // 
            // textBoxClimateType
            // 
            textBoxClimateType.Location = new Point(20, 239);
            textBoxClimateType.Margin = new Padding(3, 2, 3, 2);
            textBoxClimateType.Name = "textBoxClimateType";
            textBoxClimateType.Size = new Size(127, 23);
            textBoxClimateType.TabIndex = 1;
            // 
            // listViewClimateType
            // 
            listViewClimateType.Location = new Point(20, 20);
            listViewClimateType.Margin = new Padding(3, 2, 3, 2);
            listViewClimateType.Name = "listViewClimateType";
            listViewClimateType.Size = new Size(166, 156);
            listViewClimateType.TabIndex = 0;
            listViewClimateType.UseCompatibleStateImageBehavior = false;
            // 
            // groupBox11
            // 
            groupBox11.Controls.Add(dGTerrainType);
            groupBox11.Controls.Add(cbIsLand);
            groupBox11.Controls.Add(groupBoxTag);
            groupBox11.Controls.Add(groupBox1);
            groupBox11.Controls.Add(BtnTerrainRemoveSelect);
            groupBox11.Controls.Add(btnAddTerrain);
            groupBox11.Location = new Point(20, 40);
            groupBox11.Margin = new Padding(3, 2, 3, 2);
            groupBox11.Name = "groupBox11";
            groupBox11.Padding = new Padding(3, 2, 3, 2);
            groupBox11.Size = new Size(431, 425);
            groupBox11.TabIndex = 0;
            groupBox11.TabStop = false;
            groupBox11.Text = "Terrain Type";
            // 
            // dGTerrainType
            // 
            dGTerrainType.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dGTerrainType.Columns.AddRange(new DataGridViewColumn[] { TerrainName, TerrainTag, IsLand });
            dGTerrainType.Location = new Point(6, 20);
            dGTerrainType.Name = "dGTerrainType";
            dGTerrainType.Size = new Size(419, 150);
            dGTerrainType.TabIndex = 7;
            // 
            // TerrainName
            // 
            TerrainName.DataPropertyName = "name";
            TerrainName.HeaderText = "Terrain Name";
            TerrainName.Name = "TerrainName";
            // 
            // TerrainTag
            // 
            TerrainTag.DataPropertyName = "tag";
            TerrainTag.HeaderText = "Terrain Tag";
            TerrainTag.Name = "TerrainTag";
            // 
            // IsLand
            // 
            IsLand.DataPropertyName = "isLandType";
            IsLand.HeaderText = "Is land";
            IsLand.Name = "IsLand";
            // 
            // cbIsLand
            // 
            cbIsLand.AutoSize = true;
            cbIsLand.Checked = true;
            cbIsLand.CheckState = CheckState.Checked;
            cbIsLand.Location = new Point(24, 340);
            cbIsLand.Name = "cbIsLand";
            cbIsLand.Size = new Size(60, 19);
            cbIsLand.TabIndex = 6;
            cbIsLand.Text = "IsLand";
            cbIsLand.UseVisualStyleBackColor = true;
            // 
            // groupBoxTag
            // 
            groupBoxTag.Controls.Add(textBox1);
            groupBoxTag.Location = new Point(18, 268);
            groupBoxTag.Name = "groupBoxTag";
            groupBoxTag.Size = new Size(143, 57);
            groupBoxTag.TabIndex = 5;
            groupBoxTag.TabStop = false;
            groupBoxTag.Text = "Tag";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(6, 21);
            textBox1.Margin = new Padding(3, 2, 3, 2);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(127, 23);
            textBox1.TabIndex = 1;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(textBoxTerrainType);
            groupBox1.Location = new Point(18, 205);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(143, 57);
            groupBox1.TabIndex = 4;
            groupBox1.TabStop = false;
            groupBox1.Text = "Name";
            // 
            // textBoxTerrainType
            // 
            textBoxTerrainType.Location = new Point(6, 21);
            textBoxTerrainType.Margin = new Padding(3, 2, 3, 2);
            textBoxTerrainType.Name = "textBoxTerrainType";
            textBoxTerrainType.Size = new Size(127, 23);
            textBoxTerrainType.TabIndex = 1;
            // 
            // BtnTerrainRemoveSelect
            // 
            BtnTerrainRemoveSelect.Location = new Point(20, 180);
            BtnTerrainRemoveSelect.Margin = new Padding(3, 2, 3, 2);
            BtnTerrainRemoveSelect.Name = "BtnTerrainRemoveSelect";
            BtnTerrainRemoveSelect.Size = new Size(59, 20);
            BtnTerrainRemoveSelect.TabIndex = 3;
            BtnTerrainRemoveSelect.Text = "Remove";
            BtnTerrainRemoveSelect.UseVisualStyleBackColor = true;
            BtnTerrainRemoveSelect.Click += btnRemoveTerrain_Click;
            // 
            // btnAddTerrain
            // 
            btnAddTerrain.Location = new Point(102, 180);
            btnAddTerrain.Margin = new Padding(3, 2, 3, 2);
            btnAddTerrain.Name = "btnAddTerrain";
            btnAddTerrain.Size = new Size(59, 20);
            btnAddTerrain.TabIndex = 2;
            btnAddTerrain.Text = "Add";
            btnAddTerrain.UseVisualStyleBackColor = true;
            btnAddTerrain.Click += btnAddTerrain_Click;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Controls.Add(groupBox14);
            flowLayoutPanel1.Dock = DockStyle.Fill;
            flowLayoutPanel1.Location = new Point(0, 0);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(1027, 621);
            flowLayoutPanel1.TabIndex = 8;
            flowLayoutPanel1.VisibleChanged += OnVisibleChange;
            // 
            // StaticDataControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(flowLayoutPanel1);
            Name = "StaticDataControl";
            Size = new Size(1027, 621);
            groupBox14.ResumeLayout(false);
            gbClimate.ResumeLayout(false);
            gbClimate.PerformLayout();
            groupBox11.ResumeLayout(false);
            groupBox11.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dGTerrainType).EndInit();
            groupBoxTag.ResumeLayout(false);
            groupBoxTag.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            flowLayoutPanel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox14;
        private GroupBox groupBox11;
        private Button btnAddTerrain;
        private TextBox textBoxTerrainType;
        private FlowLayoutPanel flowLayoutPanel1;
        private GroupBox gbClimate;
        private Button button1;
        private Button btnAddClimate;
        private TextBox textBoxClimateType;
        private ListView listViewClimateType;
        private Button BtnTerrainRemoveSelect;
        private GroupBox groupBoxTag;
        private TextBox textBox1;
        private GroupBox groupBox1;
        private CheckBox cbIsLand;
        private DataGridView dGTerrainType;
        private DataGridViewTextBoxColumn TerrainName;
        private DataGridViewTextBoxColumn TerrainTag;
        private DataGridViewCheckBoxColumn IsLand;
    }
}
