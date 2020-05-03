Imports LangPadUI
Imports LangPadUI.Theming

''' <summary>
''' Handles the application's theme.
''' </summary>
Module AppTheme
    Public Themer As ThemeManager = Nothing

    ''' <summary>
    ''' Load all of the available themes and apply
    ''' the user's selected theme, if valid.
    ''' </summary>
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
                SavedTheme = New Themes.DefaultLightTheme()
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

    ''' <summary>
    ''' Add the controls to be themed for the main form.
    ''' </summary>
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

    ''' <summary>
    ''' Add the controls to be themed for the RTF editor.
    ''' </summary>
    Private Sub InitRtfEditorFormTheme()
        Themer.AddForm(RtfEditorForm)
        Themer.AddToolStripContainer(RtfEditorForm.MainToolStripContainer)
        Themer.AddToolStrip(RtfEditorForm.MainToolStrip)
    End Sub

    ''' <summary>
    ''' Add the controls to be themed for the dictionary form.
    ''' </summary>
    Private Sub InitDictionaryFormTheme()
        Themer.AddForm(DictionaryForm)
        Themer.AddToolStripContainer(DictionaryForm.MainToolStripContainer)
        Themer.AddToolStrip(DictionaryForm.MainToolStrip)
        Themer.AddGrid(DictionaryForm.DictionaryGrid)
    End Sub

    ''' <summary>
    ''' Add the controls to be themed for the character editor.
    ''' </summary>
    Private Sub InitCharEditTheme()
        Themer.AddForm(CharEditWindow, CharEditWindow.CharEdit)
        Themer.AddToolStrip(CharEditWindow.CharEdit.FileToolStrip,
                            CharEditWindow.CharEdit.LocalToolStrip,
                            CharEditWindow.CharEdit.SearchToolStrip)
        Themer.AddContextMenu(CharEditWindow.CharEdit.CharButtonMenu)
    End Sub
End Module
