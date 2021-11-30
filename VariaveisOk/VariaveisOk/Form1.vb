Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim intNumero As Integer
        intNumero = 27
        intNumero = intNumero + 1
        MessageBox.Show("intNumero + 1 = " & intNumero.ToString, "Variáveis")

    End Sub
End Class
