<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class WordCard
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.StylizedPanel1 = New Tundra.StylizedPanel()
        Me.SuspendLayout()
        '
        'StylizedPanel1
        '
        Me.StylizedPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.StylizedPanel1.Location = New System.Drawing.Point(0, 0)
        Me.StylizedPanel1.Name = "StylizedPanel1"
        Me.StylizedPanel1.Size = New System.Drawing.Size(393, 180)
        Me.StylizedPanel1.Style = Nothing
        Me.StylizedPanel1.TabIndex = 0
        '
        'WordCard
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Transparent
        Me.Controls.Add(Me.StylizedPanel1)
        Me.Name = "WordCard"
        Me.Size = New System.Drawing.Size(393, 180)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents StylizedPanel1 As Tundra.StylizedPanel
End Class
