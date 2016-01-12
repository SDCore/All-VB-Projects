<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmExceptionDemo
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
        Me.btnShowOutput = New System.Windows.Forms.Button()
        Me.lblOutput = New System.Windows.Forms.Label()
        Me.txtNumOne = New System.Windows.Forms.TextBox()
        Me.txtNumTwo = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'btnShowOutput
        '
        Me.btnShowOutput.Location = New System.Drawing.Point(80, 59)
        Me.btnShowOutput.Name = "btnShowOutput"
        Me.btnShowOutput.Size = New System.Drawing.Size(75, 23)
        Me.btnShowOutput.TabIndex = 0
        Me.btnShowOutput.Text = "Show Output"
        Me.btnShowOutput.UseVisualStyleBackColor = True
        '
        'lblOutput
        '
        Me.lblOutput.AutoSize = True
        Me.lblOutput.Location = New System.Drawing.Point(80, 113)
        Me.lblOutput.Name = "lblOutput"
        Me.lblOutput.Size = New System.Drawing.Size(39, 13)
        Me.lblOutput.TabIndex = 1
        Me.lblOutput.Text = "Label1"
        '
        'txtNumOne
        '
        Me.txtNumOne.Location = New System.Drawing.Point(80, 153)
        Me.txtNumOne.Name = "txtNumOne"
        Me.txtNumOne.Size = New System.Drawing.Size(100, 20)
        Me.txtNumOne.TabIndex = 2
        '
        'txtNumTwo
        '
        Me.txtNumTwo.Location = New System.Drawing.Point(80, 180)
        Me.txtNumTwo.Name = "txtNumTwo"
        Me.txtNumTwo.Size = New System.Drawing.Size(100, 20)
        Me.txtNumTwo.TabIndex = 3
        '
        'frmExceptionDemo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 262)
        Me.Controls.Add(Me.txtNumTwo)
        Me.Controls.Add(Me.txtNumOne)
        Me.Controls.Add(Me.lblOutput)
        Me.Controls.Add(Me.btnShowOutput)
        Me.Name = "frmExceptionDemo"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnShowOutput As System.Windows.Forms.Button
    Friend WithEvents lblOutput As System.Windows.Forms.Label
    Friend WithEvents txtNumOne As System.Windows.Forms.TextBox
    Friend WithEvents txtNumTwo As System.Windows.Forms.TextBox

End Class
