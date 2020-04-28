Imports AutoUpdaterDotNET

Module AutoUpdate
    Public Sub Update()
        AutoUpdater.Start("https://raw.githubusercontent.com/ianmartinez/LangPad/master/update/update.xml")
    End Sub
End Module
