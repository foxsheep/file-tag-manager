namespace VideoTagManager.UI {
    partial class SearchForm {
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
            this.tagSearchLbl = new System.Windows.Forms.Label();
            this.authorSearchLbl = new System.Windows.Forms.Label();
            this.txtTags = new System.Windows.Forms.TextBox();
            this.txtAuthors = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 38.62213F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 61.37787F));
            this.tableLayoutPanel1.Controls.Add(this.tagSearchLbl, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.authorSearchLbl, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.txtTags, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.txtAuthors, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.btnSearch, 1, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(479, 130);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // tagSearchLbl
            // 
            this.tagSearchLbl.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tagSearchLbl.AutoSize = true;
            this.tagSearchLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tagSearchLbl.Location = new System.Drawing.Point(70, 13);
            this.tagSearchLbl.Name = "tagSearchLbl";
            this.tagSearchLbl.Size = new System.Drawing.Size(44, 17);
            this.tagSearchLbl.TabIndex = 0;
            this.tagSearchLbl.Text = "Tags:";
            // 
            // authorSearchLbl
            // 
            this.authorSearchLbl.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.authorSearchLbl.AutoSize = true;
            this.authorSearchLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.authorSearchLbl.Location = new System.Drawing.Point(62, 56);
            this.authorSearchLbl.Name = "authorSearchLbl";
            this.authorSearchLbl.Size = new System.Drawing.Size(61, 17);
            this.authorSearchLbl.TabIndex = 0;
            this.authorSearchLbl.Text = "Authors:";
            // 
            // txtTags
            // 
            this.txtTags.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtTags.Location = new System.Drawing.Point(188, 11);
            this.txtTags.Name = "txtTags";
            this.txtTags.Size = new System.Drawing.Size(288, 20);
            this.txtTags.TabIndex = 1;
            // 
            // txtAuthors
            // 
            this.txtAuthors.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtAuthors.Location = new System.Drawing.Point(188, 54);
            this.txtAuthors.Name = "txtAuthors";
            this.txtAuthors.ReadOnly = true;
            this.txtAuthors.Size = new System.Drawing.Size(288, 20);
            this.txtAuthors.TabIndex = 1;
            this.txtAuthors.Text = "Not implemented yet";
            // 
            // btnSearch
            // 
            this.btnSearch.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSearch.Location = new System.Drawing.Point(294, 96);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 2;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // SearchForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(479, 130);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "SearchForm";
            this.Text = "Search";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label tagSearchLbl;
        private System.Windows.Forms.Label authorSearchLbl;
        private System.Windows.Forms.TextBox txtTags;
        private System.Windows.Forms.TextBox txtAuthors;
        private System.Windows.Forms.Button btnSearch;
    }
}