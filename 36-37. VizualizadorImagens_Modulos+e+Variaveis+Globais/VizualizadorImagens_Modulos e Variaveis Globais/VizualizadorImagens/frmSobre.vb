Public Class frmSobre
  Private Sub frmSobre_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Icon = frmPrincipal.Icon

        txtNomeUsuario.Text = g_strNomeUsuario
        chkMensagemAoSair.Checked = g_boolConfirmaAoSair

        If g_colorFundoPadrao = Color.White Then
            optCorDeFundoBranca.Checked = True
        Else
            optCorDeFundoPadrao.Checked = True
        End If
    End Sub

    Private Sub btnOK_Click(sender As Object, e As EventArgs) Handles btnOK.Click
        Me.Close()
    End Sub

    Private Sub btnCancela_Click(sender As Object, e As EventArgs) Handles btnCancela.Click
        Me.Close()
    End Sub

    Private Sub frmSobre_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        g_strNomeUsuario = txtNomeUsuario.Text
        g_boolConfirmaAoSair = chkMensagemAoSair.Checked

        If optCorDeFundoBranca.Checked Then
            g_colorFundoPadrao = Color.White
        Else
            g_colorFundoPadrao = System.Drawing.SystemColors.Control
        End If
    End Sub
End Class