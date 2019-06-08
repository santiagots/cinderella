Imports System.Threading.Tasks
Imports Common.Core.Exceptions
Imports Common.Core.Helper
Imports SistemaCinderella.Formularios.Venta

Public Class frmNotaCreditoAdministracion

    Private frmNotaCreditoAdministracionViewModel As frmNotaCreditoAdministracionViewModel

    Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        AddHandler txtNotaCreditoNro.DataBindings(0).Parse, AddressOf NullParseHandler
        AddHandler txtCUIT.DataBindings(0).Parse, AddressOf NullParseHandler
        AddHandler txtMontoHasta.DataBindings(0).Parse, AddressOf NullParseHandler
        AddHandler txtMontoDesde.DataBindings(0).Parse, AddressOf NullParseHandler
        AddHandler txtMontoHasta.DataBindings(0).Parse, AddressOf NullParseHandler
    End Sub

    Private Sub frmNotaCreditoAdministracion_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        EjecutarAsync(Async Function() As Task
                          frmNotaCreditoAdministracionViewModel = New frmNotaCreditoAdministracionViewModel(My.Settings.Sucursal, Me.MdiParent)
                          FrmNotaCreditoAdministracionViewModelBindingSource.DataSource = frmNotaCreditoAdministracionViewModel
                          Await frmNotaCreditoAdministracionViewModel.BuscarAsync()
                      End Function)
    End Sub

    Private Sub DG_NotaCredito_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DG_NotaCredito.CellContentClick
        EjecutarAsync(Async Function() As Task
                          If DG_NotaCredito.Columns(e.ColumnIndex).Name = "Factura" Then
                              Await frmNotaCreditoAdministracionViewModel.MostrarFacturaDetalle(DG_NotaCredito.CurrentRow.DataBoundItem)
                          End If
                      End Function)
    End Sub

    Private Sub btn_Restablecer_Click(sender As Object, e As EventArgs) Handles btn_Restablecer.Click
        EjecutarAsync(Async Function() As Task
                          Await frmNotaCreditoAdministracionViewModel.BuscarAsync()
                      End Function)
    End Sub

    Private Sub BtnFiltrar_Click(sender As Object, e As EventArgs) Handles BtnFiltrar.Click
        EjecutarAsync(Async Function() As Task
                          Await frmNotaCreditoAdministracionViewModel.BuscarAsync()
                      End Function)
    End Sub

    Private Sub NullParseHandler(ByVal sender As Object, ByVal e As ConvertEventArgs)
        If e.Value IsNot Nothing AndAlso String.IsNullOrEmpty(e.Value.ToString()) Then e.Value = Nothing
    End Sub

    Private Sub Ejecutar(accion As Action)
        Try
            accion()
        Catch ex As NegocioException
            Log.Error(ex)
            MessageBox.Show(ex.Message, "Registro de Ventas", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Catch ex As Exception
            Log.Error(ex)
            MessageBox.Show("Error al realizar la accion. Por favor, intente mas tarde o consulte con el administrador.", "Registro de Ventas", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Async Sub EjecutarAsync(accion As Func(Of Task))
        Try
            Await accion()
        Catch ex As NegocioException
            Log.Error(ex)
            MessageBox.Show(ex.Message, "Registro de Ventas", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Catch ex As Exception
            Log.Error(ex)
            MessageBox.Show("Error al realizar la accion. Por favor, intente mas tarde o consulte con el administrador.", "Registro de Ventas", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    'Dim NegNotaCredito As New Negocio.NegNotaCredito


    'Private Sub frmNotaCreditoAdministracion_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    '    FDesde.Value = Now.Date.AddDays(-30)
    '    FHasta.Value = Now.Date.AddDays(1)

    '    NotaCreditoBindingSource.DataSource = NegNotaCredito.ObtenerListado(My.Settings.Sucursal, FDesde.Value.ToString("yyyy/MM/dd"), FHasta.Value.ToString("yyyy/MM/dd"))
    'End Sub

    'Private Sub DG_NotaCredito_DataBindingComplete(sender As Object, e As DataGridViewBindingCompleteEventArgs) Handles DG_NotaCredito.DataBindingComplete
    '    lbl_Msg.Visible = DG_NotaCredito.Rows.Count = 0
    'End Sub

    'Private Sub BtnFiltrar_Click(sender As Object, e As EventArgs) Handles BtnFiltrar.Click
    '    'Cambio el cursor a "WAIT"
    '    Me.Cursor = Cursors.WaitCursor

    '    'Cargo el datagrid
    '    Dim notaCreditos As New List(Of Entidades.NotaCredito)
    '    notaCreditos = NegNotaCredito.ObtenerListado(My.Settings.Sucursal, FDesde.Value.ToString("yyyy/MM/dd"), FHasta.Value.ToString("yyyy/MM/dd"))

    '    Dim NotaCreditoTicket As New List(Of Entidades.NotaCredito)
    '    If ChkMarcaTicket.Checked Then
    '        NotaCreditoTicket = notaCreditos.Where(Function(x) x.TipoRecibo = Entidades.TipoFactura.Ticket).ToList()
    '    End If

    '    Dim NotaCreditoElectronica As New List(Of Entidades.NotaCredito)
    '    If ChkMarcaElectronica.Checked Then
    '        NotaCreditoElectronica = notaCreditos.Where(Function(x) x.TipoRecibo = Entidades.TipoFactura.Electronica).ToList()
    '    End If

    '    Dim NotaCreditoManual As New List(Of Entidades.NotaCredito)
    '    If ChkMarcaManual.Checked Then
    '        NotaCreditoManual = notaCreditos.Where(Function(x) x.TipoRecibo = Entidades.TipoFactura.Manual).ToList()
    '    End If

    '    If ChkMarcaTicket.Checked Or ChkMarcaElectronica.Checked Or ChkMarcaManual.Checked Then
    '        notaCreditos.Clear()
    '        notaCreditos.AddRange(NotaCreditoTicket)
    '        notaCreditos.AddRange(NotaCreditoElectronica)
    '        notaCreditos.AddRange(NotaCreditoManual)
    '    End If

    '    If Not String.IsNullOrEmpty(txtNotaCreditoNro.Text) Then
    '        notaCreditos = notaCreditos.Where(Function(x) x.NumeroNotaCredito = txtNotaCreditoNro.Text).ToList()
    '    End If

    '    If Not String.IsNullOrEmpty(txtMontoDesde.Text) Then
    '        notaCreditos = notaCreditos.Where(Function(x) x.Monto >= CType(txtMontoDesde.Text, Double)).ToList()
    '    End If

    '    If Not String.IsNullOrEmpty(txtMontoHasta.Text) Then
    '        notaCreditos = notaCreditos.Where(Function(x) x.Monto <= CType(txtMontoHasta.Text, Double)).ToList()
    '    End If

    '    If Not String.IsNullOrEmpty(txtNombre.Text) Then
    '        notaCreditos = notaCreditos.Where(Function(x) x.Nombre.Contains(txtNombre.Text)).ToList()
    '    End If

    '    If Not String.IsNullOrEmpty(txtCUIT.Text) Then
    '        notaCreditos = notaCreditos.Where(Function(x) x.Cuit.Contains(txtCUIT.Text)).ToList()
    '    End If

    '    NotaCreditoBindingSource.DataSource = notaCreditos

    '    'Cambio el cursor a NORMAL.
    '    Me.Cursor = Cursors.Arrow
    'End Sub

    'Private Sub btn_Restablecer_Click(sender As Object, e As EventArgs) Handles btn_Restablecer.Click
    '    FDesde.Value = Now.Date.AddDays(-30)
    '    FHasta.Value = Now.Date.AddDays(1)
    '    ChkMarcaElectronica.Checked = True
    '    ChkMarcaManual.Checked = True
    '    ChkMarcaTicket.Checked = True
    '    txtCUIT.Clear()
    '    txtNotaCreditoNro.Clear()
    '    txtMontoDesde.Clear()
    '    txtMontoHasta.Clear()
    '    txtNombre.Clear()

    '    NotaCreditoBindingSource.DataSource = NegNotaCredito.ObtenerListado(My.Settings.Sucursal, FDesde.Value.ToString("yyyy/MM/dd"), FHasta.Value.ToString("yyyy/MM/dd"))
    'End Sub

    'Private Sub DG_NotaCredito_CellFormatting(sender As Object, e As DataGridViewCellFormattingEventArgs) Handles DG_NotaCredito.CellFormatting
    '    'Elimino el boton de detalla factura en caso de que la nota de credito no tenga factura asociada
    '    If (DG_NotaCredito.Columns(e.ColumnIndex).Name = "Factura" And NotaCreditoBindingSource.List.Count > e.RowIndex) Then
    '        Dim notaCredito As Entidades.NotaCredito = NotaCreditoBindingSource.List(e.RowIndex)
    '        If (notaCredito.id_Factura = 0) Then
    '            e.CellStyle.Padding = New Padding(1000, 1000, 0, 0)
    '        End If
    '    End If
    'End Sub

    'Private Sub DG_NotaCredito_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DG_NotaCredito.CellContentClick
    '    If (DG_NotaCredito.Columns(e.ColumnIndex).Name = "Factura") Then
    '        Dim frmVerFactura As frmVerFactura = New frmVerFactura()
    '        frmVerFactura.id_Factura = CType(DG_NotaCredito.CurrentRow.DataBoundItem, Entidades.NotaCredito).id_Factura
    '        frmVerFactura.ShowDialog()
    '    End If
    'End Sub
End Class