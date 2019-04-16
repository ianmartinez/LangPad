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
        Me.cbAffricates = New System.Windows.Forms.CheckBox()
        Me.cbConsonants = New System.Windows.Forms.CheckBox()
        Me.cbTones = New System.Windows.Forms.CheckBox()
        Me.cbVowels = New System.Windows.Forms.CheckBox()
        Me.cbOther = New System.Windows.Forms.CheckBox()
        Me.cbCommon = New System.Windows.Forms.CheckBox()
        Me.cbUpdates = New System.Windows.Forms.CheckBox()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.btnOK = New System.Windows.Forms.Button()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.cbSmartReplace = New System.Windows.Forms.CheckBox()
        Me.gbLoadOnStartup = New System.Windows.Forms.GroupBox()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.gbLoadOnStartup.SuspendLayout()
        Me.SuspendLayout()
        '
        'cbAffricates
        '
        Me.cbAffricates.AutoSize = True
        Me.cbAffricates.Checked = True
        Me.cbAffricates.CheckState = System.Windows.Forms.CheckState.Checked
        Me.cbAffricates.Location = New System.Drawing.Point(6, 19)
        Me.cbAffricates.Name = "cbAffricates"
        Me.cbAffricates.Size = New System.Drawing.Size(90, 17)
        Me.cbAffricates.TabIndex = 1
        Me.cbAffricates.Text = "IPA Affricates"
        Me.cbAffricates.UseVisualStyleBackColor = True
        '
        'cbConsonants
        '
        Me.cbConsonants.AutoSize = True
        Me.cbConsonants.Checked = True
        Me.cbConsonants.CheckState = System.Windows.Forms.CheckState.Checked
        Me.cbConsonants.Location = New System.Drawing.Point(6, 42)
        Me.cbConsonants.Name = "cbConsonants"
        Me.cbConsonants.Size = New System.Drawing.Size(102, 17)
        Me.cbConsonants.TabIndex = 2
        Me.cbConsonants.Text = "IPA Consonants"
        Me.cbConsonants.UseVisualStyleBackColor = True
        '
        'cbTones
        '
        Me.cbTones.AutoSize = True
        Me.cbTones.Checked = True
        Me.cbTones.CheckState = System.Windows.Forms.CheckState.Checked
        Me.cbTones.Location = New System.Drawing.Point(6, 65)
        Me.cbTones.Name = "cbTones"
        Me.cbTones.Size = New System.Drawing.Size(76, 17)
        Me.cbTones.TabIndex = 3
        Me.cbTones.Text = "IPA Tones"
        Me.cbTones.UseVisualStyleBackColor = True
        '
        'cbVowels
        '
        Me.cbVowels.AutoSize = True
        Me.cbVowels.Checked = True
        Me.cbVowels.CheckState = System.Windows.Forms.CheckState.Checked
        Me.cbVowels.Location = New System.Drawing.Point(6, 88)
        Me.cbVowels.Name = "cbVowels"
        Me.cbVowels.Size = New System.Drawing.Size(80, 17)
        Me.cbVowels.TabIndex = 4
        Me.cbVowels.Text = "IPA Vowels"
        Me.cbVowels.UseVisualStyleBackColor = True
        '
        'cbOther
        '
        Me.cbOther.AutoSize = True
        Me.cbOther.Checked = True
        Me.cbOther.CheckState = System.Windows.Forms.CheckState.Checked
        Me.cbOther.Location = New System.Drawing.Point(6, 111)
        Me.cbOther.Name = "cbOther"
        Me.cbOther.Size = New System.Drawing.Size(126, 17)
        Me.cbOther.TabIndex = 5
        Me.cbOther.Text = "Other IPA Characters"
        Me.cbOther.UseVisualStyleBackColor = True
        '
        'cbCommon
        '
        Me.cbCommon.AutoSize = True
        Me.cbCommon.Checked = True
        Me.cbCommon.CheckState = System.Windows.Forms.CheckState.Checked
        Me.cbCommon.Location = New System.Drawing.Point(6, 131)
        Me.cbCommon.Name = "cbCommon"
        Me.cbCommon.Size = New System.Drawing.Size(121, 17)
        Me.cbCommon.TabIndex = 6
        Me.cbCommon.Text = "Common Characters"
        Me.cbCommon.UseVisualStyleBackColor = True
        '
        'cbUpdates
        '
        Me.cbUpdates.AutoSize = True
        Me.cbUpdates.Checked = True
        Me.cbUpdates.CheckState = System.Windows.Forms.CheckState.Checked
        Me.cbUpdates.Location = New System.Drawing.Point(6, 173)
        Me.cbUpdates.Name = "cbUpdates"
        Me.cbUpdates.Size = New System.Drawing.Size(66, 17)
        Me.cbUpdates.TabIndex = 8
        Me.cbUpdates.Text = "Updates"
        Me.cbUpdates.UseVisualStyleBackColor = True
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.btnOK, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.btnCancel, 1, 0)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(132, 219)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(146, 29)
        Me.TableLayoutPanel1.TabIndex = 75
        '
        'btnOK
        '
        Me.btnOK.BackColor = System.Drawing.Color.Transparent
        Me.btnOK.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnOK.Location = New System.Drawing.Point(2, 2)
        Me.btnOK.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btnOK.Name = "btnOK"
        Me.btnOK.Size = New System.Drawing.Size(69, 25)
        Me.btnOK.TabIndex = 1
        Me.btnOK.Text = "OK"
        Me.btnOK.UseVisualStyleBackColor = False
        '
        'btnCancel
        '
        Me.btnCancel.BackColor = System.Drawing.Color.Transparent
        Me.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnCancel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnCancel.Location = New System.Drawing.Point(75, 2)
        Me.btnCancel.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(69, 25)
        Me.btnCancel.TabIndex = 0
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = False
        '
        'cbSmartReplace
        '
        Me.cbSmartReplace.AutoSize = True
        Me.cbSmartReplace.Checked = True
        Me.cbSmartReplace.CheckState = System.Windows.Forms.CheckState.Checked
        Me.cbSmartReplace.Location = New System.Drawing.Point(6, 152)
        Me.cbSmartReplace.Name = "cbSmartReplace"
        Me.cbSmartReplace.Size = New System.Drawing.Size(96, 17)
        Me.cbSmartReplace.TabIndex = 7
        Me.cbSmartReplace.Text = "Smart Replace"
        Me.cbSmartReplace.UseVisualStyleBackColor = True
        '
        'gbLoadOnStartup
        '
        Me.gbLoadOnStartup.Controls.Add(Me.cbSmartReplace)
        Me.gbLoadOnStartup.Controls.Add(Me.cbAffricates)
        Me.gbLoadOnStartup.Controls.Add(Me.cbConsonants)
        Me.gbLoadOnStartup.Controls.Add(Me.cbUpdates)
        Me.gbLoadOnStartup.Controls.Add(Me.cbTones)
        Me.gbLoadOnStartup.Controls.Add(Me.cbCommon)
        Me.gbLoadOnStartup.Controls.Add(Me.cbVowels)
        Me.gbLoadOnStartup.Controls.Add(Me.cbOther)
        Me.gbLoadOnStartup.Location = New System.Drawing.Point(12, 12)
        Me.gbLoadOnStartup.Name = "gbLoadOnStartup"
        Me.gbLoadOnStartup.Size = New System.Drawing.Size(261, 200)
        Me.gbLoadOnStartup.TabIndex = 76
        Me.gbLoadOnStartup.TabStop = False
        Me.gbLoadOnStartup.Text = "Load On Startup"
        '
        'dlgSettings
        '
        Me.AcceptButton = Me.btnOK
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btnCancel
        Me.ClientSize = New System.Drawing.Size(285, 256)
        Me.Controls.Add(Me.gbLoadOnStartup)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "dlgSettings"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Settings"
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.gbLoadOnStartup.ResumeLayout(False)
        Me.gbLoadOnStartup.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents cbAffricates As CheckBox
    Friend WithEvents cbConsonants As CheckBox
    Friend WithEvents cbTones As CheckBox
    Friend WithEvents cbVowels As CheckBox
    Friend WithEvents cbOther As CheckBox
    Friend WithEvents cbCommon As CheckBox
    Friend WithEvents cbUpdates As CheckBox
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents btnOK As Button
    Friend WithEvents btnCancel As Button
    Friend WithEvents cbSmartReplace As CheckBox
    Friend WithEvents gbLoadOnStartup As GroupBox
End Class
