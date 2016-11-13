Imports System.Data.SqlClient

Public Class NegSenia
    Dim clsDatos As New Datos.Conexion

    Public Sub CrearSenia(senia As Entidades.Senia)
        'Declaro variables
        Dim cmd As New SqlCommand
        Dim HayInternet As Boolean = Funciones.HayInternet

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
            .AddWithValue("@id_Sucursal", senia.IdSucursal)
            .AddWithValue("@id_ClienteMinorista", senia.IdClienteMinorista)
            .AddWithValue("@id_ClienteMayorista", senia.IdClienteMayorista)
            .AddWithValue("@id_Venta", senia.Idventa)
            .AddWithValue("@FechaAlta", senia.FechaAlta)
            .AddWithValue("@FechaEstimadaRetiro", senia.FechaEstimadaRetiro)
            .AddWithValue("@FormaEntrega", senia.FormaEntrega)
            .AddWithValue("@Observaciones", senia.Observaciones)
            .AddWithValue("@Entregada", senia.Entregada)
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
                Dim Senia As Entidades.Senia = New Entidades.Senia()
                With Senia
                    .Id = row.Item("id_Senia")
                    .IdSucursal = row.Item("id_Sucursal")
                    .IdClienteMinorista = row.Item("id_ClienteMinorista")
                    .ApellidoNombreClienteMinorista = If(row.Item("NombreMinorista") Is DBNull.Value, String.Empty, row.Item("NombreMinorista"))
                    .IdClienteMayorista = row.Item("id_ClienteMayorista")
                    .RazonSocial = If(row.Item("RazonSocial") Is DBNull.Value, String.Empty, row.Item("RazonSocial"))
                    .Idventa = row.Item("id_Venta")
                    .FechaAlta = row.Item("FechaAlta")
                    .FechaEstimadaRetiro = row.Item("FechaEstimadaRetiro")
                    .FormaEntrega = row.Item("FormaEntrega")
                    .Observaciones = row.Item("Observaciones")
                    .MontoTotal = row.Item("Precio_Total")
                    .MontoSenia = row.Item("MontoSenia")
                    .Entregada = row.Item("Entregada")
                End With

                Senias.Add(Senia)
            Next
        End If
        Return Senias.Where(Function(x) Not x.Entregada).ToList()
    End Function

End Class
