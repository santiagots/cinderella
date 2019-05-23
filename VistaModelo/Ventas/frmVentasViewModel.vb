Imports System.ComponentModel
Imports System.Linq
Imports System.Threading.Tasks
Imports Model = Ventas.Core.Model.VentaAggregate
Imports ValueObjects = Ventas.Core.Model.ValueObjects
Imports Ventas.Core.Interfaces
Imports Ventas.Core.Model.VentaAggregate
Imports Ventas.Data.Repository
Imports Ventas.Data
Imports Enums = Common.Core.Enum
Imports Common.Core.Extension
Imports Common.Core.Exceptions
Imports Ventas.Core.Model.ValueObjects
Imports Common.Data
Imports Common.Data.Repository
Imports Common.Core.Interfaces
Imports Ventas.Core.Model.BaseAgreggate
Imports AutoMapper
Imports Ventas.Core.Model.NotaPedidoAgreggate
Imports Common.Core.Enum
Imports SistemaCinderella.Formularios.Reserva
Imports Common.Core.Model

Namespace VistaModelo.Ventas
    Public Class frmVentasViewModel
        Inherits Common

        Public Delegate Sub CargarProductoNombreyCodigoDelegate(nombreCodigoProductos As List(Of String))
        Public Delegate Function StockInsuficienteDelegate(idProducto As Integer, codigoProducto As String, ByRef stockCargado As Integer) As Boolean
        Public Delegate Sub FacturarDelegate(facturarViewModel As frmFacturarViewModel)
        Public Delegate Function FacturarDelegateCallBack(facturar As Boolean) As Task
        Public Delegate Sub TerminarVentaDelegate()

        Private CargarProductoNombreyCodigoEvent As CargarProductoNombreyCodigoDelegate
        Private StockInsuficienteEvent As StockInsuficienteDelegate
        Private FacturarEvent As FacturarDelegate
        Private FacturarCallBackEvent As FacturarDelegateCallBack
        Private TerminarVentaEvent As TerminarVentaDelegate
        Private ventaModel As Model.Venta
        Private reservaModel As Model.Reserva
        Private ReadOnly IdListaPrecioMinorista As Integer
        Private ReadOnly IdListaPrecioMayorista As Integer

        Private Productos As List(Of Model.Producto) = New List(Of Model.Producto)

        Public Property TipoClienteSeleccionado As Enums.TipoCliente

        Public ReadOnly Property TipoCliente As BindingList(Of Enums.TipoCliente)

        Private _EncargadoSeleccionado As Empleado
        Public Property EncargadoSeleccionado As Empleado
            Get
                Return _EncargadoSeleccionado
            End Get
            Set(value As Empleado)
                _EncargadoSeleccionado = value
                ventaModel.AgregarEncargado(value)
            End Set
        End Property

        Public ReadOnly Property Encargados As BindingList(Of Empleado)

        Private _VendedoresSeleccionado As Empleado
        Public Property VendedoresSeleccionado As Empleado
            Get
                Return _VendedoresSeleccionado
            End Get
            Set(value As Empleado)
                _VendedoresSeleccionado = value
                ventaModel.AgregarVendedor(value)
            End Set
        End Property
        Public ReadOnly Property Vendedores As BindingList(Of Empleado)

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
                Return New BindingList(Of VentaItemViewModel)(Mapper.Map(Of List(Of VentaItemViewModel))(ventaModel.VentaItems))
            End Get
        End Property

        Public ReadOnly Property TotalVentaItem As BindingList(Of VentaItemViewModel)
            Get
                Dim VentaItemViewModel As VentaItemViewModel = New VentaItemViewModel() With {
                    .Nombre = "Total",
                    .Cantidad = ventaModel.CantidadTotal,
                    .Iva = ventaModel.MontoTotal.Iva,
                    .Monto = ventaModel.MontoTotal.Valor,
                    .Total = ventaModel.MontoTotal.toDecimal()
                    }
                Dim list As BindingList(Of VentaItemViewModel) = New BindingList(Of VentaItemViewModel)

                list.Add(VentaItemViewModel)
                Return list
            End Get
        End Property

        Public ReadOnly Property Pagos As BindingList(Of PagoViewModel)
            Get
                Return New BindingList(Of PagoViewModel)(
                    Mapper.Map(Of List(Of PagoViewModel))(ventaModel.Pagos))
            End Get
        End Property

        Public ReadOnly Property TotalPago As BindingList(Of PagoViewModel)
            Get
                Dim PagoViewModel As PagoViewModel = New PagoViewModel() With {
                    .CFT = ventaModel.PagoTotal.CFT,
                    .IVA = ventaModel.PagoTotal.IVA,
                    .Descuento = ventaModel.PagoTotal.Descuento,
                    .Monto = ventaModel.PagoTotal.Monto,
                    .Total = ventaModel.PagoTotal.Total,
                    .Resto = ventaModel.Pagos.Sum(Function(x) x.MontoRestante),
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
                Return ventaModel.EstaPaga And TotalPago.First.Resto = 0 And ((TipoClienteSeleccionado = Enums.TipoCliente.Mayorista AndAlso IdClienteMayorista > 0) OrElse TipoClienteSeleccionado = Enums.TipoCliente.Minorista)
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
                Return Not ventaModel.EstaPaga
            End Get
        End Property

        Public ReadOnly Property IdSucursal As Integer
            Get
                Return ventaModel.IdSucursal
            End Get
        End Property

        Public Sub New(IdSucursal As Integer, tipoCliente As Enums.TipoCliente, idListaPrecioMinorista As Integer, idListaPrecioMayorista As Integer, cargarProductoNombreyCodigo As CargarProductoNombreyCodigoDelegate, stockInsuficiente As StockInsuficienteDelegate, facturar As FacturarDelegate, terminarVentaEvent As TerminarVentaDelegate)
            Me.IdListaPrecioMinorista = idListaPrecioMinorista
            Me.IdListaPrecioMayorista = idListaPrecioMayorista
            Me.CargarProductoNombreyCodigoEvent = cargarProductoNombreyCodigo
            Me.StockInsuficienteEvent = stockInsuficiente
            Me.FacturarEvent = facturar
            Me.FacturarCallBackEvent = AddressOf FacturarAsync
            Me.TerminarVentaEvent = terminarVentaEvent

            Inicializar(New Model.Venta(IdSucursal), tipoCliente, idListaPrecioMinorista, idListaPrecioMayorista)
        End Sub

        Friend Sub CargarNotaPedido(notaPedido As NotaPedido)
            CargarDatosBasicosTransaccion(notaPedido)
            CargarProductosEnVenta(notaPedido.NotaPedidoItems.Cast(Of TransaccionItem)().ToList(), notaPedido.TipoCliente)
        End Sub

        Friend Sub CargarReserva(reserva As Reserva)
            reservaModel = reserva
            reservaModel.Entregar(ventaModel)
            CargarDatosBasicosTransaccion(reservaModel.VentaReserva)
            CargarProductosEnVenta(reservaModel.VentaReserva.VentaItems.Cast(Of TransaccionItem)().ToList(), reservaModel.VentaReserva.TipoCliente)

            For Each pago As Pago In reserva.VentaReserva.Pagos
                ventaModel.AgregaPago(pago.MontoPago.Monto, pago.MontoPago.Total + pago.MontoPago.Descuento, pago.MontoPago.CFT, pago.MontoPago.IVA, pago.TipoPago, pago.PorcentajeRecargo, reservaModel.VentaReserva.PorcentajeFacturacion, reservaModel.VentaReserva.TipoCliente, pago.Tarjeta, pago.NumeroCuotas, False)
            Next

            CalcularPendientePago()

            NotifyPropertyChanged(NameOf(Me.Pagos))
            NotifyPropertyChanged(NameOf(Me.TotalPago))
        End Sub

        Private Sub CargarProductosEnVenta(transaccionItems As List(Of TransaccionItem), tipoCliente As TipoCliente)
            Dim montoProductoMinorista As MontoProducto = New MontoProducto(0, 0)
            Dim porcentejeBonificacionMinorista As Decimal = 0

            Dim montoProductoMayorista As MontoProducto
            Dim porcentejeBonificacionMayorista As Decimal

            For Each transaccionItem As TransaccionItem In transaccionItems
                Dim producto As Model.Producto = Productos.FirstOrDefault(Function(x) x.Codigo.ToUpper() = transaccionItem.CodigoProducto.ToUpper())
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

                ventaModel.AgregaVentaItem(transaccionItem.CodigoProducto,
                                           transaccionItem.NombreProducto,
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

        Private Sub CargarDatosBasicosTransaccion(venta As Transaccion)
            TipoClienteSeleccionado = venta.TipoCliente
            PorcentajeFacturacion = venta.PorcentajeFacturacion
            EncargadoSeleccionado = venta.Encargado
            VendedoresSeleccionado = venta.Vendedor
            If (venta.TipoCliente = Enums.TipoCliente.Mayorista) Then
                IdClienteMayorista = venta.IdClienteMayorista
                NombreClienteMayorista = venta.ClienteMayorista.RazonSocial
            End If
        End Sub

        Friend Sub ConfigurarVentaParaClienteMayorista()
            CargarFormaPago(New List(Of Enums.TipoPago)() From {Enums.TipoPago.Efectivo, Enums.TipoPago.Cheque, Enums.TipoPago.Deposito})
            ventaModel.ModificarTipoCliente(TipoClienteSeleccionado)
            CalcularPendientePago()
        End Sub

        Friend Sub ConfigurarVentaParaClienteMinorista()
            CargarFormaPago(New List(Of Enums.TipoPago)() From {Enums.TipoPago.Efectivo, Enums.TipoPago.TarjetaCredito, Enums.TipoPago.TarjetaDebito})
            ventaModel.ModificarTipoCliente(TipoClienteSeleccionado)
            CalcularPendientePago()
            QuitarClienteMayorista()
        End Sub

        Friend Async Function ReservaAsyn() As Task
            Dim ventaDetalleViewModel As VentaDetalleViewModel = Mapper.Map(Of VentaDetalleViewModel)(ventaModel)
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

                reservaModel = New Reserva(
                                     IdSucursal,
                                     frmReserva.FrmReservaViewModel.ReservaDetalle.Nombre,
                                     frmReserva.FrmReservaViewModel.ReservaDetalle.Apellido,
                                     frmReserva.FrmReservaViewModel.ReservaDetalle.Telefono,
                                     frmReserva.FrmReservaViewModel.ReservaDetalle.Email,
                                     frmReserva.FrmReservaViewModel.ReservaDetalle.Direccion,
                                     frmReserva.FrmReservaViewModel.ReservaDetalle.FechaEstimadaRetiro,
                                     frmReserva.FrmReservaViewModel.ReservaDetalle.MetodoEntregaSeleccionado.Key.Value,
                                     frmReserva.FrmReservaViewModel.ReservaDetalle.Observaciones,
                                     ventaModel)
            End If
        End Function

        Friend Sub NotaPedido()
            Dim notaPedido As NotaPedido = Mapper.Map(Of NotaPedido)(ventaModel)

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
                    FacturarEvent(New frmFacturarViewModel(ventaModel, FacturarCallBackEvent, desdeReserva))
                Catch ex As Exception
                    Visible = True
                End Try

            Else
                Await GuardarAsync()
            End If
        End Function

        Friend Async Function GuardarAsync() As Task
            'registrar cheque
            Dim taskAgregarComisionesl As Task = AgregarComisiones()
            Dim taskActualizarStock As Task = ActualizarStock()
            Await Task.WhenAll(taskAgregarComisionesl, taskActualizarStock)

            Dim codigoVentaSucursal As String = (Await Task.Run(Function() Servicio.ObtenerSucursal(IdSucursal))).CodigoVenta
            Dim cantidadVentas As Integer = Await Task.Run(Function() Servicio.CantidadVentas(IdSucursal))
            ventaModel.GenerarNumeroVenta(cantidadVentas + 1, codigoVentaSucursal)
            Servicio.GuardarVenta(ventaModel)

            'cerrar nota de pedido

            'Armar presupuesto

            TerminarVentaEvent()

            If (reservaModel IsNot Nothing) Then
                Await Task.Run(Sub() Servicio.GuardarReserva(reservaModel))
            End If

        End Function

        Friend Async Function FacturarAsync(facturar As Boolean) As Task
            Visible = True
            If (facturar) Then
                Await GuardarAsync()
            End If
        End Function

        Friend Sub AgregaItemVenta(esDevolucion As Boolean)
            Dim producto As Model.Producto = Productos.FirstOrDefault(Function(x) x.Codigo.ToUpper() = NombreCodigoProductoBusqueda.ToUpper() OrElse x.Nombre.ToUpper() = NombreCodigoProductoBusqueda.ToUpper())

            If (producto Is Nothing) Then
                Throw New NegocioException("El producto ingresado no existe")
            End If

            producto = GuardarProductoCompletoEnListaDeProductos(producto)

            Dim CantidadUnidadesDeProducto As Integer = ventaModel.ObtenerCantidadDeUnidadesDeProducto(producto.Codigo) + If(esDevolucion, -1, 1)
            Dim stockInsuficienteConfirmacion As Boolean = False

            If (CantidadUnidadesDeProducto > 0 AndAlso Not producto.HayStock(CantidadUnidadesDeProducto)) Then
                stockInsuficienteConfirmacion = StockInsuficienteEvent(producto.Id, producto.Codigo, CantidadUnidadesDeProducto)
                If (Not stockInsuficienteConfirmacion) Then
                    Exit Sub
                End If
            End If

            If (CantidadUnidadesDeProducto = 0) Then
                ventaModel.QuitarVentaItem(producto.Codigo, PorcentajeFacturacion, TipoClienteSeleccionado)
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

                ventaModel.AgregaVentaItem(producto.Codigo,
                                    producto.Nombre,
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

        Friend Sub ActualizarItemVenta(ventaItemViewModel As VentaItemViewModel)
            ventaModel.ActualizarVentaItem(ventaItemViewModel.Codigo,
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
            ventaModel.QuitarVentaItem(ventaItemViewModel.Codigo, PorcentajeFacturacion, TipoClienteSeleccionado)

            CalcularPendientePago()

            NotifyPropertyChanged(NameOf(Me.VentaItems))
            NotifyPropertyChanged(NameOf(Me.TotalVentaItem))
        End Sub

        Friend Sub ActualizarPorcentaBonificacionYPorcentajeFacturacion()
            For Each ventaItem As VentaItem In ventaModel.VentaItems
                ventaModel.ActualizarVentaItem(ventaItem.CodigoProducto, ventaItem.MontoProducto.Valor, ventaItem.Cantidad, PorcentajeBonificacion, PorcentajeFacturacion, TipoClienteSeleccionado)
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
            Dim motoPendientePago As MontoPago = ventaModel.ObtenerPendienteMontoPago(CuotaCft, PorcentajeFacturacion, TipoClienteSeleccionado, FormaPagoSeleccionado)
            ActualizarPago(motoPendientePago)
        End Sub

        Friend Sub CalcularPagoDesdeSubtotal(subtotal As Decimal)
            Dim motoAPagar As MontoPago = ventaModel.ObtenerMontoPagoDesdeSubtotal(subtotal, CuotaCft, PorcentajeFacturacion, TipoClienteSeleccionado, FormaPagoSeleccionado)
            ActualizarPago(motoAPagar)
        End Sub

        Friend Sub CalcularPagoDesdeTotal(total As Decimal)
            Dim motoAPagar As MontoPago = ventaModel.ObtenerMontoPagoDesdeTotal(total, CuotaCft, PorcentajeFacturacion, TipoClienteSeleccionado, FormaPagoSeleccionado)
            ActualizarPago(motoAPagar)
        End Sub

        Friend Sub QuitarPago(pagoViewModel As PagoViewModel)
            ventaModel.QuitarPago(pagoViewModel.Id)

            CalcularPendientePago()

            NotifyPropertyChanged(NameOf(Me.Pagos))
            NotifyPropertyChanged(NameOf(Me.TotalPago))
        End Sub

        Friend Sub CorregirPago(pagoViewModel As PagoViewModel)
            ventaModel.CorregirPago(pagoViewModel.Id)

            CalcularPendientePago()

            NotifyPropertyChanged(NameOf(Me.Pagos))
            NotifyPropertyChanged(NameOf(Me.TotalPago))
        End Sub

        Friend Sub AgregarPago()
            Dim numeroCuota As Integer = If(CuotaSeleccionado?.NumeroCuota, 0)
            Dim tarjeta As String = If(TarjetaSeleccionada?.Nombre, "")
            ventaModel.AgregaPago(Subtotal, Descuento, Cft, Iva, FormaPagoSeleccionado, CuotaCft, PorcentajeFacturacion, TipoClienteSeleccionado, tarjeta, numeroCuota)

            CalcularPendientePago()

            NotifyPropertyChanged(NameOf(Me.Pagos))
            NotifyPropertyChanged(NameOf(Me.TotalPago))
        End Sub

        Friend Sub ClienteMayoristaChange(idClienteMayorista As Integer, nombreClienteMayorista As String)
            Me.IdClienteMayorista = idClienteMayorista
            Me.NombreClienteMayorista = nombreClienteMayorista
            NotifyPropertyChanged(NameOf(Me.IdClienteMayorista))
            NotifyPropertyChanged(NameOf(Me.NombreClienteMayorista))

            ventaModel.ActualizarClienteMayorista(idClienteMayorista)
        End Sub

        Friend Sub PorcentajeFacturacionChange(porcentajeFacturacion As Decimal)
            Me.PorcentajeFacturacion = porcentajeFacturacion
            ActualizarPorcentaBonificacionYPorcentajeFacturacion()
            ventaModel.ActualizarPorcentajeFacturacion(porcentajeFacturacion)
            NotifyPropertyChanged(NameOf(Me.PorcentajeFacturacion))
        End Sub

        Friend Sub PorcentajeBonificacionChange(porcentajeBonificacion As Decimal)
            Me.PorcentajeBonificacion = porcentajeBonificacion
            ActualizarPorcentaBonificacionYPorcentajeFacturacion()
            NotifyPropertyChanged(NameOf(Me.PorcentajeBonificacion))
        End Sub

        Friend Sub TipoClienteChange(TipoCliente As Enums.TipoCliente)
            TipoClienteSeleccionado = TipoCliente

            If (TipoClienteSeleccionado = Enums.TipoCliente.Minorista) Then
                ListaPrecioSeleccionado = IdListaPrecioMinorista
            Else
                ListaPrecioSeleccionado = IdListaPrecioMayorista
            End If

            For Each ventaItem As VentaItem In ventaModel.VentaItems
                Dim monto As Decimal = ventaModel.ObtenerMontoPorTipoDeCliente(ventaItem.CodigoProducto, TipoClienteSeleccionado)
                Dim porcentajeBonificacion As Decimal = ventaModel.ObtenerPorcentajeBonificacionPorTipoDeCliente(ventaItem.CodigoProducto, TipoClienteSeleccionado)
                ventaModel.ActualizarVentaItem(ventaItem.CodigoProducto, monto, ventaItem.Cantidad, porcentajeBonificacion, PorcentajeFacturacion, TipoClienteSeleccionado)
            Next
            CalcularPendientePago()
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
            Dim encargados As List(Of Empleado) = Await Task.Run(Function() Servicio.ObtenerEmpleados(Enums.TipoEmpleado.Encargado, IdSucursal))
            Dim vendedor As List(Of Empleado) = Await Task.Run(Function() Servicio.ObtenerEmpleados(Enums.TipoEmpleado.Vendedor, IdSucursal))
            vendedor.AddRange(encargados)
            _Encargados = New BindingList(Of Empleado)(encargados)
            EncargadoSeleccionado = _Encargados.First()
            _Vendedores = New BindingList(Of Empleado)(vendedor)
            VendedoresSeleccionado = _Vendedores.First()


            NotifyPropertyChanged(NameOf(Me.Encargados))
            NotifyPropertyChanged(NameOf(Me.EncargadoSeleccionado))
            NotifyPropertyChanged(NameOf(Me.Vendedores))
            NotifyPropertyChanged(NameOf(Me.VendedoresSeleccionado))
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

            Dim taskSucursal As Task(Of Sucursal) = Task.Run(Function() Servicio.ObtenerSucursal(IdSucursal))
            Dim taskEsFeriado As Task(Of Boolean) = Task.Run(Function() Servicio.EsFeriado())

            Await Task.WhenAll(taskSucursal, taskEsFeriado)

            Dim sucursal As Sucursal = taskSucursal.Result
            Dim esFeriado As Boolean = taskEsFeriado.Result

            Dim porcentajeComicionVendedor As Decimal = 0
            Dim porcentajeComicionEncargado As Decimal = 0

            sucursal.ObtenerPorcentajeComision(esFeriado, TipoClienteSeleccionado, porcentajeComicionVendedor, porcentajeComicionEncargado)

            ventaModel.AgregarComision(porcentajeComicionEncargado, porcentajeComicionVendedor)
        End Function

        Private Sub AgregarCheque()
            Dim cheques As List(Of Pago) = ventaModel.Pagos.Where(Function(x) x.TipoPago = TipoPago.Cheque).ToList()
            If (cheques.Any()) Then
                Dim frmChequeAltaMasiva As frmChequeAltaMasiva = New frmChequeAltaMasiva(cheques.Sum(Function(x) x.MontoPago.Total), IdClienteMayorista)
                frmChequeAltaMasiva.ShowDialog()

                If (frmChequeAltaMasiva.DialogResult <> DialogResult.OK) Then
                    Throw New NegocioException("Error al finalizar la venta. No se encuentran cheques registrados.")
                End If

                If Not frmChequeAltaMasiva.ChequesModel.Any() Then
                    Throw New NegocioException("Error al finalizar la venta. No se encuentran cheques registrados.")
                End If

                frmChequeAltaMasiva.ChequesModel.ForEach(Sub(x) ventaModel.AgregarCheque(x))
            End If
        End Sub

        Private Function ActualizarStock() As Task

            Dim stocksVenta As List(Of Stock) = New List(Of Stock)
            Dim productosStock As List(Of KeyValuePair(Of String, Integer)) = New List(Of KeyValuePair(Of String, Integer))()

            If (reservaModel IsNot Nothing) Then
                productosStock = ObtenerCambioEnProductosPorReserva()
            Else
                ventaModel.VentaItems.ToList().ForEach(Sub(x) productosStock.Add(New KeyValuePair(Of String, Integer)(x.CodigoProducto, x.Cantidad)))
            End If

            For Each productoStock As KeyValuePair(Of String, Integer) In productosStock
                Dim stock As Stock = Productos.FirstOrDefault(Function(x) x.Codigo = productoStock.Key).Stock

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

            For Each ventaItemReserva As VentaItem In reservaModel.VentaReserva.VentaItems
                Dim ventaItem As VentaItem = ventaModel.VentaItems.FirstOrDefault(Function(x) x.CodigoProducto = ventaItemReserva.CodigoProducto)
                If (ventaItem Is Nothing) Then
                    productos.Add(New KeyValuePair(Of String, Integer)(ventaItemReserva.CodigoProducto, -ventaItemReserva.Cantidad))
                Else
                    productos.Add(New KeyValuePair(Of String, Integer)(ventaItemReserva.CodigoProducto, ventaItem.Cantidad - ventaItemReserva.Cantidad))
                End If
            Next


            For Each ventaItem As VentaItem In ventaModel.VentaItems
                Dim ventaItemReserva As VentaItem = reservaModel.VentaReserva.VentaItems.FirstOrDefault(Function(x) x.CodigoProducto = ventaItem.CodigoProducto)
                If (ventaItemReserva Is Nothing) Then
                    productos.Add(New KeyValuePair(Of String, Integer)(ventaItem.CodigoProducto, ventaItem.Cantidad))
                End If
            Next

            Return productos
        End Function

        Private Function GuardarProductoCompletoEnListaDeProductos(producto As Producto) As Producto
            If (producto.Stock Is Nothing) Then
                Dim productoCompleto As Model.Producto = Servicio.ObtenerProductoCompleto(IdSucursal, producto.Id)
                Productos(Productos.IndexOf(producto)) = productoCompleto
                producto = productoCompleto
            End If

            Return producto
        End Function

        Private Sub Inicializar(venta As Model.Venta, tipoCliente As Enums.TipoCliente, idListaPrecioMinorista As Integer, idListaPrecioMayorista As Integer)
            Visible = True
            ventaModel = venta
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
