Public Class frmMovimientoEgreso
    Dim NegErrores As New Negocio.NegManejadorErrores
    Dim NegMovimiento As New Negocio.NegMovimientos
    Dim NegSucursal As New Negocio.NegSucursales
    Dim NStock As New Negocio.NegStock
    Dim Funciones As New Funciones
    Dim eEgreso As New Entidades.MovEgreso
    Dim eEgresoMerca As New Entidades.MovEgresoMercaderia
    Dim id_Sucursal As String
    Dim Nombre_Sucursal As String
    Dim MsgEstado As String
    Dim dsMovimiento As New DataSet
    Public dsProductos As New DataTable
    Public id_Movimiento As Integer = 0
    Public Envio As Boolean = True

    'Al cerrar el formulario me fijo si está abierto el form de listados, si lo está, hago foco.
    Private Sub frmMovimientoEgreso_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        If frmMovimientoPlanilla.Visible And id_Movimiento <> 0 Then
            frmMovimientoPlanilla.WindowState = FormWindowState.Normal
        End If
    End Sub

    Private Sub frmMovimientoEgreso_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        If frmMovimientoPlanilla.Visible And id_Movimiento <> 0 Then
            frmMovimientoPlanilla.RefrescarPlanilla()
        End If
    End Sub

    'Cuando carga el formulario.
    Private Sub frmMovimientoEgreso_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Cambio el cursor a "WAIT"
        Me.Cursor = Cursors.WaitCursor

        If (Not Envio) Then
            Me.Text = "Movimientos | Recepción de Otras Sucursales"
            GroupBox1.Text = "Alta de movimientos de ""Recepción"" en la sucursal."
        End If

        Try
            'Sucursal default.
            id_Sucursal = My.Settings("Sucursal")
            Nombre_Sucursal = My.Settings("NombreSucursal")
            lbl_SucursalNombre.Text = Nombre_Sucursal
            CbSubtipo.SelectedItem = "Seleccione un tipo."

            'Cargo las sucursales.
            Dim dsSucursales As New DataSet
            dsSucursales = NegSucursal.ListadoSucursales()
            If (dsSucursales.Tables(0).Rows.Count > 0) Then
                CbSucursal.DataSource = Funciones.CrearDataTable("id_Sucursal", "Nombre", dsSucursales, "Seleccione una sucursal...")
                CbSucursal.DisplayMember = "Nombre"
                CbSucursal.ValueMember = "id_Sucursal"
                CbSucursal.SelectedIndex = 0
                CbSucursal.Refresh()
            End If

            'Cargo los tipos.
            Dim dsTiposMov As New DataSet
            dsTiposMov = NegMovimiento.ListadoTiposMov(2)
            If (dsTiposMov.Tables(0).Rows.Count > 0) Then
                CbSubtipo.DataSource = Nothing
                CbTipo.DataSource = Nothing
                CbTipo.DataSource = dsTiposMov.Tables(0)
                CbTipo.DisplayMember = "Tipo"
                CbTipo.ValueMember = "id_Tipo"
                CbTipo.Refresh()
            End If

            'Chequeo si hay ID modifico los textos.
            If id_Movimiento <> 0 Then
                btnCancelar.Visible = False
                'Cargo el movimiento en los controles
                dsMovimiento = NegMovimiento.ObtenerMov(id_Movimiento, id_Sucursal, "Egreso")
                If dsMovimiento.Tables(0).Rows.Count = 0 Then
                    dsMovimiento = NegMovimiento.ObtenerMovEgresoPorId(id_Movimiento, id_Sucursal)
                    lbl_SucursalNombre.Text = dsMovimiento.Tables(0).Rows(0).Item("Nombre").ToString
                End If
                txtDescripcion.Text = Replace(dsMovimiento.Tables(0).Rows(0).Item("Descripcion").ToString, "<br />", vbCrLf)
                txtMonto.Text = Format(CType(dsMovimiento.Tables(0).Rows(0).Item("Monto").ToString, Decimal), "###0.00")
                txtDate.Text = dsMovimiento.Tables(0).Rows(0).Item("Fecha").ToString
                CbTipo.SelectedValue = dsMovimiento.Tables(0).Rows(0).Item("id_Tipo").ToString
                CbSucursal.SelectedValue = dsMovimiento.Tables(0).Rows(0).Item("id_SucursalDestino").ToString

                If CbTipo.SelectedValue = "16" Then 'Si es efectivo.
                    CbSubtipo.DataSource = Nothing
                    CbSubtipo.Items.Add("No Requerido.")
                    CbSubtipo.SelectedItem = "No Requerido."
                    CbSubtipo.Enabled = False
                    lbl_Subtipo.Text = "Subtipo"
                    lbl_Monto.Text = "Monto (*)"
                    txtMonto.Enabled = True
                    Btn_CargarMercaderia.Visible = False

                ElseIf CbTipo.SelectedValue = "19" Then 'Si es mercadería.
                    CbSubtipo.DataSource = Nothing
                    CbSubtipo.Items.Add("No Requerido.")
                    CbSubtipo.SelectedItem = "No Requerido."
                    CbSubtipo.Enabled = False
                    lbl_Subtipo.Text = "Subtipo"
                    lbl_Monto.Text = "Monto"
                    txtMonto.Enabled = False
                    Btn_CargarMercaderia.Visible = True

                    'Consulto los productos.
                    dsProductos = NegMovimiento.ObtenerMovEgresoMercaderias(id_Movimiento, id_Sucursal).Tables(0)
                    If dsProductos IsNot Nothing And dsProductos.Rows.Count > 0 Then
                        frmCargarMercaderiaEgreso.dtProductos = dsProductos
                        lblMercaderias.Text = ""
                        lblMercaderias.Text = "(Total de Mercadería: " & dsProductos.Rows.Count & " producto/s.)"
                        lblMercaderias.Visible = True
                    End If

                Else 'Resto.
                    lbl_Subtipo.Text = "Subtipo (*)"
                    lbl_Monto.Text = "Monto (*)"
                    txtMonto.Enabled = True
                    Btn_CargarMercaderia.Visible = False
                    Dim dsSubtiposMov As New DataSet
                    dsSubtiposMov = NegMovimiento.ListadoSubtiposMov(CbTipo.SelectedValue)
                    If (dsSubtiposMov.Tables(0).Rows.Count > 0) Then
                        CbSubtipo.DataSource = Nothing
                        CbSubtipo.Items.Clear()
                        CbSubtipo.Enabled = True
                        CbSubtipo.DataSource = dsSubtiposMov.Tables(0)
                        CbSubtipo.DisplayMember = "Subtipo"
                        CbSubtipo.ValueMember = "id_Subtipo"
                        CbSubtipo.SelectedValue = dsMovimiento.Tables(0).Rows(0).Item("id_Subtipo").ToString
                        CbSubtipo.Refresh()
                    End If
                End If

                If dsMovimiento.Tables(0).Rows(0).Item("Aceptado") = 1 Or dsMovimiento.Tables(0).Rows(0).Item("Id_SucursalDestino") = My.Settings("Sucursal") Then
                    btnAceptar.Enabled = False
                    btnAceptar.Text = "No Dispo."
                    txtMonto.ReadOnly = True
                    CbSucursal.Enabled = False
                    CbTipo.Enabled = False
                    CbSubtipo.Enabled = False
                    txtDate.Enabled = False
                    txtDescripcion.ReadOnly = True
                    Btn_CargarMercaderia.Visible = False
                Else
                    btnAceptar.Enabled = True
                    btnAceptar.Text = "Modificar"
                    ToolEgresos.SetToolTip(btnAceptar, "Al hacer click en el botón 'Modificar' del formulario se modificará en el sistema el retiro de dinero del socio cargado.")
                End If
            Else
                btnAceptar.Text = "Aceptar"
                ToolEgresos.SetToolTip(btnAceptar, "Al hacer click en el botón 'Aceptar' del formulario se registrará en el sistema el retiro de dinero del socio.")
            End If

            'Cambio el cursor a "NORMAL"
            Me.Cursor = Cursors.Arrow
        Catch ex As Exception
            Me.Cursor = Cursors.Arrow
            MessageBox.Show("Se ha producido un error al cargar el formulario. Por favor, contáctese con el administrador", "Movimientos | Envió a Otras Sucursales", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        
    End Sub

    'Valida solo moneda.
    Private Sub txtMonto_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtMonto.KeyPress
        If e.KeyChar.ToString() = "." Then
            e.KeyChar = CChar(",")
        End If
        Dim KeyAscii As Short = CShort(Asc(e.KeyChar))
        KeyAscii = CShort(NegErrores.SoloCurrency(KeyAscii))
        If KeyAscii = 0 Then
            e.Handled = True
            ErrorEgresos.SetError(txtMonto, "Debe ingresar el monto en el formato permitido. Ejemplo: 725,50")
        Else
            ErrorEgresos.SetError(txtMonto, Nothing)
        End If
    End Sub

    'Funcion para Limpiar Formulario.
    Sub LimpiarFormulario()
        txtDescripcion.Clear()
        txtDescripcion.ReadOnly = False
        txtMonto.Clear()
        txtDate.Value = Date.Now
        CbTipo.Enabled = True
        CbTipo.SelectedIndex = 0
        CbSucursal.SelectedIndex = 0
        CbSubtipo.Enabled = False
        CbSubtipo.DataSource = Nothing
        CbSubtipo.Items.Clear()
        CbSubtipo.Items.Add("Seleccione un tipo.")
        CbSubtipo.SelectedItem = "Seleccione un tipo."
        Btn_CargarMercaderia.Visible = False
        ErrorEgresos.Clear()
        lblMercaderias.Text = ""
        lblMercaderias.Visible = False
        btnAceptar.Enabled = True
        btnAceptar.Text = "Aceptar"
        txtMonto.ReadOnly = False
        CbSucursal.Enabled = True
        txtDate.Enabled = True
        txtDescripcion.ReadOnly = False
    End Sub

    'Cuando hace click en Cancelar
    Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click
        LimpiarFormulario()
    End Sub

    'Cuando hace click en Aceptar.
    Private Sub btnAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAceptar.Click
        If CbSucursal.SelectedValue = id_Sucursal Then
            MessageBox.Show("La sucursal de destino debe ser distinta a la sucursal de origen", "Movimientos | Envió a Otras Sucursales", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        Else
            If txtDate.Text = "" Or CInt(CbTipo.SelectedValue) = 0 Or CInt(CbSucursal.SelectedValue) = 0 Then
                MessageBox.Show("Debe completar los campos requeridos.", "Movimientos | Envió a Otras Sucursales", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Else
                If CbTipo.SelectedValue <> "19" And txtMonto.Text = "" Then 'Si no es Cat Mercaderias y no cargo el monto, lo informo.
                    txtMonto.Focus()
                    MessageBox.Show("Debe completar el campo Monto.", "Movimientos | Envió a Otras Sucursales", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                ElseIf CbTipo.SelectedValue <> "19" And CbTipo.SelectedValue <> "16" And CbSubtipo.SelectedItem Is Nothing Then 'Si no es Cat Mercaderias o Efectivo y no cargo el subtipo, lo informo.
                    MessageBox.Show("Debe seleccionar un subtipo.", "Movimientos | Envió a Otras Sucursales", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                ElseIf CbTipo.SelectedValue = "19" And dsProductos.Rows.Count = 0 Then 'Si es Cat Mercaderias y no cargo ningun producto, lo informo.
                    MessageBox.Show("Debe agregar al menos un producto.", "Movimientos | Envió a Otras Sucursales", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Else
                    Try
                        'Cambio el cursor a "WAIT"
                        Me.Cursor = Cursors.WaitCursor

                        'Si es un mov ya cargado levanto el id para hacer un update del mismo.
                        If dsMovimiento.Tables.Count > 0 Then
                            eEgreso.id_Movimiento = dsMovimiento.Tables(0).Rows(0).Item("id_Movimiento").ToString
                        Else
                            eEgreso.id_Movimiento = 0
                        End If
                        eEgreso.id_MovimientoPadre = 0
                        eEgreso.id_Sucursal = id_Sucursal
                        eEgreso.id_SucursalDestino = CbSucursal.SelectedValue
                        eEgreso.id_Tipo = CbTipo.SelectedValue
                        eEgreso.id_Subtipo = CbSubtipo.SelectedValue
                        If txtDescripcion.Text <> "" Then
                            eEgreso.Descripcion = Replace(Trim(txtDescripcion.Text), vbCrLf, "<br />")
                        Else
                            eEgreso.Descripcion = ""
                        End If
                        eEgreso.Fecha = Trim(txtDate.Text)
                        eEgreso.Monto = Trim(txtMonto.Text)
                        eEgreso.Aceptado = 0
                        MsgEstado = NegMovimiento.AltaMovEgreso(eEgreso)

                        'Inserto el movimiento inverso.
                        Dim eEgresoInverso As New Entidades.MovEgreso
                        eEgresoInverso.id_Movimiento = 0
                        If dsMovimiento.Tables.Count > 0 Then
                            eEgresoInverso.id_MovimientoPadre = dsMovimiento.Tables(0).Rows(0).Item("id_Movimiento").ToString
                        Else
                            eEgresoInverso.id_MovimientoPadre = NegMovimiento.ObtenerID("Egresos")
                        End If
                        eEgresoInverso.id_Sucursal = CbSucursal.SelectedValue
                        eEgresoInverso.id_SucursalDestino = id_Sucursal
                        eEgresoInverso.id_Tipo = CbTipo.SelectedValue
                        eEgresoInverso.id_Subtipo = CbSubtipo.SelectedValue
                        If txtDescripcion.Text <> "" Then
                            eEgresoInverso.Descripcion = Replace(Trim(txtDescripcion.Text), vbCrLf, "<br />")
                        Else
                            eEgresoInverso.Descripcion = ""
                        End If
                        eEgresoInverso.Fecha = Trim(txtDate.Text)
                        eEgresoInverso.Monto = (Trim(txtMonto.Text) * -1)
                        eEgresoInverso.Aceptado = 0
                        MsgEstado = NegMovimiento.AltaMovEgreso(eEgresoInverso)

                        'Si eligió la categoria mercaderías, guardo el detalle.
                        If CbTipo.SelectedValue = "19" Then
                            If dsProductos IsNot Nothing Then

                                'Si se está editando, elimino todo el detalle
                                If id_Movimiento <> 0 Then
                                    NegMovimiento.EliminarMovEgresoMercaderia(id_Movimiento, id_Sucursal)
                                Else
                                    'Obtengo el ID del ultimo movimiento.
                                    id_Movimiento = (NegMovimiento.ObtenerID("Egresos") - 1)
                                End If

                                For Each prod In dsProductos.Rows
                                    eEgresoMerca.id_Movimiento = id_Movimiento
                                    eEgresoMerca.id_Producto = prod.item("id_Producto").ToString
                                    eEgresoMerca.id_Sucursal = id_Sucursal
                                    eEgresoMerca.Nombre = prod.item("Nombre").ToString
                                    eEgresoMerca.Codigo = prod.item("Codigo").ToString
                                    eEgresoMerca.Costo = prod.item("Costo").ToString
                                    eEgresoMerca.Cantidad = prod.item("Cantidad").ToString
                                    eEgresoMerca.Subtotal = prod.item("Subtotal").ToString
                                    NegMovimiento.AltaMovEgresoMercaderia(eEgresoMerca)
                                    NStock.DisminuirStock(prod.item("id_Producto"), prod.item("Cantidad"), id_Sucursal)
                                Next
                            End If
                        End If

                        'Limpiar Formulario.
                        LimpiarFormulario()

                        'Cambio el cursor a "NORMAL"
                        Me.Cursor = Cursors.Arrow

                        'Ejecuto el sp.
                        If (MessageBox.Show(MsgEstado, "Movimientos | Envió a Otras Sucursales", MessageBoxButtons.OK, MessageBoxIcon.Information) = vbOK) Then
                            'Cierro el form
                            Me.Close()
                            Me.Dispose()
                        End If

                    Catch ex As Exception
                        Me.Cursor = Cursors.Arrow
                        MessageBox.Show("Se ha producido un error al registrar el movimiento. Por favor, intente más tarde.", "Movimientos | Envió a Otras Sucursales", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End Try
                End If

            End If
        End If
        
    End Sub

    'Cuando selecciona un tipo, automaticamente cargo los subtipos en el combo subsiguiente.
    Private Sub CbTipo_SelectionChangeCommitted(ByVal sender As Object, ByVal e As System.EventArgs) Handles CbTipo.SelectionChangeCommitted
        'Cambio el cursor a "WAIT"
        Me.Cursor = Cursors.WaitCursor

        If CbTipo.SelectedValue = "16" Then 'Si es efectivo.
            CbSubtipo.DataSource = Nothing
            CbSubtipo.Items.Add("No Requerido.")
            CbSubtipo.SelectedItem = "No Requerido."
            CbSubtipo.Enabled = False
            lbl_Subtipo.Text = "Subtipo"
            lbl_Monto.Text = "Monto (*)"
            txtMonto.Enabled = True
            Btn_CargarMercaderia.Visible = False

        ElseIf CbTipo.SelectedValue = "19" Then 'Si es mercadería.
            CbSubtipo.DataSource = Nothing
            CbSubtipo.Items.Add("No Requerido.")
            CbSubtipo.SelectedItem = "No Requerido."
            CbSubtipo.Enabled = False
            lbl_Subtipo.Text = "Subtipo"
            lbl_Monto.Text = "Monto"
            txtMonto.Enabled = False
            Btn_CargarMercaderia.Visible = True

        Else 'Resto.
            lbl_Subtipo.Text = "Subtipo (*)"
            lbl_Monto.Text = "Monto (*)"
            txtMonto.Enabled = True
            Btn_CargarMercaderia.Visible = False
            Dim dsSubtiposMov As New DataSet
            dsSubtiposMov = NegMovimiento.ListadoSubtiposMov(CbTipo.SelectedValue)
            If (dsSubtiposMov.Tables(0).Rows.Count > 0) Then
                CbSubtipo.DataSource = Nothing
                CbSubtipo.Items.Clear()
                CbSubtipo.Enabled = True
                CbSubtipo.DataSource = dsSubtiposMov.Tables(0)
                CbSubtipo.DisplayMember = "Subtipo"
                CbSubtipo.ValueMember = "id_Subtipo"
                CbSubtipo.Refresh()
            End If
        End If

        'Cambio el cursor a "NORMAL"
        Me.Cursor = Cursors.Arrow
    End Sub

    'Cuando hace click en "cargar mercaderias.."
    Private Sub Btn_CargarMercaderia_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_CargarMercaderia.Click
        If CbSucursal.SelectedValue <> 0 Then
            Me.Cursor = Cursors.WaitCursor
            frmCargarMercaderiaEgreso.Nombre_Sucursal_Destino = DirectCast(CbSucursal.SelectedItem, System.Data.DataRowView).Row.ItemArray(1)
            frmCargarMercaderiaEgreso.dtProductos = dsProductos
            Funciones.ControlInstancia(frmCargarMercaderiaEgreso).MdiParent = MDIContenedor
            Funciones.ControlInstancia(frmCargarMercaderiaEgreso).Show()
            Me.Cursor = Cursors.Arrow
        Else
            CbSucursal.Focus()
            MessageBox.Show("Debe seleccionar una sucursal destino.", "Movimientos | Envió a Otras Sucursales", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If
    End Sub

    Private Sub Btn_Salir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_Salir.Click
        Me.Close()
    End Sub
End Class