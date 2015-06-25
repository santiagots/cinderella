Public Class frmProveedoresCuentaCorriente
    Dim NegCuenta As New Negocio.NegCuentaCorriente
    Dim NegMercaderia As New Negocio.NegMercaderia
    Dim NegProveedores As New Negocio.NegProveedores
    Dim id_Sucursal As Integer = My.Settings("Sucursal")
    Dim Nombre_Sucursal As String = My.Settings("NombreSucursal")
    Dim NegSucursal As New Negocio.NegSucursales
    Dim Funciones As New Funciones
    Dim id_Prov As Integer = 0
    Dim id_Merca As Integer = 0

#Region "Región Eventos"
    'Load del formulario.
    Private Sub frmProveedoresCuentaCorriente_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            'Cambio el cursor a "WAIT"
            Me.Cursor = Cursors.WaitCursor

            'seteo las imagenes
            Dim ListaImagenes = New ImageList
            ListaImagenes.ImageSize = New Size(32, 32)
            ListaImagenes.TransparentColor = Color.Blue
            ListaImagenes.ColorDepth = ColorDepth.Depth32Bit

            ListaImagenes.Images.Add(My.Resources.Recursos.Recibo_32)
            ListaImagenes.Images.Add(My.Resources.Recursos.IconoDetalle)
            ListaImagenes.Images.Add(My.Resources.Recursos.ProductosMasivos_32)

            TabCuenta.ImageList = ListaImagenes

            'icono de listado
            TabListado.ImageIndex = 0
            'icono de detalle
            TabDetalle.ImageIndex = 1
            'icono de mercaderia
            TabMercaderia.ImageIndex = 2

            'Cargar el listado.
            If VariablesGlobales.objUsuario.id_Perfil = 1 Then 'si es administrador
                DG_Cuentas.Visible = False
                DG_Cuentas2.Visible = True
                RecargarListadoAdministrador()
            Else
                DG_Cuentas.Visible = True
                DG_Cuentas2.Visible = False
                RecargarListadoEncargado()
            End If

            'Chequeo la patente.
            '300 Pagar cuentas corrientes.
            Dim objusuario As New Negocio.Usuario        
            If (objusuario.EsPatenteValida(300, VariablesGlobales.Patentes)) Then
                Btn_Pagar.Visible = True
            Else
                Btn_Pagar.Visible = False
            End If

            'Cambio el cursor a NORMAL.
            Me.Cursor = Cursors.Arrow
        Catch ex As Exception
            Me.Cursor = Cursors.Arrow
            MessageBox.Show("Se ha encontrado un error al cargar el listado.", "Cuenta Corriente con Proveedores", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    'Doble click en el grid para encargados.
    Private Sub DG_Cuentas_CellDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DG_Cuentas.CellDoubleClick
        Try
            id_Prov = DG_Cuentas.Rows(e.RowIndex).Cells("id_Proveedor").Value
            Dim Proveedor As String = DG_Cuentas.Rows(e.RowIndex).Cells("Proveedor").Value

            If id_Prov = 0 Then
                'muestro un msg de error.
                MessageBox.Show("No se puede acceder a la cuenta corriente de éste proveedor. Intente más tarde.", "Cuenta Corriente con Proveedores", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Else
                'Cursor.
                Me.Cursor = Cursors.WaitCursor

                lbl_Sucursal.Text = Nombre_Sucursal
                lbl_Proveedor.Text = Proveedor

                'Cargo el datagrid
                Dim dsItems As New DataSet
                dsItems = NegCuenta.ListadoCuentasCorrientesDetalle(id_Prov)
                If dsItems.Tables(0).Rows.Count > 0 Then
                    DG_Detalle.DataSource = dsItems.Tables(0)
                    DG_Detalle.AutoGenerateColumns = False
                    DG_Detalle.ColumnHeadersVisible = True
                    DG_Detalle.Columns("Fecha").DisplayIndex = 1
                    DG_Detalle.Columns("Concepto").DisplayIndex = 2
                    DG_Detalle.Columns("Importe").DisplayIndex = 3
                    DG_Detalle.Refresh()
                Else
                    DG_Detalle.ColumnHeadersVisible = False
                    DG_Detalle.DataSource = Nothing
                    DG_Detalle.Refresh()
                End If

                'Calculo el total.
                Dim Monto As Double = 0
                Monto = CalcularImporteTotal()
                lbl_Total2.Text = "$ " & Format(CType(Monto, Decimal), "###0.00") & ".-"

                'Cambio el color del label si el total es negativo.
                If Monto < 0 Then
                    lbl_Total2.ForeColor = Color.Red
                Else
                    lbl_Total2.ForeColor = Color.Black
                End If

                'Cursor.
                Me.Cursor = Cursors.Arrow

                'hago foco en el tab_modificacion 
                TabCuenta.SelectedIndex = 1
            End If
        Catch ex As Exception
            Me.Cursor = Cursors.Arrow
            MessageBox.Show("Se ha encontrado un error al cargar el detalle del proveedor.", "Cuenta Corriente con Proveedores", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    'Pongo los valores en rojo si son negativos.
    Private Sub DG_Cuentas_CellFormatting(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellFormattingEventArgs) Handles DG_Cuentas.CellFormatting
        If DG_Cuentas.Columns(e.ColumnIndex).Name.Equals("Saldo") Then
            If e.Value < 0 Then
                e.CellStyle.ForeColor = Color.Red
                e.CellStyle.SelectionForeColor = Color.Red
                e.CellStyle.Format = "C2"
            End If
        End If
    End Sub

    'Doble click en el grid para administradores.
    Private Sub DG_Cuentas2_CellDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DG_Cuentas2.CellDoubleClick
        Try
            Dim id_Sucu As String = ""
            Dim id_Provider As String = ""
            Dim Proveedor As String = ""
            Dim Sucursal As String = ""

            id_Provider = DG_Cuentas2.Rows(e.RowIndex).Cells("id_Proveedor").Value
            id_Sucu = DG_Cuentas2.Columns(e.ColumnIndex).ToolTipText
            Proveedor = DG_Cuentas2.Rows(e.RowIndex).Cells("Proveedor").Value
            Sucursal = DG_Cuentas2.Columns(e.ColumnIndex).HeaderText

            If IsNumeric(DG_Cuentas2(e.ColumnIndex, e.RowIndex).Value) Then
                If IsNumeric(id_Provider) And IsNumeric(id_Sucu) Then
                    If id_Provider = 0 Or id_Sucu = 0 Then
                    Else
                        'Cursor.
                        Me.Cursor = Cursors.WaitCursor

                        id_Prov = id_Provider
                        lbl_Sucursal.Text = Sucursal
                        lbl_Proveedor.Text = Proveedor

                        'Cargo el datagrid
                        Dim dsItems As New DataSet
                        dsItems = NegCuenta.ListadoCuentasCorrientesDetalleAdmin(id_Provider, id_Sucu)
                        If dsItems.Tables(0).Rows.Count > 0 Then
                            DG_Detalle.DataSource = dsItems.Tables(0)
                            DG_Detalle.AutoGenerateColumns = False
                            DG_Detalle.ColumnHeadersVisible = True
                            DG_Detalle.Columns("Fecha").DisplayIndex = 1
                            DG_Detalle.Columns("Concepto").DisplayIndex = 2
                            DG_Detalle.Columns("Importe").DisplayIndex = 3
                            DG_Detalle.Refresh()
                        Else
                            DG_Detalle.ColumnHeadersVisible = False
                            DG_Detalle.DataSource = Nothing
                            DG_Detalle.Refresh()
                        End If

                        'Calculo el total.
                        Dim Monto As Double = 0
                        Monto = CalcularImporteTotal()
                        lbl_Total2.Text = "$ " & Format(CType(Monto, Decimal), "###0.00") & ".-"

                        'Cambio el color del label si el total es negativo.
                        If Monto < 0 Then
                            lbl_Total2.ForeColor = Color.Red
                        Else
                            lbl_Total2.ForeColor = Color.Black
                        End If

                        'Cursor.
                        Me.Cursor = Cursors.Arrow

                        'hago foco en el tab_modificacion 
                        TabCuenta.SelectedIndex = 1
                    End If
                End If
            End If
        Catch ex As Exception
            Me.Cursor = Cursors.Arrow
            MessageBox.Show("Se ha encontrado un error al cargar el detalle del proveedor.", "Cuenta Corriente con Proveedores", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    'Pongo los valores en rojo si son negativos.
    Private Sub DG_Cuentas2_CellFormatting(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellFormattingEventArgs) Handles DG_Cuentas2.CellFormatting
        If IsNumeric(e.Value) Then
            If e.Value < 0 Then
                e.CellStyle.ForeColor = Color.Red
                e.CellStyle.SelectionForeColor = Color.Red
                e.CellStyle.Format = "C2"
            End If
        End If
    End Sub

    Private Sub DG_Detalle_CellDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DG_Detalle.CellDoubleClick
        Try
            id_Merca = DG_Detalle.Rows(e.RowIndex).Cells("id_Mercaderia").Value

            If id_Merca = 0 Then
                'muestro un msg de error.
                MessageBox.Show("El item seleccionado no posee detalle. Sólo los pedidos de mercadería pueden ser detallados.", "Cuenta Corriente con Proveedores", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Else
                'Cursor.
                Me.Cursor = Cursors.WaitCursor

                Dim dsMercaderiaDetalle As New DataSet
                Dim dsMercaderia As New DataSet
                Dim Monto As Double = 0

                dsMercaderia = NegMercaderia.TraerMercaderia(id_Merca)
                lbl_Proveedor2.Text = dsMercaderia.Tables(0).Rows(0).Item("Proveedor").ToString
                lbl_Fecha.Text = dsMercaderia.Tables(0).Rows(0).Item("Fecha").ToString
                Monto = dsMercaderia.Tables(0).Rows(0).Item("MontoTotal").ToString

                'Cargo el datagrid
                dsMercaderiaDetalle = NegMercaderia.ObtenerDetalleMercaderia(id_Merca)
                If dsMercaderiaDetalle.Tables(0).Rows.Count > 0 Then
                    DG_Mercaderia.DataSource = dsMercaderiaDetalle.Tables(0)
                    DG_Mercaderia.AutoGenerateColumns = False
                    DG_Mercaderia.ColumnHeadersVisible = True
                    DG_Mercaderia.Columns("Codigo").DisplayIndex = 0
                    DG_Mercaderia.Columns("Producto").DisplayIndex = 1
                    DG_Mercaderia.Columns("Costo").DisplayIndex = 2
                    DG_Mercaderia.Columns("Cantidad").DisplayIndex = 3
                    DG_Mercaderia.Columns("Total").DisplayIndex = 4
                    DG_Mercaderia.Refresh()
                Else
                    DG_Mercaderia.ColumnHeadersVisible = False
                    DG_Mercaderia.DataSource = Nothing
                    DG_Mercaderia.Refresh()
                End If

                'Cambio el color del label si el total es negativo.
                lbl_Total3.Text = "$ " & Format(CType(Monto, Decimal), "###0.00") & ".-"
                If Monto < 0 Then
                    lbl_Total3.ForeColor = Color.Red
                Else
                    lbl_Total3.ForeColor = Color.Black
                End If

                'Cursor.
                Me.Cursor = Cursors.Arrow

                'hago foco en el tab_modificacion 
                TabCuenta.SelectedIndex = 2
            End If
        Catch ex As Exception
            Me.Cursor = Cursors.Arrow
            MessageBox.Show("Se ha encontrado un error al cargar el detalle de la cuenta corriente.", "Cuenta Corriente con Proveedores", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    'Pongo los valores en rojo si son negativos.
    Private Sub DG_Detalle_CellFormatting(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellFormattingEventArgs) Handles DG_Detalle.CellFormatting
        If DG_Detalle.Columns(e.ColumnIndex).Name.Equals("Importe") Then
            If e.Value < 0 Then
                e.CellStyle.ForeColor = Color.Red
                e.CellStyle.SelectionForeColor = Color.Red
            End If
        End If
    End Sub

    'Solapas.
    Private Sub TabCuenta_Selected(ByVal sender As Object, ByVal e As System.Windows.Forms.TabControlEventArgs) Handles TabCuenta.Selected
        If TabCuenta.SelectedIndex = 0 Then 'TAB LISTADO.
            'Cambio el cursor a "WAIT"
            Me.Cursor = Cursors.WaitCursor

            'Cargo el listado.
            If VariablesGlobales.objUsuario.id_Perfil = 1 Then 'si es administrador
                '  RecargarListadoAdministrador()
            Else
                RecargarListadoEncargado()
            End If

            id_Prov = 0
            id_Merca = 0

            lbl_Total2.Text = "No disponible."
            lbl_Proveedor.Text = "No disponible."
            lbl_Sucursal.Text = "No disponible."
            DG_Detalle.ColumnHeadersVisible = False
            DG_Detalle.DataSource = Nothing
            DG_Detalle.Refresh()

            'Cambio el cursor a NORMAL.
            Me.Cursor = Cursors.Arrow
        ElseIf TabCuenta.SelectedIndex = 1 Then 'TAB DETALLE.
            id_Merca = 0
            If id_Prov > 0 Or id_Prov <> Nothing Then
            Else
                MessageBox.Show("Debe seleccionar previamente un proveedor.", "Cuenta Corriente con Proveedores", MessageBoxButtons.OK, MessageBoxIcon.Stop)
                TabCuenta.SelectedIndex = 0
            End If
        ElseIf TabCuenta.SelectedIndex = 2 Then 'TAB DETALLE.
            If id_Merca > 0 Or id_Merca <> Nothing Then
            Else
                MessageBox.Show("Debe seleccionar previamente un detalle.", "Cuenta Corriente con Proveedores", MessageBoxButtons.OK, MessageBoxIcon.Stop)
                TabCuenta.SelectedIndex = 1
            End If
        End If

    End Sub

    'Abre la solapa de pago.
    Private Sub Btn_Pagar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_Pagar.Click
        Me.WindowState = FormWindowState.Minimized
        Funciones.ControlInstancia(frmPagarCuentaCorriente).MdiParent = MDIContenedor
        Funciones.ControlInstancia(frmPagarCuentaCorriente).Show()
    End Sub

    Private Sub Btn_Limpiar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_Limpiar.Click
        Try
            'Cambio el cursor a "WAIT"
            Me.Cursor = Cursors.WaitCursor

            'Cargar el listado.
            If VariablesGlobales.objUsuario.id_Perfil = 1 Then 'si es administrador
                DG_Cuentas.Visible = False
                DG_Cuentas2.Visible = True
                RecargarListadoAdministrador()
            Else
                DG_Cuentas.Visible = True
                DG_Cuentas2.Visible = False
                RecargarListadoEncargado()
            End If

            'Cambio el cursor a NORMAL.
            Me.Cursor = Cursors.Arrow
        Catch ex As Exception
            Me.Cursor = Cursors.Arrow
            MessageBox.Show("Se ha encontrado un error al cargar el listado.", "Cuenta Corriente con Proveedores", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

#End Region

#Region "Región Funciones"
    'Calcula por columna de sucursal, los totales.
    Function CalcularSaldoColumna(ByVal col As String)
        Dim tot As Double = 0
        For Each row As DataGridViewRow In Me.DG_Cuentas2.Rows
            tot += Val(row.Cells(col).Value)
        Next

        If tot = 0 Then
            Return "-"
        Else
            Return tot
        End If
    End Function

    'Funcion que calcula el total de saldos.
    Function CalcularSaldoTotal()
        Dim subtotal As Double
        For i = 0 To (DG_Cuentas.Rows.Count - 1)
            subtotal += DG_Cuentas.Rows(i).Cells.Item("Saldo").Value
        Next
        Return subtotal
    End Function

    Function CalcularImporteTotal()
        Dim subtotal As Double
        For i = 0 To (DG_Detalle.Rows.Count - 1)
            subtotal += DG_Detalle.Rows(i).Cells.Item("Importe").Value
        Next
        Return subtotal
    End Function

    Public Sub RecargarListadoEncargado()
        'Cambio el cursor a "WAIT"
        Me.Cursor = Cursors.WaitCursor

        ' Cargo el datagrid
        Dim dsProveedores As New DataSet
        dsProveedores = NegCuenta.ListadoCuentasCorrientesSucursal(id_Sucursal)

        If dsProveedores.Tables(0).Rows.Count > 0 Then
            DG_Cuentas.DataSource = dsProveedores.Tables(0)
            DG_Cuentas.AutoGenerateColumns = False
            DG_Cuentas.ColumnHeadersVisible = True
            DG_Cuentas.Refresh()
            lbl_Msg.Visible = False
        Else
            DG_Cuentas.ColumnHeadersVisible = False
            DG_Cuentas.DataSource = Nothing
            DG_Cuentas.Refresh()
            lbl_Msg.Visible = True
        End If

        'Calculo el total.
        Dim Monto As Double = 0
        Monto = CalcularSaldoTotal()
        lbl_Total.Text = "$ " & Format(CType(Monto, Decimal), "###0.00") & ".-"

        'Cambio el color del label si el total es negativo.
        If Monto < 0 Then
            lbl_Total.ForeColor = Color.Red
        Else
            lbl_Total.ForeColor = Color.Black
        End If

        'Cambio el cursor a NORMAL.
        Me.Cursor = Cursors.Arrow
    End Sub

    Public Sub RecargarListadoAdministrador()
        'Cambio el cursor a "WAIT"
        Me.Cursor = Cursors.WaitCursor

        DG_Cuentas2.DataSource = Nothing
        DG_Cuentas2.ClearSelection()
        DG_Cuentas2.Rows.Clear()
        DG_Cuentas2.Columns.Clear()

        Dim column1 As DataGridViewColumn = New DataGridViewColumn
        column1.ValueType = System.Type.GetType("System.String")
        column1.Name = "id_Proveedor"
        column1.CellTemplate = New DataGridViewTextBoxCell
        column1.HeaderText = "id_Proveedor"
        DG_Cuentas2.Columns.Add(column1)

        Dim column2 As DataGridViewColumn = New DataGridViewColumn
        column2.ValueType = System.Type.GetType("System.String")
        column2.Name = "Proveedor"
        column2.CellTemplate = New DataGridViewTextBoxCell
        column2.HeaderText = "Proveedor"
        DG_Cuentas2.Columns.Add(column2)

        Dim dsSucursal As New DataSet
        dsSucursal = NegSucursal.ListadoSucursales()
        If dsSucursal.Tables(0).Rows.Count > 0 Then
            For Each sucu In dsSucursal.Tables(0).Rows
                Dim column As DataGridViewColumn = New DataGridViewColumn
                column.CellTemplate = New DataGridViewTextBoxCell
                column.ValueType = System.Type.GetType("System.String")
                column.ToolTipText = sucu.item("Nombre").ToString
                column.Tag = sucu.item("id_Sucursal").ToString
                column.Name = sucu.item("Nombre").ToString
                column.HeaderText = sucu.item("Nombre").ToString
                column.DefaultCellStyle.Format = "C2"
                column.ToolTipText = sucu.item("id_Sucursal").ToString
                DG_Cuentas2.Columns.Add(column)
            Next
        End If

        Dim column3 As DataGridViewColumn = New DataGridViewColumn
        column3.ValueType = System.Type.GetType("System.String")
        column3.CellTemplate = New DataGridViewTextBoxCell
        column3.Name = "Total"
        column3.HeaderText = "Total"
        column3.DefaultCellStyle.Format = "C2"
        DG_Cuentas2.Columns.Add(column3)

        'Items seleccionados en Lista A,
        Dim dsProveedores As New DataSet
        dsProveedores = NegProveedores.ListadoProveedores()

        'Muestro el form de espera..
        frmCargadorDeEspera.Show()
        frmCargadorDeEspera.Text = "Generando la planilla de Cuentas Corrientes"
        frmCargadorDeEspera.lbl_Descripcion.Text = "Iniciando..."
        frmCargadorDeEspera.BarraProgreso.Minimum = 0
        frmCargadorDeEspera.BarraProgreso.Maximum = 2 + dsProveedores.Tables(0).Rows.Count
        frmCargadorDeEspera.BarraProgreso.Value = 1
        frmCargadorDeEspera.Refresh()

        If dsProveedores.Tables(0).Rows.Count > 0 Then
            Dim Totales As Double = 0
            For Each Prov In dsProveedores.Tables(0).Rows
                Dim Subtotal As Double = 0

                'Voy seteando la barra de progreso
                frmCargadorDeEspera.lbl_Descripcion.Text = "Cargando Cuenta Corriente del proveedor " & Prov.item("RazonSocial") & " ..."
                frmCargadorDeEspera.BarraProgreso.Value += 1
                frmCargadorDeEspera.Refresh()

                'Creo la fila del producto.
                Dim dgvRow As New DataGridViewRow

                'Valor de la Columna Numero
                Dim dgvCell As DataGridViewCell
                dgvCell = New DataGridViewTextBoxCell()
                dgvCell.Value = Prov.item("id_Proveedor").ToString
                dgvRow.Cells.Add(dgvCell)

                Dim dgvCell2 As DataGridViewCell
                dgvCell2 = New DataGridViewTextBoxCell()
                dgvCell2.Value = Prov.item("RazonSocial").ToString
                dgvRow.Cells.Add(dgvCell2)

                If dsSucursal.Tables(0).Rows.Count > 0 Then
                    For Each sucu In dsSucursal.Tables(0).Rows
                        Dim dgvCell3 As DataGridViewCell
                        Dim Importe As Double
                        Importe = NegCuenta.ObtenerMontoSucursal(Prov.item("id_Proveedor").ToString, sucu.item("id_Sucursal").ToString)
                        dgvCell3 = New DataGridViewTextBoxCell()
                        If Importe = 0 Then
                            dgvCell3.Value = "-"
                        Else
                            dgvCell3.Value = Importe
                        End If
                        dgvRow.Cells.Add(dgvCell3)
                        Subtotal += Importe
                    Next
                End If

                Dim dgvCell4 As DataGridViewCell
                dgvCell4 = New DataGridViewTextBoxCell()
                If Subtotal = 0 Then
                    dgvCell4.Value = "-"
                Else
                    dgvCell4.Value = Subtotal
                End If
                dgvRow.Cells.Add(dgvCell4)
                dgvRow.Height = "30"

                'Inserto la fila
                DG_Cuentas2.Rows.Add(dgvRow)
                Totales += Subtotal
            Next

            'Voy seteando la barra de progreso
            frmCargadorDeEspera.lbl_Descripcion.Text = "Finalizando... "
            frmCargadorDeEspera.BarraProgreso.Value += 1
            frmCargadorDeEspera.Refresh()

            'Creo la fila de los totales por sucursal.
            Dim dgvRowTot As New DataGridViewRow

            For Each col In DG_Cuentas2.Columns
                'Valor de la Columna Numero
                Dim dgvCell As DataGridViewCell
                dgvCell = New DataGridViewTextBoxCell()
                If col.Name = "id_Proveedor" Or col.Name = "Proveedor" Then
                    dgvCell.Value = ""
                Else
                    dgvCell.Value = CalcularSaldoColumna(col.Name)
                End If
                dgvRowTot.Cells.Add(dgvCell)
            Next
            DG_Cuentas2.Rows.Add(dgvRowTot)
            'Creo la fila de los totales por sucursal.

            lbl_Total.Text = "$ " & Format(CType(Totales, Decimal), "###0.00") & ".-"
            DG_Cuentas2.Columns("id_Proveedor").Visible = False
            DG_Cuentas2.Columns("Total").Width = "40"
            DG_Cuentas2.Columns("Proveedor").Width = "70"
            lbl_Msg.Visible = False

            'Cambio el color del label si el total es negativo.
            If Totales < 0 Then
                lbl_Total.ForeColor = Color.Red
            Else
                lbl_Total.ForeColor = Color.Black
            End If
        End If

        frmCargadorDeEspera.Close()
        frmCargadorDeEspera.Dispose()
        Me.WindowState = FormWindowState.Maximized

        'Cambio el cursor a NORMAL.
        Me.Cursor = Cursors.Arrow
    End Sub

#End Region

    'Private Sub DG_Cuentas2_ColumnHeaderMouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles DG_Cuentas2.ColumnHeaderMouseClick
    '    For Each c In DG_Cuentas2.Columns
    '        c.SortMode = DataGridViewColumnSortMode.NotSortable
    '        c.Selected = False
    '    Next

    '    DG_Cuentas2.SelectionMode = DataGridViewSelectionMode.FullColumnSelect
    '    DG_Cuentas2.Columns(e.ColumnIndex).Selected = True
    'End Sub

    
End Class