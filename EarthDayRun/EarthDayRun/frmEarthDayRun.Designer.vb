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
        Me.btnComputeFunds = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnComputeFunds
        '
        Me.btnComputeFunds.Location = New System.Drawing.Point(13, 523)
        Me.btnComputeFunds.Name = "btnComputeFunds"
        Me.btnComputeFunds.Size = New System.Drawing.Size(813, 23)
        Me.btnComputeFunds.TabIndex = 0
        Me.btnComputeFunds.Text = "Calculate Funds Raised"
        Me.btnComputeFunds.UseVisualStyleBackColor = True
        '
        'frmEarthDayRun
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(838, 558)
        Me.Controls.Add(Me.btnComputeFunds)
        Me.Name = "frmEarthDayRun"
        Me.Text = "Earth Day Run"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnComputeFunds As System.Windows.Forms.Button

End Class
