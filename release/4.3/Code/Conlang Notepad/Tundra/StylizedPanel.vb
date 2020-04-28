Imports System.Drawing
Imports System.Drawing.Drawing2D
Imports System.Windows.Forms
Imports Tundra.ZiaFile
Imports System.ComponentModel.Design
Imports System.ComponentModel
Imports System.Drawing.Design

Public Class StylizedPanel
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
            Refresh()
        End Set
    End Property

    Private Colors As Color()
    Private Positions As Single()
    Private Angle As Integer
    Private Radius As Integer
    Private BorderColor As Color
    Private HighlightColor As Color
    Private BottomOnly As Boolean
    Private NoBorder As Boolean
    Private NoAA As Boolean
    Private Sub ReadStyle()
        On Error Resume Next

        Colors = FromCompatibleColorList(GetValue(Style, "Colors"))
        Positions = FromCompatibleSingleList(GetValue(Style, "Positions"))
        Angle = CInt(GetValue(Style, "Angle"))
        Radius = CInt(GetValue(Style, "Radius"))
        BorderColor = FromCompatibleColor(GetValue(Style, "Border Color"))
        HighlightColor = FromCompatibleColor(GetValue(Style, "Highlight Color"))
        BottomOnly = GetValue(Style, "Bottom Only")
        NoBorder = GetValue(Style, "No Border")
        NoAA = GetValue(Style, "No AA")
    End Sub

    Private Sub StylizedPanel_Paint(ByVal sender As Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Me.Paint
        On Error Resume Next
        If Style = "" Then Exit Sub
        e.Graphics.CompositingQuality = CompositingQuality.HighQuality
        e.Graphics.SmoothingMode = SmoothingMode.AntiAlias

        If NoAA = True Then
            e.Graphics.SmoothingMode = SmoothingMode.None
        End If

        Dim Blend As New ColorBlend()
        Dim FillRectangle As New Rectangle(-1, -1, Me.Width + 2, Me.Height + 2)
        Dim FillRoundedRectangle As GraphicsPath = RoundedRectangle(FillRectangle, Radius)
        Dim FillBlend As New LinearGradientBrush(FillRectangle, Color.Transparent, Color.Transparent, Angle)

        Dim BorderRectangle As New Rectangle(0, 0, Me.Width - 1, Me.Height - 1)
        Dim BorderRoundedRectangle As GraphicsPath = RoundedRectangle(BorderRectangle, Radius)

        Dim HighlightRectangle As New Rectangle(1, 1, Me.Width - 3, Me.Height - 3)
        Dim HighlightRoundedRectangle As GraphicsPath = RoundedRectangle(HighlightRectangle, Radius)

        Blend.Colors = Colors
        Blend.Positions = Positions
        FillBlend.InterpolationColors = Blend

        If NoBorder = True Then
            FillRectangle = New Rectangle(-1, -1, Me.Width + 3, Me.Height + 3)
            FillRoundedRectangle = RoundedRectangle(FillRectangle, Radius)
        End If

        If NoBorder = False AndAlso BottomOnly = False AndAlso Not BorderColor = Color.Transparent Then
            FillRectangle = BorderRectangle
            FillRoundedRectangle = BorderRoundedRectangle
        End If

        e.Graphics.FillPath(FillBlend, FillRoundedRectangle)

        If NoBorder = False Then
            If BottomOnly = True Then
                BorderRectangle = New Rectangle(-1, -1, Me.Width + 2, Me.Height - 0)
                HighlightRectangle = New Rectangle(-1, -1, Me.Width + 2, Me.Height - 1)
                BorderRoundedRectangle = RoundedRectangle(BorderRectangle, Radius)
                HighlightRoundedRectangle = RoundedRectangle(HighlightRectangle, Radius)
            End If
            e.Graphics.DrawPath(New Pen(New SolidBrush(BorderColor)), BorderRoundedRectangle)
            e.Graphics.DrawPath(New Pen(New SolidBrush(HighlightColor)), HighlightRoundedRectangle)
        End If
    End Sub
End Class
