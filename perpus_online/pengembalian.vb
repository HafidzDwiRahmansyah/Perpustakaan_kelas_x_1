Imports System.Data.Odbc
Public Class pengembalian
    Sub kondisiawal()
        Textkodeagt.Text = ""
        TextBox1.Text = ""
        TextBox2.Text = ""
        judul.Text = ""
        TextBox2.Text = ""
        tglpinjam.Text = ""
        Lbldenda.Text = ""
        LBLnopinjam.Text = ""
        namaagt.Text = ""
        Textdibayar.Text = ""
        denda.Text = ""
        Lblkembali.Text = ""
    End Sub

    Sub kondisiawal2()
        TextBox1.Text = ""
        TextBox2.Text = ""
        judul.Text = ""
        TextBox2.Text = ""
        tglpinjam.Text = ""
        Lbldenda.Text = ""
        LBLnopinjam.Text = ""
    End Sub

    Sub tampilDGV()
        DGV.Columns.Clear()
        DGV.Columns.Add("Nomer", "No Kembali")
        DGV.Columns.Add("nama", "Nama Anggota")
        DGV.Columns.Add("Nama", "Nama Petugas")
        DGV.Columns.Add("Tanggal", "Tgl Pinjam")
        DGV.Columns(0).Width = 50
        DGV.Columns(1).Width = 75
        DGV.Columns(2).Width = 75
        DGV.Columns(3).Width = 75
    End Sub

    Sub tampilDataGridView1()
        DataGridView1.Columns.Add("Kode", "Kode")
        DataGridView1.Columns.Add("Judul", "Judul Buku")
        DataGridView1.Columns.Add("Jumlah", "Jumlah")
        DataGridView1.Columns(0).Width = 75
        DataGridView1.Columns(1).Width = 300
        DataGridView1.Columns(2).Width = 100
        DataGridView1.ReadOnly = True
    End Sub

    Sub Otomatis()
        Call koneksi()
        cmd = New OdbcCommand("select * from tbl_kembali where nokembali in (select max(nokembali) from tbl_kembali)", Conn)
        Dim UrutanKode As String
        Dim Hitung As Long
        rd = cmd.ExecuteReader
        rd.Read()
        If Not rd.HasRows Then
            UrutanKode = "kmbl" + Format(Now, "yyMMdd") + "001"
        Else
            Hitung = Microsoft.VisualBasic.Right(rd.GetString(0), 9) + 1
            UrutanKode = "kbml" + Format(Now, "yyMMdd") + Microsoft.VisualBasic.Right("000" & Hitung, 3)
        End If
        nokembali.Text = UrutanKode
        TextBox2.Focus()
    End Sub

    Private Sub pengembalian_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        koneksi()
        Call Otomatis()
        tanggalkbl.Text = Today
    End Sub

    Private Sub pengembalian_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call kondisiawal()
        Call koneksi()
        Call tampilDGV()
        Call Otomatis()
        jam.Text = TimeOfDay
        namapetugas.Text = Form1.STLabel4.Text
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        jam.Text = TimeOfDay
    End Sub

    Sub munculkandata()
        Call koneksi()
        da = New OdbcDataAdapter("select * from tbl_pinjam where kodeanggota='" & Textkodeagt.Text & "'", Conn)
        ds = New DataSet
        da.Fill(ds, "tbl_detailpinjam")
        DataGridView1.DataSource = ds.Tables("tbl_detailpinjam")
        DataGridView1.ReadOnly = True
    End Sub

    Sub caridata()
        Call koneksi()
        cmd = New OdbcCommand("select * from tbl_anggota where KodeAnggota ='" & Textkodeagt.Text & "'", Conn)
        rd = cmd.ExecuteReader
        rd.Read()
        If rd.HasRows Then
            namaagt.Text = rd.Item("NamaAnggota")
            Call koneksi()
            cmd = New OdbcCommand("select KodeAnggota from tbl_pinjam where KodeAnggota = '" & Textkodeagt.Text & "'", Conn)
            rd = cmd.ExecuteReader
            rd.Read()
            If rd.HasRows Then
                Call koneksi()
                cmd = New OdbcCommand("select sum(totalpinjam) as ketemu from tbl_pinjam where KodeAnggota='" & Textkodeagt.Text & "'", Conn)
                rd = cmd.ExecuteReader
                rd.Read()
                Call munculkandata()
            End If
        End If
    End Sub

    Sub caridata2()
        Call koneksi()
        cmd = New OdbcCommand("select * from tbl_detailpinjam where kodebuku ='" & TextBox1.Text & "'", Conn)
        rd = cmd.ExecuteReader
        rd.Read()
        If rd.HasRows Then
            judul.Text = rd.Item("judulbuku")
            LBLnopinjam.Text = rd.Item("nopinjam")
            Call koneksi()
            cmd = New OdbcCommand("select kodebuku from tbl_detailpinjam where kodebuku = '" & TextBox1.Text & "'", Conn)
            rd = cmd.ExecuteReader
            rd.Read()
            If rd.HasRows Then
                Call koneksi()
                cmd = New OdbcCommand("select sum(totalpinjam) as ketemu from tbl_pinjam where KodeAnggota='" & TextBox1.Text & "'", Conn)
                rd = cmd.ExecuteReader
                Call munculkandata()
            End If

            Call koneksi()
            cmd = New OdbcCommand("select * from tbl_pinjam where nopinjam='" & LBLnopinjam.Text & "'", Conn)
            rd = cmd.ExecuteReader
            rd.Read()
            If rd.HasRows Then
                tglpinjam.Text = rd.Item("tglpinjam")
            End If
        End If
    End Sub
    Private Sub Textkodeagt_TextChanged(sender As Object, e As EventArgs) Handles Textkodeagt.TextChanged
        Call caridata()
        Call munculkandata()
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        Call koneksi()
        Call munculkandata()
        Call caridata2()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Me.Close()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Call koneksi()
        If nokembali.Text = "" Or namaagt.Text = "" Or namapetugas.Text = "" Or tglpinjam.Text = "" Then
            MsgBox("Mohon isi semua data dengan lengkap")
        Else
            Dim simpanData As String = " insert into tbl_kembali values('" & nokembali.Text & "','" & tglpinjam.Text & "','" & namaagt.Text & "','" & namapetugas.Text & "')"
            cmd = New OdbcCommand(simpanData, Conn)
            cmd.ExecuteNonQuery()
            MsgBox("Data berhasil disimpan")
            Call kondisiawal()
            Call tampilDGV()
        End If
    End Sub
End Class