Imports System.Threading.Tasks
Imports Common.Core.Exceptions
Imports Common.Core.Helper
Imports SistemaCinderella.Formularios.SucursalSaldo

Public Class frmCierreCajaAdministracion

    Dim frmCierreCajaViewModel As frmCierreCajaAdministracionViewModel
    Sub New()
        ' This call is required by the designer.
        InitializeComponent()

        frmCierreCajaViewModel = New frmCierreCajaAdministracionViewModel(My.Settings.Sucursal)
    End Sub

    Private Sub FrmResumenDiario_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        EjecutarAsync(Async Function() As Task
                          FrmCierreCajaViewModelBindingSource.DataSource = frmCierreCajaViewModel
                          Await frmCierreCajaViewModel.BuscarAsync()
                      End Function)
    End Sub

    Private Sub BtnFiltrar_Click(sender As Object, e As EventArgs) Handles BtnFiltrar.Click
        EjecutarAsync(Async Function() As Task
                          Await frmCierreCajaViewModel.BuscarAsync()
                      End Function)
    End Sub

    Private Sub Btn_Restablecer_Click(sender As Object, e As EventArgs) Handles btn_Restablecer.Click
        EjecutarAsync(Async Function() As Task
                          Await frmCierreCajaViewModel.RestablecerAsync()
                      End Function)
    End Sub

    Private Sub DG_CierreCaja_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DG_CierreCaja.CellContentClick
        If DG_CierreCaja.Columns(e.ColumnIndex).Name = "Detalle" Then
            Dim cierreCaja As CierreCajaItem = DG_CierreCaja.CurrentRow.DataBoundItem
            Dim frmCierreCaja As frmCierreCaja = New frmCierreCaja(cierreCaja.Fecha)
            frmCierreCaja.MdiParent = Me.MdiParent
            frmCierreCaja.Show()
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