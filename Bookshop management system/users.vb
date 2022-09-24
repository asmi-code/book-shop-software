Imports System.Data.SqlClient
Public Class users
    Public ReadOnly con As New SqlConnection("Data Source=ASHMI\SQLEXPRESS;Initial Catalog=bookshopdatabase;Integrated Security=True ")
    Public ReadOnly cmd As New SqlCommand
    Private Sub Populate()

        Dim query = "select *from booktbl"
        Dim adapter As SqlDataAdapter
        adapter = New SqlDataAdapter(query, con)
        Dim builder As SqlCommandBuilder
        builder = New SqlCommandBuilder(adapter)
        Dim ds As DataSet
        ds = New DataSet
        adapter.Fill(ds)
        booksdgv.DataSource = ds.Tables(0)
    End Sub
    Private Sub Filter1()
        Dim query = "select *from booktbl where categories='" & filtercb.SelectedItem.ToString() & "'"
        Dim adapter As SqlDataAdapter
        adapter = New SqlDataAdapter(query, con)
        Dim builder As SqlCommandBuilder
        builder = New SqlCommandBuilder(adapter)
        Dim ds As DataSet
        ds = New DataSet
        adapter.Fill(ds)
        booksdgv.DataSource = ds.Tables(0)
    End Sub
    Private Sub Reset()
        booknametb.Text = " "
        authortb.Text = " "
        qtytb.Text = " "
        pricrtb.Text = " "
        categorytb.SelectedItem = -1
        Key = 0

    End Sub

    Private Sub Save_Click(sender As Object, e As EventArgs) Handles save.Click
        If booknametb.Text = "" Or authortb.Text = "" Or qtytb.Text = "" Or pricrtb.Text = "" Or categorytb.SelectedItem Then
            MsgBox("Missing Information")
        Else

            con.Open()
                cmd.Connection = con
                cmd.CommandText = "insert into booktbl values('" & booknametb.Text & "','" & authortb.Text & "','" & qtytb.Text & "','" & pricrtb.Text & "','" & categorytb.SelectedItem.ToString & "')"
                cmd.ExecuteNonQuery()
                booknametb.Text = " "
                authortb.Text = " "
                qtytb.Text = " "
                pricrtb.Text = " "
                categorytb.SelectedItem = -1
            MessageBox.Show("Book Saved Sucessfully ")
            con.Close()
        End If
        Populate()
        reset()
    End Sub
    Dim Key = 0
    Private Sub Users_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Populate()
    End Sub

    Private Sub Booksdgv_CellMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles booksdgv.CellMouseClick
        Dim row As DataGridViewRow = booksdgv.Rows(e.RowIndex)
        booknametb.Text = row.Cells(1).Value.ToString
        authortb.Text = row.Cells(2).Value.ToString
        categorytb.SelectedItem = row.Cells(3).Value.ToString
        pricrtb.Text = row.Cells(5).Value.ToString
        qtytb.Text = row.Cells(4).Value.ToString

        If booknametb.Text = "" Then
            Key = 0
        Else
            Key = Convert.ToInt32(row.Cells(0).Value.ToString)
        End If
    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click
        Application.Exit()
    End Sub

    Private Sub Edit_Click(sender As Object, e As EventArgs) Handles edit.Click
        If booknametb.Text = "" Or authortb.Text = "" Or qtytb.Text = "" Or pricrtb.Text = "" Or categorytb.SelectedItem Then
            MsgBox("Missing Information")
        Else
            Try
                con.Open()
                Dim query As String
                query = "update booktbl set title='" & booknametb.Text & "',author='" & authortb.Text & "',quantity='" & qtytb.Text & "',price='" & pricrtb.Text & "' ,cateogies='" & categorytb.SelectedItem.ToString & "'where id=" & Key & ""
                Dim cmd As SqlCommand
                cmd = New SqlCommand(query, con)
                cmd.ExecuteNonQuery()
                booknametb.Text = " "
                authortb.Text = " "
                qtytb.Text = " "
                pricrtb.Text = " "
                categorytb.SelectedItem = -1
                Key = 0
                MsgBox("Book updated Sucessfully ")
            Catch ex As Exception
                MessageBox.Show("error while updating records " & ex.Message)
                con.Close()
            End Try
            Populate()
            Reset()
        End If
    End Sub

    Private Sub Filter_SelectedIndexChanged(sender As Object, e As EventArgs) Handles filtercb.SelectedIndexChanged
        Filter1()
    End Sub

    Private Sub Refreshbtn_Click(sender As Object, e As EventArgs) Handles refreshbtn.Click
        Populate()
    End Sub

    Private Sub Label10_Click(sender As Object, e As EventArgs) Handles Label10.Click
        Dim obj = New Bookusers()
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

    Private Sub delete_Click(sender As Object, e As EventArgs) Handles delete.Click
        If Key = 0 Then
            MsgBox("Select The Book To Be Deleted")
        Else
            con.Open()
            Dim query As String
            query = "Delete from booktbl where id=" & Key & ""
            Dim cmd As SqlCommand
            cmd = New SqlCommand(query, con)
            cmd.ExecuteNonQuery()
            MsgBox("User Deleted Sucessfully")
            con.Close()
            Populate()
            Reset()
        End If
    End Sub
End Class