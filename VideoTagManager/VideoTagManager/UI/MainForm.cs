using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VideoTagManager.Controller;

namespace VideoTagManager.UI {
    //5 rows
    //3 lines
    //14 per page
    public partial class MainForm : Form {
        private ReadingController reader;
        private WritingController writer;
        private SearchController searcher;

        public MainForm() {
            InitializeComponent();
            reader = new ReadingController();
            writer = new WritingController();
            //Read XML and initialize search engine
            searcher = new SearchController(reader.readAllFiles());
        }

        private void viewAllFilesToolStripMenuItem_Click(object sender, EventArgs e) {
            Panel p = new Panel();
            Label lbl = new Label();
            lbl.Text = "olaaaa";
            p.Controls.Add(lbl);
            tableLayoutPanel1.Controls.Add(p);
            Panel p1 = new Panel();
            Label lbl1 = new Label();
            lbl1.Text = "olaaaa";
            p1.Controls.Add(lbl1);
            tableLayoutPanel1.Controls.Add(p1);
        }

    }
}
