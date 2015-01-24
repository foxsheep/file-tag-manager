using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VideoTagManager.Model {

    /// <summary>
    /// Class that models a file's author
    /// </summary>
    class Author {

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

        public override string ToString() {
            return this.name;
        }
    }
}
