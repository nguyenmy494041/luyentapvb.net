Public Class Form1
    Private Sub ThêmMớiToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ThêmMớiToolStripMenuItem.Click
        Dim fromthemmoi = New FrmAddNewStudent()
        fromthemmoi.Show()
    End Sub

    Private Sub DanhSáchHọcSinhToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DanhSáchHọcSinhToolStripMenuItem.Click
        Dim frm = New FrmListStudent()
        frm.Show()
    End Sub
End Class
