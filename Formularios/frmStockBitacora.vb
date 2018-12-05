Public Class frmStockBitacora
    Dim NegStockBitacora As New Negocio.NegStockBitacora
    Dim NegSucursal As New Negocio.NegSucursales
    Dim id_Sucursal As Integer

    'Load del formulario.
    Private Sub frmStockBitacora_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
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

            If Not Negocio.Funciones.HayInternet Then
                Cb_Sucursal.Enabled = False
            End If

            FechaDesde.Value = Now.Date.AddDays(-30)
            FechaHasta.Value = Now.Date

            'Cargo el stock
            Dim dsStock As New DataSet
            dsStock = NegStockBitacora.ListadoBitacoraSucursal(Cb_Sucursal.SelectedValue, FechaDesde.Value.ToString("yyyy/MM/dd"), FechaHasta.Value.ToString("yyyy/MM/dd"))
            If dsStock.Tables(0).Rows.Count > 0 Then
                DG_Stock.DataSource = dsStock.Tables(0)
                DG_Stock.AutoGenerateColumns = False
                DG_Stock.ColumnHeadersVisible = True
                DG_Stock.Columns("id_Stock").Visible = False
                DG_Stock.Columns("Sucursal").Visible = False
                DG_Stock.Columns("Minimo_Ant").Visible = False
                DG_Stock.Columns("Minimo").Visible = False
                DG_Stock.Columns("Optimo_Ant").Visible = False
                DG_Stock.Columns("Optimo").Visible = False
                DG_Stock.Columns("Producto").DisplayIndex = 1
                DG_Stock.Columns("Codigo").DisplayIndex = 2
                DG_Stock.Columns("Costo").DisplayIndex = 3
                DG_Stock.Columns("Fecha").DisplayIndex = 4
                DG_Stock.Columns("Empleado").DisplayIndex = 5
                DG_Stock.Columns("Actual_Ant").DisplayIndex = 6
                DG_Stock.Columns("Actual").DisplayIndex = 7
                DG_Stock.Columns("Subtotal").DisplayIndex = 8
                DG_Stock.Refresh()
                lbl_Msg.Visible = False
            Else
                lbl_Msg.Visible = True
                DG_Stock.ColumnHeadersVisible = False
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
            Dim dsStock As New DataSet
            dsStock = NegStockBitacora.ListadoBitacoraSucursal(Cb_Sucursal.SelectedValue, FechaDesde.Value.ToString("yyyy/MM/dd"), FechaHasta.Value.ToString("yyyy/MM/dd"))
            If dsStock.Tables(0).Rows.Count > 0 Then
                DG_Stock.DataSource = dsStock.Tables(0)
                DG_Stock.AutoGenerateColumns = False
                DG_Stock.ColumnHeadersVisible = True
                DG_Stock.Columns("id_Stock").Visible = False
                DG_Stock.Columns("Sucursal").Visible = False
                DG_Stock.Columns("Minimo_Ant").Visible = False
                DG_Stock.Columns("Minimo").Visible = False
                DG_Stock.Columns("Optimo_Ant").Visible = False
                DG_Stock.Columns("Optimo").Visible = False
                DG_Stock.Columns("Producto").DisplayIndex = 1
                DG_Stock.Columns("Codigo").DisplayIndex = 2
                DG_Stock.Columns("Costo").DisplayIndex = 3
                DG_Stock.Columns("Fecha").DisplayIndex = 4
                DG_Stock.Columns("Empleado").DisplayIndex = 5
                DG_Stock.Columns("Actual_Ant").DisplayIndex = 6
                DG_Stock.Columns("Actual").DisplayIndex = 7
                DG_Stock.Columns("Subtotal").DisplayIndex = 8
                DG_Stock.Refresh()
                lbl_Msg.Visible = False
            Else
                lbl_Msg.Visible = True
                DG_Stock.ColumnHeadersVisible = False
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
            Dim dsStock As New DataSet
            dsStock = NegStockBitacora.ListadoBitacoraSucursal(Cb_Sucursal.SelectedValue, FechaDesde.Value.ToString("yyyy/MM/dd"), FechaHasta.Value.ToString("yyyy/MM/dd"))
            If dsStock.Tables(0).Rows.Count > 0 Then
                DG_Stock.DataSource = dsStock.Tables(0)
                DG_Stock.AutoGenerateColumns = False
                DG_Stock.ColumnHeadersVisible = True
                DG_Stock.Columns("id_Stock").Visible = False
                DG_Stock.Columns("Sucursal").Visible = False
                DG_Stock.Columns("Minimo_Ant").Visible = False
                DG_Stock.Columns("Minimo").Visible = False
                DG_Stock.Columns("Optimo_Ant").Visible = False
                DG_Stock.Columns("Optimo").Visible = False
                DG_Stock.Columns("Producto").DisplayIndex = 1
                DG_Stock.Columns("Codigo").DisplayIndex = 2
                DG_Stock.Columns("Costo").DisplayIndex = 3
                DG_Stock.Columns("Fecha").DisplayIndex = 4
                DG_Stock.Columns("Empleado").DisplayIndex = 5
                DG_Stock.Columns("Actual_Ant").DisplayIndex = 6
                DG_Stock.Columns("Actual").DisplayIndex = 7
                DG_Stock.Columns("Subtotal").DisplayIndex = 8
                DG_Stock.Refresh()
                lbl_Msg.Visible = False
            Else
                lbl_Msg.Visible = True
                DG_Stock.ColumnHeadersVisible = False
                DG_Stock.DataSource = Nothing
                DG_Stock.Refresh()
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
        For i = 0 To (DG_Stock.Rows.Count - 1)
            Tot += CDbl(DG_Stock.Rows(i).Cells.Item("Subtotal").Value)
        Next
        Return Format(CType(Tot, Decimal), "###0.00")
    End Function

End Class