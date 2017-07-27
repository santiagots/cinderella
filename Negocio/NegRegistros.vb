Imports System.Data.SqlClient
Imports System.Windows.Forms

Public Class NegRegistros
    Dim clsDatos As New Datos.Conexion
    Dim ClsFunciones As New Funciones


    'Funcion para listar todos los empleados por sucursal determinada.
    Function ListadoRegistrosSucursal(ByVal id_Sucursal As Integer) As DataSet
        Dim HayInternet As Boolean = Funciones.HayInternet
        If (HayInternet) Then
            Return clsDatos.ConsultarBaseRemoto("execute sp_Registros_ListadoSucursal @id_Sucursal=" & id_Sucursal)
        Else
            Return clsDatos.ConsultarBaseLocal("execute sp_Registros_ListadoSucursal @id_Sucursal=" & id_Sucursal)
        End If
    End Function

    'Funcion para listar todos los empleados por sucursal y fecha determinada.
    Function ListadoRegistrosFecha(ByVal id_Registro As Integer) As DataSet
        Dim HayInternet As Boolean = Funciones.HayInternet
        If (HayInternet) Then
            Return clsDatos.ConsultarBaseRemoto("execute sp_RegistrosFecha_Listado @id_Registro = " & id_Registro)
        Else
            Return clsDatos.ConsultarBaseLocal("execute sp_RegistrosFecha_Listado @id_Registro = " & id_Registro)
        End If
    End Function

    'Funcion que agrega un nuevo registro
    Function AgregarRegistro(ByVal Ereg As Entidades.Registros)
        'Declaro variables
        Dim id_Registro As Integer
        Dim NombreEmpleado As String = ""
        Dim HayInternet As Boolean = Funciones.HayInternet
        Dim respuesta As String
        Try

            'Conecto
            Dim cmd As New SqlCommand
            cmd.Connection = clsDatos.ConectarLocal()
            respuesta = AgregarRegistro(Ereg, cmd)

            'Consulto cual fue el ultimo id ingresado.
            id_Registro = UltimoRegistro(False)

            'inserto los empleados presentes para el registro
            InsertarRegistroEmpleados(Ereg.EmpleadosPresente, id_Registro, "sp_RegistrosEmpleados_Alta", False)

            'inserto los empleados ausentes para el registro
            InsertarRegistroEmpleados(Ereg.EmpleadosAusente, id_Registro, "sp_RegistrosEmpleados_Alta_Ausentes", False)

            'inserto los empleados tardios para el registro
            InsertarRegistroEmpleados(Ereg.EmpleadosTarde, id_Registro, "sp_RegistrosEmpleados_Alta_Tarde", False)

            clsDatos.DesconectarLocal()

            If (HayInternet) Then
                cmd = New SqlCommand
                cmd.Connection = clsDatos.ConectarRemoto()
                respuesta = AgregarRegistro(Ereg, cmd)

                'Consulto cual fue el ultimo id ingresado.
                id_Registro = UltimoRegistro(True)

                'inserto los empleados presentes para el registro
                InsertarRegistroEmpleados(Ereg.EmpleadosPresente, id_Registro, "sp_RegistrosEmpleados_Alta", True)

                'inserto los empleados ausentes para el registro
                InsertarRegistroEmpleados(Ereg.EmpleadosAusente, id_Registro, "sp_RegistrosEmpleados_Alta_Ausentes", True)

                'inserto los empleados tardios para el registro
                InsertarRegistroEmpleados(Ereg.EmpleadosTarde, id_Registro, "sp_RegistrosEmpleados_Alta_Tarde", True)

                clsDatos.DesconectarRemoto()
            End If

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
            .AddWithValue("@Fecha", Ereg.Fecha)
            .AddWithValue("@id_Sucursal", Ereg.id_Sucursal)
        End With
        respuesta.Direction = ParameterDirection.Output
        cmd.Parameters.Add(respuesta)
        cmd.ExecuteNonQuery()

        Return respuesta.Value
    End Function

    'Funcion para modificar un registro.
    Function ModificacionRegistro(ByVal ERegistro As Entidades.Registros) As String
        Dim HayInternet As Boolean = Funciones.HayInternet
        Dim respuesta As String

        Try
            'Conecto
            Dim cmd As New SqlCommand
            cmd.Connection = clsDatos.ConectarLocal()
            respuesta = ModificacionRegistro(ERegistro, cmd)

            'inserto los empleados presentes para el registro
            InsertarRegistroEmpleados(ERegistro.EmpleadosPresente, ERegistro.id_Registro, "sp_RegistrosEmpleados_Alta", False)

            'inserto los empleados tardios para el registro
            InsertarRegistroEmpleados(ERegistro.EmpleadosTarde, ERegistro.id_Registro, "sp_RegistrosEmpleados_Alta_Tarde", False)

            'inserto los empleados ausentes para el registro
            InsertarRegistroEmpleados(ERegistro.EmpleadosAusente, ERegistro.id_Registro, "sp_RegistrosEmpleados_Alta_Ausentes", False)
            clsDatos.DesconectarLocal()

            If (HayInternet) Then
                cmd = New SqlCommand
                cmd.Connection = clsDatos.ConectarRemoto()
                respuesta = ModificacionRegistro(ERegistro, cmd)

                'inserto los empleados presentes para el registro
                InsertarRegistroEmpleados(ERegistro.EmpleadosPresente, ERegistro.id_Registro, "sp_RegistrosEmpleados_Alta", True)

                'inserto los empleados tardios para el registro
                InsertarRegistroEmpleados(ERegistro.EmpleadosTarde, ERegistro.id_Registro, "sp_RegistrosEmpleados_Alta_Tarde", True)

                'inserto los empleados ausentes para el registro
                InsertarRegistroEmpleados(ERegistro.EmpleadosAusente, ERegistro.id_Registro, "sp_RegistrosEmpleados_Alta_Ausentes", True)
                clsDatos.DesconectarRemoto()
            End If

            Return respuesta
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
        End With
        respuesta.Direction = ParameterDirection.Output
        cmd.Parameters.Add(respuesta)
        cmd.ExecuteNonQuery()

        cmd.Parameters.Clear()
        cmd.CommandText = "sp_RegistrosEmpleados_Eliminar"
        With cmd.Parameters
            .AddWithValue("@id_Registro", ERegistro.id_Registro)
        End With
        Dim respuesta3 As New SqlParameter("@msg", SqlDbType.VarChar, 255)
        respuesta3.Direction = ParameterDirection.Output
        cmd.Parameters.Add(respuesta3)
        cmd.ExecuteNonQuery()

        Return respuesta.Value
    End Function

    Function InsertarRegistroEmpleados(ByVal CheckedListBoxEmpleados As CheckedListBox, ByVal id_Registro As Integer, ByVal Sp As String, BaseRemota As Boolean)
        'inserto los empleados presentes para el registro
        For Each iten In CheckedListBoxEmpleados.CheckedItems()

            'verifico que el empleado este marcado para guardarlo en la base
            If (CheckedListBoxEmpleados.GetItemCheckState(CheckedListBoxEmpleados.Items.IndexOf(iten)) <> Windows.Forms.CheckState.Checked) Then
                Continue For
            End If

            'conecto la bdd
            Dim cmd2 As New SqlCommand
            'Conecto
            If (BaseRemota) Then
                cmd2.Connection = clsDatos.ConectarRemoto()
            Else
                cmd2.Connection = clsDatos.ConectarLocal()
            End If
            Dim id_Empleado As Integer = DirectCast(iten.Row, System.Data.DataRow).ItemArray(0)
            Dim NombreEmpleado As String = DirectCast(iten.Row, System.Data.DataRow).ItemArray(1)
            cmd2.CommandType = CommandType.StoredProcedure
            cmd2.CommandText = Sp
            With cmd2.Parameters
                .AddWithValue("@id_Registro", id_Registro)
                .AddWithValue("@id_Empleado", id_Empleado)
                .AddWithValue("@NombreEmpleado", NombreEmpleado)
            End With
            Dim respuesta2 As New SqlParameter("@msg", SqlDbType.VarChar, 255)
            respuesta2.Direction = ParameterDirection.Output
            cmd2.Parameters.Add(respuesta2)
            cmd2.ExecuteNonQuery()

            'Desconecto
            If (BaseRemota) Then
                clsDatos.DesconectarRemoto()
            Else
                clsDatos.DesconectarLocal()
            End If
        Next
        Return Nothing
    End Function



    'Funcion que me trae el id del ultimo registro.
    Function UltimoRegistro(BaseRemota As Boolean) As Integer

        Dim ds As DataSet
        If (BaseRemota) Then
            ds = clsDatos.ConsultarBaseRemoto("Select IDENT_CURRENT('EMPLEADOS_REGISTROS') as id_Registro")
        Else
            ds = clsDatos.ConsultarBaseLocal("Select IDENT_CURRENT('EMPLEADOS_REGISTROS')  as id_Registro")
        End If

        If ds.Tables(0).Rows.Count = 1 And CInt(ds.Tables(0).Rows(0).Item("id_Registro")) > 0 Then
            Return ds.Tables(0).Rows(0).Item("id_Registro").ToString
        Else
            Return 1
        End If
    End Function

    'Funcion que me indica si x día es feriado o no.
    Function EsFeriado(ByVal Fecha As String)
        Dim HayInternet As Boolean = Funciones.HayInternet

        Dim EsFe As Boolean = False
        Dim dsFeriado As New DataSet

        If HayInternet Then
            dsFeriado = clsDatos.ConsultarBaseRemoto("execute sp_Registros_EsFeriado @Fecha='" & Fecha & "'")
        Else
            dsFeriado = clsDatos.ConsultarBaseLocal("execute sp_Registros_EsFeriado @Fecha='" & Fecha & "'")
        End If

        If dsFeriado.Tables(0).Rows(0).Item("Tot").ToString <> "" And dsFeriado.Tables(0).Rows(0).Item("Tot").ToString <> "0" Then
            EsFe = True
        Else
            EsFe = False
        End If

        Return EsFe
    End Function

    'Funcion que me indica si un empleado trabajo en x sucursal en x dia.
    Function AsistioEmpleado(ByVal id_Empleado As Integer, ByVal id_Sucursal As Integer, ByVal Fecha As String)
        Dim HayInternet As Boolean = Funciones.HayInternet

        Dim Asistio As Boolean = False
        Dim dsAsistio As New DataSet

        If HayInternet Then
            dsAsistio = clsDatos.ConsultarBaseRemoto("execute sp_Registros_AsistioEmpleado @Fecha='" & Fecha & "', @id_Empleado='" & id_Empleado & "', @id_Sucursal='" & id_Sucursal & "'")
        Else
            dsAsistio = clsDatos.ConsultarBaseLocal("execute sp_Registros_AsistioEmpleado @Fecha='" & Fecha & "', @id_Empleado='" & id_Empleado & "', @id_Sucursal='" & id_Sucursal & "'")
        End If

        If dsAsistio.Tables(0).Rows(0).Item("Tot").ToString <> "" And dsAsistio.Tables(0).Rows(0).Item("Tot").ToString <> "0" Then
            Asistio = True
        Else
            Asistio = False
        End If

        Return Asistio
    End Function

    'Funcion para eliminar un registro.
    Function EliminarRegistro(ByVal id_Registro As Integer) As String

        Dim HayInternet As Boolean = Funciones.HayInternet
        Dim cmd As New SqlCommand
        Dim respuesta As String

        Try
            cmd.Connection = clsDatos.ConectarLocal()
            respuesta = EliminarRegistro(id_Registro, cmd)
            clsDatos.DesconectarLocal()

            If (HayInternet) Then
                cmd = New SqlCommand
                cmd.Connection = clsDatos.ConectarRemoto()
                respuesta = EliminarRegistro(id_Registro, cmd)
                clsDatos.DesconectarRemoto()
            End If

        Catch ex As Exception
            Return ex.Message
        End Try

        Return respuesta
    End Function

    Private Shared Function EliminarRegistro(id_Registro As Integer, ByRef cmd As SqlCommand) As String
        Dim respuesta As New SqlParameter("@msg", SqlDbType.VarChar, 255)

        cmd.CommandType = CommandType.StoredProcedure
        cmd.CommandText = "sp_Registros_Eliminar"
        With cmd.Parameters
            .AddWithValue("@id_Registro", id_Registro)
        End With
        respuesta.Direction = ParameterDirection.Output
        cmd.Parameters.Add(respuesta)
        cmd.ExecuteNonQuery()

        Return respuesta.Value
    End Function

    'Funcion para consultar un registro.
    Public Function TraerRegistro(ByVal id_Registro As Integer)
        Dim HayInternet As Boolean = Funciones.HayInternet

        Dim dsRegistro As New DataSet
        Dim entRegistro As New Entidades.Registros

        If (HayInternet) Then
            dsRegistro = clsDatos.ConsultarBaseRemoto("execute sp_Registros_Detalle @id_Registro=" & id_Registro)
        Else
            dsRegistro = clsDatos.ConsultarBaseLocal("execute sp_Registros_Detalle @id_Registro=" & id_Registro)
        End If

        If dsRegistro.Tables(0).Rows.Count <> 0 Then
            entRegistro.id_Registro = dsRegistro.Tables(0).Rows(0).Item("id_Registro").ToString
            entRegistro.id_Sucursal = dsRegistro.Tables(0).Rows(0).Item("id_Sucursal").ToString
            entRegistro.Fecha = dsRegistro.Tables(0).Rows(0).Item("Fecha").ToString
        End If
        Return entRegistro
    End Function

    'Funcion para obtener los dias trabajados de un empleado
    Function ObtenerDias(ByVal id_Empleado As Integer, ByVal id_Sucursal As Integer, ByVal FDesde As String, ByVal FHasta As String)
        Dim HayInternet As Boolean = Funciones.HayInternet

        Dim dsDias As New DataSet
        If HayInternet Then
            dsDias = clsDatos.ConsultarBaseRemoto("execute sp_Registros_Obtener @id_Empleado=" & id_Empleado & ", @id_Sucursal=" & id_Sucursal & ", @FDesde='" & FDesde & "', @FHasta='" & FHasta & "'")
        Else
            dsDias = clsDatos.ConsultarBaseLocal("execute sp_Registros_Obtener @id_Empleado=" & id_Empleado & ", @id_Sucursal=" & id_Sucursal & ", @FDesde='" & FDesde & "', @FHasta='" & FHasta & "'")
        End If

        If dsDias.Tables(0).Rows.Count = 1 And dsDias.Tables(0).Rows(0).Item("Dias").ToString <> "" Then
            Return dsDias.Tables(0).Rows(0).Item("Dias").ToString
        Else
            Return 0
        End If
    End Function

    'Funcion para obtener los dias FERIADOS trabajados de un empleado
    Function ObtenerDiasFeriados(ByVal id_Empleado As Integer, ByVal id_Sucursal As Integer, ByVal FDesde As String, ByVal FHasta As String)
            Dim HayInternet As Boolean = Funciones.HayInternet
        Dim dsDias As New DataSet
        If HayInternet Then
            dsDias = clsDatos.ConsultarBaseRemoto("execute sp_Registros_ObtenerFeriados @id_Empleado=" & id_Empleado & ", @id_Sucursal=" & id_Sucursal & ", @FDesde='" & FDesde & "', @FHasta='" & FHasta & "'")
        Else
            dsDias = clsDatos.ConsultarBaseLocal("execute sp_Registros_ObtenerFeriados @id_Empleado=" & id_Empleado & ", @id_Sucursal=" & id_Sucursal & ", @FDesde='" & FDesde & "', @FHasta='" & FHasta & "'")
        End If

        If dsDias.Tables(0).Rows.Count = 1 And dsDias.Tables(0).Rows(0).Item("Dias").ToString <> "" Then
            Return dsDias.Tables(0).Rows(0).Item("Dias").ToString
        Else
            Return 0
        End If
    End Function

    'Funcion para obtener los dias trabajados de un empleado
    Function ListarDiasRegularesEmpleado(ByVal id_Empleado As Integer, ByVal id_Sucursal As Integer, ByVal FDesde As String, ByVal FHasta As String)
        Dim dsDias As New DataSet
        Dim HayInternet As Boolean = Funciones.HayInternet


        If HayInternet Then
            dsDias = clsDatos.ConsultarBaseRemoto("execute sp_Registros_ObtenerDiasRegulares @id_Empleado=" & id_Empleado & ", @id_Sucursal=" & id_Sucursal & ", @FDesde='" & FDesde & "', @FHasta='" & FHasta & "'")
        Else
            dsDias = clsDatos.ConsultarBaseLocal("execute sp_Registros_ObtenerDiasRegulares @id_Empleado=" & id_Empleado & ", @id_Sucursal=" & id_Sucursal & ", @FDesde='" & FDesde & "', @FHasta='" & FHasta & "'")
        End If

        Return dsDias

    End Function

    'Funcion para obtener los dias trabajados FERIADOS de un empleado
    Function ListarDiasFeriadosEmpleado(ByVal id_Empleado As Integer, ByVal id_Sucursal As Integer, ByVal FDesde As String, ByVal FHasta As String)
        Dim dsDias As New DataSet
        Dim HayInternet As Boolean = Funciones.HayInternet

        If HayInternet Then
            dsDias = clsDatos.ConsultarBaseRemoto("execute sp_Registros_ObtenerDiasFeriados @id_Empleado=" & id_Empleado & ", @id_Sucursal=" & id_Sucursal & ", @FDesde='" & FDesde & "', @FHasta='" & FHasta & "'")
        Else
            dsDias = clsDatos.ConsultarBaseLocal("execute sp_Registros_ObtenerDiasFeriados @id_Empleado=" & id_Empleado & ", @id_Sucursal=" & id_Sucursal & ", @FDesde='" & FDesde & "', @FHasta='" & FHasta & "'")
        End If

        Return dsDias

    End Function

    'Funcion para obtener los dias Ausentes de un empleado
    Function ObtenerDiasAusentes(id_Empleado As Integer, id_Sucursal As String, FDesde As String, FHasta As String) As Integer
        Dim dsDias As New DataSet
        Dim HayInternet As Boolean = Funciones.HayInternet

        If HayInternet Then
            dsDias = clsDatos.ConsultarBaseRemoto("execute sp_Registros_ObtenerAusentes @id_Empleado=" & id_Empleado & ", @id_Sucursal=" & id_Sucursal & ", @FDesde='" & FDesde & "', @FHasta='" & FHasta & "'")
        Else
            dsDias = clsDatos.ConsultarBaseLocal("execute sp_Registros_ObtenerAusentes @id_Empleado=" & id_Empleado & ", @id_Sucursal=" & id_Sucursal & ", @FDesde='" & FDesde & "', @FHasta='" & FHasta & "'")
        End If

        If dsDias.Tables(0).Rows.Count = 1 And dsDias.Tables(0).Rows(0).Item("Dias").ToString <> "" Then
            Return dsDias.Tables(0).Rows(0).Item("Dias").ToString
        Else
            Return 0
        End If
    End Function

End Class
