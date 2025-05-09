﻿using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace LangPadUI.Theming;

/// <summary>
/// Render a menu based on a theme.
/// </summary>
public class ThemeMenuRenderer(Theme theme) : ToolStripRenderer()
{
    protected override void InitializeItem(ToolStripItem item)
    {
        base.InitializeItem(item);
        item.ForeColor = theme.MenuTextColor;
    }

    protected override void Initialize(ToolStrip toolStrip)
    {
        base.Initialize(toolStrip);
        toolStrip.ForeColor = theme.MenuTextColor;
    }

    protected override void OnRenderToolStripBackground(ToolStripRenderEventArgs e)
    {
        //base.OnRenderToolStripBackground(e);
        var gradientMode = theme.HasVerticalMenuGradient ? LinearGradientMode.Vertical : LinearGradientMode.Horizontal;
        LinearGradientBrush background = new(e.AffectedBounds, theme.MenuBarBackColor1, theme.MenuBarBackColor2, gradientMode);
        e.Graphics.FillRectangle(background, e.AffectedBounds);
        Pen border = new(theme.MenuBarBorderColor);
        e.Graphics.DrawRectangle(border, e.AffectedBounds);
    }

    protected override void OnRenderImageMargin(ToolStripRenderEventArgs e)
    {
        //base.OnRenderImageMargin(e);

        // Fill background of menu
        SolidBrush menuBack = new(theme.MenuBackColor);
        Rectangle menuBackRect = new(0, 0, e.ToolStrip.Width, e.ToolStrip.Height);
        e.Graphics.FillRectangle(menuBack, menuBackRect);

        // Fill image margin
        LinearGradientBrush imageMarginBack = new(e.AffectedBounds, theme.MenuImageMarginBackColor1, theme.MenuImageMarginBackColor2, LinearGradientMode.Horizontal);
        e.Graphics.FillRectangle(imageMarginBack, e.AffectedBounds);

        // Image margin border
        SolidBrush imageMarginBorder = new(theme.MenuImageMarginBorderColor);
        Rectangle imageMarginBorderRect = new(e.AffectedBounds.Width, 2, 1, e.AffectedBounds.Height);
        e.Graphics.FillRectangle(imageMarginBorder, imageMarginBorderRect);

        // Shadow at the right of image margin
        SolidBrush imageMarginInset = new(theme.MenuImageMarginInsetColor);
        Rectangle imageMarginInsetRect = new(e.AffectedBounds.Width + 1, 2, 1, e.AffectedBounds.Height);
        e.Graphics.FillRectangle(imageMarginInset, imageMarginInsetRect);

        // Border
        Pen menuBorder = new(theme.MenuBorderColor);
        Rectangle menuBorderRect = new(0, 0, e.ToolStrip.Width - 1, e.ToolStrip.Height - 1);
        e.Graphics.DrawRectangle(menuBorder, menuBorderRect);
    }

    protected override void OnRenderSeparator(ToolStripSeparatorRenderEventArgs e)
    {
        //base.OnRenderSeparator(e);
        int offset = 0;

        SolidBrush separator = new(theme.MenuSeparatorColor);
        Rectangle separatorRect = new(offset, 3, e.Item.Width - offset, 1);
        e.Graphics.FillRectangle(separator, separatorRect);

        SolidBrush separatorShadow = new(theme.MenuSeparatorShadowColor);
        Rectangle separatorShadowRect = new(offset, 4, e.Item.Width - offset, 1);
        e.Graphics.FillRectangle(separatorShadow, separatorShadowRect);
    }

    protected override void OnRenderArrow(ToolStripArrowRenderEventArgs e)
    {
        e.ArrowColor = theme.MenuArrowColor;
        base.OnRenderArrow(e);
    }

    protected override void OnRenderMenuItemBackground(ToolStripItemRenderEventArgs e)
    {
        //base.OnRenderMenuItemBackground(e);
        e.Item.ForeColor = theme.MenuTextColor;
        Rectangle backgroundRect = new(4, 2, e.Item.Width - 6, e.Item.Height - 4);
        Rectangle borderRect = new(backgroundRect.Left - 1, backgroundRect.Top - 1, backgroundRect.Width, backgroundRect.Height + 1);
        Rectangle shadowRect = new(backgroundRect.Left - 2, backgroundRect.Top - 2, backgroundRect.Width + 2, backgroundRect.Height + 3);

        if (e.Item.Enabled)
        {
            if (!e.Item.IsOnDropDown && e.Item.Selected)
            {
                // If item is menu header and selected
                LinearGradientBrush background = new(backgroundRect, theme.MenuButtonSelectedColor1, theme.MenuButtonSelectedColor2, LinearGradientMode.Vertical);
                e.Graphics.FillRectangle(background, backgroundRect);
                Theme.DrawRoundedRectangle(e.Graphics, borderRect, theme.ButtonRadius, theme.MenuButtonSelectedBorderColor);
                Theme.DrawRoundedRectangle(e.Graphics, shadowRect, theme.ButtonRadius, theme.MenuButtonSelectedInsetColor);
                e.Item.ForeColor = theme.MenuTextColor;
            }
            else if (e.Item.IsOnDropDown && e.Item.Selected)
            {
                // If item is NOT menu header (but sub-item) and selected
                LinearGradientBrush background = new(backgroundRect, theme.MenuButtonSelectedColor1, theme.MenuButtonSelectedColor2, LinearGradientMode.Vertical);
                e.Graphics.FillRectangle(background, backgroundRect);
                Theme.DrawRoundedRectangle(e.Graphics, borderRect, theme.ButtonRadius, theme.MenuButtonSelectedBorderColor);
                e.Item.ForeColor = theme.MenuTextColor;
            }

            if (((ToolStripMenuItem)e.Item).DropDown.Visible && e.Item.IsOnDropDown == false)
            {
                // If item is menu header and menu is dropped down
                LinearGradientBrush background = new(backgroundRect, theme.MenuButtonPressedColor1, theme.MenuButtonPressedColor2, LinearGradientMode.Vertical);
                e.Graphics.FillRectangle(background, backgroundRect);
                Theme.DrawRoundedRectangle(e.Graphics, borderRect, theme.ButtonRadius, theme.MenuButtonPressedBorderColor);
                Theme.DrawRoundedRectangle(e.Graphics, shadowRect, theme.ButtonRadius, theme.MenuButtonPressedInsetColor);
                e.Item.ForeColor = theme.MenuTextColor;
            }
        }
    }
}