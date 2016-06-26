Imports System.ServiceModel

<ServiceContract()>
Public Interface IEmpleado

    <OperationContract()>
    Function GetEmpleadoPorUsuarioID(ByVal IdUsuario As Integer) As EntidadEmpleado

End Interface
