using System.Windows.Forms;

namespace LangPadUI
{
    public partial class ShortcutButton : UserControl
    {
        public ShortcutButton()
        {
            InitializeComponent();
        }

        public bool HasChar => !string.IsNullOrEmpty(charButton.Text);

        public string ShortcutText
        {
            get
            {
                return shortcutKeyLabel.Text;
            }

            set
            {
                shortcutKeyLabel.Text = value;
            }
        }

        public string CharValue
        {
            get
            {
                return charButton.Text;
            }

            set
            {
                charButton.Text = value;
            }
        }

        public string SettingsValue { get; set; } = "";
    }
}
