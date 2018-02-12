Imports System.IO
Imports System.Text
Imports Entidades
Imports Negocio


Public Class frmOrdenCompra
    Dim NegProveedor As NegProveedores = New NegProveedores()
    Dim NegStockPedido As NegOrdenCompra = New NegOrdenCompra()
    Dim NegEmpleados As NegEmpleados = New NegEmpleados()
    Dim NegProductos As NegProductos = New NegProductos()
    Dim NegSucursales As NegSucursales = New NegSucursales()
    Dim NegEmail As NegEmail = New NegEmail()
    Dim dsProductos As DataSet

    Dim Funciones As Funciones = New Funciones()
    Private Sub frmStockPedido_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        InicializarAlta()

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

        dsProductos = NegProductos.ListadoProductosCache(True)

        txtProductoAlta.AutoCompleteCustomSource = CargraListaProductos(cbProveedorAlta.SelectedValue)

        BuscarOrdenesCompra()
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

    Private Sub CellValidating(sender As Object, e As DataGridViewCellValidatingEventArgs) Handles dgMercaderiaAlta.CellValidating
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

    Private Sub dgMercaderiaDetalle_CellEndEdit(sender As Object, e As DataGridViewCellEventArgs)
        ActualizarTotales(ModificacionOrdenCompraBindingSource.DataSource, lblMontoTotalDetalle, lblTotalesDetalle)
    End Sub

    Private Sub dgMercaderiaAlta_CellEndEdit(sender As Object, e As DataGridViewCellEventArgs) Handles dgMercaderiaAlta.CellEndEdit
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

            Dim ordenesCompraDetalleGrilla As OrdenCompraDetalle = ordenesCompra.Detalles.FirstOrDefault(Function(x) x.Codigo = ordenesCompraDetalle.Codigo)
            If (ordenesCompraDetalleGrilla IsNot Nothing) Then
                ordenesCompraDetalleGrilla.Cantidad += 1
            Else
                detalleBindingSource.Add(ordenesCompraDetalle)
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

        Try
            Me.Cursor = Cursors.WaitCursor
            NegStockPedido.Guardar(AltaOrdenCompraBindingSource.DataSource)
            Me.Cursor = Cursors.Arrow
            MessageBox.Show("Se ha dado de alta la orden de compra.", "Administración de Ordenes de Compra", MessageBoxButtons.OK, MessageBoxIcon.Information)
            InicializarAlta()
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

    Private Sub BtnFiltrar_Click(sender As Object, e As EventArgs) Handles BtnFiltrar.Click
        BuscarOrdenesCompra()
    End Sub

    Private Sub BuscarOrdenesCompra()
        Try
            Me.Cursor = Cursors.WaitCursor
            Dim ordenCompra As List(Of OrdenCompra) = NegStockPedido.Obtener(My.Settings.Sucursal, dpDesdeBusqueda.Value, dpHastaBusqueda.Value)

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

        Try
            Me.Cursor = Cursors.WaitCursor
            NegStockPedido.Modificar(ModificacionOrdenCompraBindingSource.DataSource)
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
                    NegStockPedido.Eliminar(ordenCompra)
                    BuscarOrdenCompraBindingSource.Remove(BuscarOrdenCompraBindingSource.Current)
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
        If dgOrdenCompraBusqueda.Columns(e.ColumnIndex).Name = "EliminarAlta" Then
            If MessageBox.Show("¿Está seguro que desea eliminar el item seleccionado?", "Administración de Ordenes de Compra", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                AltaDetallesBindingSource.RemoveCurrent()
            End If
        End If
    End Sub

    Private Sub dgMercaderiaDetalle_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgMercaderiaDetalle.CellContentClick
        If dgOrdenCompraBusqueda.Columns(e.ColumnIndex).Name = "EliminarDetalle" Then
            If MessageBox.Show("¿Está seguro que desea eliminar el item seleccionado?", "Administración de Ordenes de Compra", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                ModificacionDetallesBindingSource.RemoveCurrent()
            End If
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
            NegStockPedido.Recibir(OrdenCompra)
            MessageBox.Show("Se a actualizado el stock correctamente.", "Administración de Ordenes de Compra", MessageBoxButtons.OK, MessageBoxIcon.Information)
            tabOrdenCompra.SelectedTab = TabBusqueda
            Me.Cursor = Cursors.Arrow
        Catch ex As Exception
            Me.Cursor = Cursors.Arrow
            MessageBox.Show("Se ha producido un error al actualizo el stock de la orden de compra. Por favor, Comuníquese con el administrador.", "Administración de Ordenes de Compra", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Async Sub btnEnviarAlta_Click(sender As Object, e As EventArgs) Handles btnEnviarAlta.Click
        If (dgMercaderiaAlta.RowCount = 0) Then
            MessageBox.Show("Debe completar los campos requeridos y cargar al menos un producto.", "Administración de Ordenes de Compra", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Return
        End If

        Dim ordenCompra As OrdenCompra = AltaOrdenCompraBindingSource.DataSource

        Try
            'Guardo la orden de compra
            Me.Cursor = Cursors.WaitCursor
            NegStockPedido.Guardar(ordenCompra)
            MessageBox.Show("Se ha dado de alta la orden de compra.", "Administración de Ordenes de Compra", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.Cursor = Cursors.Arrow
        Catch ex As Exception
            Me.Cursor = Cursors.Arrow
            MessageBox.Show("Se ha producido un error al dar de alta la orden de compra. Por favor, Comuníquese con el administrador.", "Administración de Ordenes de Compra", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End Try

        If MessageBox.Show("¿Desea enviar un email con la orden de compra al proveedor?", "Administración de Ordenes de Compra", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then

            Dim respuestaEnvioMail = Await EnviarCorreo(ordenCompra, cbProveedorAlta.SelectedValue, cbEncargadoAlta.SelectedValue, AltaDetallesBindingSource)

            If respuestaEnvioMail Then
                InicializarAlta()
                tabOrdenCompra.SelectedTab = TabBusqueda
            Else
                InicializarAlta()
            End If
        Else
            InicializarAlta()
            tabOrdenCompra.SelectedTab = TabBusqueda
        End If
    End Sub

    Private Async Sub btnEnviarModificacion_Click(sender As Object, e As EventArgs) Handles btnEnviarModificacion.Click
        If (dgMercaderiaDetalle.RowCount = 0) Then
            MessageBox.Show("Debe completar los campos requeridos y cargar al menos un producto.", "Administración de Ordenes de Compra", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Return
        End If

        If MessageBox.Show("¿Desea enviar un email con la orden de compra al proveedor?", "Administración de Ordenes de Compra", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            Dim ordenCompra As OrdenCompra = ModificacionOrdenCompraBindingSource.DataSource

            Dim respuestaEnvioMail = Await EnviarCorreo(ordenCompra, ordenCompra.idProveedor, ordenCompra.idEncargado, ModificacionDetallesBindingSource)

            If respuestaEnvioMail Then
                tabOrdenCompra.SelectedTab = TabBusqueda
            End If
        End If
    End Sub

    Private Async Function EnviarCorreo(OrdenCompra As OrdenCompra, idProveedor As Integer, idEncargado As Integer, detalleBindingSource As BindingSource) As Threading.Tasks.Task(Of Boolean)
        Try
            Me.Cursor = Cursors.WaitCursor

            'Recupero la pantatilla del mail
            Dim srMailMansaje As New StreamReader("Plantilla\MailOrdenCompra.txt", Encoding.Default)

            'Exporto la lista de productos a Excel
            Dim nombreArchivo As String = $"{System.Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments)}\OrdenCompraMercaderia.xlsx"
            Funciones.ExportarAExcel(nombreArchivo, $"Sucursal: {My.Settings.NombreSucursal}", $"Fecha: {Date.Now.ToString("yyyy/MM/dd")}", ObtenerDataTable(detalleBindingSource))

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
                Await Funciones.EnviarMailAsync(eMail, eMail.From, DialogInput.txtRespuesta.Text)

                'Actualizo la orden de compra a enviada
                OrdenCompra.Estado = OrdenCompraPedidoEstado.Enviado
                NegStockPedido.Modificar(OrdenCompra)

                MessageBox.Show("Se ha enviado la orden de compra al proveedor.", "Administración de Ordenes de Compra", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Me.Cursor = Cursors.Arrow
                Return True
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
        dt.Columns.Add("Nombre")
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
End Class