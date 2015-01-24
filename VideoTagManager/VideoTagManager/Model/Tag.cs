using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VideoTagManager.Model {

    /// <summary>
    /// Class that models a Tag used to classify a managed file
    /// </summary>
    class Tag {

        public string tag { get; set; }
        public string description { get; set; }

        public Tag() {
            this.tag = "";
            this.description = "";
        }

        public Tag(string tag) {
            this.tag = tag;
            this.description = "";
        }

        public Tag(string tag, string description) {
            this.tag = tag;
            this.description = description;
        }

        public override string ToString() {
            return this.tag;
        }

        public override bool Equals(object obj) {
            if (obj == null) return false;
            Tag objAsTag = obj as Tag;
            if (objAsTag == null) return false;
            else return (this.tag == objAsTag.tag);
        }
    }
}
