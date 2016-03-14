Imports Entidades
Imports Negocio

Public Class frmBanco

    Private Bancos As List(Of Banco) = New List(Of Banco)()

    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click

        If txtNombre.Text = String.Empty Then
            MessageBox.Show("El banco no puede ser agregado. Debe ingresar un nombre de entidad.", "Administración de bancos", MessageBoxButtons.OK, MessageBoxIcon.Stop)
            Return
        End If

        Bancos = NegBanco.TraerBancos()
        If (Bancos.Where(Function(x) x.Nombre = txtNombre.Text).Any()) Then
            MessageBox.Show("El banco no puede ser agregado. El nombre de entidad ya existe, por favor ingrese un nuevo valor.", "Administración de bancos", MessageBoxButtons.OK, MessageBoxIcon.Stop)
            Return
        End If

        Dim Banco As Banco = New Banco()

        Banco.Habilitado = chkHabilitado.Checked
        Banco.Nombre = txtNombre.Text
        Try
            NegBanco.AltaModificacionCheque(Banco)

            Bancos = NegBanco.TraerBancos()
            BancoBindingSource.DataSource = Bancos
        Catch ex As Exception
            MessageBox.Show("Se ha encontrado un error al agregar el banco. Por favor, vuelva a intentar más tarde o contáctese con el Administrador ", "Administración de bancos", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

        MessageBox.Show("El banco se agrego correctamente.", "Administración de bancos", MessageBoxButtons.OK, MessageBoxIcon.Information)

    End Sub

    Private Sub BtnActualizar_Click(sender As Object, e As EventArgs) Handles BtnActualizar.Click
        If txtNombre.Text = String.Empty Then
            MessageBox.Show("El banco no puede Modificado. Debe ingresar un nombre de entidad.", "Administración de bancos", MessageBoxButtons.OK, MessageBoxIcon.Stop)
            Return
        End If

        If (Bancos.Where(Function(x) x.Nombre = txtNombre.Text).Any()) Then
            MessageBox.Show("El banco no puede ser agregado. El nombre de entidad ya existe, por favor ingrese un nuevo valor.", "Administración de bancos", MessageBoxButtons.OK, MessageBoxIcon.Stop)
            Return
        End If

        Dim Banco As Banco = New Banco()

        Banco.Habilitado = chkHabilitado.Checked
        Banco.Nombre = txtNombre.Text
        Banco.BancoId = dgvBancos.CurrentRow.Cells(0).Value
        Try
            NegBanco.AltaModificacionCheque(Banco)

            BancoBindingSource.DataSource = NegBanco.TraerBancos()
        Catch ex As Exception
            MessageBox.Show("Se ha encontrado un error al modificar el banco. Por favor, vuelva a intentar más tarde o contáctese con el Administrador ", "Administración de bancos", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

        MessageBox.Show("El banco se modificó correctamente.", "Administración de bancos", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub frmBanco_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Bancos = NegBanco.TraerBancos()
        BancoBindingSource.DataSource = Bancos
    End Sub

    Private Sub dgvBancos_RowEnter(sender As Object, e As DataGridViewCellEventArgs) Handles dgvBancos.RowEnter
        If (dgvBancos.Focused) Then
            chkHabilitado.Checked = dgvBancos.Rows(e.RowIndex).Cells(2).Value
            txtNombre.Text = dgvBancos.Rows(e.RowIndex).Cells(1).Value
        End If
    End Sub

    Private Sub txtNombre_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtNombre.KeyPress
        chkHabilitado.Checked = True
    End Sub
End Class