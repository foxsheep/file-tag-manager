using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;
using VideoTagManager.Config;
using VideoTagManager.Model;

namespace VideoTagManager.FileIO {
    /// <summary>
    /// Class that manages writing to the XML file that stores all the video information
    /// </summary>
    class DataWriter {
        private XmlNode rootNode;
        private XmlDocument doc;
        public DataWriter() { }

        /// <summary>
        /// Writes file info into the XML file.
        /// </summary>
        /// <param name="files">List of the files in the folder</param>
        public void writeFiles(List<ManagedFile> files) {
            doc = new XmlDocument();
            checkFileExistence();
            doc.Load(Values.DATA_FILE_PATH);
            rootNode = doc.DocumentElement;

            foreach (ManagedFile file in files) {
                writeFile(file);
            }

            doc.Save(Values.DATA_FILE_PATH);
        }

        /// <summary>
        /// Writes a file's info.
        /// </summary>
        /// <param name="file">File to write</param>
        /// <param name="root">Root node of the XML document</param>
        private void writeFile(ManagedFile file) {
            XmlNode fNode = doc.CreateElement("file");

            fNode.InnerText = file.name;

            XmlNode fPath = doc.CreateElement("path");
            fNode.InnerText = file.path;
            fNode.AppendChild(fPath);

            XmlNode fRating = doc.CreateElement("rating");
            fRating.InnerText = file.rating.ToString();
            fNode.AppendChild(fRating);

            XmlNode fComment = doc.CreateElement("comment");
            fComment.InnerText = file.comment;
            fNode.AppendChild(fComment);

            fNode.AppendChild(createTagNode(file.tags));
            fNode.AppendChild(createAuthorNode(file.authors));

            rootNode.AppendChild(fNode);
        }

        /// <summary>
        /// Creates a node with all the authors
        /// </summary>
        /// <param name="list">List of Authors</param>
        /// <returns>Node with all the authors</returns>
        private XmlNode createAuthorNode(List<Author> list) {
            XmlNode authorNode = doc.CreateElement("authors");
            foreach (Author t in list) {
                XmlNode a = doc.CreateElement("author");
                a.InnerText = t.name;
                XmlNode aComment = doc.CreateElement("comment");
                aComment.InnerText = t.comment;
                a.AppendChild(aComment);

                authorNode.AppendChild(a);
            }
            return authorNode;
        }

        /// <summary>
        /// Creates a node with all the Tags
        /// </summary>
        /// <param name="list">Tag list</param>
        /// <returns>Node with all the Tags</returns>
        private XmlNode createTagNode(List<Tag> list) {
            XmlNode tagNode = doc.CreateElement("tags");
            foreach (Tag t in list) {
                XmlNode node = doc.CreateElement("tag");
                node.InnerText = t.tag;
                XmlNode tDescription = doc.CreateElement("description");
                tDescription.InnerText = t.description;
                node.AppendChild(tDescription);

                tagNode.AppendChild(node);
            }
            return tagNode;
        }


        /// <summary>
        /// Checks if the data file exists. If not, creates a new file with an empty node.
        /// </summary>
        private static void checkFileExistence() {
            if (!DataParser.dataFileExists()) {
                XmlWriter writer = XmlWriter.Create(Values.DATA_FILE_PATH);
                writer.WriteStartDocument();
                writer.WriteStartElement("files");
                writer.WriteEndDocument();
                writer.Close();
            }
        }
    }
}
