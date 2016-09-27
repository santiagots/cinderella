Imports System.Data.SqlClient

Public Class NegCuentaCorriente
    Dim clsDatos As New Datos.Conexion
    Dim ClsFunciones As New Funciones

    'Funcion para dar de alta una nueva cuenta corriente con el proveedor.
    Function AltaCuentaCorriente(ByVal ECuenta As Entidades.Cuenta_Corriente) As String
        'Declaro variables
        Dim cmd As New SqlCommand
        Dim msg As String = ""
        Dim HayInternet As Boolean = Funciones.HayInternet

        Try
            cmd.Connection = clsDatos.ConectarLocal()
            msg = AltaCuentaCorriente(ECuenta, cmd)
            clsDatos.DesconectarLocal()

            If (HayInternet) Then
                cmd = New SqlCommand()
                cmd.Connection = clsDatos.ConectarRemoto()
                AltaCuentaCorriente(ECuenta, cmd)
                clsDatos.DesconectarRemoto()
            End If

            'muestro el mensaje
            Return msg
        Catch ex As Exception
            Return ex.Message
        End Try
    End Function

    Private Shared Function AltaCuentaCorriente(ECuenta As Entidades.Cuenta_Corriente, ByRef cmd As SqlCommand) As String
        cmd.CommandType = CommandType.StoredProcedure
        cmd.CommandText = "sp_CuentaCorriente_Alta"
        With cmd.Parameters
            .AddWithValue("@id_Sucursal", ECuenta.id_Sucursal)
            .AddWithValue("@id_Proveedor", ECuenta.id_Proveedor)
            .AddWithValue("@Fecha", ECuenta.Fecha)
            .AddWithValue("@id_Mercaderia", ECuenta.id_Mercaderia)
            .AddWithValue("@Monto", ECuenta.Monto)
        End With
        Dim respuesta As New SqlParameter("@msg", SqlDbType.Int, 11)
        respuesta.Direction = ParameterDirection.Output
        cmd.Parameters.Add(respuesta)
        cmd.ExecuteNonQuery()
        Return respuesta.Value
    End Function

    'Funcion que obtiene el ultimo id de la tabla.
    Function ObtenerUltimoID()
        Dim ds As DataSet
        If (Funciones.HayInternet) Then
            ds = clsDatos.ConsultarBaseRemoto("Select IDENT_CURRENT('CUENTA_CORRIENTE') as id_Registro")
        Else
            ds = clsDatos.ConsultarBaseLocal("Select IDENT_CURRENT('CUENTA_CORRIENTE')  as id_Registro")
        End If

        If ds.Tables(0).Rows.Count = 1 And CInt(ds.Tables(0).Rows(0).Item("id_Registro")) > 0 Then
            Return ds.Tables(0).Rows(0).Item("id_Registro").ToString
        Else
            Return 1
        End If
    End Function

    'Funcion para listar las cuentas corrientes por proveedores
    Function ListadoCuentasCorrientes() As DataSet
        If Funciones.HayInternet Then
            Return clsDatos.ConsultarBaseRemoto("execute sp_CuentaCorriente_Listado")
        Else
            Return clsDatos.ConsultarBaseLocal("execute sp_CuentaCorriente_Listado")
        End If
    End Function

    'Funcion para listar las cuentas corrientes por proveedores
    Function ListadoCuentasCorrientesSucursal(ByVal id_Sucursal As Integer) As DataSet
        If Funciones.HayInternet Then
            Return clsDatos.ConsultarBaseRemoto("execute sp_CuentaCorriente_ListadoSucursal @id_Sucursal=" & id_Sucursal)
        Else
            Return clsDatos.ConsultarBaseLocal("execute sp_CuentaCorriente_ListadoSucursal @id_Sucursal=" & id_Sucursal)
        End If
    End Function

    'Funcion para listar el detalle de las cuentas corrientes por proveedores y sucursal
    Function ListadoCuentasCorrientesDetalleAdmin(ByVal id_Proveedor As Integer, ByVal id_Sucursal As Integer) As DataSet
        If Funciones.HayInternet Then
            Return clsDatos.ConsultarBaseRemoto("execute sp_CuentaCorriente_ListadoDetalleAdmin @id_Proveedor=" & id_Proveedor & ",@id_Sucursal=" & id_Sucursal)
        Else
            Return clsDatos.ConsultarBaseLocal("execute sp_CuentaCorriente_ListadoDetalleAdmin @id_Proveedor=" & id_Proveedor & ",@id_Sucursal=" & id_Sucursal)
        End If
    End Function

    'Funcion para listar el detalle de las cuentas corrientes por proveedores
    Function ListadoCuentasCorrientesDetalle(ByVal id_Proveedor As Integer) As DataSet
        If Funciones.HayInternet Then
            Return clsDatos.ConsultarBaseRemoto("execute sp_CuentaCorriente_ListadoDetalle @id_Proveedor=" & id_Proveedor)
        Else
            Return clsDatos.ConsultarBaseLocal("execute sp_CuentaCorriente_ListadoDetalle @id_Proveedor=" & id_Proveedor)
        End If
    End Function

    Function ObtenerMontoProveedor(ByVal id_Proveedor As Integer) As DataSet
        If Funciones.HayInternet Then
            Return clsDatos.ConsultarBaseRemoto("execute sp_CuentaCorriente_ObtenerMonto @id_Proveedor=" & id_Proveedor)
        Else
            Return clsDatos.ConsultarBaseLocal("execute sp_CuentaCorriente_ObtenerMonto @id_Proveedor=" & id_Proveedor)
        End If
    End Function

    Function ObtenerMontoSucursal(ByVal id_Proveedor As Integer, ByVal id_Sucursal As Integer) As Double
        Dim ds As New DataSet
        If Funciones.HayInternet Then
            ds = clsDatos.ConsultarBaseRemoto("execute sp_CuentaCorriente_ObtenerMontoSucursal @id_Sucursal=" & id_Sucursal & ", @id_Proveedor='" & id_Proveedor & "'")
        Else
            ds = clsDatos.ConsultarBaseLocal("execute sp_CuentaCorriente_ObtenerMontoSucursal @id_Sucursal=" & id_Sucursal & ", @id_Proveedor='" & id_Proveedor & "'")
        End If

        If ds.Tables(0).Rows.Count = 1 And ds.Tables(0).Rows(0).Item("Importe").ToString <> "" Then
            Return ds.Tables(0).Rows(0).Item("Importe").ToString
        Else
            Return 0
        End If
    End Function

End Class
