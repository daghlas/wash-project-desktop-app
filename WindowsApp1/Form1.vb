Public Class Form1
    Dim formWash As New frmWASH

    Private Sub btn_login_Click(sender As Object, e As EventArgs) Handles btn_login.Click
        If txt_username.Text = "daghlaskaire58@gmail.com" And
        txt_password.Text = "123456777" Then
            formWash.Show()
            Me.Visible = False
        Else
            MsgBox("Enter Valid Username/Password")
        End If
    End Sub

    Private Sub btn_logout_Click(sender As Object, e As EventArgs) Handles btn_logout.Click
        Me.Close()
    End Sub
End Class
