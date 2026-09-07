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
            TabControl = new TabControl();
            tabPage2 = new TabPage();
            staticDataControl2 = new MapToolV2.Scripts.Form.Vue.StaticDataControl();
            TabControleTile = new TabPage();
            tileDataControl2 = new MapToolV2.Scripts.Form.Vue.UserControle.TileDataControl();
            tabCountry = new TabPage();
            tabPopulation = new TabPage();
            tabPage1 = new TabPage();
            exportDataControle = new MapToolV2.Scripts.Form.Vue.UserControle.ExportDataPresenter();
            tabLoadData = new TabPage();
            importDataControle = new MapToolV2.Scripts.Form.Vue.UserControle.ImportDataControle();
            colorDialog1 = new ColorDialog();
            TabControl.SuspendLayout();
            tabPage2.SuspendLayout();
            TabControleTile.SuspendLayout();
            tabPage1.SuspendLayout();
            tabLoadData.SuspendLayout();
            SuspendLayout();
            // 
            // TabControl
            // 
            TabControl.Controls.Add(tabLoadData);
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
            tabPage2.Controls.Add(staticDataControl2);
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(1069, 854);
            tabPage2.TabIndex = 6;
            tabPage2.Text = "Static Data";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // staticDataControl2
            // 
            staticDataControl2.Dock = DockStyle.Fill;
            staticDataControl2.Location = new Point(3, 3);
            staticDataControl2.Name = "staticDataControl2";
            staticDataControl2.Size = new Size(1063, 848);
            staticDataControl2.TabIndex = 0;
            // 
            // TabControleTile
            // 
            TabControleTile.Controls.Add(tileDataControl2);
            TabControleTile.Location = new Point(4, 24);
            TabControleTile.Name = "TabControleTile";
            TabControleTile.Padding = new Padding(3);
            TabControleTile.Size = new Size(1069, 854);
            TabControleTile.TabIndex = 1;
            TabControleTile.Text = "Tile data";
            TabControleTile.UseVisualStyleBackColor = true;
            // 
            // tileDataControl2
            // 
            tileDataControl2.Dock = DockStyle.Fill;
            tileDataControl2.Location = new Point(3, 3);
            tileDataControl2.Name = "tileDataControl2";
            tileDataControl2.Size = new Size(1063, 848);
            tileDataControl2.TabIndex = 0;
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
            // tabLoadData
            // 
            tabLoadData.Controls.Add(importDataControle);
            tabLoadData.Location = new Point(4, 24);
            tabLoadData.Name = "tabLoadData";
            tabLoadData.Padding = new Padding(3);
            tabLoadData.Size = new Size(1069, 854);
            tabLoadData.TabIndex = 7;
            tabLoadData.Text = "Load Data";
            tabLoadData.UseVisualStyleBackColor = true;
            // 
            // importDataControle
            // 
            importDataControle.Dock = DockStyle.Fill;
            importDataControle.Location = new Point(3, 3);
            importDataControle.Name = "importDataControle";
            importDataControle.Size = new Size(1063, 848);
            importDataControle.TabIndex = 0;
            // 
            // MapTool
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1077, 882);
            Controls.Add(TabControl);
            Name = "MapTool";
            Text = "Map Tool";
            TabControl.ResumeLayout(false);
            tabPage2.ResumeLayout(false);
            TabControleTile.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabLoadData.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private FolderBrowserDialog folderBrowserDialog;
        private TabControl TabControl;
        private TabPage TabControleTile;
        private ColorDialog colorDialog1;
        private TabPage tabPage1;
        private TabPage tabCountry;
        private TabPage tabPopulation;
        private TabPage tabPage2;
        private Scripts.Form.Vue.StaticDataControl staticDataControl1;
        private Scripts.Form.Vue.UserControle.TileDataControl tileDataControl1;
        private Scripts.Form.Vue.UserControle.ExportDataPresenter exportDataControle;
        private TabPage tabLoadData;
        private Scripts.Form.Vue.UserControle.ImportDataControle importDataControle;
        private Scripts.Form.Vue.StaticDataControl staticDataControl2;
        private Scripts.Form.Vue.UserControle.TileDataControl tileDataControl2;
    }
}
