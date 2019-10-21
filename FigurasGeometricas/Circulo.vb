Imports System.Math
Public Class Circulo
    Inherits Figura

    Public Sub New()
        Me.radio = 0
    End Sub

    Public Property radio As UShort


    Public Overrides Function calcularArea() As Single
        Dim Pi = GetPi()
        Return Pi * Pow(radio, 2)
    End Function

    Public Function GetPi() As Double
        Return 4.0 * Math.Atan(1.0)
    End Function
End Class