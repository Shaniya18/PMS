Imports System.Data.SqlClient
Imports System.Data

Public Class Inventory_Management
    Inherits Form

    Private Sub Inventory_Management_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadData()
    End Sub

    ' Add to Database
    Private Sub btnAddToDB_Click(sender As Object, e As EventArgs) Handles btnAddToDB.Click
        Using con As SqlConnection = Database_Module.GetConnection()
            con.Open()
            ' SQL query to insert data
            Dim query As String = "INSERT INTO [tblInventory] (DrugName, Category, Price, Stock) VALUES (@DrugName, @Category, @Price, @Stock)"
            Dim cmd As New SqlCommand(query, con)

            ' Set parameter values
            cmd.Parameters.AddWithValue("@DrugName", txtAddDrugName.Text)
            cmd.Parameters.AddWithValue("@Category", txtAddCategory.Text)
            cmd.Parameters.AddWithValue("@Price", Decimal.Round(Decimal.Parse(txtAddPrice.Text, Globalization.NumberStyles.Currency, Globalization.CultureInfo.CurrentCulture), 2))

            cmd.Parameters.AddWithValue("@Stock", Integer.Parse(txtAddStock.Text))

            ' Execute command
            cmd.ExecuteNonQuery()
            MessageBox.Show("Data inserted successfully!")
        End Using

        ' Clear input fields
        txtAddDrugName.Text = String.Empty
        txtAddCategory.Text = String.Empty
        txtAddPrice.Text = String.Empty
        txtAddStock.Text = String.Empty
    End Sub

    ' Update Database
    Private Sub btnUpdateDB_Click(sender As Object, e As EventArgs) Handles btnUpdateDB.Click
        Using con As SqlConnection = Database_Module.GetConnection()
            con.Open()
            ' SQL query to update data
            Dim query As String = "UPDATE [tblInventory] SET DrugName = @DrugName, Category = @Category, Price = @Price, Stock = @Stock WHERE ID = @ID"
            Dim cmd As New SqlCommand(query, con)

            ' Set parameter values
            cmd.Parameters.AddWithValue("@DrugName", txtUpdateDrugName.Text)
            cmd.Parameters.AddWithValue("@Category", txtUpdateCategory.Text)
            cmd.Parameters.AddWithValue("@Price", Decimal.Parse(txtUpdatePrice.Text))
            cmd.Parameters.AddWithValue("@Stock", Integer.Parse(txtUpdateStock.Text))
            cmd.Parameters.AddWithValue("@ID", Integer.Parse(txtUpdateID.Text))

            ' Execute command
            cmd.ExecuteNonQuery()
            MessageBox.Show("Data updated successfully!")
        End Using

        ClearUpdateFields()
    End Sub

    Private Sub ClearUpdateFields()
        txtUpdateDrugName.Text = String.Empty
        txtUpdateCategory.Text = String.Empty
        txtUpdatePrice.Text = String.Empty
        txtUpdateStock.Text = String.Empty
        txtUpdateID.Text = String.Empty
    End Sub

    ' Delete from Database
    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        Using con As SqlConnection = Database_Module.GetConnection()
            con.Open()
            ' SQL query to delete data
            Dim query As String = "DELETE FROM [tblInventory] WHERE ID = @ID"
            Dim cmd As New SqlCommand(query, con)

            ' Set parameter value
            cmd.Parameters.AddWithValue("@ID", Integer.Parse(txtDeleteID.Text))

            ' Execute command
            cmd.ExecuteNonQuery()
            MessageBox.Show("Data deleted successfully!")
        End Using

        ' Clear input field
        txtDeleteID.Text = String.Empty
    End Sub

    ' Refresh Data Grid View
    Private Sub btnRefresh_Click(sender As Object, e As EventArgs) Handles btnRefresh.Click
        LoadData()
    End Sub

    ' Method to load data into the DataGridView
    Private Sub LoadData()
        Using con As SqlConnection = Database_Module.GetConnection()
            con.Open()
            ' SQL query to select all data
            Dim query As String = "SELECT * FROM [tblInventory]"
            Dim cmd As New SqlCommand(query, con)

            ' Fill DataTable with query results
            Dim adapter As New SqlDataAdapter(cmd)
            Dim table As New DataTable()

            ' Fill the DataTable with data
            adapter.Fill(table)

            ' Bind DataTable to DataGridView
            DataGridView1.DataSource = table
        End Using
    End Sub

    Private Sub btnPreviousPage_Click(sender As Object, e As EventArgs) Handles btnPreviousPage.Click
        ' Close the current form
        Me.Close()

        ' Show the Pharmacist_MainPage form
        Dim mainPage As New Pharmacist_MainPage()
        mainPage.Show()
    End Sub

End Class
