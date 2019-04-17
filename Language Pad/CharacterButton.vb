
Public Class CharacterButton
    Inherits Button
    Private components As System.ComponentModel.IContainer
    Private ttIPa As New IPAToolTip

    Public Sub New()
        Dim IPAFont = New Font("Calibri", 11, FontStyle.Bold)
        Dim IPAPadding = New Padding(0)
        Dim IPAMargin = New Padding(3, 3, 3, 6)
        Dim IPAMin = New Size(45, 32)

        Padding = IPAPadding
        Font = IPAFont
        AutoSize = True
        MinimumSize = IPAMin
        Margin = IPAMargin
        AutoSizeMode = AutoSizeMode.GrowAndShrink
        UseCompatibleTextRendering = True
    End Sub

    Private Sub SymbolButton_TextChanged(sender As Object, e As EventArgs) Handles Me.TextChanged
        ttIPa.SetToolTip(Me, Text)
    End Sub

    Private Sub SymbolButton_Click(sender As Object, e As EventArgs) Handles Me.Click

    End Sub

    Private Sub InitializeComponent()
        Me.SuspendLayout()
        Me.ResumeLayout(False)
    End Sub

    Private Sub CharacterButton_MouseClick(sender As Object, e As MouseEventArgs) Handles MyBase.MouseClick

        If e.Button = MouseButtons.Right Then
        Else
        End If
    End Sub
End Class


Public Class IPAToolTip
    Inherits ToolTip

    Sub New()
        MyBase.New()
        OwnerDraw = True
        AddHandler Draw, AddressOf OnDraw
    End Sub
    Public Sub New(ByVal Cont As System.ComponentModel.IContainer)
        MyBase.New(Cont)
        OwnerDraw = True
        ReshowDelay = 10
        InitialDelay = 10
        AutomaticDelay = 2
        AddHandler Draw, AddressOf OnDraw
    End Sub

    Private Sub IPAToolTip_Popup(sender As Object, e As PopupEventArgs) Handles Me.Popup
        Dim TextSize As Size = TextRenderer.MeasureText(GetToolTip(e.AssociatedControl), New Font("Calibri", 42, FontStyle.Bold))
        e.ToolTipSize = New Size(TextSize.Width + 12, TextSize.Height + 12)
    End Sub

    Private Sub OnDraw(ByVal sender As Object, ByVal e As DrawToolTipEventArgs)
        Dim rectBorder As New Rectangle(0, 0, e.Bounds.Width - 1, e.Bounds.Height - 1)
        Dim rect As New Rectangle(1, 1, e.Bounds.Width - 2, e.Bounds.Height - 2)
        Dim b As New Drawing2D.LinearGradientBrush(rect, Color.FromArgb(120, 120, 120), Color.FromArgb(20, 20, 20), 45)
        Dim b2 As New Pen(Color.FromArgb(0, 0, 0))

        e.Graphics.FillRectangle(b, rect)
        e.Graphics.DrawRectangle(b2, rectBorder)

        Dim text As DrawToolTipEventArgs = New DrawToolTipEventArgs(
           e.Graphics,
           e.AssociatedWindow,
           e.AssociatedControl,
           New Rectangle(e.Bounds.Left + 3, e.Bounds.Top + 3, e.Bounds.Right - 6, e.Bounds.Bottom - 6),
           e.ToolTipText,
           BackColor,
           Color.FromArgb(255, 255, 255),
           New Font("Calibri", 42, FontStyle.Bold))

        Dim shadow As DrawToolTipEventArgs = New DrawToolTipEventArgs(
           e.Graphics,
           e.AssociatedWindow,
           e.AssociatedControl,
           New Rectangle(e.Bounds.Left + 5, e.Bounds.Top + 5, e.Bounds.Right - 8, e.Bounds.Bottom - 8),
           e.ToolTipText,
           BackColor,
           Color.FromArgb(0, 0, 0),
           New Font("Calibri", 42, FontStyle.Bold))

        shadow.DrawText()
        text.DrawText()
    End Sub
End Class

Public Class AccentCheckButton
    Inherits CheckBox
    Private ttIPa As New IPAToolTip

    Public Sub New()
        Dim IPAFont = New Font("Calibri", 14, FontStyle.Regular)
        Dim IPAPadding = New Padding(0)
        Dim IPAMargin = New Padding(1)
        Dim IPAMin = New Size(45, 32)

        Padding = IPAPadding
        Font = IPAFont
        AutoSize = True
        MinimumSize = IPAMin
        Margin = IPAMargin
        Appearance = Appearance.Button
        TextAlign = ContentAlignment.MiddleCenter
        UseCompatibleTextRendering = True
    End Sub

    Private Sub InitializeComponent()
        SuspendLayout()
        ResumeLayout(False)
    End Sub

    Private Sub SymbolButton_TextChanged(sender As Object, e As EventArgs) Handles Me.TextChanged
        ttIPa.SetToolTip(Me, Text)
    End Sub
End Class
