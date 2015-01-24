using System;
using System.IO;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VideoTagManager.Model;
using System.Windows.Forms;


namespace VideoTagManager.FileIO {
    /// <summary>
    /// Class used to find and store all the files in a directory
    /// </summary>
    static class FileFinder {


        /// <summary>
        /// Recursive method to find all the files in a given directory, including subfolders.
        /// </summary>
        /// <param name="dirPath">Directory to search</param>
        /// <returns>An ArrayList with all the Files</returns>
        public static List<ManagedFile> getAllFilesFromDirectory(string dirPath){
            List<ManagedFile> foundFiles = new List<ManagedFile>();
            try {
                foreach (string f in Directory.GetFiles(dirPath)) {
                    foundFiles.Add(makeFileFromPath(f));
                }

                foreach (string d in Directory.GetDirectories(dirPath)) {
                    foundFiles.AddRange(getAllFilesFromDirectory(d));
                }
            } catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }

            return foundFiles;
        }

        /// <summary>
        /// Creates a new ManagedFile with a human-readable name
        /// </summary>
        /// <param name="path">Path to the file</param>
        /// <returns>ManagedFile object with correct title and path</returns>
        private static ManagedFile makeFileFromPath(string path) {
            path = path.Trim();
            string[] strings = path.Split(new Char[] {Path.DirectorySeparatorChar});
            //Gets the file name without the extension
            string name = strings.Last().Split(new Char[]{'.'}).First(); 

            return new ManagedFile(name, path);
        }
    }
}
