' Michael Voell
' Compute Depreciation
' 1/29/2016
' Purpose: To calculate the depreciation of inventory items over time using information from a text file.

Option Strict On

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
        lblPresentYear.Visible = False
        lblPresentValue.Visible = False
        lblYearDepreciation.Visible = False
        lblTotalDepreciation.Visible = False
    End Sub

    Private Sub frmComputeDepreciation_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Dim objReader As IO.StreamReader
        Dim strFileLocation As String = "E:\Advanced VB\ComputeDepreciation\ComputeDepreciation\inventory.txt"
        Dim intCount As Integer
    End Sub
End Class
