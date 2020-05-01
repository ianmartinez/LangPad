using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace LangPadData
{
    public class TempFolder
    {
        public static string AppDataFolder =
            Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);

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
