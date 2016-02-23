<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPowerSchool
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
        Dim StudentIDLabel As System.Windows.Forms.Label
        Dim FirstNameLabel As System.Windows.Forms.Label
        Dim LastNameLabel As System.Windows.Forms.Label
        Dim YearInSchoolLabel As System.Windows.Forms.Label
        Dim GPALabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmPowerSchool))
        Me.StudentInfoDataSet = New Powerschool.StudentInfoDataSet()
        Me.StudentInformationBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.StudentInformationTableAdapter = New Powerschool.StudentInfoDataSetTableAdapters.StudentInformationTableAdapter()
        Me.TableAdapterManager = New Powerschool.StudentInfoDataSetTableAdapters.TableAdapterManager()
        Me.StudentInformationBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
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
        Me.StudentInformationBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.StudentIDTextBox = New System.Windows.Forms.TextBox()
        Me.FirstNameTextBox = New System.Windows.Forms.TextBox()
        Me.LastNameTextBox = New System.Windows.Forms.TextBox()
        Me.YearInSchoolTextBox = New System.Windows.Forms.TextBox()
        Me.GPATextBox = New System.Windows.Forms.TextBox()
        Me.btnShowAverage = New System.Windows.Forms.Button()
        Me.lblAverageGPA = New System.Windows.Forms.Label()
        StudentIDLabel = New System.Windows.Forms.Label()
        FirstNameLabel = New System.Windows.Forms.Label()
        LastNameLabel = New System.Windows.Forms.Label()
        YearInSchoolLabel = New System.Windows.Forms.Label()
        GPALabel = New System.Windows.Forms.Label()
        CType(Me.StudentInfoDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StudentInformationBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StudentInformationBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.StudentInformationBindingNavigator.SuspendLayout()
        Me.SuspendLayout()
        '
        'StudentIDLabel
        '
        StudentIDLabel.AutoSize = True
        StudentIDLabel.Location = New System.Drawing.Point(12, 35)
        StudentIDLabel.Name = "StudentIDLabel"
        StudentIDLabel.Size = New System.Drawing.Size(62, 13)
        StudentIDLabel.TabIndex = 1
        StudentIDLabel.Text = "Student ID"
        '
        'FirstNameLabel
        '
        FirstNameLabel.AutoSize = True
        FirstNameLabel.Location = New System.Drawing.Point(12, 76)
        FirstNameLabel.Name = "FirstNameLabel"
        FirstNameLabel.Size = New System.Drawing.Size(64, 13)
        FirstNameLabel.TabIndex = 3
        FirstNameLabel.Text = "First Name:"
        '
        'LastNameLabel
        '
        LastNameLabel.AutoSize = True
        LastNameLabel.Location = New System.Drawing.Point(12, 117)
        LastNameLabel.Name = "LastNameLabel"
        LastNameLabel.Size = New System.Drawing.Size(62, 13)
        LastNameLabel.TabIndex = 5
        LastNameLabel.Text = "Last Name:"
        '
        'YearInSchoolLabel
        '
        YearInSchoolLabel.AutoSize = True
        YearInSchoolLabel.Location = New System.Drawing.Point(12, 158)
        YearInSchoolLabel.Name = "YearInSchoolLabel"
        YearInSchoolLabel.Size = New System.Drawing.Size(82, 13)
        YearInSchoolLabel.TabIndex = 7
        YearInSchoolLabel.Text = "Year In School:"
        '
        'GPALabel
        '
        GPALabel.AutoSize = True
        GPALabel.Location = New System.Drawing.Point(12, 199)
        GPALabel.Name = "GPALabel"
        GPALabel.Size = New System.Drawing.Size(31, 13)
        GPALabel.TabIndex = 9
        GPALabel.Text = "GPA:"
        '
        'StudentInfoDataSet
        '
        Me.StudentInfoDataSet.DataSetName = "StudentInfoDataSet"
        Me.StudentInfoDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'StudentInformationBindingSource
        '
        Me.StudentInformationBindingSource.DataMember = "StudentInformation"
        Me.StudentInformationBindingSource.DataSource = Me.StudentInfoDataSet
        '
        'StudentInformationTableAdapter
        '
        Me.StudentInformationTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.StudentInformationTableAdapter = Me.StudentInformationTableAdapter
        Me.TableAdapterManager.UpdateOrder = Powerschool.StudentInfoDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'StudentInformationBindingNavigator
        '
        Me.StudentInformationBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.StudentInformationBindingNavigator.BindingSource = Me.StudentInformationBindingSource
        Me.StudentInformationBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.StudentInformationBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.StudentInformationBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.StudentInformationBindingNavigatorSaveItem})
        Me.StudentInformationBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.StudentInformationBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.StudentInformationBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.StudentInformationBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.StudentInformationBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.StudentInformationBindingNavigator.Name = "StudentInformationBindingNavigator"
        Me.StudentInformationBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.StudentInformationBindingNavigator.Size = New System.Drawing.Size(584, 25)
        Me.StudentInformationBindingNavigator.TabIndex = 0
        Me.StudentInformationBindingNavigator.Text = "BindingNavigator1"
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
        'StudentInformationBindingNavigatorSaveItem
        '
        Me.StudentInformationBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.StudentInformationBindingNavigatorSaveItem.Image = CType(resources.GetObject("StudentInformationBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.StudentInformationBindingNavigatorSaveItem.Name = "StudentInformationBindingNavigatorSaveItem"
        Me.StudentInformationBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.StudentInformationBindingNavigatorSaveItem.Text = "Save Data"
        '
        'StudentIDTextBox
        '
        Me.StudentIDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.StudentInformationBindingSource, "studentID", True))
        Me.StudentIDTextBox.Location = New System.Drawing.Point(15, 51)
        Me.StudentIDTextBox.Name = "StudentIDTextBox"
        Me.StudentIDTextBox.Size = New System.Drawing.Size(557, 22)
        Me.StudentIDTextBox.TabIndex = 2
        '
        'FirstNameTextBox
        '
        Me.FirstNameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.StudentInformationBindingSource, "firstName", True))
        Me.FirstNameTextBox.Location = New System.Drawing.Point(15, 92)
        Me.FirstNameTextBox.Name = "FirstNameTextBox"
        Me.FirstNameTextBox.Size = New System.Drawing.Size(557, 22)
        Me.FirstNameTextBox.TabIndex = 4
        '
        'LastNameTextBox
        '
        Me.LastNameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.StudentInformationBindingSource, "lastName", True))
        Me.LastNameTextBox.Location = New System.Drawing.Point(15, 133)
        Me.LastNameTextBox.Name = "LastNameTextBox"
        Me.LastNameTextBox.Size = New System.Drawing.Size(557, 22)
        Me.LastNameTextBox.TabIndex = 6
        '
        'YearInSchoolTextBox
        '
        Me.YearInSchoolTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.StudentInformationBindingSource, "yearInSchool", True))
        Me.YearInSchoolTextBox.Location = New System.Drawing.Point(15, 174)
        Me.YearInSchoolTextBox.Name = "YearInSchoolTextBox"
        Me.YearInSchoolTextBox.Size = New System.Drawing.Size(557, 22)
        Me.YearInSchoolTextBox.TabIndex = 8
        '
        'GPATextBox
        '
        Me.GPATextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.StudentInformationBindingSource, "GPA", True))
        Me.GPATextBox.Location = New System.Drawing.Point(15, 215)
        Me.GPATextBox.Name = "GPATextBox"
        Me.GPATextBox.Size = New System.Drawing.Size(557, 22)
        Me.GPATextBox.TabIndex = 10
        '
        'btnShowAverage
        '
        Me.btnShowAverage.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnShowAverage.Location = New System.Drawing.Point(15, 244)
        Me.btnShowAverage.Name = "btnShowAverage"
        Me.btnShowAverage.Size = New System.Drawing.Size(557, 45)
        Me.btnShowAverage.TabIndex = 11
        Me.btnShowAverage.Text = "Show Average GPA"
        Me.btnShowAverage.UseVisualStyleBackColor = True
        '
        'lblAverageGPA
        '
        Me.lblAverageGPA.AutoSize = True
        Me.lblAverageGPA.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAverageGPA.Location = New System.Drawing.Point(233, 292)
        Me.lblAverageGPA.Name = "lblAverageGPA"
        Me.lblAverageGPA.Size = New System.Drawing.Size(115, 17)
        Me.lblAverageGPA.TabIndex = 12
        Me.lblAverageGPA.Text = "Average GPA: 0.00"
        '
        'frmPowerSchool
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(584, 319)
        Me.Controls.Add(Me.lblAverageGPA)
        Me.Controls.Add(Me.btnShowAverage)
        Me.Controls.Add(GPALabel)
        Me.Controls.Add(Me.GPATextBox)
        Me.Controls.Add(YearInSchoolLabel)
        Me.Controls.Add(Me.YearInSchoolTextBox)
        Me.Controls.Add(LastNameLabel)
        Me.Controls.Add(Me.LastNameTextBox)
        Me.Controls.Add(FirstNameLabel)
        Me.Controls.Add(Me.FirstNameTextBox)
        Me.Controls.Add(StudentIDLabel)
        Me.Controls.Add(Me.StudentIDTextBox)
        Me.Controls.Add(Me.StudentInformationBindingNavigator)
        Me.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "frmPowerSchool"
        Me.Text = "PowerSchool"
        CType(Me.StudentInfoDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StudentInformationBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StudentInformationBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.StudentInformationBindingNavigator.ResumeLayout(False)
        Me.StudentInformationBindingNavigator.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents StudentInfoDataSet As Powerschool.StudentInfoDataSet
    Friend WithEvents StudentInformationBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents StudentInformationTableAdapter As Powerschool.StudentInfoDataSetTableAdapters.StudentInformationTableAdapter
    Friend WithEvents TableAdapterManager As Powerschool.StudentInfoDataSetTableAdapters.TableAdapterManager
    Friend WithEvents StudentInformationBindingNavigator As System.Windows.Forms.BindingNavigator
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
    Friend WithEvents StudentInformationBindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents StudentIDTextBox As System.Windows.Forms.TextBox
    Friend WithEvents FirstNameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents LastNameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents YearInSchoolTextBox As System.Windows.Forms.TextBox
    Friend WithEvents GPATextBox As System.Windows.Forms.TextBox
    Friend WithEvents btnShowAverage As System.Windows.Forms.Button
    Friend WithEvents lblAverageGPA As System.Windows.Forms.Label

End Class
