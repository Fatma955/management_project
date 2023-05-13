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

    Private Sub btn_search_Click(sender As Object, e As EventArgs) Handles btn_search.Click
        Dim searchTerm As String = txt_search.Text.Trim()
        Dim dataTable As DataTable = CType(DataGridView1.DataSource, DataTable)
        dataTable.DefaultView.RowFilter = $"CategoryType LIKE '%{searchTerm}%'"
        DataGridView1.Refresh()
    End Sub

    'Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
    '    Dim dataTable As DataTable = CType(DataGridView1.DataSource, DataTable)
    '    dataTable.DefaultView.RowFilter = ""
    '    DataGridView1.Refresh()
    '    txt_search.Text = ""
    '    Txt_type.Text = ""
    '    Txt_price.Text = ""
    '    Txt_expired.Text = ""
    'End Sub
End Class