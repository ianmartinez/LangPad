Imports System.Drawing
Imports System.Drawing.Drawing2D

Public Class StylizedColorButton
    Inherits StylizedButton
    Private mColor As Color
    Public Event ColorChanged(ByVal sender As Object, ByVal e As EventArgs)
    Friend WithEvents dlgColor As System.Windows.Forms.ColorDialog
    Public Property Color As Color
        Get
            Return mColor
        End Get
        Set(ByVal value As Color)
            mColor = value
            On Error Resume Next
            GenerateColorBitmap()
            Me.Image = ColorBitmap
            RaiseEvent ColorChanged(Me, Nothing)
        End Set
    End Property
    Private ColorBitmap As Bitmap
    Private Sub GenerateColorBitmap()
        On Error Resume Next
        GenerateBitmaps()
        ColorBitmap = New Bitmap(14, 14)
        Dim ColorGraphics As Graphics = Graphics.FromImage(ColorBitmap)
        Dim ColorRectangle As New Rectangle(0, 0, ColorBitmap.Width - 2, ColorBitmap.Height - 2)
        Dim ColorHighlightRectangle As New Rectangle(1, 1, ColorBitmap.Width - 4, ColorBitmap.Height - 4)
        Dim ColorRoundedRectangle As GraphicsPath = RoundedRectangle(ColorRectangle, 3)
        Dim ColorHighlightRoundedRectangle As GraphicsPath = RoundedRectangle(ColorHighlightRectangle, 3)
        Dim Shine As New LinearGradientBrush(ColorRectangle, Color.FromArgb(70, 255, 255, 255), Color.Transparent, 90)
        ColorGraphics.CompositingQuality = CompositingQuality.HighQuality
        ColorGraphics.SmoothingMode = SmoothingMode.AntiAlias
        ColorGraphics.FillPath(New SolidBrush(Color), ColorRoundedRectangle)
        ColorGraphics.FillPath(Shine, ColorRoundedRectangle)
        ColorGraphics.DrawPath(New Pen(New SolidBrush(Color.FromArgb(90, 255, 255, 255))), ColorHighlightRoundedRectangle)
        ColorGraphics.DrawPath(New Pen(New SolidBrush(Color.FromArgb(100, 0, 0, 0))), ColorRoundedRectangle)
    End Sub

    Public Sub New()
        InitializeComponent()
        Me.TextAlign = ContentAlignment.BottomCenter
        Me.ImageAlign = ContentAlignment.TopCenter
        Me.MinimumSize = New Size(3, 30)
    End Sub

    Private Sub StylizedColorButton_Click(sender As Object, e As System.EventArgs) Handles Me.Click
        dlgColor.Color = Me.Color
        If dlgColor.ShowDialog = Windows.Forms.DialogResult.OK Then
            Me.Color = dlgColor.Color
        End If
    End Sub

    Private Sub StylizedColorButton_Resize(sender As Object, e As System.EventArgs) Handles Me.Resize
        On Error Resume Next
        GenerateColorBitmap()
        Me.Image = ColorBitmap
    End Sub

    Private Sub InitializeComponent()
        Me.dlgColor = New System.Windows.Forms.ColorDialog()
        Me.SuspendLayout()
        Me.dlgColor.FullOpen = True
    End Sub

    Private Sub StylizedColorButton_UIStyleChanged(ByVal sender As Object, ByVal e As EventArgs) Handles Me.UIStyleChanged
        GenerateColorBitmap()
        Me.Image = ColorBitmap
    End Sub
End Class
