' Michael Voell
' Spanish Food Inventory
' 2/23/2016
' Purpose: Show the inventory of a Spanish Food Store and calculate the total value of the intentory.

Option Strict On

Public Class frmFoodInventory

    Private Sub StoreInventoryBindingNavigatorSaveItem_Click(sender As System.Object, e As System.EventArgs) Handles StoreInventoryBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.StoreInventoryBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.SpanishfoodDataSet)

    End Sub

    Private Sub Form1_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'SpanishfoodDataSet.StoreInventory' table. You can move, or remove it, as needed.

        Try
            Me.StoreInventoryTableAdapter.Fill(Me.SpanishfoodDataSet.StoreInventory)
        Catch ex As Exception
            MsgBox("Could not connect to database. Please try again.", , "Database Connection Error")
        End Try

    End Sub

    Private Sub btnTotalInventory_Click(sender As System.Object, e As System.EventArgs) Handles btnTotalInventory.Click

        ' Select / Connecting to database
        Dim strSQL As String = "SELECT * FROM StoreInventory"
        Dim strPath As String = "Provider=Microsoft.ACE.OLEDB.12.0;" & "Data Source=E:\Advanced VB\SpanishFoodStore\SpanishFoodStore\spanishfood.accdb"
        Dim odaSpanishFood As New OleDb.OleDbDataAdapter(strSQL, strPath)
        Dim datSpanishFoodFill As New DataTable
        odaSpanishFood.Fill(datSpanishFoodFill)
        odaSpanishFood.Dispose()

        ' Variables
        Dim intCount As Integer = 0
        Dim decTotal As Decimal

        For intCount = 0 To datSpanishFoodFill.Rows.Count - 1
            decTotal = decTotal + (Convert.ToDecimal(datSpanishFoodFill.Rows(intCount)("Cost per Item")) * Convert.ToDecimal(datSpanishFoodFill.Rows(intCount)("Quantity")))
            intCount += 1
        Next

        lblTotalValue.Text = "Total Value: " & decTotal.ToString("C")

    End Sub
End Class
