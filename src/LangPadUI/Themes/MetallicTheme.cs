using LangPadUI.Theming;
using System.Drawing;

namespace LangPadUI.Themes
{
    /// <summary>
    /// A silvery theme theme.
    /// </summary>
    public class MetallicTheme : Theme
    {
        public MetallicTheme() : base("Metallic")
        {
            ButtonRadius = 0;
            FormBackColor = Color.FromArgb(249, 245, 232);
            PanelBackColor = Color.FromArgb(249, 248, 244);
            PanelTextColor = Color.Black;
            PanelBorderColor = Color.FromArgb(109, 106, 88);
            TabBackColor = Color.White;

            // Tool strip
            ToolStripTextColor = Color.FromArgb(255, 20, 20, 20);
            ToolStripBorderColor = Color.FromArgb(124, 124, 148);
            ToolStripBackColor1 = Color.FromArgb(249, 250, 254);
            ToolStripBackColor2 = Color.FromArgb(160, 157, 186);
            ToolStripInsetColor = Color.Transparent;
            ToolStripSeparatorColor = Color.FromArgb(109, 109, 143);
            ToolStripSeparatorShadowColor = Color.FromArgb(253, 253, 253);
            ToolStripButtonSelectedBorderColor = Color.FromArgb(240, 211, 137, 46);
            ToolStripButtonSelectedColor1 = Color.FromArgb(230, 252, 235, 194);
            ToolStripButtonSelectedColor2 = Color.FromArgb(235, 247, 200, 131);
            ToolStripButtonPressedBorderColor = Color.FromArgb(211, 137, 46);
            ToolStripButtonPressedColor1 = Color.FromArgb(255, 219, 133);
            ToolStripButtonPressedColor2 = Color.FromArgb(255, 185, 78);

            // Menu
            MenuBackColor = PanelBackColor;
            MenuBorderColor = Color.FromArgb(156, 155, 180);
            MenuBarBackColor1 = Color.FromArgb(228, 228, 238);
            MenuBarBackColor2 = MenuBarBackColor1;
            MenuSeparatorColor = ToolStripSeparatorColor;
            MenuSeparatorShadowColor = Color.FromArgb(240, 255, 255, 255);
            MenuImageMarginBackColor1 = ToolStripBackColor1;
            MenuImageMarginBackColor2 = ToolStripBackColor2;
            MenuImageMarginBorderColor = ToolStripBorderColor;
            MenuImageMarginInsetColor = Color.FromArgb(60, 255, 255, 255);
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
