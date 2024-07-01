Imports System.Data.SqlClient

Dim daoConexion As package
Imports connection.Conexion
Imports javax.swing.JTable
Imports java.sql.Star
Imports daoImpl.HistorialDao
Public Class HistorialCN

    Private edao As HistorialDao = New HistorialDao

    Public Sub listarHistorial(ByVal tabla As JTable, ByVal tipoBusqueda As String, ByVal valorBusqueda As String)
        Try
            Connection
        End Try

        conn = Conexion.getConnection
        ' Mostrar los datos de la tabla
        Me.edao.listarHistorial(conn, tabla, tipoBusqueda, valorBusqueda)
        SQLException
        ex
        System.out.println(ex.getMessage)
    End Sub
End Class
