Public Class frmStockMasiva
    Dim id_Sucursal As Integer = My.Settings("Sucursal")
    Dim Nombre_Sucursal As String = My.Settings("NombreSucursal")
    Dim NegProducto As New Negocio.NegProductos
    Dim NegStock As New Negocio.NegStock
    Dim NegProveedor As New Negocio.NegProveedores
    Dim NegMercaderia As New Negocio.NegMercaderia
    Dim NegCuentaCorriente As New Negocio.NegCuentaCorriente
    Dim EProducto As New Entidades.Productos
    Dim EMercaderia As New Entidades.Mercaderias
    Dim EStock As New Entidades.Stock
    Dim Funciones As New Funciones
    Dim NegErrores As New Negocio.NegManejadorErrores
    Dim dtProductos As DataTable

#Region "Región de Validaciones."

    'Valido que se ingrese solo currency en campo costo. 
    Private Sub txt_Costo_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_Costo.KeyPress
        If e.KeyChar.ToString() = "." Then
            e.KeyChar = CChar(",")
        End If
        Dim KeyAscii As Short = CShort(Asc(e.KeyChar))
        KeyAscii = CShort(NegErrores.SoloCurrency(KeyAscii))
        If KeyAscii = 0 Then
            e.Handled = True
            ErrorStock.SetError(txt_Costo, "Debe ingresar el monto en el formato permitido. Ejemplo: 725,50")
        Else
            ErrorStock.SetError(txt_Costo, Nothing)
        End If
    End Sub

    'Valido que sea solo numeros. - CANTIDAD.
    Private Sub txt_Cantidad_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_Cantidad.KeyPress
        Dim KeyAscii As Short = CShort(Asc(e.KeyChar))
        KeyAscii = CShort(NegErrores.SoloNumeros(KeyAscii))
        If KeyAscii = 0 Then
            e.Handled = True
        End If
    End Sub

    'Valido que sea solo numeros. - STOCK ACTUAL.
    Private Sub txt_Actual_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_Actual.KeyPress
        Dim KeyAscii As Short = CShort(Asc(e.KeyChar))
        KeyAscii = CShort(NegErrores.SoloNumeros(KeyAscii))
        If KeyAscii = 0 Then
            e.Handled = True
        End If
    End Sub

    'Valido que sea solo numeros. - STOCK MINIMO.
    Private Sub txt_Minimo_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_Minimo.KeyPress
        Dim KeyAscii As Short = CShort(Asc(e.KeyChar))
        KeyAscii = CShort(NegErrores.SoloNumeros(KeyAscii))
        If KeyAscii = 0 Then
            e.Handled = True
        End If
    End Sub

    'Valido que sea solo numeros. - STOCK OPTIMO.
    Private Sub txt_Optimo_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_Optimo.KeyPress
        Dim KeyAscii As Short = CShort(Asc(e.KeyChar))
        KeyAscii = CShort(NegErrores.SoloNumeros(KeyAscii))
        If KeyAscii = 0 Then
            e.Handled = True
        End If
    End Sub

    'Boton que borra la mercaderia ingresada.
    Private Sub Btn_Cancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_Cancelar.Click
        If MessageBox.Show("¿Ésta seguro que desea borrar la mercadería cargada?", "Ingreso de Mercadería", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = vbYes Then
            'Limpio los formularios.
            LimpiarFormAltaStock()
            'Limpio el datagrid.
            DG_Mercaderia.Rows.Clear()
            DG_Mercaderia.Update()
        End If
    End Sub

#End Region

#Region "Región de Funciones."
    'Limpia el formulario completamente. - ALTA
    Sub LimpiarFormAltaStock()
        txt_Actual.Clear()
        txt_Minimo.Clear()
        txt_Optimo.Clear()
        txt_Codigo.Clear()
        txt_Cantidad.Clear()
        txt_Costo.Clear()
        lbl_ProductoNombre.Text = "- - -"
        lbl_MontoTotal.Text = "$ 0"
        lbl_Totales_Prod.Text = "0"
        Gb_Stock.Visible = False
        Gb_Producto.Visible = False
        FechaIngreso.ResetText()
        Cb_Proveedor.SelectedItem = Nothing
        DG_Mercaderia.Rows.Clear()
        DG_Mercaderia.Update()
    End Sub

    'Limpia el formulario de agregar producto completamente.
    Sub LimpiarFormAgregarStock()
        txt_Actual.Clear()
        txt_Minimo.Clear()
        txt_Optimo.Clear()
        txt_Codigo.Clear()
        txt_Cantidad.Clear()
        txt_Costo.Clear()
        lbl_ProductoNombre.Text = "- - -"
        txt_Codigo.Focus()
    End Sub

    'Obtiene el stock del producto buscado.
    Sub ObtenerProducto(idProducto As Integer)
        Try
            If idProducto <> 0 Then
                'Busco informacion del producto seleccionado.
                EProducto = NegProducto.TraerProducto(idProducto)

                'Busco informacion de stock del producto seleccionado.
                EStock = NegStock.TraerStockProducto(idProducto, id_Sucursal)

                'Nombre del producto
                lbl_ProductoNombre.Text = EProducto.Nombre

                'Cargo los valores del producto ingresado.
                txt_Costo.Text = EProducto.Costo
                txt_Minimo.Text = EStock.Stock_Minimo
                txt_Optimo.Text = EStock.Stock_Optimo
                txt_Actual.Text = EStock.Stock_Actual

                txt_Cantidad.Focus()
            Else
                MessageBox.Show("No se encontró el producto con el código ingresado.", "Ingreso de Mercadería", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message.ToString, "Ingreso de Mercadería", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
    End Sub

    'Funcion que calcula el total en pesos del DATAGRID
    Function CalcularPrecioTotal()
        Dim subtotal As Double
        For i = 0 To (DG_Mercaderia.Rows.Count - 1)
            subtotal += (DG_Mercaderia.Rows(i).Cells.Item("Costo_2").Value * DG_Mercaderia.Rows(i).Cells.Item("Cantidad_2").Value)
        Next
        Return Format(CType(subtotal, Decimal), "###0.00")
    End Function
#End Region

#Region "Región de eventos."
    'Al hacer click para buscar un producto.
    Private Sub Btn_BuscarCodigo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_BuscarCodigo.Click
        Me.Cursor = Cursors.WaitCursor
        frmBuscarCodigoProducto.TipoForm = 4
        frmBuscarCodigoProducto.IdProveedor = Cb_Proveedor.SelectedValue
        Funciones.ControlInstancia(frmBuscarCodigoProducto).Show()
        Me.Cursor = Cursors.Arrow
    End Sub

    'Al cambiar el tab.
    Private Sub TabStock_Selected(ByVal sender As Object, ByVal e As System.Windows.Forms.TabControlEventArgs) Handles TabStock.Selected
        'Cambio el cursor a "WAIT"
        TabStock.Cursor = Cursors.WaitCursor

        If TabStock.SelectedTab.Name = "TabListado" Then 'TAB LISTADO DE STOCK

            Dim dsMercaderias As New DataSet
            dsMercaderias = NegMercaderia.ListadoMercaderia(id_Sucursal)
            If (dsMercaderias.Tables(0).Rows.Count > 0) Then
                DG_Stock.DataSource = dsMercaderias.Tables(0)
                DG_Stock.AutoGenerateColumns = False
                DG_Stock.ColumnHeadersVisible = True
                DG_Stock.Columns("id_Mercaderia").Visible = False
                DG_Stock.Refresh()
                lbl_Msg.Visible = False
            Else
                DG_Stock.ColumnHeadersVisible = False
                lbl_Msg.Visible = True
            End If

            'Limpio los formularios
            LimpiarFormAltaStock()

            'Seteo el id_Stock en cero
            EMercaderia.id_Mercaderia = 0

        ElseIf TabStock.SelectedTab.Name = "TabAlta" Then 'TAB ALTA DE STOCK

            'Limpio el formulario de alta.
            LimpiarFormAltaStock()
            txt_Sucursal.Text = Nombre_Sucursal

            'Seteo el id_Stock en cero
            EMercaderia.id_Mercaderia = 0

            'Oculto Columnas en el DG_Productos
            DG_Mercaderia.Columns("id_Producto_2").Visible = False

        ElseIf TabStock.SelectedTab.Name = "TabDetalle" Then 'TAB MODIFICACION DE STOCK

            If EMercaderia.id_Mercaderia > 0 Or EMercaderia.id_Mercaderia <> Nothing Then
            Else
                MessageBox.Show("Debe seleccionar previamente un pedido.", "Administración de Stock", MessageBoxButtons.OK, MessageBoxIcon.Stop)
                TabStock.SelectedTab = TabStock.TabPages("TabListado")
            End If

        End If

        'Cambio el cursor a NORMAL.
        TabStock.Cursor = Cursors.Arrow
    End Sub

    'Cuando Carga el formulario.
    Private Sub frmStockMasiva_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            'Cambio el cursor a "WAIT"
            TabStock.Cursor = Cursors.WaitCursor

            'seteo el font a 8px
            DG_Stock.AlternatingRowsDefaultCellStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            DG_Stock.DefaultCellStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            DG_Stock.RowHeadersDefaultCellStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            DG_Stock.ColumnHeadersDefaultCellStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))

            'seteo las imagenes
            Dim ListaImagenes = New ImageList
            ListaImagenes.ImageSize = New Size(32, 32)
            ListaImagenes.TransparentColor = Color.Blue
            ListaImagenes.ColorDepth = ColorDepth.Depth32Bit

            ListaImagenes.Images.Add(My.Resources.Recursos.Stock)
            ListaImagenes.Images.Add(My.Resources.Recursos.IconoADD)
            ListaImagenes.Images.Add(My.Resources.Recursos.IconoDetalle)

            TabStock.ImageList = ListaImagenes

            'icono de listado
            TabListado.ImageIndex = 0
            'icono de alta
            TabAlta.ImageIndex = 1
            'icono de Detalle
            TabDetalle.ImageIndex = 2

            Dim dsMercaderias As New DataSet
            dsMercaderias = NegMercaderia.ListadoMercaderia(id_Sucursal)
            If (dsMercaderias.Tables(0).Rows.Count > 0) Then
                DG_Stock.DataSource = dsMercaderias.Tables(0)
                DG_Stock.AutoGenerateColumns = False
                DG_Stock.ColumnHeadersVisible = True
                DG_Stock.Columns("id_Mercaderia").Visible = False
                DG_Stock.Refresh()
                lbl_Msg.Visible = False
            Else
                DG_Stock.ColumnHeadersVisible = False
                DG_Stock.DataSource = Nothing
                lbl_Msg.Visible = True
            End If

            Dim dsProveedor As DataSet = NegProveedor.ListadoProveedores()
            If (dsProveedor.Tables(0).Rows.Count > 0) Then
                Cb_Proveedor.DataSource = dsProveedor.Tables(0)
                Cb_Proveedor.DisplayMember = "RazonSocial"
                Cb_Proveedor.ValueMember = "id_Proveedor"
                Cb_Proveedor.Refresh()
            End If
            Me.Cursor = Cursors.Arrow

            'Cambio el cursor a NORMAL.
            TabStock.Cursor = Cursors.Arrow
        Catch ex As Exception
            TabStock.Cursor = Cursors.Arrow
            MessageBox.Show(ex.Message, "Ingreso de Mercadería", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    'Agregar Producto al Datagrid.
    Private Sub Btn_Agregar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_Agregar.Click
        AgregarProducto()
    End Sub

    Private Sub AgregarProducto()
        Try
            'Declaro Variables.
            Dim Costo, Cantidad, producto, Codigo, Stock_Minimo, Stock_Actual, Stock_Optimo As String

            'Si completo todos los campos agrego la fila.
            If txt_Cantidad.Text <> "" And txt_Codigo.Text <> "" Then
                'Cambio el cursor.
                Me.Cursor = Cursors.WaitCursor

                Dim idProducto As Integer = BuscarProducto()

                If (idProducto = 0) Then
                    Return
                End If

                'Seteo Variables.
                Costo = Trim(txt_Costo.Text)
                Cantidad = Trim(txt_Cantidad.Text)
                Codigo = Trim(txt_Codigo.Text)
                producto = lbl_ProductoNombre.Text
                Stock_Minimo = Trim(txt_Minimo.Text)
                Stock_Actual = Trim(CType(txt_Actual.Text, Integer) + CType(txt_Cantidad.Text, Integer))
                Stock_Optimo = Trim(txt_Optimo.Text)

                'Inserto en el Grid.
                'Creo la fila del ingreso.
                Dim dgvRow As New DataGridViewRow
                Dim dgvCell As DataGridViewCell

                'Valor de la Columna Codigo
                dgvCell = New DataGridViewTextBoxCell()
                dgvCell.Value = idProducto
                dgvRow.Cells.Add(dgvCell)

                'Valor de la Columna Nombre de producto
                dgvCell = New DataGridViewTextBoxCell()
                dgvCell.Value = producto
                dgvRow.Cells.Add(dgvCell)

                'Valor de la Columna Costo
                dgvCell = New DataGridViewTextBoxCell()
                dgvCell.Value = Format(CType(Costo, Decimal), "###0.00")
                dgvCell.Style.Format = "C2"
                dgvRow.Cells.Add(dgvCell)

                'Valor de la Columna Cantidad
                dgvCell = New DataGridViewTextBoxCell()
                dgvCell.Value = Cantidad
                dgvRow.Cells.Add(dgvCell)

                'Valor de la Columna Subtotal
                dgvCell = New DataGridViewTextBoxCell()
                dgvCell.Value = Format(CType((Cantidad * Costo), Decimal), "###0.00")
                dgvCell.Style.Format = "C2"
                dgvRow.Cells.Add(dgvCell)

                'Valor de la Columna Minimo
                dgvCell = New DataGridViewTextBoxCell()
                dgvCell.Value = Stock_Minimo
                dgvRow.Cells.Add(dgvCell)

                'Valor de la Columna Optimo
                dgvCell = New DataGridViewTextBoxCell()
                dgvCell.Value = Stock_Optimo
                dgvRow.Cells.Add(dgvCell)

                'Valor de la Columna Actual
                dgvCell = New DataGridViewTextBoxCell()
                dgvCell.Value = Stock_Actual
                dgvRow.Cells.Add(dgvCell)

                'Valor de la Columna Eliminar
                dgvCell = New DataGridViewImageCell()
                dgvCell.Value = My.Resources.Recursos.Boton_Eliminar
                dgvRow.Cells.Add(dgvCell)

                dgvRow.Height = "25"

                'Inserto la fila.
                DG_Mercaderia.Rows.Add(dgvRow)
                DG_Mercaderia.Update()

                'Limpio el formulario de agregar productos.
                LimpiarFormAgregarStock()

                'Muestro la cantidad de productos.
                lbl_Totales_Prod.Text = (DG_Mercaderia.Rows.Count)

                'Muestro el monto total.
                lbl_MontoTotal.Text = "$ " & CalcularPrecioTotal()

                'Cambio el cursor.
                Me.Cursor = Cursors.Arrow
            Else
                'Si no completo todos los campos muestro un mensaje.
                MessageBox.Show("Debe completar todos los campos.", "Ingreso de Mercadería", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End If
        Catch ex As Exception
            Me.Cursor = Cursors.Arrow
            MessageBox.Show("Se ha encontrado un error al agregar el producto.", "Ingreso de Mercadería", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End Try
    End Sub

    'Boton que ingresa la mercaderia en la base de datos.
    Private Sub Btn_Ingreso_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_Ingreso.Click
        If Cb_Proveedor.SelectedValue = 0 Then
            MessageBox.Show("Debe seleccionar un proveedor.", "Ingreso de Mercadería", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        Else
            Try
                Dim id_Mercaderia As Integer = 0 'Variable que indica el ingreso de la nueva mercaderia.
                Dim id_Proveedor As Integer = Cb_Proveedor.SelectedValue 'Variable que indica el proveedor seleccionado
                Dim Nombre_Proveedor As String = DirectCast(DirectCast(Cb_Proveedor.SelectedItem, System.Data.DataRowView).Row.ItemArray(1), String)
                Dim Fecha As Date = FechaIngreso.Value
                Dim ArrayProductos As New Collection 'Variable donde voy a guardar todos los productos, para luego imprimir las etiquetas.
                Dim MontoTotal As Double = CalcularPrecioTotal()
                If MessageBox.Show("¿Ésta seguro que desea ingresar la mercadería cargada?", "Ingreso de Mercadería", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = vbYes Then

                    'Ingreso la Mercaderia.
                    Dim EMercaderia As New Entidades.Mercaderias
                    EMercaderia.id_Proveedor = id_Proveedor
                    EMercaderia.id_Sucursal = id_Sucursal
                    EMercaderia.Habilitado = 1
                    EMercaderia.Fecha = Fecha
                    EMercaderia.CantidadTotal = DG_Mercaderia.Rows.Count
                    EMercaderia.MontoTotal = MontoTotal

                    'cambio el cursor
                    Me.Cursor = Cursors.WaitCursor

                    id_Mercaderia = NegMercaderia.AltaMercaderia(EMercaderia)

                    'Ingreso el detalle de la Mercaderia.
                    'Recorro cada producto del grid.
                    For i = 0 To DG_Mercaderia.Rows.Count - 1
                        'Declaro Variables.
                        Dim Costo, Cantidad, producto, id_Producto, Stock_Minimo, Total, Stock_Actual, Stock_Optimo As String

                        'Seteo Variables.
                        id_Producto = DG_Mercaderia.Rows(i).Cells.Item("id_Producto_2").Value
                        producto = DG_Mercaderia.Rows(i).Cells.Item("Producto_2").Value
                        Costo = DG_Mercaderia.Rows(i).Cells.Item("Costo_2").Value
                        Cantidad = DG_Mercaderia.Rows(i).Cells.Item("Cantidad_2").Value
                        Stock_Actual = DG_Mercaderia.Rows(i).Cells.Item("Stock_Actual").Value
                        Stock_Minimo = DG_Mercaderia.Rows(i).Cells.Item("Stock_Minimo").Value
                        Stock_Optimo = DG_Mercaderia.Rows(i).Cells.Item("Stock_Optimo").Value
                        Total = Costo * Cantidad

                        'Guardo el id en la coleccion.
                        If id_Producto <> 0 Then
                            Dim ArrayProducto As New Collection
                            ArrayProducto.Add(id_Producto)
                            ArrayProducto.Add(Cantidad)
                            ArrayProductos.Add(ArrayProducto)
                        End If

                        'Actualizo el Stock.
                        Dim EStockActualizado As New Entidades.Stock
                        EStock = NegStock.TraerStockProducto(id_Producto, id_Sucursal)
                        EStockActualizado.id_Stock = EStock.id_Stock
                        EStockActualizado.id_Sucursal = id_Sucursal
                        EStockActualizado.id_Producto = id_Producto
                        EStockActualizado.Stock_Optimo = Stock_Optimo
                        EStockActualizado.Stock_Minimo = Stock_Minimo
                        EStockActualizado.Stock_Actual = Stock_Actual
                        EStockActualizado.Habilitado = 1
                        EStockActualizado.Fecha_Mod = Now
                        EStockActualizado.Modificado = 0
                        EStockActualizado.id_Usuario = VariablesGlobales.objUsuario.id_Usuario
                        EStockActualizado.Motivo = ""


                        If EStock.id_Stock > 0 Then
                            NegStock.ModificacionStock(EStockActualizado)
                        Else
                            NegStock.AltaStock(EStockActualizado)
                        End If

                        'Mercaderia 
                        Dim EMercaDetalle As New Entidades.Mercaderias_Detalle
                        EMercaDetalle.id_Mercaderia = id_Mercaderia
                        EMercaDetalle.id_Producto = id_Producto
                        EMercaDetalle.Costo = Costo
                        EMercaDetalle.Cantidad = Cantidad
                        EMercaDetalle.Total = Total
                        NegMercaderia.AltaMercaderiaDetalle(EMercaDetalle)
                    Next

                    'Ingreso la deuda en la cuenta corriente
                    Dim ECuenta As New Entidades.Cuenta_Corriente
                    ECuenta.id_Mercaderia = id_Mercaderia
                    ECuenta.id_Proveedor = id_Proveedor
                    ECuenta.id_Sucursal = id_Sucursal
                    ECuenta.Fecha = Now
                    ECuenta.Monto = (MontoTotal * -1)
                    NegCuentaCorriente.AltaCuentaCorriente(ECuenta)

                    'Limpio el form.
                    LimpiarFormAltaStock()

                    'cambio el cursor
                    Me.Cursor = Cursors.Arrow

                    'Muestro MSG.
                    If MessageBox.Show("La mercaderia se ha ingresado correctamente.", "Ingreso de Mercaderia", MessageBoxButtons.OK, MessageBoxIcon.Information) = vbOK Then
                        'Abro el form de consulta.
                        DialogIngresos.ArrayProductos = ArrayProductos
                        DialogIngresos.id_Mercaderia = id_Mercaderia
                        Funciones.ControlInstancia(DialogIngresos).MdiParent = MDIContenedor
                        Funciones.ControlInstancia(DialogIngresos).Show()
                        Me.Close()
                        Me.Dispose()
                    End If

                End If
            Catch ex As Exception
                Me.Cursor = Cursors.Arrow
                MessageBox.Show("Se ha producido un error al ingresar la mercadería.", "Ingreso de Mercaderia", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try

        End If
    End Sub

    Private Sub DG_Mercaderia_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DG_Mercaderia.CellContentClick
        If DG_Mercaderia.Columns(e.ColumnIndex).Name = "Eliminar_2" Then 'Si se hace click en el boton "eliminar" de la fila.
            Dim Result As DialogResult
            Result = MessageBox.Show("¿Está seguro que desea eliminar el producto seleccionado?", "Ingreso de Mercadería", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

            If Result = System.Windows.Forms.DialogResult.Yes Then 'Si acepta eliminar el item
                Dim id_Producto As Integer = DG_Mercaderia.Rows(e.RowIndex).Cells("id_Producto_2").Value
                If id_Producto = 0 Then
                    'si no completo la descripcion, muestro un msg de error.
                    MessageBox.Show("No se puede eliminar el producto.", "Ingreso de Mercadería", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Else
                    DG_Mercaderia.Rows.RemoveAt(e.RowIndex) 'Elimino el item

                    'Muestro la cantidad de productos.
                    lbl_Totales_Prod.Text = (DG_Mercaderia.Rows.Count.ToString)

                    'Muestro el monto total.
                    lbl_MontoTotal.Text = "$ " & CalcularPrecioTotal()

                    'refresco el datagrid
                    DG_Mercaderia.Refresh()
                End If
            End If
        End If
    End Sub

    Private Sub DG_Stock_CellDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DG_Stock.CellDoubleClick
        Try
            Dim id_Mercaderia As Integer = 0
            Dim PrecioTotal As Double = 0
            Dim dsMercaderia As New DataSet
            Dim dsMercaderiaDetalle As New DataSet

            'Cambio el cursor a "WAIT"
            TabStock.Cursor = Cursors.WaitCursor

            If DG_Stock.SelectedRows.Count > 0 Then
                If e.RowIndex >= 0 Then
                    id_Mercaderia = DG_Stock.Rows(e.RowIndex).Cells("id_Mercaderia").Value()
                    EMercaderia.id_Mercaderia = id_Mercaderia

                    'Consulto la mercaderia
                    dsMercaderia = NegMercaderia.TraerMercaderia(id_Mercaderia)

                    'lleno los controls del tabDetalle
                    lbl_SucursalD.Text = Nombre_Sucursal
                    lbl_FechaD.Text = dsMercaderia.Tables(0).Rows(0).Item("Fecha").ToString
                    lbl_ProveedorD.Text = dsMercaderia.Tables(0).Rows(0).Item("Proveedor").ToString
                    lbl_Totales_Prod2.Text = dsMercaderia.Tables(0).Rows(0).Item("CantidadTotal").ToString
                    PrecioTotal = dsMercaderia.Tables(0).Rows(0).Item("MontoTotal").ToString

                    'Detalle de productos adquiridos.
                    dsMercaderiaDetalle = NegMercaderia.ObtenerDetalleMercaderia(id_Mercaderia)
                    If dsMercaderiaDetalle.Tables(0).Rows.Count > 0 Then
                        DG_ProductosD.DataSource = dsMercaderiaDetalle.Tables(0)
                        DG_ProductosD.AutoGenerateColumns = False
                        DG_ProductosD.Columns("Codigo").DisplayIndex = 0
                        DG_ProductosD.Columns("ProductoD").DisplayIndex = 1
                        DG_ProductosD.Columns("CantidadD").DisplayIndex = 2
                        DG_ProductosD.Columns("CostoD").DisplayIndex = 3
                        DG_ProductosD.Columns("MontoD").DisplayIndex = 4
                        DG_ProductosD.Refresh()
                    End If

                    'Total gastado en Productos.
                    lbl_MontoTotal2.Text = Format(CType(PrecioTotal, Decimal), "###0.00")

                    'hago foco en el tabDetalle 
                    TabStock.SelectedTab = TabStock.TabPages("TabDetalle")
                End If
            End If

            'Cambio el cursor a NORMAL.
            TabStock.Cursor = Cursors.Arrow
        Catch ex As Exception
            TabStock.Cursor = Cursors.Arrow
            MessageBox.Show("No se pudo recuperar el pedido seleccionado.", "Ingreso de Mercadería", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Sub EvaluarPermisos()
        If (VariablesGlobales.Patentes.ContainsKey(Entidades.TipoPatente.Administración_Stock_IngresoMercadería_Ingreso)) Then

        Else
            TabStock.TabPages.Remove(TabStock.TabPages("TabAlta"))
        End If

        If (VariablesGlobales.Patentes.ContainsKey(Entidades.TipoPatente.Administración_Stock_IngresoMercadería_Modificar)) Then

        Else
            TabStock.TabPages.Remove(TabStock.TabPages("TabDetalle"))
            RemoveHandler DG_Stock.CellDoubleClick, AddressOf DG_Stock_CellDoubleClick
        End If
    End Sub

    Private Sub txt_Cantidad_KeyDown(sender As Object, e As KeyEventArgs) Handles txt_Cantidad.KeyDown
        If e.KeyData = Keys.Enter Then
            AgregarProducto()
        End If
    End Sub

    Private Sub txt_Codigo_KeyDown(sender As Object, e As KeyEventArgs) Handles txt_Codigo.KeyDown
        If e.KeyData = Keys.Enter Then
            Me.Cursor = Cursors.WaitCursor
            BuscarProducto()
            Me.Cursor = Cursors.Arrow
        End If
    End Sub

    Private Function BuscarProducto() As Integer
        Dim dr As DataRow = dtProductos.Rows.Cast(Of DataRow).Where(Function(x) x.Item("Nombre").ToString().ToUpper() = txt_Codigo.Text.ToUpper() Or x.Item("Codigo").ToString().ToUpper() = txt_Codigo.Text.ToUpper()).FirstOrDefault()
        If (dr IsNot Nothing) Then
            'Obtengo el producto
            ObtenerProducto(dr("Id_Producto"))
            Return dr("Id_Producto")
        Else
            MessageBox.Show("El código o nombre del producto no existe.", "Ingreso de Mercadería", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return 0
        End If
    End Function

    Private Sub Cb_Proveedor_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Cb_Proveedor.SelectedIndexChanged
        If (Cb_Proveedor.SelectedValue > 0) Then
            If (DG_Mercaderia.RowCount > 0 AndAlso MessageBox.Show("Se encuentran registros de mercaderías pendientes por ser finalizados. En caso de cambiar de proveedor los registros actuales se perderá. ¿Desea cambiar de proveedor y perder los registros?", "Ingreso de Mercadería", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = DialogResult.Yes) Then
                LimpiarFormAgregarStock()
                DG_Mercaderia.Rows.Clear()
                DG_Mercaderia.Update()
            End If

            Me.Cursor = Cursors.WaitCursor

            Gb_Producto.Visible = True
            Gb_Stock.Visible = True

            If (Cb_Proveedor.SelectedIndex = 0) Then
                'Obtengo el listado de productos
                dtProductos = NegProducto.ListadoProductosBuscadores().Tables(0)
            Else
                'Obtengo el listado de productos segun el proveedor
                dtProductos = NegProducto.ListadoProductosPorProveedor(Cb_Proveedor.SelectedValue).Tables(0)
            End If

            'Armo una lista que contiene los nombres y codigos de todos los producto
            Dim listaNombreCodigoProductos As AutoCompleteStringCollection = New AutoCompleteStringCollection()

            listaNombreCodigoProductos.AddRange(dtProductos.Rows.Cast(Of DataRow).Select(Function(x) x.Item("Nombre").ToString).ToArray())
            listaNombreCodigoProductos.AddRange(dtProductos.Rows.Cast(Of DataRow).Select(Function(x) x.Item("Codigo").ToString).ToArray())

            txt_Codigo.AutoCompleteCustomSource = listaNombreCodigoProductos

            Me.Cursor = Cursors.Arrow
        End If
    End Sub
#End Region

End Class

