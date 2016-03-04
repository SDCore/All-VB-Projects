Public Class frmFactorioItems

    Private Sub Factorio_itemsBindingNavigatorSaveItem_Click(sender As System.Object, e As System.EventArgs) Handles Factorio_itemsBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.Factorio_itemsBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me._factorio_itemsDataSet)

    End Sub

    Private Sub frmFactorioItems_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the '_factorio_itemsDataSet._factorio_items' table. You can move, or remove it, as needed.
        Me.Factorio_itemsTableAdapter.Fill(Me._factorio_itemsDataSet._factorio_items)

    End Sub
End Class
