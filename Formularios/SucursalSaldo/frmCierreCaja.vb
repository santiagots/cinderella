Imports SistemaCinderella.Formularios.SucursalSaldo
Imports System.Threading.Tasks
Imports Common.Core.Exceptions

Public Class frmCierreCaja

    Dim frmCierreCajaViewModel As frmCierreCajaViewModel

    Sub New()
        Me.New(DateTime.Now)
    End Sub

    Sub New(fecha As DateTime)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        frmCierreCajaViewModel = New frmCierreCajaViewModel(My.Settings.Sucursal, fecha)
    End Sub


    Private Sub FrmCierreCaja_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        EjecutarAsync(Async Function() As Task
                          FrmCierreCajaViewModelBindingSource.DataSource = frmCierreCajaViewModel
                          Await frmCierreCajaViewModel.ObtenerAsync()
                      End Function)
    End Sub

    Private Sub BtnRegistrar_Click(sender As Object, e As EventArgs) Handles btnRegistrar.Click
        EjecutarAsync(Async Function() As Task
                          Dim CajaCerrada As Boolean = Await frmCierreCajaViewModel.RegistrarAsync()
                          If CajaCerrada Then
                              MessageBox.Show("El cierre de caja se ha registrado correctamente.", "Cierre Caja", MessageBoxButtons.OK, MessageBoxIcon.Information)
                              If frmCierreCajaViewModel.Fecha.Date = DateTime.Now.Date Then
                                  'Oculto los menus.
                                  MDIContenedor.MenuAccesosRapidos.Visible = False
                                  MDIContenedor.ToolsMenu.Visible = False
                                  MDIContenedor.SeguridadToolStripMenuItem.Visible = False
                                  MDIContenedor.Btn_SincronizacionMenu.Visible = False
                                  MDIContenedor.BackgroundImageLayout = ImageLayout.Stretch
                                  MDIContenedor.Btn_ResumenDiario.Visible = True
                                  MDIContenedor.Refresh()
                              End If
                              Me.Close()
                          End If
                      End Function)
    End Sub

    Private Sub BtnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        EjecutarAsync(Async Function() As Task
                          Await frmCierreCajaViewModel.ObtenerAsync()
                      End Function)
    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        Me.Close()
    End Sub

    Private Sub Ejecutar(accion As Action)
        Try
            accion()
        Catch ex As NegocioException
            MessageBox.Show(ex.Message, "Registro de Ventas", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Catch ex As Exception
            MessageBox.Show("Error al realizar la accion. Por favor, intente mas tarde o consulte con el administrador.", "Cierre Caja", MessageBoxButtons.OK, MessageBoxIcon.Error)
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