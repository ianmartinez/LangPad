<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class dlgAppendReplace
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(dlgAppendReplace))
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.btnAppend = New Tundra.StylizedButton()
        Me.btnCancel = New Tundra.StylizedButton()
        Me.btnReplace = New Tundra.StylizedButton()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.pnlTabs = New Tundra.StylizedPanel()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.pnlTabs.SuspendLayout()
        Me.SuspendLayout()
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel1.ColumnCount = 3
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel1.Controls.Add(Me.btnAppend, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.btnCancel, 2, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.btnReplace, 1, 0)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(89, 88)
        Me.TableLayoutPanel1.Margin = New System.Windows.Forms.Padding(4)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(262, 36)
        Me.TableLayoutPanel1.TabIndex = 73
        '
        'btnAppend
        '
        Me.btnAppend.BackColor = System.Drawing.Color.Transparent
        Me.btnAppend.BackgroundImage = CType(resources.GetObject("btnAppend.BackgroundImage"), System.Drawing.Image)
        Me.btnAppend.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnAppend.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnAppend.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnAppend.FlatAppearance.BorderSize = 0
        Me.btnAppend.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btnAppend.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btnAppend.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAppend.ForeColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(43, Byte), Integer), CType(CType(47, Byte), Integer))
        Me.btnAppend.Location = New System.Drawing.Point(3, 2)
        Me.btnAppend.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnAppend.Name = "btnAppend"
        Me.btnAppend.Padding = New System.Windows.Forms.Padding(0, 1, 0, 0)
        Me.btnAppend.Size = New System.Drawing.Size(81, 32)
        Me.btnAppend.Style = resources.GetString("btnAppend.Style")
        Me.btnAppend.TabIndex = 0
        Me.btnAppend.Text = "Append"
        Me.btnAppend.UseCompatibleTextRendering = True
        Me.btnAppend.UseVisualStyleBackColor = False
        '
        'btnCancel
        '
        Me.btnCancel.BackColor = System.Drawing.Color.Transparent
        Me.btnCancel.BackgroundImage = CType(resources.GetObject("btnCancel.BackgroundImage"), System.Drawing.Image)
        Me.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnCancel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnCancel.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnCancel.FlatAppearance.BorderSize = 0
        Me.btnCancel.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btnCancel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCancel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(43, Byte), Integer), CType(CType(47, Byte), Integer))
        Me.btnCancel.Location = New System.Drawing.Point(177, 2)
        Me.btnCancel.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Padding = New System.Windows.Forms.Padding(0, 1, 0, 0)
        Me.btnCancel.Size = New System.Drawing.Size(82, 32)
        Me.btnCancel.Style = resources.GetString("btnCancel.Style")
        Me.btnCancel.TabIndex = 2
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseCompatibleTextRendering = True
        Me.btnCancel.UseVisualStyleBackColor = False
        '
        'btnReplace
        '
        Me.btnReplace.BackColor = System.Drawing.Color.Transparent
        Me.btnReplace.BackgroundImage = CType(resources.GetObject("btnReplace.BackgroundImage"), System.Drawing.Image)
        Me.btnReplace.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnReplace.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnReplace.FlatAppearance.BorderSize = 0
        Me.btnReplace.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btnReplace.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btnReplace.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnReplace.ForeColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(43, Byte), Integer), CType(CType(47, Byte), Integer))
        Me.btnReplace.Location = New System.Drawing.Point(90, 2)
        Me.btnReplace.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnReplace.Name = "btnReplace"
        Me.btnReplace.Padding = New System.Windows.Forms.Padding(0, 1, 0, 0)
        Me.btnReplace.Size = New System.Drawing.Size(81, 32)
        Me.btnReplace.Style = resources.GetString("btnReplace.Style")
        Me.btnReplace.TabIndex = 1
        Me.btnReplace.Text = "Replace"
        Me.btnReplace.UseCompatibleTextRendering = True
        Me.btnReplace.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(340, 63)
        Me.Label1.TabIndex = 74
        Me.Label1.Text = "This document has embedded custom symbols. Would you like to append or replace yo" & _
    "ur current custom symbols?"
        '
        'pnlTabs
        '
        Me.pnlTabs.BackColor = System.Drawing.Color.Transparent
        Me.pnlTabs.Controls.Add(Me.Label1)
        Me.pnlTabs.Controls.Add(Me.TableLayoutPanel1)
        Me.pnlTabs.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlTabs.Location = New System.Drawing.Point(0, 0)
        Me.pnlTabs.Margin = New System.Windows.Forms.Padding(3, 2, 3, 0)
        Me.pnlTabs.Name = "pnlTabs"
        Me.pnlTabs.Padding = New System.Windows.Forms.Padding(0, 0, 0, 1)
        Me.pnlTabs.Size = New System.Drawing.Size(364, 137)
        Me.pnlTabs.Style = "Colors=$1|~245" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Positions=0|1" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Angle=90" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Radius=0" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Border Color=$1" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Highlight Col" & _
    "or$0" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Bottom Only=1"
        Me.pnlTabs.TabIndex = 75
        '
        'dlgAppendReplace
        '
        Me.AcceptButton = Me.btnAppend
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.CancelButton = Me.btnCancel
        Me.ClientSize = New System.Drawing.Size(364, 137)
        Me.Controls.Add(Me.pnlTabs)
        Me.ForeColor = System.Drawing.Color.Black
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "dlgAppendReplace"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.TopMost = True
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.pnlTabs.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents btnCancel As Tundra.StylizedButton
    Friend WithEvents btnReplace As Tundra.StylizedButton
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnAppend As Tundra.StylizedButton
    Friend WithEvents pnlTabs As Tundra.StylizedPanel

End Class
