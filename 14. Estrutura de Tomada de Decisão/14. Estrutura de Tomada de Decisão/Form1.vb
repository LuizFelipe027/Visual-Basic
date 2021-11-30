Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim intNumero As Integer = 27

        'Tomada de decisao'
        If intNumero = 1000 Then
            MessageBox.Show("IntNumero é exatamente 1000!", "IF Simples")
        ElseIf intNumero = 27 Then
            MessageBox.Show("IntNumero é exatamente 27!", "IF Simples")
        Else
            MessageBox.Show("IntNumero não é exatamente 1000 e 27!", "IF Simples")
        End If
    End Sub
End Class
