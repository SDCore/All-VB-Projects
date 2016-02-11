<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDJPlayList
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmDJPlayList))
        Me.btnShowList = New System.Windows.Forms.Button()
        Me.lblSelectType = New System.Windows.Forms.Label()
        Me.cboMusicGenre = New System.Windows.Forms.ComboBox()
        Me.lblSelectedSongs = New System.Windows.Forms.Label()
        Me.lstSelectedSongs = New System.Windows.Forms.ListBox()
        Me.SuspendLayout()
        '
        'btnShowList
        '
        Me.btnShowList.BackColor = System.Drawing.Color.Black
        Me.btnShowList.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnShowList.Font = New System.Drawing.Font("Segoe UI", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnShowList.ForeColor = System.Drawing.Color.Red
        Me.btnShowList.Location = New System.Drawing.Point(12, 371)
        Me.btnShowList.Name = "btnShowList"
        Me.btnShowList.Size = New System.Drawing.Size(460, 80)
        Me.btnShowList.TabIndex = 0
        Me.btnShowList.Text = "Show Music Playlist"
        Me.btnShowList.UseVisualStyleBackColor = False
        '
        'lblSelectType
        '
        Me.lblSelectType.AutoSize = True
        Me.lblSelectType.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSelectType.ForeColor = System.Drawing.Color.Red
        Me.lblSelectType.Location = New System.Drawing.Point(12, 9)
        Me.lblSelectType.Name = "lblSelectType"
        Me.lblSelectType.Size = New System.Drawing.Size(150, 21)
        Me.lblSelectType.TabIndex = 1
        Me.lblSelectType.Text = "Select Music Genre"
        '
        'cboMusicGenre
        '
        Me.cboMusicGenre.FormattingEnabled = True
        Me.cboMusicGenre.Location = New System.Drawing.Point(12, 34)
        Me.cboMusicGenre.Name = "cboMusicGenre"
        Me.cboMusicGenre.Size = New System.Drawing.Size(460, 21)
        Me.cboMusicGenre.TabIndex = 2
        '
        'lblSelectedSongs
        '
        Me.lblSelectedSongs.AutoSize = True
        Me.lblSelectedSongs.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSelectedSongs.ForeColor = System.Drawing.Color.Red
        Me.lblSelectedSongs.Location = New System.Drawing.Point(12, 77)
        Me.lblSelectedSongs.Name = "lblSelectedSongs"
        Me.lblSelectedSongs.Size = New System.Drawing.Size(126, 21)
        Me.lblSelectedSongs.TabIndex = 3
        Me.lblSelectedSongs.Text = "Songs in Playlist"
        '
        'lstSelectedSongs
        '
        Me.lstSelectedSongs.BackColor = System.Drawing.Color.Black
        Me.lstSelectedSongs.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstSelectedSongs.ForeColor = System.Drawing.Color.Red
        Me.lstSelectedSongs.FormattingEnabled = True
        Me.lstSelectedSongs.ItemHeight = 17
        Me.lstSelectedSongs.Location = New System.Drawing.Point(12, 101)
        Me.lstSelectedSongs.Name = "lstSelectedSongs"
        Me.lstSelectedSongs.Size = New System.Drawing.Size(460, 259)
        Me.lstSelectedSongs.TabIndex = 4
        '
        'frmDJPlayList
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(484, 462)
        Me.Controls.Add(Me.lstSelectedSongs)
        Me.Controls.Add(Me.lblSelectedSongs)
        Me.Controls.Add(Me.cboMusicGenre)
        Me.Controls.Add(Me.lblSelectType)
        Me.Controls.Add(Me.btnShowList)
        Me.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmDJPlayList"
        Me.Text = "DJ Hoster Playlist"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnShowList As System.Windows.Forms.Button
    Friend WithEvents lblSelectType As System.Windows.Forms.Label
    Friend WithEvents cboMusicGenre As System.Windows.Forms.ComboBox
    Friend WithEvents lblSelectedSongs As System.Windows.Forms.Label
    Friend WithEvents lstSelectedSongs As System.Windows.Forms.ListBox

End Class
