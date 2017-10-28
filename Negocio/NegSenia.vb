Imports System.Data.SqlClient

Public Class NegSenia
    Dim clsDatos As New Datos.Conexion

    Public Sub CrearSenia(senia As Entidades.Senia)
        'Declaro variables
        Dim cmd As New SqlCommand
        Dim HayInternet As Boolean = Funciones.HayInternet

        senia.Id = clsDatos.ObtenerCalveUnica(senia.IdSucursal)
        senia.FechaEdicion = DateTime.Now

        cmd.Connection = ClsDatos.ConectarLocal()
        CrearSenia(senia, cmd)
        ClsDatos.DesconectarLocal()

        If HayInternet Then
            cmd = New SqlCommand()
            cmd.Connection = ClsDatos.ConectarRemoto()
            CrearSenia(senia, cmd)
            ClsDatos.DesconectarRemoto()
        End If
    End Sub

    Public Sub CrearSenia(senia As Entidades.Senia, ByRef cmd As SqlCommand)
        'Cargo y ejecuto el stored.
        cmd.CommandType = CommandType.StoredProcedure
        cmd.CommandText = "sp_Senia_Alta"
        With cmd.Parameters
            .AddWithValue("@id_Senia", senia.Id)
            .AddWithValue("@id_Sucursal", senia.IdSucursal)
            .AddWithValue("@id_ClienteMinorista", senia.IdClienteMinorista)
            .AddWithValue("@id_ClienteMayorista", senia.IdClienteMayorista)
            .AddWithValue("@id_Venta_Senia", senia.IdVentaSenia)
            .AddWithValue("@FechaAlta", senia.FechaAlta)
            .AddWithValue("@FechaEstimadaRetiro", senia.FechaEstimadaRetiro)
            .AddWithValue("@FormaEntrega", senia.FormaEntrega)
            .AddWithValue("@Observaciones", senia.Observaciones)
            .AddWithValue("@Entregada", senia.Entregada)
            .AddWithValue("@FechaEdicion", senia.FechaEdicion)
        End With

        cmd.ExecuteNonQuery()
    End Sub

    Public Sub ActualizarSenia(senia As Entidades.Senia)
        'Declaro variables
        Dim cmd As New SqlCommand
        Dim HayInternet As Boolean = Funciones.HayInternet

        senia.FechaEdicion = DateTime.Now()

        cmd.Connection = clsDatos.ConectarLocal()
        ActualizarSenia(senia, cmd)
        clsDatos.DesconectarLocal()

        If HayInternet Then
            cmd = New SqlCommand()
            cmd.Connection = clsDatos.ConectarRemoto()
            ActualizarSenia(senia, cmd)
            clsDatos.DesconectarRemoto()
        End If
    End Sub

    Public Sub ActualizarSenia(senia As Entidades.Senia, ByRef cmd As SqlCommand)
        'Cargo y ejecuto el stored.
        cmd.CommandType = CommandType.StoredProcedure
        cmd.CommandText = "sp_Senia_Modificacion"
        With cmd.Parameters
            .AddWithValue("@id_Senia", senia.Id)
            .AddWithValue("@id_Sucursal", senia.IdSucursal)
            .AddWithValue("@id_ClienteMinorista", senia.IdClienteMinorista)
            .AddWithValue("@id_ClienteMayorista", senia.IdClienteMayorista)
            .AddWithValue("@id_Venta_Senia", senia.IdVentaSenia)
            .AddWithValue("@id_Venta_Retiro", senia.IdVentaRetiro)
            .AddWithValue("@FechaAlta", senia.FechaAlta)
            .AddWithValue("@FechaEstimadaRetiro", senia.FechaEstimadaRetiro)
            .AddWithValue("@FormaEntrega", senia.FormaEntrega)
            .AddWithValue("@Observaciones", senia.Observaciones)
            .AddWithValue("@Entregada", senia.Entregada)
            .AddWithValue("@Anulada", senia.Anulada)
            .AddWithValue("@FechaEdicion", senia.FechaEdicion)
        End With

        cmd.ExecuteNonQuery()
    End Sub

    Public Sub EliminarSenia(id As Integer)
        Dim cmd As New SqlCommand
        Dim HayInternet As Boolean = Funciones.HayInternet

        clsDatos.ConsultarBaseLocal("execute sp_Senia_Eliminar @idSenia=" & id)

        If HayInternet Then
            clsDatos.ConsultarBaseRemoto("execute sp_Senia_Eliminar @idSenia=" & id)
        End If
    End Sub

    Public Function ConsultarSeniaActivas(idSucursal As Integer) As List(Of Entidades.Senia)
        Dim dsStock As New DataSet
        Dim Senias As List(Of Entidades.Senia) = New List(Of Entidades.Senia)()

        If Funciones.HayInternet Then
            dsStock = clsDatos.ConsultarBaseRemoto("execute sp_Senia_Consultar @idSucursal=" & idSucursal)
        Else
            dsStock = clsDatos.ConsultarBaseLocal("execute sp_Senia_Consultar @idSucursal=" & idSucursal)
        End If

        If dsStock.Tables.Count <> 0 Then
            For Each row As DataRow In dsStock.Tables(0).Rows
                Dim Senia As Entidades.Senia = ObtenerSeniaDesdeDataRow(row)
                Senias.Add(Senia)
            Next
        End If
        Return Senias.Where(Function(x) Not x.Entregada AndAlso Not x.Anulada).ToList()
    End Function

    Public Function ConsultarSeniaPorVenta(idVenta As Int64) As Entidades.Senia
        Dim dsStock As New DataSet
        Dim Senias As List(Of Entidades.Senia) = New List(Of Entidades.Senia)()

        If Funciones.HayInternet Then
            dsStock = clsDatos.ConsultarBaseRemoto("execute sp_Senia_ConsultarVenta @IdVenta=" & idVenta)
        Else
            dsStock = clsDatos.ConsultarBaseLocal("execute sp_Senia_ConsultarVenta @IdVenta=" & idVenta)
        End If

        If dsStock.Tables.Count <> 0 AndAlso dsStock.Tables(0).Rows.Count <> 0 Then
            Return ObtenerSeniaDesdeDataRow(dsStock.Tables(0).Rows(0))
        End If
        Return Nothing
    End Function

    Private Shared Function ObtenerSeniaDesdeDataRow(row As DataRow) As Entidades.Senia
        Dim Senia As Entidades.Senia = New Entidades.Senia()
        With Senia
            .Id = row.Item("id_Senia")
            .IdSucursal = row.Item("id_Sucursal")
            .IdClienteMinorista = row.Item("id_ClienteMinorista")
            .ApellidoNombreClienteMinorista = If(row.Item("NombreMinorista") Is DBNull.Value, String.Empty, row.Item("NombreMinorista"))
            .IdClienteMayorista = row.Item("id_ClienteMayorista")
            .RazonSocial = If(row.Item("RazonSocial") Is DBNull.Value, String.Empty, row.Item("RazonSocial"))
            .IdVentaSenia = row.Item("id_Venta_Senia")
            .IdVentaRetiro = row.Item("id_Venta_Retiro")
            .FechaAlta = row.Item("FechaAlta")
            .FechaEstimadaRetiro = row.Item("FechaEstimadaRetiro")
            .FormaEntrega = row.Item("FormaEntrega")
            .Observaciones = row.Item("Observaciones")
            .MontoTotal = row.Item("Precio_Total")
            .MontoSenia = row.Item("MontoSenia")
            .Entregada = row.Item("Entregada")
            .Anulada = row.Item("Anulada")
        End With

        Return Senia
    End Function
End Class
