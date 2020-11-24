using System;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace LangPad.Controls
{
    /// <summary>
    /// A tooltip displayed when hovering over a character button.
    /// </summary>
    public class IpaToolTip : ToolTip
    {
        private readonly Font charNameFont = new Font("Calibri", 12, FontStyle.Regular);
        private readonly Font textFont = new Font("Calibri", 42, FontStyle.Bold);
        public string CharName { get; set; } = "";

        public IpaToolTip() : base()
        {
            CreateTooltip();
        }

        public IpaToolTip(IContainer Cont) : base(Cont)
        {
            CreateTooltip();
        }

        private void CreateTooltip()
        {
            OwnerDraw = true;

            Draw += IpaToolTip_Draw;
            Popup += IpaToolTip_Popup;
        }

        private void IpaToolTip_Popup(object sender, PopupEventArgs e)
        {
            var charSize = TextRenderer.MeasureText(GetToolTip(e.AssociatedControl), textFont);
            var nameSize = TextRenderer.MeasureText(CharName, charNameFont);
            var padding = new Size(12, string.IsNullOrWhiteSpace(CharName) ? 14 : 16);
            e.ToolTipSize = new Size(Math.Max(nameSize.Width, charSize.Width) + padding.Width, (nameSize.Height + charSize.Height) + padding.Height);
        }

        private void IpaToolTip_Draw(object sender, DrawToolTipEventArgs e)
        {
            var rect = new Rectangle(0, 0, e.Bounds.Width - 1, e.Bounds.Height - 1);
            var background = new LinearGradientBrush(rect, Color.FromArgb(60, 60, 60), Color.FromArgb(20, 20, 20), 90);
            var border = new Pen(Color.FromArgb(0, 0, 0));

            e.Graphics.FillRectangle(background, rect);
            e.Graphics.DrawRectangle(border, rect);

            var charNameSize = TextRenderer.MeasureText(CharName, charNameFont);
            var hasCharName = !string.IsNullOrWhiteSpace(CharName);
            var nameCenterX = e.Bounds.Left + ((e.Bounds.Width / 2) - (charNameSize.Width / 2));
            var centerY = (e.Bounds.Top) + (hasCharName ? charNameSize.Height + 6 + 3 : 0);
            var textSize = TextRenderer.MeasureText(e.ToolTipText, textFont);
            var textCenterX = (int)Math.Round(e.Bounds.Left + 3 + ((double)(e.Bounds.Width) / 2) - ((double)textSize.Width / 2));

            // Draw the name
            if (hasCharName)
            {
                var nameRect = new Rectangle(nameCenterX, e.Bounds.Top + 3, e.Bounds.Right, e.Bounds.Bottom - 6);
                var nameShadowRect = new Rectangle(nameRect.X + 1, nameRect.Y + 1, nameRect.Width, nameRect.Height);
                e.Graphics.DrawString(CharName, charNameFont, new SolidBrush(Color.Black), nameShadowRect);
                e.Graphics.DrawString(CharName, charNameFont, new SolidBrush(Color.Gainsboro), nameRect);
            }

            // Draw the character
            var textRect = new Rectangle(textCenterX, centerY, e.Bounds.Right, e.Bounds.Bottom - 6);
            var textShadowRect = new Rectangle(textRect.X + 2, textRect.Y + 2, textRect.Width, textRect.Height);
            e.Graphics.DrawString(e.ToolTipText, textFont, new SolidBrush(Color.Black), textShadowRect);
            e.Graphics.DrawString(e.ToolTipText, textFont, new SolidBrush(Color.White), textRect);
        }
    }
}