Imports System.Data.SqlClient
Imports Common.Core.Extension

Public Class ClaveUnicaSincronizar
    Implements Sincronizar

    Dim clsDatos As New Datos.Conexion
    Dim encripta As New EncriptacionHelper

    Private Shared UltimaFechaSincronizacion As Date?

    Public Sub procesar(tabla As Tabla, sucursal As Integer, conexionLocal As SqlConnection, conexionRemota As SqlConnection, transaccionRemota As SqlTransaction, transaccionLocal As SqlTransaction) Implements Sincronizar.procesar
        Dim UltimaFechaSincronizacion As Date? = ObtenerUltimaFechaSincronizacion(conexionLocal, sucursal, transaccionLocal)

        sincronizarARemota(UltimaFechaSincronizacion, tabla, sucursal, conexionLocal, conexionRemota, transaccionRemota, transaccionLocal)
        sincronizarALocal(UltimaFechaSincronizacion, tabla, sucursal, conexionLocal, conexionRemota, transaccionRemota, transaccionLocal)
    End Sub

    Public Sub sincronizarALocal(UltimaFechaSincronizacion As Date?, Tabla As Tabla, sucursal As Integer, conexionLocal As SqlConnection, conexionRemota As SqlConnection, transaccionRemota As SqlTransaction, transaccionLocal As SqlTransaction)
        Dim DatosSincronizar As DataTable = New DataTable()
        Dim DatosLocal As DataTable
        Dim DatosRemoto As DataTable
        Try
            'Verifico que exista una ultima sincornizacion
            If (UltimaFechaSincronizacion.HasValue) Then
                'Selecciono todas las filas de la base local y remota desde la ultima sincronizacion
                DatosLocal = ejecutarSQL(conexionLocal, Tabla.SQLObtenerDatosRemoto, UltimaFechaSincronizacion, sucursal, transaccionLocal).Tables(0)
                DatosRemoto = ejecutarSQL(conexionRemota, Tabla.SQLObtenerDatosRemoto, UltimaFechaSincronizacion, sucursal, transaccionRemota).Tables(0)

                'obtengo todos los registros que fueron agregados o modificados
                DatosSincronizar = ObtenerDatos(DatosRemoto, DatosLocal, Tabla.ClavePrimaria, Tabla.ClaveSincronizacion)
            Else
                'Selecciono todas las filas de lo sultimos 3 meses la base remota
                Dim consulta As String = String.Format("SELECT * FROM {0} WHERE {1} >= @UltimaActualizacion", Tabla.Nombre, Tabla.ClaveSincronizacion)
                DatosSincronizar = ejecutarSQL(conexionRemota, consulta, DateTime.Now.AddMonths(-3), Nothing, transaccionRemota).Tables(0)
            End If

            If DatosSincronizar.Rows.Count > 0 Then

                'elimino los valores de la base remota
                Dim listaIdRow As List(Of DataRow) = DatosSincronizar.Rows.Cast(Of DataRow).Select(Function(x) x).ToList()

                Dim dt As DataTable = New DataTable()
                dt.Columns.Add("ID", Type.GetType("System.Int64"))

                For Each row As DataRow In listaIdRow
                    dt.Rows.Add(row(Tabla.ClavePrimaria))
                Next

                Dim commandEliminoData As SqlCommand = New SqlCommand("sp_Sincronizacion_Borrar_Datos", conexionLocal, transaccionLocal) With
                {
                  .CommandType = CommandType.StoredProcedure
                }

                With commandEliminoData.Parameters
                    .AddWithValue("@IDS", dt).SqlDbType = SqlDbType.Structured
                    .AddWithValue("@TABLA", Tabla.Nombre)
                    .AddWithValue("@COLUMNA_ID", Tabla.ClavePrimaria)
                End With
                commandEliminoData.ExecuteNonQuery()

                'subo los valores a la base local
                Dim BulkCopy As New SqlBulkCopy(conexionLocal, SqlBulkCopyOptions.Default, transaccionLocal)

                For Each column As DataColumn In DatosSincronizar.Columns
                    BulkCopy.ColumnMappings.Add(New SqlBulkCopyColumnMapping(column.ColumnName, column.ColumnName))
                Next
                BulkCopy.DestinationTableName = Tabla.Nombre
                BulkCopy.WriteToServer(DatosSincronizar)
                BulkCopy.Close()
            End If
        Catch ex As Exception
            Throw New Exception($"Fecha: {UltimaFechaSincronizacion} Tabla: {Tabla.Nombre} {Environment.NewLine} {DatosSincronizar.ToCVS()}", ex)
        End Try

    End Sub

    Public Sub sincronizarARemota(UltimaFechaSincronizacion As Date?, tabla As Tabla, sucursal As Integer, conexionLocal As SqlConnection, conexionRemota As SqlConnection, transaccionRemota As SqlTransaction, transaccionLocal As SqlTransaction)
        Dim DatosSincronizar As DataTable = New DataTable()
        Dim DatosLocal As DataTable
        Dim DatosRemoto As DataTable

        Try
            'Verifico que exista una ultima sincornizacion
            If (UltimaFechaSincronizacion.HasValue) Then
                'Selecciono todas las filas de la base local y remota desde la ultima sincronizacion
                DatosLocal = ejecutarSQL(conexionLocal, tabla.SQLObtenerDatosLocal, UltimaFechaSincronizacion, sucursal, transaccionLocal).Tables(0)
                DatosRemoto = ejecutarSQL(conexionRemota, tabla.SQLObtenerDatosLocal, UltimaFechaSincronizacion, sucursal, transaccionRemota).Tables(0)

                'obtengo todos los registros que fueron agregados o modificados
                DatosSincronizar = ObtenerDatos(DatosLocal, DatosRemoto, tabla.ClavePrimaria, tabla.ClaveSincronizacion)
            Else
                'Selecciono todas las filas de lo ultimo 6 meses la base local que pertenecen a la sucursal
                DatosSincronizar = ejecutarSQL(conexionLocal, tabla.SQLObtenerDatosLocal, DateTime.Now.AddMonths(-6), sucursal, transaccionLocal).Tables(0)
            End If

            Dim Res As String = String.Join(Environment.NewLine, DatosSincronizar.Rows.OfType(Of DataRow)().Select(Function(x) String.Join(" ; ", x.ItemArray)))

            If DatosSincronizar.Rows.Count > 0 Then
                'elimino los valores de la base remota
                Dim listaIdRow As List(Of DataRow) = DatosSincronizar.Rows.Cast(Of DataRow).Select(Function(x) x).ToList()

                Dim dt As DataTable = New DataTable()
                dt.Columns.Add("ID", Type.GetType("System.Int64"))

                For Each row As DataRow In listaIdRow
                    dt.Rows.Add(row(tabla.ClavePrimaria))
                Next

                Dim commandEliminoData As SqlCommand = New SqlCommand("sp_Sincronizacion_Borrar_Datos", conexionRemota, transaccionRemota) With
                {
                  .CommandType = CommandType.StoredProcedure
                }

                With commandEliminoData.Parameters
                    .AddWithValue("@TABLA", tabla.Nombre)
                    .AddWithValue("@COLUMNA_ID", tabla.ClavePrimaria)
                End With

                Dim param = commandEliminoData.Parameters.AddWithValue("@IDS", dt)
                param.SqlDbType = SqlDbType.Structured
                param.TypeName = "dbo.LISTA_ID_TYPE"

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
            Throw New Exception($"Fecha: {UltimaFechaSincronizacion} Tabla: {tabla.Nombre} {Environment.NewLine} {DatosSincronizar.ToCVS()}", ex)
        End Try
    End Sub

    Private Function ejecutarSQL(conexion As SqlConnection, consulta As String, ultimaActualizacion As Date?, sucursal As Integer?, transaction As SqlTransaction) As DataSet
        Dim ds As DataSet = New DataSet()

        'Dim da As SqlDataAdapter = New SqlDataAdapter(consulta, conexion)
        'If (transaction IsNot Nothing) Then
        '    da.SelectCommand.Transaction = transaction
        'End If
        'da.Fill(ds)

        Dim command As SqlCommand = New SqlCommand(consulta, conexion)

        If (ultimaActualizacion.HasValue) Then
            command.Parameters.Add("@UltimaActualizacion", SqlDbType.DateTime).Value = ultimaActualizacion.Value
        End If

        If (sucursal.HasValue) Then
            command.Parameters.Add("@Sucursal", SqlDbType.Int).Value = sucursal.Value
        End If

        Dim da As SqlDataAdapter = New SqlDataAdapter(command)
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

    Private Function ObtenerUltimaFechaSincronizacion(conexionLocal As SqlConnection, sucursal As Integer, transaccionLocal As SqlTransaction) As Date?

        If (Not UltimaFechaSincronizacion.HasValue) Then

            Dim consultaUltimaActualizacion As String = String.Format("SELECT FECHA FROM SINCORNIZACION WHERE id_Sucursal = @Sucursal")
            Dim UltimaFechasSincronizacion As DataTable = ejecutarSQL(conexionLocal, consultaUltimaActualizacion, Nothing, sucursal, transaccionLocal).Tables(0)
            Dim fecha As Date?
            If (UltimaFechasSincronizacion.Rows.Count > 0) Then
                UltimaFechaSincronizacion = UltimaFechasSincronizacion.Rows(0)("FECHA")
            End If
        End If

        Return UltimaFechaSincronizacion
    End Function
End Class
