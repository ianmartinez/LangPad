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

            SplashScreenForm.LoadingProgressBar.Value = 0
            SplashScreenForm.LoadingLabel.Text = "Loading..."

            SplashScreenForm.LoadingLabel.Text = "Loading Accent Marks..."
            For Each AccentMark As KeyValuePair(Of String, String) In ZiaFile.Read(Resources.Accents)
                CharEditor.CharEdit.InsertAccentButton(AccentMark.Value, AccentMark.Key)
            Next

            SplashScreenForm.LoadingProgressBar.Value = 10
            SplashScreenForm.Refresh()

            SplashScreenForm.LoadingLabel.Text = "Loading IPA Affricates..."
            For Each Affricate As KeyValuePair(Of String, String) In ZiaFile.Read(Resources.Affricates)
                CharEditor.CharEdit.InsertCharacterButton(Affricate.Value, CharEditor.CharEdit.AffricatesPanel, Affricate.Key, True, True, CharacterType.IPAAffricate)
            Next

            SplashScreenForm.LoadingProgressBar.Value = 20
            SplashScreenForm.Refresh()

            SplashScreenForm.LoadingLabel.Text = "Loading IPA Consonants..."
            For Each Consonant As KeyValuePair(Of String, String) In ZiaFile.Read(Resources.Consonants)
                CharEditor.CharEdit.InsertCharacterButton(Consonant.Value, CharEditor.CharEdit.ConsonantsLayoutPanel, Consonant.Key, True, True, CharacterType.IPAConsonant)
            Next

            SplashScreenForm.LoadingProgressBar.Value = 30
            SplashScreenForm.Refresh()

            SplashScreenForm.LoadingLabel.Text = "Loading IPA Tones..."
            For Each Tone As KeyValuePair(Of String, String) In ZiaFile.Read(Resources.ToneIntonation)
                CharEditor.CharEdit.InsertCharacterButton(Tone.Value, CharEditor.CharEdit.ToneIntonationPanel, Tone.Key, True, True, CharacterType.IPATone)
            Next

            SplashScreenForm.LoadingProgressBar.Value = 40
            SplashScreenForm.Refresh()

            SplashScreenForm.LoadingLabel.Text = "Loading IPA Vowels..."
            For Each Vowel As KeyValuePair(Of String, String) In ZiaFile.Read(Resources.Vowels)
                CharEditor.CharEdit.InsertCharacterButton(Vowel.Value, CharEditor.CharEdit.VowelPanel, Vowel.Key, True, True, CharacterType.IPAVowel)
            Next

            SplashScreenForm.LoadingProgressBar.Value = 50
            SplashScreenForm.Refresh()

            SplashScreenForm.LoadingLabel.Text = "Loading IPA Diacritics..."
            For Each Diacritic As KeyValuePair(Of String, String) In ZiaFile.Read(Resources.Diacritics)
                CharEditor.CharEdit.InsertCharacterButton(Diacritic.Value, CharEditor.CharEdit.DiacriticsPanel, Diacritic.Key, True, True, CharacterType.IPADiacritic)
            Next

            SplashScreenForm.LoadingProgressBar.Value = 50
            SplashScreenForm.Refresh()

            SplashScreenForm.LoadingLabel.Text = "Loading IPA Suprasegmentals..."
            For Each Suprasegmental As KeyValuePair(Of String, String) In ZiaFile.Read(Resources.Suprasegmentals)
                CharEditor.CharEdit.InsertCharacterButton(Suprasegmental.Value, CharEditor.CharEdit.SuprasegmentalsPanel, Suprasegmental.Key, True, True, CharacterType.IPASuprasegmental)
            Next

            SplashScreenForm.LoadingProgressBar.Value = 60
            SplashScreenForm.Refresh()

            SplashScreenForm.LoadingLabel.Text = "Loading Extended Characters..."
            For Each LatinExtended As KeyValuePair(Of String, String) In ZiaFile.Read(Resources.Common)
                CharEditor.CharEdit.InsertCharacterButton(LatinExtended.Value, CharEditor.CharEdit.LatinPanel, LatinExtended.Key, False, True, CharacterType.ExtendedLatin)
            Next

            For Each CyrillicExtended As KeyValuePair(Of String, String) In ZiaFile.Read(Resources.Cyrillic)
                CharEditor.CharEdit.InsertCharacterButton(CyrillicExtended.Value, CharEditor.CharEdit.CyrillicPanel, CyrillicExtended.Key, False, True, CharacterType.ExtendedCyrillic)
            Next

            For Each GreekExtended As KeyValuePair(Of String, String) In ZiaFile.Read(Resources.Greek)
                CharEditor.CharEdit.InsertCharacterButton(GreekExtended.Value, CharEditor.CharEdit.GreekPanel, GreekExtended.Key, False, True, CharacterType.ExtendedGreek)
            Next

            SplashScreenForm.LoadingProgressBar.Value = 70
            SplashScreenForm.Refresh()

            SplashScreenForm.LoadingLabel.Text = "Loading Local Custom Characters..."
            Dim LocalCharacters As String() = Settings.CustomSymbols.Split({Environment.NewLine}, StringSplitOptions.RemoveEmptyEntries)
            For Each LocalCharacter As String In LocalCharacters
                CharEditor.CharEdit.InsertCharacterButton(LocalCharacter, CharEditor.CharEdit.LocalPanel)
            Next

            SplashScreenForm.LoadingProgressBar.Value = 80
            SplashScreenForm.Refresh()

            If Settings.SmartReplace = True Then
                SplashScreenForm.LoadingLabel.Text = "Loading Smart Replace..."
                For Each pair As KeyValuePair(Of String, String) In ZiaFile.Read(Resources.SmartReplace)
                    SmartReplaceList.Add(pair.Key, pair.Value)
                Next
            End If
            SplashScreenForm.LoadingProgressBar.Value = 90
            SplashScreenForm.Refresh()

            If Settings.Updates = True Then
                SplashScreenForm.LoadingLabel.Text = "Checking for updates..."
                UpdateDialog.FetchUpdateData()
            End If

            UpdateDialog.StartupCheck = False
            SplashScreenForm.LoadingProgressBar.Value = 100
            SplashScreenForm.Refresh()
            CharEditor.CharEdit.RefreshPanels()
        End Sub
    End Class
End Namespace
