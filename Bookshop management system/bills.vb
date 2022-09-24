Imports System.Data.SqlClient
Public Class Bills
    Dim con As New SqlConnection("Data Source=ASHMI\SQLEXPRESS;Initial Catalog=bookshopdatabase;Integrated Security=True ")
    Dim Cmd As New SqlCommand
    Public Property username As String
    Private Sub Populate()
        Dim query = "select *from Usertable"
        Dim adapter As SqlDataAdapter
        adapter = New SqlDataAdapter(query, con)
        Dim builder As SqlCommandBuilder
        builder = New SqlCommandBuilder(adapter)
        Dim ds As DataSet
        ds = New DataSet
        adapter.Fill(ds)
        booksdgv.DataSource = ds.Tables(0)
    End Sub
    Private Sub Bills_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Populate()
        Unamelbl.Text = username
    End Sub
    Dim key = 0, Stock = 0, i = 0, Grdtotal = 0

    Private Sub Addtobtn_Click(sender As Object, e As EventArgs) Handles addtobtn.Click
        If price.Text = "" Or qty.Text = "" Then
            MsgBox("Enter The Quantity")
        ElseIf bookname.Text = "" Then
            MsgBox("Select the book")
        ElseIf Convert.ToInt32(qty.text) > Stock Then
            MsgBox("No enough item")
        Else
            Dim rnum As Integer = billsdgv.Rows.Add()
            i = i + 1
            Dim total = Convert.ToInt32(qty.Text) = Convert.ToInt32(price.Text)
            billsdgv.Rows.Item(rnum).Cells("column1").Value = i
            billsdgv.Rows.Item(rnum).Cells("column2").Value = bookname.Text
            billsdgv.Rows.Item(rnum).Cells("column3").Value = qty.Text
            billsdgv.Rows.Item(rnum).Cells("column4").Value = price.Text
            billsdgv.Rows.Item(rnum).Cells("column5").Value = total
            Grdtotal = Grdtotal + total
            Dim tot As String
            tot = "Rs" + Convert.ToString(Grdtotal)
            Totallbl.Text = "Rs" + tot
            Update()
        End If
    End Sub
    Private Sub Reset()
        key = 0
        qty.Text = ""
        price.Text = ""
        cname.Text = ""
        bookname.Text = ""
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles button4.Click
        Reset()
    End Sub

    Private Sub PrintDocument1_PrintPage(sender As Object, e As Printing.PrintPageEventArgs) Handles PrintDocument1.PrintPage
        e.Graphics.DrawString("bookshop", New Font("century gothic", 25), Brushes.MidnightBlue, 350, 40)
        e.Graphics.DrawString("***Your Bill***", New Font("century gothic", 15), Brushes.MidnightBlue, 300, 70)
        Dim bm As New Bitmap(Me.billsdgv.Width, Me.billsdgv.Height)
        e.Graphics.DrawImage(bm, 60, 120)
        e.Graphics.DrawString("Total Amount Rs" + Grdtotal.ToString, New Font("century gothic", 15), Brushes.MidnightBlue, 280, 500)
        e.Graphics.DrawString("****Thanks for Buying in our shop ****", New Font("century gothic", 15), Brushes.Crimson, 150, 500)
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        PrintPreviewDialog1.ShowDialog()
        Addtobill()
    End Sub

    Private Sub Addtobill()
        Try
            con.Open()
            Dim query As String
            query = "insert into billtbl values('" & bookname.Text & "','" & cname.Text & "'," & Grdtotal.Text & "')"
            Dim cmd As SqlCommand
            cmd = New SqlCommand(query, con)
            cmd.ExecuteNonQuery()
            con.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub Booksdgv_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles booksdgv.CellContentClick
        Dim row As DataGridViewRow = booksdgv.Rows(e.RowIndex)
        bookname.Text = row.Cells(1).Value.ToString
        qty.Text = row.Cells(2).Value.ToString
        cname.Text = row.Cells(3).Value.ToString
        price.Text = row.Cells(4).Value.ToString
        Stock = Convert.ToInt32(row.Cells())
        Try
            If bookname.Text = "" Then
                key = 0
            Else
                key = Convert.ToInt32(row.Cells(0).Value.ToString)
            End If
        Catch ex As Exception
            MessageBox.Show("exception catched" & ex.Message)
        End Try
    End Sub
    Private Sub Label10_Click(sender As Object, e As EventArgs) Handles Label10.Click
        Application.Exit()
    End Sub
    Private Overloads Sub Update()
        Dim newqty = Stock - Convert.ToInt32(qty.Text)
        con.Open()
        Dim query As String
        query = "update booktbl set Quantity " & newqty & " where bid=" & key & ""
        Dim cmd As SqlCommand
        cmd = New SqlCommand(query, con)
        cmd.ExecuteNonQuery()
        MsgBox("Book Updated Sucessfully")
        con.Close()
        Populate()
    End Sub
End Class