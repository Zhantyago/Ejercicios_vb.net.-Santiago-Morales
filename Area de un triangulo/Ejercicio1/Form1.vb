Public Class Form1

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Calcular_Click(sender As Object, e As EventArgs) Handles Calcular.Click
        Dim num1, num2, resultado As Integer

        num1 = TextNum1.Text
        num2 = TextNum2.Text

        resultado = (num1 * num2) / 2

        MsgBox("El area del triangulo es: " + resultado.ToString)

    End Sub
End Class
