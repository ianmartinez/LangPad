Imports AutoUpdaterDotNET

Module AutoUpdate
    Public Sub Update()
        AutoUpdater.Start("http://rbsoft.org/updates/AutoUpdaterTest.xml")
    End Sub

End Module
