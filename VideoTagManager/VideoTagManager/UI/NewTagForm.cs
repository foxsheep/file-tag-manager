using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VideoTagManager.UI {
    public partial class NewTagForm : Form {

        public string name { get; set; }
        public string desc { get; set; }

        public NewTagForm() {
            InitializeComponent();
            CenterToScreen();
            name = "";
            desc = "";
        }

        public NewTagForm(string nameLblTxt, string descLblTxt, string windowTitle) {
            InitializeComponent();
            CenterToScreen();
            name = "";
            desc = "";
            tagDescriptionLbl.Text = descLblTxt;
            tagNameLbl.Text = nameLblTxt;
            this.Text = windowTitle;
        }

        private void btnConfirm_Click(object sender, EventArgs e) {
            name = tagNameTxt.Text;
            desc = tagDescriptionTxt.Text;
            if (String.IsNullOrEmpty(name)) {
                DialogResult = System.Windows.Forms.DialogResult.Cancel;
            } else {
                DialogResult = System.Windows.Forms.DialogResult.OK;
            }
            Close();
        }

    }
}
