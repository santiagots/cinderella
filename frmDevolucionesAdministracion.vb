Public Class frmDevolucionesAdministracion
    Dim NegDevolucion As New Negocio.NegDevolucion
    Dim NegStock As New Negocio.NegStock
    Dim NegComisiones As New Negocio.NegComisiones
    Dim id_Sucursal As String
    Dim eDevolucion As New Entidades.Devolucion
    Dim Funciones As New Funciones

    Private Sub frmDevolucionesAdministracion_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            'Cambio el cursor a "WAIT"
            Me.Cursor = Cursors.WaitCursor

            'seteo el font a 8px
            DG_Devolucion.AlternatingRowsDefaultCellStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            DG_Devolucion.DefaultCellStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            DG_Devolucion.RowHeadersDefaultCellStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            DG_Devolucion.ColumnHeadersDefaultCellStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))

            'seteo las imagenes
            Dim ListaImagenes = New ImageList
            ListaImagenes.ImageSize = New Size(32, 32)
            ListaImagenes.TransparentColor = Color.Blue
            ListaImagenes.ColorDepth = ColorDepth.Depth32Bit
            ListaImagenes.Images.Add(My.Resources.Recursos.Cambios_32)
            ListaImagenes.Images.Add(My.Resources.Recursos.Lapiz)
            TabVentas.ImageList = ListaImagenes

            'Sucursal default
            id_Sucursal = My.Settings("Sucursal")

            'icono de clientes
            TbListado.ImageIndex = 0
            'icono de detalle
            TbDetalle.ImageIndex = 1

            'Seteo fechas.
            FDesde.Value = Now.Date.AddDays(-30)
            FHasta.Value = Now.Date.AddDays(1)


            'Cargo el datagrid
            Dim dsVentas As New DataSet
            dsVentas = NegDevolucion.ListadoDevolucionesCompletoFecha(id_Sucursal, FDesde.Value.ToString("yyyy/MM/dd"), FHasta.Value.ToString("yyyy/MM/dd"))
            If dsVentas.Tables(0).Rows.Count > 0 Then
                DG_Devolucion.DataSource = dsVentas.Tables(0)
                DG_Devolucion.AutoGenerateColumns = False
                DG_Devolucion.ColumnHeadersVisible = True
                DG_Devolucion.Columns("id_Devolucion").Visible = False
                DG_Devolucion.Columns("Descuento").Visible = False
                DG_Devolucion.Columns("Empleado").DisplayIndex = 1
                DG_Devolucion.Columns("Cliente").DisplayIndex = 2
                DG_Devolucion.Columns("MontoTotal").DisplayIndex = 3
                DG_Devolucion.Columns("Fecha").DisplayIndex = 4
                DG_Devolucion.Columns("Anulado").DisplayIndex = 5
                DG_Devolucion.Columns("Facturado").DisplayIndex = 6
                DG_Devolucion.Columns("MontoTotal").DefaultCellStyle.Format = "C2"
                DG_Devolucion.Columns("Cliente").DefaultCellStyle.NullValue = "No Disponible"
                DG_Devolucion.Refresh()
                lbl_Msg.Visible = False
            Else
                DG_Devolucion.DataSource = Nothing
                DG_Devolucion.ColumnHeadersVisible = False
                DG_Devolucion.Refresh()
                lbl_Msg.Visible = True
            End If

            'Cambio el cursor a NORMAL.
            Me.Cursor = Cursors.Arrow
        Catch ex As Exception
            Me.Cursor = Cursors.Arrow
            MessageBox.Show("Se ha encontrado un error al listar las devoluciones de la sucursal.", "Administración de Devoluciones", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub BtnFiltrar_Click(sender As Object, e As EventArgs) Handles BtnFiltrar.Click
        'Cambio el cursor a "WAIT"
        Me.Cursor = Cursors.WaitCursor

        'Cargo el datagrid
        Dim dsVentas As New DataSet
        dsVentas = NegDevolucion.ListadoDevolucionesCompletoFecha(id_Sucursal, FDesde.Value.ToString("yyyy/MM/dd"), FHasta.Value.ToString("yyyy/MM/dd"))

        If dsVentas.Tables(0).Rows.Count > 0 Then
            DG_Devolucion.DataSource = dsVentas.Tables(0)
            DG_Devolucion.AutoGenerateColumns = False
            DG_Devolucion.ColumnHeadersVisible = True
            DG_Devolucion.Columns("id_Devolucion").Visible = False
            DG_Devolucion.Columns("Descuento").Visible = False
            DG_Devolucion.Columns("Empleado").DisplayIndex = 1
            DG_Devolucion.Columns("Cliente").DisplayIndex = 2
            DG_Devolucion.Columns("MontoTotal").DisplayIndex = 3
            DG_Devolucion.Columns("Fecha").DisplayIndex = 4
            DG_Devolucion.Columns("Anulado").DisplayIndex = 5
            DG_Devolucion.Columns("Facturado").DisplayIndex = 6
            DG_Devolucion.Columns("MontoTotal").DefaultCellStyle.Format = "C2"
            DG_Devolucion.Columns("Cliente").DefaultCellStyle.NullValue = "No Disponible"
            DG_Devolucion.Refresh()
            lbl_Msg.Visible = False
        Else
            DG_Devolucion.DataSource = Nothing
            DG_Devolucion.ColumnHeadersVisible = False
            DG_Devolucion.Refresh()
            lbl_Msg.Visible = True
        End If

        'Cambio el cursor a NORMAL.
        Me.Cursor = Cursors.Arrow
    End Sub

    Private Sub btn_Restablecer_Click(sender As Object, e As EventArgs) Handles btn_Restablecer.Click
        'Cambio el cursor a "WAIT"
        Me.Cursor = Cursors.WaitCursor

        'Seteo fechas.
        FDesde.Value = Now.Date.AddDays(-30)
        FHasta.Value = Now.Date

        'Cargo el datagrid
        Dim dsVentas As New DataSet
        dsVentas = NegDevolucion.ListadoDevolucionesCompletoFecha(id_Sucursal, FDesde.Value.ToString("yyyy/MM/dd"), FHasta.Value.ToString("yyyy/MM/dd"))

        If dsVentas.Tables(0).Rows.Count > 0 Then
            DG_Devolucion.DataSource = dsVentas.Tables(0)
            DG_Devolucion.AutoGenerateColumns = False
            DG_Devolucion.ColumnHeadersVisible = True
            DG_Devolucion.Columns("id_Devolucion").Visible = False
            DG_Devolucion.Columns("Descuento").Visible = False
            DG_Devolucion.Columns("Empleado").DisplayIndex = 1
            DG_Devolucion.Columns("Cliente").DisplayIndex = 2
            DG_Devolucion.Columns("MontoTotal").DisplayIndex = 3
            DG_Devolucion.Columns("Fecha").DisplayIndex = 4
            DG_Devolucion.Columns("Anulado").DisplayIndex = 5
            DG_Devolucion.Columns("Facturado").DisplayIndex = 6
            DG_Devolucion.Columns("MontoTotal").DefaultCellStyle.Format = "C2"
            DG_Devolucion.Columns("Cliente").DefaultCellStyle.NullValue = "No Disponible"
            DG_Devolucion.Refresh()
            lbl_Msg.Visible = False
        Else
            DG_Devolucion.DataSource = Nothing
            DG_Devolucion.ColumnHeadersVisible = False
            DG_Devolucion.Refresh()
            lbl_Msg.Visible = True
        End If

        'Cambio el cursor a NORMAL.
        Me.Cursor = Cursors.Arrow
    End Sub

    Private Sub DG_Ventas_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DG_Devolucion.CellDoubleClick
        Try
            'Cambio el cursor a "WAIT"
            Me.Cursor = Cursors.WaitCursor

            LimpiarFormulario()

            'Traigo la venta
            Dim id_Devolucion As Integer = DG_Devolucion.Rows(e.RowIndex).Cells("id_Devolucion").Value()
            Dim dsDevolucionDetalle, dsDevolucion As DataSet
            dsDevolucion = NegDevolucion.TraerDevolucion(id_Devolucion)
            eDevolucion.id_Devolucion = id_Devolucion
            eDevolucion.id_Sucursal = dsDevolucion.Tables(0).Rows(0).Item("id_Sucursal").ToString
            eDevolucion.id_Empleado = dsDevolucion.Tables(0).Rows(0).Item("id_Empleado").ToString

            'Cargo los labels de la venta.
            If dsDevolucion.Tables(0).Rows.Count <> 0 Then
                lblCantidad.Text = dsDevolucion.Tables(0).Rows(0).Item("Cantidad_Total").ToString
                lblMonto.Text = "$ " & Format(CType(dsDevolucion.Tables(0).Rows(0).Item("Precio_Total").ToString, Decimal), "###0.00")
                lblFecha.Text = dsDevolucion.Tables(0).Rows(0).Item("Fecha").ToString
                lblSucursal.Text = dsDevolucion.Tables(0).Rows(0).Item("Sucursal").ToString
                lblSubtotal.Text = "$ " & Format(CType(dsDevolucion.Tables(0).Rows(0).Item("Subtotal").ToString, Decimal), "###0.00")
                lblDescuento.Text = "$ " & Format(CType(dsDevolucion.Tables(0).Rows(0).Item("Descuento").ToString, Decimal), "###0.00")
                lblVenta.Text = dsDevolucion.Tables(0).Rows(0).Item("TiposDevolucion").ToString
                lblPago.Text = dsDevolucion.Tables(0).Rows(0).Item("TiposPago").ToString

                If dsDevolucion.Tables(0).Rows(0).Item("RazonSocial").ToString <> "" Then
                    lblCliente.Text = dsDevolucion.Tables(0).Rows(0).Item("RazonSocial").ToString
                Else
                    lblCliente.Text = "- - - - - "
                End If

                If dsDevolucion.Tables(0).Rows(0).Item("Empleado").ToString <> "" Then
                    lblVendedor.Text = dsDevolucion.Tables(0).Rows(0).Item("Empleado").ToString
                Else
                    lblVendedor.Text = "- - - - - "
                End If

                If dsDevolucion.Tables(0).Rows(0).Item("Encargado").ToString <> "" Then
                    lblEncargado.Text = dsDevolucion.Tables(0).Rows(0).Item("Encargado").ToString
                Else
                    lblEncargado.Text = "- - - - - "
                End If

                If dsDevolucion.Tables(0).Rows(0).Item("NotaCredito").ToString = "1" Then
                    lblFacturado.Text = "SI"
                    BtnNotaCredito.Visible = True
                    FrmVerNotaCredito.id_Devolucion = id_Devolucion
                Else
                    lblFacturado.Text = "NO"
                    BtnNotaCredito.Visible = False
                End If

                If dsDevolucion.Tables(0).Rows(0).Item("Anulado").ToString = "1" Then
                    lblAnulado.Text = "VENTA ANULADA EL " & String.Format("{0:d}", CDate(dsDevolucion.Tables(0).Rows(0).Item("FechaAnulado"))) & vbCrLf & Replace(Trim(dsDevolucion.Tables(0).Rows(0).Item("DescripcionAnulado").ToString), "<br />", vbCrLf)
                    lblAnulado.Visible = True
                    Gb_Anulado.Visible = False
                Else
                    lblAnulado.Visible = False
                    Gb_Anulado.Visible = True
                    txtDescripcionAnular.Clear()
                End If

                'Detalle de la venta.
                dsDevolucionDetalle = NegDevolucion.TraerDevolucionDetalle(id_Devolucion)
                For Each ventaDetalle In dsDevolucionDetalle.Tables(0).Rows

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
                    dgvCell.Value = Format(CType(ventaDetalle.item("Precio").ToString, Decimal), "###0.00")
                    dgvRow.Cells.Add(dgvCell)

                    'Valor de la Columna Subtotal
                    dgvCell = New DataGridViewTextBoxCell()
                    dgvCell.Value = ventaDetalle.item("Precio").ToString * ventaDetalle.item("Cantidad").ToString
                    dgvRow.Cells.Add(dgvCell)

                    dgvRow.Height = "20"

                    'Inserto la fila
                    DG_Productos.Rows.Add(dgvRow)
                Next
            End If

            'Cambio el cursor a NORMAL.
            Me.Cursor = Cursors.Arrow

            'hago foco en el tab_modificacion 
            TabVentas.SelectedIndex = 1
        Catch ex As Exception
            Me.Cursor = Cursors.Arrow
            MessageBox.Show("Se ha encontrado un error al obtener la devolución.", "Administración de Devoluciones", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub BtnAnular_Click(sender As Object, e As EventArgs) Handles BtnAnular.Click
        Dim Result As DialogResult
        Dim ResultadoAnulado As Integer
        Result = MessageBox.Show("¿Está seguro que desea anular la devolución?", "Administración de Devoluciones", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If Result = System.Windows.Forms.DialogResult.Yes Then 'Si acepta anular la venta
            'Cambio el cursor a "WAIT"
            TabVentas.Cursor = Cursors.WaitCursor

            Try
                'Actualizo el Producto.
                Dim TextoAnulado As String = Replace(Trim(txtDescripcionAnular.Text), vbCrLf, "<br />")
                ResultadoAnulado = NegDevolucion.AnularDevolucion(eDevolucion.id_Devolucion, TextoAnulado)

                If ResultadoAnulado = 1 Then 'Se anulo la venta en productos correctamente.

                    'Actualizo el Stock.
                    Dim dsVentasDetalle As DataSet
                    dsVentasDetalle = NegDevolucion.TraerDevolucionDetalle(eDevolucion.id_Devolucion)
                    For Each ventaDetalle In dsVentasDetalle.Tables(0).Rows
                        NegStock.AgregarStock(ventaDetalle.item("id_Producto").ToString(), eDevolucion.id_Sucursal, -Integer.Parse(ventaDetalle.item("Cantidad").ToString()))
                    Next

                    'Limpio Formulario
                    txtDescripcionAnular.Clear()
                    Gb_Anulado.Visible = False
                    lblAnulado.Visible = True
                    lblAnulado.Text = "DEVOLUCIÓN ANULADA EL " & String.Format("{0:d}", DateTime.Now)

                    'Muestro el resultado
                    MessageBox.Show("Se ha anulado la devolución correctamente.", "Administración de Devoluciones", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Else

                    'Muestro el resultado
                    MessageBox.Show("No ha podido ser anulada la devolución. Por favor, intente más tarde o contactese con el administrador.", "Administración de Devoluciones", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                End If

            Catch ex As Exception
                'Muestro el resultado
                MessageBox.Show("Se ha encontrado un error al anular la devolución. Por favor, contactese con el administrador.", "Administración de Devoluciones", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try

            'Cambio el cursor a NORMAL.
            TabVentas.Cursor = Cursors.Arrow
        End If
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
        lblCliente.Text = "- - - - -"
        lblAnulado.Visible = False
        BtnNotaCredito.Visible = False
        Gb_Anulado.Visible = False
    End Sub

    Private Sub BtnNotaCredito_Click(sender As Object, e As EventArgs) Handles BtnNotaCredito.Click
        Me.Cursor = Cursors.WaitCursor
        Funciones.ControlInstancia(FrmVerNotaCredito).MdiParent = MDIContenedor
        Funciones.ControlInstancia(FrmVerNotaCredito).Show()
        Me.Cursor = Cursors.Arrow
    End Sub
End Class