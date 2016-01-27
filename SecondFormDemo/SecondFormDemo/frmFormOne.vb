Public Class frmFormOne

    Public Shared _strName As String = "Michael V" ' These variables are shared across all objects within the application

    Private Sub btnShowNewForm_Click(sender As System.Object, e As System.EventArgs) Handles btnShowNewForm.Click
        Dim frmSecond As New frmFormTwo ' Declaring an reference variable and creating an frmFormTwo instance

        ' Hide() 'Hides current form

        ' Line below creats a modal form (retains the focus while open; cannot switch between form objects until the first form is closed)
        ' frmSecond.ShowDialog() ' ShowDialog function is being called on frmSecond reference

        frmSecond.Show() ' Creates a modeless form (allows both forms to be focused)

    End Sub

    Private Sub btnShowOutput_Click(sender As System.Object, e As System.EventArgs) Handles btnShowOutput.Click
        lblShowOutput.Text = "This is Form 1. My name is " + _strName

    End Sub
End Class
