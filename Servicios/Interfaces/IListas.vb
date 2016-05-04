Imports System.ServiceModel
Imports Entidades

' NOTE: You can use the "Rename" command on the context menu to change the interface name "IListas" in both code and config file together.
<ServiceContract()>
Public Interface ILista

    <OperationContract()>
    Function Configuracion() As EntidadConfiguracion

    <OperationContract()>
    Function FormasPago() As List(Of KeyValuePair(Of Integer, String))

    <OperationContract()>
    Function TiposPrecio() As List(Of EntidadTipoPrecios)

    <OperationContract()>
    Function GruposPrecio() As List(Of KeyValuePair(Of Integer, String))

    <OperationContract()>
    Function Sucursales() As List(Of KeyValuePair(Of Integer, String))

    <OperationContract()>
    Function Vendedores(ByVal idSucursal As Integer) As List(Of KeyValuePair(Of Integer, String))


End Interface
