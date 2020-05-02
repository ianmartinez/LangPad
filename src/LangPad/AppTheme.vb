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
            InitDictionaryFormTheme()
            InitCharEditTheme()

            ' Get saved theme
            Dim SavedTheme = Themer.GetTheme(My.Settings.Theme)
            ' Default to light theme if none found
            If SavedTheme Is Nothing Then
                SavedTheme = New LightTheme()
            End If

            ' Add each theme to the theme combo
            MainForm.ThemeCombo.Items.Clear()
            For Each Theme In Themer.Themes
                MainForm.ThemeCombo.Items.Add(Theme.Name)
            Next

            ' Apply saved theme
            Themer.CurrentTheme = SavedTheme

            ' Set the theme combo to be the current theme
            MainForm.ThemeCombo.SelectedItem = Themer.CurrentTheme.Name

        End If
    End Sub

    Private Sub InitMainFormTheme()
        Themer.AddForm(MainForm)
        Themer.AddMenu(MainForm.MainMenu)
        Themer.AddToolStripContainer(MainForm.MainToolStripContainer)
        Themer.AddToolStrip(MainForm.MainToolStrip, MainForm.DataToolStrip)
        Themer.AddContextMenu(MainForm.MainContextMenu)
        Themer.AddPanel(MainForm.ColorPanel, MainForm.FindReplacePanel)

        ' Noteobook editor
        Themer.AddToolStrip(MainForm.NotebookEditorPanel.DocumentToolStrip)
        Themer.AddToolStripContainer(MainForm.NotebookEditorPanel.DocumentToolStripContainer)
    End Sub

    Private Sub InitRtfEditorFormTheme()
        Themer.AddForm(RtfEditorForm)
        Themer.AddToolStripContainer(RtfEditorForm.MainToolStripContainer)
        Themer.AddToolStrip(RtfEditorForm.MainToolStrip)
    End Sub

    Private Sub InitDictionaryFormTheme()
        Themer.AddForm(DictionaryForm)
        Themer.AddToolStripContainer(DictionaryForm.MainToolStripContainer)
        Themer.AddToolStrip(DictionaryForm.MainToolStrip)
        Themer.AddGrid(DictionaryForm.DictionaryGrid)
    End Sub

    Private Sub InitCharEditTheme()
        Themer.AddToolStrip(CharEditWindow.CharEdit.FileToolStrip,
                            CharEditWindow.CharEdit.LocalToolStrip,
                            CharEditWindow.CharEdit.SearchToolStrip)
        Themer.AddContextMenu(CharEditWindow.CharEdit.CharButtonMenu)
    End Sub
End Module
