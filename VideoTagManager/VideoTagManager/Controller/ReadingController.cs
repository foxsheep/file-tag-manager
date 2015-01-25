using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VideoTagManager.FileIO;
using VideoTagManager.Model;

namespace VideoTagManager.Controller {
    public class ReadingController {

        private DataParser parser;

        public ReadingController() {
            parser = new DataParser();
        }

        public List<ManagedFile> readAllFiles() {
            return parser.readAll();
        }

    }
}
