Imports FigurasGeometricas
Module CuadradoTest
    Sub cuadrado()
        Dim cuadrado1 As New Cuadrado()
        cuadrado1.lado = 2
        Console.WriteLine("Cuadrado")
        Console.WriteLine("lado: " & cuadrado1.lado)
        Console.WriteLine("Area del cuadrado: " & cuadrado1.calcularArea())
    End Sub
End Module
