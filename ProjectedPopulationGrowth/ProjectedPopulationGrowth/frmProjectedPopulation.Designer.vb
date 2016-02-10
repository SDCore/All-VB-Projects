<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmProjectedPopulation
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
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.lblSelectCity = New System.Windows.Forms.Label()
        Me.cboSelectCity = New System.Windows.Forms.ComboBox()
        Me.lblPresentPopulation = New System.Windows.Forms.Label()
        Me.lblExpectedGrowth = New System.Windows.Forms.Label()
        Me.lstPopulationGrowth = New System.Windows.Forms.ListBox()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DisplayPresentPopulationToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ClearToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.Location = New System.Drawing.Point(-42, 300)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(758, 439)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.Font = New System.Drawing.Font("Segoe UI", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle.Location = New System.Drawing.Point(85, 23)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(407, 37)
        Me.lblTitle.TabIndex = 1
        Me.lblTitle.Text = "Largest Cities Population Growth"
        '
        'lblSelectCity
        '
        Me.lblSelectCity.AutoSize = True
        Me.lblSelectCity.Location = New System.Drawing.Point(9, 81)
        Me.lblSelectCity.Name = "lblSelectCity"
        Me.lblSelectCity.Size = New System.Drawing.Size(67, 17)
        Me.lblSelectCity.TabIndex = 2
        Me.lblSelectCity.Text = "Select City"
        '
        'cboSelectCity
        '
        Me.cboSelectCity.FormattingEnabled = True
        Me.cboSelectCity.Location = New System.Drawing.Point(12, 101)
        Me.cboSelectCity.Name = "cboSelectCity"
        Me.cboSelectCity.Size = New System.Drawing.Size(560, 25)
        Me.cboSelectCity.TabIndex = 3
        Me.cboSelectCity.Text = "Select an Item"
        '
        'lblPresentPopulation
        '
        Me.lblPresentPopulation.AutoSize = True
        Me.lblPresentPopulation.Location = New System.Drawing.Point(12, 145)
        Me.lblPresentPopulation.Name = "lblPresentPopulation"
        Me.lblPresentPopulation.Size = New System.Drawing.Size(269, 17)
        Me.lblPresentPopulation.TabIndex = 4
        Me.lblPresentPopulation.Text = "Present Population in CITYNAME is 0,000,000"
        Me.lblPresentPopulation.Visible = False
        '
        'lblExpectedGrowth
        '
        Me.lblExpectedGrowth.AutoSize = True
        Me.lblExpectedGrowth.Location = New System.Drawing.Point(12, 183)
        Me.lblExpectedGrowth.Name = "lblExpectedGrowth"
        Me.lblExpectedGrowth.Size = New System.Drawing.Size(299, 17)
        Me.lblExpectedGrowth.TabIndex = 5
        Me.lblExpectedGrowth.Text = "Expected Population Growth over the next 5 years"
        Me.lblExpectedGrowth.Visible = False
        '
        'lstPopulationGrowth
        '
        Me.lstPopulationGrowth.FormattingEnabled = True
        Me.lstPopulationGrowth.ItemHeight = 17
        Me.lstPopulationGrowth.Location = New System.Drawing.Point(15, 204)
        Me.lstPopulationGrowth.Name = "lstPopulationGrowth"
        Me.lstPopulationGrowth.Size = New System.Drawing.Size(557, 89)
        Me.lstPopulationGrowth.TabIndex = 6
        Me.lstPopulationGrowth.Visible = False
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(584, 24)
        Me.MenuStrip1.TabIndex = 7
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DisplayPresentPopulationToolStripMenuItem, Me.ClearToolStripMenuItem, Me.ExitToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.FileToolStripMenuItem.Text = "File"
        '
        'DisplayPresentPopulationToolStripMenuItem
        '
        Me.DisplayPresentPopulationToolStripMenuItem.Name = "DisplayPresentPopulationToolStripMenuItem"
        Me.DisplayPresentPopulationToolStripMenuItem.Size = New System.Drawing.Size(215, 22)
        Me.DisplayPresentPopulationToolStripMenuItem.Text = "Display Present Population"
        '
        'ClearToolStripMenuItem
        '
        Me.ClearToolStripMenuItem.Name = "ClearToolStripMenuItem"
        Me.ClearToolStripMenuItem.Size = New System.Drawing.Size(215, 22)
        Me.ClearToolStripMenuItem.Text = "Clear"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(215, 22)
        Me.ExitToolStripMenuItem.Text = "Exit"
        '
        'frmProjectedPopulation
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(584, 498)
        Me.Controls.Add(Me.lstPopulationGrowth)
        Me.Controls.Add(Me.lblExpectedGrowth)
        Me.Controls.Add(Me.lblPresentPopulation)
        Me.Controls.Add(Me.cboSelectCity)
        Me.Controls.Add(Me.lblSelectCity)
        Me.Controls.Add(Me.lblTitle)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "frmProjectedPopulation"
        Me.Text = "Projected Population"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents lblTitle As System.Windows.Forms.Label
    Friend WithEvents lblSelectCity As System.Windows.Forms.Label
    Friend WithEvents cboSelectCity As System.Windows.Forms.ComboBox
    Friend WithEvents lblPresentPopulation As System.Windows.Forms.Label
    Friend WithEvents lblExpectedGrowth As System.Windows.Forms.Label
    Friend WithEvents lstPopulationGrowth As System.Windows.Forms.ListBox
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents FileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DisplayPresentPopulationToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ClearToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem

End Class
