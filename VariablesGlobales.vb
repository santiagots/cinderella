Imports System.Reflection

Module VariablesGlobales
    Public Patentes As Dictionary(Of Integer, String)
    Public objUsuario As New Entidades.Usuario
    Public Notificaciones As Integer = 0
    Public Mensajes As Integer = 0
    Public HayConexion As Boolean = False
    Public CajaCerrada As Integer = 0

    Public RutaCertificadoFacturacionElectronica As String = $"{Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData)}\{Assembly.GetExecutingAssembly.GetName().Name}\CertificadoAFIP.p12"
    Public RutaArchivoKeyFacturacionElectronica As String = $"{Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData)}\{Assembly.GetExecutingAssembly.GetName().Name}\ClavePrivada.key"
End Module
