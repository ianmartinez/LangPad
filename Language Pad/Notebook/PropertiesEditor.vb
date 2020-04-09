Imports System.Drawing.Drawing2D
Imports TundraLib
Imports TundraLib.Themes

Public Class PropertiesEditor
    Public Color1 As Color
    Public Color2 As Color
    Public VerticalMenuGradient As Boolean = False

    Public Sub SetTheme(Theme As Theme)
        Color1 = Theme.PanelBack
        Color2 = Theme.PanelBack
        VerticalMenuGradient = Theme.VerticalMenuGradient
        DocumentToolStrip.Renderer = Theme.GetToolStripRenderer()

        Refresh()
    End Sub

    Public Sub SetIcons()
        Dim res As IconResolution = GetIconResolution()

        PageUpToolStripButton.Image = IconManager.Get("go-up", IconSize.Small, res)
        PageDownToolStripButton.Image = IconManager.Get("go-down", IconSize.Small, res)
        AddToolStripButton.Image = IconManager.Get("list-add", IconSize.Small, res)
        RemoveToolStripButton.Image = IconManager.Get("list-remove", IconSize.Small, res)
        DuplicateToolStripButton.Image = IconManager.Get("edit-copy", IconSize.Small, res)
        RenameToolStripButton.Image = IconManager.Get("edit", IconSize.Small, res)
        ImportToolStripButton.Image = IconManager.Get("document-import", IconSize.Small, res)
        ExportToolStripButton.Image = IconManager.Get("document-export", IconSize.Small, res)
        DictionaryToolStripButton.Image = IconManager.Get("dictionary", IconSize.Small, res)
    End Sub

    Private Sub txtTitle_TextChanged(sender As Object, e As EventArgs) Handles txtTitle.TextChanged
        If FirstTabUpdate Then
            CurrentDocument.Title = txtTitle.Text
            CurrentDocument.Modified = True
        End If
        DictionaryForm.Text = If(txtTitle.Text = "", "Dictionary", "Dictionary - " + txtTitle.Text)
    End Sub

    Private Sub txtAuthor_TextChanged(sender As Object, e As EventArgs) Handles txtAuthor.TextChanged
        If FirstTabUpdate Then
            CurrentDocument.Author = txtAuthor.Text
            CurrentDocument.Modified = True
        End If
    End Sub

    Private Sub txtWebsite_TextChanged(sender As Object, e As EventArgs) Handles txtWebsite.TextChanged
        If FirstTabUpdate Then
            CurrentDocument.Website = txtWebsite.Text
            CurrentDocument.Modified = True
        End If
    End Sub

    Private Sub lbPages_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lbPages.SelectedIndexChanged
        On Error Resume Next
        If MainForm.Moving = False Then
            MainForm.tcNotebook.SelectedIndex = lbPages.SelectedIndex
        Else
            CurrentDocument.Modified = True
        End If
        lbPages.Focus()
    End Sub

    Private Sub txtInfo_TextChanged(sender As Object, e As EventArgs) Handles txtInfo.TextChanged
        If FirstTabUpdate Then
            CurrentDocument.Info = txtInfo.Text
            CurrentDocument.Modified = True
        End If
    End Sub

    Private Sub PageUpToolStripButton_Click(sender As Object, e As EventArgs) Handles PageUpToolStripButton.Click
        MainForm.SaveTabs()

        If lbPages.SelectedIndex > 0 Then
            MainForm.Moving = True
            MainForm.SuspendLayout()
            Dim I = lbPages.SelectedIndex - 1
            CurrentDocument.Pages.Insert(I, CurrentDocument.Pages.Item(lbPages.SelectedIndex))
            CurrentDocument.Pages.RemoveAt(lbPages.SelectedIndex + 1)
            MainForm.UpdateTabs()
            MainForm.Moving = False
            MainForm.ResumeLayout()
            lbPages.SelectedIndex = I
        End If
    End Sub

    Private Sub PageDownToolStripButton_Click(sender As Object, e As EventArgs) Handles PageDownToolStripButton.Click
        MainForm.SaveTabs()

        If lbPages.SelectedIndex < CurrentDocument.Pages.Count - 1 Then
            MainForm.SuspendLayout()
            MainForm.Moving = True
            Dim I = lbPages.SelectedIndex + 2
            CurrentDocument.Pages.Insert(I, CurrentDocument.Pages.Item(lbPages.SelectedIndex))
            CurrentDocument.Pages.RemoveAt(lbPages.SelectedIndex)
            MainForm.UpdateTabs()
            MainForm.Moving = False
            MainForm.ResumeLayout()
            lbPages.SelectedIndex = I - 1
        End If
    End Sub

    Private Sub AddToolStripButton_Click(sender As Object, e As EventArgs) Handles AddToolStripButton.Click
        MainForm.AddPageToolStripMenuItem_Click(Me, e)
    End Sub

    Private Sub RemoveToolStripButton_Click(sender As Object, e As EventArgs) Handles RemoveToolStripButton.Click
        MainForm.RemovePageToolStripMenuItem_Click(Me, e)
    End Sub

    Private Sub DuplicateToolStripButton_Click(sender As Object, e As EventArgs) Handles DuplicateToolStripButton.Click
        MainForm.DuplicatePageToolStripMenuItem_Click(Me, e)
    End Sub

    Private Sub RenameToolStripButton_Click(sender As Object, e As EventArgs) Handles RenameToolStripButton.Click
        MainForm.RenamePageToolStripMenuItem_Click(Me, e)
    End Sub

    Private Sub ImportToolStripButton_Click(sender As Object, e As EventArgs) Handles ImportToolStripButton.Click
        MainForm.ImportPageToolStripMenuItem_Click(Me, e)
    End Sub

    Private Sub ExportToolStripButton_Click(sender As Object, e As EventArgs) Handles ExportToolStripButton.Click
        MainForm.ExportPageToolStripMenuItem_Click(Me, e)
    End Sub

    Private Sub NotebookEditor_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        btnGo.Location = New Point(btnGo.Location.X, txtWebsite.Location.Y)
        btnGo.Height = txtWebsite.Height
        SetIcons()
    End Sub

    Private Sub ToolStripContainer1_TopToolStripPanel_Paint(ByVal sender As Object, ByVal e As PaintEventArgs) Handles DocumentToolStripContainer.TopToolStripPanel.Paint,
            DocumentToolStripContainer.BottomToolStripPanel.Paint, DocumentToolStripContainer.LeftToolStripPanel.Paint, DocumentToolStripContainer.RightToolStripPanel.Paint

        Dim g As Graphics = e.Graphics
        Dim rect As New Rectangle(0, 0, DocumentToolStripContainer.Width, Height)
        Dim b As New LinearGradientBrush(rect, Color1, Color2, If(VerticalMenuGradient, LinearGradientMode.Vertical, LinearGradientMode.Horizontal))
        g.FillRectangle(b, rect)
    End Sub

    Private Sub ToolStripContainer1_TopToolStripPanel_SizeChanged(ByVal sender As Object, ByVal e As EventArgs) Handles DocumentToolStripContainer.TopToolStripPanel.SizeChanged,
            DocumentToolStripContainer.BottomToolStripPanel.SizeChanged, DocumentToolStripContainer.LeftToolStripPanel.SizeChanged, DocumentToolStripContainer.RightToolStripPanel.SizeChanged

        DocumentToolStripContainer.Invalidate()
    End Sub

    Private Sub DictionaryToolStripButton_Click(sender As Object, e As EventArgs) Handles DictionaryToolStripButton.Click
        MainForm.DictionaryMenuItem_Click(Me, e)
    End Sub

    Private Sub btnGo_Click(sender As Object, e As EventArgs) Handles btnGo.Click
        If String.IsNullOrWhiteSpace(txtWebsite.Text) Then Exit Sub

        If Not txtWebsite.Text.StartsWith("http://") Then
            Process.Start("http://" & txtWebsite.Text)
        Else
            Process.Start(txtWebsite.Text)
        End If
    End Sub

    Private Sub txtLanguage_TextChanged(sender As Object, e As EventArgs) Handles txtLanguage.TextChanged
        If FirstTabUpdate Then
            CurrentDocument.Language = txtLanguage.Text
            CurrentDocument.Modified = True
        End If
    End Sub

    Private Sub txtTitle_Enter(sender As Object, e As EventArgs) Handles txtTitle.Enter
        MainForm.LastFocused = txtTitle
    End Sub

    Private Sub txtLanguage_Enter(sender As Object, e As EventArgs) Handles txtLanguage.Enter
        MainForm.LastFocused = txtLanguage
    End Sub

    Private Sub txtAuthor_Enter(sender As Object, e As EventArgs) Handles txtAuthor.Enter
        MainForm.LastFocused = txtAuthor
    End Sub

    Private Sub txtWebsite_Enter(sender As Object, e As EventArgs) Handles txtWebsite.Enter
        MainForm.LastFocused = txtWebsite
    End Sub

    Private Sub txtInfo_Enter(sender As Object, e As EventArgs) Handles txtInfo.Enter
        MainForm.LastFocused = txtInfo
    End Sub
End Class
