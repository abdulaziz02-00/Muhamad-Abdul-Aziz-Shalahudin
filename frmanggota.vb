Public Class frmanggota


    Private Sub btnsave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnsave.Click
        SimpanBarang()
        GetData()
    End Sub

    Private Sub btnclear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnclear.Click
        ClearEntry()
    End Sub

    Private Sub btnrefresh_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnrefresh.Click
        GetData()
    End Sub

    Private Sub txtnmanggota_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtnmanggota.KeyDown
        If (e.KeyCode = Keys.Enter And txtnmanggota.Text <> "") Then
            oanggota.Carianggota(txtnmanggota.Text)
            txtalamat.Text = oanggota.Alamat_Anggota
            txtnmrtelpon.Text = oanggota.Telepon_Anggota

        End If
    End Sub
    Private Sub ClearEntry()
        txtnmranggota.Clear()
        txtnmanggota.Clear()
        txtalamat.Clear()
        txtnmrtelpon.Clear()
    End Sub
    Private Sub TampilData()
        txtnmranggota.Text = oanggota.Nomor_Anggota 
        txtnmanggota.Text = oanggota.Nama_Anggota
        txtalamat.Text = oanggota.Alamat_Anggota
        txtnmrtelpon.Text = oanggota.Telepon_Anggota
    End Sub
    Private Sub SimpanBarang()
        Anggota_baru = True
        oanggota.Nomor_Anggota = txtnmranggota.Text
        oanggota.Nama_Anggota = txtnmanggota.Text
        oanggota.Alamat_Anggota = txtalamat.Text
        oanggota.Telepon_Anggota = txtnmrtelpon.Text
    End Sub
    Private Sub GetData()
        oanggota.getAllData(DataGridView1)
    End Sub


    Private Sub frmanggota_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class
