Imports Common.Core.Model

Namespace Formularios.Cliente
    Public Class ClienteMayoristaItem
        Public ReadOnly ClienteMayorista As ClienteMayorista

        Public ReadOnly Property Id As String
            Get
                Return ClienteMayorista.Id.ToString()
            End Get
        End Property

        Public ReadOnly Property RazonSocial As String
            Get
                Return ClienteMayorista.RazonSocial
            End Get
        End Property

        Public ReadOnly Property Cuit As String
            Get
                Return ClienteMayorista.Cuit
            End Get
        End Property

        Public ReadOnly Property NotaPedidoMonto As Decimal

        Public ReadOnly Property CuentaCorrienteMonto As Decimal

        Sub New(clienteMayorista As ClienteMayorista, notaPedidoMonto As Decimal, cuentaCorrienteMonto As Decimal)
            Me.ClienteMayorista = clienteMayorista
            Me.NotaPedidoMonto = notaPedidoMonto
            Me.CuentaCorrienteMonto = cuentaCorrienteMonto
        End Sub

    End Class
End Namespace