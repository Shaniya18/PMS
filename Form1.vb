Public Class Form1

	Private Sub Pbar_Click(sender As Object, e As EventArgs) Handles Pbar.Click
        ' Increment progress bar
        Me.Pbar.Value = Pbar.Value + 10 ' Adjust increment for faster loading

        ' If progress bar reaches or exceeds 100, perform operations
        If Pbar.Value >= 100 Then
            Timer1.Stop() ' Stop the timer

            ' Optionally hide the current form and load another form quickly
            Me.Hide()
            Login_Form.Show() ' Show a different form
        End If
    End Sub
End Class
