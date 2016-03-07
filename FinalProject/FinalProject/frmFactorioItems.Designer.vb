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
        Me._factorio_itemsDataSet = New FinalProject._factorio_itemsDataSet()
        Me.Factorio_itemsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Factorio_itemsTableAdapter = New FinalProject._factorio_itemsDataSetTableAdapters.tblFactorioTableAdapter()
        Me.TableAdapterManager = New FinalProject._factorio_itemsDataSetTableAdapters.TableAdapterManager()
        Me.Factorio_itemsBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
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
        Me.Factorio_itemsBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.pboLogo = New System.Windows.Forms.PictureBox()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.lblTotalCraftingTime = New System.Windows.Forms.Label()
        Me.lblAverageCraftingTime = New System.Windows.Forms.Label()
        Me.btnCalculate = New System.Windows.Forms.Button()
        Me.lblCraftingType = New System.Windows.Forms.Label()
        CType(Me._factorio_itemsDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Factorio_itemsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Factorio_itemsBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Factorio_itemsBindingNavigator.SuspendLayout()
        CType(Me.pboLogo, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.TableAdapterManager.tblFactorioTableAdapter = Me.Factorio_itemsTableAdapter
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
        Me.Factorio_itemsBindingNavigator.Size = New System.Drawing.Size(478, 25)
        Me.Factorio_itemsBindingNavigator.TabIndex = 0
        Me.Factorio_itemsBindingNavigator.Text = "BindingNavigator1"
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
        'Factorio_itemsBindingNavigatorSaveItem
        '
        Me.Factorio_itemsBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.Factorio_itemsBindingNavigatorSaveItem.Image = CType(resources.GetObject("Factorio_itemsBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.Factorio_itemsBindingNavigatorSaveItem.Name = "Factorio_itemsBindingNavigatorSaveItem"
        Me.Factorio_itemsBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.Factorio_itemsBindingNavigatorSaveItem.Text = "Save Data"
        '
        'pboLogo
        '
        Me.pboLogo.Image = CType(resources.GetObject("pboLogo.Image"), System.Drawing.Image)
        Me.pboLogo.Location = New System.Drawing.Point(12, 28)
        Me.pboLogo.Name = "pboLogo"
        Me.pboLogo.Size = New System.Drawing.Size(446, 93)
        Me.pboLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.pboLogo.TabIndex = 13
        Me.pboLogo.TabStop = False
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.Font = New System.Drawing.Font("Segoe UI", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(202, Byte), Integer), CType(CType(117, Byte), Integer), CType(CType(39, Byte), Integer))
        Me.lblTitle.Location = New System.Drawing.Point(93, 124)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(282, 50)
        Me.lblTitle.TabIndex = 14
        Me.lblTitle.Text = "Item Repository"
        '
        'lblTotalCraftingTime
        '
        Me.lblTotalCraftingTime.AutoSize = True
        Me.lblTotalCraftingTime.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalCraftingTime.Location = New System.Drawing.Point(114, 317)
        Me.lblTotalCraftingTime.Name = "lblTotalCraftingTime"
        Me.lblTotalCraftingTime.Size = New System.Drawing.Size(238, 21)
        Me.lblTotalCraftingTime.TabIndex = 15
        Me.lblTotalCraftingTime.Text = "Total Crafting Time: 000 Seconds"
        '
        'lblAverageCraftingTime
        '
        Me.lblAverageCraftingTime.AutoSize = True
        Me.lblAverageCraftingTime.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAverageCraftingTime.Location = New System.Drawing.Point(98, 342)
        Me.lblAverageCraftingTime.Name = "lblAverageCraftingTime"
        Me.lblAverageCraftingTime.Size = New System.Drawing.Size(261, 21)
        Me.lblAverageCraftingTime.TabIndex = 16
        Me.lblAverageCraftingTime.Text = "Average Crafting Time: 000 Seconds"
        '
        'btnCalculate
        '
        Me.btnCalculate.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCalculate.Location = New System.Drawing.Point(14, 366)
        Me.btnCalculate.Name = "btnCalculate"
        Me.btnCalculate.Size = New System.Drawing.Size(443, 54)
        Me.btnCalculate.TabIndex = 17
        Me.btnCalculate.Text = "Calculate"
        Me.btnCalculate.UseVisualStyleBackColor = True
        '
        'lblCraftingType
        '
        Me.lblCraftingType.AutoSize = True
        Me.lblCraftingType.Location = New System.Drawing.Point(85, 439)
        Me.lblCraftingType.Name = "lblCraftingType"
        Me.lblCraftingType.Size = New System.Drawing.Size(40, 13)
        Me.lblCraftingType.TabIndex = 19
        Me.lblCraftingType.Text = "Label1"
        '
        'frmFactorioItems
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(478, 502)
        Me.Controls.Add(Me.lblCraftingType)
        Me.Controls.Add(Me.btnCalculate)
        Me.Controls.Add(Me.lblAverageCraftingTime)
        Me.Controls.Add(Me.lblTotalCraftingTime)
        Me.Controls.Add(Me.lblTitle)
        Me.Controls.Add(Me.pboLogo)
        Me.Controls.Add(Me.Factorio_itemsBindingNavigator)
        Me.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmFactorioItems"
        Me.Text = "Factorio Item Repository"
        CType(Me._factorio_itemsDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Factorio_itemsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Factorio_itemsBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Factorio_itemsBindingNavigator.ResumeLayout(False)
        Me.Factorio_itemsBindingNavigator.PerformLayout()
        CType(Me.pboLogo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents _factorio_itemsDataSet As FinalProject._factorio_itemsDataSet
    Friend WithEvents Factorio_itemsBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Factorio_itemsTableAdapter As FinalProject._factorio_itemsDataSetTableAdapters.tblFactorioTableAdapter
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
    Friend WithEvents pboLogo As System.Windows.Forms.PictureBox
    Friend WithEvents lblTitle As System.Windows.Forms.Label
    Friend WithEvents lblTotalCraftingTime As System.Windows.Forms.Label
    Friend WithEvents lblAverageCraftingTime As System.Windows.Forms.Label
    Friend WithEvents btnCalculate As System.Windows.Forms.Button
    Friend WithEvents lblCraftingType As System.Windows.Forms.Label

End Class
