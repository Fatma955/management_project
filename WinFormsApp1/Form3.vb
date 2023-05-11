Imports System.Data.SqlClient
Imports System.Data
Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class Form3
    Dim connectionString As String = "Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\fox code1\Desktop\New folder (3)\WinFormsApp1\WinFormsApp1\app_data\Database1.mdf;Integrated Security=True"
    Dim sqlQuery As String = "SELECT * FROM Categories"

    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load

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
    Dim tableName As String = "Categories"
    Private Sub btn_add_Click(sender As Object, e As EventArgs) Handles btn_add.Click

        Dim primaryKeyField As String = "ID"
        Dim insertQuery As String = "INSERT INTO " & tableName & " (CategoryType, Price, ExpiredDate) VALUES (@Type, @Price, @ExpiredDate)"

        Using connection As New SqlConnection(connectionString),
          command As New SqlCommand(insertQuery, connection)
            ' Set the parameter values for the new record
            command.Parameters.AddWithValue("@Type", Txt_type.Text.Trim())
            command.Parameters.AddWithValue("@Price", SqlDbType.Int).Value = Integer.Parse(Txt_price.Text.Trim())
            command.Parameters.AddWithValue("@ExpiredDate", Txt_expired.Text.Trim())
            ' Open the database connection and execute the insert query
            connection.Open()
            command.ExecuteNonQuery()
            Txt_type.Text = ""
            Txt_price.Text = ""
            Txt_expired.Text = ""

            ' Refresh the DataGridView to show the newly added item
            Form3_Load(sender, e)
        End Using

        ' Delete an existing record from the table
        'Dim deleteQuery As String = "DELETE FROM " & tableName & " WHERE " & primaryKeyField & " = @ID"
        'Using connection As New SqlConnection(connectionString),
        '      command As New SqlCommand(deleteQuery, connection)
        '    ' Set the parameter values for the delete query
        '    command.Parameters.AddWithValue("@ID", 2) ' ID of the record to delete
        '    ' Open the database connection and execute the delete query
        '    connection.Open()
        '    command.ExecuteNonQuery()
        'End Using
    End Sub

    Private selectedID As Integer

    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        ' Get the selected row
        Dim selectedRow As DataGridViewRow = DataGridView1.Rows(e.RowIndex)

        ' Store the ID of the selected row in a variable for later use
        selectedID = Convert.ToInt32(selectedRow.Cells("id").Value)
        Txt_type.Text = selectedRow.Cells("CategoryType").Value.ToString()
        Txt_price.Text = selectedRow.Cells("price").Value.ToString()
        Txt_expired.Text = selectedRow.Cells("ExpiredDate").Value.ToString()

    End Sub

    Private Sub btn_update_Click(sender As Object, e As EventArgs) Handles btn_update.Click
        Dim dataTable As DataTable = CType(DataGridView1.DataSource, DataTable)
        Dim selectedRow As DataRow = dataTable.Rows.Find(selectedID)

        If selectedRow IsNot Nothing Then
            selectedRow("CategoryType") = Txt_type.Text
            selectedRow("price") = Txt_price.Text
            selectedRow("ExpiredDate") = Txt_expired.Text

            ' Update the DataGridView to reflect the changes
            DataGridView1.Refresh()
        End If

    End Sub

End Class