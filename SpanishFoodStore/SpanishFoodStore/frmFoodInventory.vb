' Michael Voell
' Spanish Food Inventory
' 2/23/2016
' Purpose: Show the inventory of a Spanish Food Store and calculate the total value of the intentory.

' --TODO--
' Compute Total Button to compute total value of the store's inventory
' Total Value Equation: (Cost Per Item * The Quantity of the Item) + Accumulator
' Try/Catch for when database is not available

Option Strict On

Public Class frmFoodInventory

    Private Sub StoreInventoryBindingNavigatorSaveItem_Click(sender As System.Object, e As System.EventArgs) Handles StoreInventoryBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.StoreInventoryBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.SpanishfoodDataSet)

    End Sub

    Private Sub Form1_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'SpanishfoodDataSet.StoreInventory' table. You can move, or remove it, as needed.
        Me.StoreInventoryTableAdapter.Fill(Me.SpanishfoodDataSet.StoreInventory)

        ' Select / Connecting to database
        Dim strSQL As String = "SELECT * FROM StoreInventory"
        Dim strPath As String = "Provider=Microsoft.ACE.OLEDB.12.0;" & "Data Source=E:\Advanced VB\SpanishFoodStore\SpanishFoodStore\spanishfood.accdb"
        Dim odaSpanishFood As New OleDb.OleDbDataAdapter(strSQL, strPath)
        Dim datSpanishFoodFill As New DataTable
        odaSpanishFood.Fill(datSpanishFoodFill)
        odaSpanishFood.Dispose()

    End Sub
End Class
