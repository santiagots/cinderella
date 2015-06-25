Imports System.Data
Imports System.Data.SqlClient
Imports System.Configuration

Public Class Conexion
    Private CadenaConexion As String
    Dim miconexion As SqlConnection
    Dim miconexionRemoto As SqlConnection
    Dim encripta As New ClsEncriptacion
    Dim com As New SqlCommand
    Dim da As New SqlDataAdapter
    Dim ds As DataSet

    Public Function ConectarLocal()
        Try
            CadenaConexion = System.Configuration.ConfigurationManager.ConnectionStrings("SistemaCinderella.My.MySettings.Conexion").ToString
            miconexion = New SqlConnection
            'miconexion.ConnectionString = encripta.DesencriptarMD5(CadenaConexion)
            miconexion.ConnectionString = CadenaConexion
            miconexion.Open()
        Catch ex As Exception
            Windows.Forms.MessageBox.Show("Error conectando con la base de datos." & ex.Message)
        End Try
        Return miconexion
    End Function

    Public Sub DesconectarLocal()
        miconexion.Dispose()
        miconexion.Close()
    End Sub

    Public Function ConectarRemoto()
        Try
            CadenaConexion = System.Configuration.ConfigurationManager.ConnectionStrings("SistemaCinderella.My.MySettings.ConexionRemoto").ToString
            miconexionRemoto = New SqlConnection
            miconexionRemoto.ConnectionString = encripta.DesencriptarMD5(CadenaConexion)
            miconexionRemoto.Open()
        Catch ex As Exception
            Windows.Forms.MessageBox.Show("Error conectando con la base de datos." & ex.Message)
        End Try
        Return miconexionRemoto
    End Function

    Public Sub DesconectarRemoto()
        miconexionRemoto.Dispose()
        miconexionRemoto.Close()
    End Sub

    Public Sub ModificarBaseLocal(ByVal query As String)
        Me.ConectarLocal()
        com.CommandText = query
        com.ExecuteNonQuery()
        Me.DesconectarLocal()
    End Sub

    Public Sub ModificarBaseRemoto(ByVal query As String)
        Me.ConectarRemoto()
        com.Connection = miconexionRemoto
        com.CommandText = query
        com.ExecuteNonQuery()
        Me.DesconectarRemoto()
    End Sub
    Public Function ConsultarBaseLocal(ByVal query As String)
        miconexion = ConectarLocal()
        ds = New DataSet()
        da = New SqlDataAdapter(query, miconexion)
        da.Fill(ds)
        Me.DesconectarLocal()
        Return ds
    End Function
    Public Function ConsultarBaseRemoto(ByVal query As String)
        miconexion = ConectarRemoto()
        ds = New DataSet()
        da = New SqlDataAdapter(query, miconexion)
        da.Fill(ds)
        Me.DesconectarRemoto()
        Return ds
    End Function
End Class
