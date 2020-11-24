using LangPad.Appearance;
using System.Drawing;

namespace LangPad.Appearance.Themes
{
    /// <summary>
    /// A dark gray theme with a touch of blue.
    /// </summary>
    public class CoolGrayTheme : Theme
    {
        public CoolGrayTheme() : base("Cool Gray")
        {
            FormBackColor = Color.FromArgb(255, 230, 230, 235);
            FormTextColor = Color.Black;
            PanelBackColor = Color.FromArgb(255, 235, 235, 239);
            PanelTextColor = Color.Black;
            PanelBorderColor = Color.FromArgb(130, 130, 130);
            TabBackColor = PanelBackColor;
            TabTextColor = FormTextColor;

            // Tool strip
            ToolStripTextColor = Color.FromArgb(255, 20, 20, 20);
            ToolStripBorderColor = Color.FromArgb(255, 145, 145, 149);
            ToolStripBackColor1 = Color.FromArgb(255, 230, 230, 235);
            ToolStripBackColor2 = Color.FromArgb(255, 200, 200, 205);
            ToolStripInsetColor = Color.FromArgb(40, 255, 255, 255);
            ToolStripSeparatorColor = ToolStripBorderColor;
            ToolStripSeparatorShadowColor = Color.FromArgb(80, 255, 255, 255);
            ToolStripButtonSelectedBorderColor = Color.FromArgb(200, 90, 117, 170);
            ToolStripButtonSelectedColor1 = Color.FromArgb(50, 190, 220, 249);
            ToolStripButtonSelectedColor2 = Color.FromArgb(200, 190, 220, 249);
            ToolStripButtonPressedBorderColor = Color.FromArgb(220, 70, 97, 150);
            ToolStripButtonPressedColor1 = Color.FromArgb(70, 170, 200, 229);
            ToolStripButtonPressedColor2 = Color.FromArgb(220, 170, 200, 229);

            // Menu
            MenuBackColor = PanelBackColor;
            MenuBorderColor = PanelBorderColor;
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
