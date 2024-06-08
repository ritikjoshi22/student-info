Public Class Dashboard

    Private Sub AddToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AddToolStripMenuItem.Click
        studentAdd.Show()
        studentlist.Close()
        studentsearch.Close()
        studentupdate.Close()
        studentremove.Close()
        generateRoom.Close()
        viewRoom.Close()
    End Sub

    Private Sub RemoveToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RemoveToolStripMenuItem.Click
        studentremove.Show()
        studentAdd.Close()
        studentlist.Close()
        studentsearch.Close()
        studentupdate.Close()
        generateRoom.Close()
        viewRoom.Close()
    End Sub

    Private Sub UpdateToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles UpdateToolStripMenuItem.Click
        studentupdate.Show()
        studentAdd.Close()
        studentlist.Close()
        studentsearch.Close()
        studentremove.Close()
        generateRoom.Close()
        viewRoom.Close()
    End Sub

    Private Sub SearchToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SearchToolStripMenuItem.Click
        studentsearch.Show()
        studentAdd.Close()
        studentlist.Close()
        studentremove.Close()
        studentupdate.Close()
        generateRoom.Close()
        viewRoom.Close()
    End Sub

    Private Sub ListToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ListToolStripMenuItem.Click
        studentlist.Show()
        studentAdd.Close()
        studentremove.Close()
        studentsearch.Close()
        studentupdate.Close()
        generateRoom.Close()
        viewRoom.Close()
    End Sub

    Private Sub GenerateNewToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GenerateNewToolStripMenuItem.Click
        studentlist.Close()
        studentAdd.Close()
        studentremove.Close()
        studentSearch.Close()
        studentupdate.Close()
        generateRoom.Show()
        viewRoom.Close()
    End Sub

    Private Sub ViewRoomToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ViewRoomToolStripMenuItem.Click
        studentlist.Close()
        studentAdd.Close()
        studentremove.Close()
        studentSearch.Close()
        studentupdate.Close()
        generateRoom.Close()
        viewRoom.Show()
    End Sub
End Class