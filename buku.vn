Public Class Buku
    Dim strsql As String
    Dim info As String
    Private _Nomor_Buku As String
    Private _Judul As String
    Private _Kategori As String
    Private _Pengarang As String
    Private _Penerbit As String
    Private _Tahun As Integer
    Private _Stok As Integer
    Public InsertState As Boolean = False
    Public UpdateState As Boolean = False
    Public DeleteState As Boolean = False
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
    Public Property Kategori()
        Get
            Return _Kategori
        End Get
        Set(ByVal value)
            _Kategori = value
        End Set
    End Property
    Public Property Pengarang()
        Get
            Return _Pengarang
        End Get
        Set(ByVal value)
            _Pengarang = value
        End Set
    End Property
    Public Property Penerbit()
        Get
            Return _Penerbit
        End Get
        Set(ByVal value)
            _Penerbit = value
        End Set
    End Property
    Public Property Tahun()
        Get
            Return _Tahun
        End Get
        Set(ByVal value)
            _Tahun = value
        End Set
    End Property
    Public Property Stok()
        Get
            Return _Stok
        End Get
        Set(ByVal value)
            _Stok = value
        End Set
    End Property
    Public Sub Simpan()
        Dim info As String
        DBConnect()
        If (buku_baru = True) Then
            strsql = "Insert into buku(Nomor_Buku,Judul,Kategori,Pengarang,Penerbit,Tahun,Stok) values ('" & _Nomor_Buku & "','" & _Judul & "','" & _Kategori & "','" & _Pengarang & "','" & _Penerbit & "','" & _Tahun & "','" & _Stok & "')"
            info = "INSERT"
        Else
            strsql = "update buku set Nomor_Buku='" & _Nomor_Buku & "', Judul='" & _Judul & "', Kategori='" & _Kategori & "', Pengarang='" & _Pengarang & "', Penerbit='" & _Penerbit & "', Tahun='" & _Tahun & "', Stok='" & _Stok & "' where Judul='" & _Judul & "'"
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
    Public Sub Caribuku(ByVal s As String)
        DBConnect()
        strsql = "SELECT * FROM buku WHERE ='" & s & "'"
        myCommand.Connection = conn
        myCommand.CommandText = strsql
        DR = myCommand.ExecuteReader
        If (DR.HasRows = True) Then
            buku_baru = False
            DR.Read()
            Nomor_Buku = Convert.ToString((DR("Nomor_Buku")))
            Judul = Convert.ToString((DR("Judul")))
            Kategori = Convert.ToString((DR("Kategori")))
            Pengarang = Convert.ToString((DR("Pengarang")))
            Penerbit = Convert.ToString((DR("Penerbit")))
            Tahun = Convert.ToString((DR("Tahun")))
            Stok = Convert.ToString((DR("Stok")))
        Else
            MessageBox.Show("Data Tidak Ditemukan.")
            buku_baru = True
        End If
        DBDisconnect()
    End Sub
    Public Sub Hapus(ByVal s As String)
        Dim info As String
        DBConnect()
        strsql = "DELETE FROM buku WHERE ='" & s & "'"
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
            strsql = "SELECT * FROM buku"
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
