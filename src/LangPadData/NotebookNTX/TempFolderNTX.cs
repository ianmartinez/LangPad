using System;
using System.IO;

namespace LangPadData.NotebookNTX
{
    public class TempFolderNTX
    {
        public readonly string RootFolder;
        public readonly string PagesFolder;
        public readonly string DataFile;
        public readonly string PagesFile;
        public readonly string InfoFile;
        public readonly string CharactersFile;
        public readonly string DictionaryFile;
        public readonly string StylesheetFile;

        public TempFolderNTX()
        {
            RootFolder = TempFolder.GetNewTempFolderRoot();

            PagesFolder = string.Format("{0}\\pages", RootFolder);
            Directory.CreateDirectory(PagesFolder);
            DataFile = string.Format("{0}\\data.txt", RootFolder);
            PagesFile = string.Format("{0}\\pages.txt", RootFolder);
            InfoFile = string.Format("{0}\\info.txt", RootFolder);
            CharactersFile = string.Format("{0}\\characters.txt", RootFolder);
            DictionaryFile = string.Format("{0}\\dictionary.txt", RootFolder);
            StylesheetFile = string.Format("{0}\\style.css", RootFolder);
        }

        public string GetPagePath(int pageIndex)
        {
            return string.Format("{0}\\{1}.html", PagesFolder, pageIndex.ToString());
        }
    }
}
