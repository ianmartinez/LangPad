Imports System.IO
Imports LangPadUI
Imports LangPadData

Public Class CharacterEditor
    Public GetCurrentTexbox As Func(Of TextBoxBase)
    Public CharSearch As New CharacterSearch()
    Public Property Character As String
    Private ReadOnly AccentsList As List(Of String) = New List(Of String)
    Private AccentsString As String = ""

    Private Sub CharacterEditor_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        SetIcons()

        If Character = "" Then Character = "a"
        CharacterTextBox.Text = Character

        SmartReplaceCheck.Visible = My.Settings.SmartReplace
        AccentsList.Clear()
        AccentsString = ""
        UpdateResult()

        If SearchModeDropDown.SelectedIndex = -1 Then
            SearchModeDropDown.SelectedIndex = 0
        End If

        InsertCharacterButton("X", BracketsPanel, "Remove Brackets", False, False, CharacterType.Bracket, Color.Red)
        InsertCharacterButton("/◌/", BracketsPanel, "Broad Transcription", False, False, CharacterType.Bracket)
        InsertCharacterButton("[◌]", BracketsPanel, "Narrow Transcription", False, False, CharacterType.Bracket)
    End Sub

    Public Sub SetIcons()
        Dim Res As IconResolution = GetIconResolution()

        ' Local
        ImportLocalToolStripButton.Image = IconManager.Get("document-import", IconSize.Small, Res)
        ExportLocalToolStripButton.Image = IconManager.Get("document-export", IconSize.Small, Res)
        ClearLocalToolStripButton.Image = IconManager.Get("edit-clear", IconSize.Small, Res)

        ' File
        ImportFileToolStripButton.Image = IconManager.Get("document-import", IconSize.Small, Res)
        ExportFileToolStripButton.Image = IconManager.Get("document-export", IconSize.Small, Res)
        ClearFileToolStripButton.Image = IconManager.Get("edit-clear", IconSize.Small, Res)

        ' Search
        SearchToolStripButton.Image = IconManager.Get("edit-find", IconSize.Small, Res)
        Refresh()
    End Sub

    Private Sub UpdateResult()
        If CharacterTextBox.Text = "" Then
            CharacterButton.Text = ""
            SmartReplaceIndicator.BackColor = Color.DimGray
            Exit Sub
        End If

        If SmartReplaceCheck.Checked Then
            Dim SmartReplacedText As String = CharacterTextBox.Text & AccentsString
            SmartReplaceIndicator.BackColor = Color.DimGray

            For Each SmartReplacePair As KeyValuePair(Of String, String) In SmartReplaceList
                SmartReplacedText = SmartReplacedText.Replace(SmartReplacePair.Key, SmartReplacePair.Value)

                If SmartReplacedText.Contains(SmartReplacePair.Value) Then
                    SmartReplaceIndicator.BackColor = Color.LimeGreen
                End If
            Next

            CharacterButton.Text = SmartReplacedText
        Else
            CharacterButton.Text = CharacterTextBox.Text & AccentsString
        End If
    End Sub

    Private Sub ToggleAccent(sender As Object, e As EventArgs)
        Dim AccentButton As AccentCheckButton = CType(sender, AccentCheckButton)

        If (AccentButton.Checked) Then
            AccentsList.Add(AccentButton.Text.Replace("◌", ""))
        Else
            AccentsList.Remove(AccentButton.Text.Replace("◌", ""))
        End If

        AccentsString = ""
        For Each Accent As String In AccentsList
            AccentsString += Accent
        Next

        UpdateResult()
    End Sub

    Public Sub AddToLocal(Character As String)
        If AppLocalCharacters.Contains(Character) Then Exit Sub

        My.Settings.CustomSymbols = My.Settings.CustomSymbols & Environment.NewLine & Character
        RefreshLocal()
    End Sub

    Public Sub RefreshLocal()
        LocalPanel.Controls.Clear()
        For Each LocalCharacter As String In AppLocalCharacters
            InsertCharacterButton(LocalCharacter, LocalPanel)
        Next
    End Sub

    Public Sub AddToFile(Character As String)
        If CurrentNotebook.Characters.Contains(Character) Then Exit Sub

        CurrentNotebook.Characters.Add(Character)
        RefreshFile()
        CurrentNotebook.Modified = True
    End Sub

    Public Sub RefreshFile()
        FilePanel.Controls.Clear()

        For Each FileChar As String In CurrentNotebook.Characters
            InsertCharacterButton(FileChar, FilePanel)
        Next
    End Sub

    Public Sub InsertCharacterButton(Text As String, Panel As FlowLayoutPanel, Optional CharName As String = "", Optional MultiLine As Boolean = True,
                                     Optional InSearch As Boolean = False, Optional CharType As CharacterType = CharacterType.All,
                                     Optional Color As Color = Nothing)
        Dim CharButton As New CharacterButton(CharName, MultiLine) With {
            .Text = Text,
            .ForeColor = If(Color = Nothing, SystemColors.ControlText, Color)
        }

        If CharType = CharacterType.Bracket Then
            AddHandler CharButton.MouseClick, AddressOf BracketButtonClick
        Else
            AddHandler CharButton.MouseClick, AddressOf CharacterButtonClick
            CharButton.ContextMenuStrip = CharButtonMenu
        End If

        Panel.Controls.Add(CharButton)

        If InSearch Then
            CharSearch.Add(Text, CharName, CharType, MultiLine)
        End If
    End Sub

    Public Sub InsertAccentButton(ByVal text As String, ByVal charName As String)
        Dim AccentButton As New AccentCheckButton(charName) With {
            .Text = text,
            .Font = New Font("Calibri", 18, FontStyle.Regular),
            .Margin = New Padding(1),
            .Padding = New Padding(0),
            .MinimumSize = New Size(45, 45),
            .BackColor = Color.Transparent
        }
        AddHandler AccentButton.Click, AddressOf ToggleAccent
        AccentsPanel.Controls.Add(AccentButton)
    End Sub

    Public Sub CharacterButtonClick(sender As Object, e As EventArgs) Handles CharacterButton.Click
        Dim CharButton As Button = CType(sender, Button)

        If My.Computer.Keyboard.AltKeyDown Then
            CharacterTextBox.Text += CharButton.Text.Replace("◌", "")
        ElseIf My.Computer.Keyboard.CtrlKeyDown Then
            AddToLocal(CharButton.Text)
        Else
            Dim CurrentTextBox = GetCurrentTexbox()
            Dim ButtonText = CharButton.Text.Replace("◌", "")

            If CurrentTextBox IsNot Nothing Then
                If My.Computer.Keyboard.ShiftKeyDown Then
                    ButtonText = ButtonText.ToUpper()
                End If

                InsertText(CurrentTextBox, ButtonText)
                Show()
            End If
        End If
    End Sub

    Public Sub BracketButtonClick(sender As Object, e As EventArgs)
        Dim BracketButton As Button = CType(sender, Button)
        Dim CurrentTextBox = GetCurrentTexbox()
        Dim InsertButton = BracketButton.Text.Contains("◌")

        If InsertButton Then
            Dim Brackets = BracketButton.Text.Split("◌")
            Dim BracketOpen = Brackets(0)
            Dim BracketClose = Brackets(1)

            If CurrentTextBox IsNot Nothing Then
                InsertBrackets(CurrentTextBox, BracketOpen, BracketClose)
            End If
        Else ' Remove bracket button
            RemoveAllBrackets(CurrentTextBox)
        End If

        Show()
    End Sub

    Public Sub RefreshPanels()
        For Each Control In Controls
            If TypeOf (Control) Is FlowLayoutPanel Then
                Dim Panel = CType(Control, FlowLayoutPanel)
                Panel.SetAutoScrollMargin(10, 10)
                Panel.PerformLayout()
                Panel.Refresh()
            End If
        Next

        Refresh()
    End Sub

    Private Function GetButtonText(sender As Object) As String
        Return CType(sender, Button).Text
    End Function

    Private Function GetButtonTextFromMenu(sender As Object) As String
        Dim CurrentItem As ToolStripMenuItem = CType(sender, ToolStripMenuItem)
        Dim CurrentContextMenu As ContextMenuStrip = CType(CurrentItem.Owner, ContextMenuStrip)
        Return GetButtonText(CurrentContextMenu.SourceControl).Replace("◌", "")
    End Function

    Private Sub CharacterTextBox_TextChanged(sender As Object, e As EventArgs) Handles CharacterTextBox.TextChanged
        UpdateResult()
    End Sub

    Private Sub CopyToClipboardMenuItem_Click(sender As Object, e As EventArgs) Handles CopyToClipboardMenuItem.Click
        Clipboard.SetText(GetButtonTextFromMenu(sender))
    End Sub

    Private Sub CopyToEditorMenuItem_Click(sender As Object, e As EventArgs) Handles ReplaceEditorCharacterMenuItem.Click
        CharacterTextBox.Text = GetButtonTextFromMenu(sender)
    End Sub

    Private Sub CopyToClipboardButton_Click(sender As Object, e As EventArgs) Handles CopyToClipboardButton.Click
        Clipboard.SetText(CharacterButton.Text)
    End Sub

    Private Sub UppercaseButton_Click(sender As Object, e As EventArgs) Handles UppercaseButton.Click
        CharacterTextBox.Text = CharacterTextBox.Text.ToUpper()
    End Sub

    Private Sub LowercaseButton_Click(sender As Object, e As EventArgs) Handles LowercaseButton.Click
        CharacterTextBox.Text = CharacterTextBox.Text.ToLower()
    End Sub

    Private Sub AffricateButton_Click(sender As Object, e As EventArgs) Handles AffricateButton.Click
        Dim Affricate As String = "◌͡◌".Replace("◌", "")

        If CharacterTextBox.Text.Contains(Affricate) Then
            CharacterTextBox.Text = CharacterTextBox.Text.Replace(Affricate, "")
        Else
            CharacterTextBox.Text = CharacterTextBox.Text.Insert(Math.Max(CharacterTextBox.Text.Length - 1, 0), Affricate)
        End If
    End Sub

    Private Sub AddToEditorCharacterMenuItem_Click(sender As Object, e As EventArgs) Handles AddToEditorCharacterMenuItem.Click
        CharacterTextBox.Text &= GetButtonTextFromMenu(sender)
    End Sub

    Private Sub ClearButton_Click(sender As Object, e As EventArgs) Handles ClearButton.Click
        For Each Control As Control In AccentsPanel.Controls
            If TypeOf Control Is AccentCheckButton Then
                Dim AccentCheckButton As AccentCheckButton = CType(Control, AccentCheckButton)
                AccentCheckButton.Checked = False
            End If
        Next

        AccentsList.Clear()
        AccentsString = ""
        CharacterTextBox.Text = ""
        UpdateResult()
    End Sub

    Private Sub AddToFileButton_Click(sender As Object, e As EventArgs) Handles AddToFileButton.Click
        AddToFile(CharacterButton.Text)
    End Sub

    Private Sub AddToLocalButton_Click(sender As Object, e As EventArgs) Handles AddToLocalButton.Click
        AddToLocal(CharacterButton.Text)
    End Sub

    Private Sub CopyToFileMenuItem_Click(sender As Object, e As EventArgs) Handles CopyToFileMenuItem.Click
        AddToFile(GetButtonTextFromMenu(sender))
    End Sub

    Private Sub CopyToLocalMenuItem_Click(sender As Object, e As EventArgs) Handles CopyToLocalMenuItem.Click
        AddToLocal(GetButtonTextFromMenu(sender))
    End Sub

    Private Sub RemoveToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RemoveToolStripMenuItem.Click
        Dim CurrentItem As ToolStripMenuItem = CType(sender, ToolStripMenuItem)
        Dim CurrentMenu As ContextMenuStrip = CType(CurrentItem.Owner, ContextMenuStrip)
        Dim CurrentButton = CType(CurrentMenu.SourceControl, CharacterButton)

        If CurrentButton.Parent Is FilePanel Then
            If CurrentNotebook.Characters.Contains(CurrentButton.Text) Then
                CurrentNotebook.Characters.Remove(CurrentButton.Text)
                RefreshFile()
            End If
        ElseIf CurrentButton.Parent Is LocalPanel Then
            Dim LocalChars As List(Of String) = AppLocalCharacters.ToList()
            If LocalChars.Contains(CurrentButton.Text) Then
                LocalChars.Remove(CurrentButton.Text)
                My.Settings.CustomSymbols = String.Join(Environment.NewLine, LocalChars.ToArray())
                RefreshLocal()
            End If
        End If
    End Sub

    Private Sub CharButtonMenu_Opening(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles CharButtonMenu.Opening
        Dim CurrentMenu As ContextMenuStrip = CType(sender, ContextMenuStrip)
        Dim CurrentButton = CType(CurrentMenu.SourceControl, CharacterButton)

        RemoveCharSplitter.Visible = False
        RemoveToolStripMenuItem.Visible = False

        If CurrentButton.Parent Is FilePanel Or CurrentButton.Parent Is LocalPanel Then
            RemoveCharSplitter.Visible = True
            RemoveToolStripMenuItem.Visible = True
        End If
    End Sub

    Private Function ConfirmClear() As DialogResult
        Return MessageBox.Show("Are you sure you want to clear all characters? This cannot be undone.", "", MessageBoxButtons.YesNoCancel)
    End Function

    Private Sub ClearLocalToolStripButton_Click(sender As Object, e As EventArgs) Handles ClearLocalToolStripButton.Click
        If ConfirmClear() = DialogResult.Yes Then
            My.Settings.CustomSymbols = ""
            RefreshLocal()
        End If
    End Sub

    Private Sub ClearFileToolStripButton_Click(sender As Object, e As EventArgs) Handles ClearFileToolStripButton.Click
        If ConfirmClear() = DialogResult.Yes Then
            CurrentNotebook.Characters.Clear()
            CurrentNotebook.Modified = True
            RefreshFile()
        End If
    End Sub

    Private Sub ImportFile(FileName As String, ByRef Characters As List(Of String))
        Dim Lines As String() = File.ReadAllText(FileName).Split({Environment.NewLine}, StringSplitOptions.RemoveEmptyEntries)

        For i = 0 To Lines.Length - 1
            If Lines.GetValue(i) = "" Then Continue For
            If Characters.Contains(Lines.GetValue(i)) Then Continue For

            Characters.Add(Lines.GetValue(i))
        Next
    End Sub

    Private Sub ImportLocalToolStripButton_Click(sender As Object, e As EventArgs) Handles ImportLocalToolStripButton.Click
        If OpenDialog.ShowDialog = Windows.Forms.DialogResult.OK Then
            Dim LocalChars = Lines.Get(My.Settings.CustomSymbols).ToList()
            ImportFile(OpenDialog.FileName, LocalChars)
            My.Settings.CustomSymbols = String.Join(vbLf, LocalChars)
            My.Settings.Save()
            RefreshLocal()
        End If
    End Sub

    Private Sub ImportFileToolStripButton_Click(sender As Object, e As EventArgs) Handles ImportFileToolStripButton.Click
        If OpenDialog.ShowDialog = Windows.Forms.DialogResult.OK Then
            ImportFile(OpenDialog.FileName, CurrentNotebook.Characters)
            RefreshFile()
        End If
    End Sub

    Private Sub ExportLocalToolStripButton_Click(sender As Object, e As EventArgs) Handles ExportLocalToolStripButton.Click
        If SaveDialog.ShowDialog = Windows.Forms.DialogResult.OK Then
            File.WriteAllText(SaveDialog.FileName, My.Settings.CustomSymbols)
        End If
    End Sub

    Private Sub ExportFileToolStripButton_Click(sender As Object, e As EventArgs) Handles ExportFileToolStripButton.Click
        If SaveDialog.ShowDialog = Windows.Forms.DialogResult.OK Then
            File.WriteAllText(SaveDialog.FileName, String.Join(vbLf, CurrentNotebook.Characters))
        End If
    End Sub

    Private Sub SearchToolStripButton_Click(sender As Object, e As EventArgs) Handles SearchToolStripButton.Click
        Dim SearchModeString = SearchModeDropDown.SelectedItem.ToString()
        Dim SearchMode As CharacterType = CharacterType.All

        Select Case SearchModeString
            Case "All"
                SearchMode = CharacterType.All

            Case "Extended Latin"
                SearchMode = CharacterType.ExtendedLatin
            Case "Extended Cyrillic"
                SearchMode = CharacterType.ExtendedCyrillic
            Case "Extended Greek"
                SearchMode = CharacterType.ExtendedGreek

            Case "IPA (All)"
                SearchMode = CharacterType.IPAAll
            Case "IPA Consonants"
                SearchMode = CharacterType.IPAConsonant
            Case "IPA Affricates"
                SearchMode = CharacterType.IPAAffricate
            Case "IPA Vowels"
                SearchMode = CharacterType.IPAVowel
            Case "IPA Tones"
                SearchMode = CharacterType.IPATone
            Case "IPA Diacritics"
                SearchMode = CharacterType.IPADiacritic
            Case "IPA Suprasegmentals"
                SearchMode = CharacterType.IPASuprasegmental
        End Select

        SearchCharPanel.Controls.Clear()
        SearchCharPanel.SuspendLayout()

        Dim Matches = CharSearch.Search(SearchQueryTextBox.Text, SearchMode)
        For Each Character As CharacterInfo In Matches
            InsertCharacterButton(Character.Character, SearchCharPanel, Character.Description, Character.MultiLine)
        Next

        SearchCharPanel.ResumeLayout()
    End Sub

    Private Sub SearchQueryTextBox_KeyPress(sender As Object, e As KeyPressEventArgs) Handles SearchQueryTextBox.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then SearchToolStripButton_Click(sender, e)
    End Sub

    Private Sub SearchModeDropDown_KeyPress(sender As Object, e As KeyPressEventArgs) Handles SearchModeDropDown.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then SearchToolStripButton_Click(sender, e)
    End Sub

    Private Sub CharacterEditor_VisibleChanged(sender As Object, e As EventArgs) Handles MyBase.VisibleChanged
        ' Force WinForms to refresh the autoscroll dimensions because it calculates
        ' it wrong the first time.
        AccentsPanel.AutoScroll = False
        Refresh()
        AccentsPanel.AutoScroll = True
    End Sub
End Class