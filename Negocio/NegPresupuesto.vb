Imports System.Data.SqlClient
Imports Entidades

Public Class NegPresupuesto
    Dim ClsDatos As New Datos.Conexion
    Dim ClsFunciones As New Funciones

    'Funcion que inserta un nuevo registro en la tabla VENTAS.
    Public Function Alta(ByVal Presupuesto As Entidades.Presupuesto, DetallePresupuesto As List(Of Entidades.Presupuesto_Detalle)) As Integer
        'Declaro variables
        Dim cmd As New SqlCommand
        Dim msg As Boolean
        Dim dt As DataTable = New DataTable()
        Dim HayInternet As Boolean = Funciones.HayInternet
        Dim IdPresupuesto As Integer = 0

        'Cargo el detalle de la devolucion en un Tabla para pasarla por un campo al SP
        dt.Columns.Add("id_Producto", Type.GetType("System.Int32"))
        dt.Columns.Add("Cantidad", Type.GetType("System.Int32"))
        dt.Columns.Add("Precio", Type.GetType("System.Double"))
        dt.Columns.Add("Iva", Type.GetType("System.Double"))
        dt.Columns.Add("Monto", Type.GetType("System.Double"))

        For Each item As Entidades.Presupuesto_Detalle In DetallePresupuesto
            dt.Rows.Add(item.id_Producto, item.Cantidad, item.Precio, item.Iva, item.Monto)
        Next

        Try
            cmd.Connection = ClsDatos.ConectarLocal()
            IdPresupuesto = Alta(Presupuesto, cmd, dt)
            ClsDatos.DesconectarLocal()

            If HayInternet Then
                cmd = New SqlCommand()
                cmd.Connection = ClsDatos.ConectarRemoto()
                IdPresupuesto = Alta(Presupuesto, cmd, dt)
                ClsDatos.DesconectarRemoto()
            End If

            'retorno valor
            Return IdPresupuesto
        Catch ex As Exception
            Return False
        End Try
    End Function

    Private Shared Function Alta(Presupuesto As Entidades.Presupuesto, ByRef cmd As SqlCommand, dt As DataTable) As Integer
        'Cargo y ejecuto el stored.
        cmd.CommandType = CommandType.StoredProcedure
        cmd.CommandText = "sp_Presupuesto_Alta"
        With cmd.Parameters
            .AddWithValue("@id_ClienteMayorista", Presupuesto.id_ClienteMayorista)
            .AddWithValue("@id_ClienteMinorista", Presupuesto.id_ClienteMinorista)
            .AddWithValue("@id_Empleado", Presupuesto.id_Empleado)
            .AddWithValue("@id_Encargado", Presupuesto.id_Encargado)
            .AddWithValue("@id_Sucursal", Presupuesto.id_Sucursal)
            .AddWithValue("@id_TipoPago", Presupuesto.id_TipoPago)
            .AddWithValue("@id_TipoVenta", Presupuesto.id_TipoVenta)
            .AddWithValue("@id_ListaPrecio", Presupuesto.id_ListaPrecio)
            .AddWithValue("@PrecioTotal", Presupuesto.Total)
            .AddWithValue("@Subtotal", Presupuesto.SubTotal)
            .AddWithValue("@Descuento", Presupuesto.Descuento)
        End With

        'Declaro el tipo de dato para el detalle de la venta
        Dim param = cmd.Parameters.AddWithValue("@Detalle", dt)
        param.SqlDbType = SqlDbType.Structured
        param.TypeName = "dbo.VENTA_DETALLE_TYPE"

        Dim respuesta As New SqlParameter("@Id_Presupuesto", SqlDbType.Int, 255)
        respuesta.Direction = ParameterDirection.Output
        cmd.Parameters.Add(respuesta)
        cmd.ExecuteNonQuery()

        Return respuesta.Value
    End Function

    'Funcion para consultar un detalle de laa venta.
    Public Function TraerDetalle(ByVal NotaPedidoId As Integer) As List(Of Presupuesto_Detalle)
        'Declaro variables
        Dim cmd As SqlCommand = New SqlCommand()
        Dim dsNotaPedidos As DataSet
        Dim respuesta As List(Of Presupuesto_Detalle) = New List(Of Presupuesto_Detalle)()
        Dim HayInternet As Boolean = Funciones.HayInternet

        'Conecto a la bdd.
        If (HayInternet) Then
            dsNotaPedidos = ClsDatos.ConsultarBaseRemoto("execute sp_Prespuesto_Consulta_Detalle @PresupuestoId=" & NotaPedidoId)
        Else
            dsNotaPedidos = ClsDatos.ConsultarBaseLocal("execute sp_NotaPedido_Consulta_Detalle @PresupuestoId=" & NotaPedidoId)
        End If

        If dsNotaPedidos.Tables(0).Rows.Count > 0 Then
            For Each row As DataRow In dsNotaPedidos.Tables(0).Rows
                respuesta.Add(GetNotaPedidoDetalleFromRow(row))
            Next
        End If

        'retorno valor
        Return respuesta
    End Function

    Private Function GetNotaPedidoDetalleFromRow(row As DataRow) As Presupuesto_Detalle
        Dim presupuestoDetalle As Presupuesto_Detalle = New Presupuesto_Detalle()

        presupuestoDetalle.Cantidad = row.Item("Cantidad")
        presupuestoDetalle.id_Detalle = row.Item("id_Detalle")
        presupuestoDetalle.id_Producto = row.Item("id_Producto")
        presupuestoDetalle.id_Presupuesto = row.Item("id_Presupuesto")
        presupuestoDetalle.Precio = row.Item("Precio")
        presupuestoDetalle.Iva = row.Item("Iva")
        presupuestoDetalle.Monto = row.Item("Monto")

        Return presupuestoDetalle
    End Function
End Class
