using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VideoTagManager.Config;

namespace VideoTagManager.FileIO {

    /// <summary>
    /// Class used to parse the XML data file and create all the managed files.
    /// </summary>
    static class DataParser {

        /// <summary>
        /// Checks if the data file exists.
        /// </summary>
        /// <returns>True if it exists, false otherwise</returns>
        public static bool dataFileExists() {
            if (File.Exists(Values.DATA_FILE_PATH)) {
                return true;
            } else {
                return false;
            }
        }
    }
}
