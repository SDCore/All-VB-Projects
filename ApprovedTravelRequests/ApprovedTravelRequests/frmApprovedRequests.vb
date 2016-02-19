' Michael Voell
' Approved Travel Requests
' 2/19/2016
' Purpose: Approved Travel Request form

Option Strict On

Public Class frmApprovedRequests

    Private Sub ApprovedTravelRequestsBindingNavigatorSaveItem_Click(sender As System.Object, e As System.EventArgs) Handles ApprovedTravelRequestsBindingNavigatorSaveItem.Click
        ' Click event is created by the database wizard

        Me.Validate()
        Me.ApprovedTravelRequestsBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.TravelRequestsDataSet)

    End Sub

    Private Sub frmApprovedRequests_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        ' Try/Catch block catches an exception caused by a missing database file

        Try
            'TODO: This line of code loads data into the 'TravelRequestsDataSet.ApprovedTravelRequests' table. You can move, or remove it, as needed.
            Me.ApprovedTravelRequestsTableAdapter.Fill(Me.TravelRequestsDataSet.ApprovedTravelRequests)
        Catch ex As Exception
            MsgBox("Could not establish a connection with the database. Please try again.", , "Database Error")
            Close()
        End Try

    End Sub
End Class
