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
        Dim DepartmentLabel As System.Windows.Forms.Label
        Dim Number_in_DegreeLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmCollegeMajors))
        Dim DegreeLabel1 As System.Windows.Forms.Label
        Me.CollegesDataSet = New CollegeMajors.collegesDataSet()
        Me.CollegeMajorsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CollegeMajorsTableAdapter = New CollegeMajors.collegesDataSetTableAdapters.CollegeMajorsTableAdapter()
        Me.TableAdapterManager = New CollegeMajors.collegesDataSetTableAdapters.TableAdapterManager()
        Me.CollegeMajorsBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
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
        Me.CollegeMajorsBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.DepartmentTextBox = New System.Windows.Forms.TextBox()
        Me.Number_in_DegreeTextBox = New System.Windows.Forms.TextBox()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.btnFindTotal = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.DegreeComboBox = New System.Windows.Forms.ComboBox()
        Me.lblTotalStudents = New System.Windows.Forms.Label()
        Me.lblStudentsInSelectedMajor = New System.Windows.Forms.Label()
        DepartmentLabel = New System.Windows.Forms.Label()
        Number_in_DegreeLabel = New System.Windows.Forms.Label()
        DegreeLabel1 = New System.Windows.Forms.Label()
        CType(Me.CollegesDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CollegeMajorsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CollegeMajorsBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.CollegeMajorsBindingNavigator.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DepartmentLabel
        '
        DepartmentLabel.AutoSize = True
        DepartmentLabel.Location = New System.Drawing.Point(14, 282)
        DepartmentLabel.Name = "DepartmentLabel"
        DepartmentLabel.Size = New System.Drawing.Size(68, 13)
        DepartmentLabel.TabIndex = 1
        DepartmentLabel.Text = "Department"
        '
        'Number_in_DegreeLabel
        '
        Number_in_DegreeLabel.AutoSize = True
        Number_in_DegreeLabel.Location = New System.Drawing.Point(14, 332)
        Number_in_DegreeLabel.Name = "Number_in_DegreeLabel"
        Number_in_DegreeLabel.Size = New System.Drawing.Size(101, 13)
        Number_in_DegreeLabel.TabIndex = 5
        Number_in_DegreeLabel.Text = "Number in Degree"
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
        Me.CollegeMajorsBindingNavigator.Size = New System.Drawing.Size(377, 25)
        Me.CollegeMajorsBindingNavigator.TabIndex = 0
        Me.CollegeMajorsBindingNavigator.Text = "BindingNavigator1"
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
        'CollegeMajorsBindingNavigatorSaveItem
        '
        Me.CollegeMajorsBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.CollegeMajorsBindingNavigatorSaveItem.Image = CType(resources.GetObject("CollegeMajorsBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.CollegeMajorsBindingNavigatorSaveItem.Name = "CollegeMajorsBindingNavigatorSaveItem"
        Me.CollegeMajorsBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.CollegeMajorsBindingNavigatorSaveItem.Text = "Save Data"
        '
        'DepartmentTextBox
        '
        Me.DepartmentTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CollegeMajorsBindingSource, "Department", True))
        Me.DepartmentTextBox.Location = New System.Drawing.Point(88, 279)
        Me.DepartmentTextBox.Name = "DepartmentTextBox"
        Me.DepartmentTextBox.Size = New System.Drawing.Size(269, 22)
        Me.DepartmentTextBox.TabIndex = 2
        '
        'Number_in_DegreeTextBox
        '
        Me.Number_in_DegreeTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CollegeMajorsBindingSource, "Number in Degree", True))
        Me.Number_in_DegreeTextBox.Location = New System.Drawing.Point(121, 329)
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
        Me.btnFindTotal.Font = New System.Drawing.Font("Segoe UI", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnFindTotal.Location = New System.Drawing.Point(15, 357)
        Me.btnFindTotal.Name = "btnFindTotal"
        Me.btnFindTotal.Size = New System.Drawing.Size(342, 54)
        Me.btnFindTotal.TabIndex = 8
        Me.btnFindTotal.Text = "Find Total"
        Me.btnFindTotal.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(17, 93)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(340, 180)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 9
        Me.PictureBox1.TabStop = False
        '
        'DegreeLabel1
        '
        DegreeLabel1.AutoSize = True
        DegreeLabel1.Location = New System.Drawing.Point(14, 308)
        DegreeLabel1.Name = "DegreeLabel1"
        DegreeLabel1.Size = New System.Drawing.Size(44, 13)
        DegreeLabel1.TabIndex = 10
        DegreeLabel1.Text = "Degree"
        '
        'DegreeComboBox
        '
        Me.DegreeComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CollegeMajorsBindingSource, "Degree", True))
        Me.DegreeComboBox.FormattingEnabled = True
        Me.DegreeComboBox.Location = New System.Drawing.Point(64, 305)
        Me.DegreeComboBox.Name = "DegreeComboBox"
        Me.DegreeComboBox.Size = New System.Drawing.Size(293, 21)
        Me.DegreeComboBox.TabIndex = 11
        '
        'lblTotalStudents
        '
        Me.lblTotalStudents.AutoSize = True
        Me.lblTotalStudents.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalStudents.Location = New System.Drawing.Point(21, 426)
        Me.lblTotalStudents.Name = "lblTotalStudents"
        Me.lblTotalStudents.Size = New System.Drawing.Size(325, 21)
        Me.lblTotalStudents.TabIndex = 12
        Me.lblTotalStudents.Text = "Total Amount of Students in Majors: 0000"
        '
        'lblStudentsInSelectedMajor
        '
        Me.lblStudentsInSelectedMajor.AutoSize = True
        Me.lblStudentsInSelectedMajor.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStudentsInSelectedMajor.Location = New System.Drawing.Point(22, 447)
        Me.lblStudentsInSelectedMajor.Name = "lblStudentsInSelectedMajor"
        Me.lblStudentsInSelectedMajor.Size = New System.Drawing.Size(320, 21)
        Me.lblStudentsInSelectedMajor.TabIndex = 13
        Me.lblStudentsInSelectedMajor.Text = "Percentage of Students in __________: 00%"
        '
        'frmCollegeMajors
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(377, 479)
        Me.Controls.Add(Me.lblStudentsInSelectedMajor)
        Me.Controls.Add(Me.lblTotalStudents)
        Me.Controls.Add(DegreeLabel1)
        Me.Controls.Add(Me.DegreeComboBox)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.btnFindTotal)
        Me.Controls.Add(Me.lblTitle)
        Me.Controls.Add(Number_in_DegreeLabel)
        Me.Controls.Add(Me.Number_in_DegreeTextBox)
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
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents Number_in_DegreeTextBox As System.Windows.Forms.TextBox
    Friend WithEvents lblTitle As System.Windows.Forms.Label
    Friend WithEvents btnFindTotal As System.Windows.Forms.Button
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents DegreeComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents lblTotalStudents As System.Windows.Forms.Label
    Friend WithEvents lblStudentsInSelectedMajor As System.Windows.Forms.Label

End Class
