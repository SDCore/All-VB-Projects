' Michael Voell
' Factorio Item Repository - Final Project
' 3/4/2016
' Purpose: To display information based on item information, and to showcase all the things learned in the class.

' --TODO--
' Output total amount of crafting time
' Output average amount of crafting time
' MORE LATER

Public Class frmFactorioItems

    Private Sub Factorio_itemsBindingNavigatorSaveItem_Click(sender As System.Object, e As System.EventArgs) Handles Factorio_itemsBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.Factorio_itemsBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me._factorio_itemsDataSet)

    End Sub

    Private Sub frmFactorioItems_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the '_factorio_itemsDataSet._factorio_items' table. You can move, or remove it, as needed.

        ' Catching an exception if the database could not be found
        Try
            Me.Factorio_itemsTableAdapter.Fill(Me._factorio_itemsDataSet._factorio_items)
        Catch ex As Exception
            MsgBox("Could not establish connection to database. Please try again.", , "Database Error")
            Close()
        End Try

    End Sub

    Private Sub btnCalculate_Click(sender As System.Object, e As System.EventArgs) Handles btnCalculate.Click

    End Sub
End Class
