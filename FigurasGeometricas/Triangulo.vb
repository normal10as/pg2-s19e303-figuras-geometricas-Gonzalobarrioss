Public Class Triangulo
    Inherits Figura

    Public Sub New()
        Me.base = 0
        Me.altura = 0
    End Sub

    Public Property base As UShort
    Public Property altura As UShort

    Public Overrides Function calcularArea() As Single
        Return (base * altura) / 2
    End Function

End Class
