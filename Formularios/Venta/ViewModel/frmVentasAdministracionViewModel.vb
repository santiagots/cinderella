Imports System.ComponentModel
Imports System.Threading.Tasks
Imports AutoMapper
Imports Common.Core.Enum
Imports Common.Core.Exceptions
Imports Common.Core.Extension
Imports SistemaCinderella.VistaModelo.Ventas
Imports Ventas.Core.Model.BaseAgreggate
Imports Ventas.Core.Model.VentaAggregate
Imports Model = Ventas.Core.Model.VentaAggregate

Namespace Formularios.Venta
    Public Class frmVentasAdministracionViewModel
        Inherits SistemaCinderella.VistaModelo.Common

        Private IdSucursal As Integer
        Private VentaModelSeleccionada As Model.Venta

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
                Return Not VentaModelSeleccionada.Anulado
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

        Public Sub New(idSucursal As Integer)
            Me.IdSucursal = idSucursal
            Visible = True
            Ventas = New BindingList(Of VentaAdministracionItemViewModel)()
            VentaModelSeleccionada = New Model.Venta(Me.IdSucursal)
            Inicializar()
        End Sub

        Friend Async Function AnularAsync() As Task
            If (VentaModelSeleccionada.Id <= 0) Then
                Throw New NegocioException("Error al anular la venta. No se encuentra una venta seleccionada")
            End If

            VentaModelSeleccionada.Anular(MotivoAnulacion)

            Await Task.Run(Sub() Servicio.ActualizarVenta(VentaModelSeleccionada))
        End Function

        Public Async Function BuscarAsync() As Task
            Dim tiposFactura As List(Of TipoFactura) = TiposFacturasSeleccionado?.Select(Function(x) x.Key.Value).ToList()
            Dim tiposPago As List(Of TipoPago) = TiposPagosSeleccionado?.Select(Function(x) x.Key.Value).ToList()
            Dim tiposCliente As List(Of TipoCliente) = TiposClientesSeleccionado?.Select(Function(x) x.Key.Value).ToList()

            Dim ventasModel As List(Of Model.Venta) = Await Task.Run(Function() Servicio.BuscarVenta(IdSucursal, NumeroFacturaDesde, NumeroFacturaHasta, MontoDesde, MontoHasta, FechaDesde, FechaHasta, Nothing, tiposFactura, tiposPago, tiposCliente))
            Ventas = New BindingList(Of VentaAdministracionItemViewModel)(Mapper.Map(Of List(Of VentaAdministracionItemViewModel))(ventasModel))
            NotifyPropertyChanged(NameOf(Me.Ventas))
        End Function

        Friend Async Function RestablecerAsync() As Task
            Inicializar()
            Await BuscarAsync()
        End Function

        Friend Async Function CargarVentaAsync(ventaAdministracionItemViewModel As VentaAdministracionItemViewModel) As Task
            VentaModelSeleccionada = Await Task.Run(Function() Servicio.ObtenerVenta(ventaAdministracionItemViewModel.Id))
            MotivoAnulacion = VentaModelSeleccionada.MotivoAnulado
            FechaAnulacion = VentaModelSeleccionada.FechaAnulado

            NotifyPropertyChanged(NameOf(Me.MotivoAnulacion))
            NotifyPropertyChanged(NameOf(Me.FechaAnulacion))
            NotifyPropertyChanged(NameOf(Me.VentaDetalleSeleccionada))
        End Function

        Friend Async Function ImprimirAsync(MdiParent As Form) As Task
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
        End Function

        Friend Sub Faturar(MdiParent As Form)
            Visible = False
            Dim facturarViewModel As frmFacturarViewModel = New frmFacturarViewModel(VentaModelSeleccionada, AddressOf FacturarCallBackAsync, False)
            Dim frmFacturarNueva As frmFacturar = New frmFacturar(facturarViewModel)
            frmFacturarNueva.MdiParent = MdiParent
            frmFacturarNueva.Show()
        End Sub

        Friend Async Function FacturarCallBackAsync(facturar As Boolean) As Task
            Visible = True
            If (facturar) Then
                Await Task.Run(Sub() Servicio.GuardarFactura(VentaModelSeleccionada.Factura))
            End If
        End Function

        Friend Sub MostrarFacturaDetalle()
            Dim frmVerFactura As frmVerFactura = New frmVerFactura(VentaModelSeleccionada.Factura.Id)
            frmVerFactura.ShowDialog()
        End Sub

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
