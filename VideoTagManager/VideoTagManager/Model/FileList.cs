using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VideoTagManager.Model {

    /// <summary>
    /// Class that stores the files the program works with.
    /// </summary>
    public class FileList{

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
            allTags = new List<Tag>();
            allAuthors = new List<Author>();
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

        /// <summary>
        /// Searches all the files in memory for a corresponding path.
        /// </summary>
        /// <param name="path">Path of the file</param>
        /// <returns>The file with the right path if it exists, null otherwise</returns>
        public ManagedFile getFileByPath(string path) {
            foreach(ManagedFile file in files){
                if (file.path == path) return file;
            }
            return null;
        }

        /// <summary>
        /// Gets all tags stored in all files.
        /// </summary>
        /// <returns>Tag list</returns>
        public List<Tag> getAllTags() {
            return allTags;
        }

        public void removeTagFromFile(string tag, string filePath) {
            foreach (ManagedFile file in files) {
                if (file.path == filePath) {
                    file.removeTag(tag);
                    break; //Probably bad practice but idgaf
                }
            }
        }

        public void addTagToFile(Tag tag, string filePath) {
            foreach (ManagedFile file in files) {
                if (file.path == filePath) {
                    file.addTag(tag);
                    if (!allTags.Contains(tag)) {
                        allTags.Add(tag);
                    }
                    break;
                }
            }
        }

        public List<ManagedFile> getAllUntaggedFiles() {
            List<ManagedFile> untagged = new List<ManagedFile>();
            foreach (ManagedFile f in files) {
                if (f.isUntagged()) {
                    untagged.Add(f);
                }
            }
            return untagged;
        }

        /// <summary>
        /// Finds all files with at least one of the wanted tags
        /// </summary>
        /// <param name="tags">List of tags to search</param>
        /// <returns>List of files</returns>
        public List<ManagedFile> getFilesWithTags(string[] tags) {
            List<ManagedFile> result = new List<ManagedFile>();
            foreach (ManagedFile file in files) {
                foreach (string tag in tags) {
                    if (file.hasTag(tag)) {
                        result.Add(file);
                        break;
                    }
                }
            }
            return result;
        }

        /// <summary>
        /// Finds all files with all of the wanted tags.
        /// </summary>
        /// <param name="tags">List of the wanted tags</param>
        /// <returns>List of files</returns>
        public List<ManagedFile> getFilesWithAllTags(string[] tags) {
            List<ManagedFile> result = new List<ManagedFile>();

            foreach (ManagedFile file in files) {
                if (file.hasTags(tags)) result.Add(file);
            }

            return result;
        }

        /// <summary>
        /// Finds all files with selected tag
        /// </summary>
        /// <param name="tag">Tag</param>
        /// <returns>List of files</returns>
        public List<ManagedFile> getFilesWithTag(string tag) {
            List<ManagedFile> result = new List<ManagedFile>();

            foreach (ManagedFile file in files) {
                if (file.hasTag(tag)) result.Add(file);
            }

            return result;
        }
    }
}
