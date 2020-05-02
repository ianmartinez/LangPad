using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace LangPadUI.Themes
{
    /// <summary>
    /// Render a tool strip based on a theme.
    /// </summary>
    public class ThemeToolStripRenderer : ToolStripProfessionalRenderer
    {
        private readonly Theme theme;

        public ThemeToolStripRenderer(Theme theme) : base()
        {
            this.theme = theme;
        }

        protected override void OnRenderSeparator(ToolStripSeparatorRenderEventArgs e)
        {
            base.OnRenderSeparator(e);
            if (e.ToolStrip.Orientation == Orientation.Vertical)
            {
                Rectangle separatorRect = new Rectangle(2, 3, e.Item.Width - 4, 1);
                Rectangle shadowRect = new Rectangle(3, 4, e.Item.Width - 5, 1);
                e.Graphics.FillRectangle(new SolidBrush(theme.ToolStripSeparatorColor), separatorRect);
                e.Graphics.FillRectangle(new SolidBrush(theme.ToolStripSeparatorShadowColor), shadowRect);
            }
            else
            {
                Rectangle separatorRect = new Rectangle(3, 5, 1, e.Item.Height - 10);
                Rectangle shadowRect = new Rectangle(4, 6, 1, e.Item.Height - 10);
                e.Graphics.FillRectangle(new SolidBrush(theme.ToolStripSeparatorColor), separatorRect);
                e.Graphics.FillRectangle(new SolidBrush(theme.ToolStripSeparatorShadowColor), shadowRect);
            }
        }

        protected override void OnRenderToolStripBorder(ToolStripRenderEventArgs e)
        {
            //base.OnRenderToolStripBorder(e)
            Pen shadow = new Pen(theme.ToolStripBorderColor);
            Rectangle rect = new Rectangle(e.AffectedBounds.X, e.AffectedBounds.Y, e.AffectedBounds.Width - 1, e.AffectedBounds.Height);
            e.Graphics.DrawRectangle(shadow, rect);
        }

        protected override void OnRenderToolStripBackground(ToolStripRenderEventArgs e)
        {
            //base.OnRenderToolStripBackground(e);
            LinearGradientBrush background = new LinearGradientBrush(e.AffectedBounds, theme.ToolStripBackColor1, theme.ToolStripBackColor2, LinearGradientMode.Vertical);
            SolidBrush shadow = new SolidBrush(theme.ToolStripShadowColor);
            Rectangle shadowRect = new Rectangle(0, e.ToolStrip.Height - 2, e.ToolStrip.Width, 1);
            e.Graphics.FillRectangle(background, e.AffectedBounds);
            e.Graphics.FillRectangle(shadow, shadowRect);
        }

        protected override void OnRenderButtonBackground(ToolStripItemRenderEventArgs e)
        {
            //base.OnRenderButtonBackground(e);
            Rectangle rectBorder = new Rectangle(1, 1, e.Item.Width - 2, e.Item.Height - 2);
            Rectangle rect = new Rectangle(1, 1, e.Item.Width - 2, e.Item.Height - 2);

            if (e.Item.Selected || ((ToolStripButton)e.Item).Checked)
            {
                LinearGradientBrush background = new LinearGradientBrush(rect, theme.ToolStripButtonSelectedColor1, theme.ToolStripButtonSelectedColor2, LinearGradientMode.Vertical);
                Pen border = new Pen(theme.ToolStripButtonSelectedBorder);
                e.Graphics.FillRectangle(background, rect);
                e.Graphics.DrawRectangle(border, rectBorder);
            }
            if (e.Item.Pressed)
            {
                LinearGradientBrush background = new LinearGradientBrush(rect, theme.ToolStripButtonPressedColor1, theme.ToolStripButtonPressedColor2, LinearGradientMode.Vertical);
                Pen border = new Pen(theme.ToolStripButtonPressedBorder);
                e.Graphics.FillRectangle(background, rect);
                e.Graphics.DrawRectangle(border, rectBorder);
            }
        }
    }
}
