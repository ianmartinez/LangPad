<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class dlgCustomSymbols
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(dlgCustomSymbols))
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.btnCancel = New Tundra.StylizedButton()
        Me.btnOK = New Tundra.StylizedButton()
        Me.dgvSymbols = New System.Windows.Forms.DataGridView()
        Me.Symbol = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btnDeleteAll = New Tundra.StylizedButton()
        Me.btnOpen = New Tundra.StylizedButton()
        Me.btnSave = New Tundra.StylizedButton()
        Me.dlgOpen = New System.Windows.Forms.OpenFileDialog()
        Me.dlgSave = New System.Windows.Forms.SaveFileDialog()
        Me.TableLayoutPanel1.SuspendLayout()
        CType(Me.dgvSymbols, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.btnCancel, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.btnOK, 0, 0)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(132, 280)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(146, 28)
        Me.TableLayoutPanel1.TabIndex = 67
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
        Me.btnCancel.Location = New System.Drawing.Point(75, 2)
        Me.btnCancel.Margin = New System.Windows.Forms.Padding(2)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Padding = New System.Windows.Forms.Padding(0, 1, 0, 0)
        Me.btnCancel.Size = New System.Drawing.Size(69, 24)
        Me.btnCancel.Style = resources.GetString("btnCancel.Style")
        Me.btnCancel.TabIndex = 1
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseCompatibleTextRendering = True
        Me.btnCancel.UseVisualStyleBackColor = False
        '
        'btnOK
        '
        Me.btnOK.BackColor = System.Drawing.Color.Transparent
        Me.btnOK.BackgroundImage = CType(resources.GetObject("btnOK.BackgroundImage"), System.Drawing.Image)
        Me.btnOK.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnOK.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnOK.FlatAppearance.BorderSize = 0
        Me.btnOK.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btnOK.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btnOK.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnOK.ForeColor = System.Drawing.Color.Black
        Me.btnOK.Location = New System.Drawing.Point(2, 2)
        Me.btnOK.Margin = New System.Windows.Forms.Padding(2)
        Me.btnOK.Name = "btnOK"
        Me.btnOK.Padding = New System.Windows.Forms.Padding(0, 1, 0, 0)
        Me.btnOK.Size = New System.Drawing.Size(69, 24)
        Me.btnOK.Style = resources.GetString("btnOK.Style")
        Me.btnOK.TabIndex = 0
        Me.btnOK.Text = "OK"
        Me.btnOK.UseCompatibleTextRendering = True
        Me.btnOK.UseVisualStyleBackColor = False
        '
        'dgvSymbols
        '
        Me.dgvSymbols.BackgroundColor = System.Drawing.Color.White
        Me.dgvSymbols.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgvSymbols.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        Me.dgvSymbols.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvSymbols.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Symbol})
        Me.dgvSymbols.GridColor = System.Drawing.Color.Gainsboro
        Me.dgvSymbols.Location = New System.Drawing.Point(11, 11)
        Me.dgvSymbols.Margin = New System.Windows.Forms.Padding(2)
        Me.dgvSymbols.Name = "dgvSymbols"
        Me.dgvSymbols.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        Me.dgvSymbols.RowTemplate.Height = 24
        Me.dgvSymbols.Size = New System.Drawing.Size(267, 264)
        Me.dgvSymbols.TabIndex = 2
        '
        'Symbol
        '
        Me.Symbol.HeaderText = "Symbol"
        Me.Symbol.Name = "Symbol"
        Me.Symbol.Width = 225
        '
        'btnDeleteAll
        '
        Me.btnDeleteAll.BackColor = System.Drawing.Color.Transparent
        Me.btnDeleteAll.BackgroundImage = CType(resources.GetObject("btnDeleteAll.BackgroundImage"), System.Drawing.Image)
        Me.btnDeleteAll.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnDeleteAll.FlatAppearance.BorderSize = 0
        Me.btnDeleteAll.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent
        Me.btnDeleteAll.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btnDeleteAll.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btnDeleteAll.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDeleteAll.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDeleteAll.ForeColor = System.Drawing.Color.Black
        Me.btnDeleteAll.Image = CType(resources.GetObject("btnDeleteAll.Image"), System.Drawing.Image)
        Me.btnDeleteAll.Location = New System.Drawing.Point(71, 281)
        Me.btnDeleteAll.Margin = New System.Windows.Forms.Padding(2)
        Me.btnDeleteAll.Name = "btnDeleteAll"
        Me.btnDeleteAll.Padding = New System.Windows.Forms.Padding(0, 1, 0, 0)
        Me.btnDeleteAll.Size = New System.Drawing.Size(26, 26)
        Me.btnDeleteAll.Style = resources.GetString("btnDeleteAll.Style")
        Me.btnDeleteAll.TabIndex = 5
        Me.btnDeleteAll.UseCompatibleTextRendering = True
        Me.btnDeleteAll.UseVisualStyleBackColor = False
        '
        'btnOpen
        '
        Me.btnOpen.BackColor = System.Drawing.Color.Transparent
        Me.btnOpen.BackgroundImage = CType(resources.GetObject("btnOpen.BackgroundImage"), System.Drawing.Image)
        Me.btnOpen.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnOpen.FlatAppearance.BorderSize = 0
        Me.btnOpen.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent
        Me.btnOpen.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btnOpen.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btnOpen.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnOpen.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnOpen.ForeColor = System.Drawing.Color.Black
        Me.btnOpen.Image = CType(resources.GetObject("btnOpen.Image"), System.Drawing.Image)
        Me.btnOpen.Location = New System.Drawing.Point(11, 281)
        Me.btnOpen.Margin = New System.Windows.Forms.Padding(2)
        Me.btnOpen.Name = "btnOpen"
        Me.btnOpen.Padding = New System.Windows.Forms.Padding(0, 1, 0, 0)
        Me.btnOpen.Size = New System.Drawing.Size(26, 26)
        Me.btnOpen.Style = resources.GetString("btnOpen.Style")
        Me.btnOpen.TabIndex = 3
        Me.btnOpen.UseCompatibleTextRendering = True
        Me.btnOpen.UseVisualStyleBackColor = False
        '
        'btnSave
        '
        Me.btnSave.BackColor = System.Drawing.Color.Transparent
        Me.btnSave.BackgroundImage = CType(resources.GetObject("btnSave.BackgroundImage"), System.Drawing.Image)
        Me.btnSave.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnSave.FlatAppearance.BorderSize = 0
        Me.btnSave.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent
        Me.btnSave.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btnSave.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSave.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSave.ForeColor = System.Drawing.Color.Black
        Me.btnSave.Image = CType(resources.GetObject("btnSave.Image"), System.Drawing.Image)
        Me.btnSave.Location = New System.Drawing.Point(41, 281)
        Me.btnSave.Margin = New System.Windows.Forms.Padding(2)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Padding = New System.Windows.Forms.Padding(0, 1, 0, 0)
        Me.btnSave.Size = New System.Drawing.Size(26, 26)
        Me.btnSave.Style = resources.GetString("btnSave.Style")
        Me.btnSave.TabIndex = 4
        Me.btnSave.UseCompatibleTextRendering = True
        Me.btnSave.UseVisualStyleBackColor = False
        '
        'dlgOpen
        '
        Me.dlgOpen.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*"
        '
        'dlgSave
        '
        Me.dlgSave.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*"
        '
        'dlgCustomSymbols
        '
        Me.AcceptButton = Me.btnOK
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.CancelButton = Me.btnCancel
        Me.ClientSize = New System.Drawing.Size(289, 320)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.dgvSymbols)
        Me.Controls.Add(Me.btnOpen)
        Me.Controls.Add(Me.btnDeleteAll)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "dlgCustomSymbols"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Custom Symbols"
        Me.TableLayoutPanel1.ResumeLayout(False)
        CType(Me.dgvSymbols, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents btnCancel As Tundra.StylizedButton
    Friend WithEvents btnOK As Tundra.StylizedButton
    Friend WithEvents dgvSymbols As System.Windows.Forms.DataGridView
    Friend WithEvents btnDeleteAll As Tundra.StylizedButton
    Friend WithEvents btnOpen As Tundra.StylizedButton
    Friend WithEvents btnSave As Tundra.StylizedButton
    Friend WithEvents dlgOpen As System.Windows.Forms.OpenFileDialog
    Friend WithEvents dlgSave As System.Windows.Forms.SaveFileDialog
    Friend WithEvents Symbol As DataGridViewTextBoxColumn
End Class
