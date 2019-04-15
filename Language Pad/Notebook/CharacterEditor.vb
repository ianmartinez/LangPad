Public Class CharacterEditor
    Public GetCurrentTexbox As Func(Of TextBoxBase)

    Public Shared Sub AddToLocal()
        'If My.Computer.Keyboard.CtrlKeyDown Then
        '    Dim LineList1 As String() = My.Settings.CustomSymbols.Split({Environment.NewLine}, StringSplitOptions.RemoveEmptyEntries)
        '    If LineList1.Contains(Text) Then Exit Sub

        '    My.Settings.CustomSymbols = My.Settings.CustomSymbols & Environment.NewLine & Text

        '    frmMain.CustomLayoutPanel.Controls.Clear()
        '    frmDictionary.CustomLayoutPanel.Controls.Clear()

        '    Dim LineList2 As String() = My.Settings.CustomSymbols.Split({Environment.NewLine}, StringSplitOptions.RemoveEmptyEntries)
        '    For Each IPA As String In LineList2
        '        Dim SymbolButton As New SymbolButton With {
        '            .Text = IPA
        '        }
        '        AddHandler SymbolButton.Click, AddressOf frmMain.InsertIPA
        '        frmMain.CustomLayoutPanel.Controls.Add(SymbolButton)

        '        Dim SymbolButtonDictionary As New SymbolButton With {
        '            .Text = IPA
        '        }
        '        AddHandler SymbolButtonDictionary.Click, AddressOf frmDictionary.InsertIPA
        '        frmDictionary.CustomLayoutPanel.Controls.Add(SymbolButtonDictionary)
        '    Next
        'End If
    End Sub

    Public Sub InsertCharacterButton(ByVal Text As String, ByVal Panel As FlowLayoutPanel)
        Dim SymbolButton As New SymbolButton
        SymbolButton.Text = Text
        AddHandler SymbolButton.Click, AddressOf CharacterButtonClick
        Panel.Controls.Add(SymbolButton)
    End Sub

    Public Sub CharacterButtonClick(sender As Object, e As EventArgs)
        Dim Button As Button = CType(sender, Button)
        If My.Computer.Keyboard.CtrlKeyDown Then Exit Sub
        InsertText(GetCurrentTexbox(), Button.Text)
    End Sub

    Public Sub InsertText(ByVal TextBox As TextBoxBase, ByVal Text As String)
        On Error Resume Next
        Dim CurrentPos As Integer = TextBox.SelectionStart
        Dim obj As Object = Clipboard.GetDataObject
        Clipboard.SetText(Text)
        TextBox.Paste()
        Clipboard.SetDataObject(obj)

        TextBox.Focus()
        TextBox.SelectionStart = CurrentPos + Text.Length
        TextBox.SelectionLength = 0
    End Sub
End Class
