Imports MySql.Data.MySqlClient
Imports DevComponents.DotNetBar
Module MyMod
    Public myCommand As New MySqlCommand
    Public myAdapter As New MySqlDataAdapter
    Public myData As New DataTable
    Public DR As MySqlDataReader
    Public SQL As String
    Public conn As New MySqlConnection

    Public cldanggota As New frmanggota
    Public cldpetugas As New frmpetugas
    Public cldbuku As New frmbuku
    Public cldpeminjaman As New frmpeminjaman
    Public cldpengembalian As New frmpengembalian
    Public cldpeminjamandetail As New frmpeminjamandetail
    Public cldpengembaliandetail As New frmpengembaliandetail

    Public anggota As Boolean
    Public buku As Boolean
    Public peminjaman As Boolean
    Public pengembalian As Boolean
    Public petugas As Boolean

    'Table1 User
    '--------------------------------
    Public user_baru As Boolean
    Public oUser As New User
    '--------------------------------
    'Tabel Login
    '--------------------------------
    Public login_valid As Boolean
    Public nobukti As Double
    '--------------------------------
    'Tabel Anggota
    '--------------------------------
    Public Anggota_baru As Boolean
    Public oanggota As New Anggota
    '--------------------------------
    'Tabel Buku
    '--------------------------------
    Public buku_baru As Boolean
    Public obuku As New Buku
    '--------------------------------
    'Tabel peminjaman
    '--------------------------------
    Public peminjaman_baru As Boolean
    Public opeminjaman As New Peminjaman
    '--------------------------------
    'Tabel Pengembalian
    '--------------------------------
    Public pengembalian_baru As Boolean
    Public opengembalian As New Pengembalian
    '--------------------------------
    'Tabel Petugas
    '--------------------------------
    Public petugas_baru As Boolean
    Public opetugas As New Petugas

    '--------------------------------
    'Tabel Peminjaman detail
    '--------------------------------
    Public peminjamandetail_baru As Boolean
    Public opeminjamandetail As New peminjamandetail

    '--------------------------------
    'Tabel Pengembalian Detail
    '--------------------------------
    Public pengembaliandetail_baru As Boolean
    Public opengembaliandetail As New pengembaliandetail

    '--------------------------------
    Public R As Random = New Random
    Public TotalTab As Integer = 0
    Public x As Integer

    Public Sub BikinMenu(ByVal Child As Form, ByVal mytab As TabControl, ByVal sTitle As String)

        Dim newTab As DevComponents.DotNetBar.TabItem = mytab.CreateTab(sTitle)
        Dim panel As DevComponents.DotNetBar.TabControlPanel = DirectCast(newTab.AttachedControl, Panel)


        Child.TopLevel = False
        Child.FormBorderStyle = Windows.Forms.FormBorderStyle.None
        Child.Dock = DockStyle.Fill
        Child.Show()
        panel.Controls.Add(Child)

    End Sub
    Public Function getTabIndex(ByVal mytab As TabControl, ByVal sCari As String)
        Dim i As Integer
        For i = 0 To TotalTab - 1
            If (mytab.Tabs(i).Text = sCari) Then

                Exit For
            End If
        Next
        getTabIndex = i
    End Function
    Public Sub DBConnect()
        conn.ConnectionString = "server=localhost;" &
        "user id=root;" &
        "password=;" &
        "database=bdperpus"
        Try
            conn.Open()
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        Finally
            If (conn.State = ConnectionState.Open) Then
            Else
                MessageBox.Show("Sorry not connected.")
            End If
        End Try
    End Sub

    Public Sub DBDisconnect()

        If (conn.State = ConnectionState.Open) Then
            conn.Close()
            conn.Dispose()
        End If
    End Sub

    Public Function getMD5Hash(ByVal strToHash As String) As String

        Dim md5Obj As New System.Security.Cryptography.MD5CryptoServiceProvider()
        Dim bytesToHash() As Byte = System.Text.Encoding.ASCII.GetBytes(strToHash)
        bytesToHash = md5Obj.ComputeHash(bytesToHash)
        Dim strResult As String = ""
        Dim b As Byte
        For Each b In bytesToHash
            strResult += b.ToString("x2")
        Next
        Return strResult
    End Function


    Public Function getNomorBukti()
        Dim res As Double
        res = R.Next(0, 9999999)
        Return res
    End Function
End Module

