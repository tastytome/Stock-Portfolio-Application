Public Class Form5
    'AUTHOR: Thomas Tran
    'TITLE: Stock Portfolio Application (Future)
    'VERSION: v1.0

    '--sets Validation boolean as false by default
    Dim blnInputDataOK = False

    '--when button is clicked, runs DoValidation subroutine, then DoActions subroutine if data is correct
    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        blnInputDataOK = False
        DoValidation()

        '--checks if IF statements in DoValidation subroutine are fulfilled and runs DoActions
        If blnInputDataOK = True Then
            DoActions()
        End If
    End Sub

    '--validation subroutine via IF statement
    Private Sub DoValidation()

        '--existence checks
        If (String.IsNullOrEmpty(txtPresent.Text)) Then
            MessageBox.Show("Enter a present value", "Error")
            txtPresent.Focus()
        ElseIf (String.IsNullOrEmpty(txtInterest.Text)) Then
            MessageBox.Show("Enter an interest rate", "Error")
            txtInterest.Focus()
        ElseIf (String.IsNullOrEmpty(txtYears.Text)) Then
            MessageBox.Show("Enter a number of years", "Error")
            txtYears.Focus()

            '--type checks
        ElseIf (IsNumeric(txtPresent.Text)) = False Then
            MessageBox.Show("Input numbers for present value", "Error")
            txtPresent.Focus()
        ElseIf (IsNumeric(txtInterest.Text)) = False Then
            MessageBox.Show("Input numbers for interest", "Error")
            txtInterest.Focus()
        ElseIf (IsNumeric(txtYears.Text)) = False Then
            MessageBox.Show("Input numbers for years", "Error")
            txtYears.Focus()

            '--range checks
        ElseIf (txtPresent.Text <= 0) Then
            MessageBox.Show("Input a value above 0 for present value", "Error")
            txtPresent.Focus()
        ElseIf (txtInterest.Text <= 0) Then
            MessageBox.Show("Input a value above 0 for interest", "Error")
            txtInterest.Focus()
        ElseIf (txtYears.Text <= 0) Then
            MessageBox.Show("Input a value above 0 for years", "Error")
            txtYears.Focus()

            '--makes InputDataOK True if all validations are correct
        Else
            blnInputDataOK = True
        End If

    End Sub

    '--formula to calculate Future Value(FV)
    Private Sub DoActions()
        Dim FV As Double
        Dim PV As Double = txtPresent.Text
        Dim i As Double = txtInterest.Text
        Dim n As Double = txtYears.Text
        FV = PV * (1 + i / 100) ^ n
        '--rounds to 2 decimal places and outputs
        txtFuture.Text = ("$" & Math.Round(FV, 2))
    End Sub

    '--returns to menu form
    Private Sub btnMenu_Click(sender As Object, e As EventArgs) Handles btnMenu.Click
        Form1.Show()
        Me.Hide()
    End Sub

End Class