using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VideoTagManager.FileIO;
using VideoTagManager.Model;

namespace VideoTagManager.Controller {
    class WritingController {

        private List<ManagedFile> filesToWrite;
        private DataWriter writer;

        public WritingController() {
            filesToWrite = new List<ManagedFile>();
            writer = new DataWriter();

        }

        /// <summary>
        /// Writes to the data file all the files in a given path.
        /// </summary>
        /// <param name="pathToSearch">Path of the main folder</param>
        public void writeAll(string pathToSearch) {
            filesToWrite = VideoTagManager.FileIO.FileFinder.getAllFilesFromDirectory(pathToSearch);
            if (filesToWrite.Count() == 0) {
                throw new ArgumentNullException("filesToWrite", "No files found in the chosen folder");
            }
            writer.writeFiles(filesToWrite);
            filesToWrite.Clear();
        }
    }
}
