Public Class Retangulo

    'Campos, Atributos ou Data Fields
    Private comprimento As Double
    Private largura As Double

    'Construtor 
    Public Sub New(C As Double, L As Double)
        largura = L
        comprimento = C
    End Sub

    'Método que retorna valor
    Public Function getArea() As Double
        Return comprimento * largura
    End Function

    'Método que não retorna valor
    Public Sub Initfields(C As Double, L As Double)
        comprimento = C
        largura = L
    End Sub

End Class
