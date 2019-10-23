Imports FigurasGeometricas

Module TrianguloTest
    Sub Triangulo()
        Dim triangulo1 As New Triangulo("Triangulo", 2, 4)
        Console.WriteLine("Nombre: " & triangulo1.nombre)
        Console.WriteLine("base: {0}, altura: {1}", triangulo1.base, triangulo1.altura)
        Console.WriteLine("Area del triangulo: " & triangulo1.calcularArea())
    End Sub
End Module
