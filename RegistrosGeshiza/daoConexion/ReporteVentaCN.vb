Imports System.Data.SqlClient

Dim daoConexion As package
Imports connection.Conexion
Imports daoImpl.ReporteVentaDao
Imports java.sql.Star
Imports javax.swing.Star
Public Class ReporteVentaCN

    Private edao As ReporteVentaDao = New ReporteVentaDao

    Public Sub listarReporte(ByVal tabla As JTable)
        'conexion a la base
        Dim conn As Connection = Conexion.getConnection
        'mostrar los datos de la tabla
        Me.edao.listarReporte(conn, tabla)
        Try
            conn.close
        Catch ex As SQLException
            System.out.println(ex.getMessage)
        End Try

    End Sub
End Class

