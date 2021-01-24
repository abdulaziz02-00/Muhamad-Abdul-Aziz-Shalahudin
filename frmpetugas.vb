Public Class frmpetugas


    Private Sub btnsv_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSv.Click
        SimpanBarang()
        GetData()
    End Sub

    Private Sub btnclear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnclear.Click
        ClearEntry()
    End Sub

    Private Sub btnrefresh_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnrefresh.Click
        GetData()
    End Sub

    Private Sub txtnmpetugas_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtnmpetugas.KeyDown
        If (e.KeyCode = Keys.Enter And txtnmpetugas.Text <> "") Then
            opetugas.Caripetugas(txtnmpetugas.Text)
            txtpsswd.Text = opetugas.Password_Petugas
            txtsttspetugas.Text = opetugas.Status_Petugas

        End If
    End Sub
    Private Sub ClearEntry()
        txtkdpetugas.Clear()
        txtnmpetugas.Clear()
        txtpsswd.Clear()
        txtsttspetugas.Clear()
    End Sub
    Private Sub TampilData()
        txtkdpetugas.Text = opetugas.Kode_Petugas
        txtnmpetugas.Text = opetugas.Nama_Petugas
        txtpsswd.Text = opetugas.Password_Petugas
        txtsttspetugas.Text = opetugas.Status_Petugas
    End Sub
    Private Sub SimpanBarang()
        petugas_baru = True
        opetugas.Kode_Petugas = txtkdpetugas.Text
        opetugas.Nama_Petugas = txtnmpetugas.Text
        opetugas.Password_Petugas = txtpsswd.Text
        opetugas.Status_Petugas = txtsttspetugas.Text
    End Sub
    Private Sub GetData()
        opetugas.getAllData(DataGridView1)
    End Sub


    Private Sub frmpetugas_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class
