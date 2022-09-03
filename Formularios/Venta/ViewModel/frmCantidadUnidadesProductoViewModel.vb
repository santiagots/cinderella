Namespace Formularios.Venta

    Public Class frmCantidadUnidadesProductoViewModel
        Inherits Comunes.Common

        Public Property CodigoProducto As String

        Public Property CantidadUnidades As Integer

        Public Sub New(codigoProducto As String)
            Me.CodigoProducto = codigoProducto
            Me.CantidadUnidades = 1
        End Sub
    End Class

End Namespace
