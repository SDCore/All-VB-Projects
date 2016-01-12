' Michael Voell
' Compare Gas Mileage
' 1/11/2016
' Purpose: To compute the difference in cost between the cost of gas for an SUV and a Compact Car.

' --TODO--
' Same function will be called twice to calculate the total fuel cost over the life for each car
' Display total cost over the life of each cat and the difference between them
' Validate input by using Try-Catch blocks

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

        strCostPerGallon = txtCostPerGallon.Text
        decCostPerGallon = Convert.ToDecimal(strCostPerGallon)
        strMilesTraveled = txtMilesTraveled.Text
        decMilesTraveled = Convert.ToDecimal(strMilesTraveled)
        strSUVMPG = txtSUVMPG.Text
        decSUVMPG = Convert.ToDecimal(strSUVMPG)
        strCompactMPG = txtCompactMPG.Text
        decCompactMPG = Convert.ToDecimal(strCompactMPG)

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


    End Sub

    Private Function CalculateGasCost(ByVal decCostPerGallon As Decimal, ByVal decMilesTraveled As Decimal) As Decimal
        ' The equation is: Gast Cost * ((Miles Per Year * Years Owned) / MPG)

    End Function
End Class
