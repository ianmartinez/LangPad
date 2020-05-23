using System;
using System.IO;
using System.Text;
using System.Windows.Forms;
using System.Drawing;
using System.Drawing.Printing;
using System.Drawing.Imaging;
using System.Collections.Specialized;
using System.Runtime.InteropServices;

namespace LangPadUI
{
    // Most of this is not my own code:
    // It is made from various projects on CodeProject smashed together, along with some of my own code

    /// <summary>
    /// The rich text box print control class was developed by Microsoft, information about
    /// this control can be found in your help files at:  
    /// ms-help://MS.VSCC.v80/MS.MSDN.v80/MS.KB.v10.en/enu_kbvbnetkb/vbnetkb/811401.htm
    /// In general, their intent was to create a rich text box control with print capability
    /// embedded into the control.
    /// </summary>
    /// 
    /// <remarks>
    /// This control class replaces the use of the regular RichTextBox control; the
    /// purpose of this extension was specifically to facilitate printing the contents
    /// of a rich text box control.
    /// </remarks>
    public class ExtendedRichTextBox : RichTextBox
    {
        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        public static extern IntPtr SendMessage(IntPtr hWnd, int Msg, int wParam, IntPtr lParam);

        [DllImport("USER32")]
        private static extern IntPtr SendMessage(IntPtr hWnd, int msg, IntPtr wp, IntPtr lp);

        [DllImport("gdiplus.dll", SetLastError = true)]
        private static extern uint GdipEmfToWmfBits(IntPtr hEmf, uint uBufferSize, byte[] bBuffer, int iMappingMode, EmfToWmfBitsFlags flags);


        // Convert the unit that is used by the .NET framework (1/100 inch) 
        // and the unit that is used by Win32 API calls (twips 1/1440 inch)
        private const double AnInch = 14.4;
        private const int WM_USER = 0x400;
        // Allows the x-coordinates and y-coordinates of the metafile to be adjusted
        // independently
        private const int MM_ANISOTROPIC = 8;
        // Represents an unknown font family
        private const string FF_UNKNOWN = "UNKNOWN";
        // The number of hundredths of millimeters (0.01 mm) in an inch
        // For more information, see GetImagePrefix() method.
        private const int HMM_PER_INCH = 2540;
        // The number of twips in an inch
        // For more information, see GetImagePrefix() method.
        private const int TWIPS_PER_INCH = 1440;
        // RTF document elements
        private const string RTF_HEADER = @"{\rtf1\ansi\ansicpg1252\deff0\deflang1033";
        private const string RTF_DOCUMENT_PRE = @"\viewkind4\uc1\pard\cf1\f0\fs20";
        private const string RTF_DOCUMENT_POST = @"\cf0\fs17}";
        private const string RTF_IMAGE_POST = "}";

        private const int EM_FORMATRANGE = WM_USER + 57;

        [StructLayout(LayoutKind.Sequential)]
        private struct RECT
        {
            public int Left;
            public int Top;
            public int Right;
            public int Bottom;
        }

        [StructLayout(LayoutKind.Sequential)]
        private struct CHARRANGE
        {
            public int cpMin;          // First character of range (0 for start of doc)
            public int cpMax;          // Last character of range (-1 for end of doc)
        }

        [StructLayout(LayoutKind.Sequential)]
        private struct FORMATRANGE
        {
            public IntPtr hdc;             // Actual DC to draw on
            public IntPtr hdcTarget;       // Target DC for determining text formatting
            public RECT rc;                // Region of the DC to draw to (in twips)
            public RECT rcPage;            // Region of the whole DC (page size) (in twips)
            public CHARRANGE chrg;         // Range of text to draw (see above declaration)
        }

        /// <summary>
        /// Enum for possible RTF colors.
        /// </summary>
        public enum RtfColor
        {
            Black,
            Maroon,
            Green,
            Olive,
            Navy,
            Purple,
            Teal,
            Gray,
            Silver,
            Red,
            Lime,
            Yellow,
            Blue,
            Fuchsia,
            Aqua,
            White
        }

        // Specifies the flags/options for the unmanaged call to the GDI+ method
        // Metafile.EmfToWmfBits().
        private enum EmfToWmfBitsFlags
        {
            // Use the default conversion
            EmfToWmfBitsFlagsDefault = 0x0,

            // Embedded the source of the EMF metafiel within the resulting WMF
            // metafile
            EmfToWmfBitsFlagsEmbedEmf = 0x1,

            // Place a 22-byte header in the resulting WMF file.  The header is
            // required for the metafile to be considered placeable.
            EmfToWmfBitsFlagsIncludePlaceable = 0x2,

            // Don't simulate clipping by using the XOR operator.
            EmfToWmfBitsFlagsNoXORClip = 0x4
        }

        /// <summary>
        /// Definitions for colors in an RTF document.
        /// </summary>
        private struct RtfColorDef
        {
            public const string Black = @"\red0\green0\blue0";
            public const string Maroon = @"\red128\green0\blue0";
            public const string Green = @"\red0\green128\blue0";
            public const string Olive = @"\red128\green128\blue0";
            public const string Navy = @"\red0\green0\blue128";
            public const string Purple = @"\red128\green0\blue128";
            public const string Teal = @"\red0\green128\blue128";
            public const string Gray = @"\red128\green128\blue128";
            public const string Silver = @"\red192\green192\blue192";
            public const string Red = @"\red255\green0\blue0";
            public const string Lime = @"\red0\green255\blue0";
            public const string Yellow = @"\red255\green255\blue0";
            public const string Blue = @"\red0\green0\blue255";
            public const string Fuchsia = @"\red255\green0\blue255";
            public const string Aqua = @"\red0\green255\blue255";
            public const string White = @"\red255\green255\blue255";
        }

        /// <summary>
        /// Control words for RTF font families.
        /// </summary>
        private struct RtfFontFamilyDef
        {
            public const string Unknown = @"\fnil";
            public const string Roman = @"\froman";
            public const string Swiss = @"\fswiss";
            public const string Modern = @"\fmodern";
            public const string Script = @"\fscript";
            public const string Decor = @"\fdecor";
            public const string Technical = @"\ftech";
            public const string BiDirect = @"\fbidi";
        }

        // The default text color
        private RtfColor m_textColor;

        // The default text background color
        private RtfColor highlightColor;

        // Dictionary that maps color enums to RTF color codes
        private HybridDictionary RtfColorDict;

        // Dictionary that mapas Framework font families to RTF font families
        private HybridDictionary rtfFontFamily;

        // The horizontal resolution at which the control is being displayed
        private float xDpi;

        // The vertical resolution at which the control is being displayed
        private float yDpi;

        public new string Rtf
        {
            get
            {
                return RemoveBadChars(base.Rtf);
            }
            set
            {
                base.Rtf = value;
            }
        }

        /// <summary>
        /// Initializes the text colors, creates dictionaries for RTF colors and
        /// font families, and stores the horizontal and vertical resolution of
        /// the RichTextBox's graphics context.
        /// </summary>
        public ExtendedRichTextBox() : base()
        {
            AcceptsTab = true;

            // Initialize default text and background colors
            m_textColor = RtfColor.Black;
            highlightColor = RtfColor.White;

            // Initialize the dictionary mapping color codes to definitions
            RtfColorDict = new HybridDictionary();
            RtfColorDict.Add(RtfColor.Aqua, RtfColorDef.Aqua);
            RtfColorDict.Add(RtfColor.Black, RtfColorDef.Black);
            RtfColorDict.Add(RtfColor.Blue, RtfColorDef.Blue);
            RtfColorDict.Add(RtfColor.Fuchsia, RtfColorDef.Fuchsia);
            RtfColorDict.Add(RtfColor.Gray, RtfColorDef.Gray);
            RtfColorDict.Add(RtfColor.Green, RtfColorDef.Green);
            RtfColorDict.Add(RtfColor.Lime, RtfColorDef.Lime);
            RtfColorDict.Add(RtfColor.Maroon, RtfColorDef.Maroon);
            RtfColorDict.Add(RtfColor.Navy, RtfColorDef.Navy);
            RtfColorDict.Add(RtfColor.Olive, RtfColorDef.Olive);
            RtfColorDict.Add(RtfColor.Purple, RtfColorDef.Purple);
            RtfColorDict.Add(RtfColor.Red, RtfColorDef.Red);
            RtfColorDict.Add(RtfColor.Silver, RtfColorDef.Silver);
            RtfColorDict.Add(RtfColor.Teal, RtfColorDef.Teal);
            RtfColorDict.Add(RtfColor.White, RtfColorDef.White);
            RtfColorDict.Add(RtfColor.Yellow, RtfColorDef.Yellow);

            rtfFontFamily = new HybridDictionary();
            rtfFontFamily.Add(FontFamily.GenericMonospace.Name, RtfFontFamilyDef.Modern);
            rtfFontFamily.Add(FontFamily.GenericSansSerif, RtfFontFamilyDef.Swiss);
            rtfFontFamily.Add(FontFamily.GenericSerif, RtfFontFamilyDef.Roman);
            rtfFontFamily.Add(FF_UNKNOWN, RtfFontFamilyDef.Unknown);

            using (Graphics _graphics = CreateGraphics())
            {
                xDpi = _graphics.DpiX;
                yDpi = _graphics.DpiY;
            }
        }

        public void AppendRtf(string _rtf)
        {
            // Move caret to the end of the text
            Select(TextLength, 0);

            // Since SelectedRtf is null, this will append the string to the
            // end of the existing RTF
            SelectedRtf = _rtf;
        }

        public void InsertRtf(string _rtf)
        {
            SelectedRtf = _rtf;
        }

        public void InsertTextAsRtf(string _text)
        {
            InsertTextAsRtf(_text, Font);
        }


        public void InsertTextAsRtf(string _text, Font _font)
        {
            InsertTextAsRtf(_text, _font, m_textColor);
        }

        public void InsertTextAsRtf(string _text, Font _font, RtfColor _textColor)
        {
            InsertTextAsRtf(_text, _font, _textColor, highlightColor);
        }

        public void InsertTextAsRtf(string _text, Font _font, RtfColor _textColor, RtfColor _backColor)
        {
            StringBuilder _rtf = new StringBuilder();

            // Append the RTF header
            _rtf.Append(RTF_HEADER);

            // Create the font table from the font passed in and append it to the
            // RTF string
            _rtf.Append(GetFontTable(_font));

            // Create the color table from the colors passed in and append it to the
            // RTF string
            _rtf.Append(GetColorTable(_textColor, _backColor));

            // Create the document area from the text to be added as RTF and append
            // it to the RTF string.
            _rtf.Append(GetDocumentArea(_text, _font));

            SelectedRtf = _rtf.ToString();
        }

        private string GetDocumentArea(string _text, Font _font)
        {
            StringBuilder _doc = new StringBuilder();

            // Append the standard RTF document area control string
            _doc.Append(RTF_DOCUMENT_PRE);

            // Set the highlight color (the color behind the text) to the
            // third color in the color table.  See GetColorTable for more details.
            _doc.Append(@"\highlight2");

            // If the font is bold, attach corresponding tag
            if (_font.Bold)
                _doc.Append(@"\b");

            // If the font is italic, attach corresponding tag
            if (_font.Italic)
                _doc.Append(@"\i");

            // If the font is strikeout, attach corresponding tag
            if (_font.Strikeout)
                _doc.Append(@"\strike");

            // If the font is underlined, attach corresponding tag
            if (_font.Underline)
                _doc.Append(@"\ul");

            // Set the font to the first font in the font table.
            // See GetFontTable for more details.
            _doc.Append(@"\f0");

            // Set the size of the font.  In RTF, font size is measured in
            // half-points, so the font size is twice the value obtained from
            // Font.SizeInPoints
            _doc.Append(@"\fs");
            _doc.Append(Convert.ToInt32(Math.Round((2 * _font.SizeInPoints))));

            // Apppend a space before starting actual text (for clarity)
            _doc.Append(" ");

            // Append actual text, however, replace newlines with RTF \par.
            // Any other special text should be handled here (e.g.) tabs, etc.
            _doc.Append(_text.Replace("\n", @"\par "));

            // RTF isn't strict when it comes to closing control words, but what the
            // heck ...

            // Remove the highlight
            _doc.Append(@"\highlight0");

            // If font is bold, close tag
            if (_font.Bold)
                _doc.Append(@"\b0");

            // If font is italic, close tag
            if (_font.Italic)
                _doc.Append(@"\i0");

            // If font is strikeout, close tag
            if (_font.Strikeout)
                _doc.Append(@"\strike0");

            // If font is underlined, close tag
            if (_font.Underline)
                _doc.Append(@"\ulnone");

            // Revert back to default font and size
            _doc.Append(@"\f0");
            _doc.Append(@"\fs20");

            // Close the document area control string
            _doc.Append(RTF_DOCUMENT_POST);

            return _doc.ToString();
        }

        public void InsertImage(Image _image)
        {
            Image img = (Image)_image.Clone();
            Graphics g = Graphics.FromImage(_image);
            g.Clear(BackColor);
            g.DrawImage(img, new Point(0, 0));
            StringBuilder _rtf = new StringBuilder();

            // Append the RTF header
            _rtf.Append(RTF_HEADER);

            // Create the font table using the RichTextBox's current font and append
            // it to the RTF string
            _rtf.Append(GetFontTable(Font));

            // Create the image control string and append it to the RTF string
            _rtf.Append(GetImagePrefix(_image));

            // Create the Windows Metafile and append its bytes in HEX format
            _rtf.Append(GetRtfImage(_image));

            // Close the RTF image control string
            _rtf.Append(RTF_IMAGE_POST);

            SelectedRtf = _rtf.ToString();
        }

        private string GetImagePrefix(Image _image)
        {
            StringBuilder _rtf = new StringBuilder();

            // Calculate the current width of the image in (0.01)mm
            int picw = Convert.ToInt32(Math.Round((_image.Width / (double)xDpi) * HMM_PER_INCH));

            // Calculate the current height of the image in (0.01)mm
            int pich = Convert.ToInt32(Math.Round((_image.Height / (double)yDpi) * HMM_PER_INCH));

            // Calculate the target width of the image in twips
            int picwgoal = Convert.ToInt32(Math.Round((_image.Width / (double)xDpi) * TWIPS_PER_INCH));

            // Calculate the target height of the image in twips
            int pichgoal = Convert.ToInt32(Math.Round((_image.Height / (double)yDpi) * TWIPS_PER_INCH));

            // Append values to RTF string
            _rtf.Append(@"{\pict\wmetafile8");
            _rtf.Append(@"\picw");
            _rtf.Append(picw);
            _rtf.Append(@"\pich");
            _rtf.Append(pich);
            _rtf.Append(@"\picwgoal");
            _rtf.Append(picwgoal);
            _rtf.Append(@"\pichgoal");
            _rtf.Append(pichgoal);
            _rtf.Append(" ");

            return _rtf.ToString();
        }

        private string GetRtfImage(Image _image)
        {
            StringBuilder _rtf = null;

            // Used to store the enhanced metafile
            MemoryStream _stream = null;


            // The enhanced metafile
            Metafile _metaFile = null/* TODO Change to default(_) if this is not a reference type */;

            // Handle to the device context used to create the metafile
            IntPtr _hdc;

            try
            {
                _rtf = new StringBuilder();
                _stream = new MemoryStream();

                // Get a graphics context from the RichTextBox
                using (var _graphics = CreateGraphics())
                {

                    // Get the device context from the graphics context
                    _hdc = _graphics.GetHdc();

                    // Create a new Enhanced Metafile from the device context
                    _metaFile = new Metafile(_stream, _hdc);

                    // Release the device context
                    _graphics.ReleaseHdc(_hdc);
                }

                // Get a graphics context from the Enhanced Metafile
                using (var _graphics = Graphics.FromImage(_metaFile))
                {

                    // Draw the image on the Enhanced Metafile

                    _graphics.DrawImage(_image, new Rectangle(0, 0, _image.Width, _image.Height));
                }

                // Get the handle of the Enhanced Metafile
                IntPtr _hEmf = _metaFile.GetHenhmetafile();

                // A call to EmfToWmfBits with a null buffer return the size of the
                // buffer need to store the WMF bits. Use this to get the buffer
                // size.
                uint _bufferSize = GdipEmfToWmfBits(_hEmf, 0, null, MM_ANISOTROPIC, EmfToWmfBitsFlags.EmfToWmfBitsFlagsDefault);

                // Create an array to hold the bits
                byte[] _buffer = new byte[_bufferSize - 1 + 1];

                // A call to EmfToWmfBits with a valid buffer copies the bits into the
                // buffer an returns the number of bits in the WMF. 
                uint _convertedSize = GdipEmfToWmfBits(_hEmf, _bufferSize, _buffer, MM_ANISOTROPIC, EmfToWmfBitsFlags.EmfToWmfBitsFlagsDefault);

                // Append the bits to the RTF string
                for (int i = 0; i <= _buffer.Length - 1; i++)
                    _rtf.Append(String.Format("{0:X2}", _buffer[i]));

                return _rtf.ToString();
            }
            finally
            {
                if (_metaFile != null)
                    _metaFile.Dispose();
                if (_stream != null)
                    _stream.Close();
            }
        }

        private string GetFontTable(Font _font)
        {
            StringBuilder _fontTable = new StringBuilder();

            // Append table control string
            _fontTable.Append(@"{\fonttbl{\f0");
            _fontTable.Append(@"\");

            // If the font's family corresponds to an RTF family, append the
            // RTF family name, else, append the RTF for unknown font family.
            if (rtfFontFamily.Contains(_font.FontFamily.Name))
                _fontTable.Append(rtfFontFamily[_font.FontFamily.Name]);
            else
                _fontTable.Append(rtfFontFamily[FF_UNKNOWN]);

            // \fcharset specifies the character set of a font in the font table.
            // 0 is for ANSI.
            _fontTable.Append(@"\fcharset0 ");

            // Append the name of the font
            _fontTable.Append(_font.Name);

            // Close control string
            _fontTable.Append(";}}");

            return _fontTable.ToString();
        }

        private string GetColorTable(RtfColor _textColor, RtfColor _backColor)
        {
            StringBuilder _colorTable = new StringBuilder();

            // Append color table control string and default font (;)
            _colorTable.Append(@"{\colortbl ;");

            // Append the text color
            _colorTable.Append(_textColor);
            _colorTable.Append(";");

            // Append the highlight color
            _colorTable.Append(_backColor);
            _colorTable.Append(@";}\n");

            return _colorTable.ToString();
        }

        private string RemoveBadChars(string _originalRtf)
        {
            return _originalRtf.Replace("\0", "");
        }

        // Render the contents of the RichTextBox for printing
        // Return the last character printed + 1 (printing start from this point for next page)
        public int Print(int charFrom, int charTo, PrintPageEventArgs e)
        {

            // Mark starting and ending character 
            CHARRANGE cRange;
            cRange.cpMin = charFrom;
            cRange.cpMax = charTo;

            // Calculate the area to render and print
            RECT rectToPrint;
            rectToPrint.Top = (int)(e.MarginBounds.Top * AnInch);
            rectToPrint.Bottom = (int)(e.MarginBounds.Bottom * AnInch);
            rectToPrint.Left = (int)(e.MarginBounds.Left * AnInch);
            rectToPrint.Right = (int)(e.MarginBounds.Right * AnInch);

            // Calculate the size of the page
            RECT rectPage;
            rectPage.Top = (int)(e.PageBounds.Top * AnInch);
            rectPage.Bottom = (int)(e.PageBounds.Bottom * AnInch);
            rectPage.Left = (int)(e.PageBounds.Left * AnInch);
            rectPage.Right = (int)(e.PageBounds.Right * AnInch);

            IntPtr hdc = e.Graphics.GetHdc();

            FORMATRANGE fmtRange;
            fmtRange.chrg = cRange;                 // Indicate character from to character to 
            fmtRange.hdc = hdc;                     // Use the same DC for measuring and rendering
            fmtRange.hdcTarget = hdc;               // Point at printer hDC
            fmtRange.rc = rectToPrint;              // Indicate the area on page to print
            fmtRange.rcPage = rectPage;             // Indicate whole size of page

            IntPtr res = IntPtr.Zero;

            IntPtr wparam = IntPtr.Zero;
            wparam = new IntPtr(1);

            // Move the pointer to the FORMATRANGE structure in memory
            IntPtr lparam = IntPtr.Zero;
            lparam = Marshal.AllocCoTaskMem(Marshal.SizeOf(fmtRange));
            Marshal.StructureToPtr(fmtRange, lparam, false);

            // Send the rendered data for printing 
            res = SendMessage(Handle, EM_FORMATRANGE, wparam, lparam);

            // Free the block of memory allocated
            Marshal.FreeCoTaskMem(lparam);

            // Release the device context handle obtained by a previous call
            e.Graphics.ReleaseHdc(hdc);

            // Return last + 1 character printer
            return res.ToInt32();
        }

        /// <summary>
        /// Toggle a font style on a font.
        /// </summary>
        /// 
        /// <param name="originalFont">The source font.</param>
        /// <param name="newStyle">The new font style.</param>
        /// 
        /// <returns>A new font with the font style toggled with the new style.</returns>
        public static Font ToggleFontStyle(Font originalFont, FontStyle newStyle)
        {
            return new Font(originalFont, originalFont.Style ^ newStyle);
        }

        /// <summary>
        /// Apply a font style to a range of text, toggling it on or off character-by-character.
        /// </summary>
        /// 
        /// <param name="fontStyle">The font style to apply.</param>
        public void ApplyFontStyle(FontStyle fontStyle)
        {
            SuspendLayout();

            // Use basic style application if just one character
            if (SelectionLength == 0)
            {
                SelectionFont = ToggleFontStyle(SelectionFont, fontStyle);
                return;
            }

            // Create temp RTB for more complex character operations,
            // with the selected text as its content
            var tempRtb = new ExtendedRichTextBox
            {
                Rtf = SelectedRtf
            };
            tempRtb.SelectAll();

            // For some reason, the RTB control doesn't copy over '\n' sometimes,
            // so if that's the case add it in
            if (SelectedText.EndsWith("\n") != tempRtb.SelectedText.EndsWith("\n"))
            {
                tempRtb.AppendText("\n");
                tempRtb.SelectAll();
            }

            // Loop through each character of temp RTB and
            // swap the value of the font style
            var tempStart = tempRtb.SelectionStart;
            var tempEnd = tempRtb.SelectionStart + tempRtb.SelectionLength;
            for (var i = tempStart; i < tempEnd; i++)
            {
                tempRtb.SelectionStart = i;
                tempRtb.SelectionLength = 1;
                tempRtb.SelectionFont = ToggleFontStyle(tempRtb.SelectionFont, fontStyle);
            }
            tempRtb.SelectAll();

            // Store old selection positions
            var oldStartPos = SelectionStart;
            var oldStartLength = SelectionLength;

            // Copy over the formatted text from the tempRtb
            SelectedRtf = tempRtb.SelectedRtf;

            // Restore the old selection 
            Select(oldStartPos, oldStartLength);

            // Dispose of temp RTB
            tempRtb.Dispose();

            ResumeLayout();
        }

        /// <summary>
        /// Apply a style to the selection.
        /// </summary>
        /// 
        /// <param name="style">The style to apply.</param>
        public void ApplySelectionStyle(RtbStyle style)
        {
            SuspendLayout();

            if (SelectionLength > 0)
            {
                // Create temp RTB for the style operation, with the selected 
                // text as its content
                var tempRtb = new ExtendedRichTextBox
                {
                    Rtf = SelectedRtf
                };
                tempRtb.SelectAll();

                // For some reason, the RTB control doesn't copy over '\n' sometimes,
                // so if that's the case add it in
                if (SelectedText.EndsWith("\n") != tempRtb.SelectedText.EndsWith("\n"))
                {
                    tempRtb.AppendText("\n");
                    tempRtb.SelectAll();
                }

                // Apply the style on the temp RTB
                tempRtb.SelectionFont = style.Font;
                tempRtb.SelectionColor = style.Color;
                tempRtb.SelectionBackColor = style.HighlightColor;
                tempRtb.SelectionAlignment = style.Alignment;
                tempRtb.SelectionIndent = style.Indent;
                tempRtb.SelectionHangingIndent = style.HangingIndent;
                tempRtb.SelectionCharOffset = style.CharOffset;
                tempRtb.SelectAll();

                // Store old selection positions
                var oldStartPos = SelectionStart;
                var oldStartLength = SelectionLength;

                // Copy over the formatted text from the tempRtb
                SelectedRtf = tempRtb.SelectedRtf;

                // Restore the old selection 
                Select(oldStartPos, oldStartLength);

                // Dispose of temp RTB
                tempRtb.Dispose();
            }
            else
            {
                SelectionFont = style.Font;
                SelectionColor = style.Color;
                SelectionBackColor = style.HighlightColor;
                SelectionAlignment = style.Alignment;
                SelectionIndent = style.Indent;
                SelectionHangingIndent = style.HangingIndent;
                SelectionCharOffset = style.CharOffset;
            }

            ResumeLayout();
        }
    }
}