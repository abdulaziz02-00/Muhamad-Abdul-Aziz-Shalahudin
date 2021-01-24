Public Class frmpengembaliandetail
    Private Sub ClearEntry()
        txtnmrkembali.Text = ""
        txtjudul.Text = ""
        txtnmanggota.Text = ""
        txtnmpetugas.Text = ""
    End Sub
    Private Sub Reload()
        opengembaliandetail.getAllData(DataGridView1)
    End Sub
    Private Sub btnadd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnadd.Click
        SimpanDetail()
    End Sub

    Private Sub SimpanDetail()
        opengembaliandetail.Nomor_Kembali = txtnmrkembali.Text
        opengembaliandetail.Judul = txtjudul.Text
        opengembaliandetail.Nama_Anggota = txtnmanggota.Text
        opengembaliandetail.Nama_Petugas = txtnmpetugas.Text

        pengembalian_baru = True
        opengembaliandetail.Simpan()
        ClearEntry()
        Reload()
    End Sub

    Private Sub btnclear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnclear.Click
        Me.Close()
    End Sub

    Private Sub frmpengembaliandetail_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub


End Class
