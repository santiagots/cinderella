Imports System.ComponentModel
Imports Common.Core.Extension
Imports Enums = Common.Core.Enum
Imports Common.Core.Exceptions
Imports System.Threading.Tasks
Imports Helper = Common.Core.Helper
Imports Common.Core.Model
Imports Common.Core.Enum
Imports Model = Ventas.Core.Model.VentaAggregate
Imports SistemaCinderella.Formularios.Venta.frmVentasViewModel
Imports Common.Service.NotaCredito
Imports Factura.Service.Factura
Imports Factura.Service.NotaCredito.Contracts
Imports Factura.Service.Factura.Contracts
Imports Factura.Service.Common.Contracts
Imports Ventas.Core.Model.VentaAggregate
Imports Ventas.Core.Model.ValueObjects

Namespace Formularios.Facturacion
    Public Class frmFacturarViewModel
        Inherits Comunes.Common

        Private FacturarCallBackEvent As FacturarDelegateCallBackAsync

        Private desdeReserva As Boolean
        Private tipoDocumentoFiscal As TipoDocumentoFiscal
        Private CondicionIvaOriginal As CondicionIVA
        Private PuntoVentaOriginal As Integer

        Public ventaModel As Model.Venta

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
        Public Property CondicionesIVA As BindingList(Of Enums.CondicionIVA)
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

        Public ReadOnly Property HabilitarNombreYAplellido As Boolean
            Get
                Return CondicionesIVASeleccionada = CondicionIVA.Responsable_Inscripto OrElse CondicionesIVASeleccionada = CondicionIVA.Monotributo OrElse CondicionesIVASeleccionada = CondicionIVA.Exento OrElse tipoDocumentoFiscal = TipoDocumentoFiscal.NotaCredito
            End Get
        End Property

        Public ReadOnly Property HabilitarDireccion As Boolean
            Get
                Return CondicionesIVASeleccionada = CondicionIVA.Responsable_Inscripto OrElse CondicionesIVASeleccionada = CondicionIVA.Monotributo OrElse CondicionesIVASeleccionada = CondicionIVA.Exento OrElse tipoDocumentoFiscal = TipoDocumentoFiscal.NotaCredito
            End Get
        End Property

        Public ReadOnly Property HabilitarLocalidad As Boolean
            Get
                Return CondicionesIVASeleccionada = CondicionIVA.Responsable_Inscripto OrElse CondicionesIVASeleccionada = CondicionIVA.Monotributo OrElse CondicionesIVASeleccionada = CondicionIVA.Exento OrElse tipoDocumentoFiscal = TipoDocumentoFiscal.NotaCredito
            End Get
        End Property

        Public ReadOnly Property HabilitarCUIT As Boolean
            Get
                Return CondicionesIVASeleccionada = CondicionIVA.Responsable_Inscripto OrElse CondicionesIVASeleccionada = CondicionIVA.Monotributo OrElse CondicionesIVASeleccionada = CondicionIVA.Exento OrElse TiposFacturaSeleccionada = TipoFactura.Electronica OrElse tipoDocumentoFiscal = TipoDocumentoFiscal.NotaCredito
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
            CargarCondicionesIva(ventaModel.TipoCliente)
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
            If (Not RequeridosCompletos()) Then
                Return False
            End If

            Dim obtenerNumeroFacturaRequest As ObtenerNumeroFacturaRequest = New ObtenerNumeroFacturaRequest() With {
                .CondicionIVA = CondicionesIVASeleccionada,
                .Cuit = CUIT,
                .Direccion = Direccion,
                .Localidad = Localidad,
                .NombreYApellido = NombreYApellido,
                .Pagos = New List(Of PagoRequest)(),
                .PorcentajeFacturacion = ventaModel.PorcentajeFacturacion,
                .Productos = New List(Of ProductoRequest)(),
                .TipoCliente = ventaModel.TipoCliente,
                .NumerosFacturas = Numerosfacturas.ToList()
            }

            obtenerNumeroFacturaRequest.Productos = ObtenerProductoRequest(desdeReserva, ventaModel.PorcentajeFacturacion, ventaModel.TipoCliente, CondicionesIVASeleccionada, ventaModel.VentaItems)
            obtenerNumeroFacturaRequest.Pagos = ObtenerPagoRequest(ventaModel.PorcentajeFacturacion, ventaModel.TipoCliente, ventaModel.VentaItems, ventaModel.Pagos)

            Dim facturar As FacturarService = New FacturarService(TiposFacturaSeleccionada, VariablesGlobales.RutaCertificadoFacturacionElectronica, VariablesGlobales.PasswordCertificadoFacturacionElectronica)
            Dim ObtenerNumeroFacturaResponse As ObtenerNumeroFacturaResponse = facturar.ObtenerNumeroFactura(obtenerNumeroFacturaRequest)

            ventaModel.AgregarFactura(ObtenerPuntoVenta,
                                    TiposFacturaSeleccionada,
                                    CondicionesIVASeleccionada,
                                    NombreYApellido,
                                    Direccion,
                                    Localidad,
                                    CUIT,
                                    ObtenerNumeroFacturaResponse.SubTotal,
                                    ObtenerNumeroFacturaResponse.Iva,
                                    ObtenerNumeroFacturaResponse.Total,
                                    ObtenerNumeroFacturaResponse.NumeroFactura,
                                    ObtenerNumeroFacturaResponse.CAE,
                                    ObtenerNumeroFacturaResponse.FechaVencimientoCAE)

            Visible = False
            Await FacturarCallBackEvent(True, ventaModel)
            Return True
        End Function

        Friend Async Function NotaCreditoAsync() As Task(Of Boolean)
            If (Not RequeridosCompletos()) Then
                Return False
            End If

            Dim ObtenerNumeroNotaCretidoRequest As ObtenerNumeroNotaCretidoRequest = New ObtenerNumeroNotaCretidoRequest() With {
                .CondicionIVA = CondicionesIVASeleccionada,
                .Cuit = CUIT,
                .CondicionIVAOriginal = CondicionIvaOriginal,
                .Direccion = Direccion,
                .Localidad = Localidad,
                .NombreYApellido = NombreYApellido,
                .NumeroFacturaOrigen = NumeroFacturaOrigen,
                .Pagos = New List(Of PagoRequest)(),
                .PorcentajeFacturacion = ventaModel.PorcentajeFacturacion,
                .Productos = New List(Of ProductoRequest)(),
                .PuntoVentaOrigen = PuntoVentaOriginal,
                .TipoCliente = ventaModel.TipoCliente,
                .NumerosNotaCredito = Numerosfacturas.ToList()
            }

            ObtenerNumeroNotaCretidoRequest.Productos = ObtenerProductoRequest(desdeReserva, ventaModel.PorcentajeFacturacion, ventaModel.TipoCliente, CondicionesIVASeleccionada, ventaModel.VentaItems)
            ObtenerNumeroNotaCretidoRequest.Pagos = ObtenerPagoRequest(ventaModel.PorcentajeFacturacion, ventaModel.TipoCliente, ventaModel.VentaItems, ventaModel.Pagos)

            Dim notaCredito As NotaCreditoService = New NotaCreditoService(TiposFacturaSeleccionada, VariablesGlobales.RutaCertificadoFacturacionElectronica, VariablesGlobales.PasswordCertificadoFacturacionElectronica)
            Dim ObtenerNumeroNotaCretidoResponse As ObtenerNumeroNotaCretidoResponse = notaCredito.ObtenerNumeroNotaCretido(ObtenerNumeroNotaCretidoRequest)

            ventaModel.AgregarNotaCredito(ObtenerPuntoVenta(),
                                            TiposFacturaSeleccionada,
                                            CondicionesIVASeleccionada,
                                            NombreYApellido,
                                            Direccion,
                                            Localidad,
                                            CUIT,
                                            ObtenerNumeroNotaCretidoResponse.SubTotal,
                                            ObtenerNumeroNotaCretidoResponse.Iva,
                                            ObtenerNumeroNotaCretidoResponse.Total,
                                            ObtenerNumeroNotaCretidoResponse.NumeroNotaCredito,
                                            ObtenerNumeroNotaCretidoResponse.CAE,
                                            ObtenerNumeroNotaCretidoResponse.FechaVencimientoCAE)

            Visible = False
            Await FacturarCallBackEvent(True, ventaModel)
            Return True
        End Function

        Private Function RequeridosCompletos() As Boolean
            If (TiposFacturaSeleccionada = TipoFactura.Manual AndAlso Numerosfacturas.Count = 0) Then
                MessageBox.Show("Error al registrar la factura. Debe ingresar un número de factura.", "Registro de Ventas", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return False
            End If

            If ventaModel.TipoCliente = Enums.TipoCliente.Mayorista AndAlso HabilitarCUIT AndAlso Not Helper.Cuit.EsValido(CUIT) Then
                MessageBox.Show("Error al registrar la factura. El CUIL/DNI ingresado es incorrecto o se encuentra vacío.", "Registro de Ventas", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return False
            End If

            If (HabilitarNombreYAplellido AndAlso String.IsNullOrEmpty(NombreYApellido)) OrElse
               (HabilitarDireccion AndAlso String.IsNullOrEmpty(Direccion)) OrElse
               (HabilitarLocalidad AndAlso String.IsNullOrEmpty(Localidad)) Then
                MessageBox.Show("Error al registrar la factura. Debe completar todos los campos obligatorios.", "Registro de Ventas", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return False
            End If

            Return True
        End Function

        Friend Sub Cancelar()
            FacturarCallBackEvent(False, ventaModel)
        End Sub

        Friend Sub TipoFacturacionChange(tiposFactura As Enums.TipoFactura)
            TiposFacturaSeleccionada = tiposFactura
            NotifyPropertyChanged(NameOf(Me.TiposFacturaSeleccionada))
        End Sub

        Friend Sub CondicionesIVAChange(condicionesIVA As Enums.CondicionIVA)
            CondicionesIVASeleccionada = condicionesIVA
            NotifyPropertyChanged(NameOf(Me.CondicionesIVASeleccionada))
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
            _Numerofactura = Await Task.Run(Function() Servicio.ObtenerUltimoNumeroFactura(ventaModel.IdSucursal, Enums.TipoFactura.Manual) + 1)
            _Numerosfacturas = New BindingList(Of Integer)()

            NotifyPropertyChanged(NameOf(Me.Numerofactura))
            NotifyPropertyChanged(NameOf(Me.Numerosfacturas))
        End Function

        Public Async Function CargarClienteMayoristaAsync() As Task
            Dim clienteMayorista As Common.Core.Model.ClienteMayorista = Await Task.Run(Function() Comunes.Servicio.ObtenerClienteMayorista(ventaModel.IdClienteMayorista))
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

        Public Sub CargarCondicionesIva(tipoCliente As TipoCliente)

            CondicionesIVA = New BindingList(Of CondicionIVA)()

            If (tipoCliente = TipoCliente.Minorista) Then
                CondicionesIVA.Add(CondicionIVA.Consumidor_Final)
                CondicionesIVA.Add(CondicionIVA.Exento)
                CondicionesIVA.Add(CondicionIVA.Monotributo)
                CondicionesIVA.Add(CondicionIVA.Responsable_Inscripto)
            Else
                CondicionesIVA.Add(CondicionIVA.Exento)
                CondicionesIVA.Add(CondicionIVA.Monotributo)
                CondicionesIVA.Add(CondicionIVA.Responsable_Inscripto)
            End If
            NotifyPropertyChanged(NameOf(Me.CondicionesIVA))
        End Sub

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

        Private Function ObtenerProductoRequest(desdeReserva As Boolean, porcentajeFacturacion As Decimal, tipoCliente As TipoCliente, condicionIva As CondicionIVA, ventaItems As List(Of VentaItem)) As List(Of ProductoRequest)

            Dim request As List(Of ProductoRequest) = New List(Of ProductoRequest)()

            If (desdeReserva) Then
                request.Add(New ProductoRequest() With {
                    .Cantidad = 1,
                    .Codigo = "senia",
                    .Nombre = "Seña",
                    .MontoUnitario = ventaModel.Pagos.Sum(Function(x) x.MontoPago.Monto),
                    .DescuentoUnitario = ventaModel.Pagos.Sum(Function(x) x.MontoPago.Descuento),
                    .CFTUnitario = ventaModel.Pagos.Sum(Function(x) x.MontoPago.CFT),
                    .IVA = Servicio.ObtenerIVA(0.21)})
            Else
                For Each ventaItem As VentaItem In ventaItems

                    request.Add(New ProductoRequest() With {
                            .Cantidad = ventaItem.Cantidad,
                            .Codigo = ventaItem.Producto.Codigo,
                            .Nombre = ventaItem.Producto.Nombre,
                            .MontoUnitario = ventaItem.TotalMonto(porcentajeFacturacion, tipoCliente, condicionIva) / ventaItem.Cantidad,
                            .DescuentoUnitario = ventaItem.TotalDescuento(porcentajeFacturacion, tipoCliente, condicionIva) / ventaItem.Cantidad,
                            .CFTUnitario = ventaItem.TotalCFT(porcentajeFacturacion, tipoCliente, condicionIva) / ventaItem.Cantidad,
                            .IVA = ventaItem.Producto.SubCategoria.IVA})
                Next
            End If
            Return request
        End Function

        Private Function ObtenerPagoRequest(pordentajeFacturacion As Decimal, tipoCliente As TipoCliente, itemVenta As List(Of VentaItem), pagos As List(Of Pago)) As List(Of PagoRequest)

            Dim request As List(Of PagoRequest) = New List(Of PagoRequest)()

            'Dim pagos As List(Of Pago) = itemVenta.SelectMany(Of Pago)(Function(x) x.ObtenerPagosDeProducto(pordentajeFacturacion, tipoCliente)).ToList()

            'request = pagos.GroupBy(Function(x) New With {Key x.TipoPago, Key x.NumeroCuotas}) _
            '                .Select(Function(y) New PagoRequest() With {
            '                    .TipoPago = y.Key.TipoPago,
            '                    .NumeroCuotas = y.Key.NumeroCuotas,
            '                    .Monto = y.Sum(Function(z) z.MontoPago.Monto),
            '                    .Descuento = y.Sum(Function(z) z.MontoPago.Descuento),
            '                    .CFT = y.Sum(Function(z) z.MontoPago.CFT),
            '                    .IVA = y.Sum(Function(z) z.MontoPago.IVA)
            '                    }).ToList()

            'Return request

            pagos.ForEach(Sub(x) request.Add(New PagoRequest() With {
                                        .Monto = x.MontoPago.Monto,
                                        .CFT = x.MontoPago.CFT,
                                        .Descuento = x.MontoPago.Descuento,
                                        .IVA = x.MontoPago.IVA,
                                        .TipoPago = x.TipoPago,
                                        .NumeroCuotas = x.NumeroCuotas}))

            Return request
        End Function
    End Class
End Namespace
