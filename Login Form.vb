Public Class Login_Form
	Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
		' Hardcoded correct credentials for the example
		Dim correctUsername As String = "user"
		Dim correctPassword As String = "password123"

		' Validate if the username and password match
		If txtUserName.Text = correctUsername AndAlso txtPassword.Text = correctPassword Then
			' Open the main dashboard or next form after successful login
			Dim mainDashboard As New Pharmacist_MainPage() ' Replace with your main dashboard form name
			mainDashboard.Show()
			Me.Hide() ' Hide the login form
		Else
			' If username or password is incorrect
			MessageBox.Show("Invalid username or password.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error)
		End If
	End Sub

	Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
		' Close the application when the Cancel button is clicked
		Me.Close()
	End Sub
End Class