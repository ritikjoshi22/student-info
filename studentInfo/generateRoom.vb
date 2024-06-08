Imports System.Data.SqlClient
Imports System.Windows.Forms

Public Class generateRoom
    Inherits Form

    Private Function ColumnExists(con As SqlConnection, tableName As String, columnName As String) As Boolean
        ' Check if the column exists in the database table
        Dim query As String = $"SELECT COUNT(*) FROM INFORMATION_SCHEMA.COLUMNS WHERE TABLE_NAME = '{tableName}' AND COLUMN_NAME = '{columnName}'"
        Using cmd As New SqlCommand(query, con)
            Dim count As Integer = Convert.ToInt32(cmd.ExecuteScalar())
            Return count > 0
        End Using
    End Function

    Private Sub CreateRoomNumberColumn(con As SqlConnection)
        ' Create the roomNumber column in the database table
        Dim query As String = "ALTER TABLE student_data ADD roomNumber INT"
        Using cmd As New SqlCommand(query, con)
            cmd.ExecuteNonQuery()
        End Using
    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            Dim cnstr As String = "Data Source=RITIKJOSHI22\SQLEXPRESS;Initial Catalog=student_information;Integrated Security=True;TrustServerCertificate=True"
            Using con As New SqlConnection(cnstr)
                con.Open() ' Open connection

                ' Check if the roomNumber column exists, if not, create it
                If Not ColumnExists(con, "student_data", "roomNumber") Then
                    CreateRoomNumberColumn(con)
                End If

                Dim query As String = "SELECT sid, fullName FROM student_data"
                Using cmd As New SqlCommand(query, con)
                    Dim adapter As New SqlDataAdapter(cmd)
                    Dim dt As New DataTable()
                    adapter.Fill(dt)

                    ' Check if there are any students
                    If dt.Rows.Count = 0 Then
                        MessageBox.Show("No students found.")
                        Return
                    End If

                    ' Allocate rooms randomly
                    Dim rand As New Random()
                    Dim roomAllocations As New DataTable()
                    roomAllocations.Columns.Add("ID", GetType(Integer))
                    roomAllocations.Columns.Add("FullName", GetType(String))
                    roomAllocations.Columns.Add("RoomNumber", GetType(Integer))

                    For Each row As DataRow In dt.Rows
                        Dim roomNumber As Integer = rand.Next(1, 11)
                        roomAllocations.Rows.Add(row("sid"), row("fullName"), roomNumber)
                    Next

                    ' Save allocations back to the database
                    For Each row As DataRow In roomAllocations.Rows
                        Dim updateQuery As String = "UPDATE student_data SET roomNumber = @roomNumber WHERE sid = @id"
                        Using updateCmd As New SqlCommand(updateQuery, con)
                            updateCmd.Parameters.Add("@roomNumber", SqlDbType.Int).Value = row("RoomNumber")
                            updateCmd.Parameters.Add("@id", SqlDbType.Int).Value = row("ID")
                            updateCmd.ExecuteNonQuery()
                        End Using
                    Next
                    MsgBox("Room allocation completed.")
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("An error occurred: " & ex.Message)
        End Try
    End Sub

    Private Sub Button2_Click_1(sender As Object, e As EventArgs) Handles Button2.Click
        studentlist.Close()
        studentAdd.Close()
        studentremove.Close()
        studentSearch.Close()
        studentupdate.Close()
        Me.Close()
        viewRoom.Show()
    End Sub

End Class
