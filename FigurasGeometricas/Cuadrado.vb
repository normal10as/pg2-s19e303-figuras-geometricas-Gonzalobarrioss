Public Class Cuadrado
    Inherits Figura

    Public Sub New()
        Me.lado = 0
    End Sub

    Public Property lado As UShort

    Public Overrides Function calcularArea() As Single
        Return lado * lado
    End Function
End Class
