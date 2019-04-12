using System;
using System.Drawing;
using System.Windows.Forms;

namespace TundraLib.Themes
{
    public class Theme
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

        public Theme(string Name)
        {
            this.Name = Name;
        }
        
        public static void DrawRoundedRectangle(Graphics objGraphics, int m_intxAxis, int m_intyAxis, int m_intWidth, int m_intHeight, int m_diameter, Color color)
        {
            Pen pen = new Pen(color);

            // Dim g As Graphics
            RectangleF BaseRect = new RectangleF(m_intxAxis, m_intyAxis, m_intWidth, m_intHeight);
            RectangleF ArcRect = new RectangleF(BaseRect.Location, new SizeF(m_diameter, m_diameter));
            // top left Arc
            objGraphics.DrawArc(pen, ArcRect, 180, 90);
            objGraphics.DrawLine(pen, m_intxAxis + Convert.ToInt32(m_diameter / (double)2), m_intyAxis, m_intxAxis + m_intWidth - Convert.ToInt32(m_diameter / (double)2), m_intyAxis);

            // top right arc
            ArcRect.X = BaseRect.Right - m_diameter;
            objGraphics.DrawArc(pen, ArcRect, 270, 90);
            objGraphics.DrawLine(pen, m_intxAxis + m_intWidth, m_intyAxis + Convert.ToInt32(m_diameter / (double)2), m_intxAxis + m_intWidth, m_intyAxis + m_intHeight - Convert.ToInt32(m_diameter / (double)2));

            // bottom right arc
            ArcRect.Y = BaseRect.Bottom - m_diameter;
            objGraphics.DrawArc(pen, ArcRect, 0, 90);
            objGraphics.DrawLine(pen, m_intxAxis + Convert.ToInt32(m_diameter / (double)2), m_intyAxis + m_intHeight, m_intxAxis + m_intWidth - Convert.ToInt32(m_diameter / (double)2), m_intyAxis + m_intHeight);

            // bottom left arc
            ArcRect.X = BaseRect.Left;
            objGraphics.DrawArc(pen, ArcRect, 90, 90);
            objGraphics.DrawLine(pen, m_intxAxis, m_intyAxis + Convert.ToInt32(m_diameter / (double)2), m_intxAxis, m_intyAxis + m_intHeight - Convert.ToInt32(m_diameter / (double)2));
        }
    }

    public class BreezeTheme : Theme
    {
        public BreezeTheme() : base("Breeze")
        {
            Color1 = Color.FromArgb(255, 243, 244, 245);
            Color2 = Color.FromArgb(255, 243, 244, 245);
            DialogBack = SystemColors.Control;
            PanelBack = Color.FromArgb(255, 243, 244, 245);

            VerticalMenuGradient = false;
        }

        public override ToolStripRenderer GetToolStripRenderer()
        {
            return new clsBreezeToolstripRenderer();
        }

        public override ToolStripRenderer GetMenuRenderer()
        {
            return new clsBreezeMenuRenderer();
        }
    }

}