Imports System.ServiceModel
Imports System.ServiceModel.Description

Public Class Host

    Private IP As String
    Private puerto As String

    Public Shared NombreSucursal As String
    Public Shared NombreListaPrecio As String
    Public Shared Id_Sucursal As Integer
    Public Shared Id_GrupoPrecio As Integer

    Sub New(ByVal IP As String, ByVal puerto As String, nomSucrsal As String, nomListaPrecio As String, id_Suc As Integer, id_Precio As Integer)
        Me.IP = IP
        Me.puerto = puerto

        NombreSucursal = nomSucrsal
        NombreListaPrecio = nomListaPrecio
        Id_Sucursal = id_Suc
        Id_GrupoPrecio = id_Precio

    End Sub


    Sub Start()

        Try
            ' Create the ServiceHost.
            Dim hostListas As ServiceHost = New ServiceHost(GetType(Listas), New Uri(String.Format("http://{0}:{1}/Listas", IP, puerto)))
            CreateHost(hostListas, GetType(ILista))

            Dim hostCliente As ServiceHost = New ServiceHost(GetType(Cliente), New Uri(String.Format("http://{0}:{1}/Cliente", IP, puerto)))
            CreateHost(hostCliente, GetType(ICliente))

            Dim hostNotaPedido As ServiceHost = New ServiceHost(GetType(NotaPedido), New Uri(String.Format("http://{0}:{1}/NotaPedido", IP, puerto)))
            CreateHost(hostNotaPedido, GetType(INotaPedido))

            Dim hostProducto As ServiceHost = New ServiceHost(GetType(Producto), New Uri(String.Format("http://{0}:{1}/Producto", IP, puerto)))
            CreateHost(hostProducto, GetType(IProducto))

            Dim hostUsuario As ServiceHost = New ServiceHost(GetType(Usuario), New Uri(String.Format("http://{0}:{1}/Usuario", IP, puerto)))
            CreateHost(hostUsuario, GetType(IUsuario))

            Dim hostEmpleado As ServiceHost = New ServiceHost(GetType(Empleado), New Uri(String.Format("http://{0}:{1}/Empleado", IP, puerto)))
            CreateHost(hostEmpleado, GetType(IEmpleado))

        Catch ex As Exception
            Dim eventLog As EventLog = New EventLog()
            eventLog.Source = "Cinderella"
            eventLog.WriteEntry("Se genero un error al iniciar el Host de servicios. Recuerde ejecutar el comando ""netsh http add urlacl url=http://+:[PUERTO]/[SERVICIO] user:todos""" & ex.Message, EventLogEntryType.Error)
            Throw ex
        End Try

    End Sub

    Private Shared Sub CreateHost(serviceHost As ServiceHost, contract As Type)
        serviceHost.AddServiceEndpoint(contract, New BasicHttpBinding(), "")
        Dim smb As ServiceMetadataBehavior = GetBehavior()
        serviceHost.Description.Behaviors.Add(smb)
        serviceHost.Open()
    End Sub

    Private Shared Function GetBehavior() As ServiceMetadataBehavior
        Dim smb As ServiceMetadataBehavior = New ServiceMetadataBehavior()
        smb.HttpGetEnabled = True
        smb.MetadataExporter.PolicyVersion = PolicyVersion.Policy15
        Return smb
    End Function
End Class
