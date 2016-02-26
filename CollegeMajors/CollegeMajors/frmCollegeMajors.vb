' Michael Voell
' College Majors
' 2/26/2016
' Purpose: To see the percentage of students in a specific major

' --TODO--
' Clicking Find Total button object to compute total number of students presently in majors
' User can select a college major from a combo box and it will display the percentage of students participating in said major

Option Strict On

Public Class frmCollegeMajors

    Private Sub CollegeMajorsBindingNavigatorSaveItem_Click(sender As System.Object, e As System.EventArgs) Handles CollegeMajorsBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.CollegeMajorsBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.CollegesDataSet)

    End Sub

    Private Sub frmCollegeMajors_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'CollegesDataSet.CollegeMajors' table. You can move, or remove it, as needed.
        Me.CollegeMajorsTableAdapter.Fill(Me.CollegesDataSet.CollegeMajors)

    End Sub
End Class
