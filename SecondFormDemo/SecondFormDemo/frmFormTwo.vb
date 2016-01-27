Public Class frmFormTwo

    Private Sub btnShowOutput_Click(sender As System.Object, e As System.EventArgs) Handles btnShowOutput.Click
        lblOutput.Text = "My name is " + frmFormOne._strName + " and this is Form 2."
    End Sub
End Class