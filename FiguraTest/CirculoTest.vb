Imports FigurasGeometricas
Module CirculoTest
    Sub circulo()
        Dim circulo1 As New Circulo()
        circulo1.radio = 3
        Console.WriteLine("Circulo")
        Console.WriteLine("radio: " & circulo1.radio)
        Console.WriteLine("Radio del circulo: " & circulo1.calcularArea())
    End Sub
End Module
