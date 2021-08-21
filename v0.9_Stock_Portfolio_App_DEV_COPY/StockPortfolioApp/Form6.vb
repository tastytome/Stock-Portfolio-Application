Public Class Form6
    'AUTHOR: Thomas Tran
    'TITLE: Stock Portfolio Application (Present)
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
        If (String.IsNullOrEmpty(txtFuture.Text)) Then
            MessageBox.Show("Enter a given name", "Error")
            txtFuture.Focus()
        ElseIf (String.IsNullOrEmpty(txtInterest.Text)) Then
            MessageBox.Show("Enter an interest rate", "Error")
            txtInterest.Focus()
        ElseIf (String.IsNullOrEmpty(txtYears.Text)) Then
            MessageBox.Show("Enter a number of years", "Error")
            txtYears.Focus()

            '--type checks
        ElseIf (IsNumeric(txtFuture.Text)) = False Then
            MessageBox.Show("Input numbers for present value", "Error")
            txtFuture.Focus()
        ElseIf (IsNumeric(txtInterest.Text)) = False Then
            MessageBox.Show("Input numbers for interest", "Error")
            txtInterest.Focus()
        ElseIf (IsNumeric(txtYears.Text)) = False Then
            MessageBox.Show("Input numbers for years", "Error")
            txtYears.Focus()

            '--range checks
        ElseIf (txtFuture.Text <= 0) Then
            MessageBox.Show("Input a value above 0 for present value", "Error")
            txtFuture.Focus()
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

    '--formula to calculate Present Value(PV)
    Private Sub DoActions()
        Dim FV As Double = txtFuture.Text
        Dim PV As Double
        Dim i As Double = Val(txtInterest.Text) / 100
        Dim n As Double = txtYears.Text
        PV = FV / (1 + i) ^ n
        '--rounds to 2 decimal places and outputs
        txtPresent.Text = ("$" & Math.Round(PV, 2))
    End Sub

    '--returns to menu form
    Private Sub btnMenu_Click(sender As Object, e As EventArgs) Handles btnMenu.Click
        Form1.Show()
        Me.Hide()
    End Sub
End Class