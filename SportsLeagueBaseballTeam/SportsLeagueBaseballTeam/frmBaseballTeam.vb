' Michael Voell
' Sports League Baseball Team
' 2/25/2016
' Purpose: To show the information of a sports league and compare information.

' --TODO--
' Calculate the total average of all the ages
' Try/Catch statement to catch whether or not a connection to the database could be established

Option Strict On

Public Class frmBaseballTeam

    Private Sub TeamBindingNavigatorSaveItem_Click(sender As System.Object, e As System.EventArgs) Handles TeamBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.TeamBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.LittleleagueDataSet)

    End Sub

    Private Sub frmBaseballTeam_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'LittleleagueDataSet.Team' table. You can move, or remove it, as needed.
        Me.TeamTableAdapter.Fill(Me.LittleleagueDataSet.Team)

    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles btnCalculations.Click

        ' Select / Connecting to database
        Dim strSQL As String = "SELECT * FROM Team"
        Dim strPath As String = "Provider=Microsoft.ACE.OLEDB.12.0;" & "Data Source=E:\Advanced VB\SportsLeagueBaseballTeam\SportsLeagueBaseballTeam\littleleague.accdb"
        Dim odaSportsLeague As New OleDb.OleDbDataAdapter(strSQL, strPath)
        Dim datSportsLeagueFill As New DataTable
        odaSportsLeague.Fill(datSportsLeagueFill)
        odaSportsLeague.Dispose()

        'Calculations
        Dim intAge12 As Integer
        Dim intAge13 As Integer
        Dim intAge14 As Integer
        Dim intCount As Integer = 0
        Dim decAgeAverage As Decimal
        Dim decAverageTotal As Decimal

        ' Calculating Average Age
        For intCount = 0 To datSportsLeagueFill.Rows.Count - 1
            decAgeAverage = decAgeAverage + Convert.ToDecimal(datSportsLeagueFill.Rows(intCount)("Age"))
        Next

        ' Average Calculation
        decAverageTotal = decAgeAverage / datSportsLeagueFill.Rows.Count

        ' Outputting Average Age
        lblAverageAge.Visible = True
        lblAverageAge.Text = "Average Age: " & decAverageTotal.ToString("f2") & " Years"

    End Sub
End Class
