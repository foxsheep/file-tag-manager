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

        public FileList() {
            files = new List<ManagedFile>();
        }

        public FileList(List<ManagedFile> files) {
            this.files = files;
        }
    }
}
