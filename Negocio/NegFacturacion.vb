Imports System.Data.SqlClient
Imports Datos

Public Class NegFacturacion
    Dim ClsDatos As New Datos.Conexion
    Dim ClsFunciones As New Funciones
    Dim HayInternet As Boolean = ClsFunciones.GotInternet
    Dim con As New Conexion

    'Funcion que inserta un nuevo registro en la tabla VENTAS_DETALLE.
    Public Function NuevaFacturacion(ByVal EntFacturacion As Entidades.Facturacion) As Boolean
        'Declaro variables
        Dim cmd As New SqlCommand
        Dim msg As String = ""
        Try
            'Conecto a la bdd.
            If (HayInternet) Then
                cmd.Connection = ClsDatos.ConectarRemoto()
            Else
                cmd.Connection = ClsDatos.ConectarLocal()
            End If

            'Ejecuto el stored.
            cmd.CommandType = CommandType.StoredProcedure
            cmd.CommandText = "sp_Facturacion_Alta"
            With cmd.Parameters
                .AddWithValue("@id_Venta", EntFacturacion.id_Venta)
                .AddWithValue("@NumeroFactura", EntFacturacion.NumeroFactura)
                .AddWithValue("@Monto", EntFacturacion.Monto)
                .AddWithValue("@Nombre", EntFacturacion.Nombre)
                .AddWithValue("@Cuit", EntFacturacion.Cuit)
                .AddWithValue("@Direccion", EntFacturacion.Direccion)
                .AddWithValue("@Localidad", EntFacturacion.Localidad)
                .AddWithValue("@TipoFactura", EntFacturacion.TipoFactura)
            End With

            'Respuesta del stored.
            Dim respuesta As New SqlParameter("@msg", SqlDbType.Int, 255)
            respuesta.Direction = ParameterDirection.Output
            cmd.Parameters.Add(respuesta)
            cmd.ExecuteNonQuery()

            'Desconecto la bdd.
            If (HayInternet) Then
                ClsDatos.DesconectarRemoto()
            Else
                ClsDatos.DesconectarLocal()
            End If

            'retorno valor
            Return CBool(respuesta.Value)
        Catch ex As Exception
            Return False
        End Try
    End Function

    'Funcion para consultar una factura.
    Public Function TraerFacturacion(ByVal id_Venta As Integer)
        Dim dsFactura As New DataSet
        Dim entFactura As New Entidades.Facturacion

        If (HayInternet) Then
            dsFactura = ClsDatos.ConsultarBaseRemoto("execute sp_Facturacion_Detalle @id_Venta=" & id_Venta)
        Else
            dsFactura = ClsDatos.ConsultarBaseLocal("execute sp_Facturacion_Detalle @id_Venta=" & id_Venta)
        End If

        If dsFactura.Tables(0).Rows.Count <> 0 Then
            entFactura.id_Facturacion = dsFactura.Tables(0).Rows(0).Item("id_Facturacion").ToString
            entFactura.id_Venta = dsFactura.Tables(0).Rows(0).Item("id_Venta").ToString
            entFactura.NumeroFactura = dsFactura.Tables(0).Rows(0).Item("NumeroFactura").ToString
            entFactura.Monto = dsFactura.Tables(0).Rows(0).Item("Monto").ToString
            entFactura.TipoFactura = dsFactura.Tables(0).Rows(0).Item("TipoFactura").ToString
            entFactura.Nombre = dsFactura.Tables(0).Rows(0).Item("Nombre").ToString
            entFactura.Direccion = dsFactura.Tables(0).Rows(0).Item("Direccion").ToString
            entFactura.Localidad = dsFactura.Tables(0).Rows(0).Item("Localidad").ToString
            entFactura.Cuit = dsFactura.Tables(0).Rows(0).Item("Cuit").ToString
            entFactura.Fecha = dsFactura.Tables(0).Rows(0).Item("Fecha").ToString
        End If
        Return entFactura
    End Function
End Class
