using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace NotebookFile
{
    public class TempFolder
    {
        public static string AppDataFolder =
            Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);

        public readonly string RootFolder;
        public readonly string PagesFolder;
        public readonly string DataFile;
        public readonly string InfoFile;
        public readonly string CharactersFile;
        public readonly string DictionaryFile;
        public readonly string StylesheetFile;

        public TempFolder()
        {
            RootFolder = GetNewTempFolderRoot();

            if (Directory.Exists(RootFolder))
                Directory.Delete(RootFolder, true);

            Directory.CreateDirectory(RootFolder);

            PagesFolder = string.Format("{0}\\pages", RootFolder);
            DataFile = string.Format("{0}\\data.txt", RootFolder);
            InfoFile = string.Format("{0}\\info.txt", RootFolder);
            CharactersFile = string.Format("{0}\\characters.txt", RootFolder);
            DictionaryFile = string.Format("{0}\\dictionary.txt", RootFolder);
            StylesheetFile = string.Format("{0}\\style.css", RootFolder);
        }

        public static string GetNewTempFolderRoot()
        {
            return string.Format("{0}\\notebook-{1}", AppDataFolder, Guid.NewGuid().ToString());
        }

        public string GetPagePath(int pageIndex)
        {
            return string.Format("{0}\\{1}.html", PagesFolder, pageIndex.ToString());
        }
    }
}
