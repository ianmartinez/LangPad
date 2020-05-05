using System;
using System.Drawing;
using System.Windows.Forms;

namespace LangPadUI
{
    public class CharacterButton : Button
    {
        private readonly IpaToolTip CharButtonTooltip = new IpaToolTip();

        /// <summary>
        /// Create a new button representing a character.
        /// </summary>
        /// 
        /// <param name="charName">The name of the character.</param>
        /// <param name="multiLine">If the description is on multiple lines.</param>
        public CharacterButton(string charName = "", bool multiLine = true)
        {
            Padding = new Padding(0);
            ForeColor = Color.White;
            BackColor = Color.Transparent;
            Font = new Font("Calibri", 11, FontStyle.Bold);
            AutoSize = true;
            MinimumSize = new Size(45, 45);
            Margin = new Padding(3, 3, 3, 6);
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            UseCompatibleTextRendering = true;
            CharButtonTooltip.CharName = multiLine ? charName.Replace("/", "\n") : charName;
            TextChanged += CharacterButton_TextChanged;
        }

        private void CharacterButton_TextChanged(object sender, EventArgs e)
        {
            CharButtonTooltip.SetToolTip(this, Text);
        }
    }
}
