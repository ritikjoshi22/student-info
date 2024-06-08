Imports System.Data.SqlClient

Public Class mainFrm
    Dim cnstr = "Data Source=RITIKJOSHI22\SQLEXPRESS;Initial Catalog=student_information;Integrated Security=True;TrustServerCertificate=True"

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            Using con As New SqlConnection(cnstr)
                Dim cmd As New SqlCommand("select * from loginInfo where username=@un and password=@pwd", con)
                cmd.Parameters.Add("@un", SqlDbType.VarChar).Value = TextBox1.Text
                cmd.Parameters.Add("@pwd", SqlDbType.VarChar).Value = TextBox2.Text
                Dim adapter As New SqlDataAdapter(cmd)
                Dim dt As New DataTable()
                adapter.Fill(dt)
                con.Open()
                If dt.Rows.Count > 0 Then
                    Dashboard.Show()
                    Me.Hide()
                Else
                    MessageBox.Show("User does not exist")
                End If
                con.Close()
            End Using
        Catch ex As Exception
            MessageBox.Show("An error occurred: " & ex.Message)
        End Try
    End Sub

    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs) Handles Guna2Button1.Click
        Dim con As New SqlConnection(cnstr)
        Dim cmd As New SqlCommand("insert into loginInfo(fullName,mail,dob,username,password)
                                values(@fn,@email,@birth,@un,@pwd)", con)
        cmd.Parameters.Add("@fn", SqlDbType.VarChar).Value = TextBox3.Text
        cmd.Parameters.Add("@email", SqlDbType.VarChar).Value = TextBox4.Text
        cmd.Parameters.Add("@birth", SqlDbType.VarChar).Value = TextBox5.Text
        cmd.Parameters.Add("@un", SqlDbType.VarChar).Value = TextBox6.Text
        cmd.Parameters.Add("@pwd", SqlDbType.VarChar).Value = TextBox7.Text

        con.Open()
        cmd.ExecuteNonQuery()
        con.Close()
    End Sub

    Private Sub DateTimePicker1_ValueChanged_1(sender As Object, e As EventArgs) Handles DateTimePicker1.ValueChanged
        TextBox5.Text = DateTimePicker1.Value.ToShortDateString()
    End Sub
End Class
