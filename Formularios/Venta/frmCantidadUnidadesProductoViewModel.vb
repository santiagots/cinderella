Imports SistemaCinderella.Formularios.Venta

Public Class frmCantidadUnidadesProducto

    Dim frmCantidadUnidadesProductoViewModel As frmCantidadUnidadesProductoViewModel

    Public ReadOnly Property CantidadUnidades As Integer
        Get
            Return frmCantidadUnidadesProductoViewModel.CantidadUnidades
        End Get
    End Property

    Sub New(codigoProducto As String)

        InitializeComponent()

        frmCantidadUnidadesProductoViewModel = New frmCantidadUnidadesProductoViewModel(codigoProducto)
    End Sub

    Private Sub FrmCantidadProductos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Ejecutar(Sub()
                     lblMensaje.Text = String.Format(lblMensaje.Text, frmCantidadUnidadesProductoViewModel.CodigoProducto)
                     FrmCantidadUnidadesProductoViewModelBindingSource.DataSource = frmCantidadUnidadesProductoViewModel
                 End Sub)
        Me.ActiveControl = txtUnidades
    End Sub

    Private Sub btnCargar_Click(sender As Object, e As EventArgs) Handles btnCargar.Click
        Me.DialogResult = DialogResult.OK
    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        Me.DialogResult = DialogResult.Cancel
    End Sub

    Private Sub lblMensaje_Click(sender As Object, e As EventArgs) Handles lblMensaje.Click

    End Sub
End Class