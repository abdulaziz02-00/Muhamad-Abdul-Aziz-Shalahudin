Public Class frmpeminjaman


    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        SimpanBarang()
        GetData()

        MessageBox.Show("Data Disimpan")
        frmpeminjamandetail.ShowDialog()
    End Sub

    Private Sub btnClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClear.Click
        ClearEntry()
    End Sub

    Private Sub btnRefresh_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRefresh.Click
        GetData()
    End Sub

    Private Sub txtttlpinjam_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtttlpinjam.KeyDown
        If (e.KeyCode = Keys.Enter And txtttlpinjam.Text <> "") Then
            opeminjaman.Caripeminjaman(txtttlpinjam.Text)
            txtnmrbuku.Text = opeminjaman.Nomor_Buku
            txtjudul.Text = opeminjaman.Judul
            txtnmranggota.Text = opeminjaman.Nomor_Anggota
            txtnmanggota.Text = opeminjaman.Nama_Anggota
            txtkdpetugas.Text = opeminjaman.Kode_Petugas
            txtnmpetugas.Text = opeminjaman.Nama_Petugas

        End If
    End Sub
    Private Sub ClearEntry()
        txtnmrpinjam.Clear()
        txtttlpinjam.Clear()
        txtnmrbuku.Clear()
        txtjudul.Clear()
        txtnmranggota.Clear()
        txtnmanggota.Clear()
        txtkdpetugas.Clear()
        txtnmpetugas.Clear()
    End Sub
    Private Sub TampilData()
        txtnmrpinjam.Text = opeminjaman.Nomor_Pinjam
        txtttlpinjam.Text = opeminjaman.Total_Pinjam
        txtnmrbuku.Text = opeminjaman.Nomor_Buku
        txtjudul.Text = opeminjaman.Judul
        txtnmranggota.Text = opeminjaman.Nomor_Anggota
        txtnmanggota.Text = opeminjaman.Nama_Anggota
        txtkdpetugas.Text = opeminjaman.Kode_Petugas
        txtnmpetugas.Text = opeminjaman.Nama_Petugas

    End Sub
    Private Sub SimpanBarang()
        peminjaman_baru = True
        opeminjaman.Nomor_Pinjam = txtnmrpinjam.Text
        opeminjaman.Total_Pinjam = txtttlpinjam.Text
        opeminjaman.Nomor_Buku = txtnmrbuku.Text
        opeminjaman.Judul = txtjudul.Text
        opeminjaman.Nomor_Anggota = txtnmranggota.Text
        opeminjaman.Nama_Anggota = txtnmanggota.Text
        opeminjaman.Kode_Petugas = txtkdpetugas.Text
        opeminjaman.Nama_Petugas = txtnmpetugas.Text
    End Sub
    Private Sub GetData()
        opeminjaman.getAllData(DataGridView1)
    End Sub


    Private Sub frmpeminjaman_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class
