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
    public partial class FileConfigForm : Form {

        WritingController writer;
        ManagedFile file;
        SearchController searcher;
        public FileConfigForm(WritingController writer, ManagedFile file, SearchController searcher) {
            InitializeComponent();
            CenterToScreen();
            this.writer = writer;
            this.file = file;
            this.searcher = searcher;
            fileNameLabel.Text = file.name;
            filePathLabel.Text = file.path;
            makeThumbnail();
            initTagList();
            initAuthorList();
        }

        private void initTagList() {
            foreach (Tag tag in file.tags) {
                fileTagsList.Items.Add(tag.ToString());
            }
            foreach (Tag tag in searcher.getAllTags()) {
                allTagsList.Items.Add(tag.ToString());
            }
        }

        private void initAuthorList() {
            foreach (Author aut in file.authors) {
                fileAuthorsList.Items.Add(aut.ToString());
            }
            foreach (Author aut in searcher.getAllAuthors()) {
                allAuthorsList.Items.Add(aut.ToString());
            }
        }

        private void makeThumbnail() {
            Microsoft.WindowsAPICodePack.Shell.ShellFile shellFile = Microsoft.WindowsAPICodePack.Shell.ShellFile.FromFilePath(file.path);
            Bitmap shellThumb = shellFile.Thumbnail.ExtraLargeBitmap;
            shellThumb.MakeTransparent(Color.Black);
            fileThumb.Image = shellThumb;
        }

        private void btnRemoveTag_Click(object sender, EventArgs e) {
            if (fileTagsList.SelectedItem != null) {
                string toRemove = (string) fileTagsList.SelectedItem;
                fileTagsList.Items.Remove(toRemove);
                searcher.removeTagFromFile(toRemove, file.path);
            } 
        }

        private void btnAddtag_Click(object sender, EventArgs e) {
            if (allTagsList.SelectedItem != null) {
                string toAdd = (string) allTagsList.SelectedItem;
                fileTagsList.Items.Add(toAdd);
                searcher.addExistingTagToFile(toAdd, file.path);
            }
        }

        private void btnCreateTag_Click(object sender, EventArgs e) {
            NewTagForm newTag = new NewTagForm();
            var result = newTag.ShowDialog();
            if (result == System.Windows.Forms.DialogResult.OK) {
                searcher.addNewTagToFile(newTag.name, newTag.desc, file.path);
                fileTagsList.Items.Add(newTag.name);
                allTagsList.Items.Add(newTag.name);
            }
        }

        private void btnRemoveAuthor_Click(object sender, EventArgs e) {
            if (fileAuthorsList.SelectedItem != null) {
                string toRemove = (string) fileAuthorsList.SelectedItem;
                fileAuthorsList.Items.Remove(toRemove);
                searcher.removeAuthorFromFile(toRemove, file.path);
            }
        }

        private void btnAddAuthor_Click(object sender, EventArgs e) {
            if (allAuthorsList.SelectedItem != null) {
                string toAdd = (string) allAuthorsList.SelectedItem;
                fileAuthorsList.Items.Add(toAdd);
                searcher.addExistingAuthorToFile(toAdd, file.path);
            }
        }

        private void btnCreateAuthor_Click(object sender, EventArgs e) {
            NewTagForm newAut = new NewTagForm("Name:", "Comment:", "New Author");
            var result = newAut.ShowDialog();
            if (result == System.Windows.Forms.DialogResult.OK) {
                searcher.addNewAuthorToFile(newAut.name, newAut.desc, file.path);
                fileAuthorsList.Items.Add(newAut.name);
                allAuthorsList.Items.Add(newAut.name);
            }
        }

    }
}
