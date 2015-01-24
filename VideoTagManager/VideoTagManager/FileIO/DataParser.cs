using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using VideoTagManager.Config;
using VideoTagManager.Model;

namespace VideoTagManager.FileIO {

    /// <summary>
    /// Class used to parse the XML data file and create all the managed files.
    /// </summary>
    class DataParser {

        public DataParser() {
        }

        public List<ManagedFile> readAll() {
            List<ManagedFile> list = new List<ManagedFile>();
            if (!dataFileExists()) {
                throw new FileNotFoundException("Data file not found.", Values.DATA_FILE_PATH);
            }
            XElement root = XElement.Load(Values.DATA_FILE_PATH);
            IEnumerable<XElement> files = root.Elements();
            foreach (XElement file in files) {
                string path = file.Element("path").Value;

                //If the file doesnt exist in the system, delete it
                if (!File.Exists(path)) {
                    file.Remove();
                    continue;
                }

                string name = file.Element("name").Value;
                int rating = int.Parse(file.Element("rating").Value);
                string comment = file.Element("comment").Value;
                List<Tag> tags = readTags(file);
                List<Author> authors = readAuthors(file);

                list.Add(new ManagedFile(name, path, tags, authors, rating, comment));
            }

            root.Save(Values.DATA_FILE_PATH);
            return list;
        }

        private List<Author> readAuthors(XElement file) {
            List<Author> authors = new List<Author>();
            XElement autElem = file.Element("authors");
            IEnumerable<XElement> autorinos = autElem.Elements();
            foreach (XElement tag in autorinos) {
                string name = tag.Element("name").Value;
                string comment = tag.Element("comment").Value;
                authors.Add(new Author(name, comment));
            }
            return authors;
        }

        private List<Tag> readTags(XElement file) {
            List<Tag> tags = new List<Tag>();
            XElement tagElem = file.Element("tags");
            IEnumerable<XElement> tagerinos = tagElem.Elements();
            foreach (XElement tag in tagerinos) {
                string t = tag.Element("tag").Value;
                string desc = tag.Element("description").Value;
                tags.Add(new Tag(t, desc));
            }
            return tags;
        }

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
