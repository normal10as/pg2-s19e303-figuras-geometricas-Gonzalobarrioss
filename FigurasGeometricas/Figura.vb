Public Class Figura
    Public Sub New()
        Me.nombre = ""
    End Sub

    Private _nombre As String
    Public Property nombre As String
        Get
            Return _nombre
        End Get
        Set(value As String)
            _nombre = value
        End Set
    End Property

    Public Overridable Function calcularArea() As Single

    End Function
End Class
