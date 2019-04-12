Imports System.Drawing.Drawing2D
Imports TundraLib.Themes

Public Class frmRTF
    Public Color1 As Color
    Public Color2 As Color
    Public VerticalMenuGradient As Boolean = False

    Public Sub SetTheme(Theme As Theme)
        Color1 = Theme.PanelBack
        Color2 = Theme.PanelBack
        VerticalMenuGradient = Theme.VerticalMenuGradient
        BackColor = Theme.PanelBack

        MainToolStrip.Renderer = Theme.GetToolStripRenderer()

        Refresh()
    End Sub

    Private Sub ToolStripContainer1_ToolStripPanel_Paint(ByVal sender As Object, ByVal e As PaintEventArgs) Handles ToolStripContainer1.TopToolStripPanel.Paint,
        ToolStripContainer1.BottomToolStripPanel.Paint, ToolStripContainer1.LeftToolStripPanel.Paint, ToolStripContainer1.RightToolStripPanel.Paint
        Dim g As Graphics = e.Graphics
        Dim rect As New Rectangle(0, 0, ToolStripContainer1.Width, Height)
        Dim b As New LinearGradientBrush(rect, Color1, Color2, If(VerticalMenuGradient, LinearGradientMode.Vertical, LinearGradientMode.Horizontal))
        g.FillRectangle(b, rect)
    End Sub

    Private Sub ToolStripContainer1_ToolStripPanel_SizeChanged(ByVal sender As Object, ByVal e As EventArgs) Handles ToolStripContainer1.TopToolStripPanel.SizeChanged,
        ToolStripContainer1.BottomToolStripPanel.SizeChanged, ToolStripContainer1.LeftToolStripPanel.SizeChanged, ToolStripContainer1.RightToolStripPanel.SizeChanged
        ToolStripContainer1.Invalidate()
    End Sub

    Private Sub frmRTF_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtRTF.Text = frmMain.SelectedDocument.Rtf
    End Sub

    Private Sub UndoToolStripButton_Click(sender As Object, e As EventArgs) Handles UndoToolStripButton.Click
        On Error Resume Next
        txtRTF.Undo()
    End Sub

    Private Sub RedoToolStripButton_Click(sender As Object, e As EventArgs) Handles RedoToolStripButton.Click
        On Error Resume Next
        txtRTF.Redo()
    End Sub

    Private Sub CutToolStripButton_Click(sender As Object, e As EventArgs) Handles CutToolStripButton.Click
        txtRTF.Cut()
    End Sub

    Private Sub CopyToolStripButton_Click(sender As Object, e As EventArgs) Handles CopyToolStripButton.Click
        txtRTF.Copy()
    End Sub

    Private Sub PasteToolStripButton_Click(sender As Object, e As EventArgs) Handles PasteToolStripButton.Click
        Dim df As DataFormats.Format = DataFormats.GetFormat(DataFormats.UnicodeText)
        txtRTF.Paste(df)
    End Sub

    Private Sub RefreshToolStripButton_Click(sender As Object, e As EventArgs) Handles RefreshToolStripButton.Click
        On Error Resume Next

        frmMain.SelectedDocument.Rtf = txtRTF.Text
        txtRTF.Text = frmMain.SelectedDocument.Rtf
    End Sub
End Class