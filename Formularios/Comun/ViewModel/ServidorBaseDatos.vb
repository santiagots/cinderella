Namespace Formularios.Comun
    Public Class ServidorBaseDatos
        Property Nombre As String
        Property Instancia As String
        Property Version As String

        Public Sub New(nombre As String, instancia As String, version As String)
            Me.Nombre = nombre
            Me.Instancia = instancia
            Me.Version = version
        End Sub
    End Class
End Namespace
