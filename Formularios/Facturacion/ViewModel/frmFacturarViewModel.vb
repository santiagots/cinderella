Imports System.ComponentModel
Imports Common.Core.Extension
Imports Enums = Common.Core.Enum
Imports Common.Core.Exceptions
Imports System.Threading.Tasks
Imports Helper = Common.Core.Helper
Imports Common.Core.ValueObjects
Imports Common.Core.Model
Imports Common.Core.Enum
Imports Model = Ventas.Core.Model.VentaAggregate
Imports SistemaCinderella.Formularios.Venta.frmVentasViewModel

Namespace Formularios.Facturacion
    Public Class frmFacturarViewModel
        Inherits SistemaCinderella.VistaModelo.Common

        Private FacturarCallBackEvent As FacturarDelegateCallBackAsync

        Private ventaModel As Model.Venta
        Private desdeReserva As Boolean
        Private tipoDocumentoFiscal As TipoDocumentoFiscal
        Private CondicionIvaOriginal As CondicionIVA
        Private PuntoVentaOriginal As Integer

        Public ReadOnly Property TiposFactura As BindingList(Of Enums.TipoFactura)
            Get
                Return New BindingList(Of Enums.TipoFactura)([Enum](Of Enums.TipoFactura).ToList())
            End Get
        End Property
        Public Property TiposFacturaSeleccionada As Enums.TipoFactura
        Public Property EstadoControladorFiscal As String
        Public Property Fecha As DateTime
        Public Property Subtotal As Decimal
        Public Property Descuento As Decimal
        Public Property CostoFinanciero As Decimal
        Public Property Iva As Decimal
        Public Property Total As Decimal
        Public ReadOnly Property CondicionesIVA As BindingList(Of Enums.CondicionIVA)
            Get
                Return New BindingList(Of Enums.CondicionIVA)([Enum](Of Enums.CondicionIVA).ToList())
            End Get
        End Property
        Public Property CondicionesIVASeleccionada As Enums.CondicionIVA
        Public Property NombreYApellido As String
        Public Property Direccion As String
        Public Property Localidad As String
        Public Property CUIT As String
        Public Property NumeroFacturaOrigen As Integer
        Public Property Numerofactura As String
        Public ReadOnly Property Numerosfacturas As BindingList(Of Integer)
        Public Property LimiteFacturacion As Boolean
        Public ReadOnly Property HabilitarFacturar As Boolean
            Get
                Return Not LimiteFacturacion AndAlso tipoDocumentoFiscal = TipoDocumentoFiscal.Factura
            End Get
        End Property

        Public ReadOnly Property HabilitarNotaCredito As Boolean
            Get
                Return tipoDocumentoFiscal = TipoDocumentoFiscal.NotaCredito
            End Get
        End Property

        Public ReadOnly Property HabilitarFacturacionManual As Boolean
            Get
                Return TiposFacturaSeleccionada = Enums.TipoFactura.Manual
            End Get
        End Property

        Public ReadOnly Property HabilitarDatosCliente As Boolean
            Get
                Return ventaModel.TipoCliente = Enums.TipoCliente.Mayorista OrElse tipoDocumentoFiscal = TipoDocumentoFiscal.NotaCredito
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

        Public Sub New(ventaModel As Model.Venta, facturarCallBack As FacturarDelegateCallBackAsync, tipoDocumentoFiscal As TipoDocumentoFiscal)
            Me.ventaModel = ventaModel
            Me.FacturarCallBackEvent = facturarCallBack
            Me.Visible = True
            Me.NombreYApellido = String.Empty
            Me.Direccion = String.Empty
            Me.Localidad = String.Empty
            Me.CUIT = String.Empty
            Me.tipoDocumentoFiscal = tipoDocumentoFiscal
            If (tipoDocumentoFiscal = TipoDocumentoFiscal.Factura) Then
                VerificarLimiteFacturacion(_Total)
            End If
            If (tipoDocumentoFiscal = TipoDocumentoFiscal.NotaCredito) Then
                Me.NumeroFacturaOrigen = If(ventaModel.Factura?.NumeroFactura?.First?.Numero, 0)
                Me.PuntoVentaOriginal = ventaModel.Factura?.PuntoVenta
                Me.CondicionIvaOriginal = ventaModel.Factura?.CondicionIVA
            End If
        End Sub

        Public Sub New(ventaModel As Model.Venta, facturarCallBack As FacturarDelegateCallBackAsync, tipoDocumentoFiscal As TipoDocumentoFiscal, desdeReserva As Boolean)
            Me.New(ventaModel, facturarCallBack, tipoDocumentoFiscal)
            Me.desdeReserva = desdeReserva
        End Sub

        Friend Sub AgregarNumeroFacturaManual()
            If (Numerosfacturas.Contains(Numerofactura)) Then
                Throw New NegocioException($"El número de factura {Numerofactura} ya se encuentra ingresado. Por favor, ingrese otro número de factura")
            End If

            Numerosfacturas.Add(Numerofactura)
            Numerofactura += 1
            NotifyPropertyChanged(NameOf(Me.Numerofactura))
            NotifyPropertyChanged(NameOf(Me.Numerosfacturas))
        End Sub

        Friend Sub QuitarNumeroFacturaManual(numerofactura As Integer)
            Numerosfacturas.Remove(numerofactura)
        End Sub

        Friend Async Function FacturarAsync() As Task(Of Boolean)
            If (TiposFacturaSeleccionada = TipoFactura.Manual AndAlso Numerosfacturas.Count = 0) Then
                MessageBox.Show("Error al registrar la factura. Debe ingresar un número de factura.", "Registro de Ventas", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return False
            End If

            If ((CondicionesIVASeleccionada = CondicionIVA.Responsable_Inscripto OrElse CondicionesIVASeleccionada = CondicionIVA.Monotributo OrElse CondicionesIVASeleccionada = CondicionIVA.Exento) AndAlso Helper.Cuit.Validar(CUIT)) Then
                MessageBox.Show("Error al registrar la factura. El CUIL ingresado es incorrecto o se encuentra vacío.", "Registro de Ventas", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return False
            End If

            If (ventaModel.TipoCliente = Enums.TipoCliente.Mayorista AndAlso (String.IsNullOrEmpty(NombreYApellido) OrElse String.IsNullOrEmpty(Direccion) OrElse String.IsNullOrEmpty(Localidad) OrElse String.IsNullOrEmpty(CUIT))) Then
                MessageBox.Show("Error al registrar la factura. Debe completar todos los campos obligatorios.", "Registro de Ventas", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return False
            End If

            Dim ticketProducto As IList(Of TicketProducto) = New List(Of TicketProducto)
            Dim ticketPago As IList(Of TicketPago) = New List(Of TicketPago)

            If (desdeReserva) Then
                ticketProducto.Add(New TicketProducto("senia", "Seña", 1, ventaModel.Pagos.Sum(Function(x) x.MontoPago.Monto)))
            Else
                ventaModel.VentaItems.ToList().ForEach(Sub(x) ticketProducto.Add(New TicketProducto(x.CodigoProducto, x.NombreProducto, x.Cantidad, x.MontoProducto.Valor)))
            End If

            ventaModel.Pagos.ToList().ForEach(Sub(x) ticketPago.Add(New TicketPago(x.TipoPago, x.MontoPago.Monto, x.MontoPago.Descuento, x.MontoPago.CFT, x.NumeroCuotas)))

            Dim numerosFactura As List(Of Integer) = Servicio.FacturarService(TiposFacturaSeleccionada, ventaModel.TipoCliente, CondicionesIVASeleccionada, ticketPago, ticketProducto, ventaModel.PorcentajeFacturacion, NombreYApellido, Direccion, Localidad, CUIT)
            numerosFactura.ForEach(Sub(x) Numerosfacturas.Add(x))

            ventaModel.AgregarFactura(ObtenerPuntoVenta,
                                    TiposFacturaSeleccionada,
                                    CondicionesIVASeleccionada,
                                    NombreYApellido,
                                    Direccion,
                                    Localidad,
                                    CUIT,
                                    ventaModel.Pagos.Sum(Function(x) x.MontoPago.Monto),
                                    Numerosfacturas.ToList())

            Visible = False
            Await FacturarCallBackEvent(True, ventaModel)
            Return True
        End Function

        Friend Async Function NotaCreditoAsync() As Task(Of Boolean)
            If (TiposFacturaSeleccionada = TipoFactura.Manual AndAlso Numerosfacturas.Count = 0) Then
                MessageBox.Show("Error al registrar la nota de crédito. Debe ingresar un número de nota de crédito.", "Registro de Ventas", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return False
            End If

            If ((CondicionesIVASeleccionada = CondicionIVA.Responsable_Inscripto OrElse CondicionesIVASeleccionada = CondicionIVA.Monotributo OrElse CondicionesIVASeleccionada = CondicionIVA.Exento) AndAlso Helper.Cuit.Validar(CUIT)) Then
                MessageBox.Show("Error al registrar la nota de crédito. El CUIL ingresado es incorrecto o se encuentra vacío.", "Registro de Ventas", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return False
            End If

            If (String.IsNullOrEmpty(NombreYApellido) OrElse String.IsNullOrEmpty(Direccion) OrElse String.IsNullOrEmpty(Localidad) OrElse String.IsNullOrEmpty(CUIT) OrElse NumeroFacturaOrigen < 0) Then
                MessageBox.Show("Error al registrar la nota de crédito. Debe completar todos los campos obligatorios.", "Registro de Ventas", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return False
            End If

            Dim ticketProducto As IList(Of TicketProducto) = New List(Of TicketProducto)
            Dim ticketPago As IList(Of TicketPago) = New List(Of TicketPago)

            If (desdeReserva) Then
                ticketProducto.Add(New TicketProducto("senia", "Seña", 1, ventaModel.Pagos.Sum(Function(x) x.MontoPago.Monto)))
            Else
                ventaModel.VentaItems.ToList().ForEach(Sub(x) ticketProducto.Add(New TicketProducto(x.CodigoProducto, x.NombreProducto, x.Cantidad, x.MontoProducto.Valor)))
            End If

            ventaModel.Pagos.ToList().ForEach(Sub(x) ticketPago.Add(New TicketPago(x.TipoPago, x.MontoPago.Monto, x.MontoPago.Descuento, x.MontoPago.CFT, x.NumeroCuotas)))

            Dim numerosFactura As List(Of Integer) = Servicio.NotaCreditoService(TiposFacturaSeleccionada, ventaModel.TipoCliente, CondicionesIVASeleccionada, ticketPago, ticketProducto, ventaModel.PorcentajeFacturacion, NombreYApellido, Direccion, Localidad, CUIT, NumeroFacturaOrigen, PuntoVentaOriginal, CondicionIvaOriginal)
            numerosFactura.ForEach(Sub(x) Numerosfacturas.Add(x))

            ventaModel.AgregarNotaCredito(ObtenerPuntoVenta(),
                                            TiposFacturaSeleccionada,
                                            CondicionesIVASeleccionada,
                                            NombreYApellido,
                                            Direccion,
                                            Localidad,
                                            CUIT,
                                            ventaModel.Pagos.Sum(Function(x) x.MontoPago.Monto),
                                            Numerosfacturas.ToList())

            Visible = False
            Await FacturarCallBackEvent(True, ventaModel)
            Return True
        End Function

        Friend Sub Cancelar()
            FacturarCallBackEvent(False, ventaModel)
        End Sub

        Friend Sub TipoFacturacionChange(tiposFactura As Enums.TipoFactura)
            TiposFacturaSeleccionada = tiposFactura
            NotifyPropertyChanged(NameOf(Me.TiposFacturaSeleccionada))
        End Sub

        Public Async Function CargarDatosAsync() As Task
            CargarMontos()
            Dim tareas As List(Of Task) = New List(Of Task)()

            If (ventaModel.TipoCliente = Enums.TipoCliente.Mayorista) Then
                tareas.Add(CargarClienteMayoristaAsync())
            End If

            tareas.Add(CargarNumeroFacturaAsync())
            Await Task.WhenAll(tareas)
        End Function

        Public Sub CargarMontos()
            _Fecha = DateTime.Now()
            _Subtotal = ventaModel.PagoTotal.Monto * ventaModel.PorcentajeFacturacion
            _Descuento = ventaModel.PagoTotal.Descuento * ventaModel.PorcentajeFacturacion
            _CostoFinanciero = ventaModel.PagoTotal.CFT * ventaModel.PorcentajeFacturacion
            _Iva = ventaModel.PagoTotal.IVA
            _Total = (ventaModel.PagoTotal.Monto - ventaModel.PagoTotal.Descuento + ventaModel.PagoTotal.CFT) * ventaModel.PorcentajeFacturacion + ventaModel.PagoTotal.IVA
        End Sub

        Public Async Function CargarNumeroFacturaAsync() As Task
            _Numerofactura = Await Task.Run(Function() Servicio.ObtenerUltimoNumeroFactura(Enums.TipoFactura.Manual) + 1)
            _Numerosfacturas = New BindingList(Of Integer)()

            NotifyPropertyChanged(NameOf(Me.Numerofactura))
            NotifyPropertyChanged(NameOf(Me.Numerosfacturas))
        End Function

        Public Async Function CargarClienteMayoristaAsync() As Task
            Dim clienteMayorista As ClienteMayorista = Await Task.Run(Function() Comunes.Servicio.ObtenerClienteMayorista(ventaModel.IdClienteMayorista))
            CondicionesIVASeleccionada = clienteMayorista.CondicionIVA
            NombreYApellido = clienteMayorista.RazonSocial
            Direccion = clienteMayorista.DomicilioFacturacion?.Direccion
            Localidad = clienteMayorista.DomicilioFacturacion?.Localidad.Descripcion
            CUIT = clienteMayorista.Cuit

            NotifyPropertyChanged(NameOf(Me.CondicionesIVASeleccionada))
            NotifyPropertyChanged(NameOf(Me.NombreYApellido))
            NotifyPropertyChanged(NameOf(Me.Direccion))
            NotifyPropertyChanged(NameOf(Me.Localidad))
            NotifyPropertyChanged(NameOf(Me.CUIT))
        End Function

        Private Function ObtenerPuntoVenta() As Integer
            Select Case TiposFacturaSeleccionada
                Case TipoFactura.Manual
                    Return My.Settings.PuntoVentaFacturacionManual
                Case TipoFactura.Ticket
                    Return My.Settings.PuntoVentaFacturacionTicket
                Case TipoFactura.Electronica
                    Return My.Settings.PuntoVentaFacturacionElectronica
                Case Else
                    Throw New NegocioException($"No se puede identificar un punto de venta para el tipo de facturacion {TiposFacturaSeleccionada}")
            End Select
        End Function

        Private Sub VerificarLimiteFacturacion(monto As Decimal)
            Dim MontoMaximo As Decimal = 0

            Select Case TiposFacturaSeleccionada
                Case Enums.TipoFactura.Manual
                    MontoMaximo = My.Settings.MontoTopeFacturacionManual
                Case Enums.TipoFactura.Electronica
                    MontoMaximo = My.Settings.MontoTopeFacturacionElectronica
                Case Enums.TipoFactura.Ticket
                    MontoMaximo = My.Settings.MontoTopeFaturacionTicket
            End Select

            If (monto > MontoMaximo) Then
                LimiteFacturacion = True
            Else
                LimiteFacturacion = False
            End If
        End Sub
    End Class
End Namespace
