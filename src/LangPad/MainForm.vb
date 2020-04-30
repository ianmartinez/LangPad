Imports System.Drawing.Drawing2D
Imports System.IO
Imports LangPadSupport
Imports LangPadSupport.Themes

Public Class MainForm
    Public WithEvents CurrentRtb As New ExtendedRichTextBox()
    Private ReadOnly ColorPicker As New ColorDialog
    Private CurrentFilePath As String
    Private LastPrintedCharPos As Integer
    Public Title As String
    Public DisableFontChange As Boolean
    Public IsLoading As Boolean = False
    Public LastFocused As TextBoxBase
    Public Color1 As Color
    Public Color2 As Color
    Public VerticalMenuGradient As Boolean = False

    Private Sub MainForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Text = GetAppDisplayName()
        Title = Text
        MainContextMenu.ImageScalingSize = New Size(16, 16)

        ' Load the file that the program was sent, if any
        If My.Application.CommandLineArgs.Count > 0 Then
            If File.Exists(My.Application.CommandLineArgs(0)) Then
                Dim FileName As String = My.Application.CommandLineArgs(0)
                Dim FileExt As String = Path.GetExtension(FileName).ToLower()

                If FileExt = ".rtf" OrElse FileExt = ".txt" Then
                    ImportPage(0, FileName)
                Else
                    Try
                        Dim AllowOpen As Boolean = True
                        Dim OpenFile As New NotebookFile()
                        OpenFile.Open(FileName)
                        If OpenFile.NTSpecificationVersion > NTVersion Then
                            If Not MessageBox.Show("The notebook file you are trying to open is from LangPad " + OpenFile.ProgramVersion.ToString() + ", which is newer than the version you are currently using. " +
                                " This can lead to unexpected results. Are you sure you want to continue?", "File from LangPad " + OpenFile.ProgramVersion.ToString(), MessageBoxButtons.YesNoCancel, MessageBoxIcon.Exclamation) = DialogResult.Yes Then
                                AllowOpen = False
                            End If
                        End If

                        If AllowOpen Then
                            CurrentNotebook = OpenFile
                            CurrentFilePath = FileName
                        End If
                    Catch ex As Exception
                        CurrentNotebook = New NotebookFile()
                        ShowNotSupportedFileError(FileName)
                    End Try
                End If
            End If
        End If

        ' If no file was loaded, create an empty notebook
        ' with an untitled page
        If CurrentNotebook.Pages.Count = 0 Then
            InsertPage(0, "Untitled")
        End If

        SetTitle()
        SplitLayoutPanel.Panel2Collapsed = False
        SelectedDocument_TextChanged(Me, e)
        KeyPreview = True

        'SplitLayoutPanel.Panel2MinSize = 275
        SplitLayoutPanel.SplitterDistance = (SplitLayoutPanel.Width - NotebookEditorPanel.MinimumSize.Width) - 50

        ' Add indent options
        For i As Integer = 0 To 100
            IndentToolStripComboBox.Items.Add(i)
        Next
        IndentToolStripComboBox.SelectedItem = 1

        ' Reset toolstrip location
        MainToolStrip.Location = New Point(0, 0)

        ' Set theme
        ApplicationTheme = New GlacierTheme()
        SetTheme(ApplicationTheme)
        ThemeCombo.SelectedItem = My.Settings.Theme

        ' Add handlers for the color panel buttons
        For Each ColorButton As Button In ColorLayoutPanel.Controls
            If TypeOf ColorButton Is StylizedColorButton Then
                ColorButton.ImageAlign = ContentAlignment.MiddleCenter
                AddHandler ColorButton.Click, AddressOf ColorButton_Click
            End If
        Next

        ' Show character editor to the right of this form
        If My.Settings.ShowCharacterEditorOnStartup Then
            CharEditWindow.Show()
        End If
        CharEditWindow.TargetForm = Me
        Dim ScreenWidth As Integer = My.Computer.Screen.Bounds.Width
        Dim ScreenX As Integer = ScreenWidth - 20 - CharEditWindow.Width
        Dim CharToolX = Math.Min(ScreenX, Location.X + Width + 20)
        CharEditWindow.Location = New Point(CharToolX, Location.Y)
        CharEditWindow.Height = Height

        ColorPicker.FullOpen = True
        SetIcons()

        ' Set shortcut key display text
        ZoomInToolStripMenuItem.ShortcutKeyDisplayString = "Ctrl++"
        ZoomOutToolStripMenuItem.ShortcutKeyDisplayString = "Ctrl+-"

        ' The file hasn't been modified yet
        CurrentNotebook.Modified = False
    End Sub

    Public Sub SetIcons()
        Dim Res As IconResolution = GetIconResolution()
        NotebookEditorPanel.SetIcons()

        ' Toolstrip
        NewToolStripButton.Image = IconManager.Get("document-new", IconSize.Large, Res)
        OpenToolStripButton.Image = IconManager.Get("document-open", IconSize.Large, Res)
        SaveToolStripButton.Image = IconManager.Get("document-save", IconSize.Large, Res)

        CutToolStripButton.Image = IconManager.Get("edit-cut", IconSize.Large, Res)
        CopyToolStripButton.Image = IconManager.Get("edit-copy", IconSize.Large, Res)
        PasteToolStripButton.Image = IconManager.Get("edit-paste", IconSize.Large, Res)
        PastePlainToolStripButton.Image = IconManager.Get("filetype-text", IconSize.Large, Res)

        UndoToolStripButton.Image = IconManager.Get("edit-undo", IconSize.Large, Res)
        RedoToolStripButton.Image = IconManager.Get("edit-redo", IconSize.Large, Res)

        CharacterEditorToolStripButton.Image = IconManager.Get("language", IconSize.Large, Res)
        DictionaryToolStripButton.Image = IconManager.Get("dictionary", IconSize.Large, Res)

        FontToolStripButton.Image = IconManager.Get("font", IconSize.Large, Res)

        BoldToolStripButton.Image = IconManager.Get("format-text-bold", IconSize.Large, Res)
        ItalicToolStripButton.Image = IconManager.Get("format-text-italic", IconSize.Large, Res)
        UnderlineToolStripButton.Image = IconManager.Get("format-text-underline", IconSize.Large, Res)
        StrikeToolStripButton.Image = IconManager.Get("format-text-strikethrough", IconSize.Large, Res)

        AlignLeftToolStripButton.Image = IconManager.Get("format-justify-left", IconSize.Large, Res)
        AlignCenterToolStripButton.Image = IconManager.Get("format-justify-center", IconSize.Large, Res)
        AlignRightToolStripButton.Image = IconManager.Get("format-justify-right", IconSize.Large, Res)

        IndentToolStripButton.Image = IconManager.Get("format-indent-more", IconSize.Large, Res)

        ' File Menu
        NewToolStripMenuItem.Image = IconManager.Get("document-new", IconSize.Small, Res)
        NewWindowToolStripMenuItem.Image = IconManager.Get("windows", IconSize.Small, Res)
        OpenToolStripMenuItem.Image = IconManager.Get("document-open", IconSize.Small, Res)
        SaveToolStripMenuItem.Image = IconManager.Get("document-save", IconSize.Small, Res)
        SaveAsToolStripMenuItem.Image = IconManager.Get("document-save-as", IconSize.Small, Res)
        PrintToolStripMenuItem.Image = IconManager.Get("document-print", IconSize.Small, Res)
        PrintPreviewToolStripMenuItem.Image = IconManager.Get("document-print-preview", IconSize.Small, Res)
        PageSetupToolStripMenuItem.Image = IconManager.Get("document-page-setup", IconSize.Small, Res)
        RTFEditorToolStripMenuItem.Image = IconManager.Get("text-edit", IconSize.Small, Res)
        QuitToolStripMenuItem.Image = IconManager.Get("window-close", IconSize.Small, Res)

        ' Edit Menu
        UndoToolStripMenuItem.Image = IconManager.Get("edit-undo", IconSize.Small, Res)
        RedoToolStripMenuItem.Image = IconManager.Get("edit-redo", IconSize.Small, Res)
        CutToolStripMenuItem.Image = IconManager.Get("edit-cut", IconSize.Small, Res)
        CopyToolStripMenuItem.Image = IconManager.Get("edit-copy", IconSize.Small, Res)
        PasteToolStripMenuItem.Image = IconManager.Get("edit-paste", IconSize.Small, Res)
        PastePlainToolStripMenuItem.Image = IconManager.Get("filetype-text", IconSize.Small, Res)
        FindToolStripMenuItem.Image = IconManager.Get("edit-find-replace", IconSize.Small, Res)
        SelectAllToolStripMenuItem.Image = IconManager.Get("edit-select-all", IconSize.Small, Res)

        ' View Menu
        ZoomInToolStripMenuItem.Image = IconManager.Get("zoom-in", IconSize.Small, Res)
        ZoomOutToolStripMenuItem.Image = IconManager.Get("zoom-out", IconSize.Small, Res)
        ZoomToolStripMenuItem.Image = IconManager.Get("zoom-original", IconSize.Small, Res)
        EditZoomToolStripMenuItem.Image = IconManager.Get("zoom", IconSize.Small, Res)

        ' Notebook Menu
        AddPageToolStripMenuItem.Image = IconManager.Get("list-add", IconSize.Small, Res)
        RemovePageToolStripMenuItem.Image = IconManager.Get("list-remove", IconSize.Small, Res)
        DuplicatePageToolStripMenuItem.Image = IconManager.Get("edit-copy", IconSize.Small, Res)
        ImportPageToolStripMenuItem.Image = IconManager.Get("document-import", IconSize.Small, Res)
        ExportPageToolStripMenuItem.Image = IconManager.Get("document-export", IconSize.Small, Res)
        RenamePageToolStripMenuItem.Image = IconManager.Get("edit", IconSize.Small, Res)
        PreviousPageToolStripMenuItem.Image = IconManager.Get("go-previous", IconSize.Small, Res)
        NextPageToolStripMenuItem.Image = IconManager.Get("go-next", IconSize.Small, Res)
        DictionaryMenuItem.Image = IconManager.Get("dictionary", IconSize.Small, Res)

        ' Linguistics
        CharacterEditorToolStripMenuItem.Image = IconManager.Get("language", IconSize.Small, Res)

        ' Insert Menu
        ImageToolStripMenuItem.Image = IconManager.Get("filetype-image", IconSize.Small, Res)

        ' Style Menu
        ColorPanelToolStripMenuItem.Image = IconManager.Get("color-picker", IconSize.Small, Res)
        TextColorToolStripMenuItem.Image = IconManager.Get("fill-color", IconSize.Small, Res)
        HighlightToolStripMenuItem.Image = IconManager.Get("format-text-highlight", IconSize.Small, Res)
        EditStyleToolStripMenuItem.Image = IconManager.Get("template", IconSize.Small, Res)

        ' Text Menu
        FontToolStripMenuItem.Image = IconManager.Get("font", IconSize.Small, Res)
        BoldToolStripMenuItem.Image = IconManager.Get("format-text-bold", IconSize.Small, Res)
        ItalicToolStripMenuItem.Image = IconManager.Get("format-text-italic", IconSize.Small, Res)
        UnderlineToolStripMenuItem.Image = IconManager.Get("format-text-underline", IconSize.Small, Res)
        StrikeToolStripMenuItem.Image = IconManager.Get("format-text-strikethrough", IconSize.Small, Res)
        AlignLeftToolStripMenuItem.Image = IconManager.Get("format-justify-left", IconSize.Small, Res)
        AlignCenterToolStripMenuItem.Image = IconManager.Get("format-justify-center", IconSize.Small, Res)
        AlignRightToolStripMenuItem.Image = IconManager.Get("format-justify-right", IconSize.Small, Res)
        IncreaseIndentToolStripMenuItem.Image = IconManager.Get("format-indent-more", IconSize.Small, Res)
        DecreaseIndentToolStripMenuItem.Image = IconManager.Get("format-indent-less", IconSize.Small, Res)

        ' Tools Menu
        UpdateToolStripMenuItem.Image = IconManager.Get("update", IconSize.Small, Res)
        SettingsToolStripMenuItem.Image = IconManager.Get("config", IconSize.Small, Res)

        ' Help Menu
        PatreonToolStripMenuItem.Image = IconManager.Get("patreon", IconSize.Small, Res)
        AboutToolStripMenuItem.Image = IconManager.Get("help", IconSize.Small, Res)

        ' Context Menu
        CopyContextMenuItem.Image = IconManager.Get("edit-copy", IconSize.Small, Res)
        PasteContextMenuItem.Image = IconManager.Get("edit-paste", IconSize.Small, Res)
        PastePlainContextMenuItem.Image = IconManager.Get("filetype-text", IconSize.Small, Res)
        CutContextMenuItem.Image = IconManager.Get("edit-cut", IconSize.Small, Res)
        SelectAllContextMenuItem.Image = IconManager.Get("edit-select-all", IconSize.Small, Res)
    End Sub

    Public Sub SetTheme(Theme As Theme)
        Color1 = Theme.Color1
        Color2 = Theme.Color2
        VerticalMenuGradient = Theme.VerticalMenuGradient

        MainMenu.Renderer = Theme.GetMenuRenderer()
        MainToolStrip.Renderer = Theme.GetToolStripRenderer()
        DataToolStrip.Renderer = Theme.GetToolStripRenderer()
        MainContextMenu.Renderer = Theme.GetMenuRenderer()
        RtfEditorForm.SetTheme(Theme)
        DictionaryForm.SetTheme(Theme)
        BackColor = Theme.PanelBack
        ColorPanel.ForeColor = Theme.PanelText
        FindReplaceDialog.BackColor = Theme.PanelBack
        FindReplaceDialog.ForeColor = Theme.PanelText

        ' Center buttons relative to text boxes
        ' Because Windows' scaling throws them off
        FindButton.Top = FindTextBox.Top - (FindButton.Height / 2 - FindTextBox.Height / 2)
        FindNextButton.Top = FindTextBox.Top - (FindNextButton.Height / 2 - FindTextBox.Height / 2)
        ReplaceButton.Top = FindTextBox.Top - (ReplaceButton.Height / 2 - FindTextBox.Height / 2)
        ReplaceAllButton.Top = FindTextBox.Top - (ReplaceAllButton.Height / 2 - FindTextBox.Height / 2)

        NotebookEditorPanel.SetTheme(Theme)
        CharEditWindow.CharEdit.SetTheme(Theme)
        AboutDialog.BackColor = Theme.DialogBack
        PageNameDialog.BackColor = Theme.DialogBack
        CustomZoomDialog.BackColor = Theme.DialogBack
        ExportHtmlDialog.BackColor = Theme.DialogBack
        SettingsDialog.BackColor = Theme.DialogBack
        StyleDialog.BackColor = Theme.DialogBack

        Refresh()
    End Sub

    Private Sub MainToolStripContainer_ToolStripPanel_Paint(ByVal sender As Object, ByVal e As PaintEventArgs) Handles MainToolStripContainer.TopToolStripPanel.Paint,
        MainToolStripContainer.BottomToolStripPanel.Paint, MainToolStripContainer.LeftToolStripPanel.Paint, MainToolStripContainer.RightToolStripPanel.Paint
        Dim g As Graphics = e.Graphics
        Dim rect As New Rectangle(0, 0, MainToolStripContainer.Width, Height)
        Dim b As New LinearGradientBrush(rect, BackColor, BackColor, If(VerticalMenuGradient, LinearGradientMode.Vertical, LinearGradientMode.Horizontal))
        g.FillRectangle(b, rect)
    End Sub

    Private Sub MainToolStripContainer_ToolStripPanel_SizeChanged(ByVal sender As Object, ByVal e As EventArgs) Handles MainToolStripContainer.TopToolStripPanel.SizeChanged,
        MainToolStripContainer.BottomToolStripPanel.SizeChanged, MainToolStripContainer.LeftToolStripPanel.SizeChanged, MainToolStripContainer.RightToolStripPanel.SizeChanged
        MainToolStripContainer.Invalidate()
    End Sub

    Public Sub SetTitle()
        If CurrentFilePath = "" Then
            Text = Title
        Else
            Dim FileName As String = CurrentFilePath.Split("\").GetValue(CurrentFilePath.Split("\").Count - 1)
            Text = Title & " - " & FileName
        End If
    End Sub

    Public Sub ShowNotSupportedFileError(FileName As String)
        MessageBox.Show("Cannot open '" + FileName + "'. It is not supported by LangPad.", "Invalid File", MessageBoxButtons.OK, MessageBoxIcon.Error)
    End Sub

    Public Function ModifiedWarning() As DialogResult
        Return MessageBox.Show("Would you like to save the current document?", "Unsaved Document", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning)
    End Function

    Private Sub PrintDocument1_BeginPrint(ByVal sender As Object, ByVal e As Printing.PrintEventArgs) Handles PagePrintDocument.BeginPrint
        LastPrintedCharPos = 0
    End Sub

    Private Sub PagePrintDocument_PrintPage(ByVal sender As Object, ByVal e As Printing.PrintPageEventArgs) Handles PagePrintDocument.PrintPage
        LastPrintedCharPos = CurrentRtb.Print(LastPrintedCharPos, CurrentRtb.TextLength, e)

        If LastPrintedCharPos < CurrentRtb.TextLength Then
            e.HasMorePages = True
        Else
            e.HasMorePages = False
        End If
    End Sub

    Private Sub SelectedDocument_LinkClicked(sender As Object, e As LinkClickedEventArgs) Handles CurrentRtb.LinkClicked
        Dim Link As String = e.LinkText
        If Not (Link.StartsWith("http://") Or Link.StartsWith("https://")) Then Link = "https://" & Link
        Process.Start(Link)
    End Sub

    Public Sub SelectedDocument_TextChanged(sender As Object, e As EventArgs) Handles CurrentRtb.TextChanged
        UpdateWordCount()
        RtfEditorForm.RtfCodeTextBox.Text = CurrentRtb.Rtf
    End Sub

    Private Sub MainForm_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        Dim HasSaved As Boolean = False

        If CurrentNotebook.Modified Then
            Dim Mode = ModifiedWarning()

            If Mode = DialogResult.Yes Then
                HasSaved = FileSave()
            ElseIf Mode = Windows.Forms.DialogResult.Cancel Then
                e.Cancel = True
            End If

            If Mode = DialogResult.Yes AndAlso HasSaved = False Then
                e.Cancel = True
            End If
        End If

        CharEditWindow.Close()
        If DictionaryForm IsNot Nothing Then DictionaryForm.Close()
        My.Settings.Theme = ThemeCombo.SelectedItem
        My.Settings.Save()
    End Sub

    Private Sub ApplyStyle(ByVal Rtb As ExtendedRichTextBox, ByVal FontStyle As FontStyle)
        If Rtb.SelectionLength = 0 Then
            Rtb.SelectionFont = New Font(Rtb.SelectionFont, Rtb.SelectionFont.Style Xor FontStyle)
            Exit Sub
        End If

        SuspendLayout()
        Dim TempRTF As New ExtendedRichTextBox With {
            .Rtf = Rtb.SelectedRtf
        }
        TempRTF.SelectAll()

        If TempRTF.SelectionLength > 0 Then
            Dim Start As Integer = TempRTF.SelectionStart
            Dim Ending As Integer = TempRTF.SelectionLength + Start - 1

            For i = Start To Ending
                TempRTF.SelectionStart = i
                TempRTF.SelectionLength = 1
                TempRTF.SelectionFont = New Font(TempRTF.SelectionFont, TempRTF.SelectionFont.Style Xor FontStyle)
            Next

            TempRTF.SelectionStart = Start
            TempRTF.SelectionLength = Ending - Start + 1
        Else
            TempRTF.SelectionFont = New Font(TempRTF.SelectionFont, TempRTF.SelectionFont.Style Xor FontStyle)
        End If

        ' Store old selection
        Dim OldStart = Rtb.SelectionStart
        Dim OldLength = Rtb.SelectionLength
        Dim OldClip As Object = Clipboard.GetDataObject()
        TempRTF.SelectAll()
        TempRTF.Copy()
        Rtb.Paste()
        ' Restore old selection
        Rtb.Select(OldStart, OldLength)
        Clipboard.SetDataObject(OldClip)
        TempRTF.Dispose()
        ResumeLayout()
    End Sub

    Private Sub FindButton_Click(sender As Object, e As EventArgs) Handles FindButton.Click
        Dim SearchType As CompareMethod = CompareMethod.Text
        Dim StartPosition As Integer = InStr(1, CurrentRtb.Text, FindTextBox.Text, SearchType)

        If StartPosition = 0 Then
            MessageBox.Show("String: '" & FindTextBox.Text.ToString() & "' not found", "No Matches", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
            Exit Sub
        End If

        CurrentRtb.Select(StartPosition - 1, FindTextBox.Text.Length)
        CurrentRtb.ScrollToCaret()

    End Sub

    Private Sub FindNextButton_Click(sender As Object, e As EventArgs) Handles FindNextButton.Click
        Dim SearchType As CompareMethod = CompareMethod.Text
        Dim StartPosition As Integer = InStr(StartPosition, CurrentRtb.Text, FindTextBox.Text, SearchType)

        If StartPosition = 0 Then
            MessageBox.Show("String: '" & FindTextBox.Text.ToString() & "' not found", "No Matches", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
            Exit Sub
        End If

        CurrentRtb.Select(StartPosition - 1, FindTextBox.Text.Length)
        CurrentRtb.ScrollToCaret()
    End Sub

    Private Sub ReplaceButton_Click(sender As Object, e As EventArgs) Handles ReplaceButton.Click
        If CurrentRtb.SelectedText.Length <> 0 Then
            CurrentRtb.SelectedText = ReplaceTextBox.Text
        End If

        Dim SearchType As CompareMethod = CompareMethod.Text
        Dim StartPosition As Integer = InStr(StartPosition, CurrentRtb.Text, FindTextBox.Text, SearchType)

        If StartPosition = 0 Then
            MessageBox.Show("String: '" & FindTextBox.Text.ToString() & "' not found", "No Matches", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
            Exit Sub
        End If

        CurrentRtb.Select(StartPosition - 1, FindTextBox.Text.Length)
        CurrentRtb.ScrollToCaret()

    End Sub

    Private Sub ReplaceAllButton_Click(sender As Object, e As EventArgs) Handles ReplaceAllButton.Click
        Dim CurrentStart As Integer = CurrentRtb.SelectionStart
        Dim CurrentLength As Integer = CurrentRtb.SelectionLength

        CurrentRtb.Rtf = Replace(CurrentRtb.Rtf, Trim(FindTextBox.Text), Trim(ReplaceTextBox.Text))
        CurrentRtb.SelectionStart = CurrentStart
        CurrentRtb.SelectionLength = CurrentLength
    End Sub

    Private Sub CopyContextMenuItem_Click(sender As Object, e As EventArgs) Handles CopyContextMenuItem.Click
        CopyToolStripMenuItem_Click(Me, e)
    End Sub

    Private Sub PasteContextMenuItem_Click(sender As Object, e As EventArgs) Handles PasteContextMenuItem.Click
        PasteToolStripMenuItem_Click(Me, e)
    End Sub

    Private Sub CutContextMenuItem_Click(sender As Object, e As EventArgs) Handles CutContextMenuItem.Click
        CutToolStripMenuItem_Click(Me, e)
    End Sub

    Private Sub SelectAllContextMenuItem_Click(sender As Object, e As EventArgs) Handles SelectAllContextMenuItem.Click
        SelectAllToolStripMenuItem_Click(Me, e)
    End Sub

    Private Sub DeselectAllContextMenuItem_Click(sender As Object, e As EventArgs) Handles DeselectAllContextMenuItem.Click
        CurrentRtb.DeselectAll()
    End Sub

    Private Sub NewToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NewToolStripMenuItem.Click
        Dim HasSaved As Boolean = False

        If CurrentNotebook.Modified Then
            Dim Mode = ModifiedWarning()

            If Mode = DialogResult.Yes Then
                HasSaved = FileSave()
            ElseIf Mode = Windows.Forms.DialogResult.Cancel Then
                Exit Sub
            End If

            If Mode = DialogResult.Yes AndAlso HasSaved = False Then
                Exit Sub
            End If
        End If

        Dim NewNotebook = New NotebookFile With {
            .Pages = New List(Of NotebookPage)
        }

        RtbList.Clear()
        NotebookEditorPanel.PagesListBox.Items.Clear()

        Dim NewPage As NotebookPage = New NotebookPage With {
            .Title = "Untitled",
            .RTF = ""
        }

        NewNotebook.Pages.Add(NewPage)
        NewNotebook.WordDictionary = New DictionaryFile()
        CharEditWindow.CharEdit.FilePanel.Controls.Clear() ' Reset character editor file tab

        CurrentFilePath = ""
        CurrentNotebook = NewNotebook
        SetTitle()
    End Sub

    Private Sub OpenToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OpenToolStripMenuItem.Click
        Dim HasSaved As Boolean = False

        If CurrentNotebook.Modified Then
            Dim Mode = ModifiedWarning()

            If Mode = DialogResult.Yes Then
                HasSaved = FileSave()
            ElseIf Mode = Windows.Forms.DialogResult.Cancel Then
                Exit Sub
            End If

            If Mode = DialogResult.Yes AndAlso HasSaved = False Then
                Exit Sub
            End If
        End If

        If OpenDialog.ShowDialog = Windows.Forms.DialogResult.OK Then
            If Not File.Exists(OpenDialog.FileName) Then
                MessageBox.Show("Please select a valid file")
                Exit Sub
            End If

            Try
                Dim OpenFile As New NotebookFile()
                OpenFile.Open(OpenDialog.FileName)

                If OpenFile.NTSpecificationVersion > NTVersion Then
                    If Not MessageBox.Show("The notebook file you are trying to open is from LangPad " + OpenFile.ProgramVersion.ToString() + ", which is newer than the version you are currently using. " +
                " This can lead to unexpected results. Are you sure you want to continue?", "File from LangPad " + OpenFile.ProgramVersion.ToString(), MessageBoxButtons.YesNoCancel, MessageBoxIcon.Exclamation) = DialogResult.Yes Then
                        Exit Sub
                    End If
                End If

                CurrentNotebook = OpenFile
                CurrentFilePath = OpenDialog.FileName

                SetTitle()
                UpdateWordCount()
                IsLoading = False
            Catch ex As Exception
                CurrentNotebook = New NotebookFile()
                ShowNotSupportedFileError(OpenDialog.FileName)
            End Try
        End If

    End Sub

    Public Function FileSaveAs() As Boolean
        Dim SavedFile As Boolean = False

        If SaveDialog.ShowDialog = Windows.Forms.DialogResult.OK Then
            Cursor = Cursors.WaitCursor
            If SaveDialog.FileName = "" Then Return False

            If SaveDialog.FileName.EndsWith(".thw") Then
                MessageBox.Show("This file is being exported to the new Thorn Writer format. This is not compatible with LangPad.")

                Dim ThornNotebook = New ThornWriter.NotebookFile.Notebook With {
                    .Title = CurrentNotebook.Title,
                    .Language = CurrentNotebook.Language,
                    .Author = CurrentNotebook.Author,
                    .Website = CurrentNotebook.Website,
                    .Info = CurrentNotebook.Info,
                    .Stylesheet = "",
                    .Characters = ThornWriter.NotebookFile.KeyValue.ToLines(CurrentNotebook.CustomSymbols).ToList()
                }

                For Each Page In CurrentNotebook.Pages
                    Dim ThornPage As New ThornWriter.NotebookFile.Page With {
                        .Title = Page.Title,
                        .Content = RtfPipe.Rtf.ToHtml(Page.RTF).ToString()
                    }

                    ThornNotebook.Pages.Add(ThornPage)
                Next

                For Each Word In CurrentNotebook.WordDictionary.Words
                    Dim ThornWord As New ThornWriter.NotebookFile.DictionaryWord With {
                        .Definition = Word.Definition,
                        .Notes = Word.Notes,
                        .Pronunciation = Word.Pronunciation,
                        .Word = Word.Word
                    }

                    ThornNotebook.NotebookDictionary.Words.Add(ThornWord)
                Next

                ThornNotebook.Save(SaveDialog.FileName)
            Else
                CurrentNotebook.Save(SaveDialog.FileName)
                CurrentFilePath = SaveDialog.FileName
                CurrentNotebook.Modified = False
                SetTitle()
            End If

            SavedFile = True
            Cursor = Cursors.Default
        End If

        Return SavedFile
    End Function

    Public Function FileSave() As Boolean
        If CurrentFilePath = "" Then
            Return FileSaveAs()
        Else
            Cursor = Cursors.WaitCursor
            Dim Ext As String = Path.GetExtension(CurrentFilePath).ToUpper()

            If Ext = "RTF" Then
                CurrentRtb.SaveFile(CurrentFilePath)
            ElseIf Ext = "TXT" Then
                Dim Writer As StreamWriter
                Writer = New StreamWriter(CurrentFilePath)
                Writer.Write(CurrentRtb.Text)
                Writer.Close()
                CurrentRtb.SelectionStart = 0
                CurrentRtb.SelectionLength = 0
            Else
                CurrentNotebook.Save(CurrentFilePath)
                CurrentNotebook.Modified = False
                SetTitle()
            End If
        End If

        Cursor = Cursors.Default
        Return True
    End Function

    Private Sub SaveToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SaveToolStripMenuItem.Click
        FileSave()
    End Sub

    Private Sub SaveAsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SaveAsToolStripMenuItem.Click
        FileSaveAs()
    End Sub

    Private Sub PrintToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PrintToolStripMenuItem.Click
        PrintDocumentDialog.Document = PagePrintDocument

        If PrintDocumentDialog.ShowDialog() = Windows.Forms.DialogResult.OK Then
            PagePrintDocument.Print()
        End If
    End Sub

    Private Sub PrintPreviewToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PrintPreviewToolStripMenuItem.Click
        PrintDocumentDialogPreview.Document = PagePrintDocument
        PrintDocumentDialogPreview.ShowDialog()
    End Sub

    Private Sub PageSetupToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PageSetupToolStripMenuItem.Click
        PrintPageSetupDialog.Document = PagePrintDocument
        PrintPageSetupDialog.ShowDialog()
    End Sub

    Private Sub RTFEditorToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RTFEditorToolStripMenuItem.Click
        RtfEditorForm.Show()
    End Sub

    Private Sub UndoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles UndoToolStripMenuItem.Click
        If CurrentRtb.CanUndo Then
            Dim OldStart = Math.Max(0, CurrentRtb.SelectionStart)
            CurrentRtb.Undo()
            CurrentRtb.SelectionStart = Math.Max(0, Math.Min(OldStart, CurrentRtb.TextLength - 1))
            CurrentRtb.SelectionLength = 0
        End If
    End Sub

    Private Sub RedoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RedoToolStripMenuItem.Click
        If CurrentRtb.CanRedo Then
            Dim OldStart = Math.Max(0, CurrentRtb.SelectionStart)
            CurrentRtb.Redo()
            CurrentRtb.SelectionStart = Math.Max(0, Math.Min(OldStart, CurrentRtb.TextLength - 1))
            CurrentRtb.SelectionLength = 0
        End If
    End Sub

    Private Sub CutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CutToolStripMenuItem.Click
        CurrentRtb.Cut()
    End Sub

    Private Sub CopyToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CopyToolStripMenuItem.Click
        CurrentRtb.Copy()
    End Sub

    Public Sub InsertImage(img As Image)
        ImportImageDialog.SelectedImage = img

        If ImportImageDialog.ShowDialog() = DialogResult.OK Then
            CurrentRtb.InsertImage(ImportImageDialog.SelectedImage)
        End If
    End Sub

    Private Sub PasteToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PasteToolStripMenuItem.Click
        If Clipboard.ContainsImage Then
            InsertImage(Clipboard.GetImage())
        ElseIf Clipboard.ContainsFileDropList() Then
            Dim DataObject As IDataObject = Clipboard.GetDataObject()

            If DataObject.GetDataPresent(DataFormats.FileDrop) Then
                Dim ClipboardFiles As String() = DataObject.GetData(DataFormats.FileDrop)

                Try
                    Dim ClipboardImage As Image = Image.FromFile(ClipboardFiles(0))
                    InsertImage(ClipboardImage)
                Catch ex As Exception ' Not a valid image
                End Try
            End If
        Else
            CurrentRtb.Paste()
        End If
    End Sub

    Private Sub PastePlainToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PastePlainToolStripMenuItem.Click
        CurrentRtb.Paste(DataFormats.GetFormat(DataFormats.UnicodeText))
    End Sub

    Private Sub FindToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FindToolStripMenuItem.Click
        FindReplaceDialog.Visible = FindReplaceDialog.Visible Xor True
        If FindReplaceDialog.Visible = True Then FindTextBox.Focus()
    End Sub

    Private Sub SelectAllToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SelectAllToolStripMenuItem.Click
        CurrentRtb.SelectAll()
    End Sub

    Private Sub ZoomInToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ZoomInToolStripMenuItem.Click
        Dim NewZoom = CurrentRtb.ZoomFactor + 0.2

        If NewZoom >= 64 Then
            CurrentRtb.ZoomFactor = 63
        Else
            CurrentRtb.ZoomFactor = NewZoom
        End If
    End Sub

    Private Sub ZoomOutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ZoomOutToolStripMenuItem.Click
        Dim NewZoom = CurrentRtb.ZoomFactor - 0.2

        If NewZoom <= 0.015625 Then
            CurrentRtb.ZoomFactor = 0.015626
        Else
            CurrentRtb.ZoomFactor = NewZoom
        End If
    End Sub

    Private Sub ZoomToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ZoomToolStripMenuItem.Click
        CurrentRtb.ZoomFactor = 1.0F
    End Sub

    Private Sub EditZoomToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EditZoomToolStripMenuItem.Click
        CustomZoomDialog.ShowDialog()
    End Sub

    Private Sub WordWrapToolStripMenuItem_CheckedChanged(sender As Object, e As EventArgs) Handles WordWrapToolStripMenuItem.CheckedChanged
        CurrentRtb.WordWrap = WordWrapToolStripMenuItem.Checked
    End Sub

    Private Sub ImageToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ImageToolStripMenuItem.Click
        If OpenImageDialog.ShowDialog() = DialogResult.OK Then
            Dim Img As Image = Image.FromFile(OpenImageDialog.FileName)
            InsertImage(Img)
        End If
    End Sub

    Private Sub InsertBulletsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles InsertBulletsToolStripMenuItem.Click
        CurrentRtb.SelectionBullet = True
    End Sub

    Private Sub RemoveBulletsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RemoveBulletsToolStripMenuItem.Click
        CurrentRtb.SelectionBullet = False
    End Sub

    Private Sub DefaultStyleToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DefaultStyleToolStripMenuItem.Click
        If CurrentRtb.SelectionLength = 0 Then Exit Sub

        SuspendLayout()

        Dim TempRTF As New ExtendedRichTextBox With {
            .Rtf = CurrentRtb.Rtf,
            .SelectionStart = CurrentRtb.SelectionStart,
            .SelectionLength = CurrentRtb.SelectionLength,
            .SelectionFont = New Font("Calibri", 11),
            .SelectionColor = Color.Black,
            .SelectionBackColor = Color.White,
            .SelectionAlignment = HorizontalAlignment.Left,
            .SelectionIndent = 0,
            .SelectionHangingIndent = 0,
            .BulletIndent = 0,
            .SelectionCharOffset = 0
        }

        Dim CurrentPos As Integer = CurrentRtb.SelectionStart
        Dim CurrentLength As Integer = CurrentRtb.SelectionLength
        Dim OldClip As Object = Clipboard.GetDataObject()

        CurrentRtb.SelectAll()
        TempRTF.SelectAll()
        TempRTF.Copy()
        CurrentRtb.Paste()
        Clipboard.SetDataObject(OldClip)

        CurrentRtb.SelectionStart = CurrentPos
        CurrentRtb.SelectionLength = CurrentLength

        TempRTF.Dispose()
        ResumeLayout()

        CurrentRtb.SelectionAlignment = HorizontalAlignment.Left
    End Sub

    Private Sub EditStyleToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EditStyleToolStripMenuItem.Click
        StyleDialog.ShowDialog()
    End Sub

    Private Sub ApplyStyleToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ApplyStyleToolStripMenuItem.Click
        If CurrentRtb.SelectionLength = 0 Then Exit Sub

        SuspendLayout()

        Dim TempRTF As New ExtendedRichTextBox With {
            .Rtf = CurrentRtb.Rtf,
            .SelectionStart = CurrentRtb.SelectionStart,
            .SelectionLength = CurrentRtb.SelectionLength,
            .SelectionFont = StyleDialog.StyleFont,
            .SelectionColor = StyleDialog.StyleColor,
            .SelectionBackColor = StyleDialog.StyleHighlight,
            .SelectionAlignment = StyleDialog.StyleAlignment,
            .SelectionIndent = StyleDialog.StyleIndent,
            .SelectionHangingIndent = StyleDialog.StyleHangingIndent,
            .BulletIndent = StyleDialog.StyleBulletIndent,
            .SelectionCharOffset = StyleDialog.StyleCharOffset
        }

        Dim CurrentPos As Integer = CurrentRtb.SelectionStart
        Dim CurrentLength As Integer = CurrentRtb.SelectionLength
        Dim OldClip As Object = Clipboard.GetDataObject

        CurrentRtb.SelectAll()
        TempRTF.SelectAll()
        TempRTF.Copy()
        CurrentRtb.Paste()
        Clipboard.SetDataObject(OldClip)

        CurrentRtb.SelectionStart = CurrentPos
        CurrentRtb.SelectionLength = CurrentLength

        TempRTF.Dispose()
        ResumeLayout()

        CurrentRtb.SelectionAlignment = StyleDialog.StyleAlignment
    End Sub

    Private Sub TextColorToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TextColorToolStripMenuItem.Click
        ColorPicker.Color = CurrentRtb.SelectionColor
        If ColorPicker.ShowDialog = DialogResult.OK Then
            CurrentRtb.SelectionColor = ColorPicker.Color
        End If
    End Sub

    Private Sub HighlightToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles HighlightToolStripMenuItem.Click
        ColorPicker.Color = CurrentRtb.SelectionBackColor

        If ColorPicker.ShowDialog = DialogResult.OK Then
            CurrentRtb.SelectionBackColor = ColorPicker.Color
        End If
    End Sub

    Public Sub AddPageToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AddPageToolStripMenuItem.Click
        SavePages()
        PageNameDialog.Mode = PageNameMode.Add
        PageNameDialog.ShowDialog()
    End Sub

    Public Sub RemovePageToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RemovePageToolStripMenuItem.Click
        If CurrentNotebook.Pages.Count = 0 Or CurrentPageIndex < 0 Then Exit Sub

        SavePages()
        Dim ConfirmDelete = MessageBox.Show("Are you sure you want to delete this page? This cannot be undone.", "", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning)
        If ConfirmDelete = DialogResult.Yes Then
            RemovePage(CurrentPageIndex)
        End If
    End Sub

    Public Sub DuplicatePageToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DuplicatePageToolStripMenuItem.Click
        If PageInRange(CurrentPageIndex) Then
            SavePages()
            DuplicatePage(CurrentPageIndex)
        End If
    End Sub

    Private Sub DuplicateAndNameToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DuplicateAndNameToolStripMenuItem.Click
        If PageInRange(CurrentPageIndex) Then
            SavePages()
            PageNameDialog.NameTextBox.Text = CurrentNotebook.Pages(CurrentPageIndex).Title
            PageNameDialog.Mode = PageNameMode.Duplicate
            PageNameDialog.ShowDialog()
        End If
    End Sub

    Public Sub ImportPageToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ImportPageToolStripMenuItem.Click
        If OpenPageDialog.ShowDialog() = Windows.Forms.DialogResult.OK Then
            SavePages()
            ImportPage(CurrentPageIndex, OpenPageDialog.FileName)
        End If
    End Sub

    Public Sub ExportPageToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExportPageToolStripMenuItem.Click
        If CurrentNotebook.Pages.Count = 0 OrElse Not PageInRange(CurrentPageIndex) Then Exit Sub
        Dim PageTitle = CurrentNotebook.Pages(CurrentPageIndex).Title
        Dim PageFileName = PageTitle
        For Each InvalidChar In Path.GetInvalidFileNameChars
            PageFileName = PageFileName.Replace(InvalidChar, "")
        Next

        SavePageDialog.FileName = PageFileName
        If SavePageDialog.ShowDialog = Windows.Forms.DialogResult.OK Then
            If SavePageDialog.FileName = "" Then Exit Sub

            Dim ExportExt = Path.GetExtension(SavePageDialog.FileName).ToUpper()
            Select Case ExportExt
                Case ".RTF"
                    Dim Writer = New StreamWriter(SavePageDialog.FileName)
                    Writer.Write(CurrentRtb.Rtf)
                    Writer.Close()
                    CurrentRtb.SelectionStart = 0
                    CurrentRtb.SelectionLength = 0
                Case ".HTML"
                    File.WriteAllText(SavePageDialog.FileName, RtfToHtml(CurrentRtb.Rtf, PageTitle))
                Case Else
                    Dim Writer = New StreamWriter(SavePageDialog.FileName)
                    Writer.Write(CurrentRtb.Text)
                    Writer.Close()
                    CurrentRtb.SelectionStart = 0
                    CurrentRtb.SelectionLength = 0
            End Select
        End If
    End Sub

    Public Sub RenamePageToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RenamePageToolStripMenuItem.Click
        SavePages()
        If PageInRange(CurrentPageIndex) Then
            PageNameDialog.Mode = PageNameMode.Rename
            PageNameDialog.NameTextBox.Text = CurrentNotebook.Pages.Item(CurrentPageIndex).Title
            PageNameDialog.CurrentPos = CurrentPageIndex
            PageNameDialog.ShowDialog()
        End If
    End Sub

    Private Sub UpdateToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles UpdateToolStripMenuItem.Click
        AutoUpdater.CheckForUpdates()
    End Sub

    Private Sub SettingsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SettingsToolStripMenuItem.Click
        SettingsDialog.ShowDialog()
    End Sub

    Private Sub AboutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AboutToolStripMenuItem.Click
        AboutDialog.ShowDialog()
    End Sub

    Private Sub NewToolStripButton_Click(sender As Object, e As EventArgs) Handles NewToolStripButton.Click
        NewToolStripMenuItem_Click(Me, e)
    End Sub

    Private Sub OpenToolStripButton_Click(sender As Object, e As EventArgs) Handles OpenToolStripButton.Click
        OpenToolStripMenuItem_Click(Me, e)
    End Sub

    Private Sub SaveToolStripButton_Click(sender As Object, e As EventArgs) Handles SaveToolStripButton.Click
        SaveToolStripMenuItem_Click(Me, e)
    End Sub

    Private Sub CutToolStripButton_Click(sender As Object, e As EventArgs) Handles CutToolStripButton.Click
        CutToolStripMenuItem_Click(Me, e)
    End Sub

    Private Sub CopyToolStripButton_Click(sender As Object, e As EventArgs) Handles CopyToolStripButton.Click
        CopyToolStripMenuItem_Click(Me, e)
    End Sub

    Private Sub PasteToolStripButton_Click(sender As Object, e As EventArgs) Handles PasteToolStripButton.Click
        PasteToolStripMenuItem_Click(Me, e)
    End Sub

    Private Sub PastePlainToolStripButton_Click(sender As Object, e As EventArgs) Handles PastePlainToolStripButton.Click
        PastePlainToolStripMenuItem_Click(Me, e)
    End Sub

    Private Sub UndoToolStripButton_Click(sender As Object, e As EventArgs) Handles UndoToolStripButton.Click
        UndoToolStripMenuItem_Click(Me, e)
    End Sub

    Private Sub RedoToolStripButton_Click(sender As Object, e As EventArgs) Handles RedoToolStripButton.Click
        RedoToolStripMenuItem_Click(Me, e)
    End Sub

    Private Sub FontToolStripButton_Click(sender As Object, e As EventArgs) Handles FontToolStripButton.Click
        FontToolStripMenuItem_Click(Me, e)
    End Sub

    Private Sub AlignLeftToolStripButton_Click(sender As Object, e As EventArgs) Handles AlignLeftToolStripButton.Click
        AlignLeftToolStripMenuItem_Click(Me, e)
    End Sub

    Private Sub AlignCenterToolStripButton_Click(sender As Object, e As EventArgs) Handles AlignCenterToolStripButton.Click
        AlignCenterToolStripMenuItem_Click(Me, e)
    End Sub

    Private Sub AlignRightToolStripButton_Click(sender As Object, e As EventArgs) Handles AlignRightToolStripButton.Click
        AlignRightToolStripButton_Click(Me, e)
    End Sub

    Private Sub IndentToolStripButton_Click(sender As Object, e As EventArgs) Handles IndentToolStripButton.Click
        CurrentRtb.SelectionIndent = IndentToolStripComboBox.SelectedItem
    End Sub

    Private Sub BoldToolStripButton_Click(sender As Object, e As EventArgs) Handles BoldToolStripButton.Click
        BoldToolStripMenuItem_Click(Me, e)
    End Sub

    Private Sub ItalicToolStripButton_Click(sender As Object, e As EventArgs) Handles ItalicToolStripButton.Click
        ItalicToolStripMenuItem_Click(Me, e)
    End Sub

    Private Sub UnderlineToolStripButton_Click(sender As Object, e As EventArgs) Handles UnderlineToolStripButton.Click
        UnderlineToolStripMenuItem_Click(Me, e)
    End Sub

    Private Sub StrikeToolStripButton_Click(sender As Object, e As EventArgs) Handles StrikeToolStripButton.Click
        StrikeToolStripMenuItem_Click(Me, e)
    End Sub

    Private Sub ThemeCombo_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ThemeCombo.SelectedIndexChanged
        If ThemeCombo.SelectedItem.ToString().Equals("Glacier") Then
            SetTheme(New GlacierTheme)
        Else
            SetTheme(New GlacierTheme)
        End If
    End Sub

    Private Sub ColorPanelToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ColorPanelToolStripMenuItem.Click
        ColorPanel.Visible = ColorPanel.Visible Xor True
    End Sub

    Private Sub ColorButton_Click(sender As Object, e As EventArgs)
        Dim ColorButton As StylizedColorButton = CType(sender, StylizedColorButton)

        If TextColorRadio.Checked Then ' Text Color
            CurrentRtb.SelectionColor = ColorButton.Color
        Else ' Highlight Color
            CurrentRtb.SelectionBackColor = ColorButton.Color
        End If
    End Sub

    Private Sub ToggleSidebarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ToggleSidebarToolStripMenuItem.Click
        SplitLayoutPanel.Panel2Collapsed = SplitLayoutPanel.Panel2Collapsed Xor True
    End Sub

    Private Sub ToggleToolbarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ToggleToolbarToolStripMenuItem.Click
        MainToolStrip.Visible = MainToolStrip.Visible Xor True
    End Sub

    Private Sub ToggleStatusbarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ToggleStatusbarToolStripMenuItem.Click
        DataToolStrip.Visible = DataToolStrip.Visible Xor True
    End Sub

    Private Sub FullModeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FullModeToolStripMenuItem.Click
        SplitLayoutPanel.Panel2Collapsed = False
        MainToolStripContainer.TopToolStripPanelVisible = True
        MainToolStripContainer.BottomToolStripPanelVisible = True
        MainToolStripContainer.LeftToolStripPanelVisible = True
        MainToolStripContainer.RightToolStripPanelVisible = True
    End Sub

    Private Sub MinimalModeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MinimalModeToolStripMenuItem.Click
        SplitLayoutPanel.Panel2Collapsed = True
        MainToolStripContainer.TopToolStripPanelVisible = False
        MainToolStripContainer.BottomToolStripPanelVisible = False
        MainToolStripContainer.LeftToolStripPanelVisible = False
        MainToolStripContainer.RightToolStripPanelVisible = False
    End Sub

    Private Sub TransparentColorButton_Click(sender As Object, e As EventArgs) Handles TransparentColorButton.Click
        If TextColorRadio.Checked Then
            CurrentRtb.SelectionColor = Color.Transparent
        Else
            CurrentRtb.SelectionBackColor = Color.Transparent
        End If
    End Sub

    Public Sub DictionaryMenuItem_Click(sender As Object, e As EventArgs) Handles DictionaryMenuItem.Click
        DictionaryForm.Show()
        DictionaryForm.Activate()
    End Sub

    Public Sub MainForm_Activated(sender As Object, e As EventArgs) Handles MyBase.Activated
        CharEditWindow.TargetForm = Me
        CharEditWindow.GetCurrentTexbox = Function()
                                              If LastFocused Is Nothing Then
                                                  LastFocused = CurrentRtb
                                              End If

                                              Return LastFocused
                                          End Function
    End Sub

    Private Sub CharacterEditorToolStripButton_Click(sender As Object, e As EventArgs) Handles CharacterEditorToolStripButton.Click
        CharacterEditorToolStripMenuItem_Click(Me, e)
    End Sub

    Private Sub CharacterEditorToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CharacterEditorToolStripMenuItem.Click
        CharEditWindow.Show()
    End Sub

    Private Sub QuitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles QuitToolStripMenuItem.Click
        Close()
    End Sub

    Private Sub DictionaryToolStripButton_Click(sender As Object, e As EventArgs) Handles DictionaryToolStripButton.Click
        DictionaryMenuItem_Click(Me, e)
    End Sub

    Private Sub PastePlainContextMenuItem_Click(sender As Object, e As EventArgs) Handles PastePlainContextMenuItem.Click
        PastePlainToolStripMenuItem_Click(Me, e)
    End Sub

    Private Sub SelectedDocument_GotFocus(sender As Object, e As EventArgs) Handles CurrentRtb.GotFocus
        LastFocused = CurrentRtb
    End Sub

    Private Sub NewWindowToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NewWindowToolStripMenuItem.Click
        Process.Start(New ProcessStartInfo(Application.ExecutablePath))
    End Sub

    Private Sub FontToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FontToolStripMenuItem.Click
        DisableFontChange = True

        Dim FontPicker As New FontDialog With {
            .AllowSimulations = True,
            .ShowColor = True,
            .ShowEffects = True,
            .Color = CurrentRtb.SelectionColor,
            .Font = CurrentRtb.SelectionFont
        }

        If FontPicker.ShowDialog() = Windows.Forms.DialogResult.OK Then
            CurrentRtb.SelectionColor = FontPicker.Color
            CurrentRtb.SelectionFont = FontPicker.Font
        End If

        DisableFontChange = False
    End Sub

    Private Sub SubscriptToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SubscriptToolStripMenuItem.Click
        CurrentRtb.SelectionCharOffset = -10
    End Sub

    Private Sub SuperscriptToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SuperscriptToolStripMenuItem.Click
        CurrentRtb.SelectionCharOffset = 10
    End Sub

    Private Sub BaselineToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BaselineToolStripMenuItem.Click
        CurrentRtb.SelectionCharOffset = 0
    End Sub

    Private Sub BoldToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BoldToolStripMenuItem.Click
        ApplyStyle(CurrentRtb, FontStyle.Bold)
    End Sub

    Private Sub ItalicToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ItalicToolStripMenuItem.Click
        ApplyStyle(CurrentRtb, FontStyle.Italic)
    End Sub

    Private Sub UnderlineToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles UnderlineToolStripMenuItem.Click
        ApplyStyle(CurrentRtb, FontStyle.Underline)
    End Sub

    Private Sub StrikeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles StrikeToolStripMenuItem.Click
        ApplyStyle(CurrentRtb, FontStyle.Strikeout)
    End Sub

    Private Sub AlignLeftToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AlignLeftToolStripMenuItem.Click
        CurrentRtb.SelectionAlignment = HorizontalAlignment.Left
    End Sub

    Private Sub AlignCenterToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AlignCenterToolStripMenuItem.Click
        CurrentRtb.SelectionAlignment = HorizontalAlignment.Center
    End Sub

    Private Sub AlignRightToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AlignRightToolStripMenuItem.Click
        CurrentRtb.SelectionAlignment = HorizontalAlignment.Right
    End Sub

    Private Sub PreviousPageToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PreviousPageToolStripMenuItem.Click
        If Not CurrentPageIndex = 0 Then CurrentPageIndex -= 1
    End Sub

    Private Sub NextPageToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NextPageToolStripMenuItem.Click
        If Not CurrentPageIndex = CurrentNotebook.Pages.Count - 1 Then CurrentPageIndex += 1
    End Sub

    Private Sub IncreaseIndentToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles IncreaseIndentToolStripMenuItem.Click
        Dim NewIndent = CurrentRtb.SelectionIndent + 30
        CurrentRtb.SelectionIndent = NewIndent
    End Sub

    Private Sub DecreaseIndentToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DecreaseIndentToolStripMenuItem.Click
        Dim NewIndent = CurrentRtb.SelectionIndent - 30
        CurrentRtb.SelectionIndent = NewIndent
    End Sub

    Private Sub SelectedDocument_KeyPress(sender As Object, e As KeyPressEventArgs) Handles CurrentRtb.KeyPress
        ' Suppress tab character insertion
        If e.KeyChar = Chr(9) Then ' Tab
            e.Handled = True
        End If
    End Sub

    Private Sub SelectedDocument_KeyUp(sender As Object, e As KeyEventArgs) Handles CurrentRtb.KeyUp
        If Not e.Control Then ' CTRL + TAB/ CTRL + SHIFT + TAB handle bullet indent
            If e.KeyCode = Keys.Tab AndAlso Not e.Modifiers = Keys.Shift Then
                IncreaseIndentToolStripMenuItem_Click(Me, e)
            ElseIf e.Modifiers = Keys.Shift AndAlso e.KeyCode = Keys.Tab Then
                DecreaseIndentToolStripMenuItem_Click(Me, e)
            End If
        End If
    End Sub

    Private Sub IncreaseBulletIndentToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles IncreaseBulletIndentToolStripMenuItem.Click
        Dim NewIndent = CurrentRtb.BulletIndent + 30
        CurrentRtb.BulletIndent = NewIndent
    End Sub

    Private Sub DecreaseBulletIndentToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DecreaseBulletIndentToolStripMenuItem.Click
        Dim NewIndent = CurrentRtb.BulletIndent - 30
        CurrentRtb.BulletIndent = NewIndent
    End Sub

    Private Sub IncreaseHangingIndentToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles IncreaseHangingIndentToolStripMenuItem.Click
        Dim NewIndent = CurrentRtb.SelectionHangingIndent + 30
        CurrentRtb.SelectionHangingIndent = NewIndent
    End Sub

    Private Sub DecreaseHangingIndentToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DecreaseHangingIndentToolStripMenuItem.Click
        Dim NewIndent = CurrentRtb.SelectionHangingIndent - 30
        CurrentRtb.SelectionHangingIndent = NewIndent
    End Sub

    Private Sub ResetIndentToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ResetIndentToolStripMenuItem.Click
        CurrentRtb.SelectionIndent = 0
    End Sub

    Private Sub ResetBulletIndentToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ResetBulletIndentToolStripMenuItem.Click
        CurrentRtb.BulletIndent = 0
    End Sub

    Private Sub ResetHangingIndentToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ResetHangingIndentToolStripMenuItem.Click
        CurrentRtb.SelectionHangingIndent = 0
    End Sub

    Private Sub InsertTabToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles InsertTabToolStripMenuItem.Click
        CharEditWindow.CharEdit.InsertText(CurrentRtb, vbTab)
    End Sub

    Private Sub BroadTranscriptionToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BroadTranscriptionToolStripMenuItem.Click
        CharEditWindow.CharEdit.InsertBracket(CurrentRtb, "/", "/")
    End Sub

    Private Sub NarrowTranscriptionToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NarrowTranscriptionToolStripMenuItem.Click
        CharEditWindow.CharEdit.InsertBracket(CurrentRtb, "[", "]")
    End Sub

    Private Sub RemoveBracketsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RemoveBracketsToolStripMenuItem.Click
        CharEditWindow.CharEdit.RemoveBrackets(CurrentRtb)
    End Sub

    Private Sub CurrentRtb_SelectionChanged(sender As Object, e As EventArgs) Handles CurrentRtb.SelectionChanged
        UpdateLineNumber()
    End Sub

    Private Sub PatreonToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PatreonToolStripMenuItem.Click
        GoToPatreon()
    End Sub
End Class