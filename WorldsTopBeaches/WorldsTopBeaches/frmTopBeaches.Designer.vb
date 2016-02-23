<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmTopBeaches
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmTopBeaches))
        Dim RatingLabel As System.Windows.Forms.Label
        Dim Beach_CityLabel As System.Windows.Forms.Label
        Dim CountryLabel As System.Windows.Forms.Label
        Dim Beach_NameLabel As System.Windows.Forms.Label
        Me.TopBeachesDataSet = New WorldsTopBeaches.TopBeachesDataSet()
        Me.TopbeachesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TopbeachesTableAdapter = New WorldsTopBeaches.TopBeachesDataSetTableAdapters.topbeachesTableAdapter()
        Me.TableAdapterManager = New WorldsTopBeaches.TopBeachesDataSetTableAdapters.TableAdapterManager()
        Me.TopbeachesBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton()
        Me.TopbeachesBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.RatingTextBox = New System.Windows.Forms.TextBox()
        Me.Beach_CityTextBox = New System.Windows.Forms.TextBox()
        Me.CountryTextBox = New System.Windows.Forms.TextBox()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.Beach_NameComboBox = New System.Windows.Forms.ComboBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        RatingLabel = New System.Windows.Forms.Label()
        Beach_CityLabel = New System.Windows.Forms.Label()
        CountryLabel = New System.Windows.Forms.Label()
        Beach_NameLabel = New System.Windows.Forms.Label()
        CType(Me.TopBeachesDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TopbeachesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TopbeachesBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TopbeachesBindingNavigator.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TopBeachesDataSet
        '
        Me.TopBeachesDataSet.DataSetName = "TopBeachesDataSet"
        Me.TopBeachesDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TopbeachesBindingSource
        '
        Me.TopbeachesBindingSource.DataMember = "topbeaches"
        Me.TopbeachesBindingSource.DataSource = Me.TopBeachesDataSet
        '
        'TopbeachesTableAdapter
        '
        Me.TopbeachesTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.topbeachesTableAdapter = Me.TopbeachesTableAdapter
        Me.TableAdapterManager.UpdateOrder = WorldsTopBeaches.TopBeachesDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'TopbeachesBindingNavigator
        '
        Me.TopbeachesBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.TopbeachesBindingNavigator.BindingSource = Me.TopbeachesBindingSource
        Me.TopbeachesBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.TopbeachesBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.TopbeachesBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.TopbeachesBindingNavigatorSaveItem})
        Me.TopbeachesBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.TopbeachesBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.TopbeachesBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.TopbeachesBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.TopbeachesBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.TopbeachesBindingNavigator.Name = "TopbeachesBindingNavigator"
        Me.TopbeachesBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.TopbeachesBindingNavigator.Size = New System.Drawing.Size(584, 25)
        Me.TopbeachesBindingNavigator.TabIndex = 0
        Me.TopbeachesBindingNavigator.Text = "BindingNavigator1"
        '
        'BindingNavigatorMoveFirstItem
        '
        Me.BindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveFirstItem.Image = CType(resources.GetObject("BindingNavigatorMoveFirstItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveFirstItem.Name = "BindingNavigatorMoveFirstItem"
        Me.BindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveFirstItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveFirstItem.Text = "Move first"
        '
        'BindingNavigatorMovePreviousItem
        '
        Me.BindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMovePreviousItem.Image = CType(resources.GetObject("BindingNavigatorMovePreviousItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMovePreviousItem.Name = "BindingNavigatorMovePreviousItem"
        Me.BindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMovePreviousItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMovePreviousItem.Text = "Move previous"
        '
        'BindingNavigatorSeparator
        '
        Me.BindingNavigatorSeparator.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorPositionItem
        '
        Me.BindingNavigatorPositionItem.AccessibleName = "Position"
        Me.BindingNavigatorPositionItem.AutoSize = False
        Me.BindingNavigatorPositionItem.Name = "BindingNavigatorPositionItem"
        Me.BindingNavigatorPositionItem.Size = New System.Drawing.Size(50, 23)
        Me.BindingNavigatorPositionItem.Text = "0"
        Me.BindingNavigatorPositionItem.ToolTipText = "Current position"
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(35, 22)
        Me.BindingNavigatorCountItem.Text = "of {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Total number of items"
        '
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorMoveNextItem
        '
        Me.BindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveNextItem.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveNextItem.Name = "BindingNavigatorMoveNextItem"
        Me.BindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveNextItem.Text = "Move next"
        '
        'BindingNavigatorMoveLastItem
        '
        Me.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem"
        Me.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveLastItem.Text = "Move last"
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorAddNewItem
        '
        Me.BindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorAddNewItem.Image = CType(resources.GetObject("BindingNavigatorAddNewItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorAddNewItem.Name = "BindingNavigatorAddNewItem"
        Me.BindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorAddNewItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorAddNewItem.Text = "Add new"
        '
        'BindingNavigatorDeleteItem
        '
        Me.BindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorDeleteItem.Image = CType(resources.GetObject("BindingNavigatorDeleteItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorDeleteItem.Name = "BindingNavigatorDeleteItem"
        Me.BindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorDeleteItem.Text = "Delete"
        '
        'TopbeachesBindingNavigatorSaveItem
        '
        Me.TopbeachesBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.TopbeachesBindingNavigatorSaveItem.Image = CType(resources.GetObject("TopbeachesBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.TopbeachesBindingNavigatorSaveItem.Name = "TopbeachesBindingNavigatorSaveItem"
        Me.TopbeachesBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.TopbeachesBindingNavigatorSaveItem.Text = "Save Data"
        '
        'RatingLabel
        '
        RatingLabel.AutoSize = True
        RatingLabel.Location = New System.Drawing.Point(12, 74)
        RatingLabel.Name = "RatingLabel"
        RatingLabel.Size = New System.Drawing.Size(44, 13)
        RatingLabel.TabIndex = 1
        RatingLabel.Text = "Rating:"
        '
        'RatingTextBox
        '
        Me.RatingTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TopbeachesBindingSource, "Rating", True))
        Me.RatingTextBox.Location = New System.Drawing.Point(15, 90)
        Me.RatingTextBox.Name = "RatingTextBox"
        Me.RatingTextBox.Size = New System.Drawing.Size(256, 22)
        Me.RatingTextBox.TabIndex = 2
        '
        'Beach_CityLabel
        '
        Beach_CityLabel.AutoSize = True
        Beach_CityLabel.Location = New System.Drawing.Point(279, 115)
        Beach_CityLabel.Name = "Beach_CityLabel"
        Beach_CityLabel.Size = New System.Drawing.Size(63, 13)
        Beach_CityLabel.TabIndex = 5
        Beach_CityLabel.Text = "Beach City:"
        '
        'Beach_CityTextBox
        '
        Me.Beach_CityTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TopbeachesBindingSource, "Beach City", True))
        Me.Beach_CityTextBox.Location = New System.Drawing.Point(282, 131)
        Me.Beach_CityTextBox.Name = "Beach_CityTextBox"
        Me.Beach_CityTextBox.Size = New System.Drawing.Size(290, 22)
        Me.Beach_CityTextBox.TabIndex = 6
        '
        'CountryLabel
        '
        CountryLabel.AutoSize = True
        CountryLabel.Location = New System.Drawing.Point(279, 74)
        CountryLabel.Name = "CountryLabel"
        CountryLabel.Size = New System.Drawing.Size(51, 13)
        CountryLabel.TabIndex = 7
        CountryLabel.Text = "Country:"
        '
        'CountryTextBox
        '
        Me.CountryTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TopbeachesBindingSource, "Country", True))
        Me.CountryTextBox.Location = New System.Drawing.Point(282, 90)
        Me.CountryTextBox.Name = "CountryTextBox"
        Me.CountryTextBox.Size = New System.Drawing.Size(290, 22)
        Me.CountryTextBox.TabIndex = 8
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.Font = New System.Drawing.Font("Segoe UI", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle.Location = New System.Drawing.Point(126, 25)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(321, 37)
        Me.lblTitle.TabIndex = 9
        Me.lblTitle.Text = "Top Beaches of the World"
        '
        'Beach_NameLabel
        '
        Beach_NameLabel.AutoSize = True
        Beach_NameLabel.Location = New System.Drawing.Point(12, 115)
        Beach_NameLabel.Name = "Beach_NameLabel"
        Beach_NameLabel.Size = New System.Drawing.Size(73, 13)
        Beach_NameLabel.TabIndex = 9
        Beach_NameLabel.Text = "Beach Name:"
        '
        'Beach_NameComboBox
        '
        Me.Beach_NameComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TopbeachesBindingSource, "Beach Name", True))
        Me.Beach_NameComboBox.FormattingEnabled = True
        Me.Beach_NameComboBox.Location = New System.Drawing.Point(15, 131)
        Me.Beach_NameComboBox.Name = "Beach_NameComboBox"
        Me.Beach_NameComboBox.Size = New System.Drawing.Size(256, 21)
        Me.Beach_NameComboBox.TabIndex = 10
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(-46, 159)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(764, 155)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 11
        Me.PictureBox1.TabStop = False
        '
        'frmTopBeaches
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(584, 297)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Beach_NameLabel)
        Me.Controls.Add(Me.Beach_NameComboBox)
        Me.Controls.Add(Me.lblTitle)
        Me.Controls.Add(CountryLabel)
        Me.Controls.Add(Me.CountryTextBox)
        Me.Controls.Add(Beach_CityLabel)
        Me.Controls.Add(Me.Beach_CityTextBox)
        Me.Controls.Add(RatingLabel)
        Me.Controls.Add(Me.RatingTextBox)
        Me.Controls.Add(Me.TopbeachesBindingNavigator)
        Me.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmTopBeaches"
        Me.Text = "Top Beaches of the World"
        CType(Me.TopBeachesDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TopbeachesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TopbeachesBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TopbeachesBindingNavigator.ResumeLayout(False)
        Me.TopbeachesBindingNavigator.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TopBeachesDataSet As WorldsTopBeaches.TopBeachesDataSet
    Friend WithEvents TopbeachesBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents TopbeachesTableAdapter As WorldsTopBeaches.TopBeachesDataSetTableAdapters.topbeachesTableAdapter
    Friend WithEvents TableAdapterManager As WorldsTopBeaches.TopBeachesDataSetTableAdapters.TableAdapterManager
    Friend WithEvents TopbeachesBindingNavigator As System.Windows.Forms.BindingNavigator
    Friend WithEvents BindingNavigatorAddNewItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorCountItem As System.Windows.Forms.ToolStripLabel
    Friend WithEvents BindingNavigatorDeleteItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMoveFirstItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents TopbeachesBindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents RatingTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Beach_CityTextBox As System.Windows.Forms.TextBox
    Friend WithEvents CountryTextBox As System.Windows.Forms.TextBox
    Friend WithEvents lblTitle As System.Windows.Forms.Label
    Friend WithEvents Beach_NameComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox

End Class
