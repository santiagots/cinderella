Imports System.ComponentModel
Imports System.Threading.Tasks
Imports AutoMapper
Imports Producto.Core.Model.ProductoAgreggate

Namespace Formularios.Producto
    Public Class frmSuppliersViewModel
        Inherits Comunes.Common

        Private SuppliersSeleccionadoModel As Supplier

        Public Property Suppliers As BindingList(Of SupplierItemViewModel) = New BindingList(Of SupplierItemViewModel)()
        Public Property SupplierNuevo As SupplierItemViewModel
        Public Property SuppliersMod As SupplierItemViewModel
        Public Property NombreBusqueda As String = String.Empty
        Public ReadOnly Property SinResultados As Boolean
            Get
                Return Not Suppliers.Any()
            End Get
        End Property

        Friend Async Function BuscarAsync() As Task
            Dim suppliersModel As List(Of Supplier) = Await Task.Run(Function() Servicio.BuscarSupplier(NombreBusqueda))

            If suppliersModel Is Nothing Then
                suppliersModel = New List(Of Supplier)()
            End If

            Suppliers = New BindingList(Of SupplierItemViewModel)(Mapper.Map(Of List(Of SupplierItemViewModel))(suppliersModel))
            NotifyPropertyChanged(NameOf(Me.Suppliers))
        End Function

        Friend Async Function AltaAsync() As Task
            Dim supplier As Supplier = New Supplier(SupplierNuevo.Nombre, SupplierNuevo.POL, SupplierNuevo.DeliveryTime, SupplierNuevo.Habilitado)
            Await Task.Run(Sub() Servicio.AltaSupplier(supplier))
        End Function

        Friend Async Function ModificarAsync() As Task
            SuppliersSeleccionadoModel.Modificar(SuppliersMod.Nombre, SuppliersMod.POL, SuppliersMod.DeliveryTime, SuppliersMod.Habilitado)
            Await Task.Run(Sub() Servicio.ModificarSupplier(SuppliersSeleccionadoModel))
            NotifyPropertyChanged(NameOf(Me.Suppliers))
        End Function

        Friend Async Function EliminarAsync() As Task
            SuppliersSeleccionadoModel.Eliminar()

            Await Task.Run(Sub() Servicio.ModificarSupplier(SuppliersSeleccionadoModel))
            NotifyPropertyChanged(NameOf(Me.Suppliers))
        End Function

        Friend Sub Limpiar()
            NombreBusqueda = String.Empty
            NotifyPropertyChanged(NameOf(Me.NombreBusqueda))
        End Sub

        Friend Async Function ObtenerSupplierAsync(id As Integer) As Task
            SuppliersSeleccionadoModel = Await Task.Run(Function() Servicio.ObtenerSupplier(id))

            SuppliersMod = Mapper.Map(Of SupplierItemViewModel)(SuppliersSeleccionadoModel)
            NotifyPropertyChanged(NameOf(Me.SuppliersMod))
        End Function

        Friend Sub LimpiarSupplierNuevo()
            SupplierNuevo = New SupplierItemViewModel()
            NotifyPropertyChanged(NameOf(Me.SupplierNuevo))
        End Sub
    End Class
End Namespace
