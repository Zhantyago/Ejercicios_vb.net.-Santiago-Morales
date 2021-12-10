Public Class Form1

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim hora As Integer
        Dim menu As String

        hora = TextBox1.Text

        If (hora >= 7 And hora <= 10) Then
            menu = "Desayunos"
        ElseIf hora > 10 And hora <= 15 Then
            menu = "Almuerzos"
        ElseIf hora > 15 And hora <= 18 Then
            menu = "Merienda"
        ElseIf hora > 18 And hora <= 22 Then
            menu = "Cena"
        Else
            menu = "El local se encuentra cerrado, vuelva dentro del horario establecido de 7 a 22"

        End If

        TextBox2.Text = menu

    End Sub
    Private Sub TextBox1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox1.KeyPress
        If Char.IsNumber(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsSeparator(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        TextBox1.Clear()
        TextBox2.Clear()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.Close()
    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub
End Class
