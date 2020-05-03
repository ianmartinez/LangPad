using LangPadUI.Theming;
using System.Drawing;

namespace LangPadUI.Themes
{
    /// <summary>
    /// A darker theme.
    /// </summary>
    public class MetallicTheme : Theme
    {
        public MetallicTheme() : base("Metallic")
        {
            FormBackColor = Color.FromArgb(255, 230, 230, 230);
            FormTextColor = Color.Black;
            PanelBackColor = Color.FromArgb(255, 240, 240, 240);
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
        }
    }
}
