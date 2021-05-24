Imports System.Reflection
Imports Common.Core.Helper

Module VariablesGlobales
    Public Patentes As Dictionary(Of Integer, String)
    Public objUsuario As New Entidades.Usuario
    Public Notificaciones As Integer = 0
    Public Mensajes As Integer = 0
    Public HayConexion As Boolean = False
    Public CajaCerrada As Integer = 0

    Public ReadOnly PasswordCertificadoFacturacionElectronica As String = Encriptar.EncriptarMD5("QtS^j]Xog3?sFQJ")
    Public ReadOnly RutaCertificadoFacturacionElectronica As String = $"{Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData)}\{Assembly.GetExecutingAssembly.GetName().Name}\CertificadoAFIP.p12"
    Public ReadOnly RutaArchivoKeyFacturacionElectronica As String = $"{Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData)}\{Assembly.GetExecutingAssembly.GetName().Name}\ClavePrivada.key"

    Public ReadOnly colorFondoAlerta As Color = Color.FromArgb(255, 255, 75, 58)
    Public ReadOnly colorTextoAlerta As Color = Color.White
    Public ReadOnly colorFondoOk As Color = Color.FromArgb(255, 0, 205, 106)
    Public ReadOnly colorTextoOk As Color = Color.Black
End Module
