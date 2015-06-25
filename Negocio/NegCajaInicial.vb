Imports System.Data.SqlClient
Public Class NegCajaInicial
    Dim clsDatos As New Datos.Conexion
    Dim ClsFunciones As New Funciones
    Dim HayInternet As Boolean = ClsFunciones.GotInternet

    'Funcion para obtener la caja de un terminado dia.
    Function ObtenerCaja(ByVal id_Sucursal As Integer, ByVal Fecha As String) As Entidades.CajaInicial
        Dim ds As New DataSet
        Dim entCaja As New Entidades.CajaInicial

        If HayInternet Then
            ds = clsDatos.ConsultarBaseRemoto("execute sp_CajaInicial_Obtener @id_Sucursal=" & id_Sucursal & ", @Fecha='" & Fecha & "'")
        Else
            ds = clsDatos.ConsultarBaseLocal("execute sp_CajaInicial_Obtener @id_Sucursal=" & id_Sucursal & ", @Fecha='" & Fecha & "'")
        End If

        'lleno la entidad.
        If ds.Tables(0).Rows.Count > 0 Then
            entCaja.id_Caja = ds.Tables(0).Rows(0).Item("id_Caja").ToString
            entCaja.id_Empleado = ds.Tables(0).Rows(0).Item("id_Empleado").ToString
            entCaja.Empleado = ds.Tables(0).Rows(0).Item("Empleado").ToString
            entCaja.id_Sucursal = ds.Tables(0).Rows(0).Item("id_Sucursal").ToString
            entCaja.Monto = ds.Tables(0).Rows(0).Item("Monto").ToString
            entCaja.Fecha = ds.Tables(0).Rows(0).Item("Fecha").ToString
            entCaja.Hora = ds.Tables(0).Rows(0).Item("Hora").ToString
            entCaja.Abierta = ds.Tables(0).Rows(0).Item("Abierta").ToString
        End If

        Return entCaja
    End Function

    'Funcion para obtener la caja de un terminado dia.
    Function ObtenerUltimaCaja(ByVal id_Sucursal As Integer) As Entidades.CajaInicial
        Dim ds As New DataSet
        Dim entCaja As New Entidades.CajaInicial

        If HayInternet Then
            ds = clsDatos.ConsultarBaseRemoto("execute sp_CajaInicial_Ultima @id_Sucursal=" & id_Sucursal)
        Else
            ds = clsDatos.ConsultarBaseLocal("execute sp_CajaInicial_Ultima @id_Sucursal=" & id_Sucursal)
        End If

        'lleno la entidad.
        If ds.Tables(0).Rows.Count > 0 Then
            entCaja.id_Caja = ds.Tables(0).Rows(0).Item("id_Caja").ToString
            entCaja.id_Empleado = ds.Tables(0).Rows(0).Item("id_Empleado").ToString
            entCaja.Empleado = ds.Tables(0).Rows(0).Item("Empleado").ToString
            entCaja.id_Sucursal = ds.Tables(0).Rows(0).Item("id_Sucursal").ToString
            entCaja.Monto = ds.Tables(0).Rows(0).Item("Monto").ToString
            entCaja.Fecha = ds.Tables(0).Rows(0).Item("Fecha").ToString
            entCaja.Hora = ds.Tables(0).Rows(0).Item("Hora").ToString
            entCaja.Abierta = ds.Tables(0).Rows(0).Item("Abierta").ToString
        End If

        Return entCaja
    End Function

    'Funcion que inserta un nuevo registro en la tabla CAJA_INICIAL.
    Public Function CerrarCaja(ByVal EntCaja As Entidades.CajaInicial) As Integer
        'Declaro variables
        Dim cmd As New SqlCommand
        Dim msg As String = ""
        Try
            'Conecto a la bdd.
            If HayInternet Then
                cmd.Connection = clsDatos.ConectarRemoto()
            Else
                cmd.Connection = clsDatos.ConectarLocal()
            End If

            'Cargo y ejecuto el stored.
            cmd.CommandType = CommandType.StoredProcedure
            cmd.CommandText = "sp_CajaInicial_Alta"
            With cmd.Parameters
                .AddWithValue("@Abierta", EntCaja.Abierta)
                .AddWithValue("@id_Empleado", EntCaja.id_Empleado)
                .AddWithValue("@Empleado", EntCaja.Empleado)
                .AddWithValue("@id_Sucursal", EntCaja.id_Sucursal)
                .AddWithValue("@Monto", EntCaja.Monto)
                .AddWithValue("@Fecha", EntCaja.Fecha)
                .AddWithValue("@Hora", EntCaja.Hora)
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

    'Funcion que inserta un nuevo registro en la tabla CAJA_INICIAL.
    Public Function AbrirCaja(ByVal id_Sucursal As Integer, ByVal Fecha As String) As Integer
        'Declaro variables
        Dim cmd As New SqlCommand
        Dim msg As String = ""
        Try
            'Conecto a la bdd.
            If HayInternet Then
                cmd.Connection = clsDatos.ConectarRemoto()
            Else
                cmd.Connection = clsDatos.ConectarLocal()
            End If

            'Cargo y ejecuto el stored.
            cmd.CommandType = CommandType.StoredProcedure
            cmd.CommandText = "sp_CajaInicial_Baja"
            With cmd.Parameters
                .AddWithValue("@id_Sucursal", id_Sucursal)
                .AddWithValue("@Fecha", Fecha)
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

    'Funcion que actualiza un registro en la tabla CAJA_INICIAL.
    Public Function ActualizarCaja(ByVal EntCaja As Entidades.CajaInicial) As Integer
        'Declaro variables
        Dim cmd As New SqlCommand
        Dim msg As String = ""
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
                .AddWithValue("@Fecha", EntCaja.Fecha)
                .AddWithValue("@Hora", EntCaja.Hora)
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

        Dim Sueldo As Double = 0
        'Sueldo = NegEmp.ObtenerSueldosSucursalDia(id_Sucursal, Fecha)

        Dim Mercaderias As Double = 0
        'Mercaderias = NegMerca.TotalMercaderia(id_Sucursal, Fecha)
        Mercaderias = NegMov.ConsultarTotalGastoMercaderia(id_Sucursal, Fecha, Fecha)

        Dim Adelantos As Double = 0
        Adelantos = NegAdel.ObtenerAdelantosSucursal(id_Sucursal, Fecha, Fecha)

        Dim Comision As Double = 0
        'Comision = NegEmp.ObtenerComisionesSucursal(id_Sucursal, Fecha, Fecha)

        Dim EgresoCajaFuerte As Double = 0
        EgresoCajaFuerte = NegMov.ObtenerTotalMovCajaFuerte(id_Sucursal, Fecha, Fecha, 1)

        Dim IngresoCajaFuerte As Double = 0
        IngresoCajaFuerte = NegMov.ObtenerTotalMovCajaFuerte(id_Sucursal, Fecha, Fecha, 2)

        'Calculo el saldo.
        Dim Ingresos As Double = 0
        Dim Egresos As Double = 0
        Dim Saldo As Double = 0

        Ingresos = VentasEfectivo + Sobrante + entCaja.Monto + EfectivoIngreso + EgresoCajaFuerte
        Egresos = EfectivoEgreso + Gastos + Mercaderias + Sueldo + Impuesto + RetirosCaja + Faltante + Adelantos + Comision + IngresoCajaFuerte
        Saldo = Ingresos - Egresos

        Return Format(CType((Saldo), Decimal), "###0.00")
    End Function

End Class
