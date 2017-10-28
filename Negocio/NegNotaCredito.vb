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

        EntNotaCredito.id_NotaCredito = ClsDatos.ObtenerCalveUnica(EntNotaCredito.id_Sucursal)

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

    Public Function ObtenerListado(idSucursal As Integer, FDesde As String, FHasta As String) As List(Of Entidades.NotaCredito)
        'Declaro variables
        Dim dsNotaCredito As New DataSet
        Dim notaCreditos As List(Of Entidades.NotaCredito) = New List(Of Entidades.NotaCredito)()

        'Conecto a la bdd.

        Try
            If (Funciones.HayInternet) Then
                dsNotaCredito = ClsDatos.ConsultarBaseRemoto("execute sp_NotaCretido_Listado @idSucursal=" & idSucursal & ", @FDesde='" & FDesde & "', @FHasta='" & FHasta & "'")
            Else
                dsNotaCredito = ClsDatos.ConsultarBaseRemoto("execute sp_NotaCretido_Listado @idSucursal=" & idSucursal & ", @FDesde='" & FDesde & "', @FHasta='" & FHasta & "'")
            End If

            For Each motaCredito As DataRow In dsNotaCredito.Tables(0).Rows
                notaCreditos.Add(ObtenerEntidadNotaCredito(motaCredito))
            Next
            'retorno valor
            Return notaCreditos
        Catch ex As Exception
            Return notaCreditos
        End Try
    End Function

    Private Shared Function NuevaNotaCredito(EntNotaCredito As Entidades.NotaCredito, ByRef cmd As SqlCommand) As Boolean
        'Ejecuto el stored.
        cmd.CommandType = CommandType.StoredProcedure
        cmd.CommandText = "sp_NotaCredito_Alta"
        With cmd.Parameters
            .AddWithValue("@id_NotaCredito", EntNotaCredito.id_NotaCredito)
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
            .AddWithValue("@Id_Factura", EntNotaCredito.id_Factura)
        End With

        'Respuesta del stored.
        Dim respuesta As New SqlParameter("@msg", SqlDbType.Int, 255)
        respuesta.Direction = ParameterDirection.Output
        cmd.Parameters.Add(respuesta)
        cmd.ExecuteNonQuery()
        Return CBool(respuesta.Value)
    End Function

    Function TraerNotaCreditoPorIDDevolucio(id_Devolucion As Int64) As Entidades.NotaCredito
        Dim dsNotaCredito As New DataSet
        Dim entNotaCredito As New Entidades.NotaCredito

        If (Funciones.HayInternet) Then
            dsNotaCredito = ClsDatos.ConsultarBaseRemoto("execute sp_NotaCredito_Detalle @id_Devolucion=" & id_Devolucion)
        Else
            dsNotaCredito = ClsDatos.ConsultarBaseLocal("execute sp_NotaCredito_Detalle @id_Devolucion=" & id_Devolucion)
        End If

        If dsNotaCredito.Tables(0).Rows.Count <> 0 Then
            entNotaCredito = ObtenerEntidadNotaCredito(dsNotaCredito.Tables(0).Rows(0))

        End If
        Return entNotaCredito
    End Function

    Function TraerNotaCreditoPorID(id_NotaCredito As Int64) As Entidades.NotaCredito
        Dim dsNotaCredito As New DataSet
        Dim entNotaCredito As New Entidades.NotaCredito

        If (Funciones.HayInternet) Then
            dsNotaCredito = ClsDatos.ConsultarBaseRemoto("execute sp_NotaCredito_Detalle_Por_Id @id_NotaCredito=" & id_NotaCredito)
        Else
            dsNotaCredito = ClsDatos.ConsultarBaseLocal("execute sp_NotaCredito_Detalle_Por_Id @id_NotaCredito=" & id_NotaCredito)
        End If

        If dsNotaCredito.Tables(0).Rows.Count <> 0 Then
            entNotaCredito = ObtenerEntidadNotaCredito(dsNotaCredito.Tables(0).Rows(0))

        End If
        Return entNotaCredito
    End Function

    Private Shared Function ObtenerEntidadNotaCredito(drNotaCredito As DataRow) As Entidades.NotaCredito
        Dim entNotaCredito As New Entidades.NotaCredito

        entNotaCredito.id_NotaCredito = drNotaCredito.Item("id_NotaCredito").ToString
        entNotaCredito.id_Devolucion = drNotaCredito.Item("id_Devolucion").ToString
        entNotaCredito.NumeroNotaCredito = drNotaCredito.Item("NumeroNotaCredito").ToString
        entNotaCredito.Monto = drNotaCredito.Item("Monto").ToString
        entNotaCredito.TipoFactura = drNotaCredito.Item("TipoFactura").ToString
        entNotaCredito.Nombre = drNotaCredito.Item("Nombre").ToString
        entNotaCredito.Direccion = drNotaCredito.Item("Direccion").ToString
        entNotaCredito.Localidad = drNotaCredito.Item("Localidad").ToString
        entNotaCredito.Cuit = drNotaCredito.Item("Cuit").ToString
        entNotaCredito.Fecha = drNotaCredito.Item("Fecha").ToString
        entNotaCredito.PuntoVenta = drNotaCredito.Item("PuntoVenta").ToString
        entNotaCredito.TipoRecibo = Integer.Parse(drNotaCredito.Item("TipoRecibo").ToString)
        entNotaCredito.id_Sucursal = drNotaCredito.Item("Id_Sucursal").ToString
        entNotaCredito.id_Factura = If(drNotaCredito.Item("Id_Factura") Is DBNull.Value, 0, Integer.Parse(drNotaCredito.Item("Id_Factura").ToString))
        Return entNotaCredito
    End Function
End Class
