' Michael Voell
' Campground Rates
' 1/22/2016
' Purpose: To calculate the cost of a stay at campgrounds under different conditions.

' --TODO--
' Combobox -> Requests type of tent -> Tent: $20/night, RV: $35/night, Cabin: $55/night
' Textbox -> Number of nights staying
' Combobox -> AAA (10% discount) or Military (12% discount)
' Subprocedure displays: Subtotal Billing Amount for your Stay, Taxes for your Stay, and Final Total
' Subprocedure -> Type of Tent Cost * Amount of Nights Staying = Subtotal. Do not displaying amount (keep for next equation)
' Pass the subtotal + discount into a Function. Determine = Subtotal / Discount. Subtotal = Determine. Pass to calling method
' Another function should compute 7.5% tax. Total = Subtotal / 7.5%. TheTotal = Total + Subtotal. Pass back to calling method
' Pass all values to a sub procedure to displaying results.
' Input values need a Try-Catch block

Option Strict On

Public Class frmCampgroundRates

    Private Sub frmCampgroundRates_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Threading.Thread.Sleep(5000)
    End Sub
End Class
