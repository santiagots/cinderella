
Namespace Formularios.Venta
    Public Class frmStockFaltanteViewModel
        Inherits Comunes.Common

        Public Property StockActual As Integer
        Public Property CodigoProdcuto As String
        Public Property StockIngresado As Integer

        Public Sub New(stockActual As Integer, codigoProdcuto As String, StockIngresado As Integer)
            Me.StockActual = stockActual
            Me.CodigoProdcuto = codigoProdcuto
            Me.StockIngresado = StockIngresado
        End Sub
    End Class
End Namespace
