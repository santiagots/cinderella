Imports System.ServiceModel
Imports System.ServiceModel.Description
Imports System.Net

Public Class Host

    Private IP As String
    Private puerto As String

    Sub New(ByVal IP As String, ByVal puerto As String)
        Me.IP = IP
        Me.puerto = puerto
    End Sub


    Sub Start()

        Try

            Dim smb As ServiceMetadataBehavior = New ServiceMetadataBehavior()
            smb.HttpGetEnabled = True
            smb.MetadataExporter.PolicyVersion = PolicyVersion.Policy15


            ' Create the ServiceHost.
            Dim hostListas As ServiceHost = New ServiceHost(GetType(Listas), New Uri(String.Format("http://{0}:{1}/Listas", IP, puerto)))
            hostListas.AddServiceEndpoint(GetType(Servicios.ILista), New BasicHttpBinding(), "")
            AddBehavior(hostListas)
            hostListas.Description.Behaviors.Add(smb)
            hostListas.Open()

            Dim hostCliente As ServiceHost = New ServiceHost(GetType(Cliente), New Uri(String.Format("http://{0}:{1}/Cliente", IP, puerto)))
            hostCliente.AddServiceEndpoint(GetType(Servicios.ICliente), New BasicHttpBinding(), "")
            AddBehavior(hostCliente)
            hostCliente.Description.Behaviors.Add(smb)
            hostCliente.Open()

            Dim hostNotaPedido As ServiceHost = New ServiceHost(GetType(NotaPedido), New Uri(String.Format("http://{0}:{1}/NotaPedido", IP, puerto)))
            hostNotaPedido.AddServiceEndpoint(GetType(Servicios.INotaPedido), New BasicHttpBinding(), "")
            AddBehavior(hostNotaPedido)
            hostNotaPedido.Description.Behaviors.Add(smb)
            hostNotaPedido.Open()

            Dim hostProducto As ServiceHost = New ServiceHost(GetType(Producto), New Uri(String.Format("http://{0}:{1}/Producto", IP, puerto)))
            hostProducto.AddServiceEndpoint(GetType(Servicios.IProducto), New BasicHttpBinding(), "")
            AddBehavior(hostProducto)
            hostProducto.Description.Behaviors.Add(smb)
            hostProducto.Open()

            Dim hostUsuario As ServiceHost = New ServiceHost(GetType(Usuario), New Uri(String.Format("http://{0}:{1}/Usuario", IP, puerto)))
            hostUsuario.AddServiceEndpoint(GetType(Servicios.IUsuario), New BasicHttpBinding(), "")
            AddBehavior(hostUsuario)
            hostUsuario.Description.Behaviors.Add(smb)
            hostUsuario.Open()

        Catch ex As Exception
            Dim eventLog As EventLog = New EventLog()
            eventLog.Source = "Cinderella"
            eventLog.WriteEntry("Se genero un error al iniciar el Host de servicios. Recuerde ejecutar el comando ""netsh http add urlacl url=http://+:[PUERTO]/[SERVICIO] user:todos""" & ex.Message, EventLogEntryType.Error)
            Throw ex
        End Try

    End Sub

    Sub AddBehavior(ByRef host As ServiceHost)
        'Dim smb As ServiceMetadataBehavior = New ServiceMetadataBehavior()
        'smb.HttpGetEnabled = True
        'smb.MetadataExporter.PolicyVersion = PolicyVersion.Policy15
        'host.Description.Behaviors.Add(smb)
    End Sub

End Class
