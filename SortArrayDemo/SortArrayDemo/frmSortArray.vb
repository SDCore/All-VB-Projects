Public Class frmSortArray

    Private Sub btnShowOutput_Click(sender As System.Object, e As System.EventArgs) Handles btnShowOutput.Click
        Dim intNumbers() As Integer = {95, 45, 75}
        Dim strNames() As String = {"Michael", "Todd", "Ben"}

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

    End Sub
End Class
