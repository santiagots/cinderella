Imports System.Data.SqlClient

Public Class NegAdicionales
    Dim clsDatos As New Datos.Conexion
    Dim ClsFunciones As New Funciones

    'Funcion para insertar un adelanto.
    Function AltaAdicional(ByVal eAdicional As Entidades.Adicionales) As String
        'Declaro variables
        Dim cmd As New SqlCommand
        Dim msg As String = ""
        Dim HayInternet As Boolean = Funciones.HayInternet

        If (eAdicional.id_Adicional >= 0) Then
            eAdicional.id_Adicional = clsDatos.ObtenerCalveUnica(eAdicional.id_Sucursal)
        End If
        eAdicional.FechaEdicion = DateTime.Now

        Try
            cmd.Connection = clsDatos.ConectarLocal()
            msg = AltaAdicional(eAdicional, cmd)
            clsDatos.DesconectarLocal()

            If (HayInternet) Then
                cmd = New SqlCommand()
                cmd.Connection = clsDatos.ConectarRemoto()
                msg = AltaAdicional(eAdicional, cmd)
                clsDatos.DesconectarRemoto()
            End If

            'muestro el mensaje
            Return msg
        Catch ex As Exception
            Return ex.Message
        End Try
    End Function

    Private Shared Function AltaAdicional(eAdicional As Entidades.Adicionales, cmd As SqlCommand) As String
        cmd.CommandType = CommandType.StoredProcedure
        cmd.CommandText = "sp_Adicionales_Alta"
        With cmd.Parameters
            .AddWithValue("@id_Adicional", eAdicional.id_Adicional)
            .AddWithValue("@id_Empleado", eAdicional.id_Empleado)
            .AddWithValue("@id_Sucursal", eAdicional.id_Sucursal)
            .AddWithValue("@Monto", eAdicional.Monto)
            .AddWithValue("@Fecha", eAdicional.Fecha)
            .AddWithValue("@Descripcion", eAdicional.Descripcion)
            .AddWithValue("@FechaEdicion", eAdicional.FechaEdicion)
        End With
        Dim respuesta As New SqlParameter("@msg", SqlDbType.VarChar, 255)
        respuesta.Direction = ParameterDirection.Output
        cmd.Parameters.Add(respuesta)
        cmd.ExecuteNonQuery()

        Return respuesta.Value
    End Function

    'Funcion para obtener los adicionales de un empleado
    Function ObtenerAdicionales(ByVal id_Empleado As Integer, ByVal id_Sucursal As Integer, ByVal FDesde As String, ByVal FHasta As String)
        Dim dsAdel As New DataSet

        If Funciones.HayInternet Then
            dsAdel = clsDatos.ConsultarBaseRemoto("execute sp_Adicionales_Obtener @id_Empleado=" & id_Empleado & ", @id_Sucursal=" & id_Sucursal & ", @FDesde='" & FDesde & "', @FHasta='" & FHasta & "'")
        Else
            dsAdel = clsDatos.ConsultarBaseLocal("execute sp_Adicionales_Obtener @id_Empleado=" & id_Empleado & ", @id_Sucursal=" & id_Sucursal & ", @FDesde='" & FDesde & "', @FHasta='" & FHasta & "'")
        End If

        If dsAdel.Tables(0).Rows.Count > 0 Then
            If dsAdel.Tables(0).Rows(0).Item("Adicional").ToString <> "" Then
                Return dsAdel.Tables(0).Rows(0).Item("Adicional").ToString
            Else
                Return 0
            End If
        Else
            Return 0
        End If
    End Function

    'Funcion que lista las Adicionales de un empleado.
    Function ListarAdicionalesEmpleado(ByVal id_Empleado As Integer, ByVal id_Sucursal As Integer, ByVal FDesde As String, ByVal FHasta As String)
        If Funciones.HayInternet Then
            Return clsDatos.ConsultarBaseRemoto("execute sp_Adicionales_Listado @id_Empleado=" & id_Empleado & ", @id_Sucursal=" & id_Sucursal & ", @FDesde='" & FDesde & "', @FHasta='" & FHasta & "'")
        Else
            Return clsDatos.ConsultarBaseLocal("execute sp_Adicionales_Listado @id_Empleado=" & id_Empleado & ", @id_Sucursal=" & id_Sucursal & ", @FDesde='" & FDesde & "', @FHasta='" & FHasta & "'")
        End If
    End Function

    'Funcion para obtener los adicionales de una sucursal
    Function ObtenerAdicionalesSucursal(ByVal id_Sucursal As Integer, ByVal FDesde As String, ByVal FHasta As String)
        Dim dsAdel As New DataSet

        If Funciones.HayInternet Then
            dsAdel = clsDatos.ConsultarBaseRemoto("execute sp_Adicionales_SucursalObtener @id_Sucursal=" & id_Sucursal & ", @FDesde='" & FDesde & "', @FHasta='" & FHasta & "'")
        Else
            dsAdel = clsDatos.ConsultarBaseLocal("execute sp_Adicionales_SucursalObtener @id_Sucursal=" & id_Sucursal & ", @FDesde='" & FDesde & "', @FHasta='" & FHasta & "'")
        End If

        If dsAdel.Tables(0).Rows.Count > 0 Then
            If dsAdel.Tables(0).Rows(0).Item("Adicional").ToString <> "" Then
                Return dsAdel.Tables(0).Rows(0).Item("Adicional").ToString
            Else
                Return 0
            End If
        Else
            Return 0
        End If
    End Function

    'Funcion para obtener los adelantos de una sucursal
    Function ObtenerAdicionalesSucursalListado(ByVal id_Sucursal As Integer, ByVal FDesde As String, ByVal FHasta As String)
        Dim dsAdel As New DataSet

        If Funciones.HayInternet Then
            dsAdel = clsDatos.ConsultarBaseRemoto("execute sp_Adicionales_SucursalListado @id_Sucursal=" & id_Sucursal & ", @FDesde='" & FDesde & "', @FHasta='" & FHasta & "'")
        Else
            dsAdel = clsDatos.ConsultarBaseLocal("execute sp_Adicionales_SucursalListado @id_Sucursal=" & id_Sucursal & ", @FDesde='" & FDesde & "', @FHasta='" & FHasta & "'")
        End If

        Return dsAdel

    End Function

End Class
