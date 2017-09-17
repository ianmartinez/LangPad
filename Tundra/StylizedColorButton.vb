Imports System.Drawing
Imports System.Drawing.Drawing2D
Imports System.Windows.Forms

Public Class StylizedColorButton
    Inherits Button
    Public Event ColorChanged(ByVal sender As Object, ByVal e As EventArgs)
    Friend WithEvents dlgColor As ColorDialog
    Private mColor As Color
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
    Private mRightClickMode As Boolean
    Public Property RightClickMode As Boolean
        Get
            Return mRightClickMode
        End Get
        Set(ByVal value As Boolean)
            mRightClickMode = value
            On Error Resume Next
        End Set
    End Property

    Private ColorBitmap As Bitmap
    Private Sub GenerateColorBitmap()
        On Error Resume Next
        ColorBitmap = New Bitmap(22, 22)
        Dim ColorGraphics As Graphics = Graphics.FromImage(ColorBitmap)
        Dim ColorRectangle As New Rectangle(0, 0, ColorBitmap.Width - 1, ColorBitmap.Height - 1)
        Dim ColorRoundedRectangle As GraphicsPath = RoundedRectangle(ColorRectangle, 0)
        ColorGraphics.CompositingQuality = CompositingQuality.HighQuality
        ColorGraphics.SmoothingMode = SmoothingMode.AntiAlias
        ColorGraphics.FillPath(New SolidBrush(Color), ColorRoundedRectangle)
        ColorGraphics.DrawPath(New Pen(New SolidBrush(Color.FromArgb(100, 0, 0, 0))), ColorRoundedRectangle)
    End Sub

    Public Sub New()
        InitializeComponent()
        TextAlign = ContentAlignment.BottomCenter
        ImageAlign = ContentAlignment.TopCenter
        MinimumSize = New Size(3, 30)
    End Sub

    Private Sub StylizedColorButton_Resize(sender As Object, e As EventArgs) Handles Me.Resize
        On Error Resume Next
        GenerateColorBitmap()
        Image = ColorBitmap
    End Sub

    Private Sub InitializeComponent()
        dlgColor = New ColorDialog()
        SuspendLayout()
        dlgColor.FullOpen = True
    End Sub

    Private Sub StylizedColorButton_MouseDown(sender As Object, e As MouseEventArgs) Handles Me.MouseDown
        If RightClickMode AndAlso Not e.Button = Windows.Forms.MouseButtons.Right Then
            Exit Sub
        Else
            dlgColor.Color = Color
            If dlgColor.ShowDialog = Windows.Forms.DialogResult.OK Then Color = dlgColor.Color
        End If
    End Sub
End Class
