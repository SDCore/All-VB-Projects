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
