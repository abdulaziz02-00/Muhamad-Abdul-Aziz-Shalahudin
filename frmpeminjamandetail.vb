Public Class frmpeminjamandetail
    Private Sub ClearEntry()
        txtnmrpinjam.Text = ""
        txtjudul.Text = ""
        txtnmanggota.Text = ""
        txtnmpetugas .Text = ""
    End Sub
    Private Sub Reload()
        opeminjamandetail.getAllData(DataGridView1)
    End Sub
    Private Sub btnadd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnadd.Click
        SimpanDetail()
    End Sub

    Private Sub SimpanDetail()
        opeminjamandetail.Nomor_Pinjam = txtnmrpinjam.Text
        opeminjamandetail.Judul = txtjudul.Text
        opeminjamandetail.Nama_Anggota = txtnmanggota.Text
        opeminjamandetail.Nama_Petugas = txtnmpetugas.Text

        peminjamandetail_baru = True
        opeminjamandetail.Simpan()
        ClearEntry()
        Reload()
    End Sub

    Private Sub btnclear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnclear.Click
        Me.Close()
    End Sub

    Private Sub frmpeminjamandetail_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub


End Class
