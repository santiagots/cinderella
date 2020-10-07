Imports System.ComponentModel
Imports System.Threading.Tasks
Imports Common.Core.Enum
Imports Common.Core.Exceptions
Imports Common.Core.Model
Imports Ventas.Core.Model.CuentaCorrienteAggregate
Imports Ventas.Data.Service
Imports Modelo = Ventas.Core.Model.VentaAggregate

Namespace Formularios.Cliente
    Public Class frmClienteMayoristaCuentaCorrienteViewModel
        Inherits Comunes.Common

        Private Const MovimientosOrdenadoPor As String = "Fecha"
        Private Const MovimientosDireccionOrdenamiento As OrdenadoDireccion = OrdenadoDireccion.DESC
        Private ClienteMayorista As ClienteMayorista

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
        Public Property Movimientos As BindingList(Of CuentaCorrienteMovimientosItem) = New BindingList(Of CuentaCorrienteMovimientosItem)()
        Public ReadOnly Property MovimientosSinResultados As Boolean
            Get
                Return Not Movimientos.Any()
            End Get
        End Property

        Public Property MovimientosPaginaActual As Integer = 1
        Public Property MovimientosElementosPorPagina As Integer
        Public Property MovimientosTotalElementos As Integer


        Sub New(clienteMayorista As ClienteMayorista)
            Me.ClienteMayorista = clienteMayorista
        End Sub

        Friend Async Function CargarAsync() As Task
            Movimientos.Clear()
            Saldo = Await MovimientoService.ObtenerSaldoAsync(TipoBase.Remota, ClienteMayorista.Id)

            Dim MovimientosModel As List(Of Movimiento) = Await MovimientoService.ObtenerMovimientosAsync(TipoBase.Remota, IdClienteMayorista, MovimientosOrdenadoPor, MovimientosDireccionOrdenamiento, MovimientosPaginaActual, MovimientosElementosPorPagina, MovimientosTotalElementos)
            MovimientosModel.ForEach(Sub(x) Movimientos.Add(New CuentaCorrienteMovimientosItem(x)))

            NotifyPropertyChanged(NameOf(Me.Saldo))
        End Function

        Friend Async Function CargarDetalleMovimientoAsync(cuentaCorrienteMovimientosItem As CuentaCorrienteMovimientosItem) As Task
            If (cuentaCorrienteMovimientosItem.TipoMovimientoCuentaCorriente = TipoMovimientoCuentaCorriente.Deposito) Then
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
            Await CargarAsync()
        End Function
    End Class
End Namespace