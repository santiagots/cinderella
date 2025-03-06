Imports SistemaCinderella.Formularios.Comun

Public Class frmConfiguracionFacturacionImpuestos
    Inherits Comun

    Private frmConfiguracionFacturacionImpuestosViewModel As frmConfiguracionFacturacionImpuestosViewModel = New frmConfiguracionFacturacionImpuestosViewModel()

    Private Sub frmConfiguracionFacturacionImpuestos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Ejecutar(Sub()
                     frmConfiguracionFacturacionImpuestosViewModel.Inicializar()

                     RIVASi.Checked = frmConfiguracionFacturacionImpuestosViewModel.IVADiscirimiarSi
                     RIVANo.Checked = Not frmConfiguracionFacturacionImpuestosViewModel.IVADiscirimiarSi

                     FrmConfiguracionFacturacionImpuestosViewModelBindingSource.DataSource = frmConfiguracionFacturacionImpuestosViewModel
                 End Sub)
    End Sub

    Private Sub Btn_Agregar_Imp_Click(sender As Object, e As EventArgs) Handles Btn_Agregar_Imp.Click
        Ejecutar(Sub()
                     frmConfiguracionFacturacionImpuestosViewModel.GuardarImpuesto()
                 End Sub)
    End Sub

    Private Sub DG_Impuestos_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DG_Impuestos.CellContentClick

        Dim impuesto As FacturacionImpuestosViewModel = CType(DG_Impuestos.CurrentRow.DataBoundItem, FacturacionImpuestosViewModel)
        If DG_Impuestos.Columns(e.ColumnIndex).Name = "Eliminar" Then
            Dim Result As DialogResult = MessageBox.Show("¿Está seguro que desea eliminar el impuesto?", Me.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If (Result = DialogResult.Yes) Then
                frmConfiguracionFacturacionImpuestosViewModel.EliminarImpuesto(impuesto)
                MessageBox.Show(My.Resources.BorradoOk, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        ElseIf DG_Impuestos.Columns(e.ColumnIndex).Name = "Modificar" Then
                frmConfiguracionFacturacionImpuestosViewModel.ModificarImpuesto(impuesto)
        End If
    End Sub

    Private Sub BtnGuardar_Click(sender As Object, e As EventArgs) Handles BtnGuardar.Click
        Ejecutar(Sub()
                     frmConfiguracionFacturacionImpuestosViewModel.GuardarConfiguracion()
                     MessageBox.Show(My.Resources.GuardadoOk, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
                     Close()
                 End Sub)
    End Sub

    Private Sub Btn_Cancelar_Click(sender As Object, e As EventArgs) Handles Btn_Cancelar.Click
        Close()
    End Sub

    Private Sub RHabilitarSi_Click(sender As Object, e As EventArgs) Handles RHabilitarSi.Click
        Ejecutar(Sub()
                     frmConfiguracionFacturacionImpuestosViewModel.Refrescar()
                 End Sub)
    End Sub

    Private Sub RIVASi_Click(sender As Object, e As EventArgs) Handles RIVASi.Click
        Ejecutar(Sub()
                     frmConfiguracionFacturacionImpuestosViewModel.Refrescar()
                 End Sub)
    End Sub

    Private Sub RHabilitarNo_Click(sender As Object, e As EventArgs) Handles RHabilitarNo.Click
        Ejecutar(Sub()
                     frmConfiguracionFacturacionImpuestosViewModel.Refrescar()
                 End Sub)
    End Sub

    Private Sub RIVANo_Click(sender As Object, e As EventArgs) Handles RIVANo.Click
        Ejecutar(Sub()
                     frmConfiguracionFacturacionImpuestosViewModel.Refrescar()
                 End Sub)
    End Sub
End Class