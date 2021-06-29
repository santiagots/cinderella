Imports System.Threading.Tasks
Imports Common.Core.Enum
Imports Common.Core.Exceptions
Imports Common.Core.Helper
Imports SistemaCinderella.Formularios.Venta
Imports Model = Ventas.Core.Model.VentaAggregate

Public Class frmVentasAdministracion

    Private ventasAdministracionViewModel As frmVentasAdministracionViewModel
    Private ventaVerDetalle As Model.Venta

    Sub New()
        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        AddHandler txtFacturaDesde.DataBindings(0).Parse, AddressOf NullParseHandler
        AddHandler txtFacturaHasta.DataBindings(0).Parse, AddressOf NullParseHandler
        AddHandler txtMontoDesde.DataBindings(0).Parse, AddressOf NullParseHandler
        AddHandler txtMontoHasta.DataBindings(0).Parse, AddressOf NullParseHandler
    End Sub

    Sub New(venta As Model.Venta)
        ' This call is required by the designer.
        InitializeComponent()
        ventaVerDetalle = venta
        ' Add any initialization after the InitializeComponent() call.
    End Sub

    Private Sub frmVentasAdministracion_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        EjecutarAsync(Async Function() As Task

                          If (ventaVerDetalle Is Nothing) Then
                              ventasAdministracionViewModel = New frmVentasAdministracionViewModel(My.Settings.Sucursal, Me.MdiParent)
                              FrmVentasAdministracionViewModelBindingSource.DataSource = ventasAdministracionViewModel
                              VentaDetalle.VentaDetalleBindingSource.DataSource = ventasAdministracionViewModel.VentaDetalleSeleccionada
                              EvaluarPermisos()
                              Await ventasAdministracionViewModel.BuscarAsync()
                              lbFormaPago.ClearSelected()
                              lbTipoCliente.ClearSelected()
                              lbTipoFactura.ClearSelected()
                          Else
                              ventasAdministracionViewModel = New frmVentasAdministracionViewModel(ventaVerDetalle, Me.MdiParent)
                              FrmVentasAdministracionViewModelBindingSource.DataSource = ventasAdministracionViewModel
                              VentaDetalle.VentaDetalleBindingSource.DataSource = ventasAdministracionViewModel.VentaDetalleSeleccionada
                              RemoveHandler TabVentas.Selected, AddressOf TabVentas_Selected
                              TabVentas.TabPages.Remove(TbListado)
                              TabVentas.SelectedTab = TbDetalle
                          End If

                      End Function)
        Me.DataBindings.Add(New Binding("Visible", Me.FrmVentasAdministracionViewModelBindingSource, "Visible", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
    End Sub

    Private Sub btn_Restablecer_Click(sender As Object, e As EventArgs) Handles btn_Restablecer.Click
        EjecutarAsync(Async Function() As Task
                          ventasAdministracionViewModel.TiposClientesSeleccionado = Nothing
                          ventasAdministracionViewModel.TiposPagosSeleccionado = Nothing
                          ventasAdministracionViewModel.TiposFacturasSeleccionado = Nothing

                          Await ventasAdministracionViewModel.RestablecerAsync()

                          lbFormaPago.ClearSelected()
                          lbTipoCliente.ClearSelected()
                          lbTipoFactura.ClearSelected()
                      End Function)
    End Sub

    Private Sub BtnFiltrar_Click(sender As Object, e As EventArgs) Handles BtnFiltrar.Click
        EjecutarAsync(Async Function() As Task
                          ventasAdministracionViewModel.TiposClientesSeleccionado = ObtenerListBox(Of TipoCliente?)(lbTipoCliente)
                          ventasAdministracionViewModel.TiposPagosSeleccionado = ObtenerListBox(Of TipoPago?)(lbFormaPago)
                          ventasAdministracionViewModel.TiposFacturasSeleccionado = ObtenerListBox(Of TipoFactura?)(lbTipoFactura)

                          Await ventasAdministracionViewModel.BuscarAsync()

                          CaragrListBox(Of TipoCliente?)(ventasAdministracionViewModel.TiposClientesSeleccionado, lbTipoCliente)
                          CaragrListBox(Of TipoPago?)(ventasAdministracionViewModel.TiposPagosSeleccionado, lbFormaPago)
                          CaragrListBox(Of TipoFactura?)(ventasAdministracionViewModel.TiposFacturasSeleccionado, lbTipoFactura)
                      End Function)
    End Sub

    Private Sub DG_Ventas_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DG_Ventas.CellDoubleClick
        Ejecutar(Sub()
                     VentaDetalle.VentaDetalleBindingSource.DataSource = ventasAdministracionViewModel.VentaDetalleSeleccionada
                     TabVentas.SelectedTab = TbDetalle
                 End Sub)
    End Sub

    Private Sub DG_Ventas_CellFormatting(sender As Object, e As DataGridViewCellFormattingEventArgs) Handles DG_Ventas.CellFormatting

        If (DG_Ventas.Columns(e.ColumnIndex).Name = "Anulado") Then
            e.Value = If(e.Value, "Si", "No")
        End If
    End Sub

    Private Sub btnReporteVenta_Click(sender As Object, e As EventArgs) Handles btnReporteVenta.Click
        Ejecutar(Sub() ventasAdministracionViewModel.Imprimir())
    End Sub

    Private Sub BtnAnular_Click(sender As Object, e As EventArgs) Handles BtnAnular.Click
        EjecutarAsync(Async Function() As Task
                          Dim respuesta As DialogResult = MessageBox.Show("¿Está seguro que desea anular la venta?", "Administración de Ventas", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                          If respuesta = DialogResult.Yes Then
                              Await ventasAdministracionViewModel.AnularAsync()
                          End If
                      End Function)
    End Sub

    Private Sub BtnFacturaDetalle_Click(sender As Object, e As EventArgs) Handles BtnFacturaDetalle.Click
        Ejecutar(Sub() ventasAdministracionViewModel.MostrarFacturaDetalle())
    End Sub

    Private Sub BtnNotaCreditoDetalle_Click(sender As Object, e As EventArgs) Handles BtnNotaCreditoDetalle.Click
        Ejecutar(Sub() ventasAdministracionViewModel.MostrarNotaCreditoDetalle())
    End Sub

    Private Sub BtnEmitirFactura_Click(sender As Object, e As EventArgs) Handles BtnEmitirFactura.Click
        Ejecutar(Sub() ventasAdministracionViewModel.Faturar())
    End Sub

    Private Sub TabVentas_Selected(sender As Object, e As TabControlEventArgs) Handles TabVentas.Selected
        EjecutarAsync(Async Function() As Task
                          ventasAdministracionViewModel.TiposClientesSeleccionado = ObtenerListBox(Of TipoCliente?)(lbTipoCliente)
                          ventasAdministracionViewModel.TiposPagosSeleccionado = ObtenerListBox(Of TipoPago?)(lbFormaPago)
                          ventasAdministracionViewModel.TiposFacturasSeleccionado = ObtenerListBox(Of TipoFactura?)(lbTipoFactura)

                          If (TabVentas.SelectedTab.Name = TbDetalle.Name) Then
                              If (DG_Ventas.CurrentRow Is Nothing) Then
                                  MessageBox.Show("No se encuentra una venta seleccionada. Para ver el detalle de una venta debe seleccionar una.", "Administración de Ventas", MessageBoxButtons.OK, MessageBoxIcon.Error)
                                  TabVentas.SelectedTab = TbListado
                                  Return
                              End If
                              Await ventasAdministracionViewModel.CargarVentaAsync(DG_Ventas.CurrentRow.DataBoundItem)
                              VentaDetalle.VentaDetalleBindingSource.DataSource = ventasAdministracionViewModel.VentaDetalleSeleccionada
                          End If

                          CaragrListBox(Of TipoCliente?)(ventasAdministracionViewModel.TiposClientesSeleccionado, lbTipoCliente)
                          CaragrListBox(Of TipoPago?)(ventasAdministracionViewModel.TiposPagosSeleccionado, lbFormaPago)
                          CaragrListBox(Of TipoFactura?)(ventasAdministracionViewModel.TiposFacturasSeleccionado, lbTipoFactura)
                      End Function)
    End Sub

    Private Sub EvaluarPermisos()
        If (VariablesGlobales.Patentes.ContainsKey(Entidades.TipoPatente.Administración_Ventas_Administración_Detalle_Visualizar)) Then

        Else
            TabVentas.TabPages.Remove(TabVentas.TabPages("TbDetalle"))
            RemoveHandler DG_Ventas.CellDoubleClick, AddressOf DG_Ventas_CellDoubleClick
        End If

        If (VariablesGlobales.Patentes.ContainsKey(Entidades.TipoPatente.Administración_Ventas_Administración_Detalle_Anular)) Then
            BtnAnular.Enabled = True
        Else
            BtnAnular.Enabled = False
        End If

        If (VariablesGlobales.Patentes.ContainsKey(Entidades.TipoPatente.Administración_Ventas_Administración_Detalle_Facturar)) Then
            BtnFacturaDetalle.Enabled = True
        Else
            BtnFacturaDetalle.Enabled = False
        End If

        If (VariablesGlobales.Patentes.ContainsKey(Entidades.TipoPatente.Administración_Ventas_Administración_Detalle_NotaCrédito)) Then
            BtnEmitirFactura.Enabled = True
        Else
            BtnEmitirFactura.Enabled = False
        End If
    End Sub

    Private Function ObtenerListBox(Of T)(lista As ListBox) As List(Of KeyValuePair(Of T, String))
        Dim resultado As List(Of KeyValuePair(Of T, String)) = New List(Of KeyValuePair(Of T, String))
        For Each item As KeyValuePair(Of T, String) In lista.SelectedItems
            resultado.Add(item)
        Next
        Return resultado
    End Function

    Private Sub CaragrListBox(Of T)(items As List(Of KeyValuePair(Of T, String)), lista As ListBox)
        If (Not items.Any()) Then
            lista.ClearSelected()
        End If

        For Each item As KeyValuePair(Of T, String) In items
            lista.SelectedItems.Add(item)
        Next
    End Sub

    Private Sub NullParseHandler(ByVal sender As Object, ByVal e As ConvertEventArgs)
        If e.Value IsNot Nothing AndAlso String.IsNullOrEmpty(e.Value.ToString()) Then e.Value = Nothing
    End Sub
End Class