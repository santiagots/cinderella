Imports Negocio
Imports Microsoft.Office.Interop

Public Class frmControladorFiscal

    Private ControladorFiscal As NegControladorFiscal

    Dim negFactuarcion As Negocio.NegFacturacion

    Private Sub frmControladorFiscal_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Cursor = Cursors.WaitCursor
        Try
            EvaluarPermisos()
            negFactuarcion = New NegFacturacion()
            ControladorFiscal = New NegControladorFiscal(My.Settings("ConexionControladora").ToString())
        Catch ex As Exception
            lblEstado.Text = "Error Inicialización"
            MessageBox.Show("Se ha producido un error al inicializar la controladora fiscal. Por favor, vuelva a intentar más tarde o contáctese con el Administrador.", "Controlador Fiscal", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Me.Cursor = Cursors.Arrow
        End Try
        Me.Cursor = Cursors.Arrow
    End Sub

    Private Sub btnCierreX_Click(sender As Object, e As EventArgs) Handles btnCierreZPorFecha.Click
        Me.Cursor = Cursors.WaitCursor
        Try
            lblEstado.Text = "Imprimiendo cierre Z por rango de fechas"
            ControladorFiscal.AbrirPuerto()
            ControladorFiscal.CierreZPorRangoDeFecha(FDesdeCierreZ.Value.Date, FHastaCierreZ.Value.Date, My.Settings.ControladorModelo)
            ControladorFiscal.CerrarPuerto()
            lblEstado.Text = "- - - -"
        Catch ex As Exception
            lblEstado.Text = "Error en imprecion cierre z por rango de fechas"
            MessageBox.Show("Se ha producido un error al imprimir el cierre z por rango de fechas. Por favor, vuelva a intentar más tarde o contáctese con el Administrador.", "Controlador Fiscal", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Me.Cursor = Cursors.Arrow
        End Try
        Me.Cursor = Cursors.Arrow
    End Sub

    Private Sub btnCierreZ_Click(sender As Object, e As EventArgs) Handles btnCierreZ.Click
        Me.Cursor = Cursors.WaitCursor
        Try
            lblEstado.Text = "Imprimiendo cierre Z"
            ControladorFiscal.AbrirPuerto()
            ControladorFiscal.CierreZ(My.Settings.ControladorModelo)
            ControladorFiscal.CerrarPuerto()
            lblEstado.Text = "- - - -"
        Catch ex As Exception
            lblEstado.Text = "Error en impresión cierre z"
            MessageBox.Show("Se ha producido un error al imprimir el cierre Z. Por favor, vuelva a intentar más tarde o contáctese con el Administrador.", "Controlador Fiscal", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Me.Cursor = Cursors.Arrow
        End Try
        Me.Cursor = Cursors.Arrow
    End Sub

    Private Sub BtnFiltrar_Click(sender As Object, e As EventArgs) Handles BtnFiltrar.Click
        Me.Cursor = Cursors.WaitCursor
        Try
            Dim Facturas As List(Of Entidades.Facturacion) = negFactuarcion.ListadoTicketControladorFiscal("A", My.Settings.Sucursal, FDesde.Value.ToString("yyyy/MM/dd"), FHasta.Value.ToString("yyyy/MM/dd"))
            If (Facturas.Count > 0) Then
                FacturacionBindingSource.DataSource = Facturas
                lbl_Msg.Visible = False
            Else
                lbl_Msg.Visible = True
            End If
            Me.Cursor = Cursors.Arrow
        Catch ex As Exception
            MessageBox.Show("Se ha producido al recuperar la informacion de las facturas. Por favor, vuelva a intentar más tarde o contáctese con el Administrador.", "Controlador Fiscal", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Me.Cursor = Cursors.Arrow
        End Try
    End Sub

    Private Sub btn_Exportar_Click(sender As Object, e As EventArgs) Handles btn_Exportar.Click
        Try
            'Configuro la pantalla de guardado de archivos
            SaveFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments)
            SaveFileDialog.FileName = "Tickets"
            SaveFileDialog.Filter = "Excel Files|*.xlsx;"

            If SaveFileDialog.ShowDialog() = DialogResult.OK Then
                'Cambio el cursor a "WAIT"
                Me.Cursor = Cursors.WaitCursor

                frmCargadorDeEspera.Show()
                frmCargadorDeEspera.Text = "Generando Exportación a Excel "
                frmCargadorDeEspera.lbl_Descripcion.Text = "iniciando..."
                frmCargadorDeEspera.BarraProgreso.Minimum = 0
                frmCargadorDeEspera.BarraProgreso.Maximum = 7
                frmCargadorDeEspera.BarraProgreso.Value = 1
                frmCargadorDeEspera.Refresh()

                'Exporto el listado de productos a Excel
                ExportarAExcel(SaveFileDialog.FileName)

                'Voy seteando la barra de progreso
                frmCargadorDeEspera.Close()
                frmCargadorDeEspera.Dispose()

                'Cambio el cursor a "NORMAL"
                Me.Cursor = Cursors.Arrow

                'si no completo la descripcion, muestro un msg de error.
                MessageBox.Show("Se ha exportado el listado de productos de forma exitosa", "Administración de Productos", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If

        Catch ex As Exception
            'Voy seteando la barra de progreso
            frmCargadorDeEspera.Close()
            frmCargadorDeEspera.Dispose()

            'Cambio el cursor a "NORMAL"
            Me.Cursor = Cursors.Arrow
            MessageBox.Show("Se ha producido un error en la exportación de la información. Verifique que el documento no se encuentre en uso o esté abierto. Por favor, intente más tarde.", "Administración de Productos", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
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

        worksheet.Cells(1, 1).Value = "Sucursal:"
        worksheet.Cells(1, 1).style = "EstiloEncabezado"
        worksheet.Cells(1, 2).Value = My.Settings.NombreSucursal
        worksheet.Cells(1, 2).style = "EstiloEncabezado"

        worksheet.Cells(2, 1).Value = "Período:"
        worksheet.Cells(2, 1).style = "EstiloEncabezado"
        worksheet.Cells(2, 2).Value = String.Format("{0} a {1}", FDesde.Value.ToString("yyyy/MM/dd"), FHasta.Value.ToString("yyyy/MM/dd"))
        worksheet.Cells(2, 2).style = "EstiloEncabezado"

        'Export Header Names Start
        Dim columnIndex As Integer = 0
        For j As Integer = 0 To dgTickets.Columns.Count - 1
            worksheet.Cells(4, columnIndex + 1).Value = dgTickets.Columns(j).HeaderText
            worksheet.Cells(4, columnIndex + 1).style = "EstiloEncabezado"
            worksheet.Cells(4, columnIndex + 1).NumberFormat = dgTickets.Columns(j).DefaultCellStyle.Format
            columnIndex += 1
        Next
        'Export Header Name End


        'Export Each Row Start
        For i As Integer = 0 To dgTickets.Rows.Count - 1
            columnIndex = 0
            For j As Integer = 0 To dgTickets.Columns.Count - 1
                worksheet.Cells(i + 5, columnIndex + 1).Value = dgTickets.Item(j, i).Value
                columnIndex += 1
            Next
        Next
        'Export Each Row End

        'Auto fit columns
        Dim startCell As Excel.Range = CType(worksheet.Cells(1, 1), Excel.Range)
        Dim endCell As Excel.Range = CType(worksheet.Cells(dgTickets.Rows.Count + 6, dgTickets.Columns.Count + 1), Excel.Range)
        Dim writeRange As Excel.Range = worksheet.Range(startCell, endCell)
        writeRange.Rows.AutoFit()
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

    Sub EvaluarPermisos()
        If (VariablesGlobales.Patentes.ContainsKey(Entidades.TipoPatente.Sistema_Controlador_Fiscal_EmitirCierreZdía)) Then
            btnCierreZ.Enabled = True
        Else
            btnCierreZ.Enabled = False
        End If

        If (VariablesGlobales.Patentes.ContainsKey(Entidades.TipoPatente.Sistema_Controlador_Fiscal_EmitirCierreZRangoFechas)) Then
            btnCierreZPorFecha.Enabled = True
        Else
            btnCierreZPorFecha.Enabled = False
        End If

        If (VariablesGlobales.Patentes.ContainsKey(Entidades.TipoPatente.Sistema_Controlador_Fiscal_BuscarTickets)) Then
            BtnFiltrar.Enabled = True
        Else
            BtnFiltrar.Enabled = False
        End If

        If (VariablesGlobales.Patentes.ContainsKey(Entidades.TipoPatente.Sistema_Controlador_Fiscal_ExportarTickets)) Then
            btn_Exportar.Enabled = True
        Else
            btn_Exportar.Enabled = False
        End If
    End Sub
End Class