Imports System.IO

Public Class dlgCustomSymbols
    Private Sub OK_Button_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnOK.Click
        Dim CustomTXT As String = ""
        For i = 0 To dgvSymbols.RowCount - 1
            If dgvSymbols.Rows.Item(i).Cells(0).Value = "" Then Continue For
            CustomTXT &= String.Format("{0}{1}", dgvSymbols.Rows.Item(i).Cells(0).Value, Environment.NewLine)
        Next
        My.Settings.CustomSymbols = CustomTXT

        frmMain.charEdit.LocalCharPanel.Controls.Clear()
        frmDictionary.CustomLayoutPanel.Controls.Clear()

        Dim LineList2 As String() = My.Settings.CustomSymbols.Split({Environment.NewLine}, StringSplitOptions.RemoveEmptyEntries)
        For Each IPA As String In LineList2
            frmMain.charEdit.InsertCharacterButton(IPA, frmMain.charEdit.LocalCharPanel)

            Dim SymbolButtonDictionary As New SymbolButton With {
                .Text = IPA
            }
            AddHandler SymbolButtonDictionary.Click, AddressOf frmDictionary.InsertIPA
            frmDictionary.CustomLayoutPanel.Controls.Add(SymbolButtonDictionary)
        Next

        DialogResult = DialogResult.OK
        Close()
    End Sub

    Private Sub Cancel_Button_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnCancel.Click
        DialogResult = DialogResult.Cancel
        Close()
    End Sub

    Private Sub dlgCustomSymbols_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dgvSymbols.Rows.Clear()
        Dim Lines As String() = My.Settings.CustomSymbols.Split({Environment.NewLine}, StringSplitOptions.RemoveEmptyEntries)
        For i = 0 To Lines.Length - 1
            If Lines.GetValue(i) = "" Then Continue For
            dgvSymbols.Rows.Add()
            dgvSymbols.Rows.Item(i).Cells(0).Value = Lines.GetValue(i)
        Next
    End Sub

    Private Sub btnDeleteAll_Click(sender As Object, e As EventArgs) Handles btnDeleteAll.Click
        dgvSymbols.Rows.Clear()
    End Sub

    Private Sub btnOpen_Click(sender As Object, e As EventArgs) Handles btnOpen.Click
        If dlgOpen.ShowDialog = Windows.Forms.DialogResult.OK Then
            My.Settings.CustomSymbols = File.ReadAllText(dlgOpen.FileName)
            dgvSymbols.Rows.Clear()

            Dim Lines As String() = My.Settings.CustomSymbols.Split({Environment.NewLine}, StringSplitOptions.RemoveEmptyEntries)
            For i = 0 To Lines.Length - 1
                If Lines.GetValue(i) = "" Then Continue For
                dgvSymbols.Rows.Add()
                dgvSymbols.Rows.Item(i).Cells(0).Value = Lines.GetValue(i)
            Next
        End If
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        If dlgSave.ShowDialog = Windows.Forms.DialogResult.OK Then
            Dim CustomTXT As String = ""

            For i = 0 To dgvSymbols.RowCount - 1
                If dgvSymbols.Rows.Item(i).Cells(0).Value = "" Then Continue For
                CustomTXT &= String.Format("{0}{1}", dgvSymbols.Rows.Item(i).Cells(0).Value, Environment.NewLine)
            Next

            File.WriteAllText(dlgSave.FileName, CustomTXT)
        End If
    End Sub
End Class
