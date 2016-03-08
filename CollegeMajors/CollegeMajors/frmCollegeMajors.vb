' Michael Voell
' College Majors
' 2/26/2016
' Purpose: To see the percentage of students in a specific major

' --TODO--
' Think of more things to do

Option Strict On

Public Class frmCollegeMajors

    Private Sub CollegeMajorsBindingNavigatorSaveItem_Click(sender As System.Object, e As System.EventArgs) Handles CollegeMajorsBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.CollegeMajorsBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.CollegesDataSet)

    End Sub

    Private Sub frmCollegeMajors_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'CollegesDataSet.CollegeMajors' table. You can move, or remove it, as needed.

        Try
            Me.CollegeMajorsTableAdapter.Fill(Me.CollegesDataSet.CollegeMajors)
        Catch ex As Exception
            MsgBox("Cannot connect to database. Please try again.", , "Database Connection Error")
        End Try

    End Sub

    Private Sub btnFindTotal_Click(sender As System.Object, e As System.EventArgs) Handles btnFindTotal.Click

        ' Database Connection
        Dim strSql As String = "SELECT * FROM CollegeMajors"
        Dim strPath As String = "Provider=Microsoft.ACE.OLEDB.12.0;" & "Data Source=E:\Advanced VB\CollegeMajors\CollegeMajors\colleges.accdb"

        Dim odaColleges As New OleDb.OleDbDataAdapter(strSql, strPath)
        Dim datCollegeInfo As New DataTable

        odaColleges.Fill(datCollegeInfo)

        odaColleges.Dispose()

        ' Calculation Variables
        Dim decTotal As Decimal

        ' Counting number of students in all majors
        For intCount = 0 To datCollegeInfo.Rows.Count - 1
            decTotal = decTotal + Convert.ToDecimal(datCollegeInfo.Rows(intCount)("Number in Degree"))
        Next

        ' Displaying number of students in all majors
        lblTotalStudents.Text = "Total Amount of Students in Majors: " & decTotal.ToString()

        ' Getting selected item from Combo Box
        Dim intDegreeRow As Integer = DegreeComboBox.SelectedIndex

        ' Calculation variables
        Dim decStudentsInMajor As Decimal
        Dim decPercentage As Decimal
        Dim strSelectedMajor As String

        ' Getting the amount in the selected major and the name of the selected major (from combobox selection)
        decStudentsInMajor = CDec(datCollegeInfo.Rows(intDegreeRow)("Number in Degree"))
        strSelectedMajor = CStr(datCollegeInfo.Rows(intDegreeRow)("Degree"))

        ' Calculating percentage in the selected major
        decPercentage = decStudentsInMajor / decTotal

        ' Outputting the percentage to "Percentage of Students in ______: 00%" label
        lblStudentsInSelectedMajor.Text = "Percentage of Students in " & strSelectedMajor & ": " & decPercentage.ToString("P")

    End Sub
End Class
