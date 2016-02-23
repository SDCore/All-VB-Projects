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
        Me.StoreInventoryTableAdapter.Fill(Me.SpanishfoodDataSet.StoreInventory)

    End Sub
End Class
