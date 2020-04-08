Public Class dlgSettings

    Private Sub dlgSettings_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cbUpdates.Checked = My.Settings.Updates
        cbHidpi.Checked = My.Settings.HiDPI
        cbShowCharacterEditor.Checked = My.Settings.ShowCharacterEditorOnStartup
    End Sub

    Private Sub btnOK_Click(sender As Object, e As EventArgs) Handles btnOK.Click
        My.Settings.Updates = cbUpdates.Checked
        My.Settings.HiDPI = cbHidpi.Checked
        My.Settings.ShowCharacterEditorOnStartup = cbShowCharacterEditor.Checked
        My.Settings.Save()

        ' Refresh icons to DPI setting
        frmMain.SetIcons()
        frmRTF.SetIcons()
        frmDictionary.SetIcons()
        dlgStyle.SetIcons()
        CharacterEditorToolWindow.SetIcons()

        Close()
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Close()
    End Sub
End Class
