' Michael Voell
' Galaxy Hotel
' 1/7/2016
' Purpose: To compute the occupancy rate of the Galaxy Hotel.

Option Strict On

Public Class frmGalaxyHotel

    Private Sub btwShowFloors_Click(sender As System.Object, e As System.EventArgs) Handles btwShowFloors.Click

        ' Declaring variables
        Dim strOccupied As String
        Dim strVacant As String
        Dim intOccFloors As Integer
        Dim intOccTotal As Integer
        Dim intVacFloors As Integer
        Dim intVacTotal As Integer
        Dim intTotal As Integer
        Dim decAverage As Decimal

        Dim intMaxFloors As Integer = 7

        For intFloor = 1 To intMaxFloors
            strOccupied = InputBox("How many rooms are occupied on floor " & intFloor & "?", "Floor " & intFloor & "", "")
            strVacant = InputBox("How man rooms are vacant on floor " & intFloor & "?", "Floor " & intFloor & "", "")

            If IsNumeric(strOccupied) = True Then
                intOccFloors = Convert.ToInt32(strOccupied)
                If intOccFloors >= 0 Then

                Else
                    MsgBox("Input must be positive numbers only", MsgBoxStyle.Exclamation, "Bad Input")
                    intFloor = intFloor - 1
                End If
            Else
                MsgBox("Input must be numbers only", MsgBoxStyle.Exclamation, "Bad Input")
                intFloor = intFloor - 1
            End If

            If IsNumeric(strVacant) = True Then
                intVacFloors = Convert.ToInt32(strVacant)
                If intVacFloors >= 0 Then

                Else
                    MsgBox("Input must be positive numbers only", MsgBoxStyle.Exclamation, "Bad Input")
                    intFloor = intFloor - 1
                End If
            Else
                MsgBox("Input must be numbers only", MsgBoxStyle.Exclamation, "Bad Input")
                intFloor = intFloor - 1
            End If

            lstFloors.Items.Add("Floor: " & intFloor & ". Occupied: " & intOccFloors)
            lstFloors.Items.Add("Floor: " & intFloor & ". Vacant: " & intVacFloors)

            intVacTotal += intVacFloors
            intOccTotal += intOccFloors
            intTotal = intVacFloors + intOccFloors + intTotal ' Accumulator
        Next

        ' Calculations
        decAverage = CDec(intOccTotal / intTotal)

        ' Output
        lblFloorAverageOutput.Text = FormatPercent(decAverage)
        lblTotalRoomsOutput.Text = intTotal.ToString()
        lblOccupiedRoomsOutput.Text = intOccTotal.ToString()
        lblVacantRoomsOutput.Text = intVacTotal.ToString()

    End Sub

    Private Sub lblFloorAverage_Click(sender As System.Object, e As System.EventArgs) Handles lblFloorAverage.Click

    End Sub
End Class
