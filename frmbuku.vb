Public Class frmbuku


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

    Private Sub txtjudul_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtjudul.KeyDown
        If (e.KeyCode = Keys.Enter And txtjudul.Text <> "") Then
            obuku.Caribuku(txtjudul.Text)
            txtkategori.Text = obuku.Kategori
            txtpengarang.Text = obuku.Pengarang
            txtpenerbit.Text = obuku.Penerbit
            txttahun.Text = obuku.Tahun
            txtstok.Text = obuku.Stok


        End If
    End Sub
    Private Sub ClearEntry()
        txtnmrbuku.Clear()
        txtjudul.Clear()
        txtkategori.Clear()
        txtpengarang.Clear()
        txtpenerbit.Clear()
        txttahun.Clear()
        txtstok.Clear()
    End Sub
    Private Sub TampilData()
        txtnmrbuku.Text = obuku.Nomor_Buku
        txtjudul.Text = obuku.Judul
        txtkategori.Text = obuku.Kategori
        txtpengarang.Text = obuku.Pengarang
        txtpenerbit.Text = obuku.Penerbit
        txttahun.Text = obuku.Tahun
        txtstok.Text = obuku.Stok
    End Sub
    Private Sub SimpanBarang()
        buku_baru = True
        obuku.Nomor_Buku = txtnmrbuku.Text
        obuku.Judul = txtjudul.Text
        obuku.Kategori = txtkategori.Text
        obuku.Pengarang = txtpengarang.Text
        obuku.Penerbit = txtpenerbit.Text
        obuku.Tahun = txttahun.Text
        obuku.Stok = txtstok.Text

    End Sub
    Private Sub GetData()
        obuku.getAllData(DataGridView1)
    End Sub


    Private Sub frmbuku_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class
