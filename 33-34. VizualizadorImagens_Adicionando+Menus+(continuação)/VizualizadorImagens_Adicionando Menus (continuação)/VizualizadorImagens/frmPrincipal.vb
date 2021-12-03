Public Class frmPrincipal
    Private Sub btnSobre_Click(sender As Object, e As EventArgs) Handles btnSobre.Click
        frmSobre.ShowDialog()

    End Sub

    Private Sub mnuAbrirImagem_Click(sender As Object, e As EventArgs) Handles mnuAbrirImagem.Click
        'Define Local da Imagem
        Dim strNomeArquivo As String = Application.StartupPath & "\BackgroundForm.jpg"
        'Carrega imagem no controle PictureBox
        picImagem.Image = Image.FromFile(strNomeArquivo)
        'Mostrar nome do arquivo no titulo do form
        Me.Text = "Vizualizador de Imagens (" & strNomeArquivo & ")"

    End Sub

    Private Sub mnuConfirmeAoSair_Click(sender As Object, e As EventArgs) Handles mnuConfirmeAoSair.Click
        mnuConfirmeAoSair.Checked = Not mnuConfirmeAoSair.Checked
    End Sub

    Private Sub mnuSair_Click(sender As Object, e As EventArgs) Handles mnuSair.Click
        Me.Close()
    End Sub

    Private Sub mnuSobre_Click(sender As Object, e As EventArgs) Handles mnuSobre.Click
        frmSobre.ShowDialog()
    End Sub
End Class
