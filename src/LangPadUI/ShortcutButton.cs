using System.Windows.Forms;

namespace LangPadUI
{
    public partial class ShortcutButton : UserControl
    {
        public ShortcutButton()
        {
            InitializeComponent();
        }

        public bool HasChar => !string.IsNullOrEmpty(CharButton.Text);

        public string ShortcutText
        {
            get
            {
                return ShortcutKeyLabel.Text;
            }

            set
            {
                ShortcutKeyLabel.Text = value;
                CharButton.CharName = string.Format("Insert with {0}", value);
            }
        }

        public string CharValue
        {
            get
            {
                return CharButton.Text;
            }

            set
            {
                CharButton.Text = value;
            }
        }

        public string SettingsValue { get; set; } = "";
    }
}
