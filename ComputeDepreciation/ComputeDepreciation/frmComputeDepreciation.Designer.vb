﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmComputeDepreciation
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
        Me.components = New System.ComponentModel.Container()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.cboInventoryItem = New System.Windows.Forms.ComboBox()
        Me.lblInventoryItem = New System.Windows.Forms.Label()
        Me.grpDepreciationMethod = New System.Windows.Forms.GroupBox()
        Me.rdoDoubleBalance = New System.Windows.Forms.RadioButton()
        Me.rdoStraightLine = New System.Windows.Forms.RadioButton()
        Me.btnCalculate = New System.Windows.Forms.Button()
        Me.lblItemOutput = New System.Windows.Forms.Label()
        Me.lblQuantityOutput = New System.Windows.Forms.Label()
        Me.lstPresentYear = New System.Windows.Forms.ListBox()
        Me.lstTotalDepreciation = New System.Windows.Forms.ListBox()
        Me.lstYearDepreciation = New System.Windows.Forms.ListBox()
        Me.lstPresentValue = New System.Windows.Forms.ListBox()
        Me.lblPresentYear = New System.Windows.Forms.Label()
        Me.lblTotalDepreciation = New System.Windows.Forms.Label()
        Me.lblYearDepreciation = New System.Windows.Forms.Label()
        Me.lblPresentValue = New System.Windows.Forms.Label()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DisplayInventoryToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ClearToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.grpDepreciationMethod.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.Font = New System.Drawing.Font("Lucida Sans Typewriter", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle.ForeColor = System.Drawing.Color.DimGray
        Me.lblTitle.Location = New System.Drawing.Point(12, 21)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(525, 33)
        Me.lblTitle.TabIndex = 0
        Me.lblTitle.Text = "Light Span Computers Inventory"
        '
        'cboInventoryItem
        '
        Me.cboInventoryItem.FormattingEnabled = True
        Me.cboInventoryItem.Items.AddRange(New Object() {"C101", "C102", "P203", "P204", "H407", "F305", "T209", "C507"})
        Me.cboInventoryItem.Location = New System.Drawing.Point(18, 94)
        Me.cboInventoryItem.Name = "cboInventoryItem"
        Me.cboInventoryItem.Size = New System.Drawing.Size(228, 21)
        Me.cboInventoryItem.TabIndex = 1
        Me.cboInventoryItem.Text = "Select an Item"
        '
        'lblInventoryItem
        '
        Me.lblInventoryItem.AutoSize = True
        Me.lblInventoryItem.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblInventoryItem.Location = New System.Drawing.Point(15, 74)
        Me.lblInventoryItem.Name = "lblInventoryItem"
        Me.lblInventoryItem.Size = New System.Drawing.Size(128, 17)
        Me.lblInventoryItem.TabIndex = 2
        Me.lblInventoryItem.Text = "Select Inventory Item"
        '
        'grpDepreciationMethod
        '
        Me.grpDepreciationMethod.Controls.Add(Me.rdoDoubleBalance)
        Me.grpDepreciationMethod.Controls.Add(Me.rdoStraightLine)
        Me.grpDepreciationMethod.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpDepreciationMethod.Location = New System.Drawing.Point(252, 74)
        Me.grpDepreciationMethod.Name = "grpDepreciationMethod"
        Me.grpDepreciationMethod.Size = New System.Drawing.Size(285, 85)
        Me.grpDepreciationMethod.TabIndex = 3
        Me.grpDepreciationMethod.TabStop = False
        Me.grpDepreciationMethod.Text = "Select Depreciation Method"
        '
        'rdoDoubleBalance
        '
        Me.rdoDoubleBalance.AutoSize = True
        Me.rdoDoubleBalance.Location = New System.Drawing.Point(7, 51)
        Me.rdoDoubleBalance.Name = "rdoDoubleBalance"
        Me.rdoDoubleBalance.Size = New System.Drawing.Size(174, 21)
        Me.rdoDoubleBalance.TabIndex = 1
        Me.rdoDoubleBalance.TabStop = True
        Me.rdoDoubleBalance.Text = "Double-Declining Balance"
        Me.rdoDoubleBalance.UseVisualStyleBackColor = True
        '
        'rdoStraightLine
        '
        Me.rdoStraightLine.AutoSize = True
        Me.rdoStraightLine.Location = New System.Drawing.Point(7, 23)
        Me.rdoStraightLine.Name = "rdoStraightLine"
        Me.rdoStraightLine.Size = New System.Drawing.Size(99, 21)
        Me.rdoStraightLine.TabIndex = 0
        Me.rdoStraightLine.TabStop = True
        Me.rdoStraightLine.Text = "Straight-Line"
        Me.rdoStraightLine.UseVisualStyleBackColor = True
        '
        'btnCalculate
        '
        Me.btnCalculate.BackColor = System.Drawing.Color.Black
        Me.btnCalculate.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCalculate.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCalculate.ForeColor = System.Drawing.Color.White
        Me.btnCalculate.Location = New System.Drawing.Point(18, 166)
        Me.btnCalculate.Name = "btnCalculate"
        Me.btnCalculate.Size = New System.Drawing.Size(519, 38)
        Me.btnCalculate.TabIndex = 4
        Me.btnCalculate.Text = "Calculate Depreciation"
        Me.btnCalculate.UseVisualStyleBackColor = False
        '
        'lblItemOutput
        '
        Me.lblItemOutput.AutoSize = True
        Me.lblItemOutput.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblItemOutput.Location = New System.Drawing.Point(170, 207)
        Me.lblItemOutput.Name = "lblItemOutput"
        Me.lblItemOutput.Size = New System.Drawing.Size(200, 17)
        Me.lblItemOutput.TabIndex = 5
        Me.lblItemOutput.Text = "Depreciation of Item: ITEMNAME"
        Me.lblItemOutput.Visible = False
        '
        'lblQuantityOutput
        '
        Me.lblQuantityOutput.AutoSize = True
        Me.lblQuantityOutput.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblQuantityOutput.Location = New System.Drawing.Point(235, 227)
        Me.lblQuantityOutput.Name = "lblQuantityOutput"
        Me.lblQuantityOutput.Size = New System.Drawing.Size(70, 17)
        Me.lblQuantityOutput.TabIndex = 6
        Me.lblQuantityOutput.Text = "Quantity: 0"
        Me.lblQuantityOutput.Visible = False
        '
        'lstPresentYear
        '
        Me.lstPresentYear.BackColor = System.Drawing.Color.White
        Me.lstPresentYear.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstPresentYear.FormattingEnabled = True
        Me.lstPresentYear.ItemHeight = 17
        Me.lstPresentYear.Location = New System.Drawing.Point(18, 290)
        Me.lstPresentYear.Name = "lstPresentYear"
        Me.lstPresentYear.Size = New System.Drawing.Size(112, 123)
        Me.lstPresentYear.TabIndex = 7
        Me.lstPresentYear.Visible = False
        '
        'lstTotalDepreciation
        '
        Me.lstTotalDepreciation.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstTotalDepreciation.FormattingEnabled = True
        Me.lstTotalDepreciation.ItemHeight = 17
        Me.lstTotalDepreciation.Location = New System.Drawing.Point(403, 290)
        Me.lstTotalDepreciation.Name = "lstTotalDepreciation"
        Me.lstTotalDepreciation.Size = New System.Drawing.Size(130, 123)
        Me.lstTotalDepreciation.TabIndex = 8
        Me.lstTotalDepreciation.Visible = False
        '
        'lstYearDepreciation
        '
        Me.lstYearDepreciation.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstYearDepreciation.FormattingEnabled = True
        Me.lstYearDepreciation.ItemHeight = 17
        Me.lstYearDepreciation.Location = New System.Drawing.Point(252, 290)
        Me.lstYearDepreciation.Name = "lstYearDepreciation"
        Me.lstYearDepreciation.Size = New System.Drawing.Size(145, 123)
        Me.lstYearDepreciation.TabIndex = 9
        Me.lstYearDepreciation.Visible = False
        '
        'lstPresentValue
        '
        Me.lstPresentValue.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstPresentValue.FormattingEnabled = True
        Me.lstPresentValue.ItemHeight = 17
        Me.lstPresentValue.Location = New System.Drawing.Point(136, 290)
        Me.lstPresentValue.Name = "lstPresentValue"
        Me.lstPresentValue.Size = New System.Drawing.Size(110, 123)
        Me.lstPresentValue.TabIndex = 10
        Me.lstPresentValue.Visible = False
        '
        'lblPresentYear
        '
        Me.lblPresentYear.AutoSize = True
        Me.lblPresentYear.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPresentYear.Location = New System.Drawing.Point(15, 270)
        Me.lblPresentYear.Name = "lblPresentYear"
        Me.lblPresentYear.Size = New System.Drawing.Size(81, 17)
        Me.lblPresentYear.TabIndex = 11
        Me.lblPresentYear.Text = "Present Year"
        Me.lblPresentYear.Visible = False
        '
        'lblTotalDepreciation
        '
        Me.lblTotalDepreciation.AutoSize = True
        Me.lblTotalDepreciation.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalDepreciation.Location = New System.Drawing.Point(400, 253)
        Me.lblTotalDepreciation.Name = "lblTotalDepreciation"
        Me.lblTotalDepreciation.Size = New System.Drawing.Size(82, 34)
        Me.lblTotalDepreciation.TabIndex = 12
        Me.lblTotalDepreciation.Text = "Total" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Depreciation"
        Me.lblTotalDepreciation.Visible = False
        '
        'lblYearDepreciation
        '
        Me.lblYearDepreciation.AutoSize = True
        Me.lblYearDepreciation.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblYearDepreciation.Location = New System.Drawing.Point(249, 253)
        Me.lblYearDepreciation.Name = "lblYearDepreciation"
        Me.lblYearDepreciation.Size = New System.Drawing.Size(82, 34)
        Me.lblYearDepreciation.TabIndex = 13
        Me.lblYearDepreciation.Text = "Year" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Depreciation"
        Me.lblYearDepreciation.Visible = False
        '
        'lblPresentValue
        '
        Me.lblPresentValue.AutoSize = True
        Me.lblPresentValue.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPresentValue.Location = New System.Drawing.Point(133, 270)
        Me.lblPresentValue.Name = "lblPresentValue"
        Me.lblPresentValue.Size = New System.Drawing.Size(87, 17)
        Me.lblPresentValue.TabIndex = 14
        Me.lblPresentValue.Text = "Present Value"
        Me.lblPresentValue.Visible = False
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(61, 4)
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(545, 24)
        Me.MenuStrip1.TabIndex = 16
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DisplayInventoryToolStripMenuItem, Me.ClearToolStripMenuItem, Me.ExitToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.FileToolStripMenuItem.Text = "File"
        '
        'DisplayInventoryToolStripMenuItem
        '
        Me.DisplayInventoryToolStripMenuItem.Name = "DisplayInventoryToolStripMenuItem"
        Me.DisplayInventoryToolStripMenuItem.Size = New System.Drawing.Size(165, 22)
        Me.DisplayInventoryToolStripMenuItem.Text = "Display Inventory"
        '
        'ClearToolStripMenuItem
        '
        Me.ClearToolStripMenuItem.Name = "ClearToolStripMenuItem"
        Me.ClearToolStripMenuItem.Size = New System.Drawing.Size(165, 22)
        Me.ClearToolStripMenuItem.Text = "Clear"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(165, 22)
        Me.ExitToolStripMenuItem.Text = "Exit"
        '
        'frmComputeDepreciation
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ClientSize = New System.Drawing.Size(545, 421)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.lblPresentValue)
        Me.Controls.Add(Me.lblYearDepreciation)
        Me.Controls.Add(Me.lblTotalDepreciation)
        Me.Controls.Add(Me.lblPresentYear)
        Me.Controls.Add(Me.lstPresentValue)
        Me.Controls.Add(Me.lstYearDepreciation)
        Me.Controls.Add(Me.lstTotalDepreciation)
        Me.Controls.Add(Me.lstPresentYear)
        Me.Controls.Add(Me.lblQuantityOutput)
        Me.Controls.Add(Me.lblItemOutput)
        Me.Controls.Add(Me.btnCalculate)
        Me.Controls.Add(Me.grpDepreciationMethod)
        Me.Controls.Add(Me.lblInventoryItem)
        Me.Controls.Add(Me.cboInventoryItem)
        Me.Controls.Add(Me.lblTitle)
        Me.Name = "frmComputeDepreciation"
        Me.Text = "Compute Depreciation by Method"
        Me.grpDepreciationMethod.ResumeLayout(False)
        Me.grpDepreciationMethod.PerformLayout()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblTitle As System.Windows.Forms.Label
    Friend WithEvents cboInventoryItem As System.Windows.Forms.ComboBox
    Friend WithEvents lblInventoryItem As System.Windows.Forms.Label
    Friend WithEvents grpDepreciationMethod As System.Windows.Forms.GroupBox
    Friend WithEvents rdoDoubleBalance As System.Windows.Forms.RadioButton
    Friend WithEvents rdoStraightLine As System.Windows.Forms.RadioButton
    Friend WithEvents btnCalculate As System.Windows.Forms.Button
    Friend WithEvents lblItemOutput As System.Windows.Forms.Label
    Friend WithEvents lblQuantityOutput As System.Windows.Forms.Label
    Friend WithEvents lstPresentYear As System.Windows.Forms.ListBox
    Friend WithEvents lstTotalDepreciation As System.Windows.Forms.ListBox
    Friend WithEvents lstYearDepreciation As System.Windows.Forms.ListBox
    Friend WithEvents lstPresentValue As System.Windows.Forms.ListBox
    Friend WithEvents lblPresentYear As System.Windows.Forms.Label
    Friend WithEvents lblTotalDepreciation As System.Windows.Forms.Label
    Friend WithEvents lblYearDepreciation As System.Windows.Forms.Label
    Friend WithEvents lblPresentValue As System.Windows.Forms.Label
    Friend WithEvents ContextMenuStrip1 As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents FileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DisplayInventoryToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ClearToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem

End Class
