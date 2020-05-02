Imports LangPadUI.Themes
''' <summary>
''' Handles the application's theme and icons.
''' </summary>
Module AppTheme
    Public Themer As ThemeManager = Nothing

    Public Sub InitThemes()
        If Themer Is Nothing Then ' No themes have been loaded yet
            Themer = New ThemeManager()

            ' Add items to theme combo on main form
            For Each Theme In Themer.Themes
                MainForm.ThemeCombo.Items.Add(Theme.Name)
            Next

            ' Init forms
            InitMainFormTheme()
            InitRtfEditorFormTheme()

            ' Get saved theme
            Dim SavedTheme = Themer.GetTheme(My.Settings.Theme)
            ' Default to light theme if none found
            If SavedTheme Is Nothing Then
                SavedTheme = New LightTheme()
            End If

            ' Apply saved theme
            Themer.CurrentTheme = SavedTheme
        End If
    End Sub

    Private Sub InitMainFormTheme()
        Themer.AddForm(MainForm)
        Themer.AddMenu(MainForm.MainMenu)
        Themer.AddToolStripContainer(MainForm.MainToolStripContainer)
        Themer.AddToolStrip(MainForm.MainToolStrip, MainForm.DataToolStrip)
        Themer.AddContextMenu(MainForm.MainContextMenu)
        Themer.AddPanel(MainForm.ColorPanel, MainForm.FindReplacePanel)
    End Sub

    Private Sub InitRtfEditorFormTheme()
        Themer.AddForm(RtfEditorForm)
        Themer.AddToolStripContainer(RtfEditorForm.MainToolStripContainer)
        Themer.AddToolStrip(RtfEditorForm.MainToolStrip)
    End Sub
End Module
