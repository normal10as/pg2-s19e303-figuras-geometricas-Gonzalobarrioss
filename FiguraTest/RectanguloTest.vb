Imports FigurasGeometricas
Module RectanguloTest
    Sub rectangulo()
        Dim Rectangulo1 As New Rectangulo()
        Rectangulo1.base = 2
        Rectangulo1.altura = 4
        Console.WriteLine("Rectangulo")
        Console.WriteLine("base: {0}, altura: {1}", Rectangulo1.base, Rectangulo1.altura)
        Console.WriteLine("Area del rectangulo: " & Rectangulo1.calcularArea())
    End Sub

End Module

