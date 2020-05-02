using System.Drawing;
using System.Drawing.Drawing2D;

namespace LangPadUI.Themes
{
    public class Theme
    {
        public string Name { get; set; }

        public Theme(string name)
        {
            Name = name;
        }


        /**
         * Main colors
         */
        public Color Color1 { get; set; } = Color.Gray;
        public Color Color2 { get; set; } = Color.Gray;
        public Color PanelBackColor { get; set; } = Color.WhiteSmoke;
        public Color PanelTextColor { get; set; } = Color.Black;
        public bool HasVerticalMenuGradient { get; set; } = false;

        /**
         * ToolStrip colors
         */
        public Color ToolStripSeparatorColor { get; set; } = Color.FromArgb(255, 203, 204, 205);
        public Color ToolStripSeparatorShadowColor { get; set; } = Color.FromArgb(255, 255, 255, 255);
        public Color ToolStripBorderColor { get; set; } = Color.FromArgb(255, 245, 245, 245);
        public Color ToolStripBackColor1 { get; set; } = Color.FromArgb(0, 250, 250, 250); 
        public Color ToolStripBackColor2 { get; set; } = Color.FromArgb(0, 242, 242, 242);
        public Color ToolStripShadowColor { get; set; } = Color.FromArgb(255, 245, 245, 245);
        public Color ToolStripButtonSelectedColor1 { get; set; } = Color.FromArgb(100, 223, 242, 252);
        public Color ToolStripButtonSelectedColor2 { get; set; } = Color.FromArgb(205, 223, 242, 252);
        public Color ToolStripButtonSelectedBorder { get; set; } = Color.FromArgb(225, 148, 188, 209);
        public Color ToolStripButtonSelectedShadow { get; set; } = Color.FromArgb(225, 240, 240, 240);
        public Color ToolStripButtonPressedColor1 { get; set; } = Color.FromArgb(100, 180, 198, 207);
        public Color ToolStripButtonPressedColor2 { get; set; } = Color.FromArgb(205, 180, 198, 207);
        public Color ToolStripButtonPressedBorder { get; set; } = Color.FromArgb(225, 145, 160, 167);
        public Color ToolStripButtonPressedShadow { get; set; } = Color.FromArgb(225, 215, 230, 238);

        public static GraphicsPath GetRoundedRectanglePath(Rectangle Area, int Roundness)
        {
            GraphicsPath RoundedRectanglePath = new GraphicsPath();

            if (Area.Width < Roundness * 2 || Area.Height < Roundness * 2)
            {
                RoundedRectanglePath.AddEllipse(Area);
                return RoundedRectanglePath;
            }

            PointF[] CurvePoints = new[] { new PointF(Area.X, Area.Y + Roundness),
                                           new PointF(Area.X + Roundness / (float)3, Area.Y + Roundness / (float)3),
                                           new PointF(Area.X + Roundness, Area.Y) };

            RoundedRectanglePath.AddCurve(CurvePoints, 1);
            RoundedRectanglePath.AddLine(CurvePoints[2], new PointF(Area.Right - Roundness, Area.Y));

            CurvePoints[0] = new PointF(Area.Right - Roundness, Area.Y);
            CurvePoints[1] = new PointF(Area.Right - Roundness / (float)3, Area.Y + Roundness / (float)3);
            CurvePoints[2] = new PointF(Area.Right, Area.Y + Roundness);

            RoundedRectanglePath.AddCurve(CurvePoints, 1);
            RoundedRectanglePath.AddLine(CurvePoints[2], new PointF(Area.Right, Area.Bottom - Roundness));

            CurvePoints[0] = new PointF(Area.Right, Area.Bottom - Roundness);
            CurvePoints[1] = new PointF(Area.Right - Roundness / (float)3, Area.Bottom - Roundness / (float)3);
            CurvePoints[2] = new PointF(Area.Right - Roundness, Area.Bottom);

            RoundedRectanglePath.AddCurve(CurvePoints, 1);
            RoundedRectanglePath.AddLine(CurvePoints[2], new PointF(Area.X + Roundness, Area.Bottom));

            CurvePoints[0] = new PointF(Area.X + Roundness, Area.Bottom);
            CurvePoints[1] = new PointF(Area.X + Roundness / (float)3, Area.Bottom - Roundness / (float)3);
            CurvePoints[2] = new PointF(Area.X, Area.Bottom - Roundness);

            RoundedRectanglePath.AddCurve(CurvePoints, 1);
            RoundedRectanglePath.AddLine(CurvePoints[2], new PointF(Area.X, Area.Y + Roundness));

            return RoundedRectanglePath;
        }

        public static void DrawRoundedRectangle(Graphics g, int x, int y, int width, int height, int radius, Color color)
        {
            var pen = new Pen(color);
            g.DrawPath(pen, GetRoundedRectanglePath(new Rectangle(x, y, width, height), radius));
        }
        public static void FillRoundedRectangle(Graphics g, int x, int y, int width, int height, int radius, Brush brush)
        {
            g.FillPath(brush, GetRoundedRectanglePath(new Rectangle(x, y, width, height), radius));
        }

        public static void FillRoundedRectangle(Graphics g, Rectangle rect, int radius, Brush brush)
        {
            g.FillPath(brush, GetRoundedRectanglePath(rect, radius));
        }
    }
}
