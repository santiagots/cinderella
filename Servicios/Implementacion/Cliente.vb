Imports System.ServiceModel

<ServiceBehavior(IncludeExceptionDetailInFaults:=True)>
Public Class Cliente
    Implements ICliente

    Public Function GetClienteMayorista(RazonSocial As String) As List(Of EntidadClientes) Implements ICliente.GetClienteMayorista
        Dim clientesNegocio As Negocio.NegClientes = New Negocio.NegClientes()

        Dim Respuesta As List(Of EntidadClientes) = New List(Of EntidadClientes)()

        For Each cli As Entidades.Clientes In clientesNegocio.TraerCliente(RazonSocial)
            Dim entCliente As EntidadClientes = New EntidadClientes()
            entCliente.Codigo_Postal = cli.Codigo_Postal
            entCliente.Cuit = cli.Cuit
            entCliente.Direccion = cli.Direccion
            entCliente.Fecha = cli.Fecha
            entCliente.Habilitado = cli.Habilitado
            entCliente.id_Cliente = cli.id_Cliente
            entCliente.Mail = cli.Mail
            entCliente.Observaciones = cli.Observaciones
            entCliente.RazonSocial = cli.RazonSocial
            entCliente.Telefono = cli.Telefono

            Respuesta.Add(entCliente)
        Next

        Return Respuesta
    End Function

End Class

