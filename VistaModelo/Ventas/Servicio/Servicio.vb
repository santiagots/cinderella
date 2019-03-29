Imports Common.Core.Enum
Imports Common.Core.Interfaces
Imports Common.Data
Imports Common.Data.Repository
Imports Common.Service.Facturar
Imports Ventas.Core.Enum
Imports Ventas.Core.Interfaces
Imports Ventas.Core.Model.BaseAgreggate
Imports Ventas.Core.Model.NotaPedidoAgreggate
Imports Ventas.Core.Model.VentaAggregate
Imports Ventas.Data
Imports Ventas.Data.Repository
Imports Common.Core.ValueObjects

Namespace VistaModelo.Ventas
    Public Class Servicio

        Public Shared Sub ActualizarStock(stocks As List(Of Stock))
            Using context As VentaContext = New VentaContext()
                Dim stockRepository As IStockRepository = New StockRepository(context)
                stockRepository.Actualizar(stocks)
            End Using
        End Sub

        Public Shared Sub ActualizarNotaPedido(notaPedido As NotaPedido)
            Using context As VentaContext = New VentaContext()
                Dim notaPedidoRepository As INotaPedidoRepository = New NotaPedidoRepository(context)
                notaPedidoRepository.Actualizar(notaPedido)
            End Using
        End Sub

        Public Shared Function BuscarClienteMinorista(nombre As String, apellido As String) As IList(Of ClienteMinorista)
            Using context As VentaContext = New VentaContext()
                Dim clienteMinoristaRepository As IClienteMinoristaRepository = New ClienteMinoristaRepository(context)
                Return clienteMinoristaRepository.Obtener(nombre, apellido)
            End Using
        End Function

        Public Shared Function BuscarReserva(entregada As Boolean, nombre As String, fechaAlta As DateTime?, fechaRetiro As DateTime?, metodoEntrega As ReservaMetodoEntrega?) As IList(Of Reserva)
            Using context As VentaContext = New VentaContext()
                Dim reservaRepository As IReservaRepository = New ReservaRepository(context)
                Return reservaRepository.Buscar(entregada, nombre, fechaAlta, fechaRetiro, metodoEntrega)
            End Using
        End Function

        Public Shared Function CantidadVentas(idSucursal As Integer) As Integer
            Using context As VentaContext = New VentaContext()
                Dim ventaRepository As IVentaRepository = New VentaRepository(context)
                Return ventaRepository.Cantidad(idSucursal)
            End Using
        End Function

        Friend Shared Sub GuardarVenta(ventaModel As Venta)
            Using context As VentaContext = New VentaContext()
                Dim ventaRepository As IVentaRepository = New VentaRepository(context)
                ventaRepository.Guardar(ventaModel)
            End Using
        End Sub

        Friend Shared Sub GuardarNotaPedido(notaPedidoModel As NotaPedido)
            Using context As VentaContext = New VentaContext()
                Dim notaPedidoRepository As INotaPedidoRepository = New NotaPedidoRepository(context)
                notaPedidoRepository.Guardar(notaPedidoModel)
            End Using
        End Sub

        Friend Shared Sub GuardarReserva(reservaModel As Reserva)
            Using context As VentaContext = New VentaContext()
                Dim reservaRepository As IReservaRepository = New ReservaRepository(context)
                reservaRepository.Guardar(reservaModel)
            End Using
        End Sub

        Friend Shared Function EliminarReserva(id As Long) As Object
            Using context As VentaContext = New VentaContext()
                Dim reservaRepository As IReservaRepository = New ReservaRepository(context)
                reservaRepository.Eliminar(id)
            End Using
        End Function

        Public Shared Function ObtenerNotaPedido(estado As NotaPedidoEstado?, tipoCliente As TipoCliente?, tipoPago As TipoPago?, fechaDesde As DateTime, fechaHasta As DateTime, IdVendedor As Integer?, nombreCliente As String) As IList(Of NotaPedido)
            Using context As VentaContext = New VentaContext()
                Dim NotaPedidoRepository As INotaPedidoRepository = New NotaPedidoRepository(context)
                Return NotaPedidoRepository.Obtener(estado, tipoCliente, fechaDesde, fechaHasta, IdVendedor, nombreCliente)
            End Using
        End Function

        Public Shared Function ObtenerEmpleados(tipoEmpleado As TipoEmpleado, idSucursal As Integer) As IList(Of Empleado)

            Dim empleado As IList(Of Empleado) = New List(Of Empleado)
            Using context As VentaContext = New VentaContext()
                Dim empleadoRepository As IEmpleadoRepository = New EmpleadoRepository(context)
                empleado = empleadoRepository.ObtenerPresentes(idSucursal, tipoEmpleado)

                If (empleado.Count = 0) Then
                    empleado = empleadoRepository.ObtenerPorSucursal(idSucursal, tipoEmpleado)
                End If
            End Using

            Return empleado
        End Function

        Public Shared Function ObtenerTarjetas() As IList(Of Tarjeta)
            Dim banco As IList(Of Tarjeta) = New List(Of Tarjeta)
            Using context As VentaContext = New VentaContext()
                Dim bancoRepository As ITarjetaRepository = New TarjetaRepository(context)
                banco = bancoRepository.Obtener()
            End Using

            Return banco
        End Function

        Public Shared Function ObtenerCuotas(idBanco As Integer) As IList(Of CostoFinanciero)
            Dim costoFinanciero As IList(Of CostoFinanciero) = New List(Of CostoFinanciero)
            Using context As VentaContext = New VentaContext()
                Dim bancoRepository As ICostoFinancieroRepository = New CostoFinancieroRepository(context)
                costoFinanciero = bancoRepository.Obtener(idBanco)
            End Using
            Return costoFinanciero
        End Function

        Public Shared Function ObtenerListaPrecio() As IList(Of ListaPrecio)
            Dim listaPrecio As IList(Of ListaPrecio) = New List(Of ListaPrecio)
            Using context As VentaContext = New VentaContext()
                Dim listaPrecioRepository As IListaPrecioRepository = New ListaPrecioRepository(context)
                listaPrecio = listaPrecioRepository.Obtener()
            End Using

            Return listaPrecio
        End Function

        Public Shared Function ObtenerListaProductos() As IList(Of Producto)
            Dim listaProducto As IList(Of Producto) = New List(Of Producto)
            Using context As VentaContext = New VentaContext()
                Dim productoRepository As IProductoRepository = New ProductoRepository(context)
                listaProducto = productoRepository.Obtener()
            End Using

            Return listaProducto
        End Function

        Public Shared Function ObtenerProductoCompleto(idSucursal As Integer, idProducto As Integer) As Producto
            Using context As VentaContext = New VentaContext()
                Dim productoRepository As IProductoRepository = New ProductoRepository(context)
                Return productoRepository.Obtener(idSucursal, idProducto)
            End Using
        End Function

        Friend Shared Function ObtenerClienteMayorista(id As Integer) As Object
            Using context As VentaContext = New VentaContext()
                Dim productoRepository As IClienteMayoristaRepository = New ClienteMayoristaRepository(context)
                Return productoRepository.Obtener(id)
            End Using
        End Function

        Public Shared Function ObtenerSucursal(idSucursal As Integer) As Sucursal
            Using context As VentaContext = New VentaContext()
                Dim sucursalRepository As IRepository(Of Sucursal) = New Repository(Of Sucursal)(context)
                Return sucursalRepository.GetById(idSucursal)
            End Using
        End Function

        Friend Shared Function ObtenerReserva(idReserva As Long) As Object
            Using context As VentaContext = New VentaContext()
                Dim reservaRepository As IReservaRepository = New ReservaRepository(context)
                Return reservaRepository.Obtener(idReserva)
            End Using
        End Function

        Public Shared Function EsFeriado() As Boolean
            Using context As CommonContext = New CommonContext()
                Dim feriadoRepository As IFeriadoRepository = New FeriadoRepository(context)
                Return feriadoRepository.EsFeriado(DateTime.Now)
            End Using
        End Function

        Public Shared Function ObtenerUltimoNumeroFactura(tipoFactura As TipoFactura) As Integer
            Using context As VentaContext = New VentaContext()
                Dim facturaRepository As IFacturaRepository = New FacturaRepository(context)
                Return facturaRepository.ObtenerUltimoNumeroFactura(tipoFactura)
            End Using
        End Function

        Public Shared Function FacturarService(tipoFactura As TipoFactura, tipoCliente As TipoCliente, condicionesIVA As CondicionIVA, pagos As IEnumerable(Of TicketPago), productos As IEnumerable(Of TicketProducto), porcentajeFacturacion As Decimal, nombreYApellido As String, direccion As String, localidad As String, cuit As String) As IList(Of Integer)
            Dim facturar As FacturarService = New FacturarService(tipoFactura)
            Return facturar.ObtenerNumeroFactura(tipoCliente, condicionesIVA, pagos, productos, porcentajeFacturacion, nombreYApellido, direccion, localidad, cuit)
        End Function
    End Class
End Namespace