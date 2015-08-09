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
        Me.TableLayoutPanel1.SuspendLayout()
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
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(65, 71)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(196, 28)
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
        Me.btnAppend.ForeColor = System.Drawing.Color.Black
        Me.btnAppend.Location = New System.Drawing.Point(2, 2)
        Me.btnAppend.Margin = New System.Windows.Forms.Padding(2)
        Me.btnAppend.Name = "btnAppend"
        Me.btnAppend.Padding = New System.Windows.Forms.Padding(0, 1, 0, 0)
        Me.btnAppend.Size = New System.Drawing.Size(61, 24)
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
        Me.btnCancel.ForeColor = System.Drawing.Color.Black
        Me.btnCancel.Location = New System.Drawing.Point(132, 2)
        Me.btnCancel.Margin = New System.Windows.Forms.Padding(2)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Padding = New System.Windows.Forms.Padding(0, 1, 0, 0)
        Me.btnCancel.Size = New System.Drawing.Size(62, 24)
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
        Me.btnReplace.ForeColor = System.Drawing.Color.Black
        Me.btnReplace.Location = New System.Drawing.Point(67, 2)
        Me.btnReplace.Margin = New System.Windows.Forms.Padding(2)
        Me.btnReplace.Name = "btnReplace"
        Me.btnReplace.Padding = New System.Windows.Forms.Padding(0, 1, 0, 0)
        Me.btnReplace.Size = New System.Drawing.Size(61, 24)
        Me.btnReplace.Style = resources.GetString("btnReplace.Style")
        Me.btnReplace.TabIndex = 1
        Me.btnReplace.Text = "Replace"
        Me.btnReplace.UseCompatibleTextRendering = True
        Me.btnReplace.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(11, 9)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(250, 51)
        Me.Label1.TabIndex = 74
        Me.Label1.Text = "This document has embedded custom symbols. Would you like to append or replace yo" &
    "ur current custom symbols?"
        '
        'dlgAppendReplace
        '
        Me.AcceptButton = Me.btnAppend
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.CancelButton = Me.btnCancel
        Me.ClientSize = New System.Drawing.Size(273, 111)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Controls.Add(Me.Label1)
        Me.ForeColor = System.Drawing.Color.Black
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "dlgAppendReplace"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.TopMost = True
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents btnCancel As Tundra.StylizedButton
    Friend WithEvents btnReplace As Tundra.StylizedButton
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnAppend As Tundra.StylizedButton

End Class
