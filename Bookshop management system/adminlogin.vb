Public Class adminlogin
    Private Sub Label11_Click(sender As Object, e As EventArgs) Handles Label11.Click
        Dim obj = New Login()
        obj.Show()
        Me.Hide()
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click
        Application.Exit()
    End Sub

    Private Sub loginbtn_Click(sender As Object, e As EventArgs) Handles loginbtn.Click
        If password.Text = " password" Then
            Dim obj = New Bookusers()
            obj.Show()
            Me.Hide()
        Else
            MsgBox("wrong password")
        End If
    End Sub
End Class