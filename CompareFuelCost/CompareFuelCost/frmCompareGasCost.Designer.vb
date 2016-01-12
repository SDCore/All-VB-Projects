<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCompareGasCost
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmCompareGasCost))
        Me.lblCostPerGallon = New System.Windows.Forms.Label()
        Me.lblMilesTraveled = New System.Windows.Forms.Label()
        Me.lblYearsOwned = New System.Windows.Forms.Label()
        Me.lblSUVMPG = New System.Windows.Forms.Label()
        Me.lblCompactMPG = New System.Windows.Forms.Label()
        Me.btnCalculateCost = New System.Windows.Forms.Button()
        Me.lblSUVCost = New System.Windows.Forms.Label()
        Me.lblCompactCarCost = New System.Windows.Forms.Label()
        Me.lblDifference = New System.Windows.Forms.Label()
        Me.lblSUVCostOutput = New System.Windows.Forms.Label()
        Me.lblCompactCarCostOutput = New System.Windows.Forms.Label()
        Me.lblDifferenceOutput = New System.Windows.Forms.Label()
        Me.txtMilesTraveled = New System.Windows.Forms.TextBox()
        Me.txtCostPerGallon = New System.Windows.Forms.TextBox()
        Me.txtSUVMPG = New System.Windows.Forms.TextBox()
        Me.txtCompactMPG = New System.Windows.Forms.TextBox()
        Me.cboYearsOwned = New System.Windows.Forms.ComboBox()
        Me.SuspendLayout()
        '
        'lblCostPerGallon
        '
        Me.lblCostPerGallon.AutoSize = True
        Me.lblCostPerGallon.BackColor = System.Drawing.Color.White
        Me.lblCostPerGallon.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCostPerGallon.Location = New System.Drawing.Point(262, 9)
        Me.lblCostPerGallon.Name = "lblCostPerGallon"
        Me.lblCostPerGallon.Size = New System.Drawing.Size(106, 17)
        Me.lblCostPerGallon.TabIndex = 0
        Me.lblCostPerGallon.Text = "Cost per Gallon: "
        '
        'lblMilesTraveled
        '
        Me.lblMilesTraveled.AutoSize = True
        Me.lblMilesTraveled.BackColor = System.Drawing.Color.White
        Me.lblMilesTraveled.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMilesTraveled.Location = New System.Drawing.Point(262, 32)
        Me.lblMilesTraveled.Name = "lblMilesTraveled"
        Me.lblMilesTraveled.Size = New System.Drawing.Size(153, 17)
        Me.lblMilesTraveled.TabIndex = 1
        Me.lblMilesTraveled.Text = "Miles Traveled Per Year: "
        '
        'lblYearsOwned
        '
        Me.lblYearsOwned.AutoSize = True
        Me.lblYearsOwned.BackColor = System.Drawing.Color.White
        Me.lblYearsOwned.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblYearsOwned.Location = New System.Drawing.Point(262, 55)
        Me.lblYearsOwned.Name = "lblYearsOwned"
        Me.lblYearsOwned.Size = New System.Drawing.Size(174, 17)
        Me.lblYearsOwned.TabIndex = 2
        Me.lblYearsOwned.Text = "Years of Vehicle Ownership: "
        '
        'lblSUVMPG
        '
        Me.lblSUVMPG.AutoSize = True
        Me.lblSUVMPG.BackColor = System.Drawing.Color.White
        Me.lblSUVMPG.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSUVMPG.Location = New System.Drawing.Point(262, 77)
        Me.lblSUVMPG.Name = "lblSUVMPG"
        Me.lblSUVMPG.Size = New System.Drawing.Size(71, 17)
        Me.lblSUVMPG.TabIndex = 3
        Me.lblSUVMPG.Text = "SUV MPG: "
        '
        'lblCompactMPG
        '
        Me.lblCompactMPG.AutoSize = True
        Me.lblCompactMPG.BackColor = System.Drawing.Color.White
        Me.lblCompactMPG.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCompactMPG.Location = New System.Drawing.Point(262, 99)
        Me.lblCompactMPG.Name = "lblCompactMPG"
        Me.lblCompactMPG.Size = New System.Drawing.Size(123, 17)
        Me.lblCompactMPG.TabIndex = 4
        Me.lblCompactMPG.Text = "Compact Car MPG: "
        '
        'btnCalculateCost
        '
        Me.btnCalculateCost.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCalculateCost.Location = New System.Drawing.Point(265, 125)
        Me.btnCalculateCost.Name = "btnCalculateCost"
        Me.btnCalculateCost.Size = New System.Drawing.Size(327, 75)
        Me.btnCalculateCost.TabIndex = 5
        Me.btnCalculateCost.Text = "Compare Life of Vehicle Cost"
        Me.btnCalculateCost.UseVisualStyleBackColor = True
        '
        'lblSUVCost
        '
        Me.lblSUVCost.AutoSize = True
        Me.lblSUVCost.BackColor = System.Drawing.Color.White
        Me.lblSUVCost.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSUVCost.Location = New System.Drawing.Point(262, 203)
        Me.lblSUVCost.Name = "lblSUVCost"
        Me.lblSUVCost.Size = New System.Drawing.Size(95, 17)
        Me.lblSUVCost.TabIndex = 6
        Me.lblSUVCost.Text = "SUV Gas Cost: "
        '
        'lblCompactCarCost
        '
        Me.lblCompactCarCost.AutoSize = True
        Me.lblCompactCarCost.BackColor = System.Drawing.Color.White
        Me.lblCompactCarCost.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCompactCarCost.Location = New System.Drawing.Point(262, 227)
        Me.lblCompactCarCost.Name = "lblCompactCarCost"
        Me.lblCompactCarCost.Size = New System.Drawing.Size(147, 17)
        Me.lblCompactCarCost.TabIndex = 7
        Me.lblCompactCarCost.Text = "Compact Car Gas Cost: "
        '
        'lblDifference
        '
        Me.lblDifference.AutoSize = True
        Me.lblDifference.BackColor = System.Drawing.Color.White
        Me.lblDifference.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDifference.Location = New System.Drawing.Point(262, 251)
        Me.lblDifference.Name = "lblDifference"
        Me.lblDifference.Size = New System.Drawing.Size(118, 17)
        Me.lblDifference.TabIndex = 8
        Me.lblDifference.Text = "Difference in Cost: "
        '
        'lblSUVCostOutput
        '
        Me.lblSUVCostOutput.AutoSize = True
        Me.lblSUVCostOutput.BackColor = System.Drawing.Color.White
        Me.lblSUVCostOutput.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSUVCostOutput.Location = New System.Drawing.Point(439, 203)
        Me.lblSUVCostOutput.Name = "lblSUVCostOutput"
        Me.lblSUVCostOutput.Size = New System.Drawing.Size(39, 17)
        Me.lblSUVCostOutput.TabIndex = 9
        Me.lblSUVCostOutput.Text = "$0.00"
        '
        'lblCompactCarCostOutput
        '
        Me.lblCompactCarCostOutput.AutoSize = True
        Me.lblCompactCarCostOutput.BackColor = System.Drawing.Color.White
        Me.lblCompactCarCostOutput.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCompactCarCostOutput.Location = New System.Drawing.Point(439, 227)
        Me.lblCompactCarCostOutput.Name = "lblCompactCarCostOutput"
        Me.lblCompactCarCostOutput.Size = New System.Drawing.Size(39, 17)
        Me.lblCompactCarCostOutput.TabIndex = 10
        Me.lblCompactCarCostOutput.Text = "$0.00"
        '
        'lblDifferenceOutput
        '
        Me.lblDifferenceOutput.AutoSize = True
        Me.lblDifferenceOutput.BackColor = System.Drawing.Color.White
        Me.lblDifferenceOutput.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDifferenceOutput.Location = New System.Drawing.Point(439, 251)
        Me.lblDifferenceOutput.Name = "lblDifferenceOutput"
        Me.lblDifferenceOutput.Size = New System.Drawing.Size(39, 17)
        Me.lblDifferenceOutput.TabIndex = 11
        Me.lblDifferenceOutput.Text = "$0.00"
        '
        'txtMilesTraveled
        '
        Me.txtMilesTraveled.Location = New System.Drawing.Point(442, 29)
        Me.txtMilesTraveled.Name = "txtMilesTraveled"
        Me.txtMilesTraveled.Size = New System.Drawing.Size(150, 20)
        Me.txtMilesTraveled.TabIndex = 12
        '
        'txtCostPerGallon
        '
        Me.txtCostPerGallon.Location = New System.Drawing.Point(442, 6)
        Me.txtCostPerGallon.Name = "txtCostPerGallon"
        Me.txtCostPerGallon.Size = New System.Drawing.Size(150, 20)
        Me.txtCostPerGallon.TabIndex = 13
        '
        'txtSUVMPG
        '
        Me.txtSUVMPG.Location = New System.Drawing.Point(442, 74)
        Me.txtSUVMPG.Name = "txtSUVMPG"
        Me.txtSUVMPG.Size = New System.Drawing.Size(150, 20)
        Me.txtSUVMPG.TabIndex = 15
        '
        'txtCompactMPG
        '
        Me.txtCompactMPG.Location = New System.Drawing.Point(442, 96)
        Me.txtCompactMPG.Name = "txtCompactMPG"
        Me.txtCompactMPG.Size = New System.Drawing.Size(150, 20)
        Me.txtCompactMPG.TabIndex = 16
        '
        'cboYearsOwned
        '
        Me.cboYearsOwned.FormattingEnabled = True
        Me.cboYearsOwned.Items.AddRange(New Object() {"1", "2", "3", "4", "5", "6", "7", "8", "9", "10"})
        Me.cboYearsOwned.Location = New System.Drawing.Point(442, 51)
        Me.cboYearsOwned.Name = "cboYearsOwned"
        Me.cboYearsOwned.Size = New System.Drawing.Size(150, 21)
        Me.cboYearsOwned.TabIndex = 17
        '
        'frmCompareGasCost
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(604, 276)
        Me.Controls.Add(Me.cboYearsOwned)
        Me.Controls.Add(Me.txtCompactMPG)
        Me.Controls.Add(Me.txtSUVMPG)
        Me.Controls.Add(Me.txtCostPerGallon)
        Me.Controls.Add(Me.txtMilesTraveled)
        Me.Controls.Add(Me.lblDifferenceOutput)
        Me.Controls.Add(Me.lblCompactCarCostOutput)
        Me.Controls.Add(Me.lblSUVCostOutput)
        Me.Controls.Add(Me.lblDifference)
        Me.Controls.Add(Me.lblCompactCarCost)
        Me.Controls.Add(Me.lblSUVCost)
        Me.Controls.Add(Me.btnCalculateCost)
        Me.Controls.Add(Me.lblCompactMPG)
        Me.Controls.Add(Me.lblSUVMPG)
        Me.Controls.Add(Me.lblYearsOwned)
        Me.Controls.Add(Me.lblMilesTraveled)
        Me.Controls.Add(Me.lblCostPerGallon)
        Me.Name = "frmCompareGasCost"
        Me.Text = "Compare Gas Mileage"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblCostPerGallon As System.Windows.Forms.Label
    Friend WithEvents lblMilesTraveled As System.Windows.Forms.Label
    Friend WithEvents lblYearsOwned As System.Windows.Forms.Label
    Friend WithEvents lblSUVMPG As System.Windows.Forms.Label
    Friend WithEvents lblCompactMPG As System.Windows.Forms.Label
    Friend WithEvents btnCalculateCost As System.Windows.Forms.Button
    Friend WithEvents lblSUVCost As System.Windows.Forms.Label
    Friend WithEvents lblCompactCarCost As System.Windows.Forms.Label
    Friend WithEvents lblDifference As System.Windows.Forms.Label
    Friend WithEvents lblSUVCostOutput As System.Windows.Forms.Label
    Friend WithEvents lblCompactCarCostOutput As System.Windows.Forms.Label
    Friend WithEvents lblDifferenceOutput As System.Windows.Forms.Label
    Friend WithEvents txtMilesTraveled As System.Windows.Forms.TextBox
    Friend WithEvents txtCostPerGallon As System.Windows.Forms.TextBox
    Friend WithEvents txtSUVMPG As System.Windows.Forms.TextBox
    Friend WithEvents txtCompactMPG As System.Windows.Forms.TextBox
    Friend WithEvents cboYearsOwned As System.Windows.Forms.ComboBox

End Class
