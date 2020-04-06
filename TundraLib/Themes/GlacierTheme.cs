using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace TundraLib.Themes
{
    public static class GlacierColors
    {
        public static Color GlacierHorBG_GrayBlue = Color.FromArgb(255, 243, 244, 245);
        public static Color GlacierHorBG_White = Color.FromArgb(255, 255, 255, 255);
        public static Color GlacierSubmenuBG = Color.FromArgb(255, 246, 246, 246);
        public static Color GlacierImageMarginBlue = Color.FromArgb(255, 212, 216, 230);
        public static Color GlacierImageMarginWhite = Color.FromArgb(255, 232, 251, 255);
        public static Color GlacierImageMarginLine = Color.FromArgb(255, 207, 207, 207);
        public static Color GlacierSelectedBG_Blue = Color.FromArgb(255, 180, 198, 207);
        public static Color GlacierSelectedBG_Header_Blue = Color.FromArgb(255, 146, 202, 230);
        public static Color GlacierSelectedBG_White = Color.FromArgb(255, 195, 219, 232);
        public static Color GlacierSelectedBG_Border = Color.FromArgb(255, 145, 160, 167);
        public static Color GlacierSelectedBG_Drop_Blue = Color.FromArgb(255, 195, 219, 232);
        public static Color GlacierSelectedBG_Drop_Border = Color.FromArgb(255, 145, 160, 167);
        public static Color GlacierMenuBorder = Color.FromArgb(255, 160, 160, 160);
        public static Color GlacierCheckBG = Color.FromArgb(255, 206, 237, 250);

        public static Color GlacierVerBG_GrayBlue = Color.FromArgb(255, 196, 203, 219);
        public static Color GlacierVerBG_White = Color.FromArgb(255, 250, 250, 250);
        public static Color GlacierVerBG_Shadow = Color.FromArgb(255, 245, 245, 245);

        public static Color GlacierToolstripBtnGrad_Blue = Color.FromArgb(255, 223, 242, 252);
        public static Color GlacierToolstripBtnGrad_White = Color.FromArgb(255, 223, 242, 252);
        public static Color GlacierToolstripBtn_Border = Color.FromArgb(255, 148, 188, 209);
        public static Color GlacierToolstripBtnGrad_Blue_Pressed = Color.FromArgb(255, 124, 177, 204);
        public static Color GlacierToolstripBtnGrad_White_Pressed = Color.FromArgb(255, 228, 245, 252);

        public static Color GlacierHorBG_Color1 = Color.FromArgb(0, 250, 250, 250);
        public static Color GlacierHorBG_Color2 = Color.FromArgb(0, 242, 242, 242);

        public static Color GlacierImageMarginBG_Color1 = Color.FromArgb(255, 218, 218, 218);
        public static Color GlacierImageMarginBG_Color2 = Color.FromArgb(255, 238, 238, 238);

        public static Color GlacierSelected1 = Color.FromArgb(100, 223, 242, 252);
        public static Color GlacierSelected2 = Color.FromArgb(205, 223, 242, 252);
        public static Color GlacierSelectedBorder = Color.FromArgb(225, 148, 188, 209);
        public static Color GlacierSelectedShadow = Color.FromArgb(225, 240, 240, 240);

        public static Color GlacierDrop1 = Color.FromArgb(100, 180, 198, 207);
        public static Color GlacierDrop2 = Color.FromArgb(205, 180, 198, 207);
        public static Color GlacierDropBorder = Color.FromArgb(225, 145, 160, 167);
        public static Color GlacierDropShadow = Color.FromArgb(225, 215, 230, 238);

        public static Color GlacierSep = Color.FromArgb(255, 203, 204, 205);
        public static Color GlacierSepWhite = Color.FromArgb(255, 255, 255, 255);
    }

    public class GlacierMenuRenderer : ToolStripRenderer
    {
        // Make sure the textcolor is black
        protected override void InitializeItem(ToolStripItem item)
        {
            base.InitializeItem(item);
            item.ForeColor = Color.Black;
        }

        protected override void Initialize(ToolStrip toolStrip)
        {
            base.Initialize(toolStrip);
            toolStrip.ForeColor = Color.Black;
        }

        // Render horizontal bakcground gradient
        protected override void OnRenderToolStripBackground(ToolStripRenderEventArgs e)
        {
            base.OnRenderToolStripBackground(e);

            LinearGradientBrush b = new LinearGradientBrush(e.AffectedBounds, Color.FromArgb(255, 255, 255, 255), Color.FromArgb(255, 245, 245, 245), LinearGradientMode.Vertical);
            e.Graphics.FillRectangle(b, e.AffectedBounds);
        }

        // Render Image Margin and gray itembackground
        protected override void OnRenderImageMargin(ToolStripRenderEventArgs e)
        {
            base.OnRenderImageMargin(e);

            // Draw ImageMargin background gradient
            LinearGradientBrush b = new LinearGradientBrush(e.AffectedBounds, GlacierColors.GlacierImageMarginBG_Color2, GlacierColors.GlacierImageMarginBG_Color1, LinearGradientMode.Horizontal);

            // Shadow at the right of image margin
            SolidBrush DarkLine = new SolidBrush(GlacierColors.GlacierImageMarginLine);
            SolidBrush WhiteLine = new SolidBrush(Color.White);
            Rectangle rect = new Rectangle(e.AffectedBounds.Width, 2, 1, e.AffectedBounds.Height);
            Rectangle rect2 = new Rectangle(e.AffectedBounds.Width + 1, 2, 1, e.AffectedBounds.Height);

            // Gray background
            SolidBrush SubmenuBGbrush = new SolidBrush(GlacierColors.GlacierSubmenuBG);
            Rectangle rect3 = new Rectangle(0, 0, e.ToolStrip.Width, e.ToolStrip.Height);

            // Border
            Pen borderPen = new Pen(GlacierColors.GlacierMenuBorder);
            Rectangle rect4 = new Rectangle(0, 1, e.ToolStrip.Width - 1, e.ToolStrip.Height - 2);

            e.Graphics.FillRectangle(SubmenuBGbrush, rect3);
            e.Graphics.FillRectangle(b, e.AffectedBounds);
            e.Graphics.FillRectangle(DarkLine, rect);
            e.Graphics.FillRectangle(WhiteLine, rect2);
            e.Graphics.DrawRectangle(borderPen, rect4);
        }

        // Render Checkmark 
        protected override void OnRenderItemCheck(ToolStripItemImageRenderEventArgs e)
        {
            var imgSize = new Size(22, 22);

            if (e.Item.Image != null)
                imgSize = e.Item.Image.Size;

            // MyBase.OnRenderItemCheck(e)
            Rectangle rect = new Rectangle(3, 1, imgSize.Width + 4, imgSize.Height + 4);
            Rectangle rect2 = new Rectangle(4, 2, imgSize.Width + 2, imgSize.Height + 2);
            if (e.Item.Selected)
            {
                SolidBrush b = new SolidBrush(GlacierColors.GlacierToolstripBtn_Border);
                SolidBrush b2 = new SolidBrush(GlacierColors.GlacierCheckBG);

                e.Graphics.FillRectangle(b, rect);
                e.Graphics.FillRectangle(b2, rect2);
            }
            else
            {
                SolidBrush b = new SolidBrush(GlacierColors.GlacierSelectedBG_Drop_Border);
                SolidBrush b2 = new SolidBrush(GlacierColors.GlacierCheckBG);

                e.Graphics.FillRectangle(b, rect);
                e.Graphics.FillRectangle(b2, rect2);
            }
        }

        // Render separator
        protected override void OnRenderSeparator(ToolStripSeparatorRenderEventArgs e)
        {
            base.OnRenderSeparator(e);

            SolidBrush DarkLine = new SolidBrush(GlacierColors.GlacierImageMarginLine);
            SolidBrush WhiteLine = new SolidBrush(Color.White);
            Rectangle rect = new Rectangle(42, 3, e.Item.Width - 42, 1);
            Rectangle rect2 = new Rectangle(42, 4, e.Item.Width - 42, 1);
            e.Graphics.FillRectangle(DarkLine, rect);
            e.Graphics.FillRectangle(WhiteLine, rect2);
        }

        // Render arrow
        protected override void OnRenderArrow(ToolStripArrowRenderEventArgs e)
        {
            e.ArrowColor = Color.Black;
            base.OnRenderArrow(e);
        }

        // Render Menuitem background: lightblue if selected, darkblue if dropped down
        protected override void OnRenderMenuItemBackground(ToolStripItemRenderEventArgs e)
        {
            base.OnRenderMenuItemBackground(e);

            e.Item.ForeColor = Color.Black;
            if (e.Item.Enabled)
            {
                if (e.Item.IsOnDropDown == false && e.Item.Selected)
                {
                    // If item is MenuHeader and selected: draw darkblue border

                    Rectangle rect = new Rectangle(3, 2, e.Item.Width - 6, e.Item.Height - 4);
                    LinearGradientBrush b = new LinearGradientBrush(rect, GlacierColors.GlacierSelected1, GlacierColors.GlacierSelected2, LinearGradientMode.Vertical);

                    e.Graphics.FillRectangle(b, rect);
                    Theme.DrawRoundedRectangle(e.Graphics, rect.Left - 1, rect.Top - 1, rect.Width, rect.Height + 1, 1, GlacierColors.GlacierToolstripBtn_Border);
                    Theme.DrawRoundedRectangle(e.Graphics, rect.Left - 2, rect.Top - 2, rect.Width + 2, rect.Height + 3, 1, GlacierColors.GlacierSelectedShadow);
                    e.Item.ForeColor = Color.Black;
                }
                else if (e.Item.IsOnDropDown && e.Item.Selected)
                {
                    // If item is NOT menuheader (but subitem) and selected: draw lightblue border

                    Rectangle rect = new Rectangle(4, 2, e.Item.Width - 6, e.Item.Height - 4);
                    LinearGradientBrush b = new LinearGradientBrush(rect, GlacierColors.GlacierSelected1, GlacierColors.GlacierSelected2, LinearGradientMode.Vertical);

                    e.Graphics.FillRectangle(b, rect);
                    Theme.DrawRoundedRectangle(e.Graphics, rect.Left - 1, rect.Top - 1, rect.Width, rect.Height + 1, 1, GlacierColors.GlacierToolstripBtn_Border);
                    e.Item.ForeColor = Color.Black;
                }

                // If item is MenuHeader and menu is dropped down: selection rectangle is now darker
                if (((ToolStripMenuItem)e.Item).DropDown.Visible && e.Item.IsOnDropDown == false)
                {
                    Rectangle rect = new Rectangle(3, 2, e.Item.Width - 6, e.Item.Height - 4);
                    LinearGradientBrush b = new LinearGradientBrush(rect, GlacierColors.GlacierDrop1, GlacierColors.GlacierDrop2, LinearGradientMode.Vertical);

                    e.Graphics.FillRectangle(b, rect);
                    Theme.DrawRoundedRectangle(e.Graphics, rect.Left - 1, rect.Top - 1, rect.Width, rect.Height + 1, 1, GlacierColors.GlacierSelectedBG_Drop_Border);
                    Theme.DrawRoundedRectangle(e.Graphics, rect.Left - 2, rect.Top - 2, rect.Width + 2, rect.Height + 3, 1, GlacierColors.GlacierDropShadow);
                    e.Item.ForeColor = Color.Black;
                }
            }
        }
    }

    public class GlacierToolstripRenderer : ToolStripProfessionalRenderer
    {
        // Render separator
        protected override void OnRenderSeparator(ToolStripSeparatorRenderEventArgs e)
        {
            base.OnRenderSeparator(e);
            if (e.ToolStrip.Orientation == Orientation.Vertical)
            {
                Rectangle rect = new Rectangle(2, 3, e.Item.Width - 4, 1);
                Rectangle rect2 = new Rectangle(3, 4, e.Item.Width - 5, 1);
                e.Graphics.FillRectangle(new SolidBrush(GlacierColors.GlacierSep), rect);
                e.Graphics.FillRectangle(new SolidBrush(GlacierColors.GlacierSepWhite), rect2);
            }
            else
            {
                Rectangle rect = new Rectangle(3, 5, 1, e.Item.Height - 10);
                Rectangle rect2 = new Rectangle(4, 6, 1, e.Item.Height - 10);
                e.Graphics.FillRectangle(new SolidBrush(GlacierColors.GlacierSep), rect);
                e.Graphics.FillRectangle(new SolidBrush(GlacierColors.GlacierSepWhite), rect2);
            }
        }

        protected override void OnRenderToolStripBorder(ToolStripRenderEventArgs e)
        {
            // MyBase.OnRenderToolStripBorder(e)

            Pen shadow = new Pen(GlacierColors.GlacierVerBG_Shadow);
            Rectangle rect = new Rectangle(e.AffectedBounds.X, e.AffectedBounds.Y, e.AffectedBounds.Width - 1, e.AffectedBounds.Height);
            e.Graphics.DrawRectangle(shadow, rect);
        }

        // Render container background gradient
        protected override void OnRenderToolStripBackground(ToolStripRenderEventArgs e)
        {
            // MyBase.OnRenderToolStripBackground(e)
            LinearGradientBrush b = new LinearGradientBrush(e.AffectedBounds, GlacierColors.GlacierHorBG_Color1, GlacierColors.GlacierHorBG_Color2, LinearGradientMode.Vertical);
            SolidBrush shadow = new SolidBrush(GlacierColors.GlacierVerBG_Shadow);
            Rectangle rect = new Rectangle(0, e.ToolStrip.Height - 2, e.ToolStrip.Width, 1);
            e.Graphics.FillRectangle(b, e.AffectedBounds);
            e.Graphics.FillRectangle(shadow, rect);
        }

        // Render button selected and pressed state
        protected override void OnRenderButtonBackground(ToolStripItemRenderEventArgs e)
        {
            // MyBase.OnRenderButtonBackground(e)
            if (e.Item.Selected || ((ToolStripButton)e.Item).Checked)
            {
                Rectangle rectBorder = new Rectangle(1, 1, e.Item.Width - 2, e.Item.Height - 2);
                Rectangle rect = new Rectangle(1, 1, e.Item.Width - 2, e.Item.Height - 2);
                LinearGradientBrush b = new LinearGradientBrush(rect, GlacierColors.GlacierSelected1, GlacierColors.GlacierSelected2, LinearGradientMode.Vertical);
                Pen b2 = new Pen(GlacierColors.GlacierSelectedBorder);

                e.Graphics.FillRectangle(b, rect);
                e.Graphics.DrawRectangle(b2, rectBorder);
            }
            if (e.Item.Pressed)
            {
                Rectangle rectBorder = new Rectangle(1, 1, e.Item.Width - 2, e.Item.Height - 2);
                Rectangle rect = new Rectangle(1, 1, e.Item.Width - 2, e.Item.Height - 2);
                LinearGradientBrush b = new LinearGradientBrush(rect, GlacierColors.GlacierDrop1, GlacierColors.GlacierDrop2, LinearGradientMode.Vertical);
                Pen b2 = new Pen(GlacierColors.GlacierDropBorder);

                e.Graphics.FillRectangle(b, rect);
                e.Graphics.DrawRectangle(b2, rectBorder);
            }
        }
    }

}
