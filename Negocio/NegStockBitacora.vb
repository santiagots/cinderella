Imports System.Data.SqlClient
Public Class NegStockBitacora
    Dim clsDatos As New Datos.Conexion
    Dim ClsFunciones As New Funciones
    Dim HayInternet As Boolean = ClsFunciones.GotInternet

    'Funcion para listar todos las acciones sobre stock.
    Function ListadoBitacoraSucursal(ByVal id_Sucursal As Integer, ByVal FDesde As String, ByVal FHasta As String) As DataSet
        If HayInternet Then
            Return clsDatos.ConsultarBaseRemoto("execute sp_StockBitacora_ListadoSucursal @id_Sucursal=" & id_Sucursal & ", @FDesde='" & FDesde & "', @FHasta='" & FHasta & "'")
        Else
            Return clsDatos.ConsultarBaseLocal("execute sp_StockBitacora_ListadoSucursal @id_Sucursal=" & id_Sucursal & ", @FDesde='" & FDesde & "', @FHasta='" & FHasta & "'")
        End If
    End Function

    'Funcion para insertar un stock.
    Function AltaStockBitacora(ByVal estock As Entidades.Stock_Bitacora) As String
        'Declaro variables
        Dim cmd As New SqlCommand
        Dim msg As String = ""

        Try
            'Conecto la bdd.
            If HayInternet Then
                cmd.Connection = clsDatos.ConectarRemoto()
            Else
                cmd.Connection = clsDatos.ConectarLocal()
            End If

            'Ejecuto el Stored.
            cmd.CommandType = CommandType.StoredProcedure
            cmd.CommandText = "sp_StockBitacora_Alta"
            With cmd.Parameters
                .AddWithValue("@id_Producto", estock.id_Producto)
                .AddWithValue("@id_Stock", estock.id_Stock)
                .AddWithValue("@id_Sucursal", estock.id_Sucursal)
                .AddWithValue("@Stock_Minimo", estock.Stock_Minimo)
                .AddWithValue("@Stock_Actual", estock.Stock_Actual)
                .AddWithValue("@Stock_Optimo", estock.Stock_Optimo)
                .AddWithValue("@Stock_Minimo_Ant", estock.Stock_Minimo_Ant)
                .AddWithValue("@Stock_Actual_Ant", estock.Stock_Actual_Ant)
                .AddWithValue("@Stock_Optimo_Ant", estock.Stock_Optimo_Ant)
                .AddWithValue("@id_Usuario", estock.id_Usuario)
                .AddWithValue("@Usuario", estock.Usuario)
                .AddWithValue("@Motivo", estock.Motivo)
                .AddWithValue("@Accion", estock.Accion)
                .AddWithValue("@Fecha", estock.Fecha)
                .AddWithValue("@Habilitado", estock.Habilitado)
            End With

            'Respuesta del Stored.
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

            'muestro el mensaje
            Return CInt(respuesta.Value)
        Catch ex As Exception
            Return 0
        End Try
    End Function
End Class
