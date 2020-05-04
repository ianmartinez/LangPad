using LangPadUI.Theming;
using System.Drawing;

namespace LangPadUI.Themes
{
    /// <summary>
    /// A Windows XPish theme.
    /// </summary>
    public class LunaTheme : Theme
    {
        public LunaTheme() : base("Luna")
        {
            ButtonRadius = 0;
            FormBackColor = Color.FromArgb(249, 245, 232);
            PanelBackColor = Color.FromArgb(249, 248, 244);
            PanelTextColor = Color.Black;
            PanelBorderColor = Color.FromArgb(109, 106, 88);
            TabBackColor = Color.White;

            // Tool strip
            ToolStripTextColor = Color.FromArgb(255, 20, 20, 20);
            ToolStripBorderColor = Color.FromArgb(81, 124, 185);
            ToolStripBackColor1 = Color.FromArgb(222, 236, 255);
            ToolStripBackColor2 = Color.FromArgb(156, 194, 250);
            ToolStripInsetColor = Color.FromArgb(40, 255, 255, 255);
            ToolStripSeparatorColor = Color.FromArgb(106, 140, 203);
            ToolStripSeparatorShadowColor = Color.FromArgb(241, 249, 255);
            ToolStripButtonSelectedBorderColor = Color.FromArgb(240, 211, 137, 46);
            ToolStripButtonSelectedColor1 = Color.FromArgb(230, 252, 235, 194);
            ToolStripButtonSelectedColor2 = Color.FromArgb(235, 247, 200, 131);
            ToolStripButtonPressedBorderColor = Color.FromArgb(211, 137, 46);
            ToolStripButtonPressedColor1 = Color.FromArgb(255, 219, 133);
            ToolStripButtonPressedColor2 = Color.FromArgb(255, 185, 78);

            // Menu
            MenuBackColor = Color.FromArgb(254, 250, 245);
            MenuTextColor = Color.FromArgb(0, 2, 9);
            MenuBorderColor = Color.FromArgb(81, 124, 185);
            MenuBarBackColor1 = Color.FromArgb(176, 203, 248);
            MenuBarBackColor2 = MenuBarBackColor1;
            MenuBarBorderColor = Color.FromArgb(121, 141, 168);
            MenuSeparatorColor = Color.FromArgb(121, 141, 168);
            MenuSeparatorShadowColor = Color.FromArgb(10, 255, 255, 255);
            MenuImageMarginBackColor1 = Color.FromArgb(192, 206, 243);
            MenuImageMarginBackColor2 = Color.FromArgb(139, 177, 224);
            MenuImageMarginBorderColor = Color.FromArgb(124, 164, 222);
            MenuImageMarginInsetColor = Color.Transparent;
            MenuButtonSelectedBorderColor = ToolStripButtonSelectedBorderColor;
            MenuButtonSelectedInsetColor = Color.Transparent;
            MenuButtonSelectedColor1 = ToolStripButtonSelectedColor1;
            MenuButtonSelectedColor2 = ToolStripButtonSelectedColor2;
            MenuButtonPressedBorderColor = ToolStripButtonPressedBorderColor;
            MenuButtonPressedInsetColor = Color.Transparent;
            MenuButtonPressedColor1 = ToolStripButtonPressedColor1;
            MenuButtonPressedColor2 = ToolStripButtonPressedColor2;
        }
    }
}
