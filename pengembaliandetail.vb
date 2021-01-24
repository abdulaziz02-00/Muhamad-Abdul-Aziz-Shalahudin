Public Class pengembaliandetail
    Dim strsql As String
    Dim info As String
    Private _Nomor_Kembali As String
    Private _Judul As String
    Private _Nama_Anggota As String
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
    Public Property Judul()
        Get
            Return _Judul
        End Get
        Set(ByVal value)
            _Judul = value
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
        If (pengembaliandetail_baru = True) Then
            strsql = "Insert into pengembaliandetail(Nomor_Kembali,Judul,Nama_Anggota,Nama_Petugas) values ('" & _Nomor_Kembali & "','" & _Judul & "','" & _Nama_Anggota & "','" & _Nama_Petugas & "')"
            info = "INSERT"
        Else
            strsql = "update pengembaliandetail set Nomor_Kembali='" & _Nomor_Kembali & "', Judul='" & _Judul & "', Nama_Anggota='" & _Nama_Anggota & "', Nama_Petugas='" & _Nama_Petugas & "' where Judul='" & _Judul & "'"
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
    Public Sub Caripengembaliandetail(ByVal s As String)
        DBConnect()
        strsql = "SELECT * FROM pengembaliandetail WHERE ='" & s & "'"
        myCommand.Connection = conn
        myCommand.CommandText = strsql
        DR = myCommand.ExecuteReader
        If (DR.HasRows = True) Then
            pengembaliandetail_baru = False
            DR.Read()
            Nomor_Kembali = Convert.ToString((DR("Nomor_Kembali")))
            Judul = Convert.ToString((DR("Judul")))
            Nama_Anggota = Convert.ToString((DR("Nama_Anggota")))
            Nama_Petugas = Convert.ToString((DR("Nama_Petugas")))
        Else
            MessageBox.Show("Data Tidak Ditemukan.")
            pengembaliandetail_baru = True
        End If
        DBDisconnect()
    End Sub
    Public Sub Hapus(ByVal s As String)
        Dim info As String
        DBConnect()
        strsql = "DELETE FROM pengembaliandetail WHERE ='" & s & "'"
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
            strsql = "SELECT * FROM pengembaliandetail"
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
