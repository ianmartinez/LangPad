using LangPadUI.Theming;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LangPadUI.Themes
{
    /// <summary>
    /// A brownish theme.
    /// </summary>
    public class DesertTheme : Theme
    {
        public DesertTheme() : base("Desert")
        {
            FormBackColor = Color.FromArgb(255, 200, 200, 200);
            ToolStripBorderColor = Color.Black;
        }
    }
}
