using LangPadUI.Theming;
using System.Drawing;

namespace LangPadUI.Themes
{
    /// <summary>
    /// A brownish theme.
    /// </summary>
    public class DesertTheme : Theme
    {
        public DesertTheme() : base("Desert")
        {
            FormBackColor = Color.FromArgb(255, 234, 223, 218);
            PanelBackColor = FormBackColor;

            // Tool strip
            ToolStripBorderColor = Color.FromArgb(255, 193, 186, 174);
            ToolStripBackColor1 = Color.FromArgb(100, 255, 255, 255);
            ToolStripInsetColor = Color.Transparent;
            ToolStripSeparatorColor = ToolStripBorderColor;

            // Menu bar
            MenuBarBackColor2 = Color.FromArgb(100, 255, 255, 255);
        }
    }
}
