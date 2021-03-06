﻿Option Strict On

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
            decAnswer = decFirstNum / decSecondNum
        Catch ex As DivideByZeroException
            MsgBox("Attempting to divide by 0. Not allowed.")
            txtNumOne.Clear()
            txtNumTwo.Clear()
            txtNumOne.Focus()
        Catch ex As OverflowException
            MsgBox("The number was too large.")
            txtNumOne.Clear()
            txtNumTwo.Clear()
            txtNumOne.Focus()
        Catch ex As FormatException
            MsgBox("The input was not a number. Please use a number.")
            txtNumOne.Clear()
            txtNumTwo.Clear()
            txtNumOne.Focus()
        Catch ex As Exception
            MsgBox("General exception has been handled. Please try again.")
            txtNumOne.Clear()
            txtNumTwo.Clear()
            txtNumOne.Focus()
        End Try

        ' Output
        lblOutput.Text = decAnswer.ToString()

    End Sub
End Class
