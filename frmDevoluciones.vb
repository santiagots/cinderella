Imports Entidades
Imports Entidades.ClienteMayorista
Imports Negocio

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
    Dim ProductoCantidadAnterior As Integer
    Dim PorcentajeFacturacionIngresado As Double = 100

#Region "Eventos del formulario"
    'Load del formulario.
    Private Sub frmCambios_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Cambio el cursor a "WAIT"
        Me.Cursor = Cursors.WaitCursor

        'Seteo la fecha
        lbl_Fecha.Text = Now.Date.ToString("d MMM yyyy")

        'Pongo el combo en minorista y deshabilito la opcion de clientes.
        cb_Tipo.SelectedIndex = 0

        'Sucursal default
        id_Sucursal = My.Settings("Sucursal")
        Nombre_Sucursal = My.Settings("NombreSucursal")

        'Seteo el nombre de la sucursal
        lbl_Sucursal.Text = Nombre_Sucursal

        'Oculto Columnas en el DG_Productos
        DG_Productos.Columns("Numero").Visible = False
        DG_Productos.Columns("ID").Visible = False

        Dim DsEncargados As DataSet = CargarComboEncargados()

        CargarComboVendedores(DsEncargados)

        CargarComboTiposPagos(If(cb_Tipo.SelectedIndex = 1, TipoCliente.Mayorista, TipoCliente.Minorista))

        CargarComboListaPrecios(If(cb_Tipo.SelectedIndex = 1, TipoCliente.Mayorista, TipoCliente.Minorista))

        'Borro el textbox
        txt_CodigoBarra.Clear()
        txt_CodigoBarra.Focus()

        CargraListaProductos()

        PanelTotalMayorista.Location = PanelTotalMinorista.Location

        'Cambio el cursor a NORMAL.
        Me.Cursor = Cursors.Arrow
    End Sub

    'Evento que se ejecuta cuando finaliza la devolucion.
    Private Sub Btn_Finalizar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_Finalizar.Click
        Dim TotalMonto As Double = CalcularPrecioTotal()
        Dim id_Producto As Integer = 0
        Dim NotaCredito As Boolean = False

        'Obtengo toda la informacion.
        Dim TotalProductos As Integer = DG_Productos.Rows.Count 'Total de productos cargados.
        Dim TipoPago As Integer = Cb_TipoPago.SelectedValue 'Tipo de Pago.
        Dim id_Cliente As Integer = 0 'ID de Cliente.
        Dim Descuento As Double = 0 'Descuento ingresado.
        Dim Subtotal As Double = 0 'Monto total de la venta.
        Dim MontoTotal As Double = 0 'Monto total de la venta menos el descuento.
        Dim IvaTotal As Double = 0 'Iva total de la vental
        Dim PorcentajeFacturacion As Double = CType(txt_PorcentajeFacturacion.Value, Double) / 100

        'Chequeo que haya al menos un producto cargado.
        If TotalProductos <= 0 Then
            'Muestro Mensaje.
            MessageBox.Show("La devolución no puede efectuarse. No hay productos cargados !!", "Administración de Devoluciones", MessageBoxButtons.OK, MessageBoxIcon.Stop)
            Return
        End If

        'Tiene al menos un producto.
        'Chequeo que haya asignado al menos un vendedor a la Devoluciones.
        If Cb_Vendedores.SelectedValue <= 0 Then
            'Muestro Mensaje.
            MessageBox.Show("La devolución no puede efectuarse. Debe seleccionar un vendedor responsable de la devoluciones.", "Administración de Devoluciones", MessageBoxButtons.OK, MessageBoxIcon.Stop)
            Return
        End If

        If Cb_Encargados.SelectedValue <= 0 Then
            'Muestro Mensaje.
            MessageBox.Show("La devolución no puede efectuarse. Debe seleccionar un encargado responsable de la devoluciones.", "Administración de Devoluciones", MessageBoxButtons.OK, MessageBoxIcon.Stop)
            Return
        End If

        If Cb_TipoPago.SelectedValue <= 0 Then
            'Muestro Mensaje.
            MessageBox.Show("La devolución no puede efectuarse. Debe seleccionar un tipo de pago a la devoluciones.", "Administración de Devoluciones", MessageBoxButtons.OK, MessageBoxIcon.Stop)
            Return
        End If

        'Si confirma la devolución.
        If MessageBox.Show("¿Ésta seguro que desea efectuar la devolución?", "Administración de Devoluciones", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = vbNo Then
            Return
        End If

        If (MessageBox.Show("¿Desea generar nota de crédito?", "Administración de Devoluciones", MessageBoxButtons.YesNo, MessageBoxIcon.Information) = vbYes) Then

            If MontoTotal <= 0 And CDbl(MontoTotal) > CDbl(My.Settings("MontoMaximoNotaCredito")) Then
                MessageBox.Show("La devolución excede el máximo permitido para la generación de notas de crédito. El pedido no podrá ser generado.", "Administración de Devoluciones", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                NotaCredito = False
            Else
                NotaCredito = True
            End If
        Else
            NotaCredito = False
        End If

        Try
            'Seteo el cursor.
            Me.Cursor = Cursors.WaitCursor
            If (NotaCredito) Then
                Dim frmNotaCredito As frmNotaCredito = New frmNotaCredito()

                frmNotaCredito.DevolucionDetalle = ObtenerDetalleVenta()
                frmNotaCredito.MdiParent = Me.MdiParent
                AddHandler frmNotaCredito.FormClosed, AddressOf FinalizarDevolucion

                'Seteo TipoVenta
                If cb_Tipo.SelectedItem = "Minorista" Then
                    Subtotal = CType(txt_SubtotalMinorista.Text, Decimal)
                    Descuento = CType(txt_DescuentoMinorista.Text, Decimal)
                    MontoTotal = CType(txt_TotalMinorista.Text, Decimal)

                    frmNotaCredito.Monto = MontoTotal
                    frmNotaCredito.Descuento = Descuento
                    frmNotaCredito.SubTotal = Subtotal
                    frmNotaCredito.TipoPago = TipoPago
                    frmNotaCredito.TipoCliente = TipoCliente.Minorista
                    frmNotaCredito.PorcentajeFacturacion = 1
                Else
                    Descuento = CType(txt_DescuentoMayorista.Text, Decimal)
                    Subtotal = CType(txt_SubtotalMayorista.Text, Decimal)
                    IvaTotal = CType(txt_ivaTotalMayorista.Text, Decimal)
                    MontoTotal = CType(txt_TotalMayorista.Text, Decimal)

                    frmNotaCredito.id_Cliente = id_Cliente
                    frmNotaCredito.Descuento = Math.Round(Descuento * PorcentajeFacturacion, 2)
                    frmNotaCredito.SubTotal = Math.Round(Subtotal * PorcentajeFacturacion, 2)
                    frmNotaCredito.IvaTotal = IvaTotal
                    frmNotaCredito.Monto = Math.Round(frmNotaCredito.SubTotal + frmNotaCredito.IvaTotal, 2)
                    frmNotaCredito.TipoPago = TipoPago
                    frmNotaCredito.TipoCliente = TipoCliente.Mayorista
                    frmNotaCredito.PorcentajeFacturacion = PorcentajeFacturacion
                End If

                frmNotaCredito.Show()
                Me.Hide()

                'Seteo el cursor.
                Me.Cursor = Cursors.Arrow

            Else
                FinalizarDevolucion(Nothing, Nothing)
            End If


        Catch ex As Exception
            'Muestro el mensaje de ok.
            Me.Cursor = Cursors.Arrow
            MessageBox.Show("Se ha producido un error al registrar la devolución. Por favor, Comuniquese con el administrador.", "Administración de Devoluciones", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Function ObtenerDetalleVenta() As List(Of Devolucion_Detalle)
        Dim detalleDevolucion As List(Of Devolucion_Detalle) = New List(Of Devolucion_Detalle)()

        For i = 0 To DG_Productos.Rows.Count - 1
            If CInt(DG_Productos.Rows(i).Cells.Item("ID").Value) > 0 And CInt(DG_Productos.Rows(i).Cells.Item("CANTIDAD").Value) > 0 Then
                Dim detalle As New Devolucion_Detalle
                detalle.id_Detalle = 0
                detalle.Nombre = DG_Productos.Rows(i).Cells.Item("NOMBRE").Value
                detalle.id_Producto = CInt(DG_Productos.Rows(i).Cells.Item("ID").Value)
                detalle.Cantidad = CInt(DG_Productos.Rows(i).Cells.Item("CANTIDAD").Value)
                detalle.Precio = CDbl(DG_Productos.Rows(i).Cells.Item("PRECIO").Value)
                detalle.Iva = CDbl(DG_Productos.Rows(i).Cells.Item("IVA").Value)
                detalle.Monto = CDbl(DG_Productos.Rows(i).Cells.Item("MONTO").Value)

                detalleDevolucion.Add(detalle)
            End If
        Next
        Return detalleDevolucion
    End Function

    'Evento que se ejecuta cuando finaliza la devolucion.
    Private Sub FinalizarDevolucion(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim TotalMonto As Double = CalcularPrecioTotal()
        Dim id_Producto As Integer = 0

        'Obtengo toda la informacion.
        Dim NotasCreditos As List(Of NotaCredito) = New List(Of NotaCredito)()
        Dim notaCreditoGenerada As Boolean = False 'Variable que indica si la venta ´facturará o no.
        Dim TotalProductos As Integer = DG_Productos.Rows.Count 'Total de productos cargados.
        Dim TipoVenta As Integer = 0 'Tipo de Venta.
        Dim TipoPago As Integer = Cb_TipoPago.SelectedValue 'Tipo de Pago.
        Dim id_Empleado As Integer = Cb_Vendedores.SelectedValue 'ID de Vendedor.
        Dim id_Encargado As Integer = Cb_Encargados.SelectedValue 'ID de Encargado.
        Dim id_Cliente As Integer = 0 'ID de Cliente.
        Dim Facturar As Boolean = False 'Variable que indica si la venta ´facturará o no.
        Dim Descuento As Double = 0 'Descuento ingresado.
        Dim Subtotal As Double = 0 'Monto total de la venta.
        Dim MontoTotal As Double = 0 'Monto total de la venta menos el descuento.
        Dim CantidadTotal As Integer = CalcularCantidadTotal() 'Cantidad total de articulos.
        Dim Monto As Double = 0 'Será el monto que le corresponda al empleado dependiendo de la comision y el MontoTotal.
        Dim Comision As Double = 0 'Será la comision del empleado, determinada por la sucursal y el dia de la semana.
        Dim TipoPagoControlador As String = "" 'Variable que se imprime en el tique fiscal.
        Dim IvaTotal As Double = 0 'Iva total de la vental
        Dim PorcentajeFacturacion As Double = CType(txt_PorcentajeFacturacion.Value, Double) / 100

        If (sender IsNot Nothing) Then
            Me.Show()
            Dim frmNotaCredito As frmNotaCredito = CType(sender, frmNotaCredito)

            ' Si confirmo la factura cargo los valores para registrar la factura
            If frmNotaCredito.DialogResult = DialogResult.OK Then
                NotasCreditos = frmNotaCredito.NotasCreditos
                notaCreditoGenerada = True

                ' Si hubo un problema en el proceso de facturacion marco como que no se facturo para que se registre la venta
            ElseIf frmNotaCredito.DialogResult = DialogResult.Abort Then
                notaCreditoGenerada = False

                ' Si se calcelo la pantalla de facturacion no registro la venta
            Else
                Return
            End If
        End If


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
            Subtotal = CType(txt_SubtotalMinorista.Text, Decimal)
            Descuento = CType(txt_DescuentoMinorista.Text, Decimal)
            MontoTotal = CType(txt_TotalMinorista.Text, Decimal)
        Else
            TipoVenta = 2
            Descuento = CType(txt_DescuentoMayorista.Text, Decimal)
            Subtotal = CType(txt_SubtotalMayorista.Text, Decimal)
            IvaTotal = CType(txt_ivaTotalMayorista.Text, Decimal)
            MontoTotal = CType(txt_TotalMayorista.Text, Decimal)
        End If

        'Seteo ID Cliente
        If txt_id_Cliente.Text = "" Then
            id_Cliente = 0
        Else
            id_Cliente = CInt(txt_id_Cliente.Text)
        End If

        Try

            EntDevolucion.id_Cliente = id_Cliente
            EntDevolucion.id_Empleado = id_Empleado
            EntDevolucion.id_Encargado = id_Encargado
            EntDevolucion.id_Sucursal = id_Sucursal
            EntDevolucion.id_TipoPago = TipoPago
            EntDevolucion.id_TipoDevolucion = TipoVenta
            EntDevolucion.CantidadTotal = CantidadTotal
            EntDevolucion.Descuento = Descuento
            EntDevolucion.SubTotal = Subtotal
            EntDevolucion.PrecioTotal = MontoTotal
            EntDevolucion.PorcentajeFacturacion = PorcentajeFacturacion
            EntDevolucion.Habilitado = 1
            EntDevolucion.NotaCredito = If(notaCreditoGenerada, 1, 0)
            EntDevolucion.Detalle = ObtenerDetalleVenta()

            Dim idDevolucion As String = NegDevolucion.NuevaDevolucion(EntDevolucion)
            If (idDevolucion = "0") Then
                Me.Cursor = Cursors.Arrow
                MessageBox.Show("Se ha producido un error al registrar la devolución. Por favor, Comuniquese con el administrador.", "Administración de Devoluciones", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return
            End If

            Dim NegNotaCredito As NegNotaCredito = New NegNotaCredito()

            For Each notaCredito As NotaCredito In NotasCreditos
                notaCredito.id_Devolucion = idDevolucion
                NegNotaCredito.NuevaNotaCredito(notaCredito)
            Next

            'cursor..
            Me.Cursor = Cursors.Arrow

            'Muestro el mensaje de ok.
            MessageBox.Show("Se ha realizado la devolución correctamente.", "Administración de Devoluciones", MessageBoxButtons.OK, MessageBoxIcon.Information)

            Me.Close()

        Catch ex As Exception
            'Muestro el mensaje de ok.
            Me.Cursor = Cursors.Arrow
        MessageBox.Show("Se ha producido un error al registrar la devolución. Por favor, Comuniquese con el administrador.", "Administración de Devoluciones", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

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
        'Si va a iniciar a modifica la cantidad de un producto
        If DG_Productos.Columns(e.ColumnIndex).Name = "CANTIDAD" Then
            'Guardo la cantidad antes de iniciar la modificacion
            ProductoCantidadAnterior = DG_Productos(e.ColumnIndex, e.RowIndex).Value
        End If
    End Sub

    'Cuando realiza un click dentro del datagrid de productos.
    Private Sub DG_Productos_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DG_Productos.CellContentClick
        If DG_Productos.Columns(e.ColumnIndex).Name = "ELIMINAR" Then 'Si se hace click en el boton "eliminar" de la fila.
            Dim Result As DialogResult
            Result = MessageBox.Show("¿Está seguro que desea eliminar el item seleccionado?", "Registro de Ventas", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

            If Result = System.Windows.Forms.DialogResult.Yes Then 'Si acepta eliminar el item
                Dim id_Producto As Integer = DG_Productos.Rows(e.RowIndex).Cells("ID").Value
                If id_Producto = 0 Then
                    'si no completo la descripcion, muestro un msg de error.
                    MessageBox.Show("No se puede eliminar el item.", "Registro de Ventas", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Else
                    DG_Productos.Rows.RemoveAt(e.RowIndex) 'Elimino el item
                    CalcularTotales() 'Recalculo el Total y lo muestro en el label
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
            'Verifico si hay stock disponible de la cantidad ingresada del producto
            If (Not NegStock.ComprobarStock(DG_Productos("ID", e.RowIndex).Value, DG_Productos(e.ColumnIndex, e.RowIndex).Value.ToString(), id_Sucursal)) Then
                'Si no hay producto muestro un mensaje de alerta para que el usuario decida que hacer
                Dim frmStockFaltante As frmStockFaltante = New frmStockFaltante(DG_Productos("ID", e.RowIndex).Value, DG_Productos("CODIGO", e.RowIndex).Value, id_Sucursal, DG_Productos(e.ColumnIndex, e.RowIndex).Value)
                'Si retorna Ok es porque el usuario decidio cargar una cantidad de productos
                If (frmStockFaltante.ShowDialog() = Windows.Forms.DialogResult.OK) Then
                    DG_Productos(e.ColumnIndex, e.RowIndex).Value = frmStockFaltante.stockCargado
                Else
                    DG_Productos(e.ColumnIndex, e.RowIndex).Value = ProductoCantidadAnterior
                    Return
                End If
            End If

            Dim PorcentajeFacturacion As Double = Double.Parse(txt_PorcentajeFacturacion.Text) / 100

            'Actualizo el campo SUBTOTAL del producto segun el tipo de cliente
            If cb_Tipo.SelectedItem = "Minorista" Then
                DG_Productos("SUBTOTAL", e.RowIndex).Value = DG_Productos(e.ColumnIndex, e.RowIndex).Value.ToString() * DG_Productos("MONTO", e.RowIndex).Value.ToString()
            Else
                DG_Productos("SUBTOTAL", e.RowIndex).Value = DG_Productos(e.ColumnIndex, e.RowIndex).Value.ToString() * DG_Productos("PRECIO", e.RowIndex).Value.ToString() * (1 + 0.21 * PorcentajeFacturacion)
            End If
            'Recalculo el Total y lo muestro en el label
            CalcularTotales()

        ElseIf DG_Productos.Columns(e.ColumnIndex).Name = "PRECIO" Then

            'Si el monto ingresado es mayor que cero.
            If DG_Productos(e.ColumnIndex, e.RowIndex).Value >= 0 Then
                'Actualizo el campo SUBTOTAL del producto.
                DG_Productos(e.ColumnIndex, e.RowIndex).Value = Format(CType(DG_Productos(e.ColumnIndex, e.RowIndex).Value, Decimal), "###0.00")
                ActualizarColumnaIvaMonto(e.RowIndex, CType(DG_Productos(e.ColumnIndex, e.RowIndex).Value, Decimal))
                'Recalculo el Total, descuento y subtotal: lo muestro en el label
                CalcularTotales()
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
                CalcularTotales()
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
            txt_id_Cliente.Text = frmBuscarClienteMayorista.clienteMayorista.Id
            txt_RazonSocial.Text = frmBuscarClienteMayorista.clienteMayorista.RazonSocial
            Cb_ListaPrecio.SelectedValue = frmBuscarClienteMayorista.clienteMayorista.IdListaPrecio
            txt_PorcentajeBonificacion.Text = frmBuscarClienteMayorista.clienteMayorista.Bonificacion

            PorcentajeFacturacionIngresado = If(frmBuscarClienteMayorista.clienteMayorista.Lista = 0, 100, frmBuscarClienteMayorista.clienteMayorista.Lista)
            If Cb_TipoPago.SelectedValue = 1 Then
                txt_PorcentajeFacturacion.Text = PorcentajeFacturacionIngresado
            End If

            ActualizarMontosGrillaYTotales()

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

        Dim descuento As Double = Math.Round(CType(txt_DescuentoMinorista.Text, Double), 0, MidpointRounding.ToEven)
        txt_DescuentoMinorista.Text = Format(descuento, "###0.00")

        Dim PorcentajeDescuento As Double = descuento / CalcularPrecioTotal()
        txt_PorcentajeBonificacion.Text = Math.Round(PorcentajeDescuento * 100, 2, MidpointRounding.ToEven)

        CalcularTotales()

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

        Dim descuento As Double = Math.Round(CType(txt_DescuentoMayorista.Text, Double), 0, MidpointRounding.ToEven)
        txt_DescuentoMinorista.Text = Format(descuento, "###0.00")

        Dim PorcentajeDescuento As Double = descuento / CalcularPrecioTotal()
        txt_PorcentajeBonificacion.Text = Math.Round(PorcentajeDescuento * 100, 2, MidpointRounding.ToEven)

        CalcularTotales()
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

        'Es MAYORISTA
        If (cb_Tipo.SelectedIndex = 1) Then
            'Es EFECTIVO
            If (TypeOf Cb_TipoPago.SelectedValue Is String AndAlso Cb_TipoPago.SelectedValue = 1) Then
                'habilito el porcentaje de facturacion
                txt_PorcentajeFacturacion.Enabled = True
                txt_PorcentajeFacturacion.Text = PorcentajeFacturacionIngresado
            Else
                'deshabilito el porcentaje de facturacion
                txt_PorcentajeFacturacion.Text = "100"
                txt_PorcentajeFacturacion.Enabled = False
            End If
            'Es MINORISTA
        Else
            txt_PorcentajeBonificacion.Value = 0
        End If

        If (DG_Productos.Rows.Count > 0) Then
            ActualizarMontosGrillaYTotales()
        End If
    End Sub

#End Region

#Region "Funciones del formulario"
    'Funcion que agrega un nuevo item al DATAGRID - Tipo: 1-ID | 2-CODIGO DE BARRA | 3-CODIGO - TipoAccion: 1-Venta | 2-Cambio
    Public Sub AgregarItem(ByVal Numero As String, ByVal Tipo As Integer, Optional ByVal TipoAccion As Integer = 1)

        If Tipo = 1 Then 'Si manda el ID
            Dim id_Producto = Numero
            EntProducto = NegProductos.TraerProducto(id_Producto) 'Traigo el producto.      
        ElseIf Tipo = 2 Then 'Si manda el CODIGO DE BARRA
            Dim CodigoBarras = Numero
            EntProducto = NegProductos.TraerProductoPorCodBarra(CodigoBarras) 'Traigo el producto.      
        Else 'Si manda el CODIGO DE PRODUCTO
            Dim CODIGO = Numero
            EntProducto = NegProductos.TraerProductoPorCodigo(CODIGO) 'Traigo el producto.      
        End If

        AgregarItem(EntProducto, TipoAccion)

    End Sub

    'Funcion que agrega un nuevo item al DATAGRID - Tipo: 1-ID | 2-CODIGO DE BARRA
    Public Sub AgregarItem(ByVal EntProducto As Entidades.Productos, Optional ByVal TipoAccion As Integer = 1)
        Try
            'Seteo el cursor.
            Me.Cursor = Cursors.WaitCursor

            'Declaracion de Variables
            Dim NumeroFila As Integer = 0
            Dim i As Integer
            Dim SinStock As Boolean = False
            Dim cantidad As Integer = 1
            Dim subtotal As Double = 0
            Dim Repetido As Boolean = False

            'Si no encuentra el producto, sale de la funcion.
            If EntProducto.id_Producto = 0 Then
                txt_CodigoBarra.Clear()
                txt_CodigoBarra.Focus()
                Me.Cursor = Cursors.Arrow
                MessageBox.Show("No se ha encontrado el producto. Por favor, intente nuevamente.", "Registro de Ventas", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Exit Sub
            End If

            'Me fijo si ya se encuentra agregado. Si está aumento su cantidad.
            For i = 0 To DG_Productos.Rows.Count - 1
                If DG_Productos.Rows(i).Cells.Item("ID").Value = EntProducto.id_Producto Then
                    Repetido = True

                    If TipoAccion = 1 Then

                        'Chequeo si se posee stock del producto
                        If Not NegStock.ComprobarStock(EntProducto.id_Producto, DG_Productos.Rows(i).Cells.Item("CANTIDAD").Value + 1, id_Sucursal) Then
                            'Seteo el cursor.
                            Me.Cursor = Cursors.Arrow
                            'Si no hay producto muestro un mensaje de alerta para que el usuario decida que hacer
                            Dim frmStockFaltante As frmStockFaltante = New frmStockFaltante(EntProducto.id_Producto, EntProducto.Codigo, id_Sucursal, DG_Productos.Rows(i).Cells.Item("CANTIDAD").Value + 1)
                            'Si retorna Ok es porque el usuario decidio cargar una cantidad de productos
                            If (frmStockFaltante.ShowDialog() = Windows.Forms.DialogResult.OK) Then
                                DG_Productos.Rows(i).Cells.Item("CANTIDAD").Value = frmStockFaltante.stockCargado
                                DG_Productos.Rows(i).Cells.Item("SUBTOTAL").Value = (DG_Productos.Rows(i).Cells.Item("CANTIDAD").Value * DG_Productos.Rows(i).Cells.Item("PRECIO").Value)
                                CalcularTotales()
                                Return
                            Else
                                Return
                            End If
                        End If

                        Dim frmStockIngreso As frmStockIngreso = New frmStockIngreso(EntProducto.id_Producto, EntProducto.Codigo, id_Sucursal, DG_Productos.Rows(i).Cells.Item("CANTIDAD").Value + 1)
                        If (frmStockIngreso.ShowDialog() = Windows.Forms.DialogResult.OK) Then
                            DG_Productos.Rows(i).Cells.Item("CANTIDAD").Value = frmStockIngreso.stockCargado
                            DG_Productos.Rows(i).Cells.Item("SUBTOTAL").Value = (DG_Productos.Rows(i).Cells.Item("CANTIDAD").Value * DG_Productos.Rows(i).Cells.Item("PRECIO").Value)
                            CalcularTotales()
                        End If
                    Else
                        Me.Cursor = Cursors.Arrow
                        MessageBox.Show("El producto seleccionado ya se encuentra ingresado.", "Registro de Ventas", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    End If
                End If
            Next



            'Si  hay stock inserto una nueva fila.
            If Repetido = False Then

                'Chequeo si se posee stock del producto, como el produto no esta repetido consulto por si hay 1
                If Not NegStock.ComprobarStock(EntProducto.id_Producto, 1, id_Sucursal) Then
                    'Seteo el cursor.
                    Me.Cursor = Cursors.Arrow
                    'Si no hay producto muestro un mensaje de alerta para que el usuario decida que hacer
                    Dim frmStockFaltante As frmStockFaltante = New frmStockFaltante(EntProducto.id_Producto, EntProducto.Codigo, id_Sucursal, 1)
                    'Si retorna Ok es porque el usuario decidio cargar una cantidad de productos
                    If (frmStockFaltante.ShowDialog() = Windows.Forms.DialogResult.OK) Then
                        cantidad = frmStockFaltante.stockCargado
                    Else
                        Return
                    End If
                Else
                    Dim frmStockIngreso As frmStockIngreso = New frmStockIngreso(EntProducto.id_Producto, EntProducto.Codigo, id_Sucursal, 1)
                    If (frmStockIngreso.ShowDialog() = Windows.Forms.DialogResult.OK) Then
                        cantidad = frmStockIngreso.stockCargado
                    Else
                        Return
                    End If
                End If

                NumeroFila = DG_Productos.Rows.Count + 1

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

                Dim PorcentajeFacturacion As Double = CType(txt_PorcentajeFacturacion.Value, Double) / 100
                Dim Monto As Double = 0
                Dim PrecioSinIVA As Double = 0
                Dim IVA As Double = 0

                'Los precios que componen la lista de precios minorista incluyen el IVA
                'Los precios que componen la lista de precios mayoristas NO incluyen el IVA
                If cb_Tipo.SelectedItem = "Minorista" Then
                    Monto = Precio
                Else
                    PrecioSinIVA = Precio
                    IVA = PrecioSinIVA * 0.21 * PorcentajeFacturacion
                    Monto = PrecioSinIVA + IVA
                End If

                AgregarItemAGrilla(EntProducto, TipoAccion, NumeroFila, cantidad, PrecioSinIVA, IVA, Monto)

            End If

            'Lo muestro en el label
            CalcularTotales()

            'Borro el textbox
            txt_CodigoBarra.Clear()
            txt_CodigoBarra.Focus()

            'Seteo el cursor.
            Me.Cursor = Cursors.Arrow
        Catch ex As Exception
            Me.Cursor = Cursors.Arrow
            MessageBox.Show("Se ha producido un error al agregar el producto.", "Registro de Ventas", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub AgregarItemAGrilla(EntProducto As Productos, TipoAccion As Integer, NumeroFila As Integer, cantidad As Integer, Precio As Double, Iva As Double, Monto As Double)

        If cb_Tipo.SelectedItem = "Minorista" Then
            AgregarFila(EntProducto, TipoAccion, NumeroFila, cantidad, 0, 0, Monto)
        Else
            AgregarFila(EntProducto, TipoAccion, NumeroFila, cantidad, Precio, Iva, Monto)
        End If
    End Sub

    Private Sub AgregarFila(EntProducto As Productos, TipoAccion As Integer, NumeroFila As Integer, cantidad As Integer, Precio As Double, Iva As Double, Monto As Double)
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
        If TipoAccion = 2 Then
            dgvCell.Value = (Precio * -1)
        Else
            dgvCell.Value = Precio
        End If

        dgvRow.Cells.Add(dgvCell)

        'Valor de la Columna IVA
        dgvCell = New DataGridViewTextBoxCell()
        If TipoAccion = 2 Then
            dgvCell.Value = (Iva * -1)
        Else
            dgvCell.Value = Iva
        End If

        dgvRow.Cells.Add(dgvCell)

        'Valor de la Columna MONTO
        dgvCell = New DataGridViewTextBoxCell()
        If TipoAccion = 2 Then
            dgvCell.Value = (Monto * -1)
        Else
            dgvCell.Value = Monto
        End If

        dgvRow.Cells.Add(dgvCell)

        'Valor de la Columna Subtotal
        dgvCell = New DataGridViewTextBoxCell()
        If TipoAccion = 2 Then
            dgvCell.Value = (Monto * -1) * cantidad
        Else
            dgvCell.Value = Monto * cantidad
        End If
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

        If TipoAccion = 2 Then
            dgvRow.DefaultCellStyle.BackColor = Color.Silver
        Else
            dgvRow.DefaultCellStyle.BackColor = Color.White
        End If
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

    'Dependiendo para que tipo de cliente es la venta, muestro o oculto el panel de clientes.
    Private Sub cb_Tipo_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cb_Tipo.SelectedIndexChanged

        Cb_TipoPago.SelectedValue = 0

        'Mayorista
        If cb_Tipo.SelectedIndex = 1 Then
            enableAllControls(Gb_Cliente, True)
            DG_Productos.Columns("MONTO").ReadOnly = True
            DG_Productos.Columns("PRECIO").ReadOnly = False
            DG_Productos.Columns("PRECIO").Visible = True
            DG_Productos.Columns("IVA").Visible = True
            PanelTotalMayorista.Visible = True
            PanelTotalMinorista.Visible = False

        Else
            'Minorista
            enableAllControls(Gb_Cliente, False)
            txt_RazonSocial.Clear()
            txt_id_Cliente.Clear()
            DG_Productos.Columns("MONTO").ReadOnly = False
            DG_Productos.Columns("PRECIO").ReadOnly = True
            DG_Productos.Columns("PRECIO").Visible = False
            DG_Productos.Columns("IVA").Visible = False
            PanelTotalMayorista.Visible = False
            PanelTotalMinorista.Visible = True
        End If

        CargarComboListaPrecios(If(cb_Tipo.SelectedIndex = 1, TipoCliente.Mayorista, TipoCliente.Minorista))
        CargarComboTiposPagos(If(cb_Tipo.SelectedIndex = 1, TipoCliente.Mayorista, TipoCliente.Minorista))

        txt_PorcentajeFacturacion.Text = 100
        PosicionarListaPreciosSegunFormaDePago()
    End Sub

    Private Sub CargarComboListaPrecios(tipoCliente As TipoCliente)
        Dim dsListaPrecio As DataSet

        If tipoCliente = TipoCliente.Mayorista Then
            dsListaPrecio = NegListasPrecio.ListadoPreciosPorGrupo(3)
        Else
            dsListaPrecio = NegListasPrecio.ListadoPreciosPorGrupo(My.Settings("ListaPrecio"))

            Dim dv As DataView = dsListaPrecio.Tables(0).DefaultView
            dv.RowFilter = "ListaPrecio like 'Efectivo%'"
            dsListaPrecio = New DataSet()
            Dim dt As DataTable = dv.ToTable()
            dsListaPrecio.Tables.Add(dt)
        End If

        If dsListaPrecio.Tables(0).Rows.Count > 0 Then
            Cb_ListaPrecio.DataSource = Nothing
            Cb_ListaPrecio.DataSource = dsListaPrecio.Tables(0)
            Cb_ListaPrecio.DisplayMember = "ListaPrecio"
            Cb_ListaPrecio.ValueMember = "id_Lista"
            Cb_ListaPrecio.Refresh()
        End If
    End Sub

    Private Function CargarComboVendedores(DsEncargados As DataSet) As DataSet

        'busco los vendedores que asistieron hoy
        Dim DsVendedores = NegEmpleados.ListadoVendedoresSucursalAsistencia(id_Sucursal)

        'si no recupero ningun registro
        If DsEncargados.Tables(0).Rows.Count = 0 Then
            'busco los vendedores que pretenecen a la sucursal
            DsVendedores = NegEmpleados.ListadoVendedoresSucursal(id_Sucursal)
        End If

        'Agrego los Encagados a la lista de vendedores ya que un encargado puede participar de la venta como vendedor
        DsVendedores.Tables(0).Merge(DsEncargados.Tables(0))

        Dim dtOpciones As DataTable = New DataTable()
        Dim SelectedValue As Integer = 0

        If DsVendedores.Tables(0).Rows.Count = 1 Then
            dtOpciones = Funciones.CrearDataTable("id_Empleado", "NombreCompleto", DsVendedores, "", False)
            SelectedValue = If(DsVendedores.Tables(0).Rows.Count > 0, DsVendedores.Tables(0).Rows(0)("id_Empleado"), 0)
        ElseIf DsVendedores.Tables(0).Rows.Count > 1 Then
            dtOpciones = Funciones.CrearDataTable("id_Empleado", "NombreCompleto", DsVendedores, "Seleccione un vendedor...")
        End If

        If DsVendedores.Tables(0).Rows.Count > 0 Then
            Cb_Vendedores.DataSource = Nothing
            Cb_Vendedores.DataSource = dtOpciones
            Cb_Vendedores.DisplayMember = "NombreCompleto"
            Cb_Vendedores.ValueMember = "id_Empleado"
            Cb_Vendedores.SelectedValue = SelectedValue
            Cb_Vendedores.Refresh()
        Else
            Cb_Vendedores.Items.Add("No hay vendedores disponibles.")
            Cb_Vendedores.SelectedItem = "No hay vendedores disponibles."
        End If

        Return DsVendedores
    End Function

    Private Function CargarComboEncargados() As DataSet

        'busco los encargados que asistieron hoy
        Dim DsEncargados = NegEmpleados.ListadoEncargadosSucursalAsistencia(id_Sucursal)

        'si no recupero ningun registro
        If DsEncargados.Tables(0).Rows.Count = 0 Then
            'busco los encargados que pretenecen a la sucursal
            DsEncargados = NegEmpleados.ListadoEncargadosSucursal(id_Sucursal)
        End If

        Dim dtOpciones As DataTable = New DataTable()
        Dim SelectedValue As Integer = 0

        If DsEncargados.Tables(0).Rows.Count = 1 Then
            dtOpciones = Funciones.CrearDataTable("id_Empleado", "NombreCompleto", DsEncargados, "", False)
            SelectedValue = If(DsEncargados.Tables(0).Rows.Count > 0, DsEncargados.Tables(0).Rows(0)("id_Empleado"), 0)
        ElseIf DsEncargados.Tables(0).Rows.Count > 1 Then
            dtOpciones = Funciones.CrearDataTable("id_Empleado", "NombreCompleto", DsEncargados, "Seleccione un encargado...")
        End If

        If DsEncargados.Tables(0).Rows.Count > 0 Then
            Cb_Encargados.DataSource = Nothing
            Cb_Encargados.DataSource = dtOpciones
            Cb_Encargados.DisplayMember = "NombreCompleto"
            Cb_Encargados.ValueMember = "id_Empleado"
            Cb_Encargados.SelectedValue = SelectedValue
            Cb_Encargados.Refresh()
        Else
            Cb_Encargados.Items.Add("No hay encargados disponibles.")
            Cb_Encargados.SelectedItem = "No hay encargados disponibles."
        End If

        Return DsEncargados
    End Function

    Private Function CargarComboTiposPagos(tipoCliente As TipoCliente) As DataSet
        Dim DsTiposPagos As DataSet = NegTiposPagos.ListadoTiposPagos()
        Dim filtro As String

        'Elimino la forma de pago Cheque
        If tipoCliente = TipoCliente.Minorista Then
            filtro = "id_TipoPago in (1)"
        Else
            filtro = "id_TipoPago in (1,4)"
        End If

        Dim dv As DataView = DsTiposPagos.Tables(0).DefaultView
        dv.RowFilter = filtro
        DsTiposPagos = New DataSet()
        Dim dt As DataTable = dv.ToTable()
        DsTiposPagos.Tables.Add(dt)

        If DsTiposPagos.Tables(0).Rows.Count > 0 Then
            Cb_TipoPago.DataSource = Nothing
            Cb_TipoPago.DataSource = Funciones.CrearDataTable("id_TipoPago", "Descripcion", DsTiposPagos, "Seleccione un tipo de pago...")
            Cb_TipoPago.DisplayMember = "Descripcion"
            Cb_TipoPago.ValueMember = "id_TipoPago"
            Cb_TipoPago.SelectedValue = 0
            Cb_TipoPago.Refresh()
        End If

        Cb_TipoPago.SelectedIndex = Cb_TipoPago.FindString("Efectivo")

        Return DsTiposPagos
    End Function

    Private Sub txt_CodigoBarra_KeyDown(sender As Object, e As KeyEventArgs) Handles txt_CodigoBarra.KeyDown
        If e.KeyData = Keys.Enter Then
            Me.Cursor = Cursors.WaitCursor
            BuscarProducto()
            Me.Cursor = Cursors.Arrow
        End If
    End Sub

    Private Sub Cb_ListaPrecio_SelectedIndexChanged(sender As Object, e As EventArgs)
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
        CalcularTotales()

    End Sub

    Private Sub ActualizarMontosProductos(Precio As Double, row As DataGridViewRow)
        If cb_Tipo.SelectedItem = "Minorista" Then
            ActualizarMontosProductosMinoristas(Precio, row)
        Else
            ActualizarMontosProductosMayoristas(Precio, row)
        End If
    End Sub

    Private Function ActualizarMontosProductosMayoristas(Precio As Double, row As DataGridViewRow)
        Dim PorcentajeFacturacion As Double = Double.Parse(txt_PorcentajeFacturacion.Text) / 100
        Dim esDevolucion As Boolean = row.Cells("PRECIO").Value < 0
        If esDevolucion Then
            row.Cells("PRECIO").Value = -Precio
        Else
            row.Cells("PRECIO").Value = Precio
        End If
        If esDevolucion Then
            row.Cells("IVA").Value = (Precio * -1) * 0.21
        Else
            row.Cells("IVA").Value = Precio * (0.21 * PorcentajeFacturacion)
        End If

        If esDevolucion Then
            row.Cells("MONTO").Value = (Precio * -1.21)
        Else
            row.Cells("MONTO").Value = (Precio * (1 + 0.21 * PorcentajeFacturacion))
        End If

        row.Cells("SUBTOTAL").Value = row.Cells("MONTO").Value * CDbl(row.Cells("CANTIDAD").Value)
        Return row
    End Function

    Private Function ActualizarMontosProductosMinoristas(Precio As Double, row As DataGridViewRow)
        Dim esDevolucion As Boolean = row.Cells("PRECIO").Value < 0
        If esDevolucion Then
            row.Cells("PRECIO").Value = Precio * -1
        Else
            row.Cells("PRECIO").Value = Precio
        End If

        If esDevolucion Then
            row.Cells("IVA").Value = Precio * -0.21
        Else
            row.Cells("IVA").Value = Precio * 0.21
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

    Private Sub CargraListaProductos()
        'Obtengo el listado de productos guardados en cache
        dsProductos = NegProductos.ListadoProductos(True)

        'Armo una lista que contiene los nombres y codigos de todos los producto
        Dim listaNombreCodigoProductos As AutoCompleteStringCollection = New AutoCompleteStringCollection()

        listaNombreCodigoProductos.AddRange(dsProductos.Tables(0).Rows.Cast(Of DataRow).Select(Function(x) x.Item("Nombre").ToString).ToArray())
        listaNombreCodigoProductos.AddRange(dsProductos.Tables(0).Rows.Cast(Of DataRow).Select(Function(x) x.Item("Codigo").ToString).ToArray())

        txt_CodigoBarra.AutoCompleteCustomSource = listaNombreCodigoProductos

        PanelTotalMayorista.Location = PanelTotalMinorista.Location
    End Sub

    Private Sub txt_PorcentajeFacturacion_Leave(sender As Object, e As EventArgs) Handles txt_PorcentajeFacturacion.Leave
        If txt_PorcentajeFacturacion.Text.Trim = "" Then
            txt_PorcentajeFacturacion.Text = "0"
        End If

        If (DG_Productos.Rows.Count > 0) Then
            ActualizarMontosGrillaYTotales()
        End If
    End Sub

    Private Sub txt_PorcentajeFacturacion_KeyDown(sender As Object, e As KeyEventArgs) Handles txt_PorcentajeFacturacion.KeyDown
        If (e.KeyCode = Keys.Enter) Then
            e.SuppressKeyPress = True
            txt_CodigoBarra.Focus()
        End If
    End Sub

    Private Sub ActualizarMontosGrillaYTotales()
        'actualizo los montos de la grilla
        For Each row As DataGridViewRow In DG_Productos.Rows
            If (row.Cells.Item("PRECIO").Value > 0) Then
                ActualizarColumnaIvaMonto(row.Index, row.Cells.Item("PRECIO").Value)
            End If
        Next

        'actualizo los montos de los totales
        CalcularTotales()
    End Sub

    Private Sub ActualizarColumnaIvaMonto(index As Integer, precio As Double)
        Dim PorcentajeFacturacion As Double = Double.Parse(txt_PorcentajeFacturacion.Text) / 100
        'Es MAYORISTA
        If (cb_Tipo.SelectedIndex = 1) Then
            DG_Productos("IVA", index).Value = precio * (0.21 * PorcentajeFacturacion)
            DG_Productos("MONTO", index).Value = precio * (1 + 0.21 * PorcentajeFacturacion)
        Else
            DG_Productos("IVA", index).Value = 0
            DG_Productos("MONTO", index).Value = precio
        End If
        DG_Productos("SUBTOTAL", index).Value = DG_Productos("MONTO", index).Value * DG_Productos("CANTIDAD", index).Value
    End Sub

    Private Sub txt_PorcentajeDesceunto_Leave(sender As Object, e As EventArgs) Handles txt_PorcentajeBonificacion.Leave
        If txt_PorcentajeBonificacion.Text.Trim = "" Then
            txt_PorcentajeBonificacion.Text = "0"
        End If

        If (DG_Productos.Rows.Count > 0) Then
            CalcularTotales()
        End If

    End Sub

    Private Sub txt_PorcentajeDesceunto_KeyDown(sender As Object, e As KeyEventArgs) Handles txt_PorcentajeBonificacion.KeyDown
        If (e.KeyCode = Keys.Enter) Then
            e.SuppressKeyPress = True
            txt_CodigoBarra.Focus()
        End If
    End Sub

    'Funcion que calcula el total con descuento
    Sub CalcularTotales()
        Dim subtotal As Double = CalcularPrecioTotal()

        If cb_Tipo.SelectedItem = "Minorista" Then
            CaluclarPrecioMinorista(subtotal)
        Else
            CalcularPrecioMayorista(subtotal)
        End If

        If subtotal <= 0 Then
            Btn_Finalizar.Visible = False
        Else
            Btn_Finalizar.Visible = True
        End If
    End Sub

    Private Sub CalcularPrecioMayorista(ByRef subtotal As Double)
        Dim PorcentajeFacturacion As Double = Double.Parse(txt_PorcentajeFacturacion.Text) / 100
        Dim PorcentajeDescuento As Double = Double.Parse(txt_PorcentajeBonificacion.Text) / 100

        Dim descuento As Double = Math.Round(subtotal * PorcentajeDescuento, 0, MidpointRounding.ToEven)
        Dim ivaSubTotal As Double = 0

        If descuento < subtotal Then
            subtotal = subtotal - descuento
            ivaSubTotal = subtotal * (0.21 * PorcentajeFacturacion)

            txt_TotalMayorista.Text = Format(CType(subtotal + ivaSubTotal, Decimal), "###0.00")
        Else
            descuento = subtotal
            subtotal = subtotal - descuento
            ivaSubTotal = subtotal * (0.21 * PorcentajeFacturacion)
            txt_TotalMayorista.Text = Format(CType(subtotal + ivaSubTotal, Decimal), "###0.00")
        End If

        txt_DescuentoMayorista.Text = Format(descuento, "###0.00")
        txt_SubtotalMayorista.Text = Format(CType(subtotal, Decimal), "###0.00")
        txt_ivaTotalMayorista.Text = Format(CType(ivaSubTotal, Decimal), "###0.00")
    End Sub

    Private Sub CaluclarPrecioMinorista(subtotal As Double)
        Dim PorcentajeDescuento As Double = Double.Parse(txt_PorcentajeBonificacion.Text) / 100
        Dim descuento As Double = Math.Round(subtotal * PorcentajeDescuento, 0, MidpointRounding.ToEven)

        If CDbl(descuento) < subtotal Then
            txt_TotalMinorista.Text = Format(CType(subtotal - descuento, Decimal), "###0.00")
        Else
            descuento = subtotal
            txt_TotalMinorista.Text = Format(CType(subtotal - descuento, Decimal), "###0.00")
        End If
        txt_DescuentoMinorista.Text = Format(descuento, "###0.00")
        txt_SubtotalMinorista.Text = Format(CType(subtotal, Decimal), "###0.00")
    End Sub

    Private Sub enableAllControls(con As Control, enable As Boolean)

        For Each c As Control In con.Controls
            enableAllControls(c, enable)
        Next

        If TypeOf con IsNot TableLayoutPanel And TypeOf con IsNot GroupBox And Not String.IsNullOrEmpty(con.Name) Then
            con.Enabled = enable
        End If

    End Sub

    Private Sub Cb_ListaPrecio_SelectedIndexChanged_1(sender As Object, e As EventArgs) Handles Cb_ListaPrecio.SelectedIndexChanged
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
        CalcularTotales()
    End Sub
#End Region
End Class