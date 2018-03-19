Imports System.ServiceModel

<ServiceBehavior(IncludeExceptionDetailInFaults:=True, UseSynchronizationContext:=False)>
Public Class NotaPedido
    Implements INotaPedido

    Public Delegate Sub NevaNotaPedidoDelegate(EntNotaPedido As Entidades.NotaPedido, EntConsumidorFinal As Entidades.ConsumidorFinal)
    Public Shared Event onNevaNotaPedidoCompleted As NevaNotaPedidoDelegate

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

            Dim id_ConsumidorFinal As Integer = ClienteNegocio.AltaClienteConsumidorFinal(consumidorFinal)
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

        Dim notaPedido As Entidades.NotaPedido = New Entidades.NotaPedido()
        notaPedido.Fecha = EntNotaPedido.Fecha
        notaPedido.id_Cliente = EntNotaPedido.id_Cliente
        notaPedido.Id_ConsumidorFinal = EntNotaPedido.Id_ConsumidorFinal
        notaPedido.id_Empleado = EntNotaPedido.id_Empleado
        notaPedido.id_ListaPrecio = EntNotaPedido.id_ListaPrecio
        notaPedido.id_Sucursal = EntNotaPedido.id_Sucursal
        notaPedido.id_TipoPago = EntNotaPedido.id_TipoPago
        notaPedido.id_TipoVenta = EntNotaPedido.id_TipoVenta
        notaPedido.PrecioTotal = EntNotaPedido.PrecioTotal
        notaPedido.Vendida = EntNotaPedido.Vendida

        notaPedido.id_NotaPedido = NotaPedidoNegocio.NuevaNotaPedido(notaPedido, detalleNotaPedido, EntNotaPedido.id_Sucursal)

        If (notaPedido.id_NotaPedido > 0) Then
            RaiseEvent onNevaNotaPedidoCompleted(notaPedido, consumidorFinal)
            Return True
        Else
            Return False
        End If
    End Function

End Class
