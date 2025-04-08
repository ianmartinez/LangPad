using LangPadUI.Theming;
using System.Drawing;

namespace LangPadUI.Themes;

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

        // Menus
        MenuBackColor = FormBackColor;
        MenuBorderColor = Color.FromArgb(220, 220, 220);
        MenuImageMarginBackColor1 = Color.FromArgb(250, 250, 250);
        MenuImageMarginBackColor2 = Color.FromArgb(240, 240, 240);
        MenuImageMarginBorderColor = MenuBorderColor;
        MenuImageMarginInsetColor = Color.White;
        MenuSeparatorColor = Color.FromArgb(225, 225, 225);
    }
}
