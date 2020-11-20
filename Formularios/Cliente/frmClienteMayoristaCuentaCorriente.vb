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
                          frmClienteMayoristaCuentaCorrienteViewModel.MovimientosElementosPorPagina = PaginadoMovimientos.ElementosPorPagina
                          frmClienteMayoristaCuentaCorrienteViewModel.NotasPedidosElementosPorPagina = PaginadoNotaPedido.ElementosPorPagina

                          Await frmClienteMayoristaCuentaCorrienteViewModel.CargarMovimientosAsync()
                          Await frmClienteMayoristaCuentaCorrienteViewModel.CargarNotasPedidoAsync()
                      End Function)
    End Sub

    Private Sub btnPagoDocumento_Click(sender As Object, e As EventArgs) Handles btnPagoDocumento.Click
        EjecutarAsync(Async Function() As Task
                          Dim frmClienteMayoristaCuentaCorrientePago As frmClienteMayoristaDocumentoPago = New frmClienteMayoristaDocumentoPago(frmClienteMayoristaCuentaCorrienteViewModel.ClienteMayorista)
                          frmClienteMayoristaCuentaCorrientePago.ShowDialog()
                          Await frmClienteMayoristaCuentaCorrienteViewModel.CargarMovimientosAsync()
                      End Function)
    End Sub

    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        EjecutarAsync(Async Function() As Task
                          Await frmClienteMayoristaCuentaCorrienteViewModel.CargarMovimientosAsync()
                      End Function)
    End Sub

    Private Sub btnImprimir_Click(sender As Object, e As EventArgs) Handles btnImprimir.Click
        Ejecutar(Sub() frmClienteMayoristaCuentaCorrienteViewModel.ImprimirCuenta())
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
                          If dgvMovimientos.Columns(e.ColumnIndex).Name = "Imprimir" Then
                              frmClienteMayoristaCuentaCorrienteViewModel.ImprimirMovimiento(dgvMovimientos.CurrentRow.DataBoundItem)
                          End If
                      End Function)
    End Sub

    Private Sub PaginadoMovimientos_PaginaAnteriorClick(sender As Object, e As EventArgs) Handles PaginadoMovimientos.PaginaAnteriorClick
        EjecutarAsync(Async Function() As Task
                          frmClienteMayoristaCuentaCorrienteViewModel.MovimientosPaginaActual += -1
                          Await frmClienteMayoristaCuentaCorrienteViewModel.CargarMovimientosAsync()
                      End Function)
    End Sub

    Private Sub PaginadoMovimientos_PaginaFinalClick(sender As Object, e As EventArgs) Handles PaginadoMovimientos.PaginaFinalClick
        EjecutarAsync(Async Function() As Task
                          frmClienteMayoristaCuentaCorrienteViewModel.MovimientosPaginaActual = PaginadoMovimientos.TotalPaginas
                          Await frmClienteMayoristaCuentaCorrienteViewModel.CargarMovimientosAsync()
                      End Function)
    End Sub

    Private Sub PaginadoMovimientos_PaginaInicalClick(sender As Object, e As EventArgs) Handles PaginadoMovimientos.PaginaInicalClick
        EjecutarAsync(Async Function() As Task
                          frmClienteMayoristaCuentaCorrienteViewModel.MovimientosPaginaActual = 1
                          Await frmClienteMayoristaCuentaCorrienteViewModel.CargarMovimientosAsync()
                      End Function)
    End Sub

    Private Sub PaginadoMovimientos_PaginaSiguienteClick(sender As Object, e As EventArgs) Handles PaginadoMovimientos.PaginaSiguienteClick
        EjecutarAsync(Async Function() As Task
                          frmClienteMayoristaCuentaCorrienteViewModel.MovimientosPaginaActual += 1
                          Await frmClienteMayoristaCuentaCorrienteViewModel.CargarMovimientosAsync()
                      End Function)
    End Sub

    Private Sub PaginadoNotaPedido_PaginaAnteriorClick(sender As Object, e As EventArgs) Handles PaginadoNotaPedido.PaginaAnteriorClick
        EjecutarAsync(Async Function() As Task
                          frmClienteMayoristaCuentaCorrienteViewModel.NotasPedidosPaginaActual += -1
                          Await frmClienteMayoristaCuentaCorrienteViewModel.CargarNotasPedidoAsync()
                      End Function)
    End Sub

    Private Sub PaginadoNotaPedido_PaginaFinalClick(sender As Object, e As EventArgs) Handles PaginadoNotaPedido.PaginaFinalClick
        EjecutarAsync(Async Function() As Task
                          frmClienteMayoristaCuentaCorrienteViewModel.NotasPedidosPaginaActual = PaginadoNotaPedido.TotalPaginas
                          Await frmClienteMayoristaCuentaCorrienteViewModel.CargarNotasPedidoAsync()
                      End Function)
    End Sub

    Private Sub PaginadoNotaPedido_PaginaInicalClick(sender As Object, e As EventArgs) Handles PaginadoNotaPedido.PaginaInicalClick
        EjecutarAsync(Async Function() As Task
                          frmClienteMayoristaCuentaCorrienteViewModel.NotasPedidosPaginaActual = 1
                          Await frmClienteMayoristaCuentaCorrienteViewModel.CargarNotasPedidoAsync()
                      End Function)
    End Sub

    Private Sub PaginadoNotaPedido_PaginaSiguienteClick(sender As Object, e As EventArgs) Handles PaginadoNotaPedido.PaginaSiguienteClick
        EjecutarAsync(Async Function() As Task
                          frmClienteMayoristaCuentaCorrienteViewModel.NotasPedidosPaginaActual += 1
                          Await frmClienteMayoristaCuentaCorrienteViewModel.CargarNotasPedidoAsync()
                      End Function)
    End Sub

    Private Sub dgvNotasPedidos_ColumnHeaderMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles dgvNotasPedidos.ColumnHeaderMouseClick
        EjecutarAsync(Async Function() As Task
                          If (dgvNotasPedidos.Columns(e.ColumnIndex).SortMode <> DataGridViewColumnSortMode.NotSortable) Then

                              Select Case dgvNotasPedidos.Columns(e.ColumnIndex).HeaderText
                                  Case "Numero"
                                      frmClienteMayoristaCuentaCorrienteViewModel.NotasPedidosOrdenadoPor = "Numero"
                                  Case "Vendedor"
                                      frmClienteMayoristaCuentaCorrienteViewModel.NotasPedidosOrdenadoPor = "Vendedor.Apellido"
                                  Case "Fecha"
                                      frmClienteMayoristaCuentaCorrienteViewModel.NotasPedidosOrdenadoPor = "Fecha"
                                  Case "Estado"
                                      frmClienteMayoristaCuentaCorrienteViewModel.NotasPedidosOrdenadoPor = "Estado"
                              End Select

                              frmClienteMayoristaCuentaCorrienteViewModel.NotasPedidosDireccionOrdenamiento = If(frmClienteMayoristaCuentaCorrienteViewModel.NotasPedidosDireccionOrdenamiento = OrdenadoDireccion.ASC, OrdenadoDireccion.DESC, OrdenadoDireccion.ASC)
                              Await frmClienteMayoristaCuentaCorrienteViewModel.CargarNotasPedidoAsync()

                              dgvNotasPedidos.Columns(e.ColumnIndex).HeaderCell.SortGlyphDirection = If(frmClienteMayoristaCuentaCorrienteViewModel.NotasPedidosDireccionOrdenamiento = OrdenadoDireccion.ASC, SortOrder.Ascending, SortOrder.Descending)
                          End If
                      End Function)
    End Sub

    Private Sub dgvMovimientos_CellFormatting(sender As Object, e As DataGridViewCellFormattingEventArgs) Handles dgvMovimientos.CellFormatting
        Ejecutar(Sub()
                     Dim CuentaCorrienteMovimientosItem As CuentaCorrienteMovimientosItem = dgvMovimientos.Rows(e.RowIndex).DataBoundItem

                     MostrarIconoImprimir(e, CuentaCorrienteMovimientosItem)
                     ColorearCeldaPorMontoEnCuentaCorriente(e, CuentaCorrienteMovimientosItem)
                 End Sub)
    End Sub

    Private Sub MostrarIconoImprimir(ByRef e As DataGridViewCellFormattingEventArgs, CuentaCorrienteMovimientosItem As CuentaCorrienteMovimientosItem)
        If (CuentaCorrienteMovimientosItem.TipoMovimientoCuentaCorriente = Common.Core.Enum.TipoMovimientoCuentaCorriente.Venta AndAlso dgvMovimientos.Columns(e.ColumnIndex).Name = "Imprimir") Then
            e.Value = New Bitmap(1, 1)
        End If
    End Sub

    Private Sub ColorearCeldaPorMontoEnCuentaCorriente(ByRef e As DataGridViewCellFormattingEventArgs, CuentaCorrienteMovimientosItem As CuentaCorrienteMovimientosItem)
        If (CuentaCorrienteMovimientosItem.Monto = 0) Then
            Return
        End If

        If (CuentaCorrienteMovimientosItem.Monto > 0) Then
            e.CellStyle.BackColor = VariablesGlobales.colorFondoOk
            e.CellStyle.ForeColor = VariablesGlobales.colorTextoOk
        Else
            e.CellStyle.BackColor = VariablesGlobales.colorFondoAlerta
            e.CellStyle.ForeColor = VariablesGlobales.colorTextoAlerta
        End If
    End Sub
End Class