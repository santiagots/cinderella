Imports Negocio
Imports System.ServiceModel

<ServiceBehavior(IncludeExceptionDetailInFaults:=True, UseSynchronizationContext:=False)>
Public Class Usuario
    Implements IUsuario

    Public Function Login(ByVal Usuario As String, ByVal Password As String) As EntidadUsuario Implements IUsuario.Login
        Dim UsuarioNegocio As Negocio.Usuario = New Negocio.Usuario()
        Dim patentes As New Negocio.NegPatentes
        Dim encripta As New ClsEncriptacion()

        Dim usuarioLogIn As Entidades.Usuario = UsuarioNegocio.Login(Usuario.ToLower(), encripta.EncriptarMD5(Password.ToLower()))

        Dim entUsuario As EntidadUsuario = New EntidadUsuario()

        entUsuario.Apellido = usuarioLogIn.Apellido
        entUsuario.Fecha = usuarioLogIn.Fecha
        entUsuario.Habilitado = usuarioLogIn.Habilitado
        entUsuario.id_Perfil = usuarioLogIn.id_Perfil
        entUsuario.Mail = usuarioLogIn.Mail
        entUsuario.Nombre = usuarioLogIn.Nombre
        entUsuario.PWD = usuarioLogIn.PWD
        entUsuario.id_Usuario = usuarioLogIn.id_Usuario
        entUsuario.Patentes = patentes.ObtenerPatentes(usuarioLogIn.id_Usuario, Host.Id_Sucursal)

        Return entUsuario
    End Function

End Class