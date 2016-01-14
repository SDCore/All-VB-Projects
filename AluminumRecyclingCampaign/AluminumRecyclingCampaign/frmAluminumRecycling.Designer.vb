<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAluminumRecycling
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmAluminumRecycling))
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.picRecycling = New System.Windows.Forms.PictureBox()
        Me.lblRecyclingNeed = New System.Windows.Forms.Label()
        Me.cboRecyclingNeed = New System.Windows.Forms.ComboBox()
        Me.lblGoalandCans = New System.Windows.Forms.Label()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnCalculate = New System.Windows.Forms.Button()
        Me.txtAmount = New System.Windows.Forms.TextBox()
        Me.lblOutput = New System.Windows.Forms.Label()
        Me.lblOutputText = New System.Windows.Forms.Label()
        CType(Me.picRecycling, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.BackColor = System.Drawing.Color.Black
        Me.lblTitle.Font = New System.Drawing.Font("Segoe UI", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle.ForeColor = System.Drawing.Color.White
        Me.lblTitle.Location = New System.Drawing.Point(12, 9)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(387, 37)
        Me.lblTitle.TabIndex = 0
        Me.lblTitle.Text = "Aluminum Recycling Campaign"
        '
        'picRecycling
        '
        Me.picRecycling.Image = CType(resources.GetObject("picRecycling.Image"), System.Drawing.Image)
        Me.picRecycling.InitialImage = CType(resources.GetObject("picRecycling.InitialImage"), System.Drawing.Image)
        Me.picRecycling.Location = New System.Drawing.Point(12, 49)
        Me.picRecycling.Name = "picRecycling"
        Me.picRecycling.Size = New System.Drawing.Size(387, 115)
        Me.picRecycling.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picRecycling.TabIndex = 1
        Me.picRecycling.TabStop = False
        '
        'lblRecyclingNeed
        '
        Me.lblRecyclingNeed.AutoSize = True
        Me.lblRecyclingNeed.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRecyclingNeed.Location = New System.Drawing.Point(16, 210)
        Me.lblRecyclingNeed.Name = "lblRecyclingNeed"
        Me.lblRecyclingNeed.Size = New System.Drawing.Size(143, 17)
        Me.lblRecyclingNeed.TabIndex = 2
        Me.lblRecyclingNeed.Text = "Select Recycling Need: "
        '
        'cboRecyclingNeed
        '
        Me.cboRecyclingNeed.FormattingEnabled = True
        Me.cboRecyclingNeed.Items.AddRange(New Object() {"Calculate Number of Cans Needed to make Target Goal", "Calculate the Amount Earned based on Cans Collected"})
        Me.cboRecyclingNeed.Location = New System.Drawing.Point(19, 231)
        Me.cboRecyclingNeed.Name = "cboRecyclingNeed"
        Me.cboRecyclingNeed.Size = New System.Drawing.Size(380, 21)
        Me.cboRecyclingNeed.TabIndex = 3
        Me.cboRecyclingNeed.Text = "Select an Item"
        '
        'lblGoalandCans
        '
        Me.lblGoalandCans.AutoSize = True
        Me.lblGoalandCans.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblGoalandCans.Location = New System.Drawing.Point(41, 264)
        Me.lblGoalandCans.Name = "lblGoalandCans"
        Me.lblGoalandCans.Size = New System.Drawing.Size(142, 17)
        Me.lblGoalandCans.TabIndex = 4
        Me.lblGoalandCans.Text = "Target Goal Amount: "
        '
        'btnClear
        '
        Me.btnClear.BackColor = System.Drawing.Color.Black
        Me.btnClear.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClear.ForeColor = System.Drawing.Color.White
        Me.btnClear.Location = New System.Drawing.Point(212, 295)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(188, 42)
        Me.btnClear.TabIndex = 5
        Me.btnClear.Text = "Clear Form"
        Me.btnClear.UseVisualStyleBackColor = False
        '
        'btnCalculate
        '
        Me.btnCalculate.BackColor = System.Drawing.Color.Black
        Me.btnCalculate.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCalculate.ForeColor = System.Drawing.Color.White
        Me.btnCalculate.Location = New System.Drawing.Point(19, 295)
        Me.btnCalculate.Name = "btnCalculate"
        Me.btnCalculate.Size = New System.Drawing.Size(180, 42)
        Me.btnCalculate.TabIndex = 6
        Me.btnCalculate.Text = "Find Target Amount of Cans"
        Me.btnCalculate.UseVisualStyleBackColor = False
        '
        'txtAmount
        '
        Me.txtAmount.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAmount.Location = New System.Drawing.Point(213, 261)
        Me.txtAmount.Name = "txtAmount"
        Me.txtAmount.Size = New System.Drawing.Size(187, 25)
        Me.txtAmount.TabIndex = 7
        '
        'lblOutput
        '
        Me.lblOutput.AutoSize = True
        Me.lblOutput.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblOutput.Location = New System.Drawing.Point(181, 351)
        Me.lblOutput.Name = "lblOutput"
        Me.lblOutput.Size = New System.Drawing.Size(49, 21)
        Me.lblOutput.TabIndex = 8
        Me.lblOutput.Text = "0,000"
        '
        'lblOutputText
        '
        Me.lblOutputText.AutoSize = True
        Me.lblOutputText.BackColor = System.Drawing.Color.Transparent
        Me.lblOutputText.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblOutputText.Location = New System.Drawing.Point(51, 372)
        Me.lblOutputText.Name = "lblOutputText"
        Me.lblOutputText.Size = New System.Drawing.Size(313, 21)
        Me.lblOutputText.TabIndex = 9
        Me.lblOutputText.Text = "cans need to be collected to reach your goal"
        '
        'frmAluminumRecycling
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(412, 398)
        Me.Controls.Add(Me.lblOutputText)
        Me.Controls.Add(Me.lblOutput)
        Me.Controls.Add(Me.txtAmount)
        Me.Controls.Add(Me.btnCalculate)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.lblGoalandCans)
        Me.Controls.Add(Me.cboRecyclingNeed)
        Me.Controls.Add(Me.lblRecyclingNeed)
        Me.Controls.Add(Me.picRecycling)
        Me.Controls.Add(Me.lblTitle)
        Me.Name = "frmAluminumRecycling"
        Me.Text = "Aluminum Recycling Campaign"
        CType(Me.picRecycling, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblTitle As System.Windows.Forms.Label
    Friend WithEvents picRecycling As System.Windows.Forms.PictureBox
    Friend WithEvents lblRecyclingNeed As System.Windows.Forms.Label
    Friend WithEvents cboRecyclingNeed As System.Windows.Forms.ComboBox
    Friend WithEvents lblGoalandCans As System.Windows.Forms.Label
    Friend WithEvents btnClear As System.Windows.Forms.Button
    Friend WithEvents btnCalculate As System.Windows.Forms.Button
    Friend WithEvents txtAmount As System.Windows.Forms.TextBox
    Friend WithEvents lblOutput As System.Windows.Forms.Label
    Friend WithEvents lblOutputText As System.Windows.Forms.Label

End Class
