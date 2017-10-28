Imports System.Data.SqlClient
Imports Entidades

Public Class NegPresupuesto
    Dim ClsDatos As New Datos.Conexion
    Dim ClsFunciones As New Funciones

    'Funcion que inserta un nuevo registro en la tabla presupuesto.
    Public Function Alta(ByVal Presupuesto As Entidades.Presupuesto, DetallePresupuesto As List(Of Entidades.Presupuesto_Detalle)) As Int64
        'Declaro variables
        Dim cmd As New SqlCommand
        Dim dt As DataTable = New DataTable()
        Dim HayInternet As Boolean = Funciones.HayInternet
        Dim IdPresupuesto As Integer = 0

        'Cargo el detalle de la devolucion en un Tabla para pasarla por un campo al SP
        dt.Columns.Add("id_Detalle", Type.GetType("System.Int64"))
        dt.Columns.Add("id_Producto", Type.GetType("System.Int32"))
        dt.Columns.Add("Cantidad", Type.GetType("System.Int32"))
        dt.Columns.Add("Precio", Type.GetType("System.Double"))
        dt.Columns.Add("Iva", Type.GetType("System.Double"))
        dt.Columns.Add("Monto", Type.GetType("System.Double"))

        For Each item As Entidades.Presupuesto_Detalle In DetallePresupuesto
            dt.Rows.Add(ClsDatos.ObtenerCalveUnica(Presupuesto.id_Sucursal), item.id_Producto, item.Cantidad, item.Precio, item.Iva, item.Monto)
        Next

        Presupuesto.id_Presupuesto = ClsDatos.ObtenerCalveUnica(Presupuesto.id_Sucursal)
        Presupuesto.FechaEdcion = DateTime.Now

        Try
            cmd.Connection = ClsDatos.ConectarLocal()
            Alta(Presupuesto, cmd, dt)
            ClsDatos.DesconectarLocal()

            If HayInternet Then
                cmd = New SqlCommand()
                cmd.Connection = ClsDatos.ConectarRemoto()
                Alta(Presupuesto, cmd, dt)
                ClsDatos.DesconectarRemoto()
            End If

            'retorno valor
            Return Presupuesto.id_Presupuesto
        Catch ex As Exception
            Return False
        End Try
    End Function

    Private Shared Sub Alta(Presupuesto As Entidades.Presupuesto, ByRef cmd As SqlCommand, dt As DataTable)
        'Cargo y ejecuto el stored.
        cmd.CommandType = CommandType.StoredProcedure
        cmd.CommandText = "sp_Presupuesto_Alta"
        With cmd.Parameters
            .AddWithValue("@id_Presupuesto", Presupuesto.id_Presupuesto)
            .AddWithValue("@id_venta", Presupuesto.id_Venta)
            .AddWithValue("@id_ClienteMayorista", Presupuesto.id_ClienteMayorista)
            .AddWithValue("@id_ClienteMinorista", Presupuesto.id_ClienteMinorista)
            .AddWithValue("@id_Empleado", Presupuesto.id_Empleado)
            .AddWithValue("@id_Encargado", Presupuesto.id_Encargado)
            .AddWithValue("@id_Sucursal", Presupuesto.id_Sucursal)
            .AddWithValue("@id_TipoPago", Presupuesto.id_TipoPago)
            .AddWithValue("@id_TipoVenta", Presupuesto.id_TipoVenta)
            .AddWithValue("@id_ListaPrecio", Presupuesto.id_ListaPrecio)
            .AddWithValue("@id_Tarjeta", Presupuesto.id_Tarjeta)
            .AddWithValue("@CantidadCuotas", Presupuesto.CantidadCuotas)
            .AddWithValue("@PrecioTotal", Presupuesto.Total)
            .AddWithValue("@Subtotal", Presupuesto.SubTotal)
            .AddWithValue("@Descuento", Presupuesto.Descuento)
            .AddWithValue("@CostoFinanciero", Presupuesto.CostoFinanciero)
            .AddWithValue("@FechaEdicion", Presupuesto.FechaEdcion)
        End With

        'Declaro el tipo de dato para el detalle de la venta
        Dim param = cmd.Parameters.AddWithValue("@Detalle", dt)
        param.SqlDbType = SqlDbType.Structured
        param.TypeName = "dbo.VENTA_DETALLE_TYPE"

        cmd.ExecuteNonQuery()
    End Sub

    'Funcion para consultar un detalle de un presupuesto
    Public Function TraerDetalle(ByVal presupuestoID As Int64) As List(Of Presupuesto_Detalle)
        'Declaro variables
        Dim cmd As SqlCommand = New SqlCommand()
        Dim dsNotaPedidos As DataSet
        Dim respuesta As List(Of Presupuesto_Detalle) = New List(Of Presupuesto_Detalle)()
        Dim HayInternet As Boolean = Funciones.HayInternet

        'Conecto a la bdd.
        If (HayInternet) Then
            dsNotaPedidos = ClsDatos.ConsultarBaseRemoto("execute sp_Presupuesto_Consulta_Detalle @PresupuestoId=" & presupuestoID)
        Else
            dsNotaPedidos = ClsDatos.ConsultarBaseLocal("execute sp_Presupuesto_Consulta_Detalle @PresupuestoId=" & presupuestoID)
        End If

        If dsNotaPedidos.Tables(0).Rows.Count > 0 Then
            For Each row As DataRow In dsNotaPedidos.Tables(0).Rows
                respuesta.Add(GetNotaPedidoDetalleFromRow(row))
            Next
        End If

        'retorno valor
        Return respuesta
    End Function

    Public Function TraerPresupuestos(ByVal SucursalId As Integer) As List(Of Presupuesto)
        'Declaro variables
        Dim cmd As SqlCommand = New SqlCommand()
        Dim dsNotaPedidos As DataSet
        Dim respuesta As List(Of Presupuesto) = New List(Of Presupuesto)()
        Dim HayInternet As Boolean = Funciones.HayInternet

        'Conecto a la bdd.
        If (HayInternet) Then
            dsNotaPedidos = ClsDatos.ConsultarBaseRemoto("execute sp_Presupuesto_Consulta_Sucursal @SucursalId=" & SucursalId)
        Else
            dsNotaPedidos = ClsDatos.ConsultarBaseLocal("execute sp_Presupuesto_Consulta_Sucursal @SucursalId=" & SucursalId)
        End If

        If dsNotaPedidos.Tables(0).Rows.Count > 0 Then
            For Each row As DataRow In dsNotaPedidos.Tables(0).Rows
                respuesta.Add(GetPresupuestoFromRow(row))
            Next
        End If

        'retorno valor
        Return respuesta
    End Function

    Public Sub Anula(presupuesto As Presupuesto)
        'Declaro variables
        Dim cmd As New SqlCommand
        Dim HayInternet As Boolean = Funciones.HayInternet
        Dim IdPresupuesto As Integer = 0

        If (presupuesto.DescripcionAnulado = "") Then
            presupuesto.DescripcionAnulado = "No se ingreso el motivo."
        End If

        presupuesto.FechaEdcion = DateTime.Now

        cmd.Connection = ClsDatos.ConectarLocal()
        Anular(presupuesto, cmd)
        ClsDatos.DesconectarLocal()

        If HayInternet Then
            cmd = New SqlCommand()
            cmd.Connection = ClsDatos.ConectarRemoto()
            Anular(presupuesto, cmd)
            ClsDatos.DesconectarRemoto()
        End If


    End Sub

    Private Shared Sub Anular(Presupuesto As Entidades.Presupuesto, ByRef cmd As SqlCommand)
        'Cargo y ejecuto el stored.
        cmd.CommandType = CommandType.StoredProcedure
        cmd.CommandText = "sp_Presupuesto_Anular"
        With cmd.Parameters
            .AddWithValue("@id_Presupuesto", Presupuesto.id_Presupuesto)
            .AddWithValue("@Descripcion", Presupuesto.DescripcionAnulado)
            .AddWithValue("@FechaEdicion", Presupuesto.FechaEdcion)
        End With
        cmd.ExecuteNonQuery()
    End Sub

    Private Function GetPresupuestoFromRow(row As DataRow) As Presupuesto
        Dim presupesuto As Presupuesto = New Presupuesto()
        presupesuto.Anulado = If(row.Item("Anulado") Is DBNull.Value, False, row.Item("Anulado"))
        presupesuto.DescripcionAnulado = If(row.Item("DescripcionAnulado") Is DBNull.Value, String.Empty, row.Item("DescripcionAnulado"))
        presupesuto.Descuento = If(row.Item("Descuento") Is DBNull.Value, 0, row.Item("Descuento"))
        presupesuto.CostoFinanciero = If(row.Item("CostoFinanciero") Is DBNull.Value, 0, row.Item("CostoFinanciero"))
        presupesuto.VendedorNombreyApellido = If(row.Item("EmpleadoNombreyApellido") Is DBNull.Value, String.Empty, row.Item("EmpleadoNombreyApellido"))
        presupesuto.EncargadoNombreyApellido = If(row.Item("EncargadoNombreyApellido") Is DBNull.Value, String.Empty, row.Item("EncargadoNombreyApellido"))
        presupesuto.Fecha = If(row.Item("Fecha") Is DBNull.Value, Date.MinValue, row.Item("Fecha"))
        presupesuto.FechaAnulado = If(row.Item("FechaAnulado") Is DBNull.Value, Date.MinValue, row.Item("FechaAnulado"))
        presupesuto.id_ClienteMayorista = If(row.Item("id_ClienteMayorista") Is DBNull.Value, 0, row.Item("id_ClienteMayorista"))
        presupesuto.id_ClienteMinorista = If(row.Item("id_ClienteMinorista") Is DBNull.Value, 0, row.Item("id_ClienteMinorista"))
        presupesuto.id_Empleado = If(row.Item("id_Empleado") Is DBNull.Value, 0, row.Item("id_Empleado"))
        presupesuto.id_Encargado = If(row.Item("id_Encargado") Is DBNull.Value, 0, row.Item("id_Encargado"))
        presupesuto.id_ListaPrecio = If(row.Item("id_ListaPrecio") Is DBNull.Value, 0, row.Item("id_ListaPrecio"))
        presupesuto.id_Presupuesto = If(row.Item("id_Presupuesto") Is DBNull.Value, 0, row.Item("id_Presupuesto"))
        presupesuto.id_Sucursal = If(row.Item("id_Sucursal") Is DBNull.Value, 0, row.Item("id_Sucursal"))
        presupesuto.id_Tarjeta = If(row.Item("id_Tarjeta") Is DBNull.Value, 0, row.Item("id_Tarjeta"))
        presupesuto.CantidadCuotas = If(row.Item("Cantidad_Cuotas") Is DBNull.Value, 0, row.Item("Cantidad_Cuotas"))
        presupesuto.NombreSucursal = If(row.Item("NombreSucursal") Is DBNull.Value, String.Empty, row.Item("NombreSucursal"))
        presupesuto.id_TipoPago = If(row.Item("id_TipoVenta") Is DBNull.Value, 0, row.Item("id_TipoVenta"))
        presupesuto.DescripcionTipoPago = If(row.Item("DescripcionTipoPago") Is DBNull.Value, String.Empty, row.Item("DescripcionTipoPago"))
        presupesuto.id_TipoVenta = If(row.Item("id_TipoVenta") Is DBNull.Value, 0, row.Item("id_TipoVenta"))
        presupesuto.RazonSocialClienteMayorista = If(row.Item("RazonSocialCliente") Is DBNull.Value, String.Empty, row.Item("RazonSocialCliente"))
        presupesuto.SubTotal = If(row.Item("SubTotal") Is DBNull.Value, 0, row.Item("SubTotal"))
        presupesuto.Total = If(row.Item("PrecioTotal") Is DBNull.Value, 0, row.Item("PrecioTotal"))

        Return presupesuto
    End Function

    Private Function GetNotaPedidoDetalleFromRow(row As DataRow) As Presupuesto_Detalle
        Dim presupuestoDetalle As Presupuesto_Detalle = New Presupuesto_Detalle()

        presupuestoDetalle.Cantidad = row.Item("Cantidad")
        presupuestoDetalle.id_Detalle = row.Item("id_Detalle")
        presupuestoDetalle.id_Producto = row.Item("id_Producto")
        presupuestoDetalle.CodigoProducto = row.Item("CodigoProducto")
        presupuestoDetalle.NombreProducto = row.Item("NombreProducto")
        presupuestoDetalle.id_Presupuesto = row.Item("id_Presupuesto")
        presupuestoDetalle.Precio = row.Item("Precio")
        presupuestoDetalle.Iva = row.Item("Iva")
        presupuestoDetalle.Monto = row.Item("Monto")

        Return presupuestoDetalle
    End Function

    Public Function TraerPresupuestoPorVenta(idVenta As Int64) As Presupuesto
        'Declaro variables
        Dim cmd As SqlCommand = New SqlCommand()
        Dim dsNotaPedidos As DataSet
        Dim respuesta As Presupuesto = New Presupuesto()
        Dim HayInternet As Boolean = Funciones.HayInternet

        'Conecto a la bdd.
        If (HayInternet) Then
            dsNotaPedidos = ClsDatos.ConsultarBaseRemoto("execute sp_Presupuesto_Consulta_venta @VentaId=" & idVenta)
        Else
            dsNotaPedidos = ClsDatos.ConsultarBaseLocal("execute sp_Presupuesto_Consulta_venta @VentaId=" & idVenta)
        End If

        If dsNotaPedidos.Tables(0).Rows.Count > 0 Then
            For Each row As DataRow In dsNotaPedidos.Tables(0).Rows
                respuesta = GetPresupuestoFromRow(dsNotaPedidos.Tables(0).Rows(0))
            Next
        End If

        'retorno valor
        Return respuesta
    End Function
End Class
