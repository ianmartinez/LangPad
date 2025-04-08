using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace LangPadUI.Theming;

/// <summary>
/// Render a tool strip based on a theme.
/// </summary>
public class ThemeToolStripRenderer(Theme theme) : ToolStripSystemRenderer()
{
    protected override void InitializeItem(ToolStripItem item)
    {
        base.InitializeItem(item);
        item.ForeColor = theme.ToolStripTextColor;
    }

    protected override void Initialize(ToolStrip toolStrip)
    {
        base.Initialize(toolStrip);
        toolStrip.ForeColor = theme.ToolStripTextColor;
    }

    protected override void OnRenderSeparator(ToolStripSeparatorRenderEventArgs e)
    {
        //base.OnRenderSeparator(e);
        if (e.ToolStrip.Orientation == Orientation.Vertical)
        {
            Rectangle separatorRect = new(2, 3, e.Item.Width - 4, 1);
            Rectangle shadowRect = new(3, 4, e.Item.Width - 5, 1);

            e.Graphics.FillRectangle(new SolidBrush(theme.ToolStripSeparatorColor), separatorRect);
            e.Graphics.FillRectangle(new SolidBrush(theme.ToolStripSeparatorShadowColor), shadowRect);
        }
        else
        {
            Rectangle separatorRect = new(3, 5, 1, e.Item.Height - 10);
            Rectangle shadowRect = new(4, 6, 1, e.Item.Height - 10);
            e.Graphics.FillRectangle(new SolidBrush(theme.ToolStripSeparatorColor), separatorRect);
            e.Graphics.FillRectangle(new SolidBrush(theme.ToolStripSeparatorShadowColor), shadowRect);
        }
    }

    protected override void OnRenderToolStripBorder(ToolStripRenderEventArgs e)
    {
        //base.OnRenderToolStripBorder(e)
        Pen border = new(theme.ToolStripBorderColor);
        Rectangle rect = new(e.AffectedBounds.X, e.AffectedBounds.Y, e.AffectedBounds.Width - 1, e.AffectedBounds.Height - 1);
        e.Graphics.DrawPath(border, Theme.GetRoundedRectanglePath(rect, theme.ButtonRadius));
    }

    protected override void OnRenderToolStripBackground(ToolStripRenderEventArgs e)
    {
        //base.OnRenderToolStripBackground(e);
        var gradientMode = theme.HasVerticalToolbarGradient ? LinearGradientMode.Vertical : LinearGradientMode.Horizontal;
        if (e.ToolStrip.Orientation == Orientation.Vertical) // Flip if other orientation
            gradientMode = theme.HasVerticalToolbarGradient ? LinearGradientMode.Horizontal : LinearGradientMode.Vertical;

        LinearGradientBrush background = new(e.AffectedBounds, theme.ToolStripBackColor1, theme.ToolStripBackColor2, gradientMode);
        SolidBrush shadow = new(theme.ToolStripInsetColor);
        Rectangle shadowRect = new(0, e.ToolStrip.Height - 2, e.ToolStrip.Width, 1);
        Rectangle rect = new(e.AffectedBounds.X, e.AffectedBounds.Y, e.AffectedBounds.Width + 1, e.AffectedBounds.Height + 1);

        e.Graphics.FillPath(background, Theme.GetRoundedRectanglePath(rect, theme.ButtonRadius));
        e.Graphics.FillPath(shadow, Theme.GetRoundedRectanglePath(shadowRect, theme.ButtonRadius));
    }

    protected override void OnRenderButtonBackground(ToolStripItemRenderEventArgs e)
    {
        //base.OnRenderButtonBackground(e);
        Rectangle rectBorder = new(1, 1, e.Item.Width - 2, e.Item.Height - 2);
        Rectangle rect = new(1, 1, e.Item.Width - 2, e.Item.Height - 2);

        if (e.Item.Selected || ((ToolStripButton)e.Item).Checked)
        {
            LinearGradientBrush background = new(rect, theme.ToolStripButtonSelectedColor1, theme.ToolStripButtonSelectedColor2, LinearGradientMode.Vertical);
            Pen border = new(theme.ToolStripButtonSelectedBorderColor);
            e.Graphics.FillPath(background, Theme.GetRoundedRectanglePath(rect, theme.ButtonRadius));
            e.Graphics.DrawPath(border, Theme.GetRoundedRectanglePath(rectBorder, theme.ButtonRadius));
        }
        if (e.Item.Pressed)
        {
            LinearGradientBrush background = new(rect, theme.ToolStripButtonPressedColor1, theme.ToolStripButtonPressedColor2, LinearGradientMode.Vertical);
            Pen border = new(theme.ToolStripButtonPressedBorderColor);
            e.Graphics.FillPath(background, Theme.GetRoundedRectanglePath(rect, theme.ButtonRadius));
            e.Graphics.DrawPath(border, Theme.GetRoundedRectanglePath(rectBorder, theme.ButtonRadius));
        }
    }
}
