using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace LangPadUI
{
    /// <summary>
    /// A button that displays a box with a color that can
    /// be changed by the user with a color dialog when it
    /// is clicked.
    /// 
    /// Fires a ColorChanged event when the color is changed.
    /// </summary>
    public class ColorButton : Button
    {
        private readonly ColorDialog colorDialog = new ColorDialog { FullOpen = true };
        private Bitmap colorBitmap;
        private Color color;

        /// <summary>
        /// Fired when the color is changed by the user.
        /// </summary>
        public event ColorChangedEventHandler ColorChanged;
        public delegate void ColorChangedEventHandler(object sender, EventArgs e);

        /// <summary>
        /// If the color picker is opened by right clicking the button
        /// instead of left clicking.
        /// </summary>
        public bool RightClickMode { get; set; }

        /// <summary>
        /// The current color of the color button.
        /// </summary>
        public Color Color
        {
            get
            {
                return color;
            }
            set
            {
                color = value;
                GenerateColorBitmap();
                Image = colorBitmap;
                ColorChanged?.Invoke(this, null);
            }
        }

        public ColorButton()
        {
            InitializeComponent();
            TextAlign = ContentAlignment.MiddleRight;
            ImageAlign = ContentAlignment.MiddleCenter;
            MinimumSize = new Size(32, 32);
        }

        private void GenerateColorBitmap()
        {
            colorBitmap = new Bitmap(32, 32);

            Graphics g = Graphics.FromImage(colorBitmap);
            g.CompositingQuality = CompositingQuality.HighQuality;
            g.SmoothingMode = SmoothingMode.AntiAlias;

            Rectangle rect = new Rectangle(1, 1, colorBitmap.Width - 2, colorBitmap.Height - 2);
            g.FillRectangle(new SolidBrush(Color), rect);
            g.DrawRectangle(new Pen(Color.FromArgb(100, 0, 0, 0)), rect);
        }

        private void ColorButton_Resize(object sender, EventArgs e)
        {
            GenerateColorBitmap();
            Image = colorBitmap;
        }

        private void InitializeComponent()
        {
            MouseDown += ColorButton_MouseDown;
        }

        private void ColorButton_MouseDown(object sender, MouseEventArgs e)
        {
            if (RightClickMode && !(e.Button == MouseButtons.Right))
            {
                return;
            }
            else
            {
                colorDialog.Color = Color;
                if (colorDialog.ShowDialog() == DialogResult.OK)
                    Color = colorDialog.Color;
            }
        }
    }
}
