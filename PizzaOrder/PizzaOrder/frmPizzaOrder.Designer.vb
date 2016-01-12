<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPizzaOrder
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmPizzaOrder))
        Me.pnlPanel = New System.Windows.Forms.Panel()
        Me.cboSize = New System.Windows.Forms.ComboBox()
        Me.lblSize = New System.Windows.Forms.Label()
        Me.txtQuantity = New System.Windows.Forms.TextBox()
        Me.lblQuantity = New System.Windows.Forms.Label()
        Me.lblOutput = New System.Windows.Forms.Label()
        Me.btnSubmit = New System.Windows.Forms.Button()
        Me.pnlPanel.SuspendLayout()
        Me.SuspendLayout()
        '
        'pnlPanel
        '
        Me.pnlPanel.BackColor = System.Drawing.Color.Transparent
        Me.pnlPanel.Controls.Add(Me.btnSubmit)
        Me.pnlPanel.Controls.Add(Me.lblOutput)
        Me.pnlPanel.Controls.Add(Me.lblQuantity)
        Me.pnlPanel.Controls.Add(Me.txtQuantity)
        Me.pnlPanel.Controls.Add(Me.lblSize)
        Me.pnlPanel.Controls.Add(Me.cboSize)
        Me.pnlPanel.Location = New System.Drawing.Point(493, 12)
        Me.pnlPanel.Name = "pnlPanel"
        Me.pnlPanel.Size = New System.Drawing.Size(200, 576)
        Me.pnlPanel.TabIndex = 0
        '
        'cboSize
        '
        Me.cboSize.FormattingEnabled = True
        Me.cboSize.Items.AddRange(New Object() {"Small", "Medium", "Large"})
        Me.cboSize.Location = New System.Drawing.Point(62, 3)
        Me.cboSize.Name = "cboSize"
        Me.cboSize.Size = New System.Drawing.Size(135, 21)
        Me.cboSize.TabIndex = 1
        '
        'lblSize
        '
        Me.lblSize.AutoSize = True
        Me.lblSize.ForeColor = System.Drawing.Color.White
        Me.lblSize.Location = New System.Drawing.Point(3, 6)
        Me.lblSize.Name = "lblSize"
        Me.lblSize.Size = New System.Drawing.Size(55, 13)
        Me.lblSize.TabIndex = 2
        Me.lblSize.Text = "Pizza Size"
        '
        'txtQuantity
        '
        Me.txtQuantity.Location = New System.Drawing.Point(62, 30)
        Me.txtQuantity.Name = "txtQuantity"
        Me.txtQuantity.Size = New System.Drawing.Size(135, 20)
        Me.txtQuantity.TabIndex = 3
        '
        'lblQuantity
        '
        Me.lblQuantity.AutoSize = True
        Me.lblQuantity.ForeColor = System.Drawing.Color.White
        Me.lblQuantity.Location = New System.Drawing.Point(9, 33)
        Me.lblQuantity.Name = "lblQuantity"
        Me.lblQuantity.Size = New System.Drawing.Size(46, 13)
        Me.lblQuantity.TabIndex = 4
        Me.lblQuantity.Text = "Quantity"
        '
        'lblOutput
        '
        Me.lblOutput.AutoSize = True
        Me.lblOutput.ForeColor = System.Drawing.Color.White
        Me.lblOutput.Location = New System.Drawing.Point(79, 77)
        Me.lblOutput.Name = "lblOutput"
        Me.lblOutput.Size = New System.Drawing.Size(33, 13)
        Me.lblOutput.TabIndex = 5
        Me.lblOutput.Text = "Order"
        '
        'btnSubmit
        '
        Me.btnSubmit.Location = New System.Drawing.Point(6, 110)
        Me.btnSubmit.Name = "btnSubmit"
        Me.btnSubmit.Size = New System.Drawing.Size(191, 23)
        Me.btnSubmit.TabIndex = 6
        Me.btnSubmit.Text = "Calculate Order"
        Me.btnSubmit.UseVisualStyleBackColor = True
        '
        'frmPizzaOrder
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(702, 600)
        Me.Controls.Add(Me.pnlPanel)
        Me.Name = "frmPizzaOrder"
        Me.Text = "Pizza Ordering System"
        Me.pnlPanel.ResumeLayout(False)
        Me.pnlPanel.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents pnlPanel As System.Windows.Forms.Panel
    Friend WithEvents cboSize As System.Windows.Forms.ComboBox
    Friend WithEvents btnSubmit As System.Windows.Forms.Button
    Friend WithEvents lblOutput As System.Windows.Forms.Label
    Friend WithEvents lblQuantity As System.Windows.Forms.Label
    Friend WithEvents txtQuantity As System.Windows.Forms.TextBox
    Friend WithEvents lblSize As System.Windows.Forms.Label

End Class
