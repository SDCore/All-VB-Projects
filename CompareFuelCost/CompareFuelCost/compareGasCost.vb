' Michael Voell
' Compare Gas Mileage
' 1/11/2016
' Purpose: To compute the difference in cost between the cost of gas for an SUV and a Compact Car.

' --TODO--
' Same function will be called twice to calculate the total fuel cost over the life for each car
' Display total cost over the life of each cat and the difference between them
' Validate input by using Try-Catch blocks

Option Strict On

Public Class compareGasCost

    Private Sub Form1_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        ' Hold splash screen for 10 seconds
        Threading.Thread.Sleep(5000)
    End Sub

    Private Sub btnCalculateCost_Click(sender As System.Object, e As System.EventArgs) Handles btnCalculateCost.Click
        ' Variables
        Dim decCostPerGallon As Decimal
        Dim intMilesTraveled As Integer
        Dim intVehiclesOwner As Integer
        Dim decSUVMPG As Decimal
        Dim decCompactMPG As Decimal

    End Sub
End Class
