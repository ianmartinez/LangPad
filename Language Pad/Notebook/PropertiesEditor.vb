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
        If FirstTabUpdate = True Then
            CurrentDocument.Title = txtTitle.Text
        Else
            CurrentDocument.Modified = True
        End If
        frmDictionary.Text = If(txtTitle.Text = "", "Dictionary", "Dictionary - " + txtTitle.Text)
    End Sub

    Private Sub txtAuthor_TextChanged(sender As Object, e As EventArgs) Handles txtAuthor.TextChanged
        If FirstTabUpdate = True Then
            CurrentDocument.Author = txtAuthor.Text
        Else
            CurrentDocument.Modified = True
        End If
    End Sub

    Private Sub txtWebsite_TextChanged(sender As Object, e As EventArgs) Handles txtWebsite.TextChanged
        If FirstTabUpdate = True Then
            CurrentDocument.Website = txtWebsite.Text
        Else
            CurrentDocument.Modified = True
        End If
    End Sub

    Private Sub lbPages_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lbPages.SelectedIndexChanged
        On Error Resume Next
        If frmMain.Moving = False Then
            frmMain.tcNotebook.SelectedIndex = lbPages.SelectedIndex
        Else
            CurrentDocument.Modified = True
        End If
        lbPages.Focus()
    End Sub

    Private Sub txtInfo_TextChanged(sender As Object, e As EventArgs) Handles txtInfo.TextChanged
        If FirstTabUpdate = True Then
            CurrentDocument.Info = txtInfo.Text
        Else
            CurrentDocument.Modified = True
        End If
    End Sub

    Private Sub PageUpToolStripButton_Click(sender As Object, e As EventArgs) Handles PageUpToolStripButton.Click
        frmMain.SaveTabs()

        If lbPages.SelectedIndex > 0 Then
            frmMain.Moving = True
            frmMain.SuspendLayout()
            Dim I = lbPages.SelectedIndex - 1
            CurrentDocument.Pages.Insert(I, CurrentDocument.Pages.Item(lbPages.SelectedIndex))
            CurrentDocument.Pages.RemoveAt(lbPages.SelectedIndex + 1)
            frmMain.UpdateTabs()
            frmMain.Moving = False
            frmMain.ResumeLayout()
            lbPages.SelectedIndex = I
        End If
    End Sub

    Private Sub PageDownToolStripButton_Click(sender As Object, e As EventArgs) Handles PageDownToolStripButton.Click
        frmMain.SaveTabs()

        If lbPages.SelectedIndex < CurrentDocument.Pages.Count - 1 Then
            frmMain.SuspendLayout()
            frmMain.Moving = True
            Dim I = lbPages.SelectedIndex + 2
            CurrentDocument.Pages.Insert(I, CurrentDocument.Pages.Item(lbPages.SelectedIndex))
            CurrentDocument.Pages.RemoveAt(lbPages.SelectedIndex)
            frmMain.UpdateTabs()
            frmMain.Moving = False
            frmMain.ResumeLayout()
            lbPages.SelectedIndex = I - 1
        End If
    End Sub

    Private Sub AddToolStripButton_Click(sender As Object, e As EventArgs) Handles AddToolStripButton.Click
        frmMain.AddPageToolStripMenuItem_Click(Me, e)
    End Sub

    Private Sub RemoveToolStripButton_Click(sender As Object, e As EventArgs) Handles RemoveToolStripButton.Click
        frmMain.RemovePageToolStripMenuItem_Click(Me, e)
    End Sub

    Private Sub DuplicateToolStripButton_Click(sender As Object, e As EventArgs) Handles DuplicateToolStripButton.Click
        frmMain.DuplicatePageToolStripMenuItem_Click(Me, e)
    End Sub

    Private Sub RenameToolStripButton_Click(sender As Object, e As EventArgs) Handles RenameToolStripButton.Click
        frmMain.RenamePageToolStripMenuItem_Click(Me, e)
    End Sub

    Private Sub ImportToolStripButton_Click(sender As Object, e As EventArgs) Handles ImportToolStripButton.Click
        frmMain.ImportPageToolStripMenuItem_Click(Me, e)
    End Sub

    Private Sub ExportToolStripButton_Click(sender As Object, e As EventArgs) Handles ExportToolStripButton.Click
        frmMain.ExportPageToolStripMenuItem_Click(Me, e)
    End Sub

    Private Sub NotebookEditor_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        btnGo.Location = New Point(btnGo.Location.X, txtWebsite.Location.Y)
        btnGo.Height = txtWebsite.Height
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
        frmMain.DictionaryMenuItem_Click(Me, e)
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
        If FirstTabUpdate = True Then
            CurrentDocument.Language = txtLanguage.Text
        Else
            CurrentDocument.Modified = True
        End If
    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub
End Class
