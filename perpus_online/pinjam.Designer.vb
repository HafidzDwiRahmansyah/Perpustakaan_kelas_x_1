<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class pinjam
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(pinjam))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.nopinjam = New System.Windows.Forms.Label()
        Me.nama = New System.Windows.Forms.Label()
        Me.alamat = New System.Windows.Forms.Label()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.telepon = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.tanggal = New System.Windows.Forms.Label()
        Me.jam = New System.Windows.Forms.Label()
        Me.namapetugas = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.judul = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.DGV = New System.Windows.Forms.DataGridView()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.LBLPengarang = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.LBLTahun = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.LBLTotalBuku = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        CType(Me.DGV, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Navy
        Me.Label1.Location = New System.Drawing.Point(88, 124)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(95, 31)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "No Pinjaman"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Sitka Heading", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Navy
        Me.Label6.Location = New System.Drawing.Point(335, 40)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(270, 39)
        Me.Label6.TabIndex = 81
        Me.Label6.Text = "TABEL PEMINJAMAN"
        '
        'Label2
        '
        Me.Label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Navy
        Me.Label2.Location = New System.Drawing.Point(88, 155)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(95, 34)
        Me.Label2.TabIndex = 82
        Me.Label2.Text = "Kode Anggota"
        '
        'Label3
        '
        Me.Label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Navy
        Me.Label3.Location = New System.Drawing.Point(88, 189)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(95, 34)
        Me.Label3.TabIndex = 83
        Me.Label3.Text = "Nama"
        '
        'Label4
        '
        Me.Label4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Navy
        Me.Label4.Location = New System.Drawing.Point(88, 223)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(95, 34)
        Me.Label4.TabIndex = 84
        Me.Label4.Text = "Alamat"
        '
        'Label5
        '
        Me.Label5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Navy
        Me.Label5.Location = New System.Drawing.Point(539, 130)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(163, 31)
        Me.Label5.TabIndex = 85
        Me.Label5.Text = "Tanggal"
        '
        'nopinjam
        '
        Me.nopinjam.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.nopinjam.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nopinjam.ForeColor = System.Drawing.Color.Navy
        Me.nopinjam.Location = New System.Drawing.Point(189, 124)
        Me.nopinjam.Name = "nopinjam"
        Me.nopinjam.Size = New System.Drawing.Size(95, 34)
        Me.nopinjam.TabIndex = 86
        Me.nopinjam.Text = "No Pinjam"
        '
        'nama
        '
        Me.nama.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.nama.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nama.ForeColor = System.Drawing.Color.Navy
        Me.nama.Location = New System.Drawing.Point(189, 199)
        Me.nama.Name = "nama"
        Me.nama.Size = New System.Drawing.Size(327, 24)
        Me.nama.TabIndex = 88
        Me.nama.Text = "LBL Nama"
        '
        'alamat
        '
        Me.alamat.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.alamat.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.alamat.ForeColor = System.Drawing.Color.Navy
        Me.alamat.Location = New System.Drawing.Point(189, 223)
        Me.alamat.Name = "alamat"
        Me.alamat.Size = New System.Drawing.Size(327, 34)
        Me.alamat.TabIndex = 89
        Me.alamat.Text = "LBL Alamat"
        '
        'ComboBox1
        '
        Me.ComboBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBox1.ForeColor = System.Drawing.Color.Navy
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(189, 167)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(121, 26)
        Me.ComboBox1.TabIndex = 90
        '
        'telepon
        '
        Me.telepon.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.telepon.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.telepon.ForeColor = System.Drawing.Color.Navy
        Me.telepon.Location = New System.Drawing.Point(189, 257)
        Me.telepon.Name = "telepon"
        Me.telepon.Size = New System.Drawing.Size(327, 24)
        Me.telepon.TabIndex = 91
        Me.telepon.Text = "LBL Telepon"
        '
        'Label7
        '
        Me.Label7.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Navy
        Me.Label7.Location = New System.Drawing.Point(539, 155)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(163, 31)
        Me.Label7.TabIndex = 92
        Me.Label7.Text = "Jam"
        '
        'Label8
        '
        Me.Label8.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Navy
        Me.Label8.Location = New System.Drawing.Point(539, 180)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(163, 31)
        Me.Label8.TabIndex = 93
        Me.Label8.Text = "Petugas"
        '
        'tanggal
        '
        Me.tanggal.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.tanggal.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tanggal.ForeColor = System.Drawing.Color.Navy
        Me.tanggal.Location = New System.Drawing.Point(640, 130)
        Me.tanggal.Name = "tanggal"
        Me.tanggal.Size = New System.Drawing.Size(270, 31)
        Me.tanggal.TabIndex = 94
        Me.tanggal.Text = "LBL Tanggal"
        '
        'jam
        '
        Me.jam.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.jam.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.jam.ForeColor = System.Drawing.Color.Navy
        Me.jam.Location = New System.Drawing.Point(640, 155)
        Me.jam.Name = "jam"
        Me.jam.Size = New System.Drawing.Size(270, 31)
        Me.jam.TabIndex = 95
        Me.jam.Text = "LBL Jam"
        '
        'namapetugas
        '
        Me.namapetugas.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.namapetugas.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.namapetugas.ForeColor = System.Drawing.Color.Navy
        Me.namapetugas.Location = New System.Drawing.Point(640, 180)
        Me.namapetugas.Name = "namapetugas"
        Me.namapetugas.Size = New System.Drawing.Size(270, 31)
        Me.namapetugas.TabIndex = 96
        Me.namapetugas.Text = "LBLNamaPetugas"
        '
        'Label9
        '
        Me.Label9.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.Navy
        Me.Label9.Location = New System.Drawing.Point(88, 299)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(95, 25)
        Me.Label9.TabIndex = 97
        Me.Label9.Text = "Kode Buku"
        '
        'TextBox1
        '
        Me.TextBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.ForeColor = System.Drawing.Color.Navy
        Me.TextBox1.Location = New System.Drawing.Point(189, 304)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(100, 24)
        Me.TextBox1.TabIndex = 98
        '
        'Label10
        '
        Me.Label10.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.Navy
        Me.Label10.Location = New System.Drawing.Point(316, 299)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(95, 25)
        Me.Label10.TabIndex = 99
        Me.Label10.Text = "Judul Buku"
        '
        'judul
        '
        Me.judul.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.judul.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.judul.ForeColor = System.Drawing.Color.Navy
        Me.judul.Location = New System.Drawing.Point(421, 299)
        Me.judul.Name = "judul"
        Me.judul.Size = New System.Drawing.Size(297, 25)
        Me.judul.TabIndex = 100
        Me.judul.Text = "LBL Judul"
        '
        'Label11
        '
        Me.Label11.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.Navy
        Me.Label11.Location = New System.Drawing.Point(724, 299)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(68, 25)
        Me.Label11.TabIndex = 101
        Me.Label11.Text = "Jumlah"
        '
        'TextBox2
        '
        Me.TextBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox2.ForeColor = System.Drawing.Color.Navy
        Me.TextBox2.Location = New System.Drawing.Point(798, 300)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(31, 24)
        Me.TextBox2.TabIndex = 102
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.Navy
        Me.Button1.Location = New System.Drawing.Point(835, 300)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(72, 26)
        Me.Button1.TabIndex = 103
        Me.Button1.Text = "Input"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'DGV
        '
        Me.DGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGV.GridColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.DGV.Location = New System.Drawing.Point(91, 405)
        Me.DGV.Name = "DGV"
        Me.DGV.Size = New System.Drawing.Size(819, 192)
        Me.DGV.TabIndex = 104
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.ForeColor = System.Drawing.Color.Navy
        Me.Button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button2.Location = New System.Drawing.Point(621, 654)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(91, 35)
        Me.Button2.TabIndex = 105
        Me.Button2.Text = "SAVE"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Button3.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.ForeColor = System.Drawing.Color.Navy
        Me.Button3.Location = New System.Drawing.Point(719, 654)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(100, 35)
        Me.Button3.TabIndex = 106
        Me.Button3.Text = "CANCEL"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'Button4
        '
        Me.Button4.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Button4.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button4.ForeColor = System.Drawing.Color.Navy
        Me.Button4.Location = New System.Drawing.Point(830, 654)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(91, 35)
        Me.Button4.TabIndex = 107
        Me.Button4.Text = "CLOSE"
        Me.Button4.UseVisualStyleBackColor = False
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        '
        'LBLPengarang
        '
        Me.LBLPengarang.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.LBLPengarang.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBLPengarang.ForeColor = System.Drawing.Color.Navy
        Me.LBLPengarang.Location = New System.Drawing.Point(189, 342)
        Me.LBLPengarang.Name = "LBLPengarang"
        Me.LBLPengarang.Size = New System.Drawing.Size(327, 28)
        Me.LBLPengarang.TabIndex = 109
        Me.LBLPengarang.Text = "LBL Pengarang"
        '
        'Label13
        '
        Me.Label13.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.Navy
        Me.Label13.Location = New System.Drawing.Point(88, 342)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(95, 28)
        Me.Label13.TabIndex = 108
        Me.Label13.Text = "Pengarang"
        '
        'LBLTahun
        '
        Me.LBLTahun.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.LBLTahun.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBLTahun.ForeColor = System.Drawing.Color.Navy
        Me.LBLTahun.Location = New System.Drawing.Point(621, 342)
        Me.LBLTahun.Name = "LBLTahun"
        Me.LBLTahun.Size = New System.Drawing.Size(286, 28)
        Me.LBLTahun.TabIndex = 111
        Me.LBLTahun.Text = "LBL Alamat"
        '
        'Label15
        '
        Me.Label15.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.ForeColor = System.Drawing.Color.Navy
        Me.Label15.Location = New System.Drawing.Point(520, 342)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(95, 28)
        Me.Label15.TabIndex = 110
        Me.Label15.Text = "Tahun"
        '
        'LBLTotalBuku
        '
        Me.LBLTotalBuku.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.LBLTotalBuku.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBLTotalBuku.ForeColor = System.Drawing.Color.Navy
        Me.LBLTotalBuku.Location = New System.Drawing.Point(741, 612)
        Me.LBLTotalBuku.Name = "LBLTotalBuku"
        Me.LBLTotalBuku.Size = New System.Drawing.Size(156, 27)
        Me.LBLTotalBuku.TabIndex = 113
        Me.LBLTotalBuku.Text = "LBLtotalbuku"
        '
        'Label14
        '
        Me.Label14.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.Color.Navy
        Me.Label14.Location = New System.Drawing.Point(640, 612)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(95, 24)
        Me.Label14.TabIndex = 112
        Me.Label14.Text = "Total Buku"
        '
        'Label12
        '
        Me.Label12.Font = New System.Drawing.Font("Magneto", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.SteelBlue
        Me.Label12.Image = CType(resources.GetObject("Label12.Image"), System.Drawing.Image)
        Me.Label12.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label12.Location = New System.Drawing.Point(3, 9)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(269, 70)
        Me.Label12.TabIndex = 114
        Me.Label12.Text = "erpustakaan"
        Me.Label12.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'pinjam
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(970, 720)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.LBLTotalBuku)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.LBLTahun)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.LBLPengarang)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.DGV)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.judul)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.namapetugas)
        Me.Controls.Add(Me.jam)
        Me.Controls.Add(Me.tanggal)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.telepon)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.alamat)
        Me.Controls.Add(Me.nama)
        Me.Controls.Add(Me.nopinjam)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label1)
        Me.Name = "pinjam"
        Me.Text = "pinjam"
        CType(Me.DGV, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents nopinjam As System.Windows.Forms.Label
    Friend WithEvents nama As System.Windows.Forms.Label
    Friend WithEvents alamat As System.Windows.Forms.Label
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents telepon As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents tanggal As System.Windows.Forms.Label
    Friend WithEvents jam As System.Windows.Forms.Label
    Friend WithEvents namapetugas As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents judul As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents DGV As System.Windows.Forms.DataGridView
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents LBLPengarang As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents LBLTahun As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents LBLTotalBuku As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
End Class
