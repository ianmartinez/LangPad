﻿using System.Drawing;
using System.Drawing.Drawing2D;

namespace LangPadUI.Theming;

/// <summary>
/// A class storing all of the color and renderer resources
/// needed for a LangPad theme. Also contains static functions
/// to make creating some theme graphics easier.
/// </summary>
public abstract class Theme
{
    public string Name { get; set; }
    public ThemeMenuRenderer MenuRenderer { get; }
    public ThemeToolStripRenderer ToolStripRenderer { get; }

    public Theme(string name)
    {
        Name = name;
        MenuRenderer = new ThemeMenuRenderer(this);
        ToolStripRenderer = new ThemeToolStripRenderer(this);
    }

    /**
     * Main colors
     */
    public Color Color1 { get; set; } = Color.FromArgb(255, 255, 255, 255);
    public Color Color2 { get; set; } = Color.FromArgb(255, 255, 255, 255);
    public Color PanelBackColor { get; set; } = Color.FromArgb(255, 245, 245, 245);
    public Color PanelBorderColor { get; set; } = Color.FromArgb(255, 210, 210, 210);
    public Color PanelTextColor { get; set; } = Color.Black;
    public Color FormBackColor { get; set; } = Color.FromArgb(255, 245, 245, 245);
    public Color FormTextColor { get; set; } = Color.Black;
    public Color TabBackColor { get; set; } = SystemColors.Window;
    public Color TabTextColor { get; set; } = SystemColors.ControlText;
    public bool HasVerticalMenuGradient { get; set; } = true;
    public int ButtonRadius { get; set; } = 1;

    /**
     * ToolStrip colors
     */
    public bool HasVerticalToolbarGradient { get; set; } = true;
    public Color ToolStripTextColor { get; set; } = Color.Black;
    public Color ToolStripSeparatorColor { get; set; } = Color.FromArgb(255, 203, 204, 205);
    public Color ToolStripSeparatorShadowColor { get; set; } = Color.FromArgb(255, 255, 255, 255);
    public Color ToolStripBorderColor { get; set; } = Color.FromArgb(255, 210, 210, 210);
    public Color ToolStripBackColor1 { get; set; } = Color.FromArgb(255, 245, 245, 245);
    public Color ToolStripBackColor2 { get; set; } = Color.FromArgb(255, 230, 230, 230);
    public Color ToolStripInsetColor { get; set; } = Color.FromArgb(30, 255, 255, 255);
    public Color ToolStripButtonSelectedColor1 { get; set; } = Color.FromArgb(100, 223, 242, 252);
    public Color ToolStripButtonSelectedColor2 { get; set; } = Color.FromArgb(205, 223, 242, 252);
    public Color ToolStripButtonSelectedBorderColor { get; set; } = Color.FromArgb(225, 148, 188, 209);
    public Color ToolStripButtonPressedColor1 { get; set; } = Color.FromArgb(100, 180, 198, 207);
    public Color ToolStripButtonPressedColor2 { get; set; } = Color.FromArgb(205, 180, 198, 207);
    public Color ToolStripButtonPressedBorderColor { get; set; } = Color.FromArgb(225, 145, 160, 167);

    /**
     * Menu colors
     */
    public Color MenuTextColor { get; set; } = Color.Black;
    public Color MenuBarBorderColor { get; set; } = Color.Transparent;
    public Color MenuBarBackColor1 { get; set; } = Color.FromArgb(255, 250, 250, 250);
    public Color MenuBarBackColor2 { get; set; } = Color.FromArgb(255, 242, 242, 242);
    public Color MenuBackColor { get; set; } = Color.FromArgb(255, 246, 246, 246);
    public Color MenuBorderColor { get; set; } = Color.FromArgb(255, 160, 160, 160);
    public Color MenuArrowColor { get; set; } = Color.Black;
    public Color MenuImageMarginBackColor1 { get; set; } = Color.FromArgb(255, 238, 238, 238);
    public Color MenuImageMarginBackColor2 { get; set; } = Color.FromArgb(255, 218, 218, 218);
    public Color MenuImageMarginBorderColor { get; set; } = Color.FromArgb(255, 207, 207, 207);
    public Color MenuImageMarginInsetColor { get; set; } = Color.White;
    public Color MenuSeparatorColor { get; set; } = Color.FromArgb(255, 207, 207, 207);
    public Color MenuSeparatorShadowColor { get; set; } = Color.FromArgb(100, 255, 255, 255);
    public Color MenuButtonSelectedColor1 { get; set; } = Color.FromArgb(100, 223, 242, 252);
    public Color MenuButtonSelectedColor2 { get; set; } = Color.FromArgb(205, 223, 242, 252);
    public Color MenuButtonSelectedBorderColor { get; set; } = Color.FromArgb(225, 148, 188, 209);
    public Color MenuButtonSelectedInsetColor { get; set; } = Color.FromArgb(225, 240, 240, 240);
    public Color MenuButtonPressedColor1 { get; set; } = Color.FromArgb(100, 180, 198, 207);
    public Color MenuButtonPressedColor2 { get; set; } = Color.FromArgb(205, 180, 198, 207);
    public Color MenuButtonPressedBorderColor { get; set; } = Color.FromArgb(225, 145, 160, 167);
    public Color MenuButtonPressedInsetColor { get; set; } = Color.FromArgb(225, 215, 230, 238);

    /// <summary>
    /// Create a rounded rectangle path.
    /// </summary>
    /// 
    /// <param name="area">The rectangle's area.</param>
    /// <param name="radius">The border radius.</param>
    /// 
    /// <returns>The path of the rounded rectangle.</returns>
    public static GraphicsPath GetRoundedRectanglePath(Rectangle area, int radius)
    {
        GraphicsPath roundedRectPath = new();

        if (area.Width < radius * 2 || area.Height < radius * 2)
        {
            roundedRectPath.AddEllipse(area);
            return roundedRectPath;
        }

        PointF[] CurvePoints = [ new PointF(area.X, area.Y + radius),
                                         new PointF(area.X + radius / (float)3, area.Y + radius / (float)3),
                                         new PointF(area.X + radius, area.Y) ];

        roundedRectPath.AddCurve(CurvePoints, 1);
        roundedRectPath.AddLine(CurvePoints[2], new PointF(area.Right - radius, area.Y));

        CurvePoints[0] = new PointF(area.Right - radius, area.Y);
        CurvePoints[1] = new PointF(area.Right - radius / (float)3, area.Y + radius / (float)3);
        CurvePoints[2] = new PointF(area.Right, area.Y + radius);

        roundedRectPath.AddCurve(CurvePoints, 1);
        roundedRectPath.AddLine(CurvePoints[2], new PointF(area.Right, area.Bottom - radius));

        CurvePoints[0] = new PointF(area.Right, area.Bottom - radius);
        CurvePoints[1] = new PointF(area.Right - radius / (float)3, area.Bottom - radius / (float)3);
        CurvePoints[2] = new PointF(area.Right - radius, area.Bottom);

        roundedRectPath.AddCurve(CurvePoints, 1);
        roundedRectPath.AddLine(CurvePoints[2], new PointF(area.X + radius, area.Bottom));

        CurvePoints[0] = new PointF(area.X + radius, area.Bottom);
        CurvePoints[1] = new PointF(area.X + radius / (float)3, area.Bottom - radius / (float)3);
        CurvePoints[2] = new PointF(area.X, area.Bottom - radius);

        roundedRectPath.AddCurve(CurvePoints, 1);
        roundedRectPath.AddLine(CurvePoints[2], new PointF(area.X, area.Y + radius));

        return roundedRectPath;
    }

    public static void DrawRoundedRectangle(Graphics g, Rectangle rect, int radius, Color color)
    {
        var pen = new Pen(color);
        g.DrawPath(pen, GetRoundedRectanglePath(rect, radius));
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
