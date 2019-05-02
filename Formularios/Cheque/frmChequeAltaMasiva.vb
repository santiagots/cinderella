Imports System.Threading.Tasks
Imports Common.Core.Exceptions
Imports SistemaCinderella.Formularios.Cheque
Imports Ventas.Core.Model.ChequeAggregate

Public Class frmChequeAltaMasiva

    Private frmChequeAltaMasivaViewModel As frmChequeAltaMasivaViewModel
    ReadOnly Property ChequesModel As List(Of Cheque)
        Get
            Return frmChequeAltaMasivaViewModel.ChequesModel
        End Get
    End Property

    Sub New(totalAPagar As Decimal, idClienteMayorista As Integer)
        ' This call is required by the designer.
        InitializeComponent()

        frmChequeAltaMasivaViewModel = New frmChequeAltaMasivaViewModel(My.Settings.Sucursal, totalAPagar, idClienteMayorista)
    End Sub

    Private Sub frmChequeAltaMasiva_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        EjecutarAsync(Async Function() As Task
                          ucChequeDetalle.AutoScaleMode = AutoScaleMode.None
                          Await frmChequeAltaMasivaViewModel.CargarDatosAsync()
                          FrmChequeAltaMasivaViewModelBindingSource.DataSource = frmChequeAltaMasivaViewModel
                          ucChequeDetalle.ChequeDetalleViewModelBindingSource.DataSource = frmChequeAltaMasivaViewModel.ChequeDetalle
                      End Function)
    End Sub

    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click
        Ejecutar(Sub()
                     frmChequeAltaMasivaViewModel.AgregaNormal()
                     ucChequeDetalle.ChequeDetalleViewModelBindingSource.ResetBindings(False)
                 End Sub)
    End Sub

    Private Sub btnAgregarConsecutivo_Click(sender As Object, e As EventArgs) Handles btnAgregarConsecutivo.Click
        Ejecutar(Sub()
                     frmChequeAltaMasivaViewModel.AgregaConsecutivo()
                     ucChequeDetalle.ChequeDetalleViewModelBindingSource.ResetBindings(False)
                 End Sub)
    End Sub

    Private Sub btnAceptar_Click(sender As Object, e As EventArgs) Handles btnAceptar.Click
        Me.DialogResult = DialogResult.OK
        Me.Dispose()
    End Sub

    Private Sub Btn_Salir_Click(sender As Object, e As EventArgs) Handles Btn_Salir.Click
        Me.DialogResult = DialogResult.Cancel
        Dispose()
    End Sub

    Private Sub dgCheques_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgCheques.CellContentClick
        Ejecutar(Sub()
                     If dgCheques.Columns(e.ColumnIndex).Name = "Quitar" Then
                         Dim cheque As ChequeAdministracionItemViewModel = dgCheques.CurrentRow.DataBoundItem
                         frmChequeAltaMasivaViewModel.Quitar(cheque.Id)
                         ucChequeDetalle.ChequeDetalleViewModelBindingSource.ResetBindings(False)
                     End If
                 End Sub)
    End Sub

    Private Sub dgCheques_CellFormatting(sender As Object, e As DataGridViewCellFormattingEventArgs) Handles dgCheques.CellFormatting
        If (dgCheques.Columns(e.ColumnIndex).Name = "MarcaFacturado") Then
            e.Value = If(e.Value, "Si", "No")
        End If
    End Sub

    Private Sub Ejecutar(accion As Action)
        Try
            accion()
        Catch ex As NegocioException
            MessageBox.Show(ex.Message, "Registro de Ventas", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Catch ex As Exception
            MessageBox.Show("Error al realizar la accion. Por favor, intente mas tarde o consulte con el administrador.", "Registro de Ventas", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Async Sub EjecutarAsync(accion As Func(Of Task))
        Try
            Await accion()
        Catch ex As NegocioException
            MessageBox.Show(ex.Message, "Registro de Ventas", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Catch ex As Exception
            MessageBox.Show("Error al realizar la accion. Por favor, intente mas tarde o consulte con el administrador.", "Administración de Cheques", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
End Class