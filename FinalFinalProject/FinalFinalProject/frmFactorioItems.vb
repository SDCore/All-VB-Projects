' Michael Voell
' Factorio Item Repository - Final Project
' 3/4/2016
' Purpose: To display information based on item information, and to showcase all the things learned in the class.

' --TODO--


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

        ' Select / Connecting to database
        Dim strSQL As String = "SELECT * FROM tblFactorio"
        Dim strPath As String = "Provider=Microsoft.ACE.OLEDB.12.0;" & "Data Source=E:\Advanced VB\FinalProject\FinalProject\factorio-items.accdb"
        Dim odaFactorioItem As New OleDb.OleDbDataAdapter(strSQL, strPath)
        Dim datFactorioItemFill As New DataTable
        odaFactorioItem.Fill(datFactorioItemFill)
        odaFactorioItem.Dispose()



    End Sub

    Private Sub btnCalculate_Click(sender As System.Object, e As System.EventArgs) Handles btnCalculate.Click

        ' Select / Connecting to database
        Dim strSQL As String = "SELECT * FROM tblFactorio"
        Dim strPath As String = "Provider=Microsoft.ACE.OLEDB.12.0;" & "Data Source=E:\Advanced VB\FinalProject\FinalProject\factorio-items.accdb"
        Dim odaFactorioItem As New OleDb.OleDbDataAdapter(strSQL, strPath)
        Dim datFactorioItemFill As New DataTable
        odaFactorioItem.Fill(datFactorioItemFill)
        odaFactorioItem.Dispose()

        ' Calculation Variables
        Dim decAverageTotal As Decimal
        Dim decTotal As Decimal

        For intCount = 0 To datFactorioItemFill.Rows.Count - 1
            decTotal = decTotal + datFactorioItemFill(intCount)("crafting-time")
        Next

        decAverageTotal = decTotal / datFactorioItemFill.Rows.Count

        lblAverageTime.Text = "Average Crafting Time: " & decAverageTotal.ToString("f2") & "s"
        lblTotalCraftingTime.Text = "Total Crafting Time: " & decTotal.ToString("f2") & "s"

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

        Dim strCraftingType As String = Crafting_typeLabel1.Text

        Select Case strCraftingType
            Case 0
                Crafting_typeLabel1.Text = "Hand"
            Case 1
                Crafting_typeLabel1.Text = "Assembly Machine 2"
            Case 2
                Crafting_typeLabel1.Text = "Pumpjack"
            Case 3
                Crafting_typeLabel1.Text = "Chemical Plant"
            Case 4
                Crafting_typeLabel1.Text = "Stone Furnace"
            Case 5
                Crafting_typeLabel1.Text = "Other"
        End Select

    End Sub
End Class
