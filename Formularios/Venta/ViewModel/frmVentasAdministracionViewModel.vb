Imports System.ComponentModel
Imports System.Threading.Tasks
Imports AutoMapper
Imports Common.Core.Enum
Imports Common.Core.Exceptions
Imports Common.Core.Extension
Imports SistemaCinderella.Comunes
Imports SistemaCinderella.Formularios.Facturacion
Imports Ventas.Core.Model.BaseAgreggate
Imports Model = Ventas.Core.Model.VentaAggregate

Namespace Formularios.Venta
    Public Class frmVentasAdministracionViewModel
        Inherits SistemaCinderella.VistaModelo.Common

        Private IdSucursal As Integer
        Private VentaModelSeleccionada As Model.Venta
        Private VentasPorAnular As List(Of Tuple(Of Model.Venta, Boolean, String))
        Private MdiParent As Form

        Public Property NumeroFacturaDesde As Integer?
        Public Property NumeroFacturaHasta As Integer?
        Public Property MontoDesde As Decimal?
        Public Property MontoHasta As Decimal?
        Public Property FechaDesde As DateTime?
        Public Property FechaHasta As DateTime?
        Public Property AnuladoSi As Boolean
        Public Property AnuladoNo As Boolean
        Public Property MotivoAnulacion As String
        Public Property FechaAnulacion As DateTime?

        Public Property TiposFacturasSeleccionado As List(Of KeyValuePair(Of TipoFactura?, String))

        Public ReadOnly Property TiposFacturas As BindingList(Of KeyValuePair(Of TipoFactura?, String))
            Get
                Return New BindingList(Of KeyValuePair(Of TipoFactura?, String))([Enum](Of TipoFactura).ToKeyValuePairList())
            End Get
        End Property

        Public Property TiposPagosSeleccionado As List(Of KeyValuePair(Of TipoPago?, String))

        Public ReadOnly Property TiposPagos As BindingList(Of KeyValuePair(Of TipoPago?, String))
            Get
                Return New BindingList(Of KeyValuePair(Of TipoPago?, String))([Enum](Of TipoPago).ToKeyValuePairList())
            End Get
        End Property

        Public Property TiposClientesSeleccionado As List(Of KeyValuePair(Of TipoCliente?, String))

        Public ReadOnly Property TiposClientes As BindingList(Of KeyValuePair(Of TipoCliente?, String))
            Get
                Return New BindingList(Of KeyValuePair(Of TipoCliente?, String))([Enum](Of TipoCliente).ToKeyValuePairList())
            End Get
        End Property

        Public Property Ventas As BindingList(Of VentaAdministracionItemViewModel)

        Public ReadOnly Property VentaDetalleSeleccionada As VentaDetalleViewModel
            Get
                Return Mapper.Map(Of VentaDetalleViewModel)(VentaModelSeleccionada)
            End Get
        End Property

        Public ReadOnly Property HabilitarDetalleNotaCredito As Boolean
            Get
                Return VentaModelSeleccionada.NotaCredito <> Nothing
            End Get
        End Property

        Public ReadOnly Property HabilitarDetalleFacturar As Boolean
            Get
                Return VentaModelSeleccionada.Factura <> Nothing
            End Get
        End Property

        Public ReadOnly Property HabilitarFacturar As Boolean
            Get
                Return VentaModelSeleccionada.Factura = Nothing AndAlso Not VentaModelSeleccionada.Anulado
            End Get
        End Property

        Public ReadOnly Property HabilitarAnular As Boolean
            Get
                Return VentaModelSeleccionada.Factura IsNot Nothing AndAlso Not VentaModelSeleccionada.Anulado
            End Get
        End Property

        Public ReadOnly Property SinResultados As Boolean
            Get
                Return Not Ventas.Any()
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

        Public Sub New(idSucursal As Integer, mdiParent As Form)
            Me.IdSucursal = idSucursal
            Visible = True
            Ventas = New BindingList(Of VentaAdministracionItemViewModel)()
            VentaModelSeleccionada = New Model.Venta(Me.IdSucursal)
            VentasPorAnular = New List(Of Tuple(Of Model.Venta, Boolean, String))
            Me.MdiParent = mdiParent
            Inicializar()
        End Sub

        Friend Async Function AnularAsync() As Task
            If (VentaModelSeleccionada.Id <= 0) Then
                Throw New NegocioException("Error al anular la venta. No se encuentra una venta seleccionada")
            End If

            If (VentaModelSeleccionada.Factura IsNot Nothing) Then
                Await GenerarNotaCredito()
            Else
                Await AnularVentaAsync(VentaModelSeleccionada)
            End If
        End Function

        Friend Async Function RestablecerAsync() As Task
            Inicializar()
            Await BuscarAsync()
        End Function

        Friend Async Function CargarVentaAsync(ventaAdministracionItemViewModel As VentaAdministracionItemViewModel) As Task
            VentaModelSeleccionada = Await Task.Run(Function() Comunes.Servicio.ObtenerVenta(ventaAdministracionItemViewModel.Id))
            MotivoAnulacion = VentaModelSeleccionada.MotivoAnulado
            FechaAnulacion = VentaModelSeleccionada.FechaAnulado

            NotifyPropertyChanged(NameOf(Me.MotivoAnulacion))
            NotifyPropertyChanged(NameOf(Me.FechaAnulacion))
            NotifyPropertyChanged(NameOf(Me.VentaDetalleSeleccionada))
        End Function

        Friend Sub Imprimir()
            Dim frmReporteResumenReserva As frmReporteResumenReserva = New frmReporteResumenReserva("Resumen de Venta",
                                                                                                    1,
                                                                                                    VentaModelSeleccionada.TipoCliente,
                                                                                                    VentaModelSeleccionada.Vendedor.ApellidoYNombre,
                                                                                                    VentaModelSeleccionada.ClienteMayorista?.RazonSocial,
                                                                                                    VentaModelSeleccionada.Fecha,
                                                                                                    VentaModelSeleccionada.VentaItems.Cast(Of TransaccionItem).ToList(),
                                                                                                    VentaModelSeleccionada.Pagos)
            frmReporteResumenReserva.MdiParent = MdiParent
            frmReporteResumenReserva.Show()
        End Sub

        Friend Sub NotaCredito(ventasPorAnularItem As Tuple(Of Model.Venta, Boolean, String))
            Dim respuesta As DialogResult = MessageBox.Show(ventasPorAnularItem.Item3, "Administración de Ventas", MessageBoxButtons.YesNo, MessageBoxIcon.Information)
            If respuesta = DialogResult.Yes Then
                Visible = False
                Dim facturarViewModel As frmFacturarViewModel = New frmFacturarViewModel(ventasPorAnularItem.Item1, AddressOf NotaCreditoCallBackAsync, TipoDocumentoFiscal.NotaCredito, ventasPorAnularItem.Item2)
                Dim frmFacturarNueva As frmFacturar = New frmFacturar(facturarViewModel)
                frmFacturarNueva.MdiParent = MdiParent
                frmFacturarNueva.Show()
            End If
        End Sub

        Friend Sub Faturar()
            Visible = False
            Dim facturarViewModel As frmFacturarViewModel = New frmFacturarViewModel(VentaModelSeleccionada, AddressOf FacturarCallBackAsync, TipoDocumentoFiscal.Factura, False)
            Dim frmFacturarNueva As frmFacturar = New frmFacturar(facturarViewModel)
            frmFacturarNueva.MdiParent = MdiParent
            frmFacturarNueva.Show()
        End Sub

        Friend Sub MostrarFacturaDetalle()
            Dim frmVerDocumentoFiscal As frmVerDocumentoFiscal = New frmVerDocumentoFiscal(VentaModelSeleccionada.Factura.Id, TipoDocumentoFiscal.Factura)
            frmVerDocumentoFiscal.ShowDialog()
        End Sub

        Friend Sub MostrarNotaCreditoDetalle()
            Dim frmVerDocumentoFiscal As frmVerDocumentoFiscal = New frmVerDocumentoFiscal(VentaModelSeleccionada.NotaCredito.Id, TipoDocumentoFiscal.NotaCredito)
            frmVerDocumentoFiscal.ShowDialog()
        End Sub

        Private Async Function GenerarNotaCredito() As Task
            Dim reserva As Model.Reserva = Await Task.Run(Function() Comunes.Servicio.ObtenerReservaPorIdVenta(VentaModelSeleccionada.Id))

            If (reserva IsNot Nothing) Then

                If (reserva.VentaReserva.Id = VentaModelSeleccionada.Id) Then
                    VentasPorAnular.Add(New Tuple(Of Model.Venta, Boolean, String)(VentaModelSeleccionada, True, "La reserva se encuentra facturada, ¿Desea realizar una nota de crédito?"))
                Else
                    VentasPorAnular.Add(New Tuple(Of Model.Venta, Boolean, String)(VentaModelSeleccionada, False, "La venta se encuentra facturada, ¿Desea realizar una nota de crédito?"))
                    VentasPorAnular.Add(New Tuple(Of Model.Venta, Boolean, String)(reserva.VentaReserva, True, "La venta tiene asociada una reserva facturada. ¿Desea generar una nota de crédito de esta factura?"))
                End If
            Else
                VentasPorAnular.Add(New Tuple(Of Model.Venta, Boolean, String)(VentaModelSeleccionada, False, "La venta se encuentra facturada, ¿Desea realizar una nota de crédito?"))
            End If



            NotaCredito(VentasPorAnular.First())
        End Function

        Friend Async Function FacturarCallBackAsync(guardar As Boolean, venta As Model.Venta) As Task
            Visible = True
            If (guardar) Then
                Await Task.Run(Sub() Comunes.Servicio.GuardarFactura(VentaModelSeleccionada.Factura))
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

        Public Async Function AnularVentaAsync(venta As Model.Venta) As Task
            venta.Anular(MotivoAnulacion + $" {VariablesGlobales.objUsuario.Apellido}, {VariablesGlobales.objUsuario.Nombre}")
            Await Task.Run(Sub() Comunes.Servicio.ActualizarVenta(venta))
            NotifyPropertyChanged(NameOf(Me.Ventas))
            MessageBox.Show("Se ha anulado la venta de forma correcta.", "Administración de Ventas", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Function

        Public Async Function BuscarAsync() As Task
            Dim tiposFactura As List(Of TipoFactura) = TiposFacturasSeleccionado?.Select(Function(x) x.Key.Value).ToList()
            Dim tiposPago As List(Of TipoPago) = TiposPagosSeleccionado?.Select(Function(x) x.Key.Value).ToList()
            Dim tiposCliente As List(Of TipoCliente) = TiposClientesSeleccionado?.Select(Function(x) x.Key.Value).ToList()
            Dim anulado As Boolean? = If(AnuladoSi <> AnuladoNo, AnuladoSi, CType(Nothing, Boolean?))

            Dim ventasModel As List(Of Model.Venta) = Await Task.Run(Function() Servicio.BuscarVenta(IdSucursal, NumeroFacturaDesde, NumeroFacturaHasta, MontoDesde, MontoHasta, FechaDesde, FechaHasta, anulado, tiposFactura, tiposPago, tiposCliente))
            Ventas = New BindingList(Of VentaAdministracionItemViewModel)(Mapper.Map(Of List(Of VentaAdministracionItemViewModel))(ventasModel))
            NotifyPropertyChanged(NameOf(Me.Ventas))
        End Function

        Private Sub Inicializar()
            FechaDesde = DateTime.Now.AddDays(-7)
            FechaHasta = DateTime.Now
            NumeroFacturaDesde = Nothing
            NumeroFacturaHasta = Nothing
            MontoDesde = Nothing
            MontoHasta = Nothing
            AnuladoSi = False
            AnuladoNo = False
        End Sub
    End Class
End Namespace
