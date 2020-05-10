Imports System.ComponentModel
Imports System.Threading.Tasks
Imports Model = Ventas.Core.Model.VentaAggregate
Imports Ventas.Core.Model.VentaAggregate
Imports Enums = Common.Core.Enum
Imports Common.Core.Extension
Imports Common.Core.Exceptions
Imports Ventas.Core.Model.ValueObjects
Imports ModelBase = Ventas.Core.Model.BaseAgreggate
Imports AutoMapper
Imports Ventas.Core.Model.NotaPedidoAgreggate
Imports Common.Core.Enum
Imports SistemaCinderella.Formularios.Reserva
Imports Common.Core.Model
Imports SistemaCinderella.Formularios.Facturacion
Imports SistemaCinderella.Comunes

Namespace Formularios.Venta
    Public Class frmVentasViewModel
        Inherits Comunes.Common

        Public Delegate Sub CargarProductoNombreyCodigoDelegate(nombreCodigoProductos As List(Of String))
        Public Delegate Function StockInsuficienteDelegate(idProducto As Integer, codigoProducto As String, ByRef stockCargado As Integer) As Boolean
        Public Delegate Sub FacturarDelegate(facturarViewModel As frmFacturarViewModel)
        Public Delegate Function FacturarDelegateCallBackAsync(facturar As Boolean, venta As Model.Venta) As Task
        Public Delegate Function FinalizarDelegateAsync() As Task
        Public Delegate Sub FinalizarDelegate()

        Private CargarProductoNombreyCodigoEvent As CargarProductoNombreyCodigoDelegate
        Private StockInsuficienteEvent As StockInsuficienteDelegate
        Private FacturarEvent As FacturarDelegate
        Private FacturarCallBackEvent As FacturarDelegateCallBackAsync
        Private FinalizarVentaEvent As FinalizarDelegate
        Private FinalizarNotaPedidoEvent As FinalizarDelegateAsync
        Private VentaModel As Model.Venta
        Private SucursalModel As ModelBase.Sucursal
        Private ReservaModel As Model.Reserva
        Private NotaPedidoModel As NotaPedido
        Private ReadOnly IdListaPrecioMinorista As Integer
        Private ReadOnly IdListaPrecioMayorista As Integer

        Private Productos As List(Of ModelBase.Producto) = New List(Of ModelBase.Producto)

        Public Property TipoClienteSeleccionado As Enums.TipoCliente

        Public ReadOnly Property TipoCliente As BindingList(Of Enums.TipoCliente)

        Private _EncargadoSeleccionado As ModelBase.Empleado
        Public Property EncargadoSeleccionado As ModelBase.Empleado
            Get
                Return _EncargadoSeleccionado
            End Get
            Set(value As ModelBase.Empleado)
                _EncargadoSeleccionado = value
                VentaModel.AgregarEncargado(value)
            End Set
        End Property

        Public ReadOnly Property Encargados As BindingList(Of ModelBase.Empleado)

        Private _VendedoresSeleccionado As ModelBase.Empleado
        Public Property VendedoresSeleccionado As ModelBase.Empleado
            Get
                Return _VendedoresSeleccionado
            End Get
            Set(value As ModelBase.Empleado)
                _VendedoresSeleccionado = value
                VentaModel.AgregarVendedor(value)
            End Set
        End Property
        Public ReadOnly Property Vendedores As BindingList(Of ModelBase.Empleado)

        Public Property IdClienteMayorista As Integer

        Public Property NombreClienteMayorista As String

        Public Property PorcentajeFacturacion As Decimal

        Public Property PorcentajeBonificacion As Decimal

        Public Property NombreCodigoProductoBusqueda As String

        Public Property ListaPrecioSeleccionado As Integer

        Private _ListaPrecio As BindingList(Of ListaPrecio)
        Public ReadOnly Property ListaPrecio As BindingList(Of ListaPrecio)
            Get
                Return _ListaPrecio
            End Get
        End Property

        Public ReadOnly Property VentaItems As BindingList(Of VentaItemViewModel)
            Get
                Return New BindingList(Of VentaItemViewModel)(Mapper.Map(Of List(Of VentaItemViewModel))(VentaModel.VentaItems))
            End Get
        End Property

        Public ReadOnly Property TotalVentaItem As BindingList(Of VentaItemViewModel)
            Get
                Dim VentaItemViewModel As VentaItemViewModel = New VentaItemViewModel() With {
                    .Nombre = "Total",
                    .Cantidad = VentaModel.CantidadTotal,
                    .Iva = VentaModel.MontoTotal.Iva,
                    .Monto = VentaModel.MontoTotal.Valor,
                    .Total = VentaModel.MontoTotal.toDecimal()
                    }
                Dim list As BindingList(Of VentaItemViewModel) = New BindingList(Of VentaItemViewModel)

                list.Add(VentaItemViewModel)
                Return list
            End Get
        End Property

        Public ReadOnly Property Pagos As BindingList(Of PagoViewModel)
            Get
                Return New BindingList(Of PagoViewModel)(
                    Mapper.Map(Of List(Of PagoViewModel))(VentaModel.Pagos))
            End Get
        End Property

        Public ReadOnly Property TotalPago As BindingList(Of PagoViewModel)
            Get
                Dim PagoViewModel As PagoViewModel = New PagoViewModel() With {
                    .CFT = VentaModel.PagoTotal.CFT,
                    .IVA = VentaModel.PagoTotal.IVA,
                    .Descuento = VentaModel.PagoTotal.Descuento,
                    .Monto = VentaModel.PagoTotal.Monto,
                    .Total = VentaModel.PagoTotal.Total,
                    .Resto = VentaModel.Pagos.Sum(Function(x) x.MontoRestante),
                    .Descripcion = "Total"
                    }
                Dim list As BindingList(Of PagoViewModel) = New BindingList(Of PagoViewModel)
                list.Add(PagoViewModel)

                Return list
            End Get
        End Property

        Public Property FormaPagoSeleccionado As Enums.TipoPago
        Public ReadOnly Property FormaPago As BindingList(Of Enums.TipoPago)

        Public Property TarjetaSeleccionada As Tarjeta
        Public ReadOnly Property Tarjeta As BindingList(Of KeyValuePair(Of Tarjeta, String))

        Public Property CuotaSeleccionado As CostoFinanciero
        Public ReadOnly Property Cuota As BindingList(Of KeyValuePair(Of CostoFinanciero, String))

        Public Property CuotaCft As Decimal

        Private _Subtotal As Decimal
        Public Property Subtotal As Decimal
            Get
                Return _Subtotal
            End Get
            Set(ByVal value As Decimal)
                _Subtotal = value
                CalcularPagoDesdeSubtotal(_Subtotal)
            End Set
        End Property

        Public Property Descuento As Decimal

        Public Property Cft As Decimal

        Public Property Iva As Decimal

        Private _Total As Decimal
        Public Property Total As Decimal
            Get
                Return _Total
            End Get
            Set(ByVal value As Decimal)
                _Total = value
                CalcularPagoDesdeTotal(_Total)
            End Set
        End Property

        Public ReadOnly Property HabilitarVenta As Boolean
            Get
                Return VentaModel.EstaPaga And TotalPago.First.Resto = 0 And ((TipoClienteSeleccionado = Enums.TipoCliente.Mayorista AndAlso IdClienteMayorista > 0) OrElse TipoClienteSeleccionado = Enums.TipoCliente.Minorista)
            End Get
        End Property

        Dim _Visible As Boolean
        Public Property Visible As Boolean
            Set(value As Boolean)
                _Visible = value
                NotifyPropertyChanged(NameOf(Me.Visible))
            End Set
            Get
                Return _Visible
            End Get
        End Property

        Public ReadOnly Property NoEstaPaga As Boolean
            Get
                Return Not VentaModel.EstaPaga
            End Get
        End Property

        Public ReadOnly Property IdSucursal As Integer
            Get
                Return VentaModel.IdSucursal
            End Get
        End Property

        Public Sub New(IdSucursal As Integer, tipoCliente As Enums.TipoCliente, idListaPrecioMinorista As Integer, idListaPrecioMayorista As Integer, cargarProductoNombreyCodigo As CargarProductoNombreyCodigoDelegate, stockInsuficiente As StockInsuficienteDelegate, facturar As FacturarDelegate, finalizarVentaEvent As FinalizarDelegate, finalizarNotaPedidoEvent As FinalizarDelegateAsync)
            Me.IdListaPrecioMinorista = idListaPrecioMinorista
            Me.IdListaPrecioMayorista = idListaPrecioMayorista
            Me.CargarProductoNombreyCodigoEvent = cargarProductoNombreyCodigo
            Me.StockInsuficienteEvent = stockInsuficiente
            Me.FacturarEvent = facturar
            Me.FacturarCallBackEvent = AddressOf FacturarAsync
            Me.FinalizarVentaEvent = finalizarVentaEvent
            Me.FinalizarNotaPedidoEvent = finalizarNotaPedidoEvent

            Inicializar(New Model.Venta(IdSucursal), tipoCliente, idListaPrecioMinorista, idListaPrecioMayorista)
        End Sub

        Friend Sub CargarNotaPedido(notaPedido As NotaPedido)

            Me.NotaPedidoModel = notaPedido

            CargarDatosBasicosTransaccion(notaPedido)

            If (notaPedido.TipoCliente = Enums.TipoCliente.Mayorista) Then
                PorcentajeBonificacion = notaPedido.NotaPedidoItems?.First().PorcentajeBonificacion
            End If

            CargarProductosEnVenta(notaPedido.NotaPedidoItems.Cast(Of ModelBase.TransaccionItem)().ToList(), notaPedido.TipoCliente)

            CalcularPendientePago()

            NotifyPropertyChanged(NameOf(Me.Pagos))
            NotifyPropertyChanged(NameOf(Me.TotalPago))
        End Sub

        Friend Sub CargarReserva(reserva As Model.Reserva)
            ReservaModel = reserva
            ReservaModel.Entregar(VentaModel)
            CargarDatosBasicosTransaccion(ReservaModel.VentaReserva)
            CargarProductosEnVenta(ReservaModel.VentaReserva.VentaItems.Cast(Of ModelBase.TransaccionItem)().ToList(), ReservaModel.VentaReserva.TipoCliente)

            For Each pago As Pago In reserva.VentaReserva.Pagos
                VentaModel.AgregaPago(pago.MontoPago.Monto, pago.MontoPago.Monto, 0, 0, TipoPago.Bonificacion, pago.PorcentajeRecargo, ReservaModel.VentaReserva.PorcentajeFacturacion, ReservaModel.VentaReserva.TipoCliente, pago.Tarjeta, pago.NumeroCuotas, False)
            Next

            CalcularPendientePago()

            NotifyPropertyChanged(NameOf(Me.Pagos))
            NotifyPropertyChanged(NameOf(Me.TotalPago))
        End Sub

        Private Sub CargarProductosEnVenta(transaccionItems As List(Of ModelBase.TransaccionItem), tipoCliente As TipoCliente)
            Dim montoProductoMinorista As MontoProducto = New MontoProducto(0, 0)
            Dim porcentejeBonificacionMinorista As Decimal = 0

            Dim montoProductoMayorista As MontoProducto
            Dim porcentejeBonificacionMayorista As Decimal

            For Each transaccionItem As ModelBase.TransaccionItem In transaccionItems
                Dim producto As ModelBase.Producto = Productos.FirstOrDefault(Function(x) x.Codigo.ToUpper() = transaccionItem.Producto.Codigo.ToUpper())
                producto = GuardarProductoCompletoEnListaDeProductos(producto)

                If tipoCliente = TipoCliente.Minorista Then
                    montoProductoMinorista = transaccionItem.MontoProducto
                    porcentejeBonificacionMinorista = transaccionItem.PorcentajeBonificacion

                    montoProductoMayorista = producto.ObtenerMonto(IdListaPrecioMayorista, Enums.TipoCliente.Mayorista, 1)
                    porcentejeBonificacionMayorista = producto.ObtenerBonificacion(IdListaPrecioMayorista, Enums.TipoCliente.Mayorista)
                Else
                    montoProductoMinorista = producto.ObtenerMonto(IdListaPrecioMinorista, Enums.TipoCliente.Minorista, 1)
                    porcentejeBonificacionMinorista = producto.ObtenerBonificacion(IdListaPrecioMinorista, Enums.TipoCliente.Minorista)

                    montoProductoMayorista = transaccionItem.MontoProducto
                    porcentejeBonificacionMayorista = transaccionItem.PorcentajeBonificacion
                End If

                VentaModel.AgregaVentaItem(producto,
                                           transaccionItem.MontoProducto.Valor,
                                           transaccionItem.Cantidad,
                                           False,
                                           transaccionItem.PorcentajeBonificacion,
                                           PorcentajeFacturacion,
                                           tipoCliente,
                                           montoProductoMinorista.Valor,
                                           porcentejeBonificacionMinorista,
                                           montoProductoMayorista.Valor,
                                           porcentejeBonificacionMayorista)
            Next

            NotifyPropertyChanged(NameOf(Me.VentaItems))
            NotifyPropertyChanged(NameOf(Me.TotalVentaItem))
        End Sub

        Private Sub CargarDatosBasicosTransaccion(venta As ModelBase.Transaccion)
            TipoClienteSeleccionado = venta.TipoCliente
            PorcentajeFacturacion = venta.PorcentajeFacturacion
            EncargadoSeleccionado = If(venta.IdEncargado > 0, venta.Encargado, Encargados.First())
            VendedoresSeleccionado = venta.Vendedor
            If (venta.TipoCliente = Enums.TipoCliente.Mayorista) Then
                IdClienteMayorista = venta.IdClienteMayorista
                NombreClienteMayorista = venta.ClienteMayorista.RazonSocial

                VentaModel.ActualizarClienteMayorista(IdClienteMayorista)
            End If
            NotifyPropertyChanged(NameOf(Me.PorcentajeFacturacion))
        End Sub

        Friend Sub ConfigurarVentaParaClienteMayorista()
            CargarFormaPago(New List(Of Enums.TipoPago)() From {Enums.TipoPago.Efectivo, Enums.TipoPago.Cheque, Enums.TipoPago.Deposito})
            VentaModel.ModificarTipoCliente(TipoClienteSeleccionado)
            CalcularPendientePago()
        End Sub

        Friend Sub ConfigurarVentaParaClienteMinorista()
            CargarFormaPago(New List(Of Enums.TipoPago)() From {Enums.TipoPago.Efectivo, Enums.TipoPago.TarjetaCrédito, Enums.TipoPago.TarjetaDébito})
            VentaModel.ModificarTipoCliente(TipoClienteSeleccionado)
            CalcularPendientePago()
            QuitarClienteMayorista()
        End Sub

        Friend Async Function ReservaAsyn() As Task
            Dim ventaDetalleViewModel As VentaDetalleViewModel = Mapper.Map(Of VentaDetalleViewModel)(VentaModel)
            ventaDetalleViewModel.Sucursal = SucursalModel.Nombre

            Dim frmReservaViewModel As frmReservaViewModel = New frmReservaViewModel(ventaDetalleViewModel)

            If (TipoClienteSeleccionado = Enums.TipoCliente.Mayorista) Then
                Dim clienteMayorista As ClienteMayorista = Await Task.Run(Function() Comunes.Servicio.ObtenerClienteMayorista(IdClienteMayorista))
                frmReservaViewModel.ReservaDetalle.Nombre = clienteMayorista.RazonSocial
                frmReservaViewModel.ReservaDetalle.Apellido = " "
                frmReservaViewModel.ReservaDetalle.Telefono = clienteMayorista?.DomicilioFacturacion?.Telefono
                frmReservaViewModel.ReservaDetalle.Direccion = clienteMayorista?.DomicilioFacturacion?.Direccion
                frmReservaViewModel.ReservaDetalle.Email = clienteMayorista?.DomicilioFacturacion?.Email
            End If


            Dim frmReserva As frmReserva = New frmReserva(frmReservaViewModel)
            If (frmReserva.ShowDialog() = DialogResult.OK) Then
                Await FinalizarVentaAsyn(True)

                ReservaModel = New Model.Reserva(
                                     IdSucursal,
                                     frmReserva.FrmReservaViewModel.ReservaDetalle.Nombre,
                                     frmReserva.FrmReservaViewModel.ReservaDetalle.Apellido,
                                     frmReserva.FrmReservaViewModel.ReservaDetalle.Telefono,
                                     frmReserva.FrmReservaViewModel.ReservaDetalle.Email,
                                     frmReserva.FrmReservaViewModel.ReservaDetalle.Direccion,
                                     frmReserva.FrmReservaViewModel.ReservaDetalle.FechaEstimadaRetiro,
                                     frmReserva.FrmReservaViewModel.ReservaDetalle.MetodoEntregaSeleccionado.Key.Value,
                                     frmReserva.FrmReservaViewModel.ReservaDetalle.Observaciones,
                                     VentaModel)
            End If
        End Function

        Friend Sub NotaPedido()
            Dim notaPedido As NotaPedido = Mapper.Map(Of NotaPedido)(VentaModel)

            If (Not notaPedido.NotaPedidoItems.Any()) Then
                Throw New NegocioException("No se registran productos. Debe ingresar al menos un producto para generar una nota de pedido.")
            End If

            If TipoClienteSeleccionado = Enums.TipoCliente.Minorista Then
                Dim frmDatosClienteMinorista As frmDatosClienteMinorista = New frmDatosClienteMinorista()
                If (frmDatosClienteMinorista.ShowDialog() = DialogResult.OK) Then
                    notaPedido.AgregarClienteMinorista(frmDatosClienteMinorista.ClienteMinorista.Id)
                End If
            Else
                If (IdClienteMayorista = 0) Then
                    Throw New NegocioException("No se encuentra un cliente mayorista seleccionado. Debe seleccionar un cliente mayorista para generar una nota de pedido.")
                End If
                notaPedido.AgregarClienteMayorista(IdClienteMayorista)
            End If

            Servicio.GuardarNotaPedido(notaPedido)
        End Sub

        Friend Async Function FinalizarVentaAsyn(desdeReserva As Boolean) As Task
            AgregarCheque()

            If (PorcentajeFacturacion > 0) Then
                Try
                    FacturarEvent(New frmFacturarViewModel(VentaModel, FacturarCallBackEvent, TipoDocumentoFiscal.Factura, desdeReserva))
                Catch ex As Exception
                    Visible = True
                End Try

            Else
                Await GuardarAsync()
            End If
        End Function

        Friend Async Function GuardarAsync() As Task
            'registrar cheque
            Dim taskAgregarComisiones As Task = AgregarComisiones()
            Dim taskActualizarStock As Task = ActualizarStock()
            Await Task.WhenAll(taskAgregarComisiones, taskActualizarStock)

            Dim codigoVentaSucursal As String = SucursalModel.CodigoVenta
            Dim cantidadVentas As Integer = Await Task.Run(Function() Servicio.CantidadVentas(IdSucursal))
            VentaModel.GenerarNumeroVenta(cantidadVentas + 1, codigoVentaSucursal)

            Await Task.Run(Sub() Servicio.GuardarVenta(VentaModel))

            'Armar presupuesto

            FinalizarVentaEvent()

            If (ReservaModel IsNot Nothing) Then
                Await Task.Run(Sub() Servicio.GuardarReserva(ReservaModel))
            End If

            If (NotaPedidoModel IsNot Nothing) Then
                NotaPedidoModel.Cerrar()
                Await Task.Run(Sub() Servicio.ActualizarNotaPedido(NotaPedidoModel))
                Await FinalizarNotaPedidoEvent()
            End If
        End Function

        Friend Async Function FacturarAsync(facturar As Boolean, ventas As Model.Venta) As Task
            Visible = True
            If (facturar) Then
                Await GuardarAsync()
            End If
        End Function

        Friend Sub AgregaItemVenta(esDevolucion As Boolean)
            Dim producto As ModelBase.Producto = Productos.FirstOrDefault(Function(x) x.Codigo.ToUpper() = NombreCodigoProductoBusqueda.ToUpper() _
                                                                                OrElse x.Nombre.ToUpper() = NombreCodigoProductoBusqueda.ToUpper() _
                                                                                OrElse x.CodigoBarra.ToUpper() = NombreCodigoProductoBusqueda.ToUpper())

            If (producto Is Nothing) Then
                Throw New NegocioException("El producto ingresado no existe")
            End If

            producto = GuardarProductoCompletoEnListaDeProductos(producto)

            Dim CantidadUnidadesDeProducto As Integer = VentaModel.ObtenerCantidadDeUnidadesDeProducto(producto.Codigo) + If(esDevolucion, -1, 1)
            If Not HaySotck(producto, CantidadUnidadesDeProducto) Then
                Exit Sub
            End If

            If (CantidadUnidadesDeProducto = 0) Then
                VentaModel.QuitarVentaItem(producto.Codigo, PorcentajeFacturacion, TipoClienteSeleccionado)
            Else
                Dim montoProducto As MontoProducto = producto.ObtenerMonto(ListaPrecioSeleccionado, TipoClienteSeleccionado, PorcentajeFacturacion)

                Dim porcentejeBonificacion As Decimal = 0
                If (TipoClienteSeleccionado = Enums.TipoCliente.Minorista) Then
                    porcentejeBonificacion = producto.ObtenerBonificacion(ListaPrecioSeleccionado, TipoClienteSeleccionado)
                Else
                    porcentejeBonificacion = PorcentajeBonificacion
                End If


                Dim montoProductoMinorista As MontoProducto = producto.ObtenerMonto(IdListaPrecioMinorista, Enums.TipoCliente.Minorista, 1)
                Dim porcentejeBonificacionMinorista As Decimal = producto.ObtenerBonificacion(IdListaPrecioMinorista, Enums.TipoCliente.Minorista)

                Dim montoProductoMayorista As MontoProducto = producto.ObtenerMonto(IdListaPrecioMayorista, Enums.TipoCliente.Mayorista, 1)
                Dim porcentejeBonificacionMayorista As Decimal = producto.ObtenerBonificacion(IdListaPrecioMayorista, Enums.TipoCliente.Mayorista)

                VentaModel.AgregaVentaItem(producto,
                                    montoProducto.Valor,
                                    CantidadUnidadesDeProducto,
                                    esDevolucion,
                                    porcentejeBonificacion,
                                    PorcentajeFacturacion,
                                    TipoClienteSeleccionado,
                                    montoProductoMinorista.Valor,
                                    porcentejeBonificacionMinorista,
                                    montoProductoMayorista.Valor,
                                    porcentejeBonificacionMayorista)
            End If

            CalcularPendientePago()

            NombreCodigoProductoBusqueda = String.Empty

            NotifyPropertyChanged(NameOf(Me.VentaItems))
            NotifyPropertyChanged(NameOf(Me.TotalVentaItem))
            NotifyPropertyChanged(NameOf(Me.NombreCodigoProductoBusqueda))

        End Sub

        Private Function HaySotck(producto As ModelBase.Producto, ByRef CantidadUnidadesDeProducto As Integer) As Boolean
            Dim stockInsuficienteConfirmacion As Boolean = False

            If (CantidadUnidadesDeProducto > 0 AndAlso Not producto.HayStock(CantidadUnidadesDeProducto)) Then
                stockInsuficienteConfirmacion = StockInsuficienteEvent(producto.Id, producto.Codigo, CantidadUnidadesDeProducto)
            End If

            Return True
        End Function

        Friend Sub ActualizarItemVenta(ventaItemViewModel As VentaItemViewModel, verificarStock As Boolean)
            Dim producto As ModelBase.Producto = Productos.FirstOrDefault(Function(x) x.Codigo = ventaItemViewModel.Codigo)

            If verificarStock AndAlso Not HaySotck(producto, ventaItemViewModel.Cantidad) Then
                Exit Sub
            End If

            VentaModel.ActualizarVentaItem(ventaItemViewModel.Codigo,
                                           ventaItemViewModel.Monto,
                                           ventaItemViewModel.Cantidad,
                                           ventaItemViewModel.PorcentajeBonificacion,
                                           PorcentajeFacturacion,
                                           TipoClienteSeleccionado)

            CalcularPendientePago()

            NotifyPropertyChanged(NameOf(Me.VentaItems))
            NotifyPropertyChanged(NameOf(Me.TotalVentaItem))
        End Sub

        Friend Sub QuitarItemVenta(ventaItemViewModel As VentaItemViewModel)
            VentaModel.QuitarVentaItem(ventaItemViewModel.Codigo, PorcentajeFacturacion, TipoClienteSeleccionado)

            CalcularPendientePago()

            NotifyPropertyChanged(NameOf(Me.VentaItems))
            NotifyPropertyChanged(NameOf(Me.TotalVentaItem))
        End Sub

        Friend Sub ActualizarPorcentaBonificacionYPorcentajeFacturacion()
            For Each ventaItem As VentaItem In VentaModel.VentaItems
                VentaModel.ActualizarVentaItem(ventaItem.Producto.Codigo, ventaItem.MontoProducto.Valor, ventaItem.Cantidad, PorcentajeBonificacion, PorcentajeFacturacion, TipoClienteSeleccionado)
            Next
            CalcularPendientePago()
        End Sub

        Friend Sub ActualizarCostoFinanciero(costoFinanciero As CostoFinanciero)
            If (costoFinanciero Is Nothing) Then
                CuotaCft = 0
            Else
                CuotaCft = costoFinanciero.PorcentajeRecargo
            End If

            CalcularPagoDesdeSubtotal(Subtotal)

            NotifyPropertyChanged(NameOf(Me.CuotaCft))
        End Sub

        Friend Sub CalcularPendientePago()
            Dim motoPendientePago As MontoPago = VentaModel.ObtenerPendienteMontoPago(CuotaCft, PorcentajeFacturacion, TipoClienteSeleccionado, FormaPagoSeleccionado)
            ActualizarPago(motoPendientePago)
        End Sub

        Friend Sub CalcularPagoDesdeSubtotal(subtotal As Decimal)
            Dim motoAPagar As MontoPago = VentaModel.ObtenerMontoPagoDesdeSubtotal(subtotal, CuotaCft, PorcentajeFacturacion, TipoClienteSeleccionado, FormaPagoSeleccionado)
            ActualizarPago(motoAPagar)
        End Sub

        Friend Sub CalcularPagoDesdeTotal(total As Decimal)
            Dim motoAPagar As MontoPago = VentaModel.ObtenerMontoPagoDesdeTotal(total, CuotaCft, PorcentajeFacturacion, TipoClienteSeleccionado, FormaPagoSeleccionado)
            ActualizarPago(motoAPagar)
        End Sub

        Friend Sub QuitarPago(pagoViewModel As PagoViewModel)
            VentaModel.QuitarPago(pagoViewModel.Id)

            CalcularPendientePago()

            NotifyPropertyChanged(NameOf(Me.Pagos))
            NotifyPropertyChanged(NameOf(Me.TotalPago))
        End Sub

        Friend Sub CorregirPago(pagoViewModel As PagoViewModel)
            VentaModel.CorregirPago(pagoViewModel.Id)

            CalcularPendientePago()

            NotifyPropertyChanged(NameOf(Me.Pagos))
            NotifyPropertyChanged(NameOf(Me.TotalPago))
        End Sub

        Friend Sub AgregarPago()
            Dim numeroCuota As Integer = If(CuotaSeleccionado?.NumeroCuota, 0)
            Dim tarjeta As String = If(TarjetaSeleccionada?.Nombre, "")
            VentaModel.AgregaPago(Subtotal, Descuento, Cft, Iva, FormaPagoSeleccionado, CuotaCft, PorcentajeFacturacion, TipoClienteSeleccionado, tarjeta, numeroCuota)

            CalcularPendientePago()

            NotifyPropertyChanged(NameOf(Me.Pagos))
            NotifyPropertyChanged(NameOf(Me.TotalPago))
        End Sub

        Friend Sub ClienteMayoristaChange(idClienteMayorista As Integer, nombreClienteMayorista As String, porcentajeBonificacion As Decimal)
            Me.IdClienteMayorista = idClienteMayorista
            Me.NombreClienteMayorista = nombreClienteMayorista
            Me.PorcentajeBonificacion = porcentajeBonificacion
            NotifyPropertyChanged(NameOf(Me.IdClienteMayorista))
            NotifyPropertyChanged(NameOf(Me.NombreClienteMayorista))

            VentaModel.ActualizarClienteMayorista(idClienteMayorista)
        End Sub

        Friend Sub PorcentajeFacturacionChange(porcentajeFacturacion As Decimal)
            If (Me.PorcentajeFacturacion <> porcentajeFacturacion) Then
                Me.PorcentajeFacturacion = porcentajeFacturacion
                ActualizarPorcentaBonificacionYPorcentajeFacturacion()
                VentaModel.ActualizarPorcentajeFacturacion(porcentajeFacturacion)
                NotifyPropertyChanged(NameOf(Me.PorcentajeFacturacion))
            End If
        End Sub

        Friend Sub PorcentajeBonificacionChange(porcentajeBonificacion As Decimal)
            If (Me.PorcentajeBonificacion <> porcentajeBonificacion) Then
                Me.PorcentajeBonificacion = porcentajeBonificacion
                ActualizarPorcentaBonificacionYPorcentajeFacturacion()
                NotifyPropertyChanged(NameOf(Me.PorcentajeBonificacion))
            End If
        End Sub

        Friend Sub TipoClienteChange(TipoCliente As Enums.TipoCliente)
            If (Me.TipoClienteSeleccionado <> TipoCliente) Then
                TipoClienteSeleccionado = TipoCliente

                If (TipoClienteSeleccionado = Enums.TipoCliente.Minorista) Then
                    ListaPrecioSeleccionado = IdListaPrecioMinorista
                Else
                    ListaPrecioSeleccionado = IdListaPrecioMayorista
                End If

                For Each ventaItem As VentaItem In VentaModel.VentaItems
                    Dim monto As Decimal = VentaModel.ObtenerMontoPorTipoDeCliente(ventaItem.Producto.Codigo, TipoClienteSeleccionado)
                    Dim porcentajeBonificacion As Decimal = VentaModel.ObtenerPorcentajeBonificacionPorTipoDeCliente(ventaItem.Producto.Codigo, TipoClienteSeleccionado)
                    VentaModel.ActualizarVentaItem(ventaItem.Producto.Codigo, monto, ventaItem.Cantidad, porcentajeBonificacion, PorcentajeFacturacion, TipoClienteSeleccionado)
                Next
                CalcularPendientePago()
            End If
        End Sub

        Friend Sub FormaPagoChange(tipoPago As Enums.TipoPago)
            FormaPagoSeleccionado = tipoPago
            TarjetaSeleccionada = Nothing
            CuotaSeleccionado = Nothing
            CuotaCft = 0
            CalcularPagoDesdeSubtotal(Subtotal)
        End Sub

        Friend Sub TarjetaChange(tarjeta As Tarjeta)
            TarjetaSeleccionada = tarjeta
            CuotaSeleccionado = Nothing
            CuotaCft = 0
            Task.Run(Function() CargarCuotasAsync(tarjeta))
        End Sub

        Friend Sub CuotaChange(costoFinanciero As CostoFinanciero)
            CuotaSeleccionado = costoFinanciero
        End Sub

        Public Async Function CargarDatosAsync() As Task
            Dim tareas As List(Of Task) = New List(Of Task)()
            tareas.Add(CargarProductoNombreYCodigoAsync())
            tareas.Add(CargarEmpleadosAsync())
            tareas.Add(CargarListaPrecioAsync())
            tareas.Add(CargarTarjetasAsync())
            tareas.Add(CargarSucursalAsync())

            Await Task.WhenAll(tareas)
        End Function

        Private Function AplicarBonificacion() As Boolean
            If (FormaPagoSeleccionado = Enums.TipoPago.Efectivo) Then
                Return True
            Else
                Return False
            End If
        End Function


        Private Async Function CargarEmpleadosAsync() As Task
            Dim encargados As List(Of ModelBase.Empleado) = Await Task.Run(Function() Servicio.ObtenerEmpleados(Enums.TipoEmpleado.Encargado, IdSucursal))
            Dim vendedor As List(Of ModelBase.Empleado) = Await Task.Run(Function() Servicio.ObtenerEmpleados(Enums.TipoEmpleado.Vendedor, IdSucursal))
            vendedor.AddRange(encargados)
            _Encargados = New BindingList(Of ModelBase.Empleado)(encargados)
            EncargadoSeleccionado = _Encargados.FirstOrDefault()
            _Vendedores = New BindingList(Of ModelBase.Empleado)(vendedor)
            VendedoresSeleccionado = _Vendedores.FirstOrDefault()


            NotifyPropertyChanged(NameOf(Me.Encargados))
            NotifyPropertyChanged(NameOf(Me.EncargadoSeleccionado))
            NotifyPropertyChanged(NameOf(Me.Vendedores))
            NotifyPropertyChanged(NameOf(Me.VendedoresSeleccionado))
        End Function

        Private Async Function CargarSucursalAsync() As Task
            SucursalModel = Await Task.Run(Function() Servicio.ObtenerSucursal(IdSucursal))
        End Function

        Private Async Function CargarTarjetasAsync() As Task
            Dim tarjetas As IList(Of Tarjeta) = Await Task.Run(Function() Servicio.ObtenerTarjetas())
            Dim costoFinanciero As IList(Of CostoFinanciero) = Await Task.Run(Function() Servicio.ObtenerCuotas(tarjetas.FirstOrDefault()?.Id))

            _Tarjeta = New BindingList(Of KeyValuePair(Of Tarjeta, String))(tarjetas.Select(Function(x) New KeyValuePair(Of Tarjeta, String)(x, x.Nombre)).ToList)

            NotifyPropertyChanged(NameOf(Me.Tarjeta))
        End Function

        Private Async Function CargarListaPrecioAsync() As Task
            Dim listaPrecio As IList(Of ListaPrecio) = Await Task.Run(Function() Servicio.ObtenerListaPrecio())
            _ListaPrecio = New BindingList(Of ListaPrecio)(listaPrecio)

            NotifyPropertyChanged(NameOf(Me.ListaPrecio))
        End Function

        Private Sub CargarFormaPago(formasPagos As List(Of Enums.TipoPago))
            _FormaPago = New BindingList(Of Enums.TipoPago)(formasPagos)
            NotifyPropertyChanged(NameOf(Me.FormaPago))
        End Sub

        Private Async Function CargarProductoNombreYCodigoAsync() As Task
            If (CargarProductoNombreyCodigoEvent IsNot Nothing) Then

                Productos = Await Task.Run(Function() Servicio.ObtenerListaProductos())

                Dim NombreCodigoProductos As List(Of String) = New List(Of String)
                Productos.ToList().ForEach(Sub(x) NombreCodigoProductos.Add(x.Codigo))
                Productos.ToList().ForEach(Sub(x) NombreCodigoProductos.Add(x.Nombre))

                CargarProductoNombreyCodigoEvent(NombreCodigoProductos)
            End If
        End Function

        Private Async Function CargarCuotasAsync(banco As Tarjeta) As Task
            If (banco Is Nothing) Then
                Return
            End If

            Dim costoFinanciero As IList(Of CostoFinanciero) = Await Task.Run(Function() Servicio.ObtenerCuotas(banco.Id))
            _Cuota = New BindingList(Of KeyValuePair(Of CostoFinanciero, String))(costoFinanciero.Select(Function(x) New KeyValuePair(Of CostoFinanciero, String)(x, x.NumeroCuota)).ToList)

            NotifyPropertyChanged(NameOf(Me.Cuota))
        End Function

        Private Sub ActualizarPago(montoPago As MontoPago)
            _Subtotal = montoPago.Monto
            _Descuento = montoPago.Descuento
            _Cft = montoPago.CFT
            _Iva = montoPago.IVA
            _Total = montoPago.Total

            NotifyPropertyChanged(NameOf(Me.Subtotal))
            NotifyPropertyChanged(NameOf(Me.Descuento))
            NotifyPropertyChanged(NameOf(Me.Cft))
            NotifyPropertyChanged(NameOf(Me.Iva))
            NotifyPropertyChanged(NameOf(Me.Total))
        End Sub

        Private Async Function AgregarComisiones() As Task
            Dim esFeriado As Boolean = Await Task.Run(Function() Servicio.EsFeriado())

            Dim porcentajeComicionVendedor As Decimal = 0
            Dim porcentajeComicionEncargado As Decimal = 0

            SucursalModel.ObtenerPorcentajeComision(esFeriado, TipoClienteSeleccionado, porcentajeComicionVendedor, porcentajeComicionEncargado)

            VentaModel.AgregarComision(porcentajeComicionEncargado, porcentajeComicionVendedor)
        End Function

        Private Sub AgregarCheque()
            Dim cheques As List(Of Pago) = VentaModel.Pagos.Where(Function(x) x.TipoPago = TipoPago.Cheque).ToList()
            If (cheques.Any()) Then
                Dim frmChequeAltaMasiva As frmChequeAltaMasiva = New frmChequeAltaMasiva(cheques.Sum(Function(x) x.MontoPago.Total), IdClienteMayorista)
                frmChequeAltaMasiva.ShowDialog()

                If (frmChequeAltaMasiva.DialogResult <> DialogResult.OK) Then
                    Throw New NegocioException("Error al finalizar la venta. No se encuentran cheques registrados.")
                End If

                If Not frmChequeAltaMasiva.ChequesModel.Any() Then
                    Throw New NegocioException("Error al finalizar la venta. No se encuentran cheques registrados.")
                End If

                frmChequeAltaMasiva.ChequesModel.ForEach(Sub(x) VentaModel.AgregarCheque(x))
            End If
        End Sub

        Private Function ActualizarStock() As Task

            Dim stocksVenta As List(Of ModelBase.Stock) = New List(Of ModelBase.Stock)
            Dim productosStock As List(Of KeyValuePair(Of String, Integer)) = New List(Of KeyValuePair(Of String, Integer))()

            If (ReservaModel IsNot Nothing) Then
                productosStock = ObtenerCambioEnProductosPorReserva()
            Else
                VentaModel.VentaItems.ToList().ForEach(Sub(x) productosStock.Add(New KeyValuePair(Of String, Integer)(x.Producto.Codigo, x.Cantidad)))
            End If

            For Each productoStock As KeyValuePair(Of String, Integer) In productosStock
                Dim stock As ModelBase.Stock = Productos.FirstOrDefault(Function(x) x.Codigo = productoStock.Key).Stock

                If (productoStock.Value > 0) Then
                    stock.Disminuir(Math.Abs(productoStock.Value))
                Else
                    stock.Agregar(Math.Abs(productoStock.Value))
                End If

                stocksVenta.Add(stock)
            Next

            Return Task.Run(Sub() Servicio.ActualizarStock(stocksVenta))
        End Function

        Private Function ObtenerCambioEnProductosPorReserva() As List(Of KeyValuePair(Of String, Integer))
            Dim productos As List(Of KeyValuePair(Of String, Integer)) = New List(Of KeyValuePair(Of String, Integer))()

            For Each ventaItemReserva As VentaItem In ReservaModel.VentaReserva.VentaItems
                Dim ventaItem As VentaItem = VentaModel.VentaItems.FirstOrDefault(Function(x) x.Producto.Codigo = ventaItemReserva.Producto.Codigo)
                If (ventaItem Is Nothing) Then
                    productos.Add(New KeyValuePair(Of String, Integer)(ventaItemReserva.Producto.Codigo, -ventaItemReserva.Cantidad))
                Else
                    productos.Add(New KeyValuePair(Of String, Integer)(ventaItemReserva.Producto.Codigo, ventaItem.Cantidad - ventaItemReserva.Cantidad))
                End If
            Next


            For Each ventaItem As VentaItem In VentaModel.VentaItems
                Dim ventaItemReserva As VentaItem = ReservaModel.VentaReserva.VentaItems.FirstOrDefault(Function(x) x.Producto.Codigo = ventaItem.Producto.Codigo)
                If (ventaItemReserva Is Nothing) Then
                    productos.Add(New KeyValuePair(Of String, Integer)(ventaItem.Producto.Codigo, ventaItem.Cantidad))
                End If
            Next

            Return productos
        End Function

        Private Function GuardarProductoCompletoEnListaDeProductos(producto As ModelBase.Producto) As ModelBase.Producto
            If (producto.Stock Is Nothing) Then
                Dim productoCompleto As ModelBase.Producto = Servicio.ObtenerProductoCompleto(IdSucursal, producto.Id)
                Productos(Productos.IndexOf(producto)) = productoCompleto
                producto = productoCompleto
            End If

            Return producto
        End Function

        Private Sub Inicializar(venta As Model.Venta, tipoCliente As Enums.TipoCliente, idListaPrecioMinorista As Integer, idListaPrecioMayorista As Integer)
            Visible = True
            VentaModel = venta
            PorcentajeFacturacion = 1
            PorcentajeBonificacion = 0
            TipoClienteSeleccionado = tipoCliente
            IdClienteMayorista = 0
            NombreClienteMayorista = String.Empty
            FormaPagoSeleccionado = TipoPago.Efectivo

            _TipoCliente = New BindingList(Of Enums.TipoCliente)([Enum](Of Enums.TipoCliente).ToList())

            If (tipoCliente = Enums.TipoCliente.Minorista) Then
                ConfigurarVentaParaClienteMinorista()
                ListaPrecioSeleccionado = idListaPrecioMinorista
            Else
                ConfigurarVentaParaClienteMayorista()
                ListaPrecioSeleccionado = idListaPrecioMayorista
            End If
        End Sub

        Private Sub QuitarClienteMayorista()
            IdClienteMayorista = 0
            NombreClienteMayorista = String.Empty
        End Sub

    End Class
End Namespace
