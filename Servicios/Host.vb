Imports System.ServiceModel
Imports System.ServiceModel.Description
Imports System.Net

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
            hostListas.AddServiceEndpoint(GetType(Servicios.ILista), New BasicHttpBinding(), "")
            Dim smb1 As ServiceMetadataBehavior = New ServiceMetadataBehavior()
            smb1.HttpGetEnabled = True
            smb1.MetadataExporter.PolicyVersion = PolicyVersion.Policy15
            hostListas.Description.Behaviors.Add(smb1)
            hostListas.Open()

            Dim hostCliente As ServiceHost = New ServiceHost(GetType(Cliente), New Uri(String.Format("http://{0}:{1}/Cliente", IP, puerto)))
            hostCliente.AddServiceEndpoint(GetType(Servicios.ICliente), New BasicHttpBinding(), "")
            Dim smb2 As ServiceMetadataBehavior = New ServiceMetadataBehavior()
            smb2.HttpGetEnabled = True
            smb2.MetadataExporter.PolicyVersion = PolicyVersion.Policy15
            hostCliente.Description.Behaviors.Add(smb2)
            hostCliente.Open()

            Dim hostNotaPedido As ServiceHost = New ServiceHost(GetType(NotaPedido), New Uri(String.Format("http://{0}:{1}/NotaPedido", IP, puerto)))
            hostNotaPedido.AddServiceEndpoint(GetType(Servicios.INotaPedido), New BasicHttpBinding(), "")
            Dim smb3 As ServiceMetadataBehavior = New ServiceMetadataBehavior()
            smb3.HttpGetEnabled = True
            smb3.MetadataExporter.PolicyVersion = PolicyVersion.Policy15
            hostNotaPedido.Description.Behaviors.Add(smb3)
            hostNotaPedido.Open()

            Dim hostProducto As ServiceHost = New ServiceHost(GetType(Producto), New Uri(String.Format("http://{0}:{1}/Producto", IP, puerto)))
            hostProducto.AddServiceEndpoint(GetType(Servicios.IProducto), New BasicHttpBinding(), "")
            Dim smb4 As ServiceMetadataBehavior = New ServiceMetadataBehavior()
            smb4.HttpGetEnabled = True
            smb4.MetadataExporter.PolicyVersion = PolicyVersion.Policy15
            hostProducto.Description.Behaviors.Add(smb4)
            hostProducto.Open()

            Dim hostUsuario As ServiceHost = New ServiceHost(GetType(Usuario), New Uri(String.Format("http://{0}:{1}/Usuario", IP, puerto)))
            hostUsuario.AddServiceEndpoint(GetType(Servicios.IUsuario), New BasicHttpBinding(), "")
            Dim smb5 As ServiceMetadataBehavior = New ServiceMetadataBehavior()
            smb5.HttpGetEnabled = True
            smb5.MetadataExporter.PolicyVersion = PolicyVersion.Policy15
            hostUsuario.Description.Behaviors.Add(smb5)
            hostUsuario.Open()

        Catch ex As Exception
            Dim eventLog As EventLog = New EventLog()
            eventLog.Source = "Cinderella"
            eventLog.WriteEntry("Se genero un error al iniciar el Host de servicios. Recuerde ejecutar el comando ""netsh http add urlacl url=http://+:[PUERTO]/[SERVICIO] user:todos""" & ex.Message, EventLogEntryType.Error)
            Throw ex
        End Try

    End Sub

End Class
