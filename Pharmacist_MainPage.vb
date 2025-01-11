Public Class Pharmacist_MainPage


    Private Sub InventoryToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles InventoryToolStripMenuItem.Click

        ' Create an instance of the Inventory Management form
        Dim inventoryForm As New Inventory_Management()

        ' Show the Inventory Management form
        inventoryForm.Show()

        ' Optionally hide the current Pharmacist_MainPage form, or leave it open
        Me.Hide()
    End Sub

    Private Sub BillingToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BillingToolStripMenuItem.Click
        ' Create an instance of the Billing form
        Dim billingForm As New Billing_Form()

        ' Show the Billing form
        billingForm.Show()

        ' Optionally hide the current Pharmacist_MainPage form, or leave it open
        Me.Hide()
    End Sub

    Private Sub LogoutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LogoutToolStripMenuItem.Click
        ' Close the main form
        Me.Close()


        Login_Form.Show()
    End Sub

    Private Sub ReportsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ReportsToolStripMenuItem.Click
        Dim reportsForm As New ReportsForm()
        reportsForm.Show()
    End Sub
End Class