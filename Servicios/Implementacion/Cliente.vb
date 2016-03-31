Imports System.ServiceModel

<ServiceBehavior(IncludeExceptionDetailInFaults:=True)>
Public Class Cliente
    Implements ICliente

    Public Function GetClienteMayorista(RazonSocial As String) As List(Of Entidades.Clientes) Implements ICliente.GetClienteMayorista
        Dim clientesNegocio As Negocio.NegClientes = New Negocio.NegClientes()

        Return clientesNegocio.TraerCliente(RazonSocial)
    End Function

End Class
