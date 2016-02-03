' Michael Voell
' Earth Day Run
' 2/1/2016
' Purpose: To determine the total contributions recieved by the fund raising runners at the Earth Day 5K Run.

' --TODO--
' Program assigns the text file contents to three arrays that hold the runner's name, age, and amount of funds raised (Has a total of 22 elements)
' When Calculate button is pressed, program computes the total of runners added to the text file, average age of runners, and total funds raised
' Program displays names of runners in sorted alphabetical order and their ages

Option Strict On

Imports System.IO

Public Class frmEarthDayRun

    Private Sub btnComputeFunds_Click(sender As System.Object, e As System.EventArgs) Handles btnComputeFunds.Click
        ' Variables
        Dim intCount As Integer = 0
        Dim filePath = "E:\Advanced VB\EarthDayRun\EarthDayRun\earthdayrun.txt"

        ' Checking to see if file exists
        If IO.File.Exists(filePath) Then
            Using reader As New StreamReader(filePath)
                Do Until reader.EndOfStream
                    Dim line = reader.ReadLine()
                    intCount += 1
                    If intCount Mod 3 = 1 Then
                        lstRunners.Sorted = True
                        lstRunners.Items.Add(line)
                        lblRunnerCountOutput.Text = lstRunners.Items.Count.ToString()
                    End If
                Loop
            End Using
        Else
            ' Displaying an error if the file cannot be found
            MsgBox("File is not available.")
            Close()
        End If

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
