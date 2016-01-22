' Michael Voell
' Campground Rates
' 1/22/2016
' Purpose: To calculate the cost of a stay at campgrounds under different conditions.

' --TODO--
' Subprocedure -> Type of Tent Cost * Amount of Nights Staying = Subtotal. Do not displaying amount (keep for next equation)
' Pass the subtotal + discount into a Function. Determine = Subtotal / Discount. Subtotal = Determine. Pass to calling method
' Another function should compute 7.5% tax. Total = Subtotal / 7.5%. TheTotal = Total + Subtotal. Pass back to calling method
' Pass all values to a sub procedure to displaying results.
' Subprocedure displays: Subtotal Billing Amount for your Stay, Taxes for your Stay, and Final Total
' Input values need a Try-Catch block

Option Strict On

Public Class frmCampgroundRates

    Private Sub frmCampgroundRates_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Threading.Thread.Sleep(5000)
    End Sub

    Private Sub btnCalculateCost_Click(sender As System.Object, e As System.EventArgs) Handles btnCalculateCost.Click
        ' Variables
        Dim decTentCost As Decimal
        Dim decNightsStaying As Decimal
        Dim decDiscount As Decimal

        decNightsStaying = CDec(txtNumberOfNights.Text)

        decTentCost = cboStayType.SelectedIndex
        Select Case decTentCost
            Case 0
                CalculateSubTotal(20, decNightsStaying)
            Case 1
                CalculateSubTotal(35, decNightsStaying)
            Case 2
                CalculateSubTotal(55, decNightsStaying)
        End Select

    End Sub

    Private Sub CalculateSubTotal(ByVal decTheTentCost As Decimal, ByVal decTheNightsStaying As Decimal)
        ' Variables
        Dim decSubTotal As Decimal

        ' Calculations
        decSubTotal = decTheTentCost * decTheNightsStaying

    End Sub
End Class
