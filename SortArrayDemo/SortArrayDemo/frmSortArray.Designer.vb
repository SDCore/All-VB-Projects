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
        Me.SuspendLayout()
        '
        'lstOutput
        '
        Me.lstOutput.FormattingEnabled = True
        Me.lstOutput.Location = New System.Drawing.Point(13, 13)
        Me.lstOutput.Name = "lstOutput"
        Me.lstOutput.Size = New System.Drawing.Size(259, 95)
        Me.lstOutput.TabIndex = 0
        '
        'btnShowOutput
        '
        Me.btnShowOutput.Location = New System.Drawing.Point(13, 115)
        Me.btnShowOutput.Name = "btnShowOutput"
        Me.btnShowOutput.Size = New System.Drawing.Size(259, 23)
        Me.btnShowOutput.TabIndex = 1
        Me.btnShowOutput.Text = "Show Output"
        Me.btnShowOutput.UseVisualStyleBackColor = True
        '
        'frmSortArray
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 147)
        Me.Controls.Add(Me.btnShowOutput)
        Me.Controls.Add(Me.lstOutput)
        Me.Name = "frmSortArray"
        Me.Text = "Sort Array"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents lstOutput As System.Windows.Forms.ListBox
    Friend WithEvents btnShowOutput As System.Windows.Forms.Button

End Class
