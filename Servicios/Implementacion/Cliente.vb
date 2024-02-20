Imports System.ServiceModel
Imports Common.Core.Enum
Imports Common.Core.Model
Imports Common.Data.Service

<ServiceBehavior(IncludeExceptionDetailInFaults:=True, UseSynchronizationContext:=False)>
Public Class Cliente
    Implements ICliente

    Public Function GetClienteMayorista(RazonSocial As String) As List(Of EntidadClientes) Implements ICliente.GetClienteMayorista
        Dim Respuesta As List(Of EntidadClientes) = New List(Of EntidadClientes)()

        Dim clientesModel As List(Of ClienteMayorista) = ClienteMayoristaService.BuscarAsync(TipoBase.Local,
                                                                                                    RazonSocial,
                                                                                                    Nothing,
                                                                                                    Nothing,
                                                                                                    Nothing,
                                                                                                    Nothing,
                                                                                                    Nothing,
                                                                                                    Nothing,
                                                                                                    "RazonSocial",
                                                                                                    OrdenadoDireccion.ASC,
                                                                                                    1,
                                                                                                    100,
                                                                                                    Nothing).Result

        Dim cpostal As Integer

        clientesModel.ForEach(Sub(x)
                                  Dim entCliente As EntidadClientes = New EntidadClientes()
                                  entCliente.Codigo_Postal = If(Integer.TryParse(x.DomicilioFacturacion.CodigoPostal, cpostal), cpostal, 0)
                                  entCliente.Cuit = x.Cuit
                                  entCliente.Direccion = x.DomicilioFacturacion.Direccion
                                  entCliente.Habilitado = 1
                                  entCliente.id_Cliente = x.Id
                                  entCliente.Mail = x.DomicilioFacturacion.Email
                                  entCliente.Observaciones = x.Observaciones
                                  entCliente.RazonSocial = x.RazonSocial
                                  entCliente.Telefono = x.DomicilioFacturacion.Telefono
                                  entCliente.Bonificacion = x.PorcentajeBonificacion
                                  Respuesta.Add(entCliente)
                              End Sub)

        Return Respuesta
    End Function

End Class

