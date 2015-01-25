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
            this.writer = writer;
            this.file = file;
            this.searcher = searcher;
            fileNameLabel.Text = file.name;
            filePathLabel.Text = file.path;
            makeThumbnail();
            initTagList();
        }

        private void initTagList() {
            foreach (Tag tag in file.tags) {
                fileTagsList.Items.Add(tag.ToString());
            }
            foreach (Tag tag in searcher.getAllTags()) {
                allTagsList.Items.Add(tag.ToString());
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
                searcher.addNewTagToFile(newTag.tagName, newTag.tagDesc, file.path);
                fileTagsList.Items.Add(newTag.tagName);
                allTagsList.Items.Add(newTag.tagName);
            }
        }

    }
}
