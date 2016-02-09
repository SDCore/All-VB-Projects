' Michael Voell
' Projected Population Growth
' 2/8/2016
' Purpose: To determine the population growth of cities over the next 5 years

' --TODO--
' ComboBox (cboSelectCity) is populated from the text file, contains all 10 cities from text file
' User selects city from cboSelectCity, ListBox (lstPopulationGrowth) displays next 5 years of population growth based on 3% population growth
' File menu displays the "Display Present Population", "Clear", and "Exit" menu items.
'  When user selects "Display Present Population", a second form opens and siaplys the current 10 largest cities and their populations
' Comment everything

Option Strict On

Public Class frmProjectedPopulation

    Public Shared _intArraySize As Integer = 20
    Private _strCityNames(_intArraySize) As String

    Private Sub frmProjectedPopulation_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        ' Variables
        Dim objReader As IO.StreamReader
        Dim filePath As String = "E:\Advanced VB\ProjectedPopulationGrowth\ProjectedPopulationGrowth\cities.txt"
        Dim intCount As Integer = 0
        Dim intFill As Integer
        Dim strFileError As String = "File is not available. Please try again."
        Dim strFileErrorTitle As String = "File Error"

        ' Checking is file exists... and everything else
        If IO.File.Exists(filePath) Then
            objReader = IO.File.OpenText(filePath)
            Do While objReader.Peek <> -1
                _strCityNames(intCount) = objReader.ReadLine()
                intCount += 1
            Loop
            objReader.Close()

            ' Populate ComboBox with city names
            For intFill = 0 To (_strCityNames.Length - 1)
                If intFill Mod 2 = 0 Then
                    cboSelectCity.Items.Add(_strCityNames(intFill))
                End If
            Next
        Else
            MsgBox(strFileError, , strFileErrorTitle)
            Close()
        End If
    End Sub

    Private Sub cboSelectCity_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles cboSelectCity.SelectedIndexChanged
        ' Variables
        Dim intSelectedCity As Integer

        If cboSelectCity.SelectedIndex >= 0 Then
            intSelectedCity = cboSelectCity.SelectedIndex
        End If

        makeObjectsVisible()
    End Sub

    Private Sub DisplayPresentPopulationToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles DisplayPresentPopulationToolStripMenuItem.Click

    End Sub

    Private Sub ClearToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles ClearToolStripMenuItem.Click

    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles ExitToolStripMenuItem.Click
        Close()
    End Sub

    Private Sub makeObjectsVisible()
        lblExpectedGrowth.Visible = True
        lstPopulationGrowth.Visible = True
    End Sub

End Class
