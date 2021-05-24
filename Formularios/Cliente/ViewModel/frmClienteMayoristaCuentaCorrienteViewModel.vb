Imports System.ComponentModel
Imports System.Threading.Tasks
Imports Common.Core.Enum
Imports Common.Core.Exceptions
Imports Common.Core.Model
Imports Ventas.Core.Enum
Imports Ventas.Core.Model.CuentaCorrienteAggregate
Imports Ventas.Core.Model.NotaPedidoAgreggate
Imports Ventas.Data.Service
Imports Modelo = Ventas.Core.Model.VentaAggregate

Namespace Formularios.Cliente
    Public Class frmClienteMayoristaCuentaCorrienteViewModel
        Inherits Comunes.Common

        Private Const MovimientosOrdenadoPor As String = "Fecha"
        Private Const MovimientosDireccionOrdenamiento As OrdenadoDireccion = OrdenadoDireccion.DESC

        Private _ClienteMayorista As ClienteMayorista
        Public ReadOnly Property ClienteMayorista As ClienteMayorista
            Get
                Return _ClienteMayorista
            End Get
        End Property

        Public ReadOnly Property IdClienteMayorista As Integer
            Get
                Return ClienteMayorista.Id
            End Get
        End Property
        Public ReadOnly Property RazonSocial As String
            Get
                Return ClienteMayorista.RazonSocial
            End Get
        End Property
        Public Property Saldo As Decimal
        Public Property FechaBusquedaDesde As Date = Date.Now.AddMonths(-1)
        Public Property FechaBusquedaHasta As Date = Date.Now
        Public Property Movimientos As BindingList(Of CuentaCorrienteMovimientosItem) = New BindingList(Of CuentaCorrienteMovimientosItem)()
        Public Property NotasPedidos As BindingList(Of CuentaCorrienteNotaPedidoItems) = New BindingList(Of CuentaCorrienteNotaPedidoItems)()
        Public ReadOnly Property MovimientosSinResultados As Boolean
            Get
                Return Not Movimientos.Any()
            End Get
        End Property

        Public ReadOnly Property NotasPedidoSinResultados As Boolean
            Get
                Return Not NotasPedidos.Any()
            End Get
        End Property

        Public Property MovimientosPaginaActual As Integer = 1
        Public Property MovimientosElementosPorPagina As Integer
        Public Property MovimientosTotalElementos As Integer

        Public Property NotasPedidosOrdenadoPor As String = "Fecha"
        Public Property NotasPedidosDireccionOrdenamiento As OrdenadoDireccion = OrdenadoDireccion.DESC
        Public Property NotasPedidosPaginaActual As Integer = 1
        Public Property NotasPedidosElementosPorPagina As Integer
        Public Property NotasPedidosTotalElementos As Integer


        Sub New(clienteMayorista As ClienteMayorista)
            _ClienteMayorista = clienteMayorista
            Saldo = clienteMayorista.MontoCuentaCorriente
        End Sub

        Friend Async Function CargarMovimientosAsync() As Task
            Movimientos.Clear()

            Dim MovimientosModel As List(Of Movimiento) = Await MovimientoService.ObtenerMovimientosAsync(TipoBase.Remota, IdClienteMayorista, FechaBusquedaDesde, FechaBusquedaHasta, MovimientosOrdenadoPor, MovimientosDireccionOrdenamiento, MovimientosPaginaActual, MovimientosElementosPorPagina, MovimientosTotalElementos)
            MovimientosModel.ForEach(Sub(x) Movimientos.Add(New CuentaCorrienteMovimientosItem(x)))
            NotifyPropertyChanged(NameOf(Me.Movimientos))
        End Function

        Friend Async Function CargarNotasPedidoAsync() As Task
            NotasPedidos.Clear()

            Dim NotasPedidosModel As List(Of NotaPedido) = Await NotaPedidoService.BuscarAsync(TipoBase.Remota, IdClienteMayorista, Nothing, NotasPedidosOrdenadoPor, NotasPedidosDireccionOrdenamiento, NotasPedidosPaginaActual, NotasPedidosElementosPorPagina, NotasPedidosTotalElementos)
            NotasPedidosModel.ForEach(Sub(x) NotasPedidos.Add(New CuentaCorrienteNotaPedidoItems(x)))
            NotifyPropertyChanged(NameOf(Me.NotasPedidos))
        End Function

        Friend Async Function CargarDetalleMovimientoAsync(cuentaCorrienteMovimientosItem As CuentaCorrienteMovimientosItem) As Task
            If (cuentaCorrienteMovimientosItem.TipoMovimientoCuentaCorriente = TipoMovimientoCuentaCorriente.Depósito) Then
                Dim documentoDePago As DocumentoDePago = Await DocumentoDePagoService.ObtenerAsync(TipoBase.Remota, cuentaCorrienteMovimientosItem.Movimiento.IdComprobante)
                If (documentoDePago Is Nothing) Then
                    Throw New NegocioException("No se ha encontrado el detalle de movimiento. Por favor sincronice los datos y vuelva a intentar más tarde.")
                End If

                Dim frmClienteMayoristaCuentaCorrientePago As frmClienteMayoristaDocumentoPago = New frmClienteMayoristaDocumentoPago(documentoDePago)
                frmClienteMayoristaCuentaCorrientePago.ShowDialog()

            ElseIf (cuentaCorrienteMovimientosItem.TipoMovimientoCuentaCorriente = TipoMovimientoCuentaCorriente.Venta) Then
                Dim venta As Modelo.Venta = Await VentaService.ObtenerAsync(TipoBase.Remota, cuentaCorrienteMovimientosItem.Movimiento.IdComprobante)
                If (venta Is Nothing) Then
                    Throw New NegocioException("No se ha encontrado el detalle de movimiento. Por favor sincronice los datos y vuelva a intentar más tarde.")
                End If

                Dim frmVentasAdministracion As frmVentasAdministracion = New frmVentasAdministracion(venta)
                frmVentasAdministracion.ShowDialog()
            End If
            Await CargarMovimientosAsync()
        End Function

        Friend Sub ImprimirCuenta()
            Dim frmReporteMovimientosCuentaCorriente As frmReporteMovimientosCuentaCorriente = New frmReporteMovimientosCuentaCorriente(IdClienteMayorista, FechaBusquedaDesde, FechaBusquedaHasta)
            frmReporteMovimientosCuentaCorriente.ShowDialog()
        End Sub

        Friend Sub ImprimirMovimiento(cuentaCorrienteMovimientosItem As CuentaCorrienteMovimientosItem)
            Dim frmReporte As Form

            Select Case cuentaCorrienteMovimientosItem.TipoMovimientoCuentaCorriente
                Case TipoMovimientoCuentaCorriente.Depósito
                    frmReporte = New frmReporteDocumentoPagol(cuentaCorrienteMovimientosItem.Movimiento.IdComprobante)
                Case TipoMovimientoCuentaCorriente.Venta
                    Throw New NotImplementedException()
                Case Else
                    Throw New InvalidOperationException()
            End Select

            frmReporte.Show()
        End Sub
    End Class
End Namespace