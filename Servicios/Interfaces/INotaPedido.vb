Imports System.ServiceModel

' NOTE: You can use the "Rename" command on the context menu to change the interface name "IVenta" in both code and config file together.
<ServiceContract()>
Public Interface INotaPedido

    <OperationContract()>
    Function SetNevaNotaPedido(ByVal EntNotaPedido As EntidadNotaPedido, EntDetalleNotaPedido As List(Of EntidadNotaPedido_Detalle), ByVal EntConsumidorFinal As EntidadConsumidorFinal) As Boolean

End Interface
