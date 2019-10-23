Imports System.Math
Public Class Circulo
    Inherits Figura

    Public Sub New(nombre As String, radio As Single)
        MyBase.New(nombre)
        Me.radio = radio
    End Sub

    Public Property radio As Single


    Public Overrides Function calcularArea() As Single
        Dim Pi = GetPi()
        Return Pi * Pow(radio, 2)
    End Function

    Public Function GetPi() As Double
        Return 4.0 * Math.Atan(1.0)
    End Function
End Class