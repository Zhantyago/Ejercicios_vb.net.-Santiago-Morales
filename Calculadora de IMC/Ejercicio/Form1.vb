Public Class Form1

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim peso, altura, IMC As Double

        peso = TextBox1.Text
        altura = TextBox2.Text

        IMC = peso / altura ^ 2

        If (IMC < 18.49) Then
            MsgBox("Usted posee infrapeso, y su IMC es de: " + IMC.ToString)
        ElseIf (IMC > 18.5 And IMC < 24.99) Then
            MsgBox("Usted posee un peso normal y su IMC es de: " + IMC.ToString)
        ElseIf (IMC > 25.0 And IMC < 29.0) Then
            MsgBox("Usted posee sobrepeso y su IMC es de: " + IMC.ToString)
        Else
            MsgBox("Usted es obeso y su IMC es de: " + IMC.ToString)
        End If

    End Sub
End Class
