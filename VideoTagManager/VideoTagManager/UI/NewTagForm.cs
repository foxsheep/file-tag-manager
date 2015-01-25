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

        public string tagName { get; set; }
        public string tagDesc { get; set; }

        public NewTagForm() {
            InitializeComponent();
            tagName = "";
            tagDesc = "";
        }

        private void btnConfirm_Click(object sender, EventArgs e) {
            tagName = tagNameTxt.Text;
            tagDesc = tagDescriptionTxt.Text;
            if (String.IsNullOrEmpty(tagName)) {
                DialogResult = System.Windows.Forms.DialogResult.Cancel;
            } else {
                DialogResult = System.Windows.Forms.DialogResult.OK;
            }
            Close();
        }

    }
}
