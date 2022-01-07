Imports System.Threading.Tasks
Imports Common.Core.Enum
Imports Datos
Imports SistemaCinderella.Formularios.Comun

Public Class frmConfiguracionBaseDatos
    Inherits Comun

    Private frmConfiguracionBaseDatosViewModel As frmConfiguracionBaseDatosViewModel = New frmConfiguracionBaseDatosViewModel()
    Private Sub frmConfiguracionBaseDatos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Ejecutar(Sub()
                     If (frmConfiguracionBaseDatosViewModel.TipoConexionBaseLocal = TipoConexionBaseLocal.Aislado) Then
                         Chk_Aislado.Checked = True
                     Else
                         Chk_Red.Checked = True
                     End If

                     FrmConfiguracionBaseDatosViewModelBindingSource.DataSource = frmConfiguracionBaseDatosViewModel
                 End Sub)
    End Sub

    Private Sub btnVerificarBaseLocal_Click(sender As Object, e As EventArgs) Handles btnVerificarBaseLocal.Click
        EjecutarAsync(Async Function() As Task
                          Await frmConfiguracionBaseDatosViewModel.VerificarConexionBaseDatos(frmConfiguracionBaseDatosViewModel.ObtenerStringDeConexionLocal(frmConfiguracionBaseDatosViewModel.NombreBaseDatosLocalRed))
                          MessageBox.Show("La conexión a la base de datos ha sido exitosa.", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
                      End Function)
    End Sub

    Private Sub btnVerificarBaseRemota_Click(sender As Object, e As EventArgs) Handles btnVerificarBaseRemota.Click
        EjecutarAsync(Async Function() As Task
                          Await frmConfiguracionBaseDatosViewModel.VerificarConexionBaseDatos(frmConfiguracionBaseDatosViewModel.ObtenerStringDeConexionRemoto())
                          MessageBox.Show("La conexión a la base de datos ha sido exitosa.", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
                      End Function)
    End Sub

    Private Sub btnCrearBaseLocal_Click(sender As Object, e As EventArgs) Handles btnCrearBaseLocal.Click
        EjecutarAsync(Async Function() As Task
                          Dim respuestas As DialogResult = MessageBox.Show("¿Está seguro de que desea crear una nueva base de datos?", Me.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                          If (respuestas = DialogResult.No) Then
                              Return
                          End If
                          Await frmConfiguracionBaseDatosViewModel.CrearBaseDatosLocal()
                          MessageBox.Show("La base de datos ha sido creada de forma exitosa.", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
                      End Function)
    End Sub

    Private Sub btnDescargarBaseRemota_Click(sender As Object, e As EventArgs) Handles btnDescargarBaseRemota.Click
        EjecutarAsync(Async Function() As Task
                          Dim respuestas As DialogResult = MessageBox.Show("¿Está seguro de que desea descargar la base de datos en la ubicación de la base local? Esto va a generar la perdida de datos en la base local.", Me.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                          If (respuestas = DialogResult.No) Then
                              Return
                          End If
                          Await frmConfiguracionBaseDatosViewModel.CopiarEsquemaBaseDatos()
                          MessageBox.Show("La base de datos ha sido descargada de forma exitosa.", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
                      End Function)
    End Sub

    Private Sub DG_Servidores_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DG_Servidores.CellClick
        Ejecutar(Sub()
                     Dim servidorSeleccionado As ServidorBaseDatos = DG_Servidores.CurrentRow.DataBoundItem
                     frmConfiguracionBaseDatosViewModel.ActualizarServidorSeleccionado(servidorSeleccionado)
                 End Sub)
    End Sub

    Private Sub Chk_Aislado_CheckedChanged(sender As Object, e As EventArgs) Handles Chk_Aislado.CheckedChanged
        EjecutarAsync(Async Function() As Task
                          If (Chk_Aislado.Checked) Then
                              Await frmConfiguracionBaseDatosViewModel.ActualizarTipoConexionBaseLocal(TipoConexionBaseLocal.Aislado)
                          End If
                      End Function)
    End Sub

    Private Sub Chk_Red_CheckedChanged(sender As Object, e As EventArgs) Handles Chk_Red.CheckedChanged
        EjecutarAsync(Async Function() As Task
                          If (Chk_Red.Checked) Then
                              Await frmConfiguracionBaseDatosViewModel.ActualizarTipoConexionBaseLocal(TipoConexionBaseLocal.Red)
                          End If
                      End Function)
    End Sub

    Private Sub Btn_Aceptar_Click(sender As Object, e As EventArgs) Handles Btn_Aceptar.Click
        EjecutarAsync(Async Function() As Task
                          Await frmConfiguracionBaseDatosViewModel.ActualizarConfiguracion()
                          MessageBox.Show(My.Resources.GuardadoOk, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
                          Me.Close()
                      End Function)
    End Sub

    Private Sub Btn_Cancelar_Click(sender As Object, e As EventArgs) Handles Btn_Cancelar.Click
        Me.Close()
    End Sub
End Class