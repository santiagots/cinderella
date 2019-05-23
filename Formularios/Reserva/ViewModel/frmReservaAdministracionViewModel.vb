Imports System.ComponentModel
Imports System.Threading.Tasks
Imports AutoMapper
Imports Ventas.Core.Enum
Imports Common.Core.Extension
Imports ModelBase = Ventas.Core.Model.BaseAgreggate
Imports Model = Ventas.Core.Model.VentaAggregate
Imports SistemaCinderella.VistaModelo.Ventas

Namespace Formularios.Reserva
    Public Class frmReservaAdministracionViewModel
        Inherits SistemaCinderella.VistaModelo.Common

        Private reservaModel As Model.Reserva
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

        Sub New(idSucursal As Integer)
            Me.IdSucursal = idSucursal
            ReservasDetallesItems = New BindingList(Of ReservaAdministracionItemsViewModel)()
            VentaDetalleSeleccionada = New VentaDetalleViewModel()
            ReservaDetalleSeleccionada = New ReservaDetalleViewModel()
            Inicializar()
        End Sub

        Public Async Function BuscarAsync() As Task
            Dim fechaAltaFiltro As DateTime? = If(FechaAltaSeleccionada, FechaAlta, CType(Nothing, DateTime?))
            Dim FechaRetiroFiltro As DateTime? = If(FechaRetiroSeleccionada, FechaRetiro, CType(Nothing, DateTime?))

            Dim reservasModel As IList(Of Model.Reserva) = Await Task.Run(Function() Servicio.BuscarReserva(IdSucursal, False, Nombre, fechaAltaFiltro, FechaRetiroFiltro, MetodoEntregaSeleccionado.Key))

            ReservasDetallesItems = New BindingList(Of ReservaAdministracionItemsViewModel)(Mapper.Map(Of List(Of ReservaAdministracionItemsViewModel))(reservasModel))
            NotifyPropertyChanged(NameOf(Me.ReservasDetallesItems))
        End Function

        Friend Async Function RestablecerAsync() As Task
            Inicializar()
            Await BuscarAsync()
        End Function

        Friend Async Function EliminarReservaAsync(reservaAdministracionItemsViewModel As ReservaAdministracionItemsViewModel) As Task
            Await Task.Run(Function() Servicio.EliminarReserva(reservaAdministracionItemsViewModel.Id))
            ReservasDetallesItems.Remove(ReservasDetallesItems.Where(Function(x) x.Id = reservaAdministracionItemsViewModel.Id).FirstOrDefault)
        End Function

        Friend Async Function ImprimirReservaAsync(reservaAdministracionItemsViewModel As ReservaAdministracionItemsViewModel, MdiParent As Form) As Task
            Dim reservaModel As Model.Reserva = Await Task.Run(Function() Servicio.ObtenerReserva(reservaAdministracionItemsViewModel.Id))

            Dim frmReporteResumenReserva As frmReporteResumenReserva = New frmReporteResumenReserva("Resumen de Reserva",
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