Public Class frmStockMotivo
    Dim EStockBitacora As New Entidades.Stock_Bitacora
    Dim id_Sucursal As Integer
    Public id_Stock As Int64
    Dim NegStock As New Negocio.NegStock
    Dim NegStockBitacora As New Negocio.NegStockBitacora

    'Boton aceptar.
    Private Sub btnAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAceptar.Click
        If txt_Motivo.Text = "" Then
            MessageBox.Show("Debe ingresar el motivo de la baja.", "Administración de Stock", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            Try
                id_Sucursal = My.Settings("Sucursal")
                Dim EstockEliminado As New Entidades.Stock
                EstockEliminado = NegStock.TraerStock(id_Stock)

                If EstockEliminado.id_Producto <> 0 Then
                    'Lleno la entidad Stock_Bitacora.
                    EStockBitacora.id_Stock = EstockEliminado.id_Stock
                    EStockBitacora.Accion = "Eliminación"
                    EStockBitacora.id_Producto = EstockEliminado.id_Producto
                    EStockBitacora.id_Sucursal = id_Sucursal
                    EStockBitacora.Motivo = EstockEliminado.Motivo
                    EStockBitacora.Stock_Actual_Ant = 0
                    EStockBitacora.Stock_Minimo_Ant = 0
                    EStockBitacora.Stock_Optimo_Ant = 0
                    EStockBitacora.Stock_Actual = EstockEliminado.Stock_Actual
                    EStockBitacora.Stock_Minimo = EstockEliminado.Stock_Minimo
                    EStockBitacora.Stock_Optimo = EstockEliminado.Stock_Optimo
                    EStockBitacora.Fecha = Now
                    EStockBitacora.Habilitado = 1
                    EStockBitacora.id_Usuario = VariablesGlobales.objUsuario.id_Usuario
                    EStockBitacora.Usuario = VariablesGlobales.objUsuario.Usuario
                    NegStockBitacora.AltaStockBitacora(EStockBitacora)
                End If

                'ejecuto el sp_Productos_Eliminar.
                MessageBox.Show(NegStock.EliminarStock(id_Stock), "Administración de Stock", MessageBoxButtons.OK, MessageBoxIcon.Information)

                'refresco el datagrid
                Dim dsStock As New DataSet
                dsStock = NegStock.ListadoStockSucursal(id_Sucursal)
                If dsStock.Tables(0).Rows.Count > 0 Then
                    frmStock.DG_Stock.DataSource = dsStock.Tables(0)
                    frmStock.DG_Stock.AutoGenerateColumns = False
                    frmStock.DG_Stock.ColumnHeadersVisible = True
                    frmStock.DG_Stock.Columns("id_Stock").Visible = False
                    frmStock.DG_Stock.Columns("Codigo").Visible = False
                    frmStock.DG_Stock.Columns("Categoria").DisplayIndex = 1
                    frmStock.DG_Stock.Columns("Producto").DisplayIndex = 2
                    frmStock.DG_Stock.Columns("Sucursal").DisplayIndex = 3
                    frmStock.DG_Stock.Columns("Minimo").DisplayIndex = 4
                    frmStock.DG_Stock.Columns("Actual").DisplayIndex = 5
                    frmStock.DG_Stock.Columns("Optimo").DisplayIndex = 6
                    frmStock.DG_Stock.Columns("Modificar").DisplayIndex = 9
                    frmStock.DG_Stock.Columns("Eliminar").DisplayIndex = 9
                    frmStock.DG_Stock.Refresh()
                    frmStock.lbl_Msg.Visible = False
                Else
                    frmStock.lbl_Msg.Visible = True
                    frmStock.DG_Stock.ColumnHeadersVisible = False
                End If

                'Cierro la ventana.
                Me.Close()

                'Redirecciono al tab_listado
                frmStock.TabStock.SelectedIndex = 0
            Catch ex As Exception
                MessageBox.Show(ex.Message.ToString, "Administración de Stock", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End Try
        End If
    End Sub

    'Boton de cerrar la ventana.
    Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click
        Me.Close()
    End Sub

    'Load.
    Private Sub frmStockMotivo_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        lbl_Usuario2.Text = VariablesGlobales.objUsuario.Usuario
        lbl_Fecha2.Text = Now.ToShortDateString
    End Sub
End Class