Imports Common.Core.Interfaces
Imports Common.Data
Imports Common.Data.Repository
Imports Ventas.Core.Enum
Imports Ventas.Core.Interfaces
Imports Ventas.Core.Model.NotaPedidoAgreggate
Imports Ventas.Data
Imports Ventas.Data.Repository
Imports Model = Ventas.Core.Model.VentaAggregate
Imports ModelBase = Ventas.Core.Model.BaseAgreggate

Namespace Formularios.Venta
    Public Class Servicio

        Public Shared Sub ActualizarStock(stocks As List(Of ModelBase.Stock))
            Using context As VentaContext = New VentaContext()
                Dim stockRepository As IStockRepository = New StockRepository(context)
                stockRepository.Actualizar(stocks)
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

        Public Shared Sub GuardarClienteMinorista(clienteMinorista As ModelBase.ClienteMinorista)
            Using context As VentaContext = New VentaContext()
                Dim clienteMinoristaRepository As IClienteMinoristaRepository = New ClienteMinoristaRepository(context)
                clienteMinoristaRepository.Guardar(clienteMinorista)
            End Using
        End Sub

        Friend Shared Sub GuardarReserva(reservaModel As Model.Reserva)
            Using context As VentaContext = New VentaContext()
                Dim reservaRepository As IReservaRepository = New ReservaRepository(context)
                reservaRepository.Guardar(reservaModel)
            End Using
        End Sub

        Public Shared Function ObtenerCantidadNotaPedido(idSucursal As Integer, estados As List(Of NotaPedidoEstado)) As Integer
            Using context As VentaContext = New VentaContext()
                Dim NotaPedidoRepository As INotaPedidoRepository = New NotaPedidoRepository(context)
                Return NotaPedidoRepository.ObtenerCantidad(idSucursal, estados)
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