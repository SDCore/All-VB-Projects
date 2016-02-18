Public Class frmApprovedTravel

    Private Sub ApprovedTravelRequestsBindingNavigatorSaveItem_Click(sender As System.Object, e As System.EventArgs) Handles ApprovedTravelRequestsBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.ApprovedTravelRequestsBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.TravelDataSet)

    End Sub

    Private Sub frmApprovedTravel_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'TravelDataSet.ApprovedTravelRequests' table. You can move, or remove it, as needed.
        Me.ApprovedTravelRequestsTableAdapter.Fill(Me.TravelDataSet.ApprovedTravelRequests)

    End Sub
End Class
