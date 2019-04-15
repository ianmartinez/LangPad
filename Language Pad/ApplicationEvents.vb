Imports TundraLib

Namespace My

    ' The following events are available for MyApplication:
    ' 
    ' Startup: Raised when the application starts, before the startup form is created.
    ' Shutdown: Raised after all application forms are closed.  This event is not raised if the application terminates abnormally.
    ' UnhandledException: Raised if the application encounters an unhandled exception.
    ' StartupNextInstance: Raised when launching a single-instance application and the application is already active. 
    ' NetworkAvailabilityChanged: Raised when the network connection is connected or disconnected.

    Partial Friend Class MyApplication

        Private Sub MyApplication_Startup(sender As Object, e As ApplicationServices.StartupEventArgs) Handles Me.Startup
            On Error Resume Next

            ssLoading.pbLoading.Value = 0
            ssLoading.lblLoading.Text = "Loading..."

            If Settings.AccentMarks = True Then
                ssLoading.lblLoading.Text = "Loading Accent Marks..."
                For Each AccentMark As KeyValuePair(Of String, String) In ZiaFile.Read(Resources.Accents)
                    frmMain.charEdit.InsertCharacterButton(AccentMark.Value, frmMain.charEdit.AccentsLayoutPanel)

                    Dim SymbolButtonDictionary As New SymbolButton With {
                        .Text = AccentMark.Value
                    }
                    AddHandler SymbolButtonDictionary.Click, AddressOf frmDictionary.InsertIPA
                    frmDictionary.AccentsLayoutPanel.Controls.Add(SymbolButtonDictionary)
                Next
                ssLoading.pbLoading.Value = 10
                ssLoading.Refresh()
            Else
                frmMain.charEdit.tcIPA.TabPages.Remove(frmMain.charEdit.AccentsTabPage)
                frmDictionary.tcSymbols.TabPages.Remove(frmMain.charEdit.AccentsTabPage)
            End If

            If Settings.IPAAffricates = True Then
                ssLoading.lblLoading.Text = "Loading IPA Affricates..."
                For Each Affricate As KeyValuePair(Of String, String) In ZiaFile.Read(Resources.Affricates)
                    frmMain.charEdit.InsertCharacterButton(Affricate.Value, frmMain.charEdit.AffricatesLayoutPanel)

                    Dim SymbolButtonDictionary As New SymbolButton With {
                        .Text = Affricate.Value
                    }
                    AddHandler SymbolButtonDictionary.Click, AddressOf frmDictionary.InsertIPA
                    frmDictionary.AffricatesLayoutPanel.Controls.Add(SymbolButtonDictionary)
                Next
                ssLoading.pbLoading.Value = 20
                ssLoading.Refresh()
            Else
                frmMain.charEdit.tcIPA.TabPages.Remove(frmMain.charEdit.AffricatesTabPage)
                frmDictionary.tcSymbols.TabPages.Remove(frmMain.charEdit.AffricatesTabPage)
            End If

            If Settings.IPAConsonants = True Then
                ssLoading.lblLoading.Text = "Loading IPA Consonants..."
                For Each Consonant As KeyValuePair(Of String, String) In ZiaFile.Read(Resources.Consonants)
                    frmMain.charEdit.InsertCharacterButton(Consonant.Value, frmMain.charEdit.ConsonantsLayoutPanel)

                    Dim SymbolButtonDictionary As New SymbolButton With {
                        .Text = Consonant.Value
                    }
                    AddHandler SymbolButtonDictionary.Click, AddressOf frmDictionary.InsertIPA
                    frmDictionary.ConsonantsLayoutPanel.Controls.Add(SymbolButtonDictionary)
                Next
                ssLoading.pbLoading.Value = 30
                ssLoading.Refresh()
            Else
                frmMain.charEdit.tcIPA.TabPages.Remove(frmMain.charEdit.ConsonantsTabPage)
                frmDictionary.tcSymbols.TabPages.Remove(frmMain.charEdit.ConsonantsTabPage)
            End If

            If Settings.IPATones = True Then
                ssLoading.lblLoading.Text = "Loading IPA Tones..."
                For Each Tone As KeyValuePair(Of String, String) In ZiaFile.Read(Resources.ToneIntonation)
                    frmMain.charEdit.InsertCharacterButton(Tone.Value, frmMain.charEdit.ToneIntonationLayoutPanel)

                    Dim SymbolButtonDictionary As New SymbolButton With {
                        .Text = Tone.Value
                    }
                    AddHandler SymbolButtonDictionary.Click, AddressOf frmDictionary.InsertIPA
                    frmDictionary.ToneIntonationLayoutPanel.Controls.Add(SymbolButtonDictionary)
                Next
                ssLoading.pbLoading.Value = 40
                ssLoading.Refresh()
            Else
                frmMain.charEdit.tcIPA.TabPages.Remove(frmMain.charEdit.ToneIntonationTabPage)
                frmDictionary.tcSymbols.TabPages.Remove(frmMain.charEdit.ToneIntonationTabPage)
            End If

            If Settings.IPAVowels = True Then
                ssLoading.lblLoading.Text = "Loading IPA Vowels..."
                For Each Vowel As KeyValuePair(Of String, String) In ZiaFile.Read(Resources.Vowels)
                    frmMain.charEdit.InsertCharacterButton(Vowel.Value, frmMain.charEdit.VowelsLayoutPanel)


                    Dim SymbolButtonDictionary As New SymbolButton With {
                        .Text = Vowel.Value
                    }
                    AddHandler SymbolButtonDictionary.Click, AddressOf frmDictionary.InsertIPA
                    frmDictionary.VowelsLayoutPanel.Controls.Add(SymbolButtonDictionary)
                Next
                ssLoading.pbLoading.Value = 50
                ssLoading.Refresh()
            Else
                frmMain.charEdit.tcIPA.TabPages.Remove(frmMain.charEdit.VowelsTabPage)
                frmDictionary.tcSymbols.TabPages.Remove(frmMain.charEdit.VowelsTabPage)
            End If

            If Settings.OtherIPA = True Then
                ssLoading.lblLoading.Text = "Loading Other IPA Characters..."
                For Each OtherIPA As KeyValuePair(Of String, String) In ZiaFile.Read(Resources.Other)
                    frmMain.charEdit.InsertCharacterButton(OtherIPA.Value, frmMain.charEdit.OtherLayoutPanel)

                    Dim SymbolButtonDictionary As New SymbolButton With {
                        .Text = OtherIPA.Value
                    }
                    AddHandler SymbolButtonDictionary.Click, AddressOf frmDictionary.InsertIPA
                    frmDictionary.OtherLayoutPanel.Controls.Add(SymbolButtonDictionary)
                Next
                ssLoading.pbLoading.Value = 60
                ssLoading.Refresh()
            Else
                frmMain.charEdit.tcIPA.TabPages.Remove(frmMain.charEdit.OtherTabPage)
                frmDictionary.tcSymbols.TabPages.Remove(frmMain.charEdit.OtherTabPage)
            End If

            If Settings.CommonChar = True Then
                ssLoading.lblLoading.Text = "Loading Common Characters..."
                For Each CommonChar As String In Resources.Common.Split({"|"}, StringSplitOptions.RemoveEmptyEntries)
                    frmMain.charEdit.InsertCharacterButton(CommonChar, frmMain.charEdit.CommonLayoutPanel)

                    Dim SymbolButtonDictionary As New SymbolButton With {
                        .Text = CommonChar
                    }
                    AddHandler SymbolButtonDictionary.Click, AddressOf frmDictionary.InsertIPA
                    frmDictionary.CommonLayoutPanel.Controls.Add(SymbolButtonDictionary)
                Next
                ssLoading.pbLoading.Value = 70
                ssLoading.Refresh()
            Else
                frmMain.charEdit.tcIPA.TabPages.Remove(frmMain.charEdit.tpCommon)
                frmDictionary.tcSymbols.TabPages.Remove(frmMain.charEdit.tpCommon)
            End If

            ssLoading.lblLoading.Text = "Loading Local Custom Characters..."
            Dim LineList As String() = Settings.CustomSymbols.Split({Environment.NewLine}, StringSplitOptions.RemoveEmptyEntries)
            For Each LocalCharacter As String In LineList
                frmMain.charEdit.InsertCharacterButton(LocalCharacter, frmMain.charEdit.LocalCharPanel)

                Dim SymbolButtonDictionary As New SymbolButton With {
                    .Text = LocalCharacter
                }
                AddHandler SymbolButtonDictionary.Click, AddressOf frmDictionary.InsertIPA
                frmDictionary.CustomLayoutPanel.Controls.Add(SymbolButtonDictionary)
            Next
            ssLoading.pbLoading.Value = 80
            ssLoading.Refresh()

            If Settings.SmartReplace = True Then
                ssLoading.lblLoading.Text = "Loading Smart Replace..."
                For Each pair As KeyValuePair(Of String, String) In ZiaFile.Read(Resources.SmartReplace)
                    SmartReplaceList.Add(pair.Key, pair.Value)
                Next
            End If
            ssLoading.pbLoading.Value = 90
            ssLoading.Refresh()

            If Settings.Updates = True Then
                ssLoading.lblLoading.Text = "Checking for updates..."
                dlgUpdate.FetchUpdateData()
            End If

            dlgUpdate.StartupCheck = False
            ssLoading.pbLoading.Value = 100
            ssLoading.Refresh()
        End Sub
    End Class
End Namespace
