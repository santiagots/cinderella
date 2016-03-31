Imports System.ServiceModel

' NOTE: You can use the "Rename" command on the context menu to change the interface name "IVenta" in both code and config file together.
<ServiceContract()>
Public Interface INotaPedido

    <OperationContract()>
    Function SetNevaNotaPedido(ByVal EntNotaPedido As Entidades.NotaPedido, EntDetalleNotaPedido As List(Of Entidades.NotaPedido_Detalle), ByVal EntConsumidorFinal As Entidades.ConsumidorFinal) As Boolean

End Interface
