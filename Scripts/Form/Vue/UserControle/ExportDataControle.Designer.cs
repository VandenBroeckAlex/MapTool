namespace MapToolV2.Scripts.Form.Vue.UserControle
{
    partial class ExportDataPresenter
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
            flowLayoutPanel1 = new FlowLayoutPanel();
            groupBox9 = new GroupBox();
            textBoxOutputFile = new TextBox();
            buttonSelectOutputFile = new Button();
            btnCreateroot = new Button();
            button8 = new Button();
            folderBrowserDialog1 = new FolderBrowserDialog();
            flowLayoutPanel1.SuspendLayout();
            groupBox9.SuspendLayout();
            SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Controls.Add(groupBox9);
            flowLayoutPanel1.Controls.Add(btnCreateroot);
            flowLayoutPanel1.Controls.Add(button8);
            flowLayoutPanel1.Dock = DockStyle.Fill;
            flowLayoutPanel1.Location = new Point(0, 0);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(1002, 578);
            flowLayoutPanel1.TabIndex = 7;
            // 
            // groupBox9
            // 
            groupBox9.Controls.Add(textBoxOutputFile);
            groupBox9.Controls.Add(buttonSelectOutputFile);
            groupBox9.Location = new Point(3, 3);
            groupBox9.Name = "groupBox9";
            groupBox9.Size = new Size(246, 77);
            groupBox9.TabIndex = 4;
            groupBox9.TabStop = false;
            groupBox9.Text = "Select Root Fiile";
            // 
            // textBoxOutputFile
            // 
            textBoxOutputFile.BorderStyle = BorderStyle.FixedSingle;
            textBoxOutputFile.Location = new Point(6, 31);
            textBoxOutputFile.Name = "textBoxOutputFile";
            textBoxOutputFile.ReadOnly = true;
            textBoxOutputFile.Size = new Size(170, 23);
            textBoxOutputFile.TabIndex = 1;
            // 
            // buttonSelectOutputFile
            // 
            buttonSelectOutputFile.FlatStyle = FlatStyle.Flat;
            buttonSelectOutputFile.Location = new Point(182, 31);
            buttonSelectOutputFile.Name = "buttonSelectOutputFile";
            buttonSelectOutputFile.Size = new Size(41, 23);
            buttonSelectOutputFile.TabIndex = 2;
            buttonSelectOutputFile.Text = "...";
            buttonSelectOutputFile.UseVisualStyleBackColor = true;
            buttonSelectOutputFile.Click += buttonSelectOutputFile_Click_1;
            // 
            // btnCreateroot
            // 
            btnCreateroot.Location = new Point(255, 2);
            btnCreateroot.Margin = new Padding(3, 2, 3, 2);
            btnCreateroot.Name = "btnCreateroot";
            btnCreateroot.Size = new Size(164, 23);
            btnCreateroot.TabIndex = 5;
            btnCreateroot.Text = "Create root file";
            btnCreateroot.UseVisualStyleBackColor = true;
            btnCreateroot.Click += btnCreateroot_Click;
            // 
            // button8
            // 
            button8.Location = new Point(425, 3);
            button8.Name = "button8";
            button8.Size = new Size(76, 23);
            button8.TabIndex = 0;
            button8.Text = "Export Data";
            button8.UseVisualStyleBackColor = true;
            // 
            // ExportDataPresenter
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(flowLayoutPanel1);
            Name = "ExportDataPresenter";
            Size = new Size(1002, 578);
            flowLayoutPanel1.ResumeLayout(false);
            groupBox9.ResumeLayout(false);
            groupBox9.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private FlowLayoutPanel flowLayoutPanel1;
        private GroupBox groupBox9;
        private TextBox textBoxOutputFile;
        private Button buttonSelectOutputFile;
        private Button btnCreateroot;
        private Button button8;
        private FolderBrowserDialog folderBrowserDialog1;
    }
}
