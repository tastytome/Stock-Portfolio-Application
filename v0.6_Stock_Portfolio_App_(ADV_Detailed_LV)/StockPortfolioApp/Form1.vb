Public Class Form1
    'AUTHOR: Thomas Tran
    'TITLE: Stock Portfolio Application (Menu)
    'VERSION: v1.0

    'OTHER INFO:
    '--this program was developed using the 4.6.1 framework
    '--it relies on a YahooFinanceAPI and other packages

    '--button hides this form and switches to basic form
    Private Sub btnBasicForm_Click(sender As Object, e As EventArgs) Handles btnBasicForm.Click
        Form2.Show()
        Me.Hide()
    End Sub

    '--button hides this form and switches to advanced form
    Private Sub btnAdvancedForm_Click(sender As Object, e As EventArgs) Handles btnAdvancedForm.Click
        Form3.Show()
        Me.Hide()
    End Sub

    '--button hides this form and switches to sorting form
    Private Sub btnSortingForm_Click(sender As Object, e As EventArgs) Handles btnSortingForm.Click
        Form4.Show()
        Me.Hide()
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        '--exit button to close down the application, with a confirmation message 
        Dim confirm_msg As Integer
        confirm_msg = MessageBox.Show("Are you sure you want to exit?", "Exit and Close",
                      MessageBoxButtons.YesNo, MessageBoxIcon.Information)
        If confirm_msg = vbYes Then
            Me.Close()
        Else
            Exit Sub
        End If
    End Sub

End Class
