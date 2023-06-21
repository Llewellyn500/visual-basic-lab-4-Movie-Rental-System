Public Class Form1
    ' Variables to store rental information
    Private totalCustomers As Integer
    Private totalRentalAmount As Decimal

    Private Sub CalculateBtn_Click(sender As Object, e As EventArgs) Handles CalculateBtn.Click
        ' Check for missing data
        If String.IsNullOrEmpty(MovieTitleTextBox.Text) OrElse (Not VHSRadioBtn.Checked And Not DVDRadioBtn.Checked) Then
            MessageBox.Show("Please enter the movie title and select the movie format.", "Missing Data", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        ' Calculate rental amount based on movie format and new release status
        Dim rentalAmount As Decimal
        If DVDRadioBtn.Checked Then
            rentalAmount = If(NewReleaseCheckBox.Checked, 18, 15)
        Else
            rentalAmount = If(NewReleaseCheckBox.Checked, 12, 10)
        End If

        ' Apply discount for members
        If MemberCheckBox.Checked Then
            rentalAmount -= rentalAmount * 0.1
        End If

        ' Display rental amount and update the subtotal
        AmountTextBox.Text = rentalAmount.ToString("0.00")
        totalRentalAmount += rentalAmount
    End Sub

    Private Sub ClearBtn_Click(sender As Object, e As EventArgs) Handles ClearBtn.Click
        ' Clear the New Release checkbox and rental amount textbox
        NewReleaseCheckBox.Checked = False
        AmountTextBox.Text = String.Empty
    End Sub
End Class
