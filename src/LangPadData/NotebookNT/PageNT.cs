namespace LangPadData.NotebookNT;

/// <summary>
/// A page in the NT 1.x-2.x file format (*.nt).
/// </summary>
public class PageNT
{
    /// <summary>
    /// The page's title.
    /// </summary>
    public string Title { get; set; } = "";

    /// <summary>
    /// The Rich Text Format data of the page.
    /// </summary>
    public string Rtf { get; set; } = "";
}
