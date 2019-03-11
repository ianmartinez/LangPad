Imports System.Windows.Forms
Imports System.ComponentModel
Imports System.Drawing.Design
Imports System.Drawing
Imports System.Drawing.Drawing2D

Public Class StylizedCheckBox
    Inherits CheckBox
    Private mStyle As String
    <Editor(GetType(MultilineStringEditor), GetType(UITypeEditor))> _
    Public Property Style As String
        Get
            Return mStyle
        End Get
        Set(ByVal value As String)
            mStyle = value
            On Error Resume Next
            GenerateBitmaps()
            If Checked = True Then
                ApplyChecked()
            Else
                BackgroundImage = ActiveBitmap
                ForeColor = ActiveTextColor
            End If
        End Set
    End Property

    Private Radius As Integer

    Private ActiveColors As Color()
    Private ActivePositions As Single()
    Private ActiveAngle As Integer
    Private ActiveBorderColor As Color
    Private ActiveTextColor As Color
    Private ActiveHighlightColor As Color

    Private HoverColors As Color()
    Private HoverPositions As Single()
    Private HoverAngle As Integer
    Private HoverBorderColor As Color
    Private HoverTextColor As Color
    Private HoverHighlightColor As Color

    Private PressedColors As Color()
    Private PressedPositions As Single()
    Private PressedAngle As Integer
    Private PressedBorderColor As Color
    Private PressedTextColor As Color
    Private PressedHighlightColor As Color

    Private CheckedColors As Color()
    Private CheckedPositions As Single()
    Private CheckedAngle As Integer
    Private CheckedBorderColor As Color
    Private CheckedTextColor As Color
    Private CheckedHighlightColor As Color

    Private ActiveBitmap As Bitmap
    Private HoverBitmap As Bitmap
    Private PressedBitmap As Bitmap
    Private CheckedBitmap As Bitmap

    Private Sub ReadStyle()
        On Error Resume Next
        Radius = CInt(GetValue(Style, "Radius"))

        ActiveColors = FromCompatibleColorList(GetValue(Style, "Active Colors"))
        ActivePositions = FromCompatibleSingleList(GetValue(Style, "Active Positions"))
        ActiveAngle = CInt(GetValue(Style, "Active Angle"))
        ActiveBorderColor = FromCompatibleColor(GetValue(Style, "Active Border Color"))
        ActiveTextColor = FromCompatibleColor(GetValue(Style, "Active Text Color"))
        ActiveHighlightColor = FromCompatibleColor(GetValue(Style, "Active Highlight Color"))

        HoverColors = FromCompatibleColorList(GetValue(Style, "Hover Colors"))
        HoverPositions = FromCompatibleSingleList(GetValue(Style, "Hover Positions"))
        HoverAngle = CInt(GetValue(Style, "Hover Angle"))
        HoverBorderColor = FromCompatibleColor(GetValue(Style, "Hover Border Color"))
        HoverTextColor = FromCompatibleColor(GetValue(Style, "Hover Text Color"))
        HoverHighlightColor = FromCompatibleColor(GetValue(Style, "Hover Highlight Color"))

        PressedColors = FromCompatibleColorList(GetValue(Style, "Pressed Colors"))
        PressedPositions = FromCompatibleSingleList(GetValue(Style, "Pressed Positions"))
        PressedAngle = CInt(GetValue(Style, "Pressed Angle"))
        PressedBorderColor = FromCompatibleColor(GetValue(Style, "Pressed Border Color"))
        PressedTextColor = FromCompatibleColor(GetValue(Style, "Pressed Text Color"))
        PressedHighlightColor = FromCompatibleColor(GetValue(Style, "Pressed Highlight Color"))

        CheckedColors = FromCompatibleColorList(GetValue(Style, "Checked Colors"))
        CheckedPositions = FromCompatibleSingleList(GetValue(Style, "Checked Positions"))
        CheckedAngle = CInt(GetValue(Style, "Checked Angle"))
        CheckedBorderColor = FromCompatibleColor(GetValue(Style, "Checked Border Color"))
        CheckedTextColor = FromCompatibleColor(GetValue(Style, "Checked Text Color"))
        CheckedHighlightColor = FromCompatibleColor(GetValue(Style, "Checked Highlight Color"))
    End Sub

    Private Sub GenerateBitmaps()
        On Error Resume Next
        ReadStyle()
        ActiveBitmap = New Bitmap(Width, Height)
        HoverBitmap = New Bitmap(Width, Height)
        PressedBitmap = New Bitmap(Width, Height)
        CheckedBitmap = New Bitmap(Width, Height)

        Dim FillRectangle As New Rectangle(0, 0, Width - 1, Height - 1)
        Dim HighlightRectangle As New Rectangle(1, 1, Width - 3, Height - 3)
        Dim FillRoundedRectangle As GraphicsPath = RoundedRectangle(FillRectangle, Radius)
        Dim HighlightRoundedRectangle As GraphicsPath = RoundedRectangle(HighlightRectangle, Radius)

        Dim ActiveGraphics As Graphics = Graphics.FromImage(ActiveBitmap)
        ActiveGraphics.CompositingQuality = CompositingQuality.HighQuality
        ActiveGraphics.SmoothingMode = SmoothingMode.AntiAlias
        Dim ActiveBlend As New ColorBlend()
        Dim ActiveFillBlend As New LinearGradientBrush(FillRectangle, Color.Transparent, Color.Transparent, ActiveAngle)
        ActiveBlend.Colors = ActiveColors
        ActiveBlend.Positions = ActivePositions
        ActiveFillBlend.InterpolationColors = ActiveBlend
        ActiveGraphics.FillPath(ActiveFillBlend, FillRoundedRectangle)
        ActiveGraphics.DrawPath(New Pen(New SolidBrush(ActiveBorderColor)), FillRoundedRectangle)
        ActiveGraphics.DrawPath(New Pen(New SolidBrush(ActiveHighlightColor)), HighlightRoundedRectangle)

        Dim HoverGraphics As Graphics = Graphics.FromImage(HoverBitmap)
        HoverGraphics.CompositingQuality = CompositingQuality.HighQuality
        HoverGraphics.SmoothingMode = SmoothingMode.AntiAlias
        Dim HoverBlend As New ColorBlend()
        Dim HoverFillBlend As New LinearGradientBrush(FillRectangle, Color.Transparent, Color.Transparent, HoverAngle)
        HoverBlend.Colors = HoverColors
        HoverBlend.Positions = HoverPositions
        HoverFillBlend.InterpolationColors = HoverBlend
        HoverGraphics.FillPath(HoverFillBlend, FillRoundedRectangle)
        HoverGraphics.DrawPath(New Pen(New SolidBrush(HoverBorderColor)), FillRoundedRectangle)
        HoverGraphics.DrawPath(New Pen(New SolidBrush(HoverHighlightColor)), HighlightRoundedRectangle)

        Dim PressedGraphics As Graphics = Graphics.FromImage(PressedBitmap)
        PressedGraphics.CompositingQuality = CompositingQuality.HighQuality
        PressedGraphics.SmoothingMode = SmoothingMode.AntiAlias
        Dim PressedBlend As New ColorBlend()
        Dim PressedFillBlend As New LinearGradientBrush(FillRectangle, Color.Transparent, Color.Transparent, PressedAngle)
        PressedBlend.Colors = PressedColors
        PressedBlend.Positions = PressedPositions
        PressedFillBlend.InterpolationColors = PressedBlend
        PressedGraphics.FillPath(PressedFillBlend, FillRoundedRectangle)
        PressedGraphics.DrawPath(New Pen(New SolidBrush(PressedBorderColor)), FillRoundedRectangle)
        PressedGraphics.DrawPath(New Pen(New SolidBrush(PressedHighlightColor)), HighlightRoundedRectangle)

        Dim CheckedGraphics As Graphics = Graphics.FromImage(CheckedBitmap)
        CheckedGraphics.CompositingQuality = CompositingQuality.HighQuality
        CheckedGraphics.SmoothingMode = SmoothingMode.AntiAlias
        Dim CheckedBlend As New ColorBlend()
        Dim CheckedFillBlend As New LinearGradientBrush(FillRectangle, Color.Transparent, Color.Transparent, CheckedAngle)
        CheckedBlend.Colors = CheckedColors
        CheckedBlend.Positions = CheckedPositions
        CheckedFillBlend.InterpolationColors = CheckedBlend
        CheckedGraphics.FillPath(CheckedFillBlend, FillRoundedRectangle)
        CheckedGraphics.DrawPath(New Pen(New SolidBrush(CheckedBorderColor)), FillRoundedRectangle)
        CheckedGraphics.DrawPath(New Pen(New SolidBrush(CheckedHighlightColor)), HighlightRoundedRectangle)
    End Sub

    Public Sub New()
        DoubleBuffered = True
        SetStyle(ControlStyles.SupportsTransparentBackColor, True)
        SetStyle(ControlStyles.OptimizedDoubleBuffer, True)
        SetStyle(ControlStyles.ResizeRedraw, True)
        Appearance = Windows.Forms.Appearance.Button
        BackColor = Color.Transparent
        FlatStyle = FlatStyle.Flat
        FlatAppearance.BorderSize = 0
        FlatAppearance.MouseDownBackColor = Color.Transparent
        FlatAppearance.MouseOverBackColor = Color.Transparent
        FlatAppearance.CheckedBackColor = Color.Transparent
        FlatAppearance.BorderColor = Color.FromArgb(0, 0, 0, 0)
        AutoSize = False
        Padding = New Padding(0, 1, 0, 0)
        TextAlign = ContentAlignment.MiddleCenter
    End Sub

    Private Sub ApplyChecked()
        On Error Resume Next
        If Checked = True Then
            BackgroundImage = CheckedBitmap
            ForeColor = CheckedTextColor
        End If
    End Sub

    Private Sub StylizedCheckBox_CheckedChanged(sender As Object, e As EventArgs) Handles Me.CheckedChanged
        On Error Resume Next
        If Checked = True Then
            ApplyChecked()
        Else
            BackgroundImage = ActiveBitmap
            ForeColor = ActiveTextColor
        End If
    End Sub

    Private Sub StylizedCheckBox_LostFocus(sender As Object, e As EventArgs) Handles Me.LostFocus
        Refresh()
    End Sub

    Private Sub StylizedCheckBox_MouseDown(sender As Object, e As MouseEventArgs) Handles Me.MouseDown
        On Error Resume Next
        If Checked = True Then
            ApplyChecked()
        Else
            BackgroundImage = PressedBitmap
            ForeColor = PressedTextColor
        End If
    End Sub

    Private Sub StylizedCheckBox_MouseHover(sender As Object, e As EventArgs) Handles Me.MouseHover
        On Error Resume Next
        If Not MouseButtons = Windows.Forms.MouseButtons.Left Then
            If Checked = True Then
                ApplyChecked()
            Else
                BackgroundImage = HoverBitmap
                ForeColor = HoverTextColor
            End If
        End If
    End Sub

    Private Sub StylizedCheckBox_MouseLeave(sender As Object, e As EventArgs) Handles Me.MouseLeave
        On Error Resume Next
        If Checked = True Then
            ApplyChecked()
        Else
            BackgroundImage = ActiveBitmap
            ForeColor = ActiveTextColor
        End If
    End Sub

    Private Sub StylizedCheckBox_MouseMove(sender As Object, e As MouseEventArgs) Handles Me.MouseMove
        On Error Resume Next
        If Not MouseButtons = Windows.Forms.MouseButtons.Left Then
            If Checked = True Then
                ApplyChecked()
            Else
                BackgroundImage = HoverBitmap
                ForeColor = HoverTextColor
            End If
        End If
    End Sub

    Private Sub StylizedCheckBox_Resize(sender As Object, e As EventArgs) Handles Me.Resize
        On Error Resume Next
        GenerateBitmaps()
        If Checked = True Then
            ApplyChecked()
        Else
            BackgroundImage = ActiveBitmap
            ForeColor = ActiveTextColor
        End If
    End Sub
End Class