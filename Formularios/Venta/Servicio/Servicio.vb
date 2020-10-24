Imports Common.Core.Enum
Imports Ventas.Core.Interfaces
Imports Model = Ventas.Core.Model.VentaAggregate
Imports Ventas.Data
Imports Ventas.Data.Repository
Imports Ventas.Core.Model.VentaAggregate
Imports Common.Data
Imports Common.Core.Interfaces
Imports Ventas.Core.Enum
Imports ModelBase = Ventas.Core.Model.BaseAgreggate
Imports Common.Data.Repository
Imports Ventas.Core.Model.NotaPedidoAgreggate
Imports Common.Core.Model
Imports Common.Core.Exceptions

Namespace Formularios.Venta
    Public Class Servicio
        Public Shared Function BuscarVenta(idSucursal As Integer, numeroFacturaDesde As Integer?, numeroFacturaHasta As Integer?, montoDesde As Decimal?, montoHasta As Decimal?, fechaDesde As DateTime?, fechaHasta As DateTime?, anulado As Boolean?, tiposFacturas As IEnumerable(Of TipoFactura), tiposPagos As IEnumerable(Of TipoPago), tiposClientes As IEnumerable(Of TipoCliente)) As IEnumerable(Of Model.Venta)
            Using context As VentaContext = New VentaContext()
                Dim ventaRepository As IVentaRepository = New VentaRepository(context)
                Return ventaRepository.Buscar(idSucursal, numeroFacturaDesde, numeroFacturaHasta, montoDesde, montoHasta, fechaDesde, fechaHasta, anulado, tiposFacturas, tiposPagos, tiposClientes)
            End Using
        End Function

        Public Shared Sub ActualizarStock(stocks As List(Of ModelBase.Stock))
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

        Public Shared Function BuscarClienteMinorista(nombre As String, apellido As String) As IList(Of ModelBase.ClienteMinorista)
            Using context As VentaContext = New VentaContext()
                Dim clienteMinoristaRepository As IClienteMinoristaRepository = New ClienteMinoristaRepository(context)
                Return clienteMinoristaRepository.Obtener(nombre, apellido)
            End Using
        End Function

        Public Shared Function CantidadVentas(idSucursal As Integer) As Integer
            Using context As VentaContext = New VentaContext()
                Dim ventaRepository As IVentaRepository = New VentaRepository(context)
                Return ventaRepository.Cantidad(idSucursal)
            End Using
        End Function

        Friend Shared Sub GuardarVenta(ventaModel As Model.Venta)
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

        Public Shared Sub GuardarClienteMinorista(clienteMinorista As ModelBase.ClienteMinorista)
            Using context As VentaContext = New VentaContext()
                Dim clienteMinoristaRepository As IClienteMinoristaRepository = New ClienteMinoristaRepository(context)
                clienteMinoristaRepository.Guardar(clienteMinorista)
            End Using
        End Sub

        Friend Shared Function ObtenerTotalVentas(idSucursal As Integer, fecha As DateTime, facturado As Boolean?, tipoPago As TipoPago?, tipoCliente As TipoCliente?) As Decimal
            Using context As VentaContext = New VentaContext()
                Dim ventaRepository As IVentaRepository = New VentaRepository(context)
                Return ventaRepository.ObtenerTotal(idSucursal, fecha, facturado, tipoPago, tipoCliente)
            End Using
        End Function

        Friend Shared Function ObtenerTotalVentas(idSucursal As Integer, fechaDesde As DateTime, fechaHasta As DateTime, facturado As Boolean?, tipoPago As TipoPago?, tipoCliente As TipoCliente?) As Decimal
            Using context As VentaContext = New VentaContext()
                Dim ventaRepository As IVentaRepository = New VentaRepository(context)
                Return ventaRepository.ObtenerTotal(idSucursal, fechaDesde, fechaHasta, facturado, tipoPago, tipoCliente)
            End Using
        End Function

        Friend Shared Sub GuardarReserva(reservaModel As Model.Reserva)
            Using context As VentaContext = New VentaContext()
                Dim reservaRepository As IReservaRepository = New ReservaRepository(context)
                reservaRepository.Guardar(reservaModel)
            End Using
        End Sub

        Public Shared Function ObtenerCantidadNotaPedido(idSucursal As Integer, estado As NotaPedidoEstado?) As Integer
            Using context As VentaContext = New VentaContext()
                Dim NotaPedidoRepository As INotaPedidoRepository = New NotaPedidoRepository(context)
                Return NotaPedidoRepository.ObtenerCantidad(idSucursal, estado)
            End Using
        End Function

        Public Shared Function ObtenerListaProductos() As IList(Of ModelBase.Producto)
            Dim listaProducto As IList(Of ModelBase.Producto) = New List(Of ModelBase.Producto)
            Using context As VentaContext = New VentaContext()
                Dim productoRepository As IProductoRepository = New ProductoRepository(context)
                listaProducto = productoRepository.Obtener()
            End Using

            Return listaProducto
        End Function

        Public Shared Function ObtenerProductoCompleto(idSucursal As Integer, idProducto As Integer) As ModelBase.Producto
            Using context As VentaContext = New VentaContext()
                Dim productoRepository As IProductoRepository = New ProductoRepository(context)
                Return productoRepository.Obtener(idSucursal, idProducto)
            End Using
        End Function

        Public Shared Function EsFeriado() As Boolean
            Using context As CommonContext = New CommonContext()
                Dim feriadoRepository As IFeriadoRepository = New FeriadoRepository(context)
                Return feriadoRepository.EsFeriado(DateTime.Now)
            End Using
        End Function
    End Class
End Namespace