Imports System.ServiceModel
Imports Entidades
Imports Negocio

<ServiceBehavior(IncludeExceptionDetailInFaults:=True, UseSynchronizationContext:=False)>
Public Class Cliente
    Implements ICliente

    Public Function GetClienteMayorista(RazonSocial As String) As List(Of EntidadClientes) Implements ICliente.GetClienteMayorista
        Dim clientesNegocio As NegClienteMayorista = New NegClienteMayorista()
        Dim direccionNegocio As NegDireccion = New NegDireccion()

        Negocio.Funciones.HayConexionInternet()

        Dim Respuesta As List(Of EntidadClientes) = New List(Of EntidadClientes)()

        For Each cli As Entidades.ClienteMayorista In clientesNegocio.TraerCliente(RazonSocial)
            Dim dir As Direccion = direccionNegocio.Consulta(cli.IdDireccionFacturacion)
            Dim entCliente As EntidadClientes = New EntidadClientes()
            entCliente.Codigo_Postal = dir.CodigoPostal
            entCliente.Cuit = cli.Cuit
            entCliente.Direccion = dir.Direccion
            entCliente.Habilitado = cli.Habilitado
            entCliente.id_Cliente = cli.Id
            entCliente.Mail = dir.Email
            entCliente.Observaciones = cli.Observaciones
            entCliente.RazonSocial = cli.RazonSocial
            entCliente.Telefono = dir.Telefono

            Respuesta.Add(entCliente)
        Next

        Return Respuesta
    End Function

End Class

