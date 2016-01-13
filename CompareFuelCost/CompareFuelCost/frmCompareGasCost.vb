' Michael Voell
' Compare Gas Mileage
' 1/11/2016
' Purpose: To compute the difference in cost between the cost of gas for an SUV and a Compact Car.

' --TODO--

Option Strict On

Public Class frmCompareGasCost

    Private Sub Form1_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        ' Hold splash screen for 10 seconds
        Threading.Thread.Sleep(5000)
    End Sub

    Private Sub btnCalculateCost_Click(sender As System.Object, e As System.EventArgs) Handles btnCalculateCost.Click
        ' Variables
        Dim strCostPerGallon As String
        Dim decCostPerGallon As Decimal
        Dim strMilesTraveled As String
        Dim decMilesTraveled As Decimal
        Dim intYearsOwned As Integer
        Dim decYearsOwned As Decimal
        Dim strSUVMPG As String
        Dim decSUVMPG As Decimal
        Dim strCompactMPG As String
        Dim decCompactMPG As Decimal
        Dim decSUVCost As Decimal
        Dim decCompactCost As Decimal
        Dim decDifference As Decimal

        ' Get / Convert Info
        intYearsOwned = cboYearsOwned.SelectedIndex

        ' Catch Exceptions
        Try
            strCostPerGallon = txtCostPerGallon.Text
            decCostPerGallon = Convert.ToDecimal(strCostPerGallon)
            strMilesTraveled = txtMilesTraveled.Text
            decMilesTraveled = Convert.ToDecimal(strMilesTraveled)
            strSUVMPG = txtSUVMPG.Text
            decSUVMPG = Convert.ToDecimal(strSUVMPG)
            strCompactMPG = txtCompactMPG.Text
            decCompactMPG = Convert.ToDecimal(strCompactMPG)
        Catch ex As DivideByZeroException
            MsgBox("Attempting to divide by 0. Not allowed.")
        Catch ex As OverflowException
            MsgBox("Overflow: Number too large. Not allowed.")
        Catch ex As FormatException
            MsgBox("Input was not a number. Not allowed.")
        Catch ex As Exception
            MsgBox("General exception handled: Please see output for logs. Not allowed.")
        End Try

        ' Case Info
        Select Case intYearsOwned
            Case 0
                decYearsOwned = 1
            Case 1
                decYearsOwned = 2
            Case 2
                decYearsOwned = 3
            Case 3
                decYearsOwned = 4
            Case 4
                decYearsOwned = 5
            Case 5
                decYearsOwned = 6
            Case 6
                decYearsOwned = 7
            Case 7
                decYearsOwned = 8
            Case 8
                decYearsOwned = 9
            Case 9
                decYearsOwned = 10
        End Select

        decSUVCost = CalculateGasCost(decCostPerGallon, decMilesTraveled, decYearsOwned, decSUVMPG)
        lblSUVCostOutput.Text = decSUVCost.ToString("C")

        decCompactCost = CalculateGasCost(decCostPerGallon, decMilesTraveled, decYearsOwned, decCompactMPG)
        lblCompactCarCostOutput.Text = decCompactCost.ToString("C")

        decDifference = decSUVCost - decCompactCost
        lblDifferenceOutput.Text = decDifference.ToString("C")

    End Sub

    Private Function CalculateGasCost(ByVal decCostPerGallon As Decimal, ByVal decMilesTraveled As Decimal, ByVal decYearsOwned As Decimal, decMPGOUT As Decimal) As Decimal
        ' The equation is: Gas Cost * ((Miles Per Year * Years Owned) / MPG)
        Dim decTotal As Decimal

        ' Catching more exceptions just in case they aren't caught in the initial convertion
        Try
            decTotal = decCostPerGallon * ((decMilesTraveled * decYearsOwned) / decMPGOUT)
        Catch ex As DivideByZeroException
            MsgBox("Attempting to divide by 0. Not allowed.")
        Catch ex As OverflowException
            MsgBox("Overflow: Number too large. Not allowed.")
        Catch ex As FormatException
            MsgBox("Input was not a number. Not allowed.")
        Catch ex As Exception
            MsgBox("General exception handled: Please see output for logs. Not allowed.")
        End Try

        ' Return decTotal to the original Sub for use in the calculation
        Return decTotal

    End Function
End Class
