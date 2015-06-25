Imports System.Data.SqlClient

Public Class NegAdicionales
    Dim clsDatos As New Datos.Conexion
    Dim ClsFunciones As New Funciones
    Dim HayInternet As Boolean = ClsFunciones.GotInternet

    'Funcion para insertar un adelanto.
    Function AltaAdicional(ByVal eAdicional As Entidades.Adicionales) As String
        'Declaro variables
        Dim cmd As New SqlCommand
        Dim msg As String = ""

        Try
            'Conecto
            If (HayInternet) Then
                cmd.Connection = clsDatos.ConectarRemoto()
            Else
                cmd.Connection = clsDatos.ConectarLocal()
            End If

            cmd.CommandType = CommandType.StoredProcedure
            cmd.CommandText = "sp_Adicionales_Alta"
            With cmd.Parameters
                .AddWithValue("@id_Adicional", eAdicional.id_Adicional)
                .AddWithValue("@id_Empleado", eAdicional.id_Empleado)
                .AddWithValue("@id_Sucursal", eAdicional.id_Sucursal)
                .AddWithValue("@Monto", eAdicional.Monto)
                .AddWithValue("@Fecha", eAdicional.Fecha)
                .AddWithValue("@Descripcion", eAdicional.Descripcion)
            End With

            Dim respuesta As New SqlParameter("@msg", SqlDbType.VarChar, 255)
            respuesta.Direction = ParameterDirection.Output
            cmd.Parameters.Add(respuesta)
            cmd.ExecuteNonQuery()

            'Desconecto
            If (HayInternet) Then
                clsDatos.DesconectarRemoto()
            Else
                clsDatos.DesconectarLocal()
            End If

            'muestro el mensaje
            Return respuesta.Value
        Catch ex As Exception
            Return ex.Message
        End Try
    End Function

    'Funcion para obtener los adicionales de un empleado
    Function ObtenerAdicionales(ByVal id_Empleado As Integer, ByVal id_Sucursal As Integer, ByVal FDesde As String, ByVal FHasta As String)
        Dim dsAdel As New DataSet

        If HayInternet Then
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
        If HayInternet Then
            Return clsDatos.ConsultarBaseRemoto("execute sp_Adicionales_Listado @id_Empleado=" & id_Empleado & ", @id_Sucursal=" & id_Sucursal & ", @FDesde='" & FDesde & "', @FHasta='" & FHasta & "'")
        Else
            Return clsDatos.ConsultarBaseLocal("execute sp_Adicionales_Listado @id_Empleado=" & id_Empleado & ", @id_Sucursal=" & id_Sucursal & ", @FDesde='" & FDesde & "', @FHasta='" & FHasta & "'")
        End If
    End Function

    'Funcion para obtener los adicionales de una sucursal
    Function ObtenerAdicionalesSucursal(ByVal id_Sucursal As Integer, ByVal FDesde As String, ByVal FHasta As String)
        Dim dsAdel As New DataSet

        If HayInternet Then
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

        If HayInternet Then
            dsAdel = clsDatos.ConsultarBaseRemoto("execute sp_Adicionales_SucursalListado @id_Sucursal=" & id_Sucursal & ", @FDesde='" & FDesde & "', @FHasta='" & FHasta & "'")
        Else
            dsAdel = clsDatos.ConsultarBaseLocal("execute sp_Adicionales_SucursalListado @id_Sucursal=" & id_Sucursal & ", @FDesde='" & FDesde & "', @FHasta='" & FHasta & "'")
        End If

        Return dsAdel

    End Function

End Class
