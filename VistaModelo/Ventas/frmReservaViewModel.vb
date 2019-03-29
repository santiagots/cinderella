Imports System.ComponentModel
Imports Common.Core.Exceptions
Imports Ventas.Core.Enum
Imports Common.Core.Extension

Namespace VistaModelo.Ventas
    Public Class frmReservaViewModel
        Inherits Common
        Public Property ReservaDetalle As ReservaDetalle
        Public Property VentaDetalle As VentaDetalle

        Public Sub New(ventaDetalle As VentaDetalle)
            Me.ReservaDetalle = New ReservaDetalle(ventaDetalle)
            Me.VentaDetalle = ventaDetalle
        End Sub

        Friend Sub BuscarClienteMinorista()
            Dim frmBuscarClienteMinorista As frmBuscarClienteMinorista = New frmBuscarClienteMinorista()
            If (frmBuscarClienteMinorista.ShowDialog() = DialogResult.OK) Then
                ReservaDetalle.Nombre = frmBuscarClienteMinorista.clienteMinorista.Nombre
                ReservaDetalle.Apellido = frmBuscarClienteMinorista.clienteMinorista.Apellido
                ReservaDetalle.Telefono = frmBuscarClienteMinorista.clienteMinorista.Telefono
                ReservaDetalle.Email = frmBuscarClienteMinorista.clienteMinorista.Email
                ReservaDetalle.Direccion = frmBuscarClienteMinorista.clienteMinorista.Direccion
                ReservaDetalle.EnvioNovedades = frmBuscarClienteMinorista.clienteMinorista.EnviarNovedades
                ReservaDetalle.NoEnvioNovedades = Not frmBuscarClienteMinorista.clienteMinorista.EnviarNovedades

                NotifyPropertyChanged(NameOf(ReservaDetalle.Nombre))
                NotifyPropertyChanged(NameOf(ReservaDetalle.Apellido))
                NotifyPropertyChanged(NameOf(ReservaDetalle.Telefono))
                NotifyPropertyChanged(NameOf(ReservaDetalle.Email))
                NotifyPropertyChanged(NameOf(ReservaDetalle.Direccion))
                NotifyPropertyChanged(NameOf(ReservaDetalle.EnvioNovedades))
                NotifyPropertyChanged(NameOf(ReservaDetalle.NoEnvioNovedades))
            End If
        End Sub

        Friend Sub Finalizar()
            If (String.IsNullOrEmpty(ReservaDetalle.Nombre) OrElse
                String.IsNullOrEmpty(ReservaDetalle.Apellido) OrElse
                String.IsNullOrEmpty(ReservaDetalle.Telefono) OrElse
                (ReservaDetalle.DireccionVisible AndAlso String.IsNullOrEmpty(ReservaDetalle.Direccion)) OrElse
                ReservaDetalle.MetodoEntregaSeleccionado.Key Is Nothing) Then
                Throw New NegocioException("Error al crear el pago. Debe completar todos los campos requeridos.")
            End If
        End Sub

        Private Sub CargarMetodoEntrega()
            Dim metodoEntrega As List(Of KeyValuePair(Of ReservaMetodoEntrega?, String)) = [Enum](Of ReservaMetodoEntrega).ToKeyValuePairList()
            metodoEntrega.Insert(0, New KeyValuePair(Of ReservaMetodoEntrega?, String)(Nothing, "Seleccione una opción"))
            ReservaDetalle.MetodoEntregaSeleccionado = metodoEntrega.First()
            ReservaDetalle.MetodoEntrega = New BindingList(Of KeyValuePair(Of ReservaMetodoEntrega?, String))(metodoEntrega)
        End Sub
    End Class
End Namespace
