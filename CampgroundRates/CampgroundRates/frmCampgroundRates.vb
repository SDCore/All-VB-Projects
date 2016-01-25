' Michael Voell
' Campground Rates
' 1/22/2016
' Purpose: To calculate the cost of a stay at campgrounds under different conditions.

' --TODO--
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
        Dim decDiscount As Decimal

        ' Calculations
        decSubTotal = decTheTentCost * decTheNightsStaying

        ' MAKE THIS IN A SUBPROCEDURE
        lblSubtotalOutput.Text = "SubTotal: " & decSubTotal.ToString("C")

        decDiscount = cboDiscount.SelectedIndex
        Select Case decDiscount
            Case 0
                FindDiscount(decSubTotal, 0)
            Case 1
                FindDiscount(decSubTotal, CDec(0.1))
            Case 2
                FindDiscount(decSubTotal, CDec(0.12))
        End Select

    End Sub

    Private Function FindDiscount(ByVal decSubTotal As Decimal, ByVal decDiscountAmount As Decimal) As Decimal
        Dim decDiscountedTotal As Decimal
        Dim decDiscounted As Decimal

        decDiscounted = decSubTotal * decDiscountAmount
        decDiscountedTotal = decSubTotal - decDiscounted

        ' MAKE THIS IN A SUBPROCEDURE
        lblDiscountOutput.Text = "Discount: -" & decDiscounted.ToString("C")

        FindTax(decDiscountedTotal, decSubTotal)

        Return decDiscountedTotal
    End Function

    Private Function FindTax(ByVal decDiscountedTotal As Decimal, ByVal decSubtotal As Decimal) As Decimal
        ' Tax: 7.5%

        ' Variables
        Dim decTaxes As Decimal
        Dim decTaxTotal As Decimal

        decTaxes = CDec(decDiscountedTotal / 0.75)

        decTaxTotal = decSubTotal - decTaxes

        lblTaxes.Text = "Taxes: " & decTaxTotal.ToString("C")

        Return decTaxTotal

    End Function

End Class
