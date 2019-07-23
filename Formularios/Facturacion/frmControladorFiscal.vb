Imports Negocio
Imports Microsoft.Office.Interop
Imports SistemaCinderella.Formularios.Facturacion
Imports System.Threading.Tasks
Imports Common.Core.Exceptions
Imports Common.Core.Helper

Public Class frmControladorFiscal

    Private frmControladorFiscalViewModel As frmControladorFiscalViewModel

    Private Sub FrmFacturaAdministracion_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        EjecutarAsync(Async Function() As Task
                          frmControladorFiscalViewModel = New frmControladorFiscalViewModel(My.Settings.Sucursal)
                          FrmControladorFiscalViewModelBindingSource.DataSource = frmControladorFiscalViewModel
                          Await frmControladorFiscalViewModel.BuscarAsync()
                          EvaluarPermisos()
                      End Function)
    End Sub

    Private Sub BtnFiltrar_Click(sender As Object, e As EventArgs) Handles BtnFiltrar.Click
        EjecutarAsync(Async Function() As Task
                          Await frmControladorFiscalViewModel.BuscarAsync()
                      End Function)
    End Sub

    Private Sub btn_Exportar_Click(sender As Object, e As EventArgs) Handles btn_Exportar.Click
        SaveFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments)
        SaveFileDialog.FileName = String.Format("Listado Facturas Sucursal {0}", My.Settings.NombreSucursal)
        SaveFileDialog.Filter = "Excel Files|*.xlsx;"

        If SaveFileDialog.ShowDialog() = DialogResult.OK Then
            Ejecutar(Sub()
                         frmControladorFiscalViewModel.Exportar(SaveFileDialog.FileName, My.Settings.NombreSucursal)
                         MessageBox.Show("Se ha exportado el listado de facturas de forma exitosa", "Controlador Fiscal", MessageBoxButtons.OK, MessageBoxIcon.Information)
                     End Sub)

        End If
    End Sub

    Private Sub btnCierreZ_Click(sender As Object, e As EventArgs) Handles btnCierreZ.Click
        Ejecutar(Sub() frmControladorFiscalViewModel.CierreZ())
    End Sub

    Private Sub btnCierreZPorFiltro_Click(sender As Object, e As EventArgs) Handles btnCierreZPorFiltro.Click
        Ejecutar(Sub() frmControladorFiscalViewModel.CierreZPorFiltro(rblFiltroPorFecha.Checked))
    End Sub

    Private Sub btnCintaTestigoDigitalPorFiltro_Click(sender As Object, e As EventArgs) Handles btnCintaTestigoDigitalPorFiltro.Click
        Ejecutar(Sub()
                     If (FolderBrowserDialog.ShowDialog() = DialogResult.OK) Then
                         Dim nombreArchivo As String = frmControladorFiscalViewModel.CintaTestigoDigitalPorFiltro(FolderBrowserDialog.SelectedPath, rblFiltroPorFecha.Checked)
                         MessageBox.Show($"Se ha guardado el archivo {nombreArchivo} de forma exitosa", "Controlador Fiscal", MessageBoxButtons.OK, MessageBoxIcon.Information)
                     End If
                 End Sub)
    End Sub

    Private Sub btnDuplicadosDocumentosAPorFiltro_Click(sender As Object, e As EventArgs) Handles btnDuplicadosDocumentosAPorFiltro.Click
        Ejecutar(Sub()
                     If (FolderBrowserDialog.ShowDialog() = DialogResult.OK) Then
                         Dim nombreArchivo As String = frmControladorFiscalViewModel.DuplicadosDocumentosTipoA(FolderBrowserDialog.SelectedPath, rblFiltroPorFecha.Checked)
                         MessageBox.Show($"Se ha guardado el archivo {nombreArchivo} de forma exitosa", "Controlador Fiscal", MessageBoxButtons.OK, MessageBoxIcon.Information)
                     End If
                 End Sub)
    End Sub

    Private Sub btnResumenTotalesPorFiltro_Click(sender As Object, e As EventArgs) Handles btnResumenTotalesPorFiltro.Click
        Ejecutar(Sub()
                     If (FolderBrowserDialog.ShowDialog() = DialogResult.OK) Then
                         Dim nombreArchivo As String = frmControladorFiscalViewModel.ResumenTotales(FolderBrowserDialog.SelectedPath, rblFiltroPorFecha.Checked)
                         MessageBox.Show($"Se ha guardado el archivo {nombreArchivo} de forma exitosa", "Controlador Fiscal", MessageBoxButtons.OK, MessageBoxIcon.Information)
                     End If
                 End Sub)
    End Sub

    Private Sub btnInformacionTransaccionesPorFiltro_Click(sender As Object, e As EventArgs) Handles btnInformacionTransaccionesPorFiltro.Click
        Ejecutar(Sub()
                     Dim frmInformacionTransacciones As frmInformacionTransacciones = New frmInformacionTransacciones()
                     frmInformacionTransacciones.ShowDialog()
                 End Sub)
    End Sub

    Private Sub EvaluarPermisos()
        If (VariablesGlobales.Patentes.ContainsKey(Entidades.TipoPatente.Sistema_Controlador_Fiscal_EmitirCierreZdía)) Then
            btnCierreZ.Enabled = True
        Else
            btnCierreZ.Enabled = False
        End If

        If (VariablesGlobales.Patentes.ContainsKey(Entidades.TipoPatente.Sistema_Controlador_Fiscal_EmitirCierreZRangoFechas)) Then
            btnCierreZPorFiltro.Enabled = True
        Else
            btnCierreZPorFiltro.Enabled = False
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

    Private Sub Ejecutar(accion As Action)
        Try
            accion()
        Catch ex As NegocioException
            Log.Error(ex)
            MessageBox.Show(ex.Message, "Registro de Ventas", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Catch ex As Exception
            Log.Error(ex)
            MessageBox.Show("Error al realizar la accion. Por favor, intente mas tarde o consulte con el administrador.", "Registro de Ventas", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Async Sub EjecutarAsync(accion As Func(Of Task))
        Try
            Await accion()
        Catch ex As NegocioException
            Log.Error(ex)
            MessageBox.Show(ex.Message, "Registro de Ventas", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Catch ex As Exception
            Log.Error(ex)
            MessageBox.Show("Error al realizar la accion. Por favor, intente mas tarde o consulte con el administrador.", "Registro de Ventas", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
End Class