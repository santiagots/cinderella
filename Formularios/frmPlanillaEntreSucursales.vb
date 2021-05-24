Imports System.Data.OleDb
Imports Microsoft.Office.Interop
Imports System.Globalization

Public Class frmPlanillaEntreSucursales
    Dim NegMovi As New Negocio.NegMovimientos
    Dim NegSucursal As New Negocio.NegSucursales
    Dim ClsFunciones As New Funciones
    Dim id_Sucursal As Integer
    Dim dsSucursales As New DataSet
    Dim anio As Integer = 0
    Dim mes As Integer = 0

#Region "Region de Eventos"
    'Load del Formulario
    Private Sub frmPlanillaEntreSucursales_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            'Limpiar la planilla.
            LimpiarPlanilla()

            'Cargo la planilla
            ConfeccionarPlanilla()

            Me.WindowState = 2

        Catch ex As Exception
            frmCargadorDeEspera.Close()
            frmCargadorDeEspera.Dispose()
            MessageBox.Show(ex.Message, "Planilla de Movimientos entre Sucursales", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    'Evento click del boton que filtra la planilla.
    Private Sub btn_Filtrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'Cambio el cursor.
        Me.Cursor = Cursors.WaitCursor

        Try
            'Limpiar la planilla.
            LimpiarPlanilla()

            'Cargo la planilla
            ConfeccionarPlanilla()

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Planilla de Movimientos entre Sucursales", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Me.Close()
            Me.Dispose()
        End Try

        'Cambio el cursor.
        Me.Cursor = Cursors.Arrow
    End Sub

    'Evento click del boton que permite guardar la planilla.
    Private Sub Btn_Excel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'Si no se genero una plantilla de excel lo informo.
        If Not System.IO.File.Exists(Application.StartupPath & "\planilla.xls") Then
            MessageBox.Show("No se ha encontrado una planilla de excel para exportar. Por favor, intente más tarde.", "Planilla de Movimientos entre Sucursales", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        Else
            Try
                Dim DialogSave As New SaveFileDialog()

                ' Extension por defecto
                DialogSave.DefaultExt = "xls"

                ' Extensiones disponibles
                DialogSave.Filter = "Microsoft Excel (*.xls)|*.xls | All files (*.*)|*.*"
                DialogSave.FileName = "planillaSucursales"

                'Anadir extension en cas de que el usuario no lo haga
                DialogSave.AddExtension = True

                ' Restaura el directosio selectionado la proxima vez
                DialogSave.RestoreDirectory = True

                ' Titulo de la ventana
                DialogSave.Title = "¿Dónde desea guardar la planilla de movimientos entre sucursales?"

                ' Directorio donde compenzar a buscar
                DialogSave.InitialDirectory = "C:/"

                If DialogSave.ShowDialog() = DialogResult.OK Then
                    FileCopy(Application.StartupPath & "\planillaEntreSucursales.xls", DialogSave.FileName)
                    If System.IO.File.Exists(DialogSave.FileName) Then
                        MessageBox.Show("La planilla ha sido guardada correctamente.", "Planilla de Movimientos entre Sucursales", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Else
                        MessageBox.Show("La planilla no ha sido guardada.", "Planilla de Movimientos entre Sucursales", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    End If
                End If

                DialogSave.Dispose()
                DialogSave = Nothing

            Catch ex As Exception
                MessageBox.Show(ex.Message.ToString, "Planilla de Movimientos entre Sucursales", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End Try
        End If
    End Sub

    'Evento click en la planilla.
    Private Sub DG_Planilla_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DG_Planilla.CellClick
        If e.RowIndex <> (e.ColumnIndex - 1) And e.RowIndex <= (dsSucursales.Tables(0).Rows.Count - 1) And DG_Planilla.Rows(e.RowIndex).Cells(e.ColumnIndex).Value <> "-" And (e.ColumnIndex - 1) >= 0 Then
            Try
                'CAMBIO EL CURSOR.
                Me.Cursor = Cursors.WaitCursor

                GB1.Visible = True

                Dim id_Sucu As Integer = dsSucursales.Tables(0).Rows(e.ColumnIndex - 1).Item("id_Sucursal").ToString
                Dim id_SucuDestino As Integer = dsSucursales.Tables(0).Rows(e.RowIndex).Item("id_Sucursal").ToString
                Dim NombreSucursal As String = dsSucursales.Tables(0).Rows(e.ColumnIndex - 1).Item("Nombre").ToString
                Dim NombreSucursalDestino As String = dsSucursales.Tables(0).Rows(e.RowIndex).Item("Nombre").ToString

                'SETEO EL TITULO.
                GB1.Text = "CRÉDITOS DE: " & NombreSucursal & " CON " & NombreSucursalDestino

                Dim dsMovimientos As New DataSet
                dsMovimientos = NegMovi.ObtenerMovEgresoPorSucursalDestino(id_Sucu, id_SucuDestino)
                If dsMovimientos.Tables(0).Rows.Count > 0 Then
                    DG_Planilla2.DataSource = dsMovimientos.Tables(0)
                    DG_Planilla2.Columns("id_Movimiento").Visible = False
                    DG_Planilla2.Columns("id_Sucu").Visible = False
                    DG_Planilla2.Columns("id_SucuDestino").Visible = False
                End If

                'SETEO EL TOTAL.
                Dim Total As Double = 0
                For Each row In dsMovimientos.Tables(0).Rows
                    Total += row.item("Monto")
                Next
                lbl_Total.Text = "TOTAL CRÉDITOS: $ " & Format(CType(Total, Decimal), "###0.00") & ".-"

                'CAMBIO EL CURSOR.
                Me.Cursor = Cursors.Arrow
            Catch ex As Exception
                Me.Cursor = Cursors.Arrow
                MessageBox.Show(ex.Message, "Mov. entre Sucursales | Detalle", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        Else
            If GB1.Visible Then
                GB1.Visible = False
            End If
        End If
    End Sub

    'Evento click en la planilla 2.
    Private Sub DG_Planilla2_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DG_Planilla2.CellContentClick
        If DG_Planilla2.Columns(e.ColumnIndex).Name = "VerDetalle" Then 'Si se hace click en el boton "Ver Detalle" de la fila.

            'ID
            Dim id_Movimiento As Integer = DG_Planilla2.Rows(e.RowIndex).Cells("id_Movimiento").Value
            Dim id_Sucu As Integer = DG_Planilla2.Rows(e.RowIndex).Cells("id_Sucu").Value
            Dim id_SucuDestino As Integer = DG_Planilla2.Rows(e.RowIndex).Cells("id_SucuDestino").Value

            If id_Movimiento = 0 Then
                MessageBox.Show("No se puede cargar el movimiento.", "Planilla de Movimientos entre Sucursales", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Else
                Me.Cursor = Cursors.WaitCursor
                frmPlanillaEntreSucursalesD1.id_Movimiento = id_Movimiento
                frmPlanillaEntreSucursalesD1.id_Sucursal = id_Sucu
                frmPlanillaEntreSucursalesD1.id_SucursalDestino = id_SucuDestino
                ClsFunciones.ControlInstancia(frmPlanillaEntreSucursalesD1).MdiParent = MDIContenedor
                ClsFunciones.ControlInstancia(frmPlanillaEntreSucursalesD1).Show()
                Me.Cursor = Cursors.Arrow
            End If

        End If
    End Sub
#End Region

#Region "Region de Funciones que arman y muestran la planilla"
    Private Sub ConfeccionarPlanilla()
        '-----------------------ARMO LA TABLA----------------------'
        'Obtengo las sucursales
        dsSucursales = NegSucursal.ListadoSucursales()

        If dsSucursales.Tables(0).Rows.Count > 0 Then

            'VARIABLES
            Dim acum As Integer = 0 'Acumulador
            Dim TotSucursales As Integer = 0 'Cantidad de sucursales
            TotSucursales = dsSucursales.Tables(0).Rows.Count

            'Muestro el form de espera..
            frmCargadorDeEspera.Show()
            frmCargadorDeEspera.Text = "Generando la planilla de Movimientos entre sucursales"
            frmCargadorDeEspera.lbl_Descripcion.Text = "Iniciando... (1/" & TotSucursales + 1 & ")"
            frmCargadorDeEspera.BarraProgreso.Minimum = 0
            frmCargadorDeEspera.BarraProgreso.Maximum = TotSucursales + 1
            frmCargadorDeEspera.BarraProgreso.Value = 1
            frmCargadorDeEspera.Refresh()

            'Si se genero una plantilla de excel, primero la borro.
            If System.IO.File.Exists(Application.StartupPath & "\planillaEntreSucursales.xls") Then
                System.IO.File.Delete(Application.StartupPath & "\planillaEntreSucursales.xls")
            End If

            '-----------------------COLUMNAS----------------------'
            'Cantidad de Columnas
            DG_Planilla.ColumnCount = (TotSucursales + 1)
            DG_Planilla.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize

            ' Seteo el style de las columnas. 
            Dim columnHeaderStyle As New DataGridViewCellStyle
            columnHeaderStyle.BackColor = Color.Aqua
            columnHeaderStyle.Font = New Font("Arial", 9, FontStyle.Bold)
            DG_Planilla.ColumnHeadersDefaultCellStyle = columnHeaderStyle

            'Seteo los nombres de las columnas.
            DG_Planilla.Columns(acum).Name = ""
            For Each Sucu In dsSucursales.Tables(0).Rows
                'Aumento el acumulador.
                acum += 1

                'Nombro la columna.
                DG_Planilla.Columns(acum).Name = Sucu.item("Nombre").ToString
            Next
            '-----------------------COLUMNAS----------------------'

            '-------------------------FILAS-----------------------'

            'INSERTO LA PRIMERA CELDA, DE LA PRIMERA COLUMNA, CON TODAS LAS SUCURSALES.
            For Each Sucu In dsSucursales.Tables(0).Rows

                'Declaración.
                Dim dgvRow As New DataGridViewRow
                Dim dgvCell As DataGridViewCell

                'Valor de la primera celda.
                dgvCell = New DataGridViewTextBoxCell()
                dgvCell.Value = Sucu.item("Nombre").ToString
                dgvCell.Style.Font = New Font("Arial", 9, FontStyle.Bold)
                dgvRow.Cells.Add(dgvCell)

                For r = 1 To TotSucursales
                    dgvCell = New DataGridViewTextBoxCell()
                    dgvCell.Value = "-"
                    dgvRow.Cells.Add(dgvCell)
                Next

                'Inserto la fila
                DG_Planilla.Rows.Add(dgvRow)
            Next

            'INSERTO LA ULTIMA CELDA, DE LA PRIMERA COLUMNA CON EL TOTAL
            'Declaración.
            Dim dgvRow2 As New DataGridViewRow
            Dim dgvCell2 As DataGridViewCell

            'Valor de la primera celda.
            dgvCell2 = New DataGridViewTextBoxCell()
            dgvCell2.Value = ""
            dgvRow2.Cells.Add(dgvCell2)

            'Inserto la fila
            DG_Planilla.Rows.Add(dgvRow2)

            Dim dgvRow3 As New DataGridViewRow
            Dim dgvCell3 As DataGridViewCell

            dgvCell3 = New DataGridViewTextBoxCell()
            dgvCell3.Value = "TOTAL CREDITOS"
            dgvRow3.Cells.Add(dgvCell3)

            'Inserto la fila
            DG_Planilla.Rows.Add(dgvRow3)

            'INSERTO LOS MONTOS POR SUCURSAL
            For q = 1 To TotSucursales
                Dim DsSucursalesDestino As New DataSet
                DsSucursalesDestino = NegMovi.ObtenerMovEgresoPorSucursal(dsSucursales.Tables(0).Rows(q - 1).Item("id_Sucursal").ToString)

                'Voy seteando la barra de progreso
                frmCargadorDeEspera.lbl_Descripcion.Text = "Cargando sucursal " & dsSucursales.Tables(0).Rows(q - 1).Item("Nombre").ToString & "... (" & q & "/" & TotSucursales + 1 & ")"
                frmCargadorDeEspera.BarraProgreso.Value = q + 1
                frmCargadorDeEspera.Refresh()

                Dim Total As Double = 0
                If DsSucursalesDestino.Tables(0).Rows.Count > 0 Then
                    For Each SucuDestino In DsSucursalesDestino.Tables(0).Rows

                        For Each fila In DG_Planilla.Rows
                            If fila.cells(0).value.ToString = SucuDestino.Item("Nombre").ToString Then
                                fila.Cells(q).Value = "$ " & Format(CType(SucuDestino.Item("Monto"), Decimal), "###0.00")
                                Total += SucuDestino.Item("Monto")
                            End If
                        Next

                    Next
                End If
                DG_Planilla.Rows(TotSucursales + 1).Cells(q).Value = "$ " & Format(CType(Total, Decimal), "###0.00")
            Next

            'Pinto la celda que corresponde a la misma sucursal, fila y columna.
            For q = 1 To TotSucursales
                DG_Planilla.Rows(q - 1).Cells(q).Style.BackColor = Color.DarkGray
                DG_Planilla.Rows(q - 1).Cells(q).Value = ""
            Next
            DG_Planilla.Rows(Me.DG_Planilla.RowCount - 1).DefaultCellStyle.Font = New Font("Arial", 10, FontStyle.Bold)
            DG_Planilla.Rows(Me.DG_Planilla.RowCount - 1).DefaultCellStyle.BackColor = Color.Gray
            '-------------------------FILAS-----------------------'
        End If

        'Programo que las columnas no sean 'sorteables'.
        For Each column In DG_Planilla.Columns
            DG_Planilla.Columns(column.name).SortMode = DataGridViewColumnSortMode.NotSortable
        Next
        '-----------------------ARMO LA TABLA----------------------'

        'Voy seteando la barra de progreso
        frmCargadorDeEspera.Close()
        frmCargadorDeEspera.Dispose()
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
            ObjW = ObjExcel.Workbooks.Open(Application.StartupPath & "\planillaEntreSucursales.xls")

            'Objeto el nombre de la hoja.
            If ObjW.Sheets(1).Name <> "" Then
                Hoja = ObjW.Sheets(1).Name
            End If

            'Elimino los objetos.
            ObjW.Close()
            ObjExcel.Quit()
            ClsFunciones.releaseObject(ObjExcel)
            ClsFunciones.releaseObject(ObjW)

            strconn = "Provider=Microsoft.Jet.Oledb.4.0; data source= " & Application.StartupPath & "\planillaEntreSucursales.xls;Extended properties=""Excel 8.0;hdr=yes;imex=1"""
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
        Catch ex As Exception
            frmCargadorDeEspera.Close()
            frmCargadorDeEspera.Dispose()
            MessageBox.Show(ex.Message, "Planilla de Movimientos entre Sucursales", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub LimpiarPlanilla()
        DG_Planilla.DataSource = Nothing
        DG_Planilla.Rows.Clear()
    End Sub
#End Region

End Class