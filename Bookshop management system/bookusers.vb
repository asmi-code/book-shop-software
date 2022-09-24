Imports System.Data.SqlClient
Public Class Bookusers

    Dim con As New SqlConnection("Data Source=ASHMI\SQLEXPRESS;Initial Catalog=bookshopdatabase;Integrated Security=True ")
    Private Sub Populate()

        Dim query = "select *from Usertable"
        Dim adapter As SqlDataAdapter
        adapter = New SqlDataAdapter(query, con)
        Dim builder As SqlCommandBuilder
        builder = New SqlCommandBuilder(adapter)
        Dim ds As DataSet
        ds = New DataSet
        adapter.Fill(ds)
        userdgv.DataSource = ds.Tables(0)
    End Sub

    Private Sub Save_Click(sender As Object, e As EventArgs) Handles save.Click
        If usertb.Text = "" Or phonetb.Text = "" Or addresstb.Text = "" Or passwordtb.Text = "" Then
            MsgBox("Missing Information")
        Else
            con.Open()
            Dim cmd As New SqlCommand
            cmd.Connection = con
            cmd.CommandText = "insert into userTable  ([Id]
           ,[Name]
           ,[Phone]
           ,[Address]
           ,[Password]) values('" & idtb.Text & "','" & usertb.Text & "','" & phonetb.Text & "','" & addresstb.Text & "','" & passwordtb.Text & "')"

            cmd.ExecuteNonQuery()
            usertb.Text = " "
            phonetb.Text = " "
            addresstb.Text = " "
            passwordtb.Text = " "
            MessageBox.Show("User Saved Sucessfully ")
            con.Close()
            Populate()
            reset()
        End If
    End Sub
    Private Sub Bookusers_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Populate()
    End Sub
    Dim key = 0
    Private Sub Delete_Click(sender As Object, e As EventArgs) Handles delete.Click
        If key = 0 Then
            MsgBox("select the user to be deleted ")
        Else
            con.Open()
            Dim query As String
            query = "delete from userTable where id =" & key & ""
            Dim cmd As SqlCommand
            cmd = New SqlCommand(query, con)
            cmd.ExecuteNonQuery()
            MsgBox("User Deleted Sucessfully ")
            con.Close()
            Populate()
            reset()
        End If
    End Sub
    Private Sub Userdgv_CellMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles userdgv.CellMouseClick
        Dim row As DataGridViewRow = userdgv.Rows(e.RowIndex)
        usertb.Text = row.Cells(1).Value.ToString
        phonetb.Text = row.Cells(2).Value.ToString
        addresstb.Text = row.Cells(3).Value.ToString
        passwordtb.Text = row.Cells(4).Value.ToString

        If usertb.Text = "" Then
            key = 0
        Else
            key = Convert.ToInt32(row.Cells(0).Value.ToString)
        End If
    End Sub
    Private Sub reset()
        idtb.Text = ""
        usertb.Text = " "
        phonetb.Text = " "
        addresstb.Text = " "
        passwordtb.Text = " "
        key = 0
    End Sub

    Private Sub resettb_Click(sender As Object, e As EventArgs) Handles resettb.Click
        reset()
    End Sub

    Private Sub edit_Click(sender As Object, e As EventArgs) Handles edit.Click
        If usertb.Text = "" Or phonetb.Text = "" Or addresstb.Text = "" Or passwordtb.Text = "" Then
            MsgBox("Missing Information")
        Else

            con.Open()
            Dim query As String
            query = "update userTable set name='" & usertb.Text & "',address='" & addresstb.Text & "',phone='" & phonetb.Text & "',password='" & passwordtb.Text & "' where id=" & key & ""
            Dim cmd As SqlCommand
            cmd = New SqlCommand(query, con)
            cmd.ExecuteNonQuery()
            usertb.Text = " "
            phonetb.Text = " "
            addresstb.Text = " "
            passwordtb.Text = " "
            MsgBox("User updated Sucessfully ")
            con.Close()
            Populate()
        End If
    End Sub
    Private Sub Label9_Click(sender As Object, e As EventArgs) Handles Label9.Click
        Dim obj = New users()
        obj.Show()
        Me.Hide()
    End Sub

    Private Sub Label11_Click(sender As Object, e As EventArgs) Handles Label11.Click
        Dim obj = New dashboard()
        obj.Show()
        Me.Hide()
    End Sub

    Private Sub Label12_Click(sender As Object, e As EventArgs) Handles Label12.Click
        Dim obj = New Login()
        obj.Show()
        Me.Hide()
    End Sub

    Private Sub Label13_Click(sender As Object, e As EventArgs) Handles Label13.Click
        Application.Exit()
    End Sub
End Class



