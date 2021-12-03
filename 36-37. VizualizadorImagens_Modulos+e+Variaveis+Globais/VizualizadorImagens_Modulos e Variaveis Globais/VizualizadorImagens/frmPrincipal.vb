Imports System.ComponentModel

Public Class frmPrincipal


    Private Sub btnSobre_Click(sender As Object, e As EventArgs) Handles btnSobre.Click
        frmSobre.ShowDialog()

        mnuConfirmeAoSair.Checked = g_boolConfirmaAoSair
        picImagem.BackColor = g_colorFundoPadrao
    End Sub

    Private Sub frmPrincipal_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        If g_boolConfirmaAoSair Then
            If MessageBox.Show("Fechar o Visualizador de Imagens?",
                               "Visualizador de Imagens", MessageBoxButtons.YesNo,
                               MessageBoxIcon.Question) = DialogResult.No Then
                e.Cancel = True
            End If
        End If
    End Sub

    Private Sub mnuAbrirImagem_Click(sender As Object, e As EventArgs) Handles mnuAbrirImagem.Click

        'Mostra a caixa de dialogo
        If ofdSelecionaImagem.ShowDialog = DialogResult.OK Then
            'Carrega imagem no controle PictureBox
            picImagem.Image = Image.FromFile(ofdSelecionaImagem.FileName)
            'Mostrar nome do arquivo no titulo do form
            Me.Text = "Vizualizador de Imagens (" & ofdSelecionaImagem.FileName & ")"
        End If
    End Sub

    Private Sub mnuConfirmeAoSair_Click(sender As Object, e As EventArgs) Handles mnuConfirmeAoSair.Click
        mnuConfirmeAoSair.Checked = Not mnuConfirmeAoSair.Checked
        g_boolConfirmaAoSair = mnuConfirmeAoSair.Checked
    End Sub

    Private Sub mnuSair_Click(sender As Object, e As EventArgs) Handles mnuSair.Click
        Me.Close()
    End Sub

    Private Sub mnuSobre_Click(sender As Object, e As EventArgs) Handles mnuSobre.Click
        frmSobre.ShowDialog()

        mnuConfirmeAoSair.Checked = g_boolConfirmaAoSair
        picImagem.BackColor = g_colorFundoPadrao
    End Sub
End Class
