namespace VideoTagManager.UI {
    partial class HowToForm {
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
            this.howToPictureBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.howToPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // howToPictureBox
            // 
            this.howToPictureBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.howToPictureBox.Image = global::VideoTagManager.Properties.Resources.IMG_HowToUse;
            this.howToPictureBox.Location = new System.Drawing.Point(0, 0);
            this.howToPictureBox.Name = "howToPictureBox";
            this.howToPictureBox.Size = new System.Drawing.Size(799, 612);
            this.howToPictureBox.TabIndex = 0;
            this.howToPictureBox.TabStop = false;
            // 
            // HowToForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(799, 612);
            this.Controls.Add(this.howToPictureBox);
            this.Name = "HowToForm";
            this.Text = "How to use";
            ((System.ComponentModel.ISupportInitialize)(this.howToPictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox howToPictureBox;
    }
}