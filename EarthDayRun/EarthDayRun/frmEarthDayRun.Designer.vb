<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmEarthDayRun
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmEarthDayRun))
        Me.btnComputeFunds = New System.Windows.Forms.Button()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.fileFileStrip = New System.Windows.Forms.ToolStripMenuItem()
        Me.ClearToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.picEarthDay = New System.Windows.Forms.PictureBox()
        Me.txtTitle = New System.Windows.Forms.Label()
        Me.lblRunners = New System.Windows.Forms.Label()
        Me.lstRunners = New System.Windows.Forms.ListBox()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.picEarthDay, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnComputeFunds
        '
        Me.btnComputeFunds.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.btnComputeFunds.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnComputeFunds.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnComputeFunds.ForeColor = System.Drawing.Color.White
        Me.btnComputeFunds.Location = New System.Drawing.Point(13, 483)
        Me.btnComputeFunds.Name = "btnComputeFunds"
        Me.btnComputeFunds.Size = New System.Drawing.Size(813, 63)
        Me.btnComputeFunds.TabIndex = 0
        Me.btnComputeFunds.Text = "Calculate Funds Raised"
        Me.btnComputeFunds.UseVisualStyleBackColor = False
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.fileFileStrip})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(838, 24)
        Me.MenuStrip1.TabIndex = 1
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'fileFileStrip
        '
        Me.fileFileStrip.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ClearToolStripMenuItem, Me.ExitToolStripMenuItem})
        Me.fileFileStrip.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.fileFileStrip.Name = "fileFileStrip"
        Me.fileFileStrip.Size = New System.Drawing.Size(37, 20)
        Me.fileFileStrip.Text = "File"
        '
        'ClearToolStripMenuItem
        '
        Me.ClearToolStripMenuItem.Name = "ClearToolStripMenuItem"
        Me.ClearToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.ClearToolStripMenuItem.Text = "Clear"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.ExitToolStripMenuItem.Text = "Exit"
        '
        'picEarthDay
        '
        Me.picEarthDay.Image = CType(resources.GetObject("picEarthDay.Image"), System.Drawing.Image)
        Me.picEarthDay.Location = New System.Drawing.Point(468, 27)
        Me.picEarthDay.Name = "picEarthDay"
        Me.picEarthDay.Size = New System.Drawing.Size(358, 315)
        Me.picEarthDay.TabIndex = 2
        Me.picEarthDay.TabStop = False
        '
        'txtTitle
        '
        Me.txtTitle.AutoSize = True
        Me.txtTitle.Font = New System.Drawing.Font("Segoe UI", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTitle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(75, Byte), Integer), CType(CType(96, Byte), Integer))
        Me.txtTitle.Location = New System.Drawing.Point(527, 348)
        Me.txtTitle.Name = "txtTitle"
        Me.txtTitle.Size = New System.Drawing.Size(247, 130)
        Me.txtTitle.TabIndex = 3
        Me.txtTitle.Text = "Earth Day" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "5K Run"
        Me.txtTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblRunners
        '
        Me.lblRunners.AutoSize = True
        Me.lblRunners.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRunners.Location = New System.Drawing.Point(12, 27)
        Me.lblRunners.Name = "lblRunners"
        Me.lblRunners.Size = New System.Drawing.Size(139, 21)
        Me.lblRunners.TabIndex = 4
        Me.lblRunners.Text = "Earth Day Runners"
        '
        'lstRunners
        '
        Me.lstRunners.FormattingEnabled = True
        Me.lstRunners.Location = New System.Drawing.Point(16, 52)
        Me.lstRunners.Name = "lstRunners"
        Me.lstRunners.Size = New System.Drawing.Size(215, 420)
        Me.lstRunners.TabIndex = 5
        '
        'frmEarthDayRun
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(838, 558)
        Me.Controls.Add(Me.lstRunners)
        Me.Controls.Add(Me.lblRunners)
        Me.Controls.Add(Me.txtTitle)
        Me.Controls.Add(Me.picEarthDay)
        Me.Controls.Add(Me.btnComputeFunds)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(75, Byte), Integer), CType(CType(96, Byte), Integer))
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "frmEarthDayRun"
        Me.Text = "Earth Day Run"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.picEarthDay, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnComputeFunds As System.Windows.Forms.Button
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents fileFileStrip As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ClearToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents picEarthDay As System.Windows.Forms.PictureBox
    Friend WithEvents txtTitle As System.Windows.Forms.Label
    Friend WithEvents lblRunners As System.Windows.Forms.Label
    Friend WithEvents lstRunners As System.Windows.Forms.ListBox

End Class
