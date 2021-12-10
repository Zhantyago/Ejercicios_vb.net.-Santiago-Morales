Public Class Form1

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim n, n1, d As Integer

        n = Val(TextBox1.Text)
        n1 = 0
        Do Until n = 0
            d = n Mod 10
            n = n / 10
            n1 = n1 * 10 + d
        Loop
        TextBox2.Text = n1
    End Sub
End Class
