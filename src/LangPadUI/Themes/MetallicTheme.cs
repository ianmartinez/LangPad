using LangPadUI.Theming;
using System.Drawing;

namespace LangPadUI.Themes
{
    /// <summary>
    /// A silvery theme.
    /// </summary>
    public class MetallicTheme : LunaTheme
    {
        public MetallicTheme()
        {
            Name = "Metallic";

            // Tool strip
            ToolStripTextColor = Color.FromArgb(255, 20, 20, 20);
            ToolStripBorderColor = Color.FromArgb(124, 124, 148);
            ToolStripBackColor1 = Color.FromArgb(249, 250, 254);
            ToolStripBackColor2 = Color.FromArgb(160, 157, 186);
            ToolStripInsetColor = Color.Transparent;
            ToolStripSeparatorColor = Color.FromArgb(109, 109, 143);
            ToolStripSeparatorShadowColor = Color.FromArgb(253, 253, 253);

            // Menu
            MenuBackColor = PanelBackColor;
            MenuBorderColor = Color.FromArgb(156, 155, 180);
            MenuBarBackColor1 = Color.FromArgb(228, 228, 238);
            MenuBarBackColor2 = MenuBarBackColor1;
            MenuBarBorderColor = MenuBarBackColor1;
            MenuSeparatorColor = ToolStripSeparatorColor;
            MenuSeparatorShadowColor = Color.FromArgb(100, 255, 255, 255);
            MenuImageMarginBackColor1 = ToolStripBackColor1;
            MenuImageMarginBackColor2 = ToolStripBackColor2;
            MenuImageMarginBorderColor = ToolStripBorderColor;
            MenuImageMarginInsetColor = Color.FromArgb(60, 255, 255, 255);
        }
    }
}
