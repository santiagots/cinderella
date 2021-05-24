Public Class frmProductosMasiva
    Dim NegProductos As New Negocio.NegProductos
    Dim NegProductosCat As New Negocio.NegProductosCategorias
    Dim NegProductosSubCat As New Negocio.NegProductosSubcategorias
    Dim NegProveedores As New Negocio.NegProveedores
    Dim NegAromas As New Negocio.NegAromas
    Dim NegMateriales As New Negocio.NegMateriales
    Dim NegColores As New Negocio.NegColores
    Dim Funciones As New Funciones
    Private m_comboBox As ComboBox

    'Load del formulario.
    Private Sub frmProductosMasiva_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Cambio el cursor.
        Me.Cursor = Cursors.WaitCursor

        dgProductos.AutoGenerateColumns = False
        Dim ComboCategoria As DataGridViewComboBoxColumn = DirectCast(dgProductos.Columns("Categoria"), DataGridViewComboBoxColumn)
        Dim ComboProveedor As DataGridViewComboBoxColumn = DirectCast(dgProductos.Columns("Proveedor"), DataGridViewComboBoxColumn)
        Dim ComboAromas As DataGridViewComboBoxColumn = DirectCast(dgProductos.Columns("Aroma"), DataGridViewComboBoxColumn)
        Dim ComboMateriales As DataGridViewComboBoxColumn = DirectCast(dgProductos.Columns("Material"), DataGridViewComboBoxColumn)
        Dim ComboColores As DataGridViewComboBoxColumn = DirectCast(dgProductos.Columns("Color"), DataGridViewComboBoxColumn)

        'Cargo el combo de Categorias
        If (NegProductosCat.ListadoCategorias.Tables.Count <> 0) Then
            ComboCategoria.DataSource = Nothing
            ComboCategoria.DataSource = NegProductosCat.ListadoCategorias().Tables(0)
            ComboCategoria.DisplayMember = "Descripcion"
            ComboCategoria.ValueMember = "id_Categoria"
        End If

        Dim ComboSubCategoria As DataGridViewComboBoxColumn = DirectCast(dgProductos.Columns("Subcategoria"), DataGridViewComboBoxColumn)

        'Cargo el Combo de Subcategorias
        ComboSubCategoria.DataSource = Nothing
        ComboSubCategoria.DisplayMember = "Descripcion"
        ComboSubCategoria.ValueMember = "id_Subcategoria"
    

        'Cargo el combo de Proveedores.
        If (NegProveedores.ListadoProveedores.Tables.Count <> 0) Then
            ComboProveedor.DataSource = Nothing
            ComboProveedor.DataSource = NegProveedores.ListadoProveedores().Tables(0)
            ComboProveedor.DisplayMember = "RazonSocial"
            ComboProveedor.ValueMember = "id_Proveedor"
        End If

        'Cargo el combo de Aromas.
        If (NegAromas.ListadoAromas.Tables.Count <> 0) Then
            ComboAromas.DataSource = Nothing
            ComboAromas.DataSource = NegAromas.ListadoAromas().Tables(0)
            ComboAromas.DisplayMember = "Descripcion"
            ComboAromas.ValueMember = "id_Aroma"
        End If

        'Cargo el combo de Materiales.
        If (NegMateriales.ListadoMateriales.Tables.Count <> 0) Then
            ComboMateriales.DataSource = Nothing
            ComboMateriales.DataSource = NegMateriales.ListadoMateriales().Tables(0)
            ComboMateriales.DisplayMember = "Descripcion"
            ComboMateriales.ValueMember = "id_Material"
        End If

        'Cargo el combo de Colores.
        If (NegColores.ListadoColores.Tables.Count <> 0) Then
            ComboColores.DataSource = Nothing
            ComboColores.DataSource = NegColores.ListadoColores().Tables(0)
            ComboColores.DisplayMember = "Descripcion"
            ComboColores.ValueMember = "id_Color"
        End If

        'Cambio el cursor.
        Me.Cursor = Cursors.Arrow
    End Sub

    'Programo para que cuando realice un click en el datagrid puede ser editado.
    Private Sub dgProductos_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgProductos.CellClick
        dgProductos.EditMode = DataGridViewEditMode.EditProgrammatically
        dgProductos.CurrentCell = dgProductos.CurrentCell
        dgProductos.BeginEdit(True)
    End Sub

    'Programo para que cuando salte a una nueva fila pueda ser editada.
    Private Sub dgProductos_CellEnter(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgProductos.CellEnter
        dgProductos.EditMode = DataGridViewEditMode.EditProgrammatically
        dgProductos.CurrentCell = dgProductos.CurrentCell
        dgProductos.BeginEdit(True)
    End Sub

    'Programo para que cuando realice un click en el datagrid puede ser editado.
    Private Sub dgProductos_DataError(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewDataErrorEventArgs) Handles dgProductos.DataError
        e.Cancel = False
    End Sub

    'Agrego el change al combo de categoria.
    Private Sub dgProductos_EditingControlShowing(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewEditingControlShowingEventArgs) Handles dgProductos.EditingControlShowing
        If e.Control.GetType Is GetType(DataGridViewComboBoxEditingControl) Then
            m_comboBox = DirectCast(e.Control, ComboBox)
            If CStr(m_comboBox.ValueMember) = "id_Categoria" Then
                ' Instalamos el controlador para el evento SelectedValueChanged
                AddHandler m_comboBox.SelectedValueChanged, AddressOf ComboBoxOnSelectedValueChanged
            End If
        End If
    End Sub

    'Funcion que sobreescribe el selectedchange del combo
    Private Sub ComboBoxOnSelectedValueChanged( _
        ByVal sender As Object, ByVal e As EventArgs)

        ' Referenciamos el control ComboBox que ha
        ' desencadenado el evento.
        Dim cb As ComboBox = DirectCast(sender, ComboBox)

        If CStr(cb.ValueMember) = "id_Categoria" Then
            ' Obtenemos el valor de su propiedad ValueMember
            Dim value As Object = cb.SelectedValue
            'Row donde se está llevando a cabo la edicion
            Dim row As Integer = DirectCast(DirectCast(sender, System.Windows.Forms.DataGridViewComboBoxEditingControl).EditingControlDataGridView.CurrentCell, System.Windows.Forms.DataGridViewComboBoxCell).RowIndex

            If value IsNot Nothing Then
                ' Dim ComboSubCategoria As DataGridViewComboBoxColumn = DirectCast(dgProductos.Columns("Subcategoria"), DataGridViewComboBoxColumn)
                Dim ComboSubCategoria As DataGridViewComboBoxCell = DirectCast(dgProductos("Subcategoria", row), DataGridViewComboBoxCell)
                If (NegProductosSubCat.ListadoSubcategorias(value).Tables.Count <> 0) Then
                    ComboSubCategoria.DataSource = NegProductosSubCat.ListadoSubcategorias(value).Tables(0)
                    ComboSubCategoria.DisplayMember = "Descripcion"
                    ComboSubCategoria.ValueMember = "id_Subcategoria"
                End If

                RemoveHandler m_comboBox.SelectedValueChanged, AddressOf ComboBoxOnSelectedValueChanged
            End If
        End If
    End Sub

    Private Sub dgProductos_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles dgProductos.KeyDown
        Dim col As Integer = dgProductos.CurrentCell.ColumnIndex
        Dim row As Integer = dgProductos.CurrentCell.RowIndex
        If Not (row = dgProductos.NewRowIndex) Then
            If col = (dgProductos.Columns.Count - 1) Then
                col = -1
                row += 1
            Else
                col -= 1
            End If
            dgProductos.CurrentCell = dgProductos(col + 1, row)
            dgProductos.BeginEdit(True)
        End If
    End Sub

    'Valido el row ingresado.
    Private Sub dgProductos_RowValidating(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellCancelEventArgs) Handles dgProductos.RowValidating
        If m_comboBox IsNot Nothing Then
            ' Desinstalamos el controlador de eventos
            RemoveHandler m_comboBox.SelectedValueChanged, AddressOf ComboBoxOnSelectedValueChanged
        End If

        'VALIDACIONES CUANDO TERMINA UNA FILA.
        Try
            'Si no es una nueva fila la valido.
            If Not dgProductos.Rows(e.RowIndex).IsNewRow Then
                'Controlo que completo el nombre
                If dgProductos.Rows(e.RowIndex).Cells("Nombre").Value Is Nothing Or dgProductos.Rows(e.RowIndex).Cells("Nombre").Value = "" Then
                    dgProductos.CurrentRow.Cells("Nombre").ErrorText = "Éste campo es requerido. Por Favor, Complétalo."
                Else
                    dgProductos.CurrentRow.Cells("Nombre").ErrorText = ""
                End If

                'Controlo que completo el Codigo
                If dgProductos.Rows(e.RowIndex).Cells("Codigo").Value Is Nothing Or dgProductos.Rows(e.RowIndex).Cells("Codigo").Value = "" Then
                    dgProductos.CurrentRow.Cells("Codigo").ErrorText = "Éste campo es requerido. Por Favor, Complétalo."
                Else
                    dgProductos.CurrentRow.Cells("Codigo").ErrorText = ""
                End If

                'Controlo que completo el Categoria
                If dgProductos.Rows(e.RowIndex).Cells("Categoria").Value Is Nothing Or dgProductos.Rows(e.RowIndex).Cells("Categoria").Value = 0 Then
                    dgProductos.CurrentRow.Cells("Categoria").ErrorText = "Éste campo es requerido. Por Favor, Complétalo."
                Else
                    dgProductos.CurrentRow.Cells("Categoria").ErrorText = ""
                End If

                'Controlo que completo el Subcategoria
                If dgProductos.Rows(e.RowIndex).Cells("Subcategoria").Value Is Nothing Or dgProductos.Rows(e.RowIndex).Cells("Subcategoria").Value = 0 Then
                    dgProductos.CurrentRow.Cells("Subcategoria").ErrorText = "Éste campo es requerido. Por Favor, Complétalo."
                Else
                    dgProductos.CurrentRow.Cells("Subcategoria").ErrorText = ""
                End If

                'Controlo que completo el Codigo
                If dgProductos.Rows(e.RowIndex).Cells("Proveedor").Value Is Nothing Or dgProductos.Rows(e.RowIndex).Cells("Proveedor").Value = 0 Then
                    dgProductos.CurrentRow.Cells("Proveedor").ErrorText = "Éste campo es requerido. Por Favor, Complétalo."
                Else
                    dgProductos.CurrentRow.Cells("Proveedor").ErrorText = ""
                End If
            End If
        Catch ex As Exception

        End Try
    End Sub

    'Cuando hace click en el boton Cargar.
    Private Sub Btn_Procesar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_Procesar.Click
        'Contadores
        Dim TotalProductos As Integer = 0
        Dim TotalProductosRechazados As Integer = -1
        Dim contador2 As Integer = 0
        Dim message_error As String = ""

        'Total de productos en el grid.
        For Each r In dgProductos.Rows
            If Trim(r.Cells.Item("Nombre").Value()) <> "" And Trim(r.Cells.Item("Codigo").Value()) <> "" And CInt(r.Cells.Item("Categoria").Value()) <> 0 And CInt(r.Cells.Item("Subcategoria").Value()) <> 0 And CInt(r.Cells.Item("Proveedor").Value()) <> 0 Then
                TotalProductos += 1
            Else
                TotalProductosRechazados += 1
            End If
        Next

        'Si hubo productos rechazados, muestro el mensaje de advertencia
        If TotalProductosRechazados > 0 Then
            message_error = vbCrLf & "No van a ser agregados " & TotalProductosRechazados & " producto/s."
        End If

        'Si no hay productos para agregar lanzo un mensaje.
        If TotalProductos <= 0 Then
            MessageBox.Show("No hay productos para cargar en el sistema. Revise la grilla.", "Administracíon de Producto | Alta Masiva", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        Else
            'Cuadro de confirmacion de accion.
            If MessageBox.Show("¿Está seguro que desea llevar a cabo el alta masiva de Productos?." & vbCrLf & "Se van a agregar " & TotalProductos & " producto/s." & message_error, "Administracíon de Producto | Alta Masiva", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = vbYes Then

                'Acepto, se cargan los productos.
                Try
                    'seteo el cursor a "WAIT"
                    Me.Cursor = Cursors.WaitCursor

                    'Muestro el form de espera..
                    frmCargadorAltaProductos.Show()
                    frmCargadorAltaProductos.BarraProgreso.Minimum = 0
                    frmCargadorAltaProductos.BarraProgreso.Maximum = TotalProductos

                    'Declaro variables.
                    Dim Web, Habilitado, Novedad As Integer

                    'Recorro las filas del grid.
                    For Each r In dgProductos.Rows
                        'Si no completo el campo Nombre, Codigo, categoria, subcategoria y proveedor no se inserta en la base de datos.
                        If Trim(r.Cells.Item("Nombre").Value()) <> "" And Trim(r.Cells.Item("Codigo").Value()) <> "" And CInt(r.Cells.Item("Categoria").Value()) <> 0 And CInt(r.Cells.Item("Subcategoria").Value()) <> 0 And CInt(r.Cells.Item("Proveedor").Value()) <> 0 Then

                            'Seteo variables
                            If r.Cells.Item("Web").Value() Then
                                Web = 1
                            Else
                                Web = 0
                            End If
                            If r.Cells.Item("Habilitado").Value() Then
                                Habilitado = 1
                            Else
                                Habilitado = 0
                            End If
                            If r.Cells.Item("Novedad").Value() Then
                                Novedad = 1
                            Else
                                Novedad = 0
                            End If

                            'Lleno la entidad productos
                            Dim EProductos As New Entidades.Productos
                            EProductos.Nombre = Trim(r.Cells.Item("Nombre").Value())
                            EProductos.Origen = Trim(r.Cells.Item("Origen").Value())
                            EProductos.Tamano = Trim(r.Cells.Item("Tamano").Value())
                            EProductos.Costo = CDbl(r.Cells.Item("Costo").Value())
                            EProductos.Codigo = Trim(r.Cells.Item("Codigo").Value())
                            EProductos.Precio1 = CDbl(r.Cells.Item("Precio1").Value())
                            EProductos.Precio2 = CDbl(r.Cells.Item("Precio2").Value())
                            EProductos.Precio3 = CDbl(r.Cells.Item("Precio3").Value())
                            EProductos.Precio4 = CDbl(r.Cells.Item("Precio4").Value())
                            EProductos.Precio5 = CDbl(r.Cells.Item("Precio5").Value())
                            EProductos.Precio6 = CDbl(r.Cells.Item("Precio6").Value())
                            EProductos.Foto = ""
                            EProductos.Descripcion = Trim(r.Cells.Item("Descripcion").Value())
                            EProductos.id_Categoria = CInt(r.Cells.Item("Categoria").Value())
                            EProductos.id_Subcategoria = CInt(r.Cells.Item("Subcategoria").Value())
                            EProductos.id_Proveedor = CInt(r.Cells.Item("Proveedor").Value())
                            EProductos.Habilitado = Habilitado
                            EProductos.Novedad = Novedad
                            EProductos.SubirWeb = Web
                            EProductos.id_Material = CInt(r.Cells.Item("Material").Value())
                            EProductos.id_Aroma = CInt(r.Cells.Item("Aroma").Value())
                            EProductos.id_Color = CInt(r.Cells.Item("Color").Value())

                            'Ejecuto el sp_Productos_Alta
                            NegProductos.AltaProductoMasivo(EProductos)

                            'Voy seteando la barra de progreso
                            contador2 += 1
                            frmCargadorAltaProductos.BarraProgreso.Value = contador2
                        End If
                    Next

                    'Borro el grid
                    LimpiarDataGrid()

                    'Oculto el form de espera..
                    frmCargadorAltaProductos.Close()

                    'seteo el cursor a "NORMAL"
                    Me.Cursor = Cursors.Arrow

                    'Indico que se llevo todo a cabo EXCELENTEMENTE.
                    MessageBox.Show("Los productos han sido cargados correctamente.", "Administración de Productos | Alta Masiva", MessageBoxButtons.OK, MessageBoxIcon.Information)

                Catch ex As Exception
                    'seteo el cursor a "NORMAL"
                    Me.Cursor = Cursors.Arrow
                    MessageBox.Show("Se ha producido un error al registrar el producto. Por favor, intente más tarde.", "Administración de Productos | Alta Masiva", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End Try
            Else
                'cancelo, no se lleva a cabo ninguna accion.
            End If
        End If
    End Sub

    'Funcion que vacia el datagridview.
    Public Sub LimpiarDataGrid()
        dgProductos.Rows.Clear()
        dgProductos.ClearSelection()
    End Sub

    'Cuando hace click en el boton Limpiar.
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_Limpiar.Click
        If MessageBox.Show("¿Está seguro que desea vaciar la grilla de Productos Cargados?", "Administracíon de Producto | Alta Masiva", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = vbYes Then
            'Acepto, se eliminan los productos.
            LimpiarDataGrid()
        End If
    End Sub

End Class