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
            FormBackColor = Color.FromArgb(255, 250, 247, 245);
            PanelBackColor = FormBackColor;

            // Tool strip
            ToolStripTextColor = Color.FromArgb(255, 41, 33, 30);
            ToolStripBorderColor = Color.FromArgb(255, 213, 206, 194);
            ToolStripBackColor1 = Color.FromArgb(255, 242, 235, 232);
            ToolStripBackColor2 = Color.FromArgb(255, 234, 224, 219);
            ToolStripInsetColor = Color.Transparent;
            ToolStripSeparatorColor = Color.FromArgb(255, 170, 153, 146);
            ToolStripSeparatorShadowColor = Color.FromArgb(80, 255, 255, 255);
            ToolStripButtonSelectedColor1 = Color.FromArgb(100, 204, 193, 188);
            ToolStripButtonSelectedColor2 = Color.FromArgb(205, 204, 193, 188);
            ToolStripButtonSelectedBorderColor = Color.FromArgb(255, 204, 193, 188);
            ToolStripButtonPressedColor1 = Color.FromArgb(100, 175, 169, 166);
            ToolStripButtonPressedColor2 = Color.FromArgb(205, 175, 169, 166);
            ToolStripButtonPressedBorderColor = Color.FromArgb(225, 175, 169, 166);


            // Menu
            MenuBackColor = PanelBackColor;
            MenuTextColor = ToolStripTextColor;
            MenuArrowColor = MenuTextColor;
            MenuBorderColor = Color.FromArgb(255, 193, 186, 174);
            MenuBarBackColor2 = Color.FromArgb(255, 243, 236, 233);
            MenuSeparatorColor = ToolStripSeparatorColor;
            MenuSeparatorShadowColor = ToolStripSeparatorShadowColor;
            MenuButtonSelectedColor1 = ToolStripButtonSelectedColor1;
            MenuButtonSelectedColor2 = ToolStripButtonSelectedColor2;
            MenuButtonSelectedBorderColor = ToolStripButtonSelectedBorderColor;
            MenuButtonPressedColor1 = ToolStripButtonPressedColor1;
            MenuButtonPressedColor2 = ToolStripButtonPressedColor2;
            MenuButtonPressedBorderColor = ToolStripButtonPressedBorderColor;
            MenuButtonPressedInsetColor = Color.FromArgb(100, 255, 255, 255);

            // Menu image margin
            MenuImageMarginBackColor1 = ToolStripBackColor1;
            MenuImageMarginBackColor2 = ToolStripBackColor2;
            MenuImageMarginBorderColor = MenuBorderColor;
            MenuImageMarginInsetColor = Color.FromArgb(90, 255, 255, 255);
        }
    }
}
