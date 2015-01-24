using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VideoTagManager.Model;

namespace VideoTagManager.Controller {
    class SearchController {

        private FileList files;

        public SearchController(List<ManagedFile> files) {
            this.files = new FileList(files);
        }

        public List<ManagedFile> allFiles() {
            return files.files;
        }
    }
}
