<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmFoodInventory
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
        Dim Product_NumberLabel As System.Windows.Forms.Label
        Dim Name__English_Label As System.Windows.Forms.Label
        Dim Name__Spanish_Label As System.Windows.Forms.Label
        Dim QuantityLabel As System.Windows.Forms.Label
        Dim Cost_per_ItemLabel As System.Windows.Forms.Label
        Dim DepartmentLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmFoodInventory))
        Me.SpanishfoodDataSet = New SpanishFoodStore.spanishfoodDataSet()
        Me.StoreInventoryBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.StoreInventoryTableAdapter = New SpanishFoodStore.spanishfoodDataSetTableAdapters.StoreInventoryTableAdapter()
        Me.TableAdapterManager = New SpanishFoodStore.spanishfoodDataSetTableAdapters.TableAdapterManager()
        Me.StoreInventoryBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
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
        Me.StoreInventoryBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.Product_NumberTextBox = New System.Windows.Forms.TextBox()
        Me.Name__English_TextBox = New System.Windows.Forms.TextBox()
        Me.Name__Spanish_TextBox = New System.Windows.Forms.TextBox()
        Me.QuantityTextBox = New System.Windows.Forms.TextBox()
        Me.Cost_per_ItemTextBox = New System.Windows.Forms.TextBox()
        Me.DepartmentTextBox = New System.Windows.Forms.TextBox()
        Me.pboPeppers = New System.Windows.Forms.PictureBox()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.btnTotalInventory = New System.Windows.Forms.Button()
        Me.lblTotalValue = New System.Windows.Forms.Label()
        Product_NumberLabel = New System.Windows.Forms.Label()
        Name__English_Label = New System.Windows.Forms.Label()
        Name__Spanish_Label = New System.Windows.Forms.Label()
        QuantityLabel = New System.Windows.Forms.Label()
        Cost_per_ItemLabel = New System.Windows.Forms.Label()
        DepartmentLabel = New System.Windows.Forms.Label()
        CType(Me.SpanishfoodDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StoreInventoryBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StoreInventoryBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.StoreInventoryBindingNavigator.SuspendLayout()
        CType(Me.pboPeppers, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Product_NumberLabel
        '
        Product_NumberLabel.AutoSize = True
        Product_NumberLabel.Location = New System.Drawing.Point(12, 135)
        Product_NumberLabel.Name = "Product_NumberLabel"
        Product_NumberLabel.Size = New System.Drawing.Size(91, 13)
        Product_NumberLabel.TabIndex = 1
        Product_NumberLabel.Text = "Product Number"
        '
        'Name__English_Label
        '
        Name__English_Label.AutoSize = True
        Name__English_Label.Location = New System.Drawing.Point(238, 135)
        Name__English_Label.Name = "Name__English_Label"
        Name__English_Label.Size = New System.Drawing.Size(83, 13)
        Name__English_Label.TabIndex = 3
        Name__English_Label.Text = "Name (English)"
        '
        'Name__Spanish_Label
        '
        Name__Spanish_Label.AutoSize = True
        Name__Spanish_Label.Location = New System.Drawing.Point(12, 176)
        Name__Spanish_Label.Name = "Name__Spanish_Label"
        Name__Spanish_Label.Size = New System.Drawing.Size(86, 13)
        Name__Spanish_Label.TabIndex = 5
        Name__Spanish_Label.Text = "Name (Spanish)"
        '
        'QuantityLabel
        '
        QuantityLabel.AutoSize = True
        QuantityLabel.Location = New System.Drawing.Point(235, 176)
        QuantityLabel.Name = "QuantityLabel"
        QuantityLabel.Size = New System.Drawing.Size(52, 13)
        QuantityLabel.TabIndex = 7
        QuantityLabel.Text = "Quantity"
        '
        'Cost_per_ItemLabel
        '
        Cost_per_ItemLabel.AutoSize = True
        Cost_per_ItemLabel.Location = New System.Drawing.Point(12, 217)
        Cost_per_ItemLabel.Name = "Cost_per_ItemLabel"
        Cost_per_ItemLabel.Size = New System.Drawing.Size(75, 13)
        Cost_per_ItemLabel.TabIndex = 9
        Cost_per_ItemLabel.Text = "Cost per Item"
        '
        'DepartmentLabel
        '
        DepartmentLabel.AutoSize = True
        DepartmentLabel.Location = New System.Drawing.Point(238, 217)
        DepartmentLabel.Name = "DepartmentLabel"
        DepartmentLabel.Size = New System.Drawing.Size(68, 13)
        DepartmentLabel.TabIndex = 11
        DepartmentLabel.Text = "Department"
        '
        'SpanishfoodDataSet
        '
        Me.SpanishfoodDataSet.DataSetName = "spanishfoodDataSet"
        Me.SpanishfoodDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'StoreInventoryBindingSource
        '
        Me.StoreInventoryBindingSource.DataMember = "StoreInventory"
        Me.StoreInventoryBindingSource.DataSource = Me.SpanishfoodDataSet
        '
        'StoreInventoryTableAdapter
        '
        Me.StoreInventoryTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.StoreInventoryTableAdapter = Me.StoreInventoryTableAdapter
        Me.TableAdapterManager.UpdateOrder = SpanishFoodStore.spanishfoodDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'StoreInventoryBindingNavigator
        '
        Me.StoreInventoryBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.StoreInventoryBindingNavigator.BindingSource = Me.StoreInventoryBindingSource
        Me.StoreInventoryBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.StoreInventoryBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.StoreInventoryBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.StoreInventoryBindingNavigatorSaveItem})
        Me.StoreInventoryBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.StoreInventoryBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.StoreInventoryBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.StoreInventoryBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.StoreInventoryBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.StoreInventoryBindingNavigator.Name = "StoreInventoryBindingNavigator"
        Me.StoreInventoryBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.StoreInventoryBindingNavigator.Size = New System.Drawing.Size(498, 25)
        Me.StoreInventoryBindingNavigator.TabIndex = 0
        Me.StoreInventoryBindingNavigator.Text = "BindingNavigator1"
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
        'StoreInventoryBindingNavigatorSaveItem
        '
        Me.StoreInventoryBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.StoreInventoryBindingNavigatorSaveItem.Image = CType(resources.GetObject("StoreInventoryBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.StoreInventoryBindingNavigatorSaveItem.Name = "StoreInventoryBindingNavigatorSaveItem"
        Me.StoreInventoryBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.StoreInventoryBindingNavigatorSaveItem.Text = "Save Data"
        '
        'Product_NumberTextBox
        '
        Me.Product_NumberTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.StoreInventoryBindingSource, "Product Number", True))
        Me.Product_NumberTextBox.Location = New System.Drawing.Point(15, 151)
        Me.Product_NumberTextBox.Name = "Product_NumberTextBox"
        Me.Product_NumberTextBox.Size = New System.Drawing.Size(217, 22)
        Me.Product_NumberTextBox.TabIndex = 2
        '
        'Name__English_TextBox
        '
        Me.Name__English_TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.StoreInventoryBindingSource, "Name (English)", True))
        Me.Name__English_TextBox.Location = New System.Drawing.Point(238, 151)
        Me.Name__English_TextBox.Name = "Name__English_TextBox"
        Me.Name__English_TextBox.Size = New System.Drawing.Size(248, 22)
        Me.Name__English_TextBox.TabIndex = 4
        '
        'Name__Spanish_TextBox
        '
        Me.Name__Spanish_TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.StoreInventoryBindingSource, "Name (Spanish)", True))
        Me.Name__Spanish_TextBox.Location = New System.Drawing.Point(15, 192)
        Me.Name__Spanish_TextBox.Name = "Name__Spanish_TextBox"
        Me.Name__Spanish_TextBox.Size = New System.Drawing.Size(217, 22)
        Me.Name__Spanish_TextBox.TabIndex = 6
        '
        'QuantityTextBox
        '
        Me.QuantityTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.StoreInventoryBindingSource, "Quantity", True))
        Me.QuantityTextBox.Location = New System.Drawing.Point(238, 192)
        Me.QuantityTextBox.Name = "QuantityTextBox"
        Me.QuantityTextBox.Size = New System.Drawing.Size(248, 22)
        Me.QuantityTextBox.TabIndex = 8
        '
        'Cost_per_ItemTextBox
        '
        Me.Cost_per_ItemTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.StoreInventoryBindingSource, "Cost per Item", True))
        Me.Cost_per_ItemTextBox.Location = New System.Drawing.Point(15, 233)
        Me.Cost_per_ItemTextBox.Name = "Cost_per_ItemTextBox"
        Me.Cost_per_ItemTextBox.Size = New System.Drawing.Size(217, 22)
        Me.Cost_per_ItemTextBox.TabIndex = 10
        '
        'DepartmentTextBox
        '
        Me.DepartmentTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.StoreInventoryBindingSource, "Department", True))
        Me.DepartmentTextBox.Location = New System.Drawing.Point(238, 233)
        Me.DepartmentTextBox.Name = "DepartmentTextBox"
        Me.DepartmentTextBox.Size = New System.Drawing.Size(248, 22)
        Me.DepartmentTextBox.TabIndex = 12
        '
        'pboPeppers
        '
        Me.pboPeppers.Image = CType(resources.GetObject("pboPeppers.Image"), System.Drawing.Image)
        Me.pboPeppers.Location = New System.Drawing.Point(72, 28)
        Me.pboPeppers.Name = "pboPeppers"
        Me.pboPeppers.Size = New System.Drawing.Size(100, 93)
        Me.pboPeppers.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pboPeppers.TabIndex = 13
        Me.pboPeppers.TabStop = False
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.Font = New System.Drawing.Font("Segoe UI", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle.Location = New System.Drawing.Point(178, 45)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(271, 50)
        Me.lblTitle.TabIndex = 14
        Me.lblTitle.Text = "Food Inventory"
        '
        'btnTotalInventory
        '
        Me.btnTotalInventory.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnTotalInventory.Location = New System.Drawing.Point(15, 262)
        Me.btnTotalInventory.Name = "btnTotalInventory"
        Me.btnTotalInventory.Size = New System.Drawing.Size(471, 54)
        Me.btnTotalInventory.TabIndex = 15
        Me.btnTotalInventory.Text = "Compute Total Value of Inventory"
        Me.btnTotalInventory.UseVisualStyleBackColor = True
        '
        'lblTotalValue
        '
        Me.lblTotalValue.AutoSize = True
        Me.lblTotalValue.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalValue.Location = New System.Drawing.Point(151, 319)
        Me.lblTotalValue.Name = "lblTotalValue"
        Me.lblTotalValue.Size = New System.Drawing.Size(170, 25)
        Me.lblTotalValue.TabIndex = 16
        Me.lblTotalValue.Text = "Total Value: $00.00"
        '
        'frmFoodInventory
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(498, 354)
        Me.Controls.Add(Me.lblTotalValue)
        Me.Controls.Add(Me.btnTotalInventory)
        Me.Controls.Add(Me.lblTitle)
        Me.Controls.Add(Me.pboPeppers)
        Me.Controls.Add(DepartmentLabel)
        Me.Controls.Add(Me.DepartmentTextBox)
        Me.Controls.Add(Cost_per_ItemLabel)
        Me.Controls.Add(Me.Cost_per_ItemTextBox)
        Me.Controls.Add(QuantityLabel)
        Me.Controls.Add(Me.QuantityTextBox)
        Me.Controls.Add(Name__Spanish_Label)
        Me.Controls.Add(Me.Name__Spanish_TextBox)
        Me.Controls.Add(Name__English_Label)
        Me.Controls.Add(Me.Name__English_TextBox)
        Me.Controls.Add(Product_NumberLabel)
        Me.Controls.Add(Me.Product_NumberTextBox)
        Me.Controls.Add(Me.StoreInventoryBindingNavigator)
        Me.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "frmFoodInventory"
        Me.Text = "Spanish Food Store"
        CType(Me.SpanishfoodDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StoreInventoryBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StoreInventoryBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.StoreInventoryBindingNavigator.ResumeLayout(False)
        Me.StoreInventoryBindingNavigator.PerformLayout()
        CType(Me.pboPeppers, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents SpanishfoodDataSet As SpanishFoodStore.spanishfoodDataSet
    Friend WithEvents StoreInventoryBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents StoreInventoryTableAdapter As SpanishFoodStore.spanishfoodDataSetTableAdapters.StoreInventoryTableAdapter
    Friend WithEvents TableAdapterManager As SpanishFoodStore.spanishfoodDataSetTableAdapters.TableAdapterManager
    Friend WithEvents StoreInventoryBindingNavigator As System.Windows.Forms.BindingNavigator
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
    Friend WithEvents StoreInventoryBindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents Product_NumberTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Name__English_TextBox As System.Windows.Forms.TextBox
    Friend WithEvents Name__Spanish_TextBox As System.Windows.Forms.TextBox
    Friend WithEvents QuantityTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Cost_per_ItemTextBox As System.Windows.Forms.TextBox
    Friend WithEvents DepartmentTextBox As System.Windows.Forms.TextBox
    Friend WithEvents pboPeppers As System.Windows.Forms.PictureBox
    Friend WithEvents lblTitle As System.Windows.Forms.Label
    Friend WithEvents btnTotalInventory As System.Windows.Forms.Button
    Friend WithEvents lblTotalValue As System.Windows.Forms.Label

End Class
