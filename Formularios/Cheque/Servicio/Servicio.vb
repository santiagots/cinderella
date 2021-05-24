Imports Common.Core.Enum
Imports Ventas.Core.Interfaces
Imports Model = Ventas.Core.Model.ChequeAggregate
Imports Ventas.Data
Imports Ventas.Data.Repository
Imports Ventas.Core.Model.ChequeAggregate

Namespace Formularios.Cheque
    Public Class Servicio
        Public Shared Function ActualizarCheque(cheque As Model.Cheque)
            Using context As VentaContext = New VentaContext()
                Dim chequeRepository As IChequeRepository = New ChequeRepository(context)
                chequeRepository.Actualizar(cheque)
            End Using
        End Function

        Friend Shared Function AltaCheque(cheque As Model.Cheque)
            Using context As VentaContext = New VentaContext()
                Dim chequeRepository As IChequeRepository = New ChequeRepository(context)
                chequeRepository.Alta(cheque)
            End Using
        End Function

        Public Shared Function BuscarCheque(idSucursal As Integer, facturado As Boolean?, cliente As String, librador As String, fechaIngresoDesde As DateTime?, fechaIngresoHasta As DateTime?, fechaDepositoDesde As DateTime?, fechaDepositoHasta As DateTime?, fechaVencimientoDesde As DateTime?, fechaVencimientoHasta As DateTime?, fechaSalidaDesde As DateTime?, fechaSalidaHasta As DateTime?, estado As IEnumerable(Of EstadoCheque), destinoSalida As IEnumerable(Of DestinoSalidaCheque), montoDesde As Decimal?, montoHasta As Decimal?, numero As Integer?, idBanco As Integer?) As IList(Of Model.Cheque)
            Using context As VentaContext = New VentaContext()
                Dim chequeRepository As IChequeRepository = New ChequeRepository(context)
                Return chequeRepository.Buscar(idSucursal, facturado, cliente, librador, fechaIngresoDesde, fechaIngresoHasta, fechaDepositoDesde, fechaDepositoHasta, fechaVencimientoDesde, fechaVencimientoHasta, fechaSalidaDesde, fechaSalidaHasta, estado, destinoSalida, montoDesde, montoHasta, numero, idBanco)
            End Using
        End Function

        Friend Shared Function TotalCarteraCheque(idSucursal As Integer) As Decimal
            Using context As VentaContext = New VentaContext()
                Dim chequeRepository As IChequeRepository = New ChequeRepository(context)
                Return chequeRepository.TotalCartera(idSucursal)
            End Using
        End Function

        Friend Shared Function ObtenerUltimoNumeroDeOrden(idSucursal As Integer) As Integer
            Using context As VentaContext = New VentaContext()
                Dim chequeRepository As IChequeRepository = New ChequeRepository(context)
                Return chequeRepository.UltimoNumeroDeOrden(idSucursal)
            End Using
        End Function

        Friend Shared Function ObtenerCheque(id As Long) As Model.Cheque
            Using context As VentaContext = New VentaContext()
                Dim chequeRepository As IChequeRepository = New ChequeRepository(context)
                Return chequeRepository.Obtener(id)
            End Using
        End Function
    End Class
End Namespace