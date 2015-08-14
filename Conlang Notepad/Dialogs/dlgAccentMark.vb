Imports System.Windows.Forms
Imports Tundra

Public Class dlgAccentMark
    Public Property Character As String
    Private Sub UpdateResult()
        lblResult.Text = txtCharacter.Text & CType(cbAccents.SelectedItem, String)
        If txtCharacter.Text = "" Then lblResult.Text = ""
    End Sub
    Private Sub btnOK_Click(sender As Object, e As EventArgs) Handles btnOK.Click
        Character = lblResult.Text
        Me.DialogResult = Windows.Forms.DialogResult.OK
        Me.Close()
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.DialogResult = Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub

    Private Sub dlgAccentMark_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cbAccents.Items.Clear()
        For Each IPA As KeyValuePair(Of String, String) In ZiaFile.Read(My.Resources.Accents)
            cbAccents.Items.Add(IPA.Value)
        Next

        If Character = "" Then Character = "a"
        txtCharacter.Text = Character
        cbAccents.SelectedIndex = 0
    End Sub

    Private Sub cbAccents_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbAccents.SelectedIndexChanged
        UpdateResult()
    End Sub

    Private Sub txtCharacters_TextChanged(sender As Object, e As EventArgs) Handles txtCharacter.TextChanged
        UpdateResult()
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Dim NewSymbols As String = My.Settings.CustomSymbols
        NewSymbols = NewSymbols & Environment.NewLine & lblResult.Text
        My.Settings.CustomSymbols = NewSymbols

        Dim IPAFont = New Font("Segoe UI", 11, FontStyle.Regular)
        Dim IPAPadding = New Padding(0)
        frmMain.CustomLayoutPanel.Controls.Clear()
        Dim LineList As String() = My.Settings.CustomSymbols.Split({Environment.NewLine}, StringSplitOptions.RemoveEmptyEntries)
        For Each IPA As String In LineList
            Dim IPAButton As New StylizedButton
            IPAButton.Style = My.Resources.KeyStyle
            IPAButton.Padding = IPAPadding
            IPAButton.Font = IPAFont
            IPAButton.AutoSize = True
            IPAButton.MinimumSize = New Size(40, 32)
            IPAButton.Margin = New Padding(1)
            IPAButton.AutoSizeMode = Windows.Forms.AutoSizeMode.GrowAndShrink
            IPAButton.Text = IPA
            AddHandler IPAButton.Click, AddressOf frmMain.InsertIPA
            frmMain.CustomLayoutPanel.Controls.Add(IPAButton)
        Next
    End Sub

    Private Sub btnCopy_Click(sender As Object, e As EventArgs) Handles btnCopy.Click
        Clipboard.SetText(lblResult.Text)
    End Sub
End Class
