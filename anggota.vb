Public Class Anggota
    Dim strsql As String
    Dim info As String
    Private _Nomor_Anggota As String
    Private _Nama_Anggota As String
    Private _Alamat_Anggota As String
    Private _Telepon_Anggota As String
    Public InsertState As Boolean = False
    Public UpdateState As Boolean = False
    Public DeleteState As Boolean = False
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
    Public Property Alamat_Anggota()
        Get
            Return _Alamat_Anggota
        End Get
        Set(ByVal value)
            _Alamat_Anggota = value
        End Set
    End Property
    Public Property Telepon_Anggota()
        Get
            Return _Telepon_Anggota
        End Get
        Set(ByVal value)
            _Telepon_Anggota = value
        End Set
    End Property
    Public Sub Simpan()
        Dim info As String
        DBConnect()
        If (anggota_baru = True) Then
            strsql = "Insert into anggota(Nomor_Anggota,Nama_Anggota,Alamat_Anggota,Telepon_Anggota) values ('" & _Nomor_Anggota & "','" & _Nama_Anggota & "','" & _Alamat_Anggota & "','" & _Telepon_Anggota & "')"
            info = "INSERT"
        Else
            strsql = "update anggota set Nomor_Anggota='" & _Nomor_Anggota & "', Nama_Anggota='" & _Nama_Anggota & "', Alamat_Anggota='" & _Alamat_Anggota & "', Telepon_Anggota='" & _Telepon_Anggota & "' where Nama_Anggota='" & _Nama_Anggota & "'"
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
    Public Sub Carianggota(ByVal s As String)
        DBConnect()
        strsql = "SELECT * FROM anggota WHERE ='" & s & "'"
        myCommand.Connection = conn
        myCommand.CommandText = strsql
        DR = myCommand.ExecuteReader
        If (DR.HasRows = True) Then
            anggota_baru = False
            DR.Read()
            Nomor_Anggota = Convert.ToString((DR("Nomor_Anggota")))
            Nama_Anggota = Convert.ToString((DR("Nama_Anggota")))
            Alamat_Anggota = Convert.ToString((DR("Alamat_Anggota")))
            Telepon_Anggota = Convert.ToString((DR("Telepon_Anggota")))
        Else
            MessageBox.Show("Data Tidak Ditemukan.")
            anggota_baru = True
        End If
        DBDisconnect()
    End Sub
    Public Sub Hapus(ByVal s As String)
        Dim info As String
        DBConnect()
        strsql = "DELETE FROM anggota WHERE ='" & s & "'"
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
            strsql = "SELECT * FROM anggota"
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
