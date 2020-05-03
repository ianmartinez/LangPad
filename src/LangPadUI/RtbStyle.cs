using System.Drawing;
using System.Windows.Forms;

namespace LangPadUI
{
    /// <summary>
    /// The styling of text in a RichTextBox.
    /// </summary>
    public class RtbStyle
    {
        public Font Font { get; set; } = new Font("Calibri", 11);
        public Color Color { get; set; } = Color.Black;
        public Color HighlightColor { get; set; } = Color.Transparent;
        public HorizontalAlignment Alignment { get; set; } = HorizontalAlignment.Left;
        public int Indent { get; set; } = 0;
        public int HangingIndent { get; set; } = 0;
        public int BulletIndent { get; set; } = 0;
        public int CharOffset { get; set; } = 0;
    }
}
