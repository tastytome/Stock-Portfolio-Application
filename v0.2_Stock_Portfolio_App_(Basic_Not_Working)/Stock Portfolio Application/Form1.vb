Public Class Form1
    'AUTHOR: Thomas Tran
    'TITLE: Stock Portfolio Application (Menu)
    'VERSION: v1.0

    '--Button hides this form and switches to basic form
    Private Sub btnBasicForm_Click(sender As Object, e As EventArgs) Handles btnBasicForm.Click
        Form2.Show()
        Me.Hide()
    End Sub

    '--Button hides this form and switches to advanced form
    Private Sub btnAdvancedForm_Click(sender As Object, e As EventArgs) Handles btnAdvancedForm.Click
        Form3.Show()
        Me.Hide()
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        '--Exit button to close down the application, with an Are You Sure message 
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
