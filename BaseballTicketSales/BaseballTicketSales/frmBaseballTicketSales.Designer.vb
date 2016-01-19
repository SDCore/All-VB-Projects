<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmBaseballTicketSales
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmBaseballTicketSales))
        Me.imgBuyTickets = New System.Windows.Forms.PictureBox()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.lblTicketType = New System.Windows.Forms.Label()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.lblNumberOfTickets = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.lblSeatType = New System.Windows.Forms.Label()
        Me.ComboBox2 = New System.Windows.Forms.ComboBox()
        Me.btnComputeCost = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.lblTotalCost = New System.Windows.Forms.Label()
        CType(Me.imgBuyTickets, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'imgBuyTickets
        '
        Me.imgBuyTickets.BackgroundImage = CType(resources.GetObject("imgBuyTickets.BackgroundImage"), System.Drawing.Image)
        Me.imgBuyTickets.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.imgBuyTickets.ErrorImage = CType(resources.GetObject("imgBuyTickets.ErrorImage"), System.Drawing.Image)
        Me.imgBuyTickets.Location = New System.Drawing.Point(328, 12)
        Me.imgBuyTickets.Name = "imgBuyTickets"
        Me.imgBuyTickets.Size = New System.Drawing.Size(114, 62)
        Me.imgBuyTickets.TabIndex = 0
        Me.imgBuyTickets.TabStop = False
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.Font = New System.Drawing.Font("Segoe UI", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle.Location = New System.Drawing.Point(12, 29)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(310, 45)
        Me.lblTitle.TabIndex = 1
        Me.lblTitle.Text = "Baseball Ticket Sales"
        '
        'lblTicketType
        '
        Me.lblTicketType.AutoSize = True
        Me.lblTicketType.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTicketType.Location = New System.Drawing.Point(17, 112)
        Me.lblTicketType.Name = "lblTicketType"
        Me.lblTicketType.Size = New System.Drawing.Size(130, 17)
        Me.lblTicketType.TabIndex = 2
        Me.lblTicketType.Text = "Select Type of Ticket:"
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(153, 112)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(289, 21)
        Me.ComboBox1.TabIndex = 3
        Me.ComboBox1.Text = "Select an Item"
        '
        'lblNumberOfTickets
        '
        Me.lblNumberOfTickets.AutoSize = True
        Me.lblNumberOfTickets.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNumberOfTickets.Location = New System.Drawing.Point(17, 143)
        Me.lblNumberOfTickets.Name = "lblNumberOfTickets"
        Me.lblNumberOfTickets.Size = New System.Drawing.Size(118, 17)
        Me.lblNumberOfTickets.TabIndex = 4
        Me.lblNumberOfTickets.Text = "Number of Tickets:"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(141, 143)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(301, 20)
        Me.TextBox1.TabIndex = 5
        '
        'lblSeatType
        '
        Me.lblSeatType.AutoSize = True
        Me.lblSeatType.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSeatType.Location = New System.Drawing.Point(17, 175)
        Me.lblSeatType.Name = "lblSeatType"
        Me.lblSeatType.Size = New System.Drawing.Size(68, 17)
        Me.lblSeatType.TabIndex = 6
        Me.lblSeatType.Text = "Seat Type:"
        '
        'ComboBox2
        '
        Me.ComboBox2.FormattingEnabled = True
        Me.ComboBox2.Location = New System.Drawing.Point(91, 175)
        Me.ComboBox2.Name = "ComboBox2"
        Me.ComboBox2.Size = New System.Drawing.Size(351, 21)
        Me.ComboBox2.TabIndex = 7
        Me.ComboBox2.Text = "Select an Item"
        '
        'btnComputeCost
        '
        Me.btnComputeCost.BackColor = System.Drawing.Color.Black
        Me.btnComputeCost.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnComputeCost.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnComputeCost.ForeColor = System.Drawing.Color.White
        Me.btnComputeCost.Location = New System.Drawing.Point(20, 220)
        Me.btnComputeCost.Name = "btnComputeCost"
        Me.btnComputeCost.Size = New System.Drawing.Size(196, 40)
        Me.btnComputeCost.TabIndex = 8
        Me.btnComputeCost.Text = "Compute Ticket Cost"
        Me.btnComputeCost.UseVisualStyleBackColor = False
        '
        'btnClear
        '
        Me.btnClear.BackColor = System.Drawing.Color.Black
        Me.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnClear.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClear.ForeColor = System.Drawing.Color.White
        Me.btnClear.Location = New System.Drawing.Point(222, 220)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(220, 40)
        Me.btnClear.TabIndex = 9
        Me.btnClear.Text = "Clear Form"
        Me.btnClear.UseVisualStyleBackColor = False
        '
        'lblTotalCost
        '
        Me.lblTotalCost.AutoSize = True
        Me.lblTotalCost.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalCost.Location = New System.Drawing.Point(101, 272)
        Me.lblTotalCost.Name = "lblTotalCost"
        Me.lblTotalCost.Size = New System.Drawing.Size(238, 17)
        Me.lblTotalCost.TabIndex = 10
        Me.lblTotalCost.Text = "Total cost of tickets purchased: $000.00"
        '
        'frmBaseballTicketSales
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(454, 302)
        Me.Controls.Add(Me.lblTotalCost)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnComputeCost)
        Me.Controls.Add(Me.ComboBox2)
        Me.Controls.Add(Me.lblSeatType)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.lblNumberOfTickets)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.lblTicketType)
        Me.Controls.Add(Me.lblTitle)
        Me.Controls.Add(Me.imgBuyTickets)
        Me.Name = "frmBaseballTicketSales"
        Me.Text = "Buy Tickets"
        CType(Me.imgBuyTickets, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents imgBuyTickets As System.Windows.Forms.PictureBox
    Friend WithEvents lblTitle As System.Windows.Forms.Label
    Friend WithEvents lblTicketType As System.Windows.Forms.Label
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents lblNumberOfTickets As System.Windows.Forms.Label
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents lblSeatType As System.Windows.Forms.Label
    Friend WithEvents ComboBox2 As System.Windows.Forms.ComboBox
    Friend WithEvents btnComputeCost As System.Windows.Forms.Button
    Friend WithEvents btnClear As System.Windows.Forms.Button
    Friend WithEvents lblTotalCost As System.Windows.Forms.Label

End Class
