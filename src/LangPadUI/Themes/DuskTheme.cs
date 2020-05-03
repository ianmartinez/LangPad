using LangPadUI.Theming;
using System.Drawing;

namespace LangPadUI.Themes
{
    /// <summary>
    /// A darker theme.
    /// </summary>
    public class DuskTheme : Theme
    {
        public DuskTheme() : base("Dusk")
        {
            FormBackColor = Color.FromArgb(255, 84, 84, 84);
            FormTextColor = Color.White;
            PanelBackColor = FormBackColor;
            PanelTextColor = Color.White;
            PanelBorderColor = Color.White;
        }
    }
}
