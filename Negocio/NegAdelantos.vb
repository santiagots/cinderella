Imports System.Data.SqlClient

Public Class NegAdelantos
    Dim clsDatos As New Datos.Conexion

    'Funcion para insertar un adelanto.
    Function AltaAdelanto(ByVal eAdelanto As Entidades.Adelantos) As String
        'Declaro variables
        Dim cmd As New SqlCommand
        Dim msg As String = ""

        'Si el adelanto no tiene ID se trata de un alta y le tengo que generar el ID
        If (eAdelanto.id_Adelanto = 0) Then
            eAdelanto.id_Adelanto = clsDatos.ObtenerCalveUnica(eAdelanto.id_Sucursal)
        End If
        eAdelanto.FechaEdicion = DateTime.Now()

        Try
            cmd.Connection = clsDatos.ConectarLocal()
            msg = AltaAdelanto(eAdelanto, cmd)
            clsDatos.DesconectarLocal()

            'muestro el mensaje
            Return msg
        Catch ex As Exception
            Return ex.Message
        End Try
    End Function

    Private Shared Function AltaAdelanto(eAdelanto As Entidades.Adelantos, ByRef cmd As SqlCommand) As String
        cmd.CommandType = CommandType.StoredProcedure
        cmd.CommandText = "sp_Adelantos_Alta"
        With cmd.Parameters
            .AddWithValue("@id_Adelanto", eAdelanto.id_Adelanto)
            .AddWithValue("@id_Empleado", eAdelanto.id_Empleado)
            .AddWithValue("@id_Sucursal", eAdelanto.id_Sucursal)
            .AddWithValue("@Monto", eAdelanto.Monto)
            .AddWithValue("@Fecha", eAdelanto.Fecha)
            .AddWithValue("@Descripcion", eAdelanto.Descripcion)
            .AddWithValue("@FechaEdicion", eAdelanto.FechaEdicion)
        End With
        Dim respuesta As New SqlParameter("@msg", SqlDbType.VarChar, 255)
        respuesta.Direction = ParameterDirection.Output
        cmd.Parameters.Add(respuesta)
        cmd.ExecuteNonQuery()

        Return respuesta.Value
    End Function

    'Funcion para obtener los adelantos de un empleado
    Function ObtenerAdelantos(ByVal id_Empleado As Integer, ByVal id_Sucursal As Integer, ByVal FDesde As String, ByVal FHasta As String)
        Dim dsAdel As New DataSet

        dsAdel = clsDatos.ConsultarBaseLocal("execute sp_Adelantos_Obtener @id_Empleado=" & id_Empleado & ", @id_Sucursal=" & id_Sucursal & ", @FDesde='" & FDesde & "', @FHasta='" & FHasta & "'")

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
    Function EliminarAdelanto(ByVal id_Adelanto As Int64, ByVal id_Sucursal As Integer)
        Dim cmd As New SqlCommand
        Dim msg As String
        Dim FechaEdicion As DateTime = DateTime.Now

        Try
            cmd.Connection = clsDatos.ConectarLocal()
            msg = EliminarAdelanto(id_Adelanto, id_Sucursal, FechaEdicion, cmd)
            clsDatos.DesconectarLocal()

            'muestro el mensaje
            Return msg
        Catch ex As Exception
            Return ex.Message
        End Try
    End Function

    Private Shared Function EliminarAdelanto(id_Adelanto As Int64, id_Sucursal As Integer, FechaEdicion As DateTime, ByRef cmd As SqlCommand) As String
        cmd.CommandType = CommandType.StoredProcedure
        cmd.CommandText = "sp_Adelantos_Eliminar"
        With cmd.Parameters
            .AddWithValue("@id_Adelanto", id_Adelanto)
            .AddWithValue("@id_Sucursal", id_Sucursal)
            .AddWithValue("@FechaEdicion", FechaEdicion)
        End With
        Dim respuesta As New SqlParameter("@msg", SqlDbType.VarChar, 255)
        respuesta.Direction = ParameterDirection.Output
        cmd.Parameters.Add(respuesta)
        cmd.ExecuteNonQuery()

        Return respuesta.Value
    End Function

    'Funcion para obtener los adelantos de un empleado
    Function ObtenerAdelanto(ByVal id_Adelanto As Int64, ByVal id_Sucursal As Integer)
        Dim dsAdel As New DataSet

        dsAdel = clsDatos.ConsultarBaseLocal("execute sp_Adelantos_ObtenerAdelanto @id_Adelanto=" & id_Adelanto & ", @id_Sucursal=" & id_Sucursal)

        Return dsAdel
    End Function

    'Funcion para obtener los adelantos de una sucursal
    Function ObtenerAdelantosSucursal(ByVal id_Sucursal As Integer, ByVal FDesde As String, ByVal FHasta As String)
        Dim dsAdel As New DataSet

        dsAdel = clsDatos.ConsultarBaseLocal("execute sp_Adelantos_SucursalObtener @id_Sucursal=" & id_Sucursal & ", @FDesde='" & FDesde & "', @FHasta='" & FHasta & "'")

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

        dsAdel = clsDatos.ConsultarBaseLocal("execute sp_Adelantos_SucursalListado @id_Sucursal=" & id_Sucursal & ", @FDesde='" & FDesde & "', @FHasta='" & FHasta & "'")

        Return dsAdel

    End Function

    'Funcion que lista las Adelantos de un empleado.
    Function ListarAdelantosEmpleado(ByVal id_Empleado As Integer, ByVal id_Sucursal As Integer, ByVal FDesde As String, ByVal FHasta As String)

        Return clsDatos.ConsultarBaseLocal("execute sp_Adelantos_Listado @id_Empleado=" & id_Empleado & ", @id_Sucursal=" & id_Sucursal & ", @FDesde='" & FDesde & "', @FHasta='" & FHasta & "'")

    End Function

End Class
