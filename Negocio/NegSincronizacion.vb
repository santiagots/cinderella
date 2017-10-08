Imports Entidades
Imports System.Data.SqlClient
Imports Datos
Imports System.Linq
Imports System.Collections.Generic

Public Class NegSincronizacion
    Dim objUsuario As Entidades.Usuario
    Dim clsDatos As New Datos.Conexion
    Dim con As New Conexion
    Dim negFunciones As New Negocio.Funciones
    Private CadenaConexion As String
    Dim miconexion As SqlConnection
    Dim conexionRemoto As SqlConnection
    Dim encripta As New ClsEncriptacion


    Public Function ProbarConectarLocal()
        Dim estado As Boolean
        estado = False
        Try
            CadenaConexion = System.Configuration.ConfigurationManager.ConnectionStrings("SistemaCinderella.My.MySettings.Conexion").ToString
            miconexion = New SqlConnection
            miconexion.ConnectionString = CadenaConexion
            miconexion.Open()
            estado = True
            miconexion.Dispose()
        Catch ex As Exception
            Windows.Forms.MessageBox.Show("Error conectando con la base de datos local." & ex.Message)
        End Try
        Return estado
    End Function

    Public Function ProbarConectarRemoto()
        Dim estado As Boolean
        estado = False
        Try
            CadenaConexion = System.Configuration.ConfigurationManager.ConnectionStrings("SistemaCinderella.My.MySettings.ConexionRemoto").ToString
            conexionRemoto = New SqlConnection
            conexionRemoto.ConnectionString = encripta.DesencriptarMD5(CadenaConexion)
            conexionRemoto.Open()
            estado = True
            conexionRemoto.Dispose()
        Catch ex As Exception
            Windows.Forms.MessageBox.Show("Error conectando con la base de datos remota." & ex.Message)
        End Try
        Return estado
    End Function

    Public Function Sincronizar(ByVal Tabla As String) As Integer
        Dim estado As Integer = 0

        Try
            'conexion remota
            CadenaConexion = System.Configuration.ConfigurationManager.ConnectionStrings("SistemaCinderella.My.MySettings.ConexionRemoto").ToString
            conexionRemoto = New SqlConnection
            conexionRemoto.ConnectionString = encripta.DesencriptarMD5(CadenaConexion)
            conexionRemoto.Open()

            'conexion local
            CadenaConexion = System.Configuration.ConfigurationManager.ConnectionStrings("SistemaCinderella.My.MySettings.Conexion").ToString
            miconexion = New SqlConnection
            miconexion.ConnectionString = CadenaConexion
            miconexion.Open()

            Dim transaccion As SqlTransaction
            transaccion = miconexion.BeginTransaction()

            ' obtengo los datos a copiar.
            Dim commandSourceData As SqlDataAdapter = New SqlDataAdapter("SELECT * FROM " + Tabla, conexionRemoto)
            Dim ds As DataSet = New DataSet()
            commandSourceData.Fill(ds)

            If (ds.Tables(0).Rows.Count > 0) Then
                'elimino los datos locales: "la gente esta muy loca jonhy"
                Dim commandEliminoData As SqlCommand = New SqlCommand("DELETE  FROM " + Tabla, miconexion, transaccion)
                commandEliminoData.ExecuteNonQuery()

                'copio los datos a base local
                Dim BulkCopy As New SqlBulkCopy(miconexion, SqlBulkCopyOptions.KeepIdentity, transaccion)
                BulkCopy.DestinationTableName = Tabla

                Try
                    BulkCopy.WriteToServer(ds.Tables(0))
                    transaccion.Commit()
                    BulkCopy.Close()
                    estado = 1
                Catch ex As Exception
                    transaccion.Rollback()
                    BulkCopy.Close()
                End Try
            Else
                estado = 2
                ' reader.Close()
            End If

        Catch ex As Exception
            Windows.Forms.MessageBox.Show("Se produjo un error sincronizando los datos de " & Tabla & ": " & ex.Message, "Actualizacion fallida")
            miconexion.Dispose()
            conexionRemoto.Dispose()

        Finally
            miconexion.Dispose()
            conexionRemoto.Dispose()
        End Try

        Return estado
    End Function

    Public Sub DeshabilitarConstraint()
        Dim cmd As New SqlCommand
        cmd.Connection = clsDatos.ConectarLocal()
        cmd.CommandType = CommandType.Text
        cmd.CommandText = "EXEC sp_MSforeachtable @command1=""ALTER TABLE ? NOCHECK CONSTRAINT ALL"""
        cmd.ExecuteNonQuery()
        clsDatos.DesconectarLocal()

        cmd = New SqlCommand
        cmd.Connection = clsDatos.ConectarRemoto()
        cmd.CommandType = CommandType.Text
        cmd.CommandText = "EXEC sp_MSforeachtable @command1=""ALTER TABLE ? NOCHECK CONSTRAINT ALL"""
        cmd.ExecuteNonQuery()
        clsDatos.ConectarRemoto()
    End Sub

    Public Sub HabilitarConstraint()
        Dim cmd As New SqlCommand
        cmd.Connection = clsDatos.ConectarLocal()
        cmd.CommandType = CommandType.Text
        cmd.CommandText = "EXEC sp_MSforeachtable @command1=""ALTER TABLE ? CHECK CONSTRAINT ALL"""
        cmd.ExecuteNonQuery()
        clsDatos.DesconectarLocal()

        cmd = New SqlCommand
        cmd.Connection = clsDatos.ConectarRemoto()
        cmd.CommandType = CommandType.Text
        cmd.CommandText = "EXEC sp_MSforeachtable @command1=""ALTER TABLE ? CHECK CONSTRAINT ALL"""
        cmd.ExecuteNonQuery()
        clsDatos.ConectarRemoto()
    End Sub

    Public Function SincronizarLocalARemota(ByRef Tabla As Tabla, valorBusqueda As String) As Integer

        Dim conexionLocal As SqlConnection = clsDatos.ConectarLocal()
        Dim conexionRemota As SqlConnection = clsDatos.ConectarRemoto()

        Dim transaccionRemota As SqlTransaction
        Dim transaccionLocal As SqlTransaction

        transaccionRemota = conexionRemota.BeginTransaction()
        transaccionLocal = conexionLocal.BeginTransaction()

        Tabla.valorBusqueda = valorBusqueda

        Try
            Tabla.Sincronizar.sincronizarARemota(Tabla, valorBusqueda, conexionLocal, conexionRemota, transaccionRemota, transaccionLocal)

            Tabla.Sincronizar.sincronizarALocal(Tabla, valorBusqueda, conexionLocal, conexionRemota, transaccionRemota, transaccionLocal)

            transaccionLocal.Commit()
            transaccionRemota.Commit()
        Catch ex As Exception
            transaccionLocal.Rollback()
            transaccionRemota.Rollback()
            Throw New Exception("Se encontró un error al subir los datos de la base de datos local a la remota. Por favor, vuelva a intentar más tarde o comuníquese con el administrador.")
        Finally
            conexionRemota.Close()
            conexionLocal.Close()
        End Try

        Return 2
    End Function

    Sub AltaSincronizacion(ByVal idSucursal As Integer)
        'Declaro variables
        Dim cmd As New SqlCommand
        Dim HayInternet As Boolean = Funciones.HayInternet

        cmd.Connection = clsDatos.ConectarLocal()
        AltaSincronizacion(idSucursal, cmd)
        clsDatos.DesconectarLocal()

        If HayInternet Then
            cmd = New SqlCommand()
            cmd.Connection = clsDatos.ConectarRemoto()
            AltaSincronizacion(idSucursal, cmd)
            clsDatos.DesconectarRemoto()
        End If
    End Sub

    Private Shared Sub AltaSincronizacion(ByVal idSucursal As Integer, ByRef cmd As SqlCommand)
        'Ejecuto el Stored.
        cmd.CommandType = CommandType.StoredProcedure
        cmd.CommandText = "sp_Sincronizacion_Alta"
        With cmd.Parameters
            .AddWithValue("@id_Sucursal", idSucursal)
        End With

        cmd.ExecuteNonQuery()
    End Sub

    Function ObtenerUltimaSincronizacion(ByVal idSucursal As Integer) As Date
        'Declaro variables
        Dim fecha As Date
        Dim cmd As New SqlCommand
        Dim HayInternet As Boolean = Funciones.HayInternet

        If HayInternet Then
            cmd.Connection = clsDatos.ConectarRemoto()
            fecha = ObtenerUltimaSincronizacion(idSucursal, cmd)
            clsDatos.DesconectarRemoto()
        Else
            cmd.Connection = clsDatos.ConectarLocal()
            fecha = ObtenerUltimaSincronizacion(idSucursal, cmd)
            clsDatos.DesconectarLocal()
        End If

        Return fecha
    End Function

    Private Shared Function ObtenerUltimaSincronizacion(ByVal idSucursal As Integer, ByRef cmd As SqlCommand) As Date
        'Ejecuto el Stored.
        cmd.CommandType = CommandType.StoredProcedure
        cmd.CommandText = "sp_Sincronizacion_Obtener_Ultima"
        With cmd.Parameters
            .AddWithValue("@id_Sucursal", idSucursal)
        End With

        'Respuesta del Stored.
        Dim respuesta As New SqlParameter("@fecha", SqlDbType.Date, 255)
        respuesta.Direction = ParameterDirection.Output
        cmd.Parameters.Add(respuesta)
        cmd.ExecuteNonQuery()

        If (respuesta.Value Is DBNull.Value) Then
            Return Date.MinValue
        Else
            Return respuesta.Value
        End If
    End Function

    Public Function GetInformacionTablasLocales() As List(Of Tabla)
        Dim respuesta As List(Of Tabla) = New List(Of Tabla)

        respuesta.Add(EmpleadosRegistros()) 'ESTAS
        respuesta.Add(EmpleadosRegistrosPresentes()) 'ESTAS
        respuesta.Add(EmpleadosRegistrosAusentes()) 'ESTAS
        respuesta.Add(EmpleadosRegistrosTarde()) 'ESTAS
        respuesta.Add(CajaInicial()) 'ESTAS
        respuesta.Add(MovimientosCajas()) 'ESTAS
        respuesta.Add(MovimientosCajaFuerte()) 'ESTAS
        respuesta.Add(Adicionales()) 'ESTAS
        respuesta.Add(EmpleadoRecibo()) 'ESTAS
        respuesta.Add(MovimientoAporte()) 'ESTAS
        respuesta.Add(EmpleadoDeposito()) 'ESTAS
        respuesta.Add(Deuda()) 'ESTAS
        respuesta.Add(Adelanto()) 'ESTAS
        respuesta.Add(Stock()) 'ESTAS
        respuesta.Add(StockBitacora()) 'ESTAS
        respuesta.Add(MovimientoGastos()) 'ESTAS
        respuesta.Add(CuentaCorriente()) 'ESTAS
        respuesta.Add(Mercaderia())
        respuesta.Add(Ventas())
        respuesta.Add(Presupuesto())
        respuesta.Add(Notapedido()) 'ESTAS
        respuesta.Add(NotapedidoDetalle()) 'ESTAS
        respuesta.Add(Facturacion())
        respuesta.Add(Notacredito())
        respuesta.Add(Devolucion())
        respuesta.Add(MovimientoImpuesto()) 'ESTAS
        respuesta.Add(Cheque())
        respuesta.Add(MoviminetoRetiro()) 'ESTAS
        respuesta.Add(Senia())

        Return respuesta
    End Function

    Private Shared Function EmpleadosRegistros() As Tabla
        Dim tabla As Tabla = New Tabla()
        tabla.ClavePrimaria = "id_Registro"
        tabla.ClaveSincronizacion = "Fecha_Edicion"
        tabla.Nombre = "EMPLEADOS_REGISTROS"
        tabla.SQLObtenerDatosLocal = "select * from EMPLEADOS_REGISTROS where Fecha_Edicion >= CONVERT(DATETIME,'{0}',103) AND id_Sucursal = {1}"
        tabla.SQLObtenerDatosRemoto = "select * from EMPLEADOS_REGISTROS where Fecha_Edicion >= CONVERT(DATETIME,'{0}',103) AND id_Sucursal <> {1}"

        tabla.Sincronizar = New ClaveUnicaSincronizar()
        Return tabla
    End Function

    Private Shared Function EmpleadosRegistrosPresentes() As Tabla
        Dim tabla As Tabla = New Tabla()
        tabla.ClavePrimaria = "id_Auto"
        tabla.ClaveSincronizacion = "Fecha_Edicion"
        tabla.Nombre = "REL_REGISTRO_EMPLEADOS"
        tabla.SQLObtenerDatosLocal = "select * from EMPLEADOS_REGISTROS AS ER INNER JOIN REL_REGISTRO_EMPLEADOS AS R ON ER.id_Registro = R.id_Auto where R.Fecha_Edicion >= CONVERT(DATETIME,'{0}',103) AND ER.id_Sucursal = {1}"
        tabla.SQLObtenerDatosRemoto = "select * from EMPLEADOS_REGISTROS AS ER INNER JOIN REL_REGISTRO_EMPLEADOS AS R ON ER.id_Registro = R.id_Auto where R.Fecha_Edicion >= CONVERT(DATETIME,'{0}',103) AND ER.id_Sucursal <> {1}"

        tabla.Sincronizar = New ClaveUnicaSincronizar()
        Return tabla
    End Function

    Private Shared Function EmpleadosRegistrosAusentes() As Tabla
        Dim tabla As Tabla = New Tabla()
        tabla.ClavePrimaria = "id_Auto"
        tabla.ClaveSincronizacion = "Fecha_Edicion"
        tabla.Nombre = "REL_REGISTRO_EMPLEADOS_AUSENTES"
        tabla.SQLObtenerDatosLocal = "select * from EMPLEADOS_REGISTROS AS ER INNER JOIN REL_REGISTRO_EMPLEADOS_AUSENTES AS R ON ER.id_Registro = R.id_Auto where R.Fecha_Edicion >= CONVERT(DATETIME,'{0}',103) AND ER.id_Sucursal = {1}"
        tabla.SQLObtenerDatosRemoto = "select * from EMPLEADOS_REGISTROS AS ER INNER JOIN REL_REGISTRO_EMPLEADOS_AUSENTES AS R ON ER.id_Registro = R.id_Auto where R.Fecha_Edicion >= CONVERT(DATETIME,'{0}',103) AND ER.id_Sucursal <> {1}"

        tabla.Sincronizar = New ClaveUnicaSincronizar()
        Return tabla
    End Function

    Private Shared Function EmpleadosRegistrosTarde() As Tabla
        Dim tabla As Tabla = New Tabla()
        tabla.ClavePrimaria = "id_Auto"
        tabla.ClaveSincronizacion = "Fecha_Edicion"
        tabla.Nombre = "REL_REGISTRO_EMPLEADOS_TARDE"
        tabla.SQLObtenerDatosLocal = "select * from EMPLEADOS_REGISTROS AS ER INNER JOIN REL_REGISTRO_EMPLEADOS_TARDE AS R ON ER.id_Registro = R.id_Auto where R.Fecha_Edicion >= CONVERT(DATETIME,'{0}',103) AND ER.id_Sucursal = {1}"
        tabla.SQLObtenerDatosRemoto = "select * from EMPLEADOS_REGISTROS AS ER INNER JOIN REL_REGISTRO_EMPLEADOS_TARDE AS R ON ER.id_Registro = R.id_Auto where R.Fecha_Edicion >= CONVERT(DATETIME,'{0}',103) AND ER.id_Sucursal <> {1}"

        tabla.Sincronizar = New ClaveUnicaSincronizar()
        Return tabla
    End Function

    Private Shared Function CajaInicial() As Tabla
        Dim tabla As Tabla = New Tabla()
        tabla.ClavePrimaria = "id_Caja"
        tabla.ClaveSincronizacion = "Fecha_Edicion"
        tabla.Nombre = "CAJA_INICIAL"
        tabla.SQLObtenerDatosLocal = "select * from CAJA_INICIAL where Fecha_Edicion >= CONVERT(DATETIME,'{0}',103) AND id_Sucursal = {1}"
        tabla.SQLObtenerDatosRemoto = "select * from CAJA_INICIAL where Fecha_Edicion >= CONVERT(DATETIME,'{0}',103) AND id_Sucursal <> {1}"

        tabla.Sincronizar = New ClaveUnicaSincronizar()
        Return tabla
    End Function

    Private Shared Function MovimientosCajas() As Tabla
        Dim tabla As Tabla = New Tabla()

        tabla.ClavePrimaria = "id_Movimiento"
        tabla.ClaveSincronizacion = "Fecha_Edicion"
        tabla.Nombre = "MOVIMIENTOS_CAJA"
        tabla.SQLObtenerDatosLocal = "select * from MOVIMIENTOS_CAJA where Fecha_Edicion >= CONVERT(DATETIME,'{0}',103) AND id_Sucursal = {1}"
        tabla.SQLObtenerDatosRemoto = "select * from MOVIMIENTOS_CAJA where Fecha_Edicion >= CONVERT(DATETIME,'{0}',103) AND id_Sucursal <> {1}"

        tabla.Sincronizar = New ClaveUnicaSincronizar()

        Return tabla
    End Function

    Private Shared Function MovimientosCajaFuerte() As Tabla
        Dim tabla As Tabla = New Tabla()

        tabla.ClavePrimaria = "id_Movimiento"
        tabla.ClaveSincronizacion = "Fecha_Edicion"
        tabla.Nombre = "MOVIMIENTOS_CAJA_FUERTE"
        tabla.SQLObtenerDatosLocal = "select * from MOVIMIENTOS_CAJA_FUERTE where Fecha_Edicion >= CONVERT(DATETIME,'{0}',103) AND id_Sucursal = {1}"
        tabla.SQLObtenerDatosRemoto = "select * from MOVIMIENTOS_CAJA_FUERTE where Fecha_Edicion >= CONVERT(DATETIME,'{0}',103) AND id_Sucursal <> {1}"

        tabla.Sincronizar = New ClaveUnicaSincronizar()

        Return tabla
    End Function

    Private Shared Function Adicionales() As Tabla
        Dim tabla As Tabla = New Tabla()

        tabla.ClavePrimaria = "id_Adicional"
        tabla.ClaveSincronizacion = "Fecha_Edicion"
        tabla.Nombre = "ADICIONALES"
        tabla.SQLObtenerDatosLocal = "select * from ADICIONALES where Fecha_Edicion >= CONVERT(DATETIME,'{0}',103) AND id_Sucursal = {1}"
        tabla.SQLObtenerDatosRemoto = "select * from ADICIONALES where Fecha_Edicion >= CONVERT(DATETIME,'{0}',103) AND id_Sucursal <> {1}"

        tabla.Sincronizar = New ClaveUnicaSincronizar()

        Return tabla
    End Function

    Private Shared Function EmpleadoRecibo() As Tabla
        Dim tabla As Tabla = New Tabla()

        tabla.ClavePrimaria = "id_Recibo"
        tabla.ClaveSincronizacion = "Fecha_Edicion"
        tabla.Nombre = "EMPLEADOS_RECIBOS"
        tabla.SQLObtenerDatosLocal = "select * from EMPLEADOS_RECIBOS where Fecha_Edicion >= CONVERT(DATETIME,'{0}',103) AND id_Sucursal = {1}"
        tabla.SQLObtenerDatosRemoto = "select * from EMPLEADOS_RECIBOS where Fecha_Edicion >= CONVERT(DATETIME,'{0}',103) AND id_Sucursal <> {1}"

        tabla.Sincronizar = New ClaveUnicaSincronizar()

        Return tabla
    End Function

    Private Shared Function MovimientoAporte() As Tabla
        Dim tabla As Tabla = New Tabla()

        tabla.ClavePrimaria = "id_Movimiento"
        tabla.ClaveSincronizacion = "Fecha_Edicion"
        tabla.Nombre = "MOVIMIENTOS_APORTE"
        tabla.SQLObtenerDatosLocal = "select * from MOVIMIENTOS_APORTE where Fecha_Edicion >= CONVERT(DATETIME,'{0}',103) AND id_Sucursal = {1}"
        tabla.SQLObtenerDatosRemoto = "select * from MOVIMIENTOS_APORTE where Fecha_Edicion >= CONVERT(DATETIME,'{0}',103) AND id_Sucursal <> {1}"

        tabla.Sincronizar = New ClaveUnicaSincronizar()

        Return tabla
    End Function

    Private Shared Function EmpleadoDeposito() As Tabla
        Dim tabla As Tabla = New Tabla()

        tabla.ClavePrimaria = "id_Deposito"
        tabla.ClaveSincronizacion = "Fecha_Edicion"
        tabla.Nombre = "EMPLEADOS_DEPOSITOS"
        tabla.SQLObtenerDatosLocal = "select * from EMPLEADOS_DEPOSITOS where Fecha_Edicion >= CONVERT(DATETIME,'{0}',103) AND id_Sucursal = {1}"
        tabla.SQLObtenerDatosRemoto = "select * from EMPLEADOS_DEPOSITOS where Fecha_Edicion >= CONVERT(DATETIME,'{0}',103) AND id_Sucursal <> {1}"

        tabla.Sincronizar = New ClaveUnicaSincronizar()

        Return tabla
    End Function

    Private Shared Function Deuda() As Tabla
        Dim tabla As Tabla = New Tabla()

        tabla.ClavePrimaria = "id_Deuda"
        tabla.ClaveSincronizacion = "Fecha_Edicion"
        tabla.Nombre = "DEUDA"
        tabla.SQLObtenerDatosLocal = "select * from DEUDA where Fecha_Edicion >= CONVERT(DATETIME,'{0}',103) AND id_Sucursal = {1}"
        tabla.SQLObtenerDatosRemoto = "select * from DEUDA where Fecha_Edicion >= CONVERT(DATETIME,'{0}',103) AND id_Sucursal <> {1}"

        tabla.Sincronizar = New ClaveUnicaSincronizar()
        Return tabla

    End Function

    Private Shared Function Adelanto() As Tabla
        Dim tabla As Tabla = New Tabla()

        tabla.ClavePrimaria = "id_Adelanto"
        tabla.ClaveSincronizacion = "Fecha_Edicion"
        tabla.Nombre = "ADELANTOS"
        tabla.SQLObtenerDatosLocal = "select * from ADELANTOS where Fecha_Edicion >= CONVERT(DATETIME,'{0}',103) AND id_Sucursal = {1}"
        tabla.SQLObtenerDatosRemoto = "select * from ADELANTOS where Fecha_Edicion >= CONVERT(DATETIME,'{0}',103) AND id_Sucursal <> {1}"

        tabla.Sincronizar = New ClaveUnicaSincronizar()
        Return tabla
    End Function

    Private Shared Function Stock() As Tabla
        Dim tabla As Tabla = New Tabla()

        tabla.ClavePrimaria = "id_Stock"
        tabla.ClaveSincronizacion = "Fecha_Edicion"
        tabla.Nombre = "STOCK"
        tabla.SQLObtenerDatosLocal = "select * from STOCK where Fecha_Edicion >= CONVERT(DATETIME,'{0}',103) AND id_Sucursal = {1}"
        tabla.SQLObtenerDatosRemoto = "select * from STOCK where Fecha_Edicion >= CONVERT(DATETIME,'{0}',103) AND id_Sucursal <> {1}"

        tabla.Sincronizar = New ClaveUnicaSincronizar()
        Return tabla
    End Function

    Private Shared Function StockBitacora() As Tabla
        Dim tabla As Tabla = New Tabla()

        tabla.ClavePrimaria = "id_Bitacora"
        tabla.ClaveSincronizacion = "Fecha_Edicion"
        tabla.Nombre = "STOCK_BITACORA"
        tabla.SQLObtenerDatosLocal = "select * from STOCK_BITACORA where Fecha_Edicion >= CONVERT(DATETIME,'{0}',103) AND id_Sucursal = {1}"
        tabla.SQLObtenerDatosRemoto = "select * from STOCK_BITACORA where Fecha_Edicion >= CONVERT(DATETIME,'{0}',103) AND id_Sucursal <> {1}"

        tabla.Sincronizar = New ClaveUnicaSincronizar()
        Return tabla
    End Function

    Private Shared Function MovimientoGastos() As Tabla
        Dim tabla As Tabla = New Tabla()

        tabla.ClavePrimaria = "id_Movimiento"
        tabla.ClaveSincronizacion = "Fecha_Edicion"
        tabla.Nombre = "MOVIMIENTOS_GASTOS"
        tabla.SQLObtenerDatosLocal = "select * from MOVIMIENTOS_GASTOS where Fecha_Edicion >= CONVERT(DATETIME,'{0}',103) AND id_Sucursal = {1}"
        tabla.SQLObtenerDatosRemoto = "select * from MOVIMIENTOS_GASTOS where Fecha_Edicion >= CONVERT(DATETIME,'{0}',103) AND id_Sucursal <> {1}"

        tabla.Sincronizar = New ClaveUnicaSincronizar()
        Return tabla
    End Function

    Private Shared Function CuentaCorriente() As Tabla
        Dim tabla As Tabla = New Tabla()

        tabla.ClavePrimaria = "id_Registro"
        tabla.ClaveSincronizacion = "Fecha_Edicion"
        tabla.Nombre = "CUENTA_CORRIENTE"
        tabla.SQLObtenerDatosLocal = "select * from CUENTA_CORRIENTE where Fecha_Edicion >= CONVERT(DATETIME,'{0}',103) AND id_Sucursal = {1}"
        tabla.SQLObtenerDatosRemoto = "select * from CUENTA_CORRIENTE where Fecha_Edicion >= CONVERT(DATETIME,'{0}',103) AND id_Sucursal <> {1}"

        tabla.Sincronizar = New ClaveUnicaSincronizar()
        Return tabla
    End Function

    Private Shared Function Mercaderia() As Tabla
        Dim tabla As Tabla = New Tabla()
        tabla.Nombre = "MERCADERIAS"
        tabla.ClavePrimaria = "id_Mercaderia"
        tabla.ColumnaSeleccion = "id_Sucursal"
        tabla.Sincronizar = New ClaveRepetidaSincronizar()
        tabla.IdAcualizados = New List(Of KeyValuePair(Of Integer, Integer))
        tabla.TablaRelacionada = New List(Of Tabla)

        Dim tablaRelelacionada As Tabla = New Tabla()
        tablaRelelacionada.Nombre = "MERCADERIAS_DETALLE"
        tablaRelelacionada.ClavePrimaria = "id_Detalle"
        tablaRelelacionada.ColumnaSeleccion = "id_Mercaderia"
        tablaRelelacionada.ClaveForanea = New String() {"id_Mercaderia"}
        tablaRelelacionada.IdAcualizados = New List(Of KeyValuePair(Of Integer, Integer))

        tabla.TablaRelacionada.Add(tablaRelelacionada)
        Return tabla
    End Function

    Private Shared Function Ventas() As Tabla
        Dim tabla As Tabla = New Tabla()
        tabla.Nombre = "VENTAS"
        tabla.ClavePrimaria = "id_Venta"
        tabla.ColumnaSeleccion = "id_Sucursal"
        tabla.Sincronizar = New ClaveRepetidaSincronizar()
        tabla.IdAcualizados = New List(Of KeyValuePair(Of Integer, Integer))
        tabla.TablaRelacionada = New List(Of Tabla)

        Dim tablaRelelacionada1 As Tabla = New Tabla()
        tablaRelelacionada1.Nombre = "VENTAS_DETALLE"
        tablaRelelacionada1.ClavePrimaria = "id_Detalle"
        tablaRelelacionada1.ColumnaSeleccion = "id_Venta"
        tablaRelelacionada1.ClaveForanea = New String() {"id_Venta"}
        tablaRelelacionada1.IdAcualizados = New List(Of KeyValuePair(Of Integer, Integer))

        tabla.TablaRelacionada.Add(tablaRelelacionada1)

        Dim tablaRelelacionada2 As Tabla = New Tabla()
        tablaRelelacionada2.Nombre = "COMISIONES"
        tablaRelelacionada2.ClavePrimaria = "id_Comision"
        tablaRelelacionada2.ColumnaSeleccion = "id_Venta"
        tablaRelelacionada2.ClaveForanea = New String() {"id_Venta"}
        tablaRelelacionada2.IdAcualizados = New List(Of KeyValuePair(Of Integer, Integer))

        tabla.TablaRelacionada.Add(tablaRelelacionada2)

        Dim tablaRelelacionada3 As Tabla = New Tabla()
        tablaRelelacionada3.Nombre = "SENIA"
        tablaRelelacionada3.ClavePrimaria = "id_Senia"
        tablaRelelacionada3.ColumnaSeleccion = "id_Venta_Senia"
        tablaRelelacionada3.ClaveForanea = New String() {"id_Venta_Senia", "id_Venta_Retiro"}
        tablaRelelacionada3.IdAcualizados = New List(Of KeyValuePair(Of Integer, Integer))

        tabla.TablaRelacionada.Add(tablaRelelacionada3)
        Return tabla
    End Function

    Private Shared Function Presupuesto() As Tabla
        Dim tabla As Tabla = New Tabla()
        tabla.Nombre = "PRESUPUESTO"
        tabla.ClavePrimaria = "id_Presupuesto"
        tabla.ColumnaSeleccion = "id_Sucursal"
        tabla.Sincronizar = New ClaveRepetidaSincronizar()
        tabla.IdAcualizados = New List(Of KeyValuePair(Of Integer, Integer))
        tabla.TablaRelacionada = New List(Of Tabla)

        Dim tablaRelelacionada1 As Tabla = New Tabla()
        tablaRelelacionada1.Nombre = "PRESUPUESTO_DETALLE"
        tablaRelelacionada1.ClavePrimaria = "id_Detalle"
        tablaRelelacionada1.ColumnaSeleccion = "id_Presupuesto"
        tablaRelelacionada1.ClaveForanea = New String() {"id_Presupuesto"}
        tablaRelelacionada1.IdAcualizados = New List(Of KeyValuePair(Of Integer, Integer))

        tabla.TablaRelacionada.Add(tablaRelelacionada1)
        Return tabla
    End Function

    Private Shared Function Notapedido() As Tabla
        Dim tabla As Tabla = New Tabla()
        tabla.ClavePrimaria = "id_NotaPedido"
        tabla.ClaveSincronizacion = "Fecha_Edicion"
        tabla.Nombre = "NOTAPEDIDO"
        tabla.SQLObtenerDatosLocal = "select * from NOTAPEDIDO where Fecha_Edicion >= CONVERT(DATETIME,'{0}',103) AND id_Sucursal = {1}"
        tabla.SQLObtenerDatosRemoto = "select * from NOTAPEDIDO where Fecha_Edicion >= CONVERT(DATETIME,'{0}',103) AND id_Sucursal <> {1}"

        tabla.Sincronizar = New ClaveUnicaSincronizar()
        Return tabla
    End Function

    Private Shared Function NotapedidoDetalle() As Tabla
        Dim tabla As Tabla = New Tabla()
        tabla.ClavePrimaria = "id_Detalle"
        tabla.ClaveSincronizacion = "Fecha_Edicion"
        tabla.Nombre = "NOTAPEDIDO_DETALLE"
        tabla.SQLObtenerDatosLocal = "Select D.* 
                                        From NOTAPEDIDO T 
                                        INNER Join NOTAPEDIDO_DETALLE D ON D.id_NotaPedido = T.id_NotaPedido
                                        where D.Fecha_Edicion >= CONVERT(DATETIME,'{0}',103) and T.id_Sucursal = {1}"
        tabla.SQLObtenerDatosRemoto = "Select D.* 
                                        From NOTAPEDIDO T 
                                        INNER Join NOTAPEDIDO_DETALLE D ON D.id_NotaPedido = T.id_NotaPedido
                                        where D.Fecha_Edicion >= CONVERT(DATETIME,'{0}',103) and T.id_Sucursal <> {1}"
        tabla.Sincronizar = New ClaveUnicaSincronizar()
        Return tabla
    End Function

    Private Shared Function Facturacion() As Tabla
        Dim tabla As Tabla = New Tabla()
        tabla.Nombre = "FACTURACION"
        tabla.ClavePrimaria = "id_Facturacion"
        tabla.ColumnaSeleccion = "Id_Sucursal"
        tabla.Sincronizar = New ClaveRepetidaSincronizar()
        tabla.IdAcualizados = New List(Of KeyValuePair(Of Integer, Integer))
        tabla.TablaRelacionada = New List(Of Tabla)

        Return tabla
    End Function

    Private Shared Function Notacredito() As Tabla
        Dim tabla As Tabla = New Tabla()
        tabla.Nombre = "NOTACREDITO"
        tabla.ClavePrimaria = "id_NotaCredito"
        tabla.ColumnaSeleccion = "Id_Sucursal"
        tabla.Sincronizar = New ClaveRepetidaSincronizar()
        tabla.IdAcualizados = New List(Of KeyValuePair(Of Integer, Integer))
        tabla.TablaRelacionada = New List(Of Tabla)

        Return tabla
    End Function

    Private Shared Function Devolucion() As Tabla
        Dim tabla As Tabla = New Tabla()
        tabla.Nombre = "DEVOLUCIONES"
        tabla.ClavePrimaria = "id_Devolucion"
        tabla.ColumnaSeleccion = "id_Sucursal"
        tabla.Sincronizar = New ClaveRepetidaSincronizar()
        tabla.IdAcualizados = New List(Of KeyValuePair(Of Integer, Integer))
        tabla.TablaRelacionada = New List(Of Tabla)

        Dim tablaRelelacionada1 As Tabla = New Tabla()
        tablaRelelacionada1.Nombre = "DEVOLUCIONES_DETALLE"
        tablaRelelacionada1.ClavePrimaria = "id_Detalle"
        tablaRelelacionada1.ColumnaSeleccion = "id_Devolucion"
        tablaRelelacionada1.ClaveForanea = New String() {"id_Devolucion"}
        tablaRelelacionada1.IdAcualizados = New List(Of KeyValuePair(Of Integer, Integer))

        tabla.TablaRelacionada.Add(tablaRelelacionada1)
        Return tabla
    End Function

    Private Shared Function MovimientoImpuesto() As Tabla
        Dim tabla As Tabla = New Tabla()
        tabla.ClavePrimaria = "id_Movimiento"
        tabla.ClaveSincronizacion = "Fecha_Edicion"
        tabla.Nombre = "MOVIMIENTOS_IMPUESTOS"
        tabla.SQLObtenerDatosLocal = "select * from MOVIMIENTOS_IMPUESTOS where Fecha_Edicion >= CONVERT(DATETIME,'{0}',103) AND id_Sucursal = {1}"
        tabla.SQLObtenerDatosRemoto = "select * from MOVIMIENTOS_IMPUESTOS where Fecha_Edicion >= CONVERT(DATETIME,'{0}',103) AND id_Sucursal <> {1}"

        tabla.Sincronizar = New ClaveUnicaSincronizar()
        Return tabla
    End Function

    Private Shared Function Cheque() As Tabla
        Dim tabla As Tabla = New Tabla()
        tabla.Nombre = "CHEQUE"
        tabla.ClavePrimaria = "id_Cheque"
        tabla.ColumnaSeleccion = "SucursalId"
        tabla.Sincronizar = New ClaveRepetidaSincronizar()
        tabla.IdAcualizados = New List(Of KeyValuePair(Of Integer, Integer))
        tabla.TablaRelacionada = New List(Of Tabla)

        Return tabla
    End Function

    Private Shared Function MoviminetoRetiro() As Tabla

        Dim tabla As Tabla = New Tabla()

        tabla.ClavePrimaria = "id_Movimiento"
        tabla.ClaveSincronizacion = "Fecha_Edicion"
        tabla.Nombre = "MOVIMIENTOS_RETIROS"
        tabla.SQLObtenerDatosLocal = "select * from MOVIMIENTOS_RETIROS where Fecha_Edicion >= CONVERT(DATETIME,'{0}',103) AND id_Sucursal = {1}"
        tabla.SQLObtenerDatosRemoto = "select * from MOVIMIENTOS_RETIROS where Fecha_Edicion >= CONVERT(DATETIME,'{0}',103) AND id_Sucursal <> {1}"

        tabla.Sincronizar = New ClaveUnicaSincronizar()

        Return tabla
    End Function

    Private Shared Function Senia() As Tabla
        Dim tabla As Tabla = New Tabla()
        tabla.Nombre = "SENIA"
        tabla.ClavePrimaria = "id_Senia"
        tabla.ColumnaSeleccion = "id_Sucursal"
        tabla.Sincronizar = New ClaveRepetidaSincronizar()
        tabla.IdAcualizados = New List(Of KeyValuePair(Of Integer, Integer))
        tabla.TablaRelacionada = New List(Of Tabla)

        Return tabla
    End Function
End Class