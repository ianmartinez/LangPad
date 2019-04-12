Imports Tundra.ZiaFile

Public Class dlgTextArt
    Dim Loading As Boolean = True
    Private Sub ApplyText()
        If Loading = True Then Exit Sub
        Dim Zia As New List(Of ZiaLine)

        Zia.Add(New ZiaLine(LineType.KeyValue, "Colors", ToCompatibleColorList({btnColor1.Color, btnColor2.Color})))
        Zia.Add(New ZiaLine(LineType.KeyValue, "Positions", ToCompatibleSingleList({0.0F, 1.0F})))
        Zia.Add(New ZiaLine(LineType.KeyValue, "Angle", nudAngle.Value))
        Zia.Add(New ZiaLine(LineType.KeyValue, "Border Color", ToCompatibleColor(btnBorderColor.Color)))
        Zia.Add(New ZiaLine(LineType.KeyValue, "Border Size", nudSize.Value))
        Zia.Add(New ZiaLine(LineType.KeyValue, "Shadow Color", ToCompatibleColor(btnShadowColor.Color)))
        Zia.Add(New ZiaLine(LineType.KeyValue, "Shadow Offset", String.Format("({0},{1})", nudShadowX.Value, nudShadowY.Value)))

        StylizedText1.Style = Write(Zia)
    End Sub
    Private Sub OK_Button_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnOK.Click
        frmMain.SelectedDocument.InsertImage(StylizedText1.DrawBitmap)
        DialogResult = DialogResult.OK
        Close()
    End Sub

    Private Sub Cancel_Button_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnCancel.Click
        DialogResult = DialogResult.Cancel
        Close()
    End Sub

    Private Sub txtText_TextChanged(sender As Object, e As EventArgs) Handles txtText.TextChanged
        StylizedText1.ControlText = txtText.Text + ""
    End Sub

    Private Sub btnColor1_Click(sender As Object, e As EventArgs) Handles btnColor1.ColorChanged
        ApplyText()
    End Sub

    Private Sub btnColor2_Click(sender As Object, e As EventArgs) Handles btnColor2.ColorChanged
        ApplyText()
    End Sub

    Private Sub btnBorderColor_Click(sender As Object, e As EventArgs) Handles btnBorderColor.ColorChanged
        ApplyText()
    End Sub

    Private Sub btnShadowColor_Click(sender As Object, e As EventArgs) Handles btnShadowColor.ColorChanged
        ApplyText()
    End Sub

    Private Sub btnShadowColor_ColorChanged(sender As Object, e As EventArgs) Handles btnShadowColor.ColorChanged
        ApplyText()
    End Sub

    Private Sub nudAngle_ValueChanged(sender As Object, e As EventArgs) Handles nudAngle.ValueChanged
        ApplyText()
    End Sub

    Private Sub nudShadowX_ValueChanged(sender As Object, e As EventArgs) Handles nudShadowX.ValueChanged
        ApplyText()
    End Sub

    Private Sub nudShadowY_ValueChanged(sender As Object, e As EventArgs) Handles nudShadowY.ValueChanged
        ApplyText()
    End Sub

    Private Sub btnFont_Click(sender As Object, e As EventArgs) Handles btnFont.Click
        Dim dlgFont As New FontDialog
        dlgFont.AllowSimulations = True
        dlgFont.ShowColor = False
        dlgFont.ShowEffects = True

        dlgFont.Font = StylizedText1.Font
        If dlgFont.ShowDialog() = Windows.Forms.DialogResult.OK Then
            StylizedText1.Font = dlgFont.Font
        End If

        ApplyText()
    End Sub

    Private Sub dlgTextArt_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Loading = False

        If txtText.Text = "" Then
            txtText.Text = "Text Art"
        End If

        ApplyText()
    End Sub

    Private Sub nudSize_ValueChanged(sender As Object, e As EventArgs) Handles nudSize.ValueChanged
        ApplyText()
    End Sub

    Private Sub StylizedText1_Paint(sender As Object, e As PaintEventArgs) Handles StylizedText1.Paint

    End Sub
End Class
