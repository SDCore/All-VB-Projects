﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCampgroundRates
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmCampgroundRates))
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.cboStayType = New System.Windows.Forms.ComboBox()
        Me.lblNumberOfNights = New System.Windows.Forms.Label()
        Me.txtNumberOfNights = New System.Windows.Forms.TextBox()
        Me.lblStayType = New System.Windows.Forms.Label()
        Me.lblDiscount = New System.Windows.Forms.Label()
        Me.cboDiscount = New System.Windows.Forms.ComboBox()
        Me.lblSubtotalOutput = New System.Windows.Forms.Label()
        Me.lblDiscountOutput = New System.Windows.Forms.Label()
        Me.lblTotalOutput = New System.Windows.Forms.Label()
        Me.lblDivider = New System.Windows.Forms.Label()
        Me.btnCalculateCost = New System.Windows.Forms.Button()
        Me.lblTaxes = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.Location = New System.Drawing.Point(13, 13)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(459, 221)
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.BackColor = System.Drawing.Color.Transparent
        Me.lblTitle.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle.Location = New System.Drawing.Point(109, 13)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(267, 30)
        Me.lblTitle.TabIndex = 1
        Me.lblTitle.Text = "Misty River Campgrounds"
        '
        'cboStayType
        '
        Me.cboStayType.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboStayType.FormattingEnabled = True
        Me.cboStayType.Items.AddRange(New Object() {"Tent Site - $20", "RV Site - $35", "Cabin Rental - $55"})
        Me.cboStayType.Location = New System.Drawing.Point(170, 241)
        Me.cboStayType.Name = "cboStayType"
        Me.cboStayType.Size = New System.Drawing.Size(302, 25)
        Me.cboStayType.TabIndex = 2
        Me.cboStayType.Text = "Select an Item"
        '
        'lblNumberOfNights
        '
        Me.lblNumberOfNights.AutoSize = True
        Me.lblNumberOfNights.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNumberOfNights.Location = New System.Drawing.Point(12, 275)
        Me.lblNumberOfNights.Name = "lblNumberOfNights"
        Me.lblNumberOfNights.Size = New System.Drawing.Size(114, 17)
        Me.lblNumberOfNights.TabIndex = 3
        Me.lblNumberOfNights.Text = "Number of Nights"
        '
        'txtNumberOfNights
        '
        Me.txtNumberOfNights.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNumberOfNights.Location = New System.Drawing.Point(132, 272)
        Me.txtNumberOfNights.Name = "txtNumberOfNights"
        Me.txtNumberOfNights.Size = New System.Drawing.Size(340, 25)
        Me.txtNumberOfNights.TabIndex = 4
        '
        'lblStayType
        '
        Me.lblStayType.AutoSize = True
        Me.lblStayType.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStayType.Location = New System.Drawing.Point(12, 244)
        Me.lblStayType.Name = "lblStayType"
        Me.lblStayType.Size = New System.Drawing.Size(152, 17)
        Me.lblStayType.TabIndex = 5
        Me.lblStayType.Text = "What are you Staying In?"
        '
        'lblDiscount
        '
        Me.lblDiscount.AutoSize = True
        Me.lblDiscount.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDiscount.Location = New System.Drawing.Point(12, 306)
        Me.lblDiscount.Name = "lblDiscount"
        Me.lblDiscount.Size = New System.Drawing.Size(58, 17)
        Me.lblDiscount.TabIndex = 6
        Me.lblDiscount.Text = "Discount"
        '
        'cboDiscount
        '
        Me.cboDiscount.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboDiscount.FormattingEnabled = True
        Me.cboDiscount.Items.AddRange(New Object() {"None", "AAA (10%)", "Military (12%)"})
        Me.cboDiscount.Location = New System.Drawing.Point(76, 303)
        Me.cboDiscount.Name = "cboDiscount"
        Me.cboDiscount.Size = New System.Drawing.Size(396, 25)
        Me.cboDiscount.TabIndex = 7
        Me.cboDiscount.Text = "Select an Item"
        '
        'lblSubtotalOutput
        '
        Me.lblSubtotalOutput.AutoSize = True
        Me.lblSubtotalOutput.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSubtotalOutput.Location = New System.Drawing.Point(166, 393)
        Me.lblSubtotalOutput.Name = "lblSubtotalOutput"
        Me.lblSubtotalOutput.Size = New System.Drawing.Size(117, 21)
        Me.lblSubtotalOutput.TabIndex = 8
        Me.lblSubtotalOutput.Text = "SubTotal: $0.00"
        '
        'lblDiscountOutput
        '
        Me.lblDiscountOutput.AutoSize = True
        Me.lblDiscountOutput.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDiscountOutput.Location = New System.Drawing.Point(166, 416)
        Me.lblDiscountOutput.Name = "lblDiscountOutput"
        Me.lblDiscountOutput.Size = New System.Drawing.Size(117, 21)
        Me.lblDiscountOutput.TabIndex = 9
        Me.lblDiscountOutput.Text = "Discount: $0.00"
        '
        'lblTotalOutput
        '
        Me.lblTotalOutput.AutoSize = True
        Me.lblTotalOutput.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalOutput.Location = New System.Drawing.Point(166, 486)
        Me.lblTotalOutput.Name = "lblTotalOutput"
        Me.lblTotalOutput.Size = New System.Drawing.Size(90, 21)
        Me.lblTotalOutput.TabIndex = 10
        Me.lblTotalOutput.Text = "Total: $0.00"
        '
        'lblDivider
        '
        Me.lblDivider.AutoSize = True
        Me.lblDivider.BackColor = System.Drawing.Color.Transparent
        Me.lblDivider.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDivider.Location = New System.Drawing.Point(-62, 465)
        Me.lblDivider.Name = "lblDivider"
        Me.lblDivider.Size = New System.Drawing.Size(605, 21)
        Me.lblDivider.TabIndex = 11
        Me.lblDivider.Text = "_________________________________________________________________________________" & _
    "____"
        '
        'btnCalculateCost
        '
        Me.btnCalculateCost.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCalculateCost.Location = New System.Drawing.Point(15, 335)
        Me.btnCalculateCost.Name = "btnCalculateCost"
        Me.btnCalculateCost.Size = New System.Drawing.Size(457, 51)
        Me.btnCalculateCost.TabIndex = 12
        Me.btnCalculateCost.Text = "Calculate Cost"
        Me.btnCalculateCost.UseVisualStyleBackColor = True
        '
        'lblTaxes
        '
        Me.lblTaxes.AutoSize = True
        Me.lblTaxes.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTaxes.Location = New System.Drawing.Point(166, 442)
        Me.lblTaxes.Name = "lblTaxes"
        Me.lblTaxes.Size = New System.Drawing.Size(79, 21)
        Me.lblTaxes.TabIndex = 13
        Me.lblTaxes.Text = "Tax: $0.00"
        '
        'frmCampgroundRates
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(484, 514)
        Me.Controls.Add(Me.lblTaxes)
        Me.Controls.Add(Me.btnCalculateCost)
        Me.Controls.Add(Me.lblDivider)
        Me.Controls.Add(Me.lblTotalOutput)
        Me.Controls.Add(Me.lblDiscountOutput)
        Me.Controls.Add(Me.lblSubtotalOutput)
        Me.Controls.Add(Me.cboDiscount)
        Me.Controls.Add(Me.lblDiscount)
        Me.Controls.Add(Me.lblStayType)
        Me.Controls.Add(Me.txtNumberOfNights)
        Me.Controls.Add(Me.lblNumberOfNights)
        Me.Controls.Add(Me.cboStayType)
        Me.Controls.Add(Me.lblTitle)
        Me.Controls.Add(Me.PictureBox1)
        Me.Name = "frmCampgroundRates"
        Me.Text = "Campground Rates"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents lblTitle As System.Windows.Forms.Label
    Friend WithEvents cboStayType As System.Windows.Forms.ComboBox
    Friend WithEvents lblNumberOfNights As System.Windows.Forms.Label
    Friend WithEvents txtNumberOfNights As System.Windows.Forms.TextBox
    Friend WithEvents lblStayType As System.Windows.Forms.Label
    Friend WithEvents lblDiscount As System.Windows.Forms.Label
    Friend WithEvents cboDiscount As System.Windows.Forms.ComboBox
    Friend WithEvents lblSubtotalOutput As System.Windows.Forms.Label
    Friend WithEvents lblDiscountOutput As System.Windows.Forms.Label
    Friend WithEvents lblTotalOutput As System.Windows.Forms.Label
    Friend WithEvents lblDivider As System.Windows.Forms.Label
    Friend WithEvents btnCalculateCost As System.Windows.Forms.Button
    Friend WithEvents lblTaxes As System.Windows.Forms.Label

End Class
