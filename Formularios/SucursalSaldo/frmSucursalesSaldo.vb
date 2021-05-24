Imports System.Threading.Tasks
Imports Common.Core.Exceptions
Imports Common.Core.Helper
Imports SistemaCinderella.Formularios.SucursalSaldo

Public Class frmSucursalesSaldo

    Dim frmSucursalesSaldoViewModel As frmSucursalesSaldoViewModel

    Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        frmSucursalesSaldoViewModel = New frmSucursalesSaldoViewModel(My.Settings.Sucursal, My.Settings.NombreSucursal)
    End Sub

    Private Sub FrmSucursalesSaldo2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        EjecutarAsync(Async Function() As Task
                          FrmSucursalesSaldoViewModelBindingSource.DataSource = frmSucursalesSaldoViewModel
                          Await frmSucursalesSaldoViewModel.CargarSaldoAsync()
                          SaldosSucursal.SaldoSucursalViewModelBindingSource.DataSource = frmSucursalesSaldoViewModel.Saldos
                          ModificarColor()
                          SaldosSucursal.AutoScaleMode = AutoScaleMode.None
                      End Function)
    End Sub

    Private Sub Btn_Buscar_Click(sender As Object, e As EventArgs) Handles Btn_Buscar.Click
        EjecutarAsync(Async Function() As Task
                          Await frmSucursalesSaldoViewModel.CargarSaldoAsync()
                          SaldosSucursal.SaldoSucursalViewModelBindingSource.ResetBindings(False)
                          ModificarColor()
                      End Function)
    End Sub

    Private Sub Btn_Limpiar_Click(sender As Object, e As EventArgs) Handles Btn_Limpiar.Click
        EjecutarAsync(Async Function() As Task
                          Await frmSucursalesSaldoViewModel.LimpiarAsync()
                          SaldosSucursal.SaldoSucursalViewModelBindingSource.ResetBindings(False)
                          ModificarColor()
                      End Function)
    End Sub

    Private Sub Btn_Salir_Click(sender As Object, e As EventArgs) Handles Btn_Salir.Click
        Me.Close()
    End Sub

    Private Sub SaldosSucursal_BtnDevolucionesClick(sender As Object, e As EventArgs) Handles SaldosSucursal.BtnDevolucionesClick
        EjecutarAsync(Async Function() As Task
                          Await frmSucursalesSaldoViewModel.MostrarDevolucionesAsyn()
                      End Function)
    End Sub

    Private Sub SaldosSucursal_BtnSueldoClick(sender As Object, e As EventArgs) Handles SaldosSucursal.BtnSueldoClick
        EjecutarAsync(Async Function() As Task
                          Await frmSucursalesSaldoViewModel.MostrarSueldosAsyn()
                      End Function)
    End Sub

    Private Sub SaldosSucursal_BtnGastoClick(sender As Object, e As EventArgs) Handles SaldosSucursal.BtnGastoClick
        EjecutarAsync(Async Function() As Task
                          Await frmSucursalesSaldoViewModel.MostrarGastosAsyn()
                      End Function)
    End Sub

    Private Sub SaldosSucursal_BtnImpuestoClick(sender As Object, e As EventArgs) Handles SaldosSucursal.BtnImpuestoClick
        EjecutarAsync(Async Function() As Task
                          Await frmSucursalesSaldoViewModel.MostrarImpuestosAsyn()
                      End Function)
    End Sub

    Private Sub SaldosSucursal_BtnEfectivoEgresoClick(sender As Object, e As EventArgs) Handles SaldosSucursal.BtnEfectivoEgresoClick
        EjecutarAsync(Async Function() As Task
                          Await frmSucursalesSaldoViewModel.MostrarEfectivoEgresosAsyn()
                      End Function)
    End Sub

    Private Sub SaldosSucursal_BtnPendienteAutorizacionClick(sender As Object, e As EventArgs) Handles SaldosSucursal.BtnPendienteAutorizacionClick
        EjecutarAsync(Async Function() As Task
                          Await frmSucursalesSaldoViewModel.MostrarPendienteAutorizacionEgresosAsync()
                      End Function)
    End Sub

    Private Sub SaldosSucursal_BtnFaltanteClick(sender As Object, e As EventArgs) Handles SaldosSucursal.BtnFaltanteClick
        EjecutarAsync(Async Function() As Task
                          Await frmSucursalesSaldoViewModel.MostrarFaltanteCajaAsync()
                      End Function)
    End Sub

    Private Sub SaldosSucursal_BtnRetiroClick(sender As Object, e As EventArgs) Handles SaldosSucursal.BtnRetiroClick
        EjecutarAsync(Async Function() As Task
                          Await frmSucursalesSaldoViewModel.MostrarRetiroSocioAsync()
                      End Function)
    End Sub

    Private Sub SaldosSucursal_BtnVentaClick(sender As Object, e As EventArgs) Handles SaldosSucursal.BtnVentaClick
        EjecutarAsync(Async Function() As Task
                          Await frmSucursalesSaldoViewModel.MostrarTotalVentaAsync()
                      End Function)
    End Sub

    Private Sub SaldosSucursal_BtnEfectivoIngresoClick(sender As Object, e As EventArgs) Handles SaldosSucursal.BtnEfectivoIngresoClick
        EjecutarAsync(Async Function() As Task
                          Await frmSucursalesSaldoViewModel.MostrarEfectivoIngresoAsyn()
                      End Function)
    End Sub

    Private Sub SaldosSucursal_BtnSobranteClick(sender As Object, e As EventArgs) Handles SaldosSucursal.BtnSobranteClick
        EjecutarAsync(Async Function() As Task
                          Await frmSucursalesSaldoViewModel.MostrarSobranteCajaAsync()
                      End Function)
    End Sub

    Private Sub SaldosSucursal_BtnAporteClick(sender As Object, e As EventArgs) Handles SaldosSucursal.BtnAporteClick
        EjecutarAsync(Async Function() As Task
                          Await frmSucursalesSaldoViewModel.MostrarAporteSocioAsync()
                      End Function)
    End Sub

    Private Sub SaldosSucursal_BtnIngresoCajaFuerteClick(sender As Object, e As EventArgs) Handles SaldosSucursal.BtnIngresoCajaFuerteClick
        EjecutarAsync(Async Function() As Task
                          Await frmSucursalesSaldoViewModel.MostrarIngresoCajaFuerteAsync()
                      End Function)
    End Sub

    Private Sub SaldosSucursal_BtnEgresoCajaFuerteClick(sender As Object, e As EventArgs) Handles SaldosSucursal.BtnEgresoCajaFuerteClick
        EjecutarAsync(Async Function() As Task
                          Await frmSucursalesSaldoViewModel.MostrarEgresoCajaFuerteAsync()
                      End Function)
    End Sub

    Private Sub SaldosSucursal_BtnEfectivoClick(sender As Object, e As EventArgs) Handles SaldosSucursal.BtnEfectivoClick
        EjecutarAsync(Async Function() As Task
                          Await frmSucursalesSaldoViewModel.MostrarTotalVentaEfectivoAsync()
                      End Function)
    End Sub

    Private Sub SaldosSucursal_BtnChequeClick(sender As Object, e As EventArgs) Handles SaldosSucursal.BtnChequeClick
        EjecutarAsync(Async Function() As Task
                          Await frmSucursalesSaldoViewModel.MostrarTotalVentaChequeAsync()
                      End Function)
    End Sub

    Private Sub SaldosSucursal_BtnCreditoClick(sender As Object, e As EventArgs) Handles SaldosSucursal.BtnCreditoClick
        EjecutarAsync(Async Function() As Task
                          Await frmSucursalesSaldoViewModel.MostrarTotalVentaTarjetaCreditoAsync()
                      End Function)
    End Sub

    Private Sub SaldosSucursal_BtnDebitoClick(sender As Object, e As EventArgs) Handles SaldosSucursal.BtnDebitoClick
        EjecutarAsync(Async Function() As Task
                          Await frmSucursalesSaldoViewModel.MostrarTotalVentaTarjetaDebitoAsync()
                      End Function)
    End Sub

    Private Sub SaldosSucursal_BtnDepositoClick(sender As Object, e As EventArgs) Handles SaldosSucursal.BtnDepositoClick
        EjecutarAsync(Async Function() As Task
                          Await frmSucursalesSaldoViewModel.MostrarTotalVentaDepositoAsync()
                      End Function)
    End Sub

    Private Sub SaldosSucursal_BtnFacturadoClick(sender As Object, e As EventArgs) Handles SaldosSucursal.BtnFacturadoClick
        EjecutarAsync(Async Function() As Task
                          Await frmSucursalesSaldoViewModel.MostrarTotalVentaFacturadoAsync()
                      End Function)
    End Sub

    Private Sub SaldosSucursal_BtnSinFacturadoClick(sender As Object, e As EventArgs) Handles SaldosSucursal.BtnSinFacturadoClick
        EjecutarAsync(Async Function() As Task
                          Await frmSucursalesSaldoViewModel.MostrarTotalVentaSinFacturadoAsync()
                      End Function)
    End Sub

    Private Sub SaldosSucursal_BtnMayoristaClick(sender As Object, e As EventArgs) Handles SaldosSucursal.BtnMayoristaClick
        EjecutarAsync(Async Function() As Task
                          Await frmSucursalesSaldoViewModel.MostrarTotalVentaMayoristaAsync()
                      End Function)
    End Sub

    Private Sub SaldosSucursal_BtnMinoristaClick(sender As Object, e As EventArgs) Handles SaldosSucursal.BtnMinoristaClick
        EjecutarAsync(Async Function() As Task
                          Await frmSucursalesSaldoViewModel.MostrarTotalVentaMinoristaAsync()
                      End Function)
    End Sub

    Private Sub ModificarColor()
        ModificarColor(lbl_TotalCajaFuerte, frmSucursalesSaldoViewModel.TotalCajaFuerte)
        ModificarColor(lbl_TotalIngresos, frmSucursalesSaldoViewModel.Saldo)
        ModificarColor(lbl_DisponibleTotal, frmSucursalesSaldoViewModel.Disponible)
    End Sub

    Private Sub ModificarColor(control As Control, valor As Decimal)
        If valor < 0 Then
            control.ForeColor = Color.Red
        Else
            control.ForeColor = Color.Green
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