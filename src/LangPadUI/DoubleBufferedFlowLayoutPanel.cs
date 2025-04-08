using System.Windows.Forms;

namespace LangPadUI;

/// <summary>
/// A FlowLayoutPanel that is double-buffered by default, to have
/// less artifacts than the default FlowLayoutPanel.
/// </summary>
public class DoubleBufferedFlowLayoutPanel : FlowLayoutPanel
{
    public DoubleBufferedFlowLayoutPanel()
    {
        DoubleBuffered = true;
        SetStyle(ControlStyles.SupportsTransparentBackColor, true);
        SetStyle(ControlStyles.OptimizedDoubleBuffer, true);
        SetStyle(ControlStyles.ResizeRedraw, true);
    }
}