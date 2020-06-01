using System;
using System.IO;

namespace LangPadData
{
    /// <summary>
    /// Create a temp folder in the user's app data folder to extract *.nt and *.ntx
    /// notebooks into (which are really just ZIP files with a different extension),
    /// so that their contents can be read.
    /// </summary>
    public class TempFolder
    {
        /// <summary>
        /// The location of the app data folder.
        /// </summary>
        public static string AppDataFolder =
            Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);

        /// <summary>
        /// Create a new, unique folder in the app data folder that can be used
        /// for extracting data to.
        /// </summary>
        /// 
        /// <returns>The temp folder's path.</returns>
        public static string GetNewTempFolderRoot()
        {
            var tempFolder = string.Format("{0}\\notebook-{1}", TempFolder.AppDataFolder, Guid.NewGuid().ToString());
           
            if (Directory.Exists(tempFolder))
                Directory.Delete(tempFolder);

            Directory.CreateDirectory(tempFolder);

            return tempFolder;
        }
    }
}
