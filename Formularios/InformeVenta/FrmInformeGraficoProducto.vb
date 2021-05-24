Imports System.Threading.Tasks
Imports Common.Core.Exceptions
Imports SistemaCinderella.Formularios.InformeVenta

Public Class FrmInformeGraficoProducto

    Private frmInformeGraficoProductoViewModel As frmInformeGraficoProductoViewModel

    Sub New(idSucursales As IEnumerable(Of Integer), fechaDesde As DateTime, fechaHasta As DateTime)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        frmInformeGraficoProductoViewModel = New frmInformeGraficoProductoViewModel(idSucursales, fechaDesde, fechaHasta)
    End Sub

    Public Async Function CargarDatosAsync() As Task
        Await frmInformeGraficoProductoViewModel.CargarAsync()
    End Function

    Private Sub FrmInformeGraficoProducto_LoadAsync(sender As Object, e As EventArgs) Handles MyBase.Load
        chtTopProductosMonto.DataSource = frmInformeGraficoProductoViewModel.ProductoPorNombreTopMonto
        chtTopProductosMonto.DataBind()

        chtTopProductosCantidad.DataSource = frmInformeGraficoProductoViewModel.ProductoPorNombreTopCantidad
        chtTopProductosCantidad.DataBind()

        chtTopCategoriaMonto.DataSource = frmInformeGraficoProductoViewModel.ProductoPorCategoriaTopMonto
        chtTopCategoriaMonto.DataBind()

        chtTopCategoriaCantidad.DataSource = frmInformeGraficoProductoViewModel.ProductoPorCategoriaTopCantidad
        chtTopCategoriaCantidad.DataBind()

        chtTopSubcategoriaMonto.DataSource = frmInformeGraficoProductoViewModel.ProductoSubCategoriaTopMonto
        chtTopSubcategoriaMonto.DataBind()

        chtTopSubcategoriaCantidad.DataSource = frmInformeGraficoProductoViewModel.ProductoSubCategoriaTopCantidad
        chtTopSubcategoriaCantidad.DataBind()
    End Sub

    Private Async Sub EjecutarAsync(accion As Func(Of Task))
        Try
            Me.UseWaitCursor = True
            Await accion()
        Catch ex As NegocioException
            MessageBox.Show(ex.Message, "Administración de Productos", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Catch ex As Exception
            MessageBox.Show("Error al realizar la accion. Por favor, intente mas tarde o consulte con el administrador.", "Administración de Productos", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            Me.UseWaitCursor = False
        End Try
    End Sub
End Class