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

    Private Sub btnTotalTravelCost_Click(sender As System.Object, e As System.EventArgs) Handles btnTotalTravelCost.Click
        ' strSQL is an SQL statemant that select all the fields from the table
        ' Selecting table from database
        Dim strSQL As String = "SELECT * FROM ApprovedTravelRequests"

        ' Connection to DB
        Dim strPath As String = "Provider=Microsoft.ACE.OLEDB.12.0 ;" _
                                & "Data Source=E:\Advanced VB\ApprovedTravelRequests\ApprovedTravelRequests\bin\Debug\TravelRequests.accdb"
        Dim odaTravel As New OleDb.OleDbDataAdapter(strSQL, strPath)

        ' Variables
        Dim datCost As New DataTable
        Dim intCount As Integer
        Dim decTotalCost As Decimal = 0D

        ' Fill the DataTable with data
        odaTravel.Fill(datCost)
        ' Disconnect from database
        odaTravel.Dispose()

        ' Doing the math to calculate the total cost
        For intCount = 0 To datCost.Rows.Count - 1
            decTotalCost += Convert.ToDecimal(datCost.Rows(intCount)("Travel Cost"))
        Next
        ' Displaying the total cost
        lblTotalCost.Text = "Trip Approved. Total Cost: " _
            & decTotalCost.ToString("C")

    End Sub
End Class
