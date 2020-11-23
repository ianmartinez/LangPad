Imports LangPadData

Public Class SettingsDialog
    Private Sub SettingsDialog_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        UpdatesOnStartupCheck.Checked = Config.UpdateOnStartup
        LargeIconsCheck.Checked = Config.HiDPI
        ShowCharEditCheck.Checked = Config.ShowCharacterEditorOnStartup
    End Sub

    Private Sub OkDialogButton_Click(sender As Object, e As EventArgs) Handles OkDialogButton.Click
        Config.UpdateOnStartup = UpdatesOnStartupCheck.Checked
        Config.HiDPI = LargeIconsCheck.Checked
        Config.ShowCharacterEditorOnStartup = ShowCharEditCheck.Checked

        ' Refresh icons to DPI setting
        MainForm.SetIcons()
        RtfEditorForm.SetIcons()
        DictionaryForm.SetIcons()
        StyleDialog.SetIcons()
        CharacterEditorToolWindow.SetIcons()
        AboutDialog.SetIcons()

        Close()
    End Sub

    Private Sub CancelButton_Click(sender As Object, e As EventArgs) Handles CancelDialogButton.Click
        Close()
    End Sub
End Class
