using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Linq;
using System.Xml.Serialization;
using VideoTagManager.Config;
using VideoTagManager.Model;

namespace VideoTagManager.FileIO {
    /// <summary>
    /// Class that manages writing to the XML file that stores all the video information
    /// </summary>
    class DataWriter {
        private XElement root;

        public DataWriter() { }

        /// <summary>
        /// Writes file info into the XML file.
        /// </summary>
        /// <param name="files">List of the files in the folder</param>
        public void writeFiles(List<ManagedFile> files) {
            checkFileExistence();
            root = XElement.Load(Values.DATA_FILE_PATH);
            //xelement.Add(new XElement("file", "hello"));
            //xelement.Add(new XElement("file", "yolo"));

            foreach (ManagedFile file in files) {
                writeFile(file);
            }

            root.Save(Values.DATA_FILE_PATH);
        }

        /// <summary>
        /// Writes a file's info.
        /// </summary>
        /// <param name="file">File to write</param>
        /// <param name="root">Root node of the XML document</param>
        private void writeFile(ManagedFile file) {
            XElement fileNode = new XElement("file");
            fileNode.Add(new XElement("name", file.name));
            fileNode.Add(new XElement("path", file.path));
            fileNode.Add(createTagNode(file.tags));
            fileNode.Add(createAuthorNode(file.authors));
            fileNode.Add(new XElement("rating", file.rating));
            fileNode.Add(new XElement("comment", file.comment));

            root.Add(fileNode);
        }

        /// <summary>
        /// Creates a node with all the authors
        /// </summary>
        /// <param name="list">List of Authors</param>
        /// <returns>Node with all the authors</returns>
        private XElement createAuthorNode(List<Author> list) {
            XElement authors = new XElement("authors");

            foreach (Author a in list) {
                XElement ele = new XElement("author");
                ele.Add(new XElement("name", a.name));
                ele.Add(new XElement("comment", a.comment));
                authors.Add(ele);
            }

            return authors;
        }

        /// <summary>
        /// Creates a node with all the Tags
        /// </summary>
        /// <param name="list">Tag list</param>
        /// <returns>Node with all the Tags</returns>
        private XElement createTagNode(List<Tag> list) {
            XElement tags = new XElement("tags");

            foreach (Tag t in list) {
                XElement ele = new XElement("tag");
                ele.Add(new XElement("tag", t.tag));
                ele.Add(new XElement("description", t.description));
                tags.Add(ele);
            }

            return tags;
        }


        /// <summary>
        /// Checks if the data file exists. If not, creates a new file with an empty node.
        /// If it does, delete it and overwrite with new file.
        /// </summary>
        private static void checkFileExistence() {
            deleteFile();

            XmlWriter writer = XmlWriter.Create(Values.DATA_FILE_PATH);
            writer.WriteStartDocument();
            writer.WriteStartElement("files");
            writer.WriteEndDocument();
            writer.Close();
        }

        /// <summary>
        /// Duh.
        /// </summary>
        public void deleteEverything() {
            deleteFile();
        }

        /// <summary>
        /// If file exists, delete it.
        /// </summary>
        private static void deleteFile() {
            if (DataParser.dataFileExists()) {
                File.Delete(Values.DATA_FILE_PATH);
            }
        }

        public void copyTo(string destinationDir) {
            StringBuilder s = new StringBuilder();
            s.Append(destinationDir);
            s.Append(Path.DirectorySeparatorChar);
            s.Append(Values.DATA_FILE_NAME);

            File.Copy(Values.DATA_FILE_PATH, s.ToString());
        }
    }
}
