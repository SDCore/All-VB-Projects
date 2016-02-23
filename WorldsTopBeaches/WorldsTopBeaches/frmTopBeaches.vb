Public Class frmTopBeaches

    Private Sub TopbeachesBindingNavigatorSaveItem_Click(sender As System.Object, e As System.EventArgs) Handles TopbeachesBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.TopbeachesBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.TopBeachesDataSet)

    End Sub

    Private Sub frmTopBeaches_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'TopBeachesDataSet.topbeaches' table. You can move, or remove it, as needed.

        Try
            Me.TopbeachesTableAdapter.Fill(Me.TopBeachesDataSet.topbeaches)
        Catch ex As Exception
            MsgBox("Could not establish a connection to the database.", , "Database Connection Error")
            Close()
        End Try

    End Sub
End Class
