Imports System.ServiceModel

' NOTE: You can use the "Rename" command on the context menu to change the interface name "IProductoSvc" in both code and config file together.
<ServiceContract()>
Public Interface IProducto

    <OperationContract()>
    Function GetLista() As List(Of EntidadProductoReducido)

    <OperationContract()>
    Function GetProducto(ByVal IdProducto As Integer) As EntidadProducto

    <OperationContract()>
    Function GetProductoPorCodigoBarras(ByVal codigoBarras As String) As EntidadProducto

End Interface
