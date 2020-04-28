Option Explicit On

Imports System
Imports System.Windows.Forms
Imports System.Drawing
Imports System.Runtime.InteropServices
Imports System.Drawing.Printing
Imports System.Text
Imports System.IO
Imports System.Drawing.Imaging
Imports System.Collections.Specialized
'This entire file is made from various projects on CodeProject smashed together along with some of my own code

''' <summary>
''' The rich text box print control class was developed by Microsoft, information about
''' this control can be found in your help files at:  
''' ms-help://MS.VSCC.v80/MS.MSDN.v80/MS.KB.v10.en/enu_kbvbnetkb/vbnetkb/811401.htm
''' In general, their intent was to create a rich text box control with print capability
''' embedded into the control.
''' </summary>
''' <remarks>This control class replaces the use of the regular RichTextBox control; the
''' purpose of this extension was specifically to facilitate printing the contents
''' of a rich text box control.</remarks>

Public Class ExtendedRichTextBox
    Inherits RichTextBox
    ' Convert the unit that is used by the .NET framework (1/100 inch) 
    ' and the unit that is used by Win32 API calls (twips 1/1440 inch)
    Private Const AnInch As Double = 14.4

    Private Const WM_USER As Integer = &H400

    <StructLayout(LayoutKind.Sequential)> _
    Private Structure RECT
        Public Left As Integer
        Public Top As Integer
        Public Right As Integer
        Public Bottom As Integer
    End Structure

    <StructLayout(LayoutKind.Sequential)> _
    Private Structure CHARRANGE
        Public cpMin As Integer          ' First character of range (0 for start of doc)
        Public cpMax As Integer          ' Last character of range (-1 for end of doc)
    End Structure

    <StructLayout(LayoutKind.Sequential)> _
    Private Structure FORMATRANGE
        Public hdc As IntPtr             ' Actual DC to draw on
        Public hdcTarget As IntPtr       ' Target DC for determining text formatting
        Public rc As RECT                ' Region of the DC to draw to (in twips)
        Public rcPage As RECT            ' Region of the whole DC (page size) (in twips)
        Public chrg As CHARRANGE         ' Range of text to draw (see above declaration)
    End Structure

    Private Const EM_FORMATRANGE As Integer = WM_USER + 57

    Private Declare Function SendMessage Lib "USER32" Alias "SendMessageA" (ByVal hWnd As IntPtr, ByVal msg As Integer, ByVal wp As IntPtr, ByVal lp As IntPtr) As IntPtr

    ' Render the contents of the RichTextBox for printing
    '	Return the last character printed + 1 (printing start from this point for next page)
    Public Function Print(ByVal charFrom As Integer, ByVal charTo As Integer, ByVal e As PrintPageEventArgs) As Integer

        ' Mark starting and ending character 
        Dim cRange As CHARRANGE
        cRange.cpMin = charFrom
        cRange.cpMax = charTo

        ' Calculate the area to render and print
        Dim rectToPrint As RECT
        rectToPrint.Top = e.MarginBounds.Top * AnInch
        rectToPrint.Bottom = e.MarginBounds.Bottom * AnInch
        rectToPrint.Left = e.MarginBounds.Left * AnInch
        rectToPrint.Right = e.MarginBounds.Right * AnInch

        ' Calculate the size of the page
        Dim rectPage As RECT
        rectPage.Top = e.PageBounds.Top * AnInch
        rectPage.Bottom = e.PageBounds.Bottom * AnInch
        rectPage.Left = e.PageBounds.Left * AnInch
        rectPage.Right = e.PageBounds.Right * AnInch

        Dim hdc As IntPtr = e.Graphics.GetHdc()

        Dim fmtRange As FORMATRANGE
        fmtRange.chrg = cRange                 ' Indicate character from to character to 
        fmtRange.hdc = hdc                     ' Use the same DC for measuring and rendering
        fmtRange.hdcTarget = hdc               ' Point at printer hDC
        fmtRange.rc = rectToPrint              ' Indicate the area on page to print
        fmtRange.rcPage = rectPage             ' Indicate whole size of page

        Dim res As IntPtr = IntPtr.Zero

        Dim wparam As IntPtr = IntPtr.Zero
        wparam = New IntPtr(1)

        ' Move the pointer to the FORMATRANGE structure in memory
        Dim lparam As IntPtr = IntPtr.Zero
        lparam = Marshal.AllocCoTaskMem(Marshal.SizeOf(fmtRange))
        Marshal.StructureToPtr(fmtRange, lparam, False)

        ' Send the rendered data for printing 
        res = SendMessage(Handle, EM_FORMATRANGE, wparam, lparam)

        ' Free the block of memory allocated
        Marshal.FreeCoTaskMem(lparam)

        ' Release the device context handle obtained by a previous call
        e.Graphics.ReleaseHdc(hdc)

        ' Return last + 1 character printer
        Return res.ToInt32()
    End Function



    ' Enum for possible RTF colors
    Public Enum RtfColor
        Black
        Maroon
        Green
        Olive
        Navy
        Purple
        Teal
        Gray
        Silver
        Red
        Lime
        Yellow
        Blue
        Fuchsia
        Aqua
        White
    End Enum



    ' Specifies the flags/options for the unmanaged call to the GDI+ method
    ' Metafile.EmfToWmfBits().
    Private Enum EmfToWmfBitsFlags

        ' Use the default conversion
        EmfToWmfBitsFlagsDefault = &H0

        ' Embedded the source of the EMF metafiel within the resulting WMF
        ' metafile
        EmfToWmfBitsFlagsEmbedEmf = &H1

        ' Place a 22-byte header in the resulting WMF file.  The header is
        ' required for the metafile to be considered placeable.
        EmfToWmfBitsFlagsIncludePlaceable = &H2

        ' Don't simulate clipping by using the XOR operator.
        EmfToWmfBitsFlagsNoXORClip = &H4
    End Enum


    ' Definitions for colors in an RTF document
    Private Structure RtfColorDef
        Public Const Black As String = "\red0\green0\blue0"
        Public Const Maroon As String = "\red128\green0\blue0"
        Public Const Green As String = "\red0\green128\blue0"
        Public Const Olive As String = "\red128\green128\blue0"
        Public Const Navy As String = "\red0\green0\blue128"
        Public Const Purple As String = "\red128\green0\blue128"
        Public Const Teal As String = "\red0\green128\blue128"
        Public Const Gray As String = "\red128\green128\blue128"
        Public Const Silver As String = "\red192\green192\blue192"
        Public Const Red As String = "\red255\green0\blue0"
        Public Const Lime As String = "\red0\green255\blue0"
        Public Const Yellow As String = "\red255\green255\blue0"
        Public Const Blue As String = "\red0\green0\blue255"
        Public Const Fuchsia As String = "\red255\green0\blue255"
        Public Const Aqua As String = "\red0\green255\blue255"
        Public Const White As String = "\red255\green255\blue255"
    End Structure

    ' Control words for RTF font families
    Private Structure RtfFontFamilyDef
        Public Const Unknown As String = "\fnil"
        Public Const Roman As String = "\froman"
        Public Const Swiss As String = "\fswiss"
        Public Const Modern As String = "\fmodern"
        Public Const Script As String = "\fscript"
        Public Const Decor As String = "\fdecor"
        Public Const Technical As String = "\ftech"
        Public Const BiDirect As String = "\fbidi"
    End Structure

    ' Not used in this application.  Descriptions can be found with documentation
    ' of Windows GDI function SetMapMode
    Private Const MM_TEXT As Integer = 1
    Private Const MM_LOMETRIC As Integer = 2
    Private Const MM_HIMETRIC As Integer = 3
    Private Const MM_LOENGLISH As Integer = 4
    Private Const MM_HIENGLISH As Integer = 5
    Private Const MM_TWIPS As Integer = 6

    ' Ensures that the metafile maintains a 1:1 aspect ratio
    Private Const MM_ISOTROPIC As Integer = 7

    ' Allows the x-coordinates and y-coordinates of the metafile to be adjusted
    ' independently
    Private Const MM_ANISOTROPIC As Integer = 8

    ' Represents an unknown font family
    Private Const FF_UNKNOWN As String = "UNKNOWN"

    ' The number of hundredths of millimeters (0.01 mm) in an inch
    ' For more information, see GetImagePrefix() method.
    Private Const HMM_PER_INCH As Integer = 2540

    ' The number of twips in an inch
    ' For more information, see GetImagePrefix() method.
    Private Const TWIPS_PER_INCH As Integer = 1440

    ' The default text color
    Private m_textColor As RtfColor

    ' The default text background color
    Private highlightColor As RtfColor

    ' Dictionary that maps color enums to RTF color codes
    Private RtfColorDict As HybridDictionary

    ' Dictionary that mapas Framework font families to RTF font families
    Private rtfFontFamily As HybridDictionary

    ' The horizontal resolution at which the control is being displayed
    Private xDpi As Single

    ' The vertical resolution at which the control is being displayed
    Private yDpi As Single


    Private Const RTF_HEADER As String = "{\rtf1\ansi\ansicpg1252\deff0\deflang1033"


    Private Const RTF_DOCUMENT_PRE As String = "\viewkind4\uc1\pard\cf1\f0\fs20"
    Private Const RTF_DOCUMENT_POST As String = "\cf0\fs17}"
    Private RTF_IMAGE_POST As String = "}"
    Public Shadows Property Rtf() As String
        Get
            Return RemoveBadChars(MyBase.Rtf)
        End Get
        Set(value As String)
            MyBase.Rtf = value
        End Set
    End Property

    ' The color of the text
    Public Property TextColor() As RtfColor
        Get
            Return m_textColor
        End Get
        Set(value As RtfColor)
            m_textColor = value
        End Set
    End Property

    ' The color of the highlight
    Public Property HiglightColor() As RtfColor
        Get
            Return highlightColor
        End Get
        Set(value As RtfColor)
            highlightColor = value
        End Set
    End Property

    ''' <summary>
    ''' Initializes the text colors, creates dictionaries for RTF colors and
    ''' font families, and stores the horizontal and vertical resolution of
    ''' the RichTextBox's graphics context.
    ''' </summary>
    Public Sub New()
        MyBase.New()
        ' Initialize default text and background colors
        m_textColor = RtfColor.Black
        highlightColor = RtfColor.White

        ' Initialize the dictionary mapping color codes to definitions
        RtfColorDict = New HybridDictionary()
        RtfColorDict.Add(RtfColor.Aqua, RtfColorDef.Aqua)
        RtfColorDict.Add(RtfColor.Black, RtfColorDef.Black)
        RtfColorDict.Add(RtfColor.Blue, RtfColorDef.Blue)
        RtfColorDict.Add(RtfColor.Fuchsia, RtfColorDef.Fuchsia)
        RtfColorDict.Add(RtfColor.Gray, RtfColorDef.Gray)
        RtfColorDict.Add(RtfColor.Green, RtfColorDef.Green)
        RtfColorDict.Add(RtfColor.Lime, RtfColorDef.Lime)
        RtfColorDict.Add(RtfColor.Maroon, RtfColorDef.Maroon)
        RtfColorDict.Add(RtfColor.Navy, RtfColorDef.Navy)
        RtfColorDict.Add(RtfColor.Olive, RtfColorDef.Olive)
        RtfColorDict.Add(RtfColor.Purple, RtfColorDef.Purple)
        RtfColorDict.Add(RtfColor.Red, RtfColorDef.Red)
        RtfColorDict.Add(RtfColor.Silver, RtfColorDef.Silver)
        RtfColorDict.Add(RtfColor.Teal, RtfColorDef.Teal)
        RtfColorDict.Add(RtfColor.White, RtfColorDef.White)
        RtfColorDict.Add(RtfColor.Yellow, RtfColorDef.Yellow)

        rtfFontFamily = New HybridDictionary()
        rtfFontFamily.Add(FontFamily.GenericMonospace.Name, RtfFontFamilyDef.Modern)
        rtfFontFamily.Add(FontFamily.GenericSansSerif, RtfFontFamilyDef.Swiss)
        rtfFontFamily.Add(FontFamily.GenericSerif, RtfFontFamilyDef.Roman)
        rtfFontFamily.Add(FF_UNKNOWN, RtfFontFamilyDef.Unknown)

        Using _graphics As Graphics = Me.CreateGraphics()
            xDpi = _graphics.DpiX
            yDpi = _graphics.DpiY
        End Using
    End Sub

    Public Sub New(_textColor As RtfColor)
        Me.New()
        m_textColor = _textColor
    End Sub

    Public Sub New(_textColor As RtfColor, _highlightColor As RtfColor)
        Me.New()
        m_textColor = _textColor
        highlightColor = _highlightColor
    End Sub

    Public Sub AppendRtf(_rtf As String)

        ' Move caret to the end of the text
        Me.[Select](Me.TextLength, 0)

        ' Since SelectedRtf is null, this will append the string to the
        ' end of the existing RTF
        Me.SelectedRtf = _rtf
    End Sub

    Public Sub InsertRtf(_rtf As String)
        Me.SelectedRtf = _rtf
    End Sub


    Public Sub AppendTextAsRtf(_text As String)
        AppendTextAsRtf(_text, Me.Font)
    End Sub

    ''' <param name="_font"></param>
    Public Sub AppendTextAsRtf(_text As String, _font As Font)
        AppendTextAsRtf(_text, _font, m_textColor)
    End Sub

    Public Sub AppendTextAsRtf(_text As String, _font As Font, _textColor As RtfColor)
        AppendTextAsRtf(_text, _font, _textColor, highlightColor)
    End Sub

    Public Sub AppendTextAsRtf(_text As String, _font As Font, _textColor As RtfColor, _backColor As RtfColor)
        ' Move carret to the end of the text
        Me.[Select](Me.TextLength, 0)

        InsertTextAsRtf(_text, _font, _textColor, _backColor)
    End Sub

    Public Sub InsertTextAsRtf(_text As String)
        InsertTextAsRtf(_text, Me.Font)
    End Sub


    Public Sub InsertTextAsRtf(_text As String, _font As Font)
        InsertTextAsRtf(_text, _font, m_textColor)
    End Sub

    Public Sub InsertTextAsRtf(_text As String, _font As Font, _textColor As RtfColor)
        InsertTextAsRtf(_text, _font, _textColor, highlightColor)
    End Sub

    Public Sub InsertTextAsRtf(_text As String, _font As Font, _textColor As RtfColor, _backColor As RtfColor)

        Dim _rtf As New StringBuilder()

        ' Append the RTF header
        _rtf.Append(RTF_HEADER)

        ' Create the font table from the font passed in and append it to the
        ' RTF string
        _rtf.Append(GetFontTable(_font))

        ' Create the color table from the colors passed in and append it to the
        ' RTF string
        _rtf.Append(GetColorTable(_textColor, _backColor))

        ' Create the document area from the text to be added as RTF and append
        ' it to the RTF string.
        _rtf.Append(GetDocumentArea(_text, _font))

        Me.SelectedRtf = _rtf.ToString()
    End Sub

    Public Sub InsertTable(ByVal Rows As Integer, ByVal Columns As Integer, Optional ByVal Width As Integer = 100)
        Dim Twips As Integer = Width * 15
        Dim TableStringBuilder As New StringBuilder
        For Row = 1 To Rows
            TableStringBuilder.AppendLine("\trowd")
            For Column = 1 To Columns
                TableStringBuilder.AppendLine("\cellx" & (Twips * Column))
                TableStringBuilder.AppendLine(" \intbl\cell")
            Next
            TableStringBuilder.AppendLine("\row")
        Next
        Dim NewRTF As String = Me.Rtf
        NewRTF = NewRTF.Remove(NewRTF.LastIndexOf("}"), 1)
        Me.Rtf = NewRTF & TableStringBuilder.ToString & "}"
    End Sub
    Private Function GetDocumentArea(_text As String, _font As Font) As String

        Dim _doc As New StringBuilder()

        ' Append the standard RTF document area control string
        _doc.Append(RTF_DOCUMENT_PRE)

        ' Set the highlight color (the color behind the text) to the
        ' third color in the color table.  See GetColorTable for more details.
        _doc.Append("\highlight2")

        ' If the font is bold, attach corresponding tag
        If _font.Bold Then
            _doc.Append("\b")
        End If

        ' If the font is italic, attach corresponding tag
        If _font.Italic Then
            _doc.Append("\i")
        End If

        ' If the font is strikeout, attach corresponding tag
        If _font.Strikeout Then
            _doc.Append("\strike")
        End If

        ' If the font is underlined, attach corresponding tag
        If _font.Underline Then
            _doc.Append("\ul")
        End If

        ' Set the font to the first font in the font table.
        ' See GetFontTable for more details.
        _doc.Append("\f0")

        ' Set the size of the font.  In RTF, font size is measured in
        ' half-points, so the font size is twice the value obtained from
        ' Font.SizeInPoints
        _doc.Append("\fs")
        _doc.Append(CInt(Math.Round((2 * _font.SizeInPoints))))

        ' Apppend a space before starting actual text (for clarity)
        _doc.Append(" ")

        ' Append actual text, however, replace newlines with RTF \par.
        ' Any other special text should be handled here (e.g.) tabs, etc.
        _doc.Append(_text.Replace(vbLf, "\par "))

        ' RTF isn't strict when it comes to closing control words, but what the
        ' heck ...

        ' Remove the highlight
        _doc.Append("\highlight0")

        ' If font is bold, close tag
        If _font.Bold Then
            _doc.Append("\b0")
        End If

        ' If font is italic, close tag
        If _font.Italic Then
            _doc.Append("\i0")
        End If

        ' If font is strikeout, close tag
        If _font.Strikeout Then
            _doc.Append("\strike0")
        End If

        ' If font is underlined, cloes tag
        If _font.Underline Then
            _doc.Append("\ulnone")
        End If

        ' Revert back to default font and size
        _doc.Append("\f0")
        _doc.Append("\fs20")

        ' Close the document area control string
        _doc.Append(RTF_DOCUMENT_POST)

        Return _doc.ToString()
    End Function

    Public Sub InsertImage(_image As Image)
        Dim img As Image = _image.Clone
        Dim g As Graphics = Graphics.FromImage(_image)
        g.Clear(Me.BackColor)
        g.DrawImage(img, New Point(0, 0))
        Dim _rtf As New StringBuilder()

        ' Append the RTF header
        _rtf.Append(RTF_HEADER)

        ' Create the font table using the RichTextBox's current font and append
        ' it to the RTF string
        _rtf.Append(GetFontTable(Me.Font))

        ' Create the image control string and append it to the RTF string
        _rtf.Append(GetImagePrefix(_image))

        ' Create the Windows Metafile and append its bytes in HEX format
        _rtf.Append(GetRtfImage(_image))

        ' Close the RTF image control string
        _rtf.Append(RTF_IMAGE_POST)

        Me.SelectedRtf = _rtf.ToString()
    End Sub

    Private Function GetImagePrefix(_image As Image) As String

        Dim _rtf As New StringBuilder()

        ' Calculate the current width of the image in (0.01)mm
        Dim picw As Integer = CInt(Math.Round((_image.Width / xDpi) * HMM_PER_INCH))

        ' Calculate the current height of the image in (0.01)mm
        Dim pich As Integer = CInt(Math.Round((_image.Height / yDpi) * HMM_PER_INCH))

        ' Calculate the target width of the image in twips
        Dim picwgoal As Integer = CInt(Math.Round((_image.Width / xDpi) * TWIPS_PER_INCH))

        ' Calculate the target height of the image in twips
        Dim pichgoal As Integer = CInt(Math.Round((_image.Height / yDpi) * TWIPS_PER_INCH))

        ' Append values to RTF string
        _rtf.Append("{\pict\wmetafile8")
        _rtf.Append("\picw")
        _rtf.Append(picw)
        _rtf.Append("\pich")
        _rtf.Append(pich)
        _rtf.Append("\picwgoal")
        _rtf.Append(picwgoal)
        _rtf.Append("\pichgoal")
        _rtf.Append(pichgoal)
        _rtf.Append(" ")

        Return _rtf.ToString()
    End Function

    <DllImportAttribute("gdiplus.dll")> _
    Private Shared Function GdipEmfToWmfBits(_hEmf As IntPtr, _bufferSize As UInteger, _buffer As Byte(), _mappingMode As Integer, _flags As EmfToWmfBitsFlags) As UInteger
    End Function

    Private Function GetRtfImage(_image As Image) As String

        Dim _rtf As StringBuilder = Nothing

        ' Used to store the enhanced metafile
        Dim _stream As MemoryStream = Nothing


        ' The enhanced metafile
        Dim _metaFile As Metafile = Nothing

        ' Handle to the device context used to create the metafile
        Dim _hdc As IntPtr

        Try
            _rtf = New StringBuilder()
            _stream = New MemoryStream()

            ' Get a graphics context from the RichTextBox
            Using _graphics = Me.CreateGraphics()

                ' Get the device context from the graphics context
                _hdc = _graphics.GetHdc()

                ' Create a new Enhanced Metafile from the device context
                _metaFile = New Metafile(_stream, _hdc)

                ' Release the device context
                _graphics.ReleaseHdc(_hdc)
            End Using

            ' Get a graphics context from the Enhanced Metafile
            Using _graphics = Graphics.FromImage(_metaFile)

                ' Draw the image on the Enhanced Metafile

                _graphics.DrawImage(_image, New Rectangle(0, 0, _image.Width, _image.Height))
            End Using

            ' Get the handle of the Enhanced Metafile
            Dim _hEmf As IntPtr = _metaFile.GetHenhmetafile()

            ' A call to EmfToWmfBits with a null buffer return the size of the
            ' buffer need to store the WMF bits. Use this to get the buffer
            ' size.
            Dim _bufferSize As UInteger = GdipEmfToWmfBits(_hEmf, 0, Nothing, MM_ANISOTROPIC, EmfToWmfBitsFlags.EmfToWmfBitsFlagsDefault)

            ' Create an array to hold the bits
            Dim _buffer As Byte() = New Byte(_bufferSize - 1) {}

            ' A call to EmfToWmfBits with a valid buffer copies the bits into the
            ' buffer an returns the number of bits in the WMF. 
            Dim _convertedSize As UInteger = GdipEmfToWmfBits(_hEmf, _bufferSize, _buffer, MM_ANISOTROPIC, EmfToWmfBitsFlags.EmfToWmfBitsFlagsDefault)

            ' Append the bits to the RTF string
            For i As Integer = 0 To _buffer.Length - 1
                _rtf.Append([String].Format("{0:X2}", _buffer(i)))
            Next

            Return _rtf.ToString()
        Finally
            If _metaFile IsNot Nothing Then
                _metaFile.Dispose()
            End If
            If _stream IsNot Nothing Then
                _stream.Close()
            End If
        End Try
    End Function

    Private Function GetFontTable(_font As Font) As String

        Dim _fontTable As New StringBuilder()

        ' Append table control string
        _fontTable.Append("{\fonttbl{\f0")
        _fontTable.Append("\")

        ' If the font's family corresponds to an RTF family, append the
        ' RTF family name, else, append the RTF for unknown font family.
        If rtfFontFamily.Contains(_font.FontFamily.Name) Then
            _fontTable.Append(rtfFontFamily(_font.FontFamily.Name))
        Else
            _fontTable.Append(rtfFontFamily(FF_UNKNOWN))
        End If

        ' \fcharset specifies the character set of a font in the font table.
        ' 0 is for ANSI.
        _fontTable.Append("\fcharset0 ")

        ' Append the name of the font
        _fontTable.Append(_font.Name)

        ' Close control string
        _fontTable.Append(";}}")

        Return _fontTable.ToString()
    End Function

    Private Function GetColorTable(_textColor As RtfColor, _backColor As RtfColor) As String

        Dim _colorTable As New StringBuilder()

        ' Append color table control string and default font (;)
        _colorTable.Append("{\colortbl ;")

        ' Append the text color
        _colorTable.Append(_textColor)
        _colorTable.Append(";")

        ' Append the highlight color
        _colorTable.Append(_backColor)
        _colorTable.Append(";}\n")

        Return _colorTable.ToString()
    End Function

    Private Function RemoveBadChars(_originalRtf As String) As String
        Return _originalRtf.Replace(vbNullChar, "")
    End Function

End Class


