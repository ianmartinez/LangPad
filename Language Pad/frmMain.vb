Imports System.Drawing.Drawing2D
Imports System.IO
Imports TundraLib
Imports TundraLib.Themes

Public Class frmMain
    Private dlgColor As New ColorDialog
    Public Event EditText()
    Private currentFile As String
    Private checkPrint As Integer
    Public ReadOnly AssociatedRichTextBox As RichTextBox = SelectedDocument
    Public Title As String
    Public rtbList As New List(Of ExtendedRichTextBox)
    Public WithEvents SelectedDocument As New ExtendedRichTextBox
    Public SelectedPage As Integer = 0
    Public Notebook As New List(Of String)
    Public Moving As Boolean = False
    Public DisableFontChange As Boolean
    Public Sub SaveTabs()
        For i = 0 To tcNotebook.TabPages.Count - 1
            CurrentDocument.Pages.Item(i).RTF = rtbList.Item(i).Rtf
        Next
    End Sub

    Public Sub UpdateTabs()
        On Error Resume Next
        SuspendLayout()

        tcNotebook.TabPages.Clear()
        rtbList.Clear()
        pnlProperties.SuspendLayout()
        pnlProperties.lbPages.Items.Clear()

        For Each p As NotebookPage In CurrentDocument.Pages
            Dim Tab As New TabPage With {
                .Text = p.Title
            }

            Dim rtbDoc As New ExtendedRichTextBox With {
                .Rtf = p.RTF,
                .Dock = DockStyle.Fill,
                .ScrollBars = RichTextBoxScrollBars.Both,
                .BorderStyle = BorderStyle.None,
                .ContextMenuStrip = cmsMain,
                .HideSelection = False
            }
            AddHandler rtbDoc.TextChanged, AddressOf ModifiedHandler

            Tab.Controls.Add(rtbDoc)
            tcNotebook.TabPages.Add(Tab)

            pnlProperties.lbPages.Items.Add(p.Title)

            rtbList.Add(rtbDoc)
        Next

        tcNotebook.SelectedIndex = 0
        SelectedDocument = rtbList.Item(0)
        ResumeLayout()
        pnlProperties.ResumeLayout()

        pnlProperties.txtTitle.Text = CurrentDocument.Title
        pnlProperties.txtLanguage.Text = CurrentDocument.Language
        pnlProperties.txtAuthor.Text = CurrentDocument.Author
        pnlProperties.txtWebsite.Text = CurrentDocument.Website
        pnlProperties.txtInfo.Text = CurrentDocument.Info

        pnlProperties.lbPages.SelectedIndex = 0
        FirstTabUpdate = True

        lblPageCount.Text = "Page Count: " & CurrentDocument.Pages.Count
        WordWrapToolStripMenuItem.Checked = SelectedDocument.WordWrap
    End Sub

    Public Sub ModifiedHandler(sender As Object, e As EventArgs)
        CurrentDocument.Modified = True
    End Sub

    Public Sub InsertImageHandler(sender As Object, e As EventArgs)
        SelectedDocument.InsertImage(CType(sender, Button).Image.Clone)
    End Sub

    Public Function ModifiedWarning() As DialogResult
        Return MessageBox.Show("Would you like to save the current document?", "Unsaved Document", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning)
    End Function

    Public Sub SetTitle()
        If currentFile = "" Then
            Text = Title
        Else
            Dim FileName As String = currentFile.Split("\").GetValue(currentFile.Split("\").Count - 1)
            Text = Title & " - " & FileName
        End If
    End Sub

    Public Shared Function ResizeImage(ByVal image As Image, ByVal size As Size, Optional ByVal preserveAspectRatio As Boolean = True) As Image
        Dim newWidth As Integer
        Dim newHeight As Integer
        If preserveAspectRatio Then
            Dim originalWidth As Integer = image.Width
            Dim originalHeight As Integer = image.Height
            Dim percentWidth As Single = CSng(size.Width) / CSng(originalWidth)
            Dim percentHeight As Single = CSng(size.Height) / CSng(originalHeight)
            Dim percent As Single = If(percentHeight < percentWidth,
                    percentHeight, percentWidth)
            newWidth = CInt(originalWidth * percent)
            newHeight = CInt(originalHeight * percent)
        Else
            newWidth = size.Width
            newHeight = size.Height
        End If
        Dim newImage As Image = New Bitmap(newWidth, newHeight)
        Using graphicsHandle As Graphics = Graphics.FromImage(newImage)
            graphicsHandle.InterpolationMode = InterpolationMode.HighQualityBicubic
            graphicsHandle.DrawImage(image, 0, 0, newWidth, newHeight)
        End Using
        Return newImage
    End Function

    Private Sub PrintDocument1_BeginPrint(ByVal sender As Object, ByVal e As Printing.PrintEventArgs) Handles pdMain.BeginPrint
        checkPrint = 0
    End Sub

    Private Sub pdMain_PrintPage(ByVal sender As Object, ByVal e As Printing.PrintPageEventArgs) Handles pdMain.PrintPage
        checkPrint = SelectedDocument.Print(checkPrint, SelectedDocument.TextLength, e)
        If checkPrint < SelectedDocument.TextLength Then
            e.HasMorePages = True
        Else
            e.HasMorePages = False
        End If
    End Sub

    Public Shared Function WordCount(s As String) As Integer
        Return s.Split(New Char() {" "c}, StringSplitOptions.RemoveEmptyEntries).Length
    End Function

    Public Sub InsertImage(ByVal RichTextBox As RichTextBox, ByVal Image As Image)
        Dim obj As Object = Clipboard.GetDataObject
        Clipboard.SetImage(Image)
        RichTextBox.Paste()
        Clipboard.SetDataObject(obj)
    End Sub

    Private Sub SelectedDocument_LinkClicked(sender As Object, e As LinkClickedEventArgs) Handles SelectedDocument.LinkClicked
        Dim Link As String = e.LinkText
        If Not (Link.StartsWith("http://") Or Link.StartsWith("https://")) Then Link = "https://" & Link
        Process.Start(Link)
    End Sub

    Private Sub SelectedDocument_TextChanged(sender As Object, e As EventArgs) Handles SelectedDocument.TextChanged
        RaiseEvent EditText()
        CharCountToolStripLabel.Text = "Character Count: " & SelectedDocument.TextLength
        WordCountToolStripLabel.Text = "Word Count: " & WordCount(SelectedDocument.Text)
        frmRTF.txtRTF.Text = SelectedDocument.Rtf
    End Sub

    Private Sub BulletToolStripButton_ButtonClick(sender As Object, e As EventArgs)
        SelectedDocument.BulletIndent = 10
        SelectedDocument.SelectionBullet = True
    End Sub

    Private Sub frmMain_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        If CurrentDocument.Modified = True Then
            Dim Mode = ModifiedWarning()
            If Mode = DialogResult.Yes Then
                SaveToolStripMenuItem_Click(Me, e)
            ElseIf Mode = Windows.Forms.DialogResult.Cancel Then
                e.Cancel = True
            End If
        End If

        My.Settings.Theme = ThemeCombo.SelectedItem
        My.Settings.Save()
    End Sub

    Private Sub InsertImage(sender As Object, e As EventArgs)
        SelectedDocument.InsertImage(CType(sender, Button).Image)
    End Sub

    Private Sub ApplyStyle(ByVal rtb As ExtendedRichTextBox, ByVal FontStyle As FontStyle)
        If rtb.SelectionLength = 0 Then
            rtb.SelectionFont = New Font(rtb.SelectionFont, rtb.SelectionFont.Style Xor FontStyle)
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
                TempRTF.SelectionFont = New Font(TempRTF.SelectionFont, TempRTF.SelectionFont.Style Xor FontStyle)
            Next
            TempRTF.SelectionStart = Start
            TempRTF.SelectionLength = Ending - Start + 1
        Else
            TempRTF.SelectionFont = New Font(TempRTF.SelectionFont, TempRTF.SelectionFont.Style Xor FontStyle)
        End If

        On Error Resume Next
        Dim CurrentPos As Integer = rtb.SelectionStart
        Dim CurrentLength As Integer = rtb.SelectionLength

        Dim obj As Object = Clipboard.GetDataObject
        rtb.SelectAll()
        TempRTF.SelectAll()
        TempRTF.Copy()
        rtb.Paste()
        Clipboard.SetDataObject(obj)

        rtb.SelectionStart = CurrentPos
        rtb.SelectionLength = CurrentLength

        TempRTF.Dispose()
        ResumeLayout()
    End Sub

    Public Color1 As Color
    Public Color2 As Color
    Public VerticalMenuGradient As Boolean = False

    Public Sub SetTheme(Theme As Theme)
        Color1 = Theme.Color1
        Color2 = Theme.Color2
        VerticalMenuGradient = Theme.VerticalMenuGradient

        MainMenu.Renderer = Theme.GetMenuRenderer()
        FileToolStrip.Renderer = Theme.GetToolStripRenderer()
        FontToolStrip.Renderer = Theme.GetToolStripRenderer()
        DataToolStrip.Renderer = Theme.GetToolStripRenderer()
        cmsMain.Renderer = Theme.GetMenuRenderer()
        frmRTF.SetTheme(Theme)
        frmDictionary.SetTheme(Theme)
        BackColor = Theme.PanelBack
        pnlColor.ForeColor = Theme.PanelText
        pnlFindReplace.BackColor = Theme.PanelBack
        pnlFindReplace.ForeColor = Theme.PanelText

        ' Center buttons relative to text boxes
        ' Because Windows' scaling throws them off
        btnFind.Top = txtFind.Top - (btnFind.Height / 2 - txtFind.Height / 2)
        btnFindNext.Top = txtFind.Top - (btnFindNext.Height / 2 - txtFind.Height / 2)
        btnReplace.Top = txtFind.Top - (btnReplace.Height / 2 - txtFind.Height / 2)
        btnReplaceAll.Top = txtFind.Top - (btnReplaceAll.Height / 2 - txtFind.Height / 2)

        pnlProperties.SetTheme(Theme)
        dlgAbout.BackColor = Theme.DialogBack
        dlgAccentMark.BackColor = Theme.DialogBack
        dlgAddPage.BackColor = Theme.DialogBack
        dlgCustomSymbols.BackColor = Theme.DialogBack
        dlgCustomSymbols.dgvSymbols.BackgroundColor = Theme.DialogBack
        dlgCustomZoom.BackColor = Theme.DialogBack
        dlgHtml.BackColor = Theme.DialogBack
        dlgSettings.BackColor = Theme.DialogBack
        dlgStyle.BackColor = Theme.DialogBack
        dlgUpdate.BackColor = Theme.DialogBack

        Refresh()
    End Sub

    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'On Error Resume Next
        Text = LangPadVersion

        Title = Text
        cmsMain.ImageScalingSize = New Size(16, 16)

        Dim rectF As New RectangleF(10, 10, 500, 500)
        Dim solidBrush As New SolidBrush(Color.Black)

        If My.Application.CommandLineArgs.Count > 0 Then
            If File.Exists(My.Application.CommandLineArgs(0)) Then
                Dim FileName As String = My.Application.CommandLineArgs(0).Split("\").GetValue(My.Application.CommandLineArgs(0).Split("\").Count - 1)
                Dim FileEXT As String = FileName.Split(".").GetValue(1).ToString.ToLower
                CurrentDocument.Pages.Clear()

                If FileEXT = "rtf" Then
                    Dim p As New NotebookPage With {
                        .Title = "Untitled"
                    }
                    Dim txtReader As StreamReader
                    txtReader = New StreamReader(My.Application.CommandLineArgs(0))
                    p.RTF = txtReader.ReadToEnd
                    txtReader.Close()

                    CurrentDocument.Pages.Add(p)
                    currentFile = My.Application.CommandLineArgs(0)
                ElseIf FileEXT = "txt" Then
                    Dim p As New NotebookPage With {
                        .Title = "Untitled"
                    }
                    Dim txtReader As StreamReader
                    txtReader = New StreamReader(My.Application.CommandLineArgs(0))
                    p.RTF = txtReader.ReadToEnd
                    txtReader.Close()

                    CurrentDocument.Pages.Add(p)
                    currentFile = My.Application.CommandLineArgs(0)
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
                        currentFile = My.Application.CommandLineArgs(0)
                    End If
                End If
            End If
        End If

        If CurrentDocument.Pages.Count = 0 Then
            Dim p As New NotebookPage With {
                .Title = "Untitled"
            }
            CurrentDocument.Pages.Add(p)
        End If

        SetTitle()

        Initialized = True
        UpdateTabs()

        SplitLayoutPanel.Panel2Collapsed = False
        SelectedDocument_TextChanged(Me, e)

        If dlgUpdate.NewestVersion > CurrentVersion Then
            dlgUpdate.SkipFetch = True
            dlgUpdate.TopMost = True
            dlgUpdate.Show()
            dlgUpdate.BringToFront()
        End If

        CurrentDocument.Modified = False
        KeyPreview = True

        SplitLayoutPanel.SplitterDistance = (SplitLayoutPanel.Width - pnlProperties.MinimumSize.Width) - 30

        For i As Integer = 0 To 50
            IndentToolStripComboBox.Items.Add(i)
        Next

        IndentToolStripComboBox.SelectedItem = 1

        FileToolStrip.Location = New Point(0, 0)
        FontToolStrip.Location = New Point(FileToolStrip.Left + FileToolStrip.Width, 0)

        dlgColor.FullOpen = True
        StartupTheme = New GlacierTheme()
        SetTheme(StartupTheme)

        ThemeCombo.SelectedItem = My.Settings.Theme

        For Each button As Button In ColorLayoutPanel.Controls
            If TypeOf button Is StylizedColorButton Then
                button.ImageAlign = ContentAlignment.MiddleCenter
                AddHandler button.Click, AddressOf ColorButton_Click
            End If
        Next

        charEdit.GetCurrentTexbox = Function()
                                        Return SelectedDocument
                                    End Function
    End Sub

    Private Sub ToolStripContainer1_ToolStripPanel_Paint(ByVal sender As Object, ByVal e As PaintEventArgs) Handles MainToolStripContainer.TopToolStripPanel.Paint,
        MainToolStripContainer.BottomToolStripPanel.Paint, MainToolStripContainer.LeftToolStripPanel.Paint, MainToolStripContainer.RightToolStripPanel.Paint
        Dim g As Graphics = e.Graphics
        Dim rect As New Rectangle(0, 0, MainToolStripContainer.Width, Height)
        Dim b As New LinearGradientBrush(rect, BackColor, BackColor, If(VerticalMenuGradient, LinearGradientMode.Vertical, LinearGradientMode.Horizontal))
        g.FillRectangle(b, rect)
    End Sub

    Private Sub ToolStripContainer1_ToolStripPanel_SizeChanged(ByVal sender As Object, ByVal e As EventArgs) Handles MainToolStripContainer.TopToolStripPanel.SizeChanged,
        MainToolStripContainer.BottomToolStripPanel.SizeChanged, MainToolStripContainer.LeftToolStripPanel.SizeChanged, MainToolStripContainer.RightToolStripPanel.SizeChanged
        MainToolStripContainer.Invalidate()
    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs)
        dlgColor.Color = SelectedDocument.BackColor
        If dlgColor.ShowDialog = DialogResult.OK Then
            SelectedDocument.BackColor = dlgColor.Color
        End If
    End Sub

    Private Sub btnFind_Click(sender As Object, e As EventArgs) Handles btnFind.Click
        Dim StartPosition As Integer
        Dim SearchType As CompareMethod

        SearchType = CompareMethod.Text

        StartPosition = InStr(1, SelectedDocument.Text, txtFind.Text, SearchType)

        If StartPosition = 0 Then
            MessageBox.Show("String: '" & txtFind.Text.ToString() & "' not found", "No Matches", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
            Exit Sub
        End If

        SelectedDocument.Select(StartPosition - 1, txtFind.Text.Length)
        SelectedDocument.ScrollToCaret()

    End Sub

    Private Sub btnFindNext_Click(sender As Object, e As EventArgs) Handles btnFindNext.Click
        Dim StartPosition As Integer = SelectedDocument.SelectionStart + 2
        Dim SearchType As CompareMethod
        SearchType = CompareMethod.Text

        StartPosition = InStr(StartPosition, SelectedDocument.Text, txtFind.Text, SearchType)

        If StartPosition = 0 Then
            MessageBox.Show("String: '" & txtFind.Text.ToString() & "' not found", "No Matches", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
            Exit Sub
        End If

        SelectedDocument.Select(StartPosition - 1, txtFind.Text.Length)
        SelectedDocument.ScrollToCaret()
    End Sub

    Private Sub btnReplace_Click(sender As Object, e As EventArgs) Handles btnReplace.Click
        If SelectedDocument.SelectedText.Length <> 0 Then
            SelectedDocument.SelectedText = txtReplace.Text
        End If

        Dim StartPosition As Integer = SelectedDocument.SelectionStart + 2
        Dim SearchType As CompareMethod
        SearchType = CompareMethod.Text

        StartPosition = InStr(StartPosition, SelectedDocument.Text, txtFind.Text, SearchType)

        If StartPosition = 0 Then
            MessageBox.Show("String: '" & txtFind.Text.ToString() & "' not found", "No Matches", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
            Exit Sub
        End If

        SelectedDocument.Select(StartPosition - 1, txtFind.Text.Length)
        SelectedDocument.ScrollToCaret()

    End Sub

    Private Sub btnReplaceAll_Click(sender As Object, e As EventArgs) Handles btnReplaceAll.Click
        Dim currentPosition As Integer = SelectedDocument.SelectionStart
        Dim currentSelect As Integer = SelectedDocument.SelectionLength

        SelectedDocument.Rtf = Replace(SelectedDocument.Rtf, Trim(txtFind.Text), Trim(txtReplace.Text))
        SelectedDocument.SelectionStart = currentPosition
        SelectedDocument.SelectionLength = currentSelect
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

    Private Sub tcNotebook_SelectedIndexChanged(sender As Object, e As EventArgs) Handles tcNotebook.SelectedIndexChanged
        On Error Resume Next
        If tcNotebook.SelectedIndex = -1 Then Exit Sub
        If Moving = False Then
            SaveTabs()
            SelectedDocument = rtbList.Item(tcNotebook.SelectedIndex)
            pnlProperties.lbPages.SelectedIndex = tcNotebook.SelectedIndex
            frmRTF.txtRTF.Text = SelectedDocument.Rtf
            WordWrapToolStripMenuItem.Checked = SelectedDocument.WordWrap
            SelectedDocument_TextChanged(Me, e)
        End If
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs)
        SplitLayoutPanel.Panel2Collapsed = True
    End Sub

    Private Sub btnNotebookEditor_Click(sender As Object, e As EventArgs)
        SplitLayoutPanel.Panel2Collapsed = False
    End Sub

    Private Sub frmMain_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.Control And e.KeyCode.ToString = "N" Then
            NewToolStripMenuItem_Click(Me, Nothing)
        ElseIf e.Control And e.KeyCode.ToString = "O" Then
            OpenToolStripMenuItem_Click(Me, Nothing)
        ElseIf e.Control And e.KeyCode.ToString = "S" Then
            SaveToolStripMenuItem_Click(Me, Nothing)
        ElseIf e.Control And e.KeyCode.ToString = "F" Then
            FindToolStripMenuItem_Click(Me, Nothing)
        ElseIf e.Control And e.KeyCode.ToString = "B" Then
            BoldToolStripButton_Click(Me, Nothing)
        ElseIf e.Control And e.KeyCode.ToString = "U" Then
            UnderlineToolStripButton_Click(Me, Nothing)
        ElseIf e.Control And e.KeyCode.ToString = "I" Then
            ItalicToolStripButton_Click(Me, Nothing)

            'The richtextbox wants to insent a tab here, so:
            e.Handled = True
            e.SuppressKeyPress = True
        ElseIf e.Control And e.KeyCode.ToString = "M" Then
            StrikeToolStripButton_Click(Me, Nothing)
        ElseIf e.Control And e.KeyCode.ToString = "F" Then
            FindToolStripMenuItem_Click(Me, Nothing)
        ElseIf e.Control And e.KeyCode.ToString = "L" Then
            AlignLeftToolStripButton_Click(Me, Nothing)
        ElseIf e.Control And e.KeyCode.ToString = "E" Then
            AlignCenterToolStripButton_Click(Me, Nothing)
        ElseIf e.Control And e.KeyCode.ToString = "R" Then
            AlignRightToolStripButton_Click(Me, Nothing)
        ElseIf e.Control And e.KeyCode.ToString = "P" Then
            PrintToolStripMenuItem_Click(Me, Nothing)

            'Language Pad specific key combos
        ElseIf e.Control And e.KeyCode.ToString = "T" Then
            AddPageToolStripMenuItem_Click(Me, Nothing)
        ElseIf e.Control And e.KeyCode.ToString = "W" Then
            RemovePageToolStripMenuItem_Click(Me, Nothing)

        ElseIf e.Control And e.KeyCode.ToString = "D" Then
            DefaultStyleToolStripMenuItem_Click(Me, Nothing)
        ElseIf e.Control And e.KeyCode.ToString = "G" Then
            ApplyStyleToolStripMenuItem_Click(Me, Nothing)

        ElseIf e.Control And e.KeyCode.ToString = "J" Then
            If Not tcNotebook.SelectedIndex = 0 Then tcNotebook.SelectedIndex -= 1
        ElseIf e.Control And e.KeyCode.ToString = "K" Then
            If Not tcNotebook.SelectedIndex = tcNotebook.TabPages.Count - 1 Then tcNotebook.SelectedIndex += 1
        End If
    End Sub

    Private Sub NewToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NewToolStripMenuItem.Click
        If SelectedDocument.Modified Then
            Dim Mode = ModifiedWarning()
            If Mode = DialogResult.Yes Then
                SaveToolStripMenuItem_Click(Me, e)
            ElseIf Mode = Windows.Forms.DialogResult.Cancel Then
                Exit Sub
            Else

            End If
        End If

        CurrentDocument = New NotebookFile With {
            .Pages = New List(Of NotebookPage)
        }

        tcNotebook.TabPages.Clear()
        pnlProperties.lbPages.Items.Clear()

        Dim new_page As NotebookPage = New NotebookPage With {
            .Title = "Untitled",
            .RTF = ""
        }
        CurrentDocument.Pages.Add(new_page)
        CurrentDocument.WordDictionary = New DictionaryFile

        UpdateTabs()
        currentFile = ""
        SetTitle()

        CurrentDocument.Modified = False
    End Sub

    Private Sub OpenToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OpenToolStripMenuItem.Click
        If SelectedDocument.Modified Then
            Dim Mode = ModifiedWarning()
            If Mode = DialogResult.Yes Then
                SaveToolStripMenuItem_Click(Me, e)
            ElseIf Mode = Windows.Forms.DialogResult.Cancel Then
                Exit Sub
            End If
        End If

        If dlgOpen.ShowDialog = Windows.Forms.DialogResult.OK Then
            If dlgOpen.FileName = "" Then Exit Sub
            Dim OpenFile As New NotebookFile()
            OpenFile.Open(dlgOpen.FileName)

            If OpenFile.NTSpecificationVersion > NTVersion Then
                If Not MessageBox.Show("The notebook file you are trying to open is from Language Pad " + OpenFile.ProgramVersion.ToString() + ", which is newer than the version you are currently using. " +
                " This can lead to unexpected results. Are you sure you want to continue?", "File from Language Pad " + OpenFile.ProgramVersion.ToString(), MessageBoxButtons.YesNoCancel, MessageBoxIcon.Exclamation) = DialogResult.Yes Then
                    Exit Sub
                End If
            End If

            CurrentDocument = OpenFile
            UpdateTabs()
            currentFile = dlgOpen.FileName
            SelectedDocument.Modified = False
        End If

        SetTitle()
    End Sub

    Private Sub SaveToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SaveToolStripMenuItem.Click
        If currentFile = "" Then
            SaveAsToolStripMenuItem_Click(Me, e)
            Exit Sub
        Else
            Cursor = Cursors.WaitCursor
            Dim strExt As String
            strExt = Path.GetExtension(currentFile)
            strExt = strExt.ToUpper()
            If strExt = "RTF" Then
                SelectedDocument.SaveFile(currentFile)
            ElseIf strExt = "TXT" Then
                Dim txtWriter As StreamWriter
                txtWriter = New StreamWriter(currentFile)
                txtWriter.Write(SelectedDocument.Text)
                txtWriter.Close()
                SelectedDocument.SelectionStart = 0
                SelectedDocument.SelectionLength = 0
            Else
                CurrentDocument.Save(currentFile)
                SelectedDocument.Modified = False
                SetTitle()
            End If
        End If
        Cursor = Cursors.Default
    End Sub

    Private Sub SaveAsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SaveAsToolStripMenuItem.Click
        If dlgSave.ShowDialog = Windows.Forms.DialogResult.OK Then
            Cursor = Cursors.WaitCursor
            If dlgSave.FileName = "" Then Exit Sub

            CurrentDocument.Save(dlgSave.FileName)
            currentFile = dlgSave.FileName

            SelectedDocument.Modified = False
            SetTitle()
            Cursor = Cursors.Default
        End If
    End Sub

    Private Sub PrintToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PrintToolStripMenuItem.Click
        dlgPrint.Document = pdMain

        If dlgPrint.ShowDialog() = Windows.Forms.DialogResult.OK Then
            pdMain.Print()
        End If
    End Sub

    Private Sub PrintPreviewToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PrintPreviewToolStripMenuItem.Click
        dlgPrintPreview.Document = pdMain
        dlgPrintPreview.ShowDialog()
    End Sub

    Private Sub PageSetupToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PageSetupToolStripMenuItem.Click
        dlgSetup.Document = pdMain
        dlgSetup.ShowDialog()
    End Sub

    Private Sub RTFEditorToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RTFEditorToolStripMenuItem.Click
        frmRTF.Show()
    End Sub

    Private Sub UndoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles UndoToolStripMenuItem.Click
        If SelectedDocument.CanUndo Then SelectedDocument.Undo()
    End Sub

    Private Sub RedoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RedoToolStripMenuItem.Click
        If SelectedDocument.CanRedo Then SelectedDocument.Redo()
    End Sub

    Private Sub CutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CutToolStripMenuItem.Click
        SelectedDocument.Cut()
    End Sub

    Private Sub CopyToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CopyToolStripMenuItem.Click
        SelectedDocument.Copy()
    End Sub

    Private Sub PasteToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PasteToolStripMenuItem.Click
        If Clipboard.ContainsImage Then
            SelectedDocument.InsertImage(Clipboard.GetImage)
        Else
            SelectedDocument.Paste()
        End If
    End Sub

    Private Sub PastePlainToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PastePlainToolStripMenuItem.Click
        Dim df As DataFormats.Format = DataFormats.GetFormat(DataFormats.UnicodeText)
        SelectedDocument.Paste(df)
    End Sub

    Private Sub FindToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FindToolStripMenuItem.Click
        pnlFindReplace.Visible = pnlFindReplace.Visible Xor True
        If pnlFindReplace.Visible = True Then txtFind.Focus()
    End Sub

    Private Sub SelectAllToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SelectAllToolStripMenuItem.Click
        SelectedDocument.SelectAll()
    End Sub

    Private Sub ZoomInToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ZoomInToolStripMenuItem.Click
        If SelectedDocument.ZoomFactor * 2 >= 64 Then
            SelectedDocument.ZoomFactor = 63
        Else
            SelectedDocument.ZoomFactor *= 2
        End If
    End Sub

    Private Sub ZoomOutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ZoomOutToolStripMenuItem.Click
        If SelectedDocument.ZoomFactor \ 2 <= 0.015625 Then
            SelectedDocument.ZoomFactor = 0.015626
        Else
            SelectedDocument.ZoomFactor \= 2
        End If
    End Sub

    Private Sub ZoomToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ZoomToolStripMenuItem.Click
        SelectedDocument.ZoomFactor = 1.0F
    End Sub

    Private Sub EditZoomToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EditZoomToolStripMenuItem.Click
        dlgCustomZoom.ShowDialog()
    End Sub

    Private Sub WordWrapToolStripMenuItem_CheckedChanged(sender As Object, e As EventArgs) Handles WordWrapToolStripMenuItem.CheckedChanged
        SelectedDocument.WordWrap = WordWrapToolStripMenuItem.Checked
    End Sub

    Private Sub CustomSymbolsToolStripMenuItem_Click(sender As Object, e As EventArgs)
        dlgCustomSymbols.ShowDialog()
    End Sub

    Private Sub ImageToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ImageToolStripMenuItem.Click
        If dlgOpenImage.ShowDialog() = DialogResult.OK Then
            Dim strImagePath As String = dlgOpenImage.FileName
            Dim img As Image = Image.FromFile(strImagePath)
            If img.Width * img.Height >= 1024 * 1024 Then
                img = ResizeImage(img, New Size(1024, 1024), True)
            End If
            SelectedDocument.InsertImage(img)
        End If
    End Sub

    Private Sub TextArtToolStripMenuItem_Click(sender As Object, e As EventArgs)

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
            .SelectionCharOffset = 0
        }

        On Error Resume Next
        Dim CurrentPos As Integer = SelectedDocument.SelectionStart
        Dim CurrentLength As Integer = SelectedDocument.SelectionLength

        Dim obj As Object = Clipboard.GetDataObject
        SelectedDocument.SelectAll()
        TempRTF.SelectAll()
        TempRTF.Copy()
        SelectedDocument.Paste()
        Clipboard.SetDataObject(obj)

        SelectedDocument.SelectionStart = CurrentPos
        SelectedDocument.SelectionLength = CurrentLength

        TempRTF.Dispose()
        ResumeLayout()

        SelectedDocument.SelectionAlignment = HorizontalAlignment.Left
    End Sub

    Private Sub EditStyleToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EditStyleToolStripMenuItem.Click
        dlgStyle.ShowDialog()
    End Sub

    Private Sub ApplyStyleToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ApplyStyleToolStripMenuItem.Click
        If SelectedDocument.SelectionLength = 0 Then Exit Sub

        SuspendLayout()
        Dim TempRTF As New ExtendedRichTextBox With {
            .Rtf = SelectedDocument.Rtf,
            .SelectionStart = SelectedDocument.SelectionStart,
            .SelectionLength = SelectedDocument.SelectionLength,
            .SelectionFont = dlgStyle.StyleFont,
            .SelectionColor = dlgStyle.StyleColor,
            .SelectionBackColor = dlgStyle.StyleHighlight,
            .SelectionAlignment = dlgStyle.StyleAlignment,
            .SelectionIndent = dlgStyle.StyleIndent,
            .SelectionCharOffset = dlgStyle.StyleCharOffset
        }

        On Error Resume Next
        Dim CurrentPos As Integer = SelectedDocument.SelectionStart
        Dim CurrentLength As Integer = SelectedDocument.SelectionLength

        Dim obj As Object = Clipboard.GetDataObject
        SelectedDocument.SelectAll()
        TempRTF.SelectAll()
        TempRTF.Copy()
        SelectedDocument.Paste()
        Clipboard.SetDataObject(obj)

        SelectedDocument.SelectionStart = CurrentPos
        SelectedDocument.SelectionLength = CurrentLength

        TempRTF.Dispose()
        ResumeLayout()

        SelectedDocument.SelectionAlignment = dlgStyle.StyleAlignment
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

    Private Sub TextColorToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TextColorToolStripMenuItem.Click
        dlgColor.Color = SelectedDocument.SelectionColor
        If dlgColor.ShowDialog = DialogResult.OK Then
            SelectedDocument.SelectionColor = dlgColor.Color
        End If
    End Sub

    Private Sub HighlightToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles HighlightToolStripMenuItem.Click
        dlgColor.Color = SelectedDocument.SelectionBackColor
        If dlgColor.ShowDialog = DialogResult.OK Then
            SelectedDocument.SelectionBackColor = dlgColor.Color
        End If
    End Sub

    Public Sub AddPageToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AddPageToolStripMenuItem.Click
        SaveTabs()
        dlgAddPage.AddPage = True
        dlgAddPage.DuplicatePage = False
        dlgAddPage.ShowDialog()
    End Sub

    Public Sub RemovePageToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RemovePageToolStripMenuItem.Click
        If CurrentDocument.Pages.Count = 0 Then Exit Sub
        SaveTabs()
        If MessageBox.Show("Are you sure you want to delete this page? This cannot be undone.", "", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning) = Windows.Forms.DialogResult.Yes Then
            CurrentDocument.Pages.RemoveAt(tcNotebook.SelectedIndex)
            CurrentDocument.Modified = True
            UpdateTabs()
        End If
    End Sub

    Public Sub DuplicatePageToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DuplicatePageToolStripMenuItem.Click
        SaveTabs()
        dlgAddPage.DuplicatePage = True
        dlgAddPage.AddPage = False
        dlgAddPage.ShowDialog()
    End Sub

    Public Sub ImportPageToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ImportPageToolStripMenuItem.Click
        If dlgOpenPage.ShowDialog = Windows.Forms.DialogResult.OK Then
            SaveTabs()
            Dim p As New NotebookPage With {
                .Title = dlgOpenPage.FileName.Split("\").GetValue(dlgOpenPage.FileName.Split("\").Count - 1).ToString.Split(".").GetValue(0)
            }

            If dlgOpenPage.FileName = "" Then Exit Sub
            Dim strExt As String
            strExt = Path.GetExtension(dlgOpenPage.FileName)
            strExt = strExt.ToUpper()

            Select Case strExt
                Case ".RTF"
                    Dim txtReader As StreamReader
                    txtReader = New StreamReader(dlgOpenPage.FileName)
                    p.RTF = txtReader.ReadToEnd
                    txtReader.Close()
                Case Else
                    Dim txtReader As StreamReader
                    txtReader = New StreamReader(dlgOpenPage.FileName)
                    Dim R As New RichTextBox With {
                        .Text = txtReader.ReadToEnd
                    }
                    p.RTF = R.Rtf
                    txtReader.Close()
            End Select

            CurrentDocument.Pages.Add(p)
            UpdateTabs()

            tcNotebook.SelectedIndex = CurrentDocument.Pages.Count - 1
            Dim pn As Integer = 0
            For Each pa As NotebookPage In CurrentDocument.Pages
                If p.Title = pa.Title Then
                    If pn = 0 Then
                        pn += 1
                    Else
                        MessageBox.Show("A page already exists with that name.", "", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        dlgAddPage.AddPage = False
                        dlgAddPage.ShowDialog()
                        pn += 1
                    End If
                End If
            Next
        End If
    End Sub

    Public Sub ExportPageToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExportPageToolStripMenuItem.Click
        If dlgSavePage.ShowDialog = Windows.Forms.DialogResult.OK Then
            If dlgSavePage.FileName = "" Then Exit Sub

            Dim strExt As String
            strExt = Path.GetExtension(dlgSavePage.FileName)
            strExt = strExt.ToUpper()

            Select Case strExt
                Case ".RTF"
                    Dim txtWriter As StreamWriter
                    txtWriter = New StreamWriter(dlgSavePage.FileName)
                    txtWriter.Write(SelectedDocument.Rtf)
                    txtWriter.Close()
                    SelectedDocument.SelectionStart = 0
                    SelectedDocument.SelectionLength = 0
                Case Else
                    Dim txtWriter As StreamWriter
                    txtWriter = New StreamWriter(dlgSavePage.FileName)
                    txtWriter.Write(SelectedDocument.Text)
                    txtWriter.Close()
                    SelectedDocument.SelectionStart = 0
                    SelectedDocument.SelectionLength = 0
            End Select

        End If
    End Sub

    Public Sub RenamePageToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RenamePageToolStripMenuItem.Click
        SaveTabs()
        dlgAddPage.AddPage = False
        dlgAddPage.DuplicatePage = False
        dlgAddPage.txtName.Text = CurrentDocument.Pages.Item(tcNotebook.SelectedIndex).Title
        dlgAddPage.CurrentPos = tcNotebook.SelectedIndex
        dlgAddPage.ShowDialog()
    End Sub

    Private Sub UpdateToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles UpdateToolStripMenuItem.Click
        dlgUpdate.SkipFetch = False
        dlgUpdate.TopMost = False
        dlgUpdate.ShowDialog()
    End Sub

    Private Sub SettingsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SettingsToolStripMenuItem.Click
        dlgSettings.ShowDialog()
    End Sub

    Private Sub AboutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AboutToolStripMenuItem.Click
        dlgAbout.ShowDialog()
    End Sub

    Private Sub FontCombo_Click(sender As Object, e As EventArgs)

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
        On Error Resume Next
        DisableFontChange = True
        Dim dlgFont As New FontDialog With {
            .AllowSimulations = True,
            .ShowColor = True,
            .ShowEffects = True,
            .Color = SelectedDocument.SelectionColor,
            .Font = SelectedDocument.SelectionFont
        }
        If dlgFont.ShowDialog() = Windows.Forms.DialogResult.OK Then
            SelectedDocument.SelectionColor = dlgFont.Color
            SelectedDocument.SelectionFont = dlgFont.Font
        End If
        DisableFontChange = False
    End Sub

    Private Sub AlignLeftToolStripButton_Click(sender As Object, e As EventArgs) Handles AlignLeftToolStripButton.Click
        SelectedDocument.SelectionAlignment = HorizontalAlignment.Left
    End Sub

    Private Sub AlignCenterToolStripButton_Click(sender As Object, e As EventArgs) Handles AlignCenterToolStripButton.Click
        SelectedDocument.SelectionAlignment = HorizontalAlignment.Center
    End Sub

    Private Sub AlignRightToolStripButton_Click(sender As Object, e As EventArgs) Handles AlignRightToolStripButton.Click
        SelectedDocument.SelectionAlignment = HorizontalAlignment.Right
    End Sub

    Private Sub IndentToolStripButton_Click(sender As Object, e As EventArgs) Handles IndentToolStripButton.Click
        SelectedDocument.SelectionIndent = IndentToolStripComboBox.SelectedItem
    End Sub

    Private Sub BoldToolStripButton_Click(sender As Object, e As EventArgs) Handles BoldToolStripButton.Click
        ApplyStyle(SelectedDocument, FontStyle.Bold)
    End Sub

    Private Sub ItalicToolStripButton_Click(sender As Object, e As EventArgs) Handles ItalicToolStripButton.Click
        ApplyStyle(SelectedDocument, FontStyle.Italic)
    End Sub

    Private Sub UnderlineToolStripButton_Click(sender As Object, e As EventArgs) Handles UnderlineToolStripButton.Click
        ApplyStyle(SelectedDocument, FontStyle.Underline)
    End Sub

    Private Sub StrikeToolStripButton_Click(sender As Object, e As EventArgs) Handles StrikeToolStripButton.Click
        ApplyStyle(SelectedDocument, FontStyle.Strikeout)
    End Sub

    Private Sub ThemeCombo_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ThemeCombo.SelectedIndexChanged
        If ThemeCombo.SelectedItem.ToString().Equals("Glacier") Then
            SetTheme(New GlacierTheme)
        Else
            SetTheme(New GlacierTheme)
        End If
    End Sub

    Private Sub CustomSymbolsToolStripButton_Click(sender As Object, e As EventArgs)
        CustomSymbolsToolStripMenuItem_Click(Me, e)
    End Sub

    Private Sub ColorPanelToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ColorPanelToolStripMenuItem.Click
        pnlColor.Visible = pnlColor.Visible Xor True
    End Sub

    Private Sub ColorButton_Click(sender As Object, e As EventArgs)
        Dim cButton As StylizedColorButton = CType(sender, StylizedColorButton)

        If rbTextColor.Checked Then
            SelectedDocument.SelectionColor = cButton.Color
        Else
            SelectedDocument.SelectionBackColor = cButton.Color
        End If
    End Sub

    Private Sub ToggleSidebarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ToggleSidebarToolStripMenuItem.Click
        SplitLayoutPanel.Panel2Collapsed = SplitLayoutPanel.Panel2Collapsed Xor True
    End Sub

    Private Sub ToggleCommonToolbarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ToggleCommonToolbarToolStripMenuItem.Click
        FileToolStrip.Visible = FileToolStrip.Visible Xor True
    End Sub

    Private Sub ToogleFormattingToolbarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ToogleFormattingToolbarToolStripMenuItem.Click
        FontToolStrip.Visible = FontToolStrip.Visible Xor True
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

    Private Sub BtnTransparentColor_Click(sender As Object, e As EventArgs) Handles btnTransparentColor.Click
        If rbTextColor.Checked Then
            SelectedDocument.SelectionColor = Color.Transparent
        Else
            SelectedDocument.SelectionBackColor = Color.Transparent
        End If
    End Sub

    Public Sub DictionaryMenuItem_Click(sender As Object, e As EventArgs) Handles DictionaryMenuItem.Click
        frmDictionary.Show()
    End Sub
End Class
