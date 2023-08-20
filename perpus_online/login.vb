Imports System.Data.Odbc
Public Class login

    Private Sub cancel_Click(sender As Object, e As EventArgs) Handles cancel.Click
        Me.Close()
    End Sub

    Private Sub save_Click(sender As Object, e As EventArgs) Handles save.Click
        Call koneksi()
        cmd = New OdbcCommand("select * from tbl_petugas where KodePetugas='" & TextBox1.Text & "' and PasswordPetugas='" & TextBox2.Text & "'", Conn)
        rd = cmd.ExecuteReader
        rd.Read()
        If rd.HasRows Then
            Me.Close()
            Call BukaKunci()
            Form1.STLabel2.Text = rd!Kodepetugas
            Form1.STLabel4.Text = rd!namapetugas
            Form1.STLabel6.Text = rd!levelpetugas
        Else
            MsgBox("Password yang anda masukan salah atau data yang anda masukan salah !")
        End If
    End Sub

    Sub BukaKunci()
        Form1.LoginToolStripMenuItem.Enabled = False
        Form1.LogoutToolStripMenuItem.Enabled = True
        Form1.MasterToolStripMenuItem.Enabled = True
        Form1.TransaksiToolStripMenuItem.Enabled = True
    End Sub

    Private Sub login_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TextBox1.Text = ""
        TextBox2.Text = ""
        TextBox2.PasswordChar = "*"
    End Sub
End Class