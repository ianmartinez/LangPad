Imports System.Windows.Forms
Imports System.ComponentModel
Imports System.Drawing.Design
Imports System.Drawing
Imports System.Drawing.Drawing2D

Public Class StylizedProgressBar
    Inherits DoubleBufferedPanel
    Private mStyle As String
    Private mProgress As Integer
    Protected Event UIStyleChanged(ByVal sender As Object, ByVal e As EventArgs)
    Public Event ProgressChanged(ByVal sender As Object, ByVal e As EventArgs)
    Private WithEvents ProgressPanel As New DoubleBufferedPanel
    Public Progress As Integer
    <Editor(GetType(MultilineStringEditor), GetType(UITypeEditor))> _
    Public Property Style As String
        Get
            Return mStyle
        End Get
        Set(ByVal value As String)
            mStyle = value
            On Error Resume Next
            GenerateBitmaps()
            BackgroundImage = BackgroundBitmap
            ProgressPanel.BackgroundImage = ProgressBitmap
            RaiseEvent UIStyleChanged(Me, Nothing)
        End Set
    End Property


    Protected Radius As Integer
    Private NoAA As Boolean
    Private BackgroundColors As Color()
    Private BackgroundPositions As Single()
    Private BackgroundAngle As Integer
    Private BackgroundBorderColor As Color
    Private BackgroundHighlightColor As Color

    Private ProgressColors As Color()
    Private ProgressPositions As Single()
    Private ProgressAngle As Integer
    Private ProgressBorderColor As Color
    Private ProgressHighlightColor As Color

    Private BackgroundBitmap As Bitmap
    Private ProgressBitmap As Bitmap

    Private Sub ReadStyle()
        On Error Resume Next
        Radius = CInt(GetValue(Style, "Radius"))
        Padding = New Padding(CInt(GetValue(Style, "Padding")))

        BackgroundColors = FromCompatibleColorList(GetValue(Style, "Background Colors"))
        BackgroundPositions = FromCompatibleSingleList(GetValue(Style, "Background Positions"))
        BackgroundAngle = CInt(GetValue(Style, "Background Angle"))
        BackgroundBorderColor = FromCompatibleColor(GetValue(Style, "Background Border Color"))
        BackgroundHighlightColor = FromCompatibleColor(GetValue(Style, "BackgroundHighlight Color"))

        ProgressColors = FromCompatibleColorList(GetValue(Style, "Progress Colors"))
        ProgressPositions = FromCompatibleSingleList(GetValue(Style, "Progress Positions"))
        ProgressAngle = CInt(GetValue(Style, "Progress Angle"))
        ProgressBorderColor = FromCompatibleColor(GetValue(Style, "Progress Border Color"))
        ProgressHighlightColor = FromCompatibleColor(GetValue(Style, "Progress Highlight Color"))


        NoAA = GetValue(Style, "No AA")
    End Sub

    Protected Sub GenerateBitmaps()
        On Error Resume Next
        ReadStyle()
        BackgroundBitmap = New Bitmap(Width, Height)
        ProgressBitmap = New Bitmap(ProgressPanel.Width, ProgressPanel.Height)

        Dim FillRectangle As New Rectangle(0, 0, Width, Height)
        Dim HighlightRectangle As New Rectangle(1, 1, Width - 2, Height - 2)
        Dim FillRoundedRectangle As GraphicsPath = RoundedRectangle(FillRectangle, Radius)
        Dim HighlightRoundedRectangle As GraphicsPath = RoundedRectangle(HighlightRectangle, Radius)

        Dim ProgressFillRectangle As New Rectangle(0, 0, ProgressPanel.Width - 1, ProgressPanel.Height - 1)
        Dim ProgressHighlightRectangle As New Rectangle(1, 1, ProgressPanel.Width - 3, ProgressPanel.Height - 3)
        Dim ProgressFillRoundedRectangle As GraphicsPath = RoundedRectangle(ProgressFillRectangle, Radius)
        Dim ProgressHighlightRoundedRectangle As GraphicsPath = RoundedRectangle(ProgressHighlightRectangle, Radius)

        Dim BackgroundGraphics As Graphics = Graphics.FromImage(BackgroundBitmap)
        BackgroundGraphics.CompositingQuality = CompositingQuality.HighQuality
        BackgroundGraphics.SmoothingMode = SmoothingMode.AntiAlias
        If NoAA = True Then BackgroundGraphics.SmoothingMode = SmoothingMode.None
        Dim BackgroundBlend As New ColorBlend()
        Dim BackgroundFillBlend As New LinearGradientBrush(FillRectangle, Color.Transparent, Color.Transparent, BackgroundAngle)
        BackgroundBlend.Colors = BackgroundColors
        BackgroundBlend.Positions = BackgroundPositions
        BackgroundFillBlend.InterpolationColors = BackgroundBlend
        BackgroundGraphics.FillPath(BackgroundFillBlend, FillRoundedRectangle)
        BackgroundGraphics.DrawPath(New Pen(New SolidBrush(BackgroundBorderColor)), FillRoundedRectangle)
        BackgroundGraphics.DrawPath(New Pen(New SolidBrush(BackgroundHighlightColor)), HighlightRoundedRectangle)

        Dim ProgressGraphics As Graphics = Graphics.FromImage(ProgressBitmap)
        ProgressGraphics.CompositingQuality = CompositingQuality.HighQuality
        ProgressGraphics.SmoothingMode = SmoothingMode.AntiAlias
        Dim ProgressBlend As New ColorBlend()
        Dim ProgressFillBlend As New LinearGradientBrush(ProgressFillRectangle, Color.Transparent, Color.Transparent, ProgressAngle)
        ProgressBlend.Colors = ProgressColors
        ProgressBlend.Positions = ProgressPositions
        ProgressFillBlend.InterpolationColors = ProgressBlend
        ProgressGraphics.FillPath(ProgressFillBlend, ProgressFillRoundedRectangle)
        ProgressGraphics.DrawPath(New Pen(New SolidBrush(ProgressBorderColor)), ProgressFillRoundedRectangle)
        ProgressGraphics.DrawPath(New Pen(New SolidBrush(ProgressHighlightColor)), ProgressHighlightRoundedRectangle)
    End Sub

    Public Sub New()
        DoubleBuffered = True
        SetStyle(ControlStyles.SupportsTransparentBackColor, True)
        SetStyle(ControlStyles.OptimizedDoubleBuffer, True)
        SetStyle(ControlStyles.ResizeRedraw, True)
        BackColor = Color.Transparent
        Padding = New Padding(2)
        BackgroundImageLayout = ImageLayout.None
        Controls.Add(ProgressPanel)
        ProgressPanel.Dock = DockStyle.Left
        SetProgress(40)
    End Sub

    Public Sub SetProgress(ByVal Value As Integer, Optional ByVal Maximum As Integer = 100)
        ProgressPanel.Width = (Value * Width - (Padding.Left + Padding.Right)) / Maximum
        Progress = Value / Maximum * 100
        RaiseEvent ProgressChanged(Me, New EventArgs)
    End Sub

    Private Sub StylizedButton_LostFocus(sender As Object, e As EventArgs) Handles Me.LostFocus
        Refresh()
    End Sub

    Private Sub StylizedProgressBar_ProgressChanged(sender As Object, e As EventArgs) Handles Me.ProgressChanged
        GenerateBitmaps()
        BackgroundImage = BackgroundBitmap
        ProgressPanel.BackgroundImage = ProgressBitmap
    End Sub

    Private Sub StylizedProgressBar_Resize(sender As Object, e As EventArgs) Handles Me.Resize
        GenerateBitmaps()
        BackgroundImage = BackgroundBitmap
        ProgressPanel.BackgroundImage = ProgressBitmap
    End Sub
End Class