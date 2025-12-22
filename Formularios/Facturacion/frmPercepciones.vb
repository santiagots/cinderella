Imports System.Threading.Tasks
Imports SistemaCinderella.Formularios.Facturacion

Public Class frmPercepciones
    Inherits Comun

    Private frmPercepcionesViewModel As frmPercepcionesViewModel = New frmPercepcionesViewModel()

    Private Sub frmPercepciones_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        EjecutarAsync(Async Function() As Task
                          Await frmPercepcionesViewModel.InicializarAsync()
                          FrmPercepcionesViewModelBindingSource.DataSource = frmPercepcionesViewModel
                          AltaBindingSource.DataSource = frmPercepcionesViewModel.PercepcionNueva
                          ModificacionBindingSource.DataSource = frmPercepcionesViewModel.PercepcionModificacion
                          Await frmPercepcionesViewModel.Cargar()
                      End Function)
    End Sub

    Private Sub Btn_Agregar_Click(sender As Object, e As EventArgs) Handles Btn_Agregar.Click
        EjecutarAsync(Async Function() As Task
                          frmPercepcionesViewModel.PercepcionNueva.Habilitada = True
                          Await frmPercepcionesViewModel.Guardar(frmPercepcionesViewModel.PercepcionNueva)
                          MessageBox.Show(My.Resources.GuardadoOk, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
                          Await frmPercepcionesViewModel.Cargar()
                          TabPercepciones.SelectedTab = TabPercepciones.TabPages("TbListado")
                      End Function)
    End Sub

    Private Sub Btn_Modificar_Click(sender As Object, e As EventArgs) Handles Btn_Modificar.Click
        EjecutarAsync(Async Function() As Task
                          Await frmPercepcionesViewModel.Guardar(frmPercepcionesViewModel.PercepcionModificacion)
                          MessageBox.Show(My.Resources.GuardadoOk, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
                          Await frmPercepcionesViewModel.Cargar()
                          TabPercepciones.SelectedTab = TabPercepciones.TabPages("TbListado")
                      End Function)
    End Sub

    Private Sub CbAltaTipoPercepcion_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles CbAltaTipoPercepcion.SelectionChangeCommitted
        Ejecutar(Sub()
                     frmPercepcionesViewModel.AltaTipoPercepcionChange(CbAltaTipoPercepcion.SelectedItem)
                     AltaBindingSource.ResetBindings(False)
                 End Sub)
    End Sub

    Private Sub CbModificacionTipoPercepcion_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles CbModificacionTipoPercepcion.SelectionChangeCommitted
        Ejecutar(Sub()
                     frmPercepcionesViewModel.ModificacionTipoPercepcionChange(CbModificacionTipoPercepcion.SelectedItem)
                     ModificacionBindingSource.ResetBindings(False)
                 End Sub)
    End Sub

    Private Sub DG_Percepcion_CellDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DG_Percepcion.CellDoubleClick
        TabPercepciones.SelectedTab = TabPercepciones.TabPages("TbMod")
    End Sub

    Private Sub TabPercepciones_Selected(ByVal sender As Object, ByVal e As System.Windows.Forms.TabControlEventArgs) Handles TabPercepciones.Selected
        If TabPercepciones.SelectedTab.Name = "TbMod" AndAlso DG_Percepcion.CurrentRow IsNot Nothing Then
            Ejecutar(Sub()
                         Dim percepcion As PercepcionItem = CType(DG_Percepcion.CurrentRow.DataBoundItem, PercepcionItem)
                         frmPercepcionesViewModel.Cargar(percepcion.PercepcionModel)
                         ModificacionBindingSource.ResetBindings(False)
                     End Sub)
        End If
    End Sub

    Private Sub DG_Percepcion_CellContentClick(ByVal sender As Object, ByVal e As DataGridViewCellEventArgs) Handles DG_Percepcion.CellContentClick
        EjecutarAsync(Async Function() As Task
                          If DG_Percepcion.Columns(e.ColumnIndex).Name = "Eliminar" Then

                              If MessageBox.Show("¿Está seguro que desea eliminar la percepción?", Me.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                                  Dim percepcion As PercepcionItem = CType(DG_Percepcion.CurrentRow.DataBoundItem, PercepcionItem)
                                  Await frmPercepcionesViewModel.Eliminar(percepcion)
                                  Await frmPercepcionesViewModel.Cargar()
                              End If

                          ElseIf DG_Percepcion.Columns(e.ColumnIndex).Name = "Modificar" Then
                              TabPercepciones.SelectedTab = TabPercepciones.TabPages("TbMod")
                          End If
                      End Function)


    End Sub
End Class