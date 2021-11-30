Public Class Form1

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim txtNome As String = "Luiz"

        'Declara a variável que armazeranará o nome inserido no textbox'
        Dim strNome As String
        strNome = txtBox.Text

        'O nome é João?'
        If strNome <> "João" Then
            MessageBox.Show("O nome NÃO é João", "Comparação")
        End If

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        'Declara a variavel'
        Dim intNumero As Integer
        Try
            'Pega o número do textbox'
            intNumero = TextBox1.Text
        Catch
            Exit Sub
        End Try
        'O número é menor que 27?'
        If intNumero < 27 Then
            MessageBox.Show("intNumero é menor que 27? SIM!", "Comparação")
        Else
            MessageBox.Show("intNumero é menor que 27? NÂO!", "Comparação")
        End If


    End Sub
End Class
