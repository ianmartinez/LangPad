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
            CharTool = New CharacterEditorToolWindow

            ssLoading.pbLoading.Value = 0
            ssLoading.lblLoading.Text = "Loading..."

            ssLoading.lblLoading.Text = "Loading Accent Marks..."
            For Each AccentMark As KeyValuePair(Of String, String) In ZiaFile.Read(Resources.Accents)
                CharTool.charEdit.InsertAccentButton(AccentMark.Value)
            Next

            ssLoading.pbLoading.Value = 10
            ssLoading.Refresh()

            ssLoading.lblLoading.Text = "Loading IPA Affricates..."
            For Each Affricate As KeyValuePair(Of String, String) In ZiaFile.Read(Resources.Affricates)
                CharTool.charEdit.InsertCharacterButton(Affricate.Value, CharTool.charEdit.AffricatesLayoutPanel)
            Next

            ssLoading.pbLoading.Value = 20
            ssLoading.Refresh()

            ssLoading.lblLoading.Text = "Loading IPA Consonants..."
            For Each Consonant As KeyValuePair(Of String, String) In ZiaFile.Read(Resources.Consonants)
                CharTool.charEdit.InsertCharacterButton(Consonant.Value, CharTool.charEdit.ConsonantsLayoutPanel)
            Next

            ssLoading.pbLoading.Value = 30
            ssLoading.Refresh()

            ssLoading.lblLoading.Text = "Loading IPA Tones..."
            For Each Tone As KeyValuePair(Of String, String) In ZiaFile.Read(Resources.ToneIntonation)
                CharTool.charEdit.InsertCharacterButton(Tone.Value, CharTool.charEdit.ToneIntonationLayoutPanel)
            Next

            ssLoading.pbLoading.Value = 40
            ssLoading.Refresh()

            ssLoading.lblLoading.Text = "Loading IPA Vowels..."
            For Each Vowel As KeyValuePair(Of String, String) In ZiaFile.Read(Resources.Vowels)
                CharTool.charEdit.InsertCharacterButton(Vowel.Value, CharTool.charEdit.VowelsLayoutPanel)
            Next

            ssLoading.pbLoading.Value = 50
            ssLoading.Refresh()

            ssLoading.lblLoading.Text = "Loading Other IPA Characters..."
            For Each OtherIPA As KeyValuePair(Of String, String) In ZiaFile.Read(Resources.Other)
                CharTool.charEdit.InsertCharacterButton(OtherIPA.Value, CharTool.charEdit.OtherLayoutPanel)
            Next

            ssLoading.pbLoading.Value = 60
            ssLoading.Refresh()

            ssLoading.lblLoading.Text = "Loading Common Characters..."
            For Each CommonChar As KeyValuePair(Of String, String) In ZiaFile.Read(Resources.Common)
                CharTool.charEdit.InsertCharacterButton(CommonChar.Value, CharTool.charEdit.LatinExtendedLayoutPanel)
            Next

            ssLoading.pbLoading.Value = 70
            ssLoading.Refresh()

            ssLoading.lblLoading.Text = "Loading Local Custom Characters..."
            Dim LineList As String() = Settings.CustomSymbols.Split({Environment.NewLine}, StringSplitOptions.RemoveEmptyEntries)
            For Each LocalCharacter As String In LineList
                CharTool.charEdit.InsertCharacterButton(LocalCharacter, CharTool.charEdit.LocalCharPanel)
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
            CharTool.charEdit.RefreshPanels()
        End Sub
    End Class
End Namespace
