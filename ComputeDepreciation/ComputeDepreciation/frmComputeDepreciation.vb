Public Class frmComputeDepreciation

    Private Sub ExitToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles ExitToolStripMenuItem.Click
        Close()
    End Sub

    Private Sub ClearToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles ClearToolStripMenuItem.Click
        cboInventoryItem.Text = "Select an Item"
        rdoStraightLine.Checked = False
        rdoDoubleBalance.Checked = False
        lblItemOutput.Visible = False
        lblItemOutput.Text = "Depreciation of Item: ITEMNAME"
        lblQuantityOutput.Visible = False
        lblQuantityOutput.Text = "Quantity: 0"
        lstPresentYear.Items.Clear()
        lstPresentYear.Visible = False
        lstPresentValue.Items.Clear()
        lstPresentValue.Visible = False
        lstYearDepreciation.Items.Clear()
        lstYearDepreciation.Visible = False
        lstTotalDepreciation.Items.Clear()
        lstTotalDepreciation.Visible = False
    End Sub
End Class
