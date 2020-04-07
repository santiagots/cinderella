Imports System.Reflection
Imports Common.Core.Helper

Module VariablesGlobales
    Public Patentes As Dictionary(Of Integer, String)
    Public objUsuario As New Entidades.Usuario
    Public Notificaciones As Integer = 0
    Public Mensajes As Integer = 0
    Public HayConexion As Boolean = False
    Public CajaCerrada As Integer = 0

    Public PasswordCertificadoFacturacionElectronica As String = Encriptar.EncriptarMD5("QtS^j]Xog3?sFQJ")
    Public RutaCertificadoFacturacionElectronica As String = $"{Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData)}\{Assembly.GetExecutingAssembly.GetName().Name}\CertificadoAFIP.p12"
    Public RutaArchivoKeyFacturacionElectronica As String = $"{Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData)}\{Assembly.GetExecutingAssembly.GetName().Name}\ClavePrivada.key"
End Module
