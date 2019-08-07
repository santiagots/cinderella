Imports System.Threading.Tasks
Imports Common.Core.Exceptions
Imports SistemaCinderella.Formularios.ResumenDiario

Public Class frmResumenDiario
    Private frmResumenDiarioViewModel As frmResumenDiarioViewModel

    Sub New()
        ' This call is required by the designer.
        InitializeComponent()

        frmResumenDiarioViewModel = New frmResumenDiarioViewModel(My.Settings.Sucursal, My.Settings.NombreSucursal)

        AddHandler txtMonto.DataBindings(0).Parse, AddressOf NullParseHandler
    End Sub

    Private Sub FrmResumenDiario3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        EjecutarAsync(Async Function() As Task
                          FrmResumenDiarioViewModelBindingSource.DataSource = frmResumenDiarioViewModel
                          SaldosSucursal.SaldoSucursalViewModelBindingSource.DataSource = frmResumenDiarioViewModel.Saldos
                          Await frmResumenDiarioViewModel.BuscarAsync()
                          ModificarColor()
                          SaldosSucursal.AutoScaleMode = AutoScaleMode.None
                      End Function)
    End Sub

    Private Sub Btn_Buscar_Click(sender As Object, e As EventArgs) Handles Btn_Buscar.Click
        EjecutarAsync(Async Function() As Task
                          Await frmResumenDiarioViewModel.BuscarAsync()
                          ModificarColor()
                      End Function)
    End Sub

    Private Sub Btn_Limpiar_Click(sender As Object, e As EventArgs) Handles Btn_Limpiar.Click
        EjecutarAsync(Async Function() As Task
                          Await frmResumenDiarioViewModel.LimpiarAsync()
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
                          End If
                      End Function)
    End Sub

    Private Sub Btn_Abrir_Click(sender As Object, e As EventArgs) Handles Btn_Abrir.Click
        EjecutarAsync(Async Function() As Task
                          If MessageBox.Show("Está seguro que desea abrir la caja diaria?", "Resumen Diario", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = vbYes AndAlso
                                MessageBox.Show("Realmente está seguro que desea abrir la caja diaria?", "Resumen Diario", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) = vbYes Then

                              Await frmResumenDiarioViewModel.AbrirCajaAsync()
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

    Private Sub ModificarColor()
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
            MessageBox.Show(ex.Message, "Registro de Ventas", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Catch ex As Exception
            MessageBox.Show("Error al realizar la accion. Por favor, intente mas tarde o consulte con el administrador.", "Resumen Diario", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Async Sub EjecutarAsync(accion As Func(Of Task))
        Try
            Await accion()
        Catch ex As NegocioException
            MessageBox.Show(ex.Message, "Registro de Ventas", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Catch ex As Exception
            MessageBox.Show("Error al realizar la accion. Por favor, intente mas tarde o consulte con el administrador.", "Resumen Diario", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
End Class