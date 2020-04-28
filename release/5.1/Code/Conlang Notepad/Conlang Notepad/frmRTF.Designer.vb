<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmRTF
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmRTF))
        Me.txtRTF = New System.Windows.Forms.RichTextBox()
        Me.pnlTop = New Tundra.StylizedPanel()
        Me.pnlMain = New Tundra.DoubleBufferedPanel()
        Me.btnRefresh = New Tundra.StylizedButton()
        Me.DoubleBufferedPanel1 = New Tundra.DoubleBufferedPanel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnPaste = New Tundra.StylizedButton()
        Me.btnCut = New Tundra.StylizedButton()
        Me.btnCopy = New Tundra.StylizedButton()
        Me.DoubleBufferedPanel4 = New Tundra.DoubleBufferedPanel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnRedo = New Tundra.StylizedButton()
        Me.btnUndo = New Tundra.StylizedButton()
        Me.DoubleBufferedPanel3 = New Tundra.DoubleBufferedPanel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.pnlTabs = New Tundra.StylizedPanel()
        Me.btnHome = New Tundra.StylizedRadioButton()
        Me.pnlTop.SuspendLayout()
        Me.pnlMain.SuspendLayout()
        Me.pnlTabs.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtRTF
        '
        Me.txtRTF.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtRTF.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtRTF.Font = New System.Drawing.Font("Consolas", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRTF.ForeColor = System.Drawing.Color.Black
        Me.txtRTF.Location = New System.Drawing.Point(0, 116)
        Me.txtRTF.Margin = New System.Windows.Forms.Padding(2)
        Me.txtRTF.Name = "txtRTF"
        Me.txtRTF.Size = New System.Drawing.Size(680, 389)
        Me.txtRTF.TabIndex = 1
        Me.txtRTF.Text = ""
        '
        'pnlTop
        '
        Me.pnlTop.AutoScroll = True
        Me.pnlTop.BackColor = System.Drawing.Color.Transparent
        Me.pnlTop.Controls.Add(Me.pnlMain)
        Me.pnlTop.Controls.Add(Me.pnlTabs)
        Me.pnlTop.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlTop.Location = New System.Drawing.Point(0, 0)
        Me.pnlTop.Margin = New System.Windows.Forms.Padding(2)
        Me.pnlTop.Name = "pnlTop"
        Me.pnlTop.Size = New System.Drawing.Size(680, 116)
        Me.pnlTop.Style = "Colors=~245|~245|~239" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Positions=0|0.8|1" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Angle=90" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Radius=0" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Border Color=~220" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) &
    "Highlight Color=$0" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Bottom Only=1" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.pnlTop.TabIndex = 13
        '
        'pnlMain
        '
        Me.pnlMain.AutoScroll = True
        Me.pnlMain.BackColor = System.Drawing.Color.Transparent
        Me.pnlMain.Controls.Add(Me.btnRefresh)
        Me.pnlMain.Controls.Add(Me.DoubleBufferedPanel1)
        Me.pnlMain.Controls.Add(Me.Label3)
        Me.pnlMain.Controls.Add(Me.btnPaste)
        Me.pnlMain.Controls.Add(Me.btnCut)
        Me.pnlMain.Controls.Add(Me.btnCopy)
        Me.pnlMain.Controls.Add(Me.DoubleBufferedPanel4)
        Me.pnlMain.Controls.Add(Me.Label2)
        Me.pnlMain.Controls.Add(Me.btnRedo)
        Me.pnlMain.Controls.Add(Me.btnUndo)
        Me.pnlMain.Controls.Add(Me.DoubleBufferedPanel3)
        Me.pnlMain.Controls.Add(Me.Label1)
        Me.pnlMain.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlMain.Location = New System.Drawing.Point(0, 26)
        Me.pnlMain.Margin = New System.Windows.Forms.Padding(2)
        Me.pnlMain.Name = "pnlMain"
        Me.pnlMain.Size = New System.Drawing.Size(680, 81)
        Me.pnlMain.TabIndex = 43
        '
        'btnRefresh
        '
        Me.btnRefresh.BackColor = System.Drawing.Color.Transparent
        Me.btnRefresh.BackgroundImage = CType(resources.GetObject("btnRefresh.BackgroundImage"), System.Drawing.Image)
        Me.btnRefresh.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnRefresh.FlatAppearance.BorderSize = 0
        Me.btnRefresh.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btnRefresh.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnRefresh.ForeColor = System.Drawing.Color.Black
        Me.btnRefresh.Image = CType(resources.GetObject("btnRefresh.Image"), System.Drawing.Image)
        Me.btnRefresh.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnRefresh.Location = New System.Drawing.Point(224, 2)
        Me.btnRefresh.Margin = New System.Windows.Forms.Padding(2)
        Me.btnRefresh.Name = "btnRefresh"
        Me.btnRefresh.Padding = New System.Windows.Forms.Padding(0, 0, 1, 1)
        Me.btnRefresh.Size = New System.Drawing.Size(81, 26)
        Me.btnRefresh.Style = resources.GetString("btnRefresh.Style")
        Me.btnRefresh.TabIndex = 54
        Me.btnRefresh.Text = " Refresh"
        Me.btnRefresh.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnRefresh.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnRefresh.UseCompatibleTextRendering = True
        Me.btnRefresh.UseVisualStyleBackColor = False
        '
        'DoubleBufferedPanel1
        '
        Me.DoubleBufferedPanel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.DoubleBufferedPanel1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.DoubleBufferedPanel1.Location = New System.Drawing.Point(310, 7)
        Me.DoubleBufferedPanel1.Margin = New System.Windows.Forms.Padding(2)
        Me.DoubleBufferedPanel1.Name = "DoubleBufferedPanel1"
        Me.DoubleBufferedPanel1.Size = New System.Drawing.Size(1, 70)
        Me.DoubleBufferedPanel1.TabIndex = 53
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.ForeColor = System.Drawing.Color.Gray
        Me.Label3.Location = New System.Drawing.Point(223, 60)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(86, 19)
        Me.Label3.TabIndex = 52
        Me.Label3.Text = "RTF"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnPaste
        '
        Me.btnPaste.BackColor = System.Drawing.Color.Transparent
        Me.btnPaste.BackgroundImage = CType(resources.GetObject("btnPaste.BackgroundImage"), System.Drawing.Image)
        Me.btnPaste.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnPaste.FlatAppearance.BorderSize = 0
        Me.btnPaste.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btnPaste.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btnPaste.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPaste.ForeColor = System.Drawing.Color.Black
        Me.btnPaste.Image = CType(resources.GetObject("btnPaste.Image"), System.Drawing.Image)
        Me.btnPaste.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnPaste.Location = New System.Drawing.Point(77, 33)
        Me.btnPaste.Margin = New System.Windows.Forms.Padding(2)
        Me.btnPaste.Name = "btnPaste"
        Me.btnPaste.Padding = New System.Windows.Forms.Padding(0, 0, 1, 1)
        Me.btnPaste.Size = New System.Drawing.Size(67, 26)
        Me.btnPaste.Style = resources.GetString("btnPaste.Style")
        Me.btnPaste.TabIndex = 17
        Me.btnPaste.Text = " Paste"
        Me.btnPaste.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnPaste.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnPaste.UseCompatibleTextRendering = True
        Me.btnPaste.UseVisualStyleBackColor = False
        '
        'btnCut
        '
        Me.btnCut.BackColor = System.Drawing.Color.Transparent
        Me.btnCut.BackgroundImage = CType(resources.GetObject("btnCut.BackgroundImage"), System.Drawing.Image)
        Me.btnCut.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnCut.FlatAppearance.BorderSize = 0
        Me.btnCut.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btnCut.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btnCut.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCut.ForeColor = System.Drawing.Color.Black
        Me.btnCut.Image = CType(resources.GetObject("btnCut.Image"), System.Drawing.Image)
        Me.btnCut.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnCut.Location = New System.Drawing.Point(148, 2)
        Me.btnCut.Margin = New System.Windows.Forms.Padding(2)
        Me.btnCut.Name = "btnCut"
        Me.btnCut.Padding = New System.Windows.Forms.Padding(0, 0, 1, 1)
        Me.btnCut.Size = New System.Drawing.Size(67, 26)
        Me.btnCut.Style = resources.GetString("btnCut.Style")
        Me.btnCut.TabIndex = 18
        Me.btnCut.Text = " Cut"
        Me.btnCut.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnCut.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnCut.UseCompatibleTextRendering = True
        Me.btnCut.UseVisualStyleBackColor = False
        '
        'btnCopy
        '
        Me.btnCopy.BackColor = System.Drawing.Color.Transparent
        Me.btnCopy.BackgroundImage = CType(resources.GetObject("btnCopy.BackgroundImage"), System.Drawing.Image)
        Me.btnCopy.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnCopy.FlatAppearance.BorderSize = 0
        Me.btnCopy.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btnCopy.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btnCopy.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCopy.ForeColor = System.Drawing.Color.Black
        Me.btnCopy.Image = CType(resources.GetObject("btnCopy.Image"), System.Drawing.Image)
        Me.btnCopy.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnCopy.Location = New System.Drawing.Point(77, 2)
        Me.btnCopy.Margin = New System.Windows.Forms.Padding(2)
        Me.btnCopy.Name = "btnCopy"
        Me.btnCopy.Padding = New System.Windows.Forms.Padding(0, 0, 1, 1)
        Me.btnCopy.Size = New System.Drawing.Size(67, 26)
        Me.btnCopy.Style = resources.GetString("btnCopy.Style")
        Me.btnCopy.TabIndex = 16
        Me.btnCopy.Text = " Copy"
        Me.btnCopy.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnCopy.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnCopy.UseCompatibleTextRendering = True
        Me.btnCopy.UseVisualStyleBackColor = False
        '
        'DoubleBufferedPanel4
        '
        Me.DoubleBufferedPanel4.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.DoubleBufferedPanel4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.DoubleBufferedPanel4.Location = New System.Drawing.Point(219, 7)
        Me.DoubleBufferedPanel4.Margin = New System.Windows.Forms.Padding(2)
        Me.DoubleBufferedPanel4.Name = "DoubleBufferedPanel4"
        Me.DoubleBufferedPanel4.Size = New System.Drawing.Size(1, 70)
        Me.DoubleBufferedPanel4.TabIndex = 51
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.ForeColor = System.Drawing.Color.Gray
        Me.Label2.Location = New System.Drawing.Point(76, 60)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(142, 19)
        Me.Label2.TabIndex = 50
        Me.Label2.Text = "Clipboard"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnRedo
        '
        Me.btnRedo.BackColor = System.Drawing.Color.Transparent
        Me.btnRedo.BackgroundImage = CType(resources.GetObject("btnRedo.BackgroundImage"), System.Drawing.Image)
        Me.btnRedo.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnRedo.FlatAppearance.BorderSize = 0
        Me.btnRedo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btnRedo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btnRedo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnRedo.ForeColor = System.Drawing.Color.Black
        Me.btnRedo.Image = CType(resources.GetObject("btnRedo.Image"), System.Drawing.Image)
        Me.btnRedo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnRedo.Location = New System.Drawing.Point(5, 33)
        Me.btnRedo.Margin = New System.Windows.Forms.Padding(2)
        Me.btnRedo.Name = "btnRedo"
        Me.btnRedo.Padding = New System.Windows.Forms.Padding(0, 0, 1, 1)
        Me.btnRedo.Size = New System.Drawing.Size(63, 26)
        Me.btnRedo.Style = resources.GetString("btnRedo.Style")
        Me.btnRedo.TabIndex = 15
        Me.btnRedo.Text = " Redo"
        Me.btnRedo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnRedo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnRedo.UseCompatibleTextRendering = True
        Me.btnRedo.UseVisualStyleBackColor = False
        '
        'btnUndo
        '
        Me.btnUndo.BackColor = System.Drawing.Color.Transparent
        Me.btnUndo.BackgroundImage = CType(resources.GetObject("btnUndo.BackgroundImage"), System.Drawing.Image)
        Me.btnUndo.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnUndo.FlatAppearance.BorderSize = 0
        Me.btnUndo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btnUndo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btnUndo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnUndo.ForeColor = System.Drawing.Color.Black
        Me.btnUndo.Image = CType(resources.GetObject("btnUndo.Image"), System.Drawing.Image)
        Me.btnUndo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnUndo.Location = New System.Drawing.Point(5, 2)
        Me.btnUndo.Margin = New System.Windows.Forms.Padding(2)
        Me.btnUndo.Name = "btnUndo"
        Me.btnUndo.Padding = New System.Windows.Forms.Padding(0, 0, 1, 1)
        Me.btnUndo.Size = New System.Drawing.Size(63, 26)
        Me.btnUndo.Style = resources.GetString("btnUndo.Style")
        Me.btnUndo.TabIndex = 14
        Me.btnUndo.Text = " Undo"
        Me.btnUndo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnUndo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnUndo.UseCompatibleTextRendering = True
        Me.btnUndo.UseVisualStyleBackColor = False
        '
        'DoubleBufferedPanel3
        '
        Me.DoubleBufferedPanel3.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.DoubleBufferedPanel3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.DoubleBufferedPanel3.Location = New System.Drawing.Point(72, 7)
        Me.DoubleBufferedPanel3.Margin = New System.Windows.Forms.Padding(2)
        Me.DoubleBufferedPanel3.Name = "DoubleBufferedPanel3"
        Me.DoubleBufferedPanel3.Size = New System.Drawing.Size(1, 70)
        Me.DoubleBufferedPanel3.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.ForeColor = System.Drawing.Color.Gray
        Me.Label1.Location = New System.Drawing.Point(4, 60)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(67, 19)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "History"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'pnlTabs
        '
        Me.pnlTabs.BackColor = System.Drawing.Color.Transparent
        Me.pnlTabs.Controls.Add(Me.btnHome)
        Me.pnlTabs.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlTabs.Location = New System.Drawing.Point(0, 0)
        Me.pnlTabs.Margin = New System.Windows.Forms.Padding(2, 2, 2, 0)
        Me.pnlTabs.Name = "pnlTabs"
        Me.pnlTabs.Size = New System.Drawing.Size(680, 26)
        Me.pnlTabs.Style = "Colors=$1|~249" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Positions=0|1" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Angle=90" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Radius=0" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Border Color=~220" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Highlight C" &
    "olor$0" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Bottom Only=1" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.pnlTabs.TabIndex = 71
        '
        'btnHome
        '
        Me.btnHome.Appearance = System.Windows.Forms.Appearance.Button
        Me.btnHome.AutoSize = True
        Me.btnHome.BackColor = System.Drawing.Color.Transparent
        Me.btnHome.BackgroundImage = CType(resources.GetObject("btnHome.BackgroundImage"), System.Drawing.Image)
        Me.btnHome.Checked = True
        Me.btnHome.Dock = System.Windows.Forms.DockStyle.Left
        Me.btnHome.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnHome.FlatAppearance.BorderSize = 0
        Me.btnHome.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent
        Me.btnHome.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btnHome.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btnHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnHome.ForeColor = System.Drawing.Color.FromArgb(CType(CType(120, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnHome.Location = New System.Drawing.Point(0, 0)
        Me.btnHome.Margin = New System.Windows.Forms.Padding(2)
        Me.btnHome.Name = "btnHome"
        Me.btnHome.Padding = New System.Windows.Forms.Padding(0, 2, 0, 2)
        Me.btnHome.Size = New System.Drawing.Size(45, 26)
        Me.btnHome.Style = resources.GetString("btnHome.Style")
        Me.btnHome.TabIndex = 2
        Me.btnHome.TabStop = True
        Me.btnHome.Text = "Home"
        Me.btnHome.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.btnHome.UseVisualStyleBackColor = False
        '
        'frmRTF
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(680, 505)
        Me.Controls.Add(Me.txtRTF)
        Me.Controls.Add(Me.pnlTop)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "frmRTF"
        Me.ShowIcon = False
        Me.Text = "RTF Editor"
        Me.pnlTop.ResumeLayout(False)
        Me.pnlMain.ResumeLayout(False)
        Me.pnlTabs.ResumeLayout(False)
        Me.pnlTabs.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents txtRTF As System.Windows.Forms.RichTextBox
    Friend WithEvents pnlTop As Tundra.StylizedPanel
    Friend WithEvents pnlMain As Tundra.DoubleBufferedPanel
    Friend WithEvents btnPaste As Tundra.StylizedButton
    Friend WithEvents btnCut As Tundra.StylizedButton
    Friend WithEvents btnCopy As Tundra.StylizedButton
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents btnRedo As Tundra.StylizedButton
    Friend WithEvents btnUndo As Tundra.StylizedButton
    Friend WithEvents DoubleBufferedPanel3 As Tundra.DoubleBufferedPanel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents pnlTabs As Tundra.StylizedPanel
    Friend WithEvents btnHome As Tundra.StylizedRadioButton
    Friend WithEvents DoubleBufferedPanel4 As Tundra.DoubleBufferedPanel
    Friend WithEvents btnRefresh As Tundra.StylizedButton
    Friend WithEvents DoubleBufferedPanel1 As Tundra.DoubleBufferedPanel
    Friend WithEvents Label3 As System.Windows.Forms.Label
End Class
