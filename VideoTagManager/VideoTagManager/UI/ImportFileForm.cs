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
    /// <summary>
    /// Form used to ask the user for a folder to import.
    /// </summary>
    public partial class ImportFileForm : Form {
        public string chosenPath;

        public ImportFileForm() {
            chosenPath = "";
            InitializeComponent();
            CenterToScreen();
        }

        private void button1_Click(object sender, EventArgs e) {
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK) {
                chosenPath = folderBrowserDialog1.SelectedPath;
                Close();
            }
        }

    }
}
