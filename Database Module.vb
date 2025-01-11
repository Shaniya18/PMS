Imports System.Data.SqlClient
Module Database_Module
    Public ConnectionString As String = "Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\shani\source\repos\PMS\My Project\PMS Database.mdf"";Integrated Security=True"
    Public Function GetConnection() As SqlConnection
        Return New SqlConnection(ConnectionString)
    End Function
End Module
