Public Class Form1

    Private Sub btnanggota_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnanggota.Click
        If (Anggota_baru = False) Then
            BikinMenu(cldanggota, TabControl1, "Anggota")
            Anggota_baru = True
        Else
            x = getTabIndex(TabControl1, "Anggota")
            TabControl1.SelectedTabIndex = x
        End If
    End Sub
    Private Sub btnbuku_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnbuku.Click
        If (buku_baru = False) Then
            BikinMenu(cldbuku, TabControl1, "Buku")
            buku_baru = True
        Else
            x = getTabIndex(TabControl1, "Buku")
            TabControl1.SelectedTabIndex = x
        End If
    End Sub
    Private Sub TabControl1_ControlAdded(ByVal sender As Object, ByVal e As System.Windows.Forms.ControlEventArgs) Handles TabControl1.ControlAdded
        TabControl1.SelectedTabIndex = TotalTab - 1
    End Sub

    Private Sub TabControl1_TabItemClose(ByVal sender As Object, ByVal e As DevComponents.DotNetBar.TabStripActionEventArgs) Handles TabControl1.TabItemClose
        Dim itemToRemove As DevComponents.DotNetBar.TabItem = TabControl1.SelectedTab
        If (TotalTab > 3) Then
            TotalTab = TotalTab - 1
        Else
            TotalTab = 0
        End If
        TabControl1.Tabs.Remove(itemToRemove)
        TabControl1.Controls.Remove(itemToRemove.AttachedControl)
        TabControl1.RecalcLayout()


        If (itemToRemove.ToString = "Anggota") Then
            Anggota_baru = False
        ElseIf (itemToRemove.ToString = "Buku") Then
            buku_baru = False
        ElseIf (itemToRemove.ToString = "peminjaman") Then
            peminjaman_baru = False
        Else

        End If
    End Sub

    Private Sub TabControl1_TabItemOpen(ByVal sender As Object, ByVal e As System.EventArgs) Handles TabControl1.TabItemOpen
        If (TotalTab = 0) Then
            TotalTab = TotalTab + 6
        Else
            TotalTab = TotalTab + 2
        End If
    End Sub


    Private Sub btnpeminjaman_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnpeminjaman.Click
        If (peminjaman_baru = False) Then
            BikinMenu(cldpeminjaman, TabControl1, "Peminjaman")
            peminjaman_baru = True
        Else
            x = getTabIndex(TabControl1, "Peminjaman")
            TabControl1.SelectedTabIndex = x
        End If
    End Sub

    Private Sub btnpeminjamandetail_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If (peminjamandetail_baru = False) Then
            BikinMenu(cldpeminjamandetail, TabControl1, "Peminjaman Detail")
            peminjaman_baru = True
        Else
            x = getTabIndex(TabControl1, "Peminjaman Detail")
            TabControl1.SelectedTabIndex = x
        End If
    End Sub
    Private Sub btnpengembalian_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnpengembalian.Click
        If (pengembalian_baru = False) Then
            BikinMenu(cldpengembalian, TabControl1, "Pengembalian")
            peminjaman_baru = True
        Else
            x = getTabIndex(TabControl1, "Pengembalian")
            TabControl1.SelectedTabIndex = x
        End If
    End Sub

    Private Sub TabControl1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TabControl1.Click

    End Sub

    Private Sub btnpengembaliandetail_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If (pengembaliandetail_baru = False) Then
            BikinMenu(cldpengembaliandetail, TabControl1, "Pengembalian Detail")
            pengembaliandetail_baru = True
        Else
            x = getTabIndex(TabControl1, "Pengembalian Detail")
            TabControl1.SelectedTabIndex = x
        End If
    End Sub

    Private Sub btnpetugas_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnpetugas.Click
        If (petugas_baru = False) Then
            BikinMenu(cldpetugas, TabControl1, "Petugas")
            petugas_baru = True
        Else
            x = getTabIndex(TabControl1, "Petugas")
            TabControl1.SelectedTabIndex = x
        End If
    End Sub

    Private Sub RibbonControl1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RibbonControl1.Click

    End Sub

    Private Sub TabControlPanel1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TabControlPanel1.Click

    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class
