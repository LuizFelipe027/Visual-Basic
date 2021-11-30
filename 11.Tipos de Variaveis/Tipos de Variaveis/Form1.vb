Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim intIdade As Integer = 20
        Dim dblAltura As Double = 1.9
        Dim strNome As String = "Luiz"
        Dim blnPossuiFilhos As Boolean = False

        MsgBox(intIdade)
        MsgBox(dblAltura)
        MsgBox(strNome)
        MsgBox(blnPossuiFilhos)
    End Sub
End Class
