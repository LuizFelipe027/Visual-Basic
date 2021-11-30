Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'Declara Variável'
        Dim intConta As Integer

        'Chamada da Sub Rotina LimpaLista'
        LimpaLista()

        'Loop FOR para preencher lista'
        For intConta = 1 To 5
            'Adiciona item na lista'
            lstDados.Items.Add("Eu sou o item: " & intConta.ToString & " na lista !")
        Next

    End Sub

    'Criando uma Sub Rotina:'
    Private Sub LimpaLista()
        lstDados.Items.Clear()
    End Sub

End Class
