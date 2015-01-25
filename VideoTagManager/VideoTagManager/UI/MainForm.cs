using Microsoft.WindowsAPICodePack.Shell;
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
        private int filesOnScreen;

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
            filesOnScreen = 0;
        }

        private void viewAllFilesToolStripMenuItem_Click(object sender, EventArgs e) {
            filesToShow = searcher.allFiles();
            showFilesOnScreen();
        }

        private void showFilesOnScreen() {
            currentIndex = 0;
            tableLayoutPanel1.Controls.Clear(); //Clear the files currently on screen
            filesOnScreen = 0;
            while (filesOnScreen < MAX_FILES_ON_SCREEN && currentIndex < filesToShow.Count()) {
                tableLayoutPanel1.Controls.Add(createFilePanel(filesToShow[currentIndex]));
                filesOnScreen++;
                currentIndex++;
            }
        }

        /// <summary>
        /// Creates a panel with the file thumbnail and it's title below
        /// </summary>
        /// <param name="managedFile">The file</param>
        /// <returns>A panel</returns>
        private Control createFilePanel(ManagedFile managedFile) {
            TableLayoutPanel filePan = new TableLayoutPanel();
            filePan.ColumnCount = 1;
            filePan.RowCount = 2;
            filePan.RowStyles.Add(new RowStyle(SizeType.Percent, 60F)); //Thumbnail row
            filePan.RowStyles.Add(new RowStyle(SizeType.Percent, 40F)); //Title row
            filePan.Dock = DockStyle.Fill;

            //Thumbnail panel : TODO
            PictureBox p = new PictureBox();
            p.BackColor = Control.DefaultBackColor;
            p.Dock = DockStyle.Fill;
            p.SizeMode = PictureBoxSizeMode.Zoom;
            ShellFile shellFile = ShellFile.FromFilePath(managedFile.path);
            Bitmap shellThumb = shellFile.Thumbnail.ExtraLargeBitmap;
            shellThumb.MakeTransparent(Color.Black);
            p.Image = shellThumb;
            filePan.Controls.Add(p);

            //Title of file
            Label titleLbl = new Label();
            titleLbl.Text = managedFile.name;
            titleLbl.Anchor = AnchorStyles.None;
            filePan.Controls.Add(titleLbl);

            return filePan;
        }

    }
}
