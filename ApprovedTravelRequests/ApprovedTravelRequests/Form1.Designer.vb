<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Dim Employee_IDLabel As System.Windows.Forms.Label
        Dim Last_NameLabel As System.Windows.Forms.Label
        Dim First_NameLabel As System.Windows.Forms.Label
        Dim Purpose_for_TravelLabel As System.Windows.Forms.Label
        Dim LocationLabel As System.Windows.Forms.Label
        Dim Trip_DatesLabel As System.Windows.Forms.Label
        Dim Travel_CostLabel As System.Windows.Forms.Label
        Me.TravelRequestsDataSet = New ApprovedTravelRequests.TravelRequestsDataSet()
        Me.ApprovedTravelRequestsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ApprovedTravelRequestsTableAdapter = New ApprovedTravelRequests.TravelRequestsDataSetTableAdapters.ApprovedTravelRequestsTableAdapter()
        Me.TableAdapterManager = New ApprovedTravelRequests.TravelRequestsDataSetTableAdapters.TableAdapterManager()
        Me.ApprovedTravelRequestsBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
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
        Me.ApprovedTravelRequestsBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.Employee_IDTextBox = New System.Windows.Forms.TextBox()
        Me.frmApprovedTravel = New System.Windows.Forms.Label()
        Me.Last_NameTextBox = New System.Windows.Forms.TextBox()
        Me.First_NameTextBox = New System.Windows.Forms.TextBox()
        Me.Purpose_for_TravelTextBox = New System.Windows.Forms.TextBox()
        Me.LocationTextBox = New System.Windows.Forms.TextBox()
        Me.Trip_DatesTextBox = New System.Windows.Forms.TextBox()
        Me.Travel_CostTextBox = New System.Windows.Forms.TextBox()
        Me.btnTotalTravelCost = New System.Windows.Forms.Button()
        Me.lblTotalCost = New System.Windows.Forms.Label()
        Employee_IDLabel = New System.Windows.Forms.Label()
        Last_NameLabel = New System.Windows.Forms.Label()
        First_NameLabel = New System.Windows.Forms.Label()
        Purpose_for_TravelLabel = New System.Windows.Forms.Label()
        LocationLabel = New System.Windows.Forms.Label()
        Trip_DatesLabel = New System.Windows.Forms.Label()
        Travel_CostLabel = New System.Windows.Forms.Label()
        CType(Me.TravelRequestsDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ApprovedTravelRequestsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ApprovedTravelRequestsBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ApprovedTravelRequestsBindingNavigator.SuspendLayout()
        Me.SuspendLayout()
        '
        'TravelRequestsDataSet
        '
        Me.TravelRequestsDataSet.DataSetName = "TravelRequestsDataSet"
        Me.TravelRequestsDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ApprovedTravelRequestsBindingSource
        '
        Me.ApprovedTravelRequestsBindingSource.DataMember = "ApprovedTravelRequests"
        Me.ApprovedTravelRequestsBindingSource.DataSource = Me.TravelRequestsDataSet
        '
        'ApprovedTravelRequestsTableAdapter
        '
        Me.ApprovedTravelRequestsTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.ApprovedTravelRequestsTableAdapter = Me.ApprovedTravelRequestsTableAdapter
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.UpdateOrder = ApprovedTravelRequests.TravelRequestsDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'ApprovedTravelRequestsBindingNavigator
        '
        Me.ApprovedTravelRequestsBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.ApprovedTravelRequestsBindingNavigator.BindingSource = Me.ApprovedTravelRequestsBindingSource
        Me.ApprovedTravelRequestsBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.ApprovedTravelRequestsBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.ApprovedTravelRequestsBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.ApprovedTravelRequestsBindingNavigatorSaveItem})
        Me.ApprovedTravelRequestsBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.ApprovedTravelRequestsBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.ApprovedTravelRequestsBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.ApprovedTravelRequestsBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.ApprovedTravelRequestsBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.ApprovedTravelRequestsBindingNavigator.Name = "ApprovedTravelRequestsBindingNavigator"
        Me.ApprovedTravelRequestsBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.ApprovedTravelRequestsBindingNavigator.Size = New System.Drawing.Size(464, 25)
        Me.ApprovedTravelRequestsBindingNavigator.TabIndex = 0
        Me.ApprovedTravelRequestsBindingNavigator.Text = "BindingNavigator1"
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
        'ApprovedTravelRequestsBindingNavigatorSaveItem
        '
        Me.ApprovedTravelRequestsBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ApprovedTravelRequestsBindingNavigatorSaveItem.Image = CType(resources.GetObject("ApprovedTravelRequestsBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.ApprovedTravelRequestsBindingNavigatorSaveItem.Name = "ApprovedTravelRequestsBindingNavigatorSaveItem"
        Me.ApprovedTravelRequestsBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.ApprovedTravelRequestsBindingNavigatorSaveItem.Text = "Save Data"
        '
        'Employee_IDLabel
        '
        Employee_IDLabel.AutoSize = True
        Employee_IDLabel.Location = New System.Drawing.Point(16, 87)
        Employee_IDLabel.Name = "Employee_IDLabel"
        Employee_IDLabel.Size = New System.Drawing.Size(70, 13)
        Employee_IDLabel.TabIndex = 1
        Employee_IDLabel.Text = "Employee ID"
        '
        'Employee_IDTextBox
        '
        Me.Employee_IDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ApprovedTravelRequestsBindingSource, "Employee ID", True))
        Me.Employee_IDTextBox.Location = New System.Drawing.Point(19, 103)
        Me.Employee_IDTextBox.Name = "Employee_IDTextBox"
        Me.Employee_IDTextBox.Size = New System.Drawing.Size(422, 22)
        Me.Employee_IDTextBox.TabIndex = 2
        '
        'frmApprovedTravel
        '
        Me.frmApprovedTravel.AutoSize = True
        Me.frmApprovedTravel.Font = New System.Drawing.Font("Segoe UI", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.frmApprovedTravel.ForeColor = System.Drawing.Color.DarkCyan
        Me.frmApprovedTravel.Location = New System.Drawing.Point(12, 25)
        Me.frmApprovedTravel.Name = "frmApprovedTravel"
        Me.frmApprovedTravel.Size = New System.Drawing.Size(432, 37)
        Me.frmApprovedTravel.TabIndex = 3
        Me.frmApprovedTravel.Text = "Intuition Approved Travel Requests"
        '
        'Last_NameLabel
        '
        Last_NameLabel.AutoSize = True
        Last_NameLabel.Location = New System.Drawing.Point(16, 134)
        Last_NameLabel.Name = "Last_NameLabel"
        Last_NameLabel.Size = New System.Drawing.Size(59, 13)
        Last_NameLabel.TabIndex = 4
        Last_NameLabel.Text = "Last Name"
        '
        'Last_NameTextBox
        '
        Me.Last_NameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ApprovedTravelRequestsBindingSource, "Last Name", True))
        Me.Last_NameTextBox.Location = New System.Drawing.Point(19, 150)
        Me.Last_NameTextBox.Name = "Last_NameTextBox"
        Me.Last_NameTextBox.Size = New System.Drawing.Size(422, 22)
        Me.Last_NameTextBox.TabIndex = 5
        '
        'First_NameLabel
        '
        First_NameLabel.AutoSize = True
        First_NameLabel.Location = New System.Drawing.Point(16, 175)
        First_NameLabel.Name = "First_NameLabel"
        First_NameLabel.Size = New System.Drawing.Size(61, 13)
        First_NameLabel.TabIndex = 6
        First_NameLabel.Text = "First Name"
        '
        'First_NameTextBox
        '
        Me.First_NameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ApprovedTravelRequestsBindingSource, "First Name", True))
        Me.First_NameTextBox.Location = New System.Drawing.Point(19, 191)
        Me.First_NameTextBox.Name = "First_NameTextBox"
        Me.First_NameTextBox.Size = New System.Drawing.Size(422, 22)
        Me.First_NameTextBox.TabIndex = 7
        '
        'Purpose_for_TravelLabel
        '
        Purpose_for_TravelLabel.AutoSize = True
        Purpose_for_TravelLabel.Location = New System.Drawing.Point(16, 216)
        Purpose_for_TravelLabel.Name = "Purpose_for_TravelLabel"
        Purpose_for_TravelLabel.Size = New System.Drawing.Size(99, 13)
        Purpose_for_TravelLabel.TabIndex = 8
        Purpose_for_TravelLabel.Text = "Purpose for Travel"
        '
        'Purpose_for_TravelTextBox
        '
        Me.Purpose_for_TravelTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ApprovedTravelRequestsBindingSource, "Purpose for Travel", True))
        Me.Purpose_for_TravelTextBox.Location = New System.Drawing.Point(19, 232)
        Me.Purpose_for_TravelTextBox.Name = "Purpose_for_TravelTextBox"
        Me.Purpose_for_TravelTextBox.Size = New System.Drawing.Size(422, 22)
        Me.Purpose_for_TravelTextBox.TabIndex = 9
        '
        'LocationLabel
        '
        LocationLabel.AutoSize = True
        LocationLabel.Location = New System.Drawing.Point(16, 257)
        LocationLabel.Name = "LocationLabel"
        LocationLabel.Size = New System.Drawing.Size(51, 13)
        LocationLabel.TabIndex = 10
        LocationLabel.Text = "Location"
        '
        'LocationTextBox
        '
        Me.LocationTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ApprovedTravelRequestsBindingSource, "Location", True))
        Me.LocationTextBox.Location = New System.Drawing.Point(19, 273)
        Me.LocationTextBox.Name = "LocationTextBox"
        Me.LocationTextBox.Size = New System.Drawing.Size(422, 22)
        Me.LocationTextBox.TabIndex = 11
        '
        'Trip_DatesLabel
        '
        Trip_DatesLabel.AutoSize = True
        Trip_DatesLabel.Location = New System.Drawing.Point(16, 298)
        Trip_DatesLabel.Name = "Trip_DatesLabel"
        Trip_DatesLabel.Size = New System.Drawing.Size(58, 13)
        Trip_DatesLabel.TabIndex = 12
        Trip_DatesLabel.Text = "Trip Dates"
        '
        'Trip_DatesTextBox
        '
        Me.Trip_DatesTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ApprovedTravelRequestsBindingSource, "Trip Dates", True))
        Me.Trip_DatesTextBox.Location = New System.Drawing.Point(19, 314)
        Me.Trip_DatesTextBox.Name = "Trip_DatesTextBox"
        Me.Trip_DatesTextBox.Size = New System.Drawing.Size(422, 22)
        Me.Trip_DatesTextBox.TabIndex = 13
        '
        'Travel_CostLabel
        '
        Travel_CostLabel.AutoSize = True
        Travel_CostLabel.Location = New System.Drawing.Point(16, 339)
        Travel_CostLabel.Name = "Travel_CostLabel"
        Travel_CostLabel.Size = New System.Drawing.Size(62, 13)
        Travel_CostLabel.TabIndex = 14
        Travel_CostLabel.Text = "Travel Cost"
        '
        'Travel_CostTextBox
        '
        Me.Travel_CostTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ApprovedTravelRequestsBindingSource, "Travel Cost", True))
        Me.Travel_CostTextBox.Location = New System.Drawing.Point(19, 355)
        Me.Travel_CostTextBox.Name = "Travel_CostTextBox"
        Me.Travel_CostTextBox.Size = New System.Drawing.Size(422, 22)
        Me.Travel_CostTextBox.TabIndex = 15
        '
        'btnTotalTravelCost
        '
        Me.btnTotalTravelCost.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnTotalTravelCost.Location = New System.Drawing.Point(19, 384)
        Me.btnTotalTravelCost.Name = "btnTotalTravelCost"
        Me.btnTotalTravelCost.Size = New System.Drawing.Size(422, 56)
        Me.btnTotalTravelCost.TabIndex = 16
        Me.btnTotalTravelCost.Text = "Total Travel Cost"
        Me.btnTotalTravelCost.UseVisualStyleBackColor = True
        '
        'lblTotalCost
        '
        Me.lblTotalCost.AutoSize = True
        Me.lblTotalCost.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalCost.Location = New System.Drawing.Point(42, 443)
        Me.lblTotalCost.Name = "lblTotalCost"
        Me.lblTotalCost.Size = New System.Drawing.Size(373, 30)
        Me.lblTotalCost.TabIndex = 17
        Me.lblTotalCost.Text = "XXXXXXXXXXXXXXXXXXXXXXXXXXXXXX"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(464, 478)
        Me.Controls.Add(Me.lblTotalCost)
        Me.Controls.Add(Me.btnTotalTravelCost)
        Me.Controls.Add(Travel_CostLabel)
        Me.Controls.Add(Me.Travel_CostTextBox)
        Me.Controls.Add(Trip_DatesLabel)
        Me.Controls.Add(Me.Trip_DatesTextBox)
        Me.Controls.Add(LocationLabel)
        Me.Controls.Add(Me.LocationTextBox)
        Me.Controls.Add(Purpose_for_TravelLabel)
        Me.Controls.Add(Me.Purpose_for_TravelTextBox)
        Me.Controls.Add(First_NameLabel)
        Me.Controls.Add(Me.First_NameTextBox)
        Me.Controls.Add(Last_NameLabel)
        Me.Controls.Add(Me.Last_NameTextBox)
        Me.Controls.Add(Me.frmApprovedTravel)
        Me.Controls.Add(Employee_IDLabel)
        Me.Controls.Add(Me.Employee_IDTextBox)
        Me.Controls.Add(Me.ApprovedTravelRequestsBindingNavigator)
        Me.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.TravelRequestsDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ApprovedTravelRequestsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ApprovedTravelRequestsBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ApprovedTravelRequestsBindingNavigator.ResumeLayout(False)
        Me.ApprovedTravelRequestsBindingNavigator.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TravelRequestsDataSet As ApprovedTravelRequests.TravelRequestsDataSet
    Friend WithEvents ApprovedTravelRequestsBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ApprovedTravelRequestsTableAdapter As ApprovedTravelRequests.TravelRequestsDataSetTableAdapters.ApprovedTravelRequestsTableAdapter
    Friend WithEvents TableAdapterManager As ApprovedTravelRequests.TravelRequestsDataSetTableAdapters.TableAdapterManager
    Friend WithEvents ApprovedTravelRequestsBindingNavigator As System.Windows.Forms.BindingNavigator
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
    Friend WithEvents ApprovedTravelRequestsBindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents Employee_IDTextBox As System.Windows.Forms.TextBox
    Friend WithEvents frmApprovedTravel As System.Windows.Forms.Label
    Friend WithEvents Last_NameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents First_NameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Purpose_for_TravelTextBox As System.Windows.Forms.TextBox
    Friend WithEvents LocationTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Trip_DatesTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Travel_CostTextBox As System.Windows.Forms.TextBox
    Friend WithEvents btnTotalTravelCost As System.Windows.Forms.Button
    Friend WithEvents lblTotalCost As System.Windows.Forms.Label

End Class
