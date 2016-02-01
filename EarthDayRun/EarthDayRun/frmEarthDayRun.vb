' Michael Voell
' Earth Day Run
' 2/1/2016
' Purpose: To determine the total contributions recieved by the fund raising runners at the Earth Day 5K Run.

' --TODO--
' Displays Title and Earth Day Logo
' Application opens a text file named earthdayrun.txt
' Program assigns the text file contents to three arrays that hold the runner's name, age, and amount of funds raised (Has a total of 22 elements)
' When Calculate button is pressed, program computes the total of runners added to the text file, average age of runners, and total funds raised
' Program displays names of runners in sorted alphabetical order and their ages
' File Menu with Clear and Exit displayed, clearing the form and exiting the form respectively

Public Class frmEarthDayRun

    Private Sub btnComputeFunds_Click(sender As System.Object, e As System.EventArgs) Handles btnComputeFunds.Click

    End Sub

    Private Sub ClearToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles ClearToolStripMenuItem.Click

    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles ExitToolStripMenuItem.Click
        Close()
    End Sub
End Class
