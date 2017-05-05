Imports Entidades
Imports System.Data.SqlClient
Imports Datos

Public Class NegTarjeta

    Public Shared Function TraerTarjetas() As List(Of Tarjeta)
        'Declaro variables
        Dim cmd As SqlCommand = New SqlCommand()
        Dim ClsFunciones As New Funciones
        Dim clsDatos As New Datos.Conexion
        Dim msg As String = ""
        Dim dsTarjetas As DataSet
        Dim respuesta As List(Of Tarjeta) = New List(Of Tarjeta)()

        'Conecto a la bdd.
        If (Funciones.HayInternet) Then
            dsTarjetas = clsDatos.ConsultarBaseRemoto("execute sp_Tarjeta_Listado")
        Else
            dsTarjetas = clsDatos.ConsultarBaseLocal("execute sp_Tarjeta_Listado")
        End If

        If dsTarjetas.Tables(0).Rows.Count > 0 Then
            For Each row As DataRow In dsTarjetas.Tables(0).Rows
                respuesta.Add(GetTarjetasFromRow(row))
            Next
        End If

        'retorno valor
        Return respuesta
    End Function

    Public Shared Function TarearCostoFinanciero() As DataTable
        Dim dsCostoFinanciero As New DataSet
        Dim ClsDatos As New Datos.Conexion

        If Funciones.HayInternet Then
            dsCostoFinanciero = ClsDatos.ConsultarBaseRemoto("execute sp_Tarjeta_Listado_CostoFinanciero")
        Else
            dsCostoFinanciero = ClsDatos.ConsultarBaseLocal("execute sp_Tarjeta_Listado_CostoFinanciero")
        End If

        Return dsCostoFinanciero.Tables(0)
    End Function

    Public Shared Function GuardarCostoFinanciero(tarjeta As Tarjeta, costoFinancieros As List(Of CostoFinanciero)) As Boolean
        Dim dt As DataTable = New DataTable()
        Dim cmd As New SqlCommand
        Dim ClsDatos As New Datos.Conexion

        'Cargo el detalle de la devolucion en un Tabla para pasarla por un campo al SP
        dt.Columns.Add("IdTrajeta", Type.GetType("System.Int32"))
        dt.Columns.Add("NroCuota", Type.GetType("System.Int32"))
        dt.Columns.Add("PorcentajeRecargo", Type.GetType("System.Double"))

        For Each item As CostoFinanciero In costoFinancieros
            dt.Rows.Add(item.Tarjeta, item.NumeroCuotas, item.PorcentajeRecargo)
        Next
        If Funciones.HayInternet Then
            cmd.Connection = ClsDatos.ConectarRemoto()
        Else
            cmd.Connection = ClsDatos.ConectarLocal()
        End If

        cmd.CommandType = CommandType.StoredProcedure
        cmd.CommandText = "sp_Tarjeta_AltaModificacion_costoFinanciero"
        With cmd.Parameters
            .AddWithValue("@IdTrajeta", tarjeta.TarjetaId)
            .AddWithValue("@Nombre", tarjeta.Nombre)
            .AddWithValue("@Habilitado", tarjeta.Habilitado)
        End With

        'Declaro el tipo de dato para el detalle de la venta
        Dim param = cmd.Parameters.AddWithValue("@CostoFinanciero", dt)
        param.SqlDbType = SqlDbType.Structured
        param.TypeName = "dbo.COSTO_FINANCIERO_TYPE"

        Dim respuesta As New SqlParameter("@msg", SqlDbType.Int, 255)
        respuesta.Direction = ParameterDirection.Output
        cmd.Parameters.Add(respuesta)

        cmd.ExecuteNonQuery()
        Return CBool(respuesta.Value)
    End Function

    Public Shared Function TraerCostosFinancieros(idTarejeta As Integer) As List(Of CostoFinanciero)
        Dim dsCostoFinanciero As New DataSet
        Dim ClsDatos As New Datos.Conexion
        Dim CostoFinancieros As List(Of CostoFinanciero) = New List(Of CostoFinanciero)


        If Funciones.HayInternet Then
            dsCostoFinanciero = ClsDatos.ConsultarBaseRemoto("execute sp_Tarjeta_CostoFinanciero @IdTrajeta = " + idTarejeta.ToString())
        Else
            dsCostoFinanciero = ClsDatos.ConsultarBaseLocal("execute sp_Tarjeta_CostoFinanciero @IdTrajeta = " + idTarejeta.ToString())
        End If

        If dsCostoFinanciero.Tables(0).Rows.Count > 0 Then
            For Each row As DataRow In dsCostoFinanciero.Tables(0).Rows
                CostoFinancieros.Add(GetCostoFinancieroFromRow(row))
            Next
        End If

        Return CostoFinancieros
    End Function

    Public Shared Sub EliminarTarjeta(idTarjeta As Integer)
        Dim dsCostoFinanciero As New DataSet
        Dim ClsDatos As New Datos.Conexion

        If Funciones.HayInternet Then
            ClsDatos.ConsultarBaseRemoto("execute sp_Tarjeta_Eliminar @IdTrajeta = " + idTarjeta.ToString())
        Else
            ClsDatos.ConsultarBaseLocal("execute sp_Tarjeta_Eliminar @IdTrajeta = " + idTarjeta.ToString())
        End If

    End Sub

    Private Shared Function GetCostoFinancieroFromRow(row As DataRow) As Object
        Dim banco As CostoFinanciero = New CostoFinanciero With {
            .Tarjeta = row.Item("IdTarjeta"),
            .CostoFinancieroId = row.Item("CostoFinancieroId"),
            .NumeroCuotas = row.Item("NroCuota"),
            .PorcentajeRecargo = row.Item("PorcentajeRecargo")
        }
        Return banco
    End Function


    Private Shared Function GetTarjetasFromRow(row As DataRow) As Tarjeta
        Dim tarjeta As Tarjeta = New Tarjeta With {
            .Nombre = row.Item("Nombre"),
            .TarjetaId = row.Item("TarjetaId"),
            .Habilitado = row.Item("Habilitado")
        }

        Return tarjeta
    End Function
End Class
