Imports System.Data.SqlClient
Imports Entidades

Public Class NegVentas
    Dim ClsDatos As New Datos.Conexion
    Dim ClsFunciones As New Funciones


    'Funcion que inserta un nuevo registro en la tabla VENTAS.
    Public Function NuevaVenta(ByVal EntVenta As Entidades.Ventas, EntDetalleVenta As List(Of Entidades.Ventas_Detalle)) As Int64
        'Declaro variables
        Dim cmd As New SqlCommand
        Dim msg As Boolean
        Dim dt As DataTable = New DataTable()
        Dim HayInternet As Boolean = Funciones.HayInternet

        'Cargo el detalle de la devolucion en un Tabla para pasarla por un campo al SP
        dt.Columns.Add("id_Detalle", Type.GetType("System.Int64"))
        dt.Columns.Add("id_Producto", Type.GetType("System.Int32"))
        dt.Columns.Add("Cantidad", Type.GetType("System.Int32"))
        dt.Columns.Add("Precio", Type.GetType("System.Double"))
        dt.Columns.Add("Iva", Type.GetType("System.Double"))
        dt.Columns.Add("Monto", Type.GetType("System.Double"))

        For Each item As Entidades.Ventas_Detalle In EntDetalleVenta
            dt.Rows.Add(ClsDatos.ObtenerCalveUnica(EntVenta.id_Sucursal), item.id_Producto, item.Cantidad, item.Precio, item.Iva, item.Monto)
        Next

        EntVenta.id_Venta = ClsDatos.ObtenerCalveUnica(EntVenta.id_Sucursal)
        EntVenta.FechaEdicion = DateTime.Now

        Try
            cmd.Connection = ClsDatos.ConectarLocal()
            msg = NuevaVenta(EntVenta, cmd, dt)
            ClsDatos.DesconectarLocal()

            If HayInternet Then
                cmd = New SqlCommand()
                cmd.Connection = ClsDatos.ConectarRemoto()
                msg = NuevaVenta(EntVenta, cmd, dt)
                ClsDatos.DesconectarRemoto()
            End If

            'retorno valor
            Return EntVenta.id_Venta
        Catch ex As Exception
            Return False
        End Try
    End Function

    Private Shared Function NuevaVenta(EntVenta As Entidades.Ventas, ByRef cmd As SqlCommand, dt As DataTable) As Boolean
        'Cargo y ejecuto el stored.
        cmd.CommandType = CommandType.StoredProcedure
        cmd.CommandText = "sp_Ventas_Alta"
        With cmd.Parameters
            .AddWithValue("@id_Venta", EntVenta.id_Venta)
            .AddWithValue("@id_Cliente", EntVenta.id_Cliente)
            .AddWithValue("@PorcentajeFacturacion", EntVenta.PorcentajeFacturacion)
            .AddWithValue("@id_Empleado", EntVenta.id_Empleado)
            .AddWithValue("@id_Encargado", EntVenta.id_Encargado)
            .AddWithValue("@id_Sucursal", EntVenta.id_Sucursal)
            .AddWithValue("@id_TipoPago", EntVenta.id_TipoPago)
            .AddWithValue("@id_TipoVenta", EntVenta.id_TipoVenta)
            .AddWithValue("@id_ListaPrecio", EntVenta.id_ListaPrecio)
            .AddWithValue("@id_Tarjeta", EntVenta.id_Tarjeta)
            .AddWithValue("@CantidadCuotas", EntVenta.CantidadCuotas)
            .AddWithValue("@PrecioTotal", EntVenta.PrecioTotal)
            .AddWithValue("@Subtotal", EntVenta.SubTotal)
            .AddWithValue("@MontoSenia", EntVenta.MontoSenia)
            .AddWithValue("@Senia ", EntVenta.Senia)
            .AddWithValue("@CantidadTotal", EntVenta.CantidadTotal)
            .AddWithValue("@Descuento", EntVenta.Descuento)
            .AddWithValue("@CostoFinanciero", EntVenta.CostoFinanciero)
            .AddWithValue("@Anulado", EntVenta.Anulado)
            .AddWithValue("@Habilitado", EntVenta.Habilitado)
            .AddWithValue("@Facturado", EntVenta.Facturado)
            .AddWithValue("@FechaEdicion", EntVenta.FechaEdicion)
            .AddWithValue("@DiferenciaPagoCheque", EntVenta.DiferenciaPagoCheque)
        End With

        'Declaro el tipo de dato para el detalle de la venta
        Dim param = cmd.Parameters.AddWithValue("@Detalle", dt)
        param.SqlDbType = SqlDbType.Structured
        param.TypeName = "dbo.VENTA_DETALLE_TYPE"

        Dim respuesta As New SqlParameter("@msg", SqlDbType.Int, 255)
        respuesta.Direction = ParameterDirection.Output
        cmd.Parameters.Add(respuesta)
        cmd.ExecuteNonQuery()

        Return CBool(respuesta.Value)
    End Function

    'elimina la venta por ID
    Public Sub Eliminar(IDVenta As Int64)
        ClsDatos.ConsultarBaseLocal("DELETE FROM VENTAS WHERE id_Venta = " + IDVenta.ToString())
        ClsDatos.ConsultarBaseRemoto("DELETE FROM Ventas_Detalle WHERE id_Venta = " + IDVenta.ToString())
        If (Funciones.HayInternet) Then
            ClsDatos.ConsultarBaseRemoto("DELETE FROM VENTAS WHERE id_Venta = " + IDVenta.ToString())
            ClsDatos.ConsultarBaseRemoto("DELETE FROM Ventas_Detalle WHERE id_Venta = " + IDVenta.ToString())
        End If
    End Sub

    'Funcion para listar todas las ventas.
    Function ListadoVentasCompleto(ByVal id_Sucursal As Integer) As DataSet
        If Funciones.HayInternet Then
            Return ClsDatos.ConsultarBaseRemoto("execute sp_Ventas_ListadoCompleto @id_Sucursal=" & id_Sucursal)
        Else
            Return ClsDatos.ConsultarBaseLocal("execute sp_Ventas_ListadoCompleto @id_Sucursal=" & id_Sucursal)
        End If
    End Function

    'Funcion para listar todas las ventas de un cliente.
    Function ListadoVentasCliente(ByVal id_Cliente As Integer) As DataSet
        If Funciones.HayInternet Then
            Return ClsDatos.ConsultarBaseRemoto("execute sp_Ventas_ListadoCliente @id_Cliente=" & id_Cliente)
        Else
            Return ClsDatos.ConsultarBaseLocal("execute sp_Ventas_ListadoCliente @id_Cliente=" & id_Cliente)
        End If
    End Function

    'Funcion para listar todas las ventas por FECHA.
    Function ListadoVentasCompletoFecha(ByVal id_Sucursal As Integer, ByVal FDesde As String, ByVal FHasta As String) As DataSet
        If Funciones.HayInternet Then
            Return ClsDatos.ConsultarBaseRemoto("execute sp_Ventas_ListadoCompletoFecha @id_Sucursal=" & id_Sucursal & ",@FDesde='" & FDesde & "', @FHasta='" & FHasta & "'")
        Else
            Return ClsDatos.ConsultarBaseLocal("execute sp_Ventas_ListadoCompletoFecha @id_Sucursal=" & id_Sucursal & ",@FDesde='" & FDesde & "', @FHasta='" & FHasta & "'")
        End If
    End Function

    'Funcion para consultar una venta.
    Public Function TraerVenta(ByVal id_Venta As Int64)
        Dim dsVentas As New DataSet

        If (Funciones.HayInternet) Then
            dsVentas = ClsDatos.ConsultarBaseRemoto("execute sp_Ventas_Detalle @id_Venta=" & id_Venta)
        Else
            dsVentas = ClsDatos.ConsultarBaseLocal("execute sp_Ventas_Detalle @id_Venta=" & id_Venta)
        End If

        Return dsVentas
    End Function

    'Funcion para consultar un detalle de laa venta.
    Public Function TraerVentaDetalle(ByVal id_Venta As Int64)
        Dim dsVentas As New DataSet

        If (Funciones.HayInternet) Then
            dsVentas = ClsDatos.ConsultarBaseRemoto("execute sp_VentasDetalle_Listado @id_Venta=" & id_Venta)
        Else
            dsVentas = ClsDatos.ConsultarBaseLocal("execute sp_VentasDetalle_Listado @id_Venta=" & id_Venta)
        End If

        Return dsVentas
    End Function

    'Funcion para anular una venta.
    Public Function AnularVenta(ByVal id_Venta As Int64, ByVal Texto As String)

        'Declaro variables
        Dim cmd As New SqlCommand
        Dim msg As Integer
        Dim FechaEdicion As DateTime = DateTime.Now
        Dim HayInternet As Boolean = Funciones.HayInternet

        If (Texto = "") Then
            Texto = "No se ingreso el motivo."
        End If

        Try
            cmd.Connection = ClsDatos.ConectarLocal()
            msg = AnularVenta(id_Venta, Texto, FechaEdicion, cmd)
            ClsDatos.DesconectarLocal()

            If HayInternet Then
                cmd = New SqlCommand()
                cmd.Connection = ClsDatos.ConectarRemoto()
                msg = AnularVenta(id_Venta, Texto, FechaEdicion, cmd)
                ClsDatos.DesconectarRemoto()
            End If

            'retorno valor
            Return msg
        Catch ex As Exception
            Return 0
        End Try
    End Function

    Private Shared Function AnularVenta(id_Venta As Int64, Texto As String, FechaEdicion As DateTime, ByRef cmd As SqlCommand) As Integer
        'Cargo y ejecuto el stored.
        cmd.CommandType = CommandType.StoredProcedure
        cmd.CommandText = "sp_Ventas_Anular"
        With cmd.Parameters
            .AddWithValue("@id_Venta", id_Venta)
            .AddWithValue("@Texto", Texto)
            .AddWithValue("@FechaEdicion", FechaEdicion)
            .AddWithValue("@Fecha", Now.Date.ToString("yyyy/MM/dd"))
        End With
        Dim respuesta As New SqlParameter("@msg", SqlDbType.Int, 255)
        respuesta.Direction = ParameterDirection.Output
        cmd.Parameters.Add(respuesta)
        cmd.ExecuteNonQuery()
        Return respuesta.Value
    End Function

    'Funcion que obtiene el total en ventas de una sucursal.
    Public Function ObtenerVentasSucursal(ByVal id_Sucursal As Integer, ByVal FDesde As String, ByVal FHasta As String)
        Dim ds As New DataSet

        If Funciones.HayInternet Then
            ds = ClsDatos.ConsultarBaseRemoto("execute sp_Ventas_SucursalObtener @id_Sucursal=" & id_Sucursal & ", @FDesde='" & FDesde & "', @FHasta='" & FHasta & "'")
        Else
            ds = ClsDatos.ConsultarBaseLocal("execute sp_Ventas_SucursalObtener @id_Sucursal=" & id_Sucursal & ", @FDesde='" & FDesde & "', @FHasta='" & FHasta & "'")
        End If

        If ds.Tables(0).Rows.Count > 0 Then
            If ds.Tables(0).Rows(0).Item("Ventas").ToString <> "" Then
                Return ds.Tables(0).Rows(0).Item("Ventas").ToString
            Else
                Return 0
            End If
        Else
            Return 0
        End If
    End Function


    'Funcion que obtiene el total en ventas minoristas de una sucursal. //NO EXISTE EL SP EN LA BASE LOCAL. SE DEBE COPIAR.
    Public Function ObtenerVentasSucursalMinoristas(ByVal id_Sucursal As Integer, ByVal FDesde As String, ByVal FHasta As String)
        Dim ds As New DataSet

        If Funciones.HayInternet Then
            ds = ClsDatos.ConsultarBaseRemoto("execute sp_Ventas_SucursalObtenerMinoristas @id_Sucursal=" & id_Sucursal & ", @FDesde='" & FDesde & "', @FHasta='" & FHasta & "'")
        Else
            'NO ANDA LOCALMENTE! COPIAR SP!!!
            ds = ClsDatos.ConsultarBaseLocal("execute sp_Ventas_SucursalObtenerMinoristas @id_Sucursal=" & id_Sucursal & ", @FDesde='" & FDesde & "', @FHasta='" & FHasta & "'")
        End If

        If ds.Tables(0).Rows.Count > 0 Then
            If ds.Tables(0).Rows(0).Item("VentasMinoristas").ToString <> "" Then
                Return ds.Tables(0).Rows(0).Item("VentasMinoristas").ToString
            Else
                Return 0
            End If
        Else
            Return 0
        End If
    End Function

    'Funcion que obtiene el total en ventas mayoristas de una sucursal. //NO EXISTE EL SP EN LA BASE LOCAL. SE DEBE COPIAR.
    Public Function ObtenerVentasSucursalMayoristas(ByVal id_Sucursal As Integer, ByVal FDesde As String, ByVal FHasta As String)
        Dim ds As New DataSet

        If Funciones.HayInternet Then
            ds = ClsDatos.ConsultarBaseRemoto("execute sp_Ventas_SucursalObtenerMayoristas @id_Sucursal=" & id_Sucursal & ", @FDesde='" & FDesde & "', @FHasta='" & FHasta & "'")
        Else
            'NO ANDA LOCALMENTE! COPIAR SP!!!
            ds = ClsDatos.ConsultarBaseLocal("execute sp_Ventas_SucursalObtenerMayoristas @id_Sucursal=" & id_Sucursal & ", @FDesde='" & FDesde & "', @FHasta='" & FHasta & "'")
        End If

        If ds.Tables(0).Rows.Count > 0 Then
            If ds.Tables(0).Rows(0).Item("VentasMayoristas").ToString <> "" Then
                Return ds.Tables(0).Rows(0).Item("VentasMayoristas").ToString
            Else
                Return 0
            End If
        Else
            Return 0
        End If
    End Function

    'Funcion que obtiene el total en ventas efectivo de una sucursal. //NO EXISTE EL SP EN LA BASE LOCAL. SE DEBE COPIAR.
    Public Function ObtenerVentasSucursalEfectivo(ByVal id_Sucursal As Integer, ByVal FDesde As String, ByVal FHasta As String)
        Dim ds As New DataSet

        If Funciones.HayInternet Then
            ds = ClsDatos.ConsultarBaseRemoto("execute sp_Ventas_SucursalObtenerEfectivo @id_Sucursal=" & id_Sucursal & ", @FDesde='" & FDesde & "', @FHasta='" & FHasta & "'")
        Else
            'NO ANDA LOCALMENTE! COPIAR SP!!!
            ds = ClsDatos.ConsultarBaseLocal("execute sp_Ventas_SucursalObtenerEfectivo @id_Sucursal=" & id_Sucursal & ", @FDesde='" & FDesde & "', @FHasta='" & FHasta & "'")
        End If

        If ds.Tables(0).Rows.Count > 0 Then
            If ds.Tables(0).Rows(0).Item("VentasEfectivo").ToString <> "" Then
                Return ds.Tables(0).Rows(0).Item("VentasEfectivo").ToString
            Else
                Return 0
            End If
        Else
            Return 0
        End If
    End Function

    'Funcion que obtiene el total en ventas facturadas de una sucursal. //NO EXISTE EL SP EN LA BASE LOCAL. SE DEBE COPIAR.
    Public Function ObtenerVentasSucursalFacturado(ByVal id_Sucursal As Integer, ByVal FDesde As String, ByVal FHasta As String)
        Dim ds As New DataSet

        If Funciones.HayInternet Then
            ds = ClsDatos.ConsultarBaseRemoto("execute sp_Ventas_SucursalObtenerFacturado @id_Sucursal=" & id_Sucursal & ", @FDesde='" & FDesde & "', @FHasta='" & FHasta & "'")
        Else
            'NO ANDA LOCALMENTE! COPIAR SP!!!
            ds = ClsDatos.ConsultarBaseLocal("execute sp_Ventas_SucursalObtenerFacturado @id_Sucursal=" & id_Sucursal & ", @FDesde='" & FDesde & "', @FHasta='" & FHasta & "'")
        End If

        If ds.Tables(0).Rows.Count > 0 Then
            If ds.Tables(0).Rows(0).Item("VentasFacturado").ToString <> "" Then
                Return ds.Tables(0).Rows(0).Item("VentasFacturado").ToString
            Else
                Return 0
            End If
        Else
            Return 0
        End If
    End Function

    'Funcion que obtiene el total en ventas cheque de una sucursal. //NO EXISTE EL SP EN LA BASE LOCAL. SE DEBE COPIAR.
    Public Function ObtenerVentasSucursalCheque(ByVal id_Sucursal As Integer, ByVal FDesde As String, ByVal FHasta As String)
        Dim ds As New DataSet

        If Funciones.HayInternet Then
            ds = ClsDatos.ConsultarBaseRemoto("execute sp_Ventas_SucursalObtenerCheque @id_Sucursal=" & id_Sucursal & ", @FDesde='" & FDesde & "', @FHasta='" & FHasta & "'")
        Else
            'NO ANDA LOCALMENTE! COPIAR SP!!!
            ds = ClsDatos.ConsultarBaseLocal("execute sp_Ventas_SucursalObtenerCheque @id_Sucursal=" & id_Sucursal & ", @FDesde='" & FDesde & "', @FHasta='" & FHasta & "'")
        End If

        If ds.Tables(0).Rows.Count > 0 Then
            If ds.Tables(0).Rows(0).Item("VentasCheque").ToString <> "" Then
                Return ds.Tables(0).Rows(0).Item("VentasCheque").ToString
            Else
                Return 0
            End If
        Else
            Return 0
        End If
    End Function


    'Funcion que obtiene el total en ventas credito de una sucursal. //NO EXISTE EL SP EN LA BASE LOCAL. SE DEBE COPIAR.
    Public Function ObtenerVentasSucursalCredito(ByVal id_Sucursal As Integer, ByVal FDesde As String, ByVal FHasta As String)
        Dim ds As New DataSet

        If Funciones.HayInternet Then
            ds = ClsDatos.ConsultarBaseRemoto("execute sp_Ventas_SucursalObtenerCredito @id_Sucursal=" & id_Sucursal & ", @FDesde='" & FDesde & "', @FHasta='" & FHasta & "'")
        Else
            'NO ANDA LOCALMENTE! COPIAR SP!!!
            ds = ClsDatos.ConsultarBaseLocal("execute sp_Ventas_SucursalObtenerCredito @id_Sucursal=" & id_Sucursal & ", @FDesde='" & FDesde & "', @FHasta='" & FHasta & "'")
        End If

        If ds.Tables(0).Rows.Count > 0 Then
            If ds.Tables(0).Rows(0).Item("VentasCredito").ToString <> "" Then
                Return ds.Tables(0).Rows(0).Item("VentasCredito").ToString
            Else
                Return 0
            End If
        Else
            Return 0
        End If
    End Function


    'Funcion que obtiene el total en ventas debito de una sucursal. //NO EXISTE EL SP EN LA BASE LOCAL. SE DEBE COPIAR.
    Public Function ObtenerVentasSucursalDebito(ByVal id_Sucursal As Integer, ByVal FDesde As String, ByVal FHasta As String)
        Dim ds As New DataSet

        If Funciones.HayInternet Then
            ds = ClsDatos.ConsultarBaseRemoto("execute sp_Ventas_SucursalObtenerDebito @id_Sucursal=" & id_Sucursal & ", @FDesde='" & FDesde & "', @FHasta='" & FHasta & "'")
        Else
            'NO ANDA LOCALMENTE! COPIAR SP!!!
            ds = ClsDatos.ConsultarBaseLocal("execute sp_Ventas_SucursalObtenerDebito @id_Sucursal=" & id_Sucursal & ", @FDesde='" & FDesde & "', @FHasta='" & FHasta & "'")
        End If

        If ds.Tables(0).Rows.Count > 0 Then
            If ds.Tables(0).Rows(0).Item("VentasDebito").ToString <> "" Then
                Return ds.Tables(0).Rows(0).Item("VentasDebito").ToString
            Else
                Return 0
            End If
        Else
            Return 0
        End If
    End Function


    'Funcion que obtiene el listado de ventas de una sucursal.
    Public Function ObtenerVentasSucursalListado(ByVal id_Sucursal As Integer, ByVal FDesde As String, ByVal FHasta As String)
        Dim ds As New DataSet

        If Funciones.HayInternet Then
            ds = ClsDatos.ConsultarBaseRemoto("execute sp_Ventas_SucursalObtenerListado @id_Sucursal=" & id_Sucursal & ", @FDesde='" & FDesde & "', @FHasta='" & FHasta & "'")
        Else
            ds = ClsDatos.ConsultarBaseLocal("execute sp_Ventas_SucursalObtenerListado @id_Sucursal=" & id_Sucursal & ", @FDesde='" & FDesde & "', @FHasta='" & FHasta & "'")
        End If

        Return ds
    End Function

    'Funcion que actualiza una venta como facturada o no facturada.
    Public Function FacturoVenta(ByVal Facturo As Boolean, ByVal id_Venta As Int64)
        Dim Facturado As Integer = 0
        Dim HayInternet As Boolean = Funciones.HayInternet
        Dim msg As Boolean
        Dim FechaEdicion As DateTime = DateTime.Now
        Dim cmd As New SqlCommand

        If Facturo Then
            Facturado = 1
        Else
            Facturado = 0
        End If

        Try
            cmd.Connection = ClsDatos.ConectarLocal()
            msg = FacturoVenta(id_Venta, Facturado, FechaEdicion, cmd)
            ClsDatos.DesconectarLocal()

            'Conecto a la bdd.
            If HayInternet Then
                cmd = New SqlCommand()
                cmd.Connection = ClsDatos.ConectarRemoto()
                msg = FacturoVenta(id_Venta, Facturado, FechaEdicion, cmd)
                ClsDatos.DesconectarRemoto()
            End If

            'retorno valor
            Return msg
        Catch ex As Exception
            Return 0
        End Try

    End Function

    Private Shared Function FacturoVenta(id_Venta As Int64, Facturado As Integer, FechaEdicion As DateTime, ByRef cmd As SqlCommand) As Boolean
        'Cargo y ejecuto el stored.
        cmd.CommandType = CommandType.StoredProcedure
        cmd.CommandText = "sp_Ventas_Facturo"
        With cmd.Parameters
            .AddWithValue("@id_Venta", id_Venta)
            .AddWithValue("@Facturado", Facturado)
            .AddWithValue("@FechaEdicion", Facturado)
        End With

        'Respuesta del stored.
        Dim respuesta As New SqlParameter("@msg", SqlDbType.Int, 255)
        respuesta.Direction = ParameterDirection.Output
        cmd.Parameters.Add(respuesta)
        cmd.ExecuteNonQuery()
        Return CBool(respuesta.Value)
    End Function

    'Resumen Diario
    Public Function TotalVentasMinoristas(ByVal id_Sucursal As Integer, ByVal Fecha As String)
        Dim ds As New DataSet
        If Funciones.HayInternet Then
            ds = ClsDatos.ConsultarBaseRemoto("execute sp_Ventas_TotalMinorista @id_Sucursal=" & id_Sucursal & ", @Fecha='" & Fecha & "'")
        Else
            ds = ClsDatos.ConsultarBaseLocal("execute sp_Ventas_TotalMinorista @id_Sucursal=" & id_Sucursal & ", @Fecha='" & Fecha & "'")
        End If

        If ds.Tables(0).Rows.Count = 1 And ds.Tables(0).Rows(0).Item("VentasTotales").ToString <> "" Then
            Return ds.Tables(0).Rows(0).Item("VentasTotales").ToString
        Else
            Return 0
        End If
    End Function

    Public Function TotalVentasMayoristas(ByVal id_Sucursal As Integer, ByVal Fecha As String)
        Dim ds As New DataSet
        If Funciones.HayInternet Then
            ds = ClsDatos.ConsultarBaseRemoto("execute sp_Ventas_TotalMayorista @id_Sucursal=" & id_Sucursal & ", @Fecha='" & Fecha & "'")
        Else
            ds = ClsDatos.ConsultarBaseLocal("execute sp_Ventas_TotalMayorista @id_Sucursal=" & id_Sucursal & ", @Fecha='" & Fecha & "'")
        End If

        If ds.Tables(0).Rows.Count = 1 And ds.Tables(0).Rows(0).Item("VentasTotales").ToString <> "" Then
            Return ds.Tables(0).Rows(0).Item("VentasTotales").ToString
        Else
            Return 0
        End If
    End Function

    Public Function TotalVentasFacturado(ByVal id_Sucursal As Integer, ByVal Fecha As String)
        Dim ds As New DataSet
        If Funciones.HayInternet Then
            ds = ClsDatos.ConsultarBaseRemoto("execute sp_Ventas_TotalFacturado @id_Sucursal=" & id_Sucursal & ", @Fecha='" & Fecha & "'")
        Else
            ds = ClsDatos.ConsultarBaseLocal("execute sp_Ventas_TotalFacturado @id_Sucursal=" & id_Sucursal & ", @Fecha='" & Fecha & "'")
        End If

        If ds.Tables(0).Rows.Count = 1 And ds.Tables(0).Rows(0).Item("VentasTotales").ToString <> "" Then
            Return ds.Tables(0).Rows(0).Item("VentasTotales").ToString
        Else
            Return 0
        End If
    End Function

    Public Function TotalVentas(ByVal id_Sucursal As Integer, ByVal Fecha As String)
        Dim ds As New DataSet
        If Funciones.HayInternet Then
            ds = ClsDatos.ConsultarBaseRemoto("execute sp_Ventas_TotalVentas @id_Sucursal=" & id_Sucursal & ", @Fecha='" & Fecha & "'")
        Else
            ds = ClsDatos.ConsultarBaseLocal("execute sp_Ventas_TotalVentas @id_Sucursal=" & id_Sucursal & ", @Fecha='" & Fecha & "'")
        End If

        If ds.Tables(0).Rows.Count = 1 And ds.Tables(0).Rows(0).Item("VentasTotales").ToString <> "" Then
            Return ds.Tables(0).Rows(0).Item("VentasTotales").ToString
        Else
            Return 0
        End If
    End Function

    Public Function TotalVentasTarjetas(ByVal id_Sucursal As Integer, ByVal Fecha As String)
        Dim ds As New DataSet
        If Funciones.HayInternet Then
            ds = ClsDatos.ConsultarBaseRemoto("execute sp_Ventas_TotalVentasTarjetas @id_Sucursal=" & id_Sucursal & ", @Fecha='" & Fecha & "'")
        Else
            ds = ClsDatos.ConsultarBaseLocal("execute sp_Ventas_TotalVentasTarjetas @id_Sucursal=" & id_Sucursal & ", @Fecha='" & Fecha & "'")
        End If

        If ds.Tables(0).Rows.Count = 1 And ds.Tables(0).Rows(0).Item("VentasTotales").ToString <> "" Then
            Return ds.Tables(0).Rows(0).Item("VentasTotales").ToString
        Else
            Return 0
        End If
    End Function

    Public Function TotalVentasEfectivo(ByVal id_Sucursal As Integer, ByVal Fecha As String)
        Dim ds As New DataSet
        If Funciones.HayInternet Then
            ds = ClsDatos.ConsultarBaseRemoto("execute sp_Ventas_TotalVentasEfectivo @id_Sucursal=" & id_Sucursal & ", @Fecha='" & Fecha & "'")
        Else
            ds = ClsDatos.ConsultarBaseLocal("execute sp_Ventas_TotalVentasEfectivo @id_Sucursal=" & id_Sucursal & ", @Fecha='" & Fecha & "'")
        End If

        If ds.Tables(0).Rows.Count = 1 And ds.Tables(0).Rows(0).Item("VentasTotales").ToString <> "" Then
            Return ds.Tables(0).Rows(0).Item("VentasTotales").ToString
        Else
            Return 0
        End If
    End Function

    Public Function TotalVentasCheque(ByVal id_Sucursal As Integer, ByVal Fecha As String)
        Dim ds As New DataSet
        If Funciones.HayInternet Then
            ds = ClsDatos.ConsultarBaseRemoto("execute sp_Ventas_TotalVentasCheque @id_Sucursal=" & id_Sucursal & ", @Fecha='" & Fecha & "'")
        Else
            ds = ClsDatos.ConsultarBaseLocal("execute sp_Ventas_TotalVentasCheque @id_Sucursal=" & id_Sucursal & ", @Fecha='" & Fecha & "'")
        End If

        If ds.Tables(0).Rows.Count = 1 And ds.Tables(0).Rows(0).Item("VentasTotales").ToString <> "" Then
            Return ds.Tables(0).Rows(0).Item("VentasTotales").ToString
        Else
            Return 0
        End If
    End Function
End Class
