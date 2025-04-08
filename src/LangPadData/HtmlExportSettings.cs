namespace LangPadData;

/// <summary>
/// Controls how a dictionary should be exported
/// to HTML.
/// </summary>
public class HtmlExportSettings
{
    public string Title { get; set; } = "Dictionary";
    public string Description { get; set; } = "";
    public bool DescriptionParagraphs { get; set; } = true;
    public bool WordCol { get; set; } = true;
    public bool PronunciationCol { get; set; } = true;
    public bool DefinitionCol { get; set; } = true;
    public bool NotesCol { get; set; } = true;
}
