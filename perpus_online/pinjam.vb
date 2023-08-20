Imports System.Data.Odbc
Public Class pinjam

    Sub kondisiawal()
        Call NoOtomatis()
        Call MunculKodeAnggota()
        namapetugas.Text = Form1.STLabel4.Text
        nama.Text = ""
        alamat.Text = ""
        telepon.Text = ""
        judul.Text = ""
        Call BuatKolom()
    End Sub
    Private Sub pinjam_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call kondisiawal()
        tanggal.Text = Today
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        jam.Text = TimeOfDay
    End Sub
    Sub NoOtomatis()
        Call koneksi()
        cmd = New OdbcCommand("select * from tbl_pinjam where nopinjam in (select max(nopinjam) from tbl_pinjam)", Conn)
        Dim UrutanKode As String
        Dim Hitung As Long
        rd = cmd.ExecuteReader
        rd.Read()
        If Not rd.HasRows Then
            UrutanKode = "PJM" + Format(Now, "yyMMdd") + "001"
        Else
            Hitung = Microsoft.VisualBasic.Right(rd.GetString(0), 9) + 1
            UrutanKode = "PJM" + Format(Now, "yyMMdd") + Microsoft.VisualBasic.Right("000" & Hitung, 3)
        End If
        nopinjam.Text = UrutanKode
        TextBox2.Focus()
    End Sub
    Sub MunculKodeAnggota()
        Call koneksi()
        ComboBox1.Items.Clear()
        cmd = New OdbcCommand("select * from tbl_anggota", Conn)
        rd = cmd.ExecuteReader
        Do While rd.Read
            ComboBox1.Items.Add(rd.Item(0))
        Loop
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        Call koneksi()
        cmd = New OdbcCommand("select * from tbl_anggota where kodeanggota='" & ComboBox1.Text & "'", Conn)
        rd = cmd.ExecuteReader
        rd.Read()
        If rd.HasRows Then
            nama.Text = rd!NamaAnggota
            alamat.Text = rd!AlamatAnggota
            telepon.Text = rd!TelpAnggota
        End If
    End Sub

    Sub BuatKolom()
        DGV.Columns.Clear()
        DGV.Columns.Add("Kode", "KodeBuku")
        DGV.Columns.Add("Judul", "JudulBuku")
        DGV.Columns.Add("Pengarang", "Pengarang")
        DGV.Columns.Add("Penerbit", "Penerbit")
        DGV.Columns.Add("Jumlah", "Jumlah")
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        Call koneksi()
        cmd = New OdbcCommand("select * from tbl_buku where KodeBuku='" & TextBox1.Text & "'", Conn)
        rd = cmd.ExecuteReader
        rd.Read()
        If Not rd.HasRows Then
            MsgBox("kode buku tidak ada")
        Else
            TextBox1.Text = rd.Item("KodeBuku")
            judul.Text = rd.Item("JudulBuku")
            LBLPengarang.Text = rd.Item("Pengarang")
            LBLTahun.Text = rd.Item("TahunTerbit")
            TextBox2.Enabled = True
            TextBox2.Text = "1"
        End If
    End Sub

    Sub hitungtotal()
        Dim hitung As Integer
        For baris As Integer = 0 To DGV.RowCount - 1
            hitung = hitung + DGV.Rows(baris).Cells(4).Value
        Next
        LBLTotalBuku.Text = hitung
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If LBLTotalBuku.Text = (LBLTotalBuku.Text) + (TextBox2.Text) Then
            MsgBox("buku yang dipinjam melebihi maksimal!")
        Else
            If judul.Text = "" Or TextBox2.Text = "" Then
                MsgBox("silahkan masukan kode buku dan tekan ENTER !")
            Else
                DGV.Rows.Add(New String() {TextBox1.Text, judul.Text, LBLPengarang.Text, LBLTahun.Text, TextBox2.Text})
                TextBox1.Text = ""
                TextBox2.Text = ""
                judul.Text = ""
                LBLPengarang.Text = ""
                LBLTahun.Text = ""
                Call hitungtotal()
            End If
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If nama.Text = "" Or Label9.Text = "" Then
            MsgBox("Transaksi tidak ada, Silahkan lakukan transaksi terlebih dahulu")
        Else
            Call koneksi()
            Dim tglodbc As String
            tglodbc = Format(Today, "yyyy-MM-dd")
            Dim pinjam As String = "insert into tbl_pinjam values ('" & nopinjam.Text & "','" & tglodbc & "','" & jam.Text & "','" & ComboBox1.Text & "','" & LBLTotalBuku.Text & "','" & LBLTotalBuku.Text & "','" & Form1.STLabel2.Text & "')"
            cmd = New OdbcCommand(pinjam, Conn)
            cmd.ExecuteNonQuery()

            For baris As Integer = 0 To DGV.RowCount - 2
                Call koneksi()
                Dim SimpanDetail As String = "insert into tbl_detailpinjam values ('" & nopinjam.Text & "','" & DGV.Rows(baris).Cells(0).Value & "','" & DGV.Rows(baris).Cells(1).Value & "','" & DGV.Rows(baris).Cells(4).Value & "')"
                cmd = New OdbcCommand(SimpanDetail, Conn)
                cmd.ExecuteNonQuery()
                Call koneksi()
                cmd = New OdbcCommand("select * from tbl_buku where KodeBuku ='" & DGV.Rows(baris).Cells(0).Value & "'", Conn)
                rd = cmd.ExecuteReader
                rd.Read()
                Call koneksi()
                Dim kurangistock As String = "Update tbl_buku set JumlahBuku='" & rd.Item("JumlahBuku") - DGV.Rows(baris).Cells(4).Value & "' where KodeBuku='" & DGV.Rows(baris).Cells(0).Value & "'"
                cmd = New OdbcCommand(kurangistock, Conn)
                cmd.ExecuteNonQuery()
            Next
            Call kondisiawal()
            MsgBox(" Transaksi telah berhasil disimpan")
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Call kondisiawal()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Me.Close()
    End Sub
End Class