using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LangPad
{
    static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm());

            // Once run is complete, clean up temp folder
            try
            {
                if (Directory.Exists(App.DataFolder))
                    Directory.Delete(App.DataFolder, true);
            }
            catch (Exception)
            {
                // Folder delete failed, but we still want
                // to close, so ignore it
            }
        }
    }
}
