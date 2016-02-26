<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCollegeMajors
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmCollegeMajors))
        Dim DepartmentLabel As System.Windows.Forms.Label
        Dim DegreeLabel As System.Windows.Forms.Label
        Dim Number_in_DegreeLabel As System.Windows.Forms.Label
        Me.CollegesDataSet = New CollegeMajors.collegesDataSet()
        Me.CollegeMajorsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CollegeMajorsTableAdapter = New CollegeMajors.collegesDataSetTableAdapters.CollegeMajorsTableAdapter()
        Me.TableAdapterManager = New CollegeMajors.collegesDataSetTableAdapters.TableAdapterManager()
        Me.CollegeMajorsBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
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
        Me.CollegeMajorsBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.DepartmentTextBox = New System.Windows.Forms.TextBox()
        Me.DegreeTextBox = New System.Windows.Forms.TextBox()
        Me.Number_in_DegreeTextBox = New System.Windows.Forms.TextBox()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.btnFindTotal = New System.Windows.Forms.Button()
        DepartmentLabel = New System.Windows.Forms.Label()
        DegreeLabel = New System.Windows.Forms.Label()
        Number_in_DegreeLabel = New System.Windows.Forms.Label()
        CType(Me.CollegesDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CollegeMajorsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CollegeMajorsBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.CollegeMajorsBindingNavigator.SuspendLayout()
        Me.SuspendLayout()
        '
        'CollegesDataSet
        '
        Me.CollegesDataSet.DataSetName = "collegesDataSet"
        Me.CollegesDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'CollegeMajorsBindingSource
        '
        Me.CollegeMajorsBindingSource.DataMember = "CollegeMajors"
        Me.CollegeMajorsBindingSource.DataSource = Me.CollegesDataSet
        '
        'CollegeMajorsTableAdapter
        '
        Me.CollegeMajorsTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.CollegeMajorsTableAdapter = Me.CollegeMajorsTableAdapter
        Me.TableAdapterManager.UpdateOrder = CollegeMajors.collegesDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'CollegeMajorsBindingNavigator
        '
        Me.CollegeMajorsBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.CollegeMajorsBindingNavigator.BindingSource = Me.CollegeMajorsBindingSource
        Me.CollegeMajorsBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.CollegeMajorsBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.CollegeMajorsBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.CollegeMajorsBindingNavigatorSaveItem})
        Me.CollegeMajorsBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.CollegeMajorsBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.CollegeMajorsBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.CollegeMajorsBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.CollegeMajorsBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.CollegeMajorsBindingNavigator.Name = "CollegeMajorsBindingNavigator"
        Me.CollegeMajorsBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.CollegeMajorsBindingNavigator.Size = New System.Drawing.Size(367, 25)
        Me.CollegeMajorsBindingNavigator.TabIndex = 0
        Me.CollegeMajorsBindingNavigator.Text = "BindingNavigator1"
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
        'CollegeMajorsBindingNavigatorSaveItem
        '
        Me.CollegeMajorsBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.CollegeMajorsBindingNavigatorSaveItem.Image = CType(resources.GetObject("CollegeMajorsBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.CollegeMajorsBindingNavigatorSaveItem.Name = "CollegeMajorsBindingNavigatorSaveItem"
        Me.CollegeMajorsBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.CollegeMajorsBindingNavigatorSaveItem.Text = "Save Data"
        '
        'DepartmentLabel
        '
        DepartmentLabel.AutoSize = True
        DepartmentLabel.Location = New System.Drawing.Point(12, 96)
        DepartmentLabel.Name = "DepartmentLabel"
        DepartmentLabel.Size = New System.Drawing.Size(68, 13)
        DepartmentLabel.TabIndex = 1
        DepartmentLabel.Text = "Department"
        '
        'DepartmentTextBox
        '
        Me.DepartmentTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CollegeMajorsBindingSource, "Department", True))
        Me.DepartmentTextBox.Location = New System.Drawing.Point(86, 93)
        Me.DepartmentTextBox.Name = "DepartmentTextBox"
        Me.DepartmentTextBox.Size = New System.Drawing.Size(269, 22)
        Me.DepartmentTextBox.TabIndex = 2
        '
        'DegreeLabel
        '
        DegreeLabel.AutoSize = True
        DegreeLabel.Location = New System.Drawing.Point(12, 121)
        DegreeLabel.Name = "DegreeLabel"
        DegreeLabel.Size = New System.Drawing.Size(44, 13)
        DegreeLabel.TabIndex = 3
        DegreeLabel.Text = "Degree"
        '
        'DegreeTextBox
        '
        Me.DegreeTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CollegeMajorsBindingSource, "Degree", True))
        Me.DegreeTextBox.Location = New System.Drawing.Point(62, 118)
        Me.DegreeTextBox.Name = "DegreeTextBox"
        Me.DegreeTextBox.Size = New System.Drawing.Size(293, 22)
        Me.DegreeTextBox.TabIndex = 4
        '
        'Number_in_DegreeLabel
        '
        Number_in_DegreeLabel.AutoSize = True
        Number_in_DegreeLabel.Location = New System.Drawing.Point(12, 146)
        Number_in_DegreeLabel.Name = "Number_in_DegreeLabel"
        Number_in_DegreeLabel.Size = New System.Drawing.Size(101, 13)
        Number_in_DegreeLabel.TabIndex = 5
        Number_in_DegreeLabel.Text = "Number in Degree"
        '
        'Number_in_DegreeTextBox
        '
        Me.Number_in_DegreeTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CollegeMajorsBindingSource, "Number in Degree", True))
        Me.Number_in_DegreeTextBox.Location = New System.Drawing.Point(119, 143)
        Me.Number_in_DegreeTextBox.Name = "Number_in_DegreeTextBox"
        Me.Number_in_DegreeTextBox.Size = New System.Drawing.Size(236, 22)
        Me.Number_in_DegreeTextBox.TabIndex = 6
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.Font = New System.Drawing.Font("Segoe UI", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle.Location = New System.Drawing.Point(12, 25)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(345, 65)
        Me.lblTitle.TabIndex = 7
        Me.lblTitle.Text = "College Majors"
        '
        'btnFindTotal
        '
        Me.btnFindTotal.Font = New System.Drawing.Font("Segoe UI", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnFindTotal.Location = New System.Drawing.Point(13, 171)
        Me.btnFindTotal.Name = "btnFindTotal"
        Me.btnFindTotal.Size = New System.Drawing.Size(342, 54)
        Me.btnFindTotal.TabIndex = 8
        Me.btnFindTotal.Text = "Find Total"
        Me.btnFindTotal.UseVisualStyleBackColor = True
        '
        'frmCollegeMajors
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(367, 312)
        Me.Controls.Add(Me.btnFindTotal)
        Me.Controls.Add(Me.lblTitle)
        Me.Controls.Add(Number_in_DegreeLabel)
        Me.Controls.Add(Me.Number_in_DegreeTextBox)
        Me.Controls.Add(DegreeLabel)
        Me.Controls.Add(Me.DegreeTextBox)
        Me.Controls.Add(DepartmentLabel)
        Me.Controls.Add(Me.DepartmentTextBox)
        Me.Controls.Add(Me.CollegeMajorsBindingNavigator)
        Me.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmCollegeMajors"
        Me.Text = "College Majors"
        CType(Me.CollegesDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CollegeMajorsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CollegeMajorsBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.CollegeMajorsBindingNavigator.ResumeLayout(False)
        Me.CollegeMajorsBindingNavigator.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents CollegesDataSet As CollegeMajors.collegesDataSet
    Friend WithEvents CollegeMajorsBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents CollegeMajorsTableAdapter As CollegeMajors.collegesDataSetTableAdapters.CollegeMajorsTableAdapter
    Friend WithEvents TableAdapterManager As CollegeMajors.collegesDataSetTableAdapters.TableAdapterManager
    Friend WithEvents CollegeMajorsBindingNavigator As System.Windows.Forms.BindingNavigator
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
    Friend WithEvents CollegeMajorsBindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents DepartmentTextBox As System.Windows.Forms.TextBox
    Friend WithEvents DegreeTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Number_in_DegreeTextBox As System.Windows.Forms.TextBox
    Friend WithEvents lblTitle As System.Windows.Forms.Label
    Friend WithEvents btnFindTotal As System.Windows.Forms.Button

End Class
