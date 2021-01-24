Public Class Peminjaman
    Dim strsql As String
    Dim info As String
    Private _Nomor_Pinjam As String
    Private _Tanggal_Pinjam As String
    Private _Total_Pinjam As Integer
    Private _Nomor_Buku As String
    Private _Judul As String
    Private _Nomor_Anggota As String
    Private _Nama_Anggota As String
    Private _Kode_Petugas As String
    Private _Nama_Petugas As String
    Public InsertState As Boolean = False
    Public UpdateState As Boolean = False
    Public DeleteState As Boolean = False
    Public Property Nomor_Pinjam()
        Get
            Return _Nomor_Pinjam
        End Get
        Set(ByVal value)
            _Nomor_Pinjam = value
        End Set
    End Property
    Public Property Tanggal_Pinjam()
        Get
            Return _Tanggal_Pinjam
        End Get
        Set(ByVal value)
            _Tanggal_Pinjam = value
        End Set
    End Property
    Public Property Total_Pinjam()
        Get
            Return _Total_Pinjam
        End Get
        Set(ByVal value)
            _Total_Pinjam = value
        End Set
    End Property
    Public Property Nomor_Buku()
        Get
            Return _Nomor_Buku
        End Get
        Set(ByVal value)
            _Nomor_Buku = value
        End Set
    End Property
    Public Property Judul()
        Get
            Return _Judul
        End Get
        Set(ByVal value)
            _Judul = value
        End Set
    End Property
    Public Property Nomor_Anggota()
        Get
            Return _Nomor_Anggota
        End Get
        Set(ByVal value)
            _Nomor_Anggota = value
        End Set
    End Property
    Public Property Nama_Anggota()
        Get
            Return _Nama_Anggota
        End Get
        Set(ByVal value)
            _Nama_Anggota = value
        End Set
    End Property
    Public Property Kode_Petugas()
        Get
            Return _Kode_Petugas
        End Get
        Set(ByVal value)
            _Kode_Petugas = value
        End Set
    End Property
    Public Property Nama_Petugas()
        Get
            Return _Nama_Petugas
        End Get
        Set(ByVal value)
            _Nama_Petugas = value
        End Set
    End Property
    Public Sub Simpan()
        Dim info As String
        DBConnect()
        If (peminjaman_baru = True) Then
            strsql = "Insert into peminjaman(Nomor_Pinjam,Tanggal_Pinjam,Total_Pinjam,Nomor_Buku,Judul,Nomor_Anggota,Nama_Anggota,Kode_Petugas,Nama_Petugas) values ('" & _Nomor_Pinjam & "','" & _Tanggal_Pinjam & "','" & _Total_Pinjam & "','" & _Nomor_Buku & "','" & _Judul & "','" & _Nomor_Anggota & "','" & _Nama_Anggota & "','" & _Kode_Petugas & "','" & _Nama_Petugas & "')"
            info = "INSERT"
        Else
            strsql = "update peminjaman set Nomor_Pinjam='" & _Nomor_Pinjam & "', Tanggal_Pinjam='" & _Tanggal_Pinjam & "', Total_Pinjam='" & _Total_Pinjam & "', Nomor_Buku='" & _Nomor_Buku & "', Judul='" & _Judul & "', Nomor_Anggota='" & _Nomor_Anggota & "', Nama_Anggota='" & _Nama_Anggota & "', Kode_Petugas='" & _Kode_Petugas & "', Nama_Petugas='" & _Nama_Petugas & "' where Tanggal_Pinjam='" & _Tanggal_Pinjam & "'"
            info = "UPDATE"
        End If
        myCommand.Connection = conn
        myCommand.CommandText = strsql
        Try
            myCommand.ExecuteNonQuery()
        Catch ex As Exception
            If (info = "INSERT") Then
                InsertState = False
            ElseIf (info = "UPDATE") Then
                UpdateState = False
            Else
            End If
        Finally
            If (info = "INSERT") Then
                InsertState = True
            ElseIf (info = "UPDATE") Then
                UpdateState = True
            Else
            End If
        End Try
        DBDisconnect()
    End Sub
    Public Sub Caripeminjaman(ByVal s As String)
        DBConnect()
        strsql = "SELECT * FROM peminjaman WHERE ='" & s & "'"
        myCommand.Connection = conn
        myCommand.CommandText = strsql
        DR = myCommand.ExecuteReader
        If (DR.HasRows = True) Then
            peminjaman_baru = False
            DR.Read()
            Nomor_Pinjam = Convert.ToString((DR("Nomor_Pinjam")))
            Tanggal_Pinjam = Convert.ToString((DR("Tanggal_Pinjam")))
            Total_Pinjam = Convert.ToString((DR("Total_Pinjam")))
            Nomor_Buku = Convert.ToString((DR("Nomor_Buku")))
            Judul = Convert.ToString((DR("Judul")))
            Nomor_Anggota = Convert.ToString((DR("Nomor_Anggota")))
            Nama_Anggota = Convert.ToString((DR("Nama_Anggota")))
            Kode_Petugas = Convert.ToString((DR("Kode_Petugas")))
            Nama_Petugas = Convert.ToString((DR("Nama_Petugas")))
        Else
            MessageBox.Show("Data Tidak Ditemukan.")
            peminjaman_baru = True
        End If
        DBDisconnect()
    End Sub
    Public Sub Hapus(ByVal s As String)
        Dim info As String
        DBConnect()
        strsql = "DELETE FROM peminjaman WHERE ='" & s & "'"
        info = "DELETE"
        myCommand.Connection = conn
        myCommand.CommandText = strsql
        Try
            myCommand.ExecuteNonQuery()
            DeleteState = True
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
        DBDisconnect()
    End Sub
    Public Sub getAllData(ByVal dg As DataGridView)
        Try
            DBConnect()
            strsql = "SELECT * FROM peminjaman"
            myCommand.Connection = conn
            myCommand.CommandText = strsql
            myData.Clear()
            myAdapter.SelectCommand = myCommand
            myAdapter.Fill(myData)
            With dg
                .DataSource = myData
                .AllowUserToAddRows = False
                .AllowUserToDeleteRows = False
                .ReadOnly = True
            End With
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        Finally
            DBDisconnect()
        End Try
    End Sub
End Class
