using LangPadUI.Theming;
using System.Drawing;

namespace LangPadUI.Themes
{
    /// <summary>
    /// An even lighter light theme.
    /// </summary>
    public class WhiteoutTheme : Theme
    {
        public WhiteoutTheme() : base("Whiteout")
        {
            FormBackColor = Color.White;
            PanelBackColor = FormBackColor;
            ToolStripBorderColor = FormBackColor;
            ToolStripSeparatorColor = Color.FromArgb(255, 210, 210, 210);
            ToolStripBackColor1 = FormBackColor;
            ToolStripBackColor2 = FormBackColor;
            ToolStripInsetColor = FormBackColor;
            ToolStripSeparatorShadowColor = FormBackColor;
        }
    }
}
