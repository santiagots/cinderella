Imports System.ComponentModel
Imports System.Threading.Tasks
Imports AutoMapper
Imports Common.Core.Enum
Imports Common.Core.Exceptions
Imports Common.Core.Model
Imports Ventas.Core.Model.BaseAgreggate
Imports Ventas.Core.Model.CuentaCorrienteAggregate
Imports Ventas.Core.Model.ValueObjects
Imports Ventas.Core.Model.VentaAggregate
Imports Ventas.Data.Service
Imports Common.Data.Service
Imports ModelCheque = Ventas.Core.Model.ChequeAggregate

Namespace Formularios.Cliente
    Public Class frmClienteMayoristaDocumentoPagoViewModel
        Inherits Comunes.Common

        Private DocumentoDePagoModel As DocumentoDePago
        Private SucursalModel As Sucursal

        Public ReadOnly Property Sucursal As String
            Get
                Return SucursalModel?.Nombre
            End Get
        End Property
        Public Property Fecha As DateTime = Date.Now
        Public Property EncargadoSeleccionado As Empleado
            Get
                Return DocumentoDePagoModel.Encargado
            End Get
            Set(value As Empleado)
                DocumentoDePagoModel.AgregarEncargado(value)
            End Set
        End Property

        Public ReadOnly Property Encargados As BindingList(Of Empleado)

        Public Property FormaPagoSeleccionado As TipoPago
        Public ReadOnly Property FormaPago As BindingList(Of TipoPago)
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

        Public Property Cft As Decimal

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

        Public Property HabilitarPagos As Boolean
        Public Property HabilitarAnular As Boolean
        Public Property HabilitarImprimir As Boolean
        Public Property MotivoAnulacion As String
        Public ReadOnly Property FechaAnulacion As DateTime?
            Get
                Return DocumentoDePagoModel.FechaAnulado
            End Get
        End Property

        Public ReadOnly Property Pagos As BindingList(Of ClienteMayoristaDocumentoPagoItem)
            Get
                Return New BindingList(Of ClienteMayoristaDocumentoPagoItem)(
                    Mapper.Map(Of List(Of ClienteMayoristaDocumentoPagoItem))(DocumentoDePagoModel.Pagos))
            End Get
        End Property

        Public ReadOnly Property TotalPago As BindingList(Of ClienteMayoristaDocumentoPagoItem)
            Get
                Dim clienteMayoristaDocumentoPagoItem As ClienteMayoristaDocumentoPagoItem = New ClienteMayoristaDocumentoPagoItem() With {
                    .Cft = DocumentoDePagoModel.PagoTotal.CFT,
                    .Monto = DocumentoDePagoModel.PagoTotal.Monto,
                    .Total = DocumentoDePagoModel.PagoTotal.Total,
                    .Descripcion = "Total"
                    }
                Dim list As BindingList(Of ClienteMayoristaDocumentoPagoItem) = New BindingList(Of ClienteMayoristaDocumentoPagoItem)
                list.Add(clienteMayoristaDocumentoPagoItem)

                Return list
            End Get
        End Property

        Public ReadOnly Property HabilitarFinalizar As Boolean
            Get
                Return DocumentoDePagoModel.Pagos.Count > 0 AndAlso HabilitarPagos
            End Get
        End Property

        Public Sub New(idSucursal As Integer, clienteMayorista As ClienteMayorista)
            Me.HabilitarPagos = True
            Me.HabilitarImprimir = False
            Me.HabilitarAnular = False
            DocumentoDePagoModel = New DocumentoDePago(idSucursal, clienteMayorista)
        End Sub

        Public Sub New(documentoDePago As DocumentoDePago)
            Me.HabilitarPagos = False
            Me.HabilitarImprimir = True
            Me.HabilitarAnular = Not documentoDePago.Anulado
            Me.MotivoAnulacion = documentoDePago.MotivoAnulado
            Me.DocumentoDePagoModel = documentoDePago
        End Sub

        Public Async Function CargarTarjetasAsync() As Task
            Dim tarjetas As List(Of Tarjeta) = Await TarjetaService.ObtenerAsync()

            _Tarjeta = New BindingList(Of KeyValuePair(Of Tarjeta, String))(tarjetas.Select(Function(x) New KeyValuePair(Of Tarjeta, String)(x, x.Nombre)).ToList)
            NotifyPropertyChanged(NameOf(Me.Tarjeta))
        End Function

        Public Async Function CargarCostoFinancieroAsync() As Task
            Dim costoFinanciero As List(Of CostoFinanciero) = Await CostoFinancieroService.ObtenerAsync(TarjetaSeleccionada.Id)

            _Cuota = New BindingList(Of KeyValuePair(Of CostoFinanciero, String))(costoFinanciero.Select(Function(x) New KeyValuePair(Of CostoFinanciero, String)(x, x.NumeroCuota)).ToList)
            NotifyPropertyChanged(NameOf(Me.Tarjeta))
        End Function

        Public Async Function CargarEmpleadosAsync() As Task
            Dim encargados As List(Of Empleado) = Await EmpleadoService.ObtenerEmpleados(TipoEmpleado.Encargado, DocumentoDePagoModel.IdSucursal)
            _Encargados = New BindingList(Of Empleado)(encargados)
            EncargadoSeleccionado = _Encargados.FirstOrDefault()

            NotifyPropertyChanged(NameOf(Me.Encargados))
            NotifyPropertyChanged(NameOf(Me.EncargadoSeleccionado))
        End Function

        Public Async Function CargarSucursalAsync() As Task
            SucursalModel = Await SucursalService.Obtener(DocumentoDePagoModel.IdSucursal)
            NotifyPropertyChanged(NameOf(Me.Sucursal))
        End Function

        Friend Async Function AnularAsync() As Task
            DocumentoDePagoModel.Anular(MotivoAnulacion + $" {VariablesGlobales.objUsuario.Apellido}, {VariablesGlobales.objUsuario.Nombre}")
            Await DocumentoDePagoService.ActualizarAsync(TipoBase.Remota, DocumentoDePagoModel)

            Await ActualizarMontoCuentaCorrienteAsync(TipoAccionCuentaCorriente.Débito)
        End Function

        Friend Sub AgregarPago()
            Dim numeroCuota As Integer = If(CuotaSeleccionado?.NumeroCuota, 0)
            Dim tarjeta As String = If(TarjetaSeleccionada?.Nombre, "")
            Dim cheques As List(Of ModelCheque.Cheque) = New List(Of ModelCheque.Cheque)
            Dim cuentaBancaria As Common.Core.Model.CuentaBancaria = Nothing

            Select Case FormaPagoSeleccionado
                Case TipoPago.Cheque
                    Cheques = ObtenerCheque(Total)
                Case TipoPago.Deposito
                    cuentaBancaria = ObtenerCuentaBancaria()
            End Select

            DocumentoDePagoModel.AgregaPago(Subtotal, Cft, FormaPagoSeleccionado, CuotaCft, tarjeta, numeroCuota, cheques, cuentaBancaria)

            _Subtotal = 0
            _Cft = 0
            _Total = 0

            NotifyPropertyChanged(NameOf(Me.Pagos))
            NotifyPropertyChanged(NameOf(Me.TotalPago))
        End Sub

        Friend Sub QuitarPago(pago As ClienteMayoristaDocumentoPagoItem)
            DocumentoDePagoModel.QuitarPago(pago.Id)

            NotifyPropertyChanged(NameOf(Me.Pagos))
            NotifyPropertyChanged(NameOf(Me.TotalPago))
        End Sub

        Public Sub CargarFormaPago()
            _FormaPago = New BindingList(Of TipoPago)(TipoPagoService.Obtener())
            FormaPagoSeleccionado = _FormaPago.FirstOrDefault()
            NotifyPropertyChanged(NameOf(Me.FormaPago))
        End Sub

        Friend Sub FormaPagoChange(tipoPago As TipoPago)
            FormaPagoSeleccionado = tipoPago
            TarjetaSeleccionada = Nothing
            CuotaSeleccionado = Nothing
            CuotaCft = 0
        End Sub

        Friend Async Function TarjetaChangeAsync(tarjeta As Tarjeta) As Task
            TarjetaSeleccionada = tarjeta
            CuotaSeleccionado = Nothing
            CuotaCft = 0
            Await CargarCostoFinancieroAsync()
        End Function

        Friend Sub CuotaChange(cuota As CostoFinanciero)
            CuotaSeleccionado = cuota
            CuotaCft = cuota.PorcentajeRecargo

            CalcularPagoDesdeSubtotal(Subtotal)
            NotifyPropertyChanged(NameOf(Me.CuotaCft))
        End Sub

        Friend Async Function GuardarAsync() As Task
            Await GuardarDocumentoDePagoAsync()
            Await ActualizarMontoCuentaCorrienteAsync(TipoAccionCuentaCorriente.Crédito)
        End Function

        Friend Sub ImprimirMovimiento()
            Dim frmReporteDocumentoPagol As frmReporteDocumentoPagol = New frmReporteDocumentoPagol(DocumentoDePagoModel.Id)
            frmReporteDocumentoPagol.ShowDialog()
        End Sub

        Friend Sub CalcularPagoDesdeSubtotal(subtotal As Decimal)
            Dim motoAPagar As MontoPago = DocumentoDePagoModel.ObtenerMontoPagoDesdeSubtotal(subtotal, CuotaCft)
            ActualizarPago(motoAPagar)
        End Sub

        Friend Sub CalcularPagoDesdeTotal(total As Decimal)
            Dim motoAPagar As MontoPago = DocumentoDePagoModel.ObtenerMontoPagoDesdeTotal(total, CuotaCft)
            ActualizarPago(motoAPagar)
        End Sub

        Private Async Function GuardarDocumentoDePagoAsync() As Task
            Dim codigoVentaSucursal As String = SucursalModel.CodigoVenta
            Dim cantidadVentas As Integer = Await DocumentoDePagoService.CantidadAsync(TipoBase.Remota, DocumentoDePagoModel.IdSucursal)
            DocumentoDePagoModel.GenerarNumero(cantidadVentas + 1, codigoVentaSucursal)

            Await DocumentoDePagoService.GuardarAsync(TipoBase.Remota, DocumentoDePagoModel)
        End Function

        Private Async Function ActualizarMontoCuentaCorrienteAsync(tipoAccionCuentaCorriente As TipoAccionCuentaCorriente) As Task

            Dim monto As Decimal = DocumentoDePagoModel.Pagos.Sum(Function(x) x.MontoPago.Monto)

            If (tipoAccionCuentaCorriente = TipoAccionCuentaCorriente.Crédito) Then
                DocumentoDePagoModel.ClienteMayorista.AcreditarSaldoCuentaCorriente(monto)
            Else
                DocumentoDePagoModel.ClienteMayorista.DebitarSaldoCuentaCorriente(monto)
            End If

            Dim movimiento As Movimiento = New Movimiento(DocumentoDePagoModel.IdSucursal,
                                                          DocumentoDePagoModel.ClienteMayorista.Id,
                                                          monto,
                                                          DocumentoDePagoModel.ClienteMayorista.MontoCuentaCorriente,
                                                          TipoMovimientoCuentaCorriente.Depósito,
                                                          tipoAccionCuentaCorriente,
                                                          DocumentoDePagoModel.Numero,
                                                          DocumentoDePagoModel.Id)

            Await MovimientoService.GuardarAsync(TipoBase.Remota, movimiento)
            Await ClienteMayoristaService.ActualizarAsync(TipoBase.Remota, DocumentoDePagoModel.ClienteMayorista)
        End Function

        Private Sub ActualizarPago(montoPago As MontoPago)
            _Subtotal = montoPago.Monto
            _Cft = montoPago.CFT
            _Total = montoPago.Total

            NotifyPropertyChanged(NameOf(Me.Subtotal))
            NotifyPropertyChanged(NameOf(Me.Cft))
            NotifyPropertyChanged(NameOf(Me.Total))
        End Sub

        Private Function ObtenerCheque(monto As Decimal) As List(Of ModelCheque.Cheque)

            Dim ultimoNumeroDeOrden As ModelCheque.Cheque = DocumentoDePagoModel.Cheques.OrderByDescending(Function(x) x.NumeroOrden).FirstOrDefault()

            Dim frmChequeAltaMasiva As frmChequeAltaMasiva
            frmChequeAltaMasiva = New frmChequeAltaMasiva(monto, ultimoNumeroDeOrden?.NumeroOrden, DocumentoDePagoModel.ClienteMayorista.Id)
            frmChequeAltaMasiva.ShowDialog()

            If (frmChequeAltaMasiva.DialogResult <> DialogResult.OK OrElse Not frmChequeAltaMasiva.ChequesModel.Any()) Then
                Throw New NegocioException("No se encuentran cheques registrados. Por favor, para agregar la forma de pago CHEQUE debe registrar al menos un cheque.")
            End If

            Return frmChequeAltaMasiva.ChequesModel
        End Function

        Private Function ObtenerCuentaBancaria() As Common.Core.Model.CuentaBancaria
            Dim frmCuentaBancariasBuscar As frmCuentaBancariasBuscar = New frmCuentaBancariasBuscar()
            frmCuentaBancariasBuscar.ShowDialog()

            If (frmCuentaBancariasBuscar.DialogResult <> DialogResult.OK OrElse frmCuentaBancariasBuscar.CuentasBancariaSeleccionada Is Nothing) Then
                Throw New NegocioException("No se seleccionó una cuenta bancaria. Por favor, para agregar la forma de pago CUENTA debe seleccionar una cuenta bancaria.")
            End If

            Return frmCuentaBancariasBuscar.CuentasBancariaSeleccionada
        End Function
    End Class
End Namespace
