Imports System.Windows.Forms
Imports System.Drawing

Public Class WizardTabs
    Inherits TabControl
    Private mWizardMode As Boolean
    Public Property WizardMode As Boolean
        Get
            Return mWizardMode
        End Get
        Set(ByVal value As Boolean)
            mWizardMode = value
            On Error Resume Next
            ApplyTabs()
        End Set
    End Property

    Public Overrides Property Backcolor As Color

    Private Sub ApplyTabs()
        If WizardMode = True Then
            Appearance = TabAppearance.FlatButtons
            ItemSize = New Size(0, 1)
            SizeMode = TabSizeMode.Fixed

        Else
            Appearance = TabAppearance.Normal
            ItemSize = New Size(0, 1)
            SizeMode = TabSizeMode.Normal
        End If
    End Sub

    Private Sub TabControlPlus_DrawItem(sender As Object, e As DrawItemEventArgs) Handles Me.DrawItem
        e.Graphics.Clear(Color.Transparent)
    End Sub
End Class
