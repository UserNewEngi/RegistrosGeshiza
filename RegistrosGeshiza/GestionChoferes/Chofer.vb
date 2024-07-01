Dim gestionChoferes As package
Public Class Chofer

    Private nombre As String

    Private placa As String

    Public Sub New(ByVal nombre As String, ByVal placa As String)
        MyBase.New
        Me.nombre = Me.nombre
        Me.placa = Me.placa
    End Sub

    Public Function getNombre() As String
        Return Me.nombre
    End Function

    Public Function getPlaca() As String
        Return Me.placa
    End Function
End Class