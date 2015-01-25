using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VideoTagManager.Model {

    /// <summary>
    /// Class that models a file to be managed by the program
    /// </summary>
    public class ManagedFile {
        private const int MAX_RATING = 5;
        private const int MIN_RATING = 0;

        public string name { get; set; }
        public string path { get; set; }
        public List<Tag> tags;
        public List<Author> authors;

        private int mRating;
        public int rating {
            get {
                return this.mRating;
            }
            set {
                if (value < MIN_RATING || value > MAX_RATING) {

                    throw new ArgumentException(String.Format("Rating must be a value between %d and %d", MIN_RATING, MAX_RATING));
                } else {
                    this.mRating = value;
                }
            }
        }
        public string comment { get; set; }

        public ManagedFile() {
            this.name = "";
            this.path = "";
            this.tags = new List<Tag>();
            this.authors = new List<Author>();
            this.rating = 0;
            this.comment = "";
        }

        public ManagedFile(ManagedFile f) {
            this.name = f.name;
            this.path = f.path;
            this.tags = f.tags;
            this.authors = f.authors;
            this.rating = f.rating;
            this.comment = f.comment;
        }

        public ManagedFile(string name, string path) {
            this.name = name;
            this.path = path;
            this.tags = new List<Tag>();
            this.authors = new List<Author>();
            this.rating = 0;
            this.comment = "";
        }

        public ManagedFile(string name, string path, List<Tag> tags, List<Author> authors, int rating, string comment) {
            this.name = name;
            this.path = path;
            this.tags = tags;
            this.authors = authors;
            this.rating = rating;
            this.comment = comment;
        }

        public void addTag(Tag t) {
            if (!tags.Contains(t))
                tags.Add(t);
        }

        public void addAuthor(Author a) {
            authors.Add(a);
        }


        public void removeTag(string tag) {
            foreach (Tag t in tags) {
                if (t.tag == tag) {
                    tags.Remove(t);
                    break;
                }
            }
        }

        public bool isUntagged() {
            return (tags.Count == 0);
        }
    }
}
