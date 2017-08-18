Imports System.Data.SqlClient
Imports Entidades

Public Class NegCuentaCorrienteClientesMayoristas
    Public Function NuevoPago(pago As PagoCuentaCorrienteClienteMayorista, id_ClienteMayorista As Integer) As Boolean
        Dim clsDatos As New Datos.Conexion
        Dim cmd As New SqlCommand
        Dim msg As Boolean
        Dim HayInternet As Boolean = Funciones.HayInternet
        Try
            cmd.Connection = clsDatos.ConectarLocal()
            msg = NuevoPago(pago, id_ClienteMayorista, cmd)
            clsDatos.DesconectarLocal()
            If HayInternet Then
                cmd = New SqlCommand()
                cmd.Connection = clsDatos.ConectarRemoto()
                msg = NuevoPago(pago, id_ClienteMayorista, cmd)
                clsDatos.DesconectarRemoto()
            End If

            'retorno valor
            Return msg
        Catch ex As Exception
            Return False
        End Try
    End Function

    Private Shared Function NuevoPago(pago As PagoCuentaCorrienteClienteMayorista, id_ClienteMayorista As Integer, cmd As SqlCommand) As Boolean
        'Cargo y ejecuto el stored.
        cmd.CommandType = CommandType.StoredProcedure
        cmd.CommandText = "sp_CuentaCorrienteMayorista_Alta_Pago"
        With cmd.Parameters
            .AddWithValue("@id_Empresa", pago.id_Empresa)
            .AddWithValue("@id_Cheque", pago.id_Cheque)
            .AddWithValue("@Fecha", pago.Fecha)
            .AddWithValue("@Forma_Pago", pago.FormaPago)
            .AddWithValue("@Monto", pago.Monto)
            .AddWithValue("@Recibo", pago.Comprobante)
            .AddWithValue("@id_ClienteMayorista", id_ClienteMayorista)
        End With

        Dim respuesta As New SqlParameter("@msg", SqlDbType.Int, 255)
        respuesta.Direction = ParameterDirection.Output
        cmd.Parameters.Add(respuesta)
        cmd.ExecuteNonQuery()

        Return CBool(respuesta.Value)
    End Function

    Function Movimientos(id_cliente As Integer) As List(Of MovimientoCuentaCorrienteClienteMayorista)
        Dim ds As DataSet = New DataSet
        Dim mov As List(Of MovimientoCuentaCorrienteClienteMayorista) = New List(Of MovimientoCuentaCorrienteClienteMayorista)
        Dim clsDatos As New Datos.Conexion

        If Funciones.HayInternet Then
            ds = clsDatos.ConsultarBaseRemoto("execute sp_ClienteMayorista_CuentaCorriente @id_cliente='" & id_cliente & "'")
        Else
            ds = clsDatos.ConsultarBaseLocal("execute sp_ClienteMayorista_CuentaCorriente @id_cliente='" & id_cliente & "'")
        End If

        If (ds.Tables.Count > 0) Then

            For Each row As DataRow In ds.Tables(0).Rows
                mov.Add(ObtenerCorrienteMovimientosDesdeDataRow(row))
            Next

        End If
        Return mov
    End Function

    Private Function ObtenerCorrienteMovimientosDesdeDataRow(row As DataRow) As MovimientoCuentaCorrienteClienteMayorista
        Dim movimientoCuentaCorrienteClienteMayorista As MovimientoCuentaCorrienteClienteMayorista = New MovimientoCuentaCorrienteClienteMayorista()
        With movimientoCuentaCorrienteClienteMayorista
            .Fecha = row("Fecha")
            .Id_TipoMovimiento = row("Id_TipoMovimiento")
            .TipoMovimiento = row("TipoMovimiento").ToString().Trim()
            .TipoFactura = row("TipoFactura")
            .PuntoVenta = row("PuntoVenta")
            .Comprobante = row("Comprobante")
            .Pago = row("Pago").ToString().Trim()
            .Monto = row("Monto")
            .Empresa = row("Empresa")
            .Saldo = row("Saldo")
        End With
        Return movimientoCuentaCorrienteClienteMayorista
    End Function

    Public Function NuevoPresupuesto(id_Presupuesto As Integer, id_ClienteMayorista As Integer) As Boolean
        Dim clsDatos As New Datos.Conexion
        Dim cmd As New SqlCommand
        Dim msg As Boolean
        Dim HayInternet As Boolean = Funciones.HayInternet
        Try
            cmd.Connection = clsDatos.ConectarLocal()
            msg = NuevoPresupuesto(id_Presupuesto, id_ClienteMayorista, cmd)
            clsDatos.DesconectarLocal()
            If HayInternet Then
                cmd = New SqlCommand()
                cmd.Connection = clsDatos.ConectarRemoto()
                msg = NuevoPresupuesto(id_Presupuesto, id_ClienteMayorista, cmd)
                clsDatos.DesconectarRemoto()
            End If

            'retorno valor
            Return msg
        Catch ex As Exception
            Return False
        End Try
    End Function

    Private Function NuevoPresupuesto(id_Presupuesto As Integer, id_ClienteMayorista As Integer, cmd As SqlCommand) As Boolean
        'Cargo y ejecuto el stored.
        cmd.CommandType = CommandType.StoredProcedure
        cmd.CommandText = "sp_CuentaCorrienteMayorista_Alta_Presupuesto"
        With cmd.Parameters
            .AddWithValue("@id_Presupuesto", id_Presupuesto)
            .AddWithValue("@id_ClienteMayorista", id_ClienteMayorista)
        End With

        Dim respuesta As New SqlParameter("@msg", SqlDbType.Int, 255)
        respuesta.Direction = ParameterDirection.Output
        cmd.Parameters.Add(respuesta)
        cmd.ExecuteNonQuery()

        Return CBool(respuesta.Value)
    End Function

    Public Function NuevaFactura(id_Factura As Integer, id_ClienteMayorista As Integer) As Boolean
        Dim clsDatos As New Datos.Conexion
        Dim cmd As New SqlCommand
        Dim msg As Boolean
        Dim HayInternet As Boolean = Funciones.HayInternet
        Try
            cmd.Connection = clsDatos.ConectarLocal()
            msg = NuevaFactura(id_Factura, id_ClienteMayorista, cmd)
            clsDatos.DesconectarLocal()
            If HayInternet Then
                cmd = New SqlCommand()
                cmd.Connection = clsDatos.ConectarRemoto()
                msg = NuevaFactura(id_Factura, id_ClienteMayorista, cmd)
                clsDatos.DesconectarRemoto()
            End If

            'retorno valor
            Return msg
        Catch ex As Exception
            Return False
        End Try
    End Function

    Private Function NuevaFactura(id_Factura As Integer, id_ClienteMayorista As Integer, cmd As SqlCommand) As Boolean
        'Cargo y ejecuto el stored.
        cmd.CommandType = CommandType.StoredProcedure
        cmd.CommandText = "sp_CuentaCorrienteMayorista_Alta_Factura"
        With cmd.Parameters
            .AddWithValue("@id_Factura", id_Factura)
            .AddWithValue("@id_ClienteMayorista", id_ClienteMayorista)
        End With

        Dim respuesta As New SqlParameter("@msg", SqlDbType.Int, 255)
        respuesta.Direction = ParameterDirection.Output
        cmd.Parameters.Add(respuesta)
        cmd.ExecuteNonQuery()

        Return (respuesta.Value)
    End Function

    Public Function NuevaNotaCredito(idNotaCreadito As Integer, id_ClienteMayorista As Integer) As Boolean
        Dim clsDatos As New Datos.Conexion
        Dim cmd As New SqlCommand
        Dim msg As Boolean
        Dim HayInternet As Boolean = Funciones.HayInternet
        Try
            cmd.Connection = clsDatos.ConectarLocal()
            msg = NuevaNotaCredito(idNotaCreadito, id_ClienteMayorista, cmd)
            clsDatos.DesconectarLocal()
            If HayInternet Then
                cmd = New SqlCommand()
                cmd.Connection = clsDatos.ConectarRemoto()
                msg = NuevaNotaCredito(idNotaCreadito, id_ClienteMayorista, cmd)
                clsDatos.DesconectarRemoto()
            End If

            'retorno valor
            Return msg
        Catch ex As Exception
            Return False
        End Try
    End Function

    Private Function NuevaNotaCredito(idNotaCreadito As Integer, id_ClienteMayorista As Integer, cmd As SqlCommand) As Boolean
        'Cargo y ejecuto el stored.
        cmd.CommandType = CommandType.StoredProcedure
        cmd.CommandText = "sp_CuentaCorrienteMayorista_Alta_NotaCredito"
        With cmd.Parameters
            .AddWithValue("@id_NotaCreadito", idNotaCreadito)
            .AddWithValue("@id_ClienteMayorista", id_ClienteMayorista)
        End With

        Dim respuesta As New SqlParameter("@msg", SqlDbType.Int, 255)
        respuesta.Direction = ParameterDirection.Output
        cmd.Parameters.Add(respuesta)
        cmd.ExecuteNonQuery()

        Return (respuesta.Value)
    End Function
End Class
