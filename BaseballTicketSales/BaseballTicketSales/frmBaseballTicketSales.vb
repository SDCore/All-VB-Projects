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
    Private _intClearLabel As String = "Total cost for tickets: $0.00"

    Private Sub frmBaseballTicketSales_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Threading.Thread.Sleep(5000)
    End Sub

    Private Sub btnClear_Click(sender As System.Object, e As System.EventArgs) Handles btnClear.Click
        lblNumberOfTickets.Visible = False
        txtNumberOfTickets.Visible = False
        txtNumberOfTickets.Clear()
        lblSeatType.Visible = False
        cboSeatType.Visible = False
        btnComputeCost.Visible = False
        btnClear.Visible = False
        lblTotalCost.Visible = False
        lblTotalCost.Text = _intClearLabel
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
        Dim intTicketType As Integer

        intAmountOfTickets = CInt(txtNumberOfTickets.Text)
        intSeatCost = cboSeatType.SelectedIndex
        intTicketType = cboTicketType.SelectedIndex

        Select Case intTicketType
            Case 0
                Select Case intSeatCost
                    Case 0
                        intTicketCost = CInt(FindTicketCost(2500, intAmountOfTickets))
                        lblTotalCost.Visible = True
                        lblTotalCost.Text = "Season Ticket Cost: " & intTicketCost.ToString("C")
                    Case 1
                        intTicketCost = CInt(FindTicketCost(1500, intAmountOfTickets))
                        lblTotalCost.Visible = True
                        lblTotalCost.Text = "Season Ticket Cost: " & intTicketCost.ToString("C")
                End Select
            Case 1
                Select Case intSeatCost
                    Case 0
                        intTicketCost = CInt(FindTicketCost(55, intAmountOfTickets))
                        lblTotalCost.Visible = True
                        lblTotalCost.Text = "Single Ticket Cost: " & intTicketCost.ToString("C")
                    Case 1
                        intTicketCost = CInt(FindTicketCost(35, intAmountOfTickets))
                        lblTotalCost.Visible = True
                        lblTotalCost.Text = "Single Ticket Cost: " & intTicketCost.ToString("C")
                    Case 2
                        intTicketCost = CInt(FindTicketCost(25, intAmountOfTickets))
                        lblTotalCost.Visible = True
                        lblTotalCost.Text = "Single Ticket Cost: " & intTicketCost.ToString("C")
                    Case 3
                        intTicketCost = CInt(FindTicketCost(15, intAmountOfTickets))
                        lblTotalCost.Visible = True
                        lblTotalCost.Text = "Single Ticket Cost: " & intTicketCost.ToString("C")
                End Select
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

    Private Function FindTicketCost(ByVal intTicketAmount As Integer, ByVal intNumberOfTickets As Integer) As Decimal
        ' Variables
        Dim intCostTotal As Integer

        intCostTotal = intTicketAmount * intNumberOfTickets

        Return intCostTotal

    End Function

End Class
