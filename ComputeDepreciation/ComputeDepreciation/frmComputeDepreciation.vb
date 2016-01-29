Public Class frmComputeDepreciation

    Private Sub ExitToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles ExitToolStripMenuItem.Click
        Close()
    End Sub

    Private Sub ClearToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles ClearToolStripMenuItem.Click
        cboInventoryItem.Text = "Select an Item"
        rdoStraightLine.Checked = False
        rdoDoubleBalance.Checked = False
    End Sub
End Class
