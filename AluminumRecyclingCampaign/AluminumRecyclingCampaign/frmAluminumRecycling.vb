Public Class frmAluminumRecycling

    Private Sub btnClear_Click(sender As System.Object, e As System.EventArgs) Handles btnClear.Click
        cboRecyclingNeed.Text = "Select an Item"
        txtAmount.Text = ""
        lblOutput.Text = "0,000 cans need to be collected to reach your goal"
    End Sub

    Private Sub btnCalculate_Click(sender As System.Object, e As System.EventArgs) Handles btnCalculate.Click

    End Sub
End Class
