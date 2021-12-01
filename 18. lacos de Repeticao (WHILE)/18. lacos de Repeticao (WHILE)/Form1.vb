Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'Declara as variaveis'
        Dim intConta As Integer = 0

        'Chamada da sub Rotina LimpaLista'
        LimpaLista()

        'Executa loop enquanto intConta < 5
        Do While intConta < 5
            'Adiciona o número na lista
            TextBox2.Items.Add(intConta.ToString)
            intConta += 1
        Loop
    End Sub

    Private Sub LimpaLista()
        'limpa a lista'
        TextBox2.Items.clear()

    End Sub

End Class
