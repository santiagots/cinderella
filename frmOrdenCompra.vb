Imports System.IO
Imports System.Text
Imports Entidades
Imports Negocio


Public Class frmOrdenCompra
    Dim NegProveedor As NegProveedores = New NegProveedores()
    Dim NegStock As NegStock = New NegStock()
    Dim NegOrdenCompra As NegOrdenCompra = New NegOrdenCompra()
    Dim NegEmpleados As NegEmpleados = New NegEmpleados()
    Dim NegProductos As NegProductos = New NegProductos()
    Dim NegSucursales As NegSucursales = New NegSucursales()
    Dim NegEmail As NegEmail = New NegEmail()
    Dim NegMercaderia As NegMercaderia = New NegMercaderia()
    Dim NegCuentaCorriente As NegCuentaCorriente = New NegCuentaCorriente()
    Dim dsProductos As DataSet

    Dim stockNotaPedidoExistentes As List(Of OrdenCompra)
    Dim Funciones As Funciones = New Funciones()
    Private Sub frmStockPedido_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        InicializarAlta()

        ObtenerNotasPedidosAbiertasEnviadas()

        Dim ordenCompraTipoLista As List(Of String) = [Enum].GetNames(GetType(OrdenCompraPedidoTipo)).ToList()
        ordenCompraTipoLista.Insert(0, "Todos")
        cbTipoBusqueda.DataSource = ordenCompraTipoLista

        Dim ordenCompraEstadoLista As List(Of String) = [Enum].GetNames(GetType(OrdenCompraPedidoEstado)).ToList()
        ordenCompraEstadoLista.Insert(0, "Todos")
        cbEstadoBusqueda.DataSource = ordenCompraEstadoLista
        cbEstadoBusqueda.SelectedItem = OrdenCompraPedidoEstado.Nuevo.ToString

        lblSucursalBusqueda.Text = My.Settings.NombreSucursal
        dpDesdeBusqueda.Value = DateTime.Now.AddMonths(-1)
        dpHastaBusqueda.Value = DateTime.Now()

        Dim dsProveedor As DataSet = NegProveedor.ListadoProveedoresConStock(My.Settings.Sucursal)
        If (dsProveedor.Tables(0).Rows.Count > 0) Then
            cbProveedorBuscar.DataSource = Funciones.CrearDataTable("id_Proveedor", "RazonSocial", dsProveedor, "Todos")
            cbProveedorBuscar.DisplayMember = "RazonSocial"
            cbProveedorBuscar.ValueMember = "id_Proveedor"

            cbProveedorAlta.DataSource = Funciones.CrearDataTable("id_Proveedor", "RazonSocial", dsProveedor, "Seleccione un proveedor")
            cbProveedorAlta.DisplayMember = "RazonSocial"
            cbProveedorAlta.ValueMember = "id_Proveedor"
        End If

        Dim DsEncargados = NegEmpleados.ListadoEncargadosSucursal(My.Settings.Sucursal)
        If DsEncargados.Tables(0).Rows.Count > 0 Then
            cbEncargadoBusqueda.DataSource = Funciones.CrearDataTable("id_Empleado", "NombreCompleto", DsEncargados, "Todos")
            cbEncargadoBusqueda.DisplayMember = "NombreCompleto"
            cbEncargadoBusqueda.ValueMember = "id_Empleado"

            cbEncargadoAlta.DataSource = Funciones.CrearDataTable("id_Empleado", "NombreCompleto", DsEncargados, "Seleccione un encargado")
            cbEncargadoAlta.DisplayMember = "NombreCompleto"
            cbEncargadoAlta.ValueMember = "id_Empleado"
        End If

        dsProductos = NegProductos.ListadoProductos(True)

        txtProductoAlta.AutoCompleteCustomSource = CargraListaProductos(cbProveedorAlta.SelectedValue)

        BuscarOrdenesCompra()
    End Sub

    Private Sub ObtenerNotasPedidosAbiertasEnviadas()
        'Obtengo las notas de pedidos abiertas o enviadas
        stockNotaPedidoExistentes = NegOrdenCompra.Obtener(My.Settings.Sucursal, OrdenCompraPedidoEstado.Nuevo)
        stockNotaPedidoExistentes.AddRange(NegOrdenCompra.Obtener(My.Settings.Sucursal, OrdenCompraPedidoEstado.Enviado))
    End Sub

    Private Sub EditingControlShowing(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewEditingControlShowingEventArgs) Handles dgMercaderiaAlta.EditingControlShowing, dgMercaderiaDetalle.EditingControlShowing
        'Referenciamos el control TextBox subyacente en la celda actual.
        Dim cellTextBox As DataGridViewTextBoxEditingControl
        cellTextBox = TryCast(e.Control, DataGridViewTextBoxEditingControl)

        ' Obtenemos el estilo de la celda actual
        Dim style As DataGridViewCellStyle = e.CellStyle
        ' Mientras se edita la celda, aumentaremos la fuente
        ' y rellenaremos el color de fondo de la celda actual.
        With style
            .Font = New Font(style.Font.FontFamily, 10, FontStyle.Bold)
            .BackColor = Color.Red
            .ForeColor = Color.White
        End With
    End Sub

    Private Sub CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgMercaderiaAlta.CellClick, dgMercaderiaDetalle.CellClick
        Dim dataGridView As DataGridView = sender
        dataGridView.EditMode = DataGridViewEditMode.EditProgrammatically
        dataGridView.CurrentCell = dataGridView.CurrentCell
        dataGridView.BeginEdit(True)
    End Sub

    Private Sub CellValidating(sender As Object, e As DataGridViewCellValidatingEventArgs) Handles dgMercaderiaAlta.CellValidating, dgMercaderiaDetalle.CellValidating
        Dim dataGridView As DataGridView = sender
        If (dataGridView.Columns(e.ColumnIndex).HeaderText = "Cantidad") Then
            Dim cantidad As Integer = 0
            Integer.TryParse(e.FormattedValue.ToString(), cantidad)
            If cantidad <= 0 Then
                dataGridView.Rows(e.RowIndex).ErrorText = "Cantidad debe ser un numero entero mayor a cero."
                e.Cancel = True
            Else
                dataGridView.Rows(e.RowIndex).ErrorText = String.Empty
            End If
        End If
    End Sub

    Private Sub dgMercaderiaDetalle_CellEndEdit(sender As Object, e As DataGridViewCellEventArgs) Handles dgMercaderiaDetalle.CellEndEdit
        ActualizarTotales(ModificacionOrdenCompraBindingSource.DataSource, lblMontoTotalDetalle, lblTotalesDetalle)
    End Sub

    Private Sub dgMercaderiaAlta_CellEndEdit(sender As Object, e As DataGridViewCellEventArgs) Handles dgMercaderiaAlta.CellEndEdit, dgMercaderiaDetalle.CellEndEdit
        ActualizarTotales(AltaOrdenCompraBindingSource.DataSource, lblMontoTotalAlta, lblTotalesAlta)
    End Sub

    Private Sub cbProveedor_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbProveedorAlta.SelectedIndexChanged
        txtProductoAlta.AutoCompleteCustomSource = CargraListaProductos(cbProveedorAlta.SelectedValue)
        AltaDetallesBindingSource.Clear()
        lblMontoTotalAlta.Text = "0"
        lblTotalesAlta.Text = "0"
    End Sub

    Private Sub ActualizarTotales(OrdenCompra As OrdenCompra, monto As Label, cantidad As Label)
        For Each detalle As OrdenCompraDetalle In OrdenCompra.Detalles
            detalle.Importe = detalle.Costo * detalle.Cantidad
        Next

        monto.Text = OrdenCompra.Detalles.Sum(Function(x) x.Importe)
        cantidad.Text = OrdenCompra.Detalles.Sum(Function(x) x.Cantidad)
    End Sub

    Private Function CargraListaProductos(idProveedor As Integer) As AutoCompleteStringCollection
        'Obtengo el listado de productos guardados en cache
        Dim dsProductosProveedor As DataSet = NegProductos.ListadoBuscadoresPorSucursalYProveedor(idProveedor, My.Settings.Sucursal)

        'Armo una lista que contiene los nombres y codigos de todos los producto
        Dim listaNombreCodigoProductos As AutoCompleteStringCollection = New AutoCompleteStringCollection()

        listaNombreCodigoProductos.AddRange(dsProductosProveedor.Tables(0).Rows.Cast(Of DataRow).Select(Function(x) x.Item("Nombre").ToString).ToArray())
        listaNombreCodigoProductos.AddRange(dsProductosProveedor.Tables(0).Rows.Cast(Of DataRow).Select(Function(x) x.Item("Codigo").ToString).ToArray())

        Return listaNombreCodigoProductos
    End Function

    Private Function BuscarProducto(NombreCodigoProducto As String) As OrdenCompraDetalle
        Dim dr As DataRow = dsProductos.Tables(0).Rows.Cast(Of DataRow).Where(Function(x) x.Item("Nombre").ToString().ToUpper() = NombreCodigoProducto.ToUpper() Or x.Item("Codigo").ToString().ToUpper() = NombreCodigoProducto.ToUpper()).FirstOrDefault()
        If (dr IsNot Nothing) Then
            Dim producto As Productos = NegProductos.TraerProducto(dr(3))

            Return New OrdenCompraDetalle() With {
                .Cantidad = 1,
                .Codigo = producto.Codigo,
                .Costo = producto.Costo,
                .idProducto = producto.id_Producto,
                .Importe = .Cantidad * .Costo,
                .Nombre = producto.Nombre}
        Else
            Return Nothing
        End If
    End Function

    Private Sub BtnAgregarModificacion_Click(sender As Object, e As EventArgs) Handles BtnAgregarModificacion.Click
        Try
            Me.Cursor = Cursors.WaitCursor
            AgregarProductoModificacion()
            Me.Cursor = Cursors.Arrow
        Catch ex As Exception
            Me.Cursor = Cursors.Arrow
            MessageBox.Show("Se ha producido un error al agregar el producto. Por favor, Comuníquese con el administrador.", "Administración de Ordenes de Compra", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub AgregarProductoModificacion()
        AgregarProductoAGrilla(ModificacionOrdenCompraBindingSource, ModificacionDetallesBindingSource, txtProductoModificacion.Text)
        ActualizarTotales(ModificacionOrdenCompraBindingSource.DataSource, lblMontoTotalDetalle, lblTotalesDetalle)
        txtProductoModificacion.Clear()
    End Sub

    Private Sub BtnAgregarAlta_Click(sender As Object, e As EventArgs) Handles BtnAgregarAlta.Click
        Try
            Me.Cursor = Cursors.WaitCursor
            AgregarProductoAlta()
            Me.Cursor = Cursors.Arrow
        Catch ex As Exception
            Me.Cursor = Cursors.Arrow
            MessageBox.Show("Se ha producido un error al agregar el producto. Por favor, Comuníquese con el administrador.", "Administración de Ordenes de Compra", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub AgregarProductoAlta()
        AgregarProductoAGrilla(AltaOrdenCompraBindingSource, AltaDetallesBindingSource, txtProductoAlta.Text)
        ActualizarTotales(AltaOrdenCompraBindingSource.DataSource, lblMontoTotalAlta, lblTotalesAlta)
        txtProductoAlta.Clear()
    End Sub

    Private Sub AgregarProductoAGrilla(bindingSource As BindingSource, detalleBindingSource As BindingSource, producto As String)
        Dim ordenesCompraDetalle As OrdenCompraDetalle = BuscarProducto(producto)

        If ordenesCompraDetalle IsNot Nothing Then
            Dim ordenesCompra As OrdenCompra = bindingSource.DataSource

            Dim frmStockIngreso As frmStockIngreso

            Dim ordenesCompraDetalleGrilla As OrdenCompraDetalle = ordenesCompra.Detalles.FirstOrDefault(Function(x) x.Codigo = ordenesCompraDetalle.Codigo)
            If (ordenesCompraDetalleGrilla IsNot Nothing) Then
                frmStockIngreso = New frmStockIngreso(ordenesCompraDetalleGrilla.idProducto, ordenesCompraDetalleGrilla.Codigo, My.Settings.Sucursal, ordenesCompraDetalleGrilla.Cantidad, False)
                If (frmStockIngreso.ShowDialog() = Windows.Forms.DialogResult.OK) Then
                    ordenesCompraDetalleGrilla.Cantidad = frmStockIngreso.stockCargado
                End If
            Else
                frmStockIngreso = New frmStockIngreso(ordenesCompraDetalle.idProducto, ordenesCompraDetalle.Codigo, My.Settings.Sucursal, 0, False)
                If (frmStockIngreso.ShowDialog() = Windows.Forms.DialogResult.OK) Then
                    ordenesCompraDetalle.Cantidad = frmStockIngreso.stockCargado
                    detalleBindingSource.Add(ordenesCompraDetalle)
                End If
            End If

            bindingSource.ResetBindings(False)
        Else
            MessageBox.Show("No se a podido encontrar el producto ingresado.", "Administración de Ordenes de Compra", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub btnAceptarAlta_Click(sender As Object, e As EventArgs) Handles btnGuardarAlta.Click

        If (cbEncargadoAlta.SelectedValue = 0 OrElse cbProveedorAlta.SelectedValue = 0 OrElse dgMercaderiaAlta.RowCount = 0) Then
            MessageBox.Show("Debe completar los campos requeridos y cargar al menos un producto.", "Administración de Ordenes de Compra", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Return
        End If

        Dim OrdenCompra As OrdenCompra = AltaOrdenCompraBindingSource.DataSource
        If (OrdenCompra.Detalles.Any(Function(x) Not x.Verificado)) Then
            MessageBox.Show("Existen productos con advertencias, Por favor verifique las advertencias.", "Administración de Ordenes de Compra", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Return
        End If

        Try
            Me.Cursor = Cursors.WaitCursor
            NegOrdenCompra.Guardar(AltaOrdenCompraBindingSource.DataSource)
            ObtenerNotasPedidosAbiertasEnviadas()
            Me.Cursor = Cursors.Arrow
            InicializarAlta()
            MessageBox.Show("Se ha dado de alta la orden de compra.", "Administración de Ordenes de Compra", MessageBoxButtons.OK, MessageBoxIcon.Information)
            tabOrdenCompra.SelectedTab = TabBusqueda
        Catch ex As Exception
            Me.Cursor = Cursors.Arrow
            MessageBox.Show("Se ha producido un error al guardar la orden de compra. Por favor, Comuníquese con el administrador.", "Administración de Ordenes de Compra", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub InicializarAlta()
        Dim ordenCompraAlta As OrdenCompra = New OrdenCompra() With {
            .NombreSucursal = My.Settings.NombreSucursal,
            .idSucursal = My.Settings.Sucursal,
            .Fecha = DateTime.Now,
            .Estado = OrdenCompraPedidoEstado.Nuevo,
            .Tipo = OrdenCompraPedidoTipo.Manual,
            .Detalles = New List(Of OrdenCompraDetalle)()
            }
        AltaOrdenCompraBindingSource.DataSource = ordenCompraAlta
    End Sub

    Private Sub InicializarDetalle()
        Dim ordenCompraAlta As OrdenCompra = New OrdenCompra() With {
            .NombreSucursal = My.Settings.NombreSucursal,
            .idSucursal = My.Settings.Sucursal,
            .Fecha = DateTime.Now,
            .Estado = OrdenCompraPedidoEstado.Nuevo,
            .Tipo = OrdenCompraPedidoTipo.Manual,
            .Detalles = New List(Of OrdenCompraDetalle)()
            }
        ModificacionOrdenCompraBindingSource.DataSource = ordenCompraAlta
    End Sub

    Private Sub BtnFiltrar_Click(sender As Object, e As EventArgs) Handles BtnFiltrar.Click
        BuscarOrdenesCompra()
    End Sub

    Private Sub BuscarOrdenesCompra()
        Try
            Me.Cursor = Cursors.WaitCursor
            Dim ordenCompra As List(Of OrdenCompra) = NegOrdenCompra.Obtener(My.Settings.Sucursal, dpDesdeBusqueda.Value, dpHastaBusqueda.Value)

            If cbProveedorBuscar.SelectedValue > 0 Then
                ordenCompra = ordenCompra.Where(Function(x) x.idProveedor = cbProveedorBuscar.SelectedValue).ToList()
            End If

            If cbEncargadoBusqueda.SelectedValue > 0 Then
                ordenCompra = ordenCompra.Where(Function(x) x.idEncargado = cbEncargadoBusqueda.SelectedValue).ToList()
            End If

            If cbTipoBusqueda.SelectedValue <> "Todos" Then
                ordenCompra = ordenCompra.Where(Function(x) x.Tipo = [Enum].Parse(GetType(OrdenCompraPedidoTipo), cbTipoBusqueda.SelectedValue)).ToList()
            End If

            If cbEstadoBusqueda.SelectedValue <> "Todos" Then
                ordenCompra = ordenCompra.Where(Function(x) x.Estado = [Enum].Parse(GetType(OrdenCompraPedidoEstado), cbEstadoBusqueda.SelectedValue)).ToList()
            End If

            BuscarOrdenCompraBindingSource.DataSource = ordenCompra
            Me.Cursor = Cursors.Arrow
        Catch ex As Exception
            Me.Cursor = Cursors.Arrow
            MessageBox.Show("Se ha producido un error al buscar las ordenes de compras. Por favor, Comuníquese con el administrador.", "Administración de Ordenes de Compra", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub txtProductoAlta_KeyDown(sender As Object, e As KeyEventArgs) Handles txtProductoAlta.KeyDown
        If e.KeyData = Keys.Enter Then
            Try
                Me.Cursor = Cursors.WaitCursor
                AgregarProductoAlta()
                Me.Cursor = Cursors.Arrow
            Catch ex As Exception
                Me.Cursor = Cursors.Arrow
                MessageBox.Show("Se ha producido un error al agregar el producto. Por favor, Comuníquese con el administrador.", "Administración de Ordenes de Compra", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If
    End Sub

    Private Sub txtProductooModificacion_KeyDown(sender As Object, e As KeyEventArgs) Handles txtProductoModificacion.KeyDown
        If e.KeyData = Keys.Enter Then
            Try
                Me.Cursor = Cursors.WaitCursor
                AgregarProductoModificacion()
                Me.Cursor = Cursors.Arrow
            Catch ex As Exception
                Me.Cursor = Cursors.Arrow
                MessageBox.Show("Se ha producido un error al agregar el producto. Por favor, Comuníquese con el administrador.", "Administración de Ordenes de Compra", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If
    End Sub

    Private Sub Btn_Modificar_Click(sender As Object, e As EventArgs) Handles btnModificar.Click
        If (dgMercaderiaDetalle.RowCount = 0) Then
            MessageBox.Show("Debe completar los campos requeridos y cargar al menos un producto.", "Administración de Ordenes de Compra", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Return
        End If

        Dim ordenCompra As OrdenCompra = ModificacionOrdenCompraBindingSource.DataSource
        If (ordenCompra.Detalles.Any(Function(x) Not x.Verificado)) Then
            MessageBox.Show("Existen productos con advertencias, Por favor verifique las advertencias.", "Administración de Ordenes de Compra", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Return
        End If

        Try
            Me.Cursor = Cursors.WaitCursor
            NegOrdenCompra.Modificar(ModificacionOrdenCompraBindingSource.DataSource)
            MessageBox.Show("Se ha actualizado la orden de compra.", "Administración de Ordenes de Compra", MessageBoxButtons.OK, MessageBoxIcon.Information)
            tabOrdenCompra.SelectedTab = TabBusqueda
            Me.Cursor = Cursors.Arrow
        Catch ex As Exception
            Me.Cursor = Cursors.Arrow
            MessageBox.Show("Se ha producido un error al guardar la orden de compra. Por favor, Comuníquese con el administrador.", "Administración de Ordenes de Compra", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub dgOrdenCompraBusqueda_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgOrdenCompraBusqueda.CellDoubleClick
        tabOrdenCompra.SelectedTab = TabDetalle
    End Sub

    Private Sub tabOrdenCompra_Selected(sender As Object, e As TabControlEventArgs) Handles tabOrdenCompra.Selected
        If (tabOrdenCompra.SelectedTab.Name = TabDetalle.Name AndAlso dgOrdenCompraBusqueda.RowCount > 0 AndAlso dgOrdenCompraBusqueda.SelectedRows IsNot Nothing) Then
            Try
                Me.Cursor = Cursors.WaitCursor
                Dim ordenCompra As OrdenCompra = BuscarOrdenCompraBindingSource.Current
                ModificacionOrdenCompraBindingSource.DataSource = ordenCompra
                txtProductoModificacion.AutoCompleteCustomSource = CargraListaProductos(ordenCompra.idProveedor)
                ActualizarTotales(ordenCompra, lblMontoTotalDetalle, lblTotalesDetalle)
                Select Case ordenCompra.Estado
                    Case OrdenCompraPedidoEstado.Nuevo
                        BtnAgregarModificacion.Enabled = True
                        btnModificar.Enabled = True
                        btnEnviarModificacion.Enabled = True
                        btnRecibirModificacion.Enabled = False

                    Case OrdenCompraPedidoEstado.Enviado
                        BtnAgregarModificacion.Enabled = False
                        btnModificar.Enabled = False
                        btnEnviarModificacion.Enabled = False
                        btnRecibirModificacion.Enabled = True

                    Case OrdenCompraPedidoEstado.Recibido
                        BtnAgregarModificacion.Enabled = False
                        btnModificar.Enabled = False
                        btnEnviarModificacion.Enabled = False
                        btnRecibirModificacion.Enabled = False
                        EliminarDetalle.Visible = False
                    Case Else
                        BtnAgregarModificacion.Enabled = False
                        btnModificar.Enabled = False
                        btnEnviarModificacion.Enabled = False
                        btnRecibirModificacion.Enabled = False
                        EliminarDetalle.Visible = False
                End Select
                tabOrdenCompra.SelectedTab = TabDetalle
                Me.Cursor = Cursors.Arrow
            Catch ex As Exception
                Me.Cursor = Cursors.Arrow
                MessageBox.Show("Se ha producido un error al obtener el detalle de la orden de compra. Por favor, Comuníquese con el administrador.", "Administración de Ordenes de Compra", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        ElseIf tabOrdenCompra.SelectedTab.Name = TabBusqueda.Name Then
            BuscarOrdenesCompra()
        End If
    End Sub

    Private Sub dgOrdenCompraBusqueda_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgOrdenCompraBusqueda.CellContentClick
        If dgOrdenCompraBusqueda.Columns(e.ColumnIndex).Name = "Eliminar" Then
            If MessageBox.Show("¿Está seguro que desea eliminar la orden de compra?", "Administración de Ordenes de Compra", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                Try
                    Me.Cursor = Cursors.WaitCursor
                    Dim ordenCompra As OrdenCompra = BuscarOrdenCompraBindingSource.Current
                    NegOrdenCompra.Eliminar(ordenCompra)
                    BuscarOrdenCompraBindingSource.Remove(BuscarOrdenCompraBindingSource.Current)
                    ObtenerNotasPedidosAbiertasEnviadas()
                    MessageBox.Show("Se ha eliminado la orden de compra.", "Administración de Ordenes de Compra", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Me.Cursor = Cursors.Arrow
                Catch ex As Exception
                    Me.Cursor = Cursors.Arrow
                    MessageBox.Show("Se ha producido un error al eliminar la orden de compra. Por favor, Comuníquese con el administrador.", "Administración de Ordenes de Compra", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End Try
            End If
        End If
    End Sub

    Private Sub dgMercaderiaAlta_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgMercaderiaAlta.CellContentClick
        If dgMercaderiaAlta.Columns(e.ColumnIndex).Name = "EliminarAlta" Then
            If MessageBox.Show("¿Está seguro que desea eliminar el item seleccionado?", "Administración de Ordenes de Compra", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                AltaDetallesBindingSource.RemoveCurrent()
            End If
        End If

        If dgMercaderiaAlta.Columns(e.ColumnIndex).Name = "AdvertenciaAlta" Then
            Dim ordenCompraDetalle As OrdenCompraDetalle = AltaDetallesBindingSource.Current
            If MostrarAdvertencias(ordenCompraDetalle) = DialogResult.No Then
                AltaDetallesBindingSource.RemoveCurrent()
            Else
                ordenCompraDetalle.Verificado = True
                If (ordenCompraDetalle.Cantidad <= 0) Then
                    AltaDetallesBindingSource.RemoveCurrent()
                    MessageBox.Show("El producto se ha eliminado por tener cantidad igual a cero.", "Administración de Ordenes de Compra", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
            End If
            AltaOrdenCompraBindingSource.ResetBindings(False)
        End If
    End Sub

    Private Function MostrarAdvertencias(ordenCompraDetalle As OrdenCompraDetalle) As DialogResult
        Dim frmOrdenCompraProductoRepetido As frmOrdenCompraProductoRepetido = New frmOrdenCompraProductoRepetido()
        frmOrdenCompraProductoRepetido.OrdenCompraDetalle = ordenCompraDetalle
        frmOrdenCompraProductoRepetido.OrdenCompra = stockNotaPedidoExistentes.Where(Function(x) x.Detalles.Where(Function(y) y.idProducto = ordenCompraDetalle.idProducto).Any).ToList()

        Return frmOrdenCompraProductoRepetido.ShowDialog()
    End Function


    Private Sub dgMercaderiaDetalle_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgMercaderiaDetalle.CellContentClick
        If dgMercaderiaDetalle.Columns(e.ColumnIndex).Name = "EliminarDetalle" Then
            If MessageBox.Show("¿Está seguro que desea eliminar el item seleccionado?", "Administración de Ordenes de Compra", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                ModificacionDetallesBindingSource.RemoveCurrent()
            End If
        End If

        If dgMercaderiaDetalle.Columns(e.ColumnIndex).Name = "AdvertenciaDetalle" Then
            Dim ordenCompraDetalle As OrdenCompraDetalle = ModificacionDetallesBindingSource.Current
            If MostrarAdvertencias(ModificacionDetallesBindingSource.Current) = DialogResult.No Then
                ModificacionDetallesBindingSource.RemoveCurrent()
            Else
                ordenCompraDetalle.Verificado = True
            End If
            ModificacionDetallesBindingSource.ResetBindings(False)
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btnRecibirModificacion.Click
        Dim OrdenCompra As OrdenCompra = ModificacionOrdenCompraBindingSource.DataSource
        If (OrdenCompra.Estado <> OrdenCompraPedidoEstado.Enviado) Then
            MessageBox.Show(String.Format("El pedido se encuentra en estado {0}, solo las ordenes de compra en estado ENVIADO puede ser recibidas.", OrdenCompra.Estado), "Administración de Ordenes de Compra", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Return
        End If
        Try
            Me.Cursor = Cursors.WaitCursor
            OrdenCompra.Estado = OrdenCompraPedidoEstado.Recibido
            GuardarMercaderia(OrdenCompra)
            NegOrdenCompra.Recibir(OrdenCompra)
            MessageBox.Show("Se a actualizado el stock correctamente.", "Administración de Ordenes de Compra", MessageBoxButtons.OK, MessageBoxIcon.Information)
            tabOrdenCompra.SelectedTab = TabBusqueda
            ObtenerNotasPedidosAbiertasEnviadas()
            Me.Cursor = Cursors.Arrow
        Catch ex As Exception
            Me.Cursor = Cursors.Arrow
            MessageBox.Show("Se ha producido un error al actualizo el stock de la orden de compra. Por favor, Comuníquese con el administrador.", "Administración de Ordenes de Compra", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Public Sub GuardarMercaderia(OrdenCompra As OrdenCompra)
        'Ingreso la Mercaderia.
        Dim EMercaderia As New Entidades.Mercaderias() With {
                .id_Proveedor = OrdenCompra.idProveedor,
                .id_Sucursal = My.Settings.Sucursal,
                .Habilitado = 1,
                .Fecha = Date.Now,
                .CantidadTotal = OrdenCompra.Detalles.Sum(Function(x) x.Cantidad),
                .MontoTotal = OrdenCompra.Detalles.Sum(Function(x) x.Costo * x.Cantidad)}

        Dim id_Mercaderia As Int64 = NegMercaderia.AltaMercaderia(EMercaderia)

        For Each mercaderiaDetalle As OrdenCompraDetalle In OrdenCompra.Detalles
            Dim EMercaDetalle As New Entidades.Mercaderias_Detalle() With {
            .id_Mercaderia = id_Mercaderia,
            .id_Producto = mercaderiaDetalle.idProducto,
            .Costo = mercaderiaDetalle.Costo,
            .Cantidad = mercaderiaDetalle.Cantidad,
            .Total = mercaderiaDetalle.Cantidad * mercaderiaDetalle.Costo}

            NegMercaderia.AltaMercaderiaDetalle(EMercaDetalle, My.Settings.Sucursal)
        Next

        'Ingreso la deuda en la cuenta corriente
        Dim ECuenta As New Entidades.Cuenta_Corriente() With {
            .id_Mercaderia = id_Mercaderia,
            .id_Proveedor = EMercaderia.id_Proveedor,
            .id_Sucursal = EMercaderia.id_Sucursal,
            .Fecha = Date.Now,
            .Monto = EMercaderia.MontoTotal * -1}
        NegCuentaCorriente.AltaCuentaCorriente(ECuenta)
    End Sub

    Private Async Sub btnEnviarAlta_Click(sender As Object, e As EventArgs) Handles btnEnviarAlta.Click
        If (dgMercaderiaAlta.RowCount = 0) Then
            MessageBox.Show("Debe completar los campos requeridos y cargar al menos un producto.", "Administración de Ordenes de Compra", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Return
        End If

        Dim ordenCompra As OrdenCompra = AltaOrdenCompraBindingSource.DataSource
        If (ordenCompra.Detalles.Any(Function(x) Not x.Verificado)) Then
            MessageBox.Show("Existen productos con advertencias, Por favor verifique las advertencias.", "Administración de Ordenes de Compra", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Return
        End If

        Try
            'Guardo la orden de compra
            Me.Cursor = Cursors.WaitCursor
            NegOrdenCompra.Guardar(ordenCompra)
            MessageBox.Show("Se ha dado de alta la orden de compra.", "Administración de Ordenes de Compra", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.Cursor = Cursors.Arrow
        Catch ex As Exception
            Me.Cursor = Cursors.Arrow
            MessageBox.Show("Se ha producido un error al dar de alta la orden de compra. Por favor, Comuníquese con el administrador.", "Administración de Ordenes de Compra", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End Try

        If MessageBox.Show("¿Desea enviar un email con la orden de compra al proveedor?", "Administración de Ordenes de Compra", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            Dim respuestaEnvioMail = Await EnviarCorreo(ordenCompra, cbProveedorAlta.SelectedValue, cbEncargadoAlta.SelectedValue, AltaDetallesBindingSource)
        End If

        InicializarAlta()
        ObtenerNotasPedidosAbiertasEnviadas()
        tabOrdenCompra.SelectedTab = TabBusqueda
    End Sub

    Private Async Sub btnEnviarModificacion_Click(sender As Object, e As EventArgs) Handles btnEnviarModificacion.Click
        If (dgMercaderiaDetalle.RowCount = 0) Then
            MessageBox.Show("Debe completar los campos requeridos y cargar al menos un producto.", "Administración de Ordenes de Compra", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Return
        End If

        Dim ordenCompra As OrdenCompra = ModificacionOrdenCompraBindingSource.DataSource
        If (ordenCompra.Detalles.Any(Function(x) Not x.Verificado)) Then
            MessageBox.Show("Existen productos con advertencias, Por favor verifique las advertencias.", "Administración de Ordenes de Compra", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Return
        End If

        Try
            'Guardo la orden de compra
            Me.Cursor = Cursors.WaitCursor
            NegOrdenCompra.Modificar(ModificacionOrdenCompraBindingSource.DataSource)
            Me.Cursor = Cursors.Arrow
        Catch ex As Exception
            Me.Cursor = Cursors.Arrow
            MessageBox.Show("Se ha producido un error al dar de alta la orden de compra. Por favor, Comuníquese con el administrador.", "Administración de Ordenes de Compra", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End Try

        If MessageBox.Show("¿Desea enviar un email con la orden de compra al proveedor?", "Administración de Ordenes de Compra", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            Dim respuestaEnvioMail = Await EnviarCorreo(ordenCompra, ordenCompra.idProveedor, ordenCompra.idEncargado, ModificacionDetallesBindingSource)

            If respuestaEnvioMail Then
                InicializarDetalle()
                tabOrdenCompra.SelectedTab = TabBusqueda
            End If
        End If
        ObtenerNotasPedidosAbiertasEnviadas()
    End Sub

    Private Async Function EnviarCorreo(OrdenCompra As OrdenCompra, idProveedor As Integer, idEncargado As Integer, detalleBindingSource As BindingSource) As Threading.Tasks.Task(Of Boolean)
        Try
            Me.Cursor = Cursors.WaitCursor

            'Recupero la pantatilla del mail
            Dim srMailMansaje As New StreamReader("Plantilla\MailOrdenCompra.txt", Encoding.Default)

            'Exporto la lista de productos a Excel
            Dim nombreArchivo As String = $"{System.Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments)}\OrdenCompra_{My.Settings.NombreSucursal}_{Date.Now.ToString("dd-MM-yyyy")}.xlsx"
            Funciones.ExportarAExcel(nombreArchivo, $"Sucursal: {My.Settings.NombreSucursal}", $"Fecha: {Date.Now.ToString("dd/MM/yyyy")}", ObtenerDataTable(detalleBindingSource))

            Dim proveedor As Proveedores = NegProveedor.TraerProveedor(idProveedor)
            If String.IsNullOrEmpty(proveedor.Mail) Then
                MessageBox.Show("Se ha cancela el envió del email, el proveedor no tiene resgistrado un email.", "Administración de Ordenes de Compra", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Me.Cursor = Cursors.Arrow
                Return False
            End If

            Dim sucursal As Sucursales = NegSucursales.TraerSucursal(My.Settings.Sucursal)
            If String.IsNullOrEmpty(sucursal.Mail) Then
                MessageBox.Show("Se ha cancela el envió del email, la sucursal no tiene resgistrado un email.", "Administración de Ordenes de Compra", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Me.Cursor = Cursors.Arrow
                Return False
            End If

            'Envio el mail al proveedor
            Dim eMail As Mail = New Mail() With {
                .Too = proveedor.Mail,
                .CC = sucursal.Mail,
                .From = sucursal.Mail,
                .Subject = $"Orden de compra Sucursal {My.Settings.NombreSucursal}",
                .Body = String.Format(srMailMansaje.ReadToEnd(), My.Settings.NombreSucursal),
                .Attachment = nombreArchivo
                }

            Me.Cursor = Cursors.Arrow
            Dim DialogInput As DialogInput = New DialogInput($"Para enviar el email debe ingresar la calve de la casilla de correos {eMail.From}", "Administración de Ordenes de Compra")
            Dim respuesta As DialogResult = DialogInput.ShowDialog()
            If respuesta = DialogResult.OK Then
                Me.Cursor = Cursors.WaitCursor
                Dim envioOk As Boolean = Await Funciones.EnviarMailAsync(eMail, eMail.From, DialogInput.txtRespuesta.Text)

                If envioOk Then


                    'Actualizo la orden de compra a enviada
                    OrdenCompra.Estado = OrdenCompraPedidoEstado.Enviado
                    NegOrdenCompra.Modificar(OrdenCompra)

                    MessageBox.Show("Se ha enviado la orden de compra al proveedor.", "Administración de Ordenes de Compra", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Me.Cursor = Cursors.Arrow
                    Return True
                Else
                    MessageBox.Show("Se ha producido un error enviar la orden de compra. Por favor, Comuníquese con el administrador.", "Administración de Ordenes de Compra", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Me.Cursor = Cursors.Arrow
                    Return False
                End If
            Else
                MessageBox.Show("Se ha cancela el envió del email.", "Administración de Ordenes de Compra", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Return False
            End If
        Catch ex As Exception
            Me.Cursor = Cursors.Arrow
            MessageBox.Show("Se ha producido un error enviar la orden de compra. Por favor, Comuníquese con el administrador.", "Administración de Ordenes de Compra", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End Try
    End Function

    Private Function ObtenerDataTable(detalleBindingSource As BindingSource)
        Dim dt As DataTable = New DataTable()

        dt.Columns.Add("Código")
        dt.Columns.Add("Artículo")
        dt.Columns.Add("Cantidad")

        For Each detalle As OrdenCompraDetalle In detalleBindingSource.List
            Dim dr As DataRow = dt.NewRow()
            dr(0) = detalle.Codigo
            dr(1) = detalle.Nombre
            dr(2) = detalle.Cantidad

            dt.Rows.Add(dr)
        Next

        Return dt
    End Function

    Private Sub BuscarOrdenCompraBindingSource_BindingComplete(sender As Object, e As BindingCompleteEventArgs) Handles BuscarOrdenCompraBindingSource.BindingComplete
        lbl_Msg.Visible = BuscarOrdenCompraBindingSource.List.Count = 0
    End Sub

    Private Sub BtnCargaAutomaticaAlta_Click(sender As Object, e As EventArgs) Handles BtnCargaAutomaticaAlta.Click
        Try
            If (cbProveedorAlta.SelectedValue = 0) Then
                MessageBox.Show("Debe seleccionar un proveedor.", "Administración de Ordenes de Compra", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Return
            End If

            Me.Cursor = Cursors.WaitCursor

            Dim productosAgregados As Integer = 0
            Dim ordenCompra As OrdenCompra = AltaOrdenCompraBindingSource.DataSource
            Dim proveedor As Proveedores = NegProveedor.TraerProveedor(ordenCompra.idProveedor)

            'Obtengo los productos en sotck de este proveedor
            Dim stocks As List(Of Stock) = NegStock.ListadoStock(My.Settings.Sucursal, ordenCompra.idProveedor)
            For Each stock As Stock In stocks
                'Verifico si tiene faltante de stock
                If stock.Stock_Actual < stock.Stock_Minimo Then
                    Dim producto As Productos = NegProductos.TraerProducto(stock.id_Producto)
                    'Verifico que el producto no esta ingresado en la lista
                    If Not ordenCompra.Detalles.Any(Function(x) x.Codigo = producto.Codigo) Then
                        'Agrego el producto
                        ordenCompra.Detalles.Add(New OrdenCompraDetalle() With {
                                .Codigo = producto.Codigo,
                                .idProducto = producto.id_Producto,
                                .Costo = producto.Costo,
                                .Nombre = producto.Nombre,
                                .Cantidad = stock.Stock_Optimo - stock.Stock_Actual + (stock.VentaMensual / 30 * proveedor.PlazoEntrega)})

                        productosAgregados += 1
                    End If
                End If
            Next

            Me.Cursor = Cursors.Arrow

            If (productosAgregados > 0) Then
                MessageBox.Show($"Se han agregado {productosAgregados} nuevos producto con faltante de stock.", "Administración de Ordenes de Compra", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                MessageBox.Show("No se han encontrado productos con faltante de stock para el proveedor seleccionado.", "Administración de Ordenes de Compra", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If

            ActualizarTotales(AltaOrdenCompraBindingSource.DataSource, lblMontoTotalAlta, lblTotalesAlta)
            AltaOrdenCompraBindingSource.ResetBindings(False)

        Catch ex As Exception
            Me.Cursor = Cursors.Arrow
            MessageBox.Show("Se ha producido un error al cargar los productos de forma automática. Por favor, Comuníquese con el administrador.", "Administración de Ordenes de Compra", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub dgMercaderia_CellFormatting(sender As Object, e As DataGridViewCellFormattingEventArgs) Handles dgMercaderiaAlta.CellFormatting, dgMercaderiaDetalle.CellFormatting
        Dim dataGridView As DataGridView = CType(sender, DataGridView)
        If (dataGridView.Columns(e.ColumnIndex).Name.Contains("Advertencia")) Then
            Dim ordenCompraDetalle As OrdenCompraDetalle = dataGridView.Rows(e.RowIndex).DataBoundItem

            If ordenCompraDetalle.Verificado Then
                e.Value = New Bitmap(1, 1)
                Return
            End If

            Dim existeProductoEnOrdenCompraActiva As Boolean = stockNotaPedidoExistentes.Where(Function(x) x.Detalles.Where(Function(y) y.idProducto = ordenCompraDetalle.idProducto).Any).Any
            If (existeProductoEnOrdenCompraActiva) Then
                ordenCompraDetalle.Verificado = False
            Else
                e.Value = New Bitmap(1, 1)
                ordenCompraDetalle.Verificado = True
            End If
        End If
    End Sub

End Class