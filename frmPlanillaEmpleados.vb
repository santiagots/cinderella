Imports System.Data.OleDb
Imports Microsoft.Office.Interop
Imports System.Globalization
Imports Entidades

Public Class frmPlanillaEmpleados
    Dim Funciones As New Funciones
    Dim NegSucursal As New Negocio.NegSucursales
    Dim NegEmpleado As New Negocio.NegEmpleados
    Dim NegRegistros As New Negocio.NegRegistros
    Dim NegComision As New Negocio.NegComisiones
    Dim NegAdelanto As New Negocio.NegAdelantos
    Dim NegAdicionales As New Negocio.NegAdicionales
    Dim NegRecibo As New Negocio.NegRecibos
    Dim ClsFunciones As New Funciones

    'Evento click del boton que permite guardar la planilla.
    Private Sub Btn_Excel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_Excel.Click
        'Si no se genero una plantilla de excel lo informo.
        If Not System.IO.File.Exists(Application.StartupPath & "\planilla.xls") Then
            MessageBox.Show("No se ha encontrado una planilla de excel para exportar. Por favor, intente más tarde.", "Planilla de Sueldos de Empleados", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        Else
            Try
                Dim DialogSave As New SaveFileDialog()

                ' Extension por defecto
                DialogSave.DefaultExt = "xls"

                ' Extensiones disponibles
                DialogSave.Filter = "Microsoft Excel (*.xls)|*.xls | All files (*.*)|*.*"
                DialogSave.FileName = "planilla_empleados"

                'Anadir extension en cas de que el usuario no lo haga
                DialogSave.AddExtension = True

                ' Restaura el directosio selectionado la proxima vez
                DialogSave.RestoreDirectory = True

                ' Titulo de la ventana
                DialogSave.Title = "¿Dónde desea guardar la planilla de sueldos de empleados?"

                ' Directorio donde compenzar a buscar
                DialogSave.InitialDirectory = "C:/"

                If DialogSave.ShowDialog() = DialogResult.OK Then
                    FileCopy(Application.StartupPath & "\planilla_empleados.xls", DialogSave.FileName)
                    If System.IO.File.Exists(DialogSave.FileName) Then
                        MessageBox.Show("La planilla ha sido guardada correctamente.", "Planilla de Sueldos de Empleados", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Else
                        MessageBox.Show("La planilla no ha sido guardada.", "Planilla de Sueldos de Empleados", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    End If
                End If
                DialogSave.Dispose()
                DialogSave = Nothing

            Catch ex As Exception
                MessageBox.Show(ex.Message.ToString, "Planilla de Sueldos de Empleados", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End Try
        End If
    End Sub

    'Evento click del boton que filtra la planilla.
    Private Sub btn_Filtrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Filtrar.Click
        'Cambio el cursor.
        Me.Cursor = Cursors.WaitCursor

        Try
            If Cb_Sucursal.SelectedValue Is Nothing Then
                MessageBox.Show("Debe seleccionar una sucursal.", "Planilla de Sueldos de Empleados", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                'Limpiar la grilla.
                LimpiarGrilla()

                'Armo el excel.
                ConfeccionarExcel()

                'Levanto el excel armado.
                RecuperarExcel()

                'Programo que las columnas no sean 'sorteables'.
                For Each column In DG_Planilla.Columns
                    DG_Planilla.Columns(column.name).SortMode = DataGridViewColumnSortMode.NotSortable
                Next
            End If
        Catch ex As Exception
            GB_Controles.Enabled = True
            Me.Cursor = Cursors.Arrow
            MessageBox.Show(ex.Message, "Planilla de Sueldos de Empleados", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Me.Close()
            Me.Dispose()
            frmCargadorDeEspera.Close()
            frmCargadorDeEspera.Dispose()
        End Try

        'Cambio el cursor.
        Me.Cursor = Cursors.Arrow
    End Sub

    'Load del Formulario
    Private Sub frmPlanillaEmpleados_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
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

            If (Not Negocio.Funciones.HayInternet) Then
                Cb_Sucursal.Enabled = False
            End If

            'Limpiar la grilla.
            LimpiarGrilla()

            'Maximizo el form.
            Me.WindowState = 2

            EvaluarPermisos()

        Catch ex As Exception
            GB_Controles.Enabled = True
            frmCargadorDeEspera.Close()
            frmCargadorDeEspera.Dispose()
            MessageBox.Show(ex.Message, "Planilla de Sueldos de Empleados", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

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
        Dim id_Sucursal As Integer = Cb_Sucursal.SelectedValue
        Dim TotalPresentismo As Double = 0
        Dim TotalComisiones As Double = 0
        Dim TotalSueldos As Double = 0
        Dim TotalVacaciones As Double = 0
        Dim TotalAguinaldos As Double = 0

        'bloqueo los controles
        GB_Controles.Enabled = False

        'Obtengo los empleados
        Dim TotEmpleados As Integer = 0
        Dim dsEmpleados As New DataSet
        dsEmpleados = NegEmpleado.ListadoEmpleadosSucursal(id_Sucursal)
        TotEmpleados = dsEmpleados.Tables(0).Rows.Count

        'Muestro el form de espera..
        frmCargadorDeEspera.Show()
        frmCargadorDeEspera.Text = "Generando la planilla de Sueldos de Empleados de la Sucursal " & DirectCast(Cb_Sucursal.SelectedItem, System.Data.DataRowView).Row.ItemArray(1)
        frmCargadorDeEspera.lbl_Descripcion.Text = "Iniciando..."
        frmCargadorDeEspera.BarraProgreso.Minimum = 0
        frmCargadorDeEspera.BarraProgreso.Maximum = 3 + TotEmpleados
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

        'Si se genero una plantilla de excel, primero la borro.
        If System.IO.File.Exists(Application.StartupPath & "\planilla_empleados.xls") Then
            System.IO.File.Delete(Application.StartupPath & "\planilla_empleados.xls")
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

        xlWorkSheet.Cells(1, 1) = "Fecha/Empleado"
        xlWorkSheet.Cells(1, 1).style = "EstiloEncabezado"

        xlWorkSheet.Cells(2, 1) = ""
        xlWorkSheet.Cells(2, 1).style = "EstiloEncabezado"

        'Voy seteando la barra de progreso
        frmCargadorDeEspera.lbl_Descripcion.Text = "Cargando empleados..."
        frmCargadorDeEspera.BarraProgreso.Value = 2
        frmCargadorDeEspera.Refresh()

        'ENCABEZADO DEL EXCEL.
        '----------------------------------------------------------------------------------------------------------------------'
        Dim ComienzoIngreso As Integer = 1
        For w = 1 To TotEmpleados
            Dim wds As Integer = (w - 1)
            Dim wmr As Integer = 0

            If w = 1 Then
                wmr = w
            Else
                wmr = w + (w - 1)
            End If

            xlWorkSheet.Cells(1, ComienzoIngreso + wmr) = dsEmpleados.Tables(0).Rows(wds).Item("Apellido").ToString() & " " & dsEmpleados.Tables(0).Rows(wds).Item("Nombre").ToString()
            xlWorkSheet.Cells(1, ComienzoIngreso + wmr).style = "EstiloEncabezado"
            xlWorkSheet.Cells(2, ComienzoIngreso + wmr) = "Sueldo"
            xlWorkSheet.Cells(2, ComienzoIngreso + wmr).style = "EstiloCategoria"
            xlWorkSheet.Cells(2, ComienzoIngreso + wmr + 1) = "Comisión"
            xlWorkSheet.Cells(2, ComienzoIngreso + wmr + 1).style = "EstiloCategoria"

            ' Seleccionas el rango q quieres combinar
            xlApp.Range(xlWorkSheet.Cells(1, ComienzoIngreso + wmr), xlWorkSheet.Cells(1, ComienzoIngreso + wmr + 1)).Select()

            ' Estableces MergeCells a True para combinar
            xlApp.Selection.MergeCells = True
        Next
        '----------------------------------------------------------------------------------------------------------------------'


        'PRIMERA COLUMNA CON TODOS LOS DIAS DEL MES.
        '----------------------------------------------------------------------------------------------------------------------'
        'Armo la cabecera con los dias de la semana del rango seleccionado.
        For i = InicioPeriodo To FinPeriodo
            inicio = (i - InicioPeriodo) + 1
            Dim dateValue As Date = i & "/" & mes & "/" & anio
            xlWorkSheet.Cells((inicio + 2), 1) = i & "º " & dateValue.ToString("dddd", New CultureInfo("es-ES"))
            xlWorkSheet.Cells((inicio + 2), 1).style = "EstiloEncabezado"
        Next
        xlWorkSheet.Cells((FinPeriodo + 3), 1) = "PRESENTISMO"
        xlWorkSheet.Cells((FinPeriodo + 3), 1).style = "EstiloEncabezado"
        xlWorkSheet.Cells((FinPeriodo + 4), 1) = "TOTAL MENSUAL"
        xlWorkSheet.Cells((FinPeriodo + 4), 1).style = "EstiloEncabezado"
        xlWorkSheet.Cells((FinPeriodo + 6), 1) = "TOTAL UNIFICADO"
        xlWorkSheet.Cells((FinPeriodo + 6), 1).style = "EstiloEncabezado"
        xlWorkSheet.Cells((FinPeriodo + 7), 1) = "ADELANTOS OBTENIDOS"
        xlWorkSheet.Cells((FinPeriodo + 7), 1).style = "EstiloEncabezado"
        xlWorkSheet.Cells((FinPeriodo + 8), 1) = "ADICIONALES OBTENIDOS"
        xlWorkSheet.Cells((FinPeriodo + 8), 1).style = "EstiloEncabezado"
        xlWorkSheet.Cells((FinPeriodo + 9), 1) = "RECIBO DE SUELDO"
        xlWorkSheet.Cells((FinPeriodo + 9), 1).style = "EstiloEncabezado"
        xlWorkSheet.Cells((FinPeriodo + 10), 1) = "VACACIONES"
        xlWorkSheet.Cells((FinPeriodo + 10), 1).style = "EstiloEncabezado"
        xlWorkSheet.Cells((FinPeriodo + 11), 1) = "AGUINALDO"
        xlWorkSheet.Cells((FinPeriodo + 11), 1).style = "EstiloEncabezado"
        xlWorkSheet.Cells((FinPeriodo + 12), 1) = "SALDO A PAGAR EN MANO"
        xlWorkSheet.Cells((FinPeriodo + 12), 1).style = "EstiloEncabezado"
        xlWorkSheet.Cells((FinPeriodo + 13), 1) = "SALDO A DEPOSITAR"
        xlWorkSheet.Cells((FinPeriodo + 13), 1).style = "EstiloEncabezado"
        xlWorkSheet.Cells((FinPeriodo + 14), 1) = "DEUDA ACUMULADA"
        xlWorkSheet.Cells((FinPeriodo + 14), 1).style = "EstiloEncabezado"
        '----------------------------------------------------------------------------------------------------------------------'

        'CUERPO CON LOS DATOS DE LOS EMPLEADOS.
        '------------------------------------------------------------------------------------------------------------------'
        For w = 1 To TotEmpleados
            Dim wds As Integer = (w - 1)
            Dim wmr As Integer = 0

            If w = 1 Then
                wmr = w
            Else
                wmr = w + (w - 1)
            End If

            'Voy seteando la barra de progreso
            frmCargadorDeEspera.lbl_Descripcion.Text = "Cargando empleado " & dsEmpleados.Tables(0).Rows(wds).Item("Apellido") & ", " & dsEmpleados.Tables(0).Rows(wds).Item("Nombre") & " ..."
            frmCargadorDeEspera.BarraProgreso.Value += 1
            frmCargadorDeEspera.Refresh()

            'Pregunto primero si en el rango de fechas tiene comisiones cargadas.
            Dim FDesde As String = anio & "/" & mes & "/" & InicioPeriodo
            Dim FHasta As String = anio & "/" & mes & "/" & FinPeriodo
            Dim id_Empleado As Integer = CInt(dsEmpleados.Tables(0).Rows(wds).Item("id_Empleado"))

            Dim dsComisiones As DataSet = NegEmpleado.ComisionPorDia(id_Empleado, id_Sucursal, FDesde, FHasta)
            Dim dsSueldo As DataSet = NegEmpleado.SueldoPorDia(id_Empleado, id_Sucursal, FDesde, FHasta)

            'obtengo el estado de cuenta del mes en curso
            Dim estadoCuenta As EstadoCuenta = NegEmpleado.ObtenerEstadoCuenta(id_Empleado, id_Sucursal, FDesde, FHasta)

            Dim TotalComisionesEmp As Double = 0
            Dim TotalSueldosEmp As Double = 0

            For i = InicioPeriodo To FinPeriodo
                inicio = (i - InicioPeriodo) + 1
                Dim Fecha As Date = New Date(anio, mes, i)

                Dim Sueldo As DataRow = dsSueldo.Tables(0).Rows.Cast(Of DataRow).FirstOrDefault(Function(x) Date.Parse(x("Fecha")).Date = Fecha)
                If Not Sueldo Is Nothing Then
                    xlWorkSheet.Cells((inicio + 2), ComienzoIngreso + wmr).value = "$ " & Format(CType(Sueldo("Monto"), Decimal), "###0.00") 'SUELDO
                    TotalSueldosEmp += Sueldo("Monto")
                Else
                    xlWorkSheet.Cells((inicio + 2), ComienzoIngreso + wmr).value = "-" 'SUELDO
                End If

                Dim Comision As DataRow = dsComisiones.Tables(0).Rows.Cast(Of DataRow).FirstOrDefault(Function(x) Date.Parse(x("Fecha")).Date = Fecha)
                If Not Comision Is Nothing Then
                    xlWorkSheet.Cells((inicio + 2), ComienzoIngreso + wmr + 1).value = "$ " & Format(CType(Comision("Monto"), Decimal), "###0.00") 'COMISION
                    TotalComisionesEmp += Comision("Monto")
                Else
                    xlWorkSheet.Cells((inicio + 2), ComienzoIngreso + wmr + 1).value = "-" 'COMISION
                End If
            Next

            'Acumulo los totales.
            TotalComisiones += TotalComisionesEmp
            TotalSueldos += TotalSueldosEmp

            'PRESENTISMO.
            If estadoCuenta.CantidadDiasAusente = 0 AndAlso estadoCuenta.CantidadDiasTarde = 0 Then
                TotalPresentismo = (estadoCuenta.CantidadDiasNormales + estadoCuenta.CantidadDiasFeriados) * CType(dsEmpleados.Tables(0).Rows(wds).Item("SueldoPresentismo"), Double)
                xlWorkSheet.Cells((FinPeriodo + 3), ComienzoIngreso + wmr).value = "$ " & Format(CType(TotalPresentismo, Decimal), "###0.00") 'SUELDO
            Else
                xlWorkSheet.Cells((FinPeriodo + 3), ComienzoIngreso + wmr).value = "-"
            End If

            'TOTALES MENSUALES DEL EMPLEADO.
            If TotalSueldosEmp > 0 Then
                xlWorkSheet.Cells((FinPeriodo + 4), ComienzoIngreso + wmr).value = "$ " & Format(CType(TotalSueldosEmp, Decimal), "###0.00") 'SUELDO
            Else
                xlWorkSheet.Cells((FinPeriodo + 4), ComienzoIngreso + wmr).value = "-"
            End If

            If TotalComisionesEmp > 0 Then
                xlWorkSheet.Cells((FinPeriodo + 4), ComienzoIngreso + wmr + 1).value = "$ " & Format(CType(TotalComisionesEmp, Decimal), "###0.00") 'COMISION
            Else
                xlWorkSheet.Cells((FinPeriodo + 4), ComienzoIngreso + wmr + 1).value = "-"
            End If

            'TOTAL MENSUAL DEL EMPLEADO (SALDO+COMISION)
            If (TotalSueldosEmp + TotalComisionesEmp) > 0 Then
                xlWorkSheet.Cells((FinPeriodo + 6), ComienzoIngreso + wmr).value = "$ " & Format(CType(TotalSueldosEmp + TotalComisionesEmp + TotalPresentismo, Decimal), "###0.00") 'SUELDO+COMISION
            Else
                xlWorkSheet.Cells((FinPeriodo + 6), ComienzoIngreso + wmr).value = "-"
            End If
            xlWorkSheet.Cells((FinPeriodo + 6), ComienzoIngreso + wmr + 1).value = "" 'CELDA VACIA.

            ' Seleccionas el rango y la combino.
            xlApp.Range(xlWorkSheet.Cells((FinPeriodo + 6), ComienzoIngreso + wmr), xlWorkSheet.Cells((FinPeriodo + 6), ComienzoIngreso + wmr + 1)).Select()
            xlApp.Selection.MergeCells = True

            'TOTAL DE ADELANTOS OTORGADOS AL EMPLEADO
            If estadoCuenta.Adelantos > 0 Then
                xlWorkSheet.Cells((FinPeriodo + 7), ComienzoIngreso + wmr).value = "$ " & Format(CType(estadoCuenta.Adelantos, Decimal), "###0.00")
            Else
                xlWorkSheet.Cells((FinPeriodo + 7), ComienzoIngreso + wmr).value = "-"
            End If
            xlWorkSheet.Cells((FinPeriodo + 7), ComienzoIngreso + wmr + 1).value = "" 'CELDA VACIA.

            ' Seleccionas el rango y la combino.
            xlApp.Range(xlWorkSheet.Cells((FinPeriodo + 7), ComienzoIngreso + wmr), xlWorkSheet.Cells((FinPeriodo + 7), ComienzoIngreso + wmr + 1)).Select()
            xlApp.Selection.MergeCells = True

            'TOTAL DE ADICIONALES OTORGADOS AL EMPLEADO
            If estadoCuenta.Adicionales > 0 Then
                xlWorkSheet.Cells((FinPeriodo + 8), ComienzoIngreso + wmr).value = "$ " & Format(CType(estadoCuenta.Adicionales, Decimal), "###0.00")
            Else
                xlWorkSheet.Cells((FinPeriodo + 8), ComienzoIngreso + wmr).value = "-"
            End If
            xlWorkSheet.Cells((FinPeriodo + 8), ComienzoIngreso + wmr + 1).value = "" 'CELDA VACIA.

            ' Seleccionas el rango y la combino.
            xlApp.Range(xlWorkSheet.Cells((FinPeriodo + 8), ComienzoIngreso + wmr), xlWorkSheet.Cells((FinPeriodo + 8), ComienzoIngreso + wmr + 1)).Select()
            xlApp.Selection.MergeCells = True


            'RECIBO DE SUELDO
            If estadoCuenta.RecivoSueldo > 0 Then
                xlWorkSheet.Cells((FinPeriodo + 9), ComienzoIngreso + wmr).value = "$ " & Format(CType(estadoCuenta.RecivoSueldo, Decimal), "###0.00")
            Else
                xlWorkSheet.Cells((FinPeriodo + 9), ComienzoIngreso + wmr).value = "-"
            End If
            xlWorkSheet.Cells((FinPeriodo + 9), ComienzoIngreso + wmr + 1).value = "" 'CELDA VACIA.

            ' Seleccionas el rango y la combino.
            xlApp.Range(xlWorkSheet.Cells((FinPeriodo + 9), ComienzoIngreso + wmr), xlWorkSheet.Cells((FinPeriodo + 9), ComienzoIngreso + wmr + 1)).Select()
            xlApp.Selection.MergeCells = True

            'VACACIONES
            If estadoCuenta.Vacaciones > 0 Then
                xlWorkSheet.Cells((FinPeriodo + 10), ComienzoIngreso + wmr).value = "$ " & Format(CType(estadoCuenta.Vacaciones, Decimal), "###0.00")
            Else
                xlWorkSheet.Cells((FinPeriodo + 10), ComienzoIngreso + wmr).value = "-"
            End If
            xlWorkSheet.Cells((FinPeriodo + 10), ComienzoIngreso + wmr + 1).value = "" 'CELDA VACIA.

            ' Seleccionas el rango y la combino.
            xlApp.Range(xlWorkSheet.Cells((FinPeriodo + 10), ComienzoIngreso + wmr), xlWorkSheet.Cells((FinPeriodo + 10), ComienzoIngreso + wmr + 1)).Select()
            xlApp.Selection.MergeCells = True

            'AGUINALDO
            If estadoCuenta.Aguinaldo > 0 Then
                xlWorkSheet.Cells((FinPeriodo + 11), ComienzoIngreso + wmr).value = "$ " & Format(CType(estadoCuenta.Aguinaldo, Decimal), "###0.00")
            Else
                xlWorkSheet.Cells((FinPeriodo + 11), ComienzoIngreso + wmr).value = "-"
            End If
            xlWorkSheet.Cells((FinPeriodo + 11), ComienzoIngreso + wmr + 1).value = "" 'CELDA VACIA.

            ' Seleccionas el rango y la combino.
            xlApp.Range(xlWorkSheet.Cells((FinPeriodo + 11), ComienzoIngreso + wmr), xlWorkSheet.Cells((FinPeriodo + 11), ComienzoIngreso + wmr + 1)).Select()
            xlApp.Selection.MergeCells = True

            Dim SaldoEnMano As Double
            Dim SaldoADepositar As Double
            Dim Deuda As Double
            Dim DiferenciaMeses As Integer = (mes - DateTime.Now.Month) + 12 * (anio - DateTime.Now.Year)

            'si la deuda del mes seleccionado no tiene valor 
            If (Not estadoCuenta.Deuda.HasValue) Then
                'y si el mes seleccionado no es un mes futuro
                If (DiferenciaMeses < 1) Then
                    'Calcula la deuda que le corresponde a este mes
                    Deuda = CalcularDeudaMesVencidos(id_Empleado, id_Sucursal, FDesde, FHasta, dsEmpleados.Tables(0).Rows(wds), False)
                End If
            Else
                Deuda = estadoCuenta.Deuda.Value
            End If

            CalcularSueldos(TotalSueldosEmp, TotalPresentismo, Deuda, estadoCuenta, SaldoADepositar, SaldoEnMano)

            'SALDO A PAGAR EN MANO
            If SaldoEnMano > 0 Then
                xlWorkSheet.Cells((FinPeriodo + 12), ComienzoIngreso + wmr).value = "$ " & Format(CType(SaldoEnMano, Decimal), "###0.00")
            Else
                xlWorkSheet.Cells((FinPeriodo + 12), ComienzoIngreso + wmr).value = "-"
            End If
            xlWorkSheet.Cells((FinPeriodo + 12), ComienzoIngreso + wmr + 1).value = "" 'CELDA VACIA.

            ' Seleccionas el rango y la combino.
            xlApp.Range(xlWorkSheet.Cells((FinPeriodo + 12), ComienzoIngreso + wmr), xlWorkSheet.Cells((FinPeriodo + 12), ComienzoIngreso + wmr + 1)).Select()
            xlApp.Selection.MergeCells = True

            'SALDO A DEPOSITAR
            If SaldoADepositar > 0 Then
                xlWorkSheet.Cells((FinPeriodo + 13), ComienzoIngreso + wmr).value = "$ " & Format(CType(SaldoADepositar, Decimal), "###0.00")
            Else
                xlWorkSheet.Cells((FinPeriodo + 13), ComienzoIngreso + wmr).value = "-"
            End If
            xlWorkSheet.Cells((FinPeriodo + 13), ComienzoIngreso + wmr + 1).value = "" 'CELDA VACIA.

            ' Seleccionas el rango y la combino.
            xlApp.Range(xlWorkSheet.Cells((FinPeriodo + 13), ComienzoIngreso + wmr), xlWorkSheet.Cells((FinPeriodo + 13), ComienzoIngreso + wmr + 1)).Select()
            xlApp.Selection.MergeCells = True

            'DEUDA ACUMULADA
            If Deuda <> 0 Then
                xlWorkSheet.Cells((FinPeriodo + 14), ComienzoIngreso + wmr).value = "$ " & Format(CType(Deuda, Decimal), "###0.00")
            Else
                xlWorkSheet.Cells((FinPeriodo + 14), ComienzoIngreso + wmr).value = "-"
            End If
            xlWorkSheet.Cells((FinPeriodo + 14), ComienzoIngreso + wmr + 1).value = "" 'CELDA VACIA.

            ' Seleccionas el rango y la combino.
            xlApp.Range(xlWorkSheet.Cells((FinPeriodo + 14), ComienzoIngreso + wmr), xlWorkSheet.Cells((FinPeriodo + 14), ComienzoIngreso + wmr + 1)).Select()
            xlApp.Selection.MergeCells = True

            TotalVacaciones += estadoCuenta.Vacaciones
            TotalAguinaldos += estadoCuenta.Aguinaldo
        Next
        '------------------------------------------------------------------------------------------------------------------'

        'Seteo los totales
        lbl_TotComisiones.Text = "$ " & TotalComisiones
        lbl_TotSueldos.Text = "$ " & TotalSueldos
        lbl_TotVacaciones.Text = "$ " & TotalVacaciones
        lbl_TotAguinaldos.Text = "$ " & TotalAguinaldos

        'Voy seteando la barra de progreso
        frmCargadorDeEspera.lbl_Descripcion.Text = "Confeccionando planilla..."
        frmCargadorDeEspera.BarraProgreso.Value += 1
        frmCargadorDeEspera.Refresh()

        'Ajusto las columnas dependiendo de las celdas.
        xlWorkSheet.Columns.AutoFit()

        'Almaceno el excel.
        xlApp.DisplayAlerts = False
        xlWorkSheet.SaveAs(Application.StartupPath & "\planilla_empleados.xls", Excel.XlFileFormat.xlExcel8)
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

    'Funcion para obtener la deuda 
    Private Function CalcularDeudaMesVencidos(ByVal id_Empleado As Integer, ByVal id_Sucursal As Integer, ByVal FechaDesde As DateTime, ByVal FechaHasta As DateTime, ByVal drEmpleado As DataRow, ByVal TuvoDeuda As Boolean) As Double
        Dim SueldoPresentismo As Double = 0
        Dim Deuda As Double = 0

        'Obtengo es tada del cuanta del mes anterior
        Dim estadoCuenta = NegEmpleado.ObtenerEstadoCuenta(id_Empleado, id_Sucursal, FechaDesde.AddMonths(-1).ToString("yyyy/MM/dd"), FechaDesde.AddDays(-1).ToString("yyyy/MM/dd"))

        'En caso que la deuda no tenga valor es porque no se tiene deuda registrada para este mes, por lo que calculo la deuda
        If (Not estadoCuenta.Deuda.HasValue) Then
            'Antes de entrar al proceso recirsivo verifico que el empleado halla tenido algun registro de deuda para tener un corte de la recursividad
            If (TuvoDeuda Or NegEmpleado.UltimaDeuda(id_Empleado, id_Sucursal, FechaDesde) = DateTime.MinValue).HasValue Then
                'Calcula la deuda que le corresponde a este mes
                Deuda = CalcularDeudaMesVencidos(id_Empleado, id_Sucursal, FechaDesde.AddMonths(-1).ToString("yyyy/MM/dd"), FechaDesde.AddDays(-1).ToString("yyyy/MM/dd"), drEmpleado, True)
            End If
        Else
            Deuda = estadoCuenta.Deuda.Value
        End If

        If estadoCuenta.CantidadDiasAusente = 0 AndAlso estadoCuenta.CantidadDiasTarde = 0 Then
            SueldoPresentismo = estadoCuenta.CantidadDiasNormales * CType(drEmpleado("SueldoPresentismo"), Double)
        End If

        'Calculo el total trabajado y el total abonado
        Dim SubTotalTrabajado As Double = (estadoCuenta.Comisiones + (estadoCuenta.CantidadDiasNormales + estadoCuenta.CantidadDiasTarde) * CType(drEmpleado("SueldoNormal"), Double) + estadoCuenta.CantidadDiasFeriados * CType(drEmpleado("SueldoFeriado"), Double) + estadoCuenta.Aguinaldo + estadoCuenta.Vacaciones + estadoCuenta.Adicionales + SueldoPresentismo)
        Dim SubTotalAbonado As Double = estadoCuenta.Adelantos + estadoCuenta.SueldoPago + Deuda

        Deuda = -(SubTotalTrabajado - SubTotalAbonado)
        'Registro la deuda
        NegEmpleado.ActualizarDeuda(id_Empleado, id_Sucursal, Deuda, FechaDesde)
        Return Deuda
    End Function

    Sub CalcularSueldos(ByVal SueldoNormal As Double, ByVal Presentismo As Double, ByVal Deuda As Double, estadoCuenta As EstadoCuenta, ByRef SueldoPorDepositar As Double, ByRef SueldoPorPagarEnMano As Double)

        Dim SubTotalTrabajado As Double = (estadoCuenta.Comisiones + SueldoNormal + estadoCuenta.Aguinaldo + estadoCuenta.Vacaciones + estadoCuenta.Adicionales + Presentismo)

        Dim SubTotalAbonado As Double = estadoCuenta.Adelantos + estadoCuenta.SueldoPago + Deuda

        If (SubTotalTrabajado - SubTotalAbonado < 0) Then
            SueldoPorDepositar = 0
            SueldoPorPagarEnMano = SubTotalTrabajado - SubTotalAbonado
        Else
            If ((estadoCuenta.RecivoSueldo - estadoCuenta.SueldoPago) = 0) Then
                SueldoPorDepositar = 0
                SueldoPorPagarEnMano = SubTotalTrabajado - SubTotalAbonado

                'Si al total trabajado menos la deuda del mes pasado no llega a cubrir el recivo de sueldo
            ElseIf (SubTotalTrabajado - Deuda < estadoCuenta.RecivoSueldo) Then
                'Defino el monto posible a pagar como esa diferencia menos lo que ya se le pudo haber pagado del recivo
                SueldoPorDepositar = SubTotalTrabajado - Deuda - estadoCuenta.SueldoPago
                SueldoPorPagarEnMano = 0
            ElseIf (Deuda >= 0) Then
                SueldoPorDepositar = estadoCuenta.RecivoSueldo - Deuda - estadoCuenta.SueldoPago
                If (SueldoPorDepositar < 0) Then
                    SueldoPorDepositar = 0
                End If
                SueldoPorPagarEnMano = SubTotalTrabajado - SubTotalAbonado - SueldoPorDepositar
            Else
                SueldoPorDepositar = estadoCuenta.RecivoSueldo - estadoCuenta.SueldoPago
                If (SueldoPorDepositar < 0) Then
                    SueldoPorDepositar = 0
                End If
                SueldoPorPagarEnMano = SubTotalTrabajado - SubTotalAbonado - SueldoPorDepositar
            End If
        End If
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
            ObjW = ObjExcel.Workbooks.Open(Application.StartupPath & "\planilla_empleados.xls")

            'Objeto el nombre de la hoja.
            If ObjW.Sheets(1).Name <> "" Then
                Hoja = ObjW.Sheets(1).Name
            End If

            'Elimino los objetos.
            ObjW.Close()
            ObjExcel.Quit()
            ClsFunciones.releaseObject(ObjExcel)
            ClsFunciones.releaseObject(ObjW)

            strconn = "Provider=Microsoft.Jet.Oledb.4.0; data source= " & Application.StartupPath & "\planilla_empleados.xls;Extended properties=""Excel 8.0;hdr=yes;imex=1"""
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

            For Each column In DG_Planilla.Columns
                If column.headerText().Substring(0, 1) = "F" Then
                    column.headerText = ""
                End If
            Next

        Catch ex As Exception
            frmCargadorDeEspera.Close()
            frmCargadorDeEspera.Dispose()
            MessageBox.Show(ex.Message, "Planilla de Sueldos de Empleados", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub LimpiarGrilla()
        DG_Planilla.DataSource = Nothing
        DG_Planilla.Rows.Clear()
        lbl_TotComisiones.Text = "$     -"
        lbl_TotSueldos.Text = "$     -"
    End Sub

    Sub EvaluarPermisos()
        If (VariablesGlobales.Patentes.ContainsKey(Entidades.TipoPatente.Planillas_MovimientosSucursal_Exportar)) Then
            Btn_Excel.Enabled = True
        Else
            Btn_Excel.Enabled = False
        End If
    End Sub
#End Region

End Class