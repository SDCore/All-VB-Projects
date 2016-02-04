Option Strict On

Public Class frmSortArray

    Private Sub btnShowOutput_Click(sender As System.Object, e As System.EventArgs) Handles btnShowOutput.Click
        Dim intNumbers() As Integer = {95, 45, 75}
        Dim strNames() As String = {"Michael", "Todd", "Ben"}
        Dim intValue As Integer
        Dim intNumberTofind As Integer = 45

        ' Sorts a 1D array
        Array.Sort(intNumbers)
        Array.Sort(strNames)

        ' For each loop
        For Each intNum In intNumbers
            lstOutput.Items.Add(intNum)
        Next

        For Each strWord In strNames
            lstOutput.Items.Add(strWord)
        Next

        ' BinarySearch
        intValue = Array.BinarySearch(intNumbers, intNumberTofind)
        lblOutput.Text = intValue.ToString()

        If intValue >= 0 Then
            lblOutput.Text = "The number " & intNumberTofind & " was found at index position " & intValue
        Else
            lblOutput.Text = "The number " & intNumberTofind & " was NOT found"
        End If

    End Sub

    Private Sub mnuFileClear_Click(sender As System.Object, e As System.EventArgs) Handles mnuFileClear.Click
        lstOutput.Items.Clear()
    End Sub

    Private Sub mnuFileExit_Click(sender As System.Object, e As System.EventArgs) Handles mnuFileExit.Click
        Close()
    End Sub
End Class
