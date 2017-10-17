Imports System.Windows.Forms

Public Class dlgSettings


    Private Sub dlgSettings_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cbAccent.Checked = My.Settings.AccentMarks
        cbAffricates.Checked = My.Settings.IPAAffricates
        cbCommon.Checked = My.Settings.CommonChar
        cbConsonants.Checked = My.Settings.IPAConsonants
        cbOther.Checked = My.Settings.OtherIPA
        cbTones.Checked = My.Settings.IPATones
        cbUpdates.Checked = My.Settings.Updates
        cbVowels.Checked = My.Settings.IPAVowels
        cbSmartReplace.Checked = My.Settings.SmartReplace
    End Sub

    Private Sub btnOK_Click(sender As Object, e As EventArgs) Handles btnOK.Click
        My.Settings.AccentMarks = cbAccent.Checked
        My.Settings.IPAAffricates = cbAffricates.Checked
        My.Settings.CommonChar = cbCommon.Checked
        My.Settings.IPAConsonants = cbConsonants.Checked
        My.Settings.OtherIPA = cbOther.Checked
        My.Settings.IPATones = cbTones.Checked
        My.Settings.Updates = cbUpdates.Checked
        My.Settings.IPAVowels = cbVowels.Checked
        My.Settings.SmartReplace = cbSmartReplace.Checked

        My.Settings.Save()

        Me.Close()
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub
End Class
