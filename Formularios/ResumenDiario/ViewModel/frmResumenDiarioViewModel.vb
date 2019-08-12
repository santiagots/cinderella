Imports System.Threading.Tasks
Imports Common.Core.Enum
Imports SistemaCinderella.Comunes
Imports ValueObjects = Ventas.Core.Model.ValueObjects
Imports Facturacion = Formularios.Facturacion
Imports Negocio
Imports Ventas.Core.Model.VentaAggregate

Namespace Formularios.ResumenDiario
    Public Class frmResumenDiarioViewModel
        Inherits SistemaCinderella.VistaModelo.Common

        Private NegUsuarios As New Negocio.Usuario
        Private IdSucursal As Integer
        Private CajaActual As CierreCaja
        Private SucursalSaldo As ValueObjects.SucursalSaldo

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
        Public ReadOnly Property CajaChica As Decimal
            Get
                Return SucursalSaldo.Total()
            End Get
        End Property

        Public ReadOnly Property DisponibleCheque As Decimal
            Get
                Return SucursalSaldo.TotalCheques
            End Get
        End Property

        Public ReadOnly Property DisponibleEfectivo As Decimal
            Get
                Return SucursalSaldo.Disponible
            End Get
        End Property

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
            SucursalSaldo = New ValueObjects.SucursalSaldo(
                        New ValueObjects.Venta(0, 0, 0, 0, 0, 0, 0, 0),
                        New ValueObjects.Ingreso(0, 0, 0, 0, 0, 0),
                        New ValueObjects.Egreso(0, 0, 0, 0, 0, 0, 0, 0, 0, 0),
                        0,
                        0)
            Saldos = New SaldoSucursalViewModel()
            Saldos.SucursalSaldo = SucursalSaldo
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

            If (Importe <> Saldos.SucursalSaldo.Total AndAlso MessageBox.Show("Se han encontrado diferencias entre el saldo calculado y el ingresado. ¿Desea enviar dicha diferencia a caja?.", "Resumen Diario", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) = DialogResult.No) Then
                Importe = Saldos.SucursalSaldo.Total
            End If

            If (CajaActual = Nothing) Then
                Dim cierreCaja As CierreCaja = New CierreCaja(IdSucursal)
                cierreCaja.Cerrar(VariablesGlobales.objUsuario.id_Usuario, Importe, Saldos.SucursalSaldo.Total, False, DateTime.Now)
                Await Task.Run(Sub() Servicio.GuardarCierreCaja(cierreCaja))
                CajaActual = cierreCaja
            Else
                CajaActual.Cerrar(VariablesGlobales.objUsuario.id_Usuario, Importe, Saldos.SucursalSaldo.Total, True, DateTime.Now)
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
            SucursalSaldo = Await Task.Run(Function() Servicio.CargarSaldoAsync(IdSucursal, Fecha))
            Saldos.SucursalSaldo = SucursalSaldo

            NotifyPropertyChanged(NameOf(Me.CajaChica))
            NotifyPropertyChanged(NameOf(Me.DisponibleCheque))
            NotifyPropertyChanged(NameOf(Me.DisponibleEfectivo))
        End Function


        Friend Sub CierreZ()
            Facturacion.Servicio.CierreZ()
        End Sub

    End Class
End Namespace