Public Class frmDiferenciasListado
    Dim NegMov As New Negocio.NegMovimientos
    Dim NegSucursal As New Negocio.NegSucursales
    Dim id_Sucursal As Integer

    'Load del formulario.
    Private Sub frmDiferenciasListado_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            'Cambio el cursor a "WAIT"
            Me.Cursor = Cursors.WaitCursor

            'Sucursal default
            id_Sucursal = My.Settings("Sucursal")

            'Cargo el combo con las sucursales.
            Dim DsSucursales As New DataSet
            DsSucursales = NegSucursal.ListadoSucursales()
            If DsSucursales.Tables(0).Rows.Count > 1 Then
                Cb_Sucursal.DataSource = DsSucursales.Tables(0)
                Cb_Sucursal.DisplayMember = "Nombre"
                Cb_Sucursal.ValueMember = "id_Sucursal"
                Cb_Sucursal.SelectedValue = id_Sucursal
                Cb_Sucursal.Refresh()
            End If

            If (Not Negocio.Funciones.HayInternet) Then
                Cb_Sucursal.Enabled = False
            End If

            FechaDesde.Value = Now.Date.AddDays(-30)
            FechaHasta.Value = Now.Date

            'Cargo el stock
            Dim dsMov As New DataSet
            dsMov = NegMov.ObtenerDifCaja(Cb_Sucursal.SelectedValue, FechaDesde.Value.ToString("yyyy/MM/dd"), FechaHasta.Value.ToString("yyyy/MM/dd"))
            If dsMov.Tables(0).Rows.Count > 0 Then
                DG_Movimientos.DataSource = dsMov.Tables(0)
                DG_Movimientos.AutoGenerateColumns = False
                DG_Movimientos.ColumnHeadersVisible = True
                DG_Movimientos.Refresh()
                lbl_Msg.Visible = False
            Else
                lbl_Msg.Visible = True
                DG_Movimientos.DataSource = Nothing
                DG_Movimientos.Refresh()
                DG_Movimientos.ColumnHeadersVisible = False
            End If

            'Muestro el total
            txt_Total.Text = CalcularTotal()

            'Cambio el cursor a NORMAL.
            Me.Cursor = Cursors.Arrow

        Catch ex As Exception
            Me.Cursor = Cursors.Arrow
            MessageBox.Show("Se ha encontrado un error al cargar la bitácora de stocks. Por favor, contactese con el administrador.", "Administración de Stock", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    'Boton Buscar.
    Private Sub btn_Buscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Buscar.Click
        Try
            'Cambio el cursor a "WAIT"
            Me.Cursor = Cursors.WaitCursor

            'Cargo el stock
            Dim dsMov As New DataSet
            dsMov = NegMov.ObtenerDifCaja(Cb_Sucursal.SelectedValue, FechaDesde.Value.ToString("yyyy/MM/dd"), FechaHasta.Value.ToString("yyyy/MM/dd"))
            If dsMov.Tables(0).Rows.Count > 0 Then
                DG_Movimientos.DataSource = dsMov.Tables(0)
                DG_Movimientos.AutoGenerateColumns = False
                DG_Movimientos.ColumnHeadersVisible = True
                DG_Movimientos.Refresh()
                lbl_Msg.Visible = False
            Else
                lbl_Msg.Visible = True
                DG_Movimientos.DataSource = Nothing
                DG_Movimientos.Refresh()
                DG_Movimientos.ColumnHeadersVisible = False
            End If

            'Muestro el total
            txt_Total.Text = CalcularTotal()

            'Cambio el cursor a NORMAL.
            Me.Cursor = Cursors.Arrow

        Catch ex As Exception
            Me.Cursor = Cursors.Arrow
            MessageBox.Show("Se ha encontrado un error al cargar la bitácora de stocks. Por favor, contactese con el administrador.", "Administración de Stock", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    'Boton restablecer.
    Private Sub btn_Restablecer_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Restablecer.Click
        Try
            'Cambio el cursor a "WAIT"
            Me.Cursor = Cursors.WaitCursor

            Cb_Sucursal.SelectedValue = id_Sucursal
            FechaDesde.Value = Now.Date.AddDays(-30)
            FechaHasta.Value = Now.Date

            'Cargo el stock
            Dim dsMov As New DataSet
            dsMov = NegMov.ObtenerDifCaja(Cb_Sucursal.SelectedValue, FechaDesde.Value.ToString("yyyy/MM/dd"), FechaHasta.Value.ToString("yyyy/MM/dd"))
            If dsMov.Tables(0).Rows.Count > 0 Then
                DG_Movimientos.DataSource = dsMov.Tables(0)
                DG_Movimientos.AutoGenerateColumns = False
                DG_Movimientos.ColumnHeadersVisible = True
                DG_Movimientos.Refresh()
                lbl_Msg.Visible = False
            Else
                lbl_Msg.Visible = True
                DG_Movimientos.DataSource = Nothing
                DG_Movimientos.Refresh()
                DG_Movimientos.ColumnHeadersVisible = False
            End If

            'Muestro el total
            txt_Total.Text = CalcularTotal()

            'Cambio el cursor a NORMAL.
            Me.Cursor = Cursors.Arrow

        Catch ex As Exception
            Me.Cursor = Cursors.Arrow
            MessageBox.Show("Se ha encontrado un error al cargar la bitácora de stocks. Por favor, contactese con el administrador.", "Administración de Stock", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    'Funcion que calcula el total de subtotales del DATAGRID
    Function CalcularTotal()
        Dim Tot As Double = 0
        For i = 0 To (DG_Movimientos.Rows.Count - 1)

            If DG_Movimientos.Rows(i).Cells.Item("Tipo").Value = "Faltante de Caja" Then
                Tot -= CDbl(DG_Movimientos.Rows(i).Cells.Item("Monto").Value)
            Else
                Tot += CDbl(DG_Movimientos.Rows(i).Cells.Item("Monto").Value)
            End If

        Next
        Return Format(CType(Tot, Decimal), "###0.00")
    End Function

End Class