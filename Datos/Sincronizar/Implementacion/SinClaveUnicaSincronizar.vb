Imports System.Data.SqlClient
Imports Datos

Public Class SinClaveUnicaSincronizar
    Implements Sincronizar

    Public Sub procesar(tabla As Tabla, valorBusqueda As String, conexionLocal As SqlConnection, conexionRemota As SqlConnection, transaccionRemota As SqlTransaction, transaccionLocal As SqlTransaction) Implements Sincronizar.procesar
        ' obtengo los datos a copiar.

        Dim datos As DataTable = ejecutarSQL(conexionRemota, "SELECT * FROM " + tabla.Nombre, transaccionRemota).Tables(0)

        If (datos.Rows.Count > 0) Then
            'elimino los datos locales
            Dim commandEliminoData As SqlCommand = New SqlCommand("DELETE  FROM " + tabla.Nombre, conexionLocal, transaccionLocal)
            commandEliminoData.ExecuteNonQuery()

            'copio los datos a base local
            Dim BulkCopy As New SqlBulkCopy(conexionLocal, SqlBulkCopyOptions.KeepIdentity, transaccionLocal)
            BulkCopy.DestinationTableName = tabla.Nombre
            BulkCopy.WriteToServer(datos)
            BulkCopy.Close()
        End If
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
