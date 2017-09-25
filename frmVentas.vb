Imports Entidades
Imports System.Linq
Imports System.Threading.Tasks
Imports Negocio
Imports Entidades.ClienteMayorista

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
    Dim negSenia As NegSenia = New NegSenia
    Dim EntProducto As New Entidades.Productos
    Dim NegListasPrecio As New Negocio.NegListasPrecio
    Dim NegDevolucion As New Negocio.NegDevolucion
    Dim EntVentas As New Entidades.Ventas
    Dim EntDevolucion As New Entidades.Devolucion
    Dim Funciones As New Funciones
    Dim id_Sucursal As Integer
    Dim Nombre_Sucursal As String
    Dim ProductoCantidadAnterior As Integer
    Dim dsProductos As DataSet
    Dim PorcentajeFacturacionIngresado As Double = 100
    Dim PorcentajeDescuento As Double = 0
    Public NotaPedido As NotaPedido
    Public Senia As Senia


#Region "Region Funciones"

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
    Sub CalcularTotales()
        Dim subtotal As Double = CalcularPrecioTotal()

        If cb_Tipo.SelectedItem = "Minorista" Then
            CaluclarPrecioMinorista(subtotal)
        Else
            CalcularPrecioMayorista(subtotal)
        End If

        If subtotal <= 0 Then
            Btn_Finalizar.Visible = False
            Btn_NotaPedido.Visible = False
        Else
            Btn_Finalizar.Visible = True
            Btn_NotaPedido.Visible = True
        End If
    End Sub

    Private Sub CalcularPrecioMayorista(ByRef subtotal As Double)
        Dim PorcentajeFacturacion As Double = Double.Parse(txt_PorcentajeFacturacion.Text) / 100

        Dim descuento As Double = Math.Round(subtotal * PorcentajeDescuento, 0, MidpointRounding.ToEven)
        Dim ivaSubTotal As Double = 0
        Dim senia As Double = CDbl(txt_SeniaMayorista.Text)
        Dim seniaSinIva As Double = Math.Round(CDbl(txt_SeniaMayorista.Text) / 1.21, 2)
        Dim costoFinanciero As Double = 0

        If descuento < subtotal Then
            costoFinanciero = (subtotal - descuento - seniaSinIva) * ObtenerCostoFinanciero()
            subtotal = subtotal - descuento + costoFinanciero
            ivaSubTotal = subtotal * (0.21 * PorcentajeFacturacion)

            txt_TotalMayorista.Text = Format(CType(subtotal + ivaSubTotal - senia, Decimal), "###0.00")
        Else
            descuento = subtotal
            costoFinanciero = (subtotal - descuento - seniaSinIva) * ObtenerCostoFinanciero()
            subtotal = subtotal + costoFinanciero
            ivaSubTotal = subtotal * (0.21 * PorcentajeFacturacion)
            txt_TotalMayorista.Text = Format(CType(subtotal + ivaSubTotal - senia, Decimal), "###0.00")
        End If

        txt_DescuentoMayorista.Text = Format(descuento, "###0.00")
        txt_SubtotalMayorista.Text = Format(CType(subtotal, Decimal), "###0.00")
        txt_CFTMayorista.Text = Format(CType(costoFinanciero, Decimal), "###0.00")
        txt_ivaTotalMayorista.Text = Format(CType(ivaSubTotal, Decimal), "###0.00")
    End Sub

    Private Sub CaluclarPrecioMinorista(subtotal As Double)
        Dim descuento As Double = Math.Round(subtotal * PorcentajeDescuento, 0, MidpointRounding.ToEven)
        Dim costoFinanciero As Double = 0
        Dim senia As Double = CDbl(txt_SeniaMinorista.Text)

        If CDbl(descuento) < subtotal Then
            costoFinanciero = (subtotal - descuento - senia) * ObtenerCostoFinanciero()
            txt_TotalMinorista.Text = Format(CType(subtotal - descuento + costoFinanciero - senia, Decimal), "###0.00")
        Else
            descuento = subtotal
            costoFinanciero = (subtotal - descuento - senia) * ObtenerCostoFinanciero()
            txt_TotalMinorista.Text = Format(CType(subtotal + costoFinanciero - senia, Decimal), "###0.00")
        End If
        txt_DescuentoMinorista.Text = Format(descuento, "###0.00")
        txt_CFTMinorista.Text = Format(costoFinanciero, "###0.00")
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

    'Funcion que invoca el formulario de carga de cheques de forma asincornica para no bloquear el funcionamiento de la aplicacion a la espera de que se cierre la carga de los cheques 
    Async Function CargarCheques(ByVal Facturar As Boolean, ByVal MontoTotal As Double) As Task(Of Double)
        Me.Hide()
        Dim respuesta As Double = Await Task.Run((Function() (Me.abrirForm(Facturar, MontoTotal))))
        Me.Show()
        Return respuesta
    End Function

    'Funcion que muestra la pantalla de cheques
    Private Function abrirForm(factura As Boolean, monto As Double) As Double
        Dim frmChequesAltaMasiva As frmChequesAltaMasiva = New frmChequesAltaMasiva()
        frmChequesAltaMasiva.Facturado = factura
        frmChequesAltaMasiva.MontoVenta = monto

        If (frmChequesAltaMasiva.ShowDialog() = Windows.Forms.DialogResult.OK) Then
            Return frmChequesAltaMasiva.DiferenciaPagoCheques
        End If
        Return -1
    End Function

#End Region

    'Cancela la venta, setea variables por default.
    Private Sub Btn_Cancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_Cancelar.Click
        If MessageBox.Show("Ésta seguro que desea cancelar la venta?", "Registro de Ventas", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = vbYes Then
            Me.Close()
        End If
    End Sub

    'Si desea buscar un producto, se visualiza el formulario.
    Private Sub Btn_Buscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_Agregar.Click
        Me.Cursor = Cursors.WaitCursor
        BuscarProducto()
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
                    CalcularTotales() 'Recalculo el Total y lo muestro en el label
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
        enableAllControls(Gb_Cliente, False)

        btn_ActualizarListaProductos.Enabled = My.Settings.UsarMemoriaCache

        'Sucursal default
        id_Sucursal = My.Settings("Sucursal")
        Nombre_Sucursal = My.Settings("NombreSucursal")

        'Seteo el nombre de la sucursal
        lbl_Sucursal.Text = Nombre_Sucursal

        'Oculto Columnas en el DG_Productos
        DG_Productos.Columns("Numero").Visible = False
        DG_Productos.Columns("ID").Visible = False

        'Cargo el Combo de Tipos de Pago
        Dim DsTiposPagos As New DataSet
        DsTiposPagos = NegTiposPagos.ListadoTiposPagosCache(My.Settings.UsarMemoriaCache)

        If DsTiposPagos.Tables(0).Rows.Count > 0 Then
            Cb_TipoPago.DataSource = Nothing
            Cb_TipoPago.DataSource = Funciones.CrearDataTable("id_TipoPago", "Descripcion", DsTiposPagos, "Seleccione un tipo de pago...")
            Cb_TipoPago.DisplayMember = "Descripcion"
            Cb_TipoPago.ValueMember = "id_TipoPago"
            Cb_TipoPago.SelectedValue = 0
            Cb_TipoPago.Refresh()
        End If

        'Cargo el Combo de Encargados
        Dim DsEncargados As DataSet = CargarComboEncargados()

        'Cargo el Combo de vendedores
        Dim DsVendedores As DataSet = CargarComboVendedores(DsEncargados)

        'Cargo el Combo de Bancos
        Dim Tarjetas As List(Of Tarjeta) = NegTarjeta.TraerTarjetasCache(My.Settings.UsarMemoriaCache).Where(Function(x) x.Habilitado).ToList()
        Tarjetas.Insert(0, New Tarjeta() With {.TarjetaId = 0, .Nombre = "Seleccione una Tarjeta..."})
        TrajetaBindingSource.DataSource = Tarjetas

        'Cargo el Combo de Bancos
        Dim CostosFinancieros As List(Of CostoFinanciero) = New List(Of CostoFinanciero)
        CostosFinancieros.Add(New CostoFinanciero() With {.Tarjeta = 0, .CostoFinancieroId = 0, .NumeroCuotas = 0, .PorcentajeRecargo = 0})
        CostoFinancieroBindingSource.DataSource = CostosFinancieros

        'Cargo el combo de Lista de precios para un cliente minorista
        Dim dsListaPrecio As DataSet = NegListasPrecio.ListadoPreciosPorGrupoCache(My.Settings("ListaPrecio"), My.Settings.UsarMemoriaCache)
        If dsListaPrecio.Tables(0).Rows.Count > 0 Then
            Cb_ListaPrecio.DataSource = Nothing
            Cb_ListaPrecio.DataSource = dsListaPrecio.Tables(0)
            Cb_ListaPrecio.DisplayMember = "ListaPrecio"
            Cb_ListaPrecio.ValueMember = "id_Lista"
            Cb_ListaPrecio.Refresh()
        End If

        If (NotaPedido IsNot Nothing) Then
            CargarNotaPedido()
        End If

        If (Senia IsNot Nothing) Then
            CargarSenia(DsTiposPagos, DsVendedores, DsEncargados)
        End If

        CargraListaProductos(My.Settings.UsarMemoriaCache)
    End Sub

    Private Sub CargraListaProductos(usarCache)
        'Obtengo el listado de productos guardados en cache
        dsProductos = NegProductos.ListadoProductosCache(usarCache)

        'Armo una lista que contiene los nombres y codigos de todos los producto
        Dim listaNombreCodigoProductos As AutoCompleteStringCollection = New AutoCompleteStringCollection()

        listaNombreCodigoProductos.AddRange(dsProductos.Tables(0).Rows.Cast(Of DataRow).Select(Function(x) x.Item("Nombre").ToString).ToArray())
        listaNombreCodigoProductos.AddRange(dsProductos.Tables(0).Rows.Cast(Of DataRow).Select(Function(x) x.Item("Codigo").ToString).ToArray())

        txt_CodigoBarra.AutoCompleteCustomSource = listaNombreCodigoProductos

        PanelTotalMayorista.Location = PanelTotalMinorista.Location
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

    'Carga la venta con la nota de pedido
    Private Sub CargarNotaPedido()
        Dim ds As DataSet = NegEmpleados.ListadoEmpleados()

        If Cb_Vendedores.Items.Contains(NotaPedido.id_Empleado) Then
            Cb_Vendedores.SelectedValue = NotaPedido.id_Empleado
        Else
            Dim drEmpleado As DataRow = ds.Tables(0).Rows.Cast(Of DataRow).Where(Function(x) x("id_empleado") = NotaPedido.id_Empleado).FirstOrDefault()
            If (drEmpleado IsNot Nothing) Then
                Dim tb As DataTable = Cb_Vendedores.DataSource
                Dim row As DataRow = tb.NewRow()
                row.Item("id_Empleado") = drEmpleado("id_empleado")
                row.Item("NombreCompleto") = String.Format("{0}, {1}", drEmpleado("apellido"), drEmpleado("nombre"))
                tb.Rows.Add(row)
                Cb_Vendedores.SelectedValue = drEmpleado("id_empleado")
            End If
        End If

        If Cb_Encargados.Items.Contains(NotaPedido.id_Encargado) Then
            Cb_Encargados.SelectedValue = NotaPedido.id_Encargado
        Else
            Dim drEmpleado As DataRow = ds.Tables(0).Rows.Cast(Of DataRow).Where(Function(x) x("id_empleado") = NotaPedido.id_Encargado).FirstOrDefault()
            If (drEmpleado IsNot Nothing) Then
                Dim tb As DataTable = Cb_Encargados.DataSource
                Dim row As DataRow = tb.NewRow()
                row.Item("id_Empleado") = drEmpleado("id_empleado")
                row.Item("NombreCompleto") = String.Format("{0}, {1}", drEmpleado("apellido"), drEmpleado("nombre"))
                tb.Rows.Add(row)
                Cb_Encargados.SelectedValue = drEmpleado("id_empleado")
            End If
        End If

        If NotaPedido.id_TipoVenta = 1 Then
            cb_Tipo.SelectedItem = "Minorista"
        Else
            cb_Tipo.SelectedItem = "Mayorista"
        End If

        Cb_TipoPago.SelectedValue = NotaPedido.id_TipoPago

        Cb_ListaPrecio.SelectedValue = NotaPedido.id_ListaPrecio

        Cb_Tarjeta.SelectedValue = NotaPedido.Id_Tarjeta

        If (Cb_Tarjeta.SelectedValue > 0) Then
            Dim costosFinancieros As List(Of CostoFinanciero) = NegTarjeta.TraerCostosFinancieros(Cb_Tarjeta.SelectedValue)
            CostoFinancieroBindingSource.DataSource = costosFinancieros
            Dim costoFinanciero As CostoFinanciero = costosFinancieros.Where(Function(x) x.NumeroCuotas = NotaPedido.CantidadCuotas).FirstOrDefault()
            If (costoFinanciero IsNot Nothing) Then
                Cb_NumeroCuota.SelectedValue = costoFinanciero.CostoFinancieroId
                Cb_NumeroCuota_SelectedIndexChanged(Nothing, Nothing)
            End If
        End If

        'si la nota de pedido tiene un cliente
        If (NotaPedido.id_Cliente > 0) Then
            'cargo la informacion del cliente
            txt_id_Cliente.Text = NotaPedido.id_Cliente
            txt_RazonSocial.Text = NotaPedido.RazonSocialCliente
            PorcentajeFacturacionIngresado = NotaPedido.PorcentajeFacturacion
            txt_PorcentajeFacturacion.Text = PorcentajeFacturacionIngresado
        End If

        AgregarItemDesdeNotaPedido()

    End Sub

    Private Sub AgregarItemDesdeNotaPedido()

        Dim negNotaPedido As Negocio.NegNotaPedido = New Negocio.NegNotaPedido()

        Dim notaPedidoDetalles As List(Of NotaPedido_Detalle) = negNotaPedido.TraerDetalle(NotaPedido.id_NotaPedido)

        Dim NumeroFila As Integer = 0

        For Each detalle As NotaPedido_Detalle In notaPedidoDetalles

            Dim entProducto As Entidades.Productos = NegProductos.TraerProducto(detalle.id_Producto)

            NumeroFila += 1

            AgregarItemAGrilla(entProducto, 1, NumeroFila, detalle.Cantidad, detalle.Precio, detalle.Iva, detalle.Monto)
        Next

        CalcularTotales()
    End Sub

    Private Sub CargarSenia(DsTiposPagos As DataSet, DsVendedores As DataSet, DsEncargados As DataSet)
        Dim dsVentas As DataSet = NegVentas.TraerVenta(Senia.IdVentaSenia)

        If Cb_Vendedores.Items.Contains(Integer.Parse(dsVentas.Tables(0).Rows(0).Item("id_Empleado"))) Then
            Cb_Vendedores.SelectedValue = Integer.Parse(dsVentas.Tables(0).Rows(0).Item("id_Empleado"))
        Else
            Dim tb As DataTable = Cb_Vendedores.DataSource
            Dim row As DataRow = tb.NewRow()
            row.Item("id_Empleado") = dsVentas.Tables(0).Rows(0).Item("id_Empleado")
            row.Item("NombreCompleto") = dsVentas.Tables(0).Rows(0).Item("Empleado")
            tb.Rows.Add(row)
            Cb_Vendedores.SelectedValue = Integer.Parse(dsVentas.Tables(0).Rows(0).Item("id_Empleado"))
        End If

        Cb_Encargados.SelectedValue = Integer.Parse(dsVentas.Tables(0).Rows(0).Item("id_Encargado"))
        If Cb_Encargados.Items.Contains(Integer.Parse(dsVentas.Tables(0).Rows(0).Item("id_Encargado"))) Then
            Cb_Encargados.SelectedValue = Integer.Parse(dsVentas.Tables(0).Rows(0).Item("id_Encargado"))
        Else
            Dim tb As DataTable = Cb_Encargados.DataSource
            Dim row As DataRow = tb.NewRow()
            row.Item("id_Empleado") = dsVentas.Tables(0).Rows(0).Item("id_Encargado")
            row.Item("NombreCompleto") = dsVentas.Tables(0).Rows(0).Item("Encargado")
            tb.Rows.Add(row)
            Cb_Encargados.SelectedValue = Integer.Parse(dsVentas.Tables(0).Rows(0).Item("id_Encargado"))
        End If

        Cb_ListaPrecio.SelectedValue = Integer.Parse(dsVentas.Tables(0).Rows(0).Item("id_ListaPrecio"))

        Dim TipoPagoRow = DsTiposPagos.Tables(0).Rows.Cast(Of DataRow).Where(Function(x) x.Item("Descripcion") = dsVentas.Tables(0).Rows(0).Item("TiposPago")).FirstOrDefault()
        If (TipoPagoRow IsNot Nothing) Then
            Cb_TipoPago.SelectedValue = TipoPagoRow.Item("id_TipoPago")
        End If

        cb_Tipo.SelectedItem = dsVentas.Tables(0).Rows(0).Item("TiposVenta")

        Dim Subtotal = CType(dsVentas.Tables(0).Rows(0).Item("Subtotal"), Decimal)
        Dim Descuento = CType(dsVentas.Tables(0).Rows(0).Item("Descuento"), Decimal)
        Dim Total = CType(dsVentas.Tables(0).Rows(0).Item("Precio_Total"), Decimal)
        Dim SeniaMonto = CType(dsVentas.Tables(0).Rows(0).Item("MontoSenia"), Decimal)
        Dim PorcentajeFacturacion = CType(dsVentas.Tables(0).Rows(0).Item("PorcentajeFacturacion"), Decimal)

        AgregarItemDesdeSenia()

        If (dsVentas.Tables(0).Rows(0).Item("TiposVenta") = "Minorista") Then
            txt_SeniaMinorista.Text = Format(SeniaMonto, "###0.00")
            lblSeniaMinorista.Visible = True
            lblSeniaMinoristaMoneda.Visible = True
            txt_SeniaMinorista.Visible = True
            txt_SubtotalMinorista.Text = Format(Subtotal, "###0.00")
            txt_DescuentoMinorista.Text = Format(Descuento, "###0.00")
            txt_TotalMinorista.Text = Format(Total - SeniaMonto, "###0.00")
            txt_PorcentajeBonificacion.Text = Math.Round((CType(txt_DescuentoMinorista.Text, Double) / CalcularPrecioTotal()) * 100, 0, MidpointRounding.ToEven)
        Else
            txt_DescuentoMayorista.Text = Format(Descuento, "###0.00")
            txt_SeniaMayorista.Text = Format(SeniaMonto, "###0.00")
            lblSeniaMayorista.Visible = True
            lblSeniaMayoristaMoneda.Visible = True
            txt_SeniaMayorista.Visible = True
            txt_SubtotalMayorista.Text = Format(Subtotal, "###0.00")
            txt_ivaTotalMayorista.Text = Format(Subtotal * 0.21 * (PorcentajeFacturacion / 100), "###0.00")
            txt_TotalMayorista.Text = Format(Total - SeniaMonto, "###0.00")

            txt_id_Cliente.Text = Senia.IdClienteMayorista
            txt_RazonSocial.Text = Senia.RazonSocial
            PorcentajeFacturacionIngresado = PorcentajeFacturacion
            txt_PorcentajeFacturacion.Text = PorcentajeFacturacionIngresado
            txt_PorcentajeBonificacion.Text = Math.Round((CType(txt_DescuentoMayorista.Text, Double) / CalcularPrecioTotal()) * 100, 0, MidpointRounding.ToEven)
        End If

        cb_Tipo.Enabled = False
        txt_id_Cliente.Enabled = False
        txt_RazonSocial.Enabled = False
        Btn_BuscarCliente.Enabled = False
        txt_PorcentajeFacturacion.Enabled = False

        Btn_Finalizar.Visible = True
        Btn_NotaPedido.Visible = False
        GB_Reserva.Visible = False

    End Sub

    Private Sub AgregarItemDesdeSenia()
        Dim NumeroFila As Integer = 0
        Dim dsVentasDetalle = NegVentas.TraerVentaDetalle(Senia.IdVentaSenia)

        For Each ventaDetalle In dsVentasDetalle.Tables(0).Rows

            Dim entProducto As Entidades.Productos = NegProductos.TraerProducto(ventaDetalle.item("id_Producto"))

            NumeroFila += 1
            Dim precio As Decimal = CType(ventaDetalle.item("Precio").ToString, Decimal)
            Dim iva As Decimal = CType(ventaDetalle.item("Iva").ToString, Decimal)
            Dim monto As Decimal = CType(ventaDetalle.item("Monto").ToString, Decimal)
            Dim cantidad As Decimal = CType(ventaDetalle.item("Cantidad").ToString, Decimal)

            AgregarItemAGrilla(entProducto, 1, NumeroFila, cantidad, precio, iva, monto)
        Next

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
            enableAllControls(Gb_Cliente, True)
            'Cargo la lista de precios con las opciones mayoristas
            dsListas = NegListasPrecio.ListadoPreciosPorGrupoCache(3, My.Settings.UsarMemoriaCache)
            DG_Productos.Columns("MONTO").ReadOnly = True
            DG_Productos.Columns("PRECIO").ReadOnly = False
            DG_Productos.Columns("PRECIO").Visible = True
            DG_Productos.Columns("IVA").Visible = True
            PanelTotalMayorista.Visible = True
            PanelTotalMinorista.Visible = False
            If Cb_TipoPago.SelectedValue = 1 Then
                txt_PorcentajeFacturacion.Enabled = True
            Else
                txt_PorcentajeFacturacion.Enabled = False
            End If

        Else
            'Minorista
            enableAllControls(Gb_Cliente, False)
            txt_RazonSocial.Clear()
            txt_id_Cliente.Clear()
            'Cargo la lista de precios con las opciones minoristas configuradas para la sucursal
            dsListas = NegListasPrecio.ListadoPreciosPorGrupoCache(My.Settings("ListaPrecio"), My.Settings.UsarMemoriaCache)
            DG_Productos.Columns("MONTO").ReadOnly = False
            DG_Productos.Columns("PRECIO").ReadOnly = True
            DG_Productos.Columns("PRECIO").Visible = False
            DG_Productos.Columns("IVA").Visible = False
            PanelTotalMayorista.Visible = False
            PanelTotalMinorista.Visible = True
        End If

        txt_PorcentajeFacturacion.Text = 100
        txt_PorcentajeBonificacion.Text = 0
        txt_DescuentoMinorista.Text = "0,00"
        txt_DescuentoMayorista.Text = "0,00"

        If dsListas.Tables(0).Rows.Count > 0 Then
            Cb_ListaPrecio.DataSource = Nothing
            Cb_ListaPrecio.DataSource = dsListas.Tables(0)
            Cb_ListaPrecio.DisplayMember = "ListaPrecio"
            Cb_ListaPrecio.ValueMember = "id_Lista"
            Cb_ListaPrecio.Refresh()
        End If

        PosicionarListaPreciosSegunFormaDePago()

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

    Private Sub ActualizarColumnaIvaMonto(index As Integer, precio As Double)
        Dim PorcentajeFacturacion As Double = Double.Parse(txt_PorcentajeFacturacion.Text) / 100
        DG_Productos("IVA", index).Value = precio * (0.21 * PorcentajeFacturacion)
        DG_Productos("MONTO", index).Value = precio * (1 + 0.21 * PorcentajeFacturacion)
        DG_Productos("SUBTOTAL", index).Value = DG_Productos("MONTO", index).Value * DG_Productos("CANTIDAD", index).Value
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
            PorcentajeDescuento = frmBuscarClienteMayorista.clienteMayorista.Bonificacion / 100
            PorcentajeFacturacionIngresado = If(frmBuscarClienteMayorista.clienteMayorista.Lista = 0, 100, frmBuscarClienteMayorista.clienteMayorista.Lista)
            If Cb_TipoPago.SelectedValue = 1 Then
                txt_PorcentajeFacturacion.Text = PorcentajeFacturacionIngresado
            End If

            ActualizarMontosGrillaYTotales()

        End If
        Me.Cursor = Cursors.Arrow
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

    'Al finalizar la venta.
    Private Async Sub Btn_Finalizar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_Finalizar.Click
        Try
            'Obtengo toda la informacion.
            Dim TipoVenta As Integer = 0 'Tipo de Venta.
            Dim TipoPago As Integer = Cb_TipoPago.SelectedValue 'Tipo de Pago.
            Dim id_Empleado As Integer = Cb_Vendedores.SelectedValue 'ID de Vendedor.
            Dim id_Encargado As Integer = Cb_Encargados.SelectedValue 'ID de Encargado.
            Dim id_Cliente As Integer = 0 'ID de Cliente.
            Dim id_ListaPrecio As Integer = Cb_ListaPrecio.SelectedValue
            Dim Id_Tarjeta As Integer = 0
            Dim NumerCuotas As Integer = 0
            Dim Facturar As Boolean = False 'Variable que indica si la venta ´facturará o no.
            Dim Descuento As Double = 0 'Descuento ingresado.
            Dim CostoFinanciero As Double = 0
            Dim SubTotal As Double = 0 'Monto total de la venta.
            Dim MontoTotal As Double = 0 'Monto total de la venta menos el descuento.
            Dim CantidadTotal As Integer = CalcularCantidadTotal() 'Cantidad total de articulos.
            Dim DiferenciaPagoCheque As Double = 0 'Es el importe que falta cubrir de los cheques recividos como pago
            Dim PorcentajeFacturacion As Double = 0
            Dim IvaTotal As Double = 0 'Iva total de la vental
            Dim MontoSenia As Double = 0

            If (Not VentaValida("venta")) Then
                Return
            End If

            'Seteo TipoVenta
            If cb_Tipo.SelectedItem = "Minorista" Then
                TipoVenta = 1
                PorcentajeFacturacion = 1
                SubTotal = CType(txt_SubtotalMinorista.Text, Decimal)
                Descuento = CType(txt_DescuentoMinorista.Text, Decimal)
                CostoFinanciero = CType(txt_CFTMinorista.Text, Decimal)
                MontoTotal = CType(txt_TotalMinorista.Text, Decimal)
                MontoSenia = CType(txt_SeniaMinorista.Text, Decimal)
            Else
                TipoVenta = 2
                PorcentajeFacturacion = CType(txt_PorcentajeFacturacion.Text, Decimal) / 100
                Descuento = CType(txt_DescuentoMayorista.Text, Decimal)
                CostoFinanciero = CType(txt_CFTMayorista.Text, Decimal)
                SubTotal = CType(txt_SubtotalMayorista.Text, Decimal)
                IvaTotal = CType(txt_ivaTotalMayorista.Text, Decimal)
                MontoTotal = CType(txt_TotalMayorista.Text, Decimal)
                MontoSenia = CType(txt_SeniaMayorista.Text, Decimal)
            End If

            'si el pago es con tarjeta de credito
            If TipoPago = 2 Then
                Dim entCostoFinanciero As CostoFinanciero = CType(Cb_NumeroCuota.SelectedItem, CostoFinanciero)
                Id_Tarjeta = entCostoFinanciero.Tarjeta
                NumerCuotas = entCostoFinanciero.NumeroCuotas
            End If


            'Tiene asignado vendedor.
            If MessageBox.Show("¿Ésta seguro que desea efectuar la venta?", "Registro de Ventas", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = vbYes Then
                If (PorcentajeFacturacion > 0 AndAlso MessageBox.Show("¿Desea facturar la venta?", "Registro de Ventas", MessageBoxButtons.YesNo, MessageBoxIcon.Information) = vbYes) Then
                    Facturar = True
                Else
                    Facturar = False
                End If

                'Seteo ID Cliente
                If txt_id_Cliente.Text = "" Then
                    id_Cliente = 0
                Else
                    id_Cliente = CInt(txt_id_Cliente.Text)
                End If

                'Si el tipo de pago es cheque abro la ventana para cargar ingresar el cheque
                If TipoPago = 4 Then
                    'invoca la pantalla de carga de cheques y quedo a la espera del cierre
                    DiferenciaPagoCheque = Await CargarCheques(Facturar, MontoTotal)
                    'en caso que la diferencia de pago en cheques sea -1 es porque el usuario cancelo la carga de los cheques y se cancela la alta de la venta
                    If (DiferenciaPagoCheque = -1) Then
                        Return
                    End If
                End If

                Dim id_Venta As Integer = RegistrarVenta(TipoVenta, TipoPago, id_Empleado, id_Encargado, id_Cliente, Id_Tarjeta, NumerCuotas, PorcentajeFacturacion * 100, id_ListaPrecio, Descuento, CostoFinanciero, SubTotal, MontoTotal, CantidadTotal, DiferenciaPagoCheque, MontoSenia, False)

                If id_Venta > 0 Then

                    'Si hay que facturar abro el form.
                    If Facturar Then
                        Dim resultado = FacturarVenta(TipoPago, id_Cliente, Descuento, CostoFinanciero, SubTotal, MontoTotal, IvaTotal, MontoSenia, id_Venta, PorcentajeFacturacion)
                        'Si cacelo la factura se tiene que eliminar la venta y frenar el proceso de venta.
                        If resultado = DialogResult.Cancel Then
                            NegVentas.Eliminar(id_Venta)
                            Return
                        End If
                    End If

                    'si esto realizando una venta a partir de una seña
                    If (Me.Senia IsNot Nothing) Then
                        Senia.IdVentaRetiro = id_Venta
                        Senia.Entregada = True
                        negSenia.ActualizarSenia(Senia)

                        ActualizarStockDesdeSenia()
                    Else
                        ActualizarStock()
                    End If

                    RegistrarComisionesEncargadoEmpleado(id_Empleado, id_Encargado, id_Cliente, MontoTotal, id_Venta)

                    'Seteo el cursor.
                    Me.Cursor = Cursors.Arrow

                    'Muestro Mensaje.
                    MessageBox.Show("La venta ha sido finalizado correctamente.", "Registro de Ventas", MessageBoxButtons.OK, MessageBoxIcon.Question)

                    If (NotaPedido IsNot Nothing) Then
                        Dim negNotaPedido As NegNotaPedido = New NegNotaPedido()
                        NotaPedido.Vendida = True
                        NotaPedido.id_Cliente = id_Cliente
                        NotaPedido.id_Empleado = id_Empleado
                        NotaPedido.id_Encargado = id_Encargado
                        If Not negNotaPedido.ActualizarNotaPedido(NotaPedido, ObtenerDetalleNotaPedido(), id_Sucursal) Then
                            MessageBox.Show("La nota de pedido no se a podido cerrar. Por favor, Comuniquese con el administrador.", "Registro de Ventas", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        Else
                            Dim frmNotaPedido As frmNotaPedidoAdministracion = Funciones.ControlInstancia(frmNotaPedidoAdministracion)
                            'Elimino la nota de pedido del la grilla de Administracion Notas Pedido
                            frmNotaPedido.RemoverNotaPedido(NotaPedido)
                        End If
                    End If

                    'Si no se factura el 100% de la venta armo un presupuesto por el monto no facturado
                    If Facturar AndAlso PorcentajeFacturacion < 1 AndAlso MessageBox.Show("¿Desea Generar un presupuesto por el monto no facturado?", "Registro de Ventas", MessageBoxButtons.YesNo, MessageBoxIcon.Information) = DialogResult.Yes Then
                        AltaPresupuesto(id_Venta, TipoVenta, TipoPago, Cb_TipoPago.Text, id_Empleado, id_Encargado, id_Cliente, id_ListaPrecio, Id_Tarjeta, NumerCuotas, Descuento, CostoFinanciero, SubTotal, MontoTotal, PorcentajeFacturacion, MontoSenia)
                    End If

                    'Fin de la venta.
                    Me.Close()

                    'si esto realizando una venta a partir de una seña
                    If (Me.Senia IsNot Nothing) Then
                        Me.Close()
                        Funciones.ControlInstancia(frmSeniaAdministracion).Close()
                    End If

                Else
                    'Muestro Mensaje.
                    MessageBox.Show("Se ha producido un error al registrar la venta. Por favor, Comuniquese con el administrador.", "Registro de Ventas", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            End If
        Catch ex As Exception
            'Seteo el cursor.
            Me.Cursor = Cursors.Arrow
            'Muestro Mensaje.
            MessageBox.Show("Se ha producido un error al confirmar la venta. Por favor, Comuniquese con el administrador.", "Registro de Ventas", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub AltaPresupuesto(id_Venta As Integer, TipoVenta As Integer, TipoPago As Integer, DescripcionTipoPago As String, id_Empleado As Integer, id_Encargado As Integer, id_Cliente As Integer, id_ListaPrecio As Integer, id_Banco As Integer, CantidadCuotas As Integer, Descuento As Double, CostoFinanciero As Double, SubTotal As Double, MontoTotal As Double, PorcentajeFacturacion As Double, MontoSenia As Double)
        Dim MontoSeñaSinIva As Double = MontoSenia / ((0.21 * PorcentajeFacturacion) + 1)
        Dim DescuentoTotal As Double = Descuento + MontoSeñaSinIva

        Dim Presupuesto As Presupuesto = New Presupuesto()
        Presupuesto.Fecha = Date.Now
        Presupuesto.id_Venta = id_Venta
        Presupuesto.id_ClienteMayorista = id_Cliente
        Presupuesto.id_Empleado = id_Empleado
        Presupuesto.id_Encargado = id_Encargado
        Presupuesto.id_ListaPrecio = id_ListaPrecio
        Presupuesto.id_Sucursal = id_Sucursal
        Presupuesto.id_TipoPago = TipoPago
        Presupuesto.DescripcionTipoPago = DescripcionTipoPago
        Presupuesto.id_TipoVenta = TipoVenta
        Presupuesto.id_Tarjeta = id_Banco
        Presupuesto.CantidadCuotas = CantidadCuotas
        Presupuesto.Total = Math.Round((CalcularPrecioTotal() - DescuentoTotal + CostoFinanciero) * (1 - PorcentajeFacturacion), 2)
        Presupuesto.SubTotal = Math.Round((CalcularPrecioTotal()) * (1 - PorcentajeFacturacion), 2)
        Presupuesto.Descuento = Math.Round(DescuentoTotal * (1 - PorcentajeFacturacion), 2)
        Presupuesto.CostoFinanciero = Math.Round(CostoFinanciero * (1 - PorcentajeFacturacion), 2)
        Presupuesto.VendedorNombreyApellido = Cb_Vendedores.Text
        Presupuesto.RazonSocialClienteMayorista = txt_RazonSocial.Text

        Dim NegPresupuesto As NegPresupuesto = New NegPresupuesto()

        Presupuesto.id_Presupuesto = NegPresupuesto.Alta(Presupuesto, ObtenerDetallePresupuesto(1 - PorcentajeFacturacion))

        Dim frmReportePresupuesto As frmReportePresupuesto = New frmReportePresupuesto()
        frmReportePresupuesto.presupuesto = Presupuesto
        frmReportePresupuesto.MdiParent = Funciones.ControlInstancia(MDIContenedor)
        frmReportePresupuesto.Show()
    End Sub

    Private Sub AltaPresupuestoSenia(id_Venta As Integer, TipoVenta As Integer, TipoPago As Integer, DescripcionTipoPago As String, id_Empleado As Integer, id_Encargado As Integer, id_Cliente As Integer, id_ListaPrecio As Integer, PorcentajeFacturacion As Double, MontoSenia As Double, id_Banco As Integer, CantidadCuotas As Integer, CostoFinanciero As Double)
        Dim MontoSeñaSinIva As Double = MontoSenia / ((0.21 * PorcentajeFacturacion) + 1)

        Dim Presupuesto As Presupuesto = New Presupuesto()
        Presupuesto.id_Venta = id_Venta
        Presupuesto.Fecha = Date.Now
        Presupuesto.id_ClienteMayorista = id_Cliente
        Presupuesto.id_Empleado = id_Empleado
        Presupuesto.id_Encargado = id_Encargado
        Presupuesto.id_ListaPrecio = id_ListaPrecio
        Presupuesto.id_Sucursal = id_Sucursal
        Presupuesto.id_TipoPago = TipoPago
        Presupuesto.id_TipoVenta = TipoVenta
        Presupuesto.Total = Math.Round(MontoSeñaSinIva * (1 - PorcentajeFacturacion), 2)
        Presupuesto.SubTotal = 0
        Presupuesto.Descuento = 0
        Presupuesto.VendedorNombreyApellido = Cb_Vendedores.Text
        Presupuesto.RazonSocialClienteMayorista = txt_RazonSocial.Text
        Presupuesto.DescripcionTipoPago = DescripcionTipoPago
        Presupuesto.id_Tarjeta = id_Banco
        Presupuesto.CantidadCuotas = CantidadCuotas
        Presupuesto.CostoFinanciero = CostoFinanciero


        Dim NegPresupuesto As NegPresupuesto = New NegPresupuesto()

        Dim presupuestoDetalle As List(Of Presupuesto_Detalle) = New List(Of Presupuesto_Detalle)

        Presupuesto.id_Presupuesto = NegPresupuesto.Alta(Presupuesto, ObtenerDetallePresupuesto(0))

        Dim frmReportePresupuesto As frmReportePresupuesto = New frmReportePresupuesto()
        frmReportePresupuesto.presupuesto = Presupuesto
        frmReportePresupuesto.MdiParent = Funciones.ControlInstancia(MDIContenedor)
        frmReportePresupuesto.Show()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Btn_NotaPedido.Click
        Try
            If (Not VentaValida("nota de pedido")) Then
                Return
            End If

            If (NotaPedido IsNot Nothing) Then
                If MessageBox.Show("¿Ésta seguro que desea actualizar la nota de pedido?", "Registro de Ventas", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = vbYes Then
                    ActualizarNotaPedido()

                    Funciones.ControlInstancia(frmNotaPedidoAdministracion).MdiParent = Funciones.ControlInstancia(MDIContenedor)
                    Funciones.ControlInstancia(frmNotaPedidoAdministracion).Show()
                End If
            Else
                If MessageBox.Show("¿Ésta seguro que desea efectuar la nota de pedido?", "Registro de Ventas", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = vbYes Then
                    CrearNuevaNotaPedido()
                End If
            End If

        Catch ex As Exception
            'Seteo el cursor.
            Me.Cursor = Cursors.Arrow
            'Muestro Mensaje.
            MessageBox.Show("Se ha producido un error al generado la nota de pedido. Por favor, Comuniquese con el administrador.", "Registro de Ventas", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub CrearNuevaNotaPedido()
        Dim TipoPago As Integer = Cb_TipoPago.SelectedValue 'Tipo de Pago.
        Dim id_Empleado As Integer = Cb_Vendedores.SelectedValue 'ID de Vendedor.
        Dim id_Encargado As Integer = Cb_Encargados.SelectedValue 'ID de Encargado.
        Dim id_ListaPrecio As Integer = Cb_ListaPrecio.SelectedValue
        Dim ConsumidorFinal As ConsumidorFinal = New ConsumidorFinal()
        Dim ClienteNegocio As NegClienteMayorista = New NegClienteMayorista()
        Dim NotaPedidoNegocio As Negocio.NegNotaPedido = New Negocio.NegNotaPedido()
        Dim NotaPedido As NotaPedido = New NotaPedido()

        If cb_Tipo.SelectedItem = "Minorista" Then
            Dim frmDatosClienteMinorista As frmDatosClienteMinorista = New frmDatosClienteMinorista()
            If frmDatosClienteMinorista.ShowDialog() = DialogResult.Cancel Then
                Return
            End If

            ConsumidorFinal.Apellido = frmDatosClienteMinorista.txt_Apellido.Text
            ConsumidorFinal.Email = String.Empty
            ConsumidorFinal.Nombre = frmDatosClienteMinorista.txt_Nombre.Text

            NotaPedido.Id_ConsumidorFinal = ClienteNegocio.AltaClienteConsumidorFinal(ConsumidorFinal)
            NotaPedido.id_TipoVenta = 1
            NotaPedido.PrecioTotal = CType(txt_TotalMinorista.Text, Decimal)
            NotaPedido.id_Cliente = 0
            NotaPedido.RazonSocialCliente = String.Empty
            NotaPedido.PorcentajeFacturacion = 0
            NotaPedido.ConsumidorFinalNombreYApellido = ConsumidorFinal.Apellido + ", " + ConsumidorFinal.Nombre
        Else
            NotaPedido.id_TipoVenta = 2
            NotaPedido.PrecioTotal = CType(txt_TotalMayorista.Text, Decimal)
            NotaPedido.id_Cliente = CInt(txt_id_Cliente.Text)
            NotaPedido.RazonSocialCliente = txt_RazonSocial.Text
            NotaPedido.PorcentajeFacturacion = txt_PorcentajeFacturacion.Text
            NotaPedido.Id_ConsumidorFinal = 0
            NotaPedido.ConsumidorFinalNombreYApellido = String.Empty
        End If

        NotaPedido.id_Empleado = id_Empleado
        NotaPedido.id_Encargado = id_Encargado
        NotaPedido.id_ListaPrecio = id_ListaPrecio
        NotaPedido.id_Sucursal = id_Sucursal
        NotaPedido.id_TipoPago = TipoPago
        NotaPedido.Vendida = False


        'si el pago es con tarjeta de credito
        If TipoPago = 2 Then
            Dim entCostoFinanciero As CostoFinanciero = CType(Cb_NumeroCuota.SelectedItem, CostoFinanciero)
            NotaPedido.Id_Tarjeta = entCostoFinanciero.Tarjeta
            NotaPedido.CantidadCuotas = entCostoFinanciero.NumeroCuotas
        End If

        NotaPedido.Fecha = DateTime.Now
        NotaPedido.id_NotaPedido = NotaPedidoNegocio.NuevaNotaPedido(NotaPedido, ObtenerDetalleNotaPedido(), id_Sucursal)
        Me.Cursor = Cursors.Arrow
        MessageBox.Show("Se ha generado la nota de pedido correctamente.", "Registro de Ventas", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Me.Close()

    End Sub

    Private Sub ActualizarNotaPedido()
        Dim TipoPago As Integer = Cb_TipoPago.SelectedValue 'Tipo de Pago.
        Dim id_Empleado As Integer = Cb_Vendedores.SelectedValue 'ID de Vendedor.
        Dim id_Encargado As Integer = Cb_Encargados.SelectedValue 'ID de Encargado.
        Dim id_ListaPrecio As Integer = Cb_ListaPrecio.SelectedValue
        Dim ConsumidorFinal As ConsumidorFinal = New ConsumidorFinal()
        Dim ClienteNegocio As NegClienteMayorista = New NegClienteMayorista()
        Dim NotaPedidoNegocio As Negocio.NegNotaPedido = New Negocio.NegNotaPedido()

        If cb_Tipo.SelectedItem = "Minorista" Then
            ConsumidorFinal = ClienteNegocio.ConsultaClienteConsumidorFinal(NotaPedido.Id_ConsumidorFinal)
            Dim frmDatosClienteMinorista As frmDatosClienteMinorista = New frmDatosClienteMinorista()
            frmDatosClienteMinorista.txt_Apellido.Text = ConsumidorFinal.Apellido
            frmDatosClienteMinorista.txt_Nombre.Text = ConsumidorFinal.Nombre


            If frmDatosClienteMinorista.ShowDialog() = DialogResult.Cancel Then
                Return
            End If

            If (ConsumidorFinal.Apellido <> frmDatosClienteMinorista.txt_Apellido.Text Or ConsumidorFinal.Nombre <> frmDatosClienteMinorista.txt_Nombre.Text) Then
                ConsumidorFinal.Apellido = frmDatosClienteMinorista.txt_Apellido.Text
                ConsumidorFinal.Email = String.Empty
                ConsumidorFinal.Nombre = frmDatosClienteMinorista.txt_Nombre.Text

                NotaPedido.Id_ConsumidorFinal = ClienteNegocio.AltaClienteConsumidorFinal(ConsumidorFinal)
            End If

            NotaPedido.id_TipoVenta = 1
            NotaPedido.PrecioTotal = CType(txt_TotalMinorista.Text, Decimal)
            NotaPedido.id_Cliente = 0
            NotaPedido.RazonSocialCliente = String.Empty
            NotaPedido.PorcentajeFacturacion = 0
            NotaPedido.ConsumidorFinalNombreYApellido = ConsumidorFinal.Apellido + ", " + ConsumidorFinal.Nombre
        Else
            NotaPedido.id_TipoVenta = 2
            NotaPedido.PrecioTotal = CType(txt_TotalMayorista.Text, Decimal)
            NotaPedido.id_Cliente = CInt(txt_id_Cliente.Text)
            NotaPedido.PorcentajeFacturacion = CDbl(txt_PorcentajeFacturacion.Text)
            NotaPedido.RazonSocialCliente = txt_RazonSocial.Text
            NotaPedido.Id_ConsumidorFinal = 0
            NotaPedido.ConsumidorFinalNombreYApellido = String.Empty
        End If

        'si el pago es con tarjeta de credito
        If TipoPago = 2 Then
            Dim entCostoFinanciero As CostoFinanciero = CType(Cb_NumeroCuota.SelectedItem, CostoFinanciero)
            NotaPedido.Id_Tarjeta = entCostoFinanciero.Tarjeta
            NotaPedido.CantidadCuotas = entCostoFinanciero.NumeroCuotas
        End If

        NotaPedido.EmpleadoNombreyApellido = Cb_Vendedores.Text
        NotaPedido.id_Empleado = id_Empleado
        NotaPedido.id_Encargado = id_Encargado
        NotaPedido.id_ListaPrecio = id_ListaPrecio
        NotaPedido.id_Sucursal = id_Sucursal
        NotaPedido.id_TipoPago = TipoPago
        NotaPedido.Vendida = False

        NotaPedidoNegocio.ActualizarNotaPedido(NotaPedido, ObtenerDetalleNotaPedido(), id_Sucursal)
        Me.Cursor = Cursors.Arrow
        MessageBox.Show("Se ha actualizado la nota de pedido correctamente.", "Registro de Ventas", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Dim form As Form = Funciones.ControlInstancia(frmNotaPedidoAdministracion)
        If (form IsNot Nothing) Then
            form.Refresh()
            form.Show()
        End If
        Close()
    End Sub

    Private Function ObtenerDetalleNotaPedido() As List(Of NotaPedido_Detalle)
        Dim detalleNotaPedido As List(Of Entidades.NotaPedido_Detalle) = New List(Of Entidades.NotaPedido_Detalle)()

        For i = 0 To DG_Productos.Rows.Count - 1
            If CInt(DG_Productos.Rows(i).Cells.Item("ID").Value) > 0 And CInt(DG_Productos.Rows(i).Cells.Item("CANTIDAD").Value) > 0 Then
                Dim detalle As Entidades.NotaPedido_Detalle = New Entidades.NotaPedido_Detalle()
                detalle.Cantidad = CInt(DG_Productos.Rows(i).Cells.Item("CANTIDAD").Value)
                detalle.id_Producto = CInt(DG_Productos.Rows(i).Cells.Item("ID").Value)
                detalle.Precio = CDbl(DG_Productos.Rows(i).Cells.Item("PRECIO").Value)
                detalle.Iva = CDbl(DG_Productos.Rows(i).Cells.Item("IVA").Value)
                detalle.Monto = CDbl(DG_Productos.Rows(i).Cells.Item("MONTO").Value)

                detalleNotaPedido.Add(detalle)
            End If
        Next

        Return detalleNotaPedido
    End Function

    Private Function ObtenerDetallePresupuesto(porcentaje As Double) As List(Of Presupuesto_Detalle)
        Dim detalleNotaPedido As List(Of Entidades.Presupuesto_Detalle) = New List(Of Entidades.Presupuesto_Detalle)()

        For i = 0 To DG_Productos.Rows.Count - 1
            If CInt(DG_Productos.Rows(i).Cells.Item("ID").Value) > 0 And CInt(DG_Productos.Rows(i).Cells.Item("CANTIDAD").Value) > 0 Then
                Dim detalle As Entidades.Presupuesto_Detalle = New Entidades.Presupuesto_Detalle()
                detalle.Cantidad = CInt(DG_Productos.Rows(i).Cells.Item("CANTIDAD").Value)
                detalle.id_Producto = CInt(DG_Productos.Rows(i).Cells.Item("ID").Value)
                detalle.Precio = CDbl(DG_Productos.Rows(i).Cells.Item("PRECIO").Value) * porcentaje
                detalle.Iva = 0
                detalle.Monto = CDbl(DG_Productos.Rows(i).Cells.Item("PRECIO").Value) * porcentaje

                detalleNotaPedido.Add(detalle)
            End If
        Next

        Return detalleNotaPedido
    End Function

    Private Async Sub BtnSenia_Click(sender As Object, e As EventArgs) Handles BtnSenia.Click
        Try
            'Obtengo toda la informacion.
            Dim TipoVenta As Integer = 0 'Tipo de Venta.
            Dim TipoPago As Integer = Cb_TipoPago.SelectedValue 'Tipo de Pago.
            Dim id_Empleado As Integer = Cb_Vendedores.SelectedValue 'ID de Vendedor.
            Dim id_Encargado As Integer = Cb_Encargados.SelectedValue 'ID de Encargado.
            Dim id_ListaPrecio As Integer = Cb_ListaPrecio.SelectedValue
            Dim id_Cliente As Integer = 0 'ID de Cliente.
            Dim Id_Tarjeta As Integer = 0
            Dim NumerCuotas As Integer = 0
            Dim Facturar As Boolean = False 'Variable que indica si la venta ´facturará o no.
            Dim Descuento As Double = 0 'Descuento ingresado.
            Dim CostoFinanciero As Double = CType(txt_SeniaCostoFinanciero.Text, Decimal)
            Dim MontoTotalSinDescuento As Double = 0 'Monto total de la venta.
            Dim MontoTotal As Double = 0 'Monto total de la venta menos el descuento.
            Dim MontoSenia As Double = 0 'Monto total de la seña.
            Dim CantidadTotal As Integer = CalcularCantidadTotal() 'Cantidad total de articulos.
            Dim TipoPagoControlador As String = "" 'Variable que se imprime en el tique fiscal.
            Dim DiferenciaPagoCheque As Double = 0 'Es el importe que falta cubrir de los cheques recividos como pago
            Dim IvaTotal As Double = 0 'Iva total de la vental
            Dim PorcentajeFacturacion As Double = 0

            If (Not VentaReserva()) Then
                Return
            End If

            'Tiene asignado vendedor.
            If MessageBox.Show("¿Ésta seguro que desea efectuar la reserva?", "Registro de Ventas", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = vbYes Then
                If (MessageBox.Show("¿Desea facturar la reserva?", "Registro de Ventas", MessageBoxButtons.YesNo, MessageBoxIcon.Information) = vbYes) Then
                    Facturar = True
                Else
                    Facturar = False
                End If

                'Seteo TipoVenta
                If cb_Tipo.SelectedItem = "Minorista" Then
                    TipoVenta = 1
                    PorcentajeFacturacion = 1
                    MontoTotalSinDescuento = CType(txt_SubtotalMinorista.Text, Decimal)
                    Descuento = CType(txt_DescuentoMinorista.Text, Decimal)
                    MontoTotal = CType(txt_TotalMinorista.Text, Decimal) - CType(txt_CFTMinorista.Text, Decimal)
                    MontoSenia = CType(txt_Senia.Text, Decimal)
                Else
                    TipoVenta = 2
                    PorcentajeFacturacion = CType(txt_PorcentajeFacturacion.Text, Decimal) / 100
                    Descuento = CType(txt_DescuentoMayorista.Text, Decimal)
                    MontoTotalSinDescuento = CType(txt_SubtotalMayorista.Text, Decimal) - CType(txt_CFTMayorista.Text, Decimal)
                    IvaTotal = CType(txt_ivaTotalMayorista.Text, Decimal) - (CType(txt_CFTMayorista.Text, Decimal) * 0.21)
                    MontoTotal = CType(txt_TotalMayorista.Text, Decimal) - (CType(txt_CFTMayorista.Text, Decimal) * 1.21)
                    MontoSenia = CType(txt_Senia.Text, Decimal)
                End If

                'si el pago es con tarjeta de credito
                If TipoPago = 2 Then
                    Dim entCostoFinanciero As CostoFinanciero = CType(Cb_NumeroCuota.SelectedItem, CostoFinanciero)
                    Id_Tarjeta = entCostoFinanciero.Tarjeta
                    NumerCuotas = entCostoFinanciero.NumeroCuotas
                End If

                'Seteo ID Cliente
                If txt_id_Cliente.Text = "" Then
                    id_Cliente = 0
                Else
                    id_Cliente = CInt(txt_id_Cliente.Text)
                End If

                Dim dtProductos As DataTable = ConvertirDataGridViewADataTable(DG_Productos)

                'Si el tipo de pago es cheque abro la ventana para cargar ingresar el cheque
                If TipoPago = 4 Then
                    'invoca la pantalla de carga de cheques y quedo a la espera del cierre
                    DiferenciaPagoCheque = Await CargarCheques(Facturar, MontoSenia)
                    'en caso que la diferencia de pago en cheques sea -1 es porque el usuario cancelo la carga de los cheques y se cancela la alta de la venta
                    If (DiferenciaPagoCheque = -1) Then
                        Return
                    End If
                End If

                Dim frmSeniaDatos As frmSeniaDatos = New frmSeniaDatos(If(TipoVenta = 1, TipoCliente.Minorista, TipoCliente.Mayorista), id_Empleado, id_Empleado, Cb_TipoPago.SelectedText, Facturar, id_Cliente, MontoTotalSinDescuento, Descuento, MontoSenia, MontoTotal, IvaTotal, PorcentajeFacturacion * 100, dtProductos, Date.Now)
                If (Not frmSeniaDatos.ShowDialog() = DialogResult.OK) Then
                    Return
                End If

                Dim Senia As Entidades.Senia = frmSeniaDatos.Senia

                Dim id_Venta As Integer = RegistrarVenta(TipoVenta, TipoPago, id_Empleado, id_Encargado, id_Cliente, Id_Tarjeta, NumerCuotas, PorcentajeFacturacion * 100, id_ListaPrecio, Descuento, CostoFinanciero, MontoTotalSinDescuento, MontoTotal, CantidadTotal, DiferenciaPagoCheque, MontoSenia, True)
                If id_Venta > 0 Then

                    'Si hay que facturar abro el form.
                    If Facturar Then
                        Dim resultado = FacturarVenta(TipoPago, id_Cliente, MontoSenia, CostoFinanciero, id_Venta, PorcentajeFacturacion)
                        'Si cacelo la factura se tiene que eliminar la venta y frenar el proceso de venta.
                        If resultado = DialogResult.Cancel Then
                            NegVentas.Eliminar(id_Venta)
                            Return
                        End If
                    End If

                    ActualizarStock()

                    Senia.IdVentaSenia = id_Venta
                    negSenia.CrearSenia(Senia)

                    RegistrarComisionesEncargadoEmpleado(id_Empleado, id_Encargado, id_Cliente, MontoSenia, id_Venta)

                    'Seteo el cursor.
                    Me.Cursor = Cursors.Arrow

                    'Muestro Mensaje.
                    MessageBox.Show("La reserva ha sido generada correctamente.", "Registro de Ventas", MessageBoxButtons.OK, MessageBoxIcon.Question)

                    'Si no se factura el 100% de la venta armo un presupuesto por el monto no facturado
                    If Facturar AndAlso PorcentajeFacturacion < 1 AndAlso MessageBox.Show("¿Desea Generar un presupuesto por el monto no facturado?", "Registro de Ventas", MessageBoxButtons.YesNo, MessageBoxIcon.Information) = DialogResult.Yes Then
                        AltaPresupuestoSenia(id_Venta, TipoVenta, TipoPago, Cb_TipoPago.Text, id_Empleado, id_Encargado, id_Cliente, id_ListaPrecio, PorcentajeFacturacion, MontoSenia, Id_Tarjeta, NumerCuotas, CostoFinanciero)
                    End If

                    'Fin de la venta.
                    Me.Close()
                Else
                    'Muestro Mensaje.
                    MessageBox.Show("Se ha producido un error al registrar la venta. Por favor, Comuniquese con el administrador.", "Registro de Ventas", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            End If
        Catch ex As Exception
            'Seteo el cursor.
            Me.Cursor = Cursors.Arrow
            'Muestro Mensaje.
            MessageBox.Show("Se ha producido un error al confirmar la venta. Por favor, Comuniquese con el administrador.", "Registro de Ventas", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Function ConvertirDataGridViewADataTable(dataGridView As DataGridView) As DataTable
        Dim dtProductos As New DataTable

        For Each column As DataGridViewColumn In dataGridView.Columns
            dtProductos.Columns.Add(column.Name)
        Next

        For Each row As DataGridViewRow In dataGridView.Rows
            Dim dataRow As DataRow = dtProductos.NewRow()
            For Each cell As DataGridViewCell In row.Cells
                dataRow(cell.ColumnIndex) = cell.Value
            Next
            dtProductos.Rows.Add(dataRow)
        Next

        Return dtProductos
    End Function

    Private Function VentaReserva() As Boolean
        Dim TotalProductos As Integer = DG_Productos.Rows.Count 'Total de productos cargados.

        'Chequeo que haya al menos un producto cargado.
        If TotalProductos <= 0 Then
            'Muestro Mensaje.
            MessageBox.Show("La reserva no puede efectuarse. No hay productos cargados !!", "Registro de Ventas", MessageBoxButtons.OK, MessageBoxIcon.Stop)
            Return False
        End If
        'Tiene al menos un producto.
        'Chequeo que haya asignado al menos un vendedor a la venta.
        If Cb_Vendedores.SelectedValue <= 0 Then
            'Muestro Mensaje.
            MessageBox.Show("La reserva no puede efectuarse. Debe seleccionar un vendedor responsable de la venta.", "Registro de Ventas", MessageBoxButtons.OK, MessageBoxIcon.Stop)
            Return False
        End If
        If Cb_Encargados.SelectedValue <= 0 Then
            'Muestro Mensaje.
            MessageBox.Show("La reserva no puede efectuarse. Debe seleccionar un encargado responsable de la venta.", "Registro de Ventas", MessageBoxButtons.OK, MessageBoxIcon.Stop)
            Return False
        End If
        If Cb_TipoPago.SelectedValue <= 0 Then
            'Muestro Mensaje.
            MessageBox.Show("La reserva no puede efectuarse. Debe seleccionar un tipo de pago a la venta.", "Registro de Ventas", MessageBoxButtons.OK, MessageBoxIcon.Stop)
            Return False
        End If
        'Chequeo que el monto de la seña sea mayor a 0
        If CType(txt_Senia.Text, Decimal) = 0 Then
            'Muestro Mensaje.
            MessageBox.Show("La reserva no puede efectuarse. El monto de la seña debe ser mayor a cero.", "Registro de Ventas", MessageBoxButtons.OK, MessageBoxIcon.Stop)
            Return False
        End If

        If (cb_Tipo.SelectedItem = "Minorista") Then
            'Chequeo que el monto de la seña no supere el monto de la venta
            If CType(txt_Senia.Text, Decimal) > CType(txt_TotalMinorista.Text, Decimal) Then
                'Muestro Mensaje.
                MessageBox.Show("La reserva no puede efectuarse. El monto de la seña debe ser menor al importe a abonar.", "Registro de Ventas", MessageBoxButtons.OK, MessageBoxIcon.Stop)
                Return False
            End If
        Else
            If CType(txt_Senia.Text, Decimal) > CType(txt_TotalMayorista.Text, Decimal) Then
                'Muestro Mensaje.
                MessageBox.Show("La reserva no puede efectuarse. El monto de la seña debe ser menor al importe a abonar.", "Registro de Ventas", MessageBoxButtons.OK, MessageBoxIcon.Stop)
                Return False
            End If
        End If
        Return True
    End Function

    Private Function VentaValida(accion As String) As Boolean
        Dim TotalProductos As Integer = DG_Productos.Rows.Count 'Total de productos cargados.

        'Chequeo que haya al menos un producto cargado.
        If TotalProductos <= 0 Then
            'Muestro Mensaje.
            MessageBox.Show(String.Format("La {0} no puede efectuarse. No hay productos cargados !!", accion), "Registro de Ventas", MessageBoxButtons.OK, MessageBoxIcon.Stop)
            Return False
        End If
        'Tiene al menos un producto.
        'Chequeo que haya asignado al menos un vendedor a la venta.
        If Cb_Vendedores.SelectedValue <= 0 Then
            'Muestro Mensaje.
            MessageBox.Show(String.Format("La {0} no puede efectuarse. Debe seleccionar un vendedor responsable de la {0}.", accion), "Registro de Ventas", MessageBoxButtons.OK, MessageBoxIcon.Stop)
            Return False
        End If
        If Cb_Encargados.SelectedValue <= 0 Then
            'Muestro Mensaje.
            MessageBox.Show(String.Format("La {0} no puede efectuarse. Debe seleccionar un encargado responsable de la {0}.", accion), "Registro de Ventas", MessageBoxButtons.OK, MessageBoxIcon.Stop)
            Return False
        End If
        If Cb_TipoPago.SelectedValue <= 0 Then
            'Muestro Mensaje.
            MessageBox.Show(String.Format("La {0} no puede efectuarse. Debe seleccionar un tipo de pago a la {0}.", accion), "Registro de Ventas", MessageBoxButtons.OK, MessageBoxIcon.Stop)
            Return False
        End If

        If cb_Tipo.SelectedItem = "Mayorista" AndAlso txt_id_Cliente.Text = "" Then
            'Muestro Mensaje.
            MessageBox.Show(String.Format("La {0} no puede efectuarse. Debe seleccionar un cliente a la {0}.", accion), "Registro de Ventas", MessageBoxButtons.OK, MessageBoxIcon.Stop)
            Return False
        End If

        If (TypeOf Cb_TipoPago.SelectedValue Is String AndAlso Cb_TipoPago.SelectedValue = 2 AndAlso Cb_Tarjeta.SelectedIndex = 0) Then
            'Muestro Mensaje.
            MessageBox.Show(String.Format("La {0} no puede efectuarse. Debe seleccionar un banco emisor a la {0}.", accion), "Registro de Ventas", MessageBoxButtons.OK, MessageBoxIcon.Stop)
            Return False
        End If


        Return True
    End Function

    Private Function RegistrarVenta(TipoVenta As Integer, TipoPago As Integer, id_Empleado As Integer, id_Encargado As Integer, id_Cliente As Integer, Id_Tarjeta As Integer, CantidadCuotas As Integer, PorcentajeFacturacion As Double, id_ListaPrecio As Integer, Descuento As Double, CostoFinanciero As Double, MontoTotalSinDescuento As Double, MontoTotal As Double, CantidadTotal As Integer, DiferenciaPagoCheque As Double, MontoSenia As Double, EsSenia As Boolean) As Integer

        'Seteo el cursor.
        Me.Cursor = Cursors.WaitCursor

        'Datos de la venta.
        EntVentas.id_Cliente = id_Cliente
        EntVentas.PorcentajeFacturacion = PorcentajeFacturacion
        EntVentas.id_Empleado = id_Empleado
        EntVentas.id_Encargado = id_Encargado
        EntVentas.id_Sucursal = id_Sucursal
        EntVentas.id_TipoPago = TipoPago
        EntVentas.id_TipoVenta = TipoVenta
        EntVentas.id_ListaPrecio = id_ListaPrecio
        EntVentas.id_Tarjeta = Id_Tarjeta
        EntVentas.CantidadCuotas = CantidadCuotas
        EntVentas.CantidadTotal = CantidadTotal
        EntVentas.Descuento = Descuento
        EntVentas.CostoFinanciero = CostoFinanciero
        EntVentas.SubTotal = MontoTotalSinDescuento
        EntVentas.PrecioTotal = MontoTotal - DiferenciaPagoCheque
        EntVentas.Anulado = 0
        EntVentas.Habilitado = 1
        EntVentas.Facturado = 0
        EntVentas.DiferenciaPagoCheque = DiferenciaPagoCheque
        EntVentas.MontoSenia = MontoSenia
        EntVentas.Senia = EsSenia

        Dim DetalleDevolucion As List(Of Entidades.Devolucion_Detalle) = New List(Of Entidades.Devolucion_Detalle)
        Dim DetalleVenta = New List(Of Entidades.Ventas_Detalle)

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
                EntVentasDetalle.Iva = CDbl(DG_Productos.Rows(i).Cells.Item("IVA").Value)
                EntVentasDetalle.Monto = CDbl(DG_Productos.Rows(i).Cells.Item("MONTO").Value)
                DetalleVenta.Add(EntVentasDetalle)
            End If
        Next

        'Numero de Venta.
        Dim id_Venta As Integer = 0
        NegVentas.NuevaVenta(EntVentas, DetalleVenta, id_Venta)
        Me.Cursor = Cursors.Arrow

        Return id_Venta
    End Function

    Private Sub ActualizarStock()
        For i = 0 To DG_Productos.Rows.Count - 1
            'Descuento el stock de los productos si el precio es positivo, y agrego el stock si el precio es negativo ( será un cambio ).
            If CDbl(DG_Productos.Rows(i).Cells.Item("PRECIO").Value) < 0 Then
                NegStock.AgregarStock(CInt(DG_Productos.Rows(i).Cells.Item("ID").Value), id_Sucursal, CInt(DG_Productos.Rows(i).Cells.Item("CANTIDAD").Value))
            Else
                NegStock.DisminuirStock(CInt(DG_Productos.Rows(i).Cells.Item("ID").Value), CInt(DG_Productos.Rows(i).Cells.Item("CANTIDAD").Value), id_Sucursal)
            End If
        Next
    End Sub

    Private Sub ActualizarStockDesdeSenia()
        Dim SeniaDetalle As DataSet = NegVentas.TraerVentaDetalle(Me.Senia.IdVentaSenia)

        'Controlo si se agrega un nuevo producto a los productos señados o si se modifica la cantidad para actualizar el stock
        For i = 0 To DG_Productos.Rows.Count - 1

            Dim ProductoSeniado As DataRow = SeniaDetalle.Tables(0).Rows.Cast(Of DataRow).Where(Function(x) x("id_Producto") = DG_Productos.Rows(i).Cells.Item("ID").Value).FirstOrDefault()

            'Si es un producto que no fue señado
            If (ProductoSeniado Is Nothing) Then

                'Descuento el stock de los productos si el precio es positivo, y agrego el stock si el precio es negativo ( será un cambio ).
                If CDbl(DG_Productos.Rows(i).Cells.Item("PRECIO").Value) < 0 Then
                    NegStock.AgregarStock(CInt(DG_Productos.Rows(i).Cells.Item("ID").Value), id_Sucursal, CInt(DG_Productos.Rows(i).Cells.Item("CANTIDAD").Value))
                Else
                    NegStock.DisminuirStock(CInt(DG_Productos.Rows(i).Cells.Item("ID").Value), CInt(DG_Productos.Rows(i).Cells.Item("CANTIDAD").Value), id_Sucursal)
                End If

                'Si es un producto que fue señado
            Else
                'Verifico si hay alguna diferencia en las cantidades 
                Dim diferenciaCantiadad As Integer = CInt(ProductoSeniado("Cantidad") - CInt(DG_Productos.Rows(i).Cells.Item("CANTIDAD").Value))
                'Si la diferencia es positiva aumento el stock
                If (diferenciaCantiadad > 0) Then
                    NegStock.AgregarStock(CInt(DG_Productos.Rows(i).Cells.Item("ID").Value), id_Sucursal, diferenciaCantiadad)
                    'Si la diferencia es negativa disminuyo el stock
                ElseIf (diferenciaCantiadad < 0) Then
                    NegStock.DisminuirStock(CInt(DG_Productos.Rows(i).Cells.Item("ID").Value), Math.Abs(diferenciaCantiadad), id_Sucursal)
                End If
            End If
        Next

        'Controlo si un producto se quitaron a los productos señados para actualizar el stock
        For i = 0 To SeniaDetalle.Tables(0).Rows.Count - 1
            Dim idProductoSeniado As Integer = SeniaDetalle.Tables(0).Rows(i)("id_Producto")
            'Si el producto señado fue quitado hay que incrementar su stock
            If (Not DG_Productos.Rows.Cast(Of DataGridViewRow).Any(Function(x) CInt(x.Cells.Item("ID").Value) = idProductoSeniado)) Then
                NegStock.AgregarStock(idProductoSeniado, id_Sucursal, CInt(SeniaDetalle.Tables(0).Rows(i)("Cantidad")))
            End If
        Next
    End Sub

    Private Function RegistrarComisionesEncargadoEmpleado(id_Empleado As Integer, id_Encargado As Integer, id_Cliente As Integer, MontoTotal As Double, id_Venta As Integer) As Double
        Dim Monto As Double
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
        Return Monto
    End Function

    Private Function FacturarVenta(TipoPago As Integer, id_Cliente As Integer, Descuento As Double, CostoFinanciero As Double, SubTotal As Double, MontoTotal As Double, IvaTotal As Double, MontoSenia As Double, id_Venta As Integer, PorcentajeFacturacion As Double) As DialogResult
        Dim TipoPagoControlador As String

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

        Dim frmFacturar As frmFacturar = New frmFacturar()

        If (cb_Tipo.SelectedItem = "Minorista") Then
            frmFacturar.id_Venta = id_Venta
            frmFacturar.id_Cliente = id_Cliente
            frmFacturar.Monto = MontoTotal
            frmFacturar.Descuento = Descuento + MontoSenia
            frmFacturar.CostoFinanciero = CostoFinanciero
            frmFacturar.SubTotal = SubTotal
            frmFacturar.TipoPago = TipoPagoControlador
            frmFacturar.TipoCliente = TipoCliente.Minorista
            frmFacturar.EsSenia = False
            frmFacturar.PorcentajeFacturacion = 1
        Else

            Dim MontoSeñaSinIva As Double = MontoSenia / ((0.21 * PorcentajeFacturacion) + 1)
            Dim DescuentoTotal As Double = Descuento + MontoSeñaSinIva
            frmFacturar.id_Venta = id_Venta
            frmFacturar.id_Cliente = id_Cliente
            frmFacturar.Descuento = Math.Round(DescuentoTotal * PorcentajeFacturacion, 2)
            frmFacturar.CostoFinanciero = Math.Round(CostoFinanciero * PorcentajeFacturacion, 2)
            frmFacturar.SubTotal = Math.Round((CalcularPrecioTotal() - DescuentoTotal + CostoFinanciero) * PorcentajeFacturacion, 2)
            frmFacturar.IvaTotal = Math.Round(frmFacturar.SubTotal * 0.21, 2)
            frmFacturar.Monto = Math.Round(frmFacturar.SubTotal + frmFacturar.IvaTotal, 2)
            frmFacturar.TipoPago = TipoPagoControlador
            frmFacturar.TipoCliente = TipoCliente.Mayorista
            frmFacturar.EsSenia = False
            frmFacturar.PorcentajeFacturacion = PorcentajeFacturacion
        End If

        Return frmFacturar.ShowDialog()
    End Function

    Private Function FacturarVenta(TipoPago As Integer, id_Cliente As Integer, MontoSenia As Double, CostoFinanciero As Double, id_Venta As Integer, PorcentajeFacturacion As Double) As String
        Dim TipoPagoControlador As String

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

        Dim frmFacturar As frmFacturar = New frmFacturar()

        If (cb_Tipo.SelectedItem = "Minorista") Then
            frmFacturar.id_Venta = id_Venta
            frmFacturar.id_Cliente = id_Cliente
            frmFacturar.TipoPago = TipoPagoControlador
            frmFacturar.TipoCliente = TipoCliente.Minorista
            frmFacturar.CostoFinanciero = CostoFinanciero
            frmFacturar.SubTotal = MontoSenia
            frmFacturar.Monto = MontoSenia + CostoFinanciero
            frmFacturar.MontoSenia = MontoSenia
            frmFacturar.EsSenia = True
            frmFacturar.PorcentajeFacturacion = 1
        Else

            Dim MontoSeñaSinIva As Double = MontoSenia / ((0.21 * PorcentajeFacturacion) + 1)
            Dim CostoFinancieroSinIva As Double = CostoFinanciero / ((0.21 * PorcentajeFacturacion) + 1)
            frmFacturar.id_Venta = id_Venta
            frmFacturar.id_Cliente = id_Cliente
            frmFacturar.TipoPago = TipoPagoControlador
            frmFacturar.TipoCliente = TipoCliente.Mayorista
            frmFacturar.CostoFinanciero = Math.Round(CostoFinancieroSinIva, 2)
            frmFacturar.SubTotal = Math.Round((MontoSeñaSinIva + CostoFinancieroSinIva) * PorcentajeFacturacion, 2)
            frmFacturar.IvaTotal = Math.Round(frmFacturar.SubTotal * 0.21, 2)
            frmFacturar.Monto = Math.Round(frmFacturar.SubTotal + frmFacturar.IvaTotal, 2)
            frmFacturar.MontoSenia = Math.Round(MontoSeñaSinIva * PorcentajeFacturacion * 1.21, 2)
            frmFacturar.EsSenia = True
            frmFacturar.PorcentajeFacturacion = PorcentajeFacturacion
        End If

        Return frmFacturar.ShowDialog()
    End Function

    Private Sub txt_CodigoBarra_KeyDown(sender As Object, e As KeyEventArgs) Handles txt_CodigoBarra.KeyDown
        If e.KeyData = Keys.Enter Then
            Me.Cursor = Cursors.WaitCursor
            BuscarProducto()
            Me.Cursor = Cursors.Arrow
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

    Private Sub txt_Descuento_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txt_DescuentoMinorista.GotFocus
        txt_DescuentoMinorista.Clear()
    End Sub

    Private Sub txt_DescuentoMayorista_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txt_DescuentoMayorista.GotFocus
        txt_DescuentoMayorista.Clear()
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

    Private Sub txt_DescuentoMayorista_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_DescuentoMayorista.KeyPress
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

    Private Sub txt_PorcentajeFacturacion_KeyDown(sender As Object, e As KeyEventArgs) Handles txt_PorcentajeFacturacion.KeyDown
        If (e.KeyCode = Keys.Enter) Then
            e.SuppressKeyPress = True
            txt_CodigoBarra.Focus()
        End If
    End Sub

    Private Sub txt_PorcentajeDesceunto_KeyDown(sender As Object, e As KeyEventArgs) Handles txt_PorcentajeBonificacion.KeyDown
        If (e.KeyCode = Keys.Enter) Then
            e.SuppressKeyPress = True
            txt_CodigoBarra.Focus()
        End If
    End Sub

    Private Sub txt_Senia_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_Senia.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            e.Handled = True
            BtnSenia.Focus()
        End If

        Dim KeyAscii As Short = CShort(Asc(e.KeyChar))
        KeyAscii = CShort(NegErrores.SoloCurrency(KeyAscii))
        If KeyAscii = 0 Then
            e.Handled = True
        End If
    End Sub
    Private Sub txt_Senia_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txt_Senia.GotFocus
        txt_Senia.Clear()
    End Sub

    Private Sub txt_Descuento_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txt_DescuentoMinorista.LostFocus
        If txt_DescuentoMinorista.Text.Trim = "" Then
            txt_DescuentoMinorista.Text = "0,00"
        End If

        PorcentajeDescuento = CType(txt_DescuentoMinorista.Text, Double) / CalcularPrecioTotal()
        txt_PorcentajeBonificacion.Text = Math.Round(PorcentajeDescuento * 100, 0, MidpointRounding.ToEven)

        CalcularTotales()

    End Sub

    Private Sub txt_Senia_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txt_Senia.LostFocus
        If txt_Senia.Text.Trim = "" Then
            txt_Senia.Text = "0,00"
        End If
        CalcularTotales()
        txt_Senia.Text = Format(CType(txt_Senia.Text, Decimal), "###0.00")
    End Sub

    Private Sub txt_DescuentoMayorista_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txt_DescuentoMayorista.LostFocus
        If txt_DescuentoMayorista.Text.Trim = "" Then
            txt_DescuentoMayorista.Text = "0,00"
        End If

        PorcentajeDescuento = CType(txt_DescuentoMayorista.Text, Double) / CalcularPrecioTotal()
        txt_PorcentajeBonificacion.Text = Math.Round(PorcentajeDescuento * 100, 0, MidpointRounding.ToEven)

        CalcularTotales()
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
            'Es EFECTIVO
            If (TypeOf Cb_TipoPago.SelectedValue Is String AndAlso Cb_TipoPago.SelectedValue = 1) Then
                Label33.Enabled = True
                txt_PorcentajeBonificacion.Enabled = True
                txt_PorcentajeBonificacion.Value = My.Settings.DescuentoMinorista
                PorcentajeDescuento = My.Settings.DescuentoMinorista / 100
            Else
                Label33.Enabled = False
                txt_PorcentajeBonificacion.Enabled = False
                txt_PorcentajeBonificacion.Value = 0
            End If
        End If

        If (TypeOf Cb_TipoPago.SelectedValue Is String AndAlso Cb_TipoPago.SelectedValue = 2) Then
            Cb_Tarjeta.Enabled = True
            Cb_NumeroCuota.Enabled = True
            txt_CostoFinanciero.Enabled = True
        Else
            Cb_Tarjeta.Enabled = False
            Cb_Tarjeta.SelectedValue = 0
            Cb_NumeroCuota.Enabled = False
            Cb_NumeroCuota.SelectedValue = 0
            txt_CostoFinanciero.Enabled = False
            txt_CostoFinanciero.Text = Format(0, "P")
        End If

        If (DG_Productos.Rows.Count > 0) Then
            ActualizarMontosGrillaYTotales()
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

    Private Function ObtenerCostoFinanciero() As Double
        If (Cb_NumeroCuota.SelectedItem IsNot Nothing AndAlso TypeOf Cb_TipoPago.SelectedValue Is String AndAlso Cb_TipoPago.SelectedValue = 2) Then
            Return CType(Cb_NumeroCuota.SelectedItem, CostoFinanciero).PorcentajeRecargo
        Else
            Return 0
        End If
    End Function

    Private Sub txt_PorcentajeFacturacion_Leave(sender As Object, e As EventArgs) Handles txt_PorcentajeFacturacion.Leave
        If txt_PorcentajeFacturacion.Text.Trim = "" Then
            txt_PorcentajeFacturacion.Text = "0"
        End If

        If (DG_Productos.Rows.Count > 0) Then
            ActualizarMontosGrillaYTotales()
        End If
    End Sub

    Private Sub txt_PorcentajeDesceunto_Leave(sender As Object, e As EventArgs) Handles txt_PorcentajeBonificacion.Leave
        If txt_PorcentajeBonificacion.Text.Trim = "" Then
            txt_PorcentajeBonificacion.Text = "0"
        End If

        PorcentajeDescuento = CType(txt_PorcentajeBonificacion.Text, Double) / 100

        If (DG_Productos.Rows.Count > 0) Then
            CalcularTotales()
        End If

    End Sub

    Private Sub Cb_Banco_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Cb_Tarjeta.SelectedIndexChanged
        If (Cb_Tarjeta.SelectedValue > 0) Then
            CostoFinancieroBindingSource.DataSource = NegTarjeta.TraerCostosFinancieros(Cb_Tarjeta.SelectedValue)
            Cb_NumeroCuota_SelectedIndexChanged(Nothing, Nothing)
        Else
            Dim CosotosFinancieros As List(Of CostoFinanciero) = New List(Of CostoFinanciero)
            CosotosFinancieros.Add(New CostoFinanciero() With {.Tarjeta = 0, .CostoFinancieroId = 0, .NumeroCuotas = 0, .PorcentajeRecargo = 0})
            CostoFinancieroBindingSource.DataSource = CosotosFinancieros
            txt_CostoFinanciero.Text = Format(0, "P")
        End If
    End Sub

    Private Sub Cb_NumeroCuota_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Cb_NumeroCuota.SelectedIndexChanged
        If (Cb_NumeroCuota.SelectedItem IsNot Nothing) Then
            txt_CostoFinanciero.Text = CType(Cb_NumeroCuota.SelectedItem, CostoFinanciero).PorcentajeRecargo.ToString("P")
        Else
            txt_CostoFinanciero.Text = 0.ToString("P")
        End If
        txt_SeniaCostoFinanciero.Text = Format((ObtenerCostoFinanciero() * Decimal.Parse(txt_Senia.Text)), "###0.00")
        CalcularTotales()
    End Sub

    Private Sub txt_Senia_Leave(sender As Object, e As EventArgs) Handles txt_Senia.Leave
        txt_SeniaCostoFinanciero.Text = Format((ObtenerCostoFinanciero() * Decimal.Parse(txt_Senia.Text)), "###0.00")
    End Sub

    Private Sub enableAllControls(con As Control, enable As Boolean)

        For Each c As Control In con.Controls
            enableAllControls(c, enable)
        Next

        If TypeOf con IsNot TableLayoutPanel And TypeOf con IsNot GroupBox And Not String.IsNullOrEmpty(con.Name) Then
            con.Enabled = enable
        End If

    End Sub

    Private Sub btn_ActualizarListaProductos_Click(sender As Object, e As EventArgs) Handles btn_ActualizarListaProductos.Click
        Me.Cursor = Cursors.WaitCursor
        CargraListaProductos(False)
        MessageBox.Show("El listado de productos se ha actualizado correctamente.", "Registro de Ventas", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Me.Cursor = Cursors.Arrow
    End Sub
End Class