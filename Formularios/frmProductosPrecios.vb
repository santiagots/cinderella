Public Class frmProductosPrecios
    Dim NegProveedor As New Negocio.NegProveedores
    Dim NegProductos As New Negocio.NegProductos
    Dim HayCambios As Boolean = False
    Dim Salir As Boolean = True
    'Cuando se carga el formulario.
    Private Sub frmProductosPrecios_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Cambio el cursor.
        Me.Cursor = Cursors.WaitCursor

        'Cargo el combo con los proveedores.
        Dim dsProveedores As New DataSet
        dsProveedores = NegProveedor.ListadoProveedores()
        If dsProveedores.Tables(0).Rows.Count > 0 Then
            Cb_Proveedor.DataSource = Nothing
            Cb_Proveedor.DataSource = dsProveedores.Tables(0)
            Cb_Proveedor.DisplayMember = "RazonSocial"
            Cb_Proveedor.ValueMember = "id_Proveedor"
            Cb_Proveedor.Refresh()
        End If

        'Cambio el cursor.
        Me.Cursor = Cursors.Arrow
    End Sub

    'Boton que busca los productos dependiendo del proveedor.
    Private Sub btn_Buscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Buscar.Click
        If Cb_Proveedor.SelectedValue <> 0 Then
            'Cambio el cursor.
            Me.Cursor = Cursors.WaitCursor

            If HayCambios Then
                If (MessageBox.Show("Ha modificado precios y no han sido guardados. ¿Está seguro que desea cambiar de proveedor?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = vbYes) Then
                    Salir = True
                Else
                    Salir = False
                End If
            End If

            If Salir Then
                'id Proveedor
                Dim id_Proveedor As Integer = Cb_Proveedor.SelectedValue

                'Vacio el grid.
                DG_Productos.DataSource = Nothing
                DG_Productos.Rows.Clear()
                DG_Productos.ColumnHeadersVisible = False
                DG_Productos.ScrollBars = ScrollBars.None
                DG_Productos.Update()
                DG_Productos.Refresh()

                DG_Productos.Columns("id_Producto").ValueType = GetType(System.Int16)
                DG_Productos.Columns("Nombre").ValueType = GetType(System.String)
                DG_Productos.Columns("Codigo").ValueType = GetType(System.String)
                DG_Productos.Columns("Costo").ValueType = GetType(System.String)
                DG_Productos.Columns("Precio1").ValueType = GetType(System.Double)
                DG_Productos.Columns("Precio2").ValueType = GetType(System.Double)
                DG_Productos.Columns("Precio3").ValueType = GetType(System.Double)
                DG_Productos.Columns("Precio4").ValueType = GetType(System.Double)
                DG_Productos.Columns("Precio5").ValueType = GetType(System.Double)
                DG_Productos.Columns("Precio6").ValueType = GetType(System.Double)

                Try
                    'Obtengo los productos
                    Dim dsProductos As DataSet 'Dataset donde almaceno todos los productos.
                    Dim Str As String = ""
                    dsProductos = NegProductos.ListadoProductosPorProveedor(id_Proveedor)
                    If dsProductos.Tables(0).Rows.Count > 0 Then 'Si hay registros.

                        For Each prod In dsProductos.Tables(0).Rows

                            ' Str &= prod.item("id_Producto").ToString & "-" & dsPrecios.Tables(0).Rows.Count & vbCrLf
                            Dim dsPrecios As DataSet 'Dataset donde almaceno todos los precios.
                            dsPrecios = NegProductos.ListadoProductosPrecios(prod.item("id_Producto"))

                            If dsPrecios.Tables(0).Rows.Count = 6 Then

                                'Inserto en el Grid.
                                'Creo la fila del ingreso.
                                Dim dgvRow As New DataGridViewRow
                                Dim dgvCell As DataGridViewCell

                                'Valor de la Columna iD producto
                                dgvCell = New DataGridViewTextBoxCell()
                                dgvCell.ValueType = GetType(System.Int16)
                                dgvCell.Value = prod.item("id_Producto").ToString
                                dgvRow.Cells.Add(dgvCell)

                                'Valor de la Columna Nombre de producto
                                dgvCell = New DataGridViewTextBoxCell()
                                dgvCell.ValueType = GetType(System.String)
                                dgvCell.Value = prod.item("Nombre").ToString
                                dgvCell.ToolTipText = "Éste campo no es editable."
                                dgvRow.Cells.Add(dgvCell)

                                'Valor de la Columna Codigo
                                dgvCell = New DataGridViewTextBoxCell()
                                dgvCell.ValueType = GetType(System.String)
                                dgvCell.Value = prod.item("Codigo").ToString
                                dgvCell.ToolTipText = "Éste campo no es editable."
                                dgvRow.Cells.Add(dgvCell)

                                'Valor de la Columna Costo
                                dgvCell = New DataGridViewTextBoxCell()
                                dgvCell.ValueType = GetType(System.String)
                                dgvCell.Value = prod.item("Costo").ToString
                                dgvRow.Cells.Add(dgvCell)

                                For Each pre In dsPrecios.Tables(0).Rows
                                    'Valor de la Columna Precios
                                    dgvCell = New DataGridViewTextBoxCell()
                                    dgvCell.ValueType = GetType(System.Double)
                                    dgvCell.Value = pre.item("Precio").ToString
                                    dgvRow.Cells.Add(dgvCell)
                                Next

                                dgvRow.Height = "20"

                                'Inserto la fila.
                                DG_Productos.Rows.Add(dgvRow)
                            End If
                        Next

                        DG_Productos.ColumnHeadersVisible = True
                        DG_Productos.Columns("id_Producto").Visible = False
                        DG_Productos.ScrollBars = ScrollBars.Vertical
                        DG_Productos.Update()


                    End If
                Catch ex As Exception
                    MessageBox.Show("Se ha encontrado un error a cargar los productos.", "Administración de Precios de Productos", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End Try
            End If
            'Cambio el cursor.
            Me.Cursor = Cursors.Arrow
        Else
            MessageBox.Show("Debe seleccionar un proveedor de la lista.", "Administración de Precios de Productos", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub

    'Boton que resetea el filtro.
    Private Sub Btn_Cancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_Cancelar.Click
        Limpiar()
    End Sub

    'Cuando finaliza la edicion.
    Private Sub Btn_Finalizar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_Finalizar.Click
        Try
            If Cb_Proveedor.SelectedValue <> 0 Then
                If (MessageBox.Show("Se llevará a cabo la modificación de precios en los productos, ¿Desea Continuar?.", "Administración de Precios de Productos", MessageBoxButtons.YesNo, MessageBoxIcon.Information) = vbYes) Then

                    'Cambio el cursor.
                    Me.Cursor = Cursors.WaitCursor

                    'Actualizo los precios de cada producto.
                    For i = 0 To DG_Productos.Rows.Count - 1
                        Dim id_Proveedor As Integer = 0  'Proveedor.
                        Dim id_Producto As Integer = 0 'Producto.
                        Dim Precio As Double = 0 'Precio.
                        Dim Costo As Double = 0 'Costo

                        'id_Producto.
                        id_Producto = DG_Productos.Rows(i).Cells.Item("id_Producto").Value
                        Costo = DG_Productos.Rows(i).Cells.Item("Costo").Value

                        'Actualizo el costo del producto
                        NegProductos.ModificacionCosto(id_Producto, Costo)

                        'inserto los precios
                        For j = 1 To 6 'for para actualizar todas las Listas.

                            'Dependiendo de la lista, selecciono el precio.
                            If j = 1 Then
                                Precio = DG_Productos.Rows(i).Cells.Item("Precio1").Value
                            ElseIf j = 2 Then
                                Precio = DG_Productos.Rows(i).Cells.Item("Precio2").Value
                            ElseIf j = 3 Then
                                Precio = DG_Productos.Rows(i).Cells.Item("Precio3").Value
                            ElseIf j = 4 Then
                                Precio = DG_Productos.Rows(i).Cells.Item("Precio4").Value
                            ElseIf j = 5 Then
                                Precio = DG_Productos.Rows(i).Cells.Item("Precio5").Value
                            ElseIf j = 6 Then
                                Precio = DG_Productos.Rows(i).Cells.Item("Precio6").Value
                            End If

                            'Edito el Precio del producto.
                            NegProductos.ModificacionPrecio(id_Producto, j, Precio)
                        Next
                    Next

                    'Cambio el cursor.
                    Me.Cursor = Cursors.Arrow
                    Limpiar()
                    HayCambios = False
                    'Msg.
                    MessageBox.Show("Se han modificado los precios correctamente.", "Administración de Precios de Productos", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
            Else
                'Msg.
                MessageBox.Show("Debe seleccionar un proveedor de la lista.", "Administración de Precios de Productos", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End If
        Catch ex As Exception
            'Msg.
            MessageBox.Show("Se ha encontrado un error a modificar los precios.", "Administración de Precios de Productos", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Sub Limpiar()
        Cb_Proveedor.SelectedItem = Nothing
        DG_Productos.DataSource = Nothing
        DG_Productos.Rows.Clear()
        DG_Productos.ColumnHeadersVisible = False
        DG_Productos.ScrollBars = ScrollBars.None
        DG_Productos.Update()
        DG_Productos.Refresh()
    End Sub

    Private Sub DG_Productos_CellEndEdit(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DG_Productos.CellEndEdit
        HayCambios = True
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
            .BackColor = Color.Aquamarine
        End With
    End Sub

    'Obtengo las celdas copiadas.
    Private Sub DG_Productos_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles DG_Productos.KeyDown
        If (e.Control AndAlso e.KeyCode = Keys.V) OrElse (e.Shift AndAlso e.KeyCode = Keys.Insert) Then
            Dim grid As DataGridView = TryCast(sender, DataGridView)
            Dim rowIndex As Integer = grid.CurrentCell.RowIndex
            Dim colIndex As Integer = grid.CurrentCell.ColumnIndex

            Dim cb As String() = Clipboard.GetText(TextDataFormat.Text).Split(New String(0) {vbCr & vbLf}, StringSplitOptions.None)

            If cb.Length > grid.Rows.Count - rowIndex Then
                grid.Rows.Add(cb.Length - grid.Rows.Count - rowIndex)
            End If

            For i As Integer = 0 To cb.Length - 1
                If Not cb(i).Equals("") Then
                    Dim cells As [String]() = cb(i).Split(New String(0) {vbTab}, StringSplitOptions.None)

                    For j As Integer = 0 To cells.Length - 1
                        If grid.CurrentCell.ColumnIndex + j < grid.Columns.Count Then
                            Try
                                grid(j + colIndex, i + rowIndex).Value = Convert.ChangeType(cells(j), grid.Columns(j + colIndex).ValueType)
                            Catch generatedExceptionName As FormatException
                                MessageBox.Show("Los datos pegados están en formato erroneo para la celda (" & (i + rowIndex) & "," & (j + colIndex) & ")", "Administración de Precios de Productos", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                            End Try
                        End If
                    Next
                End If
            Next
        End If
    End Sub

End Class