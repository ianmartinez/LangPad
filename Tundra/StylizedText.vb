Imports System.Drawing
Imports System.Drawing.Drawing2D
Imports System.Windows.Forms
Imports System.ComponentModel
Imports System.Drawing.Design

Public Class StylizedText
    Inherits DoubleBufferedPanel
    Private mStyle As String
    <Editor(GetType(MultilineStringEditor), GetType(UITypeEditor))>
    Public Property Style As String
        Get
            Return mStyle
        End Get
        Set(ByVal value As String)
            mStyle = value
            ReadStyle()
            BackgroundImage = DrawBitmap()
        End Set
    End Property

    Private mControlText As String
    <Editor(GetType(MultilineStringEditor), GetType(UITypeEditor))>
    Public Property ControlText As String
        Get
            Return mControlText
        End Get
        Set(ByVal value As String)
            mControlText = value
            ReadStyle()
            BackgroundImage = DrawBitmap()
        End Set
    End Property

    Private Colors As Color()
    Private Positions As Single()
    Private Angle As Integer
    Private BorderColor As Color
    Private BorderSize As Integer
    Private ShadowColor As Color
    Private ShadowOffset As Point
    Private Sub ReadStyle()
        On Error Resume Next

        Colors = FromCompatibleColorList(GetValue(Style, "Colors"))
        Positions = FromCompatibleSingleList(GetValue(Style, "Positions"))
        Angle = CInt(GetValue(Style, "Angle"))
        BorderColor = FromCompatibleColor(GetValue(Style, "Border Color"))
        BorderSize = GetValue(Style, "Border Size")
        ShadowColor = FromCompatibleColor(GetValue(Style, "Shadow Color"))
        ShadowOffset = FromCompatiblePoint(GetValue(Style, "Shadow Offset"))
    End Sub

    Private Shared Function ImageTrim(img As Bitmap) As Bitmap

        ' Find the min/max non-white/transparent pixels
        Dim min As New Point(Integer.MaxValue, Integer.MaxValue)
        Dim max As New Point(Integer.MinValue, Integer.MinValue)

        For x As Integer = 0 To img.Width - 1
            For y As Integer = 0 To img.Height - 1
                Dim pixelColor As Color = img.GetPixel(x, y)
                If Not pixelColor.A = 0 Then
                    If x < min.X Then min.X = x
                    If y < min.Y Then min.Y = y
                    If x > max.X Then max.X = x
                    If y > max.Y Then max.Y = y
                End If
            Next
        Next

        ' Create a new bitmap from the crop rectangle
        Dim cropRectangle As New Rectangle(min.X, min.Y, max.X - min.X, max.Y - min.Y + 2)
        Dim newBitmap As New Bitmap(cropRectangle.Width, cropRectangle.Height)
        Using g As Graphics = Graphics.FromImage(newBitmap)
            g.DrawImage(img, 0, 0, cropRectangle, GraphicsUnit.Pixel)
        End Using

        Return newBitmap
    End Function

    Public Function DrawBitmap() As Image
        On Error Resume Next
        Dim img As Bitmap = New Bitmap(TextRenderer.MeasureText(ControlText, Font).Width + BorderSize + CInt(IIf(ShadowOffset.X > 0, ShadowOffset.X, 0)) + 6,
                                       TextRenderer.MeasureText(ControlText, Font).Height + BorderSize + CInt(IIf(ShadowOffset.Y > 0, ShadowOffset.Y, 0)) + 4)
        If Style = "" Then Return Nothing
        Dim g As Graphics = Graphics.FromImage(img)
        g.CompositingQuality = CompositingQuality.HighQuality
        g.SmoothingMode = SmoothingMode.AntiAlias
        Dim Blend As New ColorBlend()
        Dim FillRectangle As New Rectangle(0, 0, img.Width, img.Height)
        Dim ShadowRectangle As New Rectangle(ShadowOffset.X, ShadowOffset.Y, img.Width, img.Height)
        Dim FillBlend As New LinearGradientBrush(FillRectangle, Color.Transparent, Color.Transparent, Angle)

        Blend.Colors = Colors
        Blend.Positions = Positions
        FillBlend.InterpolationColors = Blend

        Dim TextPath As GraphicsPath = New GraphicsPath(FillMode.Alternate)
        TextPath.AddString(ControlText, Font.FontFamily, Me.Font.Style, g.DpiY * Font.Size / 72, FillRectangle, StringFormat.GenericTypographic)

        Dim ShadowPath As GraphicsPath = New GraphicsPath(FillMode.Alternate)
        ShadowPath.AddString(ControlText, Font.FontFamily, Me.Font.Style, g.DpiY * Font.Size / 72, ShadowRectangle, StringFormat.GenericTypographic)

        g.FillPath(New SolidBrush(ShadowColor), ShadowPath)

        g.FillPath(FillBlend, TextPath)
        g.DrawPath(New Pen(BorderColor, BorderSize), TextPath)

        Return ImageTrim(img)
    End Function

    Private Sub StylizedText_Resize(sender As Object, e As EventArgs) Handles Me.Resize
        BackgroundImage = DrawBitmap()
    End Sub
End Class
