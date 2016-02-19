Public Class Form1

    Private Sub ApprovedTravelRequestsBindingNavigatorSaveItem_Click(sender As System.Object, e As System.EventArgs) Handles ApprovedTravelRequestsBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.ApprovedTravelRequestsBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.TravelRequestsDataSet)

    End Sub

    Private Sub Form1_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'TravelRequestsDataSet.ApprovedTravelRequests' table. You can move, or remove it, as needed.
        Me.ApprovedTravelRequestsTableAdapter.Fill(Me.TravelRequestsDataSet.ApprovedTravelRequests)

    End Sub
End Class
