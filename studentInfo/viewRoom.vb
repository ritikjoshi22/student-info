Imports System.Data.SqlClient

Public Class viewRoom
    Private Sub viewRoom_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            Dim cnstr As String = "Data Source=RITIKJOSHI22\SQLEXPRESS;Initial Catalog=student_information;Integrated Security=True;TrustServerCertificate=True"
            Using con As New SqlConnection(cnstr)
                Dim query As String = "SELECT fullName,roomNumber FROM student_data
                                       ORDER BY roomNumber"
                Using cmd As New SqlCommand(query, con)
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

End Class