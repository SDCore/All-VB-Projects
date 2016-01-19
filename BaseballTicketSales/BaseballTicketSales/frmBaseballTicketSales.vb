' Michael Voell
' Baseball Ticket Sales
' 1/19/2016
' Purpose: Compute the cost of baseball tickets depending on what the user chooses using sub procedures.

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

End Class
