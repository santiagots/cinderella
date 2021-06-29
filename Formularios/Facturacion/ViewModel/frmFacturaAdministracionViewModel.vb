Imports System.ComponentModel
Imports System.Threading.Tasks
Imports AutoMapper
Imports Common.Core.Enum
Imports Common.Core.Exceptions
Imports SistemaCinderella.Comunes
Imports Ventas.Core.Model.BaseAgreggate
Imports Ventas.Core.Model.RemitoAgreggate
Imports Ventas.Data.Service
Imports Model = Ventas.Core.Model.VentaAggregate

Namespace Formularios.Facturacion
    Public Class frmFacturaAdministracionViewModel
        Inherits Comunes.Common

        Private VentasPorAnular As List(Of Tuple(Of Model.Venta, String))
        Private IdSucursal As Integer
        Private MdiParent As Form

        Public Property NumeroFactura As Integer?
        Public Property MontoDesde As Decimal?
        Public Property MontoHasta As Decimal?
        Public Property Nombre As String
        Public Property Cuit As Integer?
        Public Property FechaDesde As DateTime?
        Public Property FechaHasta As DateTime?
        Public Property FacturaManual As Boolean
        Public Property FacturaTicket As Boolean
        Public Property FacturaElectronica As Boolean
        Public Property MotivoAnulacion As String
        Public Property FechaAnulacion As DateTime?
        Private _Facturas As List(Of Model.Factura)
        Public ReadOnly Property Facturas As BindingList(Of DocumentoFiscalViewModel)
            Get
                Return New BindingList(Of DocumentoFiscalViewModel)(Mapper.Map(Of List(Of DocumentoFiscalViewModel))(_Facturas))
            End Get
        End Property
        Public ReadOnly Property SinResultados As Boolean
            Get
                Return Not Facturas.Any()
            End Get
        End Property

        Private _Visible As Boolean
        Public Property Visible As Boolean
            Set(value As Boolean)
                _Visible = value
                NotifyPropertyChanged(NameOf(Me.Visible))
            End Set
            Get
                Return _Visible
            End Get
        End Property

        Private _VentaDetalleSeleccionada As Model.Venta
        Public ReadOnly Property VentaDetalleSeleccionada As VentaDetalleViewModel
            Get
                Return Mapper.Map(Of VentaDetalleViewModel)(_VentaDetalleSeleccionada)
                NotifyPropertyChanged(NameOf(Me.VentaDetalleSeleccionada))
            End Get
        End Property

        Public ReadOnly Property HabilitarDetalleNotaCredito As Boolean
            Get
                Return _VentaDetalleSeleccionada.NotaCredito <> Nothing
            End Get
        End Property

        Public ReadOnly Property HabilitarDetalleFacturar As Boolean
            Get
                Return _VentaDetalleSeleccionada.Factura <> Nothing
            End Get
        End Property

        Public ReadOnly Property HabilitarFacturar As Boolean
            Get
                Return _VentaDetalleSeleccionada.Factura = Nothing AndAlso Not _VentaDetalleSeleccionada.Anulado
            End Get
        End Property

        Public ReadOnly Property HabilitarAnular As Boolean
            Get
                Return _VentaDetalleSeleccionada.Factura IsNot Nothing AndAlso Not _VentaDetalleSeleccionada.Anulado
            End Get
        End Property

        Public Sub New(idSucursal As Integer, mdiParent As Form)
            Me.IdSucursal = idSucursal
            Visible = True
            _Facturas = New List(Of Model.Factura)
            _VentaDetalleSeleccionada = New Model.Venta(Me.IdSucursal)
            VentasPorAnular = New List(Of Tuple(Of Model.Venta, String))()
            Me.MdiParent = mdiParent
            Inicializar()
        End Sub

        Friend Async Function AnularAsync() As Task
            If (_VentaDetalleSeleccionada.Id <= 0) Then
                Throw New NegocioException("Error al anular la venta. No se encuentra una venta seleccionada")
            End If

            If (_VentaDetalleSeleccionada.Factura IsNot Nothing) Then
                Await GenerarNotaCredito()
            Else
                Await AnularVentaAsync(_VentaDetalleSeleccionada)
            End If
        End Function

        Friend Async Function BuscarAsync() As Task

            Dim tiposFacturas As List(Of TipoFactura) = New List(Of TipoFactura)()

            If FacturaManual Then
                tiposFacturas.Add(TipoFactura.Manual)
            End If
            If FacturaTicket Then
                tiposFacturas.Add(TipoFactura.Ticket)
            End If
            If FacturaElectronica Then
                tiposFacturas.Add(TipoFactura.Electronica)
            End If

            _Facturas = Await Task.Run(Function() Servicio.BuscarFactura(IdSucursal, NumeroFactura, MontoDesde, MontoHasta, Nombre, Cuit, FechaDesde, FechaHasta, tiposFacturas))

            NotifyPropertyChanged(NameOf(Me.Facturas))
        End Function

        Friend Async Function RestablecerAsync() As Task
            Inicializar()
            Await BuscarAsync()
        End Function

        Friend Sub Imprimir()
            Dim frmReporteResumenReserva As frmReporteTransaccion = New frmReporteTransaccion("Resumen de Venta",
                                                                                                    1,
                                                                                                    _VentaDetalleSeleccionada.TipoCliente,
                                                                                                    _VentaDetalleSeleccionada.Vendedor.ApellidoYNombre,
                                                                                                    _VentaDetalleSeleccionada.ClienteMayorista?.RazonSocial,
                                                                                                    _VentaDetalleSeleccionada.Fecha,
                                                                                                    _VentaDetalleSeleccionada.VentaItems.Cast(Of TransaccionItem).ToList(),
                                                                                                    _VentaDetalleSeleccionada.Pagos)
            frmReporteResumenReserva.MdiParent = MdiParent
            frmReporteResumenReserva.Show()
        End Sub

        Friend Async Function CargarVentaAsync(documentoFiscalViewModel As DocumentoFiscalViewModel) As Task
            Dim facturaSeleccionada As Model.Factura = _Facturas.FirstOrDefault(Function(x) x.Id = documentoFiscalViewModel.Id)
            _VentaDetalleSeleccionada = Await VentaService.ObtenerAsync(TipoBase.Local, facturaSeleccionada.IdVenta)

            MotivoAnulacion = _VentaDetalleSeleccionada.MotivoAnulado
            FechaAnulacion = _VentaDetalleSeleccionada.FechaAnulado

            NotifyPropertyChanged(NameOf(Me.MotivoAnulacion))
            NotifyPropertyChanged(NameOf(Me.FechaAnulacion))
            NotifyPropertyChanged(NameOf(Me.VentaDetalleSeleccionada))
        End Function

        Friend Sub NotaCredito(ventasPorAnularItem As Tuple(Of Model.Venta, String))
            Dim respuesta As DialogResult = MessageBox.Show(ventasPorAnularItem.Item2, "Administración de Ventas", MessageBoxButtons.YesNo, MessageBoxIcon.Information)
            If respuesta = DialogResult.Yes Then
                Visible = False
                Dim facturarViewModel As frmFacturarViewModel = New frmFacturarViewModel(ventasPorAnularItem.Item1, AddressOf NotaCreditoCallBackAsync, TipoDocumentoFiscal.NotaCredito)
                Dim frmFacturarNueva As frmFacturar = New frmFacturar(facturarViewModel)
                frmFacturarNueva.MdiParent = MdiParent
                frmFacturarNueva.Show()
            End If
        End Sub

        Friend Sub Faturar()
            Visible = False
            Dim facturarViewModel As frmFacturarViewModel = New frmFacturarViewModel(_VentaDetalleSeleccionada, AddressOf FacturarCallBackAsync, TipoDocumentoFiscal.Factura, False)
            Dim frmFacturarNueva As frmFacturar = New frmFacturar(facturarViewModel)
            frmFacturarNueva.MdiParent = MdiParent
            frmFacturarNueva.Show()
        End Sub

        Friend Async Function RemitoAsync() As Task
            Dim frmRemitoDetalle As frmRemito
            Dim remitoModel As Remito = Await RemitoService.ObtenerPorVentaAsync(_VentaDetalleSeleccionada.Id)
            If (remitoModel IsNot Nothing) Then
                frmRemitoDetalle = New frmRemito(remitoModel, _VentaDetalleSeleccionada)
            Else
                frmRemitoDetalle = New frmRemito(_VentaDetalleSeleccionada)
            End If

            frmRemitoDetalle.MdiParent = MdiParent
            frmRemitoDetalle.Show()
        End Function

        Private Async Function GenerarNotaCredito() As Task
            VentasPorAnular.Add(New Tuple(Of Model.Venta, String)(_VentaDetalleSeleccionada, "La venta se encuentra facturada, ¿Desea realizar una nota de crédito?"))

            Dim reserva As Model.Reserva = Await Task.Run(Function() Comunes.Servicio.ObtenerReservaPorIdVenta(_VentaDetalleSeleccionada.Id))

            If (reserva?.VentaReserva?.Id <> _VentaDetalleSeleccionada.Id) Then
                VentasPorAnular.Add(New Tuple(Of Model.Venta, String)(reserva.VentaReserva, "La venta tiene asociada una reserva facturada. ¿Desea generar una nota de crédito de esta factura?"))
            End If

            NotaCredito(VentasPorAnular.First())
        End Function

        Friend Async Function FacturarCallBackAsync(guardar As Boolean, venta As Model.Venta) As Task
            Visible = True
            If (guardar) Then
                Await Task.Run(Sub() Comunes.Servicio.GuardarFactura(_VentaDetalleSeleccionada.Factura))
                MessageBox.Show("Se ha generado la factura de forma correcta.", "Administración de Ventas", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        End Function

        Friend Async Function NotaCreditoCallBackAsync(guardar As Boolean, venta As Model.Venta) As Task
            Visible = True
            If (guardar) Then
                Await Task.Run(Sub() Comunes.Servicio.GuardarNotaCredito(venta.NotaCredito))
                MessageBox.Show("Se ha generado la nota de crédito de forma correcta.", "Administración de Ventas", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Await AnularVentaAsync(venta)
                VentasPorAnular.Remove(VentasPorAnular.First(Function(x) x.Item1.Id = venta.Id))
                If (VentasPorAnular.Any()) Then
                    NotaCredito(VentasPorAnular.First())
                End If
            Else
                VentasPorAnular.Clear()
            End If
        End Function

        Friend Sub MostrarFacturaDetalle()
            Dim frmVerDocumentoFiscal As frmVerDocumentoFiscal = New frmVerDocumentoFiscal(_VentaDetalleSeleccionada.Factura.Id, _VentaDetalleSeleccionada.TipoCliente, TipoDocumentoFiscal.Factura)
            frmVerDocumentoFiscal.ShowDialog()
        End Sub

        Friend Sub MostrarNotaCreditoDetalle()
            Dim frmVerDocumentoFiscal As frmVerDocumentoFiscal = New frmVerDocumentoFiscal(_VentaDetalleSeleccionada.NotaCredito.Id, _VentaDetalleSeleccionada.TipoCliente, TipoDocumentoFiscal.NotaCredito)
            frmVerDocumentoFiscal.ShowDialog()
        End Sub

        Public Async Function AnularVentaAsync(venta As Model.Venta) As Task
            venta.Anular(MotivoAnulacion + $" {VariablesGlobales.objUsuario.Apellido}, {VariablesGlobales.objUsuario.Nombre}")
            Await Task.Run(Sub() Comunes.Servicio.ActualizarVenta(venta))
            MessageBox.Show("Se ha anulado la venta de forma correcta.", "Administración de Ventas", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Function

        Private Sub Inicializar()
            FechaDesde = DateTime.Now.AddDays(-7)
            FechaHasta = DateTime.Now
            MontoDesde = Nothing
            MontoHasta = Nothing
            FacturaManual = False
            FacturaTicket = False
            FacturaElectronica = False
        End Sub

    End Class
End Namespace
