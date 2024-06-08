Imports System.Data.SqlClient
Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class studentremove
    Dim cnstr = "Data Source=RITIKJOSHI22\SQLEXPRESS;Initial Catalog=student_information;Integrated Security=True;TrustServerCertificate=True"

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            Using con As New SqlConnection(cnstr)
                Dim cmd As New SqlCommand("delete student_data where sid=@id", con)
                cmd.Parameters.Add("@id", SqlDbType.Int).Value = TextBox1.Text
                con.Open()
                cmd.ExecuteNonQuery()
                MsgBox("Successfully removed a student")
                con.Close()
            End Using
        Catch ex As Exception
            MessageBox.Show("An error occurred: " & ex.Message)
        End Try
    End Sub
End Class