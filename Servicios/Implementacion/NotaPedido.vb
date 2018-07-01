Imports System.ServiceModel
Imports Entidades

<ServiceBehavior(IncludeExceptionDetailInFaults:=True, UseSynchronizationContext:=False)>
Public Class NotaPedido
    Implements INotaPedido

    Public Delegate Sub NuevaNotaPedidoDelegate(EntNotaPedido As Entidades.NotaPedido, EntConsumidorFinal As Entidades.ConsumidorFinal)
    Public Shared Event onNevaNotaPedidoCompleted As NuevaNotaPedidoDelegate

    Function SetNevaNotaPedido(ByVal EntNotaPedido As EntidadNotaPedido, EntDetalleNotaPedido As List(Of EntidadNotaPedido_Detalle), ByVal EntConsumidorFinal As EntidadConsumidorFinal) As Boolean Implements INotaPedido.SetNevaNotaPedido
        Negocio.Funciones.HayConexionInternet()

        Dim NotaPedidoNegocio As Negocio.NegNotaPedido = New Negocio.NegNotaPedido()
        Dim ClienteNegocio As Negocio.NegClienteMayorista = New Negocio.NegClienteMayorista()

        'Doy de alta el consumidor final y lo relaciono a la nota de pedido
        Dim consumidorFinal As Entidades.ConsumidorFinal = New Entidades.ConsumidorFinal()

        If (EntConsumidorFinal IsNot Nothing) Then
            consumidorFinal.Apellido = EntConsumidorFinal.Apellido
            consumidorFinal.Email = EntConsumidorFinal.Email
            consumidorFinal.Nombre = EntConsumidorFinal.Nombre

            Dim id_ConsumidorFinal As Int64 = ClienteNegocio.AltaClienteConsumidorFinal(consumidorFinal, EntNotaPedido.id_Sucursal)
            EntNotaPedido.Id_ConsumidorFinal = id_ConsumidorFinal
        End If

        Dim detalleNotaPedido As List(Of Entidades.NotaPedido_Detalle) = New List(Of Entidades.NotaPedido_Detalle)()

        For Each det As EntidadNotaPedido_Detalle In EntDetalleNotaPedido
            Dim detalle As Entidades.NotaPedido_Detalle = New Entidades.NotaPedido_Detalle()
            detalle.Cantidad = det.Cantidad
            detalle.id_Detalle = det.id_Detalle
            detalle.id_Producto = det.id_Producto
            'si la venta es minorista
            If (EntNotaPedido.id_TipoVenta = 1) Then
                detalle.Precio = 0
                detalle.Iva = 0
                detalle.Monto = det.Precio
            Else 'si la venta es mayorista
                detalle.Precio = det.Precio
                detalle.Iva = det.Precio * 0.21
                detalle.Monto = detalle.Precio + detalle.Iva
            End If


            detalleNotaPedido.Add(detalle)
        Next

        Dim porcentajeFacturacion As Double = 0

        If (EntNotaPedido.id_TipoVenta = 2) Then
            Dim Cliente As ClienteMayorista = ClienteNegocio.TraerCliente(EntNotaPedido.id_Cliente)
            porcentajeFacturacion = If(Cliente.Lista.HasValue, Cliente.Lista.Value, 0)
        End If

        Dim notaPedido As Entidades.NotaPedido = New Entidades.NotaPedido() With {
        .Fecha = EntNotaPedido.Fecha,
        .id_Cliente = EntNotaPedido.id_Cliente,
        .Id_ConsumidorFinal = EntNotaPedido.Id_ConsumidorFinal,
        .id_Empleado = EntNotaPedido.id_Empleado,
        .id_ListaPrecio = EntNotaPedido.id_ListaPrecio,
        .id_Sucursal = EntNotaPedido.id_Sucursal,
        .id_TipoPago = EntNotaPedido.id_TipoPago,
        .id_TipoVenta = EntNotaPedido.id_TipoVenta,
        .PrecioTotal = EntNotaPedido.PrecioTotal,
        .Vendida = EntNotaPedido.Vendida,
        .PorcentajeDescuento = EntNotaPedido.PorcentajeDescuento,
        .PorcentajeFacturacion = porcentajeFacturacion
        }

        notaPedido.id_NotaPedido = NotaPedidoNegocio.NuevaNotaPedido(notaPedido, detalleNotaPedido, EntNotaPedido.id_Sucursal)

        If (notaPedido.id_NotaPedido > 0) Then
            RaiseEvent onNevaNotaPedidoCompleted(notaPedido, consumidorFinal)
            Return True
        Else
            Return False
        End If
    End Function

End Class
