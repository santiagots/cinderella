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
Imports Common.Data.Service
Imports Ventas.Core.Model.ValueObjects
Imports Common.Core.Helper
Imports Newtonsoft.Json
Imports SistemaCinderella.Formularios.Comun

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
        Public Property CondicionesIVASeleccionada As Enums.CondicionIVA = CondicionIVA.Consumidor_Final
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

            obtenerNumeroFacturaRequest.Productos = ObtenerProductoRequest(ventaModel.ObtenerItemsVentaSeleccionados(), desdeReserva, CondicionesIVASeleccionada)
            obtenerNumeroFacturaRequest.Pagos = ObtenerPagoRequest(ventaModel.Pagos)
            obtenerNumeroFacturaRequest.Impuestos = ObtenerImpuestosRequest()

            Log.Info("FACTURA - VENTA", ventaModel)
            Log.Info("FACTURA - FFACTURA", ventaModel.Factura)
            Log.Info("FACTURA - REQUEST", obtenerNumeroFacturaRequest)

            'Dim json As String = "{""Numero"":null,""Comisiones"":[],""Pagos"":[{""IdVenta"":5520240903151725513,""Venta"":null,""TipoPago"":2,""MontoPago"":{""Monto"":100.0,""Descuento"":0.0,""CFT"":0.0,""IVA"":0.0,""Total"":100.0},""MontoRestante"":0.0,""Tarjeta"":""Visa"",""NumeroCuotas"":1,""PorcentajeRecargo"":0.0,""NumeroOrdenChequesData"":"""",""IdCuentaBancaria"":null,""CuentaBancaria"":null,""NumeroOrdenCheques"":null,""FechaEdicion"":""2024-09-03T15:17:50.0835652-03:00"",""Habilitado"":true,""Id"":5520240903151750083,""EstadoEntidad"":0}],""Cheques"":[],""VentaItems"":[{""IdVenta"":5520240903151725513,""Venta"":null,""EsDevolucion"":false,""Facturada"":false,""Anulada"":false,""Seleccionado"":true,""PorcentajePago"":1.0,""MontoProducto"":{""Valor"":100.0,""Iva"":0.0},""Cantidad"":1,""Total"":{""Valor"":100.0,""Iva"":0.0},""PorcentajeBonificacion"":0.00,""IdProducto"":38182,""Producto"":{""Codigo"":""varios"",""CodigoBarra"":""7791234381821"",""Nombre"":""VARIOS"",""IdCategoria"":4,""Categoria"":{""Descripcion"":""Varios"",""SubCategorias"":null,""Habilitado"":true,""Id"":4,""EstadoEntidad"":0},""IdSubcategoria"":335,""SubCategoria"":{""IdCategoria"":0,""Categoria"":null,""IdIVA"":5,""IVA"":{""Valor"":0.2100,""Id"":5,""EstadoEntidad"":0},""Descripcion"":""Varios"",""Habilitado"":true,""Id"":335,""EstadoEntidad"":0},""Stock"":{""IdSucursal"":55,""IdProducto"":38182,""Cantidad"":-6,""Minimo"":0,""Optimo"":0,""Reservado"":13,""Disponible"":-19,""Habilitado"":true,""MotivoModificacion"":null,""IdUsuario"":0,""Modificado"":false,""Borrado"":false,""Fecha"":""2023-03-02T13:28:05.53"",""FechaModificacion"":""2023-03-02T00:00:00"",""FechaEdicion"":""2023-03-02T13:28:05.53"",""VentaMensual"":0,""Id"":5520230302132805530,""EstadoEntidad"":0},""Precios"":[{""IdProducto"":38182,""IdLista"":1,""Monto"":0.00,""Habilitado"":true,""Id"":229949,""EstadoEntidad"":0},{""IdProducto"":38182,""IdLista"":2,""Monto"":0.00,""Habilitado"":true,""Id"":229950,""EstadoEntidad"":0},{""IdProducto"":38182,""IdLista"":3,""Monto"":0.00,""Habilitado"":true,""Id"":229951,""EstadoEntidad"":0},{""IdProducto"":38182,""IdLista"":4,""Monto"":0.00,""Habilitado"":true,""Id"":229952,""EstadoEntidad"":0},{""IdProducto"":38182,""IdLista"":5,""Monto"":0.00,""Habilitado"":true,""Id"":229953,""EstadoEntidad"":0},{""IdProducto"":38182,""IdLista"":6,""Monto"":0.00,""Habilitado"":true,""Id"":229954,""EstadoEntidad"":0}],""Id"":38182,""EstadoEntidad"":0},""FechaEdicion"":""2024-09-03T15:17:35.6764725-03:00"",""Id"":5520240903151735676,""EstadoEntidad"":0}],""NotaCredito"":null,""Factura"":null,""Anulado"":false,""MotivoAnulado"":null,""FechaAnulado"":null,""CantidadTotal"":1,""PagoTotal"":{""Monto"":100.0,""Descuento"":0.0,""CFT"":0.0,""IVA"":0.0,""Total"":100.0},""EstaPaga"":true,""TipoCliente"":0,""IdSucursal"":55,""Sucursal"":null,""IdEncargado"":112,""Encargado"":{""Apellido"":""Aloy"",""Nombre"":""Marina"",""Habilitado"":true,""Tipo"":2,""ApellidoYNombre"":""Aloy Marina"",""Id"":112,""EstadoEntidad"":0},""IdVendedor"":91,""Vendedor"":{""Apellido"":""Gomez"",""Nombre"":""Andrea"",""Habilitado"":true,""Tipo"":1,""ApellidoYNombre"":""Gomez Andrea"",""Id"":91,""EstadoEntidad"":0},""PorcentajeFacturacion"":1.0,""IdClienteMayorista"":null,""ClienteMayorista"":null,""Fecha"":""2024-09-03T15:17:25.5132497-03:00"",""FechaEdicion"":""2024-09-03T15:17:25.5132497-03:00"",""MontoTotal"":{""Valor"":100.0,""Iva"":0.0},""Id"":5520240903151725513,""EstadoEntidad"":0}"

            'ventaModel = JsonConvert.DeserializeObject(Of Model.Venta)(json)

            Dim ObtenerNumeroFacturaResponse As ObtenerNumeroFacturaResponse = New ObtenerNumeroFacturaResponse() With {
                .SubTotal = 123,
                .Iva = 123,
                .Total = 123,
                .NumeroFactura = New List(Of Integer) From {1},
                .CAE = "1234567890",
                .FechaVencimientoCAE = DateTime.Now.AddDays(7)
                }

            'Dim facturar As FacturarService = New FacturarService(TiposFacturaSeleccionada, VariablesGlobales.RutaCertificadoFacturacionElectronica, VariablesGlobales.PasswordCertificadoFacturacionElectronica)
            'Dim ObtenerNumeroFacturaResponse As ObtenerNumeroFacturaResponse = facturar.ObtenerNumeroFactura(obtenerNumeroFacturaRequest)

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

            ObtenerNumeroNotaCretidoRequest.Productos = ObtenerProductoRequest(ventaModel.ObtenerItemsVentaSeleccionadosYFacturados(), desdeReserva, CondicionesIVASeleccionada)
            ObtenerNumeroNotaCretidoRequest.Pagos = ObtenerPagoRequest(ventaModel.Pagos)

            Dim notaCredito As NotaCreditoService = New NotaCreditoService(TiposFacturaSeleccionada, VariablesGlobales.RutaCertificadoFacturacionElectronica, VariablesGlobales.PasswordCertificadoFacturacionElectronica)

            Log.Info("NOTA CREDITO - VENTA", ventaModel)
            Log.Info("NOTA CREDITO - FFACTURA", ventaModel.Factura)
            Log.Info("NOTA CREDITO - REQUEST", ObtenerNumeroNotaCretidoRequest)

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
            CargarMontos()
            NotifyPropertyChanged(NameOf(Me.CondicionesIVASeleccionada))
        End Sub

        Public Async Function CargarDatosAsync() As Task
            Dim tareas As List(Of Task) = New List(Of Task)()

            If (ventaModel.TipoCliente = Enums.TipoCliente.Mayorista) Then
                tareas.Add(CargarClienteMayoristaAsync())
            End If

            tareas.Add(CargarNumeroFacturaAsync())
            Await Task.WhenAll(tareas)

            CargarMontos()
        End Function

        Public Sub CargarMontos()
            Fecha = DateTime.Now()

            Dim MontoTotalPagoFacturable As MontoPago = New MontoPago(0, 0, 0, 0)

            If (tipoDocumentoFiscal = TipoDocumentoFiscal.Factura) Then
                MontoTotalPagoFacturable = ventaModel.TotalSeleccionado(CondicionesIVASeleccionada)
            Else
                MontoTotalPagoFacturable = ventaModel.TotalSeleccionadosYFacturados(CondicionesIVASeleccionada)
            End If

            Subtotal = MontoTotalPagoFacturable.Monto
            Descuento = MontoTotalPagoFacturable.Descuento
            CostoFinanciero = MontoTotalPagoFacturable.CFT
            Iva = MontoTotalPagoFacturable.IVA
            Total = MontoTotalPagoFacturable.Total

            NotifyPropertyChanged(NameOf(Me.Subtotal))
            NotifyPropertyChanged(NameOf(Me.Descuento))
            NotifyPropertyChanged(NameOf(Me.CostoFinanciero))
            NotifyPropertyChanged(NameOf(Me.Iva))
            NotifyPropertyChanged(NameOf(Me.Total))

        End Sub

        Public Async Function CargarNumeroFacturaAsync() As Task
            _Numerofactura = Await Task.Run(Function() Servicio.ObtenerUltimoNumeroFactura(ventaModel.IdSucursal, Enums.TipoFactura.Manual) + 1)
            _Numerosfacturas = New BindingList(Of Integer)()

            NotifyPropertyChanged(NameOf(Me.Numerofactura))
            NotifyPropertyChanged(NameOf(Me.Numerosfacturas))
        End Function

        Public Async Function CargarClienteMayoristaAsync() As Task
            Dim clienteMayorista As Common.Core.Model.ClienteMayorista = Await ClienteMayoristaService.ObtenerAsync(TipoBase.Local, ventaModel.IdClienteMayorista)
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

        Private Function ObtenerProductoRequest(ventaItems As List(Of VentaItem), desdeReserva As Boolean, condicionIva As CondicionIVA) As List(Of ProductoRequest)

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

                    Dim montoPago As MontoPago = ventaItem.TotalPago(ventaModel.PorcentajeFacturacion, ventaModel.TipoCliente, condicionIva)

                    request.Add(New ProductoRequest() With {
                            .Cantidad = ventaItem.Cantidad,
                            .Codigo = ventaItem.Producto.Codigo,
                            .Nombre = ventaItem.Producto.Nombre,
                            .MontoUnitario = montoPago.Monto / ventaItem.Cantidad,
                            .DescuentoUnitario = montoPago.Descuento / ventaItem.Cantidad,
                            .CFTUnitario = montoPago.CFT / ventaItem.Cantidad,
                            .IVA = ventaItem.Producto.SubCategoria.IVA})
                Next
            End If
            Return request
        End Function

        Private Function ObtenerPagoRequest(pagos As List(Of VentaPago)) As List(Of PagoRequest)

            Dim request As List(Of PagoRequest) = New List(Of PagoRequest)()

            pagos.ForEach(Sub(x) request.Add(New PagoRequest() With {
                                        .Monto = x.MontoPago.Monto,
                                        .CFT = x.MontoPago.CFT,
                                        .Descuento = x.MontoPago.Descuento,
                                        .IVA = x.MontoPago.IVA,
                                        .TipoPago = x.TipoPago,
                                        .NumeroCuotas = x.NumeroCuotas}))

            Return request
        End Function

        Private Function ObtenerImpuestosRequest() As List(Of ImpuestoRequest)

            Dim request As List(Of ImpuestoRequest) = New List(Of ImpuestoRequest)()

            If (Not My.Settings.FacturaHabilitarImpuestos) Then
                Return request
            End If

            Dim Inpuestos As List(Of FacturacionImpuestosViewModel) = JsonConvert.DeserializeObject(Of List(Of FacturacionImpuestosViewModel))(My.Settings.FacturaImpuestos)

            ''fuerzo los calculos totales con la condicion Responsable Inscripto para obtener los totales discriminando el IVA
            Dim MontoTotalPagoFacturable As MontoPago = ventaModel.TotalSeleccionado(CondicionIVA.Responsable_Inscripto)

            request.Add(New ImpuestoRequest() With {
                            .Descripcion = My.Settings.FacturaEncabezadoImpuestos})

            If (My.Settings.FacturaIVADiscirimiar) Then
                request.Add(New ImpuestoRequest() With {
                            .Monto = MontoTotalPagoFacturable.IVA,
                            .Descripcion = My.Settings.FacturaIVADescripcion})
            End If

            If Inpuestos IsNot Nothing Then
                For Each impuesto As FacturacionImpuestosViewModel In Inpuestos
                    request.Add(New ImpuestoRequest() With {
                            .Monto = MontoTotalPagoFacturable.Total * impuesto.Porcentaje + impuesto.Monto,
                            .Descripcion = impuesto.Descripcion})

                Next
            End If

            Return request

        End Function
    End Class
End Namespace
