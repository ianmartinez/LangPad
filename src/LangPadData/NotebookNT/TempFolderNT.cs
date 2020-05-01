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

        public TempFolderNT(bool createSubdirs)
        {
            RootFolder = TempFolder.GetNewTempFolderRoot();

            PagesFolder = Path.Combine(RootFolder, "pages");
            if (createSubdirs)
                Directory.CreateDirectory(PagesFolder);
            DataFile = Path.Combine(RootFolder, "data.txt");
            InfoFile = Path.Combine(RootFolder, "info.txt");
            CustomSymbolsFile = Path.Combine(RootFolder, "custom_symbols.txt");
            DictionaryFile = Path.Combine(RootFolder, "dictionary.txt");
        }

        /// <summary>
        /// The new method of storing pages.
        /// </summary>
        /// 
        /// <param name="pageIndex">The index of the page in the notebook.</param>
        /// 
        /// <returns>The path to the page.</returns>
        public string GetPagePath(int pageIndex)
        {
            return Path.Combine(PagesFolder, pageIndex.ToString() + ".rtf");
        }


        /// <summary>
        /// The old method of storing pages.
        /// </summary>
        /// 
        /// <param name="pageTitle">The title of the page.</param>
        /// 
        /// <returns>The path to the page.</returns>
        public string GetPagePath(string pageTitle)
        {
            return Path.Combine(PagesFolder, pageTitle + ".rtf");
        }
    }
}
