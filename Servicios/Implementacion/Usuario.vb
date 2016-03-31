Imports Entidades
Imports Negocio
Imports System.ServiceModel

<ServiceBehavior(IncludeExceptionDetailInFaults:=True)>
Public Class Usuario
    Implements IUsuario

    Public Function Login(ByVal Usuario As String, ByVal Password As String) As Entidades.Usuario Implements IUsuario.Login
        Dim UsuarioNegocio As Negocio.Usuario = New Negocio.Usuario()
        Dim encripta As New ClsEncriptacion()

        Dim usuarioLogIn As Entidades.Usuario = UsuarioNegocio.Login(Usuario.ToLower(), encripta.EncriptarMD5(Password.ToLower()))

        Return usuarioLogIn
    End Function

End Class