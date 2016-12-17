Imports System.Data.SqlClient
Public Class NegComisiones
    Dim clsDatos As New Datos.Conexion
    Dim ClsFunciones As New Funciones
    Dim HayInternet As Boolean = Funciones.HayInternet

    'Funcion que agrega una determinada comision a un determinado empleado.
    Function AgregarComision(ByVal ecomisiones As Entidades.Comisiones) As Boolean
        Try
            'Actualizo la base con el nuevo stock.
            'Declaro variables
            Dim cmd As New SqlCommand
            Dim msg As Boolean = False
            Dim HayInternet As Boolean = Funciones.HayInternet

            cmd.Connection = clsDatos.ConectarLocal()
            msg = AgregarComision(ecomisiones, cmd)
            clsDatos.DesconectarLocal()

            If (HayInternet) Then
                cmd = New SqlCommand()
                cmd.Connection = clsDatos.ConectarRemoto()
                msg = AgregarComision(ecomisiones, cmd)
                clsDatos.DesconectarRemoto()
            End If

            'muestro el mensaje
            Return msg
        Catch ex As Exception
            Return False
        End Try

    End Function

    Private Shared Function AgregarComision(ecomisiones As Entidades.Comisiones, ByRef cmd As SqlCommand) As Boolean
        cmd.CommandType = CommandType.StoredProcedure
        cmd.CommandText = "sp_Comisiones_Alta"
        With cmd.Parameters
            .AddWithValue("@id_Empleado", ecomisiones.id_Empleado)
            .AddWithValue("@Monto", ecomisiones.Monto)
            .AddWithValue("@Comision", ecomisiones.Comision)
            .AddWithValue("@id_Venta", ecomisiones.id_Venta)
            .AddWithValue("@id_Sucursal", ecomisiones.id_Sucursal)
        End With

        Dim respuesta As New SqlParameter("@msg", SqlDbType.VarChar, 255)
        respuesta.Direction = ParameterDirection.Output
        cmd.Parameters.Add(respuesta)
        cmd.ExecuteNonQuery()
        Return respuesta.Value
    End Function

    'Funcion que anula la comision de un empleado de una determinada venta.
    Sub AnularComisiones(ByVal id_Empleado As Integer, ByVal id_Sucursal As Integer, ByVal id_Venta As Integer)
        Dim dsComi As New DataSet
        Dim eComi As New Entidades.Comisiones

        'OBtengo la comision realizada
        If (Funciones.HayInternet) Then
            dsComi = clsDatos.ConsultarBaseRemoto("execute sp_Comisiones_Detalle @id_Venta=" & id_Venta & ", @id_Empleado=" & id_Empleado & ", @id_Sucursal=" & id_Sucursal)
        Else
            dsComi = clsDatos.ConsultarBaseLocal("execute sp_Comisiones_Detalle @id_Venta=" & id_Venta & ", @id_Empleado=" & id_Empleado & ", @id_Sucursal=" & id_Sucursal)
        End If

        'Inserto la comision pero con el monto invertido.
        If dsComi.Tables(0).Rows.Count <> 0 Then
            eComi.Comision = dsComi.Tables(0).Rows(0).Item("Comision").ToString
            eComi.Monto = (dsComi.Tables(0).Rows(0).Item("Monto") * -1)
            eComi.id_Venta = id_Venta
            eComi.id_Sucursal = id_Sucursal
            eComi.id_Empleado = id_Empleado
            AgregarComision(eComi)
        End If

    End Sub

    'Funcion que anula la comision de un empleado de una determinada venta.
    Sub EliminarComisiones(ByVal id_Venta As Integer)

        'Actualizo la base con el nuevo stock.
        'Declaro variables
        Dim cmd As New SqlCommand
        Dim HayInternet As Boolean = Funciones.HayInternet

        cmd.Connection = clsDatos.ConectarLocal()
        EliminarComisiones(id_Venta, cmd)
        clsDatos.DesconectarLocal()

        If (HayInternet) Then
            cmd = New SqlCommand()
            cmd.Connection = clsDatos.ConectarRemoto()
            EliminarComisiones(id_Venta, cmd)
            clsDatos.DesconectarRemoto()
        End If
    End Sub

    Sub EliminarComisiones(ByVal id_Venta As Integer, cmd As SqlCommand)
        cmd.CommandType = CommandType.StoredProcedure
        cmd.CommandText = "sp_Comisiones_Eliminar"
        With cmd.Parameters
            .AddWithValue("@id_Venta", id_Venta)
        End With

        cmd.ExecuteNonQuery()
    End Sub

    'Funcion que obtiene una comision de un determinado empleado.
    Function ObtenerComision(ByVal id_Sucursal As Integer, ByVal id_Cliente As Integer, ByRef Vendedor As Double, ByRef Encargado As Double)
        'Declaro variables.
        Dim cmd As New SqlCommand

        Try
            'intento hacer la conexion al servidor remoto y luego al local.
            If (Funciones.HayInternet) Then
                cmd.Connection = clsDatos.ConectarRemoto()
            Else
                cmd.Connection = clsDatos.ConectarLocal()
            End If

            cmd.CommandType = CommandType.StoredProcedure
            cmd.CommandText = "sp_Comisiones_Obtener_Porcentajes_Venta"
            With cmd.Parameters
                .AddWithValue("@id_Sucursal", id_Sucursal)
            End With

            Dim ComisionVendedor As New SqlParameter("@Comision_Vendedor", SqlDbType.Float)
            ComisionVendedor.Direction = ParameterDirection.Output
            cmd.Parameters.Add(ComisionVendedor)

            Dim ComisionEncargado As New SqlParameter("@Comision_Encargado", SqlDbType.Float)
            ComisionEncargado.Direction = ParameterDirection.Output
            cmd.Parameters.Add(ComisionEncargado)

            Dim ComisionVendedorMayor As New SqlParameter("@Comision_Vendedor_Mayor", SqlDbType.Float)
            ComisionVendedorMayor.Direction = ParameterDirection.Output
            cmd.Parameters.Add(ComisionVendedorMayor)

            Dim ComisionEncargadoMayor As New SqlParameter("@Comision_Encargado_Mayor", SqlDbType.Float)
            ComisionEncargadoMayor.Direction = ParameterDirection.Output
            cmd.Parameters.Add(ComisionEncargadoMayor)

            cmd.ExecuteNonQuery()

            If id_Cliente = 0 Then
                Vendedor = ComisionVendedor.Value
                Encargado = ComisionEncargado.Value
            Else
                Vendedor = ComisionVendedorMayor.Value
                Encargado = ComisionEncargadoMayor.Value
            End If

            Return 1
        Catch ex As Exception
            Return 0
        End Try
    End Function

    'Funcion para obtener el total de las comisiones de un empleado.
    Function ObtenerComisiones(ByVal id_Empleado As Integer, ByVal id_Sucursal As Integer, ByVal FDesde As String, ByVal FHasta As String)
        Dim Comision As Double = 0
        Dim dsCom As New DataSet

        If Funciones.HayInternet Then
            dsCom = clsDatos.ConsultarBaseRemoto("execute sp_Comisiones_Obtener @id_Empleado=" & id_Empleado & ", @id_Sucursal=" & id_Sucursal & ", @FDesde='" & FDesde & "', @FHasta='" & FHasta & "'")
        Else
            dsCom = clsDatos.ConsultarBaseLocal("execute sp_Comisiones_Obtener @id_Empleado=" & id_Empleado & ", @id_Sucursal=" & id_Sucursal & ", @FDesde='" & FDesde & "', @FHasta='" & FHasta & "'")
        End If

        If dsCom.Tables(0).Rows.Count > 0 Then
            If dsCom.Tables(0).Rows(0).Item("Comision").ToString <> "" Then
                Return dsCom.Tables(0).Rows(0).Item("Comision").ToString
            Else
                Return 0
            End If
        Else
            Return 0
        End If

    End Function

    'Funcion para obtener el total de las comisiones de un empleado.
    Function ObtenerComisionPorFecha(ByVal id_Empleado As Integer, ByVal id_Sucursal As Integer, ByVal Fecha As String)
        Dim dsCom As New DataSet

        If Funciones.HayInternet Then
            dsCom = clsDatos.ConsultarBaseRemoto("execute sp_Comisiones_ObtenerPorFecha @id_Empleado=" & id_Empleado & ", @id_Sucursal=" & id_Sucursal & ", @Fecha='" & Fecha & "'")
        Else
            dsCom = clsDatos.ConsultarBaseLocal("execute sp_Comisiones_ObtenerPorFecha @id_Empleado=" & id_Empleado & ", @id_Sucursal=" & id_Sucursal & ", @Fecha='" & Fecha & "'")
        End If

        If dsCom.Tables(0).Rows.Count = 1 And dsCom.Tables(0).Rows(0).Item("Comision").ToString <> "" Then
            Return dsCom.Tables(0).Rows(0).Item("Comision").ToString
        Else
            Return 0
        End If

    End Function

    'Funcion para obtener el total de las comisiones de un empleado.
    Function ObtenerComisionPorPeriodo(ByVal id_Sucursal As Integer, ByVal FDesde As String, ByVal FHasta As String)
        Dim dsCom As New DataSet
        If Funciones.HayInternet Then
            dsCom = clsDatos.ConsultarBaseRemoto("execute sp_Comisiones_ObtenerPorPeriodo @id_Sucursal=" & id_Sucursal & ", @FDesde='" & FDesde & "'" & ", @FHasta='" & FHasta & "'")
        Else
            dsCom = clsDatos.ConsultarBaseLocal("execute sp_Comisiones_ObtenerPorPeriodo @id_Sucursal=" & id_Sucursal & ", @FDesde='" & FDesde & "'" & ", @FHasta='" & FHasta & "'")
        End If
        Return dsCom
    End Function

    'Funcion que lista las comisiones de un empleado.
    Function ListarComisionesEmpleado(ByVal id_Empleado As Integer, ByVal id_Sucursal As Integer, ByVal FDesde As String, ByVal FHasta As String)
        If Funciones.HayInternet Then
            Return clsDatos.ConsultarBaseRemoto("execute sp_Comisiones_Listado @id_Empleado=" & id_Empleado & ", @id_Sucursal=" & id_Sucursal & ", @FDesde='" & FDesde & "', @FHasta='" & FHasta & "'")
        Else
            Return clsDatos.ConsultarBaseLocal("execute sp_Comisiones_Listado @id_Empleado=" & id_Empleado & ", @id_Sucursal=" & id_Sucursal & ", @FDesde='" & FDesde & "', @FHasta='" & FHasta & "'")
        End If
    End Function

    Function ConsultarComisionesPeriodo(ByVal id_Empleado As Integer, ByVal id_Sucursal As Integer, ByVal FDesde As String, ByVal FHasta As String)
        Dim HayComision As Boolean = False
        Dim ds As New DataSet

        If Funciones.HayInternet Then
            ds = clsDatos.ConsultarBaseRemoto("execute sp_Comisiones_Consultar @id_Sucursal=" & id_Sucursal & ", @FDesde='" & FDesde & "', @FHasta='" & FHasta & "', @id_Empleado='" & id_Empleado & "'")
        Else
            ds = clsDatos.ConsultarBaseLocal("execute sp_Comisiones_Consultar @id_Sucursal=" & id_Sucursal & ", @FDesde='" & FDesde & "', @FHasta='" & FHasta & "', @id_Empleado='" & id_Empleado & "'")
        End If

        If ds.Tables(0).Rows.Count = 1 And ds.Tables(0).Rows(0).Item("Comision").ToString <> "" Then
            HayComision = True
        Else
            HayComision = False
        End If

        Return HayComision
    End Function

    Function ConsultarComisionesPorPeriodo(ByVal id_Empleado As Integer, ByVal id_Sucursal As Integer, ByVal FDesde As String, ByVal FHasta As String)
        Dim ds As New DataSet

        If Funciones.HayInternet Then
            ds = clsDatos.ConsultarBaseRemoto("execute sp_Comisiones_Consultar @id_Sucursal=" & id_Sucursal & ", @FDesde='" & FDesde & "', @FHasta='" & FHasta & "', @id_Empleado='" & id_Empleado & "'")
        Else
            ds = clsDatos.ConsultarBaseLocal("execute sp_Comisiones_Consultar @id_Sucursal=" & id_Sucursal & ", @FDesde='" & FDesde & "', @FHasta='" & FHasta & "', @id_Empleado='" & id_Empleado & "'")
        End If

        If ds.Tables(0).Rows.Count = 1 And ds.Tables(0).Rows(0).Item("Comision").ToString <> "" Then
            Return ds.Tables(0).Rows(0).Item("Comision").ToString
        Else
            Return 0
        End If
    End Function

End Class
