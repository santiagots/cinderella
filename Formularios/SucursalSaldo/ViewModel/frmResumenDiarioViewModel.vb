Imports System.Threading.Tasks
Imports SistemaCinderella.Comunes
Imports Negocio
Imports Ventas.Core.Model.VentaAggregate
Imports Common.Core.Enum
Imports SistemaCinderella.Formularios.MovimientoDetalle
Imports System.ComponentModel

Namespace Formularios.SucursalSaldo
    Public Class frmResumenDiarioViewModel
        Inherits SistemaCinderella.VistaModelo.Common

        Private NegDev As New Negocio.NegDevolucion
        Private NegMov As New Negocio.NegMovimientos
        Private NegEmp As New Negocio.NegEmpleados
        Private NegAdel As New Negocio.NegAdelantos
        Private NegUsuarios As New Negocio.Usuario
        Private IdSucursal As Integer
        Private CajaActual As CierreCaja

        Public Property Sucursal As String
        Public Property Fecha As Date
        Public Property Importe As Decimal?
        Public ReadOnly Property FechaCierre As Date
            Get
                Return If(CajaActual <> Nothing, CajaActual.Fecha, DateTime.Now)
            End Get
        End Property
        Public Property NombreEmpleadoCierre As String
        Public Property NombreEmpleadoCajaReabierta As String
        Public Property TotalCajaFuerte As Decimal
        Public Property CajaChica As Decimal
        Public Property DisponibleCheque As Decimal
        Public Property DisponibleEfectivo As Decimal

        Public ReadOnly Property HabilitarAbrirCaja As Boolean
            Get
                Return Fecha.Date = DateTime.Now.Date AndAlso CajaActual <> Nothing AndAlso CajaActual.Estado = Ventas.Core.Enum.CierreCajaEstado.Cerrada
            End Get
        End Property

        Public ReadOnly Property HabilitarCerrarCaja As Boolean
            Get
                Return Fecha.Date = DateTime.Now.Date AndAlso
                       (CajaActual = Nothing OrElse
                       (CajaActual <> Nothing AndAlso CajaActual.Estado = Ventas.Core.Enum.CierreCajaEstado.Abierta))
            End Get
        End Property
        Public ReadOnly Property VisibleCajaReabierta As Boolean
            Get
                Return CajaActual <> Nothing AndAlso CajaActual.Abierta
            End Get
        End Property
        Public ReadOnly Property VisibleCajaCerrada As Boolean
            Get
                Return (CajaActual <> Nothing AndAlso CajaActual.Estado = Ventas.Core.Enum.CierreCajaEstado.Cerrada) OrElse
                       (CajaActual <> Nothing AndAlso CajaActual.Estado = Ventas.Core.Enum.CierreCajaEstado.Abierta AndAlso CajaActual.Abierta)
            End Get
        End Property

        Public Property Saldos As SaldoSucursalViewModel

        Sub New(IdSucursal As Integer, NombreSucursal As String)
            Me.IdSucursal = IdSucursal

            Fecha = Date.Now()
            Sucursal = NombreSucursal
            Saldos = New SaldoSucursalViewModel()
        End Sub

        Friend Async Function BuscarAsync() As Task
            Await CargarSaldoAsync()
            Await CargarCajaAsync()
        End Function

        Friend Async Function LimpiarAsync() As Task
            Fecha = DateTime.Now
            Await CargarSaldoAsync()
            Await CargarCajaAsync()
        End Function

        Friend Async Function AbrirCajaAsync() As Task
            CajaActual.Abir(VariablesGlobales.objUsuario.id_Usuario)
            Await Task.Run(Sub() Servicio.ActualizarCierreCaja(CajaActual))
            Await CargarSaldoAsync()

            Dim usuarioCajaAbre As Entidades.Usuario = Await Task.Run(Function() NegUsuarios.TraerUsuario(VariablesGlobales.objUsuario.id_Usuario))
            NombreEmpleadoCajaReabierta = $"{usuarioCajaAbre.Apellido}, {usuarioCajaAbre.Nombre}"

            NotifyPropertyChanged(NameOf(Me.NombreEmpleadoCajaReabierta))
        End Function

        Friend Async Function CerrarCajaAsyc() As Task

            Await CargarSaldoAsync()

            If (Importe <> CajaChica AndAlso MessageBox.Show("Se han encontrado diferencias entre el saldo calculado y el ingresado. ¿Desea enviar dicha diferencia a caja?.", "Resumen Diario", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) = DialogResult.No) Then
                Importe = CajaChica
            End If

            If (CajaActual = Nothing) Then
                Dim cierreCaja As CierreCaja = New CierreCaja(IdSucursal)
                cierreCaja.Cerrar(VariablesGlobales.objUsuario.id_Usuario, Importe, CajaChica, False, DateTime.Now)
                Await Task.Run(Sub() Servicio.GuardarCierreCaja(cierreCaja))
                CajaActual = cierreCaja
            Else
                CajaActual.Cerrar(VariablesGlobales.objUsuario.id_Usuario, Importe, CajaChica, True, DateTime.Now)
                Await Task.Run(Sub() Servicio.ActualizarCierreCaja(CajaActual))
            End If

            Dim usuario As Entidades.Usuario = Await Task.Run(Function() NegUsuarios.TraerUsuario(VariablesGlobales.objUsuario.id_Usuario))
            NombreEmpleadoCierre = $"{usuario.Apellido}, {usuario.Nombre}"

            NotifyPropertyChanged(NameOf(Me.HabilitarAbrirCaja))
            NotifyPropertyChanged(NameOf(Me.HabilitarCerrarCaja))
            NotifyPropertyChanged(NameOf(Me.VisibleCajaReabierta))
            NotifyPropertyChanged(NameOf(Me.VisibleCajaCerrada))
            NotifyPropertyChanged(NameOf(Me.FechaCierre))
            NotifyPropertyChanged(NameOf(Me.NombreEmpleadoCierre))
            NotifyPropertyChanged(NameOf(Me.NombreEmpleadoCajaReabierta))
        End Function

        Public Async Function MostrarDevolucionesAsyn() As Task
            Dim devoluciones As List(Of MovimientoDetalle.MovimientoDevolucion) = Await Task.Run(Function() MovimientoDetalle.Servicio.ObtenerDevoluciones(IdSucursal, Fecha, Fecha))
            Dim titulo As String = $"Devoluciones registradas en { Fecha.ToShortDateString() }"
            MostrarMovimiento(titulo, devoluciones)
        End Function

        Public Async Function MostrarSueldosAsyn() As Task
            Dim sueldos As List(Of MovimientoDetalle.MovimientoSueldo) = Await Task.Run(Function() MovimientoDetalle.Servicio.ObtenerSueldos(IdSucursal, Fecha, Fecha))
            Dim titulo As String = $"Sueldos registrados en { Fecha.ToShortDateString() }"
            MostrarMovimiento(titulo, sueldos)
        End Function

        Public Async Function MostrarGastosAsyn() As Task
            Dim gastos As List(Of MovimientoDetalle.MovimientoGasto) = Await Task.Run(Function() MovimientoDetalle.Servicio.ObtenerGastos(IdSucursal, Fecha, Fecha))
            Dim titulo As String = $"Gastos registrados en { Fecha.ToShortDateString() }"
            MostrarMovimiento(titulo, gastos)
        End Function

        Public Async Function MostrarImpuestosAsyn() As Task
            Dim impuesto As List(Of MovimientoDetalle.MovimientoImpuesto) = Await Task.Run(Function() MovimientoDetalle.Servicio.ObtenerImpuestos(IdSucursal, Fecha, Fecha))
            Dim titulo As String = $"Impuestos registrados en { Fecha.ToShortDateString() }"
            MostrarMovimiento(titulo, impuesto)
        End Function

        Friend Async Function MostrarPendienteAutorizacionEgresosAsync() As Task
            Dim pendienteAutorizacion As List(Of MovimientoDetalle.MovimientoEgreso) = Await Task.Run(Function() MovimientoDetalle.Servicio.ObtenerEgresos(IdSucursal, Fecha, Fecha, "EgresosPendientes"))
            Dim titulo As String = $"Egresos registrados en { Fecha.ToShortDateString() }"
            MostrarMovimiento(titulo, pendienteAutorizacion)
        End Function

        Public Async Function MostrarEfectivoEgresosAsyn() As Task
            Dim efectivoEgreso As List(Of MovimientoDetalle.MovimientoEgreso) = Await Task.Run(Function() MovimientoDetalle.Servicio.ObtenerEgresos(IdSucursal, Fecha, Fecha, "Egresos"))
            Dim titulo As String = $"Egresos registrados en { Fecha.ToShortDateString() }"
            MostrarMovimiento(titulo, efectivoEgreso)
        End Function

        Friend Async Function MostrarTotalVentaAsync() As Task
            Dim totalVenta As List(Of MovimientoDetalle.MovimientoVenta) = Await Task.Run(Function() MovimientoDetalle.Servicio.ObtenerVenta(IdSucursal, Fecha, Nothing, Nothing, Nothing))
            Dim titulo As String = $"Ventas registradas en { Fecha.ToShortDateString() }"
            MostrarMovimiento(titulo, totalVenta)
        End Function

        Friend Async Function MostrarTotalVentaEfectivoAsync() As Task
            Dim totalVentaEfectivo As List(Of MovimientoDetalle.MovimientoVenta) = Await Task.Run(Function() MovimientoDetalle.Servicio.ObtenerVenta(IdSucursal, Fecha, Nothing, TipoPago.Efectivo, Nothing))
            Dim titulo As String = $"Ventas en efectivo registradas en { Fecha.ToShortDateString() }"
            MostrarMovimiento(titulo, totalVentaEfectivo)
        End Function

        Friend Async Function MostrarTotalVentaChequeAsync() As Task
            Dim totalVentaCheque As List(Of MovimientoDetalle.MovimientoVenta) = Await Task.Run(Function() MovimientoDetalle.Servicio.ObtenerVenta(IdSucursal, Fecha, Nothing, TipoPago.Cheque, Nothing))
            Dim titulo As String = $"Ventas en cheque registradas en { Fecha.ToShortDateString() }"
            MostrarMovimiento(titulo, totalVentaCheque)
        End Function

        Friend Async Function MostrarTotalVentaDepositoAsync() As Task
            Dim totalVentaDeposito As List(Of MovimientoDetalle.MovimientoVenta) = Await Task.Run(Function() MovimientoDetalle.Servicio.ObtenerVenta(IdSucursal, Fecha, Nothing, TipoPago.Deposito, Nothing))
            Dim titulo As String = $"Ventas en deposito registradas en { Fecha.ToShortDateString() }"
            MostrarMovimiento(titulo, totalVentaDeposito)
        End Function

        Friend Async Function MostrarTotalVentaTarjetaCreditoAsync() As Task
            Dim totalVentaTarjetaCredito As List(Of MovimientoDetalle.MovimientoVenta) = Await Task.Run(Function() MovimientoDetalle.Servicio.ObtenerVenta(IdSucursal, Fecha, Nothing, TipoPago.TarjetaCredito, Nothing))
            Dim titulo As String = $"Ventas en tarjeta crédito registradas en { Fecha.ToShortDateString() }"
            MostrarMovimiento(titulo, totalVentaTarjetaCredito)
        End Function

        Friend Async Function MostrarTotalVentaTarjetaDebitoAsync() As Task
            Dim totalVentaTarjetaDebito As List(Of MovimientoDetalle.MovimientoVenta) = Await Task.Run(Function() MovimientoDetalle.Servicio.ObtenerVenta(IdSucursal, Fecha, Nothing, TipoPago.TarjetaDebito, Nothing))
            Dim titulo As String = $"Ventas en tarjeta debito registradas en { Fecha.ToShortDateString() }"
            MostrarMovimiento(titulo, totalVentaTarjetaDebito)
        End Function

        Friend Async Function MostrarTotalVentaFacturadoAsync() As Task
            Dim totalVentaFacturado As List(Of MovimientoDetalle.MovimientoVenta) = Await Task.Run(Function() MovimientoDetalle.Servicio.ObtenerVenta(IdSucursal, Fecha, True, Nothing, Nothing))
            Dim titulo As String = $"Ventas facturadas registradas en { Fecha.ToShortDateString() }"
            MostrarMovimiento(titulo, totalVentaFacturado)
        End Function

        Friend Async Function MostrarTotalVentaSinFacturarAsync() As Task
            Dim totalVentaFacturado As List(Of MovimientoDetalle.MovimientoVenta) = Await Task.Run(Function() MovimientoDetalle.Servicio.ObtenerVenta(IdSucursal, Fecha, False, Nothing, Nothing))
            Dim titulo As String = $"Ventas sin facturar registradas en { Fecha.ToShortDateString() }"
            MostrarMovimiento(titulo, totalVentaFacturado)
        End Function

        Friend Async Function MostrarTotalVentaMayoristaAsync() As Task
            Dim totalVentaMayorista As List(Of MovimientoDetalle.MovimientoVenta) = Await Task.Run(Function() MovimientoDetalle.Servicio.ObtenerVenta(IdSucursal, Fecha, Nothing, Nothing, TipoCliente.Mayorista))
            Dim titulo As String = $"Ventas mayoristas registradas en { Fecha.ToShortDateString() }"
            MostrarMovimiento(titulo, totalVentaMayorista)
        End Function

        Friend Async Function MostrarTotalVentaMinoristaAsync() As Task
            Dim totalVentaMinorista As List(Of MovimientoDetalle.MovimientoVenta) = Await Task.Run(Function() MovimientoDetalle.Servicio.ObtenerVenta(IdSucursal, Fecha, Nothing, Nothing, TipoCliente.Minorista))
            Dim titulo As String = $"Ventas minorista registradas en { Fecha.ToShortDateString() }"
            MostrarMovimiento(titulo, totalVentaMinorista)
        End Function

        Friend Async Function MostrarFaltanteCajaAsync() As Task
            Dim faltanteCaja As List(Of MovimientoDetalle.MovimientoCaja) = Await Task.Run(Function() MovimientoDetalle.Servicio.ObtenerMovimientoCaja(IdSucursal, Fecha, Fecha, Ventas.Core.Enum.CierreCajaSituacion.FaltanteDinero))
            Dim titulo As String = $"Faltante de caja registradas en { Fecha.ToShortDateString() }"
            MostrarMovimiento(titulo, faltanteCaja)
        End Function

        Friend Async Function MostrarIngresoCajaFuerteAsync() As Task
            Dim ingresoCajaFuerte As List(Of MovimientoDetalle.MovimientoCajaFuerte) = Await Task.Run(Function() MovimientoDetalle.Servicio.ObtenerIngresoCajaFuerte(IdSucursal, Fecha, Fecha, 2))
            Dim titulo As String = $"Ingresos de caja fuerte registrados en { Fecha.ToShortDateString() }"
            MostrarMovimiento(titulo, ingresoCajaFuerte)
        End Function

        Friend Async Function MostrarEgresoCajaFuerteAsync() As Task
            Dim egresoCajaFuerte As List(Of MovimientoDetalle.MovimientoCajaFuerte) = Await Task.Run(Function() MovimientoDetalle.Servicio.ObtenerIngresoCajaFuerte(IdSucursal, Fecha, Fecha, 1))
            Dim titulo As String = $"Egreso de caja Fuerte registrados en { Fecha.ToShortDateString() }"
            MostrarMovimiento(titulo, egresoCajaFuerte)
        End Function

        Friend Async Function MostrarRetiroSocioAsync() As Task
            Dim retiroSocio As List(Of MovimientoDetalle.MovimientoSocio) = Await Task.Run(Function() MovimientoDetalle.Servicio.ObtenerRetiroSocio(IdSucursal, Fecha, Fecha))
            Dim titulo As String = $"Retiros Socios registrados en { Fecha.ToShortDateString() }"
            MostrarMovimiento(titulo, retiroSocio)
        End Function

        Public Async Function MostrarEfectivoIngresoAsyn() As Task
            Dim efectivoIngreso As List(Of MovimientoDetalle.MovimientoEgreso) = Await Task.Run(Function() MovimientoDetalle.Servicio.ObtenerEgresos(IdSucursal, Fecha, Fecha, "Ingresos"))
            Dim titulo As String = $"Ingresos registrados en { Fecha.ToShortDateString() }"
            MostrarMovimiento(titulo, efectivoIngreso)
        End Function

        Friend Async Function MostrarSobranteCajaAsync() As Task
            Dim sobranteCaja As List(Of MovimientoDetalle.MovimientoCaja) = Await Task.Run(Function() MovimientoDetalle.Servicio.ObtenerMovimientoCaja(IdSucursal, Fecha, Fecha, Ventas.Core.Enum.CierreCajaSituacion.SobranteDinero))
            Dim titulo As String = $"Sobrante de caja registrados en { Fecha.ToShortDateString() }"
            MostrarMovimiento(titulo, sobranteCaja)
        End Function

        Friend Async Function MostrarAporteSocioAsync() As Task
            Dim aporteSocio As List(Of MovimientoDetalle.MovimientoSocio) = Await Task.Run(Function() MovimientoDetalle.Servicio.ObtenerAporteSocio(IdSucursal, Fecha, Fecha))
            Dim titulo As String = $"Aporte socios registrados en { Fecha.ToShortDateString() }"
            MostrarMovimiento(titulo, aporteSocio)
        End Function

        Private Sub MostrarMovimiento(Of T)(titulo As String, movimientos As List(Of T))
            Dim frmMoviminetoDetalleViewModel = New frmMoviminetoDetalleViewModel(Of T)(titulo, New BindingList(Of T)(movimientos))
            Dim frmMoviminetoDetalle As frmMoviminetoDetalle(Of T) = New frmMoviminetoDetalle(Of T)(frmMoviminetoDetalleViewModel)
            frmMoviminetoDetalle.ShowDialog()
        End Sub

        Private Async Function CargarCajaAsync() As Task
            CajaActual = Await Task.Run(Function() Servicio.ObtenerCierreCaja(IdSucursal, Fecha))

            If (CajaActual <> Nothing) Then
                Dim usuarioCierre As Entidades.Usuario = Await Task.Run(Function() NegUsuarios.TraerUsuario(CajaActual.IdUsuarioCierre))
                NombreEmpleadoCierre = $"{usuarioCierre.Apellido}, {usuarioCierre.Nombre}"

                If (CajaActual.IdUsuarioAbre.HasValue) Then
                    Dim usuarioCajaAbre As Entidades.Usuario = Await Task.Run(Function() NegUsuarios.TraerUsuario(CajaActual.IdUsuarioAbre.Value))
                    NombreEmpleadoCajaReabierta = $"{usuarioCajaAbre.Apellido}, {usuarioCajaAbre.Nombre}"
                End If
            End If

            NotifyPropertyChanged(NameOf(Me.HabilitarAbrirCaja))
            NotifyPropertyChanged(NameOf(Me.HabilitarCerrarCaja))
            NotifyPropertyChanged(NameOf(Me.VisibleCajaReabierta))
            NotifyPropertyChanged(NameOf(Me.VisibleCajaCerrada))
            NotifyPropertyChanged(NameOf(Me.FechaCierre))
            NotifyPropertyChanged(NameOf(Me.NombreEmpleadoCierre))
            NotifyPropertyChanged(NameOf(Me.NombreEmpleadoCajaReabierta))
        End Function

        Private Async Function CargarSaldoAsync() As Task
            Dim Saldo As Task(Of Ventas.Core.Model.ValueObjects.SucursalSaldo) = Task.Run(Function() Servicio.CargarSaldoAsync(IdSucursal, Fecha))
            Dim totalCarteraCheque As Task(Of Decimal) = Task.Run(Function() Cheque.Servicio.TotalCarteraCheque(IdSucursal))

            Await Task.WhenAll(CargarResumenVentaAsync(), Saldo, totalCarteraCheque)

            Saldos.CajaInical = Saldo.Result.Ingreso.CajaInicial
            Saldos.RecibidosSucursal = Saldo.Result.Ingreso.RecibidosSucursal
            Saldos.SobranteCaja = Saldo.Result.Ingreso.SobranteCaja
            Saldos.EgresoCajaFuerte = Saldo.Result.Ingreso.EgresosCajaFuerte
            Saldos.AporteSocios = Saldo.Result.Ingreso.AporteSocios

            Saldos.Devoluciones = Saldo.Result.Egreso.Devoluciones
            Saldos.Mercaderia = Saldo.Result.Egreso.Mercaderias
            Saldos.Sueldos = Saldo.Result.Egreso.Sueldos
            Saldos.Gastos = Saldo.Result.Egreso.Gastos
            Saldos.Impuestos = Saldo.Result.Egreso.Impuestos
            Saldos.EnviosSucursales = Saldo.Result.Egreso.EnviosSucursales
            Saldos.PendienteAutorizacion = Saldo.Result.Egreso.PendientesAutorizacion
            Saldos.FaltanteCaja = Saldo.Result.Egreso.FaltanteCaja
            Saldos.IngresosCajaFuerte = Saldo.Result.Egreso.IngresoCajaFuerte
            Saldos.RetiroSocios = Saldo.Result.Egreso.RetirosSocios

            Me.TotalCajaFuerte = Saldo.Result.TotalCajaFuerte
            Me.CajaChica = Saldo.Result.Total
            Me.DisponibleCheque = totalCarteraCheque.Result
            Me.DisponibleEfectivo = Saldo.Result.Disponible


            NotifyPropertyChanged(NameOf(Me.TotalCajaFuerte))
            NotifyPropertyChanged(NameOf(Me.CajaChica))
            NotifyPropertyChanged(NameOf(Me.DisponibleCheque))
            NotifyPropertyChanged(NameOf(Me.DisponibleEfectivo))
        End Function

        Friend Sub CierreZ()
            Facturacion.Servicio.CierreZ()
        End Sub

        Private Async Function CargarResumenVentaAsync() As Task
            Dim efectivo As Task(Of Decimal) = Task.Run(Function() Venta.Servicio.ObtenerTotalVentas(IdSucursal, Fecha, Nothing, TipoPago.Efectivo, Nothing))
            Dim cheques As Task(Of Decimal) = Task.Run(Function() Venta.Servicio.ObtenerTotalVentas(IdSucursal, Fecha, Nothing, TipoPago.Cheque, Nothing))
            Dim credito As Task(Of Decimal) = Task.Run(Function() Venta.Servicio.ObtenerTotalVentas(IdSucursal, Fecha, Nothing, TipoPago.TarjetaCredito, Nothing))
            Dim debito As Task(Of Decimal) = Task.Run(Function() Venta.Servicio.ObtenerTotalVentas(IdSucursal, Fecha, Nothing, TipoPago.TarjetaDebito, Nothing))
            Dim deposito As Task(Of Decimal) = Task.Run(Function() Venta.Servicio.ObtenerTotalVentas(IdSucursal, Fecha, Nothing, TipoPago.Deposito, Nothing))
            Dim facturado As Task(Of Decimal) = Task.Run(Function() Venta.Servicio.ObtenerTotalVentas(IdSucursal, Fecha, True, Nothing, Nothing))
            Dim sinFacturar As Task(Of Decimal) = Task.Run(Function() Venta.Servicio.ObtenerTotalVentas(IdSucursal, Fecha, False, Nothing, Nothing))
            Dim minorista As Task(Of Decimal) = Task.Run(Function() Venta.Servicio.ObtenerTotalVentas(IdSucursal, Fecha, Nothing, Nothing, TipoCliente.Minorista))
            Dim mayorista As Task(Of Decimal) = Task.Run(Function() Venta.Servicio.ObtenerTotalVentas(IdSucursal, Fecha, Nothing, Nothing, TipoCliente.Mayorista))
            Dim total As Task(Of Decimal) = Task.Run(Function() Venta.Servicio.ObtenerTotalVentas(IdSucursal, Fecha, Nothing, Nothing, Nothing))

            Await Task.WhenAll(efectivo, cheques, credito, credito, minorista, mayorista, facturado, sinFacturar, total)

            Saldos.VentaEfectivo = efectivo.Result
            Saldos.VentaCheque = cheques.Result
            Saldos.VentaCredito = credito.Result
            Saldos.VentaDeposito = debito.Result
            Saldos.VentaDebito = deposito.Result
            Saldos.VentaFacturado = facturado.Result
            Saldos.VentaSinFacturar = sinFacturar.Result
            Saldos.VentaMinorista = minorista.Result
            Saldos.VentaMayorista = mayorista.Result
            Saldos.VentaTotal = total.Result
        End Function
    End Class
End Namespace