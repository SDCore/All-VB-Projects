<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmFormOne
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
        Me.lblShowOutput = New System.Windows.Forms.Label()
        Me.btnShowOutput = New System.Windows.Forms.Button()
        Me.btnShowNewForm = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblShowOutput
        '
        Me.lblShowOutput.AutoSize = True
        Me.lblShowOutput.Location = New System.Drawing.Point(12, 9)
        Me.lblShowOutput.Name = "lblShowOutput"
        Me.lblShowOutput.Size = New System.Drawing.Size(39, 13)
        Me.lblShowOutput.TabIndex = 0
        Me.lblShowOutput.Text = "Output"
        '
        'btnShowOutput
        '
        Me.btnShowOutput.Location = New System.Drawing.Point(15, 26)
        Me.btnShowOutput.Name = "btnShowOutput"
        Me.btnShowOutput.Size = New System.Drawing.Size(257, 23)
        Me.btnShowOutput.TabIndex = 1
        Me.btnShowOutput.Text = "Show Output"
        Me.btnShowOutput.UseVisualStyleBackColor = True
        '
        'btnShowNewForm
        '
        Me.btnShowNewForm.Location = New System.Drawing.Point(15, 56)
        Me.btnShowNewForm.Name = "btnShowNewForm"
        Me.btnShowNewForm.Size = New System.Drawing.Size(257, 23)
        Me.btnShowNewForm.TabIndex = 2
        Me.btnShowNewForm.Text = "Show New Form"
        Me.btnShowNewForm.UseVisualStyleBackColor = True
        '
        'frmFormOne
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 87)
        Me.Controls.Add(Me.btnShowNewForm)
        Me.Controls.Add(Me.btnShowOutput)
        Me.Controls.Add(Me.lblShowOutput)
        Me.Name = "frmFormOne"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblShowOutput As System.Windows.Forms.Label
    Friend WithEvents btnShowOutput As System.Windows.Forms.Button
    Friend WithEvents btnShowNewForm As System.Windows.Forms.Button

End Class
