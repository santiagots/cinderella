Imports Common.Core.Model

Public Class CuentaBancariaItem

    Public ReadOnly CuentaBancaria As CuentaBancaria

    Public ReadOnly Property Banco As String
        Get
            Return CuentaBancaria.Banco.Nombre
        End Get
    End Property
    Public ReadOnly Property CBU As String
        Get
            Return CuentaBancaria.CBU
        End Get
    End Property
    Public ReadOnly Property NumeroCuenta As String
        Get
            Return CuentaBancaria.NumeroCuenta
        End Get
    End Property
    Public ReadOnly Property CBUAlias As String
        Get
            Return CuentaBancaria.CBUAlias
        End Get
    End Property
    Public ReadOnly Property Titular As String
        Get
            Return CuentaBancaria.Titular
        End Get
    End Property
    Public ReadOnly Property CUIT As String
        Get
            Return CuentaBancaria.CUIT
        End Get
    End Property
    Public ReadOnly Property EsCuentaCorriente As Boolean
        Get
            Return CuentaBancaria.EsCuentaCorriente
        End Get
    End Property
    Public ReadOnly Property Habilitado As Boolean
        Get
            Return CuentaBancaria.Habilitado
        End Get
    End Property

    Sub New(cuentaBancaria As CuentaBancaria)
        Me.CuentaBancaria = cuentaBancaria
    End Sub

End Class
