using System.IO;

namespace LangPadData.NotebookNT;

/// <summary>
/// Create a temp folder for opening/saving files in the
/// NT 1.x-2.x file format (*.nt).
/// </summary>
public class TempFolderNT
{
    /// <summary>
    /// The root folder of the file.
    /// </summary>
    public readonly string RootFolder;

    /// <summary>
    /// The folder storing the notebook pages.
    /// </summary>
    public readonly string PagesFolder;

    /// <summary>
    /// The data.txt file.
    /// </summary>
    public readonly string DataFile;

    /// <summary>
    /// The info.txt file.
    /// </summary>
    public readonly string InfoFile;

    /// <summary>
    /// The custom_symbols.txt file.
    /// </summary>
    public readonly string CharactersFile;

    /// <summary>
    /// The dictionary file.
    /// </summary>
    public readonly string DictionaryFile;

    /// <summary>
    /// Create a new temp folder with a random GUID.
    /// </summary>
    /// 
    /// <param name="createSubdirs">If the subdirectories should be created.</param>
    public TempFolderNT(bool createSubdirs)
    {
        RootFolder = TempFolder.GetNewTempFolderRoot();
        PagesFolder = Path.Combine(RootFolder, "pages");
        if (createSubdirs)
            Directory.CreateDirectory(PagesFolder);
        DataFile = Path.Combine(RootFolder, "data.txt");
        InfoFile = Path.Combine(RootFolder, "info.txt");
        CharactersFile = Path.Combine(RootFolder, "custom_symbols.txt");
        DictionaryFile = Path.Combine(RootFolder, "dictionary.txt");
    }

    /// <summary>
    /// The new method of storing pages.
    /// </summary>
    /// 
    /// <param name="pageIndex">The index of the page in the notebook.</param>
    /// 
    /// <returns>The path to the page.</returns>
    public string GetPagePath(int pageIndex) => Path.Combine(PagesFolder, $"{pageIndex}.rtf");


    /// <summary>
    /// The old method of storing pages.
    /// </summary>
    /// 
    /// <param name="pageTitle">The title of the page.</param>
    /// 
    /// <returns>The path to the page.</returns>
    public string GetPagePath(string pageTitle) => Path.Combine(PagesFolder, $"{pageTitle}.rtf");
}
