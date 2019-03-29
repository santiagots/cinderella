Imports System.ComponentModel
Imports System.Threading.Tasks
Imports AutoMapper
Imports Ventas.Core.Enum
Imports Common.Core.Extension
Imports Ventas.Core.Model.BaseAgreggate
Imports Ventas.Core.Model.VentaAggregate

Namespace VistaModelo.Ventas
    Public Class frmReservaAdministracionViewModel
        Inherits Common

        Private reservaModel As Reserva

        Public Property Nombre As String
        Public Property MetodoEntregaSeleccionado As KeyValuePair(Of ReservaMetodoEntrega?, String)
        Public ReadOnly Property MetodoEntrega As System.ComponentModel.BindingList(Of KeyValuePair(Of ReservaMetodoEntrega?, String))
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
        Public Property VentaDetalleSeleccionada As VentaDetalle
        Public Property ReservaDetalleSeleccionada As ReservaDetalle

        Sub New()
            ReservasDetallesItems = New BindingList(Of ReservaAdministracionItemsViewModel)()
            VentaDetalleSeleccionada = New VentaDetalle()
            ReservaDetalleSeleccionada = New ReservaDetalle()
            FechaAlta = DateTime.Now()
            FechaAltaSeleccionada = True
        End Sub

        Public Async Function BuscarReservaAsync() As Task
            Dim fechaAltaFiltro As DateTime? = If(FechaAltaSeleccionada, FechaAlta, CType(Nothing, DateTime?))
            Dim FechaRetiroFiltro As DateTime? = If(FechaRetiroSeleccionada, FechaRetiro, CType(Nothing, DateTime?))

            Dim reservasModel As IList(Of Reserva) = Await Task.Run(Function() Servicio.BuscarReserva(False, Nombre, fechaAltaFiltro, FechaRetiroFiltro, MetodoEntregaSeleccionado.Key))

            ReservasDetallesItems = New BindingList(Of ReservaAdministracionItemsViewModel)(Mapper.Map(Of List(Of ReservaAdministracionItemsViewModel))(reservasModel))
            NotifyPropertyChanged(NameOf(Me.ReservasDetallesItems))
        End Function

        Friend Async Function EliminarReservaAsync(reservaAdministracionItemsViewModel As ReservaAdministracionItemsViewModel) As Task
            Await Task.Run(Function() Servicio.EliminarReserva(reservaAdministracionItemsViewModel.Id))
            ReservasDetallesItems.Remove(ReservasDetallesItems.Where(Function(x) x.Id = reservaAdministracionItemsViewModel.Id).FirstOrDefault)
        End Function

        Friend Async Function ImprimirReservaAsync(reservaAdministracionItemsViewModel As ReservaAdministracionItemsViewModel, MdiParent As Form) As Task
            Dim reservaModel As Reserva = Await Task.Run(Function() Servicio.ObtenerReserva(reservaAdministracionItemsViewModel.Id))

            Dim frmReporteResumenReserva As frmReporteResumenReserva = New frmReporteResumenReserva("Resumen de Reserva",
                                                                                                    1,
                                                                                                    reservaModel.VentaReserva.TipoCliente,
                                                                                                    reservaModel.VentaReserva.Vendedor.ApellidoYNombre,
                                                                                                    reservaAdministracionItemsViewModel.Nombre,
                                                                                                    reservaModel.VentaReserva.Fecha,
                                                                                                    reservaModel.VentaReserva.VentaItems.Cast(Of TransaccionItem).ToList(),
                                                                                                    reservaModel.VentaReserva.Pagos)
            frmReporteResumenReserva.MdiParent = MdiParent
            frmReporteResumenReserva.Show()
        End Function

        Friend Sub RetirarVenta(MdiParent As Form)
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
            VentaDetalleSeleccionada = Mapper.Map(Of VentaDetalle)(reservaModel.VentaReserva)
            ReservaDetalleSeleccionada = Mapper.Map(Of ReservaDetalle)(reservaModel)
        End Function
    End Class
End Namespace