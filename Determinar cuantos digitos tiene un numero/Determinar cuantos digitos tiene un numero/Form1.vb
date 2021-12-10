Public Class Form1

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim numero As Integer

        numero = Val(TextBox1.Text)
        If (numero <= 9) Then
            TextBox2.Text = "1"
        ElseIf (numero <= 99) Then
            TextBox2.Text = "2"
        ElseIf (numero <= 999) Then
            TextBox2.Text = "3"
        ElseIf (numero <= 9999) Then
            TextBox2.Text = "4"
        ElseIf (numero <= 99999) Then
            TextBox2.Text = "5"
        ElseIf (numero <= 999999) Then
            TextBox2.Text = "6"
        ElseIf (numero <= 9999999) Then
            TextBox2.Text = "7"
        ElseIf (numero <= 99999999) Then
            TextBox2.Text = "8"
        ElseIf (numero <= 999999999) Then
            TextBox2.Text = "9"
        ElseIf (numero <= 9999999999) Then
            TextBox2.Text = "10"
        Else
            TextBox2.Text = "Error, pruebe con otro numero"
        End If

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
    End Sub
End Class
