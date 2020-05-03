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
            ToolStripSeparatorColor = Color.FromArgb(30, 0, 0, 0);
        }
    }
}
