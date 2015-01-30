namespace VideoTagManager.UI {
    partial class FileConfigForm {
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.fileInfoPanel = new System.Windows.Forms.TableLayoutPanel();
            this.fileNameLegend = new System.Windows.Forms.Label();
            this.filePathLegend = new System.Windows.Forms.Label();
            this.fileNameLabel = new System.Windows.Forms.Label();
            this.filePathLabel = new System.Windows.Forms.Label();
            this.fileThumb = new System.Windows.Forms.PictureBox();
            this.tagManagementPanel = new System.Windows.Forms.TableLayoutPanel();
            this.fileTagsList = new System.Windows.Forms.ListBox();
            this.btnRemoveTag = new System.Windows.Forms.Button();
            this.btnCreateTag = new System.Windows.Forms.Button();
            this.allTagsPanel = new System.Windows.Forms.TableLayoutPanel();
            this.allTagsList = new System.Windows.Forms.ListBox();
            this.btnAddtag = new System.Windows.Forms.Button();
            this.authorManagementPanel = new System.Windows.Forms.TableLayoutPanel();
            this.fileAuthorsList = new System.Windows.Forms.ListBox();
            this.btnRemoveAuthor = new System.Windows.Forms.Button();
            this.btnCreateAuthor = new System.Windows.Forms.Button();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.allAuthorsList = new System.Windows.Forms.ListBox();
            this.btnAddAuthor = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.fileInfoPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fileThumb)).BeginInit();
            this.tagManagementPanel.SuspendLayout();
            this.allTagsPanel.SuspendLayout();
            this.authorManagementPanel.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.authorManagementPanel, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.fileInfoPanel, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.fileThumb, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.tagManagementPanel, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 43.09623F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 56.90377F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(733, 595);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // fileInfoPanel
            // 
            this.fileInfoPanel.ColumnCount = 1;
            this.fileInfoPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.fileInfoPanel.Controls.Add(this.fileNameLegend, 0, 0);
            this.fileInfoPanel.Controls.Add(this.filePathLegend, 0, 2);
            this.fileInfoPanel.Controls.Add(this.fileNameLabel, 0, 1);
            this.fileInfoPanel.Controls.Add(this.filePathLabel, 0, 3);
            this.fileInfoPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fileInfoPanel.Location = new System.Drawing.Point(3, 3);
            this.fileInfoPanel.Name = "fileInfoPanel";
            this.fileInfoPanel.RowCount = 5;
            this.fileInfoPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.fileInfoPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.fileInfoPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.fileInfoPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.fileInfoPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.fileInfoPanel.Size = new System.Drawing.Size(360, 250);
            this.fileInfoPanel.TabIndex = 0;
            // 
            // fileNameLegend
            // 
            this.fileNameLegend.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.fileNameLegend.AutoSize = true;
            this.fileNameLegend.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fileNameLegend.Location = new System.Drawing.Point(140, 16);
            this.fileNameLegend.Name = "fileNameLegend";
            this.fileNameLegend.Size = new System.Drawing.Size(80, 17);
            this.fileNameLegend.TabIndex = 0;
            this.fileNameLegend.Text = "File Name";
            // 
            // filePathLegend
            // 
            this.filePathLegend.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.filePathLegend.AutoSize = true;
            this.filePathLegend.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.filePathLegend.Location = new System.Drawing.Point(144, 116);
            this.filePathLegend.Name = "filePathLegend";
            this.filePathLegend.Size = new System.Drawing.Size(72, 17);
            this.filePathLegend.TabIndex = 1;
            this.filePathLegend.Text = "File Path";
            // 
            // fileNameLabel
            // 
            this.fileNameLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.fileNameLabel.AutoSize = true;
            this.fileNameLabel.Location = new System.Drawing.Point(155, 68);
            this.fileNameLabel.Name = "fileNameLabel";
            this.fileNameLabel.Size = new System.Drawing.Size(49, 13);
            this.fileNameLabel.TabIndex = 2;
            this.fileNameLabel.Text = "file name";
            // 
            // filePathLabel
            // 
            this.filePathLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.filePathLabel.AutoSize = true;
            this.filePathLabel.Location = new System.Drawing.Point(158, 168);
            this.filePathLabel.Name = "filePathLabel";
            this.filePathLabel.Size = new System.Drawing.Size(44, 13);
            this.filePathLabel.TabIndex = 2;
            this.filePathLabel.Text = "file path";
            // 
            // fileThumb
            // 
            this.fileThumb.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fileThumb.Location = new System.Drawing.Point(369, 3);
            this.fileThumb.Name = "fileThumb";
            this.fileThumb.Size = new System.Drawing.Size(361, 250);
            this.fileThumb.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.fileThumb.TabIndex = 1;
            this.fileThumb.TabStop = false;
            // 
            // tagManagementPanel
            // 
            this.tagManagementPanel.ColumnCount = 2;
            this.tagManagementPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tagManagementPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tagManagementPanel.Controls.Add(this.fileTagsList, 0, 0);
            this.tagManagementPanel.Controls.Add(this.btnRemoveTag, 0, 1);
            this.tagManagementPanel.Controls.Add(this.btnCreateTag, 1, 1);
            this.tagManagementPanel.Controls.Add(this.allTagsPanel, 1, 0);
            this.tagManagementPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tagManagementPanel.Location = new System.Drawing.Point(3, 259);
            this.tagManagementPanel.Name = "tagManagementPanel";
            this.tagManagementPanel.RowCount = 2;
            this.tagManagementPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 77.17718F));
            this.tagManagementPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 22.82282F));
            this.tagManagementPanel.Size = new System.Drawing.Size(360, 333);
            this.tagManagementPanel.TabIndex = 2;
            // 
            // fileTagsList
            // 
            this.fileTagsList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fileTagsList.FormattingEnabled = true;
            this.fileTagsList.HorizontalScrollbar = true;
            this.fileTagsList.Location = new System.Drawing.Point(3, 3);
            this.fileTagsList.Name = "fileTagsList";
            this.fileTagsList.Size = new System.Drawing.Size(174, 251);
            this.fileTagsList.TabIndex = 2;
            // 
            // btnRemoveTag
            // 
            this.btnRemoveTag.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnRemoveTag.Location = new System.Drawing.Point(52, 283);
            this.btnRemoveTag.Name = "btnRemoveTag";
            this.btnRemoveTag.Size = new System.Drawing.Size(75, 23);
            this.btnRemoveTag.TabIndex = 0;
            this.btnRemoveTag.Text = "Remove";
            this.btnRemoveTag.UseVisualStyleBackColor = true;
            this.btnRemoveTag.Click += new System.EventHandler(this.btnRemoveTag_Click);
            // 
            // btnCreateTag
            // 
            this.btnCreateTag.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnCreateTag.Location = new System.Drawing.Point(232, 283);
            this.btnCreateTag.Name = "btnCreateTag";
            this.btnCreateTag.Size = new System.Drawing.Size(75, 23);
            this.btnCreateTag.TabIndex = 0;
            this.btnCreateTag.Text = "Create";
            this.btnCreateTag.UseVisualStyleBackColor = true;
            this.btnCreateTag.Click += new System.EventHandler(this.btnCreateTag_Click);
            // 
            // allTagsPanel
            // 
            this.allTagsPanel.ColumnCount = 1;
            this.allTagsPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.allTagsPanel.Controls.Add(this.allTagsList, 0, 0);
            this.allTagsPanel.Controls.Add(this.btnAddtag, 0, 1);
            this.allTagsPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.allTagsPanel.Location = new System.Drawing.Point(183, 3);
            this.allTagsPanel.Name = "allTagsPanel";
            this.allTagsPanel.RowCount = 2;
            this.allTagsPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this.allTagsPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.allTagsPanel.Size = new System.Drawing.Size(174, 251);
            this.allTagsPanel.TabIndex = 1;
            // 
            // allTagsList
            // 
            this.allTagsList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.allTagsList.FormattingEnabled = true;
            this.allTagsList.HorizontalScrollbar = true;
            this.allTagsList.Location = new System.Drawing.Point(3, 3);
            this.allTagsList.Name = "allTagsList";
            this.allTagsList.Size = new System.Drawing.Size(168, 194);
            this.allTagsList.TabIndex = 0;
            // 
            // btnAddtag
            // 
            this.btnAddtag.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnAddtag.Location = new System.Drawing.Point(49, 214);
            this.btnAddtag.Name = "btnAddtag";
            this.btnAddtag.Size = new System.Drawing.Size(75, 23);
            this.btnAddtag.TabIndex = 1;
            this.btnAddtag.Text = "<< Add";
            this.btnAddtag.UseVisualStyleBackColor = true;
            this.btnAddtag.Click += new System.EventHandler(this.btnAddtag_Click);
            // 
            // authorManagementPanel
            // 
            this.authorManagementPanel.ColumnCount = 2;
            this.authorManagementPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.authorManagementPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.authorManagementPanel.Controls.Add(this.fileAuthorsList, 0, 0);
            this.authorManagementPanel.Controls.Add(this.btnRemoveAuthor, 0, 1);
            this.authorManagementPanel.Controls.Add(this.btnCreateAuthor, 1, 1);
            this.authorManagementPanel.Controls.Add(this.tableLayoutPanel3, 1, 0);
            this.authorManagementPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.authorManagementPanel.Location = new System.Drawing.Point(369, 259);
            this.authorManagementPanel.Name = "authorManagementPanel";
            this.authorManagementPanel.RowCount = 2;
            this.authorManagementPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 77.17718F));
            this.authorManagementPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 22.82282F));
            this.authorManagementPanel.Size = new System.Drawing.Size(361, 333);
            this.authorManagementPanel.TabIndex = 3;
            // 
            // fileAuthorsList
            // 
            this.fileAuthorsList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fileAuthorsList.FormattingEnabled = true;
            this.fileAuthorsList.HorizontalScrollbar = true;
            this.fileAuthorsList.Location = new System.Drawing.Point(3, 3);
            this.fileAuthorsList.Name = "fileAuthorsList";
            this.fileAuthorsList.Size = new System.Drawing.Size(174, 251);
            this.fileAuthorsList.TabIndex = 2;
            // 
            // btnRemoveAuthor
            // 
            this.btnRemoveAuthor.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnRemoveAuthor.Location = new System.Drawing.Point(52, 283);
            this.btnRemoveAuthor.Name = "btnRemoveAuthor";
            this.btnRemoveAuthor.Size = new System.Drawing.Size(75, 23);
            this.btnRemoveAuthor.TabIndex = 0;
            this.btnRemoveAuthor.Text = "Remove";
            this.btnRemoveAuthor.UseVisualStyleBackColor = true;
            this.btnRemoveAuthor.Click += new System.EventHandler(this.btnRemoveAuthor_Click);
            // 
            // btnCreateAuthor
            // 
            this.btnCreateAuthor.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnCreateAuthor.Location = new System.Drawing.Point(233, 283);
            this.btnCreateAuthor.Name = "btnCreateAuthor";
            this.btnCreateAuthor.Size = new System.Drawing.Size(75, 23);
            this.btnCreateAuthor.TabIndex = 0;
            this.btnCreateAuthor.Text = "Create";
            this.btnCreateAuthor.UseVisualStyleBackColor = true;
            this.btnCreateAuthor.Click += new System.EventHandler(this.btnCreateAuthor_Click);
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 1;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Controls.Add(this.allAuthorsList, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.btnAddAuthor, 0, 1);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(183, 3);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 2;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(175, 251);
            this.tableLayoutPanel3.TabIndex = 1;
            // 
            // allAuthorsList
            // 
            this.allAuthorsList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.allAuthorsList.FormattingEnabled = true;
            this.allAuthorsList.HorizontalScrollbar = true;
            this.allAuthorsList.Location = new System.Drawing.Point(3, 3);
            this.allAuthorsList.Name = "allAuthorsList";
            this.allAuthorsList.Size = new System.Drawing.Size(169, 194);
            this.allAuthorsList.TabIndex = 0;
            // 
            // btnAddAuthor
            // 
            this.btnAddAuthor.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnAddAuthor.Location = new System.Drawing.Point(50, 214);
            this.btnAddAuthor.Name = "btnAddAuthor";
            this.btnAddAuthor.Size = new System.Drawing.Size(75, 23);
            this.btnAddAuthor.TabIndex = 1;
            this.btnAddAuthor.Text = "<< Add";
            this.btnAddAuthor.UseVisualStyleBackColor = true;
            this.btnAddAuthor.Click += new System.EventHandler(this.btnAddAuthor_Click);
            // 
            // FileConfigForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(733, 595);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "FileConfigForm";
            this.Text = "File Info";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.fileInfoPanel.ResumeLayout(false);
            this.fileInfoPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fileThumb)).EndInit();
            this.tagManagementPanel.ResumeLayout(false);
            this.allTagsPanel.ResumeLayout(false);
            this.authorManagementPanel.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel fileInfoPanel;
        private System.Windows.Forms.Label fileNameLegend;
        private System.Windows.Forms.Label filePathLegend;
        private System.Windows.Forms.Label fileNameLabel;
        private System.Windows.Forms.Label filePathLabel;
        private System.Windows.Forms.PictureBox fileThumb;
        private System.Windows.Forms.TableLayoutPanel tagManagementPanel;
        private System.Windows.Forms.ListBox fileTagsList;
        private System.Windows.Forms.Button btnRemoveTag;
        private System.Windows.Forms.Button btnCreateTag;
        private System.Windows.Forms.TableLayoutPanel allTagsPanel;
        private System.Windows.Forms.ListBox allTagsList;
        private System.Windows.Forms.Button btnAddtag;
        private System.Windows.Forms.TableLayoutPanel authorManagementPanel;
        private System.Windows.Forms.ListBox fileAuthorsList;
        private System.Windows.Forms.Button btnRemoveAuthor;
        private System.Windows.Forms.Button btnCreateAuthor;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.ListBox allAuthorsList;
        private System.Windows.Forms.Button btnAddAuthor;
    }
}