Public Class frmMain
    Private Const seatCount As Integer = 8
    Private seatButtons(seatCount - 1) As RadioButton
    Private seatOpen(seatCount - 1) As Boolean
    Private selectedSeat As Integer = -1

    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles Me.Load
        seatButtons(0) = rdo1A
        seatButtons(1) = rdo1B
        seatButtons(2) = rdo2A
        seatButtons(3) = rdo2B
        seatButtons(4) = rdo3A
        seatButtons(5) = rdo3B
        seatButtons(6) = rdo4A
        seatButtons(7) = rdo4B
        For i As Integer = 0 To seatCount - 1
            seatOpen(i) = True
        Next
    End Sub
    Private Sub Seat_CheckedChanged(sender As Object, e As EventArgs)
        'For i As Integer = 0 To seatCount - 1
        '    If sender Is seatButtons(i) AndAlso seatButtons(i).Checked Then
        '        selectedSeat = i
        '        Exit For
        '    End If
        'Next
    End Sub


    Private Sub btnConfirm_Click(sender As Object, e As EventArgs) Handles btnConfirm.Click
        If String.IsNullOrWhiteSpace(txtPassName.Text) Then
            MessageBox.Show("Please enter a passenger name.")
            txtPassName.Focus()
            Return
        End If
        If selectedSeat = -1 Then
            MessageBox.Show("Please select a seat.")
            Return
        End If
        'If Not seatOpen(selectedSeat) Then
        '    MessageBox.Show("Seat is already reserved. Please select another seat.")
        '    Return
        'End If
        seatOpen(selectedSeat) = False
        seatButtons(selectedSeat).Enabled = False
        seatButtons(selectedSeat).Text = "Reserved"
    End Sub

    Private Sub btnNextPass_Click(sender As Object, e As EventArgs) Handles btnNextPass.Click
        txtPassName.Clear()
        txtPassName.Focus()
    End Sub
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Application.Exit()
    End Sub

    Private Sub rdo1A_CheckedChanged(sender As Object, e As EventArgs) Handles rdo1A.CheckedChanged, rdo1B.CheckedChanged, rdo2A.CheckedChanged, rdo2B.CheckedChanged, rdo3A.CheckedChanged, rdo3B.CheckedChanged, rdo4A.CheckedChanged, rdo4B.CheckedChanged
        For i As Integer = 0 To seatCount - 1
            If sender Is seatButtons(i) AndAlso seatButtons(i).Checked Then
                selectedSeat = i
                Exit For
            End If
        Next
    End Sub
End Class
