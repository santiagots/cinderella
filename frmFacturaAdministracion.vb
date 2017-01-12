Public Class frmFacturaAdministracion

    Dim NegFacturacion As New Negocio.NegFacturacion

    Private Sub frmFacturaAdministracion_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        FDesde.Value = Now.Date.AddDays(-30)
        FHasta.Value = Now.Date.AddDays(1)

        FacturacionBindingSource.DataSource = NegFacturacion.ObtenerListado(My.Settings.Sucursal, FDesde.Value.ToString("yyyy/MM/dd"), FHasta.Value.ToString("yyyy/MM/dd"))

    End Sub

    Private Sub DataGridView1_DataBindingComplete(sender As Object, e As DataGridViewBindingCompleteEventArgs) Handles DG_facturas.DataBindingComplete
        lbl_Msg.Visible = DG_facturas.Rows.Count = 0
    End Sub

    Private Sub BtnFiltrar_Click(sender As Object, e As EventArgs) Handles BtnFiltrar.Click
        'Cambio el cursor a "WAIT"
        Me.Cursor = Cursors.WaitCursor

        'Cargo el datagrid
        Dim facturas As New List(Of Entidades.Facturacion)
        facturas = NegFacturacion.ObtenerListado(My.Settings.Sucursal, FDesde.Value.ToString("yyyy/MM/dd"), FHasta.Value.ToString("yyyy/MM/dd"))

        Dim facturasTicket As New List(Of Entidades.Facturacion)
        If ChkMarcaTicket.Checked Then
            facturasTicket = facturas.Where(Function(x) x.TipoRecibo = Entidades.TipoFactura.Ticket).ToList()
        End If

        Dim facturasElectronica As New List(Of Entidades.Facturacion)
        If ChkMarcaElectronica.Checked Then
            facturasElectronica = facturas.Where(Function(x) x.TipoRecibo = Entidades.TipoFactura.Electronica).ToList()
        End If

        Dim facturasManual As New List(Of Entidades.Facturacion)
        If ChkMarcaManual.Checked Then
            facturasManual = facturas.Where(Function(x) x.TipoRecibo = Entidades.TipoFactura.Manual).ToList()
        End If

        If ChkMarcaTicket.Checked Or ChkMarcaElectronica.Checked Or ChkMarcaManual.Checked Then
            facturas.Clear()
            facturas.AddRange(facturasTicket)
            facturas.AddRange(facturasElectronica)
            facturas.AddRange(facturasManual)
        End If

        If Not String.IsNullOrEmpty(txtFacturaNro.Text) Then
            facturas = facturas.Where(Function(x) x.NumeroFactura = txtFacturaNro.Text).ToList()
        End If

        If Not String.IsNullOrEmpty(txtMontoDesde.Text) Then
            facturas = facturas.Where(Function(x) x.Monto >= CType(txtMontoDesde.Text, Double)).ToList()
        End If

        If Not String.IsNullOrEmpty(txtMontoHasta.Text) Then
            facturas = facturas.Where(Function(x) x.Monto <= CType(txtMontoHasta.Text, Double)).ToList()
        End If

        If Not String.IsNullOrEmpty(txtNombre.Text) Then
            facturas = facturas.Where(Function(x) x.Nombre.Contains(txtNombre.Text)).ToList()
        End If

        If Not String.IsNullOrEmpty(txtCUIT.Text) Then
            facturas = facturas.Where(Function(x) x.Cuit.Contains(txtCUIT.Text)).ToList()
        End If

        FacturacionBindingSource.DataSource = facturas

        'Cambio el cursor a NORMAL.
        Me.Cursor = Cursors.Arrow
    End Sub

    Private Sub DG_facturas_CellFormatting(sender As Object, e As DataGridViewCellFormattingEventArgs) Handles DG_facturas.CellFormatting
        'Elimino el boton de detalla nota credito en caso de que la factura no tenga nota credito asociada
        If (DG_facturas.Columns(e.ColumnIndex).Name = "NotaCredito" And FacturacionBindingSource.List.Count > e.RowIndex) Then
            Dim factura As Entidades.Facturacion = FacturacionBindingSource.List(e.RowIndex)
            If (factura.id_NotaCredito = 0) Then
                e.CellStyle.Padding = New Padding(1000, 1000, 0, 0)
            End If
        End If
    End Sub

    Private Sub DG_facturas_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DG_facturas.CellContentClick
        If (DG_facturas.Columns(e.ColumnIndex).Name = "NotaCredito") Then
            Dim frmVerNotaCredito As FrmVerNotaCredito = New FrmVerNotaCredito()
            frmVerNotaCredito.id_NotaCreadito = CType(DG_facturas.CurrentRow.DataBoundItem, Entidades.Facturacion).id_NotaCredito
            frmVerNotaCredito.ShowDialog()
        End If
    End Sub

    Private Sub btn_Restablecer_Click(sender As Object, e As EventArgs) Handles btn_Restablecer.Click
        FDesde.Value = Now.Date.AddDays(-30)
        FHasta.Value = Now.Date.AddDays(1)
        ChkMarcaElectronica.Checked = True
        ChkMarcaManual.Checked = True
        ChkMarcaTicket.Checked = True
        txtCUIT.Clear()
        txtFacturaNro.Clear()
        txtMontoDesde.Clear()
        txtMontoHasta.Clear()
        txtNombre.Clear()

        FacturacionBindingSource.DataSource = NegFacturacion.ObtenerListado(My.Settings.Sucursal, FDesde.Value.ToString("yyyy/MM/dd"), FHasta.Value.ToString("yyyy/MM/dd"))
    End Sub
End Class