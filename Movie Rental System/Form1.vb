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

    Private Sub OrderCompleteBtn_Click(sender As Object, e As EventArgs) Handles OrderCompleteBtn.Click
        ' Confirm order completion with the user
        Dim result = MessageBox.Show("Are you sure you want to complete the order?", "Order Complete", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If result = DialogResult.Yes Then
            ' Increase the total customer count
            totalCustomers += 1

            ' Clear the form for a new customer
            MovieTitleTextBox.Text = String.Empty
            VHSRadioBtn.Checked = False
            DVDRadioBtn.Checked = False
            MemberCheckBox.Enabled = True
            MemberCheckBox.Checked = False
            ClearBtn.PerformClick()
        End If
    End Sub

    Private Sub SummaryBtn_Click(sender As Object, e As EventArgs) Handles SummaryBtn.Click
        ' Display the summary information
        MessageBox.Show($"Total Customers: {totalCustomers}{Environment.NewLine}Total Rental Amount: GH¢{totalRentalAmount}", "Summary")
    End Sub
End Class
