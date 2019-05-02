Imports Ventas.Data
Imports Common.Data.Repository
Imports Common.Core.Model
Imports Ventas.Data.Repository
Imports Ventas.Core.Interfaces
Imports Ventas.Core.Model.BaseAgreggate
Imports Common.Core.Interfaces
Imports Common.Data

Namespace Comunes
    Public Class Servicio
        Friend Shared Function ObtenerBancos() As IList(Of Banco)
            Using context As CommonContext = New CommonContext()
                Dim repository As Repository(Of Banco) = New Repository(Of Banco)(context)
                Return repository.List()
            End Using
        End Function

        Friend Shared Function ObtenerClienteMayorista(id As Integer) As Object
            Using context As CommonContext = New CommonContext()
                Dim clienteMayoristaRepository As IClienteMayoristaRepository = New ClienteMayoristaRepository(context)
                Return clienteMayoristaRepository.Obtener(id)
            End Using
        End Function
    End Class
End Namespace