﻿' Michael Voell
' Campground Rates
' 1/22/2016
' Purpose: To calculate the cost of a stay at campgrounds under different conditions.

Option Strict On

Public Class frmCampgroundRates

    Private Sub frmCampgroundRates_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Threading.Thread.Sleep(5000)
    End Sub

    Private Sub btnCalculateCost_Click(sender As System.Object, e As System.EventArgs) Handles btnCalculateCost.Click
        ' Variables
        Dim decTentCost As Decimal
        Dim decNightsStaying As Decimal

        ' Setting decNightsStaying to the appropriate text box
        Try
            decNightsStaying = CDec(txtNumberOfNights.Text)
        Catch ex As DivideByZeroException
            MsgBox("Cannot divide by 0")
            txtNumberOfNights.Clear()
            txtNumberOfNights.Focus()
        Catch ex As FormatException
            MsgBox("Inproper format. Please use only numbers.")
            txtNumberOfNights.Clear()
            txtNumberOfNights.Focus()
        Catch ex As Exception
            MsgBox("General exception caught.")
            txtNumberOfNights.Clear()
            txtNumberOfNights.Focus()
        End Try

        ' Getting choices from ComboBox and setting approriate function tags
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

        ' Getting choices from ComboBox and setting approriate function tags
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
        ' Variables
        Dim decDiscountedTotal As Decimal
        Dim decDiscounted As Decimal

        ' Calculations
        decDiscounted = decSubTotal * decDiscountAmount
        decDiscountedTotal = decSubTotal - decDiscounted

        ' MAKE THIS IN A SUBPROCEDURE
        lblDiscountOutput.Text = "Discount: -" & decDiscounted.ToString("C")

        ' More calculations, but in a different function
        FindTax(decDiscountedTotal, decSubTotal, decDiscounted)

        ' Returning decDiscountedTotal to original class
        Return decDiscountedTotal
    End Function

    Private Function FindTax(ByVal decDiscountedTotal As Decimal, ByVal decSubtotal As Decimal, ByVal decDiscounted As Decimal) As Decimal
        ' Tax: 7.5%

        ' Variables
        Dim decTaxes As Decimal
        Dim decTaxTotal As Decimal

        ' Calculations
        decTaxes = CDec(decDiscountedTotal / 0.75)
        decTaxTotal = decSubtotal - decTaxes

        ' Outputting to Label
        lblTaxes.Text = "Taxes: " & decTaxTotal.ToString("C")

        ' More calculations, but in a different function
        FindTotal(decDiscountedTotal, decTaxTotal, decSubtotal)

        ' Returning decTaxTotal to original class
        Return decTaxTotal

    End Function

    Private Function FindTotal(ByVal decDiscount As Decimal, ByVal decTax As Decimal, decSubTotal As Decimal) As Decimal
        ' Variables
        Dim decFinalTotal As Decimal
        Dim decFinalsFinal As Decimal

        ' Calculations
        Try
            decFinalTotal = decTax / decSubTotal
        Catch ex As DivideByZeroException
            MsgBox("Cannot divide by 0")
            txtNumberOfNights.Clear()
            txtNumberOfNights.Focus()
        Catch ex As FormatException
            MsgBox("Inproper format. Please use only numbers.")
            txtNumberOfNights.Clear()
            txtNumberOfNights.Focus()
        Catch ex As Exception
            MsgBox("General exception caught.")
            txtNumberOfNights.Clear()
            txtNumberOfNights.Focus()
        End Try
        decFinalsFinal = decFinalTotal + decSubTotal
        lblTotalOutput.Text = decFinalsFinal.ToString("C")

        ' Returning decFinalTotal to original class
        Return decFinalsFinal
    End Function

End Class
