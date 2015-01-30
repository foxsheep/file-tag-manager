using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VideoTagManager.Model {

    /// <summary>
    /// Class that models a file's author
    /// </summary>
    public class Author {
        public string name { get; set; }
        public string comment { get; set; }

        public Author(string name) {
            this.name = name;
            this.comment = "";
        }

        public Author() {
            this.name = "";
            this.comment = "";
        }

        public Author(string name, string comment) {
            this.name = name;
            this.comment = comment;
        }

        public Author(Author a) {
            this.name = a.name;
            this.comment = a.comment;
        }

        public override string ToString() {
            return this.name;
        }

        public override bool Equals(object obj) {
            if (obj == null) return false;
            Author objAsAut = obj as Author;
            if (objAsAut == null) return false;
            else return (this.name == objAsAut.name);
        }

        public override int GetHashCode() {
            char[] name = this.name.ToCharArray();
            int hash = 0;
            for (int i = 0; i < name.Count(); i++) {
                hash += (int) Char.GetNumericValue(name[i]);
            }
            return hash;
        }
    }
}
