Imports System.Data.SqlClient

Public Class NegRecibos
    Dim clsDatos As New Datos.Conexion
    Dim ClsFunciones As New Funciones

    'Funcion para insertar un recibo de sueldo.
    Function AltaReciboSueldo(ByVal eRecibo As Entidades.Recibos) As String
        'Declaro variables
        Dim cmd As New SqlCommand
        Dim msg As String = ""
        Dim HayInternet As Boolean = Funciones.HayInternet

        Try
            cmd.Connection = clsDatos.ConectarLocal()
            AltaReciboSueldo(eRecibo, cmd)
            clsDatos.DesconectarLocal()

            If (HayInternet) Then
                cmd = New SqlCommand()
                cmd.Connection = clsDatos.ConectarRemoto()
                AltaReciboSueldo(eRecibo, cmd)
                clsDatos.DesconectarRemoto()
            End If

            'muestro el mensaje
            Return msg
        Catch ex As Exception
            Return ex.Message
        End Try
    End Function

    Private Shared Function AltaReciboSueldo(eRecibo As Entidades.Recibos, ByRef cmd As SqlCommand) As String
        cmd.CommandType = CommandType.StoredProcedure
        cmd.CommandText = "sp_Recibos_Alta"
        With cmd.Parameters
            .AddWithValue("@id_Empleado", eRecibo.id_Empleado)
            .AddWithValue("@id_Sucursal", eRecibo.id_Sucursal)
            .AddWithValue("@Monto", eRecibo.Monto)
            .AddWithValue("@Vacaciones", eRecibo.Vacaciones)
            .AddWithValue("@Aguinaldo", eRecibo.Aguinaldo)
            .AddWithValue("@Mes", eRecibo.Mes)
            .AddWithValue("@Anio", eRecibo.Anio)
        End With
        Dim respuesta As New SqlParameter("@msg", SqlDbType.VarChar, 255)
        respuesta.Direction = ParameterDirection.Output
        cmd.Parameters.Add(respuesta)
        cmd.ExecuteNonQuery()
        Return respuesta.Value
    End Function

    'Funcion para obtener los recibos de un empleado
    Function ObtenerRecibos(ByVal id_Empleado As Integer, ByVal id_Sucursal As Integer, ByVal Anio As Integer)
        Dim dsRecibos As New DataSet

        If Funciones.HayInternet Then
            dsRecibos = clsDatos.ConsultarBaseRemoto("execute sp_Recibos_Obtener @id_Empleado=" & id_Empleado & ", @id_Sucursal=" & id_Sucursal & ", @Anio=" & Anio)
        Else
            dsRecibos = clsDatos.ConsultarBaseLocal("execute sp_Recibos_Obtener @id_Empleado=" & id_Empleado & ", @id_Sucursal=" & id_Sucursal & ", @Anio=" & Anio)
        End If

        If dsRecibos.Tables(0).Rows.Count > 0 Then
            Return dsRecibos
        Else
            Return Nothing
        End If
    End Function

    'Funcion para obtener el recibo de un empleado.
    Function ObtenerRecibo(ByVal id_Empleado As Integer, ByVal id_Sucursal As Integer, ByVal Mes As String, ByVal Anio As Integer)
        Dim dsRecibo As New DataSet

        If Funciones.HayInternet Then
            dsRecibo = clsDatos.ConsultarBaseRemoto("execute sp_Recibos_ObtenerRecibo @id_Empleado=" & id_Empleado & ", @id_Sucursal=" & id_Sucursal & ", @Mes='" & Mes & "', @Anio='" & Anio & "'")
        Else
            dsRecibo = clsDatos.ConsultarBaseLocal("execute sp_Recibos_ObtenerRecibo @id_Empleado=" & id_Empleado & ", @id_Sucursal=" & id_Sucursal & ", @Mes='" & Mes & "', @Anio='" & Anio & "'")
        End If

        If dsRecibo.Tables(0).Rows.Count > 0 Then
            If dsRecibo.Tables(0).Rows(0).Item("Monto").ToString <> "" Then
                Return dsRecibo.Tables(0).Rows(0).Item("Monto").ToString
            Else
                Return 0
            End If
        Else
            Return 0
        End If
    End Function

    'Funcion para obtener el recibo de un empleado.
    Function ObtenerVacacionesMes(ByVal id_Empleado As Integer, ByVal id_Sucursal As Integer, ByVal Mes As String, ByVal Anio As Integer)
        Dim dsVacaciones As New DataSet

        If Funciones.HayInternet Then
            dsVacaciones = clsDatos.ConsultarBaseRemoto("execute sp_Recibos_ObtenerVacacionesMes @id_Empleado=" & id_Empleado & ", @id_Sucursal=" & id_Sucursal & ", @Mes='" & Mes & "', @Anio='" & Anio & "'")
        Else
            dsVacaciones = clsDatos.ConsultarBaseLocal("execute sp_Recibos_ObtenerVacacionesMes @id_Empleado=" & id_Empleado & ", @id_Sucursal=" & id_Sucursal & ", @Mes='" & Mes & "', @Anio='" & Anio & "'")
        End If

        If dsVacaciones.Tables(0).Rows.Count > 0 Then
            If dsVacaciones.Tables(0).Rows(0).Item("Vacaciones").ToString <> "" Then
                Return dsVacaciones.Tables(0).Rows(0).Item("Vacaciones").ToString
            Else
                Return 0
            End If
        Else
            Return 0
        End If
    End Function

    'Funcion para obtener el recibo de un empleado.
    Function ObtenerAguinaldoMes(ByVal id_Empleado As Integer, ByVal id_Sucursal As Integer, ByVal Mes As String, ByVal Anio As Integer)
        Dim dsAguinaldo As New DataSet

        If Funciones.HayInternet Then
            dsAguinaldo = clsDatos.ConsultarBaseRemoto("execute sp_Recibos_ObtenerAguinaldoMes @id_Empleado=" & id_Empleado & ", @id_Sucursal=" & id_Sucursal & ", @Mes='" & Mes & "', @Anio='" & Anio & "'")
        Else
            dsAguinaldo = clsDatos.ConsultarBaseLocal("execute sp_Recibos_ObtenerAguinaldoMes @id_Empleado=" & id_Empleado & ", @id_Sucursal=" & id_Sucursal & ", @Mes='" & Mes & "', @Anio='" & Anio & "'")
        End If

        If dsAguinaldo.Tables(0).Rows.Count > 0 Then
            If dsAguinaldo.Tables(0).Rows(0).Item("Aguinaldo").ToString <> "" Then
                Return dsAguinaldo.Tables(0).Rows(0).Item("Aguinaldo").ToString
            Else
                Return 0
            End If
        Else
            Return 0
        End If
    End Function

    'Funcion para obtener las vacaciones de un empleado.
    Function ObtenerVacaciones(ByVal id_Empleado As Integer, ByVal id_Sucursal As Integer, ByVal FechaDesde As String, ByVal FechaHasta As String)
        Dim ReciboSueldo As Double = 0
        Dim dsRecibo As New DataSet

        If Funciones.HayInternet Then
            dsRecibo = clsDatos.ConsultarBaseRemoto("execute sp_Recibos_ObtenerVacaciones @id_Empleado=" & id_Empleado & ", @id_Sucursal=" & id_Sucursal & ", @FDesde='" & FechaDesde & "', @FHasta='" & FechaHasta & "'")
        Else
            dsRecibo = clsDatos.ConsultarBaseLocal("execute sp_Recibos_ObtenerVacaciones @id_Empleado=" & id_Empleado & ", @id_Sucursal=" & id_Sucursal & ", @FDesde='" & FechaDesde & "', @FHasta='" & FechaHasta & "'")
        End If

        If dsRecibo.Tables(0).Rows.Count > 0 Then
            If dsRecibo.Tables(0).Rows(0).Item("Total").ToString <> "" Then
                Return dsRecibo.Tables(0).Rows(0).Item("Total").ToString
            Else
                Return 0
            End If
        Else
            Return 0
        End If
    End Function

    'Funcion para obtener los recibos de sueldo de un empleado.
    Function ObtenerRecibos(ByVal id_Empleado As Integer, ByVal id_Sucursal As Integer, ByVal FechaDesde As String, ByVal FechaHasta As String)
        Dim ReciboSueldo As Double = 0
        Dim dsRecibo As New DataSet

        If Funciones.HayInternet Then
            dsRecibo = clsDatos.ConsultarBaseRemoto("execute sp_Recibos_ObtenerRecibos @id_Empleado=" & id_Empleado & ", @id_Sucursal=" & id_Sucursal & ", @FDesde='" & FechaDesde & "', @FHasta='" & FechaHasta & "'")
        Else
            dsRecibo = clsDatos.ConsultarBaseLocal("execute sp_Recibos_ObtenerRecibos @id_Empleado=" & id_Empleado & ", @id_Sucursal=" & id_Sucursal & ", @FDesde='" & FechaDesde & "', @FHasta='" & FechaHasta & "'")
        End If

        If dsRecibo.Tables(0).Rows.Count > 0 Then
            If dsRecibo.Tables(0).Rows(0).Item("Total").ToString <> "" Then
                Return dsRecibo.Tables(0).Rows(0).Item("Total").ToString
            Else
                Return 0
            End If
        Else
            Return 0
        End If
    End Function

    'Funcion para obtener el aguinaldo de un empleado.
    Function ObtenerAguinaldo(ByVal id_Empleado As Integer, ByVal id_Sucursal As Integer, ByVal FechaDesde As String, ByVal FechaHasta As String)
        Dim ReciboSueldo As Double = 0
        Dim dsRecibo As New DataSet

        If Funciones.HayInternet Then
            dsRecibo = clsDatos.ConsultarBaseRemoto("execute sp_Recibos_ObtenerAguinaldo @id_Empleado=" & id_Empleado & ", @id_Sucursal=" & id_Sucursal & ", @FDesde='" & FechaDesde & "', @FHasta='" & FechaHasta & "'")
        Else
            dsRecibo = clsDatos.ConsultarBaseLocal("execute sp_Recibos_ObtenerAguinaldo @id_Empleado=" & id_Empleado & ", @id_Sucursal=" & id_Sucursal & ", @FDesde='" & FechaDesde & "', @FHasta='" & FechaHasta & "'")
        End If

        If dsRecibo.Tables(0).Rows.Count > 0 Then
            If dsRecibo.Tables(0).Rows(0).Item("Total").ToString <> "" Then
                Return dsRecibo.Tables(0).Rows(0).Item("Total").ToString
            Else
                Return 0
            End If
        Else
            Return 0
        End If
    End Function

    'Funcion que lista las comisiones de un empleado.
    Function ListarVacacionesEmpleado(ByVal id_Empleado As Integer, ByVal id_Sucursal As Integer, ByVal FDesde As String, ByVal FHasta As String)
        If Funciones.HayInternet Then
            Return clsDatos.ConsultarBaseRemoto("execute sp_Recibos_ListadoVacaciones @id_Empleado=" & id_Empleado & ", @id_Sucursal=" & id_Sucursal & ", @FDesde='" & FDesde & "', @FHasta='" & FHasta & "'")
        Else
            Return clsDatos.ConsultarBaseLocal("execute sp_Recibos_ListadoVacaciones @id_Empleado=" & id_Empleado & ", @id_Sucursal=" & id_Sucursal & ", @FDesde='" & FDesde & "', @FHasta='" & FHasta & "'")
        End If
    End Function

    'Funcion que lista las comisiones de un empleado.
    Function ListarAguinaldoEmpleado(ByVal id_Empleado As Integer, ByVal id_Sucursal As Integer, ByVal FDesde As String, ByVal FHasta As String)
        If Funciones.HayInternet Then
            Return clsDatos.ConsultarBaseRemoto("execute sp_Recibos_ListadoAguinaldo @id_Empleado=" & id_Empleado & ", @id_Sucursal=" & id_Sucursal & ", @FDesde='" & FDesde & "', @FHasta='" & FHasta & "'")
        Else
            Return clsDatos.ConsultarBaseLocal("execute sp_Recibos_ListadoAguinaldo @id_Empleado=" & id_Empleado & ", @id_Sucursal=" & id_Sucursal & ", @FDesde='" & FDesde & "', @FHasta='" & FHasta & "'")
        End If
    End Function
End Class
