Public Class CenteredComboBox
    Inherits ComboBox
    Sub New()
        Me.DrawMode = Windows.Forms.DrawMode.OwnerDrawFixed
        Me.DropDownStyle = ComboBoxStyle.DropDownList
    End Sub

    Private Sub CenteredComboBox_DrawItem(ByVal sender As Object, ByVal e As System.Windows.Forms.DrawItemEventArgs) Handles Me.DrawItem
        e.DrawBackground()
        Dim txt As String = ""
        If e.Index >= 0 Then txt = Me.Items(e.Index).ToString
        TextRenderer.DrawText(e.Graphics, txt, e.Font, e.Bounds, e.ForeColor, TextFormatFlags.HorizontalCenter)
        e.DrawFocusRectangle()
    End Sub
End Class