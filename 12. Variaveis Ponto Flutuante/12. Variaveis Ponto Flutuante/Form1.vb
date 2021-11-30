Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'Declare a Variável'
        Dim dblNumero As Double

        'Atribiu, Multiplica e mostra'
        dblNumero = 45.34
        dblNumero *= 4.333

        MessageBox.Show("Teste de Multiplicaçao: " & dblNumero.ToString, "Pontos Flutuantes")


        'Atribiu, divide e mostra'
        dblNumero = 12
        dblNumero /= 7

        MessageBox.Show("Teste de Divisão: " & dblNumero.ToString, "Pontos Flutuantes")


    End Sub
End Class
