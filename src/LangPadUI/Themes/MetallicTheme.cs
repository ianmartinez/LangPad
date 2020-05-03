using LangPadUI.Theming;
using System.Drawing;

namespace LangPadUI.Themes
{
    /// <summary>
    /// A dark gray theme.
    /// </summary>
    public class MetallicTheme : Theme
    {
        public MetallicTheme() : base("Metallic")
        {
            FormBackColor = Color.FromArgb(255, 230, 230, 230);
            FormTextColor = Color.Black;
            PanelBackColor = Color.FromArgb(255, 230, 230, 230);
            PanelTextColor = Color.Black;
            PanelBorderColor = Color.FromArgb(130, 130, 130);
            TabBackColor = Color.FromArgb(255, 234, 234, 234);
            TabTextColor = FormTextColor;

            // Tool strip
            ToolStripTextColor = Color.FromArgb(255, 20, 20, 20);
            ToolStripBorderColor = Color.FromArgb(255, 145, 145, 145);
            ToolStripBackColor1 = Color.FromArgb(255, 230, 230, 230);
            ToolStripBackColor2 = Color.FromArgb(255, 200, 200, 200);
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
