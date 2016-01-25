Public Class frmArrayDemo

    Private Sub btnShowOutput_Click(sender As System.Object, e As System.EventArgs) Handles btnShowOutput.Click
        'Declaring a 1D Array called strNames as a string
        ' Anything after the = is an array initializer

        ' Variables
        ' Dim strNames() As String = {"Bob", "Tim", "Jon", "Pat", "Tom", "Amy", "Joe", "Tad", "Mac", "Max"}

        ' Output
        ' lblOutput.Text = "The name in index position 3 is: " + strNames(3)

        Dim strNames(9) As String 'Declared an array as a string
        strNames(0) = "Bub"
        strNames(1) = "Tam"
        strNames(2) = "Jin"
        strNames(3) = "Put"
        lblOutput.Text = "The name in index position 2 is: " + strNames(2)

    End Sub
End Class
