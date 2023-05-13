Imports System.Data.SqlClient
Imports System.Data
Public Class Form1
    ' Define connection string and SQL query

    'Dim connectionString As String = "Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\fox code1\Desktop\New folder (3)\WinFormsApp1\WinFormsApp1\app_data\Database1.mdf;Integrated Security=True"
    'Dim sqlQuery As String = "SELECT * FROM [dbo].[Table]"

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim email As String = txt_email.Text.Trim()
        Dim password As String = Txt_pass.Text.Trim()

        ' Check user credentials against database (replace with your own logic)
        If VerifyCredentials(email, password) = 1 Then
            Dim nextPage As New Form2()
            nextPage.Show()
            Me.Hide()
        ElseIf VerifyCredentials(email, password) = 2 Then
            Dim nextPage As New Form3()
            nextPage.Show()
            Me.Hide()
        Else
            ' Show error message
            MessageBox.Show("Invalid username or password")
        End If
    End Sub

    Private Function VerifyCredentials(email As String, password As String) As String
        ' Replace with your own logic to verify user credentials against a database
        ' For example, you could use a SQL query to check if the user exists and if their password matches
        Dim connString As String = "Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\fox code1\Desktop\New folder (3)\WinFormsApp1\WinFormsApp1\app_data\Database1.mdf;Integrated Security=True"
        Dim query As String = "SELECT LevelNum FROM [dbo].[Table] WHERE Email=@Email AND Password=@Password"
        Dim levelNum As Integer = 0 ' initialize the variable to hold the level number
        Try
            Using conn As New SqlConnection(connString), cmd As New SqlCommand(query, conn)
                conn.Open()
                cmd.Parameters.AddWithValue("@Email", email)
                cmd.Parameters.AddWithValue("@Password", password)
                levelNum = CInt(cmd.ExecuteScalar()) ' execute the query and get the level number
            End Using
        Catch
            ' handle any exceptions here
        End Try
        Return levelNum
    End Function
End Class
