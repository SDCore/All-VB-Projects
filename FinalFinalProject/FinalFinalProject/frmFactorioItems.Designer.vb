<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmFactorioItems
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
        Dim IDLabel As System.Windows.Forms.Label
        Dim Item_nameLabel As System.Windows.Forms.Label
        Dim Crafting_timeLabel As System.Windows.Forms.Label
        Dim Crafting_typeLabel As System.Windows.Forms.Label
        Dim Amount_givenLabel As System.Windows.Forms.Label
        Dim Base_researchLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmFactorioItems))
        Me._factorio_itemsDataSet = New FinalFinalProject._factorio_itemsDataSet()
        Me.TblFactorioBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TblFactorioTableAdapter = New FinalFinalProject._factorio_itemsDataSetTableAdapters.tblFactorioTableAdapter()
        Me.TableAdapterManager = New FinalFinalProject._factorio_itemsDataSetTableAdapters.TableAdapterManager()
        Me.TblFactorioBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.TblFactorioBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.IDComboBox = New System.Windows.Forms.ComboBox()
        Me.Item_nameTextBox = New System.Windows.Forms.TextBox()
        Me.Crafting_timeTextBox = New System.Windows.Forms.TextBox()
        Me.Crafting_typeTextBox = New System.Windows.Forms.TextBox()
        Me.Amount_givenTextBox = New System.Windows.Forms.TextBox()
        Me.Base_researchTextBox = New System.Windows.Forms.TextBox()
        Me.btnCalculate = New System.Windows.Forms.Button()
        Me.lblAverageTime = New System.Windows.Forms.Label()
        Me.lblTotalCraftingTime = New System.Windows.Forms.Label()
        Me.lblCraftingType = New System.Windows.Forms.Label()
        IDLabel = New System.Windows.Forms.Label()
        Item_nameLabel = New System.Windows.Forms.Label()
        Crafting_timeLabel = New System.Windows.Forms.Label()
        Crafting_typeLabel = New System.Windows.Forms.Label()
        Amount_givenLabel = New System.Windows.Forms.Label()
        Base_researchLabel = New System.Windows.Forms.Label()
        CType(Me._factorio_itemsDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblFactorioBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblFactorioBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TblFactorioBindingNavigator.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'IDLabel
        '
        IDLabel.AutoSize = True
        IDLabel.Location = New System.Drawing.Point(9, 206)
        IDLabel.Name = "IDLabel"
        IDLabel.Size = New System.Drawing.Size(18, 13)
        IDLabel.TabIndex = 4
        IDLabel.Text = "ID"
        '
        'Item_nameLabel
        '
        Item_nameLabel.AutoSize = True
        Item_nameLabel.Location = New System.Drawing.Point(225, 206)
        Item_nameLabel.Name = "Item_nameLabel"
        Item_nameLabel.Size = New System.Drawing.Size(61, 13)
        Item_nameLabel.TabIndex = 5
        Item_nameLabel.Text = "Item Name"
        '
        'Crafting_timeLabel
        '
        Crafting_timeLabel.AutoSize = True
        Crafting_timeLabel.Location = New System.Drawing.Point(9, 246)
        Crafting_timeLabel.Name = "Crafting_timeLabel"
        Crafting_timeLabel.Size = New System.Drawing.Size(75, 13)
        Crafting_timeLabel.TabIndex = 7
        Crafting_timeLabel.Text = "Crafting Time"
        '
        'Crafting_typeLabel
        '
        Crafting_typeLabel.AutoSize = True
        Crafting_typeLabel.Location = New System.Drawing.Point(9, 285)
        Crafting_typeLabel.Name = "Crafting_typeLabel"
        Crafting_typeLabel.Size = New System.Drawing.Size(75, 13)
        Crafting_typeLabel.TabIndex = 9
        Crafting_typeLabel.Text = "Crafting Type"
        '
        'Amount_givenLabel
        '
        Amount_givenLabel.AutoSize = True
        Amount_givenLabel.Location = New System.Drawing.Point(225, 246)
        Amount_givenLabel.Name = "Amount_givenLabel"
        Amount_givenLabel.Size = New System.Drawing.Size(80, 13)
        Amount_givenLabel.TabIndex = 11
        Amount_givenLabel.Text = "Amount Given"
        '
        'Base_researchLabel
        '
        Base_researchLabel.AutoSize = True
        Base_researchLabel.Location = New System.Drawing.Point(225, 285)
        Base_researchLabel.Name = "Base_researchLabel"
        Base_researchLabel.Size = New System.Drawing.Size(80, 13)
        Base_researchLabel.TabIndex = 13
        Base_researchLabel.Text = "Base Research"
        '
        '_factorio_itemsDataSet
        '
        Me._factorio_itemsDataSet.DataSetName = "_factorio_itemsDataSet"
        Me._factorio_itemsDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TblFactorioBindingSource
        '
        Me.TblFactorioBindingSource.DataMember = "tblFactorio"
        Me.TblFactorioBindingSource.DataSource = Me._factorio_itemsDataSet
        '
        'TblFactorioTableAdapter
        '
        Me.TblFactorioTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.tblFactorioTableAdapter = Me.TblFactorioTableAdapter
        Me.TableAdapterManager.UpdateOrder = FinalFinalProject._factorio_itemsDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'TblFactorioBindingNavigator
        '
        Me.TblFactorioBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.TblFactorioBindingNavigator.BindingSource = Me.TblFactorioBindingSource
        Me.TblFactorioBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.TblFactorioBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.TblFactorioBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.TblFactorioBindingNavigatorSaveItem})
        Me.TblFactorioBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.TblFactorioBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.TblFactorioBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.TblFactorioBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.TblFactorioBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.TblFactorioBindingNavigator.Name = "TblFactorioBindingNavigator"
        Me.TblFactorioBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.TblFactorioBindingNavigator.Size = New System.Drawing.Size(463, 25)
        Me.TblFactorioBindingNavigator.TabIndex = 0
        Me.TblFactorioBindingNavigator.Text = "BindingNavigator1"
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
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(35, 22)
        Me.BindingNavigatorCountItem.Text = "of {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Total number of items"
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
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator1"
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
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator2"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'TblFactorioBindingNavigatorSaveItem
        '
        Me.TblFactorioBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.TblFactorioBindingNavigatorSaveItem.Image = CType(resources.GetObject("TblFactorioBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.TblFactorioBindingNavigatorSaveItem.Name = "TblFactorioBindingNavigatorSaveItem"
        Me.TblFactorioBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.TblFactorioBindingNavigatorSaveItem.Text = "Save Data"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(12, 28)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(431, 113)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 3
        Me.PictureBox1.TabStop = False
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.Font = New System.Drawing.Font("Segoe UI", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle.Location = New System.Drawing.Point(12, 144)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(199, 37)
        Me.lblTitle.TabIndex = 4
        Me.lblTitle.Text = "Item Manager"
        '
        'IDComboBox
        '
        Me.IDComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblFactorioBindingSource, "ID", True))
        Me.IDComboBox.FormattingEnabled = True
        Me.IDComboBox.Location = New System.Drawing.Point(12, 222)
        Me.IDComboBox.Name = "IDComboBox"
        Me.IDComboBox.Size = New System.Drawing.Size(210, 21)
        Me.IDComboBox.TabIndex = 5
        '
        'Item_nameTextBox
        '
        Me.Item_nameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblFactorioBindingSource, "item-name", True))
        Me.Item_nameTextBox.Location = New System.Drawing.Point(228, 222)
        Me.Item_nameTextBox.Name = "Item_nameTextBox"
        Me.Item_nameTextBox.Size = New System.Drawing.Size(215, 22)
        Me.Item_nameTextBox.TabIndex = 6
        '
        'Crafting_timeTextBox
        '
        Me.Crafting_timeTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblFactorioBindingSource, "crafting-time", True))
        Me.Crafting_timeTextBox.Location = New System.Drawing.Point(12, 262)
        Me.Crafting_timeTextBox.Name = "Crafting_timeTextBox"
        Me.Crafting_timeTextBox.Size = New System.Drawing.Size(210, 22)
        Me.Crafting_timeTextBox.TabIndex = 8
        '
        'Crafting_typeTextBox
        '
        Me.Crafting_typeTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblFactorioBindingSource, "crafting-type", True))
        Me.Crafting_typeTextBox.Location = New System.Drawing.Point(12, 301)
        Me.Crafting_typeTextBox.Name = "Crafting_typeTextBox"
        Me.Crafting_typeTextBox.Size = New System.Drawing.Size(210, 22)
        Me.Crafting_typeTextBox.TabIndex = 10
        '
        'Amount_givenTextBox
        '
        Me.Amount_givenTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblFactorioBindingSource, "amount-given", True))
        Me.Amount_givenTextBox.Location = New System.Drawing.Point(228, 262)
        Me.Amount_givenTextBox.Name = "Amount_givenTextBox"
        Me.Amount_givenTextBox.Size = New System.Drawing.Size(215, 22)
        Me.Amount_givenTextBox.TabIndex = 12
        '
        'Base_researchTextBox
        '
        Me.Base_researchTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblFactorioBindingSource, "base-research", True))
        Me.Base_researchTextBox.Location = New System.Drawing.Point(228, 301)
        Me.Base_researchTextBox.Name = "Base_researchTextBox"
        Me.Base_researchTextBox.Size = New System.Drawing.Size(215, 22)
        Me.Base_researchTextBox.TabIndex = 14
        '
        'btnCalculate
        '
        Me.btnCalculate.Font = New System.Drawing.Font("Segoe UI", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCalculate.Location = New System.Drawing.Point(12, 330)
        Me.btnCalculate.Name = "btnCalculate"
        Me.btnCalculate.Size = New System.Drawing.Size(431, 54)
        Me.btnCalculate.TabIndex = 15
        Me.btnCalculate.Text = "Calculate"
        Me.btnCalculate.UseVisualStyleBackColor = True
        '
        'lblAverageTime
        '
        Me.lblAverageTime.AutoSize = True
        Me.lblAverageTime.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAverageTime.Location = New System.Drawing.Point(128, 387)
        Me.lblAverageTime.Name = "lblAverageTime"
        Me.lblAverageTime.Size = New System.Drawing.Size(190, 21)
        Me.lblAverageTime.TabIndex = 16
        Me.lblAverageTime.Text = "Average Crafting Time: 00"
        '
        'lblTotalCraftingTime
        '
        Me.lblTotalCraftingTime.AutoSize = True
        Me.lblTotalCraftingTime.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalCraftingTime.Location = New System.Drawing.Point(140, 408)
        Me.lblTotalCraftingTime.Name = "lblTotalCraftingTime"
        Me.lblTotalCraftingTime.Size = New System.Drawing.Size(167, 21)
        Me.lblTotalCraftingTime.TabIndex = 17
        Me.lblTotalCraftingTime.Text = "Total Crafting Time: 00"
        '
        'lblCraftingType
        '
        Me.lblCraftingType.AutoSize = True
        Me.lblCraftingType.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCraftingType.Location = New System.Drawing.Point(135, 429)
        Me.lblCraftingType.Name = "lblCraftingType"
        Me.lblCraftingType.Size = New System.Drawing.Size(185, 21)
        Me.lblCraftingType.TabIndex = 18
        Me.lblCraftingType.Text = "Crafted In: TYPEOFCRAFT"
        '
        'frmFactorioItems
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(463, 457)
        Me.Controls.Add(Me.lblCraftingType)
        Me.Controls.Add(Me.lblTotalCraftingTime)
        Me.Controls.Add(Me.lblAverageTime)
        Me.Controls.Add(Me.btnCalculate)
        Me.Controls.Add(Base_researchLabel)
        Me.Controls.Add(Me.Base_researchTextBox)
        Me.Controls.Add(Amount_givenLabel)
        Me.Controls.Add(Me.Amount_givenTextBox)
        Me.Controls.Add(Crafting_typeLabel)
        Me.Controls.Add(Me.Crafting_typeTextBox)
        Me.Controls.Add(Crafting_timeLabel)
        Me.Controls.Add(Me.Crafting_timeTextBox)
        Me.Controls.Add(Item_nameLabel)
        Me.Controls.Add(Me.Item_nameTextBox)
        Me.Controls.Add(IDLabel)
        Me.Controls.Add(Me.IDComboBox)
        Me.Controls.Add(Me.lblTitle)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.TblFactorioBindingNavigator)
        Me.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "frmFactorioItems"
        Me.Text = "Factorio Item Manager"
        CType(Me._factorio_itemsDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblFactorioBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblFactorioBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TblFactorioBindingNavigator.ResumeLayout(False)
        Me.TblFactorioBindingNavigator.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents _factorio_itemsDataSet As FinalFinalProject._factorio_itemsDataSet
    Friend WithEvents TblFactorioBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents TblFactorioTableAdapter As FinalFinalProject._factorio_itemsDataSetTableAdapters.tblFactorioTableAdapter
    Friend WithEvents TableAdapterManager As FinalFinalProject._factorio_itemsDataSetTableAdapters.TableAdapterManager
    Friend WithEvents TblFactorioBindingNavigator As System.Windows.Forms.BindingNavigator
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
    Friend WithEvents TblFactorioBindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents lblTitle As System.Windows.Forms.Label
    Friend WithEvents IDComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents Item_nameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Crafting_timeTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Crafting_typeTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Amount_givenTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Base_researchTextBox As System.Windows.Forms.TextBox
    Friend WithEvents btnCalculate As System.Windows.Forms.Button
    Friend WithEvents lblAverageTime As System.Windows.Forms.Label
    Friend WithEvents lblTotalCraftingTime As System.Windows.Forms.Label
    Friend WithEvents lblCraftingType As System.Windows.Forms.Label

End Class
