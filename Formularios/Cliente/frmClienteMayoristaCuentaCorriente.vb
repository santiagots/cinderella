Imports System.Threading.Tasks
Imports Common.Core.Enum
Imports Common.Core.Model
Imports SistemaCinderella.Formularios.Cliente

Public Class frmClienteMayoristaCuentaCorriente
    Inherits Comun

    Dim frmClienteMayoristaCuentaCorrienteViewModel As frmClienteMayoristaCuentaCorrienteViewModel
    Dim finalizarDelegate As Action

    Sub New(clienteMayorista As ClienteMayorista, finalizarDelegate As Action)
        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Me.finalizarDelegate = finalizarDelegate
        frmClienteMayoristaCuentaCorrienteViewModel = New frmClienteMayoristaCuentaCorrienteViewModel(clienteMayorista)
    End Sub


    Private Sub frmClienteMayoristaCuentaCorriente_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        EjecutarAsync(Async Function() As Task
                          FrmClienteMayoristaCuentaCorrienteViewModelBindingSource.DataSource = frmClienteMayoristaCuentaCorrienteViewModel
                          frmClienteMayoristaCuentaCorrienteViewModel.MovimientosElementosPorPagina = Paginado.ElementosPorPagina
                          Await frmClienteMayoristaCuentaCorrienteViewModel.CargarAsync()
                      End Function)
    End Sub

    Private Sub btnPagoDocumento_Click(sender As Object, e As EventArgs) Handles btnPagoDocumento.Click
        EjecutarAsync(Async Function() As Task
                          Dim frmClienteMayoristaCuentaCorrientePago As frmClienteMayoristaDocumentoPago = New frmClienteMayoristaDocumentoPago(frmClienteMayoristaCuentaCorrienteViewModel.IdClienteMayorista)
                          frmClienteMayoristaCuentaCorrientePago.ShowDialog()
                          Await frmClienteMayoristaCuentaCorrienteViewModel.CargarAsync()
                      End Function)
    End Sub

    Private Sub frmClienteMayoristaCuentaCorriente_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        finalizarDelegate()
    End Sub

    Private Sub dgvMovimientos_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvMovimientos.CellDoubleClick
        EjecutarAsync(Async Function() As Task
                          Await frmClienteMayoristaCuentaCorrienteViewModel.CargarDetalleMovimientoAsync(dgvMovimientos.CurrentRow.DataBoundItem)
                      End Function)
    End Sub

    Private Sub dgvMovimientos_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvMovimientos.CellClick
        EjecutarAsync(Async Function() As Task
                          If dgvMovimientos.Columns(e.ColumnIndex).Name = "Detalle" Then
                              Await frmClienteMayoristaCuentaCorrienteViewModel.CargarDetalleMovimientoAsync(dgvMovimientos.CurrentRow.DataBoundItem)
                          End If
                      End Function)
    End Sub

    Private Sub Paginado_PaginaAnteriorClick(sender As Object, e As EventArgs) Handles Paginado.PaginaAnteriorClick
        EjecutarAsync(Async Function() As Task
                          frmClienteMayoristaCuentaCorrienteViewModel.MovimientosPaginaActual += -1
                          Await frmClienteMayoristaCuentaCorrienteViewModel.CargarAsync()
                      End Function)
    End Sub

    Private Sub Paginado_PaginaFinalClick(sender As Object, e As EventArgs) Handles Paginado.PaginaFinalClick
        EjecutarAsync(Async Function() As Task
                          frmClienteMayoristaCuentaCorrienteViewModel.MovimientosPaginaActual = Paginado.TotalPaginas
                          Await frmClienteMayoristaCuentaCorrienteViewModel.CargarAsync()
                      End Function)
    End Sub

    Private Sub Paginado_PaginaInicalClick(sender As Object, e As EventArgs) Handles Paginado.PaginaInicalClick
        EjecutarAsync(Async Function() As Task
                          frmClienteMayoristaCuentaCorrienteViewModel.MovimientosPaginaActual = 1
                          Await frmClienteMayoristaCuentaCorrienteViewModel.CargarAsync()
                      End Function)
    End Sub

    Private Sub Paginado_PaginaSiguienteClick(sender As Object, e As EventArgs) Handles Paginado.PaginaSiguienteClick
        EjecutarAsync(Async Function() As Task
                          frmClienteMayoristaCuentaCorrienteViewModel.MovimientosPaginaActual += 1
                          Await frmClienteMayoristaCuentaCorrienteViewModel.CargarAsync()
                      End Function)
    End Sub
End Class