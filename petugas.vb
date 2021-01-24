Public Class Petugas
    Dim strsql As String
    Dim info As String
    Private _Kode_Petugas As String
    Private _Nama_Petugas As String
    Private _Password_Petugas As String
    Private _Status_Petugas As String
    Public InsertState As Boolean = False
    Public UpdateState As Boolean = False
    Public DeleteState As Boolean = False
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
    Public Property Password_Petugas()
        Get
            Return _Password_Petugas
        End Get
        Set(ByVal value)
            _Password_Petugas = value
        End Set
    End Property
    Public Property Status_Petugas()
        Get
            Return _Status_Petugas
        End Get
        Set(ByVal value)
            _Status_Petugas = value
        End Set
    End Property
    Public Sub Simpan()
        Dim info As String
        DBConnect()
        If (petugas_baru = True) Then
            strsql = "Insert into petugas(Kode_Petugas,Nama_Petugas,Password_Petugas,Status_Petugas) values ('" & _Kode_Petugas & "','" & _Nama_Petugas & "','" & _Password_Petugas & "','" & _Status_Petugas & "')"
            info = "INSERT"
        Else
            strsql = "update petugas set Kode_Petugas='" & _Kode_Petugas & "', Nama_Petugas='" & _Nama_Petugas & "', Password_Petugas='" & _Password_Petugas & "', Status_Petugas='" & _Status_Petugas & "' where ='"
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
    Public Sub Caripetugas(ByVal s As String)
        DBConnect()
        strsql = "SELECT * FROM petugas WHERE ='" & s & "'"
        myCommand.Connection = conn
        myCommand.CommandText = strsql
        DR = myCommand.ExecuteReader
        If (DR.HasRows = True) Then
            petugas_baru = False
            DR.Read()
            Kode_Petugas = Convert.ToString((DR("Kode_Petugas")))
            Nama_Petugas = Convert.ToString((DR("Nama_Petugas")))
            Password_Petugas = Convert.ToString((DR("Password_Petugas")))
            Status_Petugas = Convert.ToString((DR("Status_Petugas")))
        Else
            MessageBox.Show("Data Tidak Ditemukan.")
            petugas_baru = True
        End If
        DBDisconnect()
    End Sub
    Public Sub Hapus(ByVal s As String)
        Dim info As String
        DBConnect()
        strsql = "DELETE FROM petugas WHERE ='" & s & "'"
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
            strsql = "SELECT * FROM petugas"
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
