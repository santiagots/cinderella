Imports System.ComponentModel
Imports System.Threading.Tasks
Imports AutoMapper
Imports Ventas.Core.Enum
Imports Common.Core.Extension
Imports ModelBase = Ventas.Core.Model.BaseAgreggate
Imports Model = Ventas.Core.Model.VentaAggregate
Imports SistemaCinderella.VistaModelo.Ventas
Imports SistemaCinderella.Formularios.Venta
Imports Common.Core.Enum
Imports SistemaCinderella.Comunes
Imports SistemaCinderella.Formularios.Facturacion

Namespace Formularios.Reserva
    Public Class frmReservaAdministracionViewModel
        Inherits Comunes.Common

        Private reservaModel As Model.Reserva
        Private MdiParent As Form
        Private ReadOnly IdSucursal As Integer

        Public Property Nombre As String
        Public Property MetodoEntregaSeleccionado As KeyValuePair(Of ReservaMetodoEntrega?, String)
        Public ReadOnly Property MetodoEntrega As BindingList(Of KeyValuePair(Of ReservaMetodoEntrega?, String))
        Public Property FechaAlta As Date
        Public Property FechaAltaSeleccionada As Boolean
        Public Property FechaRetiro As Date
        Public Property FechaRetiroSeleccionada As Boolean
        Public Property ReservasDetallesItems As BindingList(Of ReservaAdministracionItemsViewModel)
        Public ReadOnly Property SinResultados() As Boolean
            Get
                Return Not ReservasDetallesItems.Any()
            End Get
        End Property
        Public Property VentaDetalleSeleccionada As VentaDetalleViewModel
        Public Property ReservaDetalleSeleccionada As ReservaDetalleViewModel


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

        Sub New(idSucursal As Integer, mdiParent As Form)
            Me.IdSucursal = idSucursal
            Me.MdiParent = mdiParent
            ReservasDetallesItems = New BindingList(Of ReservaAdministracionItemsViewModel)()
            VentaDetalleSeleccionada = New VentaDetalleViewModel()
            ReservaDetalleSeleccionada = New ReservaDetalleViewModel()
            Inicializar()
        End Sub

        Public Async Function AnularVentaYEliminarReservaAsync(venta As Model.Venta) As Task
            venta.Anular($"Venta anulada por borrado de reserva ({VariablesGlobales.objUsuario.Apellido}, {VariablesGlobales.objUsuario.Nombre})")
            Await Task.Run(Sub() Comunes.Servicio.ActualizarVenta(venta))

            Await Task.Run(Function() Servicio.EliminarReserva(reservaModel.Id))
            ReservasDetallesItems.Remove(ReservasDetallesItems.Where(Function(x) x.Id = reservaModel.Id).FirstOrDefault)

            MessageBox.Show("Se ha anulado la venta y eliminado la reserva de forma correcta.", "Administración de Ventas", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Function

        Public Async Function BuscarAsync() As Task
            Dim fechaAltaFiltro As DateTime? = If(FechaAltaSeleccionada, FechaAlta, CType(Nothing, DateTime?))
            Dim FechaRetiroFiltro As DateTime? = If(FechaRetiroSeleccionada, FechaRetiro, CType(Nothing, DateTime?))

            Dim reservasModel As IList(Of Model.Reserva) = Await Task.Run(Function() Servicio.BuscarReserva(IdSucursal, False, Nombre, fechaAltaFiltro, FechaRetiroFiltro, MetodoEntregaSeleccionado.Key))

            ReservasDetallesItems = New BindingList(Of ReservaAdministracionItemsViewModel)(Mapper.Map(Of List(Of ReservaAdministracionItemsViewModel))(reservasModel))
            NotifyPropertyChanged(NameOf(Me.ReservasDetallesItems))
        End Function

        Public Async Function EliminarReservaAsync(reservaAdministracionItemsViewModel As ReservaAdministracionItemsViewModel) As Task
            reservaModel = Await Task.Run(Function() Servicio.ObtenerReserva(reservaAdministracionItemsViewModel.Id))

            If (reservaModel.VentaReserva.Factura IsNot Nothing) Then
                Await GenerarNotaCreditoAsync(reservaModel.VentaReserva)
            Else
                Await AnularVentaYEliminarReservaAsync(reservaModel.VentaReserva)
            End If
        End Function

        Friend Async Function EliminarReservaAsync(idReserva As Long) As Task
            Await Task.Run(Function() Servicio.EliminarReserva(idReserva))
            ReservasDetallesItems.Remove(ReservasDetallesItems.Where(Function(x) x.Id = idReserva).FirstOrDefault)
        End Function

        Friend Async Function GenerarNotaCreditoAsync(venta As Model.Venta) As Task
            Dim respuesta As DialogResult = MessageBox.Show("La reserva tiene una factura asociada. ¿Desea generar una nota de crédito de esta factura?", "Administración de Ventas", MessageBoxButtons.YesNo, MessageBoxIcon.Information)
            If respuesta = DialogResult.Yes Then
                Visible = False
                Dim facturarViewModel As frmFacturarViewModel = New frmFacturarViewModel(venta, AddressOf NotaCreditoCallBackAsync, TipoDocumentoFiscal.NotaCredito, False)
                Dim frmFacturarNueva As frmFacturar = New frmFacturar(facturarViewModel)
                frmFacturarNueva.MdiParent = MdiParent
                frmFacturarNueva.Show()
            Else
                Await AnularVentaYEliminarReservaAsync(reservaModel.VentaReserva)
            End If
        End Function

        Friend Async Function NotaCreditoCallBackAsync(guardar As Boolean, venta As Model.Venta) As Task
            Visible = True
            If (guardar) Then
                Await Task.Run(Sub() Comunes.Servicio.GuardarNotaCredito(venta.NotaCredito))
                MessageBox.Show("Se ha generado la nota de crédito de forma correcta.", "Administración de Ventas", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Await AnularVentaYEliminarReservaAsync(venta)
            End If
        End Function

        Friend Async Function ImprimirReservaAsync(reservaAdministracionItemsViewModel As ReservaAdministracionItemsViewModel) As Task
            reservaModel = Await Task.Run(Function() Servicio.ObtenerReserva(reservaAdministracionItemsViewModel.Id))
            Dim frmReporteResumenReserva As frmReporteTransaccion = New frmReporteTransaccion("Resumen de Reserva",
                                                                                                    1,
                                                                                                    reservaModel.VentaReserva.TipoCliente,
                                                                                                    reservaModel.VentaReserva.Vendedor.ApellidoYNombre,
                                                                                                    reservaAdministracionItemsViewModel.Nombre,
                                                                                                    reservaModel.VentaReserva.Fecha,
                                                                                                    reservaModel.VentaReserva.VentaItems.Cast(Of ModelBase.TransaccionItem).ToList(),
                                                                                                    reservaModel.VentaReserva.Pagos)
            frmReporteResumenReserva.MdiParent = MdiParent
            frmReporteResumenReserva.Show()
        End Function

        Friend Async Function RestablecerAsync() As Task
            Inicializar()
            Await BuscarAsync()
        End Function

        Friend Sub RetirarVenta()
            Dim frmVenta As frmVentas = New frmVentas(reservaModel)
            frmVenta.MdiParent = MdiParent
            frmVenta.Show()
        End Sub

        Friend Sub CargarMetodosEntregas()
            Dim metodosEntrega As List(Of KeyValuePair(Of ReservaMetodoEntrega?, String)) = [Enum](Of ReservaMetodoEntrega).ToKeyValuePairList()
            metodosEntrega.Insert(0, New KeyValuePair(Of ReservaMetodoEntrega?, String)(Nothing, "Todos"))
            MetodoEntregaSeleccionado = metodosEntrega.First()
            _MetodoEntrega = New BindingList(Of KeyValuePair(Of ReservaMetodoEntrega?, String))(metodosEntrega)
        End Sub

        Friend Async Function CargarReservaAsync(reservaAdministracionItemsViewModel As ReservaAdministracionItemsViewModel) As Task
            reservaModel = Await Task.Run(Function() Servicio.ObtenerReserva(reservaAdministracionItemsViewModel.Id))
            VentaDetalleSeleccionada = Mapper.Map(Of VentaDetalleViewModel)(reservaModel.VentaReserva)
            ReservaDetalleSeleccionada = Mapper.Map(Of ReservaDetalleViewModel)(reservaModel)
        End Function

        Private Sub Inicializar()
            FechaAlta = DateTime.Now()
            FechaAltaSeleccionada = True

            FechaRetiro = Nothing
            FechaRetiroSeleccionada = False

            Nombre = String.Empty
        End Sub
    End Class
End Namespace