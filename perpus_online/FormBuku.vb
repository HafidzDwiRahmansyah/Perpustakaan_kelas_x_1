Imports System.Data.Odbc
Public Class FormBuku
    Sub kondisiawal()
        TextBox1.Text = ""
        TextBox2.Text = ""
        TextBox3.Text = ""
        TextBox4.Text = ""
        TextBox5.Text = ""
        TextBox6.Text = ""
        Call koneksi()
        da = New OdbcDataAdapter("select * from tbl_buku", Conn)
        ds = New DataSet
        da.Fill(ds, "tbl_buku")
        DGV.DataSource = (ds.Tables("tbl_buku"))
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Call koneksi()
        If TextBox1.Text = "" Or TextBox2.Text = "" Or TextBox3.Text = "" Or TextBox4.Text = "" Or TextBox5.Text = "" Or TextBox6.Text = "" Then
            MsgBox("Mohon isi semua data dengan lengkap")
        Else
            Dim simpanData As String = " insert into tbl_buku values('" & TextBox1.Text & "','" & TextBox2.Text & "','" & TextBox3.Text & "','" & TextBox4.Text & "','" & TextBox5.Text & "','" & TextBox6.Text & "')"
            cmd = New OdbcCommand(simpanData, Conn)
            cmd.ExecuteNonQuery()
            MsgBox("Data berhasil disimpan")
            Call kondisiawal()
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Call koneksi()
        If TextBox1.Text = "" Or TextBox2.Text = "" Or TextBox3.Text = "" Or TextBox4.Text = "" Or TextBox5.Text = "" Or TextBox6.Text = "" Then
            MsgBox("Mohon isi semua data dengan lengkap")
        Else
            Dim editData As String = "update tbl_buku set JudulBuku='" & TextBox2.Text & "', Pengarang='" & TextBox3.Text & "', Penerbit='" & TextBox4.Text & "', TahunTerbit='" & TextBox5.Text & "', JumlahBuku='" & TextBox6.Text & "' where KodeBuku='" & TextBox1.Text & "'"
            cmd = New OdbcCommand(editData, Conn)
            cmd.ExecuteNonQuery()
            MsgBox("Data berhasil di edit")
            Call kondisiawal()
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Call koneksi()
        If TextBox1.Text = "" Then
            MsgBox("Mohon isi kode buku yang ingin dihapus !")
        Else
            Dim HapusData As String = "delete from tbl_buku where KodeBuku='" & TextBox1.Text & "'"
            cmd = New OdbcCommand(HapusData, Conn)
            cmd.ExecuteNonQuery()
            MsgBox("Data berhasil di hapus")
            Call kondisiawal()
        End If
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Me.Close()
    End Sub

    Private Sub DGV_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGV.CellContentClick

    End Sub
End Class