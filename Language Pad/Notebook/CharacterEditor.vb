Imports System.IO
Imports TundraLib.Themes

Public Class CharacterEditor
    Public GetCurrentTexbox As Func(Of TextBoxBase)
    Public Property Character As String
    Private AccentsList As List(Of String) = New List(Of String)
    Private AccentsString As String = ""
    Public Color1 As Color
    Public Color2 As Color
    Public VerticalMenuGradient As Boolean = False

    Public Sub SetTheme(Theme As Theme)
        Color1 = Theme.PanelBack
        Color2 = Theme.PanelBack
        VerticalMenuGradient = Theme.VerticalMenuGradient
        FileToolStrip.Renderer = Theme.GetToolStripRenderer()
        LocalToolStrip.Renderer = Theme.GetToolStripRenderer()

        Refresh()
    End Sub

    Private Sub UpdateResult()
        If txtCharacter.Text = "" Then
            btnCharacter.Text = ""
            pnlSmartReplace.BackColor = Color.DimGray
            Exit Sub
        End If

        If cbSmartReplace.Checked Then
            Dim result As String = txtCharacter.Text & AccentsString '
            pnlSmartReplace.BackColor = Color.DimGray

            For Each pair As KeyValuePair(Of String, String) In SmartReplaceList
                result = result.Replace(pair.Key, pair.Value)

                If result.Contains(pair.Value) Then
                    pnlSmartReplace.BackColor = Color.LimeGreen
                End If
            Next

            btnCharacter.Text = result
        Else
            btnCharacter.Text = txtCharacter.Text & AccentsString
        End If
    End Sub


    Private Sub ToggleAccent(sender As Object, e As EventArgs)
        Dim button As AccentCheckButton = CType(sender, AccentCheckButton)

        If (button.Checked) Then
            AccentsList.Add(button.Text.Replace("◌", ""))
        Else
            AccentsList.Remove(button.Text.Replace("◌", ""))
        End If

        AccentsString = ""
        For Each accent As String In AccentsList
            AccentsString += accent
        Next

        UpdateResult()
    End Sub

    Public Sub AddToLocal(Character As String)
        Dim OriginalLocalCharacters As String() = My.Settings.CustomSymbols.Split({Environment.NewLine}, StringSplitOptions.RemoveEmptyEntries)
        If OriginalLocalCharacters.Contains(Character) Then Exit Sub

        My.Settings.CustomSymbols = My.Settings.CustomSymbols & Environment.NewLine & Character
        RefreshLocal()
    End Sub

    Public Sub RefreshLocal()
        LocalCharPanel.Controls.Clear()

        Dim LocalCharacters As String() = My.Settings.CustomSymbols.Split({Environment.NewLine}, StringSplitOptions.RemoveEmptyEntries)
        For Each LocalCharacter As String In LocalCharacters
            InsertCharacterButton(LocalCharacter, LocalCharPanel)
        Next
    End Sub

    Public Sub AddToFile(Character As String)
        Dim OriginalFileChars As String() = CurrentDocument.CustomSymbols.Split({Environment.NewLine}, StringSplitOptions.RemoveEmptyEntries)
        If OriginalFileChars.Contains(Character) Then Exit Sub

        CurrentDocument.CustomSymbols = CurrentDocument.CustomSymbols & Environment.NewLine & Character
        RefreshFile()
        CurrentDocument.Modified = True
    End Sub

    Public Sub RefreshFile()
        FilePanel.Controls.Clear()

        Dim FileChars As String() = CurrentDocument.CustomSymbols.Split({Environment.NewLine}, StringSplitOptions.RemoveEmptyEntries)
        For Each FileChar As String In FileChars
            InsertCharacterButton(FileChar, FilePanel)
        Next
    End Sub
    Public Sub InsertCharacterButton(ByVal Text As String, ByVal Panel As FlowLayoutPanel, Optional ByVal CharName As String = "", Optional MultiLine As Boolean = True)
        Dim CharacterButton As New CharacterButton(CharName, MultiLine)
        CharacterButton.Text = Text
        AddHandler CharacterButton.MouseClick, AddressOf CharacterButtonClick
        CharacterButton.ContextMenuStrip = menuCharButton
        Panel.Controls.Add(CharacterButton)
    End Sub

    Public Sub InsertAccentButton(ByVal Text As String, ByVal CharName As String)
        Dim AccentButton As New AccentCheckButton(CharName) With {
            .Text = Text,
            .Font = New Font("Calibri", 18, FontStyle.Regular),
            .Margin = New Padding(1),
            .Padding = New Padding(0),
            .MinimumSize = New Size(45, 45)
        }
        AddHandler AccentButton.Click, AddressOf ToggleAccent
        AccentsLayoutPanel.Controls.Add(AccentButton)
    End Sub

    Public Sub CharacterButtonClick(sender As Object, e As EventArgs) Handles btnCharacter.Click
        Dim Button As Button = CType(sender, Button)

        If My.Computer.Keyboard.AltKeyDown Then
            txtCharacter.Text += Button.Text.Replace("◌", "")
        ElseIf My.Computer.Keyboard.CtrlKeyDown Then
            AddToLocal(Button.Text)
        Else
            Dim CurrentTextBox = GetCurrentTexbox()
            Dim ButtonText = Button.Text.Replace("◌", "")

            If CurrentTextBox IsNot Nothing Then
                If My.Computer.Keyboard.ShiftKeyDown Then
                    ButtonText = ButtonText.ToUpper()
                End If

                InsertText(CurrentTextBox, ButtonText)
            End If
        End If
    End Sub

    Public Sub InsertText(ByVal TextBox As TextBoxBase, ByVal Text As String)
        On Error Resume Next
        Dim CurrentPos As Integer = TextBox.SelectionStart
        Dim obj As Object = Clipboard.GetDataObject
        Clipboard.SetText(Text)
        TextBox.Paste()
        Clipboard.SetDataObject(obj)

        TextBox.SelectionStart = CurrentPos + Text.Length
        TextBox.SelectionLength = 0

        ' Keep the window focused
        Show()
    End Sub

    Private Sub CharacterEditor_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If Character = "" Then Character = "a"
        txtCharacter.Text = Character

        cbSmartReplace.Visible = My.Settings.SmartReplace
        AccentsList.Clear()
        AccentsString = ""
        UpdateResult()
    End Sub

    Public Sub RefreshPanels()
        For Each control In Controls
            If TypeOf (control) Is FlowLayoutPanel Then
                Dim panel = CType(control, FlowLayoutPanel)
                panel.SetAutoScrollMargin(10, 10)
                panel.PerformLayout()
                panel.Refresh()
            End If
        Next

        Refresh()
    End Sub
    Private Function GetButtonText(sender As Object) As String
        Return CType(sender, Button).Text
    End Function

    Private Function GetButtonTextFromMenu(sender As Object) As String
        Dim currentItem As ToolStripMenuItem = CType(sender, ToolStripMenuItem)
        Dim cms As ContextMenuStrip = CType(currentItem.Owner, ContextMenuStrip)
        Return GetButtonText(cms.SourceControl).Replace("◌", "")
    End Function

    Private Sub TxtCharacter_TextChanged(sender As Object, e As EventArgs) Handles txtCharacter.TextChanged
        UpdateResult()
    End Sub

    Private Sub CopyToClipboardMenuItem_Click(sender As Object, e As EventArgs) Handles CopyToClipboardMenuItem.Click
        Clipboard.SetText(GetButtonTextFromMenu(sender))
    End Sub

    Private Sub CopyToEditorMenuItem_Click(sender As Object, e As EventArgs) Handles ReplaceEditorCharacterMenuItem.Click
        txtCharacter.Text = GetButtonTextFromMenu(sender)
    End Sub

    Private Sub BtnCopyToClipboard_Click(sender As Object, e As EventArgs) Handles btnCopyToClipboard.Click
        Clipboard.SetText(btnCharacter.Text)
    End Sub

    Private Sub BtnUppercase_Click(sender As Object, e As EventArgs) Handles btnUppercase.Click
        txtCharacter.Text = txtCharacter.Text.ToUpper()
    End Sub

    Private Sub BtnLowercase_Click(sender As Object, e As EventArgs) Handles btnLowercase.Click
        txtCharacter.Text = txtCharacter.Text.ToLower()
    End Sub

    Private Sub BtnAffricate_Click(sender As Object, e As EventArgs) Handles btnAffricate.Click
        Dim affricateChar As String = "◌͡◌".Replace("◌", "")

        If txtCharacter.Text.Contains(affricateChar) Then
            txtCharacter.Text = txtCharacter.Text.Replace(affricateChar, "")
        Else
            txtCharacter.Text = txtCharacter.Text.Insert(Math.Max(txtCharacter.Text.Length - 1, 0), affricateChar)
        End If
    End Sub

    Private Sub AddToEditorCharacterMenuItem_Click(sender As Object, e As EventArgs) Handles AddToEditorCharacterMenuItem.Click
        txtCharacter.Text &= GetButtonTextFromMenu(sender)
    End Sub

    Private Sub BtnClearAll_Click(sender As Object, e As EventArgs) Handles btnClearAll.Click
        For Each control As Control In AccentsLayoutPanel.Controls
            If TypeOf control Is AccentCheckButton Then
                Dim button As AccentCheckButton = CType(control, AccentCheckButton)
                button.Checked = False
            End If
        Next

        AccentsList.Clear()
        AccentsString = ""
        txtCharacter.Text = ""
        UpdateResult()
    End Sub

    Private Sub BtnAddToFile_Click(sender As Object, e As EventArgs) Handles btnAddToFile.Click
        AddToFile(btnCharacter.Text)
    End Sub

    Private Sub BtnAddToLocal_Click(sender As Object, e As EventArgs) Handles btnAddToLocal.Click
        AddToLocal(btnCharacter.Text)
    End Sub

    Private Sub CopyToFileMenuItem_Click(sender As Object, e As EventArgs) Handles CopyToFileMenuItem.Click
        AddToFile(GetButtonTextFromMenu(sender))
    End Sub

    Private Sub CopyToLocalMenuItem_Click(sender As Object, e As EventArgs) Handles CopyToLocalMenuItem.Click
        AddToLocal(GetButtonTextFromMenu(sender))
    End Sub

    Private Sub RemoveToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RemoveToolStripMenuItem.Click
        Dim currentItem As ToolStripMenuItem = CType(sender, ToolStripMenuItem)
        Dim cms As ContextMenuStrip = CType(currentItem.Owner, ContextMenuStrip)
        Dim button = CType(cms.SourceControl, CharacterButton)

        If button.Parent Is FilePanel Then
            Dim FileChars As List(Of String) = CurrentDocument.CustomSymbols.Split({Environment.NewLine}, StringSplitOptions.RemoveEmptyEntries).ToList()
            If FileChars.Contains(button.Text) Then
                FileChars.Remove(button.Text)
                CurrentDocument.CustomSymbols = String.Join(Environment.NewLine, FileChars.ToArray())
                RefreshFile()
            End If
        ElseIf button.Parent Is LocalCharPanel Then
            Dim LocalChars As List(Of String) = My.Settings.CustomSymbols.Split({Environment.NewLine}, StringSplitOptions.RemoveEmptyEntries).ToList()
            If LocalChars.Contains(button.Text) Then
                LocalChars.Remove(button.Text)
                My.Settings.CustomSymbols = String.Join(Environment.NewLine, LocalChars.ToArray())
                RefreshLocal()
            End If
        End If
    End Sub

    Private Sub MenuCharButton_Opening(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles menuCharButton.Opening
        Dim cms As ContextMenuStrip = CType(sender, ContextMenuStrip)
        Dim button = CType(cms.SourceControl, CharacterButton)

        RemoveCharSplitter.Visible = False
        RemoveToolStripMenuItem.Visible = False

        If button.Parent Is FilePanel Or button.Parent Is LocalCharPanel Then
            RemoveCharSplitter.Visible = True
            RemoveToolStripMenuItem.Visible = True
        End If
    End Sub

    Private Function ClearConfirm() As DialogResult
        Return MessageBox.Show("Are you sure you want to clear all characters? This cannot be undone.", "", MessageBoxButtons.YesNoCancel)
    End Function

    Private Sub ClearLocalToolStripButton_Click(sender As Object, e As EventArgs) Handles ClearLocalToolStripButton.Click
        If ClearConfirm() = DialogResult.Yes Then
            My.Settings.CustomSymbols = ""
            RefreshLocal()
        End If
    End Sub

    Private Sub ClearFileToolStripButton_Click(sender As Object, e As EventArgs) Handles ClearFileToolStripButton.Click
        If ClearConfirm() = DialogResult.Yes Then
            CurrentDocument.CustomSymbols = ""
            CurrentDocument.Modified = True
            RefreshFile()
        End If
    End Sub

    Private Sub ImportFile(FileName As String, ByRef Symbols As String)
        Dim Lines As String() = File.ReadAllText(FileName).Split({Environment.NewLine}, StringSplitOptions.RemoveEmptyEntries)
        Dim Chars As List(Of String) = Symbols.Split({Environment.NewLine}, StringSplitOptions.RemoveEmptyEntries).ToList()

        For i = 0 To Lines.Length - 1
            If Lines.GetValue(i) = "" Then Continue For
            If Chars.Contains(Lines.GetValue(i)) Then Continue For

            Chars.Add(Lines.GetValue(i))
        Next

        Symbols = String.Join(Environment.NewLine, Chars)
    End Sub

    Private Sub ImportLocalToolStripButton_Click(sender As Object, e As EventArgs) Handles ImportLocalToolStripButton.Click
        If dlgOpen.ShowDialog = Windows.Forms.DialogResult.OK Then
            ImportFile(dlgOpen.FileName, My.Settings.CustomSymbols)
            RefreshLocal()
        End If
    End Sub

    Private Sub ImportFileToolStripButton_Click(sender As Object, e As EventArgs) Handles ImportFileToolStripButton.Click
        If dlgOpen.ShowDialog = Windows.Forms.DialogResult.OK Then
            ImportFile(dlgOpen.FileName, CurrentDocument.CustomSymbols)
            RefreshFile()
        End If
    End Sub

    Private Sub ExportLocalToolStripButton_Click(sender As Object, e As EventArgs) Handles ExportLocalToolStripButton.Click
        If dlgSave.ShowDialog = Windows.Forms.DialogResult.OK Then
            File.WriteAllText(dlgSave.FileName, My.Settings.CustomSymbols)
        End If
    End Sub

    Private Sub ExportFileToolStripButton_Click(sender As Object, e As EventArgs) Handles ExportFileToolStripButton.Click
        If dlgSave.ShowDialog = Windows.Forms.DialogResult.OK Then
            File.WriteAllText(dlgSave.FileName, CurrentDocument.CustomSymbols)
        End If
    End Sub
End Class
