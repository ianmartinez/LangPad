Imports System.Drawing.Drawing2D
Imports LangPadUI
Imports LangPadUI.Themes

Public Class RtfEditorForm
    Public Color1 As Color
    Public Color2 As Color
    Public VerticalMenuGradient As Boolean = False

    Private Sub RtfEditorForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        RtfCodeTextBox.Text = MainForm.CurrentRtb.Rtf
        SetIcons()
    End Sub

    Public Sub SetTheme(Theme As OldTheme)
        Color1 = Theme.PanelBack
        Color2 = Theme.PanelBack
        VerticalMenuGradient = Theme.VerticalMenuGradient
        BackColor = Theme.PanelBack
        MainToolStrip.Renderer = Theme.GetToolStripRenderer()

        Refresh()
    End Sub

    Public Sub SetIcons()
        Dim Res As IconResolution = GetIconResolution()

        UndoToolStripButton.Image = IconManager.Get("edit-undo", IconSize.Large, Res)
        RedoToolStripButton.Image = IconManager.Get("edit-redo", IconSize.Large, Res)
        CutToolStripButton.Image = IconManager.Get("edit-cut", IconSize.Large, Res)
        CopyToolStripButton.Image = IconManager.Get("edit-copy", IconSize.Large, Res)
        PasteToolStripButton.Image = IconManager.Get("edit-paste", IconSize.Large, Res)
        RefreshToolStripButton.Image = IconManager.Get("refresh", IconSize.Large, Res)
    End Sub

    Private Sub MainToolStripContainer_ToolStripPanel_Paint(ByVal sender As Object, ByVal e As PaintEventArgs) Handles MainToolStripContainer.TopToolStripPanel.Paint,
        MainToolStripContainer.BottomToolStripPanel.Paint, MainToolStripContainer.LeftToolStripPanel.Paint, MainToolStripContainer.RightToolStripPanel.Paint
        Dim g As Graphics = e.Graphics
        Dim rect As New Rectangle(0, 0, MainToolStripContainer.Width, Height)
        Dim b As New LinearGradientBrush(rect, Color1, Color2, If(VerticalMenuGradient, LinearGradientMode.Vertical, LinearGradientMode.Horizontal))
        g.FillRectangle(b, rect)
    End Sub

    Private Sub MainToolStripContainer_ToolStripPanel_SizeChanged(ByVal sender As Object, ByVal e As EventArgs) Handles MainToolStripContainer.TopToolStripPanel.SizeChanged,
        MainToolStripContainer.BottomToolStripPanel.SizeChanged, MainToolStripContainer.LeftToolStripPanel.SizeChanged, MainToolStripContainer.RightToolStripPanel.SizeChanged
        MainToolStripContainer.Invalidate()
    End Sub

    Private Sub UndoToolStripButton_Click(sender As Object, e As EventArgs) Handles UndoToolStripButton.Click
        On Error Resume Next
        RtfCodeTextBox.Undo()
    End Sub

    Private Sub RedoToolStripButton_Click(sender As Object, e As EventArgs) Handles RedoToolStripButton.Click
        On Error Resume Next
        RtfCodeTextBox.Redo()
    End Sub

    Private Sub CutToolStripButton_Click(sender As Object, e As EventArgs) Handles CutToolStripButton.Click
        RtfCodeTextBox.Cut()
    End Sub

    Private Sub CopyToolStripButton_Click(sender As Object, e As EventArgs) Handles CopyToolStripButton.Click
        RtfCodeTextBox.Copy()
    End Sub

    Private Sub PasteToolStripButton_Click(sender As Object, e As EventArgs) Handles PasteToolStripButton.Click
        RtfCodeTextBox.Paste(DataFormats.GetFormat(DataFormats.UnicodeText))
    End Sub

    Private Sub RefreshToolStripButton_Click(sender As Object, e As EventArgs) Handles RefreshToolStripButton.Click
        On Error Resume Next

        MainForm.CurrentRtb.Rtf = RtfCodeTextBox.Text
        RtfCodeTextBox.Text = MainForm.CurrentRtb.Rtf
    End Sub
End Class