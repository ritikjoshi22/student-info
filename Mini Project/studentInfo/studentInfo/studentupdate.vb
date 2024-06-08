Imports System.Data.SqlClient

Public Class studentupdate
    Dim cnstr = "Data Source=RITIKJOSHI22\SQLEXPRESS;Initial Catalog=student_information;Integrated Security=True;TrustServerCertificate=True"
    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            Using con As New SqlConnection(cnstr)
                Dim cmd As New SqlCommand("update student_data
                                            set fullname=@fn,dob=@birth,gender=@g,phone=@ph,address=@add
                                            where sid=@id", con)
                cmd.Parameters.Add("@fn", SqlDbType.VarChar).Value = TextBox3.Text
                cmd.Parameters.Add("@birth", SqlDbType.Date).Value = TextBox5.Text
                cmd.Parameters.Add("@g", SqlDbType.VarChar).Value = TextBox6.Text
                cmd.Parameters.Add("@ph", SqlDbType.VarChar).Value = TextBox1.Text
                cmd.Parameters.Add("@add", SqlDbType.VarChar).Value = TextBox2.Text
                cmd.Parameters.Add("@id", SqlDbType.Int).Value = TextBox4.Text
                con.Open()
                cmd.ExecuteNonQuery()
                MsgBox("Successfully updated a student")
                con.Close()
            End Using
        Catch ex As Exception
            MessageBox.Show("An error occurred: " & ex.Message)
        End Try
    End Sub

    Private Sub DateTimePicker1_ValueChanged(sender As Object, e As EventArgs) Handles DateTimePicker1.ValueChanged
        TextBox5.Text = DateTimePicker1.Value.ToShortDateString()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
    End Sub
End Class