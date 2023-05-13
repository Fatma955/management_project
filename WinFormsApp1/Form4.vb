Imports System.Data.SqlClient
Imports System.Data
Public Class Form4
    Dim connectionString As String = "Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\fox code1\Desktop\New folder (3)\WinFormsApp1\WinFormsApp1\app_data\Database1.mdf;Integrated Security=True"
    Dim sqlQuery As String = "SELECT * FROM [dbo].[Table]"

    Private Sub Form4_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Create connection and data adapter objects
        Dim connection As New SqlConnection(connectionString)
        Dim dataAdapter As New SqlDataAdapter(sqlQuery, connection)
        ' Create a new DataSet object to hold the retrieved data
        Dim dataSet As New DataSet()

        ' Fill the DataSet with data from the data adapter
        dataAdapter.Fill(dataSet, "[dbo].[Table]")

        ' Bind the DataGridView control to the DataSet
        DataGridView1.DataSource = dataSet.Tables("[dbo].[Table]")
    End Sub

    Private Sub btn_add_Click(sender As Object, e As EventArgs) Handles btn_add.Click

        Dim primaryKeyField As String = "ID"
        Dim insertQuery As String = "INSERT INTO [dbo].[Table] (UserName, Email, Password, LevelNum) VALUES (@UserName, @Email, @Password, @LevelNum)"

        Using connection As New SqlConnection(connectionString),
          command As New SqlCommand(insertQuery, connection)
            ' Set the parameter values for the new record
            command.Parameters.AddWithValue("@UserName", Txt_name.Text.Trim())
            command.Parameters.AddWithValue("@Email", Txt_email.Text.Trim())
            command.Parameters.AddWithValue("@Password", Txt_pass.Text.Trim())
            command.Parameters.AddWithValue("@LevelNum", SqlDbType.Int).Value = Integer.Parse(txt_level.Text.Trim())
            connection.Open()
            command.ExecuteNonQuery()
            Txt_name.Text = ""
            Txt_email.Text = ""
            Txt_pass.Text = ""
            txt_level.Text = ""

            ' Refresh the DataGridView to show the newly added item
            Form4_Load(sender, e)
        End Using
    End Sub

    Private selectedID As Integer

    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        ' Get the selected row
        Dim selectedRow As DataGridViewRow = DataGridView1.Rows(e.RowIndex)

        ' Store the ID of the selected row in a variable for later use
        selectedID = Convert.ToInt32(selectedRow.Cells("id").Value)
        Txt_name.Text = selectedRow.Cells("UserName").Value.ToString()
        Txt_email.Text = selectedRow.Cells("Email").Value.ToString()
        Txt_pass.Text = selectedRow.Cells("Password").Value.ToString()
        txt_level.Text = selectedRow.Cells("LevelNum").Value.ToString()

        ' Define the primary key of the DataTable (if not already defined)
        Dim dataTable As DataTable = CType(DataGridView1.DataSource, DataTable)
        If dataTable.PrimaryKey.Length = 0 Then
            dataTable.PrimaryKey = New DataColumn() {dataTable.Columns("id")}
        End If
    End Sub
    Private Sub btn_update_Click(sender As Object, e As EventArgs) Handles btn_update.Click
        Dim dataTable As DataTable = CType(DataGridView1.DataSource, DataTable)

        ' Locate the row that you want to update using a loop
        For Each row As DataRow In dataTable.Rows
            If Convert.ToInt32(row("id")) = selectedID Then
                row("UserName") = Txt_name.Text
                row("Email") = Txt_email.Text
                row("Password") = Txt_pass.Text
                row("LevelNum") = txt_level.Text
                Exit For
            End If
        Next

        ' Update the database with the changes
        Dim adapter As New SqlDataAdapter("SELECT * FROM [dbo].[Table]", connectionString)
        Dim builder As New SqlCommandBuilder(adapter)
        adapter.Update(dataTable)

        ' Refresh the DataGridView to reflect the changes
        DataGridView1.Refresh()
    End Sub

    Private Sub btn_delete_Click(sender As Object, e As EventArgs) Handles btn_delete.Click
        ' Get the selected row
        Dim selectedRow As DataGridViewRow = DataGridView1.CurrentRow

        ' Get the ID of the selected row
        Dim selectedID As Integer = Convert.ToInt32(selectedRow.Cells("id").Value)

        ' Ask the user to confirm the delete operation
        Dim result As DialogResult = MessageBox.Show("Are you sure you want to delete this record?", "Confirm Delete", MessageBoxButtons.YesNo)

        If result = DialogResult.Yes Then
            ' Delete the record from the database
            Dim query As String = "DELETE FROM Categories WHERE id = @id"
            Dim connString As String = connectionString
            Using conn As New SqlConnection(connString)
                Using cmd As New SqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@id", selectedID)
                    conn.Open()
                    cmd.ExecuteNonQuery()
                    conn.Close()
                End Using
            End Using

            ' Remove the row from the DataGridView
            DataGridView1.Rows.Remove(selectedRow)
        End If
    End Sub

    Private Sub btn_search_Click(sender As Object, e As EventArgs) Handles btn_search.Click
        Dim searchTerm As String = txt_search.Text.Trim()
        Dim dataTable As DataTable = CType(DataGridView1.DataSource, DataTable)
        dataTable.DefaultView.RowFilter = $"UserName LIKE '%{searchTerm}%'"
        DataGridView1.Refresh()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim dataTable As DataTable = CType(DataGridView1.DataSource, DataTable)
        dataTable.DefaultView.RowFilter = ""
        DataGridView1.Refresh()
        txt_search.Text = ""
        Txt_name.Text = ""
        Txt_email.Text = ""
        Txt_pass.Text = ""
        txt_level.Text = ""

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim form3 As New Form3 ' اسم النافذة السابقة هنا Form1
        Me.Hide()
        form3.Show()
    End Sub
End Class