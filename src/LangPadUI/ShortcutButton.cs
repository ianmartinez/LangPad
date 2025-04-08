using System.Windows.Forms;

namespace LangPadUI;

/// <summary>
/// A button displaying one of the customizable shortcut keys available.
/// </summary>
public partial class ShortcutButton : UserControl
{
    public ShortcutButton() => InitializeComponent();

    public bool HasChar => !string.IsNullOrEmpty(CharButton.Text);

    public string ShortcutText
    {
        get => ShortcutKeyLabel.Text;

        set
        {
            ShortcutKeyLabel.Text = value;
            CharButton.CharName = $"Insert with {value}";
        }
    }

    public string CharValue
    {
        get => CharButton.Text;

        set => CharButton.Text = value;
    }

    public string SettingsValue { get; set; } = "";
}
