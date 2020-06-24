Imports Entidades
Imports Negocio

Public Class frmCostoFinancieroAdministracion

    Private CostosFinancierosSinCambios As DataTable
    Private CostosFinancieros As DataTable

    Private Sub CostoFinancieroAdministracion_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CostosFinancieros = NegTarjeta.TarearCostoFinanciero()
        CostosFinancierosSinCambios = CostosFinancieros.Copy()
        DG_costoFinanciero.DataSource = CostosFinancieros
    End Sub

    Private Sub BtnAgregar_Click(sender As Object, e As EventArgs) Handles BtnAgregar.Click
        If (Not FormularioValido()) Then
            Return
        End If

        'Compruebo que el banco que se esta ingresando ya no exita en la grilla
        If Not DG_costoFinanciero.Rows.Cast(Of DataGridViewRow).Where(Function(x) x.Cells("Nombre").Value = txtBanco.Text).Any() Then

            If CostosFinancieros Is Nothing Then
                InicializarTablaCostosFinancieros(CostosFinancieros)
                DG_costoFinanciero.DataSource = CostosFinancieros
            End If

            'cargo el banco en la grilla
            Dim NuevaRow As DataRow = CostosFinancieros.NewRow()
            NuevaRow("IdTarjeta") = 0
            NuevaRow("Habilitado") = 1
            NuevaRow("Nombre") = txtBanco.Text
            For i = 1 To 24
                NuevaRow(i.ToString()) = 0
            Next
            CostosFinancieros.Rows.Add(NuevaRow)
        Else
            MessageBox.Show("El banco que intenta ingresar ya se encuentra registrado. Por favor, ingrese otro banco.", "Administración de Costos Financieros", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub DG_costoFinanciero_CellValidating(sender As Object, e As DataGridViewCellValidatingEventArgs) Handles DG_costoFinanciero.CellValidating
        'Valido el formato de las celdas que sea para el registro de porcentajes
        If DG_costoFinanciero.Columns(e.ColumnIndex).Name <> "Habilitado" AndAlso DG_costoFinanciero.Columns(e.ColumnIndex).Name <> "Nombre" AndAlso DG_costoFinanciero.Columns(e.ColumnIndex).Name <> "Eliminar" Then
            Me.DG_costoFinanciero.Rows(e.RowIndex).ErrorText = ""
            Dim valorIngresado As String = e.FormattedValue.ToString().Replace("%", "")
            Dim valor As Decimal

            If Not Decimal.TryParse(valorIngresado, valor) OrElse valor < 0 Then
                e.Cancel = True
                DG_costoFinanciero.Rows(e.RowIndex).ErrorText = "El valor ingresado debe ser numérico y mayor a cero."
            Else
                If (DG_costoFinanciero.EditingControl IsNot Nothing) Then
                    DG_costoFinanciero.EditingControl.Text = valor / 100
                End If
            End If
        End If
    End Sub

    Private Sub DG_costoFinanciero_CellFormatting(sender As Object, e As DataGridViewCellFormattingEventArgs) Handles DG_costoFinanciero.CellFormatting
        'Modifico el formato de las celdas que sea para el registro de porcentajes
        If DG_costoFinanciero.Columns(e.ColumnIndex).Name <> "Habilitado" AndAlso DG_costoFinanciero.Columns(e.ColumnIndex).Name <> "Nombre" AndAlso DG_costoFinanciero.Columns(e.ColumnIndex).Name <> "Eliminar" Then
            Common.Core.Helper.Log.Info($"Column: {e.ColumnIndex} Row: {e.RowIndex} Value: {e.Value}")
            Dim cell As DataGridViewCell = DG_costoFinanciero.Item(e.ColumnIndex, e.RowIndex)
            Dim Valor As Decimal = 0
            If (cell.IsInEditMode) Then
                'Si esta en modo edicion muestro en formato numerico
                If (e.Value IsNot DBNull.Value AndAlso Decimal.TryParse(e.Value, Valor)) Then
                    e.Value = (Valor * 100).ToString("0.##")
                End If
            Else
                'Si no esta en modo edicion muestro en formato porcentaje
                If (e.Value IsNot DBNull.Value AndAlso Decimal.TryParse(e.Value, Valor)) Then
                    e.Value = (Valor).ToString("P")
                End If
            End If
        End If
    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        Try
            Me.Cursor = Cursors.WaitCursor

            Dim currentCell As DataGridViewCell = DG_costoFinanciero.CurrentCell
            DG_costoFinanciero.CurrentCell = Nothing
            DG_costoFinanciero.CurrentCell = currentCell

            For Each row As DataGridViewRow In DG_costoFinanciero.Rows
                Dim tarjeta As Tarjeta = New Tarjeta With {.TarjetaId = row.Cells("IdTarjeta").Value, .Nombre = row.Cells("Nombre").Value, .Habilitado = row.Cells("Habilitado").Value}
                Dim costoFinancieros As List(Of CostoFinanciero) = New List(Of CostoFinanciero)
                For i = 1 To 24
                    costoFinancieros.Add(New CostoFinanciero With {.Tarjeta = row.Cells("IdTarjeta").Value, .NumeroCuotas = i, .PorcentajeRecargo = row.Cells(String.Format("Cuota{0}", i.ToString())).Value})
                Next
                If (Not NegTarjeta.GuardarCostoFinanciero(tarjeta, costoFinancieros)) Then
                    MessageBox.Show("Se ha encontrado un error guardar los costos financieros. Por favor, vuelva a intentar más tarde o contáctese con el Administrador", "Administración de Costos Financieros", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Return
                End If
            Next

            CostosFinancierosSinCambios = CostosFinancieros.Copy()
            MessageBox.Show("Los costos financieros se han guardado correctamente.", "Administración de Costos Financieros", MessageBoxButtons.OK, MessageBoxIcon.Information)

            Me.Cursor = Cursors.Arrow
        Catch ex As Exception
            Me.Cursor = Cursors.Arrow
            MessageBox.Show("Se ha encontrado un error guardar los costos financieros. Por favor, vuelva a intentar más tarde o contáctese con el Administrador", "Administración de Costos Financieros", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub DG_costoFinanciero_DataBindingComplete(sender As Object, e As DataGridViewBindingCompleteEventArgs) Handles DG_costoFinanciero.DataBindingComplete
        lbl_Msg.Visible = DG_costoFinanciero.Rows.Count = 0
    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        DG_costoFinanciero.EndEdit()
        Me.Close()
    End Sub

    Private Sub CostoFinancieroAdministracion_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        If Not TablasSonIguales(CostosFinancierosSinCambios, CostosFinancieros) Then
            Dim rta As DialogResult = MessageBox.Show("Se realizaron modificaciones en los costos financieros y no se han guardado, si sale de la pantalla los cambios se perderán. ¿Desea salir de la pantalla?", "Administración de Costos Financieros", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If rta = DialogResult.No Then
                e.Cancel = True
            End If
        End If
    End Sub

    Private Function FormularioValido() As Boolean
        If (txtBanco.Text = String.Empty) Then
            ErrorProvider.SetError(txtBanco, String.Format("Campo requerido, debe ingresar un valor"))
            Return False
        Else
            ErrorProvider.SetError(txtBanco, String.Empty)
            Return True
        End If
    End Function

    Private Sub InicializarTablaCostosFinancieros(ByRef CostosFinancieros As DataTable)
        CostosFinancieros = New DataTable()

        CostosFinancieros.Columns.Add("Nombre")
        CostosFinancieros.Columns.Add("Habilitado")
        For i = 1 To 24
            CostosFinancieros.Columns.Add(i.ToString())
        Next
        CostosFinancieros.Columns.Add("IdTarjeta")
    End Sub

    Private Sub DG_costoFinanciero_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DG_costoFinanciero.CellContentClick
        Try
            If DG_costoFinanciero.Columns(e.ColumnIndex).Name = "Eliminar" Then 'Si se hace click en el boton "eliminar" de la fila.
                If MessageBox.Show("¿Está seguro que desea eliminar la tarjeta de crédito?", "Administración de Costos Financieros", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                    Me.Cursor = Cursors.WaitCursor
                    Dim idTarjeta As Integer = DG_costoFinanciero.Rows(e.RowIndex).Cells("IdTarjeta").Value
                    If idTarjeta > 0 Then
                        NegTarjeta.EliminarTarjeta(idTarjeta)
                        CostosFinancierosSinCambios.Rows.RemoveAt(e.RowIndex)
                    End If
                    CostosFinancieros.Rows.RemoveAt(e.RowIndex)
                End If
                Me.Cursor = Cursors.Arrow
                MessageBox.Show("La la tarjeta de crédito ha sido eliminada.", "Administración de Costos Financieros", MessageBoxButtons.OK, MessageBoxIcon.Question)
            End If

        Catch ex As Exception
            Me.Cursor = Cursors.Arrow
            MessageBox.Show("Se ha encontrado un error eliminar la tarjeta. Por favor, vuelva a intentar más tarde o contáctese con el Administrador", "Administración de Costos Financieros", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Function TablasSonIguales(table1 As DataTable, table2 As DataTable) As Boolean

        If table1.Rows.Count <> table2.Rows.Count Then
            Return False
        End If

        For i = 0 To table1.Rows.Count - 1
            Dim array1 = table1.Rows(i).ItemArray
            Dim array2 = table2.Rows(i).ItemArray

            If (Not array1.SequenceEqual(array2)) Then
                Return False
            End If
        Next
        Return True
    End Function
End Class