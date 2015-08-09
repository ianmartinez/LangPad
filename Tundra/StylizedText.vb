Imports System.Drawing
Imports System.Drawing.Drawing2D
Imports System.Windows.Forms
Imports Tundra.ZiaFile
Imports System.ComponentModel.Design
Imports System.ComponentModel
Imports System.Drawing.Design

Public Class StylizedText
    Inherits DoubleBufferedPanel
    Private mStyle As String
    <Editor(GetType(MultilineStringEditor), GetType(UITypeEditor))> _
    Public Property Style As String
        Get
            Return mStyle
        End Get
        Set(ByVal value As String)
            mStyle = value
            ReadStyle()
            Me.BackgroundImage = DrawBitmap()
        End Set
    End Property

    Private mControlText As String
    <Editor(GetType(MultilineStringEditor), GetType(UITypeEditor))> _
    Public Property ControlText As String
        Get
            Return mControlText
        End Get
        Set(ByVal value As String)
            mControlText = value
            ReadStyle()
            Me.BackgroundImage = DrawBitmap()
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

    Public Function DrawBitmap() As Image
        On Error Resume Next
        Dim img As Bitmap = New Bitmap(TextRenderer.MeasureText(ControlText, Font).Width + BorderSize + CInt(IIf(ShadowOffset.X > 0, ShadowOffset.X, 0)) + 4, TextRenderer.MeasureText(ControlText, Font).Height + BorderSize + CInt(IIf(ShadowOffset.Y > 0, ShadowOffset.Y, 0)))
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

        Dim TextPath As GraphicsPath = New System.Drawing.Drawing2D.GraphicsPath(Drawing.Drawing2D.FillMode.Alternate)
        TextPath.AddString(ControlText, Me.Font.FontFamily, Me.Font.Style, g.DpiY * Font.Size / 72, FillRectangle, StringFormat.GenericTypographic)

        Dim ShadowPath As GraphicsPath = New System.Drawing.Drawing2D.GraphicsPath(Drawing.Drawing2D.FillMode.Alternate)
        ShadowPath.AddString(ControlText, Me.Font.FontFamily, Me.Font.Style, g.DpiY * Font.Size / 72, ShadowRectangle, StringFormat.GenericTypographic)

        g.FillPath(New SolidBrush(ShadowColor), ShadowPath)

        g.FillPath(FillBlend, TextPath)
        g.DrawPath(New Pen(BorderColor, BorderSize), TextPath)
        Return img
    End Function

    Private Sub StylizedText_Resize(sender As Object, e As EventArgs) Handles Me.Resize

        Me.BackgroundImage = DrawBitmap()
    End Sub
End Class
