Public Class frmSobre
  Private Sub frmSobre_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    Me.Icon = frmPrincipal.Icon
  End Sub

    Private Sub btnOK_Click(sender As Object, e As EventArgs) Handles btnOK.Click
        Me.Close()
    End Sub

    Private Sub btnCancela_Click(sender As Object, e As EventArgs) Handles btnCancela.Click
        Me.Close()
    End Sub
End Class