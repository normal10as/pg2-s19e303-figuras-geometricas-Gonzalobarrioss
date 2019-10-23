Public Class Rectangulo
    Inherits Figura

    Public Sub New(nombre As String, base As Single, altura As Single)
        MyBase.New(nombre)
        Me.base = base
        Me.altura = altura
    End Sub

    Public Property base As Single
    Public Property altura As Single

    Public Overrides Function calcularArea() As Single
        Return altura * base
    End Function
End Class
