Public Class frmDevoluciones
    'Instancias
    Dim NegProductos As New Negocio.NegProductos
    Dim NegMovimientos As New Negocio.NegMovimientos
    Dim EntProducto As New Entidades.Productos
    Dim EMovEgreso As New Entidades.MovEgreso
    Dim Funciones As New Funciones
    Dim NegStock As New Negocio.NegStock
    Dim id_Sucursal As Integer
    Dim Nombre_Sucursal As String

#Region "Eventos del formulario"
    'Load del formulario.
    Private Sub frmCambios_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Cambio el cursor a "WAIT"
        Me.Cursor = Cursors.WaitCursor

        'Sucursal default
        id_Sucursal = My.Settings("Sucursal")
        Nombre_Sucursal = My.Settings("NombreSucursal")

        'Seteo la fecha
        lbl_Fecha.Text = Now.Date.ToString("d MMM yyyy")

        'Seteo el nombre de la sucursal
        lbl_Sucursal.Text = Nombre_Sucursal

        'Oculto Columnas en el DG_Productos
        DG_Productos.Columns("Numero").Visible = False
        DG_Productos.Columns("ID").Visible = False

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
        Dim TotalProductos As Integer = DG_Productos.Rows.Count 'Total de productos cargados.
        Dim TotalMonto As Double = CalcularPrecioTotal()
        Dim id_Producto As Integer = 0

        'Chequeo que haya al menos un producto cargado.
        If TotalProductos <= 0 Then
            'Muestro Mensaje.
            MessageBox.Show("La devolución no puede efectuarse. No hay productos cargados !!", "Administración de Devoluciones", MessageBoxButtons.OK, MessageBoxIcon.Stop)
        Else
            'Si confirma la devolución.
            If MessageBox.Show("¿Ésta seguro que desea efectuar la devolución?", "Administración de Devoluciones", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = vbYes Then
                Try
                    'cursor..
                    Me.Cursor = Cursors.WaitCursor

                    'Agrego el stock del producto en la sucursal.
                    For i = 0 To DG_Productos.Rows.Count - 1
                        id_Producto = CInt(DG_Productos.Rows(i).Cells.Item("ID").Value)
                        NegStock.AgregarStock(id_Producto, id_Sucursal, 1)
                    Next

                    'Se registra el movimiento de salida de dinero en la sucursal.
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
    End Sub

    'Evento que se ejecuta cuando cancela la devolucion.
    Private Sub Btn_Cancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_Cancelar.Click
        If MessageBox.Show("Ésta seguro que desea cancelar la devolucion?", "Administración de Devoluciones", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = vbYes Then
            'Limpio el Formulario.
            LimpiarFormDevoluciones()
        End If
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        lbl_Hora.Text = Date.Now.ToLongTimeString
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
        Funciones.ControlInstancia(frmBuscarProducto).Show()
        frmBuscarProducto.TipoForm = 2
        Me.Cursor = Cursors.Arrow
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
                MessageBox.Show("No se ha encontrado el producto. Por favor, intente nuevamente.", "Registro de Ventas", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Exit Sub
            End If

            'Me fijo si ya se encuentra agregado. Si está lo informo al usuario.
            For i = 0 To DG_Productos.Rows.Count - 1
                If DG_Productos.Rows(i).Cells.Item("ID").Value = EntProducto.id_Producto Then
                    Me.Cursor = Cursors.Arrow
                    MessageBox.Show("El producto seleccionado ya se encuentra agregado.", "Administración de Devoluciones", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    Repetido = True
                End If
            Next

            'Depende de la lista de precios asignada, le asigno un determinado precio al producto.
            Dim Precio As Double = 0
            Select Case My.Settings("ListaPrecio")
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
            If Repetido = False Then
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

                'Valor de la Columna Descripcion
                dgvCell = New DataGridViewTextBoxCell()
                If EntProducto.Descripcion <> "" Then
                    dgvCell.Value = EntProducto.Descripcion
                Else
                    dgvCell.Value = "- - -"
                End If
                dgvRow.Cells.Add(dgvCell)

                'Valor de la Columna Precio
                dgvCell = New DataGridViewTextBoxCell()
                dgvCell.Value = Precio
                dgvRow.Cells.Add(dgvCell)

                'Valor de la Columna Eliminar
                dgvCell = New DataGridViewImageCell()
                dgvCell.Value = My.Resources.Recursos.Boton_Eliminar
                dgvRow.Cells.Add(dgvCell)

                dgvRow.Height = "30"

                'Inserto la fila
                DG_Productos.Rows.Add(dgvRow)
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
            MessageBox.Show("Se ha producido un error al agregar el producto.", "Administración de Devoluciones", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    'Funcion que calcula el total en pesos del DATAGRID
    Function CalcularPrecioTotal()
        Dim subtotal As Double
        For i = 0 To (DG_Productos.Rows.Count - 1)
            subtotal += DG_Productos.Rows(i).Cells.Item("PRECIO").Value
        Next
        Return subtotal
    End Function

    'Funcion que calcula la cantidad de productos del DATAGRID
    Function CalcularCantidadTotal()
        Return DG_Productos.Rows.Count
    End Function

    'Funcion empleada para limpiar el formulario de devoluciones.
    Sub LimpiarFormDevoluciones()
        DG_Productos.Rows.Clear()
        txt_Cantidad.Text = 0
        txt_CodigoBarra.Clear()
        txt_Total.Text = "0,00"
        txt_CodigoBarra.Focus()
    End Sub
#End Region

    Private Sub txt_CodigoBarra_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_CodigoBarra.TextChanged

    End Sub
End Class