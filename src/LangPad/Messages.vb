Imports LangPadData.NotebookNT
''' <summary>
''' Show standard message boxes used throughout LangPad.
''' </summary>
Module Messages
    Public Function CheckNtVersion(Notebook As NotebookNT) As Boolean
        Dim AllowOpen = True

        If Notebook.NtSpecVersion > NotebookNT.SPEC_VERSION Then
            If Not MessageBox.Show("The notebook file you are trying to open is from a newer version of LangPad than the version you are currently using." +
                                " This can lead to unexpected results. Are you sure you want to continue?", "File from Newer Version", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Exclamation) = DialogResult.Yes Then
                AllowOpen = False
            End If
        End If

        Return AllowOpen
    End Function

    Public Sub ShowNotSupportedFileError(FileName As String)
        MessageBox.Show("Cannot open '" + FileName + "'. It is not supported by LangPad.", "Invalid File", MessageBoxButtons.OK, MessageBoxIcon.Error)
    End Sub

    Public Function ShowModifiedWarning() As DialogResult
        Return MessageBox.Show("Would you like to save the current document?", "Unsaved Document", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning)
    End Function

    Public Sub ShowNotFoundDialog(SearchText)
        MessageBox.Show("'" & SearchText & "' was not found.", "No Matches", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
    End Sub
End Module
