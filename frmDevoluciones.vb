Public Class frmDevoluciones
    'Instancias
    Dim NegProductos As New Negocio.NegProductos
    Dim NegEmpleados As New Negocio.NegEmpleados
    Dim NegTiposPagos As New Negocio.NegTipoPago
    Dim NegVentas As New Negocio.NegVentas
    Dim NegStock As New Negocio.NegStock
    Dim NegComisiones As New Negocio.NegComisiones
    Dim NegMensajes As New Negocio.NegMensajes
    Dim NegErrores As New Negocio.NegManejadorErrores
    Dim EntProducto As New Entidades.Productos
    Dim NegListasPrecio As New Negocio.NegListasPrecio
    Dim NegDevolucion As New Negocio.NegDevolucion
    Dim EntDevolucion As New Entidades.Devolucion
    Dim Funciones As New Funciones
    Dim EMovEgreso As New Entidades.MovEgreso
    Dim NegMovimientos As New Negocio.NegMovimientos
    Dim id_Sucursal As Integer
    Dim Nombre_Sucursal As String

#Region "Eventos del formulario"
    'Load del formulario.
    Private Sub frmCambios_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Cambio el cursor a "WAIT"
        Me.Cursor = Cursors.WaitCursor

        'Seteo la fecha
        lbl_Fecha.Text = Now.Date.ToString("d MMM yyyy")

        'Pongo el combo en minorista y deshabilito la opcion de clientes.
        cb_Tipo.SelectedIndex = 0
        Gb_Cliente.Enabled = False

        'Sucursal default
        id_Sucursal = My.Settings("Sucursal")
        Nombre_Sucursal = My.Settings("NombreSucursal")

        'Seteo el nombre de la sucursal
        lbl_Sucursal.Text = Nombre_Sucursal

        'Oculto Columnas en el DG_Productos
        DG_Productos.Columns("Numero").Visible = False
        DG_Productos.Columns("ID").Visible = False

        'Cargo el Combo de Encargados
        Dim DsEncargados As New DataSet
        DsEncargados = NegEmpleados.ListadoEncargadosSucursal(id_Sucursal)

        If DsEncargados.Tables(0).Rows.Count > 0 Then
            Cb_Encargados.DataSource = Nothing
            Cb_Encargados.DataSource = Funciones.CrearDataTable("id_Empleado", "NombreCompleto", DsEncargados, "Seleccione un encargado...")
            Cb_Encargados.DisplayMember = "NombreCompleto"
            Cb_Encargados.ValueMember = "id_Empleado"
            Cb_Encargados.SelectedValue = 0
            Cb_Encargados.Refresh()
        Else
            Cb_Encargados.Items.Add("No hay encargados disponibles.")
            Cb_Encargados.SelectedItem = "No hay encargados disponibles."
        End If

        'Cargo el Combo de vendedores
        Dim DsVendedores As New DataSet
        DsVendedores = NegEmpleados.ListadoVendedoresSucursal(id_Sucursal)

        If DsVendedores.Tables(0).Rows.Count > 0 Then
            Cb_Vendedores.DataSource = Nothing
            Cb_Vendedores.DataSource = Funciones.CrearDataTable("id_Empleado", "NombreCompleto", DsVendedores, "Seleccione un vendedor...")
            Cb_Vendedores.DisplayMember = "NombreCompleto"
            Cb_Vendedores.ValueMember = "id_Empleado"
            Cb_Vendedores.SelectedValue = 0
            Cb_Vendedores.Refresh()
        Else
            Cb_Vendedores.Items.Add("No hay vendedores disponibles.")
            Cb_Vendedores.SelectedItem = "No hay vendedores disponibles."
        End If

        'Cargo el Combo de Tipos de Pago
        Dim DsTiposPagos As New DataSet
        DsTiposPagos = NegTiposPagos.ListadoTiposPagos

        If DsTiposPagos.Tables(0).Rows.Count > 0 Then
            Cb_TipoPago.DataSource = Nothing
            Cb_TipoPago.DataSource = Funciones.CrearDataTable("id_TipoPago", "Descripcion", DsTiposPagos, "Seleccione un tipo de pago...")
            Cb_TipoPago.DisplayMember = "Descripcion"
            Cb_TipoPago.ValueMember = "id_TipoPago"
            Cb_TipoPago.SelectedValue = 0
            Cb_TipoPago.Refresh()
        End If

        'Cargo el combo de Lista de precios para un cliente minorista
        Dim dsListaPrecio As DataSet = NegListasPrecio.ListadoPreciosPorGrupo(My.Settings("ListaPrecio"))
        If dsListaPrecio.Tables(0).Rows.Count > 0 Then
            Cb_ListaPrecio.DataSource = Nothing
            Cb_ListaPrecio.DataSource = dsListaPrecio.Tables(0)
            Cb_ListaPrecio.DisplayMember = "ListaPrecio"
            Cb_ListaPrecio.ValueMember = "id_Lista"
            Cb_ListaPrecio.Refresh()
        End If

        'Borro el textbox
        txt_CodigoBarra.Clear()
        txt_CodigoBarra.Focus()

        'Cambio el cursor a NORMAL.
        Me.Cursor = Cursors.Arrow
    End Sub

    'Evento que se ejecuta al ingresar valores en el textbox de codigo de barra.
    Private Sub txt_CodigoBarra_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_CodigoBarra.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            Dim CodigoBarra As String = Trim(txt_CodigoBarra.Text)
            If CodigoBarra <> "" Then 'Si el campo no está vacio.
                If CodigoBarra.Length > 1 And CodigoBarra.Length < 13 Then 'Si es codigo de producto.
                    AgregarItem(CodigoBarra, 3)
                ElseIf CodigoBarra.Length >= 13 And IsNumeric(CodigoBarra) Then 'Si es codigo de barra.
                    AgregarItem(CodigoBarra, 2)
                ElseIf CodigoBarra.Length >= 13 Then 'Si es codigo de barra.
                    txt_CodigoBarra.Clear()
                    txt_CodigoBarra.Focus()
                End If

            Else 'si el campo está vacio.
                txt_CodigoBarra.Focus()
                MessageBox.Show("Ingrese un código de barra o un código de producto.", "Administración de Devoluciones", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            End If
        End If
    End Sub

    'Evento que se ejecuta cuando finaliza la devolucion.
    Private Sub Btn_Finalizar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_Finalizar.Click
        Dim TotalMonto As Double = CalcularPrecioTotal()
        Dim id_Producto As Integer = 0

        'Obtengo toda la informacion.
        Dim TotalProductos As Integer = DG_Productos.Rows.Count 'Total de productos cargados.
        Dim TipoVenta As Integer = 0 'Tipo de Venta.
        Dim TipoPago As Integer = Cb_TipoPago.SelectedValue 'Tipo de Pago.
        Dim id_Empleado As Integer = Cb_Vendedores.SelectedValue 'ID de Vendedor.
        Dim id_Encargado As Integer = Cb_Encargados.SelectedValue 'ID de Encargado.
        Dim id_Cliente As Integer = 0 'ID de Cliente.
        Dim Facturar As Boolean = False 'Variable que indica si la venta ´facturará o no.
        Dim Descuento As Double = txt_Descuento.Text.Trim 'Descuento ingresado.
        Dim MontoTotalSinDescuento As Double = CalcularPrecioTotal() 'Monto total de la venta.
        Dim MontoTotal As Double = MontoTotalSinDescuento + Descuento  'Monto total de la venta menos el descuento.
        Dim CantidadTotal As Integer = CalcularCantidadTotal() 'Cantidad total de articulos.
        Dim Monto As Double = 0 'Será el monto que le corresponda al empleado dependiendo de la comision y el MontoTotal.
        Dim Comision As Double = 0 'Será la comision del empleado, determinada por la sucursal y el dia de la semana.
        Dim PosibilidadDeFacturar As String = My.Settings("ControladorStatus") 'Variable de configuración que indica si la sucursal puede facturar o no.
        Dim TipoPagoControlador As String = "" 'Variable que se imprime en el tique fiscal.

        'Chequeo que haya al menos un producto cargado.
        If TotalProductos <= 0 Then
            'Muestro Mensaje.
            MessageBox.Show("La devolución no puede efectuarse. No hay productos cargados !!", "Administración de Devoluciones", MessageBoxButtons.OK, MessageBoxIcon.Stop)
        Else
            'Tiene al menos un producto.
            'Chequeo que haya asignado al menos un vendedor a la Devoluciones.
            If Cb_Vendedores.SelectedValue <= 0 Then
                'Muestro Mensaje.
                MessageBox.Show("La devolución no puede efectuarse. Debe seleccionar un vendedor responsable de la devoluciones.", "Administración de Devoluciones", MessageBoxButtons.OK, MessageBoxIcon.Stop)
            ElseIf Cb_Encargados.SelectedValue <= 0 Then
                'Muestro Mensaje.
                MessageBox.Show("La devolución no puede efectuarse. Debe seleccionar un encargado responsable de la devoluciones.", "Administración de Devoluciones", MessageBoxButtons.OK, MessageBoxIcon.Stop)
            ElseIf Cb_TipoPago.SelectedValue <= 0 Then
                'Muestro Mensaje.
                MessageBox.Show("La devolución no puede efectuarse. Debe seleccionar un tipo de pago a la devoluciones.", "Administración de Devoluciones", MessageBoxButtons.OK, MessageBoxIcon.Stop)
            Else
                'Si confirma la devolución.
                If MessageBox.Show("¿Ésta seguro que desea efectuar la devolución?", "Administración de Devoluciones", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = vbYes Then
                    Try
                        'cursor..
                        Me.Cursor = Cursors.WaitCursor

                        'Agrego el stock del producto en la sucursal.
                        For i = 0 To DG_Productos.Rows.Count - 1
                            id_Producto = CInt(DG_Productos.Rows(i).Cells.Item("ID").Value)
                            NegStock.AgregarStock(id_Producto, id_Sucursal, CInt(DG_Productos.Rows(i).Cells.Item("CANTIDAD").Value))
                        Next

                        'Seteo Tipo de Pago para la controladora fiscal
                        If TipoPago = 1 Then
                            TipoPagoControlador = "EFECTIVO"
                        ElseIf TipoPago = 2 Then
                            TipoPagoControlador = "CREDITO"
                        ElseIf TipoPago = 3 Then
                            TipoPagoControlador = "DEBITO"
                        Else
                            TipoPagoControlador = "CHEQUE"
                        End If

                        'Seteo TipoVenta
                        If cb_Tipo.SelectedItem = "Minorista" Then
                            TipoVenta = 1
                        Else
                            TipoVenta = 2
                        End If

                        'Seteo ID Cliente
                        If txt_id_Cliente.Text = "" Then
                            id_Cliente = 0
                        Else
                            id_Cliente = CInt(txt_id_Cliente.Text)
                        End If

                        EntDevolucion.id_Cliente = id_Cliente
                        EntDevolucion.id_Empleado = id_Empleado
                        EntDevolucion.id_Encargado = id_Encargado
                        EntDevolucion.id_Sucursal = id_Sucursal
                        EntDevolucion.id_TipoPago = TipoPago
                        EntDevolucion.id_TipoDevolucion = TipoVenta
                        EntDevolucion.CantidadTotal = CantidadTotal
                        EntDevolucion.Descuento = Descuento
                        EntDevolucion.SubTotal = MontoTotalSinDescuento
                        EntDevolucion.PrecioTotal = MontoTotal
                        EntDevolucion.Habilitado = 1
                        EntDevolucion.NotaCredito = 0
                        EntDevolucion.Detalle = New List(Of Entidades.Devolucion_Detalle)

                        For i = 0 To DG_Productos.Rows.Count - 1
                                'Creo un nuevo detalle, lleno el objeto e inserto en la bdd.
                            Dim EntDevolucionDetalle As New Entidades.Devolucion_Detalle
                            EntDevolucionDetalle.id_Detalle = 0
                            EntDevolucionDetalle.id_Producto = CInt(DG_Productos.Rows(i).Cells.Item("ID").Value)
                            EntDevolucionDetalle.Cantidad = CInt(DG_Productos.Rows(i).Cells.Item("CANTIDAD").Value)
                            EntDevolucionDetalle.Precio = CDbl(DG_Productos.Rows(i).Cells.Item("PRECIO").Value)
                            EntDevolucion.Detalle.Add(EntDevolucionDetalle)
                        Next

                        NegDevolucion.NuevaDevolucion(EntDevolucion)

                        'Se registra el movimiento de salida de dinero en la sucursal.
                        'TODO:Ver que hacer con el registro de las devoluciones como egresos
                        EMovEgreso.Aceptado = 1
                        EMovEgreso.Fecha = Now.ToString 'fecha actual.
                        EMovEgreso.id_Sucursal = id_Sucursal 'Sucursal donde se realiza la devolución.
                        EMovEgreso.id_SucursalDestino = id_Sucursal 'Sucursal donde se realiza la devolución.
                        EMovEgreso.Descripcion = "Egreso de dinero por devolución de mercaderia." 'descripcion del movimiento
                        EMovEgreso.Monto = TotalMonto 'Monto devuelto por los productos que ingresaron.
                        EMovEgreso.id_Tipo = 16 'Tipo: Efectivo.
                        EMovEgreso.id_Subtipo = 0 'No posee subtipo.
                        NegMovimientos.AltaMovEgreso(EMovEgreso)

                        'Limpio el form
                        LimpiarFormDevoluciones()

                        'cursor..
                        Me.Cursor = Cursors.Arrow

                        'Muestro el mensaje de ok.
                        If (MessageBox.Show("Se ha realizado la devolución correctamente.", "Administración de Devoluciones", MessageBoxButtons.OK, MessageBoxIcon.Information) = vbOK) Then
                            'Cierro el form.
                            Me.Dispose()
                            Me.Close()
                        End If

                    Catch ex As Exception
                        'Muestro el mensaje de ok.
                        Me.Cursor = Cursors.Arrow
                        MessageBox.Show("Se ha producido un error al registrar la devolución. Por favor, Comuniquese con el administrador.", "Administración de Devoluciones", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End Try
                End If
            End If
        End If
    End Sub

    'Evento que se ejecuta cuando cancela la devolucion.
    Private Sub Btn_Cancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_Cancelar.Click
        If MessageBox.Show("Ésta seguro que desea cancelar la devolución?", "Administración de Devoluciones", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = vbYes Then
            'Limpio el Formulario.
            LimpiarFormDevoluciones()
        End If
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        lbl_Hora.Text = Date.Now.ToLongTimeString
    End Sub

    Private Sub DG_Productos_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DG_Productos.CellClick
        DG_Productos.EditMode = DataGridViewEditMode.EditProgrammatically
        DG_Productos.CurrentCell = DG_Productos.CurrentCell
        DG_Productos.BeginEdit(True)
    End Sub

    'Cuando realiza un click dentro del datagrid de productos.
    Private Sub DG_Productos_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DG_Productos.CellContentClick
        If DG_Productos.Columns(e.ColumnIndex).Name = "ELIMINAR" Then 'Si se hace click en el boton "eliminar" de la fila.
            Dim Result As DialogResult
            Result = MessageBox.Show("¿Está seguro que desea eliminar el item seleccionado?", "Administración de Devoluciones", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

            If Result = System.Windows.Forms.DialogResult.Yes Then 'Si acepta eliminar el item
                Dim id_Producto As Integer = DG_Productos.Rows(e.RowIndex).Cells("ID").Value
                If id_Producto = 0 Then
                    'si no completo la descripcion, muestro un msg de error.
                    MessageBox.Show("No se puede eliminar el item.", "Administración de Devoluciones", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Else
                    DG_Productos.Rows.RemoveAt(e.RowIndex) 'Elimino el item
                    CalcularPreciosDescuento() 'Recalculo el Total y lo muestro en el label
                    txt_CodigoBarra.Focus()

                    'refresco el datagrid
                    DG_Productos.Refresh()
                End If
            End If
        End If
    End Sub

    'Programo para cuando modifica la cantidad de un producto se actualice el grid.
    Private Sub DG_Productos_CellEndEdit(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DG_Productos.CellEndEdit
        If DG_Productos.Columns(e.ColumnIndex).Name = "CANTIDAD" Then 'Si se modifica la cantidad de un producto
            'Actualizo el campo SUBTOTAL del producto.
            DG_Productos("SUBTOTAL", e.RowIndex).Value = DG_Productos(e.ColumnIndex, e.RowIndex).Value.ToString() * DG_Productos("PRECIO", e.RowIndex).Value.ToString()
            'Recalculo el Total y lo muestro en el label
            CalcularPreciosDescuento()

        ElseIf DG_Productos.Columns(e.ColumnIndex).Name = "PRECIO" Then

            'Si el monto ingresado es mayor que cero.
            If DG_Productos(e.ColumnIndex, e.RowIndex).Value >= 0 Then
                'Actualizo el campo SUBTOTAL del producto.
                DG_Productos(e.ColumnIndex, e.RowIndex).Value = Format(CType(DG_Productos(e.ColumnIndex, e.RowIndex).Value, Decimal), "###0.00")
                DG_Productos("SUBTOTAL", e.RowIndex).Value = DG_Productos(e.ColumnIndex, e.RowIndex).Value.ToString() * DG_Productos("CANTIDAD", e.RowIndex).Value.ToString()
                'Recalculo el Total, descuento y subtotal: lo muestro en el label
                CalcularPreciosDescuento()
            Else
                DG_Productos(e.ColumnIndex, e.RowIndex).Value = Format(CType((DG_Productos("SUBTOTAL", e.RowIndex).Value / DG_Productos("CANTIDAD", e.RowIndex).Value), Decimal), "###0.00")
            End If

            Dim newStyle As New DataGridViewCellStyle
            newStyle.Format = "C"
            DG_Productos.Item(e.ColumnIndex, e.RowIndex).Style.ApplyStyle(newStyle)
        End If
    End Sub

    Private Sub DG_Productos_CellFormatting(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellFormattingEventArgs) Handles DG_Productos.CellFormatting
        If Not IsNothing(e.Value) Then
            If IsNumeric(e.Value) Then
                e.Value = Format(CDbl(e.Value), e.CellStyle.Format)
            End If
        End If
    End Sub

    'Sobresalto la celda que se está editando.
    Private Sub DG_Productos_EditingControlShowing(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewEditingControlShowingEventArgs) Handles DG_Productos.EditingControlShowing
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

    'Abre la ventana de busqueda de productos.
    Private Sub Btn_Buscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_Buscar.Click
        Me.Cursor = Cursors.WaitCursor
        Funciones.ControlInstancia(frmBuscarProducto).Show()
        frmBuscarProducto.TipoForm = 2
        Me.Cursor = Cursors.Arrow
    End Sub

    'Si desea buscar un cliente mayorista se visualiza el formulario.
    Private Sub Btn_BuscarCliente_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_BuscarCliente.Click
        Me.Cursor = Cursors.WaitCursor
        Dim frmBuscarClienteMayorista As frmBuscarClienteMayorista = New frmBuscarClienteMayorista()
        frmBuscarClienteMayorista.ShowDialog()


        If frmBuscarClienteMayorista.idCliente <> "" And frmBuscarClienteMayorista.razonSocialCliente <> "" Then
            txt_id_Cliente.Clear()
            txt_RazonSocial.Clear()
            LimpiarFormDevolucion_2()
            txt_id_Cliente.Text = frmBuscarClienteMayorista.idCliente
            txt_RazonSocial.Text = frmBuscarClienteMayorista.razonSocialCliente
            Cb_ListaPrecio.SelectedValue = frmBuscarClienteMayorista.idListaPrecio
        End If
        Me.Cursor = Cursors.Arrow
    End Sub

    Private Sub txt_Descuento_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txt_Descuento.GotFocus
        txt_Descuento.Clear()
    End Sub

    Private Sub txt_Descuento_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_Descuento.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            e.Handled = True
            Btn_Finalizar.Focus()
        End If

        Dim KeyAscii As Short = CShort(Asc(e.KeyChar))
        KeyAscii = CShort(NegErrores.SoloCurrency(KeyAscii))
        If KeyAscii = 0 Then
            e.Handled = True
        End If

    End Sub

    Private Sub txt_Descuento_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txt_Descuento.LostFocus
        If txt_Descuento.Text.Trim = "" Then
            txt_Descuento.Text = "0,00"
        Else
            CalcularPreciosDescuento()
        End If
    End Sub

    Private Sub Cb_TipoPago_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Cb_TipoPago.SelectedIndexChanged
        PosicionarListaPreciosSegunFormaDePago()
    End Sub

#End Region

#Region "Funciones del formulario"
    'Funcion que agrega un nuevo item al DATAGRID - Tipo: 1-ID | 2-CODIGO DE BARRA
    Public Sub AgregarItem(ByVal Numero As String, ByVal Tipo As Integer)
        Try
            'Seteo el cursor.
            Me.Cursor = Cursors.WaitCursor

            'Declaracion de Variables
            Dim NumeroFila As Integer = 0
            Dim i As Integer
            Dim subtotal As Double = 0
            Dim Repetido As Boolean = False
            Dim CodigoBarras As String
            Dim id_Producto As Integer
            Dim Codigo As String = ""

            If Tipo = 1 Then 'Si manda el ID
                id_Producto = Numero
                EntProducto = NegProductos.TraerProducto(id_Producto) 'Traigo el producto.      
            ElseIf Tipo = 2 Then 'Si manda el CODIGO DE BARRA
                CodigoBarras = Numero
                EntProducto = NegProductos.TraerProductoPorCodBarra(CodigoBarras) 'Traigo el producto.      
            Else 'Si manda el CODIGO DE PRODUCTO
                Codigo = Numero
                EntProducto = NegProductos.TraerProductoPorCodigo(Codigo) 'Traigo el producto.      
            End If

            'Si no encuentra el producto, sale de la funcion.
            If EntProducto.id_Producto = 0 Then
                txt_CodigoBarra.Clear()
                txt_CodigoBarra.Focus()
                Me.Cursor = Cursors.Arrow
                MessageBox.Show("No se ha encontrado el producto. Por favor, intente nuevamente.", "Administración de Devoluciones", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Exit Sub
            End If

            'Me fijo si ya se encuentra agregado. Si está aumento su cantidad.
            For i = 0 To DG_Productos.Rows.Count - 1
                If DG_Productos.Rows(i).Cells.Item("ID").Value = EntProducto.id_Producto Then
                    DG_Productos.Rows(i).Cells.Item("CANTIDAD").Value += 1
                    DG_Productos.Rows(i).Cells.Item("SUBTOTAL").Value = (DG_Productos.Rows(i).Cells.Item("CANTIDAD").Value * DG_Productos.Rows(i).Cells.Item("PRECIO").Value)
                    CalcularPreciosDescuento()
                    txt_CodigoBarra.Clear()
                    txt_CodigoBarra.Focus()
                    Me.Cursor = Cursors.Arrow
                    Return
                End If
            Next

            'Depende de la lista de precios asignada, le asigno un determinado precio al producto.
            Dim Precio As Double = 0
            Select Case Cb_ListaPrecio.SelectedValue()
                Case "1"
                    Precio = EntProducto.Precio1
                Case "2"
                    Precio = EntProducto.Precio2
                Case "3"
                    Precio = EntProducto.Precio3
                Case "4"
                    Precio = EntProducto.Precio4
                Case "5"
                    Precio = EntProducto.Precio5
                Case "6"
                    Precio = EntProducto.Precio6
                Case Else
                    Precio = 0
            End Select

            'Si no estaba agregado y hay stock inserto una nueva fila.
            'NumeroFila = DG_Productos.Rows.Count + 1

            'Creo la fila del producto.
            Dim dgvRow As New DataGridViewRow
            Dim dgvCell As DataGridViewCell

            'Valor de la Columna Numero
            dgvCell = New DataGridViewTextBoxCell()
            dgvCell.Value = NumeroFila
            dgvRow.Cells.Add(dgvCell)

            'Valor de la Columna Id
            dgvCell = New DataGridViewTextBoxCell()
            dgvCell.Value = EntProducto.id_Producto
            dgvRow.Cells.Add(dgvCell)

            'Valor de la Columna Codigo
            dgvCell = New DataGridViewTextBoxCell()
            dgvCell.Value = EntProducto.Codigo
            dgvRow.Cells.Add(dgvCell)

            'Valor de la Columna Nombre
            dgvCell = New DataGridViewTextBoxCell()
            dgvCell.Value = EntProducto.Nombre
            dgvRow.Cells.Add(dgvCell)

            'Valor de la Columna Descripcion
            dgvCell = New DataGridViewTextBoxCell()
            If EntProducto.Descripcion <> "" Then
                dgvCell.Value = EntProducto.Descripcion
            Else
                dgvCell.Value = "- - -"
            End If
            dgvRow.Cells.Add(dgvCell)

            'Valor de la Columna Cantidad
            dgvCell = New DataGridViewTextBoxCell()
            dgvCell.Value = "1"
            dgvRow.Cells.Add(dgvCell)

            'Valor de la Columna Precio
            dgvCell = New DataGridViewTextBoxCell()
            dgvCell.Value = Precio
            dgvRow.Cells.Add(dgvCell)

            'Valor de la Columna Subtotal
            dgvCell = New DataGridViewTextBoxCell()
            dgvCell.Value = Precio
            dgvRow.Cells.Add(dgvCell)

            'Valor de la Columna Eliminar
            dgvCell = New DataGridViewImageCell()
            dgvCell.Value = My.Resources.Recursos.Boton_Eliminar
            dgvRow.Cells.Add(dgvCell)

            'Valor de la Columna Precio1
            dgvCell = New DataGridViewImageCell()
            dgvCell.Value = EntProducto.Precio1
            dgvRow.Cells.Add(dgvCell)

            'Valor de la Columna Precio2
            dgvCell = New DataGridViewImageCell()
            dgvCell.Value = EntProducto.Precio2
            dgvRow.Cells.Add(dgvCell)

            'Valor de la Columna Precio3
            dgvCell = New DataGridViewImageCell()
            dgvCell.Value = EntProducto.Precio3
            dgvRow.Cells.Add(dgvCell)

            'Valor de la Columna Precio4
            dgvCell = New DataGridViewImageCell()
            dgvCell.Value = EntProducto.Precio4
            dgvRow.Cells.Add(dgvCell)

            'Valor de la Columna Precio5
            dgvCell = New DataGridViewImageCell()
            dgvCell.Value = EntProducto.Precio5
            dgvRow.Cells.Add(dgvCell)

            'Valor de la Columna Precio6
            dgvCell = New DataGridViewImageCell()
            dgvCell.Value = EntProducto.Precio6
            dgvRow.Cells.Add(dgvCell)

            dgvRow.Height = "30"

            'Inserto la fila
            DG_Productos.Rows.Add(dgvRow)

            'Lo muestro en el label
            CalcularPreciosDescuento()

            'Borro el textbox
            txt_CodigoBarra.Clear()
            txt_CodigoBarra.Focus()

            'Seteo el cursor.
            Me.Cursor = Cursors.Arrow
        Catch ex As Exception
            Me.Cursor = Cursors.Arrow
            MessageBox.Show("Se ha producido un error al agregar el producto.", "Administración de Devoluciones", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    'Funcion que calcula la cantidad de productos del DATAGRID
    Function CalcularCantidadTotal()
        Dim cant As Integer
        For i = 0 To (DG_Productos.Rows.Count - 1)
            cant += CInt(DG_Productos.Rows(i).Cells.Item("CANTIDAD").Value)
        Next
        Return cant
    End Function
    'Funcion que calcula el total en pesos del DATAGRID
    Function CalcularPrecioTotal()
        Dim subtotal As Double
        For i = 0 To (DG_Productos.Rows.Count - 1)
            subtotal += (DG_Productos.Rows(i).Cells.Item("PRECIO").Value * DG_Productos.Rows(i).Cells.Item("CANTIDAD").Value)
        Next
        Return subtotal
    End Function

    'Funcion empleada para limpiar el formulario de devoluciones.
    Sub LimpiarFormDevoluciones()
        DG_Productos.Rows.Clear()
        txt_Total.Text = "0,00"
        txt_Subtotal.Text = "0,00"
        txt_Descuento.Text = "0,00"
        txt_CodigoBarra.Clear()
        txt_RazonSocial.Clear()
        txt_id_Cliente.Clear()
        cb_Tipo.SelectedIndex = Nothing
        Cb_TipoPago.SelectedItem = "Seleccione un tipo de pago..."
        Cb_Encargados.SelectedItem = "Seleccione un encargado..."
        Cb_Vendedores.SelectedItem = "Seleccione un vendedor..."
        Cb_ListaPrecio.SelectedIndex = Nothing
        txt_CodigoBarra.Focus()
    End Sub

    'Limpiar Formulario2
    Public Sub LimpiarFormDevolucion_2()
        DG_Productos.Rows.Clear()
        txt_Total.Text = "0,00"
        txt_Subtotal.Text = "0,00"
        txt_Descuento.Text = "0,00"
        Cb_ListaPrecio.SelectedIndex = Nothing
        txt_CodigoBarra.Clear()
        txt_CodigoBarra.Focus()
    End Sub

    'Dependiendo para que tipo de cliente es la devolucion, muestro o oculto el panel de clientes.
    Private Sub cb_Tipo_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cb_Tipo.SelectedIndexChanged

        Dim dsListas As DataSet
        'Mayorista
        If cb_Tipo.SelectedIndex = 1 Then
            Gb_Cliente.Enabled = True
            'Cargo la lista de precios con las opciones mayoristas
            dsListas = NegListasPrecio.ListadoPreciosPorGrupo(3)
        Else
            'Minorista
            Gb_Cliente.Enabled = False
            txt_RazonSocial.Clear()
            txt_id_Cliente.Clear()
            'Cargo la lista de precios con las opciones minoristas configuradas para la sucursal
            dsListas = NegListasPrecio.ListadoPreciosPorGrupo(My.Settings("ListaPrecio"))
        End If

        If dsListas.Tables(0).Rows.Count > 0 Then
            Cb_ListaPrecio.DataSource = Nothing
            Cb_ListaPrecio.DataSource = dsListas.Tables(0)
            Cb_ListaPrecio.DisplayMember = "ListaPrecio"
            Cb_ListaPrecio.ValueMember = "id_Lista"
            Cb_ListaPrecio.Refresh()
        End If

        LimpiarFormDevolucion_2()

        PosicionarListaPreciosSegunFormaDePago()
    End Sub

    Private Sub Cb_ListaPrecio_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Cb_ListaPrecio.SelectedIndexChanged
        Dim Precio As Double = 0
        For Each row As DataGridViewRow In DG_Productos.Rows
            'Actualizo el precio de cada item segun la nueva lista de precios seleccioanda
            Select Case Cb_ListaPrecio.SelectedValue()
                Case "1"
                    Precio = CDbl(row.Cells("Precio1").Value)
                Case "2"
                    Precio = CDbl(row.Cells("Precio2").Value)
                Case "3"
                    Precio = CDbl(row.Cells("Precio3").Value)
                Case "4"
                    Precio = CDbl(row.Cells("Precio4").Value)
                Case "5"
                    Precio = CDbl(row.Cells("Precio5").Value)
                Case "6"
                    Precio = CDbl(row.Cells("Precio6").Value)
            End Select

            Dim esDevolucion As Boolean = row.Cells("PRECIO").Value < 0
            If esDevolucion Then
                row.Cells("PRECIO").Value = Precio * -1
            Else
                row.Cells("PRECIO").Value = Precio
            End If

            row.Cells("SUBTOTAL").Value = Precio * CDbl(row.Cells("CANTIDAD").Value)
        Next
        'Actualizo los totales
        CalcularPreciosDescuento()
    End Sub

    'Funcion que calcula el total con descuento
    Sub CalcularPreciosDescuento()
        Dim total As Double = CalcularPrecioTotal()
        Dim total2 As Double = 0
        Dim descuento As Double = 0

        If CDbl(txt_Descuento.Text) < total Then
            If txt_Descuento.Text.Trim <> "" And txt_Descuento.Text.Trim <> "0,00" Then
                If txt_Descuento.Text < 0 Then
                    descuento = txt_Descuento.Text
                Else
                    descuento = txt_Descuento.Text * -1
                End If
                txt_Descuento.Text = Format(CType(descuento, Decimal), "###0.00")
            Else
                txt_Descuento.Text = Format(CType(descuento, Decimal), "###0.00")
            End If
            txt_Subtotal.Text = Format(CType(total, Decimal), "###0.00")
            total2 = total + CDbl(txt_Descuento.Text.Trim)
            txt_Total.Text = Format(CType(total2, Decimal), "###0.00")
        Else
            txt_Descuento.Text = Format(CType(descuento, Decimal), "###0.00")
            txt_Subtotal.Text = Format(CType(total, Decimal), "###0.00")
            txt_Total.Text = Format(CType(total, Decimal), "###0.00")
        End If

        If total <= 0 Then
            Btn_Finalizar.Visible = False
        Else
            Btn_Finalizar.Visible = True
        End If
    End Sub

    Private Sub PosicionarListaPreciosSegunFormaDePago()
        If cb_Tipo.SelectedItem = "Minorista" Then
            If Cb_TipoPago.Text = "Efectivo" Then
                Cb_ListaPrecio.SelectedIndex = Cb_ListaPrecio.FindString("Efectivo")
            Else
                Cb_ListaPrecio.SelectedIndex = Cb_ListaPrecio.FindString("Tarjeta")
            End If
        End If
    End Sub

#End Region
End Class