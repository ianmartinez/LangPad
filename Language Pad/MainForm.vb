Imports System.Drawing.Drawing2D
Imports System.IO
Imports TundraLib
Imports TundraLib.Themes

Public Class MainForm
    Private ReadOnly ColorPicker As New ColorDialog
    Private CurrentFilePath As String
    Private LastPrintedCharPos As Integer
    Public Title As String
    Public RtbList As New List(Of ExtendedRichTextBox)
    Public WithEvents SelectedDocument As New ExtendedRichTextBox()
    Public Moving As Boolean = False
    Public DisableFontChange As Boolean
    Public IsLoading As Boolean = False
    Public LastFocused As TextBoxBase
    Public Color1 As Color
    Public Color2 As Color
    Public VerticalMenuGradient As Boolean = False

    Private Sub MainForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Text = "Language Pad " & GetVersionString()
        Title = Text
        MainContextMenu.ImageScalingSize = New Size(16, 16)

        ' Load the file that the program was sent, if any
        If My.Application.CommandLineArgs.Count > 0 Then
            If File.Exists(My.Application.CommandLineArgs(0)) Then
                Dim FileName As String = My.Application.CommandLineArgs(0).Split("\").GetValue(My.Application.CommandLineArgs(0).Split("\").Count - 1)
                Dim FileEXT As String = FileName.Split(".").GetValue(1).ToString.ToLower
                CurrentDocument.Pages.Clear()

                If FileEXT = "rtf" Then
                    Dim NewPage As New NotebookPage With {
                        .Title = "Untitled"
                    }
                    Dim Reader As StreamReader
                    Reader = New StreamReader(My.Application.CommandLineArgs(0))
                    NewPage.RTF = Reader.ReadToEnd
                    Reader.Close()

                    CurrentDocument.Pages.Add(NewPage)
                    CurrentFilePath = My.Application.CommandLineArgs(0)
                ElseIf FileEXT = "txt" Then
                    Dim NewPage As New NotebookPage With {
                        .Title = "Untitled"
                    }
                    Dim Reader As StreamReader
                    Reader = New StreamReader(My.Application.CommandLineArgs(0))
                    NewPage.RTF = Reader.ReadToEnd
                    Reader.Close()

                    CurrentDocument.Pages.Add(NewPage)
                    CurrentFilePath = My.Application.CommandLineArgs(0)
                Else
                    Dim AllowOpen As Boolean = True
                    Dim OpenFile As New NotebookFile()
                    OpenFile.Open(My.Application.CommandLineArgs(0))
                    If OpenFile.NTSpecificationVersion > NTVersion Then
                        If Not MessageBox.Show("The notebook file you are trying to open is from Language Pad " + OpenFile.ProgramVersion.ToString() + ", which is newer than the version you are currently using. " +
                            " This can lead to unexpected results. Are you sure you want to continue?", "File from Language Pad " + OpenFile.ProgramVersion.ToString(), MessageBoxButtons.YesNoCancel, MessageBoxIcon.Exclamation) = DialogResult.Yes Then
                            AllowOpen = False
                        End If
                    End If

                    If AllowOpen Then
                        CurrentDocument = OpenFile
                        CurrentFilePath = My.Application.CommandLineArgs(0)
                    End If
                End If
            End If
        End If

        ' If no file was loaded, create an empty notebook
        If CurrentDocument.Pages.Count = 0 Then
            Dim NewPage As New NotebookPage With {
                .Title = "Untitled"
            }
            CurrentDocument.Pages.Add(NewPage)
        End If

        SetTitle()
        Initialized = True
        UpdateTabs()
        SplitLayoutPanel.Panel2Collapsed = False
        SelectedDocument_TextChanged(Me, e)

        If UpdateDialog.NewestVersion > GetCurrentVersionDecimal() Then
            UpdateDialog.SkipFetch = True
            UpdateDialog.TopMost = True
            UpdateDialog.Show()
            UpdateDialog.BringToFront()
        End If

        CurrentDocument.Modified = False
        KeyPreview = True

        'SplitLayoutPanel.Panel2MinSize = 275
        SplitLayoutPanel.SplitterDistance = (SplitLayoutPanel.Width - PropertiesPanel.MinimumSize.Width) - 50

        ' Add indent options
        For i As Integer = 0 To 100
            IndentToolStripComboBox.Items.Add(i)
        Next
        IndentToolStripComboBox.SelectedItem = 1

        ' Reset toolstrip location
        MainToolStrip.Location = New Point(0, 0)

        ' Set theme
        StartupTheme = New GlacierTheme()
        SetTheme(StartupTheme)
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
            CharEditor.Show()
        End If
        CharEditor.TargetForm = Me
        Dim ScreenWidth As Integer = My.Computer.Screen.Bounds.Width
        Dim ScreenX As Integer = ScreenWidth - 20 - CharEditor.Width
        Dim CharToolX = Math.Min(ScreenX, Location.X + Width + 20)
        CharEditor.Location = New Point(CharToolX, Location.Y)

        ColorPicker.FullOpen = True
        SetIcons()
    End Sub

    Public Sub SetIcons()
        Dim Res As IconResolution = GetIconResolution()
        PropertiesPanel.SetIcons()

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

        ' Insert Menu
        ImageToolStripMenuItem.Image = IconManager.Get("filetype-image", IconSize.Small, Res)
        InsertBulletsToolStripMenuItem.Image = IconManager.Get("list-add", IconSize.Small, Res)
        RemoveBulletsToolStripMenuItem.Image = IconManager.Get("list-remove", IconSize.Small, Res)

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
        CharacterEditorToolStripMenuItem.Image = IconManager.Get("language", IconSize.Small, Res)
        UpdateToolStripMenuItem.Image = IconManager.Get("update", IconSize.Small, Res)
        SettingsToolStripMenuItem.Image = IconManager.Get("config", IconSize.Small, Res)

        ' Help Menu
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

        PropertiesPanel.SetTheme(Theme)
        CharEditor.CharEdit.SetTheme(Theme)
        AboutDialog.BackColor = Theme.DialogBack
        NamePageDialog.BackColor = Theme.DialogBack
        CustomZoomDialog.BackColor = Theme.DialogBack
        ExportHtmlDialog.BackColor = Theme.DialogBack
        SettingsDialog.BackColor = Theme.DialogBack
        StyleDialog.BackColor = Theme.DialogBack
        UpdateDialog.BackColor = Theme.DialogBack

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

    Public Sub SaveTabs()
        If Not CurrentDocument.Pages.Count = RtbList.Count Then Exit Sub ' Opening document

        For i = 0 To NotebookTabs.TabPages.Count - 1
            CurrentDocument.Pages.Item(i).RTF = RtbList.Item(i).Rtf
        Next
    End Sub

    Public Sub UpdateTabs()
        SuspendLayout()

        NotebookTabs.TabPages.Clear()
        RtbList.Clear()
        PropertiesPanel.SuspendLayout()
        PropertiesPanel.PagesListBox.Items.Clear()

        For Each Page As NotebookPage In CurrentDocument.Pages
            Dim Tab As New TabPage With {
                .Text = Page.Title
            }

            Dim NewRichTextBox As New ExtendedRichTextBox With {
                .Font = New Font("Calibri", 11, FontStyle.Regular),
                .Rtf = Page.RTF,
                .Dock = DockStyle.Fill,
                .ScrollBars = RichTextBoxScrollBars.Both,
                .BorderStyle = BorderStyle.None,
                .ContextMenuStrip = MainContextMenu,
                .HideSelection = False
            }

            AddHandler NewRichTextBox.TextChanged, AddressOf ModifiedHandler
            Tab.Controls.Add(NewRichTextBox)
            NotebookTabs.TabPages.Add(Tab)
            PropertiesPanel.PagesListBox.Items.Add(Page.Title)
            RtbList.Add(NewRichTextBox)
        Next

        NotebookTabs.SelectedIndex = 0
        If RtbList.Count > 0 Then
            SelectedDocument = RtbList.Item(0)
        End If
        ResumeLayout()
        PropertiesPanel.ResumeLayout()

        PropertiesPanel.TitleTextBox.Text = CurrentDocument.Title
        PropertiesPanel.LanguageTextBox.Text = CurrentDocument.Language
        PropertiesPanel.AuthorTextBox.Text = CurrentDocument.Author
        PropertiesPanel.WebsiteTextBox.Text = CurrentDocument.Website
        PropertiesPanel.InfoTextBox.Text = CurrentDocument.Info

        If PropertiesPanel.PagesListBox.Items.Count > 0 Then
            PropertiesPanel.PagesListBox.SelectedIndex = 0
        End If

        FirstTabUpdate = True

        lblPageCount.Text = "Page Count: " & CurrentDocument.Pages.Count
        WordWrapToolStripMenuItem.Checked = SelectedDocument.WordWrap
    End Sub

    Public Sub ModifiedHandler(sender As Object, e As EventArgs)
        CurrentDocument.Modified = True
    End Sub

    Public Function ModifiedWarning() As DialogResult
        Return MessageBox.Show("Would you like to save the current document?", "Unsaved Document", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning)
    End Function

    Private Sub PrintDocument1_BeginPrint(ByVal sender As Object, ByVal e As Printing.PrintEventArgs) Handles PagePrintDocument.BeginPrint
        LastPrintedCharPos = 0
    End Sub

    Private Sub PagePrintDocument_PrintPage(ByVal sender As Object, ByVal e As Printing.PrintPageEventArgs) Handles PagePrintDocument.PrintPage
        LastPrintedCharPos = SelectedDocument.Print(LastPrintedCharPos, SelectedDocument.TextLength, e)

        If LastPrintedCharPos < SelectedDocument.TextLength Then
            e.HasMorePages = True
        Else
            e.HasMorePages = False
        End If
    End Sub

    Public Shared Function WordCount(text As String) As Integer
        Return text.Split(New Char() {" "c}, StringSplitOptions.RemoveEmptyEntries).Length
    End Function

    Private Sub SelectedDocument_LinkClicked(sender As Object, e As LinkClickedEventArgs) Handles SelectedDocument.LinkClicked
        Dim Link As String = e.LinkText
        If Not (Link.StartsWith("http://") Or Link.StartsWith("https://")) Then Link = "https://" & Link
        Process.Start(Link)
    End Sub

    Public Sub UpdateWordCount()
        CharCountToolStripLabel.Text = "Character Count: " & SelectedDocument.TextLength
        WordCountToolStripLabel.Text = "Word Count: " & WordCount(SelectedDocument.Text)
    End Sub

    Private Sub SelectedDocument_TextChanged(sender As Object, e As EventArgs) Handles SelectedDocument.TextChanged
        UpdateWordCount()
        RtfEditorForm.RtfCodeTextBox.Text = SelectedDocument.Rtf
    End Sub

    Private Sub MainForm_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        Dim HasSaved As Boolean = False

        If CurrentDocument.Modified Then
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

        CharEditor.Close()
        If DictionaryForm IsNot Nothing Then DictionaryForm.Close()
        My.Settings.Theme = ThemeCombo.SelectedItem
        My.Settings.Save()
    End Sub

    Private Sub ApplyStyle(ByVal rtb As ExtendedRichTextBox, ByVal fontStyle As FontStyle)
        If rtb.SelectionLength = 0 Then
            rtb.SelectionFont = New Font(rtb.SelectionFont, rtb.SelectionFont.Style Xor fontStyle)
            Exit Sub
        End If

        SuspendLayout()
        Dim TempRTF As New ExtendedRichTextBox With {
            .Rtf = rtb.Rtf,
            .SelectionStart = rtb.SelectionStart,
            .SelectionLength = rtb.SelectionLength
        }


        If TempRTF.SelectionLength > 0 Then
            Dim Start As Integer = TempRTF.SelectionStart
            Dim Ending As Integer = TempRTF.SelectionLength + Start - 1

            For i = Start To Ending
                TempRTF.SelectionStart = i
                TempRTF.SelectionLength = 1
                TempRTF.SelectionFont = New Font(TempRTF.SelectionFont, TempRTF.SelectionFont.Style Xor fontStyle)
            Next

            TempRTF.SelectionStart = Start
            TempRTF.SelectionLength = Ending - Start + 1
        Else
            TempRTF.SelectionFont = New Font(TempRTF.SelectionFont, TempRTF.SelectionFont.Style Xor fontStyle)
        End If

        Dim CurrentPos As Integer = rtb.SelectionStart
        Dim CurrentLength As Integer = rtb.SelectionLength
        Dim OldClip As Object = Clipboard.GetDataObject()

        rtb.SelectAll()
        TempRTF.SelectAll()
        TempRTF.Copy()
        rtb.Paste()
        Clipboard.SetDataObject(OldClip)

        rtb.SelectionStart = CurrentPos
        rtb.SelectionLength = CurrentLength

        TempRTF.Dispose()
        ResumeLayout()
    End Sub

    Private Sub FindButton_Click(sender As Object, e As EventArgs) Handles FindButton.Click
        Dim SearchType As CompareMethod = CompareMethod.Text
        Dim StartPosition As Integer = InStr(1, SelectedDocument.Text, FindTextBox.Text, SearchType)

        If StartPosition = 0 Then
            MessageBox.Show("String: '" & FindTextBox.Text.ToString() & "' not found", "No Matches", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
            Exit Sub
        End If

        SelectedDocument.Select(StartPosition - 1, FindTextBox.Text.Length)
        SelectedDocument.ScrollToCaret()

    End Sub

    Private Sub FindNextButton_Click(sender As Object, e As EventArgs) Handles FindNextButton.Click
        Dim SearchType As CompareMethod = CompareMethod.Text
        Dim StartPosition As Integer = InStr(StartPosition, SelectedDocument.Text, FindTextBox.Text, SearchType)

        If StartPosition = 0 Then
            MessageBox.Show("String: '" & FindTextBox.Text.ToString() & "' not found", "No Matches", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
            Exit Sub
        End If

        SelectedDocument.Select(StartPosition - 1, FindTextBox.Text.Length)
        SelectedDocument.ScrollToCaret()
    End Sub

    Private Sub ReplaceButton_Click(sender As Object, e As EventArgs) Handles ReplaceButton.Click
        If SelectedDocument.SelectedText.Length <> 0 Then
            SelectedDocument.SelectedText = ReplaceTextBox.Text
        End If

        Dim SearchType As CompareMethod = CompareMethod.Text
        Dim StartPosition As Integer = InStr(StartPosition, SelectedDocument.Text, FindTextBox.Text, SearchType)

        If StartPosition = 0 Then
            MessageBox.Show("String: '" & FindTextBox.Text.ToString() & "' not found", "No Matches", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
            Exit Sub
        End If

        SelectedDocument.Select(StartPosition - 1, FindTextBox.Text.Length)
        SelectedDocument.ScrollToCaret()

    End Sub

    Private Sub ReplaceAllButton_Click(sender As Object, e As EventArgs) Handles ReplaceAllButton.Click
        Dim CurrentStart As Integer = SelectedDocument.SelectionStart
        Dim CurrentLength As Integer = SelectedDocument.SelectionLength

        SelectedDocument.Rtf = Replace(SelectedDocument.Rtf, Trim(FindTextBox.Text), Trim(ReplaceTextBox.Text))
        SelectedDocument.SelectionStart = CurrentStart
        SelectedDocument.SelectionLength = CurrentLength
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
        SelectedDocument.DeselectAll()
    End Sub

    Private Sub NotebookTabs_SelectedIndexChanged(sender As Object, e As EventArgs) Handles NotebookTabs.SelectedIndexChanged
        If NotebookTabs.SelectedIndex = -1 Or IsLoading Then Exit Sub

        Dim OldModified = CurrentDocument.Modified

        If Moving = False Then
            SaveTabs()
            SelectedDocument = RtbList.Item(NotebookTabs.SelectedIndex)
            PropertiesPanel.PagesListBox.SelectedIndex = NotebookTabs.SelectedIndex
            RtfEditorForm.RtfCodeTextBox.Text = SelectedDocument.Rtf
            WordWrapToolStripMenuItem.Checked = SelectedDocument.WordWrap
            SelectedDocument_TextChanged(Me, e)
        End If

        CurrentDocument.Modified = OldModified
    End Sub

    Private Sub NewToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NewToolStripMenuItem.Click
        Dim HasSaved As Boolean = False

        If CurrentDocument.Modified Then
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

        CurrentDocument = New NotebookFile With {
            .Pages = New List(Of NotebookPage)
        }

        NotebookTabs.TabPages.Clear()
        PropertiesPanel.PagesListBox.Items.Clear()

        Dim NewPage As NotebookPage = New NotebookPage With {
            .Title = "Untitled",
            .RTF = ""
        }

        CurrentDocument.Pages.Add(NewPage)
        CurrentDocument.WordDictionary = New DictionaryFile()
        UpdateTabs()

        DictionaryForm.LoadDictionary() ' Reset dictionary form
        CharEditor.CharEdit.FilePanel.Controls.Clear() ' Reset character editor file tab

        CurrentFilePath = ""
        SetTitle()

        CurrentDocument.Modified = False
        UpdateWordCount()
    End Sub

    Private Sub OpenToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OpenToolStripMenuItem.Click
        Dim HasSaved As Boolean = False

        If CurrentDocument.Modified Then
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
            If OpenDialog.FileName = "" Then Exit Sub
            Dim OpenFile As New NotebookFile()
            OpenFile.Open(OpenDialog.FileName)

            If OpenFile.NTSpecificationVersion > NTVersion Then
                If Not MessageBox.Show("The notebook file you are trying to open is from Language Pad " + OpenFile.ProgramVersion.ToString() + ", which is newer than the version you are currently using. " +
                " This can lead to unexpected results. Are you sure you want to continue?", "File from Language Pad " + OpenFile.ProgramVersion.ToString(), MessageBoxButtons.YesNoCancel, MessageBoxIcon.Exclamation) = DialogResult.Yes Then
                    Exit Sub
                End If
            End If

            CurrentDocument = OpenFile
            UpdateTabs()
            DictionaryForm.LoadDictionary()
            CurrentFilePath = OpenDialog.FileName
            CurrentDocument.Modified = False
        End If

        SetTitle()
        UpdateWordCount()
        IsLoading = False
    End Sub

    Public Function FileSaveAs() As Boolean
        Dim SavedFile As Boolean = False

        If SaveDialog.ShowDialog = Windows.Forms.DialogResult.OK Then
            Cursor = Cursors.WaitCursor
            If SaveDialog.FileName = "" Then Return False

            If SaveDialog.FileName.EndsWith(".thw") Then
                MessageBox.Show("This file is being exported to the new Thorn Writer format. This is not compatible with Language Pad.")

                Dim ThornNotebook = New ThornWriter.NotebookFile.Notebook With {
                    .Title = CurrentDocument.Title,
                    .Language = CurrentDocument.Language,
                    .Author = CurrentDocument.Author,
                    .Website = CurrentDocument.Website,
                    .Info = CurrentDocument.Info,
                    .Stylesheet = "",
                    .Characters = ThornWriter.NotebookFile.KeyValue.ToLines(CurrentDocument.CustomSymbols).ToList()
                }

                For Each Page In CurrentDocument.Pages
                    Dim ThornPage As New ThornWriter.NotebookFile.Page With {
                        .Title = Page.Title,
                        .Content = RtfPipe.Rtf.ToHtml(Page.RTF).ToString()
                    }

                    ThornNotebook.Pages.Add(ThornPage)
                Next

                For Each Word In CurrentDocument.WordDictionary.Words
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
                CurrentDocument.Save(SaveDialog.FileName)
                CurrentFilePath = SaveDialog.FileName
                CurrentDocument.Modified = False
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
                SelectedDocument.SaveFile(CurrentFilePath)
            ElseIf Ext = "TXT" Then
                Dim Writer As StreamWriter
                Writer = New StreamWriter(CurrentFilePath)
                Writer.Write(SelectedDocument.Text)
                Writer.Close()
                SelectedDocument.SelectionStart = 0
                SelectedDocument.SelectionLength = 0
            Else
                CurrentDocument.Save(CurrentFilePath)
                CurrentDocument.Modified = False
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
        If SelectedDocument.CanUndo Then
            Dim OldStart = Math.Max(0, SelectedDocument.SelectionStart)
            SelectedDocument.Undo()
            SelectedDocument.SelectionStart = Math.Max(0, Math.Min(OldStart, SelectedDocument.TextLength - 1))
            SelectedDocument.SelectionLength = 0
        End If
    End Sub

    Private Sub RedoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RedoToolStripMenuItem.Click
        If SelectedDocument.CanRedo Then
            Dim OldStart = Math.Max(0, SelectedDocument.SelectionStart)
            SelectedDocument.Redo()
            SelectedDocument.SelectionStart = Math.Max(0, Math.Min(OldStart, SelectedDocument.TextLength - 1))
            SelectedDocument.SelectionLength = 0
        End If
    End Sub

    Private Sub CutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CutToolStripMenuItem.Click
        SelectedDocument.Cut()
    End Sub

    Private Sub CopyToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CopyToolStripMenuItem.Click
        SelectedDocument.Copy()
    End Sub

    Public Sub InsertImage(img As Image)
        ImportImageDialog.SelectedImage = img

        If ImportImageDialog.ShowDialog() = DialogResult.OK Then
            SelectedDocument.InsertImage(ImportImageDialog.SelectedImage)
        End If
    End Sub

    Private Sub PasteToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PasteToolStripMenuItem.Click
        If Clipboard.ContainsImage Then
            InsertImage(Clipboard.GetImage())
        Else
            SelectedDocument.Paste()
        End If
    End Sub

    Private Sub PastePlainToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PastePlainToolStripMenuItem.Click
        SelectedDocument.Paste(DataFormats.GetFormat(DataFormats.UnicodeText))
    End Sub

    Private Sub FindToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FindToolStripMenuItem.Click
        FindReplaceDialog.Visible = FindReplaceDialog.Visible Xor True
        If FindReplaceDialog.Visible = True Then FindTextBox.Focus()
    End Sub

    Private Sub SelectAllToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SelectAllToolStripMenuItem.Click
        SelectedDocument.SelectAll()
    End Sub

    Private Sub ZoomInToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ZoomInToolStripMenuItem.Click
        Dim NewZoom = SelectedDocument.ZoomFactor + 0.2

        If NewZoom >= 64 Then
            SelectedDocument.ZoomFactor = 63
        Else
            SelectedDocument.ZoomFactor = NewZoom
        End If
    End Sub

    Private Sub ZoomOutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ZoomOutToolStripMenuItem.Click
        Dim NewZoom = SelectedDocument.ZoomFactor - 0.2

        If NewZoom <= 0.015625 Then
            SelectedDocument.ZoomFactor = 0.015626
        Else
            SelectedDocument.ZoomFactor = NewZoom
        End If
    End Sub

    Private Sub ZoomToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ZoomToolStripMenuItem.Click
        SelectedDocument.ZoomFactor = 1.0F
    End Sub

    Private Sub EditZoomToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EditZoomToolStripMenuItem.Click
        CustomZoomDialog.ShowDialog()
    End Sub

    Private Sub WordWrapToolStripMenuItem_CheckedChanged(sender As Object, e As EventArgs) Handles WordWrapToolStripMenuItem.CheckedChanged
        SelectedDocument.WordWrap = WordWrapToolStripMenuItem.Checked
    End Sub

    Private Sub ImageToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ImageToolStripMenuItem.Click
        If OpenImageDialog.ShowDialog() = DialogResult.OK Then
            Dim Img As Image = Image.FromFile(OpenImageDialog.FileName)
            InsertImage(Img)
        End If
    End Sub

    Private Sub InsertBulletsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles InsertBulletsToolStripMenuItem.Click
        SelectedDocument.SelectionBullet = True
    End Sub

    Private Sub RemoveBulletsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RemoveBulletsToolStripMenuItem.Click
        SelectedDocument.SelectionBullet = False
    End Sub

    Private Sub DefaultStyleToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DefaultStyleToolStripMenuItem.Click
        If SelectedDocument.SelectionLength = 0 Then Exit Sub

        SuspendLayout()

        Dim TempRTF As New ExtendedRichTextBox With {
            .Rtf = SelectedDocument.Rtf,
            .SelectionStart = SelectedDocument.SelectionStart,
            .SelectionLength = SelectedDocument.SelectionLength,
            .SelectionFont = New Font("Calibri", 11),
            .SelectionColor = Color.Black,
            .SelectionBackColor = Color.White,
            .SelectionAlignment = HorizontalAlignment.Left,
            .SelectionIndent = 0,
            .SelectionHangingIndent = 0,
            .BulletIndent = 0,
            .SelectionCharOffset = 0
        }

        Dim CurrentPos As Integer = SelectedDocument.SelectionStart
        Dim CurrentLength As Integer = SelectedDocument.SelectionLength
        Dim OldClip As Object = Clipboard.GetDataObject()

        SelectedDocument.SelectAll()
        TempRTF.SelectAll()
        TempRTF.Copy()
        SelectedDocument.Paste()
        Clipboard.SetDataObject(OldClip)

        SelectedDocument.SelectionStart = CurrentPos
        SelectedDocument.SelectionLength = CurrentLength

        TempRTF.Dispose()
        ResumeLayout()

        SelectedDocument.SelectionAlignment = HorizontalAlignment.Left
    End Sub

    Private Sub EditStyleToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EditStyleToolStripMenuItem.Click
        StyleDialog.ShowDialog()
    End Sub

    Private Sub ApplyStyleToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ApplyStyleToolStripMenuItem.Click
        If SelectedDocument.SelectionLength = 0 Then Exit Sub

        SuspendLayout()

        Dim TempRTF As New ExtendedRichTextBox With {
            .Rtf = SelectedDocument.Rtf,
            .SelectionStart = SelectedDocument.SelectionStart,
            .SelectionLength = SelectedDocument.SelectionLength,
            .SelectionFont = StyleDialog.StyleFont,
            .SelectionColor = StyleDialog.StyleColor,
            .SelectionBackColor = StyleDialog.StyleHighlight,
            .SelectionAlignment = StyleDialog.StyleAlignment,
            .SelectionIndent = StyleDialog.StyleIndent,
            .SelectionHangingIndent = StyleDialog.StyleHangingIndent,
            .BulletIndent = StyleDialog.StyleBulletIndent,
            .SelectionCharOffset = StyleDialog.StyleCharOffset
        }

        Dim CurrentPos As Integer = SelectedDocument.SelectionStart
        Dim CurrentLength As Integer = SelectedDocument.SelectionLength
        Dim OldClip As Object = Clipboard.GetDataObject

        SelectedDocument.SelectAll()
        TempRTF.SelectAll()
        TempRTF.Copy()
        SelectedDocument.Paste()
        Clipboard.SetDataObject(OldClip)

        SelectedDocument.SelectionStart = CurrentPos
        SelectedDocument.SelectionLength = CurrentLength

        TempRTF.Dispose()
        ResumeLayout()

        SelectedDocument.SelectionAlignment = StyleDialog.StyleAlignment
    End Sub

    Private Sub TextColorToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TextColorToolStripMenuItem.Click
        ColorPicker.Color = SelectedDocument.SelectionColor
        If ColorPicker.ShowDialog = DialogResult.OK Then
            SelectedDocument.SelectionColor = ColorPicker.Color
        End If
    End Sub

    Private Sub HighlightToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles HighlightToolStripMenuItem.Click
        ColorPicker.Color = SelectedDocument.SelectionBackColor

        If ColorPicker.ShowDialog = DialogResult.OK Then
            SelectedDocument.SelectionBackColor = ColorPicker.Color
        End If
    End Sub

    Public Sub AddPageToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AddPageToolStripMenuItem.Click
        SaveTabs()
        NamePageDialog.AddPage = True
        NamePageDialog.DuplicatePage = False
        NamePageDialog.ShowDialog()
    End Sub

    Public Sub RemovePageToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RemovePageToolStripMenuItem.Click
        If CurrentDocument.Pages.Count = 0 Or NotebookTabs.SelectedIndex < 0 Then Exit Sub

        SaveTabs()
        If MessageBox.Show("Are you sure you want to delete this page? This cannot be undone.", "", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning) = Windows.Forms.DialogResult.Yes Then
            CurrentDocument.Pages.RemoveAt(NotebookTabs.SelectedIndex)
            CurrentDocument.Modified = True
            UpdateTabs()
        End If
    End Sub

    Public Sub DuplicatePageToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DuplicatePageToolStripMenuItem.Click
        Dim CurrentPage = NotebookTabs.SelectedIndex

        If Not CurrentPage = -1 Then
            SaveTabs()
            NamePageDialog.NameTextBox.Text = CurrentDocument.Pages(CurrentPage).Title
            NamePageDialog.DuplicatePage = True
            NamePageDialog.AddPage = False
            NamePageDialog.ShowDialog()
        End If
    End Sub

    Public Sub ImportPageToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ImportPageToolStripMenuItem.Click
        If OpenPageDialog.ShowDialog = Windows.Forms.DialogResult.OK Then
            SaveTabs()

            If OpenPageDialog.FileName = "" Then Exit Sub

            Dim NewPage As New NotebookPage With {
                .Title = OpenPageDialog.FileName.Split("\").GetValue(OpenPageDialog.FileName.Split("\").Count - 1).ToString.Split(".").GetValue(0)
            }

            Dim ImportedExt = Path.GetExtension(OpenPageDialog.FileName).ToUpper()
            Select Case ImportedExt
                Case ".RTF"
                    Dim Reader = New StreamReader(OpenPageDialog.FileName)
                    NewPage.RTF = Reader.ReadToEnd
                    Reader.Close()
                Case Else
                    Dim Reader = New StreamReader(OpenPageDialog.FileName)
                    Dim TempRichTextBox As New ExtendedRichTextBox With {
                        .Text = Reader.ReadToEnd
                    }
                    NewPage.RTF = TempRichTextBox.Rtf
                    Reader.Close()
            End Select

            CurrentDocument.Pages.Add(NewPage)
            UpdateTabs()
            NotebookTabs.SelectedIndex = CurrentDocument.Pages.Count - 1
        End If
    End Sub

    Public Sub ExportPageToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExportPageToolStripMenuItem.Click
        If SavePageDialog.ShowDialog = Windows.Forms.DialogResult.OK Then
            If SavePageDialog.FileName = "" Then Exit Sub

            Dim ExportExt = Path.GetExtension(SavePageDialog.FileName).ToUpper()
            Select Case ExportExt
                Case ".RTF"
                    Dim Writer = New StreamWriter(SavePageDialog.FileName)
                    Writer.Write(SelectedDocument.Rtf)
                    Writer.Close()
                    SelectedDocument.SelectionStart = 0
                    SelectedDocument.SelectionLength = 0
                Case ".HTML"
                    File.WriteAllText(SavePageDialog.FileName, RtfPipe.Rtf.ToHtml(SelectedDocument.Rtf).ToString())
                Case Else
                    Dim Writer = New StreamWriter(SavePageDialog.FileName)
                    Writer.Write(SelectedDocument.Text)
                    Writer.Close()
                    SelectedDocument.SelectionStart = 0
                    SelectedDocument.SelectionLength = 0
            End Select
        End If
    End Sub

    Public Sub RenamePageToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RenamePageToolStripMenuItem.Click
        SaveTabs()
        NamePageDialog.AddPage = False
        NamePageDialog.DuplicatePage = False
        NamePageDialog.NameTextBox.Text = CurrentDocument.Pages.Item(NotebookTabs.SelectedIndex).Title
        NamePageDialog.CurrentPos = NotebookTabs.SelectedIndex
        NamePageDialog.ShowDialog()
    End Sub

    Private Sub UpdateToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles UpdateToolStripMenuItem.Click
        UpdateDialog.SkipFetch = False
        UpdateDialog.TopMost = False
        UpdateDialog.ShowDialog()
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
        SelectedDocument.SelectionIndent = IndentToolStripComboBox.SelectedItem
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
            SelectedDocument.SelectionColor = ColorButton.Color
        Else ' Highlight Color
            SelectedDocument.SelectionBackColor = ColorButton.Color
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
            SelectedDocument.SelectionColor = Color.Transparent
        Else
            SelectedDocument.SelectionBackColor = Color.Transparent
        End If
    End Sub

    Public Sub DictionaryMenuItem_Click(sender As Object, e As EventArgs) Handles DictionaryMenuItem.Click
        DictionaryForm.Show()
        DictionaryForm.Activate()
    End Sub

    Public Sub MainForm_Activated(sender As Object, e As EventArgs) Handles MyBase.Activated
        CharEditor.TargetForm = Me
        CharEditor.GetCurrentTexbox = Function()
                                          If LastFocused Is Nothing Then
                                              LastFocused = SelectedDocument
                                          End If

                                          Return LastFocused
                                      End Function
    End Sub

    Private Sub CharacterEditorToolStripButton_Click(sender As Object, e As EventArgs) Handles CharacterEditorToolStripButton.Click
        CharacterEditorToolStripMenuItem_Click(Me, e)
    End Sub

    Private Sub CharacterEditorToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CharacterEditorToolStripMenuItem.Click
        CharEditor.Show()
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

    Private Sub SelectedDocument_GotFocus(sender As Object, e As EventArgs) Handles SelectedDocument.GotFocus
        LastFocused = SelectedDocument
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
            .Color = SelectedDocument.SelectionColor,
            .Font = SelectedDocument.SelectionFont
        }

        If FontPicker.ShowDialog() = Windows.Forms.DialogResult.OK Then
            SelectedDocument.SelectionColor = FontPicker.Color
            SelectedDocument.SelectionFont = FontPicker.Font
        End If

        DisableFontChange = False
    End Sub

    Private Sub SubscriptToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SubscriptToolStripMenuItem.Click
        SelectedDocument.SelectionCharOffset = -10
    End Sub

    Private Sub SuperscriptToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SuperscriptToolStripMenuItem.Click
        SelectedDocument.SelectionCharOffset = 10
    End Sub

    Private Sub BaselineToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BaselineToolStripMenuItem.Click
        SelectedDocument.SelectionCharOffset = 0
    End Sub

    Private Sub BoldToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BoldToolStripMenuItem.Click
        ApplyStyle(SelectedDocument, FontStyle.Bold)
    End Sub

    Private Sub ItalicToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ItalicToolStripMenuItem.Click
        ApplyStyle(SelectedDocument, FontStyle.Italic)
    End Sub

    Private Sub UnderlineToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles UnderlineToolStripMenuItem.Click
        ApplyStyle(SelectedDocument, FontStyle.Underline)
    End Sub

    Private Sub StrikeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles StrikeToolStripMenuItem.Click
        ApplyStyle(SelectedDocument, FontStyle.Strikeout)
    End Sub

    Private Sub AlignLeftToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AlignLeftToolStripMenuItem.Click
        SelectedDocument.SelectionAlignment = HorizontalAlignment.Left
    End Sub

    Private Sub AlignCenterToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AlignCenterToolStripMenuItem.Click
        SelectedDocument.SelectionAlignment = HorizontalAlignment.Center
    End Sub

    Private Sub AlignRightToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AlignRightToolStripMenuItem.Click
        SelectedDocument.SelectionAlignment = HorizontalAlignment.Right
    End Sub

    Private Sub PreviousPageToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PreviousPageToolStripMenuItem.Click
        If Not NotebookTabs.SelectedIndex = 0 Then NotebookTabs.SelectedIndex -= 1
    End Sub

    Private Sub NextPageToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NextPageToolStripMenuItem.Click
        If Not NotebookTabs.SelectedIndex = NotebookTabs.TabPages.Count - 1 Then NotebookTabs.SelectedIndex += 1
    End Sub

    Private Sub IncreaseIndentToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles IncreaseIndentToolStripMenuItem.Click
        Dim NewIndent = SelectedDocument.SelectionIndent + 30
        SelectedDocument.SelectionIndent = NewIndent
    End Sub

    Private Sub DecreaseIndentToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DecreaseIndentToolStripMenuItem.Click
        Dim NewIndent = SelectedDocument.SelectionIndent - 30
        SelectedDocument.SelectionIndent = NewIndent
    End Sub

    Private Sub SelectedDocument_KeyPress(sender As Object, e As KeyPressEventArgs) Handles SelectedDocument.KeyPress
        ' Suppress tab character insertion
        If e.KeyChar = Chr(9) Then ' Tab
            e.Handled = True
        End If
    End Sub

    Private Sub SelectedDocument_KeyUp(sender As Object, e As KeyEventArgs) Handles SelectedDocument.KeyUp
        If Not e.Control Then ' CTRL + TAB/ CTRL + SHIFT + TAB handle bullet indent
            If e.KeyCode = Keys.Tab AndAlso Not e.Modifiers = Keys.Shift Then
                IncreaseIndentToolStripMenuItem_Click(Me, e)
            ElseIf e.Modifiers = Keys.Shift AndAlso e.KeyCode = Keys.Tab Then
                DecreaseIndentToolStripMenuItem_Click(Me, e)
            End If
        End If
    End Sub

    Private Sub IncreaseBulletIndentToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles IncreaseBulletIndentToolStripMenuItem.Click
        Dim NewIndent = SelectedDocument.BulletIndent + 30
        SelectedDocument.BulletIndent = NewIndent
    End Sub

    Private Sub DecreaseBulletIndentToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DecreaseBulletIndentToolStripMenuItem.Click
        Dim NewIndent = SelectedDocument.BulletIndent - 30
        SelectedDocument.BulletIndent = NewIndent
    End Sub

    Private Sub IncreaseHangingIndentToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles IncreaseHangingIndentToolStripMenuItem.Click
        Dim NewIndent = SelectedDocument.SelectionHangingIndent + 30
        SelectedDocument.SelectionHangingIndent = NewIndent
    End Sub

    Private Sub DecreaseHangingIndentToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DecreaseHangingIndentToolStripMenuItem.Click
        Dim NewIndent = SelectedDocument.SelectionHangingIndent - 30
        SelectedDocument.SelectionHangingIndent = NewIndent
    End Sub

    Private Sub ResetIndentToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ResetIndentToolStripMenuItem.Click
        SelectedDocument.SelectionIndent = 0
    End Sub

    Private Sub ResetBulletIndentToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ResetBulletIndentToolStripMenuItem.Click
        SelectedDocument.BulletIndent = 0
    End Sub

    Private Sub ResetHangingIndentToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ResetHangingIndentToolStripMenuItem.Click
        SelectedDocument.SelectionHangingIndent = 0
    End Sub
End Class
