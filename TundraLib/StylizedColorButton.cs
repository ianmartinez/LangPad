using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace TundraLib
{
    public class StylizedColorButton : Button
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

        private bool mRightClickMode;
        public bool RightClickMode
        {
            get
            {
                return mRightClickMode;
            }
            set
            {
                mRightClickMode = value;
            }
        }

        private Bitmap ColorBitmap;
        private void GenerateColorBitmap()
        {
            ColorBitmap = new Bitmap(22, 22);
            Graphics ColorGraphics = Graphics.FromImage(ColorBitmap);
            Rectangle ColorRectangle = new Rectangle(0, 0, ColorBitmap.Width - 1, ColorBitmap.Height - 1);
            ColorGraphics.CompositingQuality = CompositingQuality.HighQuality;
            ColorGraphics.SmoothingMode = SmoothingMode.AntiAlias;
            ColorGraphics.FillRectangle(new SolidBrush(Color), ColorRectangle);
            ColorGraphics.DrawRectangle(new Pen(new SolidBrush(Color.FromArgb(100, 0, 0, 0))), ColorRectangle);
        }

        public StylizedColorButton()
        {
            InitializeComponent();
            TextAlign = ContentAlignment.MiddleRight;
            ImageAlign = ContentAlignment.MiddleCenter;
            MinimumSize = new Size(3, 30);
        }

        private void StylizedColorButton_Resize(object sender, EventArgs e)
        {
            GenerateColorBitmap();
            Image = ColorBitmap;
        }

        private void InitializeComponent()
        {
            dlgColor = new ColorDialog();
            SuspendLayout();
            dlgColor.FullOpen = true;
        }

        private void StylizedColorButton_MouseDown(object sender, MouseEventArgs e)
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
