using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VideoTagManager.Model {

    /// <summary>
    /// Class that models a Tag used to classify a managed file
    /// </summary>
    public class Tag {

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

        public Tag(Tag other) {
            this.tag = other.tag;
            this.description = other.description;
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

        public override int GetHashCode() {
            char[] tag = this.tag.ToCharArray();
            int hash = 0;
            for (int i = 0; i < tag.Count(); i++) {
                hash += (int) Char.GetNumericValue(tag[i]);
            }
            return hash;
        }
    }
}
