Public Class frmPowerSchool

    Private Sub StudentInformationBindingNavigatorSaveItem_Click(sender As System.Object, e As System.EventArgs) Handles StudentInformationBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.StudentInformationBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.StudentInfoDataSet)

    End Sub

    Private Sub frmPowerSchool_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'StudentInfoDataSet.StudentInformation' table. You can move, or remove it, as needed.
        Me.StudentInformationTableAdapter.Fill(Me.StudentInfoDataSet.StudentInformation)

    End Sub
End Class
