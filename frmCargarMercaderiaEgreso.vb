Public Class frmCargarMercaderiaEgreso
    'Instancias
    Dim id_Sucursal As Integer
    Dim Nombre_Sucursal As String
    Dim Funciones As New Funciones
    Dim EntProducto As New Entidades.Productos
    Dim NegProductos As New Negocio.NegProductos
    Public Nombre_Sucursal_Destino As String
    Public dsProductos As New DataTable
    Dim NegStock As New Negocio.NegStock

#Region "Eventos del formulario"
    'Load del formulario.
    Private Sub frmCargarMercaderiaEgreso_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            'Cambio el cursor a "WAIT"
            Me.Cursor = Cursors.WaitCursor

            'Sucursal default
            id_Sucursal = My.Settings("Sucursal")
            Nombre_Sucursal = My.Settings("NombreSucursal")

            'Seteo la fecha
            lbl_Fecha.Text = Now.Date.ToString("d MMM yyyy")

            'Seteo el nombre de la sucursal
            lbl_Sucursal.Text = Nombre_Sucursal
            lbl_Sucursal2.Text = Nombre_Sucursal_Destino

            'Oculto Columnas en el DG_Productos
            DG_Productos.Columns("Numero").Visible = False
            DG_Productos.Columns("id_Producto").Visible = False

            'Borro el textbox
            txt_CodigoBarra.Clear()
            txt_CodigoBarra.Focus()

            'Si mando productos, los cargo en la grilla.
            If dsProductos IsNot Nothing And dsProductos.Rows.Count > 0 Then
                AgregarItemsDeBDD(dsProductos)
            End If

            'Cambio el cursor a NORMAL.
            Me.Cursor = Cursors.Arrow
        Catch ex As Exception
            Me.Cursor = Cursors.Arrow
            MessageBox.Show("Se ha producido un error al cargar el formulario. Por favor, contáctese con el administrador", "Movimientos | Egresos", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    'Evento que se ejecuta cuando finaliza la devolucion.
    Private Sub Btn_Finalizar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_Finalizar.Click
        'Cambio el cursor a "WAIT"
        Me.Cursor = Cursors.WaitCursor

        Dim TotalProductos As Integer = DG_Productos.Rows.Count 'Total de productos cargados.
        Dim TotalMonto As Double = CalcularPrecioTotal()
        Dim GranVariable As String = ""

        'Cargo el monto total de los productos.
        frmMovimientoEgreso.txtMonto.Text = Format(CType(TotalMonto, Decimal), "###0.00")
        frmMovimientoEgreso.lblMercaderias.Text = ""
        frmMovimientoEgreso.lblMercaderias.Text = "(Total de Mercadería: " & TotalProductos & " producto/s.)"
        frmMovimientoEgreso.lblMercaderias.Visible = True

        'Armo el datatable con todos los productos cargados.
        'Recorrer(columnas)
        Dim ProductosTable As New DataTable

        For Each columna In DG_Productos.Columns
            Dim col As New DataColumn(columna.name)
            ProductosTable.Columns.Add(col)
        Next

        'Recorrer filas
        For Each fila In DG_Productos.Rows
            Dim dr As DataRow = ProductosTable.NewRow()
            dr(0) = fila.Cells(0).Value.ToString()
            dr(1) = fila.Cells(1).Value.ToString()
            dr(2) = fila.Cells(2).Value.ToString()
            dr(3) = fila.Cells(3).Value.ToString()
            dr(4) = fila.Cells(4).Value.ToString()
            dr(5) = fila.Cells(5).Value.ToString()
            dr(6) = fila.Cells(6).Value.ToString()
            dr(7) = fila.Cells(6).Value.ToString()
            ProductosTable.Rows.Add(dr)
            GranVariable &= "COD: " & fila.Cells(2).Value.ToString() & " - CANT: " & fila.Cells(5).Value.ToString() & " - COSTO: $ " & fila.Cells(4).Value.ToString() & " - SUB: $ " & fila.Cells(7).Value.ToString() & vbCrLf
        Next

        'Asigno el datatable al formulario de egresos.
        frmMovimientoEgreso.dsProductos = ProductosTable

        'Asigno el detalle a la descripcion del movimiento.
        frmMovimientoEgreso.txtDescripcion.Text = GranVariable
        frmMovimientoEgreso.txtDescripcion.ReadOnly = True

        'Cambio el cursor a NORMAL.
        Me.Cursor = Cursors.Arrow

        Me.Close()
        frmMovimientoEgreso.Focus()
    End Sub

    'Evento que se ejecuta cuando cancela la carga.
    Private Sub Btn_Cancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_Cancelar.Click
        If MessageBox.Show("Ésta seguro que desea cancelar la carga de mercaderias?", "Movimientos | Egresos | Cargar Mercaderías", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = vbYes Then
            'Limpio el Formulario.
            LimpiarFormDevoluciones()
            'Cierro el Formulario.
            Me.Close()
        End If
    End Sub

    'Evento que se ejecuta al ingresar valores en el textbox de codigo de barra.
    Private Sub txt_CodigoBarra_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_CodigoBarra.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            Dim CodigoBarra As String = Trim(txt_CodigoBarra.Text)
            If CodigoBarra <> "" Then 'Si el campo no está vacio.
                If CodigoBarra.Length > 1 And CodigoBarra.Length < 13 Then 'Si es codigo de producto.
                    Me.Cursor = Cursors.WaitCursor
                    Funciones.ControlInstancia(frmCargarMercaderiaCantidad).MdiParent = MDIContenedor
                    frmCargarMercaderiaCantidad.Codigo = CodigoBarra
                    frmCargarMercaderiaCantidad.Tipo = 3
                    Funciones.ControlInstancia(frmCargarMercaderiaCantidad).Show()
                    Me.Cursor = Cursors.Arrow
                ElseIf CodigoBarra.Length >= 13 And IsNumeric(CodigoBarra) Then 'Si es codigo de barra.
                    Me.Cursor = Cursors.WaitCursor
                    Funciones.ControlInstancia(frmCargarMercaderiaCantidad).MdiParent = MDIContenedor
                    frmCargarMercaderiaCantidad.Codigo = CodigoBarra
                    frmCargarMercaderiaCantidad.Tipo = 2
                    Funciones.ControlInstancia(frmCargarMercaderiaCantidad).Show()
                    Me.Cursor = Cursors.Arrow
                ElseIf CodigoBarra.Length >= 13 Then 'Si es codigo de barra.
                    txt_CodigoBarra.Clear()
                    txt_CodigoBarra.Focus()
                End If

            Else 'si el campo está vacio.
                txt_CodigoBarra.Focus()
                MessageBox.Show("Ingrese un código de barra o un código de producto.", "Movimientos | Egresos | Cargar Mercaderías", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            End If
        End If
    End Sub

    'Cuando realiza un click dentro del datagrid de productos.
    Private Sub DG_Productos_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DG_Productos.CellContentClick
        If DG_Productos.Columns(e.ColumnIndex).Name = "ELIMINAR" Then 'Si se hace click en el boton "eliminar" de la fila.
            Dim Result As DialogResult
            Result = MessageBox.Show("¿Está seguro que desea eliminar el item seleccionado?", "Movimientos | Egresos | Cargar Mercaderías", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If Result = System.Windows.Forms.DialogResult.Yes Then 'Si acepta eliminar el item
                Dim id_Producto As Integer = DG_Productos.Rows(e.RowIndex).Cells("id_Producto").Value
                If id_Producto = 0 Then
                    'si no completo la descripcion, muestro un msg de error.
                    MessageBox.Show("No se puede eliminar el item.", "Movimientos | Egresos | Cargar Mercaderías", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Else
                    'Elimino el item
                    DG_Productos.Rows.RemoveAt(e.RowIndex)
                    'Recalculo el Total y lo muestro en el label
                    txt_Total.Text = Format(CType(CalcularPrecioTotal(), Decimal), "###0.00")
                    txt_Cantidad.Text = CalcularCantidadTotal()

                    'refresco el datagrid
                    DG_Productos.Refresh()
                End If
            End If
        End If
    End Sub

    'Programo para cuando modifica la cantidad de un producto se actualice el grid.
    Private Sub DG_Productos_CellEndEdit(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DG_Productos.CellEndEdit
        If DG_Productos.Columns(e.ColumnIndex).Name = "CANTIDAD" Then 'Si se modifica la cantidad de un producto

            'Primero chequeo si se posee stock del producto.
            If NegStock.ComprobarStock(DG_Productos("id_Producto", e.RowIndex).Value, DG_Productos(e.ColumnIndex, e.RowIndex).Value.ToString(), id_Sucursal) Then
                'Actualizo el campo SUBTOTAL del producto.
                DG_Productos("SUBTOTAL", e.RowIndex).Value = Format(CType(DG_Productos(e.ColumnIndex, e.RowIndex).Value.ToString() * DG_Productos("COSTO", e.RowIndex).Value.ToString(), Decimal), "###0.00")
                'Recalculo el Total y lo muestro en el label
                txt_Total.Text = Format(CType(CalcularPrecioTotal(), Decimal), "###0.00")
                txt_Cantidad.Text = CalcularCantidadTotal()
            Else
                'Actualizo el campo SUBTOTAL del producto.
                DG_Productos("SUBTOTAL", e.RowIndex).Value = Format(CType(DG_Productos("COSTO", e.RowIndex).Value.ToString(), Decimal), "###0.00")
                DG_Productos(e.ColumnIndex, e.RowIndex).Value = 1
                'Recalculo el Total y lo muestro en el label
                txt_Total.Text = Format(CType(CalcularPrecioTotal(), Decimal), "###0.00")
                txt_Cantidad.Text = CalcularCantidadTotal()
                Dim entStock As New Entidades.Stock
                entStock = NegStock.TraerStockProducto(DG_Productos("id_Producto", e.RowIndex).Value, id_Sucursal)

                MessageBox.Show("El producto seleccionado no cuenta con stock suficiente en la sucursal." + vbCrLf + "Stock actual: " + entStock.Stock_Actual.ToString, "Movimientos | Egresos | Cargar Mercaderías", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End If
        End If
    End Sub

    Private Sub DG_Productos_CellFormatting(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellFormattingEventArgs) Handles DG_Productos.CellFormatting
        If Not IsNothing(e.Value) Then
            If IsNumeric(e.Value) Then
                e.Value = Format(CDbl(e.Value), e.CellStyle.Format)
            End If
        End If
    End Sub

    'Abre la ventana de busqueda de productos.
    Private Sub Btn_Buscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_Buscar.Click
        Me.Cursor = Cursors.WaitCursor
        Funciones.ControlInstancia(frmBuscarProducto).MdiParent = MDIContenedor
        Funciones.ControlInstancia(frmBuscarProducto).Show()
        frmBuscarProducto.TipoForm = 3
        Me.Cursor = Cursors.Arrow
    End Sub
#End Region

#Region "Funciones del formulario"
    'Funcion empleada para limpiar el formulario.
    Sub LimpiarFormDevoluciones()
        DG_Productos.Rows.Clear()
        txt_Cantidad.Text = 0
        txt_CodigoBarra.Clear()
        txt_Total.Text = "0,00"
        txt_CodigoBarra.Focus()
    End Sub

    'Funcion que agrega un nuevo item al DATAGRID - Tipo: 1-ID | 2-CODIGO DE BARRA | 3-CODIGO
    Public Sub AgregarItem(ByVal Numero As String, ByVal Tipo As Integer, Optional ByVal Cantidad As Integer = 1)
        Try
            'Seteo el cursor.
            Me.Cursor = Cursors.WaitCursor

            'Declaracion de Variables
            Dim NumeroFila As Integer = 0
            Dim i As Integer
            Dim subtotal As Double = 0
            Dim Repetido As Boolean = False
            Dim SinStock As Boolean = False
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
                MessageBox.Show("No se ha encontrado el producto. Por favor, intente nuevamente.", "Movimientos | Egresos | Cargar Mercaderías", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Exit Sub
            End If

            'Primero chequeo si se posee stock del producto.
            If NegStock.ComprobarStock(EntProducto.id_Producto, Cantidad, id_Sucursal) Then
                SinStock = False
            Else
                SinStock = True
            End If

            'Me fijo si ya se encuentra agregado. Si está aumento su cantidad.
            For i = 0 To DG_Productos.Rows.Count - 1
                If DG_Productos.Rows(i).Cells.Item("id_Producto").Value = EntProducto.id_Producto Then
                    Repetido = True
                    'Primero chequeo si se posee stock del producto.
                    If NegStock.ComprobarStock(EntProducto.id_Producto, (DG_Productos.Rows(i).Cells.Item("CANTIDAD").Value + Cantidad), id_Sucursal) Then
                        DG_Productos.Rows(i).Cells.Item("CANTIDAD").Value += Cantidad
                        'Lo muestro en el label
                        txt_Total.Text = Format(CType(CalcularPrecioTotal(), Decimal), "###0.00")
                        txt_Cantidad.Text = CalcularCantidadTotal()
                    Else
                        MessageBox.Show("El producto seleccionado no cuenta con stock suficiente en la sucursal.", "Movimientos | Egresos | Cargar Mercaderías", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    End If
                End If
            Next

            'Si no estaba agregado y hay stock inserto una nueva fila.
            If Repetido = False And SinStock = False Then
                NumeroFila = DG_Productos.Rows.Count + 1

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

                'Valor de la Columna Costo
                dgvCell = New DataGridViewTextBoxCell()
                dgvCell.Value = Format(CType(EntProducto.Costo, Decimal), "###0.00")
                dgvRow.Cells.Add(dgvCell)

                'Valor de la Columna Cantidad
                dgvCell = New DataGridViewTextBoxCell()
                dgvCell.Value = Cantidad
                dgvRow.Cells.Add(dgvCell)

                'Valor de la Columna Stock
                Dim entStock As New Entidades.Stock
                entStock = NegStock.TraerStockProducto(EntProducto.id_Producto, id_Sucursal)
                dgvCell = New DataGridViewTextBoxCell()
                dgvCell.Value = entStock.Stock_Actual
                dgvRow.Cells.Add(dgvCell)

                'Valor de la Columna Subtotal
                dgvCell = New DataGridViewTextBoxCell()
                dgvCell.Value = Format(CType(EntProducto.Costo * Cantidad, Decimal), "###0.00")
                dgvRow.Cells.Add(dgvCell)

                'Valor de la Columna Eliminar
                dgvCell = New DataGridViewImageCell()
                dgvCell.Value = My.Resources.Recursos.Boton_Eliminar
                dgvRow.Cells.Add(dgvCell)

                dgvRow.Height = "30"

                'Inserto la fila
                DG_Productos.Rows.Add(dgvRow)
            End If

            If SinStock Then
                Me.Cursor = Cursors.Arrow
                MessageBox.Show("El producto seleccionado no cuenta con stock suficiente en la sucursal.", "Movimientos | Egresos | Cargar Mercaderías", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End If

            'Lo muestro en el label
            txt_Total.Text = Format(CType(CalcularPrecioTotal(), Decimal), "###0.00")
            txt_Cantidad.Text = CalcularCantidadTotal()

            'Borro el textbox
            txt_CodigoBarra.Clear()
            txt_CodigoBarra.Focus()

            'Seteo el cursor.
            Me.Cursor = Cursors.Arrow
        Catch ex As Exception
            Me.Cursor = Cursors.Arrow
            MessageBox.Show("Se ha producido un error al agregar el producto.", "Movimientos | Egresos | Cargar Mercaderías", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Public Sub AgregarItemsDeBDD(ByVal dsProd As DataTable)
        'Declaracion de Variables
        Dim NumeroFila As Integer = 0
        For Each prod In dsProd.Rows
            NumeroFila = DG_Productos.Rows.Count + 1

            'Creo la fila del producto.
            Dim dgvRow As New DataGridViewRow
            Dim dgvCell As DataGridViewCell

            'Valor de la Columna Numero
            dgvCell = New DataGridViewTextBoxCell()
            dgvCell.Value = NumeroFila
            dgvRow.Cells.Add(dgvCell)

            'Valor de la Columna Id
            dgvCell = New DataGridViewTextBoxCell()
            dgvCell.Value = prod.item("id_Producto")
            dgvRow.Cells.Add(dgvCell)

            'Valor de la Columna Codigo
            dgvCell = New DataGridViewTextBoxCell()
            dgvCell.Value = prod.item("Codigo")
            dgvRow.Cells.Add(dgvCell)

            'Valor de la Columna Nombre
            dgvCell = New DataGridViewTextBoxCell()
            dgvCell.Value = prod.item("Nombre")
            dgvRow.Cells.Add(dgvCell)

            'Valor de la Columna Costo
            dgvCell = New DataGridViewTextBoxCell()
            dgvCell.Value = Format(CType(prod.item("Costo"), Decimal), "###0.00")
            dgvRow.Cells.Add(dgvCell)

            'Valor de la Columna Cantidad
            dgvCell = New DataGridViewTextBoxCell()
            dgvCell.Value = prod.item("Cantidad")
            dgvRow.Cells.Add(dgvCell)

            'Valor de la Columna Stock
            dgvCell = New DataGridViewTextBoxCell()
            dgvCell.Value = prod.item("Stock")
            dgvRow.Cells.Add(dgvCell)

            'Valor de la Columna Subtotal
            dgvCell = New DataGridViewTextBoxCell()
            dgvCell.Value = Format(CType(prod.item("Costo") * prod.item("Cantidad"), Decimal), "###0.00")
            dgvRow.Cells.Add(dgvCell)

            'Valor de la Columna Eliminar
            dgvCell = New DataGridViewImageCell()
            dgvCell.Value = My.Resources.Recursos.Boton_Eliminar
            dgvRow.Cells.Add(dgvCell)

            dgvRow.Height = "30"

            'Inserto la fila
            DG_Productos.Rows.Add(dgvRow)
        Next

        'Lo muestro en el label
        txt_Total.Text = Format(CType(CalcularPrecioTotal(), Decimal), "###0.00")
        txt_Cantidad.Text = CalcularCantidadTotal()
    End Sub

    'Funcion que calcula el total en pesos del DATAGRID
    Function CalcularPrecioTotal()
        Dim subtotal As Double
        For i = 0 To (DG_Productos.Rows.Count - 1)
            subtotal += DG_Productos.Rows(i).Cells.Item("SUBTOTAL").Value
        Next
        Return subtotal
    End Function

    'Funcion que calcula la cantidad de productos del DATAGRID
    Function CalcularCantidadTotal()
        Return DG_Productos.Rows.Count
    End Function
#End Region

End Class