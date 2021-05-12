Imports System.Threading.Tasks
Imports Common.Core.Model
Imports Common.Data.Service
Imports Stock.Data.Service
Imports Model = Stock.Core.Model.BaseAgreggate

Namespace Formularios.Stock
    Public Class frmStockMotivoViewModel
        Inherits Comunes.Common

        Private Usuario As Usuario
        Public Property Stock As Model.Stock
        Public ReadOnly Property Fecha As Date = Date.Now()
        Public ReadOnly Property UsuarioNombre As String
            Get
                Return Usuario.UsuarioNombre
            End Get
        End Property

        Public Property Motivo As String

        Public Sub New(stock As Model.Stock)
            Me.Stock = stock
            Usuario = New Usuario()
        End Sub

        Public Async Function CargarUsuario() As Task
            Usuario = Await UsuarioService.ObtenerAsync(VariablesGlobales.objUsuario.id_Usuario)

            NotifyPropertyChanged(NameOf(Me.Usuario))
        End Function

        Friend Async Function EliminarAsync() As Task
            Stock.Actualiza(Nothing, Nothing, Nothing, Nothing, Nothing, Motivo, True, Usuario)
            Await StockService.ActualizarAsync(Stock)
        End Function
    End Class
End Namespace