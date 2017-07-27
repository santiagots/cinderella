Imports Entidades
Imports System.Data.SqlClient

Public Class NegEmpleados
    Dim objEmpleado As Entidades.Empleados
    Dim clsDatos As New Datos.Conexion
    Dim ClsFunciones As New Funciones

    'Funcion para consultar un empleado.
    Public Function TraerEmpleadoPorIdEmpleado(ByVal id_Empleado As Integer)
        Dim dsEmpleado As New DataSet
        Dim entEmpleado As New Entidades.Empleados

        If (Funciones.HayInternet) Then
            dsEmpleado = clsDatos.ConsultarBaseRemoto("execute sp_Empleados_Detalle @id_Empleado=" & id_Empleado)
        Else
            dsEmpleado = clsDatos.ConsultarBaseLocal("execute sp_Empleados_Detalle @id_Empleado=" & id_Empleado)
        End If

        If dsEmpleado.Tables(0).Rows.Count <> 0 Then
            entEmpleado = ObtenerEmpleadoFromDataRow(dsEmpleado)
        End If
        Return entEmpleado
    End Function

    Public Function TraerEmpleadoPorIdUsuario(ByVal id_Usuario As Integer)
        Dim dsEmpleado As New DataSet
        Dim entEmpleado As New Entidades.Empleados

        If (Funciones.HayInternet) Then
            dsEmpleado = clsDatos.ConsultarBaseRemoto("execute sp_Empleados_Detalle_Por_Usuario @id_Usuario=" & id_Usuario)
        Else
            dsEmpleado = clsDatos.ConsultarBaseLocal("execute sp_Empleados_Detalle_Por_Usuario @id_Usuario=" & id_Usuario)
        End If

        If dsEmpleado.Tables(0).Rows.Count <> 0 Then
            entEmpleado = ObtenerEmpleadoFromDataRow(dsEmpleado)
        End If
        Return entEmpleado
    End Function

    'Funcion para traer las sucursales de un empleado
    Public Function TraerSucursalesEmpleado(ByVal id_Empleado As Integer) As String
        Dim dsEmpleado As New DataSet
        Dim sucur_string As String = ""

        If (Funciones.HayInternet) Then
            dsEmpleado = clsDatos.ConsultarBaseRemoto("execute sp_Empleados_Sucursales @id_Empleado=" & id_Empleado)
        Else
            dsEmpleado = clsDatos.ConsultarBaseLocal("execute sp_Empleados_Sucursales @id_Empleado=" & id_Empleado)
        End If

        If dsEmpleado.Tables(0).Rows.Count > 0 Then
            For Each emp In dsEmpleado.Tables(0).Rows
                sucur_string += emp.Item("Nombre").ToString + " / "
            Next
            sucur_string = sucur_string.Substring(0, sucur_string.Length - 3)
        Else
            sucur_string = "Ninguna"
        End If
        Return sucur_string
    End Function

    'Funcion para insertar un empleado.
    Function AltaEmpleado(ByVal eempleados As Entidades.Empleados) As String
        'Declaro variables
        Dim cmd As New SqlCommand
        Dim msg As String = ""

        Try
            cmd.Connection = clsDatos.ConectarRemoto()
            cmd.CommandType = CommandType.StoredProcedure
            cmd.CommandText = "sp_Empleados_Alta"
            With cmd.Parameters
                .AddWithValue("@id_Sucursal", 2)
                .AddWithValue("@id_TipoEmpleado", eempleados.id_TipoEmpleado)
                .AddWithValue("@Nombre", eempleados.Nombre)
                .AddWithValue("@Apellido", eempleados.Apellido)
                .AddWithValue("@Direccion", eempleados.Direccion)
                .AddWithValue("@SueldoNormal", eempleados.SueldoNormal)
                .AddWithValue("@SueldoFeriado", eempleados.SueldoFeriado)
                .AddWithValue("@SueldoPresentismo", eempleados.SueldoPresentismo)
                .AddWithValue("@id_Provincia", eempleados.id_Provincia)
                .AddWithValue("@id_Departamento", eempleados.id_Distrito)
                .AddWithValue("@id_Localidad", eempleados.id_Localidad)
                .AddWithValue("@CodigoPostal", eempleados.Codigo_Postal)
                .AddWithValue("@Telefono", eempleados.Telefono)
                .AddWithValue("@Telefono2", eempleados.Telefono2)
                .AddWithValue("@Mail", eempleados.Mail)
                .AddWithValue("@Cuil", eempleados.Cuil)
                .AddWithValue("@FechaNacimiento", eempleados.FechaNacimiento)
                .AddWithValue("@FechaIngreso", eempleados.FechaIngreso)
                .AddWithValue("@Observaciones", eempleados.Observaciones)
                .AddWithValue("@Habilitado", eempleados.Habilitado)
                .AddWithValue("@id_Usuario", eempleados.id_Usuario)
            End With

            Dim respuesta As New SqlParameter("@msg", SqlDbType.VarChar, 255)
            respuesta.Direction = ParameterDirection.Output
            cmd.Parameters.Add(respuesta)
            cmd.ExecuteNonQuery()
            'desconecto la bdd
            clsDatos.DesconectarRemoto()

            'Consulto cual fue el ultimo id ingresado.
            Dim id_Empleado As Integer = 0
            id_Empleado = UltimoEmpleado()

            'inserto las sucursales para el empleado.
            If eempleados.Sucursales.CheckedItems.Count > 0 Then
                For Each iten In eempleados.Sucursales.CheckedItems
                    'conecto la bdd
                    Dim cmd2 As New SqlCommand
                    cmd2.Connection = clsDatos.ConectarRemoto()
                    Dim id_Sucursal As Integer = 0
                    id_Sucursal = DirectCast(iten.Row, System.Data.DataRow).ItemArray(0)
                    cmd2.CommandType = CommandType.StoredProcedure
                    cmd2.CommandText = "sp_EmpleadosSucursales_Alta"
                    With cmd2.Parameters
                        .AddWithValue("@id_Empleado", id_Empleado)
                        .AddWithValue("@id_Sucursal", id_Sucursal)
                    End With
                    Dim respuesta2 As New SqlParameter("@msg", SqlDbType.VarChar, 255)
                    respuesta2.Direction = ParameterDirection.Output
                    cmd2.Parameters.Add(respuesta2)
                    cmd2.ExecuteNonQuery()
                    'desconecto la bdd
                    clsDatos.DesconectarRemoto()
                Next
            Else 'Sino hay sucursales, inserto la del sistema.
                'conecto la bdd
                Dim cmd2 As New SqlCommand
                cmd2.Connection = clsDatos.ConectarRemoto()
                Dim id_Sucursal As Integer = 0
                id_Sucursal = eempleados.id_Sucursal
                cmd2.CommandType = CommandType.StoredProcedure
                cmd2.CommandText = "sp_EmpleadosSucursales_Alta"
                With cmd2.Parameters
                    .AddWithValue("@id_Empleado", id_Empleado)
                    .AddWithValue("@id_Sucursal", id_Sucursal)
                End With
                Dim respuesta2 As New SqlParameter("@msg", SqlDbType.VarChar, 255)
                respuesta2.Direction = ParameterDirection.Output
                cmd2.Parameters.Add(respuesta2)
                cmd2.ExecuteNonQuery()
                'desconecto la bdd
                clsDatos.DesconectarRemoto()
            End If

            'muestro el mensaje
            Return respuesta.Value
        Catch ex As Exception
            Return ex.Message
        End Try
    End Function

    'Funcion que me trae el id del ultimo empleado.
    Function UltimoEmpleado() As Integer
        Dim ds As DataSet
        If (Funciones.HayInternet) Then
            ds = clsDatos.ConsultarBaseRemoto("Select IDENT_CURRENT('EMPLEADOS') as id_Empleado")
        Else
            ds = clsDatos.ConsultarBaseLocal("Select IDENT_CURRENT('EMPLEADOS')  as id_Empleado")
        End If

        If ds.Tables(0).Rows.Count = 1 And CInt(ds.Tables(0).Rows(0).Item("id_Empleado")) > 0 Then
            Return ds.Tables(0).Rows(0).Item("id_Empleado").ToString
        Else
            Return 1
        End If
    End Function

    'Funcion para modificar un empleado.
    Function ModificacionEmpleado(ByVal eempleados As Entidades.Empleados) As String
        Dim cmd As New SqlCommand
        Try
            cmd.Connection = clsDatos.ConectarRemoto()
            cmd.CommandType = CommandType.StoredProcedure
            cmd.CommandText = "sp_Empleados_Modificacion"
            With cmd.Parameters
                .AddWithValue("@id_Empleado", eempleados.id_Empleado)
                .AddWithValue("@id_Sucursal", eempleados.id_Sucursal)
                .AddWithValue("@id_TipoEmpleado", eempleados.id_TipoEmpleado)
                .AddWithValue("@Nombre", eempleados.Nombre)
                .AddWithValue("@Apellido", eempleados.Apellido)
                .AddWithValue("@Direccion", eempleados.Direccion)
                .AddWithValue("@SueldoNormal", eempleados.SueldoNormal)
                .AddWithValue("@SueldoFeriado", eempleados.SueldoFeriado)
                .AddWithValue("@SueldoPresentismo", eempleados.SueldoPresentismo)
                .AddWithValue("@id_Provincia", eempleados.id_Provincia)
                .AddWithValue("@id_Departamento", eempleados.id_Distrito)
                .AddWithValue("@id_Localidad", eempleados.id_Localidad)
                .AddWithValue("@CodigoPostal", eempleados.Codigo_Postal)
                .AddWithValue("@Telefono", eempleados.Telefono)
                .AddWithValue("@Telefono2", eempleados.Telefono2)
                .AddWithValue("@Mail", eempleados.Mail)
                .AddWithValue("@Cuil", eempleados.Cuil)
                .AddWithValue("@FechaNacimiento", eempleados.FechaNacimiento)
                .AddWithValue("@FechaIngreso", eempleados.FechaIngreso)
                .AddWithValue("@Observaciones", eempleados.Observaciones)
                .AddWithValue("@Habilitado", eempleados.Habilitado)
                .AddWithValue("@id_Usuario", eempleados.id_Usuario)
            End With
            Dim respuesta As New SqlParameter("@msg", SqlDbType.VarChar, 255)
            respuesta.Direction = ParameterDirection.Output
            cmd.Parameters.Add(respuesta)

            cmd.ExecuteNonQuery()
            clsDatos.DesconectarRemoto()

            'Elimino las relaciones.
            clsDatos.ConsultarBaseRemoto("execute sp_EmpleadosSucursales_Eliminar @id_Empleado=" & eempleados.id_Empleado)

            'inserto las sucursales para el empleado.
            If eempleados.Sucursales.CheckedItems.Count > 0 Then
                For Each iten In eempleados.Sucursales.CheckedItems
                    'conecto la bdd
                    Dim cmd2 As New SqlCommand
                    cmd2.Connection = clsDatos.ConectarRemoto()
                    Dim id_Sucursal As Integer = 0
                    id_Sucursal = DirectCast(iten.Row, System.Data.DataRow).ItemArray(0)
                    cmd2.CommandType = CommandType.StoredProcedure
                    cmd2.CommandText = "sp_EmpleadosSucursales_Alta"
                    With cmd2.Parameters
                        .AddWithValue("@id_Empleado", eempleados.id_Empleado)
                        .AddWithValue("@id_Sucursal", id_Sucursal)
                    End With
                    Dim respuesta2 As New SqlParameter("@msg", SqlDbType.VarChar, 255)
                    respuesta2.Direction = ParameterDirection.Output
                    cmd2.Parameters.Add(respuesta2)
                    cmd2.ExecuteNonQuery()
                    'desconecto la bdd
                    clsDatos.DesconectarRemoto()
                Next
            Else 'Sino hay sucursales, inserto la del sistema.
                'conecto la bdd
                Dim cmd2 As New SqlCommand
                cmd2.Connection = clsDatos.ConectarRemoto()
                Dim id_Sucursal As Integer = 0
                id_Sucursal = eempleados.id_Sucursal
                cmd2.CommandType = CommandType.StoredProcedure
                cmd2.CommandText = "sp_EmpleadosSucursales_Alta"
                With cmd2.Parameters
                    .AddWithValue("@id_Empleado", eempleados.id_Empleado)
                    .AddWithValue("@id_Sucursal", id_Sucursal)
                End With
                Dim respuesta2 As New SqlParameter("@msg", SqlDbType.VarChar, 255)
                respuesta2.Direction = ParameterDirection.Output
                cmd2.Parameters.Add(respuesta2)
                cmd2.ExecuteNonQuery()
                'desconecto la bdd
                clsDatos.DesconectarRemoto()
            End If

            Return respuesta.Value
        Catch ex As Exception
            Return ex.Message
        End Try
    End Function

    'Funcion para eliminar un empleado.
    Function EliminarEmpleado(ByVal id_Empleado As Integer) As String
        Dim cmd As New SqlCommand
        Try
            cmd.Connection = clsDatos.ConectarRemoto()
            cmd.CommandType = CommandType.StoredProcedure
            cmd.CommandText = "sp_Empleados_Eliminar"
            With cmd.Parameters
                .AddWithValue("@id_Empleado", id_Empleado)
            End With
            Dim respuesta As New SqlParameter("@msg", SqlDbType.VarChar, 255)
            respuesta.Direction = ParameterDirection.Output
            cmd.Parameters.Add(respuesta)

            cmd.ExecuteNonQuery()
            clsDatos.DesconectarRemoto()

            Return respuesta.Value
        Catch ex As Exception
            Return ex.Message
        End Try
    End Function

    'Funcion para listar todos los empleados.
    Function ListadoEmpleados() As DataSet
        If (Funciones.HayInternet) Then
            Return clsDatos.ConsultarBaseRemoto("execute sp_Empleados_Listado")
        Else
            Return clsDatos.ConsultarBaseLocal("execute sp_Empleados_Listado")
        End If
    End Function

    'Funcion para listar todos los empleados por sucursal.
    Function ListadoEmpleadosSucursal(ByVal id_Sucursal As Integer) As DataSet
        If (Funciones.HayInternet) Then
            Return clsDatos.ConsultarBaseRemoto("execute sp_Empleados_ListadoSucursal @id_Sucursal=" & id_Sucursal)
        Else
            Return clsDatos.ConsultarBaseLocal("execute sp_Empleados_ListadoSucursal @id_Sucursal=" & id_Sucursal)
        End If
    End Function

    'Funcion para listar todos los Vendedores por sucursal.
    Function ListadoVendedoresSucursal(ByVal id_Sucursal As Integer) As DataSet
        If (Funciones.HayInternet) Then
            Return clsDatos.ConsultarBaseRemoto("execute sp_Empleados_Vendedores_ListadoSucursal @id_Sucursal=" & id_Sucursal)
        Else
            Return clsDatos.ConsultarBaseLocal("execute sp_Empleados_Vendedores_ListadoSucursal @id_Sucursal=" & id_Sucursal)
        End If
    End Function

    'Funcion para listar todos los Encargados por sucursal.
    Function ListadoEncargadosSucursal(ByVal id_Sucursal As Integer) As DataSet
        If (Funciones.HayInternet) Then
            Return clsDatos.ConsultarBaseRemoto("execute sp_Empleados_Encargados_ListadoSucursal @id_Sucursal=" & id_Sucursal)
        Else
            Return clsDatos.ConsultarBaseLocal("execute sp_Empleados_Encargados_ListadoSucursal @id_Sucursal=" & id_Sucursal)
        End If
    End Function

    'Funcion para listar todos los Vendedores por sucursal que asistieron en el dia.
    Function ListadoVendedoresSucursalAsistencia(ByVal id_Sucursal As Integer) As DataSet
        If (Funciones.HayInternet) Then
            Return clsDatos.ConsultarBaseRemoto("execute sp_Empleados_Vendedores_ListadoSucursal_Asistencia @id_Sucursal=" & id_Sucursal)
        Else
            Return clsDatos.ConsultarBaseLocal("execute sp_Empleados_Vendedores_ListadoSucursal_Asistencia @id_Sucursal=" & id_Sucursal)
        End If
    End Function

    'Funcion para listar todos los Encargados por sucursal que asistieron en el dia.
    Function ListadoEncargadosSucursalAsistencia(ByVal id_Sucursal As Integer) As DataSet
        If (Funciones.HayInternet) Then
            Return clsDatos.ConsultarBaseRemoto("execute sp_Empleados_Encargados_ListadoSucursal_Asistencia @id_Sucursal=" & id_Sucursal)
        Else
            Return clsDatos.ConsultarBaseLocal("execute sp_Empleados_Encargados_ListadoSucursal_Asistencia @id_Sucursal=" & id_Sucursal)
        End If
    End Function

    'Obtiene la sumatoria de todos los sueldos de la sucursal.
    Function ObtenerSueldosSucursal(ByVal id_Sucursal As Integer, ByVal FDesde As String, ByVal FHasta As String) As Double

        Dim SueldosSucursal As DataSet = SueldoDepositadoDetalleSucursal(id_Sucursal, FDesde, FHasta)

        Dim TotalSueldosEmp As Double = SueldosSucursal.Tables(0).AsEnumerable().Sum(Function(row) row.Field(Of Double)("Monto"))

        Return TotalSueldosEmp
    End Function

    'Obtiene la sumatoria de todos los sueldos de la sucursal.
    Function ObtenerSueldosSucursalDia(ByVal id_Sucursal As Integer, ByVal Fecha As String)
        'Declaracion de variables
        Dim NegRegistros As New Negocio.NegRegistros
        Dim TotEmpleados As Integer = 0
        Dim dsEmpleados As New DataSet
        'Dim Comision As Double = 0
        Dim Dias As Integer = 0
        Dim DiasFeriados As Integer = 0
        Dim SueldoNormal As Double = 0
        Dim SueldoFeriado As Double = 0
        'Dim TotalComisionesEmp As Double = 0
        Dim TotalSueldosEmp As Double = 0

        dsEmpleados = ListadoEmpleadosSucursal(id_Sucursal)
        TotEmpleados = dsEmpleados.Tables(0).Rows.Count

        For Each emp In dsEmpleados.Tables(0).Rows
            Dim Sueldo As Double = 0
            Dim id_Empleado As Integer = 0

            id_Empleado = CInt(emp.Item("id_Empleado"))
            Dias = NegRegistros.ObtenerDias(id_Empleado, id_Sucursal, Fecha, Fecha)
            DiasFeriados = NegRegistros.ObtenerDiasFeriados(id_Empleado, id_Sucursal, Fecha, Fecha)
            SueldoNormal = CDbl(emp.Item("SueldoNormal"))
            SueldoFeriado = CDbl(emp.Item("SueldoFeriado"))

            If (Dias + DiasFeriados) > 0 Then
                Sueldo = (Dias * SueldoNormal) + (DiasFeriados * SueldoFeriado)
            Else
                Sueldo = 0
            End If

            'Acumulo los totales del empleado.
            TotalSueldosEmp += Sueldo
        Next

        Return TotalSueldosEmp
    End Function

    'Obtiene la sumatoria de todas las comisiones de la sucursal.
    Function ObtenerComisionesSucursal(ByVal id_Sucursal As Integer, ByVal FDesde As String, ByVal FHasta As String)
        'Declaracion de variables
        Dim NegComision As New Negocio.NegComisiones
        Dim TotEmpleados As Integer = 0
        Dim dsEmpleados As New DataSet

        Dim Comision As Double = 0
        Dim TotalComisionesEmp As Double = 0

        dsEmpleados = ListadoEmpleadosSucursal(id_Sucursal)
        TotEmpleados = dsEmpleados.Tables(0).Rows.Count

        For Each emp In dsEmpleados.Tables(0).Rows
            Dim id_Empleado As Integer = 0
            id_Empleado = CInt(emp.Item("id_Empleado"))

            Comision = NegComision.ConsultarComisionesPorPeriodo(id_Empleado, id_Sucursal, FDesde, FHasta)

            'Acumulo los totales del empleado.
            TotalComisionesEmp += Comision
        Next

        Return TotalComisionesEmp
    End Function

    'Funcion que se fija, dependiendo de la fecha si su sueldo fue depositado.
    Function SueldoDepositado(ByVal id_Empleado As Integer, ByVal id_Sucursal As Integer, ByVal Fecha As String) As Integer
        Dim ds As DataSet
        If (Funciones.HayInternet) Then
            ds = clsDatos.ConsultarBaseRemoto("execute sp_Empleados_SueldoDepositado @id_Sucursal=" & id_Sucursal & ", @id_Empleado='" & id_Empleado & "', @Fecha='" & Fecha & "'")
        Else
            ds = clsDatos.ConsultarBaseLocal("execute sp_Empleados_SueldoDepositado  @id_Sucursal=" & id_Sucursal & ", @id_Empleado='" & id_Empleado & "', @Fecha='" & Fecha & "'")
        End If

        If ds.Tables(0).Rows.Count = 1 Then
            Return 1
        Else
            Return 0
        End If
    End Function

    'Funcion que returna el total de sueldo depositados en un periodo de tiempo.
    Function SueldoDepositadoTotal(ByVal id_Empleado As Integer, ByVal id_Sucursal As Integer, ByVal FechaDesde As String, ByVal FechaHasta As String) As Integer
        Dim ds As DataSet
        Dim SueldoDepositado As Integer = 0

        If (Funciones.HayInternet) Then
            ds = clsDatos.ConsultarBaseRemoto("execute sp_Empleados_SueldoDepositado_detalle @id_Sucursal=" & id_Sucursal & ", @id_Empleado='" & id_Empleado & "', @FechaDesde='" & FechaDesde & "', @FechaHasta='" & FechaHasta & "'")
        Else
            ds = clsDatos.ConsultarBaseLocal("execute sp_Empleados_SueldoDepositado_detalle @id_Sucursal=" & id_Sucursal & ", @id_Empleado='" & id_Empleado & "', @FechaDesde='" & FechaDesde & "', @FechaHasta='" & FechaHasta & "'")
        End If

        For Each emp In ds.Tables(0).Rows
            SueldoDepositado += CInt(emp.Item("Monto"))
        Next
        Return SueldoDepositado
    End Function

    'Funcion que returna el detalle de sueldo depositados en un periodo de tiempo.
    Function SueldoDepositadoDetalle(ByVal id_Empleado As Integer, ByVal id_Sucursal As Integer, ByVal FechaDesde As String, ByVal FechaHasta As String) As DataSet
        Dim ds As DataSet
        Dim SueldoDepositado As Integer = 0

        If (Funciones.HayInternet) Then
            ds = clsDatos.ConsultarBaseRemoto("execute sp_Empleados_SueldoDepositado_detalle @id_Sucursal=" & id_Sucursal & ", @id_Empleado='" & id_Empleado & "', @FechaDesde='" & FechaDesde & "', @FechaHasta='" & FechaHasta & "'")
        Else
            ds = clsDatos.ConsultarBaseLocal("execute sp_Empleados_SueldoDepositado_detalle @id_Sucursal=" & id_Sucursal & ", @id_Empleado='" & id_Empleado & "', @FechaDesde='" & FechaDesde & "', @FechaHasta='" & FechaHasta & "'")
        End If

        Return ds
    End Function

    'Funcion que returna el detalle de sueldo depositados en un periodo de tiempo.
    Function SueldoDepositadoDetalleSucursal(ByVal id_Sucursal As Integer, ByVal FechaDesde As String, ByVal FechaHasta As String) As DataSet
        Dim ds As DataSet
        Dim SueldoDepositado As Integer = 0

        If (Funciones.HayInternet) Then
            ds = clsDatos.ConsultarBaseRemoto("execute sp_Empleados_SueldoDepositado_SucursalListado @id_Sucursal=" & id_Sucursal & ", @FechaDesde='" & FechaDesde & "', @FechaHasta='" & FechaHasta & "'")
        Else
            ds = clsDatos.ConsultarBaseLocal("execute sp_Empleados_SueldoDepositado_SucursalListado @id_Sucursal=" & id_Sucursal & ", @FechaDesde='" & FechaDesde & "', @FechaHasta='" & FechaHasta & "'")
        End If

        Return ds
    End Function
    'Funcion para insertar un adelanto.
    Function AltaDeposito(ByVal eDeposito As Entidades.Depositos) As String
        'Declaro variables
        Dim cmd As New SqlCommand
        Dim msg As String = ""
        Dim HayInternet As Boolean = Funciones.HayInternet

        Try
            cmd.Connection = clsDatos.ConectarLocal()
            msg = AltaDeposito(eDeposito, cmd)
            clsDatos.DesconectarLocal()

            If (HayInternet) Then
                cmd = New SqlCommand()
                cmd.Connection = clsDatos.ConectarRemoto()
                msg = AltaDeposito(eDeposito, cmd)
                clsDatos.DesconectarRemoto()
            End If

            'muestro el mensaje
            Return msg
        Catch ex As Exception
            Return ex.Message
        End Try
    End Function

    Private Shared Function AltaDeposito(eDeposito As Depositos, ByRef cmd As SqlCommand)
        cmd.CommandType = CommandType.StoredProcedure
        cmd.CommandText = "sp_Empleados_SueldoDepositadoAlta"
        With cmd.Parameters
            .AddWithValue("@id_Empleado", eDeposito.id_Empleado)
            .AddWithValue("@id_Sucursal", eDeposito.id_Sucursal)
            .AddWithValue("@Monto", eDeposito.Monto)
            .AddWithValue("@Fecha", eDeposito.Fecha)
            .AddWithValue("@Mes", eDeposito.Mes)
            .AddWithValue("@Anio", eDeposito.Anio)
            .AddWithValue("@Habilitado", eDeposito.Habilitado)
        End With
        Dim respuesta As New SqlParameter("@msg", SqlDbType.VarChar, 255)
        respuesta.Direction = ParameterDirection.Output
        cmd.Parameters.Add(respuesta)
        cmd.ExecuteNonQuery()
        Return respuesta.Value
    End Function

    'Funcion para insertar un adelanto.
    Function ActualizarDeuda(ByVal id_Empleado As Integer, ByVal id_Sucursal As Integer, ByVal Monto As Double, ByVal Fecha As Date) As String
        'Declaro variables
        Dim cmd As New SqlCommand
        Dim msg As String = ""
        Dim HayInternet As Boolean = Funciones.HayInternet

        Try
            cmd.Connection = clsDatos.ConectarLocal()
            msg = ActualizarDeuda(id_Empleado, id_Sucursal, Monto, Fecha, cmd)
            clsDatos.DesconectarLocal()

            If (HayInternet) Then
                cmd = New SqlCommand()
                cmd.Connection = clsDatos.ConectarRemoto()
                msg = ActualizarDeuda(id_Empleado, id_Sucursal, Monto, Fecha, cmd)
                clsDatos.DesconectarRemoto()
            End If

            'muestro el mensaje
            Return msg
        Catch ex As Exception
            Return ex.Message
        End Try
    End Function

    Private Shared Function ActualizarDeuda(id_Empleado As Integer, id_Sucursal As Integer, Monto As Double, Fecha As Date, ByRef cmd As SqlCommand) As String
        cmd.CommandType = CommandType.StoredProcedure
        cmd.CommandText = "sp_Deuda_Actualizar"
        With cmd.Parameters
            .AddWithValue("@id_Empleado", id_Empleado)
            .AddWithValue("@id_Sucursal", id_Sucursal)
            .AddWithValue("@Monto", Monto)
            .AddWithValue("@Fecha", Fecha)
        End With
        Dim respuesta As New SqlParameter("@msg", SqlDbType.VarChar, 255)
        respuesta.Direction = ParameterDirection.Output
        cmd.Parameters.Add(respuesta)
        cmd.ExecuteNonQuery()
        Return respuesta.Value
    End Function

    Function ObtenerEstadoCuenta(ByVal id_Empleado As Integer, ByVal id_Sucursal As Integer, ByVal FechaDesde As String, ByVal FechaHasta As String) As EstadoCuenta
        Dim HayInternet As Boolean = Funciones.HayInternet
        Dim cmd As New SqlCommand

        'Conecto
        If (HayInternet) Then
            cmd.Connection = clsDatos.ConectarRemoto()
        Else
            cmd.Connection = clsDatos.ConectarLocal()
        End If

        cmd.CommandType = CommandType.StoredProcedure
        cmd.CommandText = "sp_Empleado_Obtener_Estado_Cuenta"
        With cmd.Parameters
            .AddWithValue("@id_Empleado", id_Empleado)
            .AddWithValue("@id_Sucursal", id_Sucursal)
            .AddWithValue("@FDesde", FechaDesde)
            .AddWithValue("@FHasta", FechaHasta)
        End With

        Dim DiasFeriados As New SqlParameter("@DiasFeriados", SqlDbType.Int)
        DiasFeriados.Direction = ParameterDirection.Output
        cmd.Parameters.Add(DiasFeriados)

        Dim DiasNormales As New SqlParameter("@DiasNormales", SqlDbType.Int)
        DiasNormales.Direction = ParameterDirection.Output
        cmd.Parameters.Add(DiasNormales)

        Dim DiasTarde As New SqlParameter("@DiasTarde", SqlDbType.Int)
        DiasTarde.Direction = ParameterDirection.Output
        cmd.Parameters.Add(DiasTarde)

        Dim DiasAusente As New SqlParameter("@DiasAusente", SqlDbType.Int)
        DiasAusente.Direction = ParameterDirection.Output
        cmd.Parameters.Add(DiasAusente)

        Dim Adicionales As New SqlParameter("@Adicionales", SqlDbType.Float)
        Adicionales.Direction = ParameterDirection.Output
        cmd.Parameters.Add(Adicionales)

        Dim Vacaciones As New SqlParameter("@Vacaciones", SqlDbType.Float)
        Vacaciones.Direction = ParameterDirection.Output
        cmd.Parameters.Add(Vacaciones)

        Dim Aguinaldo As New SqlParameter("@Aguinaldo", SqlDbType.Float)
        Aguinaldo.Direction = ParameterDirection.Output
        cmd.Parameters.Add(Aguinaldo)

        Dim RecivoSueldo As New SqlParameter("@RecivoSueldo", SqlDbType.Float)
        RecivoSueldo.Direction = ParameterDirection.Output
        cmd.Parameters.Add(RecivoSueldo)

        Dim Comisiones As New SqlParameter("@Comisiones", SqlDbType.Float)
        Comisiones.Direction = ParameterDirection.Output
        cmd.Parameters.Add(Comisiones)

        Dim Adelantos As New SqlParameter("@Adelantos", SqlDbType.Float)
        Adelantos.Direction = ParameterDirection.Output
        cmd.Parameters.Add(Adelantos)

        Dim SueldoPagado As New SqlParameter("@SueldoPagado", SqlDbType.Float)
        SueldoPagado.Direction = ParameterDirection.Output
        cmd.Parameters.Add(SueldoPagado)

        Dim Deuda As New SqlParameter("@Deuda", SqlDbType.Float)
        Deuda.Direction = ParameterDirection.Output
        cmd.Parameters.Add(Deuda)

        cmd.ExecuteNonQuery()

        'Desconecto
        If (HayInternet) Then
            clsDatos.DesconectarRemoto()
        Else
            clsDatos.DesconectarLocal()
        End If

        Dim estadoCuenta As EstadoCuenta = New EstadoCuenta()

        estadoCuenta.Adicionales = Adicionales.Value
        estadoCuenta.Adelantos = Adelantos.Value
        estadoCuenta.Comisiones = Comisiones.Value
        estadoCuenta.CantidadDiasAusente = DiasAusente.Value
        estadoCuenta.CantidadDiasTarde = DiasTarde.Value
        estadoCuenta.CantidadDiasFeriados = DiasFeriados.Value
        estadoCuenta.CantidadDiasNormales = DiasNormales.Value
        estadoCuenta.RecivoSueldo = RecivoSueldo.Value
        estadoCuenta.Aguinaldo = Aguinaldo.Value
        estadoCuenta.SueldoPago = SueldoPagado.Value
        estadoCuenta.Vacaciones = Vacaciones.Value

        If IsDBNull(Deuda.Value) Then
            estadoCuenta.Deuda = Nothing
        Else
            estadoCuenta.Deuda = Deuda.Value
        End If

        Return estadoCuenta
    End Function

    'Funcion que returna el detalle de las comisiones diferenciada por dia
    Function ComisionPorDia(ByVal id_Empleado As Integer, ByVal id_Sucursal As Integer, ByVal FechaDesde As String, ByVal FechaHasta As String) As DataSet
        Dim ds As DataSet

        If (Funciones.HayInternet) Then
            ds = clsDatos.ConsultarBaseRemoto("execute sp_Empleado_Obtener_Comisiones_Dia @id_Empleado=" & id_Empleado & ", @id_Sucursal='" & id_Sucursal & "', @FDesde='" & FechaDesde & "', @FHasta='" & FechaHasta & "'")
        Else
            ds = clsDatos.ConsultarBaseRemoto("execute sp_Empleado_Obtener_Comisiones_Dia @id_Empleado=" & id_Empleado & ", @id_Sucursal='" & id_Sucursal & "', @FDesde='" & FechaDesde & "', @FHasta='" & FechaHasta & "'")
        End If

        Return ds
    End Function

    'Funcion que returna el detalle de sueldo diferenciada por dia
    Function SueldoPorDia(ByVal id_Empleado As Integer, ByVal id_Sucursal As Integer, ByVal FechaDesde As String, ByVal FechaHasta As String) As DataSet
        Dim ds As DataSet

        If (Funciones.HayInternet) Then
            ds = clsDatos.ConsultarBaseRemoto("execute sp_Empleado_Obtener_Sueldo_Dia @id_Empleado=" & id_Empleado & ", @id_Sucursal='" & id_Sucursal & "', @FDesde='" & FechaDesde & "', @FHasta='" & FechaHasta & "'")
        Else
            ds = clsDatos.ConsultarBaseRemoto("execute sp_Empleado_Obtener_Sueldo_Dia @id_Empleado=" & id_Empleado & ", @id_Sucursal='" & id_Sucursal & "', @FDesde='" & FechaDesde & "', @FHasta='" & FechaHasta & "'")
        End If

        Return ds
    End Function

    Function UltimaDeuda(id_Empleado As Integer, id_Sucursal As Integer, fechaDesde As DateTime) As DateTime?
        Dim cmd As New SqlCommand
        Dim HayInternet As Boolean = Funciones.HayInternet

        'Conecto
        If (HayInternet) Then
            cmd.Connection = clsDatos.ConectarRemoto()
        Else
            cmd.Connection = clsDatos.ConectarLocal()
        End If

        cmd.CommandType = CommandType.StoredProcedure
        cmd.CommandText = "sp_Deuda_UltimaDeuda"
        With cmd.Parameters
            .AddWithValue("@id_Empleado", id_Empleado)
            .AddWithValue("@id_Sucursal", id_Sucursal)
            .AddWithValue("@fechaDesde", fechaDesde)
        End With

        Dim fecha As New SqlParameter("@fecha", SqlDbType.Date)
        fecha.Direction = ParameterDirection.Output
        cmd.Parameters.Add(fecha)

        cmd.ExecuteNonQuery()

        'Desconecto
        If (HayInternet) Then
            clsDatos.DesconectarRemoto()
        Else
            clsDatos.DesconectarLocal()
        End If

        If IsDBNull(fecha.Value) Then
            Return Nothing
        Else
            Return fecha.Value
        End If
    End Function

    Private Shared Function ObtenerEmpleadoFromDataRow(dsEmpleado As DataSet) As Empleados

        Dim entEmpleado As New Entidades.Empleados

        entEmpleado.id_Empleado = dsEmpleado.Tables(0).Rows(0).Item("id_Empleado").ToString
        entEmpleado.id_TipoEmpleado = dsEmpleado.Tables(0).Rows(0).Item("id_TipoEmpleado").ToString
        entEmpleado.id_Sucursal = dsEmpleado.Tables(0).Rows(0).Item("id_Sucursal").ToString
        entEmpleado.Nombre = dsEmpleado.Tables(0).Rows(0).Item("Nombre").ToString
        entEmpleado.Apellido = dsEmpleado.Tables(0).Rows(0).Item("Apellido").ToString
        entEmpleado.SueldoNormal = dsEmpleado.Tables(0).Rows(0).Item("SueldoNormal").ToString
        entEmpleado.SueldoFeriado = dsEmpleado.Tables(0).Rows(0).Item("SueldoFeriado").ToString
        entEmpleado.SueldoPresentismo = dsEmpleado.Tables(0).Rows(0).Item("SueldoPresentismo").ToString
        entEmpleado.Direccion = dsEmpleado.Tables(0).Rows(0).Item("Direccion").ToString
        entEmpleado.Codigo_Postal = dsEmpleado.Tables(0).Rows(0).Item("Codigo_Postal").ToString
        entEmpleado.Cuil = dsEmpleado.Tables(0).Rows(0).Item("Cuil").ToString
        entEmpleado.id_Provincia = dsEmpleado.Tables(0).Rows(0).Item("id_Provincia").ToString
        entEmpleado.id_Localidad = dsEmpleado.Tables(0).Rows(0).Item("id_Localidad").ToString
        entEmpleado.id_Distrito = dsEmpleado.Tables(0).Rows(0).Item("id_Departamento").ToString
        entEmpleado.Observaciones = dsEmpleado.Tables(0).Rows(0).Item("Observaciones").ToString
        entEmpleado.Telefono = dsEmpleado.Tables(0).Rows(0).Item("Telefono").ToString
        entEmpleado.Telefono2 = dsEmpleado.Tables(0).Rows(0).Item("Telefono2").ToString
        entEmpleado.Mail = dsEmpleado.Tables(0).Rows(0).Item("Mail").ToString
        entEmpleado.Habilitado = dsEmpleado.Tables(0).Rows(0).Item("Habilitado").ToString
        entEmpleado.Fecha = dsEmpleado.Tables(0).Rows(0).Item("Fecha").ToString
        entEmpleado.FechaNacimiento = dsEmpleado.Tables(0).Rows(0).Item("FechaNacimiento").ToString
        entEmpleado.FechaIngreso = dsEmpleado.Tables(0).Rows(0).Item("FechaIngreso").ToString
        entEmpleado.id_Usuario = If(dsEmpleado.Tables(0).Rows(0).Item("id_Usuario") Is DBNull.Value, 0, dsEmpleado.Tables(0).Rows(0).Item("id_Usuario"))
        Return entEmpleado
    End Function

End Class
