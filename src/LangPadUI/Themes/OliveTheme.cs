using LangPadUI.Theming;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LangPadUI.Themes
{
    public class OliveTheme : LunaTheme
    {
        public OliveTheme()
        {
            Name = "Olive Green";

            // Tool strip
            ToolStripTextColor = Color.FromArgb(255, 20, 20, 20);
            ToolStripBorderColor = Color.FromArgb(96, 128, 87);
            ToolStripBackColor1 = Color.FromArgb(255, 255, 237);
            ToolStripBackColor2 = Color.FromArgb(186, 200, 147);
            ToolStripInsetColor = Color.FromArgb(40, 255, 255, 255);
            ToolStripSeparatorColor = Color.FromArgb(97, 127, 89);
            ToolStripSeparatorShadowColor = Color.FromArgb(244, 246, 224);

            // Menu
            MenuBackColor = Color.FromArgb(254, 250, 245);
            MenuTextColor = Color.FromArgb(0, 2, 9);
            MenuBorderColor = Color.FromArgb(16, 42, 103);
            MenuBarBackColor1 = Color.FromArgb(176, 203, 248);
            MenuBarBackColor2 = MenuBarBackColor1;
            MenuBarBorderColor = Color.FromArgb(169, 200, 247);
            MenuSeparatorColor = ToolStripSeparatorColor;
            MenuSeparatorShadowColor = Color.FromArgb(10, 255, 255, 255);
            MenuImageMarginBackColor1 = Color.FromArgb(192, 206, 243);
            MenuImageMarginBackColor2 = Color.FromArgb(139, 177, 224);
            MenuImageMarginBorderColor = Color.FromArgb(124, 164, 222);
            MenuImageMarginInsetColor = Color.Transparent;
        }
    }
}
