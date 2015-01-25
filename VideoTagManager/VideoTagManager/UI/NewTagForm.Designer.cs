namespace VideoTagManager.UI {
    partial class NewTagForm {
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
            this.tagNameLbl = new System.Windows.Forms.Label();
            this.tagDescriptionLbl = new System.Windows.Forms.Label();
            this.tagNameTxt = new System.Windows.Forms.TextBox();
            this.tagDescriptionTxt = new System.Windows.Forms.TextBox();
            this.btnConfirm = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 36.42534F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 63.57466F));
            this.tableLayoutPanel1.Controls.Add(this.tagNameLbl, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tagDescriptionLbl, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.tagNameTxt, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.tagDescriptionTxt, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.btnConfirm, 1, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(449, 175);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // tagNameLbl
            // 
            this.tagNameLbl.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tagNameLbl.AutoSize = true;
            this.tagNameLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tagNameLbl.Location = new System.Drawing.Point(42, 20);
            this.tagNameLbl.Name = "tagNameLbl";
            this.tagNameLbl.Size = new System.Drawing.Size(78, 17);
            this.tagNameLbl.TabIndex = 0;
            this.tagNameLbl.Text = "Tag Name:";
            this.tagNameLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tagDescriptionLbl
            // 
            this.tagDescriptionLbl.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tagDescriptionLbl.AutoSize = true;
            this.tagDescriptionLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tagDescriptionLbl.Location = new System.Drawing.Point(25, 78);
            this.tagDescriptionLbl.Name = "tagDescriptionLbl";
            this.tagDescriptionLbl.Size = new System.Drawing.Size(112, 17);
            this.tagDescriptionLbl.TabIndex = 0;
            this.tagDescriptionLbl.Text = "Tag Description:";
            this.tagDescriptionLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tagNameTxt
            // 
            this.tagNameTxt.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tagNameTxt.Location = new System.Drawing.Point(166, 19);
            this.tagNameTxt.Name = "tagNameTxt";
            this.tagNameTxt.Size = new System.Drawing.Size(280, 20);
            this.tagNameTxt.TabIndex = 1;
            // 
            // tagDescriptionTxt
            // 
            this.tagDescriptionTxt.AcceptsReturn = true;
            this.tagDescriptionTxt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tagDescriptionTxt.Location = new System.Drawing.Point(166, 61);
            this.tagDescriptionTxt.Multiline = true;
            this.tagDescriptionTxt.Name = "tagDescriptionTxt";
            this.tagDescriptionTxt.Size = new System.Drawing.Size(280, 52);
            this.tagDescriptionTxt.TabIndex = 2;
            // 
            // btnConfirm
            // 
            this.btnConfirm.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnConfirm.Location = new System.Drawing.Point(268, 134);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(75, 23);
            this.btnConfirm.TabIndex = 3;
            this.btnConfirm.Text = "Confirm";
            this.btnConfirm.UseVisualStyleBackColor = true;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // NewTagForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(449, 175);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "NewTagForm";
            this.Text = "New Tag";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label tagNameLbl;
        private System.Windows.Forms.Label tagDescriptionLbl;
        private System.Windows.Forms.TextBox tagNameTxt;
        private System.Windows.Forms.TextBox tagDescriptionTxt;
        private System.Windows.Forms.Button btnConfirm;
    }
}