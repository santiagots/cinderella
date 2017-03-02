Imports Entidades
Imports Negocio

Public Class frmVerComprasCliente
    Public id_Cliente As Integer
    Dim NegClientes As New Negocio.NegClienteMayorista
    Dim NegVentas As New Negocio.NegVentas
    Dim eVentas As New Entidades.Ventas
    Dim eVentasDetalle As New Entidades.Ventas_Detalle

    'Al cerrar el formulario me fijo si está abierto el form de listados, si lo está, hago foco.
    Private Sub frmVerComprasCliente_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        If frmClienteMayorista.Visible Then
            'TODO:Actualizar funcion
            'frmClientes.EClientes.id_Cliente = 0
            frmClienteMayorista.WindowState = FormWindowState.Normal
        End If
    End Sub

    'Load del form.
    Private Sub frmVerComprasCliente_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            'Cambio el cursor a "WAIT"
            Me.Cursor = Cursors.WaitCursor

            'seteo las imagenes
            Dim ListaImagenes = New ImageList
            ListaImagenes.ImageSize = New Size(32, 32)
            ListaImagenes.TransparentColor = Color.Blue
            ListaImagenes.ColorDepth = ColorDepth.Depth32Bit

            ListaImagenes.Images.Add(My.Resources.Recursos.Ventas_32)
            ListaImagenes.Images.Add(My.Resources.Recursos.IconoDetalle)

            TabCompras.ImageList = ListaImagenes
            TabListado.ImageIndex = 0
            TabDetalle.ImageIndex = 1

            Dim NegListasPrecio As NegListasPrecio = New NegListasPrecio()
            Dim dsListas As DataSet = NegListasPrecio.ListadoListasPrecios()
            cmb_ListaPrecio.DataSource = dsListas.Tables(0)
            cmb_ListaPrecio.DisplayMember = "ListaPrecio"
            cmb_ListaPrecio.ValueMember = "id_Lista"

            Dim NegCondicionesIva As NegCondicionesIva = New NegCondicionesIva()
            Dim dsCondiciones As New DataSet
            dsCondiciones = NegCondicionesIva.ListadoCondiciones()
            cmb_CondicionIVA.DataSource = dsCondiciones.Tables(0)
            cmb_CondicionIVA.DisplayMember = "Descripcion"
            cmb_CondicionIVA.ValueMember = "id_CondicionIva"

            Dim cliente As ClienteMayorista = NegClientes.TraerCliente(id_Cliente)
            ClienteMayoristaBindingSource.DataSource = cliente

            'Me fijo si tiene compras realizadas.
            Dim dsCompras As New DataSet
            dsCompras = NegVentas.ListadoVentasCliente(id_Cliente)
            If dsCompras.Tables(0).Rows.Count > 0 Then
                DG_Compras.ColumnHeadersVisible = True
                DG_Compras.DataSource = dsCompras.Tables(0)
                DG_Compras.Refresh()
                lblMsg.Visible = False
            Else
                DG_Compras.ColumnHeadersVisible = False
                lblMsg.Visible = True
            End If

            'Cambio el cursor a NORMAL.
            Me.Cursor = Cursors.Arrow
        Catch ex As Exception
            Me.Cursor = Cursors.Arrow
            MessageBox.Show("Se ha encontrado un error al cargar el listado compras realizadas.", "Administración de Clientes", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    'Boton que cierra el form.
    Private Sub Btn_Cerrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_Cerrar.Click
        Me.Close()
    End Sub

    'Solapas.
    Private Sub TabCompras_Selected(ByVal sender As Object, ByVal e As System.Windows.Forms.TabControlEventArgs) Handles TabCompras.Selected
        'Cambio el cursor a "WAIT"
        Me.Cursor = Cursors.WaitCursor

        If TabCompras.SelectedIndex = 0 Then 'TAB LISTADO
            'Seteo el id_Venta en cero
            eVentas.id_Venta = 0
        ElseIf TabCompras.SelectedIndex = 1 Then 'TAB DETALLE DE VENTA
            If eVentas.id_Venta > 0 Or eVentas.id_Venta <> Nothing Then
            Else
                MessageBox.Show("Debe seleccionar previamente una compra para ver su respectivo detalle.", "Administración de Clientes", MessageBoxButtons.OK, MessageBoxIcon.Stop)
                TabCompras.SelectedIndex = 0
            End If
        End If

        'Cambio el cursor a NORMAL.
        Me.Cursor = Cursors.Arrow
    End Sub

    'Limpia el formulario.
    Sub LimpiarFormulario()
        DG_Productos.Rows.Clear()
        lblCantidad.Text = "- - - - -"
        lblMonto.Text = "- - - - -"
        lblFecha.Text = "- - - - -"
        lblSucursal.Text = "- - - - -"
        lblVendedor.Text = "- - - - -"
        lblVenta.Text = "- - - - -"
        lblPago.Text = "- - - - -"
        lblFacturado.Text = "- - - - -"
        lblAnulado.Text = "- - - - -"
        BtnFactura.Visible = False
    End Sub

    'CUando hace doble click en el grid.
    Private Sub DG_Compras_CellContentDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DG_Compras.CellContentDoubleClick
        Try
            'Cambio el cursor a "WAIT"
            Me.Cursor = Cursors.WaitCursor

            'Limpio el form
            LimpiarFormulario()

            Dim id_Venta As Integer = DG_Compras.Rows(e.RowIndex).Cells("id_Venta").Value()
            Dim dsVentasDetalle, dsVentas As New DataSet
            dsVentas = NegVentas.TraerVenta(id_Venta)
            eVentas.id_Venta = id_Venta

            'Cargo los labels de la venta.
            If dsVentas.Tables(0).Rows.Count > 0 Then
                lblCantidad.Text = dsVentas.Tables(0).Rows(0).Item("Cantidad_Total").ToString
                lblMonto.Text = "$ " & Format(CType(dsVentas.Tables(0).Rows(0).Item("Precio_Total").ToString, Decimal), "###0.00")
                lblFecha.Text = dsVentas.Tables(0).Rows(0).Item("Fecha").ToString
                lblSucursal.Text = dsVentas.Tables(0).Rows(0).Item("Sucursal").ToString
                lblVendedor.Text = dsVentas.Tables(0).Rows(0).Item("Empleado").ToString
                lblEncargado.Text = dsVentas.Tables(0).Rows(0).Item("Encargado").ToString
                lblSubtotal.Text = "$ " & Format(CType(dsVentas.Tables(0).Rows(0).Item("Subtotal").ToString, Decimal), "###0.00")
                lblDescuento.Text = "$ " & Format(CType(dsVentas.Tables(0).Rows(0).Item("Descuento").ToString, Decimal), "###0.00")
                lblVenta.Text = dsVentas.Tables(0).Rows(0).Item("TiposVenta").ToString
                lblPago.Text = dsVentas.Tables(0).Rows(0).Item("TiposPago").ToString

                Dim TipoFactura As Integer = Integer.Parse(dsVentas.Tables(0).Rows(0).Item("TipoFactura").ToString)

                If TipoFactura >= 0 Then
                    lblFacturado.Text = [Enum].GetName(GetType(Entidades.TipoFactura), TipoFactura)
                Else
                    lblFacturado.Text = "NO"
                End If

                If dsVentas.Tables(0).Rows(0).Item("Anulado").ToString = "1" Then
                    lblAnulado.Text = "SI"
                Else
                    lblAnulado.Text = "NO"
                End If

                'Detalle de la venta.
                dsVentasDetalle = NegVentas.TraerVentaDetalle(id_Venta)
                For Each ventaDetalle In dsVentasDetalle.Tables(0).Rows

                    'Creo la fila del producto.
                    Dim dgvRow As New DataGridViewRow
                    Dim dgvCell As DataGridViewCell

                    'Valor de la Columna Numero
                    dgvCell = New DataGridViewTextBoxCell()
                    dgvCell.Value = DG_Productos.Rows.Count + 1
                    dgvRow.Cells.Add(dgvCell)

                    'Valor de la Columna Codigo
                    dgvCell = New DataGridViewTextBoxCell()
                    dgvCell.Value = ventaDetalle.item("Codigo").ToString
                    dgvRow.Cells.Add(dgvCell)

                    'Valor de la Columna Nombre
                    dgvCell = New DataGridViewTextBoxCell()
                    dgvCell.Value = ventaDetalle.item("Nombre").ToString
                    dgvRow.Cells.Add(dgvCell)

                    'Valor de la Columna Cantidad
                    dgvCell = New DataGridViewTextBoxCell()
                    dgvCell.Value = ventaDetalle.item("Cantidad").ToString
                    dgvRow.Cells.Add(dgvCell)

                    'Valor de la Columna Precio
                    dgvCell = New DataGridViewTextBoxCell()
                    dgvCell.Value = "$ " & Format(CType(ventaDetalle.item("Precio").ToString, Decimal), "###0.00")
                    dgvRow.Cells.Add(dgvCell)

                    'Valor de la Columna Subtotal
                    dgvCell = New DataGridViewTextBoxCell()
                    dgvCell.Value = "$ " & Format(CType(ventaDetalle.item("Precio").ToString * ventaDetalle.item("Cantidad").ToString, Decimal), "###0.00")
                    dgvRow.Cells.Add(dgvCell)

                    dgvRow.Height = "20"

                    'Inserto la fila
                    DG_Productos.Rows.Add(dgvRow)
                Next

                TabCompras.SelectedIndex = 1
            Else
                Me.Cursor = Cursors.Arrow
                MessageBox.Show("No se ha encontrado la compra en el sistema.", "Administración de Clientes", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            End If

            'Cambio el cursor a "NORMAL"
            Me.Cursor = Cursors.Arrow

        Catch ex As Exception
            Me.Cursor = Cursors.Arrow
            MessageBox.Show("Se ha encontrado un error al cargar el detalle de la compra.", "Administración de Clientes", MessageBoxButtons.OK, MessageBoxIcon.Stop)
            TabCompras.SelectedIndex = 0
        End Try
    End Sub

    'Boton 2 que cierra el form.
    Private Sub Btn_Cerrar2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_Cerrar2.Click
        Me.Close()
    End Sub
End Class