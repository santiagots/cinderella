Imports System.Data.SqlClient
Public Class NegCajaInicial
    Dim clsDatos As New Datos.Conexion
    Dim ClsFunciones As New Funciones

    'Funcion para obtener la caja de un terminado dia.
    Function ObtenerCaja(ByVal id_Sucursal As Integer, ByVal Fecha As String) As Entidades.CajaInicial
        Dim ds As New DataSet
        Dim entCaja As New Entidades.CajaInicial

        If Funciones.HayInternet Then
            ds = clsDatos.ConsultarBaseRemoto("execute sp_CajaInicial_Obtener @id_Sucursal=" & id_Sucursal & ", @Fecha='" & Fecha & "'")
        Else
            ds = clsDatos.ConsultarBaseLocal("execute sp_CajaInicial_Obtener @id_Sucursal=" & id_Sucursal & ", @Fecha='" & Fecha & "'")
        End If

        'lleno la entidad.
        If ds.Tables(0).Rows.Count > 0 Then
            entCaja = ObtenerCajaFromDataRow(ds.Tables(0).Rows(0), entCaja)
        End If

        Return entCaja
    End Function

    'Funcion para obtener la caja de un terminado dia.
    Function ObtenerUltimaCaja(ByVal id_Sucursal As Integer) As Entidades.CajaInicial
        Dim ds As New DataSet
        Dim entCaja As New Entidades.CajaInicial

        If Funciones.HayInternet Then
            ds = clsDatos.ConsultarBaseRemoto("execute sp_CajaInicial_Ultima @id_Sucursal=" & id_Sucursal)
        Else
            ds = clsDatos.ConsultarBaseLocal("execute sp_CajaInicial_Ultima @id_Sucursal=" & id_Sucursal)
        End If

        'lleno la entidad.
        If ds.Tables(0).Rows.Count > 0 Then
            entCaja = ObtenerCajaFromDataRow(ds.Tables(0).Rows(0), entCaja)
        End If

        Return entCaja
    End Function

    'Funcion que inserta un nuevo registro en la tabla CAJA_INICIAL.
    Public Function CerrarCaja(ByVal EntCaja As Entidades.CajaInicial, sucursal As Integer) As Boolean
        'Declaro variables
        Dim cmd As New SqlCommand
        Dim resultadoOk As Boolean
        Dim HayInternet As Boolean = Funciones.HayInternet
        Try
            EntCaja.id_Caja = clsDatos.ObtenerCalveUnica(sucursal)
            EntCaja.FechaEdicion = DateTime.Now

            cmd.Connection = clsDatos.ConectarLocal()
            resultadoOk = CerrarCaja(EntCaja, cmd)
            clsDatos.DesconectarLocal()

            If Not resultadoOk Then
                Throw New Exception("No se ha podido cerrar la caja en la base local.")
            End If


            If HayInternet Then
                cmd = New SqlCommand()
                cmd.Connection = clsDatos.ConectarRemoto()
                resultadoOk = CerrarCaja(EntCaja, cmd)
                clsDatos.DesconectarRemoto()

                If Not resultadoOk Then
                    Throw New Exception("No se ha podido cerrar la caja en la base remota.")
                End If

            End If

            'retorno valor
            Return resultadoOk
        Catch ex As Exception
            Return False
        End Try
    End Function

    Private Shared Function CerrarCaja(EntCaja As Entidades.CajaInicial, ByRef cmd As SqlCommand) As Boolean
        'Cargo y ejecuto el stored.
        cmd.CommandType = CommandType.StoredProcedure
        cmd.CommandText = "sp_CajaInicial_Alta"
        With cmd.Parameters
            .AddWithValue("@id_Caja", EntCaja.id_Caja)
            .AddWithValue("@id_Movimiento", EntCaja.id_Movimiento)
            .AddWithValue("@id_Empleado", EntCaja.id_Empleado)
            .AddWithValue("@id_Sucursal", EntCaja.id_Sucursal)
            .AddWithValue("@Abierta", EntCaja.Abierta)
            .AddWithValue("@Empleado", EntCaja.Empleado)
            .AddWithValue("@Fecha", EntCaja.Fecha)
            .AddWithValue("@Hora", EntCaja.Hora)
            .AddWithValue("@Monto", EntCaja.Monto)
            .AddWithValue("@FechaEdicion", EntCaja.FechaEdicion)
        End With
        Dim respuesta As New SqlParameter("@msg", SqlDbType.Int, 255)
        respuesta.Direction = ParameterDirection.Output
        cmd.Parameters.Add(respuesta)
        cmd.ExecuteNonQuery()
        Return CInt(respuesta.Value)
    End Function

    'Funcion que inserta un nuevo registro en la tabla CAJA_INICIAL.
    Public Function AbrirCaja(ByVal id_Sucursal As Integer, ByVal Fecha As String) As Boolean
        'Declaro variables
        Dim cmd As New SqlCommand
        Dim resultadoOk As Boolean
        Dim HayInternet As Boolean = Funciones.HayInternet

        Try
            Dim FechaEdicion As DateTime = DateTime.Now

            cmd.Connection = clsDatos.ConectarLocal()
            resultadoOk = AbrirCaja(id_Sucursal, Fecha, FechaEdicion, cmd)
            clsDatos.DesconectarLocal()

            If Not resultadoOk Then
                Throw New Exception("No se ha podido abrir la caja en la base local.")
            End If

            'Conecto a la bdd.
            If HayInternet Then
                cmd = New SqlCommand()
                cmd.Connection = clsDatos.ConectarRemoto()
                resultadoOk = AbrirCaja(id_Sucursal, Fecha, FechaEdicion, cmd)
                clsDatos.DesconectarRemoto()

                If Not resultadoOk Then
                    Throw New Exception("No se ha podido abrir la caja en la base remota.")
                End If
            End If

            'retorno valor
            Return resultadoOk
        Catch ex As Exception
            Return False
        End Try
    End Function

    Private Shared Function AbrirCaja(id_Sucursal As Integer, Fecha As String, FechaEdicion As DateTime, ByRef cmd As SqlCommand) As Boolean

        'Cargo y ejecuto el stored.
        cmd.CommandType = CommandType.StoredProcedure
        cmd.CommandText = "sp_CajaInicial_Baja"
        With cmd.Parameters
            .AddWithValue("@id_Sucursal", id_Sucursal)
            .AddWithValue("@Fecha", Fecha)
            .AddWithValue("@FechaEdicion", Fecha)
        End With
        Dim respuesta As New SqlParameter("@msg", SqlDbType.Bit, 1)
        respuesta.Direction = ParameterDirection.Output
        cmd.Parameters.Add(respuesta)
        cmd.ExecuteNonQuery()

        Return CInt(respuesta.Value)
    End Function

    'Funcion que actualiza un registro en la tabla CAJA_INICIAL.
    Public Function ActualizarCaja(ByVal EntCaja As Entidades.CajaInicial) As Integer
        'Declaro variables
        Dim cmd As New SqlCommand
        Dim msg As String = ""
        Dim HayInternet As Boolean = Funciones.HayInternet

        Try
            'Conecto a la bdd.
            If HayInternet Then
                cmd.Connection = clsDatos.ConectarRemoto()
            Else
                cmd.Connection = clsDatos.ConectarLocal()
            End If

            'Cargo y ejecuto el stored.
            cmd.CommandType = CommandType.StoredProcedure
            cmd.CommandText = "sp_CajaInicial_Actualizar"
            With cmd.Parameters
                .AddWithValue("@id_Caja", EntCaja.id_Caja)
                .AddWithValue("@Abierta", EntCaja.Abierta)
                .AddWithValue("@id_Empleado", EntCaja.id_Empleado)
                .AddWithValue("@Empleado", EntCaja.Empleado)
                .AddWithValue("@id_Sucursal", EntCaja.id_Sucursal)
                .AddWithValue("@Monto", EntCaja.Monto)
                .AddWithValue("@FechaEdicion", EntCaja.Monto)
            End With

            'Respuesta del stored.
            Dim respuesta As New SqlParameter("@msg", SqlDbType.Int, 255)
            respuesta.Direction = ParameterDirection.Output
            cmd.Parameters.Add(respuesta)
            cmd.ExecuteNonQuery()

            'Desconecto la bdd.
            If HayInternet Then
                clsDatos.DesconectarRemoto()
            Else
                clsDatos.DesconectarLocal()
            End If

            'retorno valor
            Return CInt(respuesta.Value)
        Catch ex As Exception
            Return False
        End Try
    End Function

    'Funcion para insertar una Dif. de Caja.
    Function AltaMovCaja(ByVal eCaja As Entidades.MovCaja, sucursal As Integer) As Int64
        'Declaro variables
        Dim cmd As New SqlCommand
        Dim resultadoOk As Boolean
        Dim HayInternet As Boolean = Funciones.HayInternet

        eCaja.id_Movimiento = clsDatos.ObtenerCalveUnica(sucursal)
        eCaja.FechaEdicion = DateTime.Now

        Try
            cmd.Connection = clsDatos.ConectarLocal()
            resultadoOk = AltaMovCaja(eCaja, cmd)
            clsDatos.DesconectarLocal()

            If Not resultadoOk Then
                Throw New Exception("No se ha podido dar de alta el movimiento en la base local.")
            End If

            If (HayInternet) Then
                cmd = New SqlCommand()
                cmd.Connection = clsDatos.ConectarRemoto()
                resultadoOk = AltaMovCaja(eCaja, cmd)
                clsDatos.DesconectarRemoto()

                If Not resultadoOk Then
                    Throw New Exception("No se ha podido dar de alta el movimiento en la base remota.")
                End If
            End If

            'muestro el mensaje
            Return eCaja.id_Movimiento
        Catch ex As Exception
            Return ex.Message
        End Try
    End Function

    Private Shared Function AltaMovCaja(eCaja As Entidades.MovCaja, ByRef cmd As SqlCommand) As Boolean
        cmd.CommandType = CommandType.StoredProcedure
        cmd.CommandText = "sp_MovCaja_Alta"
        With cmd.Parameters
            .AddWithValue("@id_Movimiento", eCaja.id_Movimiento)
            .AddWithValue("@id_Tipo", eCaja.id_Tipo)
            .AddWithValue("@id_Sucursal", eCaja.id_Sucursal)
            .AddWithValue("@id_Usuario", eCaja.id_Usuario)
            .AddWithValue("@Monto", eCaja.Monto)
            .AddWithValue("@Fecha", eCaja.Fecha)
            .AddWithValue("@Descripcion", eCaja.Descripcion)
            .AddWithValue("@FechaEdicion", eCaja.FechaEdicion)
        End With
        Dim respuesta As New SqlParameter("@msg", SqlDbType.Bit, 1)
        respuesta.Direction = ParameterDirection.Output
        cmd.Parameters.Add(respuesta)
        cmd.ExecuteNonQuery()

        Return respuesta.Value
    End Function

    'Funcion para actualizar una Dif. de Caja.
    Function ActualizarMovCaja(ByVal eCaja As Entidades.MovCaja) As Int64
        'Declaro variables
        Dim cmd As New SqlCommand
        Dim resultadoOk As Boolean
        Dim HayInternet As Boolean = Funciones.HayInternet

        eCaja.FechaEdicion = DateTime.Now

        Try
            cmd.Connection = clsDatos.ConectarLocal()
            resultadoOk = ActualizarMovCaja(eCaja, cmd)
            clsDatos.DesconectarLocal()

            If Not resultadoOk Then
                Throw New Exception("No se ha podido actualizar el movimiento en la base local.")
            End If

            If (HayInternet) Then
                cmd = New SqlCommand()
                cmd.Connection = clsDatos.ConectarRemoto()
                resultadoOk = ActualizarMovCaja(eCaja, cmd)
                clsDatos.DesconectarRemoto()

                If Not resultadoOk Then
                    Throw New Exception("No se ha podido actualizar el movimiento en la base remota.")
                End If
            End If

            'muestro el mensaje
            Return eCaja.id_Movimiento
        Catch ex As Exception
            Return ex.Message
        End Try
    End Function

    Private Shared Function ActualizarMovCaja(eCaja As Entidades.MovCaja, ByRef cmd As SqlCommand) As Boolean
        cmd.CommandType = CommandType.StoredProcedure
        cmd.CommandText = "sp_MovCaja_Actualizar"
        With cmd.Parameters
            .AddWithValue("@id_Movimiento", eCaja.id_Movimiento)
            .AddWithValue("@id_Tipo", eCaja.id_Tipo)
            .AddWithValue("@id_Sucursal", eCaja.id_Sucursal)
            .AddWithValue("@id_Usuario", eCaja.id_Usuario)
            .AddWithValue("@Monto", eCaja.Monto)
            .AddWithValue("@Fecha", eCaja.Fecha)
            .AddWithValue("@Descripcion", eCaja.Descripcion)
            .AddWithValue("@FechaEdicion", eCaja.FechaEdicion)
        End With
        Dim respuesta As New SqlParameter("@msg", SqlDbType.Bit, 1)
        respuesta.Direction = ParameterDirection.Output
        cmd.Parameters.Add(respuesta)
        cmd.ExecuteNonQuery()

        Return respuesta.Value
    End Function

    'Funcion para baja una Dif. de Caja.
    Function BajaMovCaja(ByVal id_Movimiento As Int64) As Boolean
        'Declaro variables
        Dim cmd As New SqlCommand
        Dim resultadoOk As Boolean
        Dim HayInternet As Boolean = Funciones.HayInternet

        Dim fecha As DateTime = DateTime.Now

        Try
            cmd.Connection = clsDatos.ConectarLocal()
            resultadoOk = BajaMovCaja(id_Movimiento, fecha, cmd)
            clsDatos.DesconectarLocal()

            If Not resultadoOk Then
                Throw New Exception("No se ha podido dar de baja el movimiento en la base local.")
            End If

            If (HayInternet) Then
                cmd = New SqlCommand()
                cmd.Connection = clsDatos.ConectarRemoto()
                resultadoOk = BajaMovCaja(id_Movimiento, fecha, cmd)
                clsDatos.DesconectarRemoto()

                If Not resultadoOk Then
                    Throw New Exception("No se ha podido dar de baja el movimiento en la base remota.")
                End If
            End If

            'muestro el mensaje
            Return resultadoOk
        Catch ex As Exception
            Return ex.Message
        End Try
    End Function

    Private Shared Function BajaMovCaja(id_Movimiento As Int64, fecha As DateTime, ByRef cmd As SqlCommand) As Boolean
        cmd.CommandType = CommandType.StoredProcedure
        cmd.CommandText = "sp_MovCaja_Baja"
        With cmd.Parameters
            .AddWithValue("@id_Movimiento", id_Movimiento)
            .AddWithValue("@FechaEdicion", fecha)
        End With
        Dim respuesta As New SqlParameter("@msg", SqlDbType.Bit, 1)
        respuesta.Direction = ParameterDirection.Output
        cmd.Parameters.Add(respuesta)
        cmd.ExecuteNonQuery()

        Return respuesta.Value
    End Function

    Public Function ComprobarCajas(ByVal id_Sucursal As Integer)
        'Traigo la ultima caja.
        Dim entCaja As New Entidades.CajaInicial
        entCaja = ObtenerUltimaCaja(id_Sucursal)

        'Si hay alguna caja registrada.
        If entCaja.id_Caja > 0 Then
            'Cuanto la cantidad de dias que pasaron de hoy hasta la ultima caja cerrada.
            Dim UltimaCaja As Date = entCaja.Fecha
            Dim FechaHoy As Date = Now
            Dim CantDias As Integer = 0
            CantDias = (DateDiff(DateInterval.Day, UltimaCaja, FechaHoy) - 1)
            Return CantDias
        Else
            Return 0
        End If

    End Function

    Function ObtenerSaldo(ByVal id_Sucursal As Integer, ByVal Fech As Date) As Decimal
        Dim NegVen As New Negocio.NegVentas
        Dim NegMov As New Negocio.NegMovimientos
        Dim NegEmp As New Negocio.NegEmpleados
        Dim NegMerca As New Negocio.NegMercaderia
        Dim NegAdel As New Negocio.NegAdelantos
        Dim entCaja As New Entidades.CajaInicial
        Dim FechaAyer As String = ""
        Dim Fecha As String = ""

        Fecha = Fech.ToString("yyyy/MM/dd")
        FechaAyer = Fech.AddDays(-1).ToString("yyyy/MM/dd")
        entCaja = ObtenerCaja(id_Sucursal, FechaAyer)

        Dim VentasEfectivo As Double = 0
        VentasEfectivo = NegVen.TotalVentasEfectivo(id_Sucursal, Fecha)

        Dim Gastos As Double = 0
        Gastos = NegMov.ConsultarTotalMovimiento(id_Sucursal, Fecha, Fecha, 1)

        Dim EfectivoEgreso As Double = 0
        EfectivoEgreso = NegMov.ObtenerTotalMovEgreso(id_Sucursal, Fecha, Fecha, "Egresos")

        Dim EfectivoIngreso As Double = 0
        EfectivoIngreso = NegMov.ObtenerTotalMovEgreso(id_Sucursal, Fecha, Fecha, "Ingresos")

        Dim Impuesto As Double = 0
        Impuesto = NegMov.ConsultarTotalMovimiento(id_Sucursal, Fecha, Fecha, 3)

        Dim RetirosCaja As Double = 0
        RetirosCaja = NegMov.ConsultarTotalMovimiento(id_Sucursal, Fecha, Fecha, 5)

        Dim Sobrante As Double = 0
        Sobrante = NegMov.ObtenerTotalMovCaja(id_Sucursal, Fecha, Fecha, "Sobrante")

        Dim Faltante As Double = 0
        Faltante = NegMov.ObtenerTotalMovCaja(id_Sucursal, Fecha, Fecha, "Faltante")

        Dim AporteSocios As Double = 0
        AporteSocios = NegMov.ConsultarTotalMovimiento(id_Sucursal, Fecha, Fecha, 6)

        Dim Sueldo As Double = 0
        Sueldo = NegEmp.ObtenerSueldosSucursal(id_Sucursal, Fecha, Fecha)

        Dim Mercaderias As Double = 0
        Mercaderias = NegMov.ConsultarTotalGastoMercaderia(id_Sucursal, Fecha, Fecha)

        Dim Adelantos As Double = 0
        Adelantos = NegAdel.ObtenerAdelantosSucursal(id_Sucursal, Fecha, Fecha)

        Dim EgresoCajaFuerte As Double = 0
        EgresoCajaFuerte = NegMov.ObtenerTotalMovCajaFuerte(id_Sucursal, Fecha, Fecha, 1)

        Dim IngresoCajaFuerte As Double = 0
        IngresoCajaFuerte = NegMov.ObtenerTotalMovCajaFuerte(id_Sucursal, Fecha, Fecha, 2)

        Dim NegDevolucion As Negocio.NegDevolucion = New Negocio.NegDevolucion()
        Dim DevolucionesEfectivo As Double = NegDevolucion.TotalDevolucionesEfectivo(id_Sucursal, Fecha)

        'Calculo el saldo.
        Dim Ingresos As Double = 0
        Dim Egresos As Double = 0
        Dim Saldo As Double = 0

        Ingresos = VentasEfectivo + Sobrante + entCaja.Monto + EfectivoIngreso + EgresoCajaFuerte + AporteSocios
        Egresos = EfectivoEgreso + Gastos + Mercaderias + Impuesto + RetirosCaja + Faltante + Adelantos + Sueldo + IngresoCajaFuerte + DevolucionesEfectivo
        Saldo = Ingresos - Egresos

        Return Format(CType((Saldo), Decimal), "###0.00")
    End Function

    Private Shared Function ObtenerCajaFromDataRow(dr As DataRow, entCaja As Entidades.CajaInicial) As Entidades.CajaInicial
        entCaja.id_Caja = dr.Item("id_Caja").ToString
        entCaja.id_Movimiento = dr.Item("id_Movimiento").ToString
        entCaja.id_Empleado = dr.Item("id_Empleado").ToString
        entCaja.Empleado = dr.Item("Empleado").ToString
        entCaja.id_Sucursal = dr.Item("id_Sucursal").ToString
        entCaja.Monto = dr.Item("Monto").ToString
        entCaja.Fecha = dr.Item("Fecha").ToString
        entCaja.Hora = dr.Item("Hora").ToString
        entCaja.Abierta = dr.Item("Abierta").ToString
        Return entCaja
    End Function

End Class
