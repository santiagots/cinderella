Public Class frmPlanillaEntreSucursalesD1
    Public id_Movimiento As Integer = 0
    Public id_Sucursal As Integer = 0
    Public id_SucursalDestino As Integer = 0
    Dim NegMovimiento As New Negocio.NegMovimientos

    'Load de formulario.
    Private Sub frmPlanillaEntreSucursalesD1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            'CAMBIO EL CURSOR.
            Me.Cursor = Cursors.WaitCursor

            'Limpio.
            LimpiarFormulario()

            'Obtengo el movimiento.
            Dim dsMovimiento As New DataSet
            dsMovimiento = NegMovimiento.ObtenerMovEgresoDetalle(id_Movimiento, id_Sucursal, id_SucursalDestino)

            lblFecha.Text = dsMovimiento.Tables(0).Rows(0).Item("Fecha")
            lblSucursal.Text = dsMovimiento.Tables(0).Rows(0).Item("Sucursal").ToString()
            lblSucursalDestino.Text = dsMovimiento.Tables(0).Rows(0).Item("SucursalDestino").ToString()
            If dsMovimiento.Tables(0).Rows(0).Item("Subtipo").ToString <> "" Then
                lblDescripcion.Text = dsMovimiento.Tables(0).Rows(0).Item("Subtipo").ToString()
            End If
            lblTipo.Text = dsMovimiento.Tables(0).Rows(0).Item("Tipo").ToString
            lblMonto.Text = "$ " & Format(CType(dsMovimiento.Tables(0).Rows(0).Item("Monto"), Decimal), "###0.00") & ".-"
            lblFecha.Text = dsMovimiento.Tables(0).Rows(0).Item("Fecha").ToString
            lblComentarios.Text = dsMovimiento.Tables(0).Rows(0).Item("Descripcion").ToString

            'CAMBIO EL CURSOR.
            Me.Cursor = Cursors.Arrow
        Catch ex As Exception
            Me.Cursor = Cursors.Arrow
            MessageBox.Show(ex.Message, "Mov. entre Sucursales | Detalle", MessageBoxButtons.OK, MessageBoxIcon.Error)            
        End Try
    End Sub

    'Evento click del boton cerrar.
    Private Sub BtnCerrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnCerrar.Click
        Me.Close()
        frmPlanillaEntreSucursales.Visible = True
    End Sub

    Sub LimpiarFormulario()
        lblFecha.Text = "- - -"
        lblSucursal.Text = "- - -"
        lblSucursalDestino.Text = "- - -"
        lblDescripcion.Text = "- - -"
        lblTipo.Text = "- - -"
        lblMonto.Text = "- - -"
        lblFecha.Text = "- - -"
        lblComentarios.Text = "- - -"
    End Sub

End Class