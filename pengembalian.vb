Public Class Pengembalian
    Dim strsql As String
    Dim info As String
    Private _Nomor_Kembali As String
    Private _Tanggal_Kembali As String
    Private _Nomor_Buku As String
    Private _Judul As String
    Private _Total_Kembali As Integer
    Private _Denda As Integer
    Private _Nomor_Anggota As String
    Private _Nama_Anggota As String
    Private _Kode_Petugas As String
    Private _Nama_Petugas As String
    Public InsertState As Boolean = False
    Public UpdateState As Boolean = False
    Public DeleteState As Boolean = False
    Public Property Nomor_Kembali()
        Get
            Return _Nomor_Kembali
        End Get
        Set(ByVal value)
            _Nomor_Kembali = value
        End Set
    End Property
    Public Property Tanggal_Kembali()
        Get
            Return _Tanggal_Kembali
        End Get
        Set(ByVal value)
            _Tanggal_Kembali = value
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
    Public Property Total_Kembali()
        Get
            Return _Total_Kembali
        End Get
        Set(ByVal value)
            _Total_Kembali = value
        End Set
    End Property
    Public Property Denda()
        Get
            Return _Denda
        End Get
        Set(ByVal value)
            _Denda = value
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
        If (pengembalian_baru = True) Then
            strsql = "Insert into pengembalian(Nomor_Kembali,Tanggal_Kembali,Nomor_Buku,Judul,Total_Kembali,Denda,Nomor_Anggota,Nama_Anggota,Kode_Petugas,Nama_Petugas) values ('" & _Nomor_Kembali & "','" & _Tanggal_Kembali & "','" & _Nomor_Buku & "','" & _Judul & "','" & _Total_Kembali & "','" & _Denda & "','" & _Nomor_Anggota & "','" & _Nama_Anggota & "','" & _Kode_Petugas & "','" & _Nama_Petugas & "')"
            info = "INSERT"
        Else
            strsql = "update pengembalian set Nomor_Kembali='" & _Nomor_Kembali & "', Tanggal_Kembali='" & _Tanggal_Kembali & "', Nomor_Buku='" & _Nomor_Buku & "', Judul='" & _Judul & "', Total_Kembali='" & _Total_Kembali & "', Denda='" & _Denda & "', Nomor_Anggota='" & _Nomor_Anggota & "', Nama_Anggota='" & _Nama_Anggota & "', Kode_Petugas='" & _Kode_Petugas & "', Nama_Petugas='" & _Nama_Petugas & "' where ='"
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
    Public Sub Caripengembalian(ByVal s As String)
        DBConnect()
        strsql = "SELECT * FROM pengembalian WHERE ='" & s & "'"
        myCommand.Connection = conn
        myCommand.CommandText = strsql
        DR = myCommand.ExecuteReader
        If (DR.HasRows = True) Then
            pengembalian_baru = False
            DR.Read()
            Nomor_Kembali = Convert.ToString((DR("Nomor_Kembali")))
            Tanggal_Kembali = Convert.ToString((DR("Tanggal_Kembali")))
            Nomor_Buku = Convert.ToString((DR("Nomor_Buku")))
            Judul = Convert.ToString((DR("Judul")))
            Total_Kembali = Convert.ToString((DR("Total_Kembali")))
            Denda = Convert.ToString((DR("Denda")))
            Nomor_Anggota = Convert.ToString((DR("Nomor_Anggota")))
            Nama_Anggota = Convert.ToString((DR("Nama_Anggota")))
            Kode_Petugas = Convert.ToString((DR("Kode_Petugas")))
            Nama_Petugas = Convert.ToString((DR("Nama_Petugas")))
        Else
            MessageBox.Show("Data Tidak Ditemukan.")
            pengembalian_baru = True
        End If
        DBDisconnect()
    End Sub
    Public Sub Hapus(ByVal s As String)
        Dim info As String
        DBConnect()
        strsql = "DELETE FROM pengembalian WHERE ='" & s & "'"
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
            strsql = "SELECT * FROM pengembalian"
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
