Public Class frmpengembalian


    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnsave.Click
        SimpanBarang()
        GetData()

        MessageBox.Show("Data Disimpan")
        frmpengembaliandetail.ShowDialog()
    End Sub

    Private Sub btnClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnclear.Click
        ClearEntry()
    End Sub

    Private Sub btnRefresh_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnrefresh.Click
        GetData()
    End Sub

    Private Sub txtnmrbuku_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtnmrbuku.KeyDown
        If (e.KeyCode = Keys.Enter And txtnmrbuku.Text <> "") Then
            opengembalian.Caripengembalian(txtnmrbuku.Text)
            txtjudul.Text = opengembalian.Judul
            txtttlkembali.Text = opengembalian.Total_Kembali
            txtdenda.Text = opengembalian.Denda
            txtnmranggota.Text = opengembalian.Nomor_Anggota
            txtnmanggota.Text = opengembalian.Nama_Anggota
            txtkdpetugas.Text = opengembalian.Kode_Petugas
            txtnmpetugas.Text = opengembalian.Nama_Petugas

        End If
    End Sub
    Private Sub ClearEntry()
        txtnmrkembali.Clear()
        txtnmrbuku.Clear()
        txtjudul.Clear()
        txtttlkembali.Clear()
        txtdenda.Clear()
        txtnmranggota.Clear()
        txtnmanggota.Clear()
        txtkdpetugas.Clear()
        txtnmpetugas.Clear()

    End Sub
    Private Sub TampilData()
        txtnmrkembali.Text = opengembalian.Nomor_Kembali
        txtnmrbuku.Text = opengembalian.Nomor_Buku
        txtjudul.Text = opengembalian.Judul
        txtttlkembali.Text = opengembalian.Total_Kembali
        txtdenda.Text = opengembalian.Denda
        txtnmranggota.Text = opengembalian.Nomor_Anggota
        txtnmanggota.Text = opengembalian.Nama_Anggota
        txtkdpetugas.Text = opengembalian.Kode_Petugas
        txtnmpetugas.Text = opengembalian.Nama_Petugas

    End Sub
    Private Sub SimpanBarang()
        pengembalian_baru = True
        opengembalian.Nomor_Kembali = txtnmrkembali.Text
        opengembalian.Nomor_Buku = txtnmrbuku.Text
        opengembalian.Judul = txtjudul.Text
        opengembalian.Total_Kembali = txtttlkembali.Text
        opengembalian.Denda = txtdenda.Text
        opengembalian.Nomor_Anggota = txtnmranggota.Text
        opengembalian.Nama_Anggota = txtnmanggota.Text
        opengembalian.Kode_Petugas = txtkdpetugas.Text
        opengembalian.Nama_Petugas = txtnmpetugas.Text

    End Sub
    Private Sub GetData()
        opengembalian.getAllData(DataGridView1)
    End Sub


    Private Sub frmpengembalian_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class
