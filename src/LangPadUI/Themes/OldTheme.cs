using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace LangPadUI.Themes
{
    public class OldTheme
    {
        public string Name;
        public Color Color1 = Color.Gray;
        public Color Color2 = Color.Gray;
        public Color PanelBack = Color.WhiteSmoke;
        public Color PanelText = Color.Black;
        public Color DialogBack = Color.White;

        public bool VerticalMenuGradient = false;

        public virtual ToolStripRenderer GetToolStripRenderer()
        {
            return new ToolStripProfessionalRenderer();
        }

        public virtual ToolStripRenderer GetMenuRenderer()
        {
            return new ToolStripProfessionalRenderer();
        }

        public OldTheme(string Name)
        {
            this.Name = Name;
        }

        public static GraphicsPath GetRoundedRectanglePath(Rectangle Area, int Roundness)
        {
            GraphicsPath RoundedRectanglePath = new GraphicsPath();

            if (Area.Width < Roundness * 2 || Area.Height < Roundness * 2)
            {
                RoundedRectanglePath.AddEllipse(Area);
                return RoundedRectanglePath;
            }

            PointF[] CurvePoints = new[] { new PointF(Area.X, Area.Y + Roundness), new PointF(Area.X + Roundness / (float)3, Area.Y + Roundness / (float)3), new PointF(Area.X + Roundness, Area.Y) };

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


        public static void DrawRoundedRectangle(Graphics g, int x, int y, int width, int height, int Radius, Color Color)
        {
            var pen = new Pen(Color);
            g.DrawPath(pen, GetRoundedRectanglePath(new Rectangle(x, y, width, height), Radius));
        }
        public static void FillRoundedRectangle(Graphics g, int x, int y, int width, int height, int Radius, Brush brush)
        {
            g.FillPath(brush, GetRoundedRectanglePath(new Rectangle(x, y, width, height), Radius));
        }

        public static void FillRoundedRectangle(Graphics g, Rectangle Rect, int Radius, Brush brush)
        {
            g.FillPath(brush, GetRoundedRectanglePath(Rect, Radius));
        }
    }

    public class GlacierTheme : OldTheme
    {
        public GlacierTheme() : base("Glacier")
        {
            Color1 = Color.FromArgb(255, 255, 255, 255);
            Color2 = Color.FromArgb(255, 255, 255, 255);
            DialogBack = SystemColors.Control;
            PanelBack = Color.FromArgb(255, 245, 245, 245);

            VerticalMenuGradient = true;
        }

        public override ToolStripRenderer GetToolStripRenderer()
        {
            return new GlacierToolstripRenderer();
        }

        public override ToolStripRenderer GetMenuRenderer()
        {
            return new GlacierMenuRenderer();
        }
    }

}