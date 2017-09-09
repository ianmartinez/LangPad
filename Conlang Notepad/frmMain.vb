Imports Tundra
Imports System.Drawing.Drawing2D
Imports System.IO

Public Class frmMain
    Private dlgColor As New ColorDialog
    Public Event EditText()
    Public Modified As Boolean = False
    Private currentFile As String
    Private checkPrint As Integer
    Public ReadOnly AssociatedRichTextBox As RichTextBox = Me.SelectedDocument
    Public Title As String
    Public rtbList As New List(Of ExtendedRichTextBox)
    Public WithEvents SelectedDocument As New Tundra.ExtendedRichTextBox
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
        NotebookEditor1.SuspendLayout()
        NotebookEditor1.lbPages.Items.Clear()

        For Each p As NotebookPage In CurrentDocument.Pages
            Dim Tab As New TabPage
            Tab.Text = p.Title

            Dim rtbDoc As New ExtendedRichTextBox
            rtbDoc.Rtf = p.RTF
            rtbDoc.Dock = DockStyle.Fill
            rtbDoc.ScrollBars = RichTextBoxScrollBars.Both
            rtbDoc.BorderStyle = BorderStyle.None
            rtbDoc.ContextMenuStrip = cmsMain
            rtbDoc.HideSelection = False
            AddHandler rtbDoc.TextChanged, AddressOf ModifiedHandler

            Tab.Controls.Add(rtbDoc)
            tcNotebook.TabPages.Add(Tab)

            NotebookEditor1.lbPages.Items.Add(p.Title)

            rtbList.Add(rtbDoc)
        Next



        tcNotebook.SelectedIndex = 0
        SelectedDocument = rtbList.Item(0)
        ResumeLayout()
        NotebookEditor1.ResumeLayout()

        NotebookEditor1.txtTitle.Text = CurrentDocument.Title
        NotebookEditor1.txtAuthor.Text = CurrentDocument.Author
        NotebookEditor1.txtWebsite.Text = CurrentDocument.Website
        NotebookEditor1.txtInfo.Text = CurrentDocument.Info
        NotebookEditor1.cbEmbed.Checked = CurrentDocument.EmbedSymbols

        NotebookEditor1.lbPages.SelectedIndex = 0
        FirstTabUpdate = True
    End Sub

    Public Sub ModifiedHandler(sender As Object, e As EventArgs)
        Modified = True
    End Sub

    Public Sub InsertImageHandler(sender As Object, e As EventArgs)
        SelectedDocument.InsertImage(CType(sender, Tundra.StylizedButton).Image.Clone)
    End Sub

    Public Function ModifiedWarning() As DialogResult
        Return MessageBox.Show("Would you like to save the current document?", "Unsaved Document", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning)
    End Function

    Public Sub SetTitle()
        If currentFile = "" Then
            Me.Text = Title
        Else
            Dim FileName As String = currentFile.Split("\").GetValue(currentFile.Split("\").Count - 1)
            Me.Text = Title & " - " & FileName
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

    Private Sub PrintDocument1_BeginPrint(ByVal sender As Object, ByVal e As System.Drawing.Printing.PrintEventArgs) Handles pdMain.BeginPrint
        checkPrint = 0
    End Sub

    Private Sub pdMain_PrintPage(ByVal sender As Object, ByVal e As System.Drawing.Printing.PrintPageEventArgs) Handles pdMain.PrintPage
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
    Public Sub InsertText(ByVal RichTextBox As RichTextBox, ByVal Text As String)
        On Error Resume Next
        Dim CurrentPos As Integer = RichTextBox.SelectionStart
        Dim obj As Object = Clipboard.GetDataObject
        Clipboard.SetText(Text)
        RichTextBox.Paste()
        Clipboard.SetDataObject(obj)

        RichTextBox.Focus()
        RichTextBox.SelectionStart = CurrentPos + Text.Length
        RichTextBox.SelectionLength = 0
    End Sub

    Private Sub SelectedDocument_LinkClicked(sender As Object, e As LinkClickedEventArgs) Handles SelectedDocument.LinkClicked
        Dim Link As String = e.LinkText.Split("#").GetValue(e.LinkText.Split("#").Count - 1)
        If Not Link.StartsWith("http://") Then Link = "http://" & Link
        Process.Start(Link)
    End Sub


    Private Sub SelectedDocument_TextChanged(sender As System.Object, e As System.EventArgs) Handles SelectedDocument.TextChanged
        RaiseEvent EditText()
        ' lblCharCount.Text = "Character Count: " & SelectedDocument.TextLength
        ' lblWordCount.Text = "Word Count: " & WordCount(SelectedDocument.Text)
        frmRTF.txtRTF.Text = SelectedDocument.Rtf
    End Sub

    Private Sub BulletToolStripButton_ButtonClick(sender As System.Object, e As System.EventArgs)
        SelectedDocument.BulletIndent = 10
        SelectedDocument.SelectionBullet = True
    End Sub

    Private Sub frmMain_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        If Modified = True Then
            Dim Mode = ModifiedWarning()
            If Mode = DialogResult.Yes Then
                SaveToolStripMenuItem_Click(Me, e)
            ElseIf Mode = Windows.Forms.DialogResult.Cancel Then
                e.Cancel = True
            End If
        End If
    End Sub

    Private Sub InsertImage(sender As Object, e As EventArgs)
        SelectedDocument.InsertImage(CType(sender, Tundra.StylizedButton).Image)
    End Sub

    Private Sub ApplyStyle(ByVal rtb As ExtendedRichTextBox, ByVal FontStyle As FontStyle)
        SuspendLayout()
        Dim TempRTF As New ExtendedRichTextBox
        TempRTF.Rtf = rtb.Rtf
        TempRTF.SelectionStart = rtb.SelectionStart
        TempRTF.SelectionLength = rtb.SelectionLength


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

    Private Sub ApplyFontChange(ByVal rtb As ExtendedRichTextBox, ByVal Font As Font)
        SuspendLayout()
        Dim TempRTF As New ExtendedRichTextBox
        TempRTF.Rtf = rtb.Rtf
        TempRTF.SelectionStart = rtb.SelectionStart
        TempRTF.SelectionLength = rtb.SelectionLength

        If TempRTF.SelectionLength > 0 Then
            Dim Start As Integer = TempRTF.SelectionStart
            Dim Ending As Integer = TempRTF.SelectionLength + Start - 1
            For i = Start To Ending
                TempRTF.SelectionStart = i
                TempRTF.SelectionLength = 1
                TempRTF.SelectionFont = New Font(Font, TempRTF.SelectionFont.Style)
            Next
            TempRTF.SelectionStart = Start
            TempRTF.SelectionLength = Ending - Start + 1
        Else
            TempRTF.SelectionFont = New Font(Font, TempRTF.SelectionFont.Style)
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

    Private Sub ApplySizeChange(ByVal rtb As ExtendedRichTextBox, ByVal Size As Integer)
        SuspendLayout()
        Dim TempRTF As New ExtendedRichTextBox
        TempRTF.Rtf = rtb.Rtf
        TempRTF.SelectionStart = rtb.SelectionStart
        TempRTF.SelectionLength = rtb.SelectionLength

        If TempRTF.SelectionLength > 0 Then
            Dim Start As Integer = TempRTF.SelectionStart
            Dim Ending As Integer = TempRTF.SelectionLength + Start - 1
            For i = Start To Ending
                TempRTF.SelectionStart = i
                TempRTF.SelectionLength = 1
                TempRTF.SelectionFont = New Font(TempRTF.SelectionFont.FontFamily, Size, TempRTF.SelectionFont.Style)
            Next
            TempRTF.SelectionStart = Start
            TempRTF.SelectionLength = Ending - Start + 1
        Else
            TempRTF.SelectionFont = New Font(TempRTF.SelectionFont.FontFamily, Size, TempRTF.SelectionFont.Style)
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

    Private Sub RichTextEditor_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        On Error Resume Next
        Me.Text = LangPadVersion

        MainMenu.Renderer = New clsMenuRenderer
        FileToolStrip.Renderer = New clsToolstripRenderer
        FontToolStrip.Renderer = New clsToolstripRenderer
        ParagraphToolStrip.Renderer = New clsToolstripRenderer

        Title = Me.Text
        cmsMain.ImageScalingSize = New Size(16, 16)

        Dim rectF As New RectangleF(10, 10, 500, 500)
        Dim solidBrush As New SolidBrush(Color.Black)

        Dim family As FontFamily
        For Each family In FontFamily.Families
            FontCombo.Items.Add(family.Name)
        Next family

        For fontSize As Integer = 2 To 256
            FontSizeCombo.Items.Add(fontSize)
        Next

        FontCombo.SelectedItem = "Calibri"

        SplitContainer1.Panel1Collapsed = True

        If My.Application.CommandLineArgs.Count > 0 Then
            If File.Exists(My.Application.CommandLineArgs(0)) Then
                Dim FileName As String = My.Application.CommandLineArgs(0).Split("\").GetValue(My.Application.CommandLineArgs(0).Split("\").Count - 1)
                Dim FileEXT As String = FileName.Split(".").GetValue(1).ToString.ToLower
                CurrentDocument.Pages.Clear()

                If FileEXT = "rtf" Then
                    Dim p As New NotebookPage
                    p.Title = "Untitled"
                    Dim txtReader As System.IO.StreamReader
                    txtReader = New System.IO.StreamReader(My.Application.CommandLineArgs(0))
                    p.RTF = txtReader.ReadToEnd
                    txtReader.Close()

                    CurrentDocument.Pages.Add(p)
                ElseIf FileEXT = "txt" Then
                    Dim p As New NotebookPage
                    p.Title = "Untitled"
                    Dim txtReader As System.IO.StreamReader
                    txtReader = New System.IO.StreamReader(My.Application.CommandLineArgs(0))
                    p.RTF = txtReader.ReadToEnd
                    txtReader.Close()

                    CurrentDocument.Pages.Add(p)
                Else
                    CurrentDocument.Open(My.Application.CommandLineArgs(0))
                End If

                currentFile = My.Application.CommandLineArgs(0)
            End If
        End If

        If CurrentDocument.Pages.Count = 0 Then
            Dim p As New NotebookPage
            p.Title = "Untitled"
            CurrentDocument.Pages.Add(p)
        End If

        SetTitle()

        Initialized = True
        UpdateTabs()

        SplitContainer2.Panel2Collapsed = False
        SelectedDocument_TextChanged(Me, e)

        If dlgUpdate.NewestVersion > CurrentVersion Then
            dlgUpdate.SkipFetch = True
            dlgUpdate.TopMost = True
            dlgUpdate.Show()
            dlgUpdate.BringToFront()
        End If

        Modified = False
        KeyPreview = True

    End Sub

    Private Sub ToolStripContainer1_TopToolStripPanel_Paint(ByVal sender As System.Object, ByVal e As PaintEventArgs) Handles ToolStripContainer1.TopToolStripPanel.Paint
        Dim g As Graphics = e.Graphics
        Dim rect As New Rectangle(0, 0, ToolStripContainer1.Width, Me.Height)
        Dim b As New LinearGradientBrush(rect, clrHorBG_GrayBlue, clrHorBG_White, LinearGradientMode.Horizontal)
        g.FillRectangle(b, rect)
    End Sub

    Private Sub ToolStripContainer1_TopToolStripPanel_SizeChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripContainer1.TopToolStripPanel.SizeChanged
        ToolStripContainer1.Invalidate()
    End Sub

    Public Sub InsertIPA(sender As Object, e As EventArgs)
        Dim Button As Button = CType(sender, Button)
        If My.Computer.Keyboard.CtrlKeyDown Then Exit Sub
        InsertText(SelectedDocument, Button.Text)
    End Sub

    Private Sub cbFont_SelectedIndexChanged(sender As Object, e As EventArgs) Handles FontCombo.SelectedIndexChanged
        On Error Resume Next
        If DisableFontChange = True Then Exit Sub
        Dim NewFont As Font = New Font(FontCombo.SelectedItem.ToString, Integer.Parse(FontSizeCombo.SelectedText))
        If Not SelectedDocument.SelectionFont Is Nothing Then
            If New FontFamily(FontCombo.SelectedItem.ToString).IsStyleAvailable(FontStyle.Regular) = False Then
                If New FontFamily(FontCombo.SelectedItem.ToString).IsStyleAvailable(FontStyle.Bold) = True Then
                    NewFont = New Font(FontCombo.SelectedItem.ToString, SelectedDocument.SelectionFont.Size, FontStyle.Bold)
                ElseIf New FontFamily(FontCombo.SelectedItem.ToString).IsStyleAvailable(FontStyle.Italic) = True Then
                    NewFont = New Font(FontCombo.SelectedItem.ToString, SelectedDocument.SelectionFont.Size, FontStyle.Italic)
                ElseIf New FontFamily(FontCombo.SelectedItem.ToString).IsStyleAvailable(FontStyle.Strikeout) = True Then
                    NewFont = New Font(FontCombo.SelectedItem.ToString, SelectedDocument.SelectionFont.Size, FontStyle.Strikeout)
                ElseIf New FontFamily(FontCombo.SelectedItem.ToString).IsStyleAvailable(FontStyle.Underline) = True Then
                    NewFont = New Font(FontCombo.SelectedItem.ToString, SelectedDocument.SelectionFont.Size, FontStyle.Underline)
                Else
                    NewFont = New Font(FontCombo.SelectedItem.ToString, SelectedDocument.SelectionFont.Size, SelectedDocument.SelectionFont.Style)
                End If
            Else
                NewFont = New Font(FontCombo.SelectedItem.ToString, SelectedDocument.SelectionFont.Size, SelectedDocument.SelectionFont.Style)
            End If
        End If

        ApplyFontChange(SelectedDocument, NewFont)
    End Sub

    Private Sub btnBold_Click(sender As Object, e As EventArgs)
        ApplyStyle(SelectedDocument, FontStyle.Bold)

    End Sub

    Private Sub btnItalic_Click(sender As Object, e As EventArgs)
        ApplyStyle(SelectedDocument, FontStyle.Italic)
    End Sub

    Private Sub btnUnderline_Click(sender As Object, e As EventArgs)
        ApplyStyle(SelectedDocument, FontStyle.Underline)
    End Sub

    Private Sub btnStrikethrough_Click(sender As Object, e As EventArgs)
        ApplyStyle(SelectedDocument, FontStyle.Strikeout)
    End Sub

    Private Sub nudSize_ValueChanged(sender As Object, e As EventArgs)
        If DisableFontChange = True Then Exit Sub

        ApplySizeChange(SelectedDocument, Integer.Parse(FontSizeCombo.SelectedText))
    End Sub

    Private Sub btnIndent_Click(sender As Object, e As EventArgs)
        'SelectedDocument.SelectionIndent = nudIndent.Value
    End Sub

    Private Sub btnLeft_Click(sender As Object, e As EventArgs)
        SelectedDocument.SelectionAlignment = HorizontalAlignment.Left
    End Sub

    Private Sub btnCenter_Click(sender As Object, e As EventArgs)
        SelectedDocument.SelectionAlignment = HorizontalAlignment.Center
    End Sub

    Private Sub btnRight_Click(sender As Object, e As EventArgs)
        SelectedDocument.SelectionAlignment = HorizontalAlignment.Right
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
        CopyContextMenuItem_Click(Me, e)
    End Sub

    Private Sub PasteContextMenuItem_Click(sender As Object, e As EventArgs) Handles PasteContextMenuItem.Click
        PasteContextMenuItem_Click(Me, e)
    End Sub

    Private Sub CutContextMenuItem_Click(sender As Object, e As EventArgs) Handles CutContextMenuItem.Click
        CutContextMenuItem_Click(Me, e)
    End Sub

    Private Sub SelectAllContextMenuItem_Click(sender As Object, e As EventArgs) Handles SelectAllContextMenuItem.Click
        SelectAllContextMenuItem_Click(Me, e)
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
            NotebookEditor1.lbPages.SelectedIndex = tcNotebook.SelectedIndex
            frmRTF.txtRTF.Text = SelectedDocument.Rtf

            SelectedDocument_TextChanged(Me, e)
        End If
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs)
        SplitContainer2.Panel2Collapsed = True
    End Sub

    Private Sub btnNotebookEditor_Click(sender As Object, e As EventArgs)
        SplitContainer2.Panel2Collapsed = False
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
            btnBold_Click(Me, Nothing)
        ElseIf e.Control And e.KeyCode.ToString = "U" Then
            btnUnderline_Click(Me, Nothing)
        ElseIf e.Control And e.KeyCode.ToString = "I" Then
            btnItalic_Click(Me, Nothing)

            'The richtextbox wants to insent a tab here, so:
            e.Handled = True
            e.SuppressKeyPress = True
        ElseIf e.Control And e.KeyCode.ToString = "M" Then
            btnStrikethrough_Click(Me, Nothing)
        ElseIf e.Control And e.KeyCode.ToString = "F" Then
            FindToolStripMenuItem_Click(Me, Nothing)
        ElseIf e.Control And e.KeyCode.ToString = "L" Then
            btnLeft_Click(Me, Nothing)
        ElseIf e.Control And e.KeyCode.ToString = "E" Then
            btnCenter_Click(Me, Nothing)
        ElseIf e.Control And e.KeyCode.ToString = "R" Then
            btnRight_Click(Me, Nothing)
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

        CurrentDocument = New NotebookFile
        Dim p As New NotebookPage
        p.Title = "Untitled"
        CurrentDocument.Pages.Add(p)

        UpdateTabs()
        currentFile = ""
        SetTitle()
    End Sub

    Private Sub OpenToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OpenToolStripMenuItem.Click
        If SelectedDocument.Modified Then
            Dim Mode = ModifiedWarning()
            If Mode = DialogResult.Yes Then
                SaveToolStripMenuItem_Click(Me, e)
            ElseIf Mode = Windows.Forms.DialogResult.Cancel Then
                Exit Sub
            Else

            End If
        End If

        If dlgOpen.ShowDialog = Windows.Forms.DialogResult.OK Then
            If dlgOpen.FileName = "" Then Exit Sub
            CurrentDocument.Open(dlgOpen.FileName)
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
            Me.Cursor = Cursors.WaitCursor
            Dim strExt As String
            strExt = System.IO.Path.GetExtension(currentFile)
            strExt = strExt.ToUpper()
            If strExt = "RTF" Then
                SelectedDocument.SaveFile(currentFile)
            ElseIf strExt = "TXT" Then
                Dim txtWriter As System.IO.StreamWriter
                txtWriter = New System.IO.StreamWriter(currentFile)
                txtWriter.Write(SelectedDocument.Text)
                txtWriter.Close()
                txtWriter = Nothing
                SelectedDocument.SelectionStart = 0
                SelectedDocument.SelectionLength = 0
            Else
                CurrentDocument.Save(currentFile)
                SelectedDocument.Modified = False
                SetTitle()
            End If
        End If
        Me.Cursor = Cursors.Default
    End Sub

    Private Sub SaveAsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SaveAsToolStripMenuItem.Click
        If dlgSave.ShowDialog = Windows.Forms.DialogResult.OK Then
            Me.Cursor = Cursors.WaitCursor
            If dlgSave.FileName = "" Then Exit Sub

            CurrentDocument.Save(dlgSave.FileName)
            currentFile = dlgSave.FileName

            SelectedDocument.Modified = False
            SetTitle()
            Me.Cursor = Cursors.Default
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

    Private Sub SymbolsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SymbolsToolStripMenuItem.Click
        SplitContainer1.Panel1Collapsed = SplitContainer1.Panel1Collapsed Xor True
    End Sub

    Private Sub CustomSymbolsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CustomSymbolsToolStripMenuItem.Click
        dlgCustomSymbols.ShowDialog()
    End Sub

    Private Sub AccentMarkToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AccentMarkToolStripMenuItem.Click
        If SelectedDocument.SelectionLength > 0 Then
            dlgAccentMark.Character = SelectedDocument.SelectedText
        Else
            dlgAccentMark.Character = ""
        End If
        If dlgAccentMark.ShowDialog = DialogResult.OK Then
            InsertText(SelectedDocument, dlgAccentMark.Character)
            dlgAccentMark.Character = ""
        End If
    End Sub

    Public Sub DictionaryToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DictionaryToolStripMenuItem.Click
        frmDictionary.Show()
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

    Private Sub TextArtToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TextArtToolStripMenuItem.Click
        dlgTextArt.txtText.Text = SelectedDocument.SelectedText
        dlgTextArt.ShowDialog()
    End Sub

    Private Sub TableToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TableToolStripMenuItem.Click
        dlgTable.ShowDialog()
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
        Dim TempRTF As New ExtendedRichTextBox
        TempRTF.Rtf = SelectedDocument.Rtf
        TempRTF.SelectionStart = SelectedDocument.SelectionStart
        TempRTF.SelectionLength = SelectedDocument.SelectionLength

        TempRTF.SelectionFont = New Font("Calibri", 11)
        TempRTF.SelectionColor = Color.Black
        TempRTF.SelectionBackColor = Color.White
        TempRTF.SelectionAlignment = HorizontalAlignment.Left
        TempRTF.SelectionIndent = 0
        TempRTF.SelectionCharOffset = 0

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
        Dim TempRTF As New ExtendedRichTextBox
        TempRTF.Rtf = SelectedDocument.Rtf
        TempRTF.SelectionStart = SelectedDocument.SelectionStart
        TempRTF.SelectionLength = SelectedDocument.SelectionLength

        TempRTF.SelectionFont = dlgStyle.StyleFont
        TempRTF.SelectionColor = dlgStyle.StyleColor
        TempRTF.SelectionBackColor = dlgStyle.StyleHighlight
        TempRTF.SelectionAlignment = dlgStyle.StyleAlignment
        TempRTF.SelectionIndent = dlgStyle.StyleIndent
        TempRTF.SelectionCharOffset = dlgStyle.StyleCharOffset

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
            Modified = True
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
            Dim p As New NotebookPage
            p.Title = dlgOpenPage.FileName.Split("\").GetValue(dlgOpenPage.FileName.Split("\").Count - 1).ToString.Split(".").GetValue(0)

            If dlgOpenPage.FileName = "" Then Exit Sub
            Dim strExt As String
            strExt = System.IO.Path.GetExtension(dlgOpenPage.FileName)
            strExt = strExt.ToUpper()

            Select Case strExt
                Case ".RTF"
                    Dim txtReader As System.IO.StreamReader
                    txtReader = New System.IO.StreamReader(dlgOpenPage.FileName)
                    p.RTF = txtReader.ReadToEnd
                    txtReader.Close()
                    txtReader = Nothing
                Case Else
                    Dim txtReader As System.IO.StreamReader
                    txtReader = New System.IO.StreamReader(dlgOpenPage.FileName)
                    Dim R As New RichTextBox
                    R.Text = txtReader.ReadToEnd
                    p.RTF = R.Rtf
                    txtReader.Close()
                    txtReader = Nothing
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
            strExt = System.IO.Path.GetExtension(dlgSavePage.FileName)
            strExt = strExt.ToUpper()

            Select Case strExt
                Case ".RTF"
                    Dim txtWriter As System.IO.StreamWriter
                    txtWriter = New System.IO.StreamWriter(dlgSavePage.FileName)
                    txtWriter.Write(SelectedDocument.Rtf)
                    txtWriter.Close()
                    txtWriter = Nothing
                    SelectedDocument.SelectionStart = 0
                    SelectedDocument.SelectionLength = 0
                Case Else
                    Dim txtWriter As System.IO.StreamWriter
                    txtWriter = New System.IO.StreamWriter(dlgSavePage.FileName)
                    txtWriter.Write(SelectedDocument.Text)
                    txtWriter.Close()
                    txtWriter = Nothing
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

    Private Sub FontCombo_Click(sender As Object, e As EventArgs) Handles FontCombo.Click

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
        Dim dlgFont As New FontDialog
        dlgFont.AllowSimulations = True
        dlgFont.ShowColor = True
        dlgFont.ShowEffects = True

        dlgFont.Color = SelectedDocument.SelectionColor
        dlgFont.Font = SelectedDocument.SelectionFont
        If dlgFont.ShowDialog() = Windows.Forms.DialogResult.OK Then
            SelectedDocument.SelectionColor = dlgFont.Color
            SelectedDocument.SelectionFont = dlgFont.Font

            FontCombo.SelectedItem = dlgFont.Font.FontFamily.Name
            FontSizeCombo.SelectedText = dlgFont.Font.Size
        End If
        DisableFontChange = False
    End Sub
End Class
