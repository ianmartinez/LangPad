''' <summary>
''' Handles the insertion and deletion of characters in
''' text boxes.
''' </summary>
Module CharacterInsertion
    ''' <summary>
    ''' Insert text into a text box.
    ''' </summary>
    ''' 
    ''' <param name="TextBox">The text box to insert into.</param>
    ''' <param name="Text">The text to insert.</param>
    Public Sub InsertText(TextBox As TextBoxBase, Text As String)
        Dim IsRtb = TypeOf TextBox Is RichTextBox
        Dim CurrentPos As Integer = TextBox.SelectionStart

        If IsRtb Then
            Dim Rtb As RichTextBox = CType(TextBox, RichTextBox)
            Rtb.SelectedText = Text
        Else
            TextBox.Text = TextBox.Text.Insert(CurrentPos, Text)
        End If

        TextBox.SelectionStart = CurrentPos + Text.Length
        TextBox.SelectionLength = 0
    End Sub

    ''' <summary>
    ''' Select a string in a textbox between two characters. 
    ''' </summary>
    ''' 
    ''' <param name="TextBox">The text box.</param>
    ''' <param name="StartChar">The character before the word.</param>
    ''' <param name="EndChar">The character after the word.</param>
    Public Sub SelectWord(TextBox As TextBoxBase, Optional StartChar As Char = " ", Optional EndChar As Char = " ")
        Dim TextChars As Char() = TextBox.Text.ToCharArray()
        Dim i As Integer = TextBox.SelectionStart - 1

        While i >= 0 AndAlso TextChars(i) <> StartChar AndAlso TextChars(i) <> vbLf
            i -= 1
        End While

        Dim StartPos As Integer = i + 1
        i = TextBox.SelectionStart

        While i < TextChars.Length AndAlso TextChars(i) <> EndChar AndAlso TextChars(i) <> vbLf
            i += 1
        End While

        Dim EndPos As Integer = i
        TextBox.Select(StartPos, EndPos - StartPos)
    End Sub

    ''' <summary>
    ''' Insert a pair of brackets surrounding the current selection or word.
    ''' </summary>
    ''' 
    ''' <param name="TextBox">The text box to insert into.</param>
    ''' <param name="BracketOpen">The opening bracket.</param>
    ''' <param name="BracketClose">The closing bracket.</param>
    Public Sub InsertBrackets(TextBox As TextBoxBase, BracketOpen As String, BracketClose As String)
        Dim IsRtb = TypeOf TextBox Is RichTextBox
        Dim SelectionFont = If(IsRtb, CType(TextBox, RichTextBox).SelectionFont, Nothing)
        Dim SelectionColor = If(IsRtb, CType(TextBox, RichTextBox).SelectionColor, Nothing)
        Dim SelectionBackColor = If(IsRtb, CType(TextBox, RichTextBox).SelectionBackColor, Nothing)

        ' If nothing is selected, select the word the caret is in
        If TextBox.SelectionLength = 0 Then
            SelectWord(TextBox)
        End If

        Dim CurrentPos As Integer = TextBox.SelectionStart
        Dim SelectionLength As Integer = TextBox.SelectionLength
        Dim SelectionText = TextBox.SelectedText
        ' If the selections ends with '\n', remove the
        ' final end line character so that the brackets
        ' don't wrap to the next line when they shouldn't
        If SelectionText.EndsWith(vbLf) Then
            SelectionLength -= 1
        End If
        TextBox.SelectionLength = 0

        ' If it's an RTB, copy the style of the start of the selection
        If IsRtb Then
            Dim Rtf = CType(TextBox, RichTextBox)
            Rtf.SelectionFont = SelectionFont
            Rtf.SelectionColor = SelectionColor
            Rtf.SelectionBackColor = SelectionBackColor
        End If

        ' Insert bracket before
        InsertText(TextBox, BracketOpen)

        ' Insert bracket after
        TextBox.SelectionStart = CurrentPos + SelectionLength + BracketOpen.Length
        InsertText(TextBox, BracketClose)

        ' Move the cursor to the end of the brackets
        TextBox.SelectionLength = 0
        TextBox.SelectionStart = CurrentPos + BracketOpen.Length + BracketClose.Length
    End Sub

    ''' <summary>
    ''' Remove a set of brackets from the current selection or word.
    ''' </summary>
    ''' 
    ''' <param name="TextBox">The text box to remove the brackets from.</param>
    ''' <param name="BracketStart">The starting bracket.</param>
    ''' <param name="BracketEnd">The closing bracket.</param>
    Public Sub RemoveBrackets(TextBox As TextBoxBase, BracketStart As String, BracketEnd As String)
        If TextBox.Text.Length >= 2 AndAlso TextBox.SelectionLength = 0 Then ' Infer what the user wants selected
            ' Get the current state of the selection in the text box
            Dim OldSelLength = TextBox.SelectionLength
            Dim OldSelStart = TextBox.SelectionStart

            ' Get characters before and after selection
            Dim OldStart = Math.Max(0, OldSelStart - 1)
            Dim OldStartChar = TextBox.Text.Chars(OldStart)
            Dim ValidStart = True ' If this is really a valid start bracket

            ' If it's not at the start, make sure the previous char is a space
            If OldStart <> 0 Then
                ValidStart = (TextBox.Text.Chars(OldStart - 1) <> " ")
            End If

            ' Look at end bracket
            Dim OldEnd = Math.Max(0, OldSelStart + OldSelLength - 1)
            Dim OldEndChar = TextBox.Text.Chars(OldEnd)
            Dim ValidEnd = True ' If this is really a valid end bracket

            ' If it's not at the end, make sure the next char is a space
            If OldEnd <> TextBox.Text.Length - 1 Then
                ValidEnd = (TextBox.Text.Chars(OldEnd + 1) <> " ")
            End If

            ' If at end of brackets, move inside word for parsing
            If TextBox.SelectionLength = 0 AndAlso OldStartChar = BracketEnd AndAlso ValidEnd Then
                TextBox.SelectionStart = Math.Max(0, OldStart - 1)
            End If

            ' If at beginning of brackets, move inside word for parsing
            If TextBox.SelectionLength = 0 AndAlso OldStartChar = BracketStart AndAlso ValidStart Then
                TextBox.SelectionStart = Math.Min(TextBox.Text.Length - 1, OldStart + 1)
            End If

            ' Try to select the word bounded by the brackets
            SelectWord(TextBox, BracketStart, BracketEnd)
            Dim StartPos = Math.Max(0, TextBox.SelectionStart - 1)
            Dim StartChar = TextBox.Text.Chars(StartPos)
            Dim EndPos = Math.Min(TextBox.Text.Length - 1, TextBox.SelectionStart + TextBox.SelectionLength)
            Dim EndChar = TextBox.Text.Chars(EndPos)
            Dim AnySelected = StartPos <> EndPos ' The start isn't the same as the end

            ' If the text is actually inside the brackets
            If StartChar = BracketStart AndAlso EndChar = BracketEnd AndAlso AnySelected Then
                ' Remove the start bracket
                TextBox.Select(StartPos, 1)
                TextBox.SelectedText = ""

                ' Remove the end bracket
                TextBox.Select(EndPos - 1, 1)
                TextBox.SelectedText = ""

                ' Reset the selection
                TextBox.Select(Math.Max(0, OldSelStart - 1), OldSelLength)
            Else ' Nothing to remove
                TextBox.Select(OldSelStart, OldSelLength)
            End If
        Else ' The user has already selected the text to search
            Dim BracketStartPos = TextBox.Text.IndexOf(BracketStart) ' Outermost start bracket
            Dim BracketEndPos = TextBox.Text.LastIndexOf(BracketEnd) ' Outermost end bracket

            If BracketStartPos <> -1 AndAlso BracketEndPos <> -1 Then
                ' Remove start bracket
                TextBox.Select(BracketStartPos, 1)
                TextBox.SelectedText = ""

                ' Remove end bracket
                TextBox.Select(BracketEndPos - 1, 1)
                TextBox.SelectedText = ""
            End If
        End If
    End Sub

    ''' <summary>
    ''' Remove all brackets from the current selection or word.
    ''' </summary>
    ''' 
    ''' <param name="TextBox">The textbox to remove the brackets from.</param>
    Public Sub RemoveAllBrackets(TextBox As TextBoxBase)
        RemoveBrackets(TextBox, "[", "]")
        RemoveBrackets(TextBox, "/", "/")
    End Sub
End Module
