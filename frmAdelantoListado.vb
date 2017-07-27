Public Class frmAdelantoListado
    'Instancias
    Dim id_Sucursal As Integer
    Dim Nombre_Sucursal As String
    Dim NegAdelantos As New Negocio.NegAdelantos
    Dim Funciones As New Funciones

    Private Sub frmAdelantoListado_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        If frmAdelantoEfectivo.Visible Then
            frmAdelantoEfectivo.WindowState = FormWindowState.Normal
            frmAdelantoEfectivo.id_Adelanto = 0
            frmAdelantoEfectivo.RellenarFormulario()
        End If
    End Sub

    Private Sub frmAdelantoListado_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            'Cambio el cursor a "WAIT"
            Me.Cursor = Cursors.WaitCursor

            'Sucursal default
            id_Sucursal = My.Settings("Sucursal")
            Nombre_Sucursal = My.Settings("NombreSucursal")

            MostrarAdelantos()

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

            EditarAdelanto(e.RowIndex)

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

                    MostrarAdelantos()
                End If

            End If

            'Cambio el cursor a "NORMAL"
            Me.Cursor = Cursors.Arrow

        End If
    End Sub

    Private Sub MostrarAdelantos()
        Dim primerDiaMes As DateTime = New DateTime(Now.Date.Year, Now.Date.Month, 1)
        Dim ultimoDiaMes As DateTime = primerDiaMes.AddMonths(1).AddDays(-1)

        Dim ds As New DataSet
        ds = NegAdelantos.ObtenerAdelantosSucursalListado(id_Sucursal, primerDiaMes.ToString("yyyy/MM/d"), ultimoDiaMes.ToString("yyyy/MM/d"))
        If (ds.Tables(0).Rows.Count > 0) Then
            DG_Adelantos.AutoGenerateColumns = False
            DG_Adelantos.DataSource = ds.Tables(0)
            DG_Adelantos.ColumnHeadersVisible = True
            DG_Adelantos.Refresh()
            lbl_Msg.Visible = False
        Else
            DG_Adelantos.ColumnHeadersVisible = False
            DG_Adelantos.DataSource = Nothing
            DG_Adelantos.Refresh()
            lbl_Msg.Visible = True
        End If
    End Sub

    Private Sub EditarAdelanto(rowIndex As Integer)
        'Seteo las variables
        Dim id_Adelanto As Integer = DG_Adelantos.Rows(rowIndex).Cells("id_Adelanto").Value()

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
    End Sub

    Private Sub DG_Adelantos_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DG_Adelantos.CellDoubleClick
        'Solo se pueden modificar o eliminar adelanto de la fecha en curso
        If Date.Parse(DG_Adelantos.Rows(e.RowIndex).Cells("Fecha").Value()).Date <> DateTime.Now.Date Then
            Return
        End If

        'Cambio el cursor a "WAIT"
        Me.Cursor = Cursors.WaitCursor

        EditarAdelanto(e.RowIndex)

        'Cambio el cursor a "NORMAL"
        Me.Cursor = Cursors.Arrow
    End Sub

    Private Sub DG_Adelantos_CellFormatting(sender As Object, e As DataGridViewCellFormattingEventArgs) Handles DG_Adelantos.CellFormatting
        'Oculto los botones para que solo puedan ser modificados o eliminados los adelantos de la fecha en curso
        If DG_Adelantos.Columns(e.ColumnIndex).Name = "Fecha" AndAlso Date.Parse(e.Value).Date <> DateTime.Now.Date Then
            CType(DG_Adelantos.Rows(e.RowIndex).Cells("Eliminar"), DataGridViewImageCell).Value = New Bitmap(1, 1)
            CType(DG_Adelantos.Rows(e.RowIndex).Cells("Modificar"), DataGridViewImageCell).Value = New Bitmap(1, 1)
        End If
    End Sub
End Class