Imports System.ComponentModel

Namespace Formularios.MovimientoDetalle

    Public Class frmMoviminetoDetalleViewModel(Of T)
        Inherits Comunes.Common

        Public Property Titulo As String
        Public Property MovimientoDetalle As BindingList(Of T)

        Sub New(titulo As String, movimientoDetalle As BindingList(Of T))
            Me.Titulo = titulo
            Me.MovimientoDetalle = movimientoDetalle
        End Sub
    End Class

End Namespace
