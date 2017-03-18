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
    Dim miconexionRemoto As SqlConnection
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
            miconexionRemoto = New SqlConnection
            miconexionRemoto.ConnectionString = encripta.DesencriptarMD5(CadenaConexion)
            miconexionRemoto.Open()
            estado = True
            miconexionRemoto.Dispose()
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
            miconexionRemoto = New SqlConnection
            miconexionRemoto.ConnectionString = encripta.DesencriptarMD5(CadenaConexion)
            miconexionRemoto.Open()

            'conexion local
            CadenaConexion = System.Configuration.ConfigurationManager.ConnectionStrings("SistemaCinderella.My.MySettings.Conexion").ToString
            miconexion = New SqlConnection
            miconexion.ConnectionString = CadenaConexion
            miconexion.Open()

            Dim transaccion As SqlTransaction
            transaccion = miconexion.BeginTransaction()

            ' obtengo los datos a copiar.
            Dim commandSourceData As SqlDataAdapter = New SqlDataAdapter("SELECT * FROM " + Tabla, miconexionRemoto)
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
            miconexionRemoto.Dispose()

        Finally
            miconexion.Dispose()
            miconexionRemoto.Dispose()
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

        If (ActualizarClaves(Tabla, valorBusqueda)) Then
            Return SincronizarARemota(Tabla, valorBusqueda)
        End If

        Return 2
    End Function


    Private Function ActualizarClaves(ByRef Tabla As Tabla, valorBusqueda As String) As Boolean
        Dim Respuesta As IList(Of DataTable) = New List(Of DataTable)
        Dim tablaLocal As DataTable
        Dim tablaRemota As DataTable

        If (Not String.IsNullOrEmpty(Tabla.ColumnaSeleccion)) Then

            'Selecciono todas las filas de la base local 
            tablaLocal = CType(clsDatos.ConsultarBaseLocal(String.Format("select * from {0} where {1} = {2}", Tabla.Nombre, Tabla.ColumnaSeleccion, valorBusqueda)), DataSet).Tables(0)

            'Selecciono todas las filas de la base remota
            tablaRemota = CType(clsDatos.ConsultarBaseRemoto(String.Format("select * from {0} where {1} = {2}", Tabla.Nombre, Tabla.ColumnaSeleccion, valorBusqueda)), DataSet).Tables(0)
        Else

            'Selecciono todas las filas de la base local 
            tablaLocal = CType(clsDatos.ConsultarBaseLocal(String.Format("select * from {0}", Tabla.Nombre)), DataSet).Tables(0)

            'Selecciono todas las filas de la base remota
            tablaRemota = CType(clsDatos.ConsultarBaseRemoto(String.Format("select * from {0}", Tabla.Nombre)), DataSet).Tables(0)

        End If
        Dim ClavePrimaria As String = Tabla.ClavePrimaria

        'Obtengo un listado de todos los ID de la base remota
        Dim ListaIdBaseRemota As List(Of Integer) = tablaRemota.Rows.Cast(Of DataRow).Select(Function(x) CType(x(ClavePrimaria), Integer)).ToList()
        Dim ListaIdBaseLocal As List(Of Integer) = tablaLocal.Rows.Cast(Of DataRow).Select(Function(x) CType(x(ClavePrimaria), Integer)).ToList()

        'Si la base de datos remota tiene mas datos que la base de datos local no tengo que actualizar mis valores locales. Esta situacion solo se da cuando el sistema tiene datos remoto y por algun motivo la base de datos local esta bacia 
        If (ListaIdBaseRemota.Count > ListaIdBaseLocal.Count Or ListaIdBaseLocal.Count = 0) Then
            Return False
        End If

        'Obtengo el ultimo ID de la base remota
        Dim ultimoValor As Integer = ObtenerUltimoIdBaseRemota(Tabla.Nombre)

        'Recorro todas las rows de la base local
        For Each rowLocal As DataRow In tablaLocal.Rows
            'Si el ID de la base local no exite en la base remota quiere decir que esta row fue generada en modo offline
            If Not ListaIdBaseRemota.Contains(rowLocal(Tabla.ClavePrimaria)) Then

                Tabla.IdAcualizados.Add(New KeyValuePair(Of Integer, Integer)(rowLocal(Tabla.ClavePrimaria), ultimoValor))

                'Por lo tanto tengo que actualizar su ID con el ultimo ID de la base remota
                rowLocal(Tabla.ClavePrimaria) = ultimoValor
                ultimoValor += 1
            End If
        Next

        Tabla.TablaActualizada = tablaLocal

        'Recorro todas las tablas relacionadas a la actualizada para actualizar sus IDs y claves foraneas
        For Each tablaForanea As Tabla In Tabla.TablaRelacionada
            ActualizarClavesForaneas(ListaIdBaseLocal, ListaIdBaseRemota, Tabla.IdAcualizados, tablaForanea)
        Next

        Return True

    End Function

    Private Sub ActualizarClavesForaneas(IdForaneosLocal As List(Of Integer), IdForaneosRemota As List(Of Integer), IdActualizados As IList(Of KeyValuePair(Of Integer, Integer)), ByRef TablaForanea As Tabla)

        'Selecciono todas las filas de la base local 
        Dim tablaForaneaLocal As DataTable
        If (IdForaneosLocal.Count = 0) Then
            tablaForaneaLocal = CType(clsDatos.ConsultarBaseLocal(String.Format("select * from {0}", TablaForanea.Nombre)), DataSet).Tables(0)
        Else
            tablaForaneaLocal = CType(clsDatos.ConsultarBaseLocal(String.Format("select * from {0} where {1} in ({2})", TablaForanea.Nombre, TablaForanea.ColumnaSeleccion, String.Join(",", IdForaneosLocal))), DataSet).Tables(0)
        End If

        'Selecciono todas las filas de la base remota
        Dim tablaForaneaRemota As DataTable
        If (IdForaneosRemota.Count = 0) Then
            tablaForaneaRemota = CType(clsDatos.ConsultarBaseRemoto(String.Format("select * from {0}", TablaForanea.Nombre)), DataSet).Tables(0)
        Else
            tablaForaneaRemota = CType(clsDatos.ConsultarBaseRemoto(String.Format("select * from {0} where {1} in ({2})", TablaForanea.Nombre, TablaForanea.ColumnaSeleccion, String.Join(",", IdForaneosRemota))), DataSet).Tables(0)
        End If

        Dim ClavePrimaria As String = TablaForanea.ClavePrimaria

        'Obtengo un listado de todos los ID de la base remota
        Dim tablaForaneaRemotaListaPrimariKey As List(Of Integer) = tablaForaneaRemota.Rows.Cast(Of DataRow).Select(Function(x) CType(x(ClavePrimaria), Integer)).ToList()

        'Obtengo el ultimo ID de la base remota
        Dim ultimoValor As Integer = ObtenerUltimoIdBaseRemota(TablaForanea.Nombre)

        'Recorro todas las rows de la base local
        For Each rowLocal As DataRow In tablaForaneaLocal.Rows
            'Si el ID de la base local no exite en la base remota quiere decir que esta row fue generada en modo offline
            If Not tablaForaneaRemotaListaPrimariKey.Contains(rowLocal(TablaForanea.ClavePrimaria)) Then
                TablaForanea.IdAcualizados.Add(New KeyValuePair(Of Integer, Integer)(rowLocal(TablaForanea.ClavePrimaria), ultimoValor))
                'Por lo tanto tengo que actualizar su ID con el ultimo ID de la base remota
                rowLocal(TablaForanea.ClavePrimaria) = ultimoValor
                ultimoValor += 1
            End If
        Next

        'Actualizo las claves foranesa de las rows
        For Each claveForanea As String In TablaForanea.ClaveForanea
            For Each IdForaneoActualizado As KeyValuePair(Of Integer, Integer) In IdActualizados
                Dim rows As DataRow() = tablaForaneaLocal.Select(String.Format("{0} = {1}", claveForanea, IdForaneoActualizado.Key))
                For Each row As DataRow In rows
                    row(claveForanea) = IdForaneoActualizado.Value
                Next
            Next
        Next
        TablaForanea.TablaActualizada = tablaForaneaLocal

    End Sub

    Private Function SincronizarARemota(Tabla As Tabla, valorBusqueda As String) As Integer
        Dim estado As Integer = 0

        Try
            'conexion remota
            CadenaConexion = System.Configuration.ConfigurationManager.ConnectionStrings("SistemaCinderella.My.MySettings.ConexionRemoto").ToString
            miconexionRemoto = New SqlConnection
            miconexionRemoto.ConnectionString = encripta.DesencriptarMD5(CadenaConexion)
            miconexionRemoto.Open()

            Dim transaccion As SqlTransaction
            transaccion = miconexionRemoto.BeginTransaction()

            'Selecciono todas las filas de la base remota
            Dim tablaRemota As DataTable = CType(clsDatos.ConsultarBaseRemoto(String.Format("select * from {0} where {1} = {2}", Tabla.Nombre, Tabla.ColumnaSeleccion, valorBusqueda)), DataSet).Tables(0)

            Dim ClavePrimaria As String = Tabla.ClavePrimaria
            Dim ListaIdBaseRemota As List(Of Integer) = tablaRemota.Rows.Cast(Of DataRow).Select(Function(x) CType(x(ClavePrimaria), Integer)).ToList()

            Dim commandEliminoData As SqlCommand = New SqlCommand(String.Format("Delete from {0} where {1} = {2}", Tabla.Nombre, Tabla.ColumnaSeleccion, valorBusqueda), miconexionRemoto, transaccion)
            commandEliminoData.ExecuteNonQuery()

            'copio los datos a base local
            Dim BulkCopy As New SqlBulkCopy(miconexionRemoto, SqlBulkCopyOptions.KeepIdentity, transaccion)
            BulkCopy.DestinationTableName = Tabla.Nombre

            Try
                BulkCopy.WriteToServer(Tabla.TablaActualizada)

                'Recorro todas las tablas relacionadas para sincronizar
                For Each tablaForanea As Tabla In Tabla.TablaRelacionada

                    SincronizarForanea(tablaForanea, ListaIdBaseRemota, transaccion)
                Next

                transaccion.Commit()
                BulkCopy.Close()
                estado = 1
            Catch ex As Exception
                transaccion.Rollback()
                BulkCopy.Close()
            End Try

        Catch ex As Exception
            Windows.Forms.MessageBox.Show("Se produjo un error sincronizando los datos de " & Tabla.Nombre & ": " & ex.Message, "Actualizacion fallida")
            miconexionRemoto.Dispose()

        Finally
            miconexionRemoto.Dispose()
        End Try

        Return estado
    End Function

    Private Sub SincronizarForanea(TablaForanea As Tabla, IdForaneosRemota As List(Of Integer), transaccion As SqlTransaction)
        For Each claveForanea As String In TablaForanea.ClaveForanea
            If (IdForaneosRemota.Count <> 0) Then
                Dim commandEliminoData As SqlCommand = New SqlCommand(String.Format("Delete from {0} where {1} in ({2})", TablaForanea.Nombre, claveForanea, String.Join(",", IdForaneosRemota)), miconexionRemoto, transaccion)
                commandEliminoData.ExecuteNonQuery()
            End If
        Next

        'copio los datos a base local
        Using BulkCopy As New SqlBulkCopy(miconexionRemoto, SqlBulkCopyOptions.KeepIdentity, transaccion)
            BulkCopy.DestinationTableName = TablaForanea.Nombre
            BulkCopy.WriteToServer(TablaForanea.TablaActualizada)
        End Using
    End Sub

    Function ObtenerUltimoIdBaseRemota(nombreTabla As String) As Integer
        Dim ds As DataSet
        ds = clsDatos.ConsultarBaseRemoto(String.Format("Select IDENT_CURRENT('{0}') as id", nombreTabla))

        If ds.Tables(0).Rows.Count = 1 And CInt(ds.Tables(0).Rows(0).Item("id")) > 0 Then
            Return ds.Tables(0).Rows(0).Item("id") + 1
        Else
            Return 1
        End If
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

        respuesta.Add(EmpleadosRegistros())
        respuesta.Add(CajaInicial())
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
        respuesta.Add(Ventas())
        respuesta.Add(Presupuesto())
        respuesta.Add(Notapedido())
        respuesta.Add(Facturacion())
        respuesta.Add(Notacredito())
        respuesta.Add(Devolucion())
        respuesta.Add(MovimientoImpuesto())
        respuesta.Add(Cheque())
        respuesta.Add(MoviminetoRetiro())
        respuesta.Add(Senia())

        Return respuesta
    End Function

    Private Shared Function EmpleadosRegistros() As Tabla
        Dim tablaRegistro As Tabla = New Tabla()
        tablaRegistro.Nombre = "EMPLEADOS_REGISTROS"
        tablaRegistro.ClavePrimaria = "id_Registro"
        tablaRegistro.ColumnaSeleccion = "id_Sucursal"
        tablaRegistro.IdAcualizados = New List(Of KeyValuePair(Of Integer, Integer))
        tablaRegistro.TablaRelacionada = New List(Of Tabla)

        Dim tablaRelRegistroEmpleados As Tabla = New Tabla()
        tablaRelRegistroEmpleados.Nombre = "REL_REGISTRO_EMPLEADOS"
        tablaRelRegistroEmpleados.ClavePrimaria = "id_Auto"
        tablaRelRegistroEmpleados.ColumnaSeleccion = "id_Registro"
        tablaRelRegistroEmpleados.ClaveForanea = New String() {"id_Registro"}
        tablaRelRegistroEmpleados.IdAcualizados = New List(Of KeyValuePair(Of Integer, Integer))

        tablaRegistro.TablaRelacionada.Add(tablaRelRegistroEmpleados)

        Dim tablaRelRegistroEmpleadosAusentes As Tabla = New Tabla()
        tablaRelRegistroEmpleadosAusentes.Nombre = "REL_REGISTRO_EMPLEADOS_AUSENTES"
        tablaRelRegistroEmpleadosAusentes.ClavePrimaria = "id_Auto"
        tablaRelRegistroEmpleadosAusentes.ColumnaSeleccion = "id_Registro"
        tablaRelRegistroEmpleadosAusentes.ClaveForanea = New String() {"id_Registro"}
        tablaRelRegistroEmpleadosAusentes.IdAcualizados = New List(Of KeyValuePair(Of Integer, Integer))

        tablaRegistro.TablaRelacionada.Add(tablaRelRegistroEmpleadosAusentes)

        Return tablaRegistro
    End Function

    Private Shared Function CajaInicial() As Tabla
        Dim tabla As Tabla = New Tabla()
        tabla.Nombre = "CAJA_INICIAL"
        tabla.ClavePrimaria = "id_Caja"
        tabla.ColumnaSeleccion = "id_Sucursal"
        tabla.IdAcualizados = New List(Of KeyValuePair(Of Integer, Integer))
        tabla.TablaRelacionada = New List(Of Tabla)

        Return tabla
    End Function

    Private Shared Function MovimientosCajas() As Tabla
        Dim tabla As Tabla = New Tabla()
        tabla.Nombre = "MOVIMIENTOS_CAJA"
        tabla.ClavePrimaria = "id_Movimiento"
        tabla.ColumnaSeleccion = "id_Sucursal"
        tabla.IdAcualizados = New List(Of KeyValuePair(Of Integer, Integer))
        tabla.TablaRelacionada = New List(Of Tabla)

        Return tabla
    End Function

    Private Shared Function MovimientosCajaFuerte() As Tabla
        Dim tabla As Tabla = New Tabla()
        tabla.Nombre = "MOVIMIENTOS_CAJA_FUERTE"
        tabla.ClavePrimaria = "id_Movimiento"
        tabla.ColumnaSeleccion = "id_Sucursal"
        tabla.IdAcualizados = New List(Of KeyValuePair(Of Integer, Integer))
        tabla.TablaRelacionada = New List(Of Tabla)

        Return tabla
    End Function

    Private Shared Function Adicionales() As Tabla
        Dim tabla As Tabla = New Tabla()
        tabla.Nombre = "ADICIONALES"
        tabla.ClavePrimaria = "id_Adicional"
        tabla.ColumnaSeleccion = "id_Sucursal"
        tabla.IdAcualizados = New List(Of KeyValuePair(Of Integer, Integer))
        tabla.TablaRelacionada = New List(Of Tabla)

        Return tabla
    End Function

    Private Shared Function EmpleadoRecibo() As Tabla
        Dim tabla As Tabla = New Tabla()
        tabla.Nombre = "EMPLEADOS_RECIBOS"
        tabla.ClavePrimaria = "id_Recibo"
        tabla.ColumnaSeleccion = "id_Sucursal"
        tabla.IdAcualizados = New List(Of KeyValuePair(Of Integer, Integer))
        tabla.TablaRelacionada = New List(Of Tabla)

        Return tabla
    End Function

    Private Shared Function MovimientoAporte() As Tabla
        Dim tabla As Tabla = New Tabla()
        tabla.Nombre = "MOVIMIENTOS_APORTE"
        tabla.ClavePrimaria = "id_Movimiento"
        tabla.ColumnaSeleccion = "id_Sucursal"
        tabla.IdAcualizados = New List(Of KeyValuePair(Of Integer, Integer))
        tabla.TablaRelacionada = New List(Of Tabla)

        Return tabla
    End Function

    Private Shared Function EmpleadoDeposito() As Tabla
        Dim tabla As Tabla = New Tabla()
        tabla.Nombre = "EMPLEADOS_DEPOSITOS"
        tabla.ClavePrimaria = "id_Deposito"
        tabla.ColumnaSeleccion = "id_Sucursal"
        tabla.IdAcualizados = New List(Of KeyValuePair(Of Integer, Integer))
        tabla.TablaRelacionada = New List(Of Tabla)

        Return tabla
    End Function

    Private Shared Function Deuda() As Tabla
        Dim tabla As Tabla = New Tabla()
        tabla.Nombre = "DEUDA"
        tabla.ClavePrimaria = "id_Deuda"
        tabla.ColumnaSeleccion = "id_Sucursal"
        tabla.IdAcualizados = New List(Of KeyValuePair(Of Integer, Integer))
        tabla.TablaRelacionada = New List(Of Tabla)

        Return tabla
    End Function

    Private Shared Function Adelanto() As Tabla
        Dim tabla As Tabla = New Tabla()
        tabla.Nombre = "ADELANTOS"
        tabla.ClavePrimaria = "id_Adelanto"
        tabla.ColumnaSeleccion = "id_Sucursal"
        tabla.IdAcualizados = New List(Of KeyValuePair(Of Integer, Integer))
        tabla.TablaRelacionada = New List(Of Tabla)

        Return tabla
    End Function

    Private Shared Function Stock() As Tabla
        Dim tabla As Tabla = New Tabla()
        tabla.Nombre = "STOCK"
        tabla.ClavePrimaria = "id_Stock"
        tabla.ColumnaSeleccion = "id_Sucursal"
        tabla.IdAcualizados = New List(Of KeyValuePair(Of Integer, Integer))
        tabla.TablaRelacionada = New List(Of Tabla)

        Return tabla
    End Function

    Private Shared Function StockBitacora() As Tabla
        Dim tabla As Tabla = New Tabla()
        tabla.Nombre = "STOCK_BITACORA"
        tabla.ClavePrimaria = "id_Bitacora"
        tabla.ColumnaSeleccion = "id_Sucursal"
        tabla.IdAcualizados = New List(Of KeyValuePair(Of Integer, Integer))
        tabla.TablaRelacionada = New List(Of Tabla)

        Return tabla
    End Function

    Private Shared Function MovimientoGastos() As Tabla
        Dim tabla As Tabla = New Tabla()
        tabla.Nombre = "MOVIMIENTOS_GASTOS"
        tabla.ClavePrimaria = "id_Movimiento"
        tabla.ColumnaSeleccion = "id_Sucursal"
        tabla.IdAcualizados = New List(Of KeyValuePair(Of Integer, Integer))
        tabla.TablaRelacionada = New List(Of Tabla)

        Return tabla
    End Function

    Private Shared Function CuentaCorriente() As Tabla
        Dim tabla As Tabla = New Tabla()
        tabla.Nombre = "CUENTA_CORRIENTE"
        tabla.ClavePrimaria = "id_Registro"
        tabla.ColumnaSeleccion = "id_Sucursal"
        tabla.IdAcualizados = New List(Of KeyValuePair(Of Integer, Integer))
        tabla.TablaRelacionada = New List(Of Tabla)

        Return tabla
    End Function

    Private Shared Function Mercaderia() As Tabla
        Dim tabla As Tabla = New Tabla()
        tabla.Nombre = "MERCADERIAS"
        tabla.ClavePrimaria = "id_Mercaderia"
        tabla.ColumnaSeleccion = "id_Sucursal"
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
        tabla.Nombre = "NOTAPEDIDO"
        tabla.ClavePrimaria = "id_NotaPedido"
        tabla.ColumnaSeleccion = "id_Sucursal"
        tabla.IdAcualizados = New List(Of KeyValuePair(Of Integer, Integer))
        tabla.TablaRelacionada = New List(Of Tabla)

        Dim tablaRelelacionada1 As Tabla = New Tabla()
        tablaRelelacionada1.Nombre = "NOTAPEDIDO_DETALLE"
        tablaRelelacionada1.ClavePrimaria = "id_Detalle"
        tablaRelelacionada1.ColumnaSeleccion = "id_NotaPedido"
        tablaRelelacionada1.ClaveForanea = New String() {"id_NotaPedido"}
        tablaRelelacionada1.IdAcualizados = New List(Of KeyValuePair(Of Integer, Integer))

        tabla.TablaRelacionada.Add(tablaRelelacionada1)
        Return tabla
    End Function

    Private Shared Function Facturacion() As Tabla
        Dim tabla As Tabla = New Tabla()
        tabla.Nombre = "FACTURACION"
        tabla.ClavePrimaria = "id_Facturacion"
        tabla.ColumnaSeleccion = "Id_Sucursal"
        tabla.IdAcualizados = New List(Of KeyValuePair(Of Integer, Integer))
        tabla.TablaRelacionada = New List(Of Tabla)

        Return tabla
    End Function

    Private Shared Function Notacredito() As Tabla
        Dim tabla As Tabla = New Tabla()
        tabla.Nombre = "NOTACREDITO"
        tabla.ClavePrimaria = "id_NotaCredito"
        tabla.ColumnaSeleccion = "Id_Sucursal"
        tabla.IdAcualizados = New List(Of KeyValuePair(Of Integer, Integer))
        tabla.TablaRelacionada = New List(Of Tabla)

        Return tabla
    End Function

    Private Shared Function Devolucion() As Tabla
        Dim tabla As Tabla = New Tabla()
        tabla.Nombre = "DEVOLUCIONES"
        tabla.ClavePrimaria = "id_Devolucion"
        tabla.ColumnaSeleccion = "id_Sucursal"
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
        tabla.Nombre = "MOVIMIENTOS_IMPUESTOS"
        tabla.ClavePrimaria = "id_Movimiento"
        tabla.ColumnaSeleccion = "id_Sucursal"
        tabla.IdAcualizados = New List(Of KeyValuePair(Of Integer, Integer))
        tabla.TablaRelacionada = New List(Of Tabla)

        Return tabla
    End Function

    Private Shared Function Cheque() As Tabla
        Dim tabla As Tabla = New Tabla()
        tabla.Nombre = "CHEQUE"
        tabla.ClavePrimaria = "id_Cheque"
        tabla.ColumnaSeleccion = "SucursalId"
        tabla.IdAcualizados = New List(Of KeyValuePair(Of Integer, Integer))
        tabla.TablaRelacionada = New List(Of Tabla)

        Return tabla
    End Function

    Private Shared Function MoviminetoRetiro() As Tabla
        Dim tabla As Tabla = New Tabla()
        tabla.Nombre = "MOVIMIENTOS_RETIROS"
        tabla.ClavePrimaria = "id_Movimiento"
        tabla.ColumnaSeleccion = "id_Sucursal"
        tabla.IdAcualizados = New List(Of KeyValuePair(Of Integer, Integer))
        tabla.TablaRelacionada = New List(Of Tabla)

        Return tabla
    End Function

    Private Shared Function Senia() As Tabla
        Dim tabla As Tabla = New Tabla()
        tabla.Nombre = "SENIA"
        tabla.ClavePrimaria = "id_Senia"
        tabla.ColumnaSeleccion = "id_Sucursal"
        tabla.IdAcualizados = New List(Of KeyValuePair(Of Integer, Integer))
        tabla.TablaRelacionada = New List(Of Tabla)

        Return tabla
    End Function
End Class

Public Class Tabla
    Private _Nombre As String
    Public Property Nombre() As String
        Get
            Return _Nombre
        End Get
        Set(ByVal value As String)
            _Nombre = value
        End Set
    End Property

    Private _ColumnaSeleccion As String
    Public Property ColumnaSeleccion() As String
        Get
            Return _ColumnaSeleccion
        End Get
        Set(ByVal value As String)
            _ColumnaSeleccion = value
        End Set
    End Property

    Private _ClavePrimaria As String
    Public Property ClavePrimaria() As String
        Get
            Return _ClavePrimaria
        End Get
        Set(ByVal value As String)
            _ClavePrimaria = value
        End Set
    End Property

    Private _ClaveForanea As String()
    Public Property ClaveForanea() As String()
        Get
            Return _ClaveForanea
        End Get
        Set(ByVal value As String())
            _ClaveForanea = value
        End Set
    End Property

    Private _IdActualizados As IList(Of KeyValuePair(Of Integer, Integer))
    Public Property IdAcualizados() As IList(Of KeyValuePair(Of Integer, Integer))
        Get
            Return _IdActualizados
        End Get
        Set(ByVal value As IList(Of KeyValuePair(Of Integer, Integer)))
            _IdActualizados = value
        End Set
    End Property

    Private _TablaActualizada As DataTable
    Public Property TablaActualizada() As DataTable
        Get
            Return _TablaActualizada
        End Get
        Set(ByVal value As DataTable)
            _TablaActualizada = value
        End Set
    End Property

    Private _TablaRelacionada As IList(Of Tabla)
    Public Property TablaRelacionada() As IList(Of Tabla)
        Get
            Return _TablaRelacionada
        End Get
        Set(ByVal value As IList(Of Tabla))
            _TablaRelacionada = value
        End Set
    End Property
End Class
