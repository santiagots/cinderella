Imports System.Data.OleDb
Imports Microsoft.Office.Interop
Imports System.Globalization
Imports System.Configuration

Public Class frmPlanillaSucursales
    Dim NegMovi As New Negocio.NegMovimientos
    Dim NegSucursal As New Negocio.NegSucursales
    Dim NegPlanillaSucursales As New Negocio.NegPlanillaSucursales
    Dim NegVen As New Negocio.NegVentas
    Dim ClsFunciones As New Funciones

#Region "Region de Eventos"
    'Load del Formulario
    Private Sub frmPlanillaSucursales_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            Dim primerDiaMes As Date = DateTime.Today.AddDays(1 - DateTime.Today.Day)
            Dim ultimoDiaMes As Date = primerDiaMes.AddMonths(1).AddSeconds(-1)

            'Cargo la fecha hasta con el primer dia del mes
            txt_FDesde.Value = DateTime.Today.AddDays(1 - DateTime.Today.Day)
            'Cargo la fecha desde con la fecha actual
            txt_FHasta.Value = Date.Today()
            txt_FDesde.MinDate = primerDiaMes
            txt_FDesde.MaxDate = ultimoDiaMes

            txt_FHasta.MinDate = primerDiaMes
            txt_FHasta.MaxDate = ultimoDiaMes

            'Cargo el combo con las sucursales.
            Dim dsSucursal As New DataSet
            dsSucursal = NegSucursal.ListadoSucursales()
            If dsSucursal.Tables(0).Rows.Count > 0 Then
                Cb_Sucursal.DataSource = dsSucursal.Tables(0)
                Cb_Sucursal.DisplayMember = "Nombre"
                Cb_Sucursal.ValueMember = "id_Sucursal"
                Cb_Sucursal.SelectedValue = My.Settings("Sucursal")
                Cb_Sucursal.Refresh()
            End If

            'Limpiar la grilla.
            LimpiarGrilla()

            'Maximizo el form.
            Me.WindowState = 2

        Catch ex As Exception
            GB_Controles.Enabled = True
            frmCargadorDeEspera.Close()
            frmCargadorDeEspera.Dispose()
            MessageBox.Show(ex.Message, "Planilla de Movimientos de Sucursales", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    'Evento click del boton que filtra la planilla.
    Private Sub btn_Filtrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Filtrar.Click
        'Cambio el cursor.
        Me.Cursor = Cursors.WaitCursor

        Try
            If Cb_Sucursal.SelectedValue Is Nothing Then
                MessageBox.Show("Debe seleccionar una sucursal.", "Planilla de Movimientos de Sucursales", MessageBoxButtons.OK, MessageBoxIcon.Information)
            ElseIf (txt_FHasta.Value < txt_FDesde.Value) Then
                MessageBox.Show("El rango de fechas seleccionado es incorrecto.", "Planilla de Movimientos de Sucursales", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else

                'Muestro el form de espera..
                frmCargadorDeEspera.Show()
                frmCargadorDeEspera.Text = "Generando la planilla de Movimientos de la Sucursal " & DirectCast(Cb_Sucursal.SelectedItem, System.Data.DataRowView).Row.ItemArray(1)
                frmCargadorDeEspera.lbl_Descripcion.Text = "Iniciando... "
                frmCargadorDeEspera.BarraProgreso.Minimum = 0
                frmCargadorDeEspera.BarraProgreso.Maximum = 13
                frmCargadorDeEspera.BarraProgreso.Value = 1
                frmCargadorDeEspera.Refresh()

                'Limpiar la grilla.
                LimpiarGrilla()

                'Cargo la grilla.
                CargarGrilla()

                'Defino el color alternativo de las rows
                DG_Planilla.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(255, 221, 235, 247)

                DG_Planilla.Columns("Nivel").Visible = False

                'Defino el formato de las columnas
                For i As Integer = 2 To DG_Planilla.Columns.Count - 1
                    DG_Planilla.Columns(i).DefaultCellStyle.Format = "c"
                Next

                'Programo que las columnas no sean 'sorteables'.
                For Each column In DG_Planilla.Columns
                    DG_Planilla.Columns(column.name).SortMode = DataGridViewColumnSortMode.NotSortable
                Next
            End If
        Catch ex As Exception
            MessageBox.Show("Se ha encontrado un error al generar la grilla de movimientos. Por favor, vuelva a intentar más tarde o contáctese con el Administrador", "Planilla de Movimientos de Sucursales", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Me.Close()
            Me.Dispose()
        Finally
            frmCargadorDeEspera.Close()
            frmCargadorDeEspera.Dispose()
        End Try


        'Cambio el cursor.
        Me.Cursor = Cursors.Arrow
    End Sub

    'Evento click del boton que permite guardar la planilla.
    Private Sub Btn_Excel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_Excel.Click
        'Si no se genero una plantilla de excel lo informo.
        If DG_Planilla.Rows.Count = 0 Then
            MessageBox.Show("No se ha encontrado una planilla a exportar. Por favor, genere una planilla para poder ser exportada.", "Planilla de Movimientos de Sucursales", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        Else
            Try
                'Configuro la pantalla de guardado de archivos
                Dim DialogSave As New SaveFileDialog()
                DialogSave.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments)
                DialogSave.FileName = "MoviminetoSucursal"
                DialogSave.Filter = "Excel Files|*.xlsx;"

                If DialogSave.ShowDialog() = DialogResult.OK Then
                    Me.Cursor = Cursors.WaitCursor
                    ExportarAExcel(DialogSave.FileName)
                End If

                'si no completo la descripcion, muestro un msg de error.
                MessageBox.Show("Se ha exportado el listado de movimientos de forma exitosa", "Administración de Productos", MessageBoxButtons.OK, MessageBoxIcon.Information)

            Catch ex As Exception
                MessageBox.Show("Se ha producido un error en la exportación de la información. Verifique que el documento no se encuentre en uso o esté abierto. Por favor, intente más tarde.", "Planilla de Movimientos de Sucursales", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Finally
                'Cambio el cursor a "NORMAL"
                Me.Cursor = Cursors.Arrow
            End Try


        End If
    End Sub
    Private Sub DG_Planilla_CellFormatting(sender As Object, e As DataGridViewCellFormattingEventArgs) Handles DG_Planilla.CellFormatting
        If (Not IsDBNull(DG_Planilla.Rows(e.RowIndex).Cells("Nivel").Value) AndAlso DG_Planilla.Rows(e.RowIndex).Cells("Nivel").Value = 1) Then
            e.CellStyle.BackColor = Color.FromArgb(255, 91, 155, 213)
            e.CellStyle.Font = New Font(e.CellStyle.Font, FontStyle.Bold)
            e.CellStyle.ForeColor = Color.White
        ElseIf (Not IsDBNull(DG_Planilla.Rows(e.RowIndex).Cells("Nivel").Value) AndAlso DG_Planilla.Rows(e.RowIndex).Cells("Nivel").Value = 0) Then
            e.CellStyle.BackColor = Color.FromArgb(255, 91, 155, 213)
            e.CellStyle.Font = New Font(e.CellStyle.Font.Name, (e.CellStyle.Font.Size + 2), FontStyle.Bold)
            e.CellStyle.ForeColor = Color.White
        ElseIf (Not IsDBNull(DG_Planilla.Rows(e.RowIndex).Cells("Nivel").Value) AndAlso DG_Planilla.Rows(e.RowIndex).Cells("Nivel").Value = -1) Then
            e.CellStyle.BackColor = Color.FromArgb(255, 91, 155, 213)
            e.CellStyle.Font = New Font(e.CellStyle.Font, FontStyle.Bold)
            e.CellStyle.ForeColor = Color.White
            e.CellStyle.Format = "P"
        Else
            e.CellStyle.Font = New Font(e.CellStyle.Font.Name, (e.CellStyle.Font.Size - 2))
        End If

    End Sub
#End Region

#Region "Region de Funciones que arman y muestran la planilla"

    Private Sub LimpiarGrilla()
        DG_Planilla.DataSource = Nothing
        DG_Planilla.Rows.Clear()
    End Sub

    Private Sub CargarGrilla()
        Dim fechaDesde As String = txt_FDesde.Value.ToString("yyyy-MM-dd")
        Dim fechaHasta As String = txt_FHasta.Value.ToString("yyyy-MM-dd")
        Dim id_Sucursal As Integer = Cb_Sucursal.SelectedValue

        Dim Movimientos As DataTable = New DataTable()

        'Indice Mercaderia
        ActualizarPantallaCarga("Obteniendo Indice Mercaderías / Ventas (1/14)", 1)
        Dim IndiceMercaderia As DataSet = NegPlanillaSucursales.ObtenerIndiceMercaderia(id_Sucursal, fechaDesde, fechaHasta)
        Movimientos.Merge(IndiceMercaderia.Tables(0))

        'Indice Sueldo
        ActualizarPantallaCarga("Obteniendo Indice Sueldos / Ventas (2/14)", 2)
        Dim IndiceSueldo As DataSet = NegPlanillaSucursales.ObtenerIndiceSueldo(id_Sucursal, fechaDesde, fechaHasta)
        Movimientos.Merge(IndiceSueldo.Tables(0))


        'Indice Alquiler
        ActualizarPantallaCarga("Obteniendo Indice Alquiler / Ventas (3/14)", 3)
        Dim IndiceAlquiler As DataSet = NegPlanillaSucursales.ObtenerIndiceAlquiler(id_Sucursal, fechaDesde, fechaHasta)
        Movimientos.Merge(IndiceAlquiler.Tables(0))

        'Disponibilidades
        ActualizarPantallaCarga("Obteniendo Disponibilidades (4/14)", 4)
        Dim Disponibilidades As DataSet = NegPlanillaSucursales.ObtenerDisponibilidades(id_Sucursal, fechaDesde, fechaHasta)
        Movimientos.Merge(Disponibilidades.Tables(0))

        'Ventas
        ActualizarPantallaCarga("Obteniendo Ventas (5/14)", 5)
        Dim Ventas As DataSet = NegPlanillaSucursales.ObtenerVentas(id_Sucursal, fechaDesde, fechaHasta)
        Movimientos.Merge(Ventas.Tables(0))

        'Mercaderia
        ActualizarPantallaCarga("Obteniendo Mercaderia (6/14)", 6)
        Dim Mercaderia As DataSet = NegPlanillaSucursales.ObtenerMercaderia(id_Sucursal, fechaDesde, fechaHasta)
        Movimientos.Merge(Mercaderia.Tables(0))

        'Sueldos
        ActualizarPantallaCarga("Obteniendo Sueldos (7/14)", 7)
        Dim Sueldos As DataSet = NegPlanillaSucursales.ObtenerSueldos(id_Sucursal, fechaDesde, fechaHasta)
        Movimientos.Merge(Sueldos.Tables(0))

        'Caja
        ActualizarPantallaCarga("Obteniendo Diferencias de Caja (8/14)", 8)
        Dim Caja As DataSet = NegPlanillaSucursales.ObtenerCaja(id_Sucursal, fechaDesde, fechaHasta)
        Movimientos.Merge(Caja.Tables(0))

        'Movimiento Socios
        ActualizarPantallaCarga("Obteniendo Movimientos de Socios (9/14)", 9)
        Dim MovimientoSocios As DataSet = NegPlanillaSucursales.ObtenerMovimientoSocios(id_Sucursal, fechaDesde, fechaHasta)
        Movimientos.Merge(MovimientoSocios.Tables(0))

        'Movimiento Sucursales
        ActualizarPantallaCarga("Obteniendo Movimientos entre Sucursales (11/14)", 10)
        Dim MovimientosSucursales As DataSet = NegPlanillaSucursales.ObtenerMovimientosSucursales(id_Sucursal, fechaDesde, fechaHasta)
        Movimientos.Merge(MovimientosSucursales.Tables(0))

        'Gastos
        ActualizarPantallaCarga("Obteniendo Gastos (12/14)", 11)
        Dim MovimientosGastos As DataSet = NegPlanillaSucursales.ObtenerGastos(id_Sucursal, fechaDesde, fechaHasta)
        Movimientos.Merge(MovimientosGastos.Tables(0))

        'Impuestos
        ActualizarPantallaCarga("Obteniendo Impuestos (13/14)", 12)
        Dim MovimientosImpuestos As DataSet = NegPlanillaSucursales.ObtenerImpuestos(id_Sucursal, fechaDesde, fechaHasta)
        Movimientos.Merge(MovimientosImpuestos.Tables(0))

        'Resultado Financiero
        ActualizarPantallaCarga("Obteniendo Resultado Financiero (14/14)", 13)
        Dim ResultadoFinanciero As DataRow = Movimientos.NewRow()

        'inicializo la row de resultado financiero a 0
        For Each col As DataColumn In Movimientos.Columns

            If (IsDBNull(ResultadoFinanciero(col))) Then
                ResultadoFinanciero(col) = 0
            End If
        Next

        'calculo el resultado financiero a partir de los DS recuperados
        'Resultado Financiero (ventas – mercaderías – sueldos + diferencia caja – gastos – impuestos)
        For i As Integer = 2 To Ventas.Tables(0).Rows(0).ItemArray.Count - 1
            ResultadoFinanciero.Item(i) += Ventas.Tables(0).Rows(0).Item(i)
        Next

        For i As Integer = 2 To Mercaderia.Tables(0).Rows(0).ItemArray.Count - 1
            ResultadoFinanciero.Item(i) -= Mercaderia.Tables(0).Rows(0).Item(i)
        Next

        For i As Integer = 2 To Sueldos.Tables(0).Rows(0).ItemArray.Count - 1
            ResultadoFinanciero.Item(i) -= Sueldos.Tables(0).Rows(0).Item(i)
        Next

        For i As Integer = 2 To Caja.Tables(0).Rows(0).ItemArray.Count - 1
            ResultadoFinanciero.Item(i) += Caja.Tables(0).Rows(0).Item(i)
        Next

        For i As Integer = 2 To MovimientosGastos.Tables(0).Rows(0).ItemArray.Count - 1
            ResultadoFinanciero.Item(i) -= MovimientosGastos.Tables(0).Rows(0).Item(i)
        Next

        For i As Integer = 2 To MovimientosImpuestos.Tables(0).Rows(0).ItemArray.Count - 1
            ResultadoFinanciero.Item(i) -= MovimientosImpuestos.Tables(0).Rows(0).Item(i)
        Next

        ResultadoFinanciero.Item(0) = "Resultado Financiero"

        ResultadoFinanciero.Item(1) = 0

        Movimientos.Rows.InsertAt(ResultadoFinanciero, 0)

        DG_Planilla.DataSource = Movimientos
    End Sub

    Private Sub ActualizarPantallaCarga(texto As String, Progreso As Integer)
        'Voy seteando la barra de progreso
        frmCargadorDeEspera.lbl_Descripcion.Text = texto
        frmCargadorDeEspera.BarraProgreso.Value = Progreso
        frmCargadorDeEspera.Refresh()
    End Sub

    Private Sub ExportarAExcel(nombreArchivo As String)
        Dim source1 As New BindingSource
        Dim APP As New Excel.Application
        Dim worksheet As Excel.Worksheet
        Dim workbook As Excel.Workbook
        Dim misValue As Object = System.Reflection.Missing.Value

        workbook = APP.Workbooks.Add(misValue)
        worksheet = CType(workbook.Worksheets.Item(1), Excel.Worksheet)

        '------------------------------------------Estilos para el excel------------------------------------------'
        Dim EstiloEncabezado As Microsoft.Office.Interop.Excel.Style
        EstiloEncabezado = workbook.Styles.Add("EstiloEncabezado")
        EstiloEncabezado.Font.Bold = True
        EstiloEncabezado.Font.Color = System.Drawing.ColorTranslator.ToOle(System.Drawing.Color.White)
        EstiloEncabezado.Font.Size = 11
        EstiloEncabezado.Font.Name = "Microsoft Sans Serif"
        EstiloEncabezado.Interior.Color = Color.FromArgb(255, 91, 155, 213)
        EstiloEncabezado.Interior.Pattern = Microsoft.Office.Interop.Excel.XlPattern.xlPatternSolid

        Dim EstiloCategoria As Microsoft.Office.Interop.Excel.Style
        EstiloCategoria = workbook.Styles.Add("EstiloCategoria")
        EstiloCategoria.Font.Bold = True
        EstiloCategoria.Font.Color = System.Drawing.ColorTranslator.ToOle(System.Drawing.Color.White)
        EstiloCategoria.Font.Size = 9
        EstiloCategoria.Font.Name = "Microsoft Sans Serif"
        EstiloCategoria.Interior.Color = Color.FromArgb(255, 91, 155, 213)
        EstiloCategoria.Interior.Pattern = Microsoft.Office.Interop.Excel.XlPattern.xlPatternSolid
        '------------------------------------------Estilos para el excel------------------------------------------'

        'Export Header Names Start
        Dim columnIndex As Integer = 0
        For j As Integer = 0 To DG_Planilla.Columns.Count - 1
            If (DG_Planilla.Columns(j).Name = "Nivel") Then
                Continue For
            End If
            worksheet.Cells(1, columnIndex + 1).Value = DG_Planilla.Columns(j).Name
            worksheet.Cells(1, columnIndex + 1).style = "EstiloEncabezado"
            If (j > 1) Then
                worksheet.Cells(1, columnIndex + 1).NumberFormat = "yyyy/MM/dd"
            End If
            columnIndex += 1
        Next
        'Export Header Name End


        'Export Each Row Start
        For i As Integer = 0 To DG_Planilla.Rows.Count - 1
            columnIndex = 0
            For j As Integer = 0 To DG_Planilla.Columns.Count - 1
                If (Not DG_Planilla.Columns(j).Visible) Then
                    Continue For
                End If

                If (DG_Planilla.Item("Nivel", i).Value <= 1) Then
                    worksheet.Cells(i + 2, columnIndex + 1).style = "EstiloCategoria"
                End If

                If (DG_Planilla.Item("Nivel", i).Value = -1) Then
                    worksheet.Cells(i + 2, columnIndex + 1).NumberFormat = "0.00%"
                Else
                    worksheet.Cells(i + 2, columnIndex + 1).NumberFormat = "$ #.###,00"
                End If
                worksheet.Cells(i + 2, columnIndex + 1).Value = DG_Planilla.Item(j, i).Value
                columnIndex += 1
            Next
        Next
        'Export Each Row End

        'Auto fit columns
        Dim startCell As Excel.Range = CType(worksheet.Cells(1, 1), Excel.Range)
        Dim endCell As Excel.Range = CType(worksheet.Cells(DG_Planilla.Rows.Count + 1, DG_Planilla.Columns.Count), Excel.Range)
        Dim writeRange As Excel.Range = worksheet.Range(startCell, endCell)
        writeRange.Columns.AutoFit()

        APP.DisplayAlerts = False
        workbook.SaveAs(nombreArchivo, Excel.XlFileFormat.xlOpenXMLWorkbook, misValue, misValue, False, False, Excel.XlSaveAsAccessMode.xlNoChange, Excel.XlSaveConflictResolution.xlUserResolution, True, misValue, misValue, misValue)
        APP.DisplayAlerts = True
        workbook.Close(0)
        APP.Workbooks.Close()
        APP.Quit()
        KillExcel()
    End Sub

    Private Sub KillExcel()

        Dim proc As System.Diagnostics.Process
        For Each proc In System.Diagnostics.Process.GetProcessesByName("EXCEL")
            If proc.MainWindowTitle.ToString = "" Then
                proc.Kill()
            End If
        Next

    End Sub

#End Region
End Class