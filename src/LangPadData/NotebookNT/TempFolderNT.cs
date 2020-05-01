using System.IO;

namespace LangPadData.NotebookNT
{
    public class TempFolderNT
    {
        public readonly string RootFolder;
        public readonly string PagesFolder;
        public readonly string DataFile;
        public readonly string InfoFile;
        public readonly string CustomSymbolsFile;
        public readonly string DictionaryFile;

        public TempFolderNT()
        {
            RootFolder = TempFolder.GetNewTempFolderRoot();

            if (Directory.Exists(RootFolder))
                Directory.Delete(RootFolder, true);

            Directory.CreateDirectory(RootFolder);

            PagesFolder = string.Format("{0}\\pages", RootFolder);
            DataFile = string.Format("{0}\\data.txt", RootFolder);
            InfoFile = string.Format("{0}\\info.txt", RootFolder);
            CustomSymbolsFile = string.Format("{0}\\custom_symbols.txt", RootFolder);
            DictionaryFile = string.Format("{0}\\dictionary.txt", RootFolder);
        }

        public string GetPagePath(int pageIndex)
        {
            return string.Format("{0}\\{1}.html", PagesFolder, pageIndex.ToString());
        }
    }
}
