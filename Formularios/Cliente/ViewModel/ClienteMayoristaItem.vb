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
            Get
                Return ClienteMayorista.MontoNotasPedido
            End Get
        End Property

        Public ReadOnly Property CuentaCorrienteMonto As Decimal
            Get
                Return ClienteMayorista.MontoCuentaCorriente
            End Get
        End Property

        Sub New(clienteMayorista As ClienteMayorista)
            Me.ClienteMayorista = clienteMayorista
        End Sub

    End Class
End Namespace