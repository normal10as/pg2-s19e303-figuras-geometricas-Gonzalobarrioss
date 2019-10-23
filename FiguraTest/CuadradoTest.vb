Imports FigurasGeometricas
Module CuadradoTest
    Sub cuadrado()
        Dim cuadrado1 As New Cuadrado("Cuadrado", 2)
        Console.WriteLine("Nombre: " & cuadrado1.nombre)
        Console.WriteLine("lado: " & cuadrado1.lado)
        Console.WriteLine("Area del cuadrado: " & cuadrado1.calcularArea())
    End Sub
End Module
