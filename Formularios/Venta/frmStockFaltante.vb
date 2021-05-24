Imports System.Threading.Tasks
Imports SistemaCinderella.Formularios.Venta

Public Class frmStockFaltante
    Public ReadOnly Property StockIngresado As Integer
        Get
            Return frmStockFaltanteViewModel.StockIngresado
        End Get
    End Property

    Dim frmStockFaltanteViewModel As frmStockFaltanteViewModel

    Sub New()

        InitializeComponent()
    End Sub

    Sub New(codigoProducto As String, stockCargado As Integer, stockDisponible As Integer)

        InitializeComponent()

        frmStockFaltanteViewModel = New frmStockFaltanteViewModel(stockDisponible, codigoProducto, stockCargado)
    End Sub

    Private Sub frmStockFaltante_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Ejecutar(Sub()
                     lblMensaje.Text = String.Format(lblMensaje.Text, frmStockFaltanteViewModel.CodigoProdcuto, frmStockFaltanteViewModel.StockActual)
                     FrmStockFaltanteViewModelBindingSource.DataSource = frmStockFaltanteViewModel
                 End Sub)
        Me.ActiveControl = txtStock
    End Sub


    Private Sub btnCargar_Click(sender As Object, e As EventArgs) Handles btnCargar.Click

        DialogResult = Windows.Forms.DialogResult.OK
    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        DialogResult = Windows.Forms.DialogResult.Cancel
    End Sub
End Class