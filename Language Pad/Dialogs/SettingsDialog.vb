Public Class SettingsDialog
    Private Sub SettingsDialog_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        UpdatesOnStartupCheck.Checked = My.Settings.Updates
        LargeIconsCheck.Checked = My.Settings.HiDPI
        ShowCharEditCheck.Checked = My.Settings.ShowCharacterEditorOnStartup
    End Sub

    Private Sub OkDialogButton_Click(sender As Object, e As EventArgs) Handles OkDialogButton.Click
        My.Settings.Updates = UpdatesOnStartupCheck.Checked
        My.Settings.HiDPI = LargeIconsCheck.Checked
        My.Settings.ShowCharacterEditorOnStartup = ShowCharEditCheck.Checked
        My.Settings.Save()

        ' Refresh icons to DPI setting
        MainForm.SetIcons()
        RtfEditorForm.SetIcons()
        DictionaryForm.SetIcons()
        StyleDialog.SetIcons()
        CharacterEditorToolWindow.SetIcons()

        Close()
    End Sub

    Private Sub CancelButton_Click(sender As Object, e As EventArgs) Handles CancelDialogButton.Click
        Close()
    End Sub
End Class
