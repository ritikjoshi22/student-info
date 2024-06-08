Imports System.Data.SqlClient

Public Class studentAdd
    Dim cnstr = "Data Source=RITIKJOSHI22\SQLEXPRESS;Initial Catalog=student_information;Integrated Security=True;TrustServerCertificate=True"
    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            Using con As New SqlConnection(cnstr)
                Dim cmd As New SqlCommand("insert into student_data(fullName,dob,gender,phone,address)
                                            values(@fn,@birth,@g,@ph,@add)", con)
                cmd.Parameters.Add("@fn", SqlDbType.VarChar).Value = TextBox3.Text
                cmd.Parameters.Add("@birth", SqlDbType.Date).Value = TextBox5.Text
                cmd.Parameters.Add("@g", SqlDbType.VarChar).Value = TextBox2.Text
                cmd.Parameters.Add("@ph", SqlDbType.VarChar).Value = TextBox1.Text
                cmd.Parameters.Add("@add", SqlDbType.VarChar).Value = TextBox2.Text
                con.Open()
                cmd.ExecuteNonQuery()
                MsgBox("Successfully added a student")
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