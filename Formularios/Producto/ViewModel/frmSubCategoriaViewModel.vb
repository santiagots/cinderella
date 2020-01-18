Imports System.ComponentModel
Imports System.Threading.Tasks
Imports AutoMapper
Imports Common.Core.Enum
Imports Common.Core.Model

Namespace Formularios.Producto
    Public Class frmSubCategoriaViewModel
        Inherits Comunes.Common

        Private SubcategoriasSeleccionadaModel As SubCategoria

        Private TotalPaginas As Integer = 0
        Private ItemsPorPagina As Integer = My.Settings.PaginacionItemsPagina

        Public Property IVAs As BindingList(Of KeyValuePair(Of IVA, String))
        Public Property Categorias As BindingList(Of Categoria)
        Public Property NuevaCatagoriaSeleccionada As Categoria
        Public Property NuevaNombre As String
        Public Property NuevaIVASeleccionada As IVA
        Public Property NuevaHabilitada As String
        Public Property ModificarCatagoriaSeleccionada As Categoria
        Public Property ModificarNombre As String
        Public Property ModificarIVASeleccionada As IVA
        Public Property ModificarHabilitada As String
        Public Property BuscarIVAs As BindingList(Of KeyValuePair(Of IVA, String))
        Public Property BuscarCategorias As BindingList(Of KeyValuePair(Of Categoria, String))
        Public Property BuscarCatagoriaSeleccionada As KeyValuePair(Of Categoria, String)
        Public Property BuscarIVASeleccionada As KeyValuePair(Of IVA, String)
        Public Property BuscarNombre As String
        Public Property BuscarHabilitada As Boolean
        Public Property Subcategorias As BindingList(Of SubcategoriaItemViewModel)
        Public Property PaginasSubcategorias As BindingList(Of SubcategoriaItemViewModel)()
        Public Property SubcategoriaOrdenadoDireccion As OrdenadoDireccion
        Public Property SubcategoriaOrdenadoPor As String
        Public Property PaginaActual As Integer

        Sub New()
            Categorias = New BindingList(Of Categoria)()
            Subcategorias = New BindingList(Of SubcategoriaItemViewModel)
            SubcategoriaOrdenadoDireccion = OrdenadoDireccion.DESC
            SubcategoriaOrdenadoPor = "Categoria.Descripcion"
            PaginaActual = 1
            BuscarHabilitada = True
        End Sub

        Friend Async Function AgregarSubcategoriaAsync() As Task
            Dim subCategoria As SubCategoria = New SubCategoria(NuevaNombre, NuevaIVASeleccionada, NuevaHabilitada, NuevaCatagoriaSeleccionada)
            Await Task.Run(Sub() Servicio.GuardarSubCategorias(subCategoria))
            Await BuscarSubcategoriasAsync()

            LimpiarProductoNuevo()
        End Function

        Friend Async Function ActualizarSubcategoriaAsync() As Task
            SubcategoriasSeleccionadaModel.ActualizarDatos(ModificarNombre, ModificarIVASeleccionada, ModificarHabilitada, ModificarCatagoriaSeleccionada)
            Await Task.Run(Sub() Servicio.ActualizarCategorias(SubcategoriasSeleccionadaModel))
            Await BuscarSubcategoriasAsync()
        End Function

        Friend Async Function CargarDatosAsync() As Task
            Dim tareas As List(Of Task) = New List(Of Task)()
            tareas.Add(BuscarSubcategoriasAsync())
            tareas.Add(CargarCategoriasAsync())
            tareas.Add(CargarIVAsAsync())
            Await Task.WhenAll(tareas)

            LimpiarProductoNuevo()
        End Function

        Friend Sub LimpiarProductoNuevo()
            NuevaCatagoriaSeleccionada = Categorias.First()
            NuevaNombre = String.Empty
            NuevaHabilitada = True

            Dim iva As KeyValuePair(Of IVA, String) = IVAs.FirstOrDefault(Function(x) x.Key.Valor = 0.21)
            NuevaIVASeleccionada = If(iva.Key, IVAs.First.Key)

            NotifyPropertyChanged(NameOf(Me.NuevaCatagoriaSeleccionada))
            NotifyPropertyChanged(NameOf(Me.NuevaNombre))
            NotifyPropertyChanged(NameOf(Me.NuevaIVASeleccionada))
            NotifyPropertyChanged(NameOf(Me.NuevaHabilitada))
        End Sub

        Private Async Function CargarCategoriasAsync() As Task
            Dim categoriaModel As IList(Of Categoria) = Await Task.Run(Function() Servicio.ObtenerCategorias())

            Categorias = New BindingList(Of Categoria)(categoriaModel)

            BuscarCategorias = New BindingList(Of KeyValuePair(Of Categoria, String))(categoriaModel.Select(Function(x) New KeyValuePair(Of Categoria, String)(x, x.Descripcion)).ToList())
            BuscarCategorias.Insert(0, New KeyValuePair(Of Categoria, String)(Nothing, "Todos"))

            NotifyPropertyChanged(NameOf(Me.Categorias))
        End Function

        Friend Async Function CargarSubcategoriaAsync(id As Integer) As Task
            SubcategoriasSeleccionadaModel = Await Task.Run(Function() Servicio.ObtenerSubcategorias(id))

            ModificarCatagoriaSeleccionada = SubcategoriasSeleccionadaModel.Categoria
            ModificarNombre = SubcategoriasSeleccionadaModel.Descripcion
            ModificarIVASeleccionada = SubcategoriasSeleccionadaModel.IVA
            ModificarHabilitada = SubcategoriasSeleccionadaModel.Habilitado

            NotifyPropertyChanged(NameOf(Me.ModificarCatagoriaSeleccionada))
            NotifyPropertyChanged(NameOf(Me.ModificarNombre))
            NotifyPropertyChanged(NameOf(Me.ModificarIVASeleccionada))
            NotifyPropertyChanged(NameOf(Me.ModificarHabilitada))
        End Function

        Private Async Function CargarIVAsAsync() As Task
            Dim ivaModel As IList(Of IVA) = Await Task.Run(Function() Servicio.ObtenerIVAs())

            IVAs = New BindingList(Of KeyValuePair(Of IVA, String))(ivaModel.Select(Function(x) New KeyValuePair(Of IVA, String)(x, x.Valor.ToString("p"))).ToList())

            BuscarIVAs = New BindingList(Of KeyValuePair(Of IVA, String))(ivaModel.Select(Function(x) New KeyValuePair(Of IVA, String)(x, x.Valor.ToString("p"))).ToList())
            BuscarIVAs.Insert(0, New KeyValuePair(Of IVA, String)(Nothing, "Todos"))

            NotifyPropertyChanged(NameOf(Me.IVAs))
        End Function

        Friend Async Function BuscarSubcategoriasAsync() As Task
            Dim subCategoriaModel As IList(Of SubCategoria) = Await Task.Run(Function() Servicio.BuscarSubcategorias(BuscarNombre, BuscarCatagoriaSeleccionada.Key, BuscarIVASeleccionada.Key, BuscarHabilitada, SubcategoriaOrdenadoPor, SubcategoriaOrdenadoDireccion, PaginaActual, ItemsPorPagina, TotalPaginas))
            Subcategorias = New BindingList(Of SubcategoriaItemViewModel)(Mapper.Map(Of List(Of SubcategoriaItemViewModel))(subCategoriaModel))
            PaginasSubcategorias = New BindingList(Of SubcategoriaItemViewModel)(CalcularCantidadPaginas(TotalPaginas)) {}

            NotifyPropertyChanged(NameOf(Me.Subcategorias))
        End Function

        Private Function CalcularCantidadPaginas(cantidadItemas As Integer) As Integer
            Dim paginas As Integer = 0

            Do
                paginas += 1
                cantidadItemas -= ItemsPorPagina
            Loop Until (cantidadItemas <= 0)

            Return paginas - 1
        End Function

    End Class
End Namespace
