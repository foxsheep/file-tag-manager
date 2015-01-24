using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VideoTagManager.Model {

    /// <summary>
    /// Class that stores the files the program works with.
    /// </summary>
    class FileList{

        public List<ManagedFile> files;
        public List<Tag> allTags;
        public List<Author> allAuthors;

        public FileList() {
            files = new List<ManagedFile>();
        }

        public FileList(List<ManagedFile> files) {
            this.files = files;
            initializeLists();
        }

        private void initializeLists() {
            foreach (ManagedFile file in files) {
                foreach (Tag tag in file.tags) {
                    if (!allTags.Contains(tag)) {
                        allTags.Add(tag);
                    }
                }
                foreach (Author aut in file.authors) {
                    if (!allAuthors.Contains(aut)) {
                        allAuthors.Add(aut);
                    }
                }
            }
        }
    }
}
