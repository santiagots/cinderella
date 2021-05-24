Imports System.Threading.Tasks
Imports Common.Core.Exceptions
Imports Common.Core.Helper
Imports SistemaCinderella.Formularios.Reserva
Imports SistemaCinderella.VistaModelo.Ventas

Public Class frmReservaAdministracion

    Public frmReservaAdministracionViewModel As frmReservaAdministracionViewModel


    Sub New()
        ' This call is required by the designer.
        InitializeComponent()

        frmReservaAdministracionViewModel = New frmReservaAdministracionViewModel(My.Settings.Sucursal, Me.MdiParent)
    End Sub

    Private Sub frmReservaAdministracion_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        EjecutarAsync(Async Function() As Task
                          FrmReservaAdministracionViewModelBindingSource.DataSource = frmReservaAdministracionViewModel
                          ReservaDetalle1.AutoScaleMode = AutoScaleMode.None
                          ReservaDetalle1.Btn_BuscarConsumidorFinal.Visible = False
                          frmReservaAdministracionViewModel.CargarMetodosEntregas()
                          Await frmReservaAdministracionViewModel.BuscarAsync()
                      End Function)
    End Sub

    Private Sub BtnFiltrar_Click(sender As Object, e As EventArgs) Handles BtnFiltrar.Click
        EjecutarAsync(Async Function() As Task
                          Await frmReservaAdministracionViewModel.BuscarAsync()
                      End Function)
    End Sub

    Private Sub btn_Restablecer_Click(sender As Object, e As EventArgs) Handles btn_Restablecer.Click
        EjecutarAsync(Async Function() As Task
                          Await frmReservaAdministracionViewModel.RestablecerAsync()
                      End Function)
    End Sub

    Private Sub dgReservas_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgReservas.CellContentClick
        EjecutarAsync(Async Function() As Task
                          If dgReservas.Columns(e.ColumnIndex).Name = "ReservaEliminar" Then
                              Dim respuesta As DialogResult = MessageBox.Show("¿Está seguro que desea eliminar la reserva?", "Administración de Reservas", MessageBoxButtons.YesNo, MessageBoxIcon.Information)
                              If respuesta = DialogResult.Yes Then
                                  Await frmReservaAdministracionViewModel.EliminarReservaAsync(dgReservas.CurrentRow.DataBoundItem)
                              End If
                          End If

                          If dgReservas.Columns(e.ColumnIndex).Name = "ReservaImprimir" Then
                              Await frmReservaAdministracionViewModel.ImprimirReservaAsync(dgReservas.CurrentRow.DataBoundItem)
                          End If

                          ReservaDetalle1.ReservaDetalleBindingSource.DataSource = frmReservaAdministracionViewModel.ReservaDetalleSeleccionada
                          ReservaDetalle1.VentaDetalle1.VentaDetalleBindingSource.DataSource = frmReservaAdministracionViewModel.VentaDetalleSeleccionada
                      End Function)
    End Sub

    Private Sub tabAdministracionReservas_Selected(sender As Object, e As TabControlEventArgs) Handles tabAdministracionReservas.Selected
        EjecutarAsync(Async Function() As Task
                          If (tabAdministracionReservas.SelectedTab.Name = tabDetalle.Name) Then
                              If (dgReservas.CurrentRow Is Nothing) Then
                                  MessageBox.Show("No se encuentra una reserva seleccionada. Para ver el detalle de una reserva debe seleccionar una.", "Administración de Reservas", MessageBoxButtons.OK, MessageBoxIcon.Error)
                                  tabAdministracionReservas.SelectedTab = tabAdministracion
                                  Return
                              End If
                              Await frmReservaAdministracionViewModel.CargarReservaAsync(dgReservas.CurrentRow.DataBoundItem)
                              ReservaDetalle1.ReservaDetalleBindingSource.DataSource = frmReservaAdministracionViewModel.ReservaDetalleSeleccionada
                              ReservaDetalle1.VentaDetalle1.VentaDetalleBindingSource.DataSource = frmReservaAdministracionViewModel.VentaDetalleSeleccionada
                          End If
                      End Function)
    End Sub

    Private Sub dgReservas_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgReservas.CellDoubleClick
        Ejecutar(Sub()
                     'ReservaDetalle1.ReservaDetalleBindingSource.DataSource = frmReservaAdministracionViewModel.ReservaDetalleSeleccionada
                     'ReservaDetalle1.VentaDetalle1.VentaDetalleBindingSource.DataSource = frmReservaAdministracionViewModel.VentaDetalleSeleccionada
                     tabAdministracionReservas.SelectedTab = tabDetalle
                 End Sub)
    End Sub

    Private Sub btnRetirar_Click(sender As Object, e As EventArgs) Handles btnRetirar.Click
        Ejecutar(Sub()
                     frmReservaAdministracionViewModel.RetirarVenta()
                     Dispose()
                 End Sub)
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