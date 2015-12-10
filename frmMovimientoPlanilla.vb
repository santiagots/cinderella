Public Class frmMovimientoPlanilla
    'Instancias
    Dim id_Sucursal As Integer
    Dim Nombre_Sucursal As String
    Dim Funciones As New Funciones
    Dim NegMovimiento As New Negocio.NegMovimientos
    Dim NegDevolucion As New Negocio.NegDevolucion

#Region "Region de Eventos"
    'Load del formulario.
    Private Sub frmMovimientoPlanilla_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            'Cambio el cursor a "WAIT"
            Me.Cursor = Cursors.WaitCursor

            'Sucursal default
            id_Sucursal = My.Settings("Sucursal")
            Nombre_Sucursal = My.Settings("NombreSucursal")

            'Oculto Columnas en el DG_Productos
            DG_Movimientos.Columns("id_Movimiento").Visible = False

            'Selecciono todos los movimientos por default.
            CbTipo.SelectedIndex = 0

            'Cargo el combo con los años y selecciono el actual como default.
            Funciones.CargarComboAnios(CbAnios)

            'Cargo el combo con los meses y selecciono el actual como default.
            Funciones.CargarComboMeses(CbMeses)

            'Cargo la planilla.
            CargarPlanilla(CbTipo.SelectedItem, CbAnios.SelectedItem, CbMeses.SelectedItem)

            'Cambio el cursor a NORMAL.
            Me.Cursor = Cursors.Arrow
        Catch ex As Exception
            Me.Cursor = Cursors.Arrow
            MessageBox.Show(ex.Message, "Movimientos | Listado", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    'Cuando realiza un click dentro del datagrid de movimientos.
    Private Sub DG_Movimientos_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DG_Movimientos.CellContentClick
        If DG_Movimientos.Columns(e.ColumnIndex).Name = "VerDetalle" Then 'Si se hace click en el boton "Ver Detalle" del movimiento

            'Cambio el cursor a "WAIT"
            Me.Cursor = Cursors.WaitCursor

            'Seteo las variables
            Dim Tipo As String = DG_Movimientos.Rows(e.RowIndex).Cells("Tipo").Value()
            Dim Descripcion As String = DG_Movimientos.Rows(e.RowIndex).Cells("Descripcion").Value()
            Dim id_Mov As Integer = DG_Movimientos.Rows(e.RowIndex).Cells("id_Movimiento").Value()

            'Dependiendo del tipo abro un form u otro.
            If Tipo = "Dif. de Caja" Then
                Me.WindowState = FormWindowState.Minimized
                frmMovimientoCaja.id_Movimiento = id_Mov
                Funciones.ControlInstancia(frmMovimientoCaja).MdiParent = MDIContenedor
                Funciones.ControlInstancia(frmMovimientoCaja).Show()
            ElseIf Tipo = "Egreso" Then
                Me.WindowState = FormWindowState.Minimized
                frmMovimientoEgreso.id_Movimiento = id_Mov
                Funciones.ControlInstancia(frmMovimientoEgreso).MdiParent = MDIContenedor
                Funciones.ControlInstancia(frmMovimientoEgreso).Show()
            ElseIf Tipo = "Gasto" Then
                Me.WindowState = FormWindowState.Minimized
                frmMovimientoGasto.id_Movimiento = id_Mov
                Funciones.ControlInstancia(frmMovimientoGasto).MdiParent = MDIContenedor
                Funciones.ControlInstancia(frmMovimientoGasto).Show()
            ElseIf Tipo = "Impuesto" Then
                Me.WindowState = FormWindowState.Minimized
                frmMovimientoImpuesto.id_Movimiento = id_Mov
                Funciones.ControlInstancia(frmMovimientoImpuesto).MdiParent = MDIContenedor
                Funciones.ControlInstancia(frmMovimientoImpuesto).Show()
            ElseIf Tipo = "Movimiento de Socio" Then
                Me.WindowState = FormWindowState.Minimized
                If (Descripcion = "Retiro de socio") Then
                    frmMovimientoSocios.Accion = 0
                Else
                    frmMovimientoSocios.Accion = 1
                End If
                frmMovimientoSocios.id_Movimiento = id_Mov
                Funciones.ControlInstancia(frmMovimientoSocios).MdiParent = MDIContenedor
                Funciones.ControlInstancia(frmMovimientoSocios).Show()

            ElseIf Tipo = "Caja Fuerte" Then
                Me.WindowState = FormWindowState.Minimized
                frmMovimientoCajaFuerte.id_Movimiento = id_Mov
                Funciones.ControlInstancia(frmMovimientoCajaFuerte).MdiParent = MDIContenedor
                Funciones.ControlInstancia(frmMovimientoCajaFuerte).Show()
            End If

            'Cambio el cursor a NORMAL.
            Me.Cursor = Cursors.Arrow
        ElseIf DG_Movimientos.Columns(e.ColumnIndex).Name = "Eliminar" Then 'Si se hace click en el boton "Eliminar" del movimiento

            If DG_Movimientos.Rows(e.RowIndex).Cells(6).Value().ToString = "-" Then
                MessageBox.Show("El movimiento no puede ser eliminado ya que fue aceptado por la sucursal destino.", "Movimientos | Listado", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                If MessageBox.Show("¿Está seguro que desea eliminar el movimiento?", "Movimientos | Listado", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = vbYes Then
                    'Cambio el cursor a "WAIT"
                    Me.Cursor = Cursors.WaitCursor

                    'Seteo las variables
                    Dim Tipo As String = DG_Movimientos.Rows(e.RowIndex).Cells("Tipo").Value()
                    Dim Descripcion As String = DG_Movimientos.Rows(e.RowIndex).Cells("Descripcion").Value()
                    Dim id_Mov As Integer = DG_Movimientos.Rows(e.RowIndex).Cells("id_Movimiento").Value()

                    'Dependiendo del tipo abro un form u otro.
                    Dim Estado As String = ""

                    If Tipo = "Dif. de Caja" Then
                        Estado = NegMovimiento.EliminarMovimiento(id_Mov, id_Sucursal, 1)
                    ElseIf Tipo = "Egreso" Then
                        Estado = NegMovimiento.EliminarMovimiento(id_Mov, id_Sucursal, 2)
                    ElseIf Tipo = "Gasto" Then
                        Dim dsMov As New DataSet
                        Dim id_Reg As Integer = 0
                        dsMov = NegMovimiento.ObtenerMov(id_Mov, id_Sucursal, "Gasto")
                        id_Reg = dsMov.Tables(0).Rows(0).Item("id_Registro").ToString
                        Estado = NegMovimiento.EliminarMovimiento(id_Mov, id_Sucursal, 3, id_Reg)
                    ElseIf Tipo = "Impuesto" Then
                        Estado = NegMovimiento.EliminarMovimiento(id_Mov, id_Sucursal, 4)
                    ElseIf Tipo = "Movimiento de Socio" Then
                        If (Descripcion = "Retiro de socio") Then
                            Estado = NegMovimiento.EliminarMovimiento(id_Mov, id_Sucursal, 5)
                        Else
                            Estado = NegMovimiento.EliminarMovimiento(id_Mov, id_Sucursal, 7)
                        End If
                    ElseIf Tipo = "Caja Fuerte" Then
                        Estado = NegMovimiento.EliminarMovimiento(id_Mov, id_Sucursal, 6)
                    End If

                    MessageBox.Show(Estado, "Movimientos | Listado", MessageBoxButtons.OK, MessageBoxIcon.Information)

                    'Recargo la planilla.
                    CargarPlanilla(CbTipo.SelectedItem, CbAnios.SelectedItem, CbMeses.SelectedItem)

                    'Cambio el cursor a NORMAL.
                    Me.Cursor = Cursors.Arrow
                End If
            End If
        End If
    End Sub

    'Cuando hace click en buscar, refresco la grilla.
    Private Sub BtnBuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnBuscar.Click
        'Cargo la planilla.
        CargarPlanilla(CbTipo.SelectedItem, CbAnios.SelectedItem, CbMeses.SelectedItem)
    End Sub

    'Hago aparecer la manito loca!
    Private Sub DG_Movimientos_CellMouseEnter(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DG_Movimientos.CellMouseEnter
        If e.ColumnIndex < 0 Or e.RowIndex < 0 Then
            Return
        Else
            If e.ColumnIndex = 5 Or e.ColumnIndex = 6 Then
                DG_Movimientos.Cursor = Cursors.Hand
            Else
                DG_Movimientos.Cursor = Cursors.Arrow
            End If
        End If
    End Sub

    'Boton Restablecer.
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        RefrescarPlanillaHoy()
    End Sub
#End Region

#Region "Region de Funciones"
    'Funcion que agrega un movimiento al Grid.
    Sub AgregarMovimiento(ByVal id_Movimiento As Integer, ByVal Fecha As String, ByVal Descripcion As String, ByVal Monto As Double, ByVal Tipo As String, Optional ByVal Destino As Boolean = False, Optional ByVal Aceptado As Integer = 0)

        'Creo la fila del producto.
        Dim dgvRow As New DataGridViewRow
        Dim dgvCell As DataGridViewCell

        'Valor de la Columna Id
        dgvCell = New DataGridViewTextBoxCell()
        dgvCell.Value = id_Movimiento
        dgvRow.Cells.Add(dgvCell)

        'Valor de la Columna Fecha
        dgvCell = New DataGridViewTextBoxCell()
        dgvCell.Value = Fecha
        dgvRow.Cells.Add(dgvCell)

        'Valor de la Columna Tipo
        dgvCell = New DataGridViewTextBoxCell()
        dgvCell.Value = Tipo
        dgvRow.Cells.Add(dgvCell)

        'Valor de la Columna Descripcion
        dgvCell = New DataGridViewTextBoxCell()
        dgvCell.Value = Descripcion
        dgvRow.Cells.Add(dgvCell)

        'Valor de la Columna Monto
        dgvCell = New DataGridViewTextBoxCell()
        dgvCell.Value = "$ " & Format(CType(Monto, Decimal), "###0.00")
        dgvRow.Cells.Add(dgvCell)

        If Destino Or Aceptado = 1 Then
            'Valor de la Columna VerDetalle
            dgvCell = New DataGridViewImageCell()
            dgvCell.Value = My.Resources.Recursos.Detalle_Pequeno
            dgvCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
            dgvCell.ToolTipText = "Ver movimiento"
            dgvRow.Cells.Add(dgvCell)

            'Valor de la Columna Eliminar
            dgvCell = New DataGridViewTextBoxCell()
            dgvCell.Value = "-"
            dgvCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
            dgvCell.ToolTipText = "No se puede eliminar éste movimiento"
            dgvRow.Cells.Add(dgvCell)
        Else
            'Valor de la Columna VerDetalle
            dgvCell = New DataGridViewImageCell()
            dgvCell.Value = My.Resources.Recursos.Detalle_Pequeno
            dgvCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
            dgvCell.ToolTipText = "Editar movimiento"
            dgvRow.Cells.Add(dgvCell)

            'Valor de la Columna Eliminar
            dgvCell = New DataGridViewImageCell()
            dgvCell.Value = My.Resources.Recursos.Boton_Eliminar
            dgvCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
            dgvCell.ToolTipText = "Eliminar movimiento"
            dgvRow.Cells.Add(dgvCell)
        End If


        dgvRow.Height = "30"

        'Inserto la fila
        DG_Movimientos.Rows.Add(dgvRow)

    End Sub

    Sub CargarPlanilla(ByVal Tipo As String, ByVal Anio As Integer, ByVal Mes As String)

        Dim NumeroMes As Integer = Funciones.ObtenerNumeroMes(Mes)
        'Limpio el datagrid
        DG_Movimientos.Rows.Clear()
        DG_Movimientos.Refresh()

        If Tipo = "Todos los movimientos" Then
            'Muestro el form de espera..
            frmCargadorDeEspera.Show()
            frmCargadorDeEspera.Text = "Generando el listado de Movimientos de la Sucursal " & Nombre_Sucursal
            frmCargadorDeEspera.lbl_Descripcion.Text = "iniciando..."
            frmCargadorDeEspera.BarraProgreso.Minimum = 0
            frmCargadorDeEspera.BarraProgreso.Maximum = 9
            frmCargadorDeEspera.BarraProgreso.Value = 1
            frmCargadorDeEspera.Refresh()

            'Voy seteando la barra de progreso
            frmCargadorDeEspera.BarraProgreso.Value = 2
            frmCargadorDeEspera.lbl_Descripcion.Text = "Cargando movimientos de diferencias de caja... (1/8)"
            frmCargadorDeEspera.Refresh()

            'Cargo los movimientos de Dif. de Caja.
            Dim DsCaja As New DataSet
            DsCaja = NegMovimiento.ObtenerMovCaja(id_Sucursal, Anio, NumeroMes)
            If DsCaja IsNot Nothing Then
                For Each mov In DsCaja.Tables(0).Rows
                    AgregarMovimiento(mov.item("id_Movimiento"), mov.item("Fecha"), mov.item("Tipo"), mov.item("Monto"), "Dif. de Caja")
                Next
            End If

            'Voy seteando la barra de progreso
            frmCargadorDeEspera.BarraProgreso.Value = 3
            frmCargadorDeEspera.lbl_Descripcion.Text = "Cargando Gastos... (2/8)"
            frmCargadorDeEspera.Refresh()

            'Cargo los movimientos de Gastos.
            Dim DsGasto As New DataSet
            DsGasto = NegMovimiento.ObtenerMovGasto(id_Sucursal, Anio, NumeroMes)
            If DsGasto IsNot Nothing Then
                For Each mov In DsGasto.Tables(0).Rows
                    AgregarMovimiento(mov.item("id_Movimiento"), mov.item("Fecha"), mov.item("Tipo"), mov.item("Monto"), "Gasto")
                Next
            End If



            'Voy seteando la barra de progreso
            frmCargadorDeEspera.BarraProgreso.Value = 4
            frmCargadorDeEspera.lbl_Descripcion.Text = "Cargando Impuestos... (3/8)"
            frmCargadorDeEspera.Refresh()

            'Cargo los movimientos de Impuestos.
            Dim DsImpuesto As New DataSet
            DsImpuesto = NegMovimiento.ObtenerMovImpuesto(id_Sucursal, Anio, NumeroMes)
            If DsImpuesto IsNot Nothing Then
                For Each mov In DsImpuesto.Tables(0).Rows
                    AgregarMovimiento(mov.item("id_Movimiento"), mov.item("Fecha"), mov.item("Tipo"), mov.item("Monto"), "Impuesto")
                Next
            End If

            'Voy seteando la barra de progreso
            frmCargadorDeEspera.BarraProgreso.Value = 5
            frmCargadorDeEspera.lbl_Descripcion.Text = "Cargando Envíos a otras sucursales... (4/8)"
            frmCargadorDeEspera.Refresh()

            'Cargo los movimientos de Egresos.
            Dim DsEgreso As New DataSet
            DsEgreso = NegMovimiento.ObtenerMovEgreso(id_Sucursal, Anio, NumeroMes)
            If DsEgreso IsNot Nothing Then
                For Each mov In DsEgreso.Tables(0).Rows
                    Dim description As String = mov.item("Tipo")
                    Dim destiny As Boolean = False
                    If mov.item("id_Sucursal") <> id_Sucursal Then
                        description = mov.item("Tipo") & " (ENV. OTRAS SUC.)"
                        destiny = True
                    End If
                    AgregarMovimiento(mov.item("id_Movimiento"), mov.item("Fecha"), description, mov.item("Monto"), "Env. otras Suc.", destiny, mov.item("Aceptado"))
                Next
            End If

            'Voy seteando la barra de progreso
            frmCargadorDeEspera.BarraProgreso.Value = 6
            frmCargadorDeEspera.lbl_Descripcion.Text = "Cargando Retiro de socios... (5/8)"
            frmCargadorDeEspera.Refresh()

            'Cargo los movimientos de Retiro de socios.
            Dim DsRetiro As New DataSet
            DsRetiro = NegMovimiento.ObtenerMovRetiro(id_Sucursal, Anio, NumeroMes)
            If DsRetiro IsNot Nothing Then
                For Each mov In DsRetiro.Tables(0).Rows
                    AgregarMovimiento(mov.item("id_Movimiento"), mov.item("Fecha"), "Retiro de socio", mov.item("Monto"), "Movimiento de Socio")
                Next
            End If

            'Voy seteando la barra de progreso
            frmCargadorDeEspera.BarraProgreso.Value = 7
            frmCargadorDeEspera.lbl_Descripcion.Text = "Cargando Aporte de socios... (6/8)"
            frmCargadorDeEspera.Refresh()

            'Cargo los movimientos de Aporte de socios.
            Dim DsAporte As New DataSet
            DsAporte = NegMovimiento.ObtenerMovAporte(id_Sucursal, Anio, NumeroMes)
            If DsAporte IsNot Nothing Then
                For Each mov In DsAporte.Tables(0).Rows
                    AgregarMovimiento(mov.item("id_Movimiento"), mov.item("Fecha"), "Aporte de socio", mov.item("Monto"), "Movimiento de Socio")
                Next
            End If

            'Voy seteando la barra de progreso
            frmCargadorDeEspera.BarraProgreso.Value = 8
            frmCargadorDeEspera.lbl_Descripcion.Text = "Cargando Caja Fuerte... (7/8)"
            frmCargadorDeEspera.Refresh()

            'Cargo los movimientos de Caja Fuerte
            Dim DsCajaFuerte As New DataSet
            DsCajaFuerte = NegMovimiento.ObtenerMovCajaFuerte(id_Sucursal, Anio, NumeroMes)
            If DsCajaFuerte IsNot Nothing Then
                For Each mov In DsCajaFuerte.Tables(0).Rows
                    AgregarMovimiento(mov.item("id_Movimiento"), mov.item("Fecha"), mov.item("Tipo"), mov.item("Monto"), "Caja Fuerte")
                Next
            End If

            'Cargo las dovoluciones.
            Dim DsDevoluciones As New DataSet
            Dim FDesde As String = New Date(Anio, NumeroMes, 1).ToString("yyyy/MM/dd")
            Dim FHasta As String = New Date(Anio, NumeroMes, 1).AddMonths(1).AddDays(-1).ToString("yyyy/MM/dd")
            DsDevoluciones = NegDevolucion.ObtenerDevolucionesSucursalListado(id_Sucursal, FDesde, FHasta)
            If DsDevoluciones IsNot Nothing Then
                For Each mov In DsDevoluciones.Tables(0).Rows
                    AgregarMovimiento(mov.item("id_devolucion"), mov.item("Fecha"), mov.item("Tipo_Pago"), mov.item("Precio_Total"), "Devolución", True)
                Next
            End If

            'Voy seteando la barra de progreso
            frmCargadorDeEspera.BarraProgreso.Value = 9
            frmCargadorDeEspera.lbl_Descripcion.Text = "Cargando Devoluciones... (8/8)"
            frmCargadorDeEspera.Refresh()

            'Voy seteando la barra de progreso
            frmCargadorDeEspera.Close()
            frmCargadorDeEspera.Dispose()
        ElseIf Tipo = "Diferencias de Caja" Then
            'Cargo los movimientos de Dif. de Caja.
            Dim DsCaja As New DataSet
            DsCaja = NegMovimiento.ObtenerMovCaja(id_Sucursal, Anio, NumeroMes)
            If DsCaja IsNot Nothing Then
                For Each mov In DsCaja.Tables(0).Rows
                    AgregarMovimiento(mov.item("id_Movimiento"), mov.item("Fecha"), mov.item("Tipo"), mov.item("Monto"), "Dif. de Caja")
                Next
            End If
        ElseIf Tipo = "Egresos" Then
            'Cargo los movimientos de Egresos.
            Dim DsEgreso As New DataSet
            DsEgreso = NegMovimiento.ObtenerMovEgreso(id_Sucursal, Anio, NumeroMes)
            If DsEgreso IsNot Nothing Then
                For Each mov In DsEgreso.Tables(0).Rows
                    AgregarMovimiento(mov.item("id_Movimiento"), mov.item("Fecha"), mov.item("Tipo"), mov.item("Monto"), "Egreso")
                Next
            End If
        ElseIf Tipo = "Gastos" Then
            'Cargo los movimientos de Gastos.
            Dim DsGasto As New DataSet
            DsGasto = NegMovimiento.ObtenerMovGasto(id_Sucursal, Anio, NumeroMes)
            If DsGasto IsNot Nothing Then
                For Each mov In DsGasto.Tables(0).Rows
                    AgregarMovimiento(mov.item("id_Movimiento"), mov.item("Fecha"), mov.item("Tipo"), mov.item("Monto"), "Gasto")
                Next
            End If
        ElseIf Tipo = "Impuestos" Then
            'Cargo los movimientos de Impuestos.
            Dim DsImpuesto As New DataSet
            DsImpuesto = NegMovimiento.ObtenerMovImpuesto(id_Sucursal, Anio, NumeroMes)
            If DsImpuesto IsNot Nothing Then
                For Each mov In DsImpuesto.Tables(0).Rows
                    AgregarMovimiento(mov.item("id_Movimiento"), mov.item("Fecha"), mov.item("Tipo"), mov.item("Monto"), "Impuesto")
                Next
            End If
        ElseIf Tipo = "Movimiento de Socio" Then
            'Cargo los movimientos de Retiro de socios.
            Dim DsRetiro As New DataSet
            DsRetiro = NegMovimiento.ObtenerMovRetiro(id_Sucursal, Anio, NumeroMes)
            If DsRetiro IsNot Nothing Then
                For Each mov In DsRetiro.Tables(0).Rows
                    AgregarMovimiento(mov.item("id_Movimiento"), mov.item("Fecha"), "Retiro de socios", mov.item("Monto"), "Movimiento de Socio")
                Next
            End If

            'Cargo los movimientos de Aporte de socios.
            Dim DsAporte As New DataSet
            DsAporte = NegMovimiento.ObtenerMovAporte(id_Sucursal, Anio, NumeroMes)
            If DsAporte IsNot Nothing Then
                For Each mov In DsAporte.Tables(0).Rows
                    AgregarMovimiento(mov.item("id_Movimiento"), mov.item("Fecha"), "Aporte de socio", mov.item("Monto"), "Movimiento de Socio")
                Next
            End If

        ElseIf Tipo = "Caja Fuerte" Then
            'Cargo los movimientos de Caja Fuerte
            Dim DsCajaFuerte As New DataSet
            DsCajaFuerte = NegMovimiento.ObtenerMovCajaFuerte(id_Sucursal, Anio, NumeroMes)
            If DsCajaFuerte IsNot Nothing Then
                For Each mov In DsCajaFuerte.Tables(0).Rows
                    AgregarMovimiento(mov.item("id_Movimiento"), mov.item("Fecha"), mov.item("Tipo"), mov.item("Monto"), "Caja Fuerte")
                Next
            End If

        ElseIf Tipo = "Devoluciones" Then
            'Cargo las dovoluciones.
            Dim DsDevoluciones As New DataSet
            Dim FDesde As String = New Date(Anio, NumeroMes, 1).ToString("yyyy/MM/dd")
            Dim FHasta As String = New Date(Anio, NumeroMes, 1).AddMonths(1).AddDays(-1).ToString("yyyy/MM/dd")
            DsDevoluciones = NegDevolucion.ObtenerDevolucionesSucursalListado(id_Sucursal, FDesde, FHasta)
            If DsDevoluciones IsNot Nothing Then
                For Each mov In DsDevoluciones.Tables(0).Rows
                    AgregarMovimiento(mov.item("id_devolucion"), mov.item("Fecha"), mov.item("Tipo_Pago"), mov.item("Precio_Total"), "Devolución", True)
                Next
            End If
        End If



        'Ordeno las filas, por fecha descendientemente.
        DG_Movimientos.Sort(DG_Movimientos.Columns(1), System.ComponentModel.ListSortDirection.Descending)
        DG_Movimientos.ClearSelection()
    End Sub

    Public Sub RefrescarPlanilla()
        Try
            'Cambio el cursor a "WAIT"
            Me.Cursor = Cursors.WaitCursor
            CargarPlanilla(CbTipo.SelectedItem, CbAnios.SelectedItem, CbMeses.SelectedItem)
            'Cambio el cursor a NORMAL.
            Me.Cursor = Cursors.Arrow
        Catch ex As Exception
            Me.Cursor = Cursors.Arrow
            MessageBox.Show("Se ha encontrado un error al cargar la planilla de movimientos.", "Movimientos | Listado", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Public Sub RefrescarPlanillaHoy()
        Try
            'Cambio el cursor a "WAIT"
            Me.Cursor = Cursors.WaitCursor

            Dim datetimeFormat = Threading.Thread.CurrentThread.CurrentCulture.DateTimeFormat
            CbTipo.SelectedItem = "Todos los movimientos"
            CbMeses.SelectedItem = datetimeFormat.GetMonthName(Date.Today.Month)
            CbAnios.SelectedItem = Now.Year
            CargarPlanilla("Todos los movimientos", Now.Year, datetimeFormat.GetMonthName(Date.Today.Month))

            'Cambio el cursor a NORMAL.
            Me.Cursor = Cursors.Arrow
        Catch ex As Exception
            Me.Cursor = Cursors.Arrow
            MessageBox.Show("Se ha encontrado un error al cargar la planilla de movimientos.", "Movimientos | Listado", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
#End Region

End Class