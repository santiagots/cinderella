Imports System.Threading.Tasks
Imports Common.Core.Exceptions
Imports Common.Core.Helper
Imports SistemaCinderella.Formularios.SucursalSaldo

Public Class frmResumenDiario
    Private frmResumenDiarioViewModel As frmResumenDiarioViewModel

    Sub New()
        ' This call is required by the designer.
        InitializeComponent()

        frmResumenDiarioViewModel = New frmResumenDiarioViewModel(My.Settings.Sucursal, My.Settings.NombreSucursal)

        AddHandler txtMonto.DataBindings(0).Parse, AddressOf NullParseHandler
    End Sub

    Private Sub FrmResumenDiario_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        EjecutarAsync(Async Function() As Task
                          FrmResumenDiarioViewModelBindingSource.DataSource = frmResumenDiarioViewModel
                          Await frmResumenDiarioViewModel.BuscarAsync()
                          SaldosSucursal.SaldoSucursalViewModelBindingSource.DataSource = frmResumenDiarioViewModel.Saldos
                          ModificarColor()
                          SaldosSucursal.AutoScaleMode = AutoScaleMode.None
                      End Function)
    End Sub

    Private Sub Btn_Buscar_Click(sender As Object, e As EventArgs) Handles Btn_Buscar.Click
        EjecutarAsync(Async Function() As Task
                          Await frmResumenDiarioViewModel.BuscarAsync()
                          SaldosSucursal.SaldoSucursalViewModelBindingSource.ResetBindings(False)
                          ModificarColor()
                      End Function)
    End Sub

    Private Sub Btn_Limpiar_Click(sender As Object, e As EventArgs) Handles Btn_Limpiar.Click
        EjecutarAsync(Async Function() As Task
                          Await frmResumenDiarioViewModel.LimpiarAsync()
                          SaldosSucursal.SaldoSucursalViewModelBindingSource.ResetBindings(False)
                          ModificarColor()
                      End Function)
    End Sub

    Private Sub Btn_Cerrar_Click(sender As Object, e As EventArgs) Handles Btn_Cerrar.Click
        EjecutarAsync(Async Function() As Task
                          If MessageBox.Show("Está seguro que desea cerrar la caja diaria?", "Resumen Diario", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = vbYes AndAlso
                             MessageBox.Show("Realmente está seguro que desea cerrar la caja diaria?" & vbCrLf & "Éste proceso debe llevarse a cabo solamente al finalizar el día", "Resumen Diario", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) = vbYes Then

                              Await frmResumenDiarioViewModel.CerrarCajaAsyc()
                              ModificarColor()

                              MessageBox.Show("La caja diaria ha sido cerrada correctamente.", "Resumen Diario", MessageBoxButtons.OK, MessageBoxIcon.Information)

                              If MessageBox.Show("Desea imprimir la Z Diaria?", "Resumen Diario", MessageBoxButtons.YesNo, MessageBoxIcon.Information) = DialogResult.Yes Then
                                  frmResumenDiarioViewModel.CierreZ()
                              End If

                              'Oculto los menus.
                              MDIContenedor.MenuAccesosRapidos.Visible = False
                              MDIContenedor.ToolsMenu.Visible = False
                              MDIContenedor.SeguridadToolStripMenuItem.Visible = False
                              MDIContenedor.Btn_SincronizacionMenu.Visible = False
                              MDIContenedor.BackgroundImageLayout = ImageLayout.Stretch
                              MDIContenedor.Btn_ResumenDiario.Visible = True
                              MDIContenedor.Refresh()

                              Me.Close()
                          End If
                      End Function)
    End Sub

    Private Sub Btn_Abrir_Click(sender As Object, e As EventArgs) Handles Btn_Abrir.Click
        EjecutarAsync(Async Function() As Task
                          If MessageBox.Show("Está seguro que desea abrir la caja diaria?", "Resumen Diario", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = vbYes AndAlso
                                MessageBox.Show("Realmente está seguro que desea abrir la caja diaria?", "Resumen Diario", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) = vbYes Then

                              Await frmResumenDiarioViewModel.AbrirCajaAsync()
                              SaldosSucursal.SaldoSucursalViewModelBindingSource.ResetBindings(False)
                              ModificarColor()

                              'Muestro los menus.
                              MDIContenedor.MenuAccesosRapidos.Visible = True
                              MDIContenedor.ToolsMenu.Visible = True
                              MDIContenedor.SeguridadToolStripMenuItem.Visible = True
                              MDIContenedor.Btn_SincronizacionMenu.Visible = True
                              MDIContenedor.BackgroundImageLayout = ImageLayout.Stretch
                              MDIContenedor.Btn_ResumenDiario.Visible = False
                              MDIContenedor.Refresh()
                          End If
                      End Function)
    End Sub

    Private Sub Btn_Salir_Click(sender As Object, e As EventArgs) Handles Btn_Salir.Click
        Me.Close()
    End Sub

    Private Sub SaldosSucursal_BtnDevolucionesClick(sender As Object, e As EventArgs) Handles SaldosSucursal.BtnDevolucionesClick
        EjecutarAsync(Async Function() As Task
                          Await frmResumenDiarioViewModel.MostrarDevolucionesAsyn()
                      End Function)
    End Sub

    Private Sub SaldosSucursal_BtnSueldoClick(sender As Object, e As EventArgs) Handles SaldosSucursal.BtnSueldoClick
        EjecutarAsync(Async Function() As Task
                          Await frmResumenDiarioViewModel.MostrarSueldosAsyn()
                      End Function)
    End Sub

    Private Sub SaldosSucursal_BtnGastoClick(sender As Object, e As EventArgs) Handles SaldosSucursal.BtnGastoClick
        EjecutarAsync(Async Function() As Task
                          Await frmResumenDiarioViewModel.MostrarGastosAsyn()
                      End Function)
    End Sub

    Private Sub SaldosSucursal_BtnImpuestoClick(sender As Object, e As EventArgs) Handles SaldosSucursal.BtnImpuestoClick
        EjecutarAsync(Async Function() As Task
                          Await frmResumenDiarioViewModel.MostrarImpuestosAsyn()
                      End Function)
    End Sub

    Private Sub SaldosSucursal_BtnEfectivoEgresoClick(sender As Object, e As EventArgs) Handles SaldosSucursal.BtnEfectivoEgresoClick
        EjecutarAsync(Async Function() As Task
                          Await frmResumenDiarioViewModel.MostrarEfectivoEgresosAsyn()
                      End Function)
    End Sub

    Private Sub SaldosSucursal_BtnPendienteAutorizacionClick(sender As Object, e As EventArgs) Handles SaldosSucursal.BtnPendienteAutorizacionClick
        EjecutarAsync(Async Function() As Task
                          Await frmResumenDiarioViewModel.MostrarPendienteAutorizacionEgresosAsync()
                      End Function)
    End Sub

    Private Sub SaldosSucursal_BtnFaltanteClick(sender As Object, e As EventArgs) Handles SaldosSucursal.BtnFaltanteClick
        EjecutarAsync(Async Function() As Task
                          Await frmResumenDiarioViewModel.MostrarFaltanteCajaAsync()
                      End Function)
    End Sub

    Private Sub SaldosSucursal_BtnRetiroClick(sender As Object, e As EventArgs) Handles SaldosSucursal.BtnRetiroClick
        EjecutarAsync(Async Function() As Task
                          Await frmResumenDiarioViewModel.MostrarRetiroSocioAsync()
                      End Function)
    End Sub

    Private Sub SaldosSucursal_BtnVentaClick(sender As Object, e As EventArgs) Handles SaldosSucursal.BtnVentaClick
        EjecutarAsync(Async Function() As Task
                          Await frmResumenDiarioViewModel.MostrarTotalVentaAsync()
                      End Function)
    End Sub

    Private Sub SaldosSucursal_BtnEfectivoIngresoClick(sender As Object, e As EventArgs) Handles SaldosSucursal.BtnEfectivoIngresoClick
        EjecutarAsync(Async Function() As Task
                          Await frmResumenDiarioViewModel.MostrarEfectivoIngresoAsyn()
                      End Function)
    End Sub

    Private Sub SaldosSucursal_BtnSobranteClick(sender As Object, e As EventArgs) Handles SaldosSucursal.BtnSobranteClick
        EjecutarAsync(Async Function() As Task
                          Await frmResumenDiarioViewModel.MostrarSobranteCajaAsync()
                      End Function)
    End Sub

    Private Sub SaldosSucursal_BtnAporteClick(sender As Object, e As EventArgs) Handles SaldosSucursal.BtnAporteClick
        EjecutarAsync(Async Function() As Task
                          Await frmResumenDiarioViewModel.MostrarAporteSocioAsync()
                      End Function)
    End Sub

    Private Sub SaldosSucursal_BtnIngresoCajaFuerteClick(sender As Object, e As EventArgs) Handles SaldosSucursal.BtnIngresoCajaFuerteClick
        EjecutarAsync(Async Function() As Task
                          Await frmResumenDiarioViewModel.MostrarIngresoCajaFuerteAsync()
                      End Function)
    End Sub

    Private Sub SaldosSucursal_BtnEgresoCajaFuerteClick(sender As Object, e As EventArgs) Handles SaldosSucursal.BtnEgresoCajaFuerteClick
        EjecutarAsync(Async Function() As Task
                          Await frmResumenDiarioViewModel.MostrarEgresoCajaFuerteAsync()
                      End Function)
    End Sub

    Private Sub SaldosSucursal_BtnEfectivoClick(sender As Object, e As EventArgs) Handles SaldosSucursal.BtnEfectivoClick
        EjecutarAsync(Async Function() As Task
                          Await frmResumenDiarioViewModel.MostrarTotalVentaEfectivoAsync()
                      End Function)
    End Sub

    Private Sub SaldosSucursal_BtnChequeClick(sender As Object, e As EventArgs) Handles SaldosSucursal.BtnChequeClick
        EjecutarAsync(Async Function() As Task
                          Await frmResumenDiarioViewModel.MostrarTotalVentaChequeAsync()
                      End Function)
    End Sub

    Private Sub SaldosSucursal_BtnCreditoClick(sender As Object, e As EventArgs) Handles SaldosSucursal.BtnCreditoClick
        EjecutarAsync(Async Function() As Task
                          Await frmResumenDiarioViewModel.MostrarTotalVentaTarjetaCreditoAsync()
                      End Function)
    End Sub

    Private Sub SaldosSucursal_BtnDebitoClick(sender As Object, e As EventArgs) Handles SaldosSucursal.BtnDebitoClick
        EjecutarAsync(Async Function() As Task
                          Await frmResumenDiarioViewModel.MostrarTotalVentaTarjetaDebitoAsync()
                      End Function)
    End Sub

    Private Sub SaldosSucursal_BtnDepositoClick(sender As Object, e As EventArgs) Handles SaldosSucursal.BtnDepositoClick
        EjecutarAsync(Async Function() As Task
                          Await frmResumenDiarioViewModel.MostrarTotalVentaDepositoAsync()
                      End Function)
    End Sub

    Private Sub SaldosSucursal_BtnFacturadoClick(sender As Object, e As EventArgs) Handles SaldosSucursal.BtnFacturadoClick
        EjecutarAsync(Async Function() As Task
                          Await frmResumenDiarioViewModel.MostrarTotalVentaFacturadoAsync()
                      End Function)
    End Sub

    Private Sub SaldosSucursal_BtnSinFacturadoClick(sender As Object, e As EventArgs) Handles SaldosSucursal.BtnSinFacturadoClick
        EjecutarAsync(Async Function() As Task
                          Await frmResumenDiarioViewModel.MostrarTotalVentaSinFacturarAsync()
                      End Function)
    End Sub

    Private Sub SaldosSucursal_BtnMayoristaClick(sender As Object, e As EventArgs) Handles SaldosSucursal.BtnMayoristaClick
        EjecutarAsync(Async Function() As Task
                          Await frmResumenDiarioViewModel.MostrarTotalVentaMayoristaAsync()
                      End Function)
    End Sub

    Private Sub SaldosSucursal_BtnMinoristaClick(sender As Object, e As EventArgs) Handles SaldosSucursal.BtnMinoristaClick
        EjecutarAsync(Async Function() As Task
                          Await frmResumenDiarioViewModel.MostrarTotalVentaMinoristaAsync()
                      End Function)
    End Sub

    Private Sub ModificarColor()
        ModificarColor(lbl_Total_Caja_Fuerte, frmResumenDiarioViewModel.TotalCajaFuerte)
        ModificarColor(lbl_Saldo, frmResumenDiarioViewModel.CajaChica)
        ModificarColor(lbl_DispoCheq, frmResumenDiarioViewModel.DisponibleCheque)
        ModificarColor(lbl_DispoEfect, frmResumenDiarioViewModel.DisponibleEfectivo)
    End Sub

    Private Sub ModificarColor(control As Control, valor As Decimal)
        If valor < 0 Then
            control.ForeColor = Color.Red
        Else
            control.ForeColor = Color.Green
        End If
    End Sub

    Private Sub NullParseHandler(ByVal sender As Object, ByVal e As ConvertEventArgs)
        If e.Value IsNot Nothing AndAlso String.IsNullOrEmpty(e.Value.ToString()) Then e.Value = Nothing
    End Sub

    Private Sub Ejecutar(accion As Action)
        Try
            accion()
        Catch ex As NegocioException
            Log.Error(ex)
            MessageBox.Show(ex.Message, "Registro de Ventas", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Catch ex As Exception
            Log.Error(ex)
            MessageBox.Show("Error al realizar la accion. Por favor, intente mas tarde o consulte con el administrador.", "Resumen Diario", MessageBoxButtons.OK, MessageBoxIcon.Error)
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
            MessageBox.Show("Error al realizar la accion. Por favor, intente mas tarde o consulte con el administrador.", "Resumen Diario", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
End Class