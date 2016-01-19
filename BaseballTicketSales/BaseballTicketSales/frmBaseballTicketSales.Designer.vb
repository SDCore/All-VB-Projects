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
        CType(Me.imgBuyTickets, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'imgBuyTickets
        '
        Me.imgBuyTickets.BackgroundImage = CType(resources.GetObject("imgBuyTickets.BackgroundImage"), System.Drawing.Image)
        Me.imgBuyTickets.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.imgBuyTickets.ErrorImage = CType(resources.GetObject("imgBuyTickets.ErrorImage"), System.Drawing.Image)
        Me.imgBuyTickets.Location = New System.Drawing.Point(156, 57)
        Me.imgBuyTickets.Name = "imgBuyTickets"
        Me.imgBuyTickets.Size = New System.Drawing.Size(141, 85)
        Me.imgBuyTickets.TabIndex = 0
        Me.imgBuyTickets.TabStop = False
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.Font = New System.Drawing.Font("Segoe UI", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle.Location = New System.Drawing.Point(76, 9)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(310, 45)
        Me.lblTitle.TabIndex = 1
        Me.lblTitle.Text = "Baseball Ticket Sales"
        '
        'frmBaseballTicketSales
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(454, 448)
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

End Class
