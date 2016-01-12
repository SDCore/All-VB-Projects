Option Strict On

Public Class frmPizzaOrder

    Private Sub frmPizzaOrder_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        ' Hold splash screen for 10 seconds
        Threading.Thread.Sleep(2000)
    End Sub

    Private Sub btnSubmit_Click(sender As System.Object, e As System.EventArgs) Handles btnSubmit.Click
        ' Declaring Variables
        Dim intSizeSelected As Integer
        Dim intQuantity As Integer
        Dim strQuantity As String
        Dim decSizePrice As Decimal
        Dim decOrderTotal As Decimal

        ' Get Information & Convert
        intSizeSelected = cboSize.SelectedIndex
        strQuantity = txtQuantity.Text
        intQuantity = Convert.ToInt32(strQuantity)

        Select Case intSizeSelected
            Case 0
                decSizePrice = 8
            Case 1
                decSizePrice = 10
            Case 2
                decSizePrice = 12
        End Select

        ' Calculations
        decOrderTotal = CalculateOrderTotal(decSizePrice, intQuantity)

        ' Output
        lblOutput.Text = decOrderTotal.ToString("C")

    End Sub

    Private Function CalculateOrderTotal(ByVal decSizeCost As Decimal, ByVal intQuantity As Integer) As Decimal ' The last part is the return type
        Dim decTotal As Decimal

        decTotal = decSizeCost * intQuantity

        Return decTotal

    End Function

End Class
