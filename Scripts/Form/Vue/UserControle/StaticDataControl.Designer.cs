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
            BtnTerrainRemoveSelect = new Button();
            btnAddTerrain = new Button();
            textBoxTerrainType = new TextBox();
            listViewTerrain = new ListView();
            flowLayoutPanel1 = new FlowLayoutPanel();
            groupBox14.SuspendLayout();
            gbClimate.SuspendLayout();
            groupBox11.SuspendLayout();
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
            groupBox14.Size = new Size(543, 366);
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
            gbClimate.Location = new Point(269, 40);
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
            groupBox11.Controls.Add(BtnTerrainRemoveSelect);
            groupBox11.Controls.Add(btnAddTerrain);
            groupBox11.Controls.Add(textBoxTerrainType);
            groupBox11.Controls.Add(listViewTerrain);
            groupBox11.Location = new Point(20, 40);
            groupBox11.Margin = new Padding(3, 2, 3, 2);
            groupBox11.Name = "groupBox11";
            groupBox11.Padding = new Padding(3, 2, 3, 2);
            groupBox11.Size = new Size(212, 279);
            groupBox11.TabIndex = 0;
            groupBox11.TabStop = false;
            groupBox11.Text = "Terrain Type";
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
            btnAddTerrain.Location = new Point(148, 239);
            btnAddTerrain.Margin = new Padding(3, 2, 3, 2);
            btnAddTerrain.Name = "btnAddTerrain";
            btnAddTerrain.Size = new Size(59, 20);
            btnAddTerrain.TabIndex = 2;
            btnAddTerrain.Text = "Add";
            btnAddTerrain.UseVisualStyleBackColor = true;
            btnAddTerrain.Click += btnAddTerrain_Click;
            // 
            // textBoxTerrainType
            // 
            textBoxTerrainType.Location = new Point(20, 239);
            textBoxTerrainType.Margin = new Padding(3, 2, 3, 2);
            textBoxTerrainType.Name = "textBoxTerrainType";
            textBoxTerrainType.Size = new Size(127, 23);
            textBoxTerrainType.TabIndex = 1;
            // 
            // listViewTerrain
            // 
            listViewTerrain.GridLines = true;
            listViewTerrain.Location = new Point(20, 20);
            listViewTerrain.Margin = new Padding(3, 2, 3, 2);
            listViewTerrain.Name = "listViewTerrain";
            listViewTerrain.Size = new Size(166, 156);
            listViewTerrain.TabIndex = 0;
            listViewTerrain.UseCompatibleStateImageBehavior = false;
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
            flowLayoutPanel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox14;
        private GroupBox groupBox11;
        private Button btnAddTerrain;
        private TextBox textBoxTerrainType;
        private ListView listViewTerrain;
        private FlowLayoutPanel flowLayoutPanel1;
        private GroupBox gbClimate;
        private Button button1;
        private Button btnAddClimate;
        private TextBox textBoxClimateType;
        private ListView listViewClimateType;
        private Button BtnTerrainRemoveSelect;
    }
}
