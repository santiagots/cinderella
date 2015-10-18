Imports System.Linq

Public Class frmVentas
    'Instancias
    Dim NegSucursal As New Negocio.NegSucursales
    Dim EntSucursal As Entidades.Sucursales
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
    Dim EntVentas As New Entidades.Ventas
    Dim EntDevolucion As New Entidades.Devolucion
    Dim Funciones As New Funciones
    Dim id_Sucursal As Integer
    Dim Nombre_Sucursal As String
    Dim ProductoCantidadAnterior As Integer


#Region "Region Funciones"
    'Limpiar Formulario
    Public Sub LimpiarFormVentas()
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
    Public Sub LimpiarFormVentas_2()
        DG_Productos.Rows.Clear()
        txt_Total.Text = "0,00"
        txt_Subtotal.Text = "0,00"
        txt_Descuento.Text = "0,00"
        Cb_ListaPrecio.SelectedIndex = Nothing
        txt_CodigoBarra.Clear()
        txt_CodigoBarra.Focus()
    End Sub

    'Funcion que agrega un nuevo item al DATAGRID - Tipo: 1-ID | 2-CODIGO DE BARRA | 3-CODIGO - TipoAccion: 1-Venta | 2-Cambio
    Public Sub AgregarItem(ByVal Numero As String, ByVal Tipo As Integer, Optional ByVal TipoAccion As Integer = 1)
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
            'Dim SinStock As Boolean = False
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
                                CalcularPreciosDescuento()
                                Return
                            Else
                                Return
                            End If
                        End If

                        DG_Productos.Rows(i).Cells.Item("CANTIDAD").Value += 1
                        DG_Productos.Rows(i).Cells.Item("SUBTOTAL").Value = (DG_Productos.Rows(i).Cells.Item("CANTIDAD").Value * DG_Productos.Rows(i).Cells.Item("PRECIO").Value)
                        CalcularPreciosDescuento()
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
                Precio = Format(CType(Precio, Decimal), "###0.00")

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

                'Valor de la Columna Subtotal
                dgvCell = New DataGridViewTextBoxCell()
                If TipoAccion = 2 Then
                    dgvCell.Value = (Precio * -1)
                Else
                    dgvCell.Value = Precio * cantidad
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
            End If

            'Lo muestro en el label
            CalcularPreciosDescuento()

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

    'Funcion que calcula el total en pesos del DATAGRID
    Function CalcularPrecioTotal()
        Dim subtotal As Double
        For i = 0 To (DG_Productos.Rows.Count - 1)
            subtotal += (DG_Productos.Rows(i).Cells.Item("PRECIO").Value * DG_Productos.Rows(i).Cells.Item("CANTIDAD").Value)
        Next
        Return subtotal
    End Function

    'Funcion que calcula la cantidad de productos del DATAGRID
    Function CalcularCantidadTotal()
        Dim cant As Integer
        For i = 0 To (DG_Productos.Rows.Count - 1)
            If CInt(DG_Productos.Rows(i).Cells.Item("PRECIO").Value) > 0 Then
                cant += CInt(DG_Productos.Rows(i).Cells.Item("CANTIDAD").Value)
            End If
        Next
        Return cant
    End Function

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
            'MessageBox.Show("No puede aplicar un descuento mayor o igual que el total de la compra.", "Registro de Ventas", MessageBoxButtons.OK, MessageBoxIcon.Warning)
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

    'Cancela la venta, setea variables por default.
    Private Sub Btn_Cancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_Cancelar.Click
        If MessageBox.Show("Ésta seguro que desea cancelar la venta?", "Registro de Ventas", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = vbYes Then
            'Limpio el Formulario.
            LimpiarFormVentas()
        End If
    End Sub

    'Si desea buscar un producto, se visualiza el formulario.
    Private Sub Btn_Buscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_Buscar.Click
        Me.Cursor = Cursors.WaitCursor
        Dim frmBuscarProducto As frmBuscarProducto = New frmBuscarProducto()
        frmBuscarProducto.ShowDialog()
        If (Not String.IsNullOrEmpty(frmBuscarProducto.idProducto)) Then
            AgregarItem(frmBuscarProducto.idProducto, 1)
        End If
        Me.Cursor = Cursors.Arrow
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
                    CalcularPreciosDescuento() 'Recalculo el Total y lo muestro en el label
                    txt_CodigoBarra.Focus()

                    'refresco el datagrid
                    DG_Productos.Refresh()
                End If
            End If
        End If
    End Sub

    'Cuando Carga el formulario de ventas.
    Private Sub frmVentas_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        'Seteo la fecha
        lbl_Fecha.Text = Now.Date.ToString("d MMM yyyy")

        'Pongo el combo en minorista y deshabilito la opcion de clientes.
        cb_Tipo.SelectedIndex = 0
        Gb_Cliente.Enabled = False

        'Sucursal default
        id_Sucursal = My.Settings("Sucursal")
        Nombre_Sucursal = My.Settings("NombreSucursal")

        'lleno la entidad sucursales
        EntSucursal = NegSucursal.TraerSucursal(id_Sucursal)

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
    End Sub

    'Actualizo la hora que se muestra dentro del formulario.
    Private Sub Reloj_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Reloj.Tick
        lbl_Hora.Text = Date.Now.ToLongTimeString
    End Sub

    'Dependiendo para que tipo de cliente es la venta, muestro o oculto el panel de clientes.
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

        LimpiarFormVentas_2()

        PosicionarListaPreciosSegunFormaDePago()

    End Sub

    'Programo para cuando modifica la cantidad de un producto se actualice el grid.
    Private Sub DG_Productos_CellEndEdit(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DG_Productos.CellEndEdit
        If DG_Productos.Columns(e.ColumnIndex).Name = "CANTIDAD" Then 'Si se modifica la cantidad de un producto
            'Verifico si hay stock disponible de la cantidad ingresada del producto
            If (DG_Productos("PRECIO", e.RowIndex).Value > 0 And Not NegStock.ComprobarStock(DG_Productos("ID", e.RowIndex).Value, DG_Productos(e.ColumnIndex, e.RowIndex).Value.ToString(), id_Sucursal)) Then
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

    'Si desea buscar un cliente mayorista se visualiza el formulario.
    Private Sub Btn_BuscarCliente_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_BuscarCliente.Click
        Me.Cursor = Cursors.WaitCursor
        Dim frmBuscarClienteMayorista As frmBuscarClienteMayorista = New frmBuscarClienteMayorista()
        frmBuscarClienteMayorista.ShowDialog()


        If frmBuscarClienteMayorista.idCliente <> "" And frmBuscarClienteMayorista.razonSocialCliente <> "" Then
            txt_id_Cliente.Clear()
            txt_RazonSocial.Clear()
            LimpiarFormVentas_2()
            txt_id_Cliente.Text = frmBuscarClienteMayorista.idCliente
            txt_RazonSocial.Text = frmBuscarClienteMayorista.razonSocialCliente
            Cb_ListaPrecio.SelectedValue = frmBuscarClienteMayorista.idListaPrecio
        End If
        Me.Cursor = Cursors.Arrow
    End Sub

    'Al finalizar la venta.
    Private Sub Btn_Finalizar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_Finalizar.Click
        Try
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
            Dim PosibilidadDeFacturar As String = My.Settings("ControladorStatus") 'Variable de configuración que indica si la sucursal puede facturar o no.
            Dim TipoPagoControlador As String = "" 'Variable que se imprime en el tique fiscal.

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

            'Chequeo que haya al menos un producto cargado.
            If TotalProductos <= 0 Then
                'Muestro Mensaje.
                MessageBox.Show("La venta no puede efectuarse. No hay productos cargados !!", "Registro de Ventas", MessageBoxButtons.OK, MessageBoxIcon.Stop)
            Else
                'Tiene al menos un producto.
                'Chequeo que haya asignado al menos un vendedor a la venta.
                If Cb_Vendedores.SelectedValue <= 0 Then
                    'Muestro Mensaje.
                    MessageBox.Show("La venta no puede efectuarse. Debe seleccionar un vendedor responsable de la venta.", "Registro de Ventas", MessageBoxButtons.OK, MessageBoxIcon.Stop)
                ElseIf Cb_Encargados.SelectedValue <= 0 Then
                    'Muestro Mensaje.
                    MessageBox.Show("La venta no puede efectuarse. Debe seleccionar un encargado responsable de la venta.", "Registro de Ventas", MessageBoxButtons.OK, MessageBoxIcon.Stop)
                ElseIf Cb_TipoPago.SelectedValue <= 0 Then
                    'Muestro Mensaje.
                    MessageBox.Show("La venta no puede efectuarse. Debe seleccionar un tipo de pago a la venta.", "Registro de Ventas", MessageBoxButtons.OK, MessageBoxIcon.Stop)
                Else
                    'Tiene asignado vendedor.
                    If MessageBox.Show("¿Ésta seguro que desea efectuar la venta?", "Registro de Ventas", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = vbYes Then
                        'Si la sucursal puede facturar y el total es mayor que cero.
                        If PosibilidadDeFacturar = "SI" And MontoTotal > 0 Then
                            'Pregunto si desea realizar la factura de la venta.
                            If MessageBox.Show("¿Desea llevar a cabo factura de la venta?", "Registro de Ventas", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = vbYes Then
                                'Si el Monto excede el máximo permitido para facturar, aviso al usuario.
                                If CDbl(MontoTotal) > CDbl(My.Settings("ControladorMontoTope")) Then
                                    MessageBox.Show("La venta excede el máximo permitido para facturación. El pedido no podrá ser facturado.", "Registro de Ventas", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                                Else
                                    Facturar = True
                                End If
                            End If
                        End If

                        'Seteo el cursor.
                        Me.Cursor = Cursors.WaitCursor

                        'Datos de la venta.
                        EntVentas.id_Cliente = id_Cliente
                        EntVentas.id_Empleado = id_Empleado
                        EntVentas.id_Encargado = id_Encargado
                        EntVentas.id_Sucursal = id_Sucursal
                        EntVentas.id_TipoPago = TipoPago
                        EntVentas.id_TipoVenta = TipoVenta
                        EntVentas.CantidadTotal = CantidadTotal
                        EntVentas.Descuento = Descuento
                        EntVentas.SubTotal = MontoTotalSinDescuento
                        EntVentas.PrecioTotal = MontoTotal
                        EntVentas.Anulado = 0
                        EntVentas.Habilitado = 1
                        EntVentas.Facturado = 0

                        Dim DetalleDevolucion As List(Of Entidades.Devolucion_Detalle) = New List(Of Entidades.Devolucion_Detalle)
                        Dim DetalleVenta As List(Of Entidades.Ventas_Detalle) = New List(Of Entidades.Ventas_Detalle)

                        'Almaceno el detalle de la venta.
                        For i = 0 To DG_Productos.Rows.Count - 1
                            'esta era la linea original, la comente porque en caso de ser una devolucion nunca entraba en el if y luego se contemplaba una devolucion modificado el 11-7-2014
                            ' If CInt(DG_Productos.Rows(i).Cells.Item("ID").Value) > 0 And CInt(DG_Productos.Rows(i).Cells.Item("CANTIDAD").Value) > 0 And CDbl(DG_Productos.Rows(i).Cells.Item("PRECIO").Value) > 0 Then
                            If CInt(DG_Productos.Rows(i).Cells.Item("ID").Value) > 0 And CInt(DG_Productos.Rows(i).Cells.Item("CANTIDAD").Value) > 0 Then
                                'Creo un nuevo detalle, lleno el objeto e inserto en la bdd.
                                Dim EntVentasDetalle As New Entidades.Ventas_Detalle
                                EntVentasDetalle.id_Producto = CInt(DG_Productos.Rows(i).Cells.Item("ID").Value)
                                EntVentasDetalle.Cantidad = CInt(DG_Productos.Rows(i).Cells.Item("CANTIDAD").Value)
                                EntVentasDetalle.Precio = CDbl(DG_Productos.Rows(i).Cells.Item("PRECIO").Value)
                                DetalleVenta.Add(EntVentasDetalle)

                                'Descuento el stock de los productos si el precio es positivo, y agrego el stock si el precio es negativo ( será un cambio ).
                                'EDIT: ¿DE QUE ESTÁS HABLANDO WILLIS?

                                If CDbl(DG_Productos.Rows(i).Cells.Item("PRECIO").Value) < 0 Then
                                    NegStock.AgregarStock(CInt(DG_Productos.Rows(i).Cells.Item("ID").Value), id_Sucursal, CInt(DG_Productos.Rows(i).Cells.Item("CANTIDAD").Value))
                                    'tambien hay que registrar el movimiento en la sucursal 
                                    'Se registra el movimiento de salida de dinero en la sucursal.
                                    'TODO:Ver que hacer con el registro de las devoluciones como egresos
                                    Dim EMovEgreso As New Entidades.MovEgreso
                                    Dim NegMovimientos As New Negocio.NegMovimientos
                                    EMovEgreso.Aceptado = 1
                                    EMovEgreso.Fecha = Now.ToString 'fecha actual.
                                    EMovEgreso.id_Sucursal = id_Sucursal 'Sucursal donde se realiza la devolución.
                                    EMovEgreso.id_SucursalDestino = id_Sucursal 'Sucursal donde se realiza la devolución.
                                    EMovEgreso.Descripcion = "Egreso de dinero por devolución de mercaderia." 'descripcion del movimiento
                                    EMovEgreso.Monto = Math.Abs(CInt(DG_Productos.Rows(i).Cells.Item("PRECIO").Value) * CInt(DG_Productos.Rows(i).Cells.Item("CANTIDAD").Value))  'Monto devuelto por los productos que ingresaron.
                                    EMovEgreso.id_Tipo = 16 'Tipo: Efectivo.
                                    EMovEgreso.id_Subtipo = 0 'No posee subtipo.
                                    NegMovimientos.AltaMovEgreso(EMovEgreso)

                                Else
                                    NegStock.DisminuirStock(CInt(DG_Productos.Rows(i).Cells.Item("ID").Value), CInt(DG_Productos.Rows(i).Cells.Item("CANTIDAD").Value), id_Sucursal)
                                End If
                            End If
                        Next

                        NegVentas.NuevaVenta(EntVentas, DetalleVenta)

                        'Numero de Venta.
                        Dim id_Venta As Integer = NegVentas.ObtenerID()

                        'Comisiones para el vendedor.
                        Dim EntComisiones As New Entidades.Comisiones

                        Dim ComisionVendedor As Double = 0
                        Dim ComisionEncargado As Double = 0

                        'Obtengo las comisions del vendedor y encargado determinada por la sucursal y el dia de la semana.
                        NegComisiones.ObtenerComision(id_Sucursal, id_Cliente, ComisionVendedor, ComisionEncargado)

                        'Calculo el monto para el empleado dependiendo de la comision
                        Monto = (MontoTotal * ComisionVendedor) / 100

                        'Completo la Clase de Comisiones 
                        EntComisiones.id_Sucursal = id_Sucursal
                        EntComisiones.id_Venta = id_Venta
                        EntComisiones.id_Empleado = id_Empleado
                        EntComisiones.Comision = ComisionVendedor
                        EntComisiones.Monto = Monto

                        'Agrego la Comision
                        NegComisiones.AgregarComision(EntComisiones)

                        'Comisiones para el encargado.
                        Dim EntComisiones2 As New Entidades.Comisiones

                        'Calculo el monto para el empleado dependiendo de la comision
                        Monto = (MontoTotal * ComisionEncargado) / 100

                        'Completo la Clase de Comisiones 
                        EntComisiones2.id_Sucursal = id_Sucursal
                        EntComisiones2.id_Venta = id_Venta
                        EntComisiones2.id_Empleado = id_Encargado
                        EntComisiones2.Comision = ComisionEncargado
                        EntComisiones2.Monto = Monto

                        'Agrego la Comision
                        NegComisiones.AgregarComision(EntComisiones2)

                        'Fin de la venta.
                        'Limpio el Formulario.
                        LimpiarFormVentas()

                        'Seteo el cursor.
                        Me.Cursor = Cursors.Arrow

                        'Muestro Mensaje.
                        MessageBox.Show("La venta ha sido finalizado correctamente.", "Registro de Ventas", MessageBoxButtons.OK, MessageBoxIcon.Question)

                        'Si hay que facturar, muestro  un mensaje que se va a llevar a cabo dicha factura y abro el form.
                        If Facturar Then
                            If (MessageBox.Show("Se llevará a cabo la factura de la venta Nº " & id_Venta & ", ¿Desea Continuar?.", "Registro de Ventas", MessageBoxButtons.YesNo, MessageBoxIcon.Information) = vbYes) Then

                                'Seteo el cursor.
                                Me.Cursor = Cursors.WaitCursor

                                'Abro el form de datos de facturacion.
                                frmFacturar.id_Venta = id_Venta
                                frmFacturar.Monto = MontoTotal
                                frmFacturar.Descuento = Descuento
                                frmFacturar.MontoSinDescuento = MontoTotalSinDescuento
                                frmFacturar.TipoPago = TipoPagoControlador
                                Funciones.ControlInstancia(frmFacturar).Show()

                                'Seteo el cursor.
                                Me.Cursor = Cursors.Arrow

                            End If
                        End If
                    Else
                        'Muestro Mensaje.
                        MessageBox.Show("Se ha producido un error al registrar la venta. Por favor, Comuniquese con el administrador.", "Registro de Ventas", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End If
                End If
            End If
        Catch ex As Exception
            'Seteo el cursor.
            Me.Cursor = Cursors.Arrow
            'Muestro Mensaje.
            MessageBox.Show("Se ha producido un error al confirmar la venta. Por favor, Comuniquese con el administrador.", "Registro de Ventas", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    'Evento lanzado cuando escriben en el textbox de codigo.
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
                MessageBox.Show("Ingrese un código de barra o un código de producto.", "Registro de Ventas", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
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

    Private Sub Btn_Cambiar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_Cambiar.Click
        Me.Cursor = Cursors.WaitCursor
        Dim frmCambios As frmCambios = New frmCambios()
        frmCambios.ShowDialog()
        If (Not String.IsNullOrEmpty(frmCambios.codigoBarras)) Then
            AgregarItem(frmCambios.codigoBarras, 2, 2)
        ElseIf (Not String.IsNullOrEmpty(frmCambios.CodigoProducto)) Then
            AgregarItem(frmCambios.CodigoProducto, 3, 2)
        End If
        Me.Cursor = Cursors.Arrow
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

    Private Sub Cb_TipoPago_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Cb_TipoPago.SelectedIndexChanged
        PosicionarListaPreciosSegunFormaDePago()
    End Sub

End Class