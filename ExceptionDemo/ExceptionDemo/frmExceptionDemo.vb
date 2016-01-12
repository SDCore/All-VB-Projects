Option Strict On

Public Class frmExceptionDemo

    Private Sub btnShowOutput_Click(sender As System.Object, e As System.EventArgs) Handles btnShowOutput.Click
        ' Variables
        Dim decFirstNum As Decimal
        Dim decSecondNum As Decimal
        Dim decAnswer As Decimal

        ' Get and convert
        Try
            decFirstNum = Convert.ToDecimal(txtNumOne.Text)
            decSecondNum = Convert.ToDecimal(txtNumTwo.Text)
        Catch ex As OverflowException
            MsgBox("The number was too large.")
        End Try

        ' Computations
        Try
            decAnswer = decFirstNum / decSecondNum
        Catch ex As DivideByZeroException
            MsgBox("Attempting to divide by 0. Not allowed.")
        End Try

        ' Output
        lblOutput.Text = decAnswer.ToString()

    End Sub
End Class
