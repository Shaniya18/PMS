
Imports System.Data.SqlClient

Public Class Billing_Form
    Private totalAmount As Decimal = 0
    Private cartDataTable As New DataTable()

    Private Sub Billing_Form_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        InitializeCartDataTable()
        RefreshSalesData()
    End Sub

    Private Sub InitializeCartDataTable()
        cartDataTable.Columns.Add("InventoryID", GetType(Integer))
        cartDataTable.Columns.Add("DrugName", GetType(String))
        cartDataTable.Columns.Add("Price", GetType(Decimal))
        cartDataTable.Columns.Add("Quantity", GetType(Integer))
        cartDataTable.Columns.Add("TotalPrice", GetType(Decimal))

        dgvCart.DataSource = cartDataTable
        dgvCart.Columns("InventoryID").Visible = False
    End Sub

    Private Sub btnAddToCart_Click(sender As Object, e As EventArgs) Handles btnAddToCart.Click
        If String.IsNullOrEmpty(txtDrugName.Text) OrElse Not Decimal.TryParse(txtPrice.Text, Nothing) OrElse Not Integer.TryParse(txtQuantity.Text, Nothing) Then
            MessageBox.Show("Please enter valid drug name, price, and quantity.")
            Return
        End If

        Dim drugName As String = txtDrugName.Text
        Dim price As Decimal = Decimal.Parse(txtPrice.Text)
        Dim quantity As Integer = Integer.Parse(txtQuantity.Text)

        Dim inventoryID As Integer = GetInventoryID(drugName)
        If inventoryID = -1 Then
            MessageBox.Show("Drug not found in inventory.")
            Return
        End If

        If Not CheckSufficientStock(inventoryID, quantity) Then
            MessageBox.Show("Insufficient stock.")
            Return
        End If

        Dim totalPrice As Decimal = price * quantity
        cartDataTable.Rows.Add(inventoryID, drugName, price, quantity, totalPrice)

        totalAmount += totalPrice
        UpdateTotalAmountDisplay()
        ClearInputFields()
    End Sub

    Private Function GetInventoryID(drugName As String) As Integer
        Using con As SqlConnection = Database_Module.GetConnection()
            con.Open()
            Dim query As String = "SELECT ID FROM tblInventory WHERE DrugName = @DrugName"
            Using cmd As New SqlCommand(query, con)
                cmd.Parameters.AddWithValue("@DrugName", drugName)
                Dim result As Object = cmd.ExecuteScalar()
                If result IsNot Nothing Then
                    Return CInt(result)
                End If
            End Using
        End Using
        Return -1
    End Function

    Private Function CheckSufficientStock(inventoryID As Integer, requestedQuantity As Integer) As Boolean
        Using con As SqlConnection = Database_Module.GetConnection()
            con.Open()
            Dim query As String = "SELECT Stock FROM tblInventory WHERE ID = @ID"
            Using cmd As New SqlCommand(query, con)
                cmd.Parameters.AddWithValue("@ID", inventoryID)
                Dim currentStock As Object = cmd.ExecuteScalar()
                If currentStock IsNot Nothing AndAlso IsNumeric(currentStock) Then
                    Return CInt(currentStock) >= requestedQuantity
                End If
            End Using
        End Using
        Return False
    End Function


    Private Sub SaveBillToDatabase()

        Dim errorLog As New System.Text.StringBuilder()
        errorLog.AppendLine($"Starting SaveBillToDatabase process at {DateTime.Now}")
        errorLog.AppendLine($"Total Amount: {totalAmount}")

        Try
            Using con As SqlConnection = Database_Module.GetConnection()
                errorLog.AppendLine("Database connection opened")
                con.Open()
                Using transaction As SqlTransaction = con.BeginTransaction()
                    Try
                        ' Get the next available Id for tblBills
                        Dim getNextIdQuery As String = "SELECT ISNULL(MAX(Id), 0) + 1 FROM tblBills"
                        Dim nextBillId As Integer
                        Using getIdCmd As New SqlCommand(getNextIdQuery, con, transaction)
                            nextBillId = Convert.ToInt32(getIdCmd.ExecuteScalar())
                            errorLog.AppendLine($"Next Bill ID: {nextBillId}")
                        End Using

                        ' Insert into tblBills table (This represents the sale)
                        Dim billQuery As String = "INSERT INTO tblBills (Id, [Total Amount], BillDate) VALUES (@Id, @TotalAmount, @BillDate)"
                        Using billCmd As New SqlCommand(billQuery, con, transaction)
                            billCmd.Parameters.AddWithValue("@Id", nextBillId)
                            billCmd.Parameters.AddWithValue("@TotalAmount", Math.Round(totalAmount, 2))
                            billCmd.Parameters.AddWithValue("@BillDate", DateTime.Now)
                            errorLog.AppendLine($"Executing bill insert query: {billQuery}")
                            errorLog.AppendLine($"Parameters: Id = {nextBillId}, TotalAmount = {Math.Round(totalAmount, 2)}, BillDate = {DateTime.Now}")
                            billCmd.ExecuteNonQuery()
                            errorLog.AppendLine("Bill (Sale) inserted successfully")
                        End Using

                        ' Insert into tblBillItems table (This represents the sale items)
                        For Each row As DataGridViewRow In dgvCart.Rows
                            If Not row.IsNewRow Then
                                errorLog.AppendLine($"Processing row: {row.Index}")
                                Try
                                    Dim inventoryID As Object = If(row.Cells("InventoryID").Value Is Nothing, DBNull.Value, row.Cells("InventoryID").Value)
                                    Dim drugName As String = Convert.ToString(row.Cells("DrugName").Value)
                                    Dim price As Decimal = Convert.ToDecimal(row.Cells("Price").Value)
                                    Dim quantity As Integer = Convert.ToInt32(row.Cells("Quantity").Value)
                                    Dim totalPrice As Decimal = Convert.ToDecimal(row.Cells("TotalPrice").Value)

                                    errorLog.AppendLine($"Row data: InventoryID={inventoryID}, DrugName={drugName}, Price={price:F2}, Quantity={quantity}, TotalPrice={totalPrice:F2}")

                                    Dim itemQuery As String = "INSERT INTO tblBillItems (BillID, InventoryID, DrugName, Price, Quantity, TotalPrice) VALUES (@BillID, @InventoryID, @DrugName, @Price, @Quantity, @TotalPrice)"
                                    Using itemCmd As New SqlCommand(itemQuery, con, transaction)
                                        itemCmd.Parameters.AddWithValue("@BillID", nextBillId)
                                        itemCmd.Parameters.AddWithValue("@InventoryID", inventoryID)
                                        itemCmd.Parameters.AddWithValue("@DrugName", drugName)
                                        itemCmd.Parameters.AddWithValue("@Price", Math.Round(price, 2))
                                        itemCmd.Parameters.AddWithValue("@Quantity", quantity)
                                        itemCmd.Parameters.AddWithValue("@TotalPrice", Math.Round(totalPrice, 2))
                                        errorLog.AppendLine($"Executing bill item insert query: {itemQuery}")
                                        errorLog.AppendLine($"Parameters: BillID = {nextBillId}, InventoryID = {inventoryID}, DrugName = {drugName}, Price = {Math.Round(price, 2)}, Quantity = {quantity}, TotalPrice = {Math.Round(totalPrice, 2)}")
                                        itemCmd.ExecuteNonQuery()
                                        errorLog.AppendLine("Bill item (Sale item) inserted successfully")
                                    End Using

                                    ' Update inventory
                                    If inventoryID IsNot DBNull.Value Then
                                        Dim updateQuery As String = "UPDATE tblInventory SET Stock = Stock - @QuantitySold WHERE ID = @ID"
                                        Using updateCmd As New SqlCommand(updateQuery, con, transaction)
                                            updateCmd.Parameters.AddWithValue("@QuantitySold", quantity)
                                            updateCmd.Parameters.AddWithValue("@ID", inventoryID)
                                            errorLog.AppendLine($"Executing inventory update query: {updateQuery}")
                                            errorLog.AppendLine($"Parameters: QuantitySold = {quantity}, ID = {inventoryID}")
                                            updateCmd.ExecuteNonQuery()
                                            errorLog.AppendLine("Inventory updated successfully")
                                        End Using
                                    Else
                                        errorLog.AppendLine($"Skipping inventory update: Invalid ID")
                                    End If
                                Catch ex As Exception
                                    errorLog.AppendLine($"Error processing row: {ex.Message}")
                                    errorLog.AppendLine($"Stack Trace: {ex.StackTrace}")
                                    Throw
                                End Try
                            End If
                        Next

                        transaction.Commit()
                        errorLog.AppendLine("Transaction committed successfully")
                        MessageBox.Show("Sale recorded and inventory updated successfully!")
                    Catch ex As Exception
                        transaction.Rollback()
                        errorLog.AppendLine($"Transaction rolled back. Error: {ex.Message}")
                        errorLog.AppendLine($"Stack Trace: {ex.StackTrace}")
                        Throw
                    End Try
                End Using
            End Using
        Catch ex As Exception
            errorLog.AppendLine($"Outer exception: {ex.Message}")
            errorLog.AppendLine($"Stack Trace: {ex.StackTrace}")
            MessageBox.Show($"Error saving sale and updating inventory. Please check the error log for details.")
        Finally
            ' Save error log to file
            System.IO.File.WriteAllText("ErrorLog.txt", errorLog.ToString())
        End Try
    End Sub


    Private Sub ClearCart()
        cartDataTable.Clear()
        dgvCart.Refresh()
    End Sub

    Private Sub UpdateTotalAmountDisplay()
        lblTotalAmount.Text = "Total Amount: $" & totalAmount.ToString("F2")
    End Sub

    Private Sub ClearInputFields()
        txtDrugName.Text = String.Empty
        txtPrice.Text = String.Empty
        txtQuantity.Text = String.Empty
    End Sub

    Private Sub btnRefreshSales_Click(sender As Object, e As EventArgs) Handles btnRefreshSales.Click
        RefreshSalesData()
    End Sub
    Private Sub RefreshSalesData()

        Try
            Using con As SqlConnection = Database_Module.GetConnection()
                con.Open()
                Dim query As String = "SELECT Id, BillDate, [Total Amount] AS TotalAmount FROM tblBills ORDER BY BillDate DESC"
                Using cmd As New SqlCommand(query, con)
                    Dim adapter As New SqlDataAdapter(cmd)
                    Dim table As New DataTable()
                    adapter.Fill(table)
                    dgvSales.DataSource = table
                End Using
            End Using

            ' Format the DataGridView
            FormatSalesDataGridView()

            MessageBox.Show("Sales data refreshed successfully!", "Refresh Complete", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As Exception
            MessageBox.Show("Error refreshing sales data: " & ex.Message, "Refresh Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub



    Private Sub FormatSalesDataGridView()
        If dgvSales.Columns.Count > 0 Then
            ' Adjust column headers
            dgvSales.Columns("Id").HeaderText = "Bill ID"
            dgvSales.Columns("BillDate").HeaderText = "Bill Date"
            dgvSales.Columns("TotalAmount").HeaderText = "Total Amount"

            ' Format the date column
            dgvSales.Columns("BillDate").DefaultCellStyle.Format = "dd/MM/yyyy HH:mm:ss"

            ' Format the amount column
            dgvSales.Columns("TotalAmount").DefaultCellStyle.Format = "C2" ' Currency format with 2 decimal places

            ' Auto-size columns
            dgvSales.AutoResizeColumns()
        End If
    End Sub

    Private Sub ShowBillDetails(billId As Integer)
        Try
            Using con As SqlConnection = Database_Module.GetConnection()
                con.Open()
                Dim query As String = "SELECT InventoryID, DrugName, Price, Quantity, TotalPrice FROM tblBillItems WHERE BillID = @BillID"
                Using cmd As New SqlCommand(query, con)
                    cmd.Parameters.AddWithValue("@BillID", billId)
                    Dim adapter As New SqlDataAdapter(cmd)
                    Dim table As New DataTable()
                    adapter.Fill(table)

                    ' You can display this data in a new form or in another DataGridView
                    ' For now, let's just show it in a message box
                    Dim details As String = "Bill Details for Bill ID " & billId & ":" & vbNewLine & vbNewLine
                    For Each row As DataRow In table.Rows
                        details &= $"Drug: {row("DrugName")}, Quantity: {row("Quantity")}, Price: {row("Price"):C2}, Total: {row("TotalPrice"):C2}" & vbNewLine
                    Next
                    MessageBox.Show(details, "Bill Details", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Error retrieving bill details: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnGenerateBill_Click_1(sender As Object, e As EventArgs) Handles btnGenerateBill.Click
        If cartDataTable.Rows.Count > 0 Then
            SaveBillToDatabase()
            ClearCart()
            totalAmount = 0
            UpdateTotalAmountDisplay()
        Else
            MessageBox.Show("Cart is empty! Please add items.")
        End If
    End Sub

    Private Sub btnPreviousPage_Click(sender As Object, e As EventArgs) Handles btnPreviousPage.Click
        ' Close the current form
        Me.Close()

        ' Show the Pharmacist_MainPage form
        Dim mainPage As New Pharmacist_MainPage()
        mainPage.Show()
    End Sub

End Class
