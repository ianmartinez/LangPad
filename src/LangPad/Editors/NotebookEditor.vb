Imports System.Drawing.Drawing2D
Imports LangPadUI

Public Class NotebookEditor
    Private Sub NotebookEditor_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        GoButton.Location = New Point(GoButton.Location.X, WebsiteTextBox.Location.Y)
        GoButton.Height = WebsiteTextBox.Height
        SetIcons()
    End Sub

    Public Sub SetIcons()
        Dim Res As IconResolution = GetIconResolution()

        PageUpToolStripButton.Image = IconManager.Get("go-up", IconSize.Small, Res)
        PageDownToolStripButton.Image = IconManager.Get("go-down", IconSize.Small, Res)
        AddToolStripButton.Image = IconManager.Get("list-add", IconSize.Small, Res)
        RemoveToolStripButton.Image = IconManager.Get("list-remove", IconSize.Small, Res)
        DuplicateToolStripButton.Image = IconManager.Get("edit-copy", IconSize.Small, Res)
        RenameToolStripButton.Image = IconManager.Get("edit", IconSize.Small, Res)
        ImportToolStripButton.Image = IconManager.Get("document-import", IconSize.Small, Res)
        ExportToolStripButton.Image = IconManager.Get("document-export", IconSize.Small, Res)
        AdjustMinWidth()
    End Sub

    Public Sub AdjustMinWidth()
        Dim MinWidth = 0
        For Each ToolItem As ToolStripItem In DocumentToolStrip.Items
            MinWidth += (ToolItem.Width + 2)
        Next

        MinimumSize = New Size(MinWidth, MinimumSize.Height)
    End Sub

    Private Sub TitleTextBox_TextChanged(sender As Object, e As EventArgs) Handles TitleTextBox.TextChanged
        If FirstTabUpdate Then
            CurrentNotebook.Title = TitleTextBox.Text
            CurrentNotebook.Modified = True
        End If

        DictionaryForm.Text = If(TitleTextBox.Text = "", "Dictionary", "Dictionary - " + TitleTextBox.Text)
    End Sub

    Private Sub AuthorTextBox_TextChanged(sender As Object, e As EventArgs) Handles AuthorTextBox.TextChanged
        If FirstTabUpdate Then
            CurrentNotebook.Author = AuthorTextBox.Text
            CurrentNotebook.Modified = True
        End If
    End Sub

    Private Sub WebsiteTextBox_TextChanged(sender As Object, e As EventArgs) Handles WebsiteTextBox.TextChanged
        If FirstTabUpdate Then
            CurrentNotebook.Website = WebsiteTextBox.Text
            CurrentNotebook.Modified = True
        End If
    End Sub

    Private Sub PagesListBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles PagesListBox.SelectedIndexChanged
        UserPageSwitch = True
        If Not MovingPage Then
            CurrentPageIndex = PagesListBox.SelectedIndex
        Else
            CurrentNotebook.Modified = True
        End If
        PagesListBox.Focus()
        UserPageSwitch = False
    End Sub

    Private Sub InfoTextBox_TextChanged(sender As Object, e As EventArgs) Handles InfoTextBox.TextChanged
        If FirstTabUpdate Then
            CurrentNotebook.Info = InfoTextBox.Text
            CurrentNotebook.Modified = True
        End If
    End Sub

    Private Sub PageUpToolStripButton_Click(sender As Object, e As EventArgs) Handles PageUpToolStripButton.Click
        MovePageUp(CurrentPageIndex)
    End Sub

    Private Sub PageDownToolStripButton_Click(sender As Object, e As EventArgs) Handles PageDownToolStripButton.Click
        MovePageDown(CurrentPageIndex)
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

    Private Sub GoButton_Click(sender As Object, e As EventArgs) Handles GoButton.Click
        If String.IsNullOrWhiteSpace(WebsiteTextBox.Text) Then Exit Sub

        If Not WebsiteTextBox.Text.StartsWith("http://") Then
            Process.Start("http://" & WebsiteTextBox.Text)
        Else
            Process.Start(WebsiteTextBox.Text)
        End If
    End Sub

    Private Sub LanguageTextBox_TextChanged(sender As Object, e As EventArgs) Handles LanguageTextBox.TextChanged
        If FirstTabUpdate Then
            CurrentNotebook.Language = LanguageTextBox.Text
            CurrentNotebook.Modified = True
        End If
    End Sub

    Private Sub TitleTextBox_Enter(sender As Object, e As EventArgs) Handles TitleTextBox.Enter
        MainForm.LastFocused = TitleTextBox
    End Sub

    Private Sub LanguageTextBox_Enter(sender As Object, e As EventArgs) Handles LanguageTextBox.Enter
        MainForm.LastFocused = LanguageTextBox
    End Sub

    Private Sub AuthorTextBox_Enter(sender As Object, e As EventArgs) Handles AuthorTextBox.Enter
        MainForm.LastFocused = AuthorTextBox
    End Sub

    Private Sub WebsiteTextBox_Enter(sender As Object, e As EventArgs) Handles WebsiteTextBox.Enter
        MainForm.LastFocused = WebsiteTextBox
    End Sub

    Private Sub InfoTextBox_Enter(sender As Object, e As EventArgs) Handles InfoTextBox.Enter
        MainForm.LastFocused = InfoTextBox
    End Sub
End Class