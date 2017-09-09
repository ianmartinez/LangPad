<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class dlgSettings
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(dlgSettings))
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.btnCancel = New Tundra.StylizedButton()
        Me.btnOK = New Tundra.StylizedButton()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cbAccent = New System.Windows.Forms.CheckBox()
        Me.cbAffricates = New System.Windows.Forms.CheckBox()
        Me.cbConsonants = New System.Windows.Forms.CheckBox()
        Me.cbTones = New System.Windows.Forms.CheckBox()
        Me.cbVowels = New System.Windows.Forms.CheckBox()
        Me.cbOther = New System.Windows.Forms.CheckBox()
        Me.cbCommon = New System.Windows.Forms.CheckBox()
        Me.cbUpdates = New System.Windows.Forms.CheckBox()
        Me.TableLayoutPanel1.SuspendLayout()
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
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(254, 403)
        Me.TableLayoutPanel1.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 56.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(292, 56)
        Me.TableLayoutPanel1.TabIndex = 70
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
        Me.btnCancel.Location = New System.Drawing.Point(150, 4)
        Me.btnCancel.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Padding = New System.Windows.Forms.Padding(0, 2, 0, 0)
        Me.btnCancel.Size = New System.Drawing.Size(138, 48)
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
        Me.btnOK.Location = New System.Drawing.Point(4, 4)
        Me.btnOK.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnOK.Name = "btnOK"
        Me.btnOK.Padding = New System.Windows.Forms.Padding(0, 2, 0, 0)
        Me.btnOK.Size = New System.Drawing.Size(138, 48)
        Me.btnOK.Style = resources.GetString("btnOK.Style")
        Me.btnOK.TabIndex = 0
        Me.btnOK.Text = "OK"
        Me.btnOK.UseCompatibleTextRendering = True
        Me.btnOK.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(24, 17)
        Me.Label1.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(175, 25)
        Me.Label1.TabIndex = 71
        Me.Label1.Text = "Load On Startup:"
        '
        'cbAccent
        '
        Me.cbAccent.AutoSize = True
        Me.cbAccent.Checked = True
        Me.cbAccent.CheckState = System.Windows.Forms.CheckState.Checked
        Me.cbAccent.Location = New System.Drawing.Point(30, 54)
        Me.cbAccent.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.cbAccent.Name = "cbAccent"
        Me.cbAccent.Size = New System.Drawing.Size(175, 29)
        Me.cbAccent.TabIndex = 0
        Me.cbAccent.Text = "Accent Marks"
        Me.cbAccent.UseVisualStyleBackColor = True
        '
        'cbAffricates
        '
        Me.cbAffricates.AutoSize = True
        Me.cbAffricates.Checked = True
        Me.cbAffricates.CheckState = System.Windows.Forms.CheckState.Checked
        Me.cbAffricates.Location = New System.Drawing.Point(30, 98)
        Me.cbAffricates.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.cbAffricates.Name = "cbAffricates"
        Me.cbAffricates.Size = New System.Drawing.Size(173, 29)
        Me.cbAffricates.TabIndex = 1
        Me.cbAffricates.Text = "IPA Affricates"
        Me.cbAffricates.UseVisualStyleBackColor = True
        '
        'cbConsonants
        '
        Me.cbConsonants.AutoSize = True
        Me.cbConsonants.Checked = True
        Me.cbConsonants.CheckState = System.Windows.Forms.CheckState.Checked
        Me.cbConsonants.Location = New System.Drawing.Point(30, 142)
        Me.cbConsonants.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.cbConsonants.Name = "cbConsonants"
        Me.cbConsonants.Size = New System.Drawing.Size(198, 29)
        Me.cbConsonants.TabIndex = 2
        Me.cbConsonants.Text = "IPA Consonants"
        Me.cbConsonants.UseVisualStyleBackColor = True
        '
        'cbTones
        '
        Me.cbTones.AutoSize = True
        Me.cbTones.Checked = True
        Me.cbTones.CheckState = System.Windows.Forms.CheckState.Checked
        Me.cbTones.Location = New System.Drawing.Point(30, 187)
        Me.cbTones.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.cbTones.Name = "cbTones"
        Me.cbTones.Size = New System.Drawing.Size(143, 29)
        Me.cbTones.TabIndex = 3
        Me.cbTones.Text = "IPA Tones"
        Me.cbTones.UseVisualStyleBackColor = True
        '
        'cbVowels
        '
        Me.cbVowels.AutoSize = True
        Me.cbVowels.Checked = True
        Me.cbVowels.CheckState = System.Windows.Forms.CheckState.Checked
        Me.cbVowels.Location = New System.Drawing.Point(30, 231)
        Me.cbVowels.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.cbVowels.Name = "cbVowels"
        Me.cbVowels.Size = New System.Drawing.Size(152, 29)
        Me.cbVowels.TabIndex = 4
        Me.cbVowels.Text = "IPA Vowels"
        Me.cbVowels.UseVisualStyleBackColor = True
        '
        'cbOther
        '
        Me.cbOther.AutoSize = True
        Me.cbOther.Checked = True
        Me.cbOther.CheckState = System.Windows.Forms.CheckState.Checked
        Me.cbOther.Location = New System.Drawing.Point(30, 275)
        Me.cbOther.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.cbOther.Name = "cbOther"
        Me.cbOther.Size = New System.Drawing.Size(247, 29)
        Me.cbOther.TabIndex = 5
        Me.cbOther.Text = "Other IPA Characters"
        Me.cbOther.UseVisualStyleBackColor = True
        '
        'cbCommon
        '
        Me.cbCommon.AutoSize = True
        Me.cbCommon.Checked = True
        Me.cbCommon.CheckState = System.Windows.Forms.CheckState.Checked
        Me.cbCommon.Location = New System.Drawing.Point(30, 313)
        Me.cbCommon.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.cbCommon.Name = "cbCommon"
        Me.cbCommon.Size = New System.Drawing.Size(240, 29)
        Me.cbCommon.TabIndex = 6
        Me.cbCommon.Text = "Common Characters"
        Me.cbCommon.UseVisualStyleBackColor = True
        '
        'cbUpdates
        '
        Me.cbUpdates.AutoSize = True
        Me.cbUpdates.Checked = True
        Me.cbUpdates.CheckState = System.Windows.Forms.CheckState.Checked
        Me.cbUpdates.Location = New System.Drawing.Point(30, 354)
        Me.cbUpdates.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.cbUpdates.Name = "cbUpdates"
        Me.cbUpdates.Size = New System.Drawing.Size(124, 29)
        Me.cbUpdates.TabIndex = 9
        Me.cbUpdates.Text = "Updates"
        Me.cbUpdates.UseVisualStyleBackColor = True
        '
        'dlgSettings
        '
        Me.AcceptButton = Me.btnOK
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btnCancel
        Me.ClientSize = New System.Drawing.Size(570, 482)
        Me.Controls.Add(Me.cbUpdates)
        Me.Controls.Add(Me.cbCommon)
        Me.Controls.Add(Me.cbOther)
        Me.Controls.Add(Me.cbVowels)
        Me.Controls.Add(Me.cbTones)
        Me.Controls.Add(Me.cbConsonants)
        Me.Controls.Add(Me.cbAffricates)
        Me.Controls.Add(Me.cbAccent)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "dlgSettings"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Settings"
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents btnCancel As Tundra.StylizedButton
    Friend WithEvents btnOK As Tundra.StylizedButton
    Friend WithEvents Label1 As Label
    Friend WithEvents cbAccent As CheckBox
    Friend WithEvents cbAffricates As CheckBox
    Friend WithEvents cbConsonants As CheckBox
    Friend WithEvents cbTones As CheckBox
    Friend WithEvents cbVowels As CheckBox
    Friend WithEvents cbOther As CheckBox
    Friend WithEvents cbCommon As CheckBox
    Friend WithEvents cbUpdates As CheckBox
End Class
