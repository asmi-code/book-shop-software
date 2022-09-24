Imports System.Data.SqlClient
Public Class dashboard
    Dim con As New SqlConnection("Data Source=ASHMI\SQLEXPRESS;Initial Catalog=bookshopdatabase;Integrated Security=True ")
    Private Sub countbooks()
        Dim booknum As Integer
        con.Open()
        Dim sql = "select COUNT(*) from userTable"
        Dim cmd As SqlCommand
        cmd = New SqlCommand(sql, con)
        booknum = cmd.ExecuteScalar()
        booklbl.Text = booknum
        con.Close()
    End Sub
    Private Sub countusers()
        Dim usernum As Integer
        con.Open()
        Dim sql = "select COUNT(*) from booktbl"
        Dim cmd As SqlCommand
        cmd = New SqlCommand(sql, con)
        usernum = cmd.ExecuteScalar()
        userlbl.Text = usernum
        con.Close()
    End Sub

    Private Sub dashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        countbooks()
        countusers()
        sumnum()
    End Sub
    Private Sub sumnum()

        Dim amountnum As Integer
        con.Open()
        Dim sql = "select COUNT(*) from billtbl"
        Dim cmd As SqlCommand
        cmd = New SqlCommand(sql, con)
        amountnum = cmd.ExecuteScalar()
        amount.Text = "Rs" + Convert.ToString(amountnum)
        con.Close()
    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click
        Application.Exit()
    End Sub

    Private Sub Label9_Click(sender As Object, e As EventArgs) Handles Label9.Click
        Dim obj = New Bookusers()
        obj.Show()
        Me.Hide()
    End Sub

    Private Sub Label10_Click(sender As Object, e As EventArgs) Handles Label10.Click
        Dim obj = New users()
        obj.Show()
        Me.Hide()
    End Sub

    Private Sub Label12_Click(sender As Object, e As EventArgs) Handles Label12.Click
        Dim obj = New Login()
        obj.Show()
        Me.Hide()
    End Sub
End Class