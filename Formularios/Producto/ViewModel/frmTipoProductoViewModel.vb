Imports System.ComponentModel
Imports System.Threading.Tasks
Imports AutoMapper
Imports Producto.Core.Model.ProductoAgreggate

Namespace Formularios.Producto
    Public Class frmTipoProductoViewModel
        Inherits Comunes.Common

        Private TipoProductoSeleccionadoModel As TipoProducto

        Public Property TiposProductos As BindingList(Of TipoProductoItemViewModel) = New BindingList(Of TipoProductoItemViewModel)()
        Public Property TipoProductoNuevo As TipoProductoItemViewModel
        Public Property TipoProductoMod As TipoProductoItemViewModel
        Public Property NombreBusqueda As String = String.Empty
        Public ReadOnly Property SinResultados As Boolean
            Get
                Return Not TiposProductos.Any()
            End Get
        End Property

        Friend Async Function BuscarAsync() As Task
            Dim TiposProductosModel As List(Of TipoProducto) = Await Task.Run(Function() Servicio.BuscarTipoProducto(NombreBusqueda))

            If TiposProductosModel Is Nothing Then
                TiposProductosModel = New List(Of TipoProducto)()
            End If

            TiposProductos = New BindingList(Of TipoProductoItemViewModel)(Mapper.Map(Of List(Of TipoProductoItemViewModel))(TiposProductosModel))
            NotifyPropertyChanged(NameOf(Me.TiposProductos))
        End Function

        Friend Async Function AltaAsync() As Task
            Dim tipoProducto As TipoProducto = New TipoProducto(TipoProductoNuevo.Nombre, TipoProductoNuevo.Habilitado)
            Await Task.Run(Sub() Servicio.AltaTipoProducto(tipoProducto))
        End Function

        Friend Async Function ModificarAsync() As Task
            TipoProductoSeleccionadoModel.Modificar(TipoProductoMod.Nombre, TipoProductoMod.Habilitado)
            Await Task.Run(Sub() Servicio.ModificarTipoProducto(TipoProductoSeleccionadoModel))
            NotifyPropertyChanged(NameOf(Me.TiposProductos))
        End Function

        Friend Async Function EliminarAsync() As Task
            TipoProductoSeleccionadoModel.Eliminar()

            Await Task.Run(Sub() Servicio.ModificarTipoProducto(TipoProductoSeleccionadoModel))
            NotifyPropertyChanged(NameOf(Me.TiposProductos))
        End Function

        Friend Sub Limpiar()
            NombreBusqueda = String.Empty
            NotifyPropertyChanged(NameOf(Me.NombreBusqueda))
        End Sub

        Friend Async Function ObtenerSupplierAsync(id As Integer) As Task
            TipoProductoSeleccionadoModel = Await Task.Run(Function() Servicio.ObtenerTipoProducto(id))

            TipoProductoMod = Mapper.Map(Of TipoProductoItemViewModel)(TipoProductoSeleccionadoModel)
            NotifyPropertyChanged(NameOf(Me.TipoProductoMod))
        End Function

        Friend Sub LimpiarColorNuevo()
            TipoProductoNuevo = New TipoProductoItemViewModel()
            NotifyPropertyChanged(NameOf(Me.TipoProductoNuevo))
        End Sub
    End Class

End Namespace