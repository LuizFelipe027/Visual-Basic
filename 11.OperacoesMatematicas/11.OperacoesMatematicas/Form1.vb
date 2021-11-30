Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'Declara a variável'
        Dim intNumero As Integer

        'Seta número, soma numero e mostra resultado'
        intNumero = 16
        intNumero += 8
        MessageBox.Show("Teste de soma: " & intNumero.ToString, "Matemática com Integer")

        'seta nnumero, subtrai e mostra resultado'
        intNumero = 24
        intNumero -= 2
        MessageBox.Show("Teste de Subtração: " & intNumero.ToString, "Matemática com Integer")

        'Seta numero, multiplica numero e mostra o resultado'
        intNumero = 6
        intNumero *= 10
        MessageBox.Show("Teste de multiplicação: " & intNumero.ToString, "Matemática com Integer")

        'Seta numero, divide numero e mostra o resultado'
        intNumero = 12
        intNumero /= 6
        MessageBox.Show("Teste de divisão: " & intNumero.ToString, "Matemática com Integer")

    End Sub
End Class

