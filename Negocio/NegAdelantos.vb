Imports System.Data.SqlClient

Public Class NegAdelantos
    Dim clsDatos As New Datos.Conexion

    'Funcion para insertar un adelanto.
    Function AltaAdelanto(ByVal eAdelanto As Entidades.Adelantos) As String
        'Declaro variables
        Dim cmd As New SqlCommand
        Dim msg As String = ""
        Dim HayInternet As Boolean = Funciones.HayInternet

        Try
            'Conecto
            If (HayInternet) Then
                cmd.Connection = clsDatos.ConectarRemoto()
            Else
                cmd.Connection = clsDatos.ConectarLocal()
            End If

            cmd.CommandType = CommandType.StoredProcedure
            cmd.CommandText = "sp_Adelantos_Alta"
            With cmd.Parameters
                .AddWithValue("@id_Adelanto", eAdelanto.id_Adelanto)
                .AddWithValue("@id_Empleado", eAdelanto.id_Empleado)
                .AddWithValue("@id_Sucursal", eAdelanto.id_Sucursal)
                .AddWithValue("@Monto", eAdelanto.Monto)
                .AddWithValue("@Fecha", eAdelanto.Fecha)
                .AddWithValue("@Descripcion", eAdelanto.Descripcion)
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

    'Funcion para obtener los adelantos de un empleado
    Function ObtenerAdelantos(ByVal id_Empleado As Integer, ByVal id_Sucursal As Integer, ByVal FDesde As String, ByVal FHasta As String)
        Dim dsAdel As New DataSet

        If Funciones.HayInternet Then
            dsAdel = clsDatos.ConsultarBaseRemoto("execute sp_Adelantos_Obtener @id_Empleado=" & id_Empleado & ", @id_Sucursal=" & id_Sucursal & ", @FDesde='" & FDesde & "', @FHasta='" & FHasta & "'")
        Else
            dsAdel = clsDatos.ConsultarBaseLocal("execute sp_Adelantos_Obtener @id_Empleado=" & id_Empleado & ", @id_Sucursal=" & id_Sucursal & ", @FDesde='" & FDesde & "', @FHasta='" & FHasta & "'")
        End If

        If dsAdel.Tables(0).Rows.Count > 0 Then
            If dsAdel.Tables(0).Rows(0).Item("Adelanto").ToString <> "" Then
                Return dsAdel.Tables(0).Rows(0).Item("Adelanto").ToString
            Else
                Return 0
            End If
        Else
            Return 0
        End If
    End Function

    'Funcion para obtener los adelantos de un empleado
    Function EliminarAdelanto(ByVal id_Adelanto As Integer, ByVal id_Sucursal As Integer)
        Dim cmd As New SqlCommand
        Dim HayInternet As Boolean = Funciones.HayInternet

        Try
            If HayInternet Then
                cmd.Connection = clsDatos.ConectarRemoto()
            Else
                cmd.Connection = clsDatos.ConectarLocal()
            End If

            cmd.CommandType = CommandType.StoredProcedure
            cmd.CommandText = "sp_Adelantos_Eliminar"
            With cmd.Parameters
                .AddWithValue("@id_Adelanto", id_Adelanto)
                .AddWithValue("@id_Sucursal", id_Sucursal)
            End With
            Dim respuesta As New SqlParameter("@msg", SqlDbType.VarChar, 255)
            respuesta.Direction = ParameterDirection.Output
            cmd.Parameters.Add(respuesta)

            cmd.ExecuteNonQuery()

            If HayInternet Then
                clsDatos.DesconectarRemoto()
            Else
                clsDatos.DesconectarLocal()
            End If

            Return respuesta.Value
        Catch ex As Exception
            Return ex.Message
        End Try

    End Function

    'Funcion para obtener los adelantos de un empleado
    Function ObtenerAdelanto(ByVal id_Adelanto As Integer, ByVal id_Sucursal As Integer)
        Dim dsAdel As New DataSet

        If Funciones.HayInternet Then
            dsAdel = clsDatos.ConsultarBaseRemoto("execute sp_Adelantos_ObtenerAdelanto @id_Adelanto=" & id_Adelanto & ", @id_Sucursal=" & id_Sucursal)
        Else
            dsAdel = clsDatos.ConsultarBaseLocal("execute sp_Adelantos_ObtenerAdelanto @id_Adelanto=" & id_Adelanto & ", @id_Sucursal=" & id_Sucursal)
        End If
            Return dsAdel
    End Function

    'Funcion para obtener los adelantos de una sucursal
    Function ObtenerAdelantosSucursal(ByVal id_Sucursal As Integer, ByVal FDesde As String, ByVal FHasta As String)
        Dim dsAdel As New DataSet

        If Funciones.HayInternet Then
            dsAdel = clsDatos.ConsultarBaseRemoto("execute sp_Adelantos_SucursalObtener @id_Sucursal=" & id_Sucursal & ", @FDesde='" & FDesde & "', @FHasta='" & FHasta & "'")
        Else
            dsAdel = clsDatos.ConsultarBaseLocal("execute sp_Adelantos_SucursalObtener @id_Sucursal=" & id_Sucursal & ", @FDesde='" & FDesde & "', @FHasta='" & FHasta & "'")
        End If

        If dsAdel.Tables(0).Rows.Count > 0 Then
            If dsAdel.Tables(0).Rows(0).Item("Adelanto").ToString <> "" Then
                Return dsAdel.Tables(0).Rows(0).Item("Adelanto").ToString
            Else
                Return 0
            End If
        Else
            Return 0
        End If
    End Function

    'Funcion para obtener los adelantos de una sucursal
    Function ObtenerAdelantosSucursalListado(ByVal id_Sucursal As Integer, ByVal FDesde As String, ByVal FHasta As String)
        Dim dsAdel As New DataSet

        If Funciones.HayInternet Then
            dsAdel = clsDatos.ConsultarBaseRemoto("execute sp_Adelantos_SucursalListado @id_Sucursal=" & id_Sucursal & ", @FDesde='" & FDesde & "', @FHasta='" & FHasta & "'")
        Else
            dsAdel = clsDatos.ConsultarBaseLocal("execute sp_Adelantos_SucursalListado @id_Sucursal=" & id_Sucursal & ", @FDesde='" & FDesde & "', @FHasta='" & FHasta & "'")
        End If

        Return dsAdel

    End Function

    'Funcion que lista las Adelantos de un empleado.
    Function ListarAdelantosEmpleado(ByVal id_Empleado As Integer, ByVal id_Sucursal As Integer, ByVal FDesde As String, ByVal FHasta As String)
        If Funciones.HayInternet Then
            Return clsDatos.ConsultarBaseRemoto("execute sp_Adelantos_Listado @id_Empleado=" & id_Empleado & ", @id_Sucursal=" & id_Sucursal & ", @FDesde='" & FDesde & "', @FHasta='" & FHasta & "'")
        Else
            Return clsDatos.ConsultarBaseLocal("execute sp_Adelantos_Listado @id_Empleado=" & id_Empleado & ", @id_Sucursal=" & id_Sucursal & ", @FDesde='" & FDesde & "', @FHasta='" & FHasta & "'")
        End If
    End Function

End Class
