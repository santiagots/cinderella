Imports System.Data.SqlClient
Imports System.Windows.Forms

Public Class NegRegistros
    Dim clsDatos As New Datos.Conexion
    Dim ClsFunciones As New Funciones


    'Funcion para listar todos los empleados por sucursal determinada.
    Function ListadoRegistrosSucursal(ByVal id_Sucursal As Integer) As DataSet
        Return clsDatos.ConsultarBaseLocal("execute sp_Registros_ListadoSucursal @id_Sucursal=" & id_Sucursal)
    End Function

    'Funcion para listar todos los empleados por sucursal y fecha determinada.
    Function ListadoRegistrosFecha(ByVal id_Registro As Int64) As DataSet
        Return clsDatos.ConsultarBaseLocal("execute sp_RegistrosFecha_Listado @id_Registro = " & id_Registro)
    End Function

    'Funcion que agrega un nuevo registro
    Function AgregarRegistro(ByVal Ereg As Entidades.Registros)
        'Declaro variables
        Dim NombreEmpleado As String = ""
        Dim respuesta As String
        Try

            Ereg.id_Registro = clsDatos.ObtenerCalveUnica(Ereg.id_Sucursal)
            Ereg.FechaEdicion = DateTime.Now

            'Conecto
            Dim cmd As New SqlCommand
            cmd.Connection = clsDatos.ConectarLocal()
            respuesta = AgregarRegistro(Ereg, cmd)

            'inserto los empleados presentes para el registro
            InsertarRegistroEmpleados(Ereg.EmpleadosPresente, Ereg.id_Registro, Ereg.id_Sucursal, Ereg.FechaEdicion, "sp_RegistrosEmpleados_Alta")

            'inserto los empleados ausentes para el registro
            InsertarRegistroEmpleados(Ereg.EmpleadosAusente, Ereg.id_Registro, Ereg.id_Sucursal, Ereg.FechaEdicion, "sp_RegistrosEmpleados_Alta_Ausentes")

            'inserto los empleados tardios para el registro
            InsertarRegistroEmpleados(Ereg.EmpleadosTarde, Ereg.id_Registro, Ereg.id_Sucursal, Ereg.FechaEdicion, "sp_RegistrosEmpleados_Alta_Tarde")

            clsDatos.DesconectarLocal()

            Return respuesta
        Catch ex As Exception
            Return ex.Message
        End Try

    End Function

    Private Function AgregarRegistro(Ereg As Entidades.Registros, ByRef cmd As SqlCommand)
        Dim respuesta As SqlParameter = New SqlParameter("@msg", SqlDbType.VarChar, 255)

        cmd.CommandType = CommandType.StoredProcedure
        cmd.CommandText = "sp_Registros_Alta"
        With cmd.Parameters
            .AddWithValue("@id_Registro", Ereg.id_Registro)
            .AddWithValue("@id_Sucursal", Ereg.id_Sucursal)
            .AddWithValue("@Fecha", Ereg.Fecha)
            .AddWithValue("@FechaEdicion", Ereg.FechaEdicion)
        End With
        respuesta.Direction = ParameterDirection.Output
        cmd.Parameters.Add(respuesta)
        cmd.ExecuteNonQuery()

        Return respuesta.Value
    End Function

    'Funcion para modificar un registro.
    Function ModificacionRegistro(ByVal ERegistro As Entidades.Registros) As String
        Dim respuesta As String

        Dim RegistroEliminar = ERegistro.id_Registro

        ERegistro.FechaEdicion = DateTime.Now
        ERegistro.id_Registro = clsDatos.ObtenerCalveUnica(ERegistro.id_Sucursal)

        Try
            'Conecto
            Dim cmd As New SqlCommand
            cmd.Connection = clsDatos.ConectarLocal()
            respuesta = EliminarRegistro(RegistroEliminar, ERegistro.FechaEdicion, cmd)

            cmd = New SqlCommand
            cmd.Connection = clsDatos.ConectarLocal()

            respuesta = AgregarRegistro(ERegistro, cmd)

            'inserto los empleados presentes para el registro
            InsertarRegistroEmpleados(ERegistro.EmpleadosPresente, ERegistro.id_Registro, ERegistro.id_Sucursal, ERegistro.FechaEdicion, "sp_RegistrosEmpleados_Alta")

            'inserto los empleados tardios para el registro
            InsertarRegistroEmpleados(ERegistro.EmpleadosTarde, ERegistro.id_Registro, ERegistro.id_Sucursal, ERegistro.FechaEdicion, "sp_RegistrosEmpleados_Alta_Tarde")

            'inserto los empleados ausentes para el registro
            InsertarRegistroEmpleados(ERegistro.EmpleadosAusente, ERegistro.id_Registro, ERegistro.id_Sucursal, ERegistro.FechaEdicion, "sp_RegistrosEmpleados_Alta_Ausentes")
            clsDatos.DesconectarLocal()

            Return "El Registro se ha modificado correctamente."
        Catch ex As Exception
            Return ex.Message
        End Try
    End Function

    Private Function ModificacionRegistro(ERegistro As Entidades.Registros, ByRef cmd As SqlCommand)
        Dim respuesta As SqlParameter = New SqlParameter("@msg", SqlDbType.VarChar, 255)

        cmd.CommandType = CommandType.StoredProcedure
        cmd.CommandText = "sp_Registros_Modificacion"
        With cmd.Parameters
            .AddWithValue("@id_Registro", ERegistro.id_Registro)
            .AddWithValue("@id_Sucursal", ERegistro.id_Sucursal)
            .AddWithValue("@Fecha", ERegistro.Fecha)
            .AddWithValue("@FechaEdicion", ERegistro.FechaEdicion)
        End With
        respuesta.Direction = ParameterDirection.Output
        cmd.Parameters.Add(respuesta)
        cmd.ExecuteNonQuery()

        cmd.Parameters.Clear()
        cmd.CommandText = "sp_RegistrosEmpleados_Eliminar"
        With cmd.Parameters
            .AddWithValue("@id_Registro", ERegistro.id_Registro)
            .AddWithValue("@fechaEdicion", ERegistro.FechaEdicion)
        End With
        Dim respuesta3 As New SqlParameter("@msg", SqlDbType.VarChar, 255)
        respuesta3.Direction = ParameterDirection.Output
        cmd.Parameters.Add(respuesta3)
        cmd.ExecuteNonQuery()

        Return respuesta.Value
    End Function

    Function InsertarRegistroEmpleados(CheckedListBoxEmpleados As CheckedListBox, id_Registro As Int64, id_Sucursal As Integer, FechaEdicion As DateTime, Sp As String)
        'inserto los empleados presentes para el registro
        For Each iten In CheckedListBoxEmpleados.CheckedItems()

            'verifico que el empleado este marcado para guardarlo en la base
            If (CheckedListBoxEmpleados.GetItemCheckState(CheckedListBoxEmpleados.Items.IndexOf(iten)) <> Windows.Forms.CheckState.Checked) Then
                Continue For
            End If

            'conecto la bdd
            Dim cmd As New SqlCommand
            'Conecto
            cmd.Connection = clsDatos.ConectarLocal()

            Dim id_Empleado As Integer = DirectCast(iten.Row, System.Data.DataRow).ItemArray(0)
            Dim NombreEmpleado As String = DirectCast(iten.Row, System.Data.DataRow).ItemArray(1)
            cmd.CommandType = CommandType.StoredProcedure
            cmd.CommandText = Sp
            With cmd.Parameters
                .AddWithValue("@id_Rel", clsDatos.ObtenerCalveUnica(id_Sucursal))
                .AddWithValue("@id_Registro", id_Registro)
                .AddWithValue("@id_Empleado", id_Empleado)
                .AddWithValue("@NombreEmpleado", NombreEmpleado)
                .AddWithValue("@FechaEdicion", FechaEdicion)
            End With
            Dim respuesta2 As New SqlParameter("@msg", SqlDbType.VarChar, 255)
            respuesta2.Direction = ParameterDirection.Output
            cmd.Parameters.Add(respuesta2)
            cmd.ExecuteNonQuery()

            clsDatos.DesconectarLocal()
        Next
        Return Nothing
    End Function


    'Funcion que me indica si x día es feriado o no.
    Function EsFeriado(ByVal Fecha As String)

        Dim EsFe As Boolean = False
        Dim dsFeriado As New DataSet

        dsFeriado = clsDatos.ConsultarBaseLocal("execute sp_Registros_EsFeriado @Fecha='" & Fecha & "'")

        If dsFeriado.Tables(0).Rows(0).Item("Tot").ToString <> "" And dsFeriado.Tables(0).Rows(0).Item("Tot").ToString <> "0" Then
            EsFe = True
        Else
            EsFe = False
        End If

        Return EsFe
    End Function

    'Funcion que me indica si un empleado trabajo en x sucursal en x dia.
    Function AsistioEmpleado(ByVal id_Empleado As Integer, ByVal id_Sucursal As Integer, ByVal Fecha As String)

        Dim Asistio As Boolean = False
        Dim dsAsistio As New DataSet

        dsAsistio = clsDatos.ConsultarBaseLocal("execute sp_Registros_AsistioEmpleado @Fecha='" & Fecha & "', @id_Empleado='" & id_Empleado & "', @id_Sucursal='" & id_Sucursal & "'")

        If dsAsistio.Tables(0).Rows(0).Item("Tot").ToString <> "" And dsAsistio.Tables(0).Rows(0).Item("Tot").ToString <> "0" Then
            Asistio = True
        Else
            Asistio = False
        End If

        Return Asistio
    End Function

    'Funcion para eliminar un registro.
    Function EliminarRegistro(ByVal id_Registro As Int64) As String
        Dim cmd As New SqlCommand
        Dim respuesta As String

        Dim FechaEdicion As DateTime = DateTime.Now
        Try
            cmd.Connection = clsDatos.ConectarLocal()
            respuesta = EliminarRegistro(id_Registro, FechaEdicion, cmd)
            clsDatos.DesconectarLocal()
        Catch ex As Exception
            Return ex.Message
        End Try

        Return respuesta
    End Function

    Private Shared Function EliminarRegistro(id_Registro As Int64, FechaEdicion As DateTime, ByRef cmd As SqlCommand) As String
        Dim respuesta As New SqlParameter("@msg", SqlDbType.VarChar, 255)

        cmd.CommandType = CommandType.StoredProcedure
        cmd.CommandText = "sp_Registros_Eliminar"
        With cmd.Parameters
            .AddWithValue("@id_Registro", id_Registro)
            .AddWithValue("@FechaEdicion", FechaEdicion)
        End With
        respuesta.Direction = ParameterDirection.Output
        cmd.Parameters.Add(respuesta)
        cmd.ExecuteNonQuery()

        Return respuesta.Value
    End Function

    'Funcion para consultar un registro.
    Public Function TraerRegistro(ByVal id_Registro As Int64)
        Dim dsRegistro As New DataSet
        Dim entRegistro As New Entidades.Registros

        dsRegistro = clsDatos.ConsultarBaseLocal("execute sp_Registros_Detalle @id_Registro=" & id_Registro)

        If dsRegistro.Tables(0).Rows.Count <> 0 Then
            entRegistro.id_Registro = dsRegistro.Tables(0).Rows(0).Item("id_Registro").ToString
            entRegistro.id_Sucursal = dsRegistro.Tables(0).Rows(0).Item("id_Sucursal").ToString
            entRegistro.Fecha = dsRegistro.Tables(0).Rows(0).Item("Fecha").ToString
        End If
        Return entRegistro
    End Function

    'Funcion para obtener los dias trabajados de un empleado
    Function ObtenerDias(ByVal id_Empleado As Integer, ByVal id_Sucursal As Integer, ByVal FDesde As String, ByVal FHasta As String)

        Dim dsDias As DataSet = clsDatos.ConsultarBaseLocal("execute sp_Registros_Obtener @id_Empleado=" & id_Empleado & ", @id_Sucursal=" & id_Sucursal & ", @FDesde='" & FDesde & "', @FHasta='" & FHasta & "'")

        If dsDias.Tables(0).Rows.Count = 1 And dsDias.Tables(0).Rows(0).Item("Dias").ToString <> "" Then
            Return dsDias.Tables(0).Rows(0).Item("Dias").ToString
        Else
            Return 0
        End If
    End Function

    'Funcion para obtener los dias FERIADOS trabajados de un empleado
    Function ObtenerDiasFeriados(ByVal id_Empleado As Integer, ByVal id_Sucursal As Integer, ByVal FDesde As String, ByVal FHasta As String)
        Dim dsDias As DataSet = clsDatos.ConsultarBaseLocal("execute sp_Registros_ObtenerFeriados @id_Empleado=" & id_Empleado & ", @id_Sucursal=" & id_Sucursal & ", @FDesde='" & FDesde & "', @FHasta='" & FHasta & "'")

        If dsDias.Tables(0).Rows.Count = 1 And dsDias.Tables(0).Rows(0).Item("Dias").ToString <> "" Then
            Return dsDias.Tables(0).Rows(0).Item("Dias").ToString
        Else
            Return 0
        End If
    End Function

    'Funcion para obtener los dias trabajados de un empleado
    Function ListarDiasRegularesEmpleado(ByVal id_Empleado As Integer, ByVal id_Sucursal As Integer, ByVal FDesde As String, ByVal FHasta As String)
        Return clsDatos.ConsultarBaseLocal("execute sp_Registros_ObtenerDiasRegulares @id_Empleado=" & id_Empleado & ", @id_Sucursal=" & id_Sucursal & ", @FDesde='" & FDesde & "', @FHasta='" & FHasta & "'")
    End Function

    'Funcion para obtener los dias trabajados FERIADOS de un empleado
    Function ListarDiasFeriadosEmpleado(ByVal id_Empleado As Integer, ByVal id_Sucursal As Integer, ByVal FDesde As String, ByVal FHasta As String)
        Return clsDatos.ConsultarBaseLocal("execute sp_Registros_ObtenerDiasFeriados @id_Empleado=" & id_Empleado & ", @id_Sucursal=" & id_Sucursal & ", @FDesde='" & FDesde & "', @FHasta='" & FHasta & "'")
    End Function

    'Funcion para obtener los dias Ausentes de un empleado
    Function ObtenerDiasAusentes(id_Empleado As Integer, id_Sucursal As String, FDesde As String, FHasta As String) As Integer
        Dim dsDias As DataSet = clsDatos.ConsultarBaseLocal("execute sp_Registros_ObtenerAusentes @id_Empleado=" & id_Empleado & ", @id_Sucursal=" & id_Sucursal & ", @FDesde='" & FDesde & "', @FHasta='" & FHasta & "'")

        If dsDias.Tables(0).Rows.Count = 1 And dsDias.Tables(0).Rows(0).Item("Dias").ToString <> "" Then
            Return dsDias.Tables(0).Rows(0).Item("Dias").ToString
        Else
            Return 0
        End If
    End Function

End Class
