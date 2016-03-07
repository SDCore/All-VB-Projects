' Michael Voell
' Factorio Item Repository - Final Project
' 3/4/2016
' Purpose: To display information based on item information, and to showcase all the things learned in the class.

' --TODO--
' Output total amount of crafting time
' Output average amount of crafting time
' MORE LATER

Public Class frmFactorioItems

    Private Sub TblFactorioBindingNavigatorSaveItem_Click(sender As System.Object, e As System.EventArgs) Handles TblFactorioBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.TblFactorioBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me._factorio_itemsDataSet)

    End Sub

    Private Sub frmFactorioItems_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the '_factorio_itemsDataSet.tblFactorio' table. You can move, or remove it, as needed.

        ' Catching an exception if the database could not be found
        Try
            Me.TblFactorioTableAdapter.Fill(Me._factorio_itemsDataSet.tblFactorio)
        Catch ex As Exception
            MsgBox("Could not establish connection to database. Please try again.", , "Database Error")
            Close()
        End Try

    End Sub

    Private Sub btnCalculate_Click(sender As System.Object, e As System.EventArgs) Handles btnCalculate.Click

        ' Select / Connecting to database
        Dim strSQL As String = "SELECT * FROM tblFactorio"
        Dim strPath As String = "Provider=Microsoft.ACE.OLEDB.12.0;" & "Data Source=E:\Advanced VB\FinalProject\FinalProject\factorio-items.accdb"
        Dim odaFactorioItem As New OleDb.OleDbDataAdapter(strSQL, strPath)
        Dim datFactorioItemFill As New DataTable
        odaFactorioItem.Fill(datFactorioItemFill)
        odaFactorioItem.Dispose()

    End Sub

    Private Sub TblFactorioBindingNavigator_RefreshItems(sender As System.Object, e As System.EventArgs) Handles TblFactorioBindingNavigator.RefreshItems

        ' Select / Connecting to database.
        Dim strSQL As String = "SELECT * FROM tblFactorio"
        Dim strPath As String = "Provider=Microsoft.ACE.OLEDB.12.0;" & "Data Source=E:\Advanced VB\FinalProject\FinalProject\factorio-items.accdb"
        Dim odaFactorioItem As New OleDb.OleDbDataAdapter(strSQL, strPath)
        Dim datFactorioItemFill As New DataTable
        odaFactorioItem.Fill(datFactorioItemFill)
        odaFactorioItem.Dispose()

        ' Get selected ID from ComboBox
        Dim intIDRow As Integer = IDComboBox.SelectedIndex + 1

        ' Calculations
        Dim decCraftingType As Decimal
        Dim strCraftingType As String

        ' Getting Crafting Type
        decCraftingType = CDec(datFactorioItemFill.Rows(intIDRow)("crafting-type"))

        Select Case decCraftingType
            Case 0
                strCraftingType = "Hand"
            Case 1
                strCraftingType = "Assembly Machine 1"
            Case 2
                strCraftingType = "Assembly Machine 2"
            Case 3
                strCraftingType = "Assembly Machine 3"
            Case 4
                strCraftingType = "Pumpjack"
            Case 5
                strCraftingType = "Chemical Plant"
            Case 6
                strCraftingType = "Stone Furnace"
            Case 7
                strCraftingType = "Steel Furnace"
            Case 8
                strCraftingType = "Electronic Furnace"
            Case 9
                strCraftingType = "Other"
        End Select

        lblCraftingType.Text = strCraftingType

        ' Getting the amount in the selected major and the name of the selected major (from combobox selection)
        'decStudentsInMajor = CDec(datCollegeInfo.Rows(intDegreeRow)("Number in Degree"))
        'strSelectedMajor = CStr(datCollegeInfo.Rows(intDegreeRow)("Degree"))

        ' Calculating percentage in the selected major)
        'decPercentage = decStudentsInMajor / decTotal

        ' Outputting the percentage to "Percentage of Students in ______: 00%" label
        'lblStudentsInSelectedMajor.Text = "Percentage of Students in " & strSelectedMajor & ": " & decPercentage.ToString("P")

    End Sub
End Class
