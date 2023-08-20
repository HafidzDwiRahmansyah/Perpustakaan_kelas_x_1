Imports System.Data.Odbc
Public Class FormPetugas

    Sub kondisiawal()
        TextBox1.Text = ""
        TextBox2.Text = ""
        TextBox3.Text = ""
        ComboBox1.Text = ""
        Call koneksi()
        da = New OdbcDataAdapter("select * from tbl_petugas", Conn)
        ds = New DataSet
        da.Fill(ds, "tbl_petugas")
        DGV.DataSource = (ds.Tables("tbl_petugas"))
        ComboBox1.Items.Clear()
        ComboBox1.Items.Add("ADMIN 1")
        ComboBox1.Items.Add("ADMIN 2")
    End Sub

    Private Sub FormPetugas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call kondisiawal()
        TextBox1.MaxLength = 10
        TextBox2.MaxLength = 50
        TextBox3.MaxLength = 50
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Call koneksi()
        If TextBox1.Text = "" Or TextBox2.Text = "" Or TextBox3.Text = "" Or ComboBox1.Text = "" Then
            MsgBox("Mohon isi semua data dengan lengkap")
        Else
            Dim simpanData As String = " insert into tbl_petugas values('" & TextBox1.Text & "','" & TextBox2.Text & "','" & TextBox3.Text & "','" & ComboBox1.Text & "')"
            cmd = New OdbcCommand(simpanData, Conn)
            cmd.ExecuteNonQuery()
            MsgBox("Data berhasil disimpan")
            Call kondisiawal()
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Call koneksi()
        If TextBox1.Text = "" Or TextBox2.Text = "" Or TextBox3.Text = "" Or ComboBox1.Text = "" Then
            MsgBox("Mohon isi semua data dengan lengkap")
        Else
            Dim editData As String = "update tbl_petugas set namapetugas='" & TextBox2.Text & "', passwordpetugas='" & TextBox3.Text & "', levelpetugas='" & ComboBox1.Text & "' where kodepetugas='" & TextBox1.Text & "'"
            cmd = New OdbcCommand(editData, Conn)
            cmd.ExecuteNonQuery()
            MsgBox("Data berhasil di edit")
            Call kondisiawal()
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Call koneksi()
        If TextBox1.Text = "" Then
            MsgBox("Mohon isi kode anggota yang ingin dihapus")
        Else
            Dim HapusData As String = "delete from tbl_petugas where kodepetugas='" & TextBox1.Text & "'"
            cmd = New OdbcCommand(HapusData, Conn)
            cmd.ExecuteNonQuery()
            MsgBox("Data berhasil di hapus")
            Call kondisiawal()
        End If
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Me.Close()
    End Sub
End Class