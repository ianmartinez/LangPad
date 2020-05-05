using System;
using System.Drawing;
using System.Windows.Forms;

namespace LangPadUI
{
    public class AccentCheckButton : CheckBox
    {
        private readonly IpaToolTip CharButtonTooltip = new IpaToolTip();

        /// <summary>
        /// Create a new check box button representing an accent mark.
        /// </summary>
        /// 
        /// <param name="charName">The name of the character.</param>
        /// <param name="multiLine">If the description is on multiple lines.</param>
        public AccentCheckButton(string charName = "", bool multiLine = true)
        {
            Padding = new Padding(0);
            Font = new Font("Calibri", 14, FontStyle.Regular);
            AutoSize = true;
            MinimumSize = new Size(45, 32);
            Margin = new Padding(1);
            Appearance = Appearance.Button;
            TextAlign = ContentAlignment.MiddleCenter;
            UseCompatibleTextRendering = true;
            CharButtonTooltip.CharName = multiLine ? charName.Replace("/", "\n") : charName;
            TextChanged += AccentCheckButton_TextChanged;
        }

        private void AccentCheckButton_TextChanged(object sender, EventArgs e)
        {
            CharButtonTooltip.SetToolTip(this, Text);
        }
    }
}
