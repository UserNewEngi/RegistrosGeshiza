Dim daoImpl As package
Imports java.sql.Connection
Imports java.sql.PreparedStatement
Imports java.sql.ResultSet
Imports javax.swing.JOptionPane
Imports javax.swing.JTable
Imports javax.swing.table.DefaultTableModel
Public Class HistorialDao

    Public Sub listarHistorial(ByVal con As Connection, ByVal tabla As JTable, ByVal tipoBusqueda As String, ByVal valorBusqueda As String)
        'columnas a mostrar en la tabla ya declaradas
        Dim model As DefaultTableModel
        Dim columnas() As String = New String() {"IdBoleto", "numeroBoleta", "metodoPago", "tipoPago", "origen", "destino", "asiento", "horaSalida", "fechaRegistro", "vendedor", "cliente", "dni", "placa"}
        model = New DefaultTableModel(Nothing, columnas)
        model.setRowCount(0)
        'copnsulta y ordene segun el id
        Dim sql As String = ("SELECT * FROM Boletos WHERE " _
                    + (tipoBusqueda + " = ? ORDER BY IdBoleto"))
        'crear filas
        Dim filas() As String = New String((13) - 1) {}
        Try
            PreparedStatement
        End Try

        pst = con.prepareStatement(sql)
        pst.setString(1, valorBusqueda)
        Dim rs As ResultSet = pst.executeQuery
        'validar si existe el dato
        'el metodo isBeforeFirst() verifica si el datos ingresado a buscar se encuentra en la tabla
        If Not rs.isBeforeFirst Then
            JOptionPane.showMessageDialog(Nothing, "Dato inexistente")
        Else
            While rs.next
                'recorra hasta el 8 si estan los datos
                Dim i As Integer = 0
                Do While (i < 13)
                    filas(i) = rs.getString((i + 1))
                    i = (i + 1)
                Loop

                model.addRow(filas)

            End While

        End If

        tabla.setModel(model)
        Exception
        e
        System.out.println
    End Sub
End Class