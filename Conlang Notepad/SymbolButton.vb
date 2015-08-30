Public Class SymbolButton
    Inherits Button
    Public Sub New()
        Dim IPAFont = New Font("Segoe UI", 11, FontStyle.Regular)
        Dim IPAPadding = New Padding(0)
        Dim IPAMargin = New Padding(1)
        Dim IPAMin = New Size(45, 32)

        'Me.Style = My.Resources.KeyStyle
        Me.Padding = IPAPadding
        Me.Font = IPAFont
        Me.AutoSize = True
        Me.MinimumSize = IPAMin
        Me.Margin = IPAMargin
        Me.AutoSizeMode = Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.UseCompatibleTextRendering = True
    End Sub
End Class
