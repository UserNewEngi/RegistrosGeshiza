Dim gestionChoferes As package
Imports java.util.ArrayList
Imports java.util.List
Public Class GestorDeChoferes

    Private choferes As List(Of Chofer)

    Public Sub New()
        MyBase.New
        Me.choferes = New ArrayList
        ' array de lista de choferes con sus placas
        Me.choferes.Add(New Chofer("Oscar Alberto Vargas Pe�a", "BRU-236"))
        Me.choferes.Add(New Chofer("Luis Enrique Castillo Moreno", "XZT-482"))
        Me.choferes.Add(New Chofer("Mario Enrique P�rez L�pez", "GHY-756"))
        Me.choferes.Add(New Chofer("Andr�s Felipe Torres Castillo", "QWE-134"))
        Me.choferes.Add(New Chofer("Roberto Carlos Men�ndez Rojas", "RTF-850"))
        Me.choferes.Add(New Chofer("Juan Pablo Valdez Morales", "LOP-679"))
        Me.choferes.Add(New Chofer("Santiago Alberto Luna Guerrero", "NMB-560"))
        Me.choferes.Add(New Chofer("Ricardo Jos� Alvarado Fern�ndez", "KLP-489"))
        Me.choferes.Add(New Chofer("Enrique Alfredo D�az Paredes", "WSD-378"))
        Me.choferes.Add(New Chofer("Fernando Gabriel Herrera P�rez", "OIL-952"))
    End Sub

    Public Function getChoferes() As List(Of Chofer)
        Return Me.choferes
    End Function

    Public Function buscarPlacaPorNombre(ByVal nombre As String) As String
        For Each c As Chofer In Me.choferes
            If c.getNombre.Equals(nombre) Then
                Return c.getPlaca0
            End If

        Next
        Return Nothing
    End Function
End Class
