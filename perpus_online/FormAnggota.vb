Imports System.Data.Odbc
Public Class FormAnggota
    Sub kondisiawal()
        TextBox1.Text = ""
        TextBox2.Text = ""
        ComboBox1.Text = ""
        TextBox3.Text = ""
        TextBox4.Text = ""
        Call koneksi()
        da = New OdbcDataAdapter("select * from tbl_anggota", Conn)
        ds = New DataSet
        da.Fill(ds, "tbl_anggota")
        DGV.DataSource = (ds.Tables("tbl_anggota"))
        ComboBox1.Items.Clear()
        ComboBox1.Items.Add("Laki-Laki")
        ComboBox1.Items.Add("Perempuan")
    End Sub

    Private Sub FormAnggota_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call kondisiawal()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Call koneksi()
        If TextBox1.Text = "" Or TextBox2.Text = "" Or ComboBox1.Text = "" Or TextBox3.Text = "" Or TextBox4.Text = "" Then
            MsgBox("Mohon isi semua data dengan lengkap")
        Else
            Dim simpanData As String = " insert into tbl_anggota values('" & TextBox1.Text & "','" & TextBox2.Text & "','" & ComboBox1.Text & "','" & TextBox3.Text & "','" & TextBox4.Text & "')"
            cmd = New OdbcCommand(simpanData, Conn)
            cmd.ExecuteNonQuery()
            MsgBox("Data berhasil disimpan")
            Call kondisiawal()
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Call koneksi()
        If TextBox1.Text = "" Or TextBox2.Text = "" Or ComboBox1.Text = "" Or TextBox3.Text = "" Or TextBox4.Text = "" Then
            MsgBox("Mohon isi semua data dengan lengkap")
        Else
            Dim editData As String = "update tbl_anggota set NamaAnggota='" & TextBox2.Text & "', JenisKelamin='" & ComboBox1.Text & "', AlamatAnggota='" & TextBox3.Text & "', TelpAnggota='" & TextBox4.Text & "' where KodeAnggota='" & TextBox1.Text & "'"
            cmd = New OdbcCommand(editData, Conn)
            cmd.ExecuteNonQuery()
            MsgBox("Data berhasil di edit")
            Call kondisiawal()
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Call koneksi()
        If TextBox1.Text = "" Then
            MsgBox("Mohon isi kode petugas yang ingin dihapus")
        Else
            Dim HapusData As String = "delete from tbl_anggota where KodeAnggota='" & TextBox1.Text & "'"
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