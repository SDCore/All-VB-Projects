' Michael Voell
' Baseball Ticket Sales
' 1/19/2016
' Purpose: Compute the cost of baseball tickets depending on what the user chooses using sub procedures.

' --TODO--
' User selects item from Ticket Type combo box, nothing else is shown until something is chosen
' User enters amount of tickets in textbox
' User selects seat type in textbox
' One of two functions will be called depending on seat/ticket type
' Clear Form button
' Try-Catch block to validate input
' Comment everything

Option Strict On

Public Class frmBaseballTicketSales

    ' Class Variables


    Private Sub frmBaseballTicketSales_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Threading.Thread.Sleep(5000)
    End Sub

    Private Sub cboTicketType_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles cboTicketType.SelectedIndexChanged
        Dim intTicketType As Integer

        ' Getting Case Information
        intTicketType = cboTicketType.SelectedIndex
        Select Case intTicketType
            Case 0
                SeasonTickets()
                MakeVisible()
            Case 1
                SingleTickets()
                MakeVisible()
        End Select

    End Sub

    Private Sub btnComputeCost_Click(sender As System.Object, e As System.EventArgs) Handles btnComputeCost.Click
        ' Variables
        Dim intAmountOfTickets As Integer
        Dim intTicketCost As Integer
        Dim intSeatCost As Integer
        Dim intCostTotal As Integer

        intAmountOfTickets = CInt(txtNumberOfTickets.Text)
        intSeatCost = cboSeatType.SelectedIndex

        Select Case intSeatCost
            Case 0
                intTicketCost = CInt(FindTicketAmount(55, intAmountOfTickets))
                lblTotalCost.Visible = True
                lblTotalCost.Text = "The total cost will be: " & intTicketCost.ToString("C")
            Case 1
                intTicketCost = CInt(FindTicketAmount(35, intAmountOfTickets))
                lblTotalCost.Visible = True
                lblTotalCost.Text = "The total cost will be: " & intTicketCost.ToString("C")
            Case 2
                intTicketCost = CInt(FindTicketAmount(25, intAmountOfTickets))
                lblTotalCost.Visible = True
                lblTotalCost.Text = "The total cost will be: " & intTicketCost.ToString("C")
            Case 3
                intTicketCost = CInt(FindTicketAmount(15, intAmountOfTickets))
                lblTotalCost.Visible = True
                lblTotalCost.Text = "The total cost will be: " & intTicketCost.ToString("C")
        End Select

    End Sub

    Private Sub SeasonTickets()
        cboSeatType.Items.Clear()
        cboSeatType.Text = "Select an Item"
        cboSeatType.Items.Add("Box Seats - $2500")
        cboSeatType.Items.Add("Lower Deck - $1500")
    End Sub

    Private Sub SingleTickets()
        cboSeatType.Items.Clear()
        cboSeatType.Text = "Select an Item"
        cboSeatType.Items.Add("Box Seats - $55")
        cboSeatType.Items.Add("Lower Deck - $35")
        cboSeatType.Items.Add("Upper Deck - $25")
        cboSeatType.Items.Add("Standing Room Only - $15")
    End Sub

    Private Sub MakeVisible()
        lblNumberOfTickets.Visible = True
        txtNumberOfTickets.Visible = True
        lblSeatType.Visible = True
        cboSeatType.Visible = True
        btnComputeCost.Visible = True
        btnClear.Visible = True
    End Sub

    Private Function FindTicketAmount(ByVal intTicketAmount As Decimal, ByVal intNumberOfTickets As Decimal) As Decimal
        ' Variables
        Dim strTotal As Decimal
        Dim intCostTotal As Integer

        intCostTotal = CInt(intTicketAmount * intNumberOfTickets)

        Return intCostTotal

    End Function

End Class
