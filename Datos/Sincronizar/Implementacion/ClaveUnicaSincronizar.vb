Imports System.Data.SqlClient
Imports Datos
Imports System.Linq
Imports System.Collections.Generic
Imports System.Text

Public Class ClaveUnicaSincronizar
    Implements Sincronizar

    Dim clsDatos As New Datos.Conexion
    Dim encripta As New ClsEncriptacion

    Public Sub procesar(tabla As Tabla, valorBusqueda As String, conexionLocal As SqlConnection, conexionRemota As SqlConnection, transaccionRemota As SqlTransaction, transaccionLocal As SqlTransaction) Implements Sincronizar.procesar
        sincronizarARemota(tabla, valorBusqueda, conexionLocal, conexionRemota, transaccionRemota, transaccionLocal)
        sincronizarALocal(tabla, valorBusqueda, conexionLocal, conexionRemota, transaccionRemota, transaccionLocal)
    End Sub

    Public Sub sincronizarALocal(tabla As Tabla, valorBusqueda As String, conexionLocal As SqlConnection, conexionRemota As SqlConnection, transaccionRemota As SqlTransaction, transaccionLocal As SqlTransaction)
        Dim UltimaFechasSincronizacion As DataTable
        Dim fecha As Date
        Try
            Dim DatosSincronizar As DataTable = New DataTable()

            'Verifico que exista una ultima sincornizacion
            UltimaFechasSincronizacion = ejecutarSQL(conexionLocal, String.Format("SELECT FECHA FROM SINCORNIZACION WHERE id_Sucursal = {0}", valorBusqueda), transaccionLocal).Tables(0)
            Dim DatosLocal As DataTable
            Dim DatosRemoto As DataTable

            If (UltimaFechasSincronizacion.Rows.Count > 0) Then
                'Selecciono todas las filas de la base local y remota desde la ultima sincronizacion
                fecha = UltimaFechasSincronizacion.Rows(0)("FECHA")
                DatosLocal = ejecutarSQL(conexionLocal, String.Format(tabla.SQLObtenerDatosRemoto, fecha.ToString("yyyy-MM-dd"), valorBusqueda), transaccionLocal).Tables(0)
                DatosRemoto = ejecutarSQL(conexionRemota, String.Format(tabla.SQLObtenerDatosRemoto, fecha.ToString("yyyy-MM-dd"), valorBusqueda), transaccionRemota).Tables(0)

                'obtengo todos los registros que fueron agregados o modificados
                DatosSincronizar = ObtenerDatos(DatosRemoto, DatosLocal, tabla.ClavePrimaria, tabla.ClaveSincronizacion)
            Else
                'Selecciono todas las filas de lo sultimos 3 meses la base remota
                DatosSincronizar = ejecutarSQL(conexionRemota, String.Format("SELECT * FROM {0} WHERE {1} >= {2}", tabla.Nombre, tabla.ClaveSincronizacion, DateTime.Now.AddMonths(-3).ToString("yyyy-MM-dd")), transaccionRemota).Tables(0)
            End If

            If DatosSincronizar.Rows.Count > 0 Then

                Dim listaId As String = String.Join(",", DatosSincronizar.Rows.Cast(Of DataRow).Select(Function(x) x(tabla.ClavePrimaria)).ToArray())

                Dim commandEliminoData As SqlCommand = New SqlCommand(String.Format("Delete from {0} where {1} in ({2})", tabla.Nombre, tabla.ClavePrimaria, listaId), conexionLocal, transaccionLocal)
                commandEliminoData.ExecuteNonQuery()

                'subo los valores a la base remota
                Dim BulkCopy As New SqlBulkCopy(conexionLocal, SqlBulkCopyOptions.Default, transaccionLocal)

                For Each column As DataColumn In DatosSincronizar.Columns
                    BulkCopy.ColumnMappings.Add(New SqlBulkCopyColumnMapping(column.ColumnName, column.ColumnName))
                Next
                BulkCopy.DestinationTableName = tabla.Nombre
                BulkCopy.WriteToServer(DatosSincronizar)
                BulkCopy.Close()
            End If
        Catch ex As Exception
            Throw New Exception(String.Format("DATOS UltimaFechasSincronizacion {0}  fecha {1}", UltimaFechasSincronizacion.Rows.Count.ToString(), fecha), ex)
        End Try

    End Sub

    Public Sub sincronizarARemota(tabla As Tabla, valorBusqueda As String, conexionLocal As SqlConnection, conexionRemota As SqlConnection, transaccionRemota As SqlTransaction, transaccionLocal As SqlTransaction)
        Dim UltimaFechasSincronizacion As DataTable
        Dim fecha As Date
        Try
            Dim DatosSincronizar As DataTable = New DataTable()

            'Verifico que exista una ultima sincornizacion
            UltimaFechasSincronizacion = ejecutarSQL(conexionRemota, String.Format("SELECT FECHA FROM SINCORNIZACION WHERE id_Sucursal = {0}", valorBusqueda), transaccionRemota).Tables(0)
            Dim DatosLocal As DataTable
            Dim DatosRemoto As DataTable

            If (UltimaFechasSincronizacion.Rows.Count > 0) Then
                'Selecciono todas las filas de la base local y remota desde la ultima sincronizacion
                fecha = UltimaFechasSincronizacion.Rows(0)("FECHA")
                DatosLocal = ejecutarSQL(conexionLocal, String.Format(tabla.SQLObtenerDatosLocal, fecha.ToString("yyyy-MM-dd"), valorBusqueda), transaccionLocal).Tables(0)
                DatosRemoto = ejecutarSQL(conexionRemota, String.Format(tabla.SQLObtenerDatosLocal, fecha.ToString("yyyy-MM-dd"), valorBusqueda), transaccionRemota).Tables(0)

                'obtengo todos los registros que fueron agregados o modificados
                DatosSincronizar = ObtenerDatos(DatosLocal, DatosRemoto, tabla.ClavePrimaria, tabla.ClaveSincronizacion)
            Else
                'Selecciono todas las filas de la base local
                DatosSincronizar = ejecutarSQL(conexionLocal, String.Format("SELECT * FROM {0} WHERE {1} >= {2}", tabla.Nombre, tabla.ClaveSincronizacion, DateTime.Now.AddMonths(-3).ToString("yyyy-MM-dd")), transaccionRemota).Tables(0)
            End If

            If DatosSincronizar.Rows.Count > 0 Then

                Dim listaId As String = String.Join(",", DatosSincronizar.Rows.Cast(Of DataRow).Select(Function(x) x(tabla.ClavePrimaria)).ToArray())

                Dim commandEliminoData As SqlCommand = New SqlCommand(String.Format("Delete from {0} where {1} in ({2})", tabla.Nombre, tabla.ClavePrimaria, listaId), conexionRemota, transaccionRemota)
                commandEliminoData.ExecuteNonQuery()

                'subo los valores a la base remota
                Dim BulkCopy As New SqlBulkCopy(conexionRemota, SqlBulkCopyOptions.Default, transaccionRemota)
                For Each column As DataColumn In DatosSincronizar.Columns
                    BulkCopy.ColumnMappings.Add(New SqlBulkCopyColumnMapping(column.ColumnName, column.ColumnName))
                Next
                BulkCopy.DestinationTableName = tabla.Nombre
                BulkCopy.WriteToServer(DatosSincronizar)
                BulkCopy.Close()
            End If
        Catch ex As Exception
            Throw New Exception(String.Format("DATOS UltimaFechasSincronizacion {0}  fecha {1}", UltimaFechasSincronizacion.Rows.Count.ToString(), fecha), ex)
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

    Private Function ObtenerDatos(DatosLocal As DataTable, DatosRemoto As DataTable, ClavePrimaria As String, ColumnaUltimaModificacion As String) As DataTable

        Dim tablaDiferencias As DataTable = DatosLocal.Clone()
        Dim rowDiferencia As DataRow = Nothing

        For Each rowLocal As DataRow In DatosLocal.Rows
            Dim rowRemota As DataRow = DatosRemoto.Rows.Cast(Of DataRow).FirstOrDefault(Function(x) x(ClavePrimaria) = rowLocal(ClavePrimaria))
            If rowRemota Is Nothing Then
                tablaDiferencias.ImportRow(rowLocal)
            ElseIf rowLocal(ColumnaUltimaModificacion) > rowRemota(ColumnaUltimaModificacion) Then
                tablaDiferencias.ImportRow(rowLocal)
            End If
        Next

        Return tablaDiferencias
    End Function
End Class
