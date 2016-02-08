' Michael Voell
' Earth Day Run
' 2/1/2016
' Purpose: To determine the total contributions recieved by the fund raising runners at the Earth Day 5K Run.

' --TODO--
' When Calculate button is pressed, program computes the total funds raised

Option Strict On

Imports System.IO

Public Class frmEarthDayRun

    Private Sub btnComputeFunds_Click(sender As System.Object, e As System.EventArgs) Handles btnComputeFunds.Click

    End Sub

    Private Sub ClearToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles ClearToolStripMenuItem.Click
        lstRunners.Items.Clear()
        lblRunnerCountOutput.Text = "00"
        lblAverageAgesOutput.Text = "00"
        lblTotalFundsOutput.Text = "$0,000.00"
    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles ExitToolStripMenuItem.Click
        Close()
    End Sub

End Class
