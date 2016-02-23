Option Strict On

Public Class frmPowerSchool

    Private Sub StudentInformationBindingNavigatorSaveItem_Click(sender As System.Object, e As System.EventArgs) Handles StudentInformationBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.StudentInformationBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.StudentInfoDataSet)

    End Sub

    Private Sub frmPowerSchool_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        ' TODO: This line of code loads data into the 'StudentInfoDataSet.StudentInformation' table. You can move, or remove it, as needed.
        Me.StudentInformationTableAdapter.Fill(Me.StudentInfoDataSet.StudentInformation)

    End Sub

    Private Sub btnShowAverage_Click(sender As System.Object, e As System.EventArgs) Handles btnShowAverage.Click
        ' Selecting StudentInformation table from database
        Dim strSql As String = "SELECT * FROM StudentInformation"

        ' Finding drivers for connection to database and finding access database file
        Dim strPath As String = "Provider=Microsoft.ACE.OLEDB.12.0;" & "Data Source=E:\Advanced VB\PowerSchool\PowerSchool\StudentInfo.accdb"

        ' Creating an instance of OldDBDataAdapter to connect to database, assigns it to variable odaStudent
        Dim odaStudent As New OleDb.OleDbDataAdapter(strSql, strPath)

        ' DataTable needed to hold information from database
        Dim datStudentInfo As New DataTable

        ' DataTable datStudentInfo filled with table data from database
        odaStudent.Fill(datStudentInfo)

        ' Closes connection from database
        odaStudent.Dispose()

        For intCount = 0 To datStudentInfo.Rows.Count - 1

        Next

    End Sub
End Class
