' Michael Voell
' Earth Day Run
' 2/1/2016
' Purpose: To determine the total contributions recieved by the fund raising runners at the Earth Day 5K Run.

' --TODO--
' Application opens a text file named earthdayrun.txt
' Program assigns the text file contents to three arrays that hold the runner's name, age, and amount of funds raised (Has a total of 22 elements)
' When Calculate button is pressed, program computes the total of runners added to the text file, average age of runners, and total funds raised
' Program displays names of runners in sorted alphabetical order and their ages

Option Strict On

Public Class frmEarthDayRun

    Private Sub btnComputeFunds_Click(sender As System.Object, e As System.EventArgs) Handles btnComputeFunds.Click
        Dim objReader As IO.StreamReader

        If IO.File.Exists("E:\Advanced VB\EarthDayRun\EarthDayRun\earthdayrun.txt") Then
            objReader = IO.File.OpenText("E:\Advanced VB\EarthDayRun\EarthDayRun\earthdayrun.txt")
            Do While objReader.Peek <> -1
                lstRunners.Items.Add(objReader.ReadLine())
            Loop

        Else
            MsgBox("File is not available. Please re-run program when it is available.")
            Close()
        End If

        objReader.Close()

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
