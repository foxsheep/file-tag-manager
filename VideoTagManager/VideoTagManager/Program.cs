using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using VideoTagManager.FileIO;
using VideoTagManager.UI;

namespace VideoTagManager {
    static class Program {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main() {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            if (VideoTagManager.FileIO.DataParser.dataFileExists()) {
                init();
            } else {
                ImportFileForm form = new ImportFileForm();
                form.ShowDialog();

                string path = form.chosenPath;
                VideoTagManager.Controller.WritingController c = new VideoTagManager.Controller.WritingController();
                try {
                    c.writeAll(path);
                    init();
                } catch (Exception ex) {
                    MessageBox.Show(ex.Message);
                }
                
            }
            //Application.Run(new Form1());
        }

        static void init() {
            Application.Run(new MainForm());
        }
    }
}
