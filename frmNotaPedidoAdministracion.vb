Imports Negocio
Imports Entidades
Imports System.Linq

Public Class frmNotaPedidoAdministracion

    Dim Funciones As New Funciones()
    Dim negNotaPedido As NegNotaPedido = New NegNotaPedido()
    Dim negEmpleados As NegEmpleados = New NegEmpleados()
    Dim negTiposPagos As NegTipoPago = New NegTipoPago()

    Private Sub NotaPedidoAdministracion_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try

            'seteo el font a 8px
            dgvNotaPedidos.AlternatingRowsDefaultCellStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            dgvNotaPedidos.DefaultCellStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            dgvNotaPedidos.RowHeadersDefaultCellStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            dgvNotaPedidos.ColumnHeadersDefaultCellStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))

            'Cargo los combos de banco
            NotaPedidoBindingSource.DataSource = negNotaPedido.TraerNotas(My.Settings.Sucursal)

            cmbTipoVenta.SelectedIndex = 0

            'Cargo el Combo de vendedores
            Dim DsVendedores As New DataSet
            DsVendedores = negEmpleados.ListadoVendedoresSucursal(My.Settings.Sucursal)
            If DsVendedores.Tables(0).Rows.Count > 0 Then
                cmbVendedor.DataSource = Nothing
                cmbVendedor.DataSource = Funciones.CrearDataTable("id_Empleado", "NombreCompleto", DsVendedores, "Seleccione un vendedor...")
                cmbVendedor.DisplayMember = "NombreCompleto"
                cmbVendedor.ValueMember = "id_Empleado"
                cmbVendedor.SelectedValue = 0
                cmbVendedor.Refresh()
            Else
                cmbTipoVenta.Items.Add("No hay vendedores disponibles.")
                cmbTipoVenta.SelectedItem = "No hay vendedores disponibles."
            End If

            'Cargo el Combo de Tipos de Pago
            Dim DsTiposPagos As New DataSet
            DsTiposPagos = negTiposPagos.ListadoTiposPagos()

            If DsTiposPagos.Tables(0).Rows.Count > 0 Then
                cmbTiposPago.DataSource = Nothing
                cmbTiposPago.DataSource = Funciones.CrearDataTable("id_TipoPago", "Descripcion", DsTiposPagos, "Seleccione un tipo de pago...")
                cmbTiposPago.DisplayMember = "Descripcion"
                cmbTiposPago.ValueMember = "id_TipoPago"
                cmbTiposPago.SelectedValue = 0
                cmbTiposPago.Refresh()
            End If

        Catch ex As Exception

            MessageBox.Show("Se ha encontrado un error al recuperar las notas de pedido. Por favor, vuelva a intentar más tarde o contáctese con el Administrador ", "Administración de Notas de Pedido", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub dgvNotaPedidos_CellFormatting(sender As Object, e As DataGridViewCellFormattingEventArgs) Handles dgvNotaPedidos.CellFormatting

        If (dgvNotaPedidos.Columns(e.ColumnIndex).Name = "NombreCliente" And NotaPedidoBindingSource.List.Count > e.RowIndex) Then
            Dim notaPedido As NotaPedido = NotaPedidoBindingSource.List(e.RowIndex)
            If (Not String.IsNullOrEmpty(notaPedido.RazonSocialCliente)) Then
                e.Value = notaPedido.RazonSocialCliente
            Else
                e.Value = notaPedido.ConsumidorFinalNombreYApellido

            End If
        End If
    End Sub

    Private Sub BtnFiltrar_Click(sender As Object, e As EventArgs) Handles BtnFiltrar.Click
        'Cambio el cursor a "WAIT"
        Me.Cursor = Cursors.WaitCursor

        Try
            'recupero las notas de pedido de la base para la sucursal correspondinte
            Dim notaPedido As List(Of NotaPedido) = negNotaPedido.TraerNotas(My.Settings.Sucursal)

            'filtro por cliente mayorista
            Dim filtroCLienteMayorista As List(Of NotaPedido) = New List(Of NotaPedido)
            If (Not String.IsNullOrEmpty(txtNombreCliente.Text)) Then
                filtroCLienteMayorista = notaPedido.Where(Function(x) x.RazonSocialCliente.ToUpper.Contains(txtNombreCliente.Text.ToUpper)).ToList()
            End If

            'filtro por cliente consumidor final
            Dim filtroCLienteConsumidorFinal As List(Of NotaPedido) = New List(Of NotaPedido)
            If (Not String.IsNullOrEmpty(txtNombreCliente.Text)) Then
                filtroCLienteConsumidorFinal = notaPedido.Where(Function(x) x.ConsumidorFinalNombreYApellido.ToUpper.Contains(txtNombreCliente.Text.ToUpper)).ToList()

            End If

            If (filtroCLienteMayorista.Count > 0 Or filtroCLienteConsumidorFinal.Count > 0) Then
                notaPedido.Clear()
            End If

            notaPedido.AddRange(filtroCLienteMayorista)
            notaPedido.AddRange(filtroCLienteConsumidorFinal)

            'filtro por tipo de venta
            If (cmbTipoVenta.SelectedItem.ToString <> "Seleccione un tipo de venta...") Then
                notaPedido = notaPedido.Where(Function(x) x.TipoVentaDescripcion = cmbTipoVenta.SelectedItem.ToString).ToList()
            End If

            'filtro por tipo de pago
            If (cmbTiposPago.SelectedValue <> 0) Then
                notaPedido = notaPedido.Where(Function(x) x.id_TipoPago = cmbTiposPago.SelectedValue).ToList()
            End If

            'filtro por vendedor
            If (cmbVendedor.SelectedValue <> 0) Then
                notaPedido = notaPedido.Where(Function(x) x.id_Empleado = cmbVendedor.SelectedValue).ToList()
            End If

            NotaPedidoBindingSource.DataSource = notaPedido

        Catch ex As Exception
            'Cambio el cursor a NORMAL.
            Me.Cursor = Cursors.Arrow
            MessageBox.Show("Se ha encontrado un error al filtrar las notas de pedido. Por favor, vuelva a intentar más tarde o contáctese con el Administrador ", "Administración de Notas de Pedido", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

        'Cambio el cursor a NORMAL.
        Me.Cursor = Cursors.Arrow
    End Sub

    Private Sub btn_Restablecer_Click(sender As Object, e As EventArgs) Handles btn_Restablecer.Click

        'Cargo los combos de banco
        NotaPedidoBindingSource.DataSource = negNotaPedido.TraerNotas(My.Settings.Sucursal)

        cmbTiposPago.SelectedIndex = 0
        cmbTipoVenta.SelectedIndex = 0
        cmbVendedor.SelectedIndex = 0
        txtNombreCliente.Clear()

    End Sub

    Private Sub dgvNotaPedidos_DoubleClick(sender As Object, e As EventArgs) Handles dgvNotaPedidos.DoubleClick
        'Cambio el cursor a "WAIT".
        Me.Cursor = Cursors.WaitCursor

        'instacion un formulario de venta
        Dim frmVentas As frmVentas = New frmVentas()

        'le paso la nota de pedido seleccionada
        frmVentas.NotaPedido = NotaPedidoBindingSource.Current
        frmVentas.MdiParent = Me.MdiParent

        'muestro el formulario de venta
        frmVentas.Show()

        'Cambio el cursor a NORMAL.
        Me.Cursor = Cursors.Arrow

    End Sub

    'Cuando realiza un click dentro del datagrid de productos.
    Private Sub dgvNotaPedidos_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvNotaPedidos.CellContentClick
        If dgvNotaPedidos.Columns(e.ColumnIndex).Name.ToUpper() = "ELIMINAR" Then 'Si se hace click en el boton "eliminar" de la fila.
            Dim Result As DialogResult
            Result = MessageBox.Show("¿Está seguro que desea eliminar el item seleccionado?", "Administración de Notas de Pedido", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

            If Result = System.Windows.Forms.DialogResult.Yes Then 'Si acepta eliminar el item
                Dim notaPedido As NotaPedido = NotaPedidoBindingSource.List(e.RowIndex)
                If notaPedido Is Nothing Then
                    'si no completo la descripcion, muestro un msg de error.
                    MessageBox.Show("No se puede eliminar el item.", "Administración de Notas de Pedido", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Else
                    If (Not negNotaPedido.BorrarNota(notaPedido.id_NotaPedido)) Then
                        MessageBox.Show("La note de pedido no se a podido eliminar. Por favor, vuelva a intentar más tarde o contáctese con el Administrador ", "Administración de Notas de Pedido", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Else
                        NotaPedidoBindingSource.RemoveAt(e.RowIndex) 'Elimino el item de la grilla
                    End If

                    'refresco el datagrid
                    dgvNotaPedidos.Refresh()
                End If
            End If
        End If
    End Sub

    Public Sub RemoverNotaPedido(ByVal notaPedido As NotaPedido)
        If (NotaPedidoBindingSource.List.Count > 1) Then
            NotaPedidoBindingSource.List.Remove(notaPedido)
        Else
            NotaPedidoBindingSource.DataSource = Nothing
        End If
    End Sub
End Class