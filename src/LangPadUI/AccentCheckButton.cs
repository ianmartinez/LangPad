using System;
using System.Drawing;
using System.Windows.Forms;

namespace LangPadUI
{
    public class AccentCheckButton : CheckBox
    {
        private readonly IpaToolTip CharButtonTooltip = new IpaToolTip();

        public AccentCheckButton(string CharName = "", bool MultiLine = true)
        {
            Padding = new Padding(0);
            Font = new Font("Calibri", 14, FontStyle.Regular);
            AutoSize = true;
            MinimumSize = new Size(45, 32);
            Margin = new Padding(1);
            Appearance = Appearance.Button;
            TextAlign = ContentAlignment.MiddleCenter;
            UseCompatibleTextRendering = true;
            CharButtonTooltip.CharName = MultiLine ? CharName.Replace("/", "\n") : CharName;
            TextChanged += AccentCheckButton_TextChanged;
        }

        private void AccentCheckButton_TextChanged(object sender, EventArgs e)
        {
            CharButtonTooltip.SetToolTip(this, Text);
        }
    }
}
