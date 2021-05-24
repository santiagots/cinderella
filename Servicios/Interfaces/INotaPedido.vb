Imports System.ServiceModel

' NOTE: You can use the "Rename" command on the context menu to change the interface name "IVenta" in both code and config file together.
<ServiceContract()>
Public Interface INotaPedido

    <OperationContract()>
    Sub AgregarNotaPedido(ByVal notaPedido As EntidadNotaPedido, ByVal EntConsumidorFinal As EntidadConsumidorFinal)

End Interface
