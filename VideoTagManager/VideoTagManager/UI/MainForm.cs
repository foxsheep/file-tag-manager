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
using VideoTagManager.Model;

namespace VideoTagManager.UI {
    //5 rows
    //3 lines
    //14 per page
    public partial class MainForm : Form {
        private ReadingController reader;
        private WritingController writer;
        private SearchController searcher;

        private List<ManagedFile> filesToShow;
        private int currentIndex;

        private const int MAX_FILES_ON_SCREEN = 14;

        public MainForm() {
            InitializeComponent();
            reader = new ReadingController();
            writer = new WritingController();
            //Read XML and initialize search engine
            searcher = new SearchController(reader.readAllFiles());
            //Empty list
            filesToShow = new List<ManagedFile>();
            currentIndex = 0;
        }

        private void viewAllFilesToolStripMenuItem_Click(object sender, EventArgs e) {
            filesToShow = searcher.allFiles();
            currentIndex = 0;
            tableLayoutPanel1.Controls.Clear(); //Clear the files currently on screen
            int filesOnScreen = 0;
            while (filesOnScreen < MAX_FILES_ON_SCREEN && currentIndex < filesToShow.Count()) {
                tableLayoutPanel1.Controls.Add(createFilePanel(filesToShow[currentIndex]));
            }
        }

        private Control createFilePanel(ManagedFile managedFile) {
            TableLayoutPanel filePan = new TableLayoutPanel();
            filePan.ColumnCount = 1;
            filePan.RowCount = 2;
            filePan.RowStyles.Add(new RowStyle(SizeType.Percent, 60F)); //Thumbnail row
            filePan.RowStyles.Add(new RowStyle(SizeType.Percent, 40F)); //Title row
            filePan.Dock = DockStyle.Fill;

            Panel p = new Panel();
            filePan.Controls.Add(p);

            Label titleLbl = new Label();
            titleLbl.Text = managedFile.name;
            filePan.Controls.Add(titleLbl);

            return filePan;
        }

    }
}
