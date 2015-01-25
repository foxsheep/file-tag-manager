using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VideoTagManager.Controller;
using VideoTagManager.Model;

namespace VideoTagManager.UI {
    public partial class SearchForm : Form {

        private static char[] STATEMENT_SEPARATOR = new char[] { '+' };
        private static char[] TAG_SEPARATOR = new char[] { ',' };

        private SearchController searcher;
        public List<ManagedFile> searchResult;

        public SearchForm(SearchController searcher) {
            InitializeComponent();
            CenterToScreen();
            this.searcher = searcher;
            searchResult = new List<ManagedFile>();
        }

        private void btnSearch_Click(object sender, EventArgs e) {
            string tagSearch = txtTags.Text;
            bool and = tagSearch.Contains(STATEMENT_SEPARATOR[0]);
            bool or = tagSearch.Contains(TAG_SEPARATOR[0]);
            if (or && and)
                throw new ArgumentException("Search terms incorrectly formatted");
            if (!or && !and) {
                searchResult = searcher.getFilesWithTags(tagSearch);
            } else {
                if (or) {
                    searchResult = searcher.getFilesWithTags(tagSearch.Split(TAG_SEPARATOR));
                } else if (and) {
                    searchResult = searcher.getFilesWithAllTags(tagSearch.Split(STATEMENT_SEPARATOR));
                }
            }
            DialogResult = System.Windows.Forms.DialogResult.OK;
            Close();
        }

    }
}
