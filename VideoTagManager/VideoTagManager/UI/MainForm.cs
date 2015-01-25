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
            currentIndex = 0;
            showFilesOnScreen();
        }

        private void showFilesOnScreen() {
            tableLayoutPanel1.Controls.Clear(); //Clear the files currently on screen
            filesOnScreen = 0;
            while (filesOnScreen < MAX_FILES_ON_SCREEN && currentIndex < filesToShow.Count()) {
                tableLayoutPanel1.Controls.Add(createFilePanel(filesToShow[currentIndex]));
                filesOnScreen++;
                currentIndex++;
            }

            //Make navigation buttons appear on the lower right corner
            if (filesOnScreen < MAX_FILES_ON_SCREEN) {
                for (int i = filesOnScreen; i < MAX_FILES_ON_SCREEN; i++) {
                    tableLayoutPanel1.Controls.Add(new Panel());
                }
            }
            tableLayoutPanel1.Controls.Add(navigationPanel);
        }

        //Creates a panel with the file thumbnail and it's title below. The tag references the file's path.
        private Control createFilePanel(ManagedFile managedFile) {
            TableLayoutPanel filePan = new TableLayoutPanel();
            filePan.ColumnCount = 1;
            filePan.RowCount = 2;
            filePan.RowStyles.Add(new RowStyle(SizeType.Percent, 60F)); //Thumbnail row
            filePan.RowStyles.Add(new RowStyle(SizeType.Percent, 40F)); //Title row
            filePan.Dock = DockStyle.Fill;

            //File thumbnail
            PictureBox p = new PictureBox();
            p.BackColor = Control.DefaultBackColor;
            p.Dock = DockStyle.Fill;
            p.SizeMode = PictureBoxSizeMode.Zoom;
            ShellFile shellFile = ShellFile.FromFilePath(managedFile.path);
            Bitmap shellThumb = shellFile.Thumbnail.ExtraLargeBitmap;
            shellThumb.Tag = managedFile.path; 
            shellThumb.MakeTransparent(Color.Black);
            p.Image = shellThumb;
            p.Tag = managedFile.path;
            filePan.Controls.Add(p);

            //Title of file
            Label titleLbl = new Label();
            titleLbl.Text = managedFile.name;
            titleLbl.Anchor = AnchorStyles.None;
            filePan.Controls.Add(titleLbl);
            titleLbl.Tag = managedFile.path;

            filePan.Tag = managedFile.path;

            //Create and attach click event handler
            EventHandler clickHandler = new EventHandler(filePanel_Click);
            filePan.Click += clickHandler;
            titleLbl.Click += clickHandler;
            p.Click += clickHandler;

            return filePan;
        }

        private void filePanel_Click(object sender, EventArgs e) {
            //Handles clicking on a file
            MouseEventArgs me = (MouseEventArgs) e;
            Control file = (Control) sender;
            //If cast was successeful
            if (file != null && me != null) {
                //File path is stored in Tag
                string controlTag = (string) file.Tag;
                if (me.Button == MouseButtons.Right) {
                    //TODO: Right click shows file config dialog
                    FileConfigForm configForm = new FileConfigForm(writer, searcher.getFileByPath(controlTag), searcher);
                    configForm.Show();
                } else if (me.Button == MouseButtons.Left) {
                    //Left click opens the file
                    System.Diagnostics.Process.Start(controlTag);
                }
            }
        }

        //On closing, ask the user if he wants to save changes
        protected override void OnFormClosing(FormClosingEventArgs e) {
            base.OnFormClosing(e);
            if (e.CloseReason == CloseReason.WindowsShutDown) return;
            // Confirm user wants to close
            switch (MessageBox.Show(this, "Save changes?", "Closing", MessageBoxButtons.YesNo)) {
                case DialogResult.Yes:
                    writer.writeFileList(searcher.allFiles());
                    break;
                default:
                    break;
            }       
        }

        //Delete XML and clear file panel
        private void deleteStoredDataToolStripMenuItem_Click(object sender, EventArgs e) {
            writer.deleteEverything();
            tableLayoutPanel1.Controls.Clear();
        }

        //Scans folder and overwrites the existing data
        private void exitToolStripMenuItem_Click(object sender, EventArgs e) {
            //BROKEN fix it later
            throw new NotImplementedException("Not implemented yet");

            //ImportFileForm form = new ImportFileForm();
            //form.ShowDialog();

            //string path = form.chosenPath;
            //try {
            //    writer.writeAll(path);
            //    Refresh();
            //} catch (Exception ex) {
            //    MessageBox.Show(ex.Message);
            //}
        }

        private void btnNext_Click(object sender, EventArgs e) {
            //If there's anything more to show
            if (currentIndex < filesToShow.Count()) {
                showFilesOnScreen();
            }
        }

        private void btnPrevious_Click(object sender, EventArgs e) {
            if (currentIndex > MAX_FILES_ON_SCREEN) {
                currentIndex -= (MAX_FILES_ON_SCREEN + filesOnScreen);
                showFilesOnScreen();
            }
        }

        //Show all untagged files
        private void viewUndefinedFilesToolStripMenuItem_Click(object sender, EventArgs e) {
            filesToShow = searcher.getUntaggedFiles();
            currentIndex = 0;
            showFilesOnScreen();
        }

        private void exportStoredDataToolStripMenuItem_Click(object sender, EventArgs e) {
            FolderBrowserDialog browser = new FolderBrowserDialog();
            browser.Description = "Please select destination folder";
            if (browser.ShowDialog() == System.Windows.Forms.DialogResult.OK) {
                writer.exportDataFile(browser.SelectedPath);
                MessageBox.Show("Data exported successefully");
            }
        }

        private void startSearchToolStripMenuItem_Click(object sender, EventArgs e) {
            //Start search form
            try {
                SearchForm newSearch = new SearchForm(this.searcher);
                if (newSearch.ShowDialog() == System.Windows.Forms.DialogResult.OK) {
                    filesToShow = newSearch.searchResult;
                    currentIndex = 0;
                    showFilesOnScreen();
                }
            } catch (ArgumentException ex) {
                MessageBox.Show(ex.Message);
            }
        }

        private void saveChangesToolStripMenuItem_Click(object sender, EventArgs e) {
            writer.writeFileList(searcher.allFiles());
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e) {
            MessageBox.Show("Coded by Gonçalo João Correia\n\nGoncaloJoaoCorreia@gmail.com\nhttps://github.com/GoncaloJoaoCorreia", "About");
        }

    }
}
