Imports System.Data.SqlClient
Imports Common.Core.Extension

Public Class SinClaveUnicaSincronizar
    Implements Sincronizar

    Public Sub procesar(tabla As Tabla, sucursal As Integer, conexionLocal As SqlConnection, conexionRemota As SqlConnection, transaccionRemota As SqlTransaction, transaccionLocal As SqlTransaction) Implements Sincronizar.procesar
        Dim datos As DataTable = New DataTable()
        Try
            ' obtengo los datos a copiar.
            datos = ejecutarSQL(conexionRemota, "SELECT * FROM " + tabla.Nombre, transaccionRemota).Tables(0)

            If (datos.Rows.Count > 0) Then
                'elimino los datos locales
                Dim commandEliminoData As SqlCommand = New SqlCommand("DELETE  FROM " + tabla.Nombre, conexionLocal, transaccionLocal)
                commandEliminoData.ExecuteNonQuery()

                'copio los datos a base local
                Dim BulkCopy As New SqlBulkCopy(conexionLocal, SqlBulkCopyOptions.KeepIdentity, transaccionLocal)
                For Each column As DataColumn In datos.Columns
                    BulkCopy.ColumnMappings.Add(New SqlBulkCopyColumnMapping(column.ColumnName, column.ColumnName))
                Next
                BulkCopy.DestinationTableName = tabla.Nombre
                BulkCopy.WriteToServer(datos)
                BulkCopy.Close()
            End If
        Catch ex As Exception
            Throw New Exception($"Tabla: {tabla.Nombre} {Environment.NewLine} {datos.ToCVS()}", ex)
        End Try
    End Sub

    Private Function ejecutarSQL(conexion As SqlConnection, consulta As String, transaction As SqlTransaction) As DataSet
        Dim ds As DataSet = New DataSet()
        Dim da As SqlDataAdapter = New SqlDataAdapter(consulta, conexion)
        If (transaction IsNot Nothing) Then
            da.SelectCommand.Transaction = transaction
        End If
        da.Fill(ds)

        Return ds
    End Function
End Class
