namespace MapToolV2.Scripts.Form.UIElement
{
    partial class SimpleGridUserControle
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
            GroupBoxSimpleGrid = new GroupBox();
            DataGrid = new DataGridView();
            flowLayoutPanel = new FlowLayoutPanel();
            BtnAdd = new Button();
            BtnRemove = new Button();
            GroupBoxSimpleGrid.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DataGrid).BeginInit();
            flowLayoutPanel.SuspendLayout();
            SuspendLayout();
            // 
            // GroupBoxSimpleGrid
            // 
            GroupBoxSimpleGrid.Controls.Add(DataGrid);
            GroupBoxSimpleGrid.Controls.Add(flowLayoutPanel);
            GroupBoxSimpleGrid.Dock = DockStyle.Fill;
            GroupBoxSimpleGrid.Location = new Point(0, 0);
            GroupBoxSimpleGrid.Margin = new Padding(3, 2, 3, 2);
            GroupBoxSimpleGrid.Name = "GroupBoxSimpleGrid";
            GroupBoxSimpleGrid.Padding = new Padding(3, 2, 3, 2);
            GroupBoxSimpleGrid.Size = new Size(694, 521);
            GroupBoxSimpleGrid.TabIndex = 1;
            GroupBoxSimpleGrid.TabStop = false;
            GroupBoxSimpleGrid.Text = "GridName";
            // 
            // DataGrid
            // 
            DataGrid.AllowUserToAddRows = false;
            DataGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DataGrid.Dock = DockStyle.Fill;
            DataGrid.Location = new Point(3, 18);
            DataGrid.Name = "DataGrid";
            DataGrid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            DataGrid.Size = new Size(688, 458);
            DataGrid.TabIndex = 7;
            // 
            // flowLayoutPanel
            // 
            flowLayoutPanel.Controls.Add(BtnAdd);
            flowLayoutPanel.Controls.Add(BtnRemove);
            flowLayoutPanel.Dock = DockStyle.Bottom;
            flowLayoutPanel.Location = new Point(3, 476);
            flowLayoutPanel.Name = "flowLayoutPanel";
            flowLayoutPanel.Padding = new Padding(0, 10, 0, 0);
            flowLayoutPanel.Size = new Size(688, 43);
            flowLayoutPanel.TabIndex = 9;
            // 
            // BtnAdd
            // 
            BtnAdd.Location = new Point(3, 12);
            BtnAdd.Margin = new Padding(3, 2, 3, 2);
            BtnAdd.Name = "BtnAdd";
            BtnAdd.Size = new Size(59, 20);
            BtnAdd.TabIndex = 5;
            BtnAdd.Text = "Add";
            BtnAdd.UseVisualStyleBackColor = true;
            BtnAdd.Click += BtnAdd_Click;
            // 
            // BtnRemove
            // 
            BtnRemove.Location = new Point(68, 12);
            BtnRemove.Margin = new Padding(3, 2, 3, 2);
            BtnRemove.Name = "BtnRemove";
            BtnRemove.Size = new Size(59, 20);
            BtnRemove.TabIndex = 4;
            BtnRemove.Text = "Remove";
            BtnRemove.UseVisualStyleBackColor = true;
            BtnRemove.Click += BtnRemove_Click;
            // 
            // SimpleGridUserControle
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(GroupBoxSimpleGrid);
            Name = "SimpleGridUserControle";
            Size = new Size(694, 521);
            GroupBoxSimpleGrid.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)DataGrid).EndInit();
            flowLayoutPanel.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private GroupBox GroupBoxSimpleGrid;
        private DataGridView DataGrid;
        private FlowLayoutPanel flowLayoutPanel;
        private Button BtnAdd;
        private Button BtnRemove;
    }
}
