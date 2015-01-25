using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VideoTagManager.Model;

namespace VideoTagManager.Controller {
    public class SearchController {

        private FileList files;

        public SearchController(List<ManagedFile> files) {
            this.files = new FileList(files);
        }

        public List<ManagedFile> allFiles() {
            return files.files;
        }

        public ManagedFile getFileByPath(string path) {
            return files.getFileByPath(path);
        }

        /// <summary>
        /// Gets all tags stored in all files.
        /// </summary>
        /// <returns>Tag list</returns>
        public List<Tag> getAllTags() {
            return files.allTags;
        }

        public void removeTagFromFile(string tag, string filePath) {
            files.removeTagFromFile(tag, filePath);
        }

        public void addExistingTagToFile(string tag, string filePath) {
            Tag toAdd = new Tag();
            foreach (Tag t in files.allTags) {
                if (t.tag == tag) {
                    toAdd = new Tag(t);
                    break;
                }
            }
            files.addTagToFile(toAdd, filePath);
        }

        public void addNewTagToFile(string tagName, string tagDescription, string filePath){
            Tag toAdd = new Tag(tagName, tagDescription);
            files.addTagToFile(toAdd, filePath);
        }

        public List<ManagedFile> getUntaggedFiles() {
            return files.getAllUntaggedFiles();
        }
    }
}
