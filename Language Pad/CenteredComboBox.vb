Public Class CenteredComboBox
    Inherits ComboBox
    Sub New()
        DrawMode = DrawMode.OwnerDrawFixed
        DropDownStyle = ComboBoxStyle.DropDownList
    End Sub

    Private Sub CenteredComboBox_DrawItem(ByVal sender As Object, ByVal e As DrawItemEventArgs) Handles Me.DrawItem
        e.DrawBackground()
        Dim txt As String = ""
        If e.Index >= 0 Then txt = Items(e.Index).ToString
        TextRenderer.DrawText(e.Graphics, txt, e.Font, e.Bounds, e.ForeColor, TextFormatFlags.HorizontalCenter)
        e.DrawFocusRectangle()
    End Sub
End Class