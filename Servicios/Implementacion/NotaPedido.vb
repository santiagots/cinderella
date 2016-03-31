Imports System.ServiceModel

<ServiceBehavior(IncludeExceptionDetailInFaults:=True)>
Public Class NotaPedido
    Implements INotaPedido
    Function SetNevaNotaPedido(ByVal EntNotaPedido As Entidades.NotaPedido, EntDetalleNotaPedido As List(Of Entidades.NotaPedido_Detalle), ByVal EntConsumidorFinal As Entidades.ConsumidorFinal) As Boolean Implements INotaPedido.SetNevaNotaPedido
        Dim NotaPedidoNegocio As Negocio.NegNotaPedido = New Negocio.NegNotaPedido()
        Dim ClienteNegocio As Negocio.NegClientes = New Negocio.NegClientes()

        If (EntConsumidorFinal IsNot Nothing) Then
            Dim id_ConsumidorFinal As Integer = ClienteNegocio.AltaClienteConsumidorFinal(EntConsumidorFinal)

            EntNotaPedido.Id_ConsumidorFinal = id_ConsumidorFinal
        End If

        Dim AltaOk As Boolean = NotaPedidoNegocio.NuevaNotaPedido(EntNotaPedido, EntDetalleNotaPedido)

        Return AltaOk
    End Function

End Class
