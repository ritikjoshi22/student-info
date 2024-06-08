Imports System.Data.SqlClient
Imports System.Windows.Forms

Public Class studentSearch
    Inherits Form

    Public Sub display()
        Try
            Dim cnstr As String = "Data Source=RITIKJOSHI22\SQLEXPRESS;Initial Catalog=student_information;Integrated Security=True;TrustServerCertificate=True"
            Using con As New SqlConnection(cnstr)
                Dim query As String = "SELECT * FROM student_data WHERE sid=@search"
                Using cmd As New SqlCommand(query, con)
                    cmd.Parameters.Add("@search", SqlDbType.Int).Value = TextBox1.Text
                    con.Open()
                    Dim adapter As New SqlDataAdapter(cmd)
                    Dim dt As New DataTable()
                    adapter.Fill(dt)
                    DataGridView1.DataSource = dt
                    con.Close()
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("An error occurred: " & ex.Message)
        End Try
    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        display()
    End Sub
End Class
