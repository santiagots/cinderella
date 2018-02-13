Imports System.Data.SqlClient
Imports System.Linq

Public Class NegMovimientos
    Dim clsDatos As New Datos.Conexion
    Dim ClsFunciones As New Funciones

    'Obtener Ingresos
    Function ObtenerIngresos(ByVal id_Sucursal As Integer, ByVal FDesde As String, ByVal FHasta As String)
        Dim ds As New DataSet
        If Funciones.HayInternet Then
            ds = clsDatos.ConsultarBaseRemoto("execute sp_Sucursales_Ingresos @id_Sucursal=" & id_Sucursal & ", @FDesde='" & FDesde & "', @FHasta='" & FHasta & "'")
        Else
            ds = clsDatos.ConsultarBaseLocal("execute sp_Sucursales_Ingresos @id_Sucursal=" & id_Sucursal & ", @FDesde='" & FDesde & "', @FHasta='" & FHasta & "'")
        End If
        Return ds.Tables(0).Rows(0).Item("Ingreso").ToString
    End Function

    'Obtener Egresos
    Function ObtenerEgresos(ByVal id_Sucursal As Integer, ByVal FDesde As String, ByVal FHasta As String)
        Dim ds As New DataSet
        If Funciones.HayInternet Then
            ds = clsDatos.ConsultarBaseRemoto("execute sp_Sucursales_Egresos @id_Sucursal=" & id_Sucursal & ", @FDesde='" & FDesde & "', @FHasta='" & FHasta & "'")
        Else
            ds = clsDatos.ConsultarBaseLocal("execute sp_Sucursales_Egresos @id_Sucursal=" & id_Sucursal & ", @FDesde='" & FDesde & "', @FHasta='" & FHasta & "'")
        End If
        Return ds.Tables(0).Rows(0).Item("Egreso").ToString
    End Function

    'Obtener Ingresos Listado
    Function ObtenerIngresosListado(ByVal id_Sucursal As Integer, ByVal FDesde As String, ByVal FHasta As String)
        Dim ds As New DataSet
        If Funciones.HayInternet Then
            ds = clsDatos.ConsultarBaseRemoto("execute sp_Sucursales_IngresosListado @id_Sucursal=" & id_Sucursal & ", @FDesde='" & FDesde & "', @FHasta='" & FHasta & "'")
        Else
            ds = clsDatos.ConsultarBaseLocal("execute sp_Sucursales_IngresosListado @id_Sucursal=" & id_Sucursal & ", @FDesde='" & FDesde & "', @FHasta='" & FHasta & "'")
        End If
        Return ds
    End Function

    'Obtener Egresos Listado
    Function ObtenerEgresosListado(ByVal id_Sucursal As Integer, ByVal FDesde As String, ByVal FHasta As String)
        Dim ds As New DataSet
        If Funciones.HayInternet Then
            ds = clsDatos.ConsultarBaseRemoto("execute sp_Sucursales_EgresosListado @id_Sucursal=" & id_Sucursal & ", @FDesde='" & FDesde & "', @FHasta='" & FHasta & "'")
        Else
            ds = clsDatos.ConsultarBaseLocal("execute sp_Sucursales_EgresosListado @id_Sucursal=" & id_Sucursal & ", @FDesde='" & FDesde & "', @FHasta='" & FHasta & "'")
        End If
        Return ds
    End Function

    'Funcion para insertar un Gasto.
    Function ConsultaSaldo(ByVal idSucursal As Integer, ByVal fecha As String) As Double
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
            cmd.CommandText = "sp_MovSaldo_Total"
            With cmd.Parameters
                .AddWithValue("@id_Sucursal", idSucursal)
                .AddWithValue("@Fecha", fecha)
            End With

            Dim respuesta As New SqlParameter("@Monto", SqlDbType.Float)
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

    'Consulto si existen montos de un tipo de movimiento de un determinado rango de fechas.
    Function ConsultarMovimiento(ByVal id_Sucursal As Integer, ByVal FDesde As String, ByVal FHasta As String, ByVal id_Seccion As Integer, ByVal id_Tipo As Integer) As Double
        Dim ds As New DataSet
        If Funciones.HayInternet Then
            ds = clsDatos.ConsultarBaseRemoto("execute sp_Movimientos_Consultar @id_Sucursal=" & id_Sucursal & ", @FDesde='" & FDesde & "', @FHasta='" & FHasta & "', @id_Seccion='" & id_Seccion & "', @id_Tipo='" & id_Tipo & "'")
        Else
            ds = clsDatos.ConsultarBaseLocal("execute sp_Movimientos_Consultar @id_Sucursal=" & id_Sucursal & ", @FDesde='" & FDesde & "', @FHasta='" & FHasta & "', @id_Seccion='" & id_Seccion & "', @id_Tipo='" & id_Tipo & "'")
        End If

        If ds.Tables(0).Rows.Count = 1 And ds.Tables(0).Rows(0).Item("Suma").ToString <> "" Then
            Return 1
        Else
            Return 0
        End If
    End Function

    'Consulto si existen montos de un tipo de movimiento de un determinado rango de fechas.
    Function ConsultarTotalMovimiento(ByVal id_Sucursal As Integer, ByVal FDesde As String, ByVal FHasta As String, ByVal id_Seccion As Integer) As Double
        Dim ds As New DataSet
        If Funciones.HayInternet Then
            ds = clsDatos.ConsultarBaseRemoto("execute sp_Movimientos_ConsultarTotal @id_Sucursal=" & id_Sucursal & ", @FDesde='" & FDesde & "', @FHasta='" & FHasta & "', @id_Seccion='" & id_Seccion & "'")
        Else
            ds = clsDatos.ConsultarBaseLocal("execute sp_Movimientos_ConsultarTotal @id_Sucursal=" & id_Sucursal & ", @FDesde='" & FDesde & "', @FHasta='" & FHasta & "', @id_Seccion='" & id_Seccion & "'")
        End If

        If ds.Tables(0).Rows.Count = 1 And ds.Tables(0).Rows(0).Item("Suma").ToString <> "" Then
            Return ds.Tables(0).Rows(0).Item("Suma").ToString
        Else
            Return 0
        End If
    End Function

    'Consulto si existen montos de un tipo de movimiento de un determinado rango de fechas.
    Function ConsultarTotalGastoMercaderia(ByVal id_Sucursal As Integer, ByVal FDesde As String, ByVal FHasta As String) As Double
        Dim ds As New DataSet
        If Funciones.HayInternet Then
            ds = clsDatos.ConsultarBaseRemoto("execute sp_Movimientos_MercaderiaTotal @id_Sucursal=" & id_Sucursal & ", @FDesde='" & FDesde & "', @FHasta='" & FHasta & "'")
        Else
            ds = clsDatos.ConsultarBaseLocal("execute sp_Movimientos_MercaderiaTotal @id_Sucursal=" & id_Sucursal & ", @FDesde='" & FDesde & "', @FHasta='" & FHasta & "'")
        End If

        If ds.Tables(0).Rows.Count = 1 And ds.Tables(0).Rows(0).Item("Suma").ToString <> "" Then
            Return ds.Tables(0).Rows(0).Item("Suma").ToString
        Else
            Return 0
        End If
    End Function

    'Consulto si existen montos de un tipo de movimiento de un determinado rango de fechas.
    Function ConsultarTotalCajaFuerte(ByVal id_Sucursal As Integer, ByVal Fecha As String) As Double
        Dim ds As New DataSet
        If Funciones.HayInternet Then
            ds = clsDatos.ConsultarBaseRemoto("execute sp_MovCajaFuerte_ObtenerSumaTotal @id_Sucursal=" & id_Sucursal & ", @Fecha='" & Fecha & "'")
        Else
            ds = clsDatos.ConsultarBaseLocal("execute sp_MovCajaFuerte_ObtenerSumaTotal @id_Sucursal=" & id_Sucursal & ", @Fecha='" & Fecha & "'")
        End If

        If ds.Tables(0).Rows.Count = 1 And ds.Tables(0).Rows(0).Item("Total").ToString <> "" Then
            Return ds.Tables(0).Rows(0).Item("Total").ToString
        Else
            Return 0
        End If
    End Function

    'Obtiene el monto de un tipo de movimiento de un determinado dia.
    Function ObtenerMovimiento(ByVal id_Sucursal As Integer, ByVal Fecha As String, ByVal id_Seccion As Integer, ByVal id_Tipo As Integer) As Double
        Dim ds As New DataSet
        If Funciones.HayInternet Then
            ds = clsDatos.ConsultarBaseRemoto("execute sp_Movimientos_Obtener @id_Sucursal=" & id_Sucursal & ", @Fecha='" & Fecha & "', @id_Tipo='" & id_Tipo & "', @id_Seccion='" & id_Seccion & "'")
        Else
            ds = clsDatos.ConsultarBaseLocal("execute sp_Movimientos_Obtener @id_Sucursal=" & id_Sucursal & ", @Fecha='" & Fecha & "', @id_Tipo='" & id_Tipo & "', @id_Seccion='" & id_Seccion & "'")
        End If

        If ds.Tables(0).Rows.Count = 1 And ds.Tables(0).Rows(0).Item("Suma").ToString <> "" Then
            Return ds.Tables(0).Rows(0).Item("Suma")
        Else
            Return 0
        End If
    End Function

    'Obtiene los tipos de movimientos dependiendo de la seccion enviada.
    Function ListadoTiposMov(ByVal id_Seccion As Integer) As DataSet
        If (Funciones.HayInternet) Then
            Return clsDatos.ConsultarBaseRemoto("execute sp_Movimientos_ListadoTiposMov @id_Seccion = " & id_Seccion)
        Else
            Return clsDatos.ConsultarBaseLocal("execute sp_Movimientos_ListadoTiposMov @id_Seccion = " & id_Seccion)
        End If
    End Function

    'Obtiene los subtipos de movimientos dependiendo de la seccion y el tipo enviado.
    Function ListadoSubtiposMov(ByVal id_Tipo As Integer) As DataSet
        If (Funciones.HayInternet) Then
            Return clsDatos.ConsultarBaseRemoto("execute sp_Movimientos_ListadoSubtiposMov @id_Tipo=" & id_Tipo)
        Else
            Return clsDatos.ConsultarBaseLocal("execute sp_Movimientos_ListadoSubtiposMov @id_Tipo=" & id_Tipo)
        End If
    End Function

    'Funcion para insertar un Impuesto.
    Function AltaMovImpuesto(ByVal eImpuesto As Entidades.MovImpuesto) As String
        'Declaro variables
        Dim cmd As New SqlCommand
        Dim msg As String = ""
        Dim HayInternet As Boolean = Funciones.HayInternet

        'Si el Id del movimiento es 0 quiere decir que es un alta y se tiene que generar un ID
        If (eImpuesto.id_Movimiento = 0) Then
            eImpuesto.id_Movimiento = clsDatos.ObtenerCalveUnica(eImpuesto.id_Sucursal)
        End If
        eImpuesto.FechaEdicion = DateTime.Now

        Try
            cmd.Connection = clsDatos.ConectarLocal()
            msg = AltaMovImpuesto(eImpuesto, cmd)
            clsDatos.DesconectarLocal()

            If (HayInternet) Then
                cmd = New SqlCommand()
                cmd.Connection = clsDatos.ConectarRemoto()
                msg = AltaMovImpuesto(eImpuesto, cmd)
                clsDatos.DesconectarRemoto()
            End If

            'muestro el mensaje
            Return msg
        Catch ex As Exception
            Return ex.Message
        End Try
    End Function

    Private Shared Function AltaMovImpuesto(eImpuesto As Entidades.MovImpuesto, ByRef cmd As SqlCommand) As String
        cmd.CommandType = CommandType.StoredProcedure
        cmd.CommandText = "sp_MovImpuestos_Alta"
        With cmd.Parameters
            .AddWithValue("@id_Movimiento", eImpuesto.id_Movimiento)
            .AddWithValue("@id_Tipo", eImpuesto.id_Tipo)
            .AddWithValue("@id_Sucursal", eImpuesto.id_Sucursal)
            .AddWithValue("@Monto", eImpuesto.Monto)
            .AddWithValue("@Fecha", eImpuesto.Fecha)
            .AddWithValue("@FechaEdicion", eImpuesto.FechaEdicion)
        End With
        Dim respuesta As New SqlParameter("@msg", SqlDbType.VarChar, 255)
        respuesta.Direction = ParameterDirection.Output
        cmd.Parameters.Add(respuesta)
        cmd.ExecuteNonQuery()
        Return respuesta.Value
    End Function

    'Funcion para insertar un mov de caja chica.
    Function AltaMovCajaFuerte(ByVal eCaja As Entidades.MovCajaFuerte) As String
        'Declaro variables
        Dim cmd As New SqlCommand
        Dim msg As String = ""
        Dim HayInternet As Boolean = Funciones.HayInternet
        Dim respuesta As String

        'Si el Id del movimiento es 0 quiere decir que es un alta y se tiene que generar un ID
        If (eCaja.id_Movimiento = 0) Then
            eCaja.id_Movimiento = clsDatos.ObtenerCalveUnica(eCaja.id_Sucursal)
        End If
        eCaja.FechaEdicion = DateTime.Now()

        Try
            cmd.Connection = clsDatos.ConectarLocal()
            respuesta = AltaMovCajaFuerte(eCaja, cmd)
            clsDatos.DesconectarLocal()

            If (HayInternet) Then
                cmd = New SqlCommand()
                cmd.Connection = clsDatos.ConectarRemoto()
                respuesta = AltaMovCajaFuerte(eCaja, cmd)
                clsDatos.DesconectarRemoto()
            End If

            'muestro el mensaje
            Return respuesta
        Catch ex As Exception
            Return ex.Message
        End Try
    End Function

    Private Shared Function AltaMovCajaFuerte(eCaja As Entidades.MovCajaFuerte, ByRef cmd As SqlCommand) As String
        cmd.CommandType = CommandType.StoredProcedure
        cmd.CommandText = "sp_MovCajaFuerte_Alta"
        With cmd.Parameters
            .AddWithValue("@id_Movimiento", eCaja.id_Movimiento)
            .AddWithValue("@id_Tipo", eCaja.id_Tipo)
            .AddWithValue("@id_Sucursal", eCaja.id_Sucursal)
            .AddWithValue("@Monto", eCaja.Monto)
            .AddWithValue("@Descripcion", eCaja.Descripcion)
            .AddWithValue("@Fecha", eCaja.Fecha)
            .AddWithValue("@FechaEdicion", eCaja.FechaEdicion)
        End With
        Dim respuesta As New SqlParameter("@msg", SqlDbType.VarChar, 255)
        respuesta.Direction = ParameterDirection.Output
        cmd.Parameters.Add(respuesta)
        cmd.ExecuteNonQuery()

        Return respuesta.Value
    End Function

    'Funcion para insertar un retiro de socios.
    Function AltaMovRetiro(ByVal eRetiro As Entidades.MovSocios) As String
        'Declaro variables
        Dim cmd As New SqlCommand
        Dim msg As String = ""
        Dim HayInternet As Boolean = Funciones.HayInternet

        'Si el Id del movimiento es 0 quiere decir que es un alta y se tiene que generar un ID
        If (eRetiro.id_Movimiento = 0) Then
            eRetiro.id_Movimiento = clsDatos.ObtenerCalveUnica(eRetiro.id_Sucursal)
        End If
        eRetiro.FechaEdicion = DateTime.Now()

        Try
            cmd.Connection = clsDatos.ConectarLocal()
            msg = AltaMovRetiro(eRetiro, cmd)
            clsDatos.DesconectarLocal()

            If (HayInternet) Then
                cmd = New SqlCommand()
                cmd.Connection = clsDatos.ConectarRemoto()
                msg = AltaMovRetiro(eRetiro, cmd)
                clsDatos.DesconectarRemoto()
            End If

            'muestro el mensaje
            Return msg
        Catch ex As Exception
            Return ex.Message
        End Try
    End Function

    Private Shared Function AltaMovRetiro(eRetiro As Entidades.MovSocios, ByRef cmd As SqlCommand) As String
        cmd.CommandType = CommandType.StoredProcedure
        cmd.CommandText = "sp_MovRetiro_Alta"
        With cmd.Parameters
            .AddWithValue("@id_Movimiento", eRetiro.id_Movimiento)
            .AddWithValue("@id_Sucursal", eRetiro.id_Sucursal)
            .AddWithValue("@Monto", eRetiro.Monto)
            .AddWithValue("@Descripcion", eRetiro.Descripcion)
            .AddWithValue("@Encargado", eRetiro.Encargado)
            .AddWithValue("@Persona", eRetiro.Persona)
            .AddWithValue("@id_Tipo_Pago", eRetiro.IdTipoPago)
            .AddWithValue("@id_Cheque", eRetiro.IdCheque)
            .AddWithValue("@Fecha", eRetiro.Fecha)
            .AddWithValue("@FechaEdicion", eRetiro.FechaEdicion)
        End With
        Dim respuesta As New SqlParameter("@msg", SqlDbType.VarChar, 255)
        respuesta.Direction = ParameterDirection.Output
        cmd.Parameters.Add(respuesta)
        cmd.ExecuteNonQuery()
        Return respuesta.Value
    End Function

    'Funcion para insertar un aporte de socios.
    Function AltaMovAporte(ByVal eRetiro As Entidades.MovSocios) As String
        'Declaro variables
        Dim cmd As New SqlCommand
        Dim msg As String = ""
        Dim HayInternet As Boolean = Funciones.HayInternet

        'Si el Id del movimiento es 0 quiere decir que es un alta y se tiene que generar un ID
        If (eRetiro.id_Movimiento = 0) Then
            eRetiro.id_Movimiento = clsDatos.ObtenerCalveUnica(eRetiro.id_Sucursal)
        End If
        eRetiro.FechaEdicion = DateTime.Now()

        Try
            cmd.Connection = clsDatos.ConectarLocal()
            msg = AltaMovAporte(eRetiro, cmd)
            clsDatos.DesconectarLocal()

            If (HayInternet) Then
                cmd = New SqlCommand()
                cmd.Connection = clsDatos.ConectarRemoto()
                msg = AltaMovAporte(eRetiro, cmd)
                clsDatos.DesconectarRemoto()
            End If

            'muestro el mensaje
            Return msg
        Catch ex As Exception
            Return ex.Message
        End Try
    End Function

    Private Shared Function AltaMovAporte(eRetiro As Entidades.MovSocios, ByRef cmd As SqlCommand) As String
        cmd.CommandType = CommandType.StoredProcedure
        cmd.CommandText = "sp_MovAporte_Alta"
        With cmd.Parameters
            .AddWithValue("@id_Movimiento", eRetiro.id_Movimiento)
            .AddWithValue("@id_Sucursal", eRetiro.id_Sucursal)
            .AddWithValue("@Monto", eRetiro.Monto)
            .AddWithValue("@Descripcion", eRetiro.Descripcion)
            .AddWithValue("@Encargado", eRetiro.Encargado)
            .AddWithValue("@Persona", eRetiro.Persona)
            .AddWithValue("@id_Tipo_Pago", eRetiro.IdTipoPago)
            .AddWithValue("@id_Cheque", eRetiro.IdCheque)
            .AddWithValue("@Fecha", eRetiro.Fecha)
            .AddWithValue("@FechaEdicion", eRetiro.FechaEdicion)
        End With
        Dim respuesta As New SqlParameter("@msg", SqlDbType.VarChar, 255)
        respuesta.Direction = ParameterDirection.Output
        cmd.Parameters.Add(respuesta)
        cmd.ExecuteNonQuery()
        Return respuesta.Value
    End Function

    'Funcion para insertar un Gasto.
    Function AltaMovGasto(ByVal eGasto As Entidades.MovGasto) As String
        'Declaro variables
        Dim cmd As New SqlCommand
        Dim msg As String = ""
        Dim HayInternet As Boolean = Funciones.HayInternet

        'Si el Id del movimiento es 0 quiere decir que es un alta y se tiene que generar un ID
        If (eGasto.id_Movimiento = 0) Then
            eGasto.id_Movimiento = clsDatos.ObtenerCalveUnica(eGasto.id_Sucursal)
        End If

        'Si el Id del movimiento es 0 quiere decir que es un alta y se tiene que generar un ID
        If (eGasto.id_Registro = 0) Then
            eGasto.id_Registro = clsDatos.ObtenerCalveUnica(eGasto.id_Registro)
        End If

        eGasto.FechaEdicion = DateTime.Now

        Try
            cmd.Connection = clsDatos.ConectarLocal()
            msg = AltaMovGasto(eGasto, cmd)
            clsDatos.DesconectarLocal()

            If (HayInternet) Then
                cmd = New SqlCommand()
                cmd.Connection = clsDatos.ConectarRemoto()
                msg = AltaMovGasto(eGasto, cmd)
                clsDatos.DesconectarRemoto()
            End If

            'muestro el mensaje
            Return msg
        Catch ex As Exception
            Return ex.Message
        End Try
    End Function

    Private Shared Function AltaMovGasto(eGasto As Entidades.MovGasto, ByRef cmd As SqlCommand) As String
        cmd.CommandType = CommandType.StoredProcedure
        cmd.CommandText = "sp_MovGasto_Alta"
        With cmd.Parameters
            .AddWithValue("@id_Movimiento", eGasto.id_Movimiento)
            .AddWithValue("@id_Tipo", eGasto.id_Tipo)
            .AddWithValue("@id_Sucursal", eGasto.id_Sucursal)
            .AddWithValue("@id_Registro", eGasto.id_Registro)
            .AddWithValue("@Monto", eGasto.Monto)
            .AddWithValue("@Fecha", eGasto.Fecha)
            .AddWithValue("@SoloLectura", eGasto.SoloLectura)
            .AddWithValue("@Observaciones", eGasto.Observaciones)
            .AddWithValue("@FechaEdicion", eGasto.FechaEdicion)
        End With
        Dim respuesta As New SqlParameter("@msg", SqlDbType.VarChar, 255)
        respuesta.Direction = ParameterDirection.Output
        cmd.Parameters.Add(respuesta)
        cmd.ExecuteNonQuery()
        Return respuesta.Value
    End Function

    'Funcion para insertar un Egreso.
    Function AltaMovEgreso(ByVal eEgreso As Entidades.MovEgreso) As String
        'Declaro variables
        Dim cmd As New SqlCommand
        Dim msg As String = ""
        Dim HayInternet As Boolean = Funciones.HayInternet

        Try
            cmd.Connection = clsDatos.ConectarLocal()
            msg = AltaMovEgreso(eEgreso, cmd)
            clsDatos.DesconectarLocal()

            If (HayInternet) Then
                cmd = New SqlCommand()
                cmd.Connection = clsDatos.ConectarRemoto()
                msg = AltaMovEgreso(eEgreso, cmd)
                clsDatos.DesconectarRemoto()
            End If

            'muestro el mensaje
            Return msg
        Catch ex As Exception
            Return ex.Message
        End Try
    End Function

    Private Shared Function AltaMovEgreso(eEgreso As Entidades.MovEgreso, ByRef cmd As SqlCommand) As String
        cmd.CommandType = CommandType.StoredProcedure
        cmd.CommandText = "sp_MovEgreso_Alta"
        With cmd.Parameters
            .AddWithValue("@id_Movimiento", eEgreso.id_Movimiento)
            .AddWithValue("@id_MovimientoPadre", eEgreso.id_MovimientoPadre)
            .AddWithValue("@id_Tipo", eEgreso.id_Tipo)
            .AddWithValue("@id_Subtipo", eEgreso.id_Subtipo)
            .AddWithValue("@id_Sucursal", eEgreso.id_Sucursal)
            .AddWithValue("@id_SucursalDestino", eEgreso.id_SucursalDestino)
            .AddWithValue("@Monto", eEgreso.Monto)
            .AddWithValue("@Descripcion", eEgreso.Descripcion)
            .AddWithValue("@Aceptado", eEgreso.Aceptado)
            .AddWithValue("@Fecha", eEgreso.Fecha)
        End With
        Dim respuesta As New SqlParameter("@msg", SqlDbType.VarChar, 255)
        respuesta.Direction = ParameterDirection.Output
        cmd.Parameters.Add(respuesta)
        cmd.ExecuteNonQuery()
        Return respuesta.Value
    End Function

    'Obtener ID
    Function ObtenerID(ByVal Tabla As String)
        Dim ds As New DataSet

        If Funciones.HayInternet Then
            ds = clsDatos.ConsultarBaseRemoto("execute sp_Movimientos_ObtenerID @Tabla=" & Tabla)
        Else
            ds = clsDatos.ConsultarBaseLocal("execute sp_Movimientos_ObtenerID @Tabla=" & Tabla)
        End If

        If ds.Tables(0).Rows.Count > 0 Then
            If ds.Tables(0).Rows(0).Item("ID").ToString <> "" Then
                Return ds.Tables(0).Rows(0).Item("ID").ToString
            Else
                Return 0
            End If
        Else
            Return 0
        End If
    End Function

    'Function para insertar una nueva mercaderia para el egreso "mercaderias"
    Function AltaMovEgresoMercaderia(ByVal eMerca As Entidades.MovEgresoMercaderia) As String
        'Declaro variables
        Dim cmd As New SqlCommand
        Dim msg As String = ""
        Dim HayInternet As Boolean = Funciones.HayInternet
        Try
            cmd.Connection = clsDatos.ConectarLocal()
            msg = AltaMovEgresoMercaderia(eMerca, cmd)
            clsDatos.DesconectarLocal()

            If (HayInternet) Then
                cmd = New SqlCommand()
                cmd.Connection = clsDatos.ConectarRemoto()
                msg = AltaMovEgresoMercaderia(eMerca, cmd)
                clsDatos.DesconectarRemoto()
            End If

            Return msg
        Catch ex As Exception
            Return ex.Message
        End Try
    End Function

    Private Shared Function AltaMovEgresoMercaderia(eMerca As Entidades.MovEgresoMercaderia, ByRef cmd As SqlCommand) As String
        cmd.CommandType = CommandType.StoredProcedure
        cmd.CommandText = "sp_MovEgreso_AltaMercaderia"
        With cmd.Parameters
            .AddWithValue("@id_Movimiento", eMerca.id_Movimiento)
            .AddWithValue("@id_Sucursal", eMerca.id_Sucursal)
            .AddWithValue("@id_Producto", eMerca.id_Producto)
            .AddWithValue("@Nombre", eMerca.Nombre)
            .AddWithValue("@Codigo", eMerca.Codigo)
            .AddWithValue("@Costo", eMerca.Costo)
            .AddWithValue("@Cantidad", eMerca.Cantidad)
            .AddWithValue("@Subtotal", eMerca.Subtotal)
        End With
        Dim respuesta As New SqlParameter("@msg", SqlDbType.VarChar, 255)
        respuesta.Direction = ParameterDirection.Output
        cmd.Parameters.Add(respuesta)
        cmd.ExecuteNonQuery()

        Return respuesta.Value
    End Function

    'Function para insertar una nueva mercaderia para el egreso "mercaderias"
    Function EliminarMovEgresoMercaderia(ByVal id_Movimiento As Integer, ByVal id_Sucursal As Integer)
        Dim cmd As New SqlCommand
        Dim HayInternet As Boolean = Funciones.HayInternet
        Dim msg As String = ""
        Dim fechaEdicion As DateTime = DateTime.Now()

        Try
            cmd.Connection = clsDatos.ConectarLocal()
            msg = EliminarMovEgresoMercaderia(id_Movimiento, id_Sucursal, fechaEdicion, cmd)
            clsDatos.DesconectarLocal()

            If (HayInternet) Then
                cmd = New SqlCommand()
                cmd.Connection = clsDatos.ConectarRemoto()
                msg = EliminarMovEgresoMercaderia(id_Movimiento, id_Sucursal, fechaEdicion, cmd)
                clsDatos.DesconectarRemoto()
            End If

            Return msg
        Catch ex As Exception
            Return ex.Message
        End Try
    End Function

    Private Shared Function EliminarMovEgresoMercaderia(id_Movimiento As Integer, id_Sucursal As Integer, fechaEdicion As DateTime, ByRef cmd As SqlCommand) As String
        cmd.CommandType = CommandType.StoredProcedure
        cmd.CommandText = "sp_MovEgreso_EliminarMercaderia"
        With cmd.Parameters
            .AddWithValue("@id_Movimiento", id_Movimiento)
            .AddWithValue("@id_Sucursal", id_Sucursal)
            .AddWithValue("@FechaEdicion", fechaEdicion)
        End With
        Dim respuesta As New SqlParameter("@msg", SqlDbType.VarChar, 255)
        respuesta.Direction = ParameterDirection.Output
        cmd.Parameters.Add(respuesta)

        cmd.ExecuteNonQuery()
        Return respuesta.Value
    End Function

    'Function para eliminar un movimiento del sistema.
    Function EliminarMovimiento(ByVal id_Movimiento As Int64, ByVal id_Sucursal As Integer, ByVal Tipo As Integer, Optional ByVal id_Registro As Int64 = 0)
        Try
            Dim EsMercaderia As Integer = 0
            Dim HayInternet As Boolean = Funciones.HayInternet
            Dim cmd As New SqlCommand
            Dim msg As String = ""
            Dim fechaEdicion As DateTime = DateTime.Now()

            'Si es un egreso.
            If Tipo = 2 Then

                'Averiguo que movimiento es.
                Dim DsMovimiento As New DataSet
                DsMovimiento = ObtenerMov(id_Movimiento, id_Sucursal, "Egreso")

                Dim id_Tipo As String = DsMovimiento.Tables(0).Rows(0).Item("id_Tipo").ToString

                'Si es mercaderia, hago un rollback del stock
                If id_Tipo = "19" Then

                    EsMercaderia = 1
                    Dim dsMercaderias As New DataSet
                    Dim NStock As New NegStock
                    Dim SucuOrigen As Integer = CInt(DsMovimiento.Tables(0).Rows(0).Item("id_Sucursal"))
                    Dim SucuDestino As Integer = CInt(DsMovimiento.Tables(0).Rows(0).Item("id_SucursalDestino"))

                    'Aumento el stock de la sucursal Origen.
                    dsMercaderias = ObtenerMovEgresoMercaderias(id_Movimiento, SucuOrigen)
                    If dsMercaderias IsNot Nothing Then
                        If dsMercaderias.Tables(0).Rows.Count > 0 Then
                            For Each prod In dsMercaderias.Tables(0).Rows
                                NStock.AgregarStock(prod.item("id_Producto"), SucuOrigen, prod.item("Cantidad"))
                            Next
                        End If
                    End If

                    'Disminuyo el stock de la sucursal destino si se acepto el envio.
                    If dsMercaderias IsNot Nothing And DsMovimiento.Tables(0).Rows(0).Item("Aceptado") = 1 Then
                        If dsMercaderias.Tables(0).Rows.Count > 0 Then
                            For Each prod In dsMercaderias.Tables(0).Rows
                                NStock.DisminuirStock(prod.item("id_Producto"), prod.item("Cantidad"), SucuDestino)
                            Next
                        End If
                    End If

                End If
            End If

            cmd = New SqlCommand()
            cmd.Connection = clsDatos.ConectarLocal()
            msg = EliminarMovimiento(id_Movimiento, id_Sucursal, Tipo, id_Registro, EsMercaderia, fechaEdicion, cmd)
            clsDatos.DesconectarLocal()

            If HayInternet Then
                cmd = New SqlCommand()
                cmd.Connection = clsDatos.ConectarRemoto()
                msg = EliminarMovimiento(id_Movimiento, id_Sucursal, Tipo, id_Registro, EsMercaderia, fechaEdicion, cmd)
                clsDatos.DesconectarRemoto()
            End If

            Return msg
        Catch ex As Exception
            Return ex.Message
        End Try
    End Function

    Private Function EliminarMovimiento(id_Movimiento As Int64, id_Sucursal As Integer, Tipo As Integer, id_Registro As Int64, EsMercaderia As Integer, fechaEdicion As DateTime, ByRef cmd As SqlCommand) As String
        cmd.CommandType = CommandType.StoredProcedure
        cmd.CommandText = "sp_Movimientos_Eliminar"
        With cmd.Parameters
            .AddWithValue("@id_Movimiento", id_Movimiento)
            .AddWithValue("@id_Registro", id_Registro)
            .AddWithValue("@id_Sucursal", id_Sucursal)
            .AddWithValue("@EsMercaderia", EsMercaderia)
            .AddWithValue("@Tipo", Tipo)
            .AddWithValue("@FechaEdicion", fechaEdicion)
        End With
        Dim respuesta As New SqlParameter("@msg", SqlDbType.VarChar, 255)
        respuesta.Direction = ParameterDirection.Output
        cmd.Parameters.Add(respuesta)
        cmd.ExecuteNonQuery()
        Return respuesta.Value
    End Function

    'Obtener un listado de Dif. de Caja.
    Function ObtenerMovCaja(ByVal id_Sucursal As Integer, ByVal Anio As Integer, ByVal Mes As Integer)
        Dim ds As New DataSet
        If Funciones.HayInternet Then
            ds = clsDatos.ConsultarBaseRemoto("execute sp_MovCaja_Obtener @id_Sucursal=" & id_Sucursal & ", @Anio=" & Anio & ", @Mes=" & Mes)
        Else
            ds = clsDatos.ConsultarBaseLocal("execute sp_MovCaja_Obtener @id_Sucursal=" & id_Sucursal & ", @Anio=" & Anio & ", @Mes=" & Mes)
        End If
        Return ds
    End Function

    Function ObtenerDifCaja(ByVal id_Sucursal As Integer, ByVal FDesde As String, ByVal FHasta As String)
        Dim ds As New DataSet
        If Funciones.HayInternet Then
            ds = clsDatos.ConsultarBaseRemoto("execute sp_MovDiferencia_Obtener @id_Sucursal=" & id_Sucursal & ", @FDesde='" & FDesde & "', @FHasta='" & FHasta & "'")
        Else
            ds = clsDatos.ConsultarBaseLocal("execute sp_MovDiferencia_Obtener @id_Sucursal=" & id_Sucursal & ", @FDesde='" & FDesde & "', @FHasta='" & FHasta & "'")
        End If
        Return ds
    End Function

    'Obtener un listado de Caja Fuerte.
    Function ObtenerMovCajaFuerte(ByVal id_Sucursal As Integer, ByVal Anio As Integer, ByVal Mes As Integer)
        Dim ds As New DataSet
        If Funciones.HayInternet Then
            ds = clsDatos.ConsultarBaseRemoto("execute sp_MovCajaFuerte_Obtener @id_Sucursal=" & id_Sucursal & ", @Anio=" & Anio & ", @Mes=" & Mes)
        Else
            ds = clsDatos.ConsultarBaseLocal("execute sp_MovCajaFuerte_Obtener @id_Sucursal=" & id_Sucursal & ", @Anio=" & Anio & ", @Mes=" & Mes)
        End If
        Return ds
    End Function

    'Obtengo el monto total de un determinado rango de fechas.
    Function ObtenerTotalMovCaja(ByVal id_Sucursal As Integer, ByVal FDesde As String, ByVal FHasta As String, ByVal Tipo As String) As Double
        Dim ds As New DataSet
        If Funciones.HayInternet Then
            ds = clsDatos.ConsultarBaseRemoto("execute sp_MovCaja_ObtenerTotal @id_Sucursal=" & id_Sucursal & ", @FDesde='" & FDesde & "', @FHasta='" & FHasta & "', @Tipo='" & Tipo & "'")
        Else
            ds = clsDatos.ConsultarBaseLocal("execute sp_MovCaja_ObtenerTotal @id_Sucursal=" & id_Sucursal & ", @FDesde='" & FDesde & "', @FHasta='" & FHasta & "', @Tipo='" & Tipo & "'")
        End If

        If ds.Tables(0).Rows.Count = 1 And ds.Tables(0).Rows(0).Item("Suma").ToString <> "" Then
            Return ds.Tables(0).Rows(0).Item("Suma").ToString
        Else
            Return 0
        End If
    End Function

    'Obtengo el monto total de un determinado rango de fechas.
    Function ObtenerTotalMovCajaFuerte(ByVal id_Sucursal As Integer, ByVal FDesde As String, ByVal FHasta As String, ByVal Tipo As Integer) As Double
        Dim ds As New DataSet
        If Funciones.HayInternet Then
            ds = clsDatos.ConsultarBaseRemoto("execute sp_MovCajaFuerte_ObtenerTotal @id_Sucursal=" & id_Sucursal & ", @FDesde='" & FDesde & "', @FHasta='" & FHasta & "', @Tipo='" & Tipo & "'")
        Else
            ds = clsDatos.ConsultarBaseLocal("execute sp_MovCajaFuerte_ObtenerTotal @id_Sucursal=" & id_Sucursal & ", @FDesde='" & FDesde & "', @FHasta='" & FHasta & "', @Tipo='" & Tipo & "'")
        End If

        If ds.Tables(0).Rows.Count = 1 And ds.Tables(0).Rows(0).Item("Suma").ToString <> "" Then
            Return ds.Tables(0).Rows(0).Item("Suma").ToString
        Else
            Return 0
        End If
    End Function

    'Obtengo el monto total de un determinado rango de fechas.
    Function ObtenerTotalMovEgreso(ByVal id_Sucursal As Integer, ByVal FDesde As String, ByVal FHasta As String, ByVal Tipo As String) As Double
        Dim ds As New DataSet
        If Funciones.HayInternet Then
            ds = clsDatos.ConsultarBaseRemoto("execute sp_MovEgreso_ObtenerTotal @id_Sucursal=" & id_Sucursal & ", @FDesde='" & FDesde & "', @FHasta='" & FHasta & "', @Tipo='" & Tipo & "'")
        Else
            ds = clsDatos.ConsultarBaseLocal("execute sp_MovEgreso_ObtenerTotal @id_Sucursal=" & id_Sucursal & ", @FDesde='" & FDesde & "', @FHasta='" & FHasta & "', @Tipo='" & Tipo & "'")
        End If

        If ds.Tables(0).Rows.Count = 1 And ds.Tables(0).Rows(0).Item("Suma").ToString <> "" Then
            Return ds.Tables(0).Rows(0).Item("Suma").ToString
        Else
            Return 0
        End If
    End Function

    'Obtener un listado de Gastos.
    Function ObtenerMovGasto(ByVal id_Sucursal As Integer, ByVal Anio As Integer, ByVal Mes As Integer)
        Dim ds As New DataSet
        If Funciones.HayInternet Then
            ds = clsDatos.ConsultarBaseRemoto("execute sp_MovGasto_Obtener @id_Sucursal=" & id_Sucursal & ", @Anio=" & Anio & ", @Mes=" & Mes)
        Else
            ds = clsDatos.ConsultarBaseLocal("execute sp_MovGasto_Obtener @id_Sucursal=" & id_Sucursal & ", @Anio=" & Anio & ", @Mes=" & Mes)
        End If
        Return ds
    End Function

    'Obtener un listado de Impuestos.
    Function ObtenerMovImpuesto(ByVal id_Sucursal As Integer, ByVal Anio As Integer, ByVal Mes As Integer)
        Dim ds As New DataSet
        If Funciones.HayInternet Then
            ds = clsDatos.ConsultarBaseRemoto("execute sp_MovImpuesto_Obtener @id_Sucursal=" & id_Sucursal & ", @Anio=" & Anio & ", @Mes=" & Mes)
        Else
            ds = clsDatos.ConsultarBaseLocal("execute sp_MovImpuesto_Obtener @id_Sucursal=" & id_Sucursal & ", @Anio=" & Anio & ", @Mes=" & Mes)
        End If
        Return ds
    End Function

    'Obtener un listado de Impuestos.
    Function ObtenerMovImpuestoFecha(ByVal id_Sucursal As Integer, ByVal FDesde As String, ByVal FHasta As String)
        Dim ds As New DataSet
        If Funciones.HayInternet Then
            ds = clsDatos.ConsultarBaseRemoto("execute sp_MovImpuesto_ObtenerPorFecha @id_Sucursal=" & id_Sucursal & ", @FDesde='" & FDesde & "', @FHasta='" & FHasta & "'")
        Else
            ds = clsDatos.ConsultarBaseLocal("execute sp_MovImpuesto_ObtenerPorFecha @id_Sucursal=" & id_Sucursal & ", @FDesde='" & FDesde & "', @FHasta='" & FHasta & "'")
        End If
        Return ds
    End Function

    'Obtener un listado de Gastos por rango de fechas.
    Function ObtenerMovGastoFecha(ByVal id_Sucursal As Integer, ByVal FDesde As String, ByVal FHasta As String)
        Dim ds As New DataSet
        If Funciones.HayInternet Then
            ds = clsDatos.ConsultarBaseRemoto("execute sp_MovGasto_ObtenerPorFecha @id_Sucursal=" & id_Sucursal & ", @FDesde='" & FDesde & "', @FHasta='" & FHasta & "'")
        Else
            ds = clsDatos.ConsultarBaseLocal("execute sp_MovGasto_ObtenerPorFecha @id_Sucursal=" & id_Sucursal & ", @FDesde='" & FDesde & "', @FHasta='" & FHasta & "'")
        End If
        Return ds
    End Function

    'Obtener un listado de Retiros de socios por rango de fechas.
    Function ObtenerMovRetiroFecha(ByVal id_Sucursal As Integer, ByVal FDesde As String, ByVal FHasta As String)
        Dim ds As New DataSet
        If Funciones.HayInternet Then
            ds = clsDatos.ConsultarBaseRemoto("execute sp_MovRetiro_ObtenerPorFecha @id_Sucursal=" & id_Sucursal & ", @FDesde='" & FDesde & "', @FHasta='" & FHasta & "'")
        Else
            ds = clsDatos.ConsultarBaseLocal("execute sp_MovRetiro_ObtenerPorFecha @id_Sucursal=" & id_Sucursal & ", @FDesde='" & FDesde & "', @FHasta='" & FHasta & "'")
        End If
        Return ds
    End Function

    'Obtener un listado de Retiros de socios por rango de fechas.
    Function ObtenerMovAporteFecha(ByVal id_Sucursal As Integer, ByVal FDesde As String, ByVal FHasta As String)
        Dim ds As New DataSet
        If Funciones.HayInternet Then
            ds = clsDatos.ConsultarBaseRemoto("execute sp_MovAporte_ObtenerPorFecha @id_Sucursal=" & id_Sucursal & ", @FDesde='" & FDesde & "', @FHasta='" & FHasta & "'")
        Else
            ds = clsDatos.ConsultarBaseLocal("execute sp_MovAporte_ObtenerPorFecha @id_Sucursal=" & id_Sucursal & ", @FDesde='" & FDesde & "', @FHasta='" & FHasta & "'")
        End If
        Return ds
    End Function

    'Obtener un listado de diferencias de caja por rango de fechas.
    Function ObtenerMovCajaFecha(ByVal id_Sucursal As Integer, ByVal FDesde As String, ByVal FHasta As String, ByVal Tipo As Integer)
        Dim ds As New DataSet
        If Funciones.HayInternet Then
            ds = clsDatos.ConsultarBaseRemoto("execute sp_MovCaja_ObtenerPorFecha @id_Sucursal=" & id_Sucursal & ", @FDesde='" & FDesde & "', @FHasta='" & FHasta & "'" & ", @Tipo=" & Tipo)
        Else
            ds = clsDatos.ConsultarBaseLocal("execute sp_MovCaja_ObtenerPorFecha @id_Sucursal=" & id_Sucursal & ", @FDesde='" & FDesde & "', @FHasta='" & FHasta & "'" & ", @Tipo=" & Tipo)
        End If
        Return ds
    End Function

    'Obtener un listado de efectivos por rango de fechas.
    Function ObtenerMovEgresoFecha(ByVal id_Sucursal As Integer, ByVal FDesde As String, ByVal FHasta As String, ByVal Tipo As String)
        Dim ds As New DataSet
        If Funciones.HayInternet Then
            ds = clsDatos.ConsultarBaseRemoto("execute sp_MovEgreso_ObtenerPorFecha @id_Sucursal=" & id_Sucursal & ", @FDesde='" & FDesde & "', @FHasta='" & FHasta & "'" & ", @Tipo=" & Tipo)
        Else
            ds = clsDatos.ConsultarBaseLocal("execute sp_MovEgreso_ObtenerPorFecha @id_Sucursal=" & id_Sucursal & ", @FDesde='" & FDesde & "', @FHasta='" & FHasta & "'" & ", @Tipo=" & Tipo)
        End If
        Return ds
    End Function

    'Obtener un listado de Egresos.
    Function ObtenerMovEgreso(ByVal id_Sucursal As Integer, ByVal Anio As Integer, ByVal Mes As Integer)
        Dim ds As New DataSet
        If Funciones.HayInternet Then
            ds = clsDatos.ConsultarBaseRemoto("execute sp_MovEgreso_Obtener @id_Sucursal=" & id_Sucursal & ", @Anio=" & Anio & ", @Mes=" & Mes)
        Else
            ds = clsDatos.ConsultarBaseLocal("execute sp_MovEgreso_Obtener @id_Sucursal=" & id_Sucursal & ", @Anio=" & Anio & ", @Mes=" & Mes)
        End If
        Return ds
    End Function

    'Obtener un listado de Egresos por sucursal.
    Function ObtenerMovEgresoPorSucursal(ByVal id_Sucursal As Integer)
        Dim ds As New DataSet
        If Funciones.HayInternet Then
            ds = clsDatos.ConsultarBaseRemoto("execute sp_MovEgreso_ObtenerPorSucursal @id_Sucursal=" & id_Sucursal)
        Else
            ds = clsDatos.ConsultarBaseLocal("execute sp_MovEgreso_ObtenerPorSucursal @id_Sucursal=" & id_Sucursal)
        End If
        Return ds
    End Function

    'Obtener un listado de Egresos por sucursal destino.
    Function ObtenerMovEgresoPorSucursalDestino(ByVal id_Sucursal As Integer, ByVal id_SucursalDestino As Integer)
        Dim ds As New DataSet
        If Funciones.HayInternet Then
            ds = clsDatos.ConsultarBaseRemoto("execute sp_MovEgreso_ObtenerPorSucursalDestino @id_Sucursal=" & id_Sucursal & ", @id_SucursalDestino=" & id_SucursalDestino)
        Else
            ds = clsDatos.ConsultarBaseLocal("execute sp_MovEgreso_ObtenerPorSucursalDestino @id_Sucursal=" & id_Sucursal & ",  @id_SucursalDestino=" & id_SucursalDestino)
        End If
        Return ds
    End Function

    'Obtener un listado de Retiro de Socio.
    Function ObtenerMovRetiro(ByVal id_Sucursal As Integer, ByVal Anio As Integer, ByVal Mes As Integer)
        Dim ds As New DataSet
        If Funciones.HayInternet Then
            ds = clsDatos.ConsultarBaseRemoto("execute sp_MovRetiro_Obtener @id_Sucursal=" & id_Sucursal & ", @Anio=" & Anio & ", @Mes=" & Mes)
        Else
            ds = clsDatos.ConsultarBaseLocal("execute sp_MovRetiro_Obtener @id_Sucursal=" & id_Sucursal & ", @Anio=" & Anio & ", @Mes=" & Mes)
        End If
        Return ds
    End Function

    'Obtener un listado de Aporte de Socio.
    Function ObtenerMovAporte(ByVal id_Sucursal As Integer, ByVal Anio As Integer, ByVal Mes As Integer)
        Dim ds As New DataSet
        If Funciones.HayInternet Then
            ds = clsDatos.ConsultarBaseRemoto("execute sp_MovAporte_Obtener @id_Sucursal=" & id_Sucursal & ", @Anio=" & Anio & ", @Mes=" & Mes)
        Else
            ds = clsDatos.ConsultarBaseLocal("execute sp_MovAporte_Obtener @id_Sucursal=" & id_Sucursal & ", @Anio=" & Anio & ", @Mes=" & Mes)
        End If
        Return ds
    End Function

    'Obtener un movimiento determinado.
    Function ObtenerMov(ByVal id_Movimiento As Int64, ByVal id_sucursal As Integer, ByVal Tipo As String)
        Dim ds As New DataSet
        If Funciones.HayInternet Then
            ds = clsDatos.ConsultarBaseRemoto("execute sp_Mov_ObtenerDetalle @id_Movimiento=" & id_Movimiento & ", @id_sucursal=" & id_sucursal & ", @Tipo=" & Tipo)
        Else
            ds = clsDatos.ConsultarBaseLocal("execute sp_Mov_ObtenerDetalle @id_Movimiento=" & id_Movimiento & ", @id_sucursal=" & id_sucursal & ", @Tipo=" & Tipo)
        End If
        Return ds
    End Function

    Function ObtenerMovDestino(ByVal id_Movimiento As Integer, ByVal id_sucursal As Integer, ByVal Tipo As String)
        Dim ds As New DataSet
        If Funciones.HayInternet Then
            ds = clsDatos.ConsultarBaseRemoto("execute sp_Mov_ObtenerDestinoDetalle @id_Movimiento=" & id_Movimiento & ", @id_sucursal=" & id_sucursal & ", @Tipo=" & Tipo)
        Else
            ds = clsDatos.ConsultarBaseLocal("execute sp_Mov_ObtenerDestinoDetalle @id_Movimiento=" & id_Movimiento & ", @id_sucursal=" & id_sucursal & ", @Tipo=" & Tipo)
        End If
        Return ds
    End Function


    'Obtener un movimiento determinado.
    Function ObtenerMovEgresoDetalle(ByVal id_Movimiento As Integer, ByVal id_sucursal As Integer, ByVal id_sucursalDestino As Integer)
        Dim ds As New DataSet
        If Funciones.HayInternet Then
            ds = clsDatos.ConsultarBaseRemoto("execute sp_MovEgreso_Detalle @id_Movimiento=" & id_Movimiento & ", @id_sucursal=" & id_sucursal & ", @id_sucursalDestino=" & id_sucursalDestino)
        Else
            ds = clsDatos.ConsultarBaseLocal("execute sp_MovEgreso_Detalle @id_Movimiento=" & id_Movimiento & ", @id_sucursal=" & id_sucursal & ", @id_sucursalDestino=" & id_sucursalDestino)
        End If
        Return ds
    End Function

    'Obtiene los productos de un egreso tipo mercaderias.
    Function ObtenerMovEgresoMercaderias(ByVal id_Movimiento As Integer, ByVal id_sucursal As Integer)
        Dim ds As New DataSet
        If Funciones.HayInternet Then
            ds = clsDatos.ConsultarBaseRemoto("execute sp_MovEgreso_ObtenerMercaderia @id_Movimiento=" & id_Movimiento & ", @id_sucursal=" & id_sucursal)
        Else
            ds = clsDatos.ConsultarBaseLocal("execute sp_MovEgreso_ObtenerMercaderia @id_Movimiento=" & id_Movimiento & ", @id_sucursal=" & id_sucursal)
        End If
        Return ds
    End Function

    'Obtener notificaciones.
    Function ObtenerNotificaciones(ByVal id_Sucursal As Integer)
        Dim ds As New DataSet
        If Funciones.HayInternet Then
            ds = clsDatos.ConsultarBaseRemoto("execute sp_Movimientos_ObtenerNuevos @id_Sucursal=" & id_Sucursal)
            If ds.Tables(0).Rows.Count > 0 Then
                If ds.Tables(0).Rows(0).Item("Total").ToString <> "" Then
                    Return CInt(ds.Tables(0).Rows(0).Item("Total"))
                Else
                    Return 0
                End If
            Else
                Return 0
            End If
        Else
            Return 0
        End If
    End Function

    'Obtener listado de notificaciones.
    Function ObtenerListadoNotificaciones(ByVal id_Sucursal As Integer)
        Dim ds As New DataSet
        If Funciones.HayInternet Then
            ds = clsDatos.ConsultarBaseRemoto("execute sp_Movimientos_ObtenerListadoNuevos @id_Sucursal=" & id_Sucursal)
        Else
            ds = clsDatos.ConsultarBaseLocal("execute sp_Movimientos_ObtenerListadoNuevos @id_Sucursal=" & id_Sucursal)
        End If
        Return ds
    End Function

    'Obtener la relacion entre egresos y gastos
    Function ObtenerRelacionEgresosGastos() As DataSet
        Dim ds As New DataSet
        If Funciones.HayInternet Then
            ds = clsDatos.ConsultarBaseRemoto("execute sp_Movimientos_Obtener_Relacion_Egresos_Gastos")
        Else
            ds = clsDatos.ConsultarBaseLocal("execute sp_Movimientos_Obtener_Relacion_Egresos_Gastos")
        End If
        Return ds
    End Function

    'Acepta un movimiento determinado.
    Function AceptarMovimiento(ByVal id_Movimiento As Integer, ByVal id_Tipo As Integer, ByVal id_Subtipo As Integer, ByVal id_Sucursal As Integer, ByVal id_SucursalConect As Integer, Monto As Decimal) As Boolean
        Dim cmd As New SqlCommand
        Dim msg As Boolean
        Dim HayInternet As Boolean = Funciones.HayInternet
        Try
            cmd.Connection = clsDatos.ConectarLocal()
            msg = AceptarMovimineto(id_Movimiento, id_SucursalConect, cmd)
            clsDatos.DesconectarLocal()

            If HayInternet Then
                cmd = New SqlCommand
                cmd.Connection = clsDatos.ConectarRemoto()
                msg = AceptarMovimineto(id_Movimiento, id_SucursalConect, cmd)
                clsDatos.DesconectarRemoto()
            End If

            'Si es mercadería la que envio manejo los stocks
            If id_Tipo = 19 Then
                'Instancias.
                Dim NStock As New NegStock
                Dim dsMercaderias As New DataSet

                'Disminuyo el stock de la sucursal.
                dsMercaderias = ObtenerMovEgresoMercaderias(id_Movimiento, id_Sucursal)

                'Aumento el stock de la sucursal Destino.
                If dsMercaderias IsNot Nothing Then
                    If dsMercaderias.Tables(0).Rows.Count > 0 Then
                        For Each prod In dsMercaderias.Tables(0).Rows
                            NStock.AgregarStock(prod.item("id_Producto"), id_SucursalConect, prod.item("Cantidad"))
                        Next
                    End If
                End If

                'genero un gasto negativo en la sucursal origen
                Dim eGasto As Entidades.MovGasto = New Entidades.MovGasto()
                eGasto.id_Movimiento = 0
                eGasto.id_Registro = 0
                eGasto.id_Sucursal = id_Sucursal
                eGasto.id_Tipo = 20
                eGasto.Fecha = Now
                eGasto.Monto = -Monto
                eGasto.Observaciones = "Gasto por movimiento de mercadería entre sucursales."
                eGasto.SoloLectura = True

                AltaMovGasto(eGasto)

                'genero un gasto positivo en la sucursal destino
                eGasto.id_Movimiento = 0
                eGasto.id_Registro = 0
                eGasto.id_Sucursal = id_SucursalConect
                eGasto.id_Tipo = 20
                eGasto.Fecha = Now
                eGasto.Monto = Monto
                eGasto.Observaciones = "Gasto por movimiento de mercadería entre sucursales."
                eGasto.SoloLectura = True

                AltaMovGasto(eGasto)

            End If

            'Si es mobimiento de bienes
            If id_Tipo = 18 Then
                Dim Relaciones As DataSet = ObtenerRelacionEgresosGastos()
                Dim Relacio = Relaciones.Tables(0).AsEnumerable.Where(Function(x) x.Field(Of Integer)("id_TipoEgreso") = id_Subtipo).FirstOrDefault()
                'genero un gasto negativo en la sucursal origen
                Dim eGasto As Entidades.MovGasto = New Entidades.MovGasto()
                eGasto.id_Movimiento = 0
                eGasto.id_Registro = 0
                eGasto.id_Sucursal = id_Sucursal
                eGasto.id_Tipo = Relacio("id_TipoGasto")
                eGasto.Fecha = Now
                eGasto.Monto = -Monto
                eGasto.Observaciones = "Gasto por movimiento de mercadería entre sucursales."
                eGasto.SoloLectura = True

                AltaMovGasto(eGasto)

                'genero un gasto positivo en la sucursal destino
                eGasto.id_Movimiento = 0
                eGasto.id_Registro = 0
                eGasto.id_Sucursal = id_SucursalConect
                eGasto.id_Tipo = Relacio("id_TipoGasto")
                eGasto.Fecha = Now
                eGasto.Monto = Monto
                eGasto.Observaciones = "Gasto por movimiento de mercadería entre sucursales."
                eGasto.SoloLectura = True

                AltaMovGasto(eGasto)
            End If

            Return msg
        Catch ex As Exception
            Return False
        End Try
    End Function

    Private Shared Function AceptarMovimineto(id_Movimiento As Integer, id_SucursalConect As Integer, ByRef cmd As SqlCommand) As Boolean
        'Cargo y ejecuto el stored.
        cmd.CommandType = CommandType.StoredProcedure
        cmd.CommandText = "sp_Movimientos_AceptarNuevo"
        With cmd.Parameters
            .AddWithValue("@id_Movimiento", id_Movimiento)
            .AddWithValue("@id_Sucursal", id_SucursalConect)
        End With

        'Respuesta del stored.
        Dim respuesta As New SqlParameter("@msg", SqlDbType.Bit, 1)
        respuesta.Direction = ParameterDirection.Output
        cmd.Parameters.Add(respuesta)
        cmd.ExecuteNonQuery()
        Return CBool(respuesta.Value)
    End Function

    'Rechaza un movimiento determinado.
    Function RechazarMovimiento(ByVal id_Movimiento As Integer, ByVal id_Tipo As Integer, ByVal id_Sucursal As Integer, ByVal id_SucursalConect As Integer) As Boolean
        Dim cmd As New SqlCommand
        Dim HayInternet As Boolean = Funciones.HayInternet
        Dim msg As Boolean
        Try
            cmd.Connection = clsDatos.ConectarLocal()
            msg = RechazarMovimiento(id_Movimiento, id_Sucursal, id_SucursalConect, cmd)
            clsDatos.DesconectarLocal()

            If HayInternet Then
                cmd = New SqlCommand()
                cmd.Connection = clsDatos.ConectarRemoto()
                msg = RechazarMovimiento(id_Movimiento, id_Sucursal, id_SucursalConect, cmd)
                clsDatos.DesconectarLocal()
            End If

            'Si es mercadería la que envio manejo los stocks
            If id_Tipo = 19 Then
                'Instancias.
                Dim NStock As New NegStock
                Dim dsMercaderias As New DataSet

                'Aumento el stock de la sucursal Origen.
                dsMercaderias = ObtenerMovEgresoMercaderias(id_Movimiento, id_Sucursal)
                If dsMercaderias IsNot Nothing Then
                    If dsMercaderias.Tables(0).Rows.Count > 0 Then
                        For Each prod In dsMercaderias.Tables(0).Rows
                            NStock.AgregarStock(prod.item("id_Producto"), prod.item("id_Sucursal"), prod.item("Cantidad"))
                        Next
                    End If
                End If
            End If

            Return msg
        Catch ex As Exception
            Return False
        End Try
    End Function

    Private Shared Function RechazarMovimiento(id_Movimiento As Integer, id_Sucursal As Integer, id_SucursalConect As Integer, ByRef cmd As SqlCommand) As Boolean
        'Cargo y ejecuto el stored.
        cmd.CommandType = CommandType.StoredProcedure
        cmd.CommandText = "sp_Movimientos_RechazarNuevo"
        With cmd.Parameters
            .AddWithValue("@id_Movimiento", id_Movimiento)
            .AddWithValue("@id_Sucursal", id_Sucursal)
            .AddWithValue("@id_SucursalDestino", id_SucursalConect)
        End With
        Dim respuesta As New SqlParameter("@msg", SqlDbType.Bit, 1)
        respuesta.Direction = ParameterDirection.Output
        cmd.Parameters.Add(respuesta)
        cmd.ExecuteNonQuery()
        Return CBool(respuesta.Value)
    End Function
End Class