Public Class EntidadUsuario
    Public Property id_Perfil As Integer
    Public Property id_Usuario As Integer
    Public Property PWD As String
    Public Property Nombre As String
    Public Property Apellido As String
    Public Property Mail As String
    Public Property Fecha As Date
    Public Property Habilitado As Integer
    Public Property Patentes As Dictionary(Of Integer, String)
End Class
