Imports System.ServiceModel

' NOTE: You can use the "Rename" command on the context menu to change the interface name "IUsuarioSvc" in both code and config file together.
<ServiceContract()>
Public Interface IUsuario

    <OperationContract()>
    Function Login(ByVal Usuario As String, ByVal Password As String) As Entidades.Usuario

End Interface
