namespace VideoTagManager.UI {
    partial class MainForm {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.searchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.scanToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewUndefinedFilesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteStoredDataToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exportStoredDataToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveChangesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.searchToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.startSearchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewAllFilesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.howToUseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.navigationPanel = new System.Windows.Forms.TableLayoutPanel();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnPrevious = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.navigationPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.searchToolStripMenuItem,
            this.searchToolStripMenuItem1,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(997, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // searchToolStripMenuItem
            // 
            this.searchToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.scanToolStripMenuItem,
            this.viewUndefinedFilesToolStripMenuItem,
            this.deleteStoredDataToolStripMenuItem,
            this.exportStoredDataToolStripMenuItem,
            this.saveChangesToolStripMenuItem});
            this.searchToolStripMenuItem.Name = "searchToolStripMenuItem";
            this.searchToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.searchToolStripMenuItem.Text = "File";
            // 
            // scanToolStripMenuItem
            // 
            this.scanToolStripMenuItem.Name = "scanToolStripMenuItem";
            this.scanToolStripMenuItem.Size = new System.Drawing.Size(177, 22);
            this.scanToolStripMenuItem.Text = "Scan folder";
            this.scanToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // viewUndefinedFilesToolStripMenuItem
            // 
            this.viewUndefinedFilesToolStripMenuItem.Name = "viewUndefinedFilesToolStripMenuItem";
            this.viewUndefinedFilesToolStripMenuItem.Size = new System.Drawing.Size(177, 22);
            this.viewUndefinedFilesToolStripMenuItem.Text = "View untagged files";
            this.viewUndefinedFilesToolStripMenuItem.Click += new System.EventHandler(this.viewUndefinedFilesToolStripMenuItem_Click);
            // 
            // deleteStoredDataToolStripMenuItem
            // 
            this.deleteStoredDataToolStripMenuItem.Name = "deleteStoredDataToolStripMenuItem";
            this.deleteStoredDataToolStripMenuItem.Size = new System.Drawing.Size(177, 22);
            this.deleteStoredDataToolStripMenuItem.Text = "Delete stored data";
            this.deleteStoredDataToolStripMenuItem.Click += new System.EventHandler(this.deleteStoredDataToolStripMenuItem_Click);
            // 
            // exportStoredDataToolStripMenuItem
            // 
            this.exportStoredDataToolStripMenuItem.Name = "exportStoredDataToolStripMenuItem";
            this.exportStoredDataToolStripMenuItem.Size = new System.Drawing.Size(177, 22);
            this.exportStoredDataToolStripMenuItem.Text = "Export stored data";
            this.exportStoredDataToolStripMenuItem.Click += new System.EventHandler(this.exportStoredDataToolStripMenuItem_Click);
            // 
            // saveChangesToolStripMenuItem
            // 
            this.saveChangesToolStripMenuItem.Name = "saveChangesToolStripMenuItem";
            this.saveChangesToolStripMenuItem.Size = new System.Drawing.Size(177, 22);
            this.saveChangesToolStripMenuItem.Text = "Save changes";
            this.saveChangesToolStripMenuItem.Click += new System.EventHandler(this.saveChangesToolStripMenuItem_Click);
            // 
            // searchToolStripMenuItem1
            // 
            this.searchToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.startSearchToolStripMenuItem,
            this.viewAllFilesToolStripMenuItem});
            this.searchToolStripMenuItem1.Name = "searchToolStripMenuItem1";
            this.searchToolStripMenuItem1.Size = new System.Drawing.Size(54, 20);
            this.searchToolStripMenuItem1.Text = "Search";
            // 
            // startSearchToolStripMenuItem
            // 
            this.startSearchToolStripMenuItem.Name = "startSearchToolStripMenuItem";
            this.startSearchToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
            this.startSearchToolStripMenuItem.Text = "Start search...";
            this.startSearchToolStripMenuItem.Click += new System.EventHandler(this.startSearchToolStripMenuItem_Click);
            // 
            // viewAllFilesToolStripMenuItem
            // 
            this.viewAllFilesToolStripMenuItem.Name = "viewAllFilesToolStripMenuItem";
            this.viewAllFilesToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
            this.viewAllFilesToolStripMenuItem.Text = "View all files";
            this.viewAllFilesToolStripMenuItem.Click += new System.EventHandler(this.viewAllFilesToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.howToUseToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // howToUseToolStripMenuItem
            // 
            this.howToUseToolStripMenuItem.Name = "howToUseToolStripMenuItem";
            this.howToUseToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.howToUseToolStripMenuItem.Text = "How to use";
            this.howToUseToolStripMenuItem.Click += new System.EventHandler(this.howToUseToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 5;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.Controls.Add(this.navigationPanel, 4, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 24);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(997, 495);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // navigationPanel
            // 
            this.navigationPanel.ColumnCount = 1;
            this.navigationPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.navigationPanel.Controls.Add(this.btnNext, 0, 0);
            this.navigationPanel.Controls.Add(this.btnPrevious, 0, 1);
            this.navigationPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.navigationPanel.Location = new System.Drawing.Point(799, 333);
            this.navigationPanel.Name = "navigationPanel";
            this.navigationPanel.RowCount = 2;
            this.navigationPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.navigationPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.navigationPanel.Size = new System.Drawing.Size(195, 159);
            this.navigationPanel.TabIndex = 0;
            // 
            // btnNext
            // 
            this.btnNext.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnNext.Location = new System.Drawing.Point(60, 28);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(75, 23);
            this.btnNext.TabIndex = 0;
            this.btnNext.Text = "Next";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnPrevious
            // 
            this.btnPrevious.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnPrevious.Location = new System.Drawing.Point(60, 107);
            this.btnPrevious.Name = "btnPrevious";
            this.btnPrevious.Size = new System.Drawing.Size(75, 23);
            this.btnPrevious.TabIndex = 1;
            this.btnPrevious.Text = "Previous";
            this.btnPrevious.UseVisualStyleBackColor = true;
            this.btnPrevious.Click += new System.EventHandler(this.btnPrevious_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(997, 519);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "File Manager";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.navigationPanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem searchToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem scanToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewUndefinedFilesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem searchToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem startSearchToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewAllFilesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem howToUseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel navigationPanel;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnPrevious;
        private System.Windows.Forms.ToolStripMenuItem deleteStoredDataToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exportStoredDataToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveChangesToolStripMenuItem;
    }
}