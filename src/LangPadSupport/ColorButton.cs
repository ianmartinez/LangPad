using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace LangPadUI
{
    public class ColorButton : Button
    {
        private ColorDialog dlgColor;
        public event ColorChangedEventHandler ColorChanged;
        public delegate void ColorChangedEventHandler(object sender, EventArgs e);

        private Color mColor;
        public Color Color
        {
            get
            {
                return mColor;
            }
            set
            {
                mColor = value;
                GenerateColorBitmap();
                Image = ColorBitmap;
                ColorChanged?.Invoke(this, null);
            }
        }

        public bool RightClickMode { get; set; }

        private Bitmap ColorBitmap;
        private void GenerateColorBitmap()
        {
            ColorBitmap = new Bitmap(32, 32);
            Graphics ColorGraphics = Graphics.FromImage(ColorBitmap);
            Rectangle ColorRectangle = new Rectangle(1, 1, ColorBitmap.Width - 2, ColorBitmap.Height - 2);
            ColorGraphics.CompositingQuality = CompositingQuality.HighQuality;
            ColorGraphics.SmoothingMode = SmoothingMode.AntiAlias;
            ColorGraphics.FillRectangle(new SolidBrush(Color), ColorRectangle);
            ColorGraphics.DrawRectangle(new Pen(new SolidBrush(Color.FromArgb(100, 0, 0, 0))), ColorRectangle);
        }

        public ColorButton()
        {
            InitializeComponent();
            TextAlign = ContentAlignment.MiddleRight;
            ImageAlign = ContentAlignment.MiddleCenter;
            MinimumSize = new Size(32, 32);
        }

        private void ColorButton_Resize(object sender, EventArgs e)
        {
            GenerateColorBitmap();
            Image = ColorBitmap;
        }

        private void InitializeComponent()
        {
            dlgColor = new ColorDialog();
            SuspendLayout();
            dlgColor.FullOpen = true;
            MouseDown += ColorButton_MouseDown;
        }

        private void ColorButton_MouseDown(object sender, MouseEventArgs e)
        {
            if (RightClickMode && !(e.Button == MouseButtons.Right))
                return;
            else
            {
                dlgColor.Color = Color;
                if (dlgColor.ShowDialog() == DialogResult.OK)
                    Color = dlgColor.Color;
            }
        }
    }
}
