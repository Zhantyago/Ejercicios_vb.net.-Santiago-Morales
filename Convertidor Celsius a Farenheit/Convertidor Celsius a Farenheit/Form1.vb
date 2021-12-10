Public Class Form1

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
       
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim celsius As Integer
        Dim farenheit As Double
        Dim resultadofarenheit As Double

        celsius = Val(TextBox1.Text)
        farenheit = Val(TextBox2.Text)
        resultadofarenheit = (9 / 5) * (celsius + 32)

        TextBox2.Text = resultadofarenheit

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
    End Sub
End Class
