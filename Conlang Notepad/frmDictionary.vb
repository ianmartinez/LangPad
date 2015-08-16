Imports System.ComponentModel
Imports Tundra

Public Class frmDictionary
    Dim c As TextBox
    Dim SelectedCell As DataGridViewCell
    Private Sub StylizedButton3_Click(sender As Object, e As EventArgs) Handles StylizedButton3.Click

    End Sub

    Private Sub StylizedButton4_Click(sender As Object, e As EventArgs) Handles StylizedButton4.Click

    End Sub

    Public Sub InsertText(ByVal Textbox As TextBox, ByVal Text As String)
        '' On Error Resume Next
        Dim CurrentPos As Integer = Textbox.SelectionStart
        Dim obj As Object = Clipboard.GetDataObject
        Clipboard.SetText(Text)
        Textbox.Paste()
        Clipboard.SetDataObject(obj)

        Textbox.Focus()
        Textbox.SelectionStart = CurrentPos + Text.Length
        Textbox.SelectionLength = 0
    End Sub



    Public Sub InsertIPA(sender As Object, e As EventArgs)
        Dim Button As Button = CType(sender, Button)
        dgvDictionary.Focus()
        dgvDictionary.BeginEdit(False)

        InsertText(c, Button.Text)
    End Sub

    Private Sub frmDictionary_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        If My.Settings.ForceSansSerif = True Then
            Me.Font = New Font("Microsoft Sans Serif", "8.25")
        End If

        pnlTop.Height = pnlTabs.Height + pnlHome.Height
    End Sub

    Private Sub dgvDictionary_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvDictionary.CellContentClick

    End Sub

    Private Sub dgvDictionary_EditingControlShowing(sender As Object, e As DataGridViewEditingControlShowingEventArgs) Handles dgvDictionary.EditingControlShowing
        c = e.Control
    End Sub

    Private Sub dgvDictionary_EditModeChanged(sender As Object, e As EventArgs) Handles dgvDictionary.EditModeChanged

    End Sub

    Private Sub dgvDictionary_GiveFeedback(sender As Object, e As GiveFeedbackEventArgs) Handles dgvDictionary.GiveFeedback

    End Sub

    Private Sub dgvDictionary_LostFocus(sender As Object, e As EventArgs) Handles dgvDictionary.LostFocus

    End Sub

    Private Sub dgvDictionary_CellEndEdit(sender As Object, e As DataGridViewCellEventArgs) Handles dgvDictionary.CellEndEdit

    End Sub

    Private Sub frmDictionary_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        e.Cancel = True
        Me.Hide()
    End Sub
End Class