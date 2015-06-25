Public Class frmAdelantoListado
    'Instancias
    Dim id_Sucursal As Integer
    Dim Nombre_Sucursal As String
    Dim NegAdelantos As New Negocio.NegAdelantos
    Dim Funciones As New Funciones

    Private Sub frmAdelantoListado_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        If frmAdelantoEfectivo.Visible Then
            frmAdelantoEfectivo.WindowState = FormWindowState.Normal
        End If
    End Sub

    Private Sub frmAdelantoListado_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            'Cambio el cursor a "WAIT"
            Me.Cursor = Cursors.WaitCursor

            'Sucursal default
            id_Sucursal = My.Settings("Sucursal")
            Nombre_Sucursal = My.Settings("NombreSucursal")

            Dim ds As New DataSet
            ds = NegAdelantos.ObtenerAdelantosSucursalListado(id_Sucursal, Now.Date.ToString("yyyy/MM/d"), Now.Date.ToString("yyyy/MM/d"))
            If (ds.Tables(0).Rows.Count > 0) Then
                DG_Adelantos.DataSource = ds.Tables(0)
                DG_Adelantos.AutoGenerateColumns = False
                DG_Adelantos.ColumnHeadersVisible = True
                DG_Adelantos.Columns("id_Adelanto").Visible = False
                DG_Adelantos.Columns("Fecha").Visible = False
                DG_Adelantos.Columns("Modificar").DisplayIndex = 5
                DG_Adelantos.Columns("Eliminar").DisplayIndex = 5
                DG_Adelantos.Refresh()
                lbl_Msg.Visible = False
            Else
                DG_Adelantos.ColumnHeadersVisible = False
                lbl_Msg.Visible = True
            End If

            'Cambio el cursor a NORMAL.
            Me.Cursor = Cursors.Arrow

        Catch ex As Exception
            Me.Cursor = Cursors.Arrow
            MessageBox.Show(ex.Message, "Listado de Adelantos del día", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub DG_Adelantos_CellContentClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DG_Adelantos.CellContentClick
        If DG_Adelantos.Columns(e.ColumnIndex).Name = "Modificar" Then 'Si se hace click en el boton "Modificar" del adelanto.

            'Cambio el cursor a "WAIT"
            Me.Cursor = Cursors.WaitCursor

            'Seteo las variables
            Dim id_Adelanto As Integer = DG_Adelantos.Rows(e.RowIndex).Cells("id_Adelanto").Value()

            If id_Adelanto <> 0 Then
                Me.Close()
                frmAdelantoEfectivo.id_Adelanto = id_Adelanto
                frmAdelantoEfectivo.RellenarFormulario()
                Funciones.ControlInstancia(frmAdelantoEfectivo).MdiParent = MDIContenedor
                Funciones.ControlInstancia(frmAdelantoEfectivo).Show()
                frmAdelantoEfectivo.WindowState = FormWindowState.Normal
            Else
                MessageBox.Show("No se puede eliminar el adelanto.", "Listado de Adelantos del día", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End If

            'Cambio el cursor a "NORMAL"
            Me.Cursor = Cursors.Arrow

        ElseIf DG_Adelantos.Columns(e.ColumnIndex).Name = "Eliminar" Then 'Si se hace click en el boton "Eliminar" del adelanto.

            'Cambio el cursor a "WAIT"
            Me.Cursor = Cursors.WaitCursor

            'Seteo las variables
            Dim id_Adelanto As Integer = DG_Adelantos.Rows(e.RowIndex).Cells("id_Adelanto").Value()

            If id_Adelanto = 0 Then
                MessageBox.Show("No se puede eliminar el empleado.", "Listado de Adelantos del día", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Else

                Dim Result As DialogResult
                Result = MessageBox.Show("¿Está seguro que desea eliminar el adelanto?", "Listado de Adelantos del día", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

                If Result = System.Windows.Forms.DialogResult.Yes Then 'Si acepta eliminar el item

                    MessageBox.Show(NegAdelantos.EliminarAdelanto(id_Adelanto, id_Sucursal), "Listado de Adelantos del día", MessageBoxButtons.OK, MessageBoxIcon.Information)

                    Dim ds As New DataSet
                    ds = NegAdelantos.ObtenerAdelantosSucursalListado(id_Sucursal, Now.Date.ToString("yyyy/MM/d"), Now.Date.ToString("yyyy/MM/d"))
                    If (ds.Tables(0).Rows.Count > 0) Then
                        DG_Adelantos.DataSource = ds.Tables(0)
                        DG_Adelantos.AutoGenerateColumns = False
                        DG_Adelantos.ColumnHeadersVisible = True
                        DG_Adelantos.Columns("id_Adelanto").Visible = False
                        DG_Adelantos.Columns("Fecha").Visible = False
                        DG_Adelantos.Columns("Modificar").DisplayIndex = 5
                        DG_Adelantos.Columns("Eliminar").DisplayIndex = 5
                        DG_Adelantos.Refresh()
                        lbl_Msg.Visible = False
                    Else
                        DG_Adelantos.ColumnHeadersVisible = False
                        DG_Adelantos.DataSource = Nothing
                        DG_Adelantos.Refresh()
                        lbl_Msg.Visible = True
                    End If
                End If

            End If

            'Cambio el cursor a "NORMAL"
            Me.Cursor = Cursors.Arrow

            End If
    End Sub
End Class