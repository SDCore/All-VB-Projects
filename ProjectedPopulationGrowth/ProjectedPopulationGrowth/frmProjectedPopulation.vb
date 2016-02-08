' Michael Voell
' Projected Population Growth
' 2/8/2016
' Purpose: To determine the population growth of cities over the next 5 years

' --TODO--
' ComboBox (cboSelectCity) is populated from the text file, contains all 10 cities from text file
' User selects city from cboSelectCity, ListBox (lstPopulationGrowth) displays next 5 years of population growth based on 3% population growth
' File menu displays the "Display Present Population", "Clear", and "Exit" menu items.
'  When user selects "Display Present Population", a second form opens and siaplys the current 10 largest cities and their populations

Public Class frmProjectedPopulation

    Private Sub cboSelectCity_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles cboSelectCity.SelectedIndexChanged

    End Sub

    Private Sub DisplayPresentPopulationToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles DisplayPresentPopulationToolStripMenuItem.Click

    End Sub

    Private Sub ClearToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles ClearToolStripMenuItem.Click

    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles ExitToolStripMenuItem.Click
        Close()
    End Sub
End Class
