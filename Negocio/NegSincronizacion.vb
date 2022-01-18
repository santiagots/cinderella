Imports Entidades
Imports System.Data.SqlClient
Imports Datos
Imports System.Linq
Imports System.Collections.Generic
Imports System.IO
Imports System.Reflection

Public Class NegSincronizacion
    Dim objUsuario As Entidades.Usuario
    Dim clsDatos As New Datos.Conexion
    Dim con As New Conexion
    Dim negFunciones As New Negocio.Funciones
    Private CadenaConexion As String
    Dim miconexion As SqlConnection
    Dim conexionRemoto As SqlConnection
    Dim encripta As New ClsEncriptacion

    Public Function Sincronizar(ByVal Tabla As String) As Integer
        Dim estado As Integer = 0

        Try
            'conexion remota
            CadenaConexion = Conexion.STRING_CONEXION_BASE_REMOTA
            conexionRemoto = New SqlConnection
            conexionRemoto.ConnectionString = encripta.DesencriptarMD5(CadenaConexion)
            conexionRemoto.Open()

            'conexion local
            CadenaConexion = Conexion.STRING_CONEXION_BASE_LOCAL
            miconexion = New SqlConnection
            miconexion.ConnectionString = String.Format(CadenaConexion, Assembly.GetEntryAssembly.GetName().Name)
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
            .AddWithValue("@fecha", DateTime.Now)
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

    Public Function GetTablas() As List(Of Tabla)
        Dim tablas As List(Of Tabla) = New List(Of Tabla)
        tablas.AddRange(GetInformacionTablasLocales())
        tablas.AddRange(GetInformacionTablasRemotas())

        Return tablas
    End Function

    Public Function GetInformacionTablasRemotas() As List(Of Tabla)
        Dim respuesta As List(Of Tabla) = New List(Of Tabla)

        respuesta.Add(New Tabla() With {.Nombre = "REL_USUARIOS_PERFILES", .Sincronizar = New SinClaveUnicaSincronizar()})
        respuesta.Add(New Tabla() With {.Nombre = "SUCURSALES", .Sincronizar = New SinClaveUnicaSincronizar()})
        respuesta.Add(New Tabla() With {.Nombre = "AROMAS", .Sincronizar = New SinClaveUnicaSincronizar()})
        respuesta.Add(New Tabla() With {.Nombre = "SUELDOS", .Sincronizar = New SinClaveUnicaSincronizar()})
        respuesta.Add(New Tabla() With {.Nombre = "BANCOS", .Sincronizar = New SinClaveUnicaSincronizar()})
        respuesta.Add(New Tabla() With {.Nombre = "TIPOS_COMISIONES", .Sincronizar = New SinClaveUnicaSincronizar()})
        respuesta.Add(New Tabla() With {.Nombre = "TIPOS_EGRESOS", .Sincronizar = New SinClaveUnicaSincronizar()})
        respuesta.Add(New Tabla() With {.Nombre = "TIPOS_PAGO", .Sincronizar = New SinClaveUnicaSincronizar()})
        respuesta.Add(New Tabla() With {.Nombre = "CLIENTEMAYORISTA", .Sincronizar = New SinClaveUnicaSincronizar()})
        respuesta.Add(New Tabla() With {.Nombre = "TIPOS_VENTAS", .Sincronizar = New SinClaveUnicaSincronizar()})
        respuesta.Add(New Tabla() With {.Nombre = "COLORES", .Sincronizar = New SinClaveUnicaSincronizar()})
        respuesta.Add(New Tabla() With {.Nombre = "USUARIOS", .Sincronizar = New SinClaveUnicaSincronizar()})
        respuesta.Add(New Tabla() With {.Nombre = "USUARIOS_MENSAJES", .Sincronizar = New SinClaveUnicaSincronizar()})
        respuesta.Add(New Tabla() With {.Nombre = "CONDICIONES_IVA", .Sincronizar = New SinClaveUnicaSincronizar()})
        respuesta.Add(New Tabla() With {.Nombre = "CONSUMIDORFINAL", .Sincronizar = New SinClaveUnicaSincronizar()})
        respuesta.Add(New Tabla() With {.Nombre = "DEPARTAMENTOS", .Sincronizar = New SinClaveUnicaSincronizar()})
        respuesta.Add(New Tabla() With {.Nombre = "DEPARTAMENTOS", .Sincronizar = New SinClaveUnicaSincronizar()})
        respuesta.Add(New Tabla() With {.Nombre = "EMPLEADOS", .Sincronizar = New SinClaveUnicaSincronizar()})
        respuesta.Add(New Tabla() With {.Nombre = "DIRECCION", .Sincronizar = New SinClaveUnicaSincronizar()})
        respuesta.Add(New Tabla() With {.Nombre = "FERIADOS", .Sincronizar = New SinClaveUnicaSincronizar()})
        respuesta.Add(New Tabla() With {.Nombre = "LISTA_GRUPO", .Sincronizar = New SinClaveUnicaSincronizar()})
        respuesta.Add(New Tabla() With {.Nombre = "LISTA_PRECIO", .Sincronizar = New SinClaveUnicaSincronizar()})
        respuesta.Add(New Tabla() With {.Nombre = "LOCALIDADES", .Sincronizar = New SinClaveUnicaSincronizar()})
        respuesta.Add(New Tabla() With {.Nombre = "MATERIALES", .Sincronizar = New SinClaveUnicaSincronizar()})
        respuesta.Add(New Tabla() With {.Nombre = "MOVIMIENTOS", .Sincronizar = New SinClaveUnicaSincronizar()})
        respuesta.Add(New Tabla() With {.Nombre = "MOVIMIENTOS_EGRESOS", .Sincronizar = New SinClaveUnicaSincronizar()})
        respuesta.Add(New Tabla() With {.Nombre = "MOVIMIENTOS_MERCADERIAS", .Sincronizar = New SinClaveUnicaSincronizar()})
        respuesta.Add(New Tabla() With {.Nombre = "MOVIMIENTOS_SECCIONES", .Sincronizar = New SinClaveUnicaSincronizar()})
        respuesta.Add(New Tabla() With {.Nombre = "MOVIMIENTOS_SUBTIPOS", .Sincronizar = New SinClaveUnicaSincronizar()})
        respuesta.Add(New Tabla() With {.Nombre = "MOVIMIENTOS_TIPOEGRESO_TIPOGASTO", .Sincronizar = New SinClaveUnicaSincronizar()})
        respuesta.Add(New Tabla() With {.Nombre = "MOVIMIENTOS_TIPOS", .Sincronizar = New SinClaveUnicaSincronizar()})
        respuesta.Add(New Tabla() With {.Nombre = "PATENTES", .Sincronizar = New SinClaveUnicaSincronizar()})
        respuesta.Add(New Tabla() With {.Nombre = "PATENTES_GRUPO", .Sincronizar = New SinClaveUnicaSincronizar()})
        respuesta.Add(New Tabla() With {.Nombre = "PERFILES", .Sincronizar = New SinClaveUnicaSincronizar()})
        respuesta.Add(New Tabla() With {.Nombre = "PRECIOS", .Sincronizar = New SinClaveUnicaSincronizar()})
        respuesta.Add(New Tabla() With {.Nombre = "PRODUCTOS", .Sincronizar = New SinClaveUnicaSincronizar()})
        respuesta.Add(New Tabla() With {.Nombre = "PRODUCTOS_CATEGORIAS", .Sincronizar = New SinClaveUnicaSincronizar()})
        respuesta.Add(New Tabla() With {.Nombre = "PRODUCTOS_SUBCATEGORIAS", .Sincronizar = New SinClaveUnicaSincronizar()})
        respuesta.Add(New Tabla() With {.Nombre = "PROVEEDORES", .Sincronizar = New SinClaveUnicaSincronizar()})
        respuesta.Add(New Tabla() With {.Nombre = "PROVINCIAS", .Sincronizar = New SinClaveUnicaSincronizar()})
        respuesta.Add(New Tabla() With {.Nombre = "REL_EMPLEADOS_SUCURSALES", .Sincronizar = New SinClaveUnicaSincronizar()})
        respuesta.Add(New Tabla() With {.Nombre = "REL_PERFILES_PATENTES", .Sincronizar = New SinClaveUnicaSincronizar()})
        respuesta.Add(New Tabla() With {.Nombre = "REL_PRODUCTOS_AROMAS", .Sincronizar = New SinClaveUnicaSincronizar()})
        respuesta.Add(New Tabla() With {.Nombre = "REL_PRODUCTOS_COLORES", .Sincronizar = New SinClaveUnicaSincronizar()})
        respuesta.Add(New Tabla() With {.Nombre = "REL_PRODUCTOS_MATERIALES", .Sincronizar = New SinClaveUnicaSincronizar()})
        respuesta.Add(New Tabla() With {.Nombre = "SINCORNIZACION", .Sincronizar = New SinClaveUnicaSincronizar()})
        respuesta.Add(New Tabla() With {.Nombre = "CLIENTEMINORISTA", .Sincronizar = New SinClaveUnicaSincronizar()})
        respuesta.Add(New Tabla() With {.Nombre = "TARJETAS", .Sincronizar = New SinClaveUnicaSincronizar()})
        respuesta.Add(New Tabla() With {.Nombre = "COSTOFINANCIERO", .Sincronizar = New SinClaveUnicaSincronizar()})
        respuesta.Add(New Tabla() With {.Nombre = "NUEVA_IVA", .Sincronizar = New SinClaveUnicaSincronizar()})
        respuesta.Add(New Tabla() With {.Nombre = "NUEVA_CUENTABANCARIA", .Sincronizar = New SinClaveUnicaSincronizar()})
        respuesta.Add(New Tabla() With {.Nombre = "NUEVA_TRANSPORTE", .Sincronizar = New SinClaveUnicaSincronizar()})

        Return respuesta
    End Function

    Public Function GetInformacionTablasLocales() As List(Of Tabla)
        Dim respuesta As List(Of Tabla) = New List(Of Tabla)

        respuesta.Add(EmpleadosRegistros())
        respuesta.Add(EmpleadosRegistrosPresentes())
        respuesta.Add(EmpleadosRegistrosAusentes())
        respuesta.Add(EmpleadosRegistrosTarde())
        respuesta.Add(CierreCaja()) 'nuevo
        respuesta.Add(ClienteMayoristaDocumentoPago()) 'nuevo
        respuesta.Add(ClienteMayoristaDocumentoPagoPago()) 'nuevo
        respuesta.Add(ClienteMayoristaMovimiento()) 'nuevo
        respuesta.Add(MovimientosCajas())
        respuesta.Add(MovimientosCajaFuerte())
        respuesta.Add(Adicionales())
        respuesta.Add(EmpleadoRecibo())
        respuesta.Add(MovimientoAporte())
        respuesta.Add(EmpleadoDeposito())
        respuesta.Add(Deuda())
        respuesta.Add(Adelanto())
        respuesta.Add(Stock())
        respuesta.Add(StockBitacora())
        respuesta.Add(MovimientoGastos())
        respuesta.Add(CuentaCorriente())
        respuesta.Add(Mercaderia())
        respuesta.Add(MercaderiaDetalle())
        respuesta.Add(Ventas()) 'nuevo
        respuesta.Add(VentasItems()) 'nuevo
        respuesta.Add(VentasPagos()) 'nuevo
        respuesta.Add(OrdenCompra())
        respuesta.Add(OrdenCompraDetalle())
        respuesta.Add(Comisiones()) 'nuevo
        respuesta.Add(Senia())
        respuesta.Add(Presupuesto())
        respuesta.Add(PresupuestoDetalle())
        respuesta.Add(Reserva()) 'nuevo
        respuesta.Add(Notapedido()) 'nuevo
        respuesta.Add(NotapedidoItems()) 'nuevo
        respuesta.Add(Factura()) 'nuevo
        respuesta.Add(NumeroFactura()) 'nuevo
        respuesta.Add(Notacredito()) 'nuevo
        respuesta.Add(NumeroNotacredito()) 'nuevo
        respuesta.Add(Devolucion())
        respuesta.Add(DevolucionDetalle())
        respuesta.Add(MovimientoImpuesto())
        respuesta.Add(Cheque()) 'nuevo
        respuesta.Add(MoviminetoRetiro())
        respuesta.Add(Remito())
        respuesta.Add(RemitoItems())

        Return respuesta
    End Function

    Private Shared Function EmpleadosRegistros() As Tabla
        Dim tabla As Tabla = New Tabla()
        tabla.ClavePrimaria = "id_Registro"
        tabla.ClaveSincronizacion = "Fecha_Edicion"
        tabla.Nombre = "EMPLEADOS_REGISTROS"
        tabla.SQLObtenerDatosLocal = "select * from EMPLEADOS_REGISTROS where Fecha_Edicion >= '{0}' AND id_Sucursal = {1}"
        tabla.SQLObtenerDatosRemoto = "select * from EMPLEADOS_REGISTROS where Fecha_Edicion >= '{0}' AND id_Sucursal = {1}"

        tabla.Sincronizar = New ClaveUnicaSincronizar()
        Return tabla
    End Function

    Private Shared Function EmpleadosRegistrosPresentes() As Tabla
        Dim tabla As Tabla = New Tabla()
        tabla.ClavePrimaria = "id_Auto"
        tabla.ClaveSincronizacion = "Fecha_Edicion"
        tabla.Nombre = "REL_REGISTRO_EMPLEADOS"
        tabla.SQLObtenerDatosLocal = "select R.* from EMPLEADOS_REGISTROS AS ER INNER JOIN REL_REGISTRO_EMPLEADOS AS R ON ER.id_Registro = R.id_Registro where R.Fecha_Edicion >= '{0}' AND ER.id_Sucursal = {1}"
        tabla.SQLObtenerDatosRemoto = "select R.* from EMPLEADOS_REGISTROS AS ER INNER JOIN REL_REGISTRO_EMPLEADOS AS R ON ER.id_Registro = R.id_Registro where R.Fecha_Edicion >= '{0}' AND ER.id_Sucursal = {1}"

        tabla.Sincronizar = New ClaveUnicaSincronizar()
        Return tabla
    End Function

    Private Shared Function EmpleadosRegistrosAusentes() As Tabla
        Dim tabla As Tabla = New Tabla()
        tabla.ClavePrimaria = "id_Auto"
        tabla.ClaveSincronizacion = "Fecha_Edicion"
        tabla.Nombre = "REL_REGISTRO_EMPLEADOS_AUSENTES"
        tabla.SQLObtenerDatosLocal = "select R.* from EMPLEADOS_REGISTROS AS ER INNER JOIN REL_REGISTRO_EMPLEADOS_AUSENTES AS R ON ER.id_Registro = R.id_Registro where R.Fecha_Edicion >= '{0}' AND ER.id_Sucursal = {1}"
        tabla.SQLObtenerDatosRemoto = "select R.* from EMPLEADOS_REGISTROS AS ER INNER JOIN REL_REGISTRO_EMPLEADOS_AUSENTES AS R ON ER.id_Registro = R.id_Registro where R.Fecha_Edicion >= '{0}' AND ER.id_Sucursal = {1}"

        tabla.Sincronizar = New ClaveUnicaSincronizar()
        Return tabla
    End Function

    Private Shared Function EmpleadosRegistrosTarde() As Tabla
        Dim tabla As Tabla = New Tabla()
        tabla.ClavePrimaria = "id_Auto"
        tabla.ClaveSincronizacion = "Fecha_Edicion"
        tabla.Nombre = "REL_REGISTRO_EMPLEADOS_TARDE"
        tabla.SQLObtenerDatosLocal = "select R.* from EMPLEADOS_REGISTROS AS ER INNER JOIN REL_REGISTRO_EMPLEADOS_TARDE AS R ON ER.id_Registro = R.id_Registro where R.Fecha_Edicion >= '{0}' AND ER.id_Sucursal = {1}"
        tabla.SQLObtenerDatosRemoto = "select R.* from EMPLEADOS_REGISTROS AS ER INNER JOIN REL_REGISTRO_EMPLEADOS_TARDE AS R ON ER.id_Registro = R.id_Registro where R.Fecha_Edicion >= '{0}' AND ER.id_Sucursal = {1}"

        tabla.Sincronizar = New ClaveUnicaSincronizar()
        Return tabla
    End Function

    Private Shared Function CierreCaja() As Tabla
        Dim tabla As Tabla = New Tabla()
        tabla.ClavePrimaria = "Id"
        tabla.ClaveSincronizacion = "FechaEdicion"
        tabla.Nombre = "NUEVA_CIERRE_CAJA"
        tabla.SQLObtenerDatosLocal = "select * from NUEVA_CIERRE_CAJA where FechaEdicion >= '{0}' AND IdSucursal = {1}"
        tabla.SQLObtenerDatosRemoto = "select * from NUEVA_CIERRE_CAJA where FechaEdicion >= '{0}' AND IdSucursal = {1}"

        tabla.Sincronizar = New ClaveUnicaSincronizar()
        Return tabla
    End Function

    Private Shared Function ClienteMayoristaDocumentoPago() As Tabla
        Dim tabla As Tabla = New Tabla()

        tabla.ClavePrimaria = "id"
        tabla.ClaveSincronizacion = "FechaEdicion"
        tabla.Nombre = "NUEVA_CLIENTE_MAYORISTA_DOCUMENTO_PAGO"
        tabla.SQLObtenerDatosLocal = "select * from NUEVA_CLIENTE_MAYORISTA_DOCUMENTO_PAGO where FechaEdicion >= '{0}' AND IdSucursal = {1}"
        tabla.SQLObtenerDatosRemoto = "select * from NUEVA_CLIENTE_MAYORISTA_DOCUMENTO_PAGO where FechaEdicion >= '{0}' AND IdSucursal = {1}"

        tabla.Sincronizar = New ClaveUnicaSincronizar()

        Return tabla
    End Function

    Private Shared Function ClienteMayoristaDocumentoPagoPago() As Tabla
        Dim tabla As Tabla = New Tabla()

        tabla.ClavePrimaria = "id"
        tabla.ClaveSincronizacion = "FechaEdicion"
        tabla.Nombre = "NUEVA_CLIENTE_MAYORISTA_DOCUMENTO_PAGO_PAGO"

        tabla.SQLObtenerDatosLocal = "select P.* 
                                        from NUEVA_CLIENTE_MAYORISTA_DOCUMENTO_PAGO_PAGO P 
                                        inner join NUEVA_CLIENTE_MAYORISTA_DOCUMENTO_PAGO D on P.IdDocumentoDePago = D.Id  
                                        where D.FechaEdicion >= '{0}' AND D.IdSucursal = {1}"

        tabla.SQLObtenerDatosRemoto = "select P.* 
                                        from NUEVA_CLIENTE_MAYORISTA_DOCUMENTO_PAGO_PAGO P 
                                        inner join NUEVA_CLIENTE_MAYORISTA_DOCUMENTO_PAGO D on P.IdDocumentoDePago = D.Id  
                                        where D.FechaEdicion >= '{0}' AND D.IdSucursal = {1}"

        tabla.Sincronizar = New ClaveUnicaSincronizar()

        Return tabla
    End Function

    Private Shared Function ClienteMayoristaMovimiento() As Tabla
        Dim tabla As Tabla = New Tabla()

        tabla.ClavePrimaria = "id"
        tabla.ClaveSincronizacion = "Fecha"
        tabla.Nombre = "NUEVA_CLIENTE_MAYORISTA_MOVIMIENTO"
        tabla.SQLObtenerDatosLocal = "select * from NUEVA_CLIENTE_MAYORISTA_MOVIMIENTO where Fecha >= '{0}' AND IdSucursal = {1}"
        tabla.SQLObtenerDatosRemoto = "select * from NUEVA_CLIENTE_MAYORISTA_MOVIMIENTO where Fecha >= '{0}' AND IdSucursal = {1}"

        tabla.Sincronizar = New ClaveUnicaSincronizar()

        Return tabla
    End Function

    Private Shared Function MovimientosCajas() As Tabla
        Dim tabla As Tabla = New Tabla()

        tabla.ClavePrimaria = "id_Movimiento"
        tabla.ClaveSincronizacion = "Fecha_Edicion"
        tabla.Nombre = "MOVIMIENTOS_CAJA"
        tabla.SQLObtenerDatosLocal = "select * from MOVIMIENTOS_CAJA where Fecha_Edicion >= '{0}' AND id_Sucursal = {1}"
        tabla.SQLObtenerDatosRemoto = "select * from MOVIMIENTOS_CAJA where Fecha_Edicion >= '{0}' AND id_Sucursal = {1}"

        tabla.Sincronizar = New ClaveUnicaSincronizar()

        Return tabla
    End Function

    Private Shared Function MovimientosCajaFuerte() As Tabla
        Dim tabla As Tabla = New Tabla()

        tabla.ClavePrimaria = "id_Movimiento"
        tabla.ClaveSincronizacion = "Fecha_Edicion"
        tabla.Nombre = "MOVIMIENTOS_CAJA_FUERTE"
        tabla.SQLObtenerDatosLocal = "select * from MOVIMIENTOS_CAJA_FUERTE where Fecha_Edicion >= '{0}' AND id_Sucursal = {1}"
        tabla.SQLObtenerDatosRemoto = "select * from MOVIMIENTOS_CAJA_FUERTE where Fecha_Edicion >= '{0}' AND id_Sucursal = {1}"

        tabla.Sincronizar = New ClaveUnicaSincronizar()

        Return tabla
    End Function

    Private Shared Function Adicionales() As Tabla
        Dim tabla As Tabla = New Tabla()

        tabla.ClavePrimaria = "id_Adicional"
        tabla.ClaveSincronizacion = "Fecha_Edicion"
        tabla.Nombre = "ADICIONALES"
        tabla.SQLObtenerDatosLocal = "select * from ADICIONALES where Fecha_Edicion >= '{0}' AND id_Sucursal = {1}"
        tabla.SQLObtenerDatosRemoto = "select * from ADICIONALES where Fecha_Edicion >= '{0}' AND id_Sucursal = {1}"

        tabla.Sincronizar = New ClaveUnicaSincronizar()

        Return tabla
    End Function

    Private Shared Function EmpleadoRecibo() As Tabla
        Dim tabla As Tabla = New Tabla()

        tabla.ClavePrimaria = "id_Recibo"
        tabla.ClaveSincronizacion = "Fecha_Edicion"
        tabla.Nombre = "EMPLEADOS_RECIBOS"
        tabla.SQLObtenerDatosLocal = "select * from EMPLEADOS_RECIBOS where Fecha_Edicion >= '{0}' AND id_Sucursal = {1}"
        tabla.SQLObtenerDatosRemoto = "select * from EMPLEADOS_RECIBOS where Fecha_Edicion >= '{0}' AND id_Sucursal = {1}"

        tabla.Sincronizar = New ClaveUnicaSincronizar()

        Return tabla
    End Function

    Private Shared Function MovimientoAporte() As Tabla
        Dim tabla As Tabla = New Tabla()

        tabla.ClavePrimaria = "id_Movimiento"
        tabla.ClaveSincronizacion = "Fecha_Edicion"
        tabla.Nombre = "MOVIMIENTOS_APORTE"
        tabla.SQLObtenerDatosLocal = "select * from MOVIMIENTOS_APORTE where Fecha_Edicion >= '{0}' AND id_Sucursal = {1}"
        tabla.SQLObtenerDatosRemoto = "select * from MOVIMIENTOS_APORTE where Fecha_Edicion >= '{0}' AND id_Sucursal = {1}"

        tabla.Sincronizar = New ClaveUnicaSincronizar()

        Return tabla
    End Function

    Private Shared Function EmpleadoDeposito() As Tabla
        Dim tabla As Tabla = New Tabla()

        tabla.ClavePrimaria = "id_Deposito"
        tabla.ClaveSincronizacion = "Fecha_Edicion"
        tabla.Nombre = "EMPLEADOS_DEPOSITOS"
        tabla.SQLObtenerDatosLocal = "select * from EMPLEADOS_DEPOSITOS where Fecha_Edicion >= '{0}' AND id_Sucursal = {1}"
        tabla.SQLObtenerDatosRemoto = "select * from EMPLEADOS_DEPOSITOS where Fecha_Edicion >= '{0}' AND id_Sucursal = {1}"

        tabla.Sincronizar = New ClaveUnicaSincronizar()

        Return tabla
    End Function

    Private Shared Function Deuda() As Tabla
        Dim tabla As Tabla = New Tabla()

        tabla.ClavePrimaria = "id_Deuda"
        tabla.ClaveSincronizacion = "Fecha_Edicion"
        tabla.Nombre = "DEUDA"
        tabla.SQLObtenerDatosLocal = "select * from DEUDA where Fecha_Edicion >= '{0}' AND id_Sucursal = {1}"
        tabla.SQLObtenerDatosRemoto = "select * from DEUDA where Fecha_Edicion >= '{0}' AND id_Sucursal = {1}"

        tabla.Sincronizar = New ClaveUnicaSincronizar()
        Return tabla

    End Function

    Private Shared Function Adelanto() As Tabla
        Dim tabla As Tabla = New Tabla()

        tabla.ClavePrimaria = "id_Adelanto"
        tabla.ClaveSincronizacion = "Fecha_Edicion"
        tabla.Nombre = "ADELANTOS"
        tabla.SQLObtenerDatosLocal = "select * from ADELANTOS where Fecha_Edicion >= '{0}' AND id_Sucursal = {1}"
        tabla.SQLObtenerDatosRemoto = "select * from ADELANTOS where Fecha_Edicion >= '{0}' AND id_Sucursal = {1}"

        tabla.Sincronizar = New ClaveUnicaSincronizar()
        Return tabla
    End Function

    Private Shared Function Stock() As Tabla
        Dim tabla As Tabla = New Tabla()

        tabla.ClavePrimaria = "id_Stock"
        tabla.ClaveSincronizacion = "Fecha_Edicion"
        tabla.Nombre = "STOCK"
        tabla.SQLObtenerDatosLocal = "select * from STOCK where Fecha_Edicion >= '{0}' AND id_Sucursal = {1}"
        tabla.SQLObtenerDatosRemoto = "select * from STOCK where Fecha_Edicion >= '{0}' AND id_Sucursal = {1}"

        tabla.Sincronizar = New ClaveUnicaSincronizar()
        Return tabla
    End Function

    Private Shared Function StockBitacora() As Tabla
        Dim tabla As Tabla = New Tabla()

        tabla.ClavePrimaria = "id_Bitacora"
        tabla.ClaveSincronizacion = "Fecha_Edicion"
        tabla.Nombre = "STOCK_BITACORA"
        tabla.SQLObtenerDatosLocal = "select * from STOCK_BITACORA where Fecha_Edicion >= '{0}' AND id_Sucursal = {1}"
        tabla.SQLObtenerDatosRemoto = "select * from STOCK_BITACORA where Fecha_Edicion >= '{0}' AND id_Sucursal = {1}"

        tabla.Sincronizar = New ClaveUnicaSincronizar()
        Return tabla
    End Function

    Private Shared Function MovimientoGastos() As Tabla
        Dim tabla As Tabla = New Tabla()

        tabla.ClavePrimaria = "id_Movimiento"
        tabla.ClaveSincronizacion = "Fecha_Edicion"
        tabla.Nombre = "MOVIMIENTOS_GASTOS"
        tabla.SQLObtenerDatosLocal = "select * from MOVIMIENTOS_GASTOS where Fecha_Edicion >= '{0}' AND id_Sucursal = {1}"
        tabla.SQLObtenerDatosRemoto = "select * from MOVIMIENTOS_GASTOS where Fecha_Edicion >= '{0}' AND id_Sucursal = {1}"

        tabla.Sincronizar = New ClaveUnicaSincronizar()
        Return tabla
    End Function

    Private Shared Function CuentaCorriente() As Tabla
        Dim tabla As Tabla = New Tabla()

        tabla.ClavePrimaria = "id_Registro"
        tabla.ClaveSincronizacion = "Fecha_Edicion"
        tabla.Nombre = "CUENTA_CORRIENTE"
        tabla.SQLObtenerDatosLocal = "select * from CUENTA_CORRIENTE where Fecha_Edicion >= '{0}' AND id_Sucursal = {1}"
        tabla.SQLObtenerDatosRemoto = "select * from CUENTA_CORRIENTE where Fecha_Edicion >= '{0}' AND id_Sucursal = {1}"

        tabla.Sincronizar = New ClaveUnicaSincronizar()
        Return tabla
    End Function

    Private Shared Function Mercaderia() As Tabla
        Dim tabla As Tabla = New Tabla()

        tabla.ClavePrimaria = "id_Mercaderia"
        tabla.ClaveSincronizacion = "Fecha_Edicion"
        tabla.Nombre = "MERCADERIAS"
        tabla.SQLObtenerDatosLocal = "select * from MERCADERIAS where Fecha_Edicion >= '{0}' AND id_Sucursal = {1}"
        tabla.SQLObtenerDatosRemoto = "select * from MERCADERIAS where Fecha_Edicion >= '{0}' AND id_Sucursal = {1}"

        tabla.Sincronizar = New ClaveUnicaSincronizar()
        Return tabla
    End Function

    Private Shared Function MercaderiaDetalle() As Tabla
        Dim tabla As Tabla = New Tabla()

        tabla.ClavePrimaria = "id_Detalle"
        tabla.ClaveSincronizacion = "Fecha_Edicion"
        tabla.Nombre = "MERCADERIAS_DETALLE"
        tabla.SQLObtenerDatosLocal = "Select D.* 
                                        From MERCADERIAS M 
                                        INNER Join MERCADERIAS_DETALLE D ON D.id_Mercaderia = M.id_Mercaderia
                                        where D.Fecha_Edicion >= '{0}' and M.id_Sucursal = {1}"
        tabla.SQLObtenerDatosRemoto = "Select D.* 
                                        From MERCADERIAS M 
                                        INNER Join MERCADERIAS_DETALLE D ON D.id_Mercaderia = M.id_Mercaderia
                                        where D.Fecha_Edicion >= '{0}' and M.id_Sucursal = {1}"

        tabla.Sincronizar = New ClaveUnicaSincronizar()
        Return tabla
    End Function

    Private Shared Function Ventas() As Tabla
        Dim tabla As Tabla = New Tabla()

        tabla.ClavePrimaria = "Id"
        tabla.ClaveSincronizacion = "FechaEdicion"
        tabla.Nombre = "NUEVA_VENTAS"
        tabla.SQLObtenerDatosLocal = "select * from NUEVA_VENTAS where FechaEdicion >= '{0}' AND IdSucursal = {1}"
        tabla.SQLObtenerDatosRemoto = "select * from NUEVA_VENTAS where FechaEdicion >= '{0}' AND IdSucursal = {1}"

        tabla.Sincronizar = New ClaveUnicaSincronizar()
        Return tabla
    End Function

    Private Shared Function VentasItems() As Tabla
        Dim tabla As Tabla = New Tabla()

        tabla.ClavePrimaria = "Id"
        tabla.ClaveSincronizacion = "FechaEdicion"
        tabla.Nombre = "NUEVA_VENTA_ITEMS"
        tabla.SQLObtenerDatosLocal = "Select D.* 
                                        From NUEVA_VENTAS V
                                        INNER Join NUEVA_VENTA_ITEMS D ON V.Id = D.IdVenta
                                        where D.FechaEdicion >= '{0}' and V.IdSucursal = {1}"
        tabla.SQLObtenerDatosRemoto = "Select D.* 
                                        From NUEVA_VENTAS V
                                        INNER Join NUEVA_VENTA_ITEMS D ON V.Id = D.IdVenta
                                        where D.FechaEdicion >= '{0}' and V.IdSucursal = {1}"

        tabla.Sincronizar = New ClaveUnicaSincronizar()
        Return tabla
    End Function

    Private Shared Function Remito() As Tabla
        Dim tabla As Tabla = New Tabla()

        tabla.ClavePrimaria = "Id"
        tabla.ClaveSincronizacion = "FechaEdicion"
        tabla.Nombre = "NUEVA_REMITOS"
        tabla.SQLObtenerDatosLocal = "select R.* from NUEVA_REMITOS R INNER Join NUEVA_VENTAS V ON R.IdVenta = V.Id where R.FechaEdicion >= '{0}' AND V.IdSucursal = {1}"
        tabla.SQLObtenerDatosRemoto = "select R.* from NUEVA_REMITOS R INNER Join NUEVA_VENTAS V ON R.IdVenta = V.Id where R.FechaEdicion >= '{0}' AND V.IdSucursal = {1}"

        tabla.Sincronizar = New ClaveUnicaSincronizar()
        Return tabla
    End Function

    Private Shared Function RemitoItems() As Tabla
        Dim tabla As Tabla = New Tabla()

        tabla.ClavePrimaria = "Id"
        tabla.ClaveSincronizacion = "FechaEdicion"
        tabla.Nombre = "NUEVA_REMITO_ITEMS"
        tabla.SQLObtenerDatosLocal = "Select RI.* 
		                            from NUEVA_REMITO_ITEMS RI
                                    INNER Join NUEVA_REMITOS R ON RI.IdRemito = R.Id
                                    INNER Join NUEVA_VENTAS V ON V.Id = R.IdVenta
                                    where RI.FechaEdicion >= '{0}' and V.IdSucursal = {1}"
        tabla.SQLObtenerDatosRemoto = "Select RI.* 
		                            from NUEVA_REMITO_ITEMS RI
                                    INNER Join NUEVA_REMITOS R ON RI.IdRemito = R.Id
                                    INNER Join NUEVA_VENTAS V ON V.Id = R.IdVenta
                                    where RI.FechaEdicion >= '{0}' and V.IdSucursal = {1}"

        tabla.Sincronizar = New ClaveUnicaSincronizar()
        Return tabla
    End Function

    Private Shared Function VentasPagos() As Tabla
        Dim tabla As Tabla = New Tabla()

        tabla.ClavePrimaria = "Id"
        tabla.ClaveSincronizacion = "FechaEdicion"
        tabla.Nombre = "NUEVA_VENTA_PAGOS"
        tabla.SQLObtenerDatosLocal = "Select P.* 
                                        From NUEVA_VENTAS V
                                        INNER Join NUEVA_VENTA_PAGOS P ON V.Id = P.IdVenta
                                        where P.FechaEdicion >= '{0}' and V.idSucursal = {1}"
        tabla.SQLObtenerDatosRemoto = "Select P.* 
                                        From NUEVA_VENTAS V
                                        INNER Join NUEVA_VENTA_PAGOS P ON V.Id = P.IdVenta
                                        where P.FechaEdicion >= '{0}' and V.idSucursal = {1}"

        tabla.Sincronizar = New ClaveUnicaSincronizar()
        Return tabla
    End Function

    Private Shared Function OrdenCompra() As Tabla
        Dim tabla As Tabla = New Tabla()

        tabla.ClavePrimaria = "idOrdenCompra"
        tabla.ClaveSincronizacion = "FechaEdicion"
        tabla.Nombre = "ORDEN_COMPRA"
        tabla.SQLObtenerDatosLocal = "select * from ORDEN_COMPRA where FechaEdicion >= '{0}' AND idSucursal = {1}"
        tabla.SQLObtenerDatosRemoto = "select * from ORDEN_COMPRA where FechaEdicion >= '{0}' AND idSucursal = {1}"

        tabla.Sincronizar = New ClaveUnicaSincronizar()
        Return tabla
    End Function

    Private Shared Function OrdenCompraDetalle() As Tabla
        Dim tabla As Tabla = New Tabla()

        tabla.ClavePrimaria = "idOrdenCompraDetalle"
        tabla.ClaveSincronizacion = "FechaEdicion"
        tabla.Nombre = "ORDEN_COMPRA_DETALLE"
        tabla.SQLObtenerDatosLocal = "Select OCD.* 
                                        From ORDEN_COMPRA  OC
                                        INNER Join ORDEN_COMPRA_DETALLE OCD ON OC.idOrdenCompra = OCD.idOrdenCompra
                                        where OCD.FechaEdicion >= '{0}' and OC.idSucursal = {1}"
        tabla.SQLObtenerDatosRemoto = "Select OCD.* 
                                        From ORDEN_COMPRA  OC
                                        INNER Join ORDEN_COMPRA_DETALLE OCD ON OC.idOrdenCompra = OCD.idOrdenCompra
                                        where OCD.FechaEdicion >= '{0}' and OC.idSucursal = {1}"

        tabla.Sincronizar = New ClaveUnicaSincronizar()
        Return tabla
    End Function

    Private Shared Function Comisiones() As Tabla
        Dim tabla As Tabla = New Tabla()

        tabla.ClavePrimaria = "Id"
        tabla.ClaveSincronizacion = "FechaEdicion"
        tabla.Nombre = "NUEVA_COMISION"
        tabla.SQLObtenerDatosLocal = "select * from NUEVA_COMISION where FechaEdicion >= '{0}' AND IdSucursal = {1}"
        tabla.SQLObtenerDatosRemoto = "select * from NUEVA_COMISION where FechaEdicion >= '{0}' AND IdSucursal = {1}"

        tabla.Sincronizar = New ClaveUnicaSincronizar()
        Return tabla
    End Function

    Private Shared Function Senia() As Tabla
        Dim tabla As Tabla = New Tabla()

        tabla.ClavePrimaria = "id_Senia"
        tabla.ClaveSincronizacion = "Fecha_Edicion"
        tabla.Nombre = "SENIA"
        tabla.SQLObtenerDatosLocal = "select * from SENIA where Fecha_Edicion >= '{0}' AND id_Sucursal = {1}"
        tabla.SQLObtenerDatosRemoto = "select * from SENIA where Fecha_Edicion >= '{0}' AND id_Sucursal = {1}"

        tabla.Sincronizar = New ClaveUnicaSincronizar()
        Return tabla
    End Function

    Private Shared Function Presupuesto() As Tabla
        Dim tabla As Tabla = New Tabla()

        tabla.ClavePrimaria = "id_Presupuesto"
        tabla.ClaveSincronizacion = "Fecha_Edicion"
        tabla.Nombre = "PRESUPUESTO"
        tabla.SQLObtenerDatosLocal = "select * from PRESUPUESTO where Fecha_Edicion >= '{0}' AND id_Sucursal = {1}"
        tabla.SQLObtenerDatosRemoto = "select * from PRESUPUESTO where Fecha_Edicion >= '{0}' AND id_Sucursal = {1}"

        tabla.Sincronizar = New ClaveUnicaSincronizar()
        Return tabla
    End Function

    Private Shared Function PresupuestoDetalle() As Tabla
        Dim tabla As Tabla = New Tabla()

        tabla.ClavePrimaria = "id_Detalle"
        tabla.ClaveSincronizacion = "Fecha_Edicion"
        tabla.Nombre = "PRESUPUESTO_DETALLE"
        tabla.SQLObtenerDatosLocal = "Select D.* 
                                        From PRESUPUESTO P
                                        INNER Join PRESUPUESTO_DETALLE D ON P.id_Presupuesto = D.id_Presupuesto
                                        where D.Fecha_Edicion >= '{0}' and P.id_Sucursal = {1}"
        tabla.SQLObtenerDatosRemoto = "Select D.* 
                                        From PRESUPUESTO P
                                        INNER Join PRESUPUESTO_DETALLE D ON P.id_Presupuesto = D.id_Presupuesto
                                        where D.Fecha_Edicion >= '{0}' and P.id_Sucursal = {1}"

        tabla.Sincronizar = New ClaveUnicaSincronizar()
        Return tabla
    End Function

    Private Shared Function Reserva() As Tabla
        Dim tabla As Tabla = New Tabla()
        tabla.ClavePrimaria = "Id"
        tabla.ClaveSincronizacion = "FechaEdicion"
        tabla.Nombre = "NUEVA_RESERVA"
        tabla.SQLObtenerDatosLocal = "Select * from NUEVA_RESERVA where FechaEdicion >= '{0}' AND IdSucursal = {1}"
        tabla.SQLObtenerDatosRemoto = "select * from NUEVA_RESERVA where FechaEdicion >= '{0}' AND IdSucursal = {1}"

        tabla.Sincronizar = New ClaveUnicaSincronizar()
        Return tabla
    End Function

    Private Shared Function Notapedido() As Tabla
        Dim tabla As Tabla = New Tabla()
        tabla.ClavePrimaria = "Id"
        tabla.ClaveSincronizacion = "FechaEdicion"
        tabla.Nombre = "NUEVA_NOTA_PEDIDO"
        tabla.SQLObtenerDatosLocal = "Select * from NUEVA_NOTA_PEDIDO where FechaEdicion >= '{0}' AND IdSucursal = {1}"
        tabla.SQLObtenerDatosRemoto = "select * from NUEVA_NOTA_PEDIDO where FechaEdicion >= '{0}' AND IdSucursal = {1}"

        tabla.Sincronizar = New ClaveUnicaSincronizar()
        Return tabla
    End Function

    Private Shared Function NotapedidoItems() As Tabla
        Dim tabla As Tabla = New Tabla()
        tabla.ClavePrimaria = "Id"
        tabla.ClaveSincronizacion = "FechaEdicion"
        tabla.Nombre = "NUEVA_NOTA_PEDIDO_ITEMS"
        tabla.SQLObtenerDatosLocal = "Select D.* 
                                        From NUEVA_NOTA_PEDIDO T 
                                        INNER Join NUEVA_NOTA_PEDIDO_ITEMS D ON D.IdNotaPedido = T.Id
                                        where D.FechaEdicion >= '{0}' and T.IdSucursal = {1}"
        tabla.SQLObtenerDatosRemoto = "Select D.* 
                                        From NUEVA_NOTA_PEDIDO T 
                                        INNER Join NUEVA_NOTA_PEDIDO_ITEMS D ON D.IdNotaPedido = T.Id
                                        where D.FechaEdicion >= '{0}' and T.IdSucursal = {1}"
        tabla.Sincronizar = New ClaveUnicaSincronizar()
        Return tabla
    End Function

    Private Shared Function Factura() As Tabla
        Dim tabla As Tabla = New Tabla()
        tabla.ClavePrimaria = "Id"
        tabla.ClaveSincronizacion = "Fecha"
        tabla.Nombre = "NUEVA_FACTURA"
        tabla.SQLObtenerDatosLocal = "Select F.* 
                                        From NUEVA_VENTAS V
                                        INNER Join NUEVA_FACTURA F ON V.Id = F.IdVenta
                                        where F.Fecha >= '{0}' and V.idSucursal = {1}"
        tabla.SQLObtenerDatosRemoto = "Select F.* 
                                        From NUEVA_VENTAS V
                                        INNER Join NUEVA_FACTURA F ON V.Id = F.IdVenta
                                        where F.Fecha >= '{0}' and V.idSucursal = {1}"

        tabla.Sincronizar = New ClaveUnicaSincronizar()
        Return tabla
    End Function

    Private Shared Function NumeroFactura() As Tabla
        Dim tabla As Tabla = New Tabla()
        tabla.ClavePrimaria = "Id"
        tabla.ClaveSincronizacion = "Numero"
        tabla.Nombre = "NUEVA_NUMERO_FACTURA"
        tabla.SQLObtenerDatosLocal = "Select N.* 
                                        From NUEVA_VENTAS V
                                        INNER Join NUEVA_FACTURA F ON V.Id = F.IdVenta
                                        INNER Join NUEVA_NUMERO_FACTURA N ON F.Id = N.IdFactura
                                        where F.Fecha >= '{0}' and V.idSucursal = {1}"
        tabla.SQLObtenerDatosRemoto = "Select N.* 
                                        From NUEVA_VENTAS V
                                        INNER Join NUEVA_FACTURA F ON V.Id = F.IdVenta
                                        INNER Join NUEVA_NUMERO_FACTURA N ON F.Id = N.IdFactura
                                        where F.Fecha >= '{0}' and V.idSucursal = {1}"

        tabla.Sincronizar = New ClaveUnicaSincronizar()
        Return tabla
    End Function

    Private Shared Function Notacredito() As Tabla
        Dim tabla As Tabla = New Tabla()
        tabla.ClavePrimaria = "Id"
        tabla.ClaveSincronizacion = "Fecha"
        tabla.Nombre = "NUEVA_NOTA_CREDITO"
        tabla.SQLObtenerDatosLocal = "Select C.* 
                                        From NUEVA_VENTAS V
                                        INNER Join NUEVA_NOTA_CREDITO C ON V.Id = C.IdVenta
                                        where C.Fecha >= '{0}' and V.idSucursal = {1}"
        tabla.SQLObtenerDatosRemoto = "Select C.* 
                                        From NUEVA_VENTAS V
                                        INNER Join NUEVA_NOTA_CREDITO C ON V.Id = C.IdVenta
                                        where C.Fecha >= '{0}' and V.idSucursal = {1}"

        tabla.Sincronizar = New ClaveUnicaSincronizar()
        Return tabla
    End Function

    Private Shared Function NumeroNotacredito() As Tabla
        Dim tabla As Tabla = New Tabla()
        tabla.ClavePrimaria = "Id"
        tabla.ClaveSincronizacion = "Numero"
        tabla.Nombre = "NUEVA_NUMERO_NOTA_CREDITO"
        tabla.SQLObtenerDatosLocal = "Select N.* 
                                        From NUEVA_VENTAS V
                                        INNER Join NUEVA_NOTA_CREDITO C ON V.Id = C.IdVenta
                                        INNER Join NUEVA_NUMERO_NOTA_CREDITO N ON C.Id = N.IdNotaCredito
                                        where C.Fecha >= '{0}' and V.idSucursal = {1}"
        tabla.SQLObtenerDatosRemoto = "Select N.* 
                                        From NUEVA_VENTAS V
                                        INNER Join NUEVA_NOTA_CREDITO C ON V.Id = C.IdVenta
                                        INNER Join NUEVA_NUMERO_NOTA_CREDITO N ON C.Id = N.IdNotaCredito
                                        where C.Fecha >= '{0}' and V.idSucursal = {1}"

        tabla.Sincronizar = New ClaveUnicaSincronizar()
        Return tabla
    End Function

    Private Shared Function Devolucion() As Tabla

        Dim tabla As Tabla = New Tabla()
        tabla.ClavePrimaria = "id_Devolucion"
        tabla.ClaveSincronizacion = "Fecha_Edicion"
        tabla.Nombre = "DEVOLUCIONES"
        tabla.SQLObtenerDatosLocal = "Select * from DEVOLUCIONES where Fecha_Edicion >= '{0}' AND id_Sucursal = {1}"
        tabla.SQLObtenerDatosRemoto = "select * from DEVOLUCIONES where Fecha_Edicion >= '{0}' AND id_Sucursal = {1}"

        tabla.Sincronizar = New ClaveUnicaSincronizar()
        Return tabla
    End Function

    Private Shared Function DevolucionDetalle() As Tabla

        Dim tabla As Tabla = New Tabla()
        tabla.ClavePrimaria = "id_Detalle"
        tabla.ClaveSincronizacion = "Fecha_Edicion"
        tabla.Nombre = "DEVOLUCIONES_DETALLE"
        tabla.SQLObtenerDatosLocal = "Select DE.* 
                                        From DEVOLUCIONES D 
                                        INNER Join DEVOLUCIONES_DETALLE DE ON DE.id_Devolucion = D.id_Devolucion
                                        where DE.Fecha_Edicion >= '{0}' and D.id_Sucursal = {1}"

        tabla.SQLObtenerDatosRemoto = "Select DE.* 
                                        From DEVOLUCIONES D 
                                        INNER Join DEVOLUCIONES_DETALLE DE ON DE.id_Devolucion = D.id_Devolucion
                                        where DE.Fecha_Edicion >= '{0}' and D.id_Sucursal = {1}"

        tabla.Sincronizar = New ClaveUnicaSincronizar()
        Return tabla
    End Function

    Private Shared Function MovimientoImpuesto() As Tabla
        Dim tabla As Tabla = New Tabla()
        tabla.ClavePrimaria = "id_Movimiento"
        tabla.ClaveSincronizacion = "Fecha_Edicion"
        tabla.Nombre = "MOVIMIENTOS_IMPUESTOS"
        tabla.SQLObtenerDatosLocal = "select * from MOVIMIENTOS_IMPUESTOS where Fecha_Edicion >= '{0}' AND id_Sucursal = {1}"
        tabla.SQLObtenerDatosRemoto = "select * from MOVIMIENTOS_IMPUESTOS where Fecha_Edicion >= '{0}' AND id_Sucursal = {1}"

        tabla.Sincronizar = New ClaveUnicaSincronizar()
        Return tabla
    End Function

    Private Shared Function Cheque() As Tabla
        Dim tabla As Tabla = New Tabla()
        tabla.ClavePrimaria = "Id"
        tabla.ClaveSincronizacion = "FechaEdicion"
        tabla.Nombre = "NUEVA_CHEQUE"
        tabla.SQLObtenerDatosLocal = "select * from NUEVA_CHEQUE where FechaEdicion >= '{0}' AND IdSucursal = {1}"
        tabla.SQLObtenerDatosRemoto = "select * from NUEVA_CHEQUE where FechaEdicion >= '{0}' AND IdSucursal = {1}"

        tabla.Sincronizar = New ClaveUnicaSincronizar()
        Return tabla
    End Function

    Private Shared Function MoviminetoRetiro() As Tabla

        Dim tabla As Tabla = New Tabla()

        tabla.ClavePrimaria = "id_Movimiento"
        tabla.ClaveSincronizacion = "Fecha_Edicion"
        tabla.Nombre = "MOVIMIENTOS_RETIROS"
        tabla.SQLObtenerDatosLocal = "select * from MOVIMIENTOS_RETIROS where Fecha_Edicion >= '{0}' AND id_Sucursal = {1}"
        tabla.SQLObtenerDatosRemoto = "select * from MOVIMIENTOS_RETIROS where Fecha_Edicion >= '{0}' AND id_Sucursal = {1}"

        tabla.Sincronizar = New ClaveUnicaSincronizar()

        Return tabla
    End Function

End Class