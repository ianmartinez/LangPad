using System.Windows.Forms;

namespace LangPadUI;

/// <summary>
/// A Panel that is double-buffered by default, to have
/// less artifacts than the default Panel.
/// </summary>
public class DoubleBufferedPanel : Panel
{
    public DoubleBufferedPanel()
    {
        DoubleBuffered = true;
        SetStyle(ControlStyles.SupportsTransparentBackColor, true);
        SetStyle(ControlStyles.OptimizedDoubleBuffer, true);
        SetStyle(ControlStyles.ResizeRedraw, true);
    }
}
