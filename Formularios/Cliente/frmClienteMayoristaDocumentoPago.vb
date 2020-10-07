Imports System.Threading.Tasks
Imports Common.Core.Enum
Imports SistemaCinderella.Formularios.Cliente
Imports Ventas.Core.Model.CuentaCorrienteAggregate

Public Class frmClienteMayoristaDocumentoPago
    Inherits Comun

    Dim frmClienteMayoristaCuentaCorrientePagoViewModel As frmClienteMayoristaDocumentoPagoViewModel

    Sub New(idClienteMayorista As Integer)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        frmClienteMayoristaCuentaCorrientePagoViewModel = New frmClienteMayoristaDocumentoPagoViewModel(My.Settings.Sucursal, idClienteMayorista)
    End Sub

    Sub New(documentoDePagoModel As DocumentoDePago)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        frmClienteMayoristaCuentaCorrientePagoViewModel = New frmClienteMayoristaDocumentoPagoViewModel(documentoDePagoModel)
    End Sub

    Private Sub frmClienteMayoristaCuentaCorrientePago_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        EjecutarAsync(Async Function() As Task
                          FrmClienteMayoristaCuentaCorrientePagoViewModelBindingSource.DataSource = frmClienteMayoristaCuentaCorrientePagoViewModel
                          Await frmClienteMayoristaCuentaCorrientePagoViewModel.CargarTarjetasAsync()
                          Await frmClienteMayoristaCuentaCorrientePagoViewModel.CargarEmpleadosAsync()
                          Await frmClienteMayoristaCuentaCorrientePagoViewModel.CargarSucursalAsync()
                          frmClienteMayoristaCuentaCorrientePagoViewModel.CargarFormaPago()
                          HabilitarSegunFormaDePago(Cb_FormaPago.SelectedValue)
                      End Function)
    End Sub

    Private Sub btnAgregaPago_Click(sender As Object, e As EventArgs) Handles btnAgregaPago.Click
        Ejecutar(Sub()
                     frmClienteMayoristaCuentaCorrientePagoViewModel.AgregarPago()
                 End Sub)
    End Sub

    Private Sub Btn_Cancelar_Click(sender As Object, e As EventArgs) Handles Btn_Cancelar.Click
        Me.Close()
    End Sub

    Private Sub Btn_Finalizar_Click(sender As Object, e As EventArgs) Handles Btn_Finalizar.Click
        EjecutarAsync(Async Function() As Task
                          Await frmClienteMayoristaCuentaCorrientePagoViewModel.GuardarAsync()
                          MessageBox.Show(My.Resources.GuardadoOk, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
                          Me.Close()
                      End Function)
    End Sub

    Private Sub BtnAnular_Click(sender As Object, e As EventArgs) Handles BtnAnular.Click
        EjecutarAsync(Async Function() As Task
                          Await frmClienteMayoristaCuentaCorrientePagoViewModel.AnularAsync()
                          MessageBox.Show(My.Resources.GuardadoOk, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
                          Me.Close()
                      End Function)
    End Sub

    Private Sub txt_Subtotal_KeyDown(sender As Object, e As KeyEventArgs) Handles txt_Subtotal.KeyDown
        Ejecutar(
            Sub()
                If (e.KeyData = Keys.Enter) Then
                    frmClienteMayoristaCuentaCorrientePagoViewModel.AgregarPago()
                End If
            End Sub)
    End Sub

    Private Sub txt_Total_KeyDown(sender As Object, e As KeyEventArgs) Handles txt_Total.KeyDown
        Ejecutar(
            Sub()
                If (e.KeyData = Keys.Enter) Then
                    frmClienteMayoristaCuentaCorrientePagoViewModel.AgregarPago()
                End If
            End Sub)
    End Sub

    Private Sub Cb_FormaPago_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles Cb_FormaPago.SelectionChangeCommitted
        Ejecutar(Sub()
                     HabilitarSegunFormaDePago(Cb_FormaPago.SelectedValue)
                     frmClienteMayoristaCuentaCorrientePagoViewModel.FormaPagoChange(Cb_FormaPago.SelectedValue)
                     Cb_Trajeta.SelectedItem = Nothing
                     Cb_NroCuota.SelectedItem = Nothing
                 End Sub)
    End Sub

    Private Sub Cb_Trajeta_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles Cb_Trajeta.SelectionChangeCommitted
        EjecutarAsync(Async Function() As Task
                          Await frmClienteMayoristaCuentaCorrientePagoViewModel.TarjetaChangeAsync(Cb_Trajeta.SelectedValue)
                      End Function)
    End Sub

    Private Sub Cb_NroCuota_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles Cb_NroCuota.SelectionChangeCommitted
        Ejecutar(Sub()
                     frmClienteMayoristaCuentaCorrientePagoViewModel.CuotaChange(Cb_NroCuota.SelectedValue)
                 End Sub)
    End Sub

    Private Sub dgPagos_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvPagos.CellContentClick
        Ejecutar(
            Sub()
                If (dgvPagos.Columns(e.ColumnIndex).Name = "Quitar") Then
                    frmClienteMayoristaCuentaCorrientePagoViewModel.QuitarPago(dgvPagos.CurrentRow.DataBoundItem)
                End If
            End Sub)
    End Sub

    Private Sub HabilitarSegunFormaDePago(tipoPago As TipoPago)
        Cb_Trajeta.Enabled = tipoPago = TipoPago.TarjetaCrédito OrElse tipoPago = TipoPago.TarjetaDébito
        Cb_NroCuota.Enabled = tipoPago = TipoPago.TarjetaCrédito
    End Sub
End Class