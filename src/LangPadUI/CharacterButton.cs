using System;
using System.Drawing;
using System.Windows.Forms;

namespace LangPadUI
{
    public class CharacterButton : Button
    {
        private readonly System.ComponentModel.IContainer components;
        private readonly IpaToolTip CharButtonTooltip = new IpaToolTip();

        /// <summary>
        /// Create a new button representing a character.
        /// </summary>
        /// 
        /// <param name="CharName">The name of the character.</param>
        /// <param name="MultiLine">If the description is on multiple lines.</param>
        public CharacterButton(string CharName = "", bool MultiLine = true)
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
            CharButtonTooltip.CharName = MultiLine ? CharName.Replace("/", "\n") : CharName;
            TextChanged += CharacterButton_TextChanged;
        }

        private void CharacterButton_TextChanged(object sender, EventArgs e)
        {
            CharButtonTooltip.SetToolTip(this, Text);
        }
    }
}
