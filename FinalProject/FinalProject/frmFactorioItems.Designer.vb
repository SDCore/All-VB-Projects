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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmFactorioItems))
        Dim IDLabel As System.Windows.Forms.Label
        Dim Item_nameLabel As System.Windows.Forms.Label
        Dim Crafting_timeLabel As System.Windows.Forms.Label
        Dim Crafting_typeLabel As System.Windows.Forms.Label
        Dim Amount_givenLabel As System.Windows.Forms.Label
        Dim Base_researchLabel As System.Windows.Forms.Label
        Me._factorio_itemsDataSet = New FinalProject._factorio_itemsDataSet()
        Me.Factorio_itemsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Factorio_itemsTableAdapter = New FinalProject._factorio_itemsDataSetTableAdapters.factorio_itemsTableAdapter()
        Me.TableAdapterManager = New FinalProject._factorio_itemsDataSetTableAdapters.TableAdapterManager()
        Me.Factorio_itemsBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
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
        Me.Factorio_itemsBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.IDTextBox = New System.Windows.Forms.TextBox()
        Me.Item_nameTextBox = New System.Windows.Forms.TextBox()
        Me.Crafting_timeTextBox = New System.Windows.Forms.TextBox()
        Me.Crafting_typeTextBox = New System.Windows.Forms.TextBox()
        Me.Amount_givenTextBox = New System.Windows.Forms.TextBox()
        Me.Base_researchTextBox = New System.Windows.Forms.TextBox()
        IDLabel = New System.Windows.Forms.Label()
        Item_nameLabel = New System.Windows.Forms.Label()
        Crafting_timeLabel = New System.Windows.Forms.Label()
        Crafting_typeLabel = New System.Windows.Forms.Label()
        Amount_givenLabel = New System.Windows.Forms.Label()
        Base_researchLabel = New System.Windows.Forms.Label()
        CType(Me._factorio_itemsDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Factorio_itemsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Factorio_itemsBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Factorio_itemsBindingNavigator.SuspendLayout()
        Me.SuspendLayout()
        '
        '_factorio_itemsDataSet
        '
        Me._factorio_itemsDataSet.DataSetName = "_factorio_itemsDataSet"
        Me._factorio_itemsDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Factorio_itemsBindingSource
        '
        Me.Factorio_itemsBindingSource.DataMember = "factorio-items"
        Me.Factorio_itemsBindingSource.DataSource = Me._factorio_itemsDataSet
        '
        'Factorio_itemsTableAdapter
        '
        Me.Factorio_itemsTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.factorio_itemsTableAdapter = Me.Factorio_itemsTableAdapter
        Me.TableAdapterManager.UpdateOrder = FinalProject._factorio_itemsDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'Factorio_itemsBindingNavigator
        '
        Me.Factorio_itemsBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.Factorio_itemsBindingNavigator.BindingSource = Me.Factorio_itemsBindingSource
        Me.Factorio_itemsBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.Factorio_itemsBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.Factorio_itemsBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.Factorio_itemsBindingNavigatorSaveItem})
        Me.Factorio_itemsBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.Factorio_itemsBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.Factorio_itemsBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.Factorio_itemsBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.Factorio_itemsBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.Factorio_itemsBindingNavigator.Name = "Factorio_itemsBindingNavigator"
        Me.Factorio_itemsBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.Factorio_itemsBindingNavigator.Size = New System.Drawing.Size(620, 25)
        Me.Factorio_itemsBindingNavigator.TabIndex = 0
        Me.Factorio_itemsBindingNavigator.Text = "BindingNavigator1"
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
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(35, 15)
        Me.BindingNavigatorCountItem.Text = "of {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Total number of items"
        '
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 6)
        '
        'BindingNavigatorMoveNextItem
        '
        Me.BindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveNextItem.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveNextItem.Name = "BindingNavigatorMoveNextItem"
        Me.BindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem.Size = New System.Drawing.Size(23, 20)
        Me.BindingNavigatorMoveNextItem.Text = "Move next"
        '
        'BindingNavigatorMoveLastItem
        '
        Me.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem"
        Me.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem.Size = New System.Drawing.Size(23, 20)
        Me.BindingNavigatorMoveLastItem.Text = "Move last"
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 6)
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
        Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(23, 20)
        Me.BindingNavigatorDeleteItem.Text = "Delete"
        '
        'Factorio_itemsBindingNavigatorSaveItem
        '
        Me.Factorio_itemsBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.Factorio_itemsBindingNavigatorSaveItem.Image = CType(resources.GetObject("Factorio_itemsBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.Factorio_itemsBindingNavigatorSaveItem.Name = "Factorio_itemsBindingNavigatorSaveItem"
        Me.Factorio_itemsBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 23)
        Me.Factorio_itemsBindingNavigatorSaveItem.Text = "Save Data"
        '
        'IDLabel
        '
        IDLabel.AutoSize = True
        IDLabel.Location = New System.Drawing.Point(65, 203)
        IDLabel.Name = "IDLabel"
        IDLabel.Size = New System.Drawing.Size(21, 13)
        IDLabel.TabIndex = 1
        IDLabel.Text = "ID:"
        '
        'IDTextBox
        '
        Me.IDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Factorio_itemsBindingSource, "ID", True))
        Me.IDTextBox.Location = New System.Drawing.Point(92, 200)
        Me.IDTextBox.Name = "IDTextBox"
        Me.IDTextBox.Size = New System.Drawing.Size(100, 20)
        Me.IDTextBox.TabIndex = 2
        '
        'Item_nameLabel
        '
        Item_nameLabel.AutoSize = True
        Item_nameLabel.Location = New System.Drawing.Point(66, 244)
        Item_nameLabel.Name = "Item_nameLabel"
        Item_nameLabel.Size = New System.Drawing.Size(58, 13)
        Item_nameLabel.TabIndex = 3
        Item_nameLabel.Text = "item-name:"
        '
        'Item_nameTextBox
        '
        Me.Item_nameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Factorio_itemsBindingSource, "item-name", True))
        Me.Item_nameTextBox.Location = New System.Drawing.Point(130, 241)
        Me.Item_nameTextBox.Name = "Item_nameTextBox"
        Me.Item_nameTextBox.Size = New System.Drawing.Size(100, 20)
        Me.Item_nameTextBox.TabIndex = 4
        '
        'Crafting_timeLabel
        '
        Crafting_timeLabel.AutoSize = True
        Crafting_timeLabel.Location = New System.Drawing.Point(61, 293)
        Crafting_timeLabel.Name = "Crafting_timeLabel"
        Crafting_timeLabel.Size = New System.Drawing.Size(67, 13)
        Crafting_timeLabel.TabIndex = 5
        Crafting_timeLabel.Text = "crafting-time:"
        '
        'Crafting_timeTextBox
        '
        Me.Crafting_timeTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Factorio_itemsBindingSource, "crafting-time", True))
        Me.Crafting_timeTextBox.Location = New System.Drawing.Point(134, 290)
        Me.Crafting_timeTextBox.Name = "Crafting_timeTextBox"
        Me.Crafting_timeTextBox.Size = New System.Drawing.Size(100, 20)
        Me.Crafting_timeTextBox.TabIndex = 6
        '
        'Crafting_typeLabel
        '
        Crafting_typeLabel.AutoSize = True
        Crafting_typeLabel.Location = New System.Drawing.Point(55, 345)
        Crafting_typeLabel.Name = "Crafting_typeLabel"
        Crafting_typeLabel.Size = New System.Drawing.Size(68, 13)
        Crafting_typeLabel.TabIndex = 7
        Crafting_typeLabel.Text = "crafting-type:"
        '
        'Crafting_typeTextBox
        '
        Me.Crafting_typeTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Factorio_itemsBindingSource, "crafting-type", True))
        Me.Crafting_typeTextBox.Location = New System.Drawing.Point(129, 342)
        Me.Crafting_typeTextBox.Name = "Crafting_typeTextBox"
        Me.Crafting_typeTextBox.Size = New System.Drawing.Size(100, 20)
        Me.Crafting_typeTextBox.TabIndex = 8
        '
        'Amount_givenLabel
        '
        Amount_givenLabel.AutoSize = True
        Amount_givenLabel.Location = New System.Drawing.Point(72, 388)
        Amount_givenLabel.Name = "Amount_givenLabel"
        Amount_givenLabel.Size = New System.Drawing.Size(74, 13)
        Amount_givenLabel.TabIndex = 9
        Amount_givenLabel.Text = "amount-given:"
        '
        'Amount_givenTextBox
        '
        Me.Amount_givenTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Factorio_itemsBindingSource, "amount-given", True))
        Me.Amount_givenTextBox.Location = New System.Drawing.Point(152, 385)
        Me.Amount_givenTextBox.Name = "Amount_givenTextBox"
        Me.Amount_givenTextBox.Size = New System.Drawing.Size(100, 20)
        Me.Amount_givenTextBox.TabIndex = 10
        '
        'Base_researchLabel
        '
        Base_researchLabel.AutoSize = True
        Base_researchLabel.Location = New System.Drawing.Point(76, 430)
        Base_researchLabel.Name = "Base_researchLabel"
        Base_researchLabel.Size = New System.Drawing.Size(77, 13)
        Base_researchLabel.TabIndex = 11
        Base_researchLabel.Text = "base-research:"
        '
        'Base_researchTextBox
        '
        Me.Base_researchTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Factorio_itemsBindingSource, "base-research", True))
        Me.Base_researchTextBox.Location = New System.Drawing.Point(159, 427)
        Me.Base_researchTextBox.Name = "Base_researchTextBox"
        Me.Base_researchTextBox.Size = New System.Drawing.Size(100, 20)
        Me.Base_researchTextBox.TabIndex = 12
        '
        'frmFactorioItems
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(620, 486)
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
        Me.Controls.Add(Me.IDTextBox)
        Me.Controls.Add(Me.Factorio_itemsBindingNavigator)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmFactorioItems"
        Me.Text = "Factorio Item Repository"
        CType(Me._factorio_itemsDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Factorio_itemsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Factorio_itemsBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Factorio_itemsBindingNavigator.ResumeLayout(False)
        Me.Factorio_itemsBindingNavigator.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents _factorio_itemsDataSet As FinalProject._factorio_itemsDataSet
    Friend WithEvents Factorio_itemsBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Factorio_itemsTableAdapter As FinalProject._factorio_itemsDataSetTableAdapters.factorio_itemsTableAdapter
    Friend WithEvents TableAdapterManager As FinalProject._factorio_itemsDataSetTableAdapters.TableAdapterManager
    Friend WithEvents Factorio_itemsBindingNavigator As System.Windows.Forms.BindingNavigator
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
    Friend WithEvents Factorio_itemsBindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents IDTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Item_nameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Crafting_timeTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Crafting_typeTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Amount_givenTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Base_researchTextBox As System.Windows.Forms.TextBox

End Class
