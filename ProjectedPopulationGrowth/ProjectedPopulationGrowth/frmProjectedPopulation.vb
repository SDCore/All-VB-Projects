' Michael Voell
' Projected Population Growth
' 2/8/2016
' Purpose: To determine the population growth of cities over the next 5 years

' --TODO--
' File menu displays the "Display Present Population", "Clear", and "Exit" menu items.
'  When user selects "Display Present Population", a second form opens and siaplys the current 10 largest cities and their populations
' Comment everything

Option Strict On

Public Class frmProjectedPopulation

    Public Shared _intArraySize As Integer = 20
    Private _strCityNames(_intArraySize) As String
    Private _strCityPop(_intArraySize) As String

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
        Dim objReader As IO.StreamReader
        Dim filePath As String = "E:\Advanced VB\ProjectedPopulationGrowth\ProjectedPopulationGrowth\cities.txt"
        Dim intCount As Integer = 0
        Dim intCount2 As Integer = 0
        Dim strFileError As String = "File is not available. Please try again."
        Dim strFileErrorTitle As String = "File Error"
        Dim intCityPop As Integer

        Dim strDetroit As String = "Detroit"

        ' Checking is file exists... and everything else
        If IO.File.Exists(filePath) Then
            objReader = IO.File.OpenText(filePath)
            Do While objReader.Peek <> -1
                _strCityNames(intCount) = objReader.ReadLine()
                intCount += 1
                Array.Sort(_strCityNames)
            Loop
            objReader.Close()

            While intCount2 > 0 And intCount2 < 9
                If CDbl(cboSelectCity.Text) = CDbl(strDetroit) Then
                    intCityPop = 925051
                    While intCount2 < 4
                        lstPopulationGrowth.Items.Add(intCityPop * 0.03)
                    End While
                ElseIf CDbl(cboSelectCity.Text) = CDbl("San Antonio") Then
                    intCityPop = CInt(_strCityNames(1))
                    lstPopulationGrowth.Items.Add(intCityPop.ToString())
                End If
            End While

        Else
            MsgBox(strFileError, , strFileErrorTitle)
            Close()
        End If

        ' Making the ExpectedGrowth label and Population Growth listbox visible when an object is selected
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
