<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UpdateDialog
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(UpdateDialog))
        Me.StatusLabel = New System.Windows.Forms.Label()
        Me.DescriptionTextBox = New System.Windows.Forms.TextBox()
        Me.MainTooltip = New System.Windows.Forms.ToolTip(Me.components)
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.SourceButton = New System.Windows.Forms.Button()
        Me.RedditButton = New System.Windows.Forms.Button()
        Me.CancelDialogButton = New System.Windows.Forms.Button()
        Me.OkDialogButton = New System.Windows.Forms.Button()
        Me.StylizedPanel1 = New TundraLib.DoubleBufferedPanel()
        Me.LanguagePadLabel = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.StylizedPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'StatusLabel
        '
        Me.StatusLabel.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.StatusLabel.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.StatusLabel.ForeColor = System.Drawing.Color.White
        Me.StatusLabel.Location = New System.Drawing.Point(0, 131)
        Me.StatusLabel.Margin = New System.Windows.Forms.Padding(3)
        Me.StatusLabel.Name = "StatusLabel"
        Me.StatusLabel.Size = New System.Drawing.Size(868, 43)
        Me.StatusLabel.TabIndex = 74
        Me.StatusLabel.Text = "The update ""Language Pad {0}"" is available."
        Me.StatusLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'DescriptionTextBox
        '
        Me.DescriptionTextBox.BackColor = System.Drawing.SystemColors.Window
        Me.DescriptionTextBox.Location = New System.Drawing.Point(16, 220)
        Me.DescriptionTextBox.Multiline = True
        Me.DescriptionTextBox.Name = "DescriptionTextBox"
        Me.DescriptionTextBox.ReadOnly = True
        Me.DescriptionTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.DescriptionTextBox.Size = New System.Drawing.Size(834, 493)
        Me.DescriptionTextBox.TabIndex = 75
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 4
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.SourceButton, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.RedditButton, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.CancelDialogButton, 3, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.OkDialogButton, 2, 0)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 721)
        Me.TableLayoutPanel1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.Padding = New System.Windows.Forms.Padding(5)
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(868, 64)
        Me.TableLayoutPanel1.TabIndex = 78
        '
        'SourceButton
        '
        Me.SourceButton.BackColor = System.Drawing.Color.Transparent
        Me.SourceButton.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SourceButton.Location = New System.Drawing.Point(8, 8)
        Me.SourceButton.Name = "SourceButton"
        Me.SourceButton.Size = New System.Drawing.Size(208, 48)
        Me.SourceButton.TabIndex = 3
        Me.SourceButton.Text = "View Source"
        Me.SourceButton.UseVisualStyleBackColor = False
        '
        'RedditButton
        '
        Me.RedditButton.BackColor = System.Drawing.Color.Transparent
        Me.RedditButton.Dock = System.Windows.Forms.DockStyle.Fill
        Me.RedditButton.Location = New System.Drawing.Point(222, 8)
        Me.RedditButton.Name = "RedditButton"
        Me.RedditButton.Size = New System.Drawing.Size(208, 48)
        Me.RedditButton.TabIndex = 2
        Me.RedditButton.Text = "View Reddit Thread"
        Me.RedditButton.UseVisualStyleBackColor = False
        '
        'CancelDialogButton
        '
        Me.CancelDialogButton.BackColor = System.Drawing.Color.Transparent
        Me.CancelDialogButton.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.CancelDialogButton.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CancelDialogButton.Location = New System.Drawing.Point(650, 8)
        Me.CancelDialogButton.Name = "CancelDialogButton"
        Me.CancelDialogButton.Size = New System.Drawing.Size(210, 48)
        Me.CancelDialogButton.TabIndex = 0
        Me.CancelDialogButton.Text = "Close"
        Me.CancelDialogButton.UseVisualStyleBackColor = False
        '
        'OkDialogButton
        '
        Me.OkDialogButton.BackColor = System.Drawing.Color.Transparent
        Me.OkDialogButton.Dock = System.Windows.Forms.DockStyle.Fill
        Me.OkDialogButton.Location = New System.Drawing.Point(436, 8)
        Me.OkDialogButton.Name = "OkDialogButton"
        Me.OkDialogButton.Size = New System.Drawing.Size(208, 48)
        Me.OkDialogButton.TabIndex = 1
        Me.OkDialogButton.Text = "Download Update"
        Me.OkDialogButton.UseVisualStyleBackColor = False
        '
        'StylizedPanel1
        '
        Me.StylizedPanel1.BackColor = System.Drawing.Color.Transparent
        Me.StylizedPanel1.BackgroundImage = CType(resources.GetObject("StylizedPanel1.BackgroundImage"), System.Drawing.Image)
        Me.StylizedPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.StylizedPanel1.Controls.Add(Me.LanguagePadLabel)
        Me.StylizedPanel1.Controls.Add(Me.StatusLabel)
        Me.StylizedPanel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.StylizedPanel1.Location = New System.Drawing.Point(0, 0)
        Me.StylizedPanel1.Name = "StylizedPanel1"
        Me.StylizedPanel1.Size = New System.Drawing.Size(868, 174)
        Me.StylizedPanel1.TabIndex = 79
        '
        'LanguagePadLabel
        '
        Me.LanguagePadLabel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LanguagePadLabel.Font = New System.Drawing.Font("Tahoma", 22.125!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LanguagePadLabel.ForeColor = System.Drawing.Color.White
        Me.LanguagePadLabel.Location = New System.Drawing.Point(0, 0)
        Me.LanguagePadLabel.Name = "LanguagePadLabel"
        Me.LanguagePadLabel.Size = New System.Drawing.Size(868, 131)
        Me.LanguagePadLabel.TabIndex = 12
        Me.LanguagePadLabel.Text = "Language Pad"
        Me.LanguagePadLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.875!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 188)
        Me.Label1.Margin = New System.Windows.Forms.Padding(9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(100, 20)
        Me.Label1.TabIndex = 80
        Me.Label1.Text = "Changelog:"
        '
        'UpdateDialog
        '
        Me.AcceptButton = Me.OkDialogButton
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(868, 785)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.StylizedPanel1)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Controls.Add(Me.DescriptionTextBox)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "UpdateDialog"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Update"
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.StylizedPanel1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents StatusLabel As Label
    Friend WithEvents DescriptionTextBox As TextBox
    Friend WithEvents MainTooltip As ToolTip
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents OkDialogButton As Button
    Friend WithEvents CancelDialogButton As Button
    Friend WithEvents StylizedPanel1 As TundraLib.DoubleBufferedPanel
    Friend WithEvents LanguagePadLabel As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents RedditButton As Button
    Friend WithEvents SourceButton As Button
End Class
