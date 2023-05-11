Imports System.Data.SqlClient
Imports System.Data
Public Class Form2

    Dim connectionString As String = "Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\fox code1\Desktop\New folder (3)\WinFormsApp1\WinFormsApp1\app_data\Database1.mdf;Integrated Security=True"
    Dim sqlQuery As String = "SELECT * FROM Categories"
    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Create connection and data adapter objects
        Dim connection As New SqlConnection(connectionString)
        Dim dataAdapter As New SqlDataAdapter(sqlQuery, connection)
        ' Create a new DataSet object to hold the retrieved data
        Dim dataSet As New DataSet()

        ' Fill the DataSet with data from the data adapter
        dataAdapter.Fill(dataSet, "Categories")

        ' Bind the DataGridView control to the DataSet
        DataGridView1.DataSource = dataSet.Tables("Categories")
    End Sub
End Class