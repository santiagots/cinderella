Imports System.Threading.Tasks
Imports Common.Core.Model
Imports SistemaCinderella.Formularios.Comex
Imports Modelo = Comex.Core.Model.ComexAggregate

Public Class frmBuscarProductoComex
    Inherits Comun

    Private frmBuscarProductoComexViewModel As frmBuscarProductoComexViewModel
    Private NombreCodigoProductoBusqueda As String
    Private SupplierSeleccionado As Supplier

    Public ProductoSeleccionado As Modelo.Producto

    Public Sub New()
        ' This call is required by the designer.
        InitializeComponent()
    End Sub

    Public Sub New(supplier As Supplier, nombreCodigoProductoBusqueda As String)
        Me.New()
        Me.NombreCodigoProductoBusqueda = nombreCodigoProductoBusqueda
        Me.SupplierSeleccionado = supplier
    End Sub



    Private Sub frmBuscarProductoComex_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        EjecutarAsync(Async Function() As Task
                          frmBuscarProductoComexViewModel = New frmBuscarProductoComexViewModel(NombreCodigoProductoBusqueda)
                          FrmBuscarProductoComexViewModelBindingSource.DataSource = frmBuscarProductoComexViewModel
                          Await frmBuscarProductoComexViewModel.CargarDatosAsync()

                          If (SupplierSeleccionado IsNot Nothing) Then
                              frmBuscarProductoComexViewModel.SeleccionarSupplier(SupplierSeleccionado)
                          End If
                      End Function)
    End Sub

    Private Sub btn_Buscar_Click(sender As Object, e As EventArgs) Handles btn_Buscar.Click
        EjecutarAsync(Async Function() As Task
                          Await frmBuscarProductoComexViewModel.BuscarProducto()
                      End Function)
    End Sub

    Private Sub DG_Productos_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DG_Productos.CellDoubleClick
        Dim producto As BuscarProductoComexItemViewModel = DG_Productos.CurrentRow.DataBoundItem
        ProductoSeleccionado = producto.Producto
        Me.DialogResult = DialogResult.OK
    End Sub
End Class