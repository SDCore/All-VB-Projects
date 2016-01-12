<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmGalaxyHotel
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
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.lstFloors = New System.Windows.Forms.ListBox()
        Me.lblFloorAverage = New System.Windows.Forms.Label()
        Me.lblFloorAverageOutput = New System.Windows.Forms.Label()
        Me.btwShowFloors = New System.Windows.Forms.Button()
        Me.lblTotalRooms = New System.Windows.Forms.Label()
        Me.lblTotalRoomsOutput = New System.Windows.Forms.Label()
        Me.lblOccupiedRooms = New System.Windows.Forms.Label()
        Me.lblOccupiedRoomsOutput = New System.Windows.Forms.Label()
        Me.lblVacantRooms = New System.Windows.Forms.Label()
        Me.lblVacantRoomsOutput = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.Font = New System.Drawing.Font("Segoe UI", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle.Location = New System.Drawing.Point(55, 9)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(168, 37)
        Me.lblTitle.TabIndex = 0
        Me.lblTitle.Text = "Galaxy Hotel"
        Me.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lstFloors
        '
        Me.lstFloors.FormattingEnabled = True
        Me.lstFloors.Location = New System.Drawing.Point(12, 49)
        Me.lstFloors.Name = "lstFloors"
        Me.lstFloors.Size = New System.Drawing.Size(261, 212)
        Me.lstFloors.TabIndex = 1
        '
        'lblFloorAverage
        '
        Me.lblFloorAverage.AutoSize = True
        Me.lblFloorAverage.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFloorAverage.Location = New System.Drawing.Point(43, 264)
        Me.lblFloorAverage.Name = "lblFloorAverage"
        Me.lblFloorAverage.Size = New System.Drawing.Size(128, 21)
        Me.lblFloorAverage.TabIndex = 2
        Me.lblFloorAverage.Text = "Occupancy Rate: "
        '
        'lblFloorAverageOutput
        '
        Me.lblFloorAverageOutput.AutoSize = True
        Me.lblFloorAverageOutput.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFloorAverageOutput.Location = New System.Drawing.Point(190, 264)
        Me.lblFloorAverageOutput.Name = "lblFloorAverageOutput"
        Me.lblFloorAverageOutput.Size = New System.Drawing.Size(32, 21)
        Me.lblFloorAverageOutput.TabIndex = 3
        Me.lblFloorAverageOutput.Text = "0%"
        '
        'btwShowFloors
        '
        Me.btwShowFloors.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btwShowFloors.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btwShowFloors.Location = New System.Drawing.Point(12, 351)
        Me.btwShowFloors.Name = "btwShowFloors"
        Me.btwShowFloors.Size = New System.Drawing.Size(261, 39)
        Me.btwShowFloors.TabIndex = 4
        Me.btwShowFloors.Text = "Calculate Average"
        Me.btwShowFloors.UseVisualStyleBackColor = True
        '
        'lblTotalRooms
        '
        Me.lblTotalRooms.AutoSize = True
        Me.lblTotalRooms.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalRooms.Location = New System.Drawing.Point(43, 285)
        Me.lblTotalRooms.Name = "lblTotalRooms"
        Me.lblTotalRooms.Size = New System.Drawing.Size(104, 21)
        Me.lblTotalRooms.TabIndex = 5
        Me.lblTotalRooms.Text = "Total Rooms: "
        '
        'lblTotalRoomsOutput
        '
        Me.lblTotalRoomsOutput.AutoSize = True
        Me.lblTotalRoomsOutput.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalRoomsOutput.Location = New System.Drawing.Point(196, 285)
        Me.lblTotalRoomsOutput.Name = "lblTotalRoomsOutput"
        Me.lblTotalRoomsOutput.Size = New System.Drawing.Size(19, 21)
        Me.lblTotalRoomsOutput.TabIndex = 6
        Me.lblTotalRoomsOutput.Text = "0"
        '
        'lblOccupiedRooms
        '
        Me.lblOccupiedRooms.AutoSize = True
        Me.lblOccupiedRooms.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblOccupiedRooms.Location = New System.Drawing.Point(43, 306)
        Me.lblOccupiedRooms.Name = "lblOccupiedRooms"
        Me.lblOccupiedRooms.Size = New System.Drawing.Size(135, 21)
        Me.lblOccupiedRooms.TabIndex = 7
        Me.lblOccupiedRooms.Text = "Occupied Rooms: "
        '
        'lblOccupiedRoomsOutput
        '
        Me.lblOccupiedRoomsOutput.AutoSize = True
        Me.lblOccupiedRoomsOutput.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblOccupiedRoomsOutput.Location = New System.Drawing.Point(196, 306)
        Me.lblOccupiedRoomsOutput.Name = "lblOccupiedRoomsOutput"
        Me.lblOccupiedRoomsOutput.Size = New System.Drawing.Size(19, 21)
        Me.lblOccupiedRoomsOutput.TabIndex = 8
        Me.lblOccupiedRoomsOutput.Text = "0"
        '
        'lblVacantRooms
        '
        Me.lblVacantRooms.AutoSize = True
        Me.lblVacantRooms.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblVacantRooms.Location = New System.Drawing.Point(43, 327)
        Me.lblVacantRooms.Name = "lblVacantRooms"
        Me.lblVacantRooms.Size = New System.Drawing.Size(117, 21)
        Me.lblVacantRooms.TabIndex = 9
        Me.lblVacantRooms.Text = "Vacant Rooms: "
        '
        'lblVacantRoomsOutput
        '
        Me.lblVacantRoomsOutput.AutoSize = True
        Me.lblVacantRoomsOutput.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblVacantRoomsOutput.Location = New System.Drawing.Point(196, 327)
        Me.lblVacantRoomsOutput.Name = "lblVacantRoomsOutput"
        Me.lblVacantRoomsOutput.Size = New System.Drawing.Size(19, 21)
        Me.lblVacantRoomsOutput.TabIndex = 10
        Me.lblVacantRoomsOutput.Text = "0"
        '
        'frmGalaxyHotel
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(285, 395)
        Me.Controls.Add(Me.lblVacantRoomsOutput)
        Me.Controls.Add(Me.lblVacantRooms)
        Me.Controls.Add(Me.lblOccupiedRoomsOutput)
        Me.Controls.Add(Me.lblOccupiedRooms)
        Me.Controls.Add(Me.lblTotalRoomsOutput)
        Me.Controls.Add(Me.lblTotalRooms)
        Me.Controls.Add(Me.btwShowFloors)
        Me.Controls.Add(Me.lblFloorAverageOutput)
        Me.Controls.Add(Me.lblFloorAverage)
        Me.Controls.Add(Me.lstFloors)
        Me.Controls.Add(Me.lblTitle)
        Me.ForeColor = System.Drawing.Color.Black
        Me.Name = "frmGalaxyHotel"
        Me.Text = "Galaxy Hotel"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblTitle As System.Windows.Forms.Label
    Friend WithEvents lstFloors As System.Windows.Forms.ListBox
    Friend WithEvents lblFloorAverage As System.Windows.Forms.Label
    Friend WithEvents lblFloorAverageOutput As System.Windows.Forms.Label
    Friend WithEvents btwShowFloors As System.Windows.Forms.Button
    Friend WithEvents lblTotalRooms As System.Windows.Forms.Label
    Friend WithEvents lblTotalRoomsOutput As System.Windows.Forms.Label
    Friend WithEvents lblOccupiedRooms As System.Windows.Forms.Label
    Friend WithEvents lblOccupiedRoomsOutput As System.Windows.Forms.Label
    Friend WithEvents lblVacantRooms As System.Windows.Forms.Label
    Friend WithEvents lblVacantRoomsOutput As System.Windows.Forms.Label

End Class
