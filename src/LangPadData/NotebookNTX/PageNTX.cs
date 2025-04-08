namespace LangPadData.NotebookNTX;

/// <summary>
/// A page in the future NTX file format (*.ntx), designed to replace
/// the NT format (NotebookNT, DictionaryNT, etc.). It is based around HTML
/// page data instead of RTF page data, and contains many other breaking features
/// that make it incompatible with the current format.
/// 
/// It is a work in progress and the NT format is still used by the actual 
/// program for the time being.
/// </summary>
public class PageNTX
{
    public string Title { get; set; }
    public string Content { get; set; }
}
