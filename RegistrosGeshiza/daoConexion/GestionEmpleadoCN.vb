Imports System.Data.SqlClient

Dim daoConexion As package
Imports connection.Conexion
Imports model.GestionEmpleado
Imports daoImpl.GestionEmpleadoDao
Imports java.sql.Star
Imports javax.swing.JTable
Public Class GestionEmpleadoCN

    Private mensaje As String = ""

    Private edao As GestionEmpleadoDao = New GestionEmpleadoDao

    Public Function agregarEmpleado(ByVal emp As GestionEmpleado) As String
        'se crea la conexion
        Dim conn As Connection = Conexion.getConnection
        Try
            'la va a trabajar en la clase DAO se envia y recibe. //el emp igual recibe y envia datos
            Me.mensaje = Me.edao.agregarEmpleado(conn, emp)
            'el roll bat detiene la conxion
            conn.rollback
        Catch e As Exception
            System.out.println(e)
        Finally
            Try
                If (Not (conn) Is Nothing) Then
                    conn.close
                End If

            Catch e As Exception
                System.out.println(e)
            End Try

        End Try

        Return Nothing
    End Function

    Public Function actualizarEmpleado(ByVal emp As GestionEmpleado) As String
        Dim conn As Connection = Conexion.getConnection
        Try
            'la va a trabajar en la clase DAO se envia y recibe. //el emp igual recibe y envia datos
            Me.mensaje = Me.edao.actualizarEmpleado(conn, emp)
            'el roll bat detiene la conxion
            conn.rollback
        Catch e As Exception
            System.out.println(e)
        Finally
            Try
                If (Not (conn) Is Nothing) Then
                    conn.close
                End If

            Catch e As Exception
                System.out.println(e)
            End Try

        End Try

        Return Me.mensaje
    End Function

    Public Function eliminarEmpleado(ByVal id As Integer) As String
        Dim conn As Connection = Conexion.getConnection
        Try
            'la va a trabajar en la clase DAO se envia y recibe. //el emp igual recibe y envia datos
            Me.mensaje = Me.edao.eliminarEmpleado(conn, id)
            'el roll bat detiene la conxion
            conn.rollback
        Catch e As Exception
            Me.mensaje = (Me.mensaje + (" " + e.getMessage))
        Finally
            Try
                If (Not (conn) Is Nothing) Then
                    conn.close
                End If

            Catch e As Exception
                Me.mensaje = (Me.mensaje + (" " + e.getMessage))
            End Try

        End Try

        Return Me.mensaje
    End Function

    Public Sub listarEmpleado(ByVal tabla As JTable)
        Dim conn As Connection = Conexion.getConnection
        Me.edao.listarEmpleado(conn, tabla)
        Try
            conn.close
        Catch ex As SQLException
            System.out.println(ex.getMessage)
        End Try

    End Sub
End Class