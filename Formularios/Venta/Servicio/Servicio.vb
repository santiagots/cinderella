﻿Imports Common.Core.Enum
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

        Public Shared Function ObtenerSucursal(idSucursal As Integer) As ModelBase.Sucursal
            Using context As VentaContext = New VentaContext()
                Dim sucursalRepository As IRepository(Of ModelBase.Sucursal) = New Repository(Of ModelBase.Sucursal)(context)
                Return sucursalRepository.GetById(idSucursal)
            End Using
        End Function

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

        Public Shared Function ObtenerNotaPedido(idSucursal As Integer, estado As NotaPedidoEstado?, tipoCliente As TipoCliente?, tipoPago As TipoPago?, fechaDesde As DateTime, fechaHasta As DateTime, IdVendedor As Integer?, nombreCliente As String) As IList(Of NotaPedido)
            Using context As VentaContext = New VentaContext()
                Dim NotaPedidoRepository As INotaPedidoRepository = New NotaPedidoRepository(context)
                Return NotaPedidoRepository.Obtener(idSucursal, estado, tipoCliente, fechaDesde, fechaHasta, IdVendedor, nombreCliente)
            End Using
        End Function

        Public Shared Function ObtenerCantidadNotaPedido(idSucursal As Integer, estado As NotaPedidoEstado?) As Integer
            Using context As VentaContext = New VentaContext()
                Dim NotaPedidoRepository As INotaPedidoRepository = New NotaPedidoRepository(context)
                Return NotaPedidoRepository.ObtenerCantidad(idSucursal, estado)
            End Using
        End Function

        Public Shared Function ObtenerEmpleados(tipoEmpleado As TipoEmpleado, idSucursal As Integer) As IList(Of ModelBase.Empleado)

            Dim empleado As IList(Of ModelBase.Empleado) = New List(Of ModelBase.Empleado)
            Using context As VentaContext = New VentaContext()
                Dim empleadoRepository As IEmpleadoRepository = New EmpleadoRepository(context)
                empleado = empleadoRepository.ObtenerPresentes(idSucursal, tipoEmpleado)

                If (empleado.Count = 0) Then
                    empleado = empleadoRepository.ObtenerPorSucursal(idSucursal, tipoEmpleado)
                End If

                If (empleado.Count = 0) Then
                    Throw New NegocioException($"La sucursal no tiene configurado un {tipoEmpleado.ToString()}. Por favor, registre un {tipoEmpleado.ToString()} en el menú de empleados o contacte al administrador.")
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