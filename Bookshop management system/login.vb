
Imports System.Data.SqlClient

Public Class Login
    Public ReadOnly con As New SqlClient.SqlConnection("Data Source=ASHMI\SQLEXPRESS;Initial Catalog=bookshopdatabase;Integrated Security=True")
    Dim cmd As SqlCommand
    Private Sub Loginbtn_Click(sender As Object, e As EventArgs) Handles loginbtn.Click
        If Unametb.Text = "" Or Passwordtb.Text = "" Then
            MsgBox("Enter username and Password ")
        Else
            con.Open()
            Dim query = "select *from usertable where name='" & Unametb.Text & "' and password='" & Passwordtb.Text & "'"
            cmd = New SqlCommand(query, con)
            Dim x As SqlDataAdapter = New SqlDataAdapter(cmd)
            Dim y As DataSet = New DataSet()
            x.Fill(y)
            Dim a As Integer
            a = y.Tables(0).Rows.Count
            If a = 0 Then
                MsgBox("Wrong username or password")
            Else
                Dim bill = New Bills
                Bills.username = Unametb.Text
                Bills.Show()
                Me.Hide()
            End If
            con.Close()
        End If
    End Sub

    Private Sub Label10_Click(sender As Object, e As EventArgs) Handles Label10.Click
        Application.Exit()
    End Sub

    Private Sub Label11_Click(sender As Object, e As EventArgs) Handles Label11.Click
        Dim obj = New adminlogin
        obj.Show()
        Me.Hide()
    End Sub
End Class
