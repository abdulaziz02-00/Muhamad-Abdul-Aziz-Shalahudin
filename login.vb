Public Class Login

    Private Sub btnsubmit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnsubmit.Click
        login_valid = oUser.Login(txtusser.Text, txtpasswd.Text)
        If (login_valid = True) Then
            MessageBox.Show("Selamat Datang Di Perpustakaan UMC")
            Form1.Show()
            Me.Hide()
        Else
            MessageBox.Show("Login Not Valid")
        End If
    End Sub

    Private Sub btncancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btncancel.Click
        Me.Close()
    End Sub

    Private Sub Login_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class
