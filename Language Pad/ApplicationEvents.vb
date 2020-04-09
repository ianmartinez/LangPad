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

            CharEditor = New CharacterEditorToolWindow

            SplashScreenForm.pbLoading.Value = 0
            SplashScreenForm.lblLoading.Text = "Loading..."

            SplashScreenForm.lblLoading.Text = "Loading Accent Marks..."
            For Each AccentMark As KeyValuePair(Of String, String) In ZiaFile.Read(Resources.Accents)
                CharEditor.charEdit.InsertAccentButton(AccentMark.Value, AccentMark.Key)
            Next

            SplashScreenForm.pbLoading.Value = 10
            SplashScreenForm.Refresh()

            SplashScreenForm.lblLoading.Text = "Loading IPA Affricates..."
            For Each Affricate As KeyValuePair(Of String, String) In ZiaFile.Read(Resources.Affricates)
                CharEditor.charEdit.InsertCharacterButton(Affricate.Value, CharEditor.charEdit.AffricatesLayoutPanel, Affricate.Key, True, True, CharacterType.IPAAffricate)
            Next

            SplashScreenForm.pbLoading.Value = 20
            SplashScreenForm.Refresh()

            SplashScreenForm.lblLoading.Text = "Loading IPA Consonants..."
            For Each Consonant As KeyValuePair(Of String, String) In ZiaFile.Read(Resources.Consonants)
                CharEditor.charEdit.InsertCharacterButton(Consonant.Value, CharEditor.charEdit.ConsonantsLayoutPanel, Consonant.Key, True, True, CharacterType.IPAConsonant)
            Next

            SplashScreenForm.pbLoading.Value = 30
            SplashScreenForm.Refresh()

            SplashScreenForm.lblLoading.Text = "Loading IPA Tones..."
            For Each Tone As KeyValuePair(Of String, String) In ZiaFile.Read(Resources.ToneIntonation)
                CharEditor.charEdit.InsertCharacterButton(Tone.Value, CharEditor.charEdit.ToneIntonationLayoutPanel, Tone.Key, True, True, CharacterType.IPATone)
            Next

            SplashScreenForm.pbLoading.Value = 40
            SplashScreenForm.Refresh()

            SplashScreenForm.lblLoading.Text = "Loading IPA Vowels..."
            For Each Vowel As KeyValuePair(Of String, String) In ZiaFile.Read(Resources.Vowels)
                CharEditor.charEdit.InsertCharacterButton(Vowel.Value, CharEditor.charEdit.VowelsLayoutPanel, Vowel.Key, True, True, CharacterType.IPAVowel)
            Next

            SplashScreenForm.pbLoading.Value = 50
            SplashScreenForm.Refresh()

            SplashScreenForm.lblLoading.Text = "Loading IPA Diacritics..."
            For Each Diacritic As KeyValuePair(Of String, String) In ZiaFile.Read(Resources.Diacritics)
                CharEditor.charEdit.InsertCharacterButton(Diacritic.Value, CharEditor.charEdit.DiacriticsLayoutPanel, Diacritic.Key, True, True, CharacterType.IPADiacritic)
            Next

            SplashScreenForm.pbLoading.Value = 50
            SplashScreenForm.Refresh()

            SplashScreenForm.lblLoading.Text = "Loading IPA Suprasegmentals..."
            For Each Suprasegmental As KeyValuePair(Of String, String) In ZiaFile.Read(Resources.Suprasegmentals)
                CharEditor.charEdit.InsertCharacterButton(Suprasegmental.Value, CharEditor.charEdit.SuprasegmentalsLayoutPanel, Suprasegmental.Key, True, True, CharacterType.IPASuprasegmental)
            Next

            SplashScreenForm.pbLoading.Value = 60
            SplashScreenForm.Refresh()

            SplashScreenForm.lblLoading.Text = "Loading Extended Characters..."
            For Each LatinExtended As KeyValuePair(Of String, String) In ZiaFile.Read(Resources.Common)
                CharEditor.charEdit.InsertCharacterButton(LatinExtended.Value, CharEditor.charEdit.LatinExtendedLayoutPanel, LatinExtended.Key, False, True, CharacterType.ExtendedLatin)
            Next

            For Each CyrillicExtended As KeyValuePair(Of String, String) In ZiaFile.Read(Resources.Cyrillic)
                CharEditor.charEdit.InsertCharacterButton(CyrillicExtended.Value, CharEditor.charEdit.CyrillicExtendedPanel, CyrillicExtended.Key, False, True, CharacterType.ExtendedCyrillic)
            Next

            For Each GreekExtended As KeyValuePair(Of String, String) In ZiaFile.Read(Resources.Greek)
                CharEditor.charEdit.InsertCharacterButton(GreekExtended.Value, CharEditor.charEdit.GreekExtendedPanel, GreekExtended.Key, False, True, CharacterType.ExtendedGreek)
            Next

            SplashScreenForm.pbLoading.Value = 70
            SplashScreenForm.Refresh()

            SplashScreenForm.lblLoading.Text = "Loading Local Custom Characters..."
            Dim LocalCharacters As String() = Settings.CustomSymbols.Split({Environment.NewLine}, StringSplitOptions.RemoveEmptyEntries)
            For Each LocalCharacter As String In LocalCharacters
                CharEditor.charEdit.InsertCharacterButton(LocalCharacter, CharEditor.charEdit.LocalCharPanel)
            Next

            SplashScreenForm.pbLoading.Value = 80
            SplashScreenForm.Refresh()

            If Settings.SmartReplace = True Then
                SplashScreenForm.lblLoading.Text = "Loading Smart Replace..."
                For Each pair As KeyValuePair(Of String, String) In ZiaFile.Read(Resources.SmartReplace)
                    SmartReplaceList.Add(pair.Key, pair.Value)
                Next
            End If
            SplashScreenForm.pbLoading.Value = 90
            SplashScreenForm.Refresh()

            If Settings.Updates = True Then
                SplashScreenForm.lblLoading.Text = "Checking for updates..."
                UpdateDialog.FetchUpdateData()
            End If

            UpdateDialog.StartupCheck = False
            SplashScreenForm.pbLoading.Value = 100
            SplashScreenForm.Refresh()
            CharEditor.charEdit.RefreshPanels()
        End Sub
    End Class
End Namespace
