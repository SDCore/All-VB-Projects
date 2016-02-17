' Michael Voell
' Compute Depreciation
' 1/29/2016
' Purpose: To calculate the depreciation of inventory items over time using information from a text file.

Option Strict On

Public Class frmComputeDepreciation

    Private _intLifeOfItems As Integer = 5
    Public Shared _intSizeOfArray As Integer = 7
    Public Shared _strInventoryItem(_intSizeOfArray) As String
    Private _strItemId(_intSizeOfArray) As String
    Private _decInitialPrice(_intSizeOfArray) As Decimal
    Private _intQuantity(_intSizeOfArray) As Integer

    Private Sub frmComputeDepreciation_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Dim objReader As IO.StreamReader
        Dim strFileLocation As String = "E:\Advanced VB\ComputeDepreciation\ComputeDepreciation\inventory.txt"
        Dim intCount As Integer = 0
        Dim intFill As Integer

        If IO.File.Exists(strFileLocation) Then
            objReader = IO.File.OpenText(strFileLocation)
            Do While objReader.Peek <> -1
                _strInventoryItem(intCount) = objReader.ReadLine()
                _strItemId(intCount) = objReader.ReadLine()
                intCount += 1
            Loop
            objReader.Close()

            For intFill = 0 To (_strItemId.Length - 1)
                cboInventoryItem.Items.Add(_strItemId(intFill))
            Next
        End If

    End Sub

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
End Class
