using System;
using System.Drawing;
using System.Windows.Forms;

namespace LangPad.Controls
{
    /// <summary>
    /// A character button in the character editor that is inserts a
    /// character into the target textbox when clicked.
    /// </summary>
    public class CharacterButton : Button
    {
        private string charName = "";
        public string CharName
        {
            get
            {
                return charName;
            }

            set
            {
                CharButtonTooltip.CharName = multiline ? value.Replace("/", "\n") : value;
                charName = value;
            }
        }

        private bool multiline = true;
        public bool Multiline
        {
            get
            {
                return multiline;
            }

            set
            {
                CharButtonTooltip.CharName = value ? charName.Replace("/", "\n") : charName;
                multiline = value;
            }
        }

        private readonly IpaToolTip CharButtonTooltip = new IpaToolTip();

        /// <summary>
        /// Create a new button representing a character.
        /// </summary>
        public CharacterButton()
        {
            Padding = new Padding(0);
            ForeColor = Color.Black;
            BackColor = Color.Transparent;
            Font = new Font("Calibri", 11, FontStyle.Bold);
            AutoSize = true;
            MinimumSize = new Size(45, 45);
            Margin = new Padding(3, 3, 3, 6);
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            UseCompatibleTextRendering = true;
            TextChanged += CharacterButton_TextChanged;
        }


        /// <summary>
        /// Create a new button representing a character.
        /// </summary>
        /// 
        /// <param name="charName">The name of the character.</param>
        /// <param name="multiline">If the description is on multiple lines.</param>
        public CharacterButton(string charName = "", bool multiline = true) : this()
        {
            this.multiline = multiline;
            CharName = charName;
        }

        private void CharacterButton_TextChanged(object sender, EventArgs e)
        {
            CharButtonTooltip.SetToolTip(this, Text);
        }
    }
}
