<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmBaseballTeam
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmBaseballTeam))
        Dim Player_NumberLabel As System.Windows.Forms.Label
        Dim First_NameLabel As System.Windows.Forms.Label
        Dim Last_NameLabel As System.Windows.Forms.Label
        Dim Parent_Name_s_Label As System.Windows.Forms.Label
        Dim AddressLabel As System.Windows.Forms.Label
        Dim CityLabel As System.Windows.Forms.Label
        Dim StateLabel As System.Windows.Forms.Label
        Dim Zip_CodeLabel As System.Windows.Forms.Label
        Dim Telephone_NumberLabel As System.Windows.Forms.Label
        Dim AgeLabel As System.Windows.Forms.Label
        Me.LittleleagueDataSet = New SportsLeagueBaseballTeam.littleleagueDataSet()
        Me.TeamBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TeamTableAdapter = New SportsLeagueBaseballTeam.littleleagueDataSetTableAdapters.TeamTableAdapter()
        Me.TableAdapterManager = New SportsLeagueBaseballTeam.littleleagueDataSetTableAdapters.TableAdapterManager()
        Me.TeamBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
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
        Me.TeamBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.Player_NumberTextBox = New System.Windows.Forms.TextBox()
        Me.First_NameTextBox = New System.Windows.Forms.TextBox()
        Me.Last_NameTextBox = New System.Windows.Forms.TextBox()
        Me.Parent_Name_s_TextBox = New System.Windows.Forms.TextBox()
        Me.AddressTextBox = New System.Windows.Forms.TextBox()
        Me.CityTextBox = New System.Windows.Forms.TextBox()
        Me.StateTextBox = New System.Windows.Forms.TextBox()
        Me.Zip_CodeTextBox = New System.Windows.Forms.TextBox()
        Me.Telephone_NumberTextBox = New System.Windows.Forms.TextBox()
        Me.AgeTextBox = New System.Windows.Forms.TextBox()
        Me.btnCalculations = New System.Windows.Forms.Button()
        Me.pboLogo = New System.Windows.Forms.PictureBox()
        Me.lblAges12 = New System.Windows.Forms.Label()
        Me.lblAges13 = New System.Windows.Forms.Label()
        Me.lblAges14 = New System.Windows.Forms.Label()
        Me.lblAverageAge = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Player_NumberLabel = New System.Windows.Forms.Label()
        First_NameLabel = New System.Windows.Forms.Label()
        Last_NameLabel = New System.Windows.Forms.Label()
        Parent_Name_s_Label = New System.Windows.Forms.Label()
        AddressLabel = New System.Windows.Forms.Label()
        CityLabel = New System.Windows.Forms.Label()
        StateLabel = New System.Windows.Forms.Label()
        Zip_CodeLabel = New System.Windows.Forms.Label()
        Telephone_NumberLabel = New System.Windows.Forms.Label()
        AgeLabel = New System.Windows.Forms.Label()
        CType(Me.LittleleagueDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TeamBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TeamBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TeamBindingNavigator.SuspendLayout()
        CType(Me.pboLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LittleleagueDataSet
        '
        Me.LittleleagueDataSet.DataSetName = "littleleagueDataSet"
        Me.LittleleagueDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TeamBindingSource
        '
        Me.TeamBindingSource.DataMember = "Team"
        Me.TeamBindingSource.DataSource = Me.LittleleagueDataSet
        '
        'TeamTableAdapter
        '
        Me.TeamTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.TeamTableAdapter = Me.TeamTableAdapter
        Me.TableAdapterManager.UpdateOrder = SportsLeagueBaseballTeam.littleleagueDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'TeamBindingNavigator
        '
        Me.TeamBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.TeamBindingNavigator.BindingSource = Me.TeamBindingSource
        Me.TeamBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.TeamBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.TeamBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.TeamBindingNavigatorSaveItem})
        Me.TeamBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.TeamBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.TeamBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.TeamBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.TeamBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.TeamBindingNavigator.Name = "TeamBindingNavigator"
        Me.TeamBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.TeamBindingNavigator.Size = New System.Drawing.Size(496, 25)
        Me.TeamBindingNavigator.TabIndex = 0
        Me.TeamBindingNavigator.Text = "BindingNavigator1"
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
        'TeamBindingNavigatorSaveItem
        '
        Me.TeamBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.TeamBindingNavigatorSaveItem.Image = CType(resources.GetObject("TeamBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.TeamBindingNavigatorSaveItem.Name = "TeamBindingNavigatorSaveItem"
        Me.TeamBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.TeamBindingNavigatorSaveItem.Text = "Save Data"
        '
        'Player_NumberLabel
        '
        Player_NumberLabel.AutoSize = True
        Player_NumberLabel.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Player_NumberLabel.Location = New System.Drawing.Point(9, 144)
        Player_NumberLabel.Name = "Player_NumberLabel"
        Player_NumberLabel.Size = New System.Drawing.Size(81, 13)
        Player_NumberLabel.TabIndex = 1
        Player_NumberLabel.Text = "Player Number"
        '
        'Player_NumberTextBox
        '
        Me.Player_NumberTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TeamBindingSource, "Player Number", True))
        Me.Player_NumberTextBox.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Player_NumberTextBox.Location = New System.Drawing.Point(12, 160)
        Me.Player_NumberTextBox.Name = "Player_NumberTextBox"
        Me.Player_NumberTextBox.Size = New System.Drawing.Size(231, 22)
        Me.Player_NumberTextBox.TabIndex = 2
        '
        'First_NameLabel
        '
        First_NameLabel.AutoSize = True
        First_NameLabel.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        First_NameLabel.Location = New System.Drawing.Point(246, 144)
        First_NameLabel.Name = "First_NameLabel"
        First_NameLabel.Size = New System.Drawing.Size(64, 13)
        First_NameLabel.TabIndex = 3
        First_NameLabel.Text = "First Name:"
        '
        'First_NameTextBox
        '
        Me.First_NameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TeamBindingSource, "First Name", True))
        Me.First_NameTextBox.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.First_NameTextBox.Location = New System.Drawing.Point(249, 160)
        Me.First_NameTextBox.Name = "First_NameTextBox"
        Me.First_NameTextBox.Size = New System.Drawing.Size(235, 22)
        Me.First_NameTextBox.TabIndex = 4
        '
        'Last_NameLabel
        '
        Last_NameLabel.AutoSize = True
        Last_NameLabel.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Last_NameLabel.Location = New System.Drawing.Point(9, 183)
        Last_NameLabel.Name = "Last_NameLabel"
        Last_NameLabel.Size = New System.Drawing.Size(62, 13)
        Last_NameLabel.TabIndex = 5
        Last_NameLabel.Text = "Last Name:"
        '
        'Last_NameTextBox
        '
        Me.Last_NameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TeamBindingSource, "Last Name", True))
        Me.Last_NameTextBox.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Last_NameTextBox.Location = New System.Drawing.Point(12, 199)
        Me.Last_NameTextBox.Name = "Last_NameTextBox"
        Me.Last_NameTextBox.Size = New System.Drawing.Size(231, 22)
        Me.Last_NameTextBox.TabIndex = 6
        '
        'Parent_Name_s_Label
        '
        Parent_Name_s_Label.AutoSize = True
        Parent_Name_s_Label.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Parent_Name_s_Label.Location = New System.Drawing.Point(246, 183)
        Parent_Name_s_Label.Name = "Parent_Name_s_Label"
        Parent_Name_s_Label.Size = New System.Drawing.Size(86, 13)
        Parent_Name_s_Label.TabIndex = 7
        Parent_Name_s_Label.Text = "Parent Name(s):"
        '
        'Parent_Name_s_TextBox
        '
        Me.Parent_Name_s_TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TeamBindingSource, "Parent Name(s)", True))
        Me.Parent_Name_s_TextBox.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Parent_Name_s_TextBox.Location = New System.Drawing.Point(249, 199)
        Me.Parent_Name_s_TextBox.Name = "Parent_Name_s_TextBox"
        Me.Parent_Name_s_TextBox.Size = New System.Drawing.Size(235, 22)
        Me.Parent_Name_s_TextBox.TabIndex = 8
        '
        'AddressLabel
        '
        AddressLabel.AutoSize = True
        AddressLabel.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        AddressLabel.Location = New System.Drawing.Point(9, 222)
        AddressLabel.Name = "AddressLabel"
        AddressLabel.Size = New System.Drawing.Size(51, 13)
        AddressLabel.TabIndex = 9
        AddressLabel.Text = "Address:"
        '
        'AddressTextBox
        '
        Me.AddressTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TeamBindingSource, "Address", True))
        Me.AddressTextBox.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AddressTextBox.Location = New System.Drawing.Point(12, 238)
        Me.AddressTextBox.Name = "AddressTextBox"
        Me.AddressTextBox.Size = New System.Drawing.Size(231, 22)
        Me.AddressTextBox.TabIndex = 10
        '
        'CityLabel
        '
        CityLabel.AutoSize = True
        CityLabel.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        CityLabel.Location = New System.Drawing.Point(246, 222)
        CityLabel.Name = "CityLabel"
        CityLabel.Size = New System.Drawing.Size(29, 13)
        CityLabel.TabIndex = 11
        CityLabel.Text = "City:"
        '
        'CityTextBox
        '
        Me.CityTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TeamBindingSource, "City", True))
        Me.CityTextBox.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CityTextBox.Location = New System.Drawing.Point(249, 238)
        Me.CityTextBox.Name = "CityTextBox"
        Me.CityTextBox.Size = New System.Drawing.Size(235, 22)
        Me.CityTextBox.TabIndex = 12
        '
        'StateLabel
        '
        StateLabel.AutoSize = True
        StateLabel.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        StateLabel.Location = New System.Drawing.Point(9, 261)
        StateLabel.Name = "StateLabel"
        StateLabel.Size = New System.Drawing.Size(36, 13)
        StateLabel.TabIndex = 13
        StateLabel.Text = "State:"
        '
        'StateTextBox
        '
        Me.StateTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TeamBindingSource, "State", True))
        Me.StateTextBox.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.StateTextBox.Location = New System.Drawing.Point(12, 277)
        Me.StateTextBox.Name = "StateTextBox"
        Me.StateTextBox.Size = New System.Drawing.Size(231, 22)
        Me.StateTextBox.TabIndex = 14
        '
        'Zip_CodeLabel
        '
        Zip_CodeLabel.AutoSize = True
        Zip_CodeLabel.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Zip_CodeLabel.Location = New System.Drawing.Point(246, 261)
        Zip_CodeLabel.Name = "Zip_CodeLabel"
        Zip_CodeLabel.Size = New System.Drawing.Size(56, 13)
        Zip_CodeLabel.TabIndex = 15
        Zip_CodeLabel.Text = "Zip Code:"
        '
        'Zip_CodeTextBox
        '
        Me.Zip_CodeTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TeamBindingSource, "Zip Code", True))
        Me.Zip_CodeTextBox.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Zip_CodeTextBox.Location = New System.Drawing.Point(249, 277)
        Me.Zip_CodeTextBox.Name = "Zip_CodeTextBox"
        Me.Zip_CodeTextBox.Size = New System.Drawing.Size(235, 22)
        Me.Zip_CodeTextBox.TabIndex = 16
        '
        'Telephone_NumberLabel
        '
        Telephone_NumberLabel.AutoSize = True
        Telephone_NumberLabel.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Telephone_NumberLabel.Location = New System.Drawing.Point(9, 300)
        Telephone_NumberLabel.Name = "Telephone_NumberLabel"
        Telephone_NumberLabel.Size = New System.Drawing.Size(108, 13)
        Telephone_NumberLabel.TabIndex = 17
        Telephone_NumberLabel.Text = "Telephone Number:"
        '
        'Telephone_NumberTextBox
        '
        Me.Telephone_NumberTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TeamBindingSource, "Telephone Number", True))
        Me.Telephone_NumberTextBox.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Telephone_NumberTextBox.Location = New System.Drawing.Point(12, 316)
        Me.Telephone_NumberTextBox.Name = "Telephone_NumberTextBox"
        Me.Telephone_NumberTextBox.Size = New System.Drawing.Size(231, 22)
        Me.Telephone_NumberTextBox.TabIndex = 18
        '
        'AgeLabel
        '
        AgeLabel.AutoSize = True
        AgeLabel.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        AgeLabel.Location = New System.Drawing.Point(246, 300)
        AgeLabel.Name = "AgeLabel"
        AgeLabel.Size = New System.Drawing.Size(30, 13)
        AgeLabel.TabIndex = 19
        AgeLabel.Text = "Age:"
        '
        'AgeTextBox
        '
        Me.AgeTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TeamBindingSource, "Age", True))
        Me.AgeTextBox.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AgeTextBox.Location = New System.Drawing.Point(249, 316)
        Me.AgeTextBox.Name = "AgeTextBox"
        Me.AgeTextBox.Size = New System.Drawing.Size(235, 22)
        Me.AgeTextBox.TabIndex = 20
        '
        'btnCalculations
        '
        Me.btnCalculations.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCalculations.Location = New System.Drawing.Point(12, 344)
        Me.btnCalculations.Name = "btnCalculations"
        Me.btnCalculations.Size = New System.Drawing.Size(472, 56)
        Me.btnCalculations.TabIndex = 21
        Me.btnCalculations.Text = "Calculate Ages"
        Me.btnCalculations.UseVisualStyleBackColor = True
        '
        'pboLogo
        '
        Me.pboLogo.Image = CType(resources.GetObject("pboLogo.Image"), System.Drawing.Image)
        Me.pboLogo.Location = New System.Drawing.Point(12, 28)
        Me.pboLogo.Name = "pboLogo"
        Me.pboLogo.Size = New System.Drawing.Size(472, 113)
        Me.pboLogo.TabIndex = 22
        Me.pboLogo.TabStop = False
        '
        'lblAges12
        '
        Me.lblAges12.AutoSize = True
        Me.lblAges12.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAges12.Location = New System.Drawing.Point(13, 403)
        Me.lblAges12.Name = "lblAges12"
        Me.lblAges12.Size = New System.Drawing.Size(128, 21)
        Me.lblAges12.TabIndex = 23
        Me.lblAges12.Text = "12 Year Olds:  00"
        '
        'lblAges13
        '
        Me.lblAges13.AutoSize = True
        Me.lblAges13.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAges13.Location = New System.Drawing.Point(186, 403)
        Me.lblAges13.Name = "lblAges13"
        Me.lblAges13.Size = New System.Drawing.Size(124, 21)
        Me.lblAges13.TabIndex = 24
        Me.lblAges13.Text = "13 Year Olds: 00"
        '
        'lblAges14
        '
        Me.lblAges14.AutoSize = True
        Me.lblAges14.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAges14.Location = New System.Drawing.Point(360, 403)
        Me.lblAges14.Name = "lblAges14"
        Me.lblAges14.Size = New System.Drawing.Size(124, 21)
        Me.lblAges14.TabIndex = 25
        Me.lblAges14.Text = "14 Year Olds: 00"
        '
        'lblAverageAge
        '
        Me.lblAverageAge.AutoSize = True
        Me.lblAverageAge.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAverageAge.Location = New System.Drawing.Point(186, 424)
        Me.lblAverageAge.Name = "lblAverageAge"
        Me.lblAverageAge.Size = New System.Drawing.Size(123, 21)
        Me.lblAverageAge.TabIndex = 26
        Me.lblAverageAge.Text = "Average Age: 00"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(364, 437)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(40, 13)
        Me.Label1.TabIndex = 27
        Me.Label1.Text = "Label1"
        '
        'frmBaseballTeam
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(496, 452)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lblAverageAge)
        Me.Controls.Add(Me.lblAges14)
        Me.Controls.Add(Me.lblAges13)
        Me.Controls.Add(Me.lblAges12)
        Me.Controls.Add(Me.pboLogo)
        Me.Controls.Add(Me.btnCalculations)
        Me.Controls.Add(AgeLabel)
        Me.Controls.Add(Me.AgeTextBox)
        Me.Controls.Add(Telephone_NumberLabel)
        Me.Controls.Add(Me.Telephone_NumberTextBox)
        Me.Controls.Add(Zip_CodeLabel)
        Me.Controls.Add(Me.Zip_CodeTextBox)
        Me.Controls.Add(StateLabel)
        Me.Controls.Add(Me.StateTextBox)
        Me.Controls.Add(CityLabel)
        Me.Controls.Add(Me.CityTextBox)
        Me.Controls.Add(AddressLabel)
        Me.Controls.Add(Me.AddressTextBox)
        Me.Controls.Add(Parent_Name_s_Label)
        Me.Controls.Add(Me.Parent_Name_s_TextBox)
        Me.Controls.Add(Last_NameLabel)
        Me.Controls.Add(Me.Last_NameTextBox)
        Me.Controls.Add(First_NameLabel)
        Me.Controls.Add(Me.First_NameTextBox)
        Me.Controls.Add(Player_NumberLabel)
        Me.Controls.Add(Me.Player_NumberTextBox)
        Me.Controls.Add(Me.TeamBindingNavigator)
        Me.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "frmBaseballTeam"
        Me.Text = "Sports League Baseball Team"
        CType(Me.LittleleagueDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TeamBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TeamBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TeamBindingNavigator.ResumeLayout(False)
        Me.TeamBindingNavigator.PerformLayout()
        CType(Me.pboLogo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents LittleleagueDataSet As SportsLeagueBaseballTeam.littleleagueDataSet
    Friend WithEvents TeamBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents TeamTableAdapter As SportsLeagueBaseballTeam.littleleagueDataSetTableAdapters.TeamTableAdapter
    Friend WithEvents TableAdapterManager As SportsLeagueBaseballTeam.littleleagueDataSetTableAdapters.TableAdapterManager
    Friend WithEvents TeamBindingNavigator As System.Windows.Forms.BindingNavigator
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
    Friend WithEvents TeamBindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents Player_NumberTextBox As System.Windows.Forms.TextBox
    Friend WithEvents First_NameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Last_NameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Parent_Name_s_TextBox As System.Windows.Forms.TextBox
    Friend WithEvents AddressTextBox As System.Windows.Forms.TextBox
    Friend WithEvents CityTextBox As System.Windows.Forms.TextBox
    Friend WithEvents StateTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Zip_CodeTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Telephone_NumberTextBox As System.Windows.Forms.TextBox
    Friend WithEvents AgeTextBox As System.Windows.Forms.TextBox
    Friend WithEvents btnCalculations As System.Windows.Forms.Button
    Friend WithEvents pboLogo As System.Windows.Forms.PictureBox
    Friend WithEvents lblAges12 As System.Windows.Forms.Label
    Friend WithEvents lblAges13 As System.Windows.Forms.Label
    Friend WithEvents lblAges14 As System.Windows.Forms.Label
    Friend WithEvents lblAverageAge As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label

End Class
