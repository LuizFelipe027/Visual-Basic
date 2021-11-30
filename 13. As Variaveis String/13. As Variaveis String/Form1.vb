Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'Declara a variável'
        Dim strResultado As String

        'Atribui um valor string'
        strResultado = "Hello Word!"

        'Mostra Resultado'
        MessageBox.Show(strResultado, "Strings")
    End Sub
End Class
