Public Class Form1

    Public Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Myprogress.Increment(1)
        Label2.Text = Convert.ToString(Myprogress.Value) + "%"
        If Myprogress.Value = 100 Then
            Me.Hide()
            Dim log = New Bills
            log.Show()
            Timer1.Enabled() = "false"
        End If
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Start()
    End Sub


End Class
