﻿Public Class dlgAbout

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOK.Click
        Me.Close()
    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TextBox2.TextChanged

    End Sub

    Private Sub btnGitHub_Click(sender As Object, e As EventArgs)
        Process.Start("https://github.com/ianmartinez/Language-Pad")
    End Sub

    Private Sub dlgAbout_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblLanguagePad.Text = LangPadVersion
    End Sub

    Private Sub btnCheckUpdates_Click(sender As Object, e As EventArgs)
        dlgUpdate.SkipFetch = False
        dlgUpdate.TopMost = False
        dlgUpdate.ShowDialog()
    End Sub
End Class