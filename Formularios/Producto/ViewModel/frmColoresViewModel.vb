Imports System.ComponentModel
Imports System.Threading.Tasks
Imports AutoMapper
Imports Model = Producto.Core.Model.ProductoAgreggate

Namespace Formularios.Producto
    Public Class frmColoresViewModel
        Inherits Comunes.Common

        Private ColorSeleccionadoModel As Model.Color

        Public Property Colores As BindingList(Of ColorItemViewModel) = New BindingList(Of ColorItemViewModel)()
        Public Property ColorNuevo As ColorItemViewModel
        Public Property ColorMod As ColorItemViewModel
        Public Property NombreBusqueda As String = String.Empty
        Public ReadOnly Property SinResultados As Boolean
            Get
                Return Not Colores.Any()
            End Get
        End Property

        Friend Async Function BuscarAsync() As Task
            Dim ColoresModel As List(Of Model.Color) = Await Task.Run(Function() Servicio.BuscarColores(NombreBusqueda))

            If ColoresModel Is Nothing Then
                ColoresModel = New List(Of Model.Color)()
            End If

            Colores = New BindingList(Of ColorItemViewModel)(Mapper.Map(Of List(Of ColorItemViewModel))(ColoresModel))
            NotifyPropertyChanged(NameOf(Me.Colores))
        End Function

        Friend Async Function AltaAsync() As Task
            Dim color As Model.Color = New Model.Color(ColorNuevo.Nombre, ColorNuevo.Habilitado)
            Await Task.Run(Sub() Servicio.AltaColor(color))
        End Function

        Friend Async Function ModificarAsync() As Task
            ColorSeleccionadoModel.Modificar(ColorMod.Nombre, ColorMod.Habilitado)
            Await Task.Run(Sub() Servicio.ModificarColor(ColorSeleccionadoModel))
            NotifyPropertyChanged(NameOf(Me.Colores))
        End Function

        Friend Async Function EliminarAsync() As Task
            ColorSeleccionadoModel.Eliminar()

            Await Task.Run(Sub() Servicio.ModificarColor(ColorSeleccionadoModel))
            NotifyPropertyChanged(NameOf(Me.Colores))
        End Function

        Friend Sub Limpiar()
            NombreBusqueda = String.Empty
            NotifyPropertyChanged(NameOf(Me.NombreBusqueda))
        End Sub

        Friend Async Function ObtenerSupplierAsync(id As Integer) As Task
            ColorSeleccionadoModel = Await Task.Run(Function() Servicio.ObtenerColor(id))

            ColorMod = Mapper.Map(Of ColorItemViewModel)(ColorSeleccionadoModel)
            NotifyPropertyChanged(NameOf(Me.ColorMod))
        End Function

        Friend Sub LimpiarColorNuevo()
            ColorNuevo = New ColorItemViewModel()
            NotifyPropertyChanged(NameOf(Me.ColorNuevo))
        End Sub
    End Class

End Namespace