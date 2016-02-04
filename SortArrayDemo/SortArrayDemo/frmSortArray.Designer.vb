<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSortArray
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
        Me.lstOutput = New System.Windows.Forms.ListBox()
        Me.btnShowOutput = New System.Windows.Forms.Button()
        Me.mnuFileStrip = New System.Windows.Forms.MenuStrip()
        Me.mnuFile = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuFileClear = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuFileExit = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuFileStrip.SuspendLayout()
        Me.SuspendLayout()
        '
        'lstOutput
        '
        Me.lstOutput.FormattingEnabled = True
        Me.lstOutput.Location = New System.Drawing.Point(13, 31)
        Me.lstOutput.Name = "lstOutput"
        Me.lstOutput.Size = New System.Drawing.Size(259, 95)
        Me.lstOutput.TabIndex = 0
        '
        'btnShowOutput
        '
        Me.btnShowOutput.Location = New System.Drawing.Point(13, 132)
        Me.btnShowOutput.Name = "btnShowOutput"
        Me.btnShowOutput.Size = New System.Drawing.Size(259, 23)
        Me.btnShowOutput.TabIndex = 1
        Me.btnShowOutput.Text = "Show Output"
        Me.btnShowOutput.UseVisualStyleBackColor = True
        '
        'mnuFileStrip
        '
        Me.mnuFileStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuFile})
        Me.mnuFileStrip.Location = New System.Drawing.Point(0, 0)
        Me.mnuFileStrip.Name = "mnuFileStrip"
        Me.mnuFileStrip.Size = New System.Drawing.Size(284, 24)
        Me.mnuFileStrip.TabIndex = 2
        Me.mnuFileStrip.Text = "MenuStrip1"
        '
        'mnuFile
        '
        Me.mnuFile.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuFileClear, Me.mnuFileExit})
        Me.mnuFile.Name = "mnuFile"
        Me.mnuFile.Size = New System.Drawing.Size(37, 20)
        Me.mnuFile.Text = "&File"
        '
        'mnuFileClear
        '
        Me.mnuFileClear.Name = "mnuFileClear"
        Me.mnuFileClear.Size = New System.Drawing.Size(152, 22)
        Me.mnuFileClear.Text = "&Clear"
        '
        'mnuFileExit
        '
        Me.mnuFileExit.Name = "mnuFileExit"
        Me.mnuFileExit.Size = New System.Drawing.Size(152, 22)
        Me.mnuFileExit.Text = "E&xit"
        '
        'frmSortArray
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 166)
        Me.Controls.Add(Me.btnShowOutput)
        Me.Controls.Add(Me.lstOutput)
        Me.Controls.Add(Me.mnuFileStrip)
        Me.MainMenuStrip = Me.mnuFileStrip
        Me.Name = "frmSortArray"
        Me.Text = "Sort Array"
        Me.mnuFileStrip.ResumeLayout(False)
        Me.mnuFileStrip.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lstOutput As System.Windows.Forms.ListBox
    Friend WithEvents btnShowOutput As System.Windows.Forms.Button
    Friend WithEvents mnuFileStrip As System.Windows.Forms.MenuStrip
    Friend WithEvents mnuFile As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuFileClear As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuFileExit As System.Windows.Forms.ToolStripMenuItem

End Class
