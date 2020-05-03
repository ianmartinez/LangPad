Public Class CharacterButton
    Inherits Button

    Private ReadOnly components As System.ComponentModel.IContainer
    Private ReadOnly CharButtonTooltip As New IPAToolTip()

    ''' <summary>
    ''' Create a new button representing a character.
    ''' </summary>
    ''' 
    ''' <param name="CharName">The name of the character.</param>
    ''' <param name="MultiLine">If the description is multiple lines.</param>
    Public Sub New(Optional CharName = "", Optional MultiLine = True)
        Dim IPAFont = New Font("Calibri", 11, FontStyle.Bold)
        Dim IPAPadding = New Padding(0)
        Dim IPAMargin = New Padding(3, 3, 3, 6)
        Dim IPAMin = New Size(45, 45)

        Padding = IPAPadding
        ForeColor = Color.White
        BackColor = Color.Transparent
        Font = IPAFont
        AutoSize = True
        MinimumSize = IPAMin
        Margin = IPAMargin
        AutoSizeMode = AutoSizeMode.GrowAndShrink
        UseCompatibleTextRendering = True
        CharButtonTooltip.CharName = If(MultiLine, CharName.Replace("/", vbCrLf), CharName)
    End Sub

    Private Sub SymbolButton_TextChanged(sender As Object, e As EventArgs) Handles Me.TextChanged
        CharButtonTooltip.SetToolTip(Me, Text)
    End Sub

    Private Sub InitializeComponent()
        SuspendLayout()
        ResumeLayout(False)
    End Sub
End Class

Public Class IPAToolTip
    Inherits ToolTip

    Public CharName As String = ""
    Private ReadOnly CharNameFont = New Font("Calibri", 12, FontStyle.Regular)
    Private ReadOnly TextFont = New Font("Calibri", 42, FontStyle.Bold)

    Sub New()
        MyBase.New()
        OwnerDraw = True
        AddHandler Draw, AddressOf OnDraw
    End Sub

    Public Sub New(ByVal Cont As System.ComponentModel.IContainer)
        MyBase.New(Cont)
        OwnerDraw = True
        ReshowDelay = 10
        AutoPopDelay = 20
        InitialDelay = 10
        AutomaticDelay = 2

        AddHandler Draw, AddressOf OnDraw
    End Sub

    Private Sub IPAToolTip_Popup(sender As Object, e As PopupEventArgs) Handles Me.Popup
        Dim CharacterTextSize As Size = TextRenderer.MeasureText(GetToolTip(e.AssociatedControl), TextFont)
        Dim NameTextSize As Size = TextRenderer.MeasureText(CharName, CharNameFont)
        Dim Padding = New Size(12, If(String.IsNullOrWhiteSpace(CharName), 14, 16))
        e.ToolTipSize = New Size(Math.Max(NameTextSize.Width, CharacterTextSize.Width) + Padding.Width, (NameTextSize.Height + CharacterTextSize.Height) + Padding.Height)
    End Sub

    Private Sub OnDraw(ByVal sender As Object, ByVal e As DrawToolTipEventArgs)
        Dim rect As New Rectangle(0, 0, e.Bounds.Width - 1, e.Bounds.Height - 1)
        Dim background As New Drawing2D.LinearGradientBrush(rect, Color.FromArgb(60, 60, 60), Color.FromArgb(20, 20, 20), 90)
        Dim border As New Pen(Color.FromArgb(0, 0, 0))

        e.Graphics.FillRectangle(background, rect)
        e.Graphics.DrawRectangle(border, rect)

        Dim CharNameSize = TextRenderer.MeasureText(CharName, CharNameFont)
        Dim TextSize = TextRenderer.MeasureText(e.ToolTipText, TextFont)

        ' Draw the name
        If Not String.IsNullOrWhiteSpace(CharName) Then
            Dim nameRect = New Rectangle(e.Bounds.Left + ((e.Bounds.Width / 2) - (CharNameSize.Width / 2)), e.Bounds.Top + 3, e.Bounds.Right, e.Bounds.Bottom - 6)
            Dim nameShadowRect = New Rectangle(nameRect.X + 1, nameRect.Y + 1, nameRect.Width, nameRect.Height)
            e.Graphics.DrawString(CharName, CharNameFont, New SolidBrush(Color.Black), nameShadowRect)
            e.Graphics.DrawString(CharName, CharNameFont, New SolidBrush(Color.Gainsboro), nameRect)
        End If

        ' Draw the character
        Dim textRect = New Rectangle(e.Bounds.Left + ((e.Bounds.Width / 2) - (TextSize.Width / 2)),
                                     e.Bounds.Top + If(String.IsNullOrWhiteSpace(CharName), 0, CharNameSize.Height + 6) + 3,
                                     e.Bounds.Right,
                                     e.Bounds.Bottom - 6)
        Dim textShadowRect = New Rectangle(textRect.X + 2, textRect.Y + 2, textRect.Width, textRect.Height)
        e.Graphics.DrawString(e.ToolTipText, TextFont, New SolidBrush(Color.Black), textShadowRect)
        e.Graphics.DrawString(e.ToolTipText, TextFont, New SolidBrush(Color.White), textRect)
    End Sub
End Class

Public Class AccentCheckButton
    Inherits CheckBox

    Private ReadOnly CharButtonTooltip As New IPAToolTip()

    Public Sub New(Optional CharName = "", Optional MultiLine = True)
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
        CharButtonTooltip.CharName = If(MultiLine, CharName.Replace("/", vbCrLf), CharName)
    End Sub

    Private Sub InitializeComponent()
        SuspendLayout()
        ResumeLayout(False)
    End Sub

    Private Sub SymbolButton_TextChanged(sender As Object, e As EventArgs) Handles Me.TextChanged
        CharButtonTooltip.SetToolTip(Me, Text)
    End Sub
End Class
