<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CharacterEditor
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
        Me.components = New System.ComponentModel.Container()
        Me.tcCharacters = New System.Windows.Forms.TabControl()
        Me.tpFile = New System.Windows.Forms.TabPage()
        Me.FilePanel = New System.Windows.Forms.FlowLayoutPanel()
        Me.tpLocal = New System.Windows.Forms.TabPage()
        Me.LocalCharPanel = New System.Windows.Forms.FlowLayoutPanel()
        Me.tpCommon = New System.Windows.Forms.TabPage()
        Me.CommonLayoutPanel = New System.Windows.Forms.FlowLayoutPanel()
        Me.tpIPA = New System.Windows.Forms.TabPage()
        Me.tcIPA = New System.Windows.Forms.TabControl()
        Me.ConsonantsTabPage = New System.Windows.Forms.TabPage()
        Me.ConsonantsLayoutPanel = New System.Windows.Forms.FlowLayoutPanel()
        Me.AffricatesTabPage = New System.Windows.Forms.TabPage()
        Me.AffricatesLayoutPanel = New System.Windows.Forms.FlowLayoutPanel()
        Me.VowelsTabPage = New System.Windows.Forms.TabPage()
        Me.VowelsLayoutPanel = New System.Windows.Forms.FlowLayoutPanel()
        Me.ToneIntonationTabPage = New System.Windows.Forms.TabPage()
        Me.ToneIntonationLayoutPanel = New System.Windows.Forms.FlowLayoutPanel()
        Me.OtherTabPage = New System.Windows.Forms.TabPage()
        Me.OtherLayoutPanel = New System.Windows.Forms.FlowLayoutPanel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnCharacter = New System.Windows.Forms.Button()
        Me.pnlSmartReplace = New TundraLib.DoubleBufferedPanel()
        Me.cbSmartReplace = New System.Windows.Forms.CheckBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.gbAccents = New System.Windows.Forms.GroupBox()
        Me.AccentsLayoutPanel = New System.Windows.Forms.FlowLayoutPanel()
        Me.txtCharacter = New System.Windows.Forms.TextBox()
        Me.btnAddToFile = New System.Windows.Forms.Button()
        Me.btnAddToLocal = New System.Windows.Forms.Button()
        Me.menuCharButton = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.CopyToEditorMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.CopyToFileMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CopyToLocalMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CopyToClipboardMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.tcCharacters.SuspendLayout()
        Me.tpFile.SuspendLayout()
        Me.tpLocal.SuspendLayout()
        Me.tpCommon.SuspendLayout()
        Me.tpIPA.SuspendLayout()
        Me.tcIPA.SuspendLayout()
        Me.ConsonantsTabPage.SuspendLayout()
        Me.AffricatesTabPage.SuspendLayout()
        Me.VowelsTabPage.SuspendLayout()
        Me.ToneIntonationTabPage.SuspendLayout()
        Me.OtherTabPage.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.gbAccents.SuspendLayout()
        Me.menuCharButton.SuspendLayout()
        Me.SuspendLayout()
        '
        'tcCharacters
        '
        Me.tcCharacters.Controls.Add(Me.tpFile)
        Me.tcCharacters.Controls.Add(Me.tpLocal)
        Me.tcCharacters.Controls.Add(Me.tpCommon)
        Me.tcCharacters.Controls.Add(Me.tpIPA)
        Me.tcCharacters.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tcCharacters.Location = New System.Drawing.Point(0, 315)
        Me.tcCharacters.Name = "tcCharacters"
        Me.tcCharacters.SelectedIndex = 0
        Me.tcCharacters.Size = New System.Drawing.Size(293, 341)
        Me.tcCharacters.TabIndex = 74
        '
        'tpFile
        '
        Me.tpFile.Controls.Add(Me.FilePanel)
        Me.tpFile.Location = New System.Drawing.Point(4, 22)
        Me.tpFile.Name = "tpFile"
        Me.tpFile.Padding = New System.Windows.Forms.Padding(3)
        Me.tpFile.Size = New System.Drawing.Size(285, 315)
        Me.tpFile.TabIndex = 0
        Me.tpFile.Text = "File"
        Me.tpFile.UseVisualStyleBackColor = True
        '
        'FilePanel
        '
        Me.FilePanel.AutoScroll = True
        Me.FilePanel.AutoScrollMargin = New System.Drawing.Size(0, 5)
        Me.FilePanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.FilePanel.Location = New System.Drawing.Point(3, 3)
        Me.FilePanel.Margin = New System.Windows.Forms.Padding(4)
        Me.FilePanel.Name = "FilePanel"
        Me.FilePanel.Padding = New System.Windows.Forms.Padding(4, 4, 0, 4)
        Me.FilePanel.Size = New System.Drawing.Size(279, 309)
        Me.FilePanel.TabIndex = 10
        '
        'tpLocal
        '
        Me.tpLocal.Controls.Add(Me.LocalCharPanel)
        Me.tpLocal.Location = New System.Drawing.Point(4, 22)
        Me.tpLocal.Name = "tpLocal"
        Me.tpLocal.Padding = New System.Windows.Forms.Padding(3)
        Me.tpLocal.Size = New System.Drawing.Size(285, 315)
        Me.tpLocal.TabIndex = 1
        Me.tpLocal.Text = "Local"
        Me.tpLocal.UseVisualStyleBackColor = True
        '
        'LocalCharPanel
        '
        Me.LocalCharPanel.AutoScroll = True
        Me.LocalCharPanel.AutoScrollMargin = New System.Drawing.Size(0, 5)
        Me.LocalCharPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LocalCharPanel.Location = New System.Drawing.Point(3, 3)
        Me.LocalCharPanel.Margin = New System.Windows.Forms.Padding(4)
        Me.LocalCharPanel.Name = "LocalCharPanel"
        Me.LocalCharPanel.Padding = New System.Windows.Forms.Padding(4, 4, 0, 4)
        Me.LocalCharPanel.Size = New System.Drawing.Size(279, 309)
        Me.LocalCharPanel.TabIndex = 10
        '
        'tpCommon
        '
        Me.tpCommon.Controls.Add(Me.CommonLayoutPanel)
        Me.tpCommon.Location = New System.Drawing.Point(4, 22)
        Me.tpCommon.Name = "tpCommon"
        Me.tpCommon.Padding = New System.Windows.Forms.Padding(3)
        Me.tpCommon.Size = New System.Drawing.Size(285, 315)
        Me.tpCommon.TabIndex = 2
        Me.tpCommon.Text = "Common"
        Me.tpCommon.UseVisualStyleBackColor = True
        '
        'CommonLayoutPanel
        '
        Me.CommonLayoutPanel.AutoScroll = True
        Me.CommonLayoutPanel.AutoScrollMargin = New System.Drawing.Size(0, 5)
        Me.CommonLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CommonLayoutPanel.Location = New System.Drawing.Point(3, 3)
        Me.CommonLayoutPanel.Margin = New System.Windows.Forms.Padding(4)
        Me.CommonLayoutPanel.Name = "CommonLayoutPanel"
        Me.CommonLayoutPanel.Padding = New System.Windows.Forms.Padding(4, 4, 0, 4)
        Me.CommonLayoutPanel.Size = New System.Drawing.Size(279, 309)
        Me.CommonLayoutPanel.TabIndex = 9
        '
        'tpIPA
        '
        Me.tpIPA.Controls.Add(Me.tcIPA)
        Me.tpIPA.Location = New System.Drawing.Point(4, 22)
        Me.tpIPA.Name = "tpIPA"
        Me.tpIPA.Padding = New System.Windows.Forms.Padding(3)
        Me.tpIPA.Size = New System.Drawing.Size(285, 315)
        Me.tpIPA.TabIndex = 3
        Me.tpIPA.Text = "IPA"
        Me.tpIPA.UseVisualStyleBackColor = True
        '
        'tcIPA
        '
        Me.tcIPA.Controls.Add(Me.ConsonantsTabPage)
        Me.tcIPA.Controls.Add(Me.AffricatesTabPage)
        Me.tcIPA.Controls.Add(Me.VowelsTabPage)
        Me.tcIPA.Controls.Add(Me.ToneIntonationTabPage)
        Me.tcIPA.Controls.Add(Me.OtherTabPage)
        Me.tcIPA.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tcIPA.Location = New System.Drawing.Point(3, 3)
        Me.tcIPA.Margin = New System.Windows.Forms.Padding(2)
        Me.tcIPA.Name = "tcIPA"
        Me.tcIPA.SelectedIndex = 0
        Me.tcIPA.Size = New System.Drawing.Size(279, 309)
        Me.tcIPA.TabIndex = 72
        '
        'ConsonantsTabPage
        '
        Me.ConsonantsTabPage.Controls.Add(Me.ConsonantsLayoutPanel)
        Me.ConsonantsTabPage.Location = New System.Drawing.Point(4, 22)
        Me.ConsonantsTabPage.Margin = New System.Windows.Forms.Padding(2)
        Me.ConsonantsTabPage.Name = "ConsonantsTabPage"
        Me.ConsonantsTabPage.Size = New System.Drawing.Size(271, 283)
        Me.ConsonantsTabPage.TabIndex = 0
        Me.ConsonantsTabPage.Text = "Consonants"
        Me.ConsonantsTabPage.UseVisualStyleBackColor = True
        '
        'ConsonantsLayoutPanel
        '
        Me.ConsonantsLayoutPanel.AutoScroll = True
        Me.ConsonantsLayoutPanel.AutoScrollMargin = New System.Drawing.Size(15, 5)
        Me.ConsonantsLayoutPanel.AutoSize = True
        Me.ConsonantsLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ConsonantsLayoutPanel.Location = New System.Drawing.Point(0, 0)
        Me.ConsonantsLayoutPanel.Margin = New System.Windows.Forms.Padding(4)
        Me.ConsonantsLayoutPanel.Name = "ConsonantsLayoutPanel"
        Me.ConsonantsLayoutPanel.Padding = New System.Windows.Forms.Padding(4, 4, 0, 4)
        Me.ConsonantsLayoutPanel.Size = New System.Drawing.Size(271, 283)
        Me.ConsonantsLayoutPanel.TabIndex = 7
        '
        'AffricatesTabPage
        '
        Me.AffricatesTabPage.Controls.Add(Me.AffricatesLayoutPanel)
        Me.AffricatesTabPage.Location = New System.Drawing.Point(4, 22)
        Me.AffricatesTabPage.Margin = New System.Windows.Forms.Padding(2)
        Me.AffricatesTabPage.Name = "AffricatesTabPage"
        Me.AffricatesTabPage.Size = New System.Drawing.Size(271, 283)
        Me.AffricatesTabPage.TabIndex = 5
        Me.AffricatesTabPage.Text = "Affricates"
        Me.AffricatesTabPage.UseVisualStyleBackColor = True
        '
        'AffricatesLayoutPanel
        '
        Me.AffricatesLayoutPanel.AutoScroll = True
        Me.AffricatesLayoutPanel.AutoScrollMargin = New System.Drawing.Size(0, 5)
        Me.AffricatesLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.AffricatesLayoutPanel.Location = New System.Drawing.Point(0, 0)
        Me.AffricatesLayoutPanel.Margin = New System.Windows.Forms.Padding(4)
        Me.AffricatesLayoutPanel.Name = "AffricatesLayoutPanel"
        Me.AffricatesLayoutPanel.Padding = New System.Windows.Forms.Padding(4, 4, 0, 4)
        Me.AffricatesLayoutPanel.Size = New System.Drawing.Size(271, 283)
        Me.AffricatesLayoutPanel.TabIndex = 8
        '
        'VowelsTabPage
        '
        Me.VowelsTabPage.Controls.Add(Me.VowelsLayoutPanel)
        Me.VowelsTabPage.Location = New System.Drawing.Point(4, 22)
        Me.VowelsTabPage.Margin = New System.Windows.Forms.Padding(2)
        Me.VowelsTabPage.Name = "VowelsTabPage"
        Me.VowelsTabPage.Size = New System.Drawing.Size(271, 283)
        Me.VowelsTabPage.TabIndex = 1
        Me.VowelsTabPage.Text = "Vowels"
        Me.VowelsTabPage.UseVisualStyleBackColor = True
        '
        'VowelsLayoutPanel
        '
        Me.VowelsLayoutPanel.AutoScroll = True
        Me.VowelsLayoutPanel.AutoScrollMargin = New System.Drawing.Size(0, 5)
        Me.VowelsLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.VowelsLayoutPanel.Location = New System.Drawing.Point(0, 0)
        Me.VowelsLayoutPanel.Margin = New System.Windows.Forms.Padding(4)
        Me.VowelsLayoutPanel.Name = "VowelsLayoutPanel"
        Me.VowelsLayoutPanel.Padding = New System.Windows.Forms.Padding(4, 4, 0, 4)
        Me.VowelsLayoutPanel.Size = New System.Drawing.Size(271, 283)
        Me.VowelsLayoutPanel.TabIndex = 8
        '
        'ToneIntonationTabPage
        '
        Me.ToneIntonationTabPage.Controls.Add(Me.ToneIntonationLayoutPanel)
        Me.ToneIntonationTabPage.Location = New System.Drawing.Point(4, 22)
        Me.ToneIntonationTabPage.Margin = New System.Windows.Forms.Padding(2)
        Me.ToneIntonationTabPage.Name = "ToneIntonationTabPage"
        Me.ToneIntonationTabPage.Size = New System.Drawing.Size(271, 283)
        Me.ToneIntonationTabPage.TabIndex = 4
        Me.ToneIntonationTabPage.Text = "Tone"
        Me.ToneIntonationTabPage.UseVisualStyleBackColor = True
        '
        'ToneIntonationLayoutPanel
        '
        Me.ToneIntonationLayoutPanel.AutoScroll = True
        Me.ToneIntonationLayoutPanel.AutoScrollMargin = New System.Drawing.Size(0, 5)
        Me.ToneIntonationLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ToneIntonationLayoutPanel.Location = New System.Drawing.Point(0, 0)
        Me.ToneIntonationLayoutPanel.Margin = New System.Windows.Forms.Padding(4)
        Me.ToneIntonationLayoutPanel.Name = "ToneIntonationLayoutPanel"
        Me.ToneIntonationLayoutPanel.Padding = New System.Windows.Forms.Padding(4, 4, 0, 4)
        Me.ToneIntonationLayoutPanel.Size = New System.Drawing.Size(271, 283)
        Me.ToneIntonationLayoutPanel.TabIndex = 10
        '
        'OtherTabPage
        '
        Me.OtherTabPage.Controls.Add(Me.OtherLayoutPanel)
        Me.OtherTabPage.Location = New System.Drawing.Point(4, 22)
        Me.OtherTabPage.Margin = New System.Windows.Forms.Padding(2)
        Me.OtherTabPage.Name = "OtherTabPage"
        Me.OtherTabPage.Size = New System.Drawing.Size(271, 283)
        Me.OtherTabPage.TabIndex = 2
        Me.OtherTabPage.Text = "Other"
        Me.OtherTabPage.UseVisualStyleBackColor = True
        '
        'OtherLayoutPanel
        '
        Me.OtherLayoutPanel.AutoScroll = True
        Me.OtherLayoutPanel.AutoScrollMargin = New System.Drawing.Size(0, 5)
        Me.OtherLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.OtherLayoutPanel.Location = New System.Drawing.Point(0, 0)
        Me.OtherLayoutPanel.Margin = New System.Windows.Forms.Padding(4)
        Me.OtherLayoutPanel.Name = "OtherLayoutPanel"
        Me.OtherLayoutPanel.Padding = New System.Windows.Forms.Padding(4, 4, 0, 4)
        Me.OtherLayoutPanel.Size = New System.Drawing.Size(271, 283)
        Me.OtherLayoutPanel.TabIndex = 8
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.btnCharacter)
        Me.Panel1.Controls.Add(Me.pnlSmartReplace)
        Me.Panel1.Controls.Add(Me.cbSmartReplace)
        Me.Panel1.Controls.Add(Me.Button1)
        Me.Panel1.Controls.Add(Me.gbAccents)
        Me.Panel1.Controls.Add(Me.txtCharacter)
        Me.Panel1.Controls.Add(Me.btnAddToFile)
        Me.Panel1.Controls.Add(Me.btnAddToLocal)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Padding = New System.Windows.Forms.Padding(6)
        Me.Panel1.Size = New System.Drawing.Size(293, 315)
        Me.Panel1.TabIndex = 75
        '
        'btnCharacter
        '
        Me.btnCharacter.Font = New System.Drawing.Font("Calibri", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCharacter.Location = New System.Drawing.Point(9, 9)
        Me.btnCharacter.Name = "btnCharacter"
        Me.btnCharacter.Size = New System.Drawing.Size(80, 80)
        Me.btnCharacter.TabIndex = 88
        Me.btnCharacter.Text = "a"
        Me.btnCharacter.UseVisualStyleBackColor = True
        '
        'pnlSmartReplace
        '
        Me.pnlSmartReplace.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.pnlSmartReplace.BackColor = System.Drawing.Color.DimGray
        Me.pnlSmartReplace.Location = New System.Drawing.Point(95, 11)
        Me.pnlSmartReplace.Margin = New System.Windows.Forms.Padding(2)
        Me.pnlSmartReplace.Name = "pnlSmartReplace"
        Me.pnlSmartReplace.Size = New System.Drawing.Size(14, 15)
        Me.pnlSmartReplace.TabIndex = 87
        '
        'cbSmartReplace
        '
        Me.cbSmartReplace.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.cbSmartReplace.AutoSize = True
        Me.cbSmartReplace.Checked = True
        Me.cbSmartReplace.CheckState = System.Windows.Forms.CheckState.Checked
        Me.cbSmartReplace.Location = New System.Drawing.Point(113, 10)
        Me.cbSmartReplace.Margin = New System.Windows.Forms.Padding(2)
        Me.cbSmartReplace.Name = "cbSmartReplace"
        Me.cbSmartReplace.Size = New System.Drawing.Size(96, 17)
        Me.cbSmartReplace.TabIndex = 86
        Me.cbSmartReplace.Text = "Smart Replace"
        Me.cbSmartReplace.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Button1.Location = New System.Drawing.Point(95, 57)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(60, 32)
        Me.Button1.TabIndex = 79
        Me.Button1.Text = "Copy"
        '
        'gbAccents
        '
        Me.gbAccents.Controls.Add(Me.AccentsLayoutPanel)
        Me.gbAccents.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.gbAccents.Location = New System.Drawing.Point(6, 95)
        Me.gbAccents.Name = "gbAccents"
        Me.gbAccents.Size = New System.Drawing.Size(281, 214)
        Me.gbAccents.TabIndex = 78
        Me.gbAccents.TabStop = False
        Me.gbAccents.Text = "Accent Marks"
        '
        'AccentsLayoutPanel
        '
        Me.AccentsLayoutPanel.AutoScroll = True
        Me.AccentsLayoutPanel.AutoScrollMargin = New System.Drawing.Size(0, 5)
        Me.AccentsLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.AccentsLayoutPanel.Location = New System.Drawing.Point(3, 16)
        Me.AccentsLayoutPanel.Margin = New System.Windows.Forms.Padding(4)
        Me.AccentsLayoutPanel.Name = "AccentsLayoutPanel"
        Me.AccentsLayoutPanel.Padding = New System.Windows.Forms.Padding(4, 4, 0, 4)
        Me.AccentsLayoutPanel.Size = New System.Drawing.Size(275, 195)
        Me.AccentsLayoutPanel.TabIndex = 10
        '
        'txtCharacter
        '
        Me.txtCharacter.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.txtCharacter.Location = New System.Drawing.Point(95, 31)
        Me.txtCharacter.Name = "txtCharacter"
        Me.txtCharacter.Size = New System.Drawing.Size(192, 20)
        Me.txtCharacter.TabIndex = 77
        '
        'btnAddToFile
        '
        Me.btnAddToFile.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.btnAddToFile.Location = New System.Drawing.Point(161, 57)
        Me.btnAddToFile.Name = "btnAddToFile"
        Me.btnAddToFile.Size = New System.Drawing.Size(60, 32)
        Me.btnAddToFile.TabIndex = 76
        Me.btnAddToFile.Text = "File"
        '
        'btnAddToLocal
        '
        Me.btnAddToLocal.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.btnAddToLocal.Location = New System.Drawing.Point(227, 57)
        Me.btnAddToLocal.Name = "btnAddToLocal"
        Me.btnAddToLocal.Size = New System.Drawing.Size(60, 32)
        Me.btnAddToLocal.TabIndex = 1
        Me.btnAddToLocal.Text = "Local"
        '
        'menuCharButton
        '
        Me.menuCharButton.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CopyToEditorMenuItem, Me.ToolStripSeparator1, Me.CopyToClipboardMenuItem, Me.CopyToFileMenuItem, Me.CopyToLocalMenuItem})
        Me.menuCharButton.Name = "menuCharButton"
        Me.menuCharButton.Size = New System.Drawing.Size(181, 120)
        '
        'CopyToEditorMenuItem
        '
        Me.CopyToEditorMenuItem.Name = "CopyToEditorMenuItem"
        Me.CopyToEditorMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.CopyToEditorMenuItem.Text = "Copy to Editor"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(168, 6)
        '
        'CopyToFileMenuItem
        '
        Me.CopyToFileMenuItem.Name = "CopyToFileMenuItem"
        Me.CopyToFileMenuItem.Size = New System.Drawing.Size(171, 22)
        Me.CopyToFileMenuItem.Text = "Copy to File"
        '
        'CopyToLocalMenuItem
        '
        Me.CopyToLocalMenuItem.Name = "CopyToLocalMenuItem"
        Me.CopyToLocalMenuItem.Size = New System.Drawing.Size(171, 22)
        Me.CopyToLocalMenuItem.Text = "Copy to Local"
        '
        'CopyToClipboardMenuItem
        '
        Me.CopyToClipboardMenuItem.Name = "CopyToClipboardMenuItem"
        Me.CopyToClipboardMenuItem.Size = New System.Drawing.Size(171, 22)
        Me.CopyToClipboardMenuItem.Text = "Copy to Clipboard"
        Me.CopyToClipboardMenuItem.TextImageRelation = System.Windows.Forms.TextImageRelation.Overlay
        '
        'CharacterEditor
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.tcCharacters)
        Me.Controls.Add(Me.Panel1)
        Me.MinimumSize = New System.Drawing.Size(293, 0)
        Me.Name = "CharacterEditor"
        Me.Size = New System.Drawing.Size(293, 656)
        Me.tcCharacters.ResumeLayout(False)
        Me.tpFile.ResumeLayout(False)
        Me.tpLocal.ResumeLayout(False)
        Me.tpCommon.ResumeLayout(False)
        Me.tpIPA.ResumeLayout(False)
        Me.tcIPA.ResumeLayout(False)
        Me.ConsonantsTabPage.ResumeLayout(False)
        Me.ConsonantsTabPage.PerformLayout()
        Me.AffricatesTabPage.ResumeLayout(False)
        Me.VowelsTabPage.ResumeLayout(False)
        Me.ToneIntonationTabPage.ResumeLayout(False)
        Me.OtherTabPage.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.gbAccents.ResumeLayout(False)
        Me.menuCharButton.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents tcCharacters As TabControl
    Friend WithEvents tpFile As TabPage
    Friend WithEvents tpLocal As TabPage
    Friend WithEvents tpCommon As TabPage
    Friend WithEvents CommonLayoutPanel As FlowLayoutPanel
    Friend WithEvents tpIPA As TabPage
    Friend WithEvents tcIPA As TabControl
    Friend WithEvents ConsonantsTabPage As TabPage
    Friend WithEvents ConsonantsLayoutPanel As FlowLayoutPanel
    Friend WithEvents AffricatesTabPage As TabPage
    Friend WithEvents AffricatesLayoutPanel As FlowLayoutPanel
    Friend WithEvents VowelsTabPage As TabPage
    Friend WithEvents VowelsLayoutPanel As FlowLayoutPanel
    Friend WithEvents ToneIntonationTabPage As TabPage
    Friend WithEvents ToneIntonationLayoutPanel As FlowLayoutPanel
    Friend WithEvents OtherTabPage As TabPage
    Friend WithEvents OtherLayoutPanel As FlowLayoutPanel
    Friend WithEvents FilePanel As FlowLayoutPanel
    Friend WithEvents LocalCharPanel As FlowLayoutPanel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents gbAccents As GroupBox
    Friend WithEvents AccentsLayoutPanel As FlowLayoutPanel
    Friend WithEvents txtCharacter As TextBox
    Friend WithEvents btnAddToFile As Button
    Friend WithEvents btnAddToLocal As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents pnlSmartReplace As TundraLib.DoubleBufferedPanel
    Friend WithEvents cbSmartReplace As CheckBox
    Friend WithEvents btnCharacter As Button
    Friend WithEvents menuCharButton As ContextMenuStrip
    Friend WithEvents CopyToEditorMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents CopyToFileMenuItem As ToolStripMenuItem
    Friend WithEvents CopyToLocalMenuItem As ToolStripMenuItem
    Friend WithEvents CopyToClipboardMenuItem As ToolStripMenuItem
End Class
