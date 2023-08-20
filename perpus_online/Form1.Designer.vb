<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LoginToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LogoutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.KeluarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MasterToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PetugasaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AnggotaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BukuToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TransaksiToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PeminjamanToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PengembalianToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.STLabel1 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.STLabel2 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.STLabel3 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.STLabel4 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.STLabel5 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.STLabel6 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.STLabel7 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.STLabel8 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.MenuStrip1.SuspendLayout()
        Me.StatusStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.AutoSize = False
        Me.MenuStrip1.BackColor = System.Drawing.SystemColors.Control
        Me.MenuStrip1.Font = New System.Drawing.Font("Sitka Display", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem1, Me.FileToolStripMenuItem, Me.MasterToolStripMenuItem, Me.TransaksiToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1370, 70)
        Me.MenuStrip1.Stretch = False
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(12, 66)
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.LoginToolStripMenuItem, Me.LogoutToolStripMenuItem, Me.KeluarToolStripMenuItem})
        Me.FileToolStripMenuItem.ForeColor = System.Drawing.Color.Navy
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(66, 66)
        Me.FileToolStripMenuItem.Text = "FILE"
        '
        'LoginToolStripMenuItem
        '
        Me.LoginToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.LoginToolStripMenuItem.ForeColor = System.Drawing.Color.Navy
        Me.LoginToolStripMenuItem.Name = "LoginToolStripMenuItem"
        Me.LoginToolStripMenuItem.Size = New System.Drawing.Size(144, 34)
        Me.LoginToolStripMenuItem.Text = "login"
        '
        'LogoutToolStripMenuItem
        '
        Me.LogoutToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.LogoutToolStripMenuItem.ForeColor = System.Drawing.Color.Navy
        Me.LogoutToolStripMenuItem.Name = "LogoutToolStripMenuItem"
        Me.LogoutToolStripMenuItem.Size = New System.Drawing.Size(144, 34)
        Me.LogoutToolStripMenuItem.Text = "logout"
        '
        'KeluarToolStripMenuItem
        '
        Me.KeluarToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.KeluarToolStripMenuItem.ForeColor = System.Drawing.Color.Navy
        Me.KeluarToolStripMenuItem.Name = "KeluarToolStripMenuItem"
        Me.KeluarToolStripMenuItem.Size = New System.Drawing.Size(144, 34)
        Me.KeluarToolStripMenuItem.Text = "keluar"
        '
        'MasterToolStripMenuItem
        '
        Me.MasterToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PetugasaToolStripMenuItem, Me.AnggotaToolStripMenuItem, Me.BukuToolStripMenuItem})
        Me.MasterToolStripMenuItem.ForeColor = System.Drawing.Color.Navy
        Me.MasterToolStripMenuItem.Name = "MasterToolStripMenuItem"
        Me.MasterToolStripMenuItem.Size = New System.Drawing.Size(102, 66)
        Me.MasterToolStripMenuItem.Text = "MASTER"
        '
        'PetugasaToolStripMenuItem
        '
        Me.PetugasaToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.PetugasaToolStripMenuItem.ForeColor = System.Drawing.Color.Navy
        Me.PetugasaToolStripMenuItem.Name = "PetugasaToolStripMenuItem"
        Me.PetugasaToolStripMenuItem.Size = New System.Drawing.Size(158, 34)
        Me.PetugasaToolStripMenuItem.Text = "petugas"
        '
        'AnggotaToolStripMenuItem
        '
        Me.AnggotaToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.AnggotaToolStripMenuItem.ForeColor = System.Drawing.Color.Navy
        Me.AnggotaToolStripMenuItem.Name = "AnggotaToolStripMenuItem"
        Me.AnggotaToolStripMenuItem.Size = New System.Drawing.Size(158, 34)
        Me.AnggotaToolStripMenuItem.Text = "anggota"
        '
        'BukuToolStripMenuItem
        '
        Me.BukuToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.BukuToolStripMenuItem.ForeColor = System.Drawing.Color.Navy
        Me.BukuToolStripMenuItem.Name = "BukuToolStripMenuItem"
        Me.BukuToolStripMenuItem.Size = New System.Drawing.Size(158, 34)
        Me.BukuToolStripMenuItem.Text = "Buku"
        '
        'TransaksiToolStripMenuItem
        '
        Me.TransaksiToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PeminjamanToolStripMenuItem, Me.PengembalianToolStripMenuItem})
        Me.TransaksiToolStripMenuItem.ForeColor = System.Drawing.Color.Navy
        Me.TransaksiToolStripMenuItem.Name = "TransaksiToolStripMenuItem"
        Me.TransaksiToolStripMenuItem.Size = New System.Drawing.Size(131, 66)
        Me.TransaksiToolStripMenuItem.Text = "TRANSAKSI"
        '
        'PeminjamanToolStripMenuItem
        '
        Me.PeminjamanToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.PeminjamanToolStripMenuItem.ForeColor = System.Drawing.Color.Navy
        Me.PeminjamanToolStripMenuItem.Name = "PeminjamanToolStripMenuItem"
        Me.PeminjamanToolStripMenuItem.Size = New System.Drawing.Size(212, 34)
        Me.PeminjamanToolStripMenuItem.Text = "peminjaman "
        '
        'PengembalianToolStripMenuItem
        '
        Me.PengembalianToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.PengembalianToolStripMenuItem.ForeColor = System.Drawing.Color.Navy
        Me.PengembalianToolStripMenuItem.Name = "PengembalianToolStripMenuItem"
        Me.PengembalianToolStripMenuItem.Size = New System.Drawing.Size(212, 34)
        Me.PengembalianToolStripMenuItem.Text = "pengembalian"
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.STLabel1, Me.STLabel2, Me.STLabel3, Me.STLabel4, Me.STLabel5, Me.STLabel6, Me.STLabel7, Me.STLabel8})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 727)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(1370, 22)
        Me.StatusStrip1.TabIndex = 1
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'STLabel1
        '
        Me.STLabel1.Name = "STLabel1"
        Me.STLabel1.Size = New System.Drawing.Size(42, 17)
        Me.STLabel1.Text = "KODE :"
        '
        'STLabel2
        '
        Me.STLabel2.Name = "STLabel2"
        Me.STLabel2.Size = New System.Drawing.Size(0, 17)
        '
        'STLabel3
        '
        Me.STLabel3.Name = "STLabel3"
        Me.STLabel3.Size = New System.Drawing.Size(49, 17)
        Me.STLabel3.Text = "NAMA :"
        '
        'STLabel4
        '
        Me.STLabel4.Name = "STLabel4"
        Me.STLabel4.Size = New System.Drawing.Size(0, 17)
        '
        'STLabel5
        '
        Me.STLabel5.Name = "STLabel5"
        Me.STLabel5.Size = New System.Drawing.Size(44, 17)
        Me.STLabel5.Text = "LEVEL :"
        '
        'STLabel6
        '
        Me.STLabel6.Name = "STLabel6"
        Me.STLabel6.Size = New System.Drawing.Size(0, 17)
        '
        'STLabel7
        '
        Me.STLabel7.Name = "STLabel7"
        Me.STLabel7.Size = New System.Drawing.Size(65, 17)
        Me.STLabel7.Text = "TANGGAL :"
        '
        'STLabel8
        '
        Me.STLabel8.Name = "STLabel8"
        Me.STLabel8.Size = New System.Drawing.Size(0, 17)
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Image = CType(resources.GetObject("Label1.Image"), System.Drawing.Image)
        Me.Label1.Location = New System.Drawing.Point(-3, 70)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(1370, 633)
        Me.Label1.TabIndex = 116
        '
        'Label12
        '
        Me.Label12.BackColor = System.Drawing.SystemColors.Control
        Me.Label12.Font = New System.Drawing.Font("Magneto", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.SteelBlue
        Me.Label12.Image = CType(resources.GetObject("Label12.Image"), System.Drawing.Image)
        Me.Label12.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label12.Location = New System.Drawing.Point(1101, 0)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(269, 70)
        Me.Label12.TabIndex = 115
        Me.Label12.Text = "erpustakaan"
        Me.Label12.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1370, 749)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents ToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents FileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LoginToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LogoutToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents KeluarToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MasterToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PetugasaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AnggotaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TransaksiToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PeminjamanToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PengembalianToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents BukuToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents STLabel1 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents STLabel2 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents STLabel3 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents STLabel4 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents STLabel5 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents STLabel6 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents STLabel7 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents STLabel8 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label

End Class
