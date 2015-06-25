Imports System.Data.OleDb
Imports Microsoft.Office.Interop
Imports System.Globalization
Public Class frmPlanillaSucursales
    Dim NegMovi As New Negocio.NegMovimientos
    Dim NegSucursal As New Negocio.NegSucursales
    Dim NegVen As New Negocio.NegVentas
    Dim ClsFunciones As New Funciones

#Region "Region de Eventos"
    'Load del Formulario
    Private Sub frmPlanillaSucursales_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            'Cargo el combo con los meses.
            ClsFunciones.CargarComboMeses(Cb_Meses)

            'Cargo el combo con los anios.
            ClsFunciones.CargarComboAnios(Cb_Anios)

            'Cargo el combo con los periodos.
            Cb_Periodo.SelectedItem = "Mes Completo"

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
            Else
                'Limpiar la grilla.
                LimpiarGrilla()

                'Armo el excel
                ConfeccionarExcel()

                'Levanto el excel armado.
                RecuperarExcel()

                'Programo que las columnas no sean 'sorteables'.
                For Each column In DG_Planilla.Columns
                    DG_Planilla.Columns(column.name).SortMode = DataGridViewColumnSortMode.NotSortable
                Next
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Planilla de Movimientos de Sucursales", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Me.Close()
            Me.Dispose()
        End Try

        'Cambio el cursor.
        Me.Cursor = Cursors.Arrow
    End Sub

    'Evento click del boton que permite guardar la planilla.
    Private Sub Btn_Excel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_Excel.Click
        'Si no se genero una plantilla de excel lo informo.
        If Not System.IO.File.Exists(Application.StartupPath & "\planilla.xls") Then
            MessageBox.Show("No se ha encontrado una planilla de excel para exportar. Por favor, intente más tarde.", "Planilla de Movimientos de Sucursales", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        Else
            Try
                Dim DialogSave As New SaveFileDialog()

                ' Extension por defecto
                DialogSave.DefaultExt = "xls"

                ' Extensiones disponibles
                DialogSave.Filter = "Microsoft Excel (*.xls)|*.xls | All files (*.*)|*.*"
                DialogSave.FileName = "planilla"

                'Anadir extension en cas de que el usuario no lo haga
                DialogSave.AddExtension = True

                ' Restaura el directosio selectionado la proxima vez
                DialogSave.RestoreDirectory = True

                ' Titulo de la ventana
                DialogSave.Title = "¿Dónde desea guardar la planilla de movimientos de sucursales?"

                ' Directorio donde compenzar a buscar
                DialogSave.InitialDirectory = "C:/"

                If DialogSave.ShowDialog() = DialogResult.OK Then
                    FileCopy(Application.StartupPath & "\planilla.xls", DialogSave.FileName)
                    If System.IO.File.Exists(DialogSave.FileName) Then
                        MessageBox.Show("La planilla ha sido guardada correctamente.", "Planilla de Movimientos de Sucursales", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Else
                        MessageBox.Show("La planilla no ha sido guardada.", "Planilla de Movimientos de Sucursales", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    End If
                End If

                DialogSave.Dispose()
                DialogSave = Nothing

            Catch ex As Exception
                MessageBox.Show(ex.Message.ToString, "Planilla de Movimientos de Sucursales", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End Try
        End If
    End Sub
#End Region

#Region "Region de Funciones que arman y muestran la planilla"
    Private Sub ConfeccionarExcel()
        'Declare
        Dim xlApp As Excel.Application
        Dim xlWorkBook As Excel.Workbook
        Dim xlWorkSheet As Excel.Worksheet
        Dim anio As Integer = Cb_Anios.SelectedItem
        Dim mes As Integer = ClsFunciones.ObtenerNumeroMes(Cb_Meses.SelectedItem)
        Dim periodo As Integer = ClsFunciones.ObtenerNumeroPeriodo(Cb_Periodo.SelectedItem)
        Dim FinPeriodo As Integer
        Dim InicioPeriodo As Integer
        Dim inicio As Integer = 0
        Dim TotEgresos As Integer = 0
        Dim TotImpuestos As Integer = 0
        Dim totCaja As Integer = 0
        Dim TotGastos As Integer = 0
        Dim TotRetiros As Integer = 0
        Dim TotIngresos As Integer = 0
        Dim DsEgreso As New DataSet
        Dim DsGasto As New DataSet
        Dim DsCaja As New DataSet
        Dim DsImpuesto As New DataSet
        Dim DsRetiro As New DataSet
        Dim id_Sucursal As Integer = Cb_Sucursal.SelectedValue

        'bloqueo los controles
        GB_Controles.Enabled = False

        'Muestro el form de espera..
        frmCargadorDeEspera.Show()
        frmCargadorDeEspera.Text = "Generando la planilla de Movimientos de la Sucursal " & DirectCast(Cb_Sucursal.SelectedItem, System.Data.DataRowView).Row.ItemArray(1)
        frmCargadorDeEspera.lbl_Descripcion.Text = "Iniciando... (1/8)"
        frmCargadorDeEspera.BarraProgreso.Minimum = 0
        frmCargadorDeEspera.BarraProgreso.Maximum = 8
        frmCargadorDeEspera.BarraProgreso.Value = 1
        frmCargadorDeEspera.Refresh()

        xlApp = New Excel.Application
        xlWorkBook = xlApp.Workbooks.Add()
        xlWorkSheet = xlWorkBook.Worksheets(1)

        '------------------------------------------Estilos para el excel------------------------------------------'
        Dim EstiloEncabezado As Microsoft.Office.Interop.Excel.Style
        EstiloEncabezado = xlWorkBook.Styles.Add("EstiloEncabezado")
        EstiloEncabezado.Font.Bold = True
        EstiloEncabezado.Font.Color = System.Drawing.ColorTranslator.ToOle(System.Drawing.Color.White)
        EstiloEncabezado.Font.Size = 11
        EstiloEncabezado.Font.Name = "Arial"
        EstiloEncabezado.Interior.Color = System.Drawing.ColorTranslator.ToOle(System.Drawing.Color.DarkGreen)
        EstiloEncabezado.Interior.Pattern = Microsoft.Office.Interop.Excel.XlPattern.xlPatternSolid

        Dim EstiloCategoria As Microsoft.Office.Interop.Excel.Style
        EstiloCategoria = xlWorkBook.Styles.Add("EstiloCategoria")
        EstiloCategoria.Font.Bold = True
        EstiloCategoria.Font.Color = System.Drawing.ColorTranslator.ToOle(System.Drawing.Color.Black)
        EstiloCategoria.Font.Size = 11
        EstiloCategoria.Font.Name = "Arial"
        EstiloCategoria.Font.Underline = True

        Dim EstiloCuerpo As Microsoft.Office.Interop.Excel.Style
        EstiloCuerpo = xlWorkBook.Styles.Add("EstiloCuerpo")
        EstiloCuerpo.Font.Bold = False
        EstiloCuerpo.Font.Color = System.Drawing.ColorTranslator.ToOle(System.Drawing.Color.Black)
        EstiloCuerpo.Font.Size = 10
        EstiloCuerpo.Font.Name = "Arial"
        EstiloCuerpo.Font.Underline = False
        '------------------------------------------Estilos para el excel------------------------------------------'

        '------------------------------------------Consulto la cantidad de Movimientos----------------------------'
        'Ingresos
        Dim VectorIngresos As New Collection
        VectorIngresos.Add("Caja Inicial", 1)
        VectorIngresos.Add("Ventas Mayoristas", 2)
        VectorIngresos.Add("Ventas Minoristas", 3)
        VectorIngresos.Add("Ventas Facturadas", 4)
        VectorIngresos.Add("Ventas con Tarjeta de Crédito", 5)
        VectorIngresos.Add("Ventas Totales", 6)
        VectorIngresos.Add("Efectivo desde otra sucursal", 7)
        TotIngresos = VectorIngresos.Count

        'Consulta - Gastos.
        DsGasto = NegMovi.ListadoTiposMov(1)
        TotGastos = DsGasto.Tables(0).Rows.Count

        'Consulta - Egresos.
        DsEgreso = NegMovi.ListadoTiposMov(2)
        TotEgresos = DsEgreso.Tables(0).Rows.Count

        'Consulta - Impuestos.
        DsImpuesto = NegMovi.ListadoTiposMov(3)
        TotImpuestos = DsImpuesto.Tables(0).Rows.Count

        'Consulta - Diferencia de Cajas.
        DsCaja = NegMovi.ListadoTiposMov(4)
        totCaja = DsCaja.Tables(0).Rows.Count

        'Consulta - Retiro de Socios.
        DsRetiro = NegMovi.ListadoTiposMov(5)
        TotRetiros = DsRetiro.Tables(0).Rows.Count
        '------------------------------------------Consulto la cantidad de Movimientos----------------------------'

        'Si se genero una plantilla de excel, primero la borro.
        If System.IO.File.Exists(Application.StartupPath & "\planilla.xls") Then
            System.IO.File.Delete(Application.StartupPath & "\planilla.xls")
        End If

        'Dependiendo del periodo, establezco el rango.
        If periodo = 0 Then
            InicioPeriodo = 1
            FinPeriodo = Date.DaysInMonth(anio, mes)
        ElseIf periodo = 1 Then
            InicioPeriodo = 1
            FinPeriodo = 15
        Else
            InicioPeriodo = Date.DaysInMonth(anio, mes) - 15
            FinPeriodo = Date.DaysInMonth(anio, mes)
        End If

        'Comienzo a formatear el excel.
        xlWorkSheet.Cells.Style = "EstiloCuerpo"

        xlWorkSheet.Cells(1, 1) = "Tipo/Día"
        xlWorkSheet.Cells(1, 1).style = "EstiloEncabezado"

        xlWorkSheet.Cells(1, 2) = "Mensual"
        xlWorkSheet.Cells(1, 2).style = "EstiloEncabezado"

        '------------------------------------------INGRESOS------------------------------------------------------'
        'Voy seteando la barra de progreso
        frmCargadorDeEspera.lbl_Descripcion.Text = "Calculando ingresos... (2/8)"
        frmCargadorDeEspera.BarraProgreso.Value = 2
        frmCargadorDeEspera.Refresh()

        xlWorkSheet.Cells(2, 1) = "INGRESOS"
        xlWorkSheet.Cells(2, 1).style = "EstiloCategoria"

        Dim ComienzoIngreso As Integer = 2
        Dim CostoTotalIngreso As Double = 0
        For w = 1 To TotIngresos

            Dim wds As Integer = (w - 1)
            xlWorkSheet.Cells(ComienzoIngreso + w, 1) = VectorIngresos.Item(w).ToString()

            '-----Completo los valores de los mov por dia-----
            ' Dim FDesde As String = mes & "/" & InicioPeriodo & "/" & anio
            '  Dim FHasta As String = mes & "/" & FinPeriodo & "/" & anio
            '  Dim id_Tipo As Integer = DsGasto.Tables(0).Rows(wds).Item(0).ToString()
            '  Dim HayMovimientos As Integer = NegMovi.ConsultarMovimiento(id_Sucursal, FDesde, FHasta, 1, id_Tipo)
            Dim HayMovimientos As Integer = 1

            Dim CostoTotal As Double = 0
            For i = InicioPeriodo To FinPeriodo
                inicio = (i - InicioPeriodo) + 1
                'Se obtiene la suma del dia y se coloca en la celda.
                Dim Fecha As String = mes & "/" & i & "/" & anio
                Dim Costo As Double = 0

                If HayMovimientos = 1 Then
                    If w = 1 Then
                        Dim entCaja As New Entidades.CajaInicial
                        Dim NegCaja As New Negocio.NegCajaInicial
                        entCaja = NegCaja.ObtenerCaja(id_Sucursal, Fecha)
                        If entCaja.id_Caja > 0 Then
                            Costo = entCaja.Monto
                        Else
                            Costo = 0
                        End If
                    ElseIf w = 2 Then
                        Costo = NegVen.TotalVentasMayoristas(id_Sucursal, Fecha)
                    ElseIf w = 3 Then
                        Costo = NegVen.TotalVentasMinoristas(id_Sucursal, Fecha)
                    ElseIf w = 4 Then
                        Costo = NegVen.TotalVentasFacturado(id_Sucursal, Fecha)
                    ElseIf w = 5 Then
                        Costo = NegVen.TotalVentasTarjetas(id_Sucursal, Fecha)
                    ElseIf w = 6 Then
                        Costo = NegVen.TotalVentas(id_Sucursal, Fecha)
                    ElseIf w = 7 Then
                        Costo = NegMovi.ObtenerTotalMovEgreso(id_Sucursal, Fecha, Fecha, "Ingresos")
                    End If

                Else
                    Costo = 0
                End If

                    If Costo > 0 Then
                        xlWorkSheet.Cells(ComienzoIngreso + w, (inicio + 2)) = "$ " & Format(CType(Costo, Decimal), "###0.00")
                    Else
                        xlWorkSheet.Cells(ComienzoIngreso + w, (inicio + 2)) = "-"
                    End If

                    'Se incrementa el subtotal.
                    CostoTotal += Costo

            Next

            'Se coloca el subtotal en la celda.
            If CostoTotal > 0 Then
                xlWorkSheet.Cells(ComienzoIngreso + w, 2) = "$ " & Format(CType(CostoTotal, Decimal), "###0.00")
            Else
                xlWorkSheet.Cells(ComienzoIngreso + w, 2) = "-"
            End If

            'Se incrementa el subtotal de los ingresos.
            If w = 4 Then
                CostoTotalIngreso += CostoTotal
            End If
            '-----Completo los valores de los mov por dia-----

        Next

        If CostoTotalIngreso > 0 Then
            xlWorkSheet.Cells(2, 2) = "$ " & Format(CType(CostoTotalIngreso, Decimal), "###0.00")
        Else
            xlWorkSheet.Cells(2, 2) = "-"
        End If

        '------------------------------------------INGRESOS------------------------------------------------------'

        '------------------------------------------GASTOS--------------------------------------------------------'
        'Voy seteando la barra de progreso
        frmCargadorDeEspera.lbl_Descripcion.Text = "Calculando gastos... (3/8)"
        frmCargadorDeEspera.BarraProgreso.Value = 2
        frmCargadorDeEspera.Refresh()


        xlWorkSheet.Cells((ComienzoIngreso + TotIngresos + 1), 1) = ""
        xlWorkSheet.Cells((ComienzoIngreso + TotIngresos + 2), 1) = "GASTOS"
        xlWorkSheet.Cells((ComienzoIngreso + TotIngresos + 2), 1).style = "EstiloCategoria"

        Dim ComienzoGasto As Integer = ComienzoIngreso + TotIngresos + 2
        Dim CostoTotalGasto As Double = 0
        For w = 1 To TotGastos

            Dim wds As Integer = (w - 1)
            xlWorkSheet.Cells(ComienzoGasto + w, 1) = DsGasto.Tables(0).Rows(wds).Item("Tipo").ToString()

            '-----Completo los valores de los mov por dia-----
            Dim FDesde As String = mes & "/" & InicioPeriodo & "/" & anio
            Dim FHasta As String = mes & "/" & FinPeriodo & "/" & anio
            Dim id_Tipo As Integer = DsGasto.Tables(0).Rows(wds).Item(0).ToString()
            Dim HayMovimientos As Integer = NegMovi.ConsultarMovimiento(id_Sucursal, FDesde, FHasta, 1, id_Tipo)

            Dim CostoTotal As Double = 0
            For i = InicioPeriodo To FinPeriodo
                inicio = (i - InicioPeriodo) + 1
                'Se obtiene la suma del dia y se coloca en la celda.
                Dim Fecha As String = mes & "/" & i & "/" & anio
                Dim Costo As Double = 0

                If HayMovimientos = 1 Then
                    Costo = NegMovi.ObtenerMovimiento(id_Sucursal, Fecha, 1, id_Tipo)
                Else
                    Costo = 0
                End If

                If Costo > 0 Then
                    xlWorkSheet.Cells(ComienzoGasto + w, (inicio + 2)) = "$ " & Format(CType(Costo, Decimal), "###0.00")
                Else
                    xlWorkSheet.Cells(ComienzoGasto + w, (inicio + 2)) = "-"
                End If

                'Se incrementa el subtotal.
                CostoTotal += Costo
            Next

            'Se coloca el subtotal en la celda.
            If CostoTotal > 0 Then
                xlWorkSheet.Cells(ComienzoGasto + w, 2) = "$ " & Format(CType(CostoTotal, Decimal), "###0.00")
            Else
                xlWorkSheet.Cells(ComienzoGasto + w, 2) = "-"
            End If

            'Se incrementa el subtotal de los ingresos.
            CostoTotalGasto += CostoTotal
            '-----Completo los valores de los mov por dia-----

        Next

        If CostoTotalGasto > 0 Then
            xlWorkSheet.Cells(ComienzoIngreso + TotIngresos + 2, 2) = "$ " & Format(CType(CostoTotalGasto, Decimal), "###0.00")
        Else
            xlWorkSheet.Cells(ComienzoIngreso + TotIngresos + 2, 2) = "-"
        End If

        '------------------------------------------GASTOS--------------------------------------------------------'

        '------------------------------------------EGRESOS-------------------------------------------------------'
        'Voy seteando la barra de progreso
        frmCargadorDeEspera.lbl_Descripcion.Text = "Calculando egresos... (4/8)"
        frmCargadorDeEspera.BarraProgreso.Value = 3
        frmCargadorDeEspera.Refresh()

        xlWorkSheet.Cells((ComienzoGasto + TotGastos + 1), 1) = ""
        xlWorkSheet.Cells((ComienzoGasto + TotGastos + 2), 1) = "EGRESOS"
        xlWorkSheet.Cells((ComienzoGasto + TotGastos + 2), 1).style = "EstiloCategoria"

        Dim ComienzoEgreso As Integer = ComienzoGasto + TotGastos + 2
        Dim CostoTotalEgreso As Double = 0
        For e = 1 To TotEgresos

            Dim eds As Integer = (e - 1)
            xlWorkSheet.Cells(ComienzoEgreso + e, 1) = DsEgreso.Tables(0).Rows(eds).Item("Tipo").ToString()

            '-----Completo los valores de los mov por dia-----
            Dim FDesde As String = mes & "/" & InicioPeriodo & "/" & anio
            Dim FHasta As String = mes & "/" & FinPeriodo & "/" & anio
            Dim id_Tipo As Integer = DsEgreso.Tables(0).Rows(eds).Item(0).ToString()
            Dim HayMovimientos As Integer = NegMovi.ConsultarMovimiento(id_Sucursal, FDesde, FHasta, 2, id_Tipo)

            Dim CostoTotal As Double = 0
            For i = InicioPeriodo To FinPeriodo
                inicio = (i - InicioPeriodo) + 1
                'Se obtiene la suma del dia y se coloca en la celda.
                Dim Fecha As String = mes & "/" & i & "/" & anio
                Dim Costo As Double = 0

                If HayMovimientos = 1 Then
                    Costo = NegMovi.ObtenerMovimiento(id_Sucursal, Fecha, 2, id_Tipo)
                Else
                    Costo = 0
                End If

                If Costo > 0 Then
                    xlWorkSheet.Cells(ComienzoEgreso + e, (inicio + 2)) = "$ " & Format(CType(Costo, Decimal), "###0.00")
                Else
                    xlWorkSheet.Cells(ComienzoEgreso + e, (inicio + 2)) = "-"
                End If

                'Se incrementa el subtotal.
                CostoTotal += Costo
            Next

            'Se coloca el subtotal en la celda.
            If CostoTotal > 0 Then
                xlWorkSheet.Cells(ComienzoEgreso + e, 2) = "$ " & Format(CType(CostoTotal, Decimal), "###0.00")
            Else
                xlWorkSheet.Cells(ComienzoEgreso + e, 2) = "-"
            End If

            'Se incrementa el subtotal de los ingresos.
            CostoTotalEgreso += CostoTotal
            '-----Completo los valores de los mov por dia-----

        Next

        If CostoTotalEgreso > 0 Then
            xlWorkSheet.Cells((ComienzoGasto + TotGastos + 2), 2) = "$ " & Format(CType(CostoTotalEgreso, Decimal), "###0.00")
        Else
            xlWorkSheet.Cells((ComienzoGasto + TotGastos + 2), 2) = "-"
        End If
        '------------------------------------------EGRESOS-------------------------------------------------------'

        '------------------------------------------IMPUESTOS-----------------------------------------------------'
        'Voy seteando la barra de progreso
        frmCargadorDeEspera.lbl_Descripcion.Text = "Calculando impuestos... (5/8)"
        frmCargadorDeEspera.BarraProgreso.Value = 4
        frmCargadorDeEspera.Refresh()

        xlWorkSheet.Cells((ComienzoEgreso + TotEgresos + 1), 1) = ""
        xlWorkSheet.Cells((ComienzoEgreso + TotEgresos + 2), 1) = "IMPUESTOS"
        xlWorkSheet.Cells((ComienzoEgreso + TotEgresos + 2), 1).style = "EstiloCategoria"

        Dim ComienzoImpuestos As Integer = ComienzoEgreso + TotEgresos + 2
        Dim CostoTotalImpuesto As Double = 0
        For q = 1 To TotImpuestos

            Dim qds As Integer = (q - 1)
            xlWorkSheet.Cells(ComienzoImpuestos + q, 1) = DsImpuesto.Tables(0).Rows(qds).Item("Tipo").ToString()

            '-----Completo los valores de los mov por dia-----
            Dim FDesde As String = mes & "/" & InicioPeriodo & "/" & anio
            Dim FHasta As String = mes & "/" & FinPeriodo & "/" & anio
            Dim id_Tipo As Integer = DsImpuesto.Tables(0).Rows(qds).Item(0).ToString()
            Dim HayMovimientos As Integer = NegMovi.ConsultarMovimiento(id_Sucursal, FDesde, FHasta, 3, id_Tipo)

            Dim CostoTotal As Double = 0
            For i = InicioPeriodo To FinPeriodo
                inicio = (i - InicioPeriodo) + 1
                'Se obtiene la suma del dia y se coloca en la celda.
                Dim Fecha As String = mes & "/" & i & "/" & anio
                Dim Costo As Double = 0

                If HayMovimientos = 1 Then
                    Costo = NegMovi.ObtenerMovimiento(id_Sucursal, Fecha, 3, id_Tipo)
                Else
                    Costo = 0
                End If

                If Costo > 0 Then
                    xlWorkSheet.Cells(ComienzoImpuestos + q, (inicio + 2)) = "$ " & Format(CType(Costo, Decimal), "###0.00")
                Else
                    xlWorkSheet.Cells(ComienzoImpuestos + q, (inicio + 2)) = "-"
                End If

                'Se incrementa el subtotal.
                CostoTotal += Costo
            Next

            'Se coloca el subtotal en la celda.
            If CostoTotal > 0 Then
                xlWorkSheet.Cells(ComienzoImpuestos + q, 2) = "$ " & Format(CType(CostoTotal, Decimal), "###0.00")
            Else
                xlWorkSheet.Cells(ComienzoImpuestos + q, 2) = "-"
            End If

            'Se incrementa el subtotal de los ingresos.
            CostoTotalImpuesto += CostoTotal
            '-----Completo los valores de los mov por dia-----
        Next

        If CostoTotalImpuesto > 0 Then
            xlWorkSheet.Cells((ComienzoEgreso + TotEgresos + 2), 2) = "$ " & Format(CType(CostoTotalImpuesto, Decimal), "###0.00")
        Else
            xlWorkSheet.Cells((ComienzoEgreso + TotEgresos + 2), 2) = "-"
        End If
        '------------------------------------------IMPUESTOS-----------------------------------------------------'

        '------------------------------------------DIFERENCIAS DE CAJA-------------------------------------------'
        'Voy seteando la barra de progreso
        frmCargadorDeEspera.lbl_Descripcion.Text = "Calculando diferencias de caja... (6/8)"
        frmCargadorDeEspera.BarraProgreso.Value = 5
        frmCargadorDeEspera.Refresh()

        xlWorkSheet.Cells((ComienzoImpuestos + TotImpuestos + 1), 1) = ""
        xlWorkSheet.Cells((ComienzoImpuestos + TotImpuestos + 2), 1) = "DIFERENCIA DE CAJA"
        xlWorkSheet.Cells((ComienzoImpuestos + TotImpuestos + 2), 1).style = "EstiloCategoria"

        Dim ComienzoCaja As Integer = ComienzoImpuestos + TotImpuestos + 2
        Dim CostoTotalCaja As Double = 0
        For r = 1 To totCaja

            Dim rds As Integer = (r - 1)
            xlWorkSheet.Cells(ComienzoCaja + r, 1) = DsCaja.Tables(0).Rows(rds).Item("Tipo").ToString()

            Dim FDesde As String = mes & "/" & InicioPeriodo & "/" & anio
            Dim FHasta As String = mes & "/" & FinPeriodo & "/" & anio
            Dim id_Tipo As Integer = DsCaja.Tables(0).Rows(rds).Item(0).ToString()
            Dim HayMovimientos As Integer = NegMovi.ConsultarMovimiento(id_Sucursal, FDesde, FHasta, 4, id_Tipo)

            '-----Completo los valores de los mov por dia-----
            Dim CostoTotal As Double = 0
            For i = InicioPeriodo To FinPeriodo
                inicio = (i - InicioPeriodo) + 1
                'Se obtiene la suma del dia y se coloca en la celda.
                Dim Fecha As String = mes & "/" & i & "/" & anio
                Dim Costo As Double = 0

                If HayMovimientos = 1 Then
                    Costo = NegMovi.ObtenerMovimiento(id_Sucursal, Fecha, 4, id_Tipo)
                Else
                    Costo = 0
                End If

                If Costo > 0 Then
                    xlWorkSheet.Cells(ComienzoCaja + r, (inicio + 2)) = "$ " & Format(CType(Costo, Decimal), "###0.00")
                Else
                    xlWorkSheet.Cells(ComienzoCaja + r, (inicio + 2)) = "-"
                End If

                'Se incrementa el subtotal.
                CostoTotal += Costo
            Next

            'Se coloca el subtotal en la celda.
            If CostoTotal > 0 Then
                xlWorkSheet.Cells(ComienzoCaja + r, 2) = "$ " & Format(CType(CostoTotal, Decimal), "###0.00")
            Else
                xlWorkSheet.Cells(ComienzoCaja + r, 2) = "-"
            End If

            'Se incrementa el subtotal de los ingresos.
            CostoTotalCaja += CostoTotal
            '-----Completo los valores de los mov por dia-----
        Next

        If CostoTotalCaja > 0 Then
            xlWorkSheet.Cells((ComienzoImpuestos + TotImpuestos + 2), 2) = "$ " & Format(CType(CostoTotalCaja, Decimal), "###0.00")
        Else
            xlWorkSheet.Cells((ComienzoImpuestos + TotImpuestos + 2), 2) = "-"
        End If
        '------------------------------------------DIFERENCIAS DE CAJA-------------------------------------------'

        '------------------------------------------RETIROS DE SOCIO----------------------------------------------'
        'Voy seteando la barra de progreso
        frmCargadorDeEspera.lbl_Descripcion.Text = "Calculando retiros de socio... (7/8)"
        frmCargadorDeEspera.BarraProgreso.Value = 6
        frmCargadorDeEspera.Refresh()

        xlWorkSheet.Cells((ComienzoCaja + totCaja + 1), 1) = ""
        xlWorkSheet.Cells((ComienzoCaja + totCaja + 2), 1) = "RETIROS DE SOCIOS"
        xlWorkSheet.Cells((ComienzoCaja + totCaja + 2), 1).style = "EstiloCategoria"

        Dim ComienzoRetiros As Integer = ComienzoCaja + totCaja + 2
        Dim CostoTotalRetiro As Double = 0
        For r = 1 To TotRetiros

            Dim rds As Integer = (r - 1)
            xlWorkSheet.Cells(ComienzoRetiros + r, 1) = DsRetiro.Tables(0).Rows(rds).Item("Tipo").ToString()

            Dim FDesde As String = mes & "/" & InicioPeriodo & "/" & anio
            Dim FHasta As String = mes & "/" & FinPeriodo & "/" & anio
            Dim id_Tipo As Integer = DsRetiro.Tables(0).Rows(rds).Item(0).ToString()
            Dim HayMovimientos As Integer = NegMovi.ConsultarMovimiento(id_Sucursal, FDesde, FHasta, 5, id_Tipo)

            '-----Completo los valores de los mov por dia-----
            Dim CostoTotal As Double = 0
            For i = InicioPeriodo To FinPeriodo
                inicio = (i - InicioPeriodo) + 1
                'Se obtiene la suma del dia y se coloca en la celda.
                Dim Fecha As String = mes & "/" & i & "/" & anio
                Dim Costo As Double = 0

                If HayMovimientos = 1 Then
                    Costo = NegMovi.ObtenerMovimiento(id_Sucursal, Fecha, 5, id_Tipo)
                Else
                    Costo = 0
                End If

                If Costo > 0 Then
                    xlWorkSheet.Cells(ComienzoRetiros + r, (inicio + 2)) = "$ " & Format(CType(Costo, Decimal), "###0.00")
                Else
                    xlWorkSheet.Cells(ComienzoRetiros + r, (inicio + 2)) = "-"
                End If

                'Se incrementa el subtotal.
                CostoTotal += Costo
            Next

            'Se coloca el subtotal en la celda.
            If CostoTotal > 0 Then
                xlWorkSheet.Cells(ComienzoRetiros + r, 2) = "$ " & Format(CType(CostoTotal, Decimal), "###0.00")
            Else
                xlWorkSheet.Cells(ComienzoRetiros + r, 2) = "-"
            End If

            'Se incrementa el subtotal de los ingresos.
            CostoTotalRetiro += CostoTotal
            '-----Completo los valores de los mov por dia-----
        Next

        If CostoTotalRetiro > 0 Then
            xlWorkSheet.Cells((ComienzoCaja + totCaja + 2), 2) = "$ " & Format(CType(CostoTotalRetiro, Decimal), "###0.00")
        Else
            xlWorkSheet.Cells((ComienzoCaja + totCaja + 2), 2) = "-"
        End If
        '------------------------------------------RETIROS DE SOCIO----------------------------------------------'

        'Voy seteando la barra de progreso
        frmCargadorDeEspera.lbl_Descripcion.Text = "Confeccionando planilla... (8/8)"
        frmCargadorDeEspera.BarraProgreso.Value = 7
        frmCargadorDeEspera.Refresh()

        'Armo la cabecera con los dias de la semana del rango seleccionado.
        For i = InicioPeriodo To FinPeriodo
            inicio = (i - InicioPeriodo) + 1
            Dim dateValue As Date = i & "/" & mes & "/" & anio
            xlWorkSheet.Cells(1, (inicio + 2)) = i & "º " & dateValue.ToString("dddd", New CultureInfo("es-ES"))
            xlWorkSheet.Cells(1, (inicio + 2)).style = "EstiloEncabezado"
        Next

        'Ajusto las columnas dependiendo de las celdas.
        xlWorkSheet.Columns.AutoFit()

        'Almaceno el excel.
        xlApp.DisplayAlerts = False
        xlWorkBook.SaveAs(Application.StartupPath & "\planilla.xls", Excel.XlFileFormat.xlExcel8)
        xlWorkBook.Close()
        xlApp.DisplayAlerts = True
        xlApp.Quit()

        'Limpio las variables utilizadas.
        ClsFunciones.releaseObject(xlApp)
        ClsFunciones.releaseObject(xlWorkBook)
        ClsFunciones.releaseObject(xlWorkSheet)

        'Voy seteando la barra de progreso
        frmCargadorDeEspera.Close()
        frmCargadorDeEspera.Dispose()

        'bloqueo los controles
        GB_Controles.Enabled = True

    End Sub

    Private Sub RecuperarExcel()
        Try
            'Levanto el excel armado.
            Dim strconn As String
            Dim dt As New DataTable
            Dim ObjExcel As Excel.Application
            Dim ObjW As Excel.Workbook
            Dim Hoja As String = "Hoja1"
            ObjExcel = New Excel.Application
            ObjW = ObjExcel.Workbooks.Open(Application.StartupPath & "\planilla.xls")

            'Objeto el nombre de la hoja.
            If ObjW.Sheets(1).Name <> "" Then
                Hoja = ObjW.Sheets(1).Name
            End If

            'Elimino los objetos.
            ObjW.Close()
            ObjExcel.Quit()
            ClsFunciones.releaseObject(ObjExcel)
            ClsFunciones.releaseObject(ObjW)

            strconn = "Provider=Microsoft.Jet.Oledb.4.0; data source= " & Application.StartupPath & "\planilla.xls;Extended properties=""Excel 8.0;hdr=yes;imex=1"""
            Dim mconn As New OleDbConnection(strconn)
            Dim ad As New OleDbDataAdapter("Select * from [" & Hoja & "$]", mconn)
            mconn.Open()
            ad.Fill(dt)
            mconn.Close()
            DG_Planilla.DataSource = dt

            'Seteo el estilo de la cabecera.
            DG_Planilla.ColumnHeadersVisible = True
            Dim columnHeaderStyle As New DataGridViewCellStyle()
            columnHeaderStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            columnHeaderStyle.Font = New Font("Verdana", 10, FontStyle.Bold)
            DG_Planilla.ColumnHeadersDefaultCellStyle = columnHeaderStyle
            DG_Planilla.AutoResizeColumnHeadersHeight()
            DG_Planilla.AutoResizeRows(DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders)
            DG_Planilla.Columns(0).Frozen = True
        Catch ex As Exception
            frmCargadorDeEspera.Close()
            frmCargadorDeEspera.Dispose()
            MessageBox.Show(ex.Message, "Planilla de Movimientos de Sucursales", MessageBoxButtons.OK, MessageBoxIcon.Error)            
        End Try
    End Sub

    Private Sub LimpiarGrilla()
        DG_Planilla.DataSource = Nothing
        DG_Planilla.Rows.Clear()
    End Sub
#End Region

End Class