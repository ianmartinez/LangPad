Imports System.Windows.Forms
Imports System.Threading

Public Class dlgWebcam
    Public Property WebcamPicture As Image
    Dim i As Integer = 0
    Dim FlashColor As Color = Color.White
    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOK.Click
        WebcamPicture = wfMain.GetSnapshot(True)
        wfMain.Pause()
        wfMain.DeactivateWebcam()

        Me.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.Close()
    End Sub

    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub

    Private Sub dlgWebcam_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        wfMain.DeactivateWebcam()
    End Sub
    Private Sub TextColor(sender As System.Object, e As EventArgs) Handles ToolStripMenuItem2.Click, ToolStripMenuItem3.Click, ToolStripMenuItem4.Click, ToolStripMenuItem5.Click,
    ToolStripMenuItem6.Click, ToolStripMenuItem7.Click, ToolStripMenuItem8.Click, ToolStripMenuItem9.Click, ToolStripMenuItem10.Click, ToolStripMenuItem11.Click
        Dim t As ToolStripMenuItem = TryCast(sender, ToolStripMenuItem)
        FlashColor = t.BackColor
    End Sub

    Private Sub dlgWebcam_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            wfMain.ActivateWebcam()
            i = 0
        Catch ex As Exception
            MessageBox.Show("Cannot load webcam", "", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Me.Close()
        End Try
    End Sub

    Private Sub btnPlay_Click(sender As Object, e As EventArgs) Handles btnPlay.Click
        wfMain.Play()
    End Sub

    Private Sub btnPause_Click(sender As Object, e As EventArgs) Handles btnPause.Click
        wfMain.Pause()
    End Sub

    Private Sub wfMain_Click(sender As Object, e As EventArgs) Handles wfMain.Click

    End Sub
    Private Sub wfMain_Paint(sender As Object, e As PaintEventArgs) Handles wfMain.Paint

    End Sub

    Private Sub btnFlash_Click(sender As Object, e As EventArgs) Handles btnFlash.Click
        wfMain.Play()
        Thread.Sleep(500)
        Dim frmFlash As New Form
        frmFlash.BackColor = FlashColor
        frmFlash.FormBorderStyle = Windows.Forms.FormBorderStyle.None
        frmFlash.TopMost = True
        frmFlash.WindowState = FormWindowState.Maximized
        frmFlash.Show()
        Thread.Sleep(1000)
        wfMain.Pause()
        Thread.Sleep(100)
        frmFlash.Close()
        frmFlash.Dispose()

    End Sub

    Private Sub wfMain_NewFrame(sender As Object, e As EventArgs)

    End Sub
End Class
