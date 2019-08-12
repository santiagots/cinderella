Imports Ventas.Core.Model.ValueObjects

Namespace Comunes

    Public Class SaldoSucursalViewModel
        Inherits SistemaCinderella.VistaModelo.Common

        Private _SucursalSaldo As SucursalSaldo
        Public Property SucursalSaldo As SucursalSaldo
            Get
                Return _SucursalSaldo
            End Get
            Set(value As SucursalSaldo)
                _SucursalSaldo = value
                NotifyPropertyChanged(NameOf(Me.SucursalSaldo))
            End Set
        End Property

        Public ReadOnly Property VentaEfectivo() As Decimal
            Get
                Return SucursalSaldo.Venta.Efectivo
            End Get
        End Property

        Public ReadOnly Property VentaCheque() As Decimal
            Get
                Return SucursalSaldo.Venta.Cheque
            End Get
        End Property

        Public ReadOnly Property VentaCredito() As Decimal
            Get
                Return SucursalSaldo.Venta.Credito
            End Get
        End Property

        Public ReadOnly Property VentaDeposito() As Decimal
            Get
                Return SucursalSaldo.Venta.Deposito
            End Get
        End Property

        Public ReadOnly Property VentaDebito() As Decimal
            Get
                Return SucursalSaldo.Venta.Debito
            End Get
        End Property

        Public ReadOnly Property VentaFacturado() As Decimal
            Get
                Return SucursalSaldo.Venta.Facturado
            End Get
        End Property

        Public ReadOnly Property VentaMinorista() As Decimal
            Get
                Return SucursalSaldo.Venta.Minorista
            End Get
        End Property

        Public ReadOnly Property VentaMayorista() As Decimal
            Get
                Return SucursalSaldo.Venta.Mayorista
            End Get
        End Property

        Public ReadOnly Property VentaTotal() As Decimal
            Get
                Return SucursalSaldo.Ingreso.TotalVentas
            End Get
        End Property

        Public ReadOnly Property CajaInical() As Decimal
            Get
                Return SucursalSaldo.Ingreso.CajaInicial
            End Get
        End Property

        Public ReadOnly Property RecibidosSucursal() As Decimal
            Get
                Return SucursalSaldo.Ingreso.RecibidosSucursal
            End Get
        End Property

        Public ReadOnly Property SobranteCaja() As Decimal
            Get
                Return SucursalSaldo.Ingreso.SobranteCaja
            End Get
        End Property

        Public ReadOnly Property EgresoCajaFuerte() As Decimal
            Get
                Return SucursalSaldo.Ingreso.EgresosCajaFuerte
            End Get
        End Property

        Public ReadOnly Property AporteSocios() As Decimal
            Get
                Return SucursalSaldo.Ingreso.AporteSocios
            End Get
        End Property

        Public ReadOnly Property Devoluciones() As Decimal
            Get
                Return SucursalSaldo.Egreso.Devoluciones
            End Get
        End Property

        Public ReadOnly Property Mercaderia() As Decimal
            Get
                Return SucursalSaldo.Egreso.Mercaderias
            End Get
        End Property

        Public ReadOnly Property Sueldos() As Decimal
            Get
                Return SucursalSaldo.Egreso.Sueldos
            End Get
        End Property

        Public ReadOnly Property Gastos() As Decimal
            Get
                Return SucursalSaldo.Egreso.Gastos
            End Get
        End Property

        Public ReadOnly Property Impuestos() As Decimal
            Get
                Return SucursalSaldo.Egreso.Impuestos
            End Get
        End Property

        Public ReadOnly Property EnviosSucursales() As Decimal
            Get
                Return SucursalSaldo.Egreso.EnviosSucursales
            End Get
        End Property

        Public ReadOnly Property PendienteAutorizacion() As Decimal
            Get
                Return SucursalSaldo.Egreso.PendientesAutorizacion
            End Get
        End Property

        Public ReadOnly Property FaltanteCaja() As Decimal
            Get
                Return SucursalSaldo.Egreso.FaltanteCaja
            End Get
        End Property

        Public ReadOnly Property IngresosCajaFuerte() As Decimal
            Get
                Return SucursalSaldo.Egreso.IngresoCajaFuerte
            End Get
        End Property

        Public ReadOnly Property RetiroSocios() As Decimal
            Get
                Return SucursalSaldo.Egreso.RetirosSocios
            End Get
        End Property

        Sub New()
            Me.SucursalSaldo = New SucursalSaldo(
                                    New Venta(0, 0, 0, 0, 0, 0, 0, 0),
                                    New Ingreso(0, 0, 0, 0, 0, 0),
                                    New Egreso(0, 0, 0, 0, 0, 0, 0, 0, 0, 0),
                                    0,
                                    0)
        End Sub

    End Class
End Namespace