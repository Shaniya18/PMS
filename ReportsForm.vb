Imports System.Data.SqlClient
Public Class ReportsForm
    Private Sub ReportsForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Populate the report types
        cboReportType.Items.Add("Sales Summary")
        cboReportType.Items.Add("Top Selling Products")
        cboReportType.Items.Add("Inventory Status")

        ' Set default dates
        dtpStartDate.Value = DateTime.Now.AddDays(-30)
        dtpEndDate.Value = DateTime.Now
    End Sub

    Private Sub btnGenerateReports_Click(sender As Object, e As EventArgs) Handles btnGenerateReports.Click
        If cboReportType.SelectedItem Is Nothing Then
            MessageBox.Show("Please select a report type.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        Select Case cboReportType.SelectedItem.ToString()
            Case "Sales Summary"
                GenerateSalesSummaryReport()
            Case "Top Selling Products"
                GenerateTopSellingProductsReport()
            Case "Inventory Status"
                GenerateInventoryStatusReport()
            Case Else
                MessageBox.Show("Invalid report type selected.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Select
    End Sub

    Private Sub GenerateSalesSummaryReport()
        Try
            Using con As SqlConnection = Database_Module.GetConnection()
                con.Open()
                Dim query As String = "SELECT CONVERT(date, BillDate) AS Date, COUNT(*) AS TotalSales, SUM([Total Amount]) AS TotalRevenue " &
                                      "FROM tblBills " &
                                      "WHERE BillDate BETWEEN @StartDate AND @EndDate " &
                                      "GROUP BY CONVERT(date, BillDate) " &
                                      "ORDER BY Date"

                Using cmd As New SqlCommand(query, con)
                    cmd.Parameters.AddWithValue("@StartDate", dtpStartDate.Value.Date)
                    cmd.Parameters.AddWithValue("@EndDate", dtpEndDate.Value.Date.AddDays(1).AddSeconds(-1))
                    Dim adapter As New SqlDataAdapter(cmd)
                    Dim table As New DataTable()
                    adapter.Fill(table)
                    dgvReportData.DataSource = table
                End Using
            End Using

            FormatSalesSummaryReport()
        Catch ex As Exception
            MessageBox.Show("Error generating sales summary report: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub GenerateTopSellingProductsReport()
        Try
            Using con As SqlConnection = Database_Module.GetConnection()
                con.Open()
                Dim query As String = "SELECT TOP 10 bi.DrugName, SUM(bi.Quantity) AS TotalQuantitySold, SUM(bi.TotalPrice) AS TotalRevenue " &
                                      "FROM tblBillItems bi " &
                                      "INNER JOIN tblBills b ON bi.BillID = b.Id " &
                                      "WHERE b.BillDate BETWEEN @StartDate AND @EndDate " &
                                      "GROUP BY bi.DrugName " &
                                      "ORDER BY TotalQuantitySold DESC"

                Using cmd As New SqlCommand(query, con)
                    cmd.Parameters.AddWithValue("@StartDate", dtpStartDate.Value.Date)
                    cmd.Parameters.AddWithValue("@EndDate", dtpEndDate.Value.Date.AddDays(1).AddSeconds(-1))
                    Dim adapter As New SqlDataAdapter(cmd)
                    Dim table As New DataTable()
                    adapter.Fill(table)
                    dgvReportData.DataSource = table
                End Using
            End Using

            FormatTopSellingProductsReport()
        Catch ex As Exception
            MessageBox.Show("Error generating top selling products report: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub GenerateInventoryStatusReport()

        Try
            Using con As SqlConnection = Database_Module.GetConnection()
                con.Open()
                Dim query As String = "SELECT DrugName, Stock, " &
                                      "CASE WHEN Stock <= 10 THEN 'Reorder' ELSE 'OK' END AS Status " &
                                      "FROM tblInventory " &
                                      "ORDER BY Status DESC, DrugName"

                Using cmd As New SqlCommand(query, con)
                    Dim adapter As New SqlDataAdapter(cmd)
                    Dim table As New DataTable()
                    adapter.Fill(table)
                    dgvReportData.DataSource = table
                End Using
            End Using

            FormatInventoryStatusReport()
        Catch ex As Exception
            MessageBox.Show("Error generating inventory status report: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub


    Private Sub FormatSalesSummaryReport()
        dgvReportData.Columns("Date").DefaultCellStyle.Format = "dd/MM/yyyy"
        dgvReportData.Columns("TotalRevenue").DefaultCellStyle.Format = "C2"
        dgvReportData.AutoResizeColumns()
    End Sub

    Private Sub FormatTopSellingProductsReport()
        dgvReportData.Columns("TotalRevenue").DefaultCellStyle.Format = "C2"
        dgvReportData.AutoResizeColumns()
    End Sub

    Private Sub FormatInventoryStatusReport()
        dgvReportData.AutoResizeColumns()
    End Sub

    Private Sub btnPreviousPage_Click(sender As Object, e As EventArgs) Handles btnPreviousPage.Click
        ' Close the current form
        Me.Close()

        ' Show the Pharmacist_MainPage form
        Dim mainPage As New Pharmacist_MainPage()
        mainPage.Show()
    End Sub

End Class
