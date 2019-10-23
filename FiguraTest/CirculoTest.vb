Imports FigurasGeometricas
Module CirculoTest
    Sub circulo()
        Dim circulo1 As New Circulo("Circulo", 3)
        Console.WriteLine("Nombre: " & circulo1.nombre)
        Console.WriteLine("radio: " & circulo1.radio)
        Console.WriteLine("Radio del circulo: " & circulo1.calcularArea())
    End Sub
End Module
