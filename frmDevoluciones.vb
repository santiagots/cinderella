Imports Entidades
Imports Entidades.ClienteMayorista

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
    Dim dsProductos As DataSet
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

        'Agrego los Encagados a la lista de vendedores ya que un encargado puede participar de la venta como vendedor
        DsVendedores.Tables(0).Merge(DsEncargados.Tables(0))

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

        'Obtengo el listado de productos
        dsProductos = NegProductos.ListadoProductosBuscadores()

        'Armo una lista que contiene los nombres y codigos de todos los producto
        Dim listaNombreCodigoProductos As AutoCompleteStringCollection = New AutoCompleteStringCollection()

        listaNombreCodigoProductos.AddRange(dsProductos.Tables(0).Rows.Cast(Of DataRow).Select(Function(x) x.Item("Nombre").ToString).ToArray())
        listaNombreCodigoProductos.AddRange(dsProductos.Tables(0).Rows.Cast(Of DataRow).Select(Function(x) x.Item("Codigo").ToString).ToArray())

        txt_CodigoBarra.AutoCompleteCustomSource = listaNombreCodigoProductos

        PanelTotalMayorista.Location = PanelTotalMinorista.Location

        'Cambio el cursor a NORMAL.
        Me.Cursor = Cursors.Arrow
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
        Dim Descuento As Double = 0 'Descuento ingresado.
        Dim MontoTotalSinDescuento As Double = 0 'Monto total de la venta.
        Dim MontoTotal As Double = 0 'Monto total de la venta menos el descuento.
        Dim CantidadTotal As Integer = CalcularCantidadTotal() 'Cantidad total de articulos.
        Dim Monto As Double = 0 'Será el monto que le corresponda al empleado dependiendo de la comision y el MontoTotal.
        Dim Comision As Double = 0 'Será la comision del empleado, determinada por la sucursal y el dia de la semana.
        Dim TipoPagoControlador As String = "" 'Variable que se imprime en el tique fiscal.
        Dim IvaTotal As Double = 0 'Iva total de la vental

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
                            MontoTotalSinDescuento = CType(txt_SubtotalMinorista.Text, Decimal)
                            Descuento = CType(txt_DescuentoMinorista.Text, Decimal)
                            MontoTotal = CType(txt_TotalMinorista.Text, Decimal)
                        Else
                            TipoVenta = 2
                            Descuento = CType(txt_DescuentoMayorista.Text, Decimal)
                            MontoTotalSinDescuento = CType(txt_SubtotalMayorista.Text, Decimal)
                            IvaTotal = CType(txt_ivaTotalMayorista.Text, Decimal)
                            MontoTotal = CType(txt_TotalMayorista.Text, Decimal)
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
                            EntDevolucionDetalle.Precio = CDbl(DG_Productos.Rows(i).Cells.Item("MONTO").Value)
                            EntDevolucion.Detalle.Add(EntDevolucionDetalle)
                        Next

                        Dim idDevolucion As String = NegDevolucion.NuevaDevolucion(EntDevolucion)
                        If (idDevolucion = "0") Then
                            Me.Cursor = Cursors.Arrow
                            MessageBox.Show("Se ha producido un error al registrar la devolución. Por favor, Comuniquese con el administrador.", "Administración de Devoluciones", MessageBoxButtons.OK, MessageBoxIcon.Error)
                            Return
                        End If

                        'cursor..
                        Me.Cursor = Cursors.Arrow

                        'Muestro el mensaje de ok.
                        If (MessageBox.Show("Se ha realizado la devolución correctamente.", "Administración de Devoluciones", MessageBoxButtons.OK, MessageBoxIcon.Information) = vbOK) Then


                            'Si el total es mayor que cero y no supera el monto maximo para la generacion de notas de credito.
                            If MontoTotal <= 0 And CDbl(MontoTotal) > CDbl(My.Settings("MontoMaximoNotaCredito")) Then
                                MessageBox.Show("La devolución excede el máximo permitido para la generación de notas de crédito. El pedido no podrá ser generado.", "Administración de Devoluciones", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                            Else
                                Facturar = True
                            End If

                            'Si hay que facturar, muestro  un mensaje que se va a llevar a cabo dicha factura y abro el form.
                            If Facturar Then
                                If (MessageBox.Show("¿Desea generar nota de crédito?", "Administración de Devoluciones", MessageBoxButtons.YesNo, MessageBoxIcon.Information) = vbYes) Then

                                    'Seteo el cursor.
                                    Me.Cursor = Cursors.WaitCursor

                                    'Abro el form de datos de facturacion.
                                    Dim frmNotaCredito As frmNotaCredito = New frmNotaCredito()
                                    frmNotaCredito.id_Devolucion = Integer.Parse(idDevolucion)
                                    frmNotaCredito.Monto = MontoTotal
                                    frmNotaCredito.Descuento = Descuento
                                    frmNotaCredito.IvaTotal = IvaTotal
                                    frmNotaCredito.SubTotal = MontoTotalSinDescuento
                                    frmNotaCredito.TipoPago = TipoPagoControlador
                                    frmNotaCredito.TipoCliente = If(cb_Tipo.SelectedItem = "Minorista", TipoCliente.Minorista, TipoCliente.Mayorista)
                                    frmNotaCredito.ShowDialog()

                                    'Seteo el cursor.
                                    Me.Cursor = Cursors.Arrow

                                End If

                                'Cierro el form.
                                Me.Dispose()
                                Me.Close()
                            End If
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
            'Actualizo el campo SUBTOTAL del producto segun el tipo de cliente
            If cb_Tipo.SelectedItem = "Minorista" Then
                DG_Productos("SUBTOTAL", e.RowIndex).Value = DG_Productos(e.ColumnIndex, e.RowIndex).Value.ToString() * DG_Productos("MONTO", e.RowIndex).Value.ToString()
            Else
                DG_Productos("SUBTOTAL", e.RowIndex).Value = DG_Productos(e.ColumnIndex, e.RowIndex).Value.ToString() * DG_Productos("PRECIO", e.RowIndex).Value.ToString()
            End If
            'Recalculo el Total y lo muestro en el label
            CalcularPreciosDescuento()

        ElseIf DG_Productos.Columns(e.ColumnIndex).Name = "PRECIO" Then

            'Si el monto ingresado es mayor que cero.
            If DG_Productos(e.ColumnIndex, e.RowIndex).Value >= 0 Then
                'Actualizo el campo SUBTOTAL del producto.
                DG_Productos(e.ColumnIndex, e.RowIndex).Value = Format(CType(DG_Productos(e.ColumnIndex, e.RowIndex).Value, Decimal), "###0.00")
                ActualizarColumnaIvaMonto(e, CType(DG_Productos(e.ColumnIndex, e.RowIndex).Value, Decimal))
                'Recalculo el Total, descuento y subtotal: lo muestro en el label
                CalcularPreciosDescuento()
            Else
                DG_Productos(e.ColumnIndex, e.RowIndex).Value = Format(CType((DG_Productos("SUBTOTAL", e.RowIndex).Value / DG_Productos("CANTIDAD", e.RowIndex).Value), Decimal), "###0.00")
            End If

            Dim newStyle As New DataGridViewCellStyle
            newStyle.Format = "C"
            DG_Productos.Item(e.ColumnIndex, e.RowIndex).Style.ApplyStyle(newStyle)

        ElseIf DG_Productos.Columns(e.ColumnIndex).Name = "MONTO" Then

            'Si el monto ingresado es mayor que cero.
            If DG_Productos(e.ColumnIndex, e.RowIndex).Value >= 0 Then
                'Actualizo el campo SUBTOTAL del producto.
                DG_Productos(e.ColumnIndex, e.RowIndex).Value = Format(CType(DG_Productos(e.ColumnIndex, e.RowIndex).Value, Decimal), "###0.00")
                DG_Productos("SUBTOTAL", e.RowIndex).Value = DG_Productos("MONTO", e.RowIndex).Value * DG_Productos("CANTIDAD", e.RowIndex).Value
                'Recalculo el Total, descuento y subtotal: lo muestro en el label
                CalcularPreciosDescuento()
            Else
                DG_Productos(e.ColumnIndex, e.RowIndex).Value = Format(CType((DG_Productos("SUBTOTAL", e.RowIndex).Value / DG_Productos("CANTIDAD", e.RowIndex).Value), Decimal), "###0.00")
            End If
        End If
    End Sub

    Private Sub ActualizarColumnaIvaMonto(e As DataGridViewCellEventArgs, precio As Double)
        If (Cb_ListaPrecio.SelectedValue = 5) Then 'MayoristaSinFactura
            DG_Productos("IVA", e.RowIndex).Value = 0
            DG_Productos("MONTO", e.RowIndex).Value = precio
            DG_Productos("SUBTOTAL", e.RowIndex).Value = DG_Productos("MONTO", e.RowIndex).Value * DG_Productos("CANTIDAD", e.RowIndex).Value
        Else
            DG_Productos("IVA", e.RowIndex).Value = precio * 0.21
            DG_Productos("MONTO", e.RowIndex).Value = precio * 1.21
            DG_Productos("SUBTOTAL", e.RowIndex).Value = DG_Productos("MONTO", e.RowIndex).Value * DG_Productos("CANTIDAD", e.RowIndex).Value
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
    Private Sub Btn_Agregar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_Agregar.Click
        Me.Cursor = Cursors.WaitCursor
        BuscarProducto()
        Me.Cursor = Cursors.Arrow
    End Sub

    'Si desea buscar un cliente mayorista se visualiza el formulario.
    Private Sub Btn_BuscarCliente_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_BuscarCliente.Click
        Me.Cursor = Cursors.WaitCursor
        Dim frmBuscarClienteMayorista As frmBuscarClienteMayorista = New frmBuscarClienteMayorista()
        frmBuscarClienteMayorista.ShowDialog()


        If frmBuscarClienteMayorista.clienteMayorista IsNot Nothing Then
            txt_id_Cliente.Clear()
            txt_RazonSocial.Clear()
            LimpiarFormDevolucion_2()
            txt_id_Cliente.Text = frmBuscarClienteMayorista.clienteMayorista.Id
            txt_RazonSocial.Text = frmBuscarClienteMayorista.clienteMayorista.RazonSocial
            Cb_ListaPrecio.SelectedValue = frmBuscarClienteMayorista.clienteMayorista.IdListaPrecio
        End If
        Me.Cursor = Cursors.Arrow
    End Sub

    Private Sub txt_Descuento_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txt_DescuentoMinorista.GotFocus
        txt_DescuentoMinorista.Clear()
    End Sub

    Private Sub txt_Descuento_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txt_DescuentoMinorista.LostFocus
        If txt_DescuentoMinorista.Text.Trim = "" Then
            txt_DescuentoMinorista.Text = "0,00"
        End If
        CalcularPreciosDescuento()
    End Sub

    Private Sub txt_Descuento_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_DescuentoMinorista.KeyPress
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

    Private Sub txt_DescuentoMayorista_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txt_DescuentoMayorista.GotFocus
        txt_DescuentoMayorista.Clear()
    End Sub

    Private Sub txt_DescuentoMayorista_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txt_DescuentoMayorista.LostFocus
        If txt_DescuentoMayorista.Text.Trim = "" Then
            txt_DescuentoMayorista.Text = "0,00"
        End If
        CalcularPreciosDescuento()
    End Sub

    Private Sub txt_DescuentoMayorista_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_DescuentoMayorista.KeyPress
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

            AgregarItemAGrilla(EntProducto, NumeroFila, 1, Precio)

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

    Private Sub AgregarItemAGrilla(EntProducto As Productos, NumeroFila As Integer, cantidad As Integer, Precio As Double)

        If cb_Tipo.SelectedItem = "Minorista" Then
            AgregarFila(EntProducto, NumeroFila, cantidad, 0, 0, Precio)
        Else
            If (Cb_ListaPrecio.SelectedValue = 5) Then 'MayoristaSinFactura
                AgregarFila(EntProducto, NumeroFila, cantidad, Precio, 0, Precio)
            Else
                AgregarFila(EntProducto, NumeroFila, cantidad, Precio / 1.21, (Precio / 1.21) * 0.21, Precio)
            End If
        End If
    End Sub

    Private Sub AgregarFila(EntProducto As Productos, NumeroFila As Integer, cantidad As Integer, Precio As Double, Iva As Double, Monto As Double)
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

        'Valor de la Columna Cantidad
        dgvCell = New DataGridViewTextBoxCell()
        dgvCell.Value = cantidad.ToString()
        dgvRow.Cells.Add(dgvCell)

        'Valor de la Columna Precio
        dgvCell = New DataGridViewTextBoxCell()
        dgvCell.Value = Precio
        dgvRow.Cells.Add(dgvCell)

        'Valor de la Columna IVA
        dgvCell = New DataGridViewTextBoxCell()
        dgvCell.Value = Iva
        dgvRow.Cells.Add(dgvCell)

        'Valor de la Columna MONTO
        dgvCell = New DataGridViewTextBoxCell()
        dgvCell.Value = Monto
        dgvRow.Cells.Add(dgvCell)

        'Valor de la Columna Subtotal
        dgvCell = New DataGridViewTextBoxCell()
        dgvCell.Value = Monto * cantidad
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

        dgvRow.DefaultCellStyle.BackColor = Color.White

        dgvRow.Height = "30"

        'Inserto la fila
        DG_Productos.Rows.Add(dgvRow)
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
        If cb_Tipo.SelectedItem = "Minorista" Then
            For i = 0 To (DG_Productos.Rows.Count - 1)
                subtotal += DG_Productos.Rows(i).Cells.Item("SUBTOTAL").Value
            Next
        Else
            For i = 0 To (DG_Productos.Rows.Count - 1)
                subtotal += DG_Productos.Rows(i).Cells.Item("PRECIO").Value * DG_Productos.Rows(i).Cells.Item("CANTIDAD").Value
            Next
        End If

        Return subtotal
    End Function

    'Funcion empleada para limpiar el formulario de devoluciones.
    Sub LimpiarFormDevoluciones()
        DG_Productos.Rows.Clear()
        txt_TotalMinorista.Text = "0,00"
        txt_SubtotalMinorista.Text = "0,00"
        txt_DescuentoMinorista.Text = "0,00"
        txt_TotalMayorista.Text = "0,00"
        txt_SubtotalMayorista.Text = "0,00"
        txt_DescuentoMayorista.Text = "0,00"
        txt_ivaTotalMayorista.Text = "0,00"
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
        txt_TotalMinorista.Text = "0,00"
        txt_SubtotalMinorista.Text = "0,00"
        txt_DescuentoMinorista.Text = "0,00"
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
            DG_Productos.Columns("MONTO").ReadOnly = True
            DG_Productos.Columns("PRECIO").ReadOnly = False
            DG_Productos.Columns("PRECIO").Visible = True
            DG_Productos.Columns("IVA").Visible = True
            PanelTotalMayorista.Visible = True
            PanelTotalMinorista.Visible = False
        Else
            'Minorista
            Gb_Cliente.Enabled = False
            txt_RazonSocial.Clear()
            txt_id_Cliente.Clear()
            'Cargo la lista de precios con las opciones minoristas configuradas para la sucursal
            dsListas = NegListasPrecio.ListadoPreciosPorGrupo(My.Settings("ListaPrecio"))
            DG_Productos.Columns("MONTO").ReadOnly = False
            DG_Productos.Columns("PRECIO").ReadOnly = True
            DG_Productos.Columns("PRECIO").Visible = False
            DG_Productos.Columns("IVA").Visible = False
            PanelTotalMayorista.Visible = False
            PanelTotalMinorista.Visible = True
        End If

        If dsListas.Tables(0).Rows.Count > 0 Then
            Cb_ListaPrecio.DataSource = Nothing
            Cb_ListaPrecio.DataSource = dsListas.Tables(0)
            Cb_ListaPrecio.DisplayMember = "ListaPrecio"
            Cb_ListaPrecio.ValueMember = "id_Lista"
            Cb_ListaPrecio.Refresh()
        End If

        PosicionarListaPreciosSegunFormaDePago()

    End Sub

    Private Sub txt_CodigoBarra_KeyDown(sender As Object, e As KeyEventArgs) Handles txt_CodigoBarra.KeyDown
        If e.KeyData = Keys.Enter Then
            Me.Cursor = Cursors.WaitCursor
            BuscarProducto()
            Me.Cursor = Cursors.Arrow
        End If
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

            ActualizarMontosProductos(Precio, row)
        Next
        'Actualizo los totales
        CalcularPreciosDescuento()
    End Sub

    Private Sub ActualizarMontosProductos(Precio As Double, row As DataGridViewRow)
        If cb_Tipo.SelectedItem = "Minorista" Then
            ActualizarMontosProductosMinoristas(Precio, row)
        Else
            If (Cb_ListaPrecio.SelectedValue = 5) Then 'MayoristaSinFactura
                ActualizarMontosProductosMayoristasSinFactura(Precio, row)
            Else
                ActualizarMontosProductosMayoristasConFactura(Precio, row)
            End If
        End If
    End Sub

    Private Shared Function ActualizarMontosProductosMayoristasConFactura(Precio As Double, row As DataGridViewRow)
        Dim esDevolucion As Boolean = row.Cells("PRECIO").Value < 0
        If esDevolucion Then
            row.Cells("PRECIO").Value = (Precio * -1) / 1.21
        Else
            row.Cells("PRECIO").Value = Precio / 1.21
        End If

        If esDevolucion Then
            row.Cells("IVA").Value = ((Precio * -1) / 1.21) * 0.21
        Else
            row.Cells("IVA").Value = (Precio / 1.21) * 0.21
        End If

        If esDevolucion Then
            row.Cells("MONTO").Value = (Precio * -1)
        Else
            row.Cells("MONTO").Value = Precio
        End If

        row.Cells("SUBTOTAL").Value = Precio * CDbl(row.Cells("CANTIDAD").Value)
        Return row
    End Function

    Private Shared Function ActualizarMontosProductosMayoristasSinFactura(Precio As Double, row As DataGridViewRow)
        Dim esDevolucion As Boolean = row.Cells("PRECIO").Value < 0
        If esDevolucion Then
            row.Cells("PRECIO").Value = (Precio * -1)
        Else
            row.Cells("PRECIO").Value = Precio
        End If

        If esDevolucion Then
            row.Cells("IVA").Value = 0
        Else
            row.Cells("IVA").Value = 0
        End If

        If esDevolucion Then
            row.Cells("MONTO").Value = (Precio * -1)
        Else
            row.Cells("MONTO").Value = Precio
        End If

        row.Cells("SUBTOTAL").Value = Precio * CDbl(row.Cells("CANTIDAD").Value)
        Return row
    End Function

    Private Shared Function ActualizarMontosProductosMinoristas(Precio As Double, row As DataGridViewRow)
        Dim esDevolucion As Boolean = row.Cells("PRECIO").Value < 0
        If esDevolucion Then
            row.Cells("PRECIO").Value = 0
        Else
            row.Cells("PRECIO").Value = 0
        End If

        If esDevolucion Then
            row.Cells("IVA").Value = 0
        Else
            row.Cells("IVA").Value = 0
        End If

        If esDevolucion Then
            row.Cells("MONTO").Value = (Precio * -1)
        Else
            row.Cells("MONTO").Value = Precio
        End If

        row.Cells("SUBTOTAL").Value = Precio * CDbl(row.Cells("CANTIDAD").Value)
        Return row
    End Function

    'Funcion que calcula el total con descuento
    Sub CalcularPreciosDescuento()
        Dim subtotal As Double = CalcularPrecioTotal()
        Dim descuento As Double = 0
        Dim ivaSubTotal As Double = 0

        If cb_Tipo.SelectedItem = "Minorista" Then
            CaluclarPrecioDescuentoMinorista(subtotal)
        Else
            If (Cb_ListaPrecio.SelectedValue = 5) Then 'MayoristaSinFactura
                CalcularPrecioDescuentoMayoristaSinFactura(subtotal)
            Else
                CalcularPrecioDescuentoMayoristaConFactura(subtotal)
            End If
        End If

        If subtotal <= 0 Then
            Btn_Finalizar.Visible = False
        Else
            Btn_Finalizar.Visible = True
        End If
    End Sub

    Private Sub CalcularPrecioDescuentoMayoristaConFactura(ByRef subtotal As Double)
        Dim descuento As Double = 0
        Dim ivaSubTotal As Double = 0

        If CDbl(txt_DescuentoMayorista.Text) < subtotal Then
            descuento = CType(txt_DescuentoMayorista.Text, Decimal)
            subtotal = subtotal - descuento
            ivaSubTotal = subtotal * 0.21

            txt_TotalMayorista.Text = Format(CType(subtotal + ivaSubTotal, Decimal), "###0.00")
        Else
            ivaSubTotal = subtotal * 0.21
            txt_TotalMayorista.Text = Format(CType(subtotal + ivaSubTotal, Decimal), "###0.00")
        End If

        txt_DescuentoMayorista.Text = Format(descuento, "###0.00")
        txt_SubtotalMayorista.Text = Format(CType(subtotal, Decimal), "###0.00")
        txt_ivaTotalMayorista.Text = Format(CType(ivaSubTotal, Decimal), "###0.00")
    End Sub

    Private Sub CalcularPrecioDescuentoMayoristaSinFactura(ByRef subtotal As Double)
        Dim descuento As Double = 0
        Dim ivaSubTotal As Double = 0

        If CDbl(txt_DescuentoMayorista.Text) < subtotal Then
            descuento = CType(txt_DescuentoMayorista.Text, Decimal)
            subtotal = subtotal - descuento

            txt_TotalMayorista.Text = Format(CType(subtotal, Decimal), "###0.00")
        Else
            txt_TotalMayorista.Text = Format(CType(subtotal, Decimal), "###0.00")
        End If

        txt_DescuentoMayorista.Text = Format(descuento, "###0.00")
        txt_SubtotalMayorista.Text = Format(CType(subtotal, Decimal), "###0.00")
        txt_ivaTotalMayorista.Text = Format(CType(ivaSubTotal, Decimal), "###0.00")
    End Sub

    Private Sub CaluclarPrecioDescuentoMinorista(subtotal As Double)
        Dim descuento As Double = 0

        If CDbl(txt_DescuentoMinorista.Text) < subtotal Then
            descuento = CType(txt_DescuentoMinorista.Text, Decimal)
            txt_TotalMinorista.Text = Format(CType(subtotal - descuento, Decimal), "###0.00")
        Else
            txt_TotalMinorista.Text = Format(CType(subtotal, Decimal), "###0.00")
        End If
        txt_DescuentoMinorista.Text = Format(descuento, "###0.00")
        txt_SubtotalMinorista.Text = Format(CType(subtotal, Decimal), "###0.00")
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

    Private Sub BuscarProducto()
        Dim dr As DataRow = dsProductos.Tables(0).Rows.Cast(Of DataRow).Where(Function(x) x.Item("Nombre").ToString().ToUpper() = txt_CodigoBarra.Text.ToUpper() Or x.Item("Codigo").ToString().ToUpper() = txt_CodigoBarra.Text.ToUpper()).FirstOrDefault()
        If (dr IsNot Nothing) Then
            AgregarItem(dr(3), 1)
        Else
            MessageBox.Show("El código o nombre de producto no existe. Por favor verifique la información ingresada sea la correcta.", "Registro de Ventas", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub



#End Region
End Class