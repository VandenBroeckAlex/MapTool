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
            simpleGridTerrain = new MapToolV2.Scripts.Form.UIElement.SimpleGridUserControle();
            flowLayoutPanel1 = new FlowLayoutPanel();
            ClimateGrid = new MapToolV2.Scripts.Form.UIElement.SimpleGridUserControle();
            groupBox14.SuspendLayout();
            flowLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox14
            // 
            groupBox14.Controls.Add(ClimateGrid);
            groupBox14.Controls.Add(simpleGridTerrain);
            groupBox14.Location = new Point(3, 2);
            groupBox14.Margin = new Padding(3, 2, 3, 2);
            groupBox14.Name = "groupBox14";
            groupBox14.Padding = new Padding(3, 2, 3, 2);
            groupBox14.Size = new Size(1021, 543);
            groupBox14.TabIndex = 6;
            groupBox14.TabStop = false;
            groupBox14.Text = "Static Data";
            // 
            // simpleGridTerrain
            // 
            simpleGridTerrain.Location = new Point(6, 32);
            simpleGridTerrain.Name = "simpleGridTerrain";
            simpleGridTerrain.Size = new Size(497, 447);
            simpleGridTerrain.TabIndex = 1;
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
            // ClimateGrid
            // 
            ClimateGrid.Location = new Point(509, 32);
            ClimateGrid.Name = "ClimateGrid";
            ClimateGrid.Size = new Size(403, 447);
            ClimateGrid.TabIndex = 2;
            // 
            // StaticDataControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(flowLayoutPanel1);
            Name = "StaticDataControl";
            Size = new Size(1027, 621);
            groupBox14.ResumeLayout(false);
            flowLayoutPanel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox14;
        private FlowLayoutPanel flowLayoutPanel1;
        private UIElement.SimpleGridUserControle simpleGridUC;
        private UIElement.SimpleGridUserControle simpleGridTerrain;
        private UIElement.SimpleGridUserControle ClimateGrid;
    }
}
