Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Dim i, n, faktoriyel As Integer

        faktoriyel = 1
        n = Val(TextBox1.Text)

        For i = 1 To n
            faktoriyel = faktoriyel * i
        Next

        TextBox2.Text = faktoriyel

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
