Imports System.Data.SqlClient
Imports Datos

Public Class NegNotaCredito
    Dim ClsDatos As New Datos.Conexion
    Dim ClsFunciones As New Funciones
    Dim con As New Conexion

    Public Function NuevaNotaCredito(ByVal EntNotaCredito As Entidades.NotaCredito) As Boolean
        'Declaro variables
        Dim cmd As New SqlCommand
        Dim msg As Boolean
        Dim HayInternet As Boolean = Funciones.HayInternet

        Try
            cmd.Connection = ClsDatos.ConectarLocal()
            msg = NuevaNotaCredito(EntNotaCredito, cmd)
            ClsDatos.DesconectarLocal()

            If (HayInternet) Then
                cmd = New SqlCommand()
                cmd.Connection = ClsDatos.ConectarRemoto()
                msg = NuevaNotaCredito(EntNotaCredito, cmd)
                ClsDatos.DesconectarRemoto()
            End If

            'retorno valor
            Return msg
        Catch ex As Exception
            Return False
        End Try
    End Function

    Private Shared Function NuevaNotaCredito(EntNotaCredito As Entidades.NotaCredito, ByRef cmd As SqlCommand) As Boolean
        'Ejecuto el stored.
        cmd.CommandType = CommandType.StoredProcedure
        cmd.CommandText = "sp_NotaCredito_Alta"
        With cmd.Parameters
            .AddWithValue("@id_Devolucion", EntNotaCredito.id_Devolucion)
            .AddWithValue("@NumeroNotaCredito", EntNotaCredito.NumeroNotaCredito)
            .AddWithValue("@Monto", EntNotaCredito.Monto)
            .AddWithValue("@Nombre", EntNotaCredito.Nombre)
            .AddWithValue("@Cuit", EntNotaCredito.Cuit)
            .AddWithValue("@Direccion", EntNotaCredito.Direccion)
            .AddWithValue("@Localidad", EntNotaCredito.Localidad)
            .AddWithValue("@TipoFactura", EntNotaCredito.TipoFactura)
            .AddWithValue("@PuntoVenta", EntNotaCredito.PuntoVenta)
            .AddWithValue("@Id_Sucursal", EntNotaCredito.id_Sucursal)
            .AddWithValue("@TipoRecibo", EntNotaCredito.TipoRecibo)
        End With

        'Respuesta del stored.
        Dim respuesta As New SqlParameter("@msg", SqlDbType.Int, 255)
        respuesta.Direction = ParameterDirection.Output
        cmd.Parameters.Add(respuesta)
        cmd.ExecuteNonQuery()
        Return CBool(respuesta.Value)
    End Function

    Function TraerNotaCredito(id_Devolucion As Integer) As Entidades.NotaCredito
        Dim dsNotaCredito As New DataSet
        Dim entNotaCredito As New Entidades.NotaCredito

        If (Funciones.HayInternet) Then
            dsNotaCredito = ClsDatos.ConsultarBaseRemoto("execute sp_NotaCredito_Detalle @id_Devolucion=" & id_Devolucion)
        Else
            dsNotaCredito = ClsDatos.ConsultarBaseLocal("execute sp_NotaCredito_Detalle @id_Devolucion=" & id_Devolucion)
        End If

        If dsNotaCredito.Tables(0).Rows.Count <> 0 Then
            entNotaCredito.id_NotaCredito = dsNotaCredito.Tables(0).Rows(0).Item("id_NotaCredito").ToString
            entNotaCredito.id_Devolucion = dsNotaCredito.Tables(0).Rows(0).Item("id_Devolucion").ToString
            entNotaCredito.NumeroNotaCredito = dsNotaCredito.Tables(0).Rows(0).Item("NumeroNotaCredito").ToString
            entNotaCredito.Monto = dsNotaCredito.Tables(0).Rows(0).Item("Monto").ToString
            entNotaCredito.TipoFactura = dsNotaCredito.Tables(0).Rows(0).Item("TipoFactura").ToString
            entNotaCredito.Nombre = dsNotaCredito.Tables(0).Rows(0).Item("Nombre").ToString
            entNotaCredito.Direccion = dsNotaCredito.Tables(0).Rows(0).Item("Direccion").ToString
            entNotaCredito.Localidad = dsNotaCredito.Tables(0).Rows(0).Item("Localidad").ToString
            entNotaCredito.Cuit = dsNotaCredito.Tables(0).Rows(0).Item("Cuit").ToString
            entNotaCredito.Fecha = dsNotaCredito.Tables(0).Rows(0).Item("Fecha").ToString
            entNotaCredito.PuntoVenta = dsNotaCredito.Tables(0).Rows(0).Item("PuntoVenta").ToString
            entNotaCredito.TipoRecibo = Integer.Parse(dsNotaCredito.Tables(0).Rows(0).Item("TipoRecibo").ToString)
            entNotaCredito.id_Sucursal = dsNotaCredito.Tables(0).Rows(0).Item("Id_Sucursal").ToString

        End If
        Return entNotaCredito
    End Function

End Class
