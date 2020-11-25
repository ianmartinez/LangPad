using System;
using System.IO;

namespace LangPadData
{
    public enum TempFolderType
    {
        Notebook,
        AppData
    }

    /// <summary>
    /// Create a temp folder in the user's app data folder to extract notebooks 
    /// into (which are really just ZIP files with a different extension),
    /// so that their contents can be read.
    /// </summary>
    public static class TempFolder
    {
        /// <summary>
        /// The location of the app data folder.
        /// </summary>
        public static string AppDataFolder =>
            Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);

        /// <summary>
        /// Create a new, unique folder in the app data folder that can be used
        /// for extracting data to.
        /// </summary>
        /// 
        /// <returns>The temp folder's path.</returns>
        public static string GetNewTempFolderRoot(TempFolderType folderType = TempFolderType.Notebook)
        {
            var tempFolder = string.Format("{0}\\LangPad\\{1}-{2}", AppDataFolder, Enum.GetName(folderType), Guid.NewGuid().ToString());

            if (Directory.Exists(tempFolder))
                Directory.Delete(tempFolder);

            Directory.CreateDirectory(tempFolder);

            return tempFolder;
        }
    }
}
