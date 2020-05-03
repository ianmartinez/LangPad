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
            ToolStripBorderColor = Color.FromArgb(255, 185, 185, 185);
            ToolStripBackColor1 = Color.FromArgb(255, 240, 240, 240);
            ToolStripBackColor2 = Color.FromArgb(255, 205, 205, 205);
            ToolStripInsetColor = Color.FromArgb(40, 255, 255, 255);
            ToolStripSeparatorColor = Color.FromArgb(145, 145, 145);
            ToolStripSeparatorShadowColor = Color.FromArgb(150, 255, 255, 255);
            ToolStripButtonSelectedBorderColor = Color.FromArgb(240, 211, 137, 46);
            ToolStripButtonSelectedColor1 = Color.FromArgb(230, 252, 235, 194);
            ToolStripButtonSelectedColor2 = Color.FromArgb(235, 247, 200, 131);
            ToolStripButtonPressedBorderColor = Color.FromArgb(211, 137, 46);
            ToolStripButtonPressedColor1 = Color.FromArgb(255, 219, 133);
            ToolStripButtonPressedColor2 = Color.FromArgb(255, 185, 78);

            // Menu
            MenuBackColor = PanelBackColor;
            MenuBorderColor = PanelBorderColor;
            MenuBarBackColor1 = Color.FromArgb(230, 230, 230);
            MenuBarBackColor2 = Color.FromArgb(230, 230, 230);
            MenuSeparatorColor = Color.FromArgb(215, 145, 145, 145);
            MenuSeparatorShadowColor = Color.FromArgb(40, 255, 255, 255);
            MenuImageMarginBackColor1 = Color.FromArgb(10, 0, 0, 0);
            MenuImageMarginBackColor2 = Color.FromArgb(40, 0, 0, 0);
            MenuImageMarginBorderColor = ToolStripSeparatorColor;
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
