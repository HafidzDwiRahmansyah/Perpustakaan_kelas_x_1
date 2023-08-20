Public Class Form1

    Private Sub KeluarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles KeluarToolStripMenuItem.Click
        End
    End Sub

    Sub Terkunci()
        LoginToolStripMenuItem.Enabled = True
        LogoutToolStripMenuItem.Enabled = False
        MasterToolStripMenuItem.Enabled = False
        TransaksiToolStripMenuItem.Enabled = False
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call Terkunci()
        STLabel8.Text = Today
    End Sub

    Private Sub LoginToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LoginToolStripMenuItem.Click
        login.ShowDialog()
    End Sub

    Private Sub LogoutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LogoutToolStripMenuItem.Click
        Call Terkunci()
    End Sub

    Private Sub PetugasaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PetugasaToolStripMenuItem.Click
        FormPetugas.ShowDialog()
    End Sub

    Private Sub AnggotaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AnggotaToolStripMenuItem.Click
        FormAnggota.ShowDialog()
    End Sub

    Private Sub MasterToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MasterToolStripMenuItem.Click

    End Sub

    Private Sub FileToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FileToolStripMenuItem.Click

    End Sub

    Private Sub BukuToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BukuToolStripMenuItem.Click
        FormBuku.ShowDialog()
    End Sub

    Private Sub PeminjamanToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PeminjamanToolStripMenuItem.Click
        pinjam.ShowDialog()
    End Sub

    Private Sub PengembalianToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PengembalianToolStripMenuItem.Click
        pengembalian.ShowDialog()
    End Sub
End Class