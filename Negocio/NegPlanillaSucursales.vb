Imports System.Data.SqlClient

Public Class NegPlanillaSucursales
    Dim clsDatos As New Datos.Conexion
    Dim ClsFunciones As New Funciones
    Dim HayInternet As Boolean = ClsFunciones.GotInternet

    'Obtener Ventas
    Function ObtenerVentas(ByVal id_Sucursal As Integer, ByVal FDesde As String, ByVal FHasta As String) As DataSet
        Dim ds As New DataSet
        If HayInternet Then
            ds = clsDatos.ConsultarBaseRemoto("execute sp_Movimiento_Sucursales_Ventas @id_Sucursal=" & id_Sucursal & ", @FDesde='" & FDesde & "', @FHasta='" & FHasta & "'")
        Else
            ds = clsDatos.ConsultarBaseLocal("execute sp_Movimiento_Sucursales_Ventas @id_Sucursal=" & id_Sucursal & ", @FDesde='" & FDesde & "', @FHasta='" & FHasta & "'")
        End If

        SetCeroToDBnull(ds)
        AddTotalColumn(ds, "Total")
        Return ds
    End Function

    'Obtener Disponibilidades
    Function ObtenerDisponibilidades(ByVal id_Sucursal As Integer, ByVal FDesde As String, ByVal FHasta As String) As DataSet
        Dim ds As New DataSet
        If HayInternet Then
            ds = clsDatos.ConsultarBaseRemoto("execute sp_Movimiento_Sucursales_Disponibilidades @id_Sucursal=" & id_Sucursal & ", @FDesde='" & FDesde & "', @FHasta='" & FHasta & "'")
        Else
            ds = clsDatos.ConsultarBaseLocal("execute sp_Movimiento_Sucursales_Disponibilidades @id_Sucursal=" & id_Sucursal & ", @FDesde='" & FDesde & "', @FHasta='" & FHasta & "'")
        End If

        SetCeroToDBnull(ds)
        AddTotalColumn(ds, "Total")
        Return ds
    End Function

    'Obtener Mercaderia
    Function ObtenerMercaderia(ByVal id_Sucursal As Integer, ByVal FDesde As String, ByVal FHasta As String) As DataSet
        Dim ds As New DataSet
        If HayInternet Then
            ds = clsDatos.ConsultarBaseRemoto("execute sp_Movimiento_Sucursales_Mercaderia @id_Sucursal=" & id_Sucursal & ", @FDesde='" & FDesde & "', @FHasta='" & FHasta & "'")
        Else
            ds = clsDatos.ConsultarBaseLocal("execute sp_Movimiento_Sucursales_Mercaderia @id_Sucursal=" & id_Sucursal & ", @FDesde='" & FDesde & "', @FHasta='" & FHasta & "'")
        End If

        SetCeroToDBnull(ds)
        AddTotalColumn(ds, "Total")
        Return ds
    End Function

    'Obtener Mercaderia Detalle
    Function ObtenerMercaderiaDetalle(ByVal id_Sucursal As Integer, ByVal FDesde As String, ByVal FHasta As String) As DataSet
        Dim ds As New DataSet
        If HayInternet Then
            ds = clsDatos.ConsultarBaseRemoto("execute sp_Movimiento_Sucursales_Mercaderia_Detalle @id_Sucursal=" & id_Sucursal & ", @FDesde='" & FDesde & "', @FHasta='" & FHasta & "'")
        Else
            ds = clsDatos.ConsultarBaseLocal("execute sp_Movimiento_Sucursales_Mercaderia_Detalle @id_Sucursal=" & id_Sucursal & ", @FDesde='" & FDesde & "', @FHasta='" & FHasta & "'")
        End If

        SetCeroToDBnull(ds)
        AddTotalColumn(ds, "Total")
        Return ds
    End Function

    'Obtener Sueldos
    Function ObtenerSueldos(ByVal id_Sucursal As Integer, ByVal FDesde As String, ByVal FHasta As String) As DataSet
        Dim ds As New DataSet
        If HayInternet Then
            ds = clsDatos.ConsultarBaseRemoto("execute sp_Movimiento_Sucursales_Sueldos @id_Sucursal=" & id_Sucursal & ", @FDesde='" & FDesde & "', @FHasta='" & FHasta & "'")
        Else
            ds = clsDatos.ConsultarBaseLocal("execute sp_Movimiento_Sucursales_Sueldos @id_Sucursal=" & id_Sucursal & ", @FDesde='" & FDesde & "', @FHasta='" & FHasta & "'")
        End If

        SetCeroToDBnull(ds)
        AddTotalColumn(ds, "Total")
        Return ds
    End Function

    'Obtener Sueldos Detalle
    Function ObtenerSueldosDetalle(ByVal id_Sucursal As Integer, ByVal FDesde As String, ByVal FHasta As String) As DataSet
        Dim ds As New DataSet
        If HayInternet Then
            ds = clsDatos.ConsultarBaseRemoto("execute sp_Movimiento_Sucursales_Sueldos_Detalle @id_Sucursal=" & id_Sucursal & ", @FDesde='" & FDesde & "', @FHasta='" & FHasta & "'")
        Else
            ds = clsDatos.ConsultarBaseLocal("execute sp_Movimiento_Sucursales_Sueldos_Detalle @id_Sucursal=" & id_Sucursal & ", @FDesde='" & FDesde & "', @FHasta='" & FHasta & "'")
        End If

        SetCeroToDBnull(ds)
        AddTotalColumn(ds, "Total")
        Return ds
    End Function

    'Obtener Caja
    Function ObtenerCaja(ByVal id_Sucursal As Integer, ByVal FDesde As String, ByVal FHasta As String) As DataSet
        Dim ds As New DataSet
        If HayInternet Then
            ds = clsDatos.ConsultarBaseRemoto("execute sp_Movimiento_Sucursales_Caja @id_Sucursal=" & id_Sucursal & ", @FDesde='" & FDesde & "', @FHasta='" & FHasta & "'")
        Else
            ds = clsDatos.ConsultarBaseLocal("execute sp_Movimiento_Sucursales_Caja @id_Sucursal=" & id_Sucursal & ", @FDesde='" & FDesde & "', @FHasta='" & FHasta & "'")
        End If

        SetCeroToDBnull(ds)
        AddTotalColumn(ds, "Total")
        Return ds
    End Function

    'Obtener Movimiento Socios
    Function ObtenerMovimientoSocios(ByVal id_Sucursal As Integer, ByVal FDesde As String, ByVal FHasta As String) As DataSet
        Dim ds As New DataSet
        If HayInternet Then
            ds = clsDatos.ConsultarBaseRemoto("execute sp_Movimiento_Sucursales_Socios @id_Sucursal=" & id_Sucursal & ", @FDesde='" & FDesde & "', @FHasta='" & FHasta & "'")
        Else
            ds = clsDatos.ConsultarBaseLocal("execute sp_Movimiento_Sucursales_Socios @id_Sucursal=" & id_Sucursal & ", @FDesde='" & FDesde & "', @FHasta='" & FHasta & "'")
        End If

        SetCeroToDBnull(ds)
        AddTotalColumn(ds, "Total")
        Return ds
    End Function

    'Obtener Movimientos Sucursales
    Function ObtenerMovimientosSucursales(ByVal id_Sucursal As Integer, ByVal FDesde As String, ByVal FHasta As String) As DataSet
        Dim ds As New DataSet
        If HayInternet Then
            ds = clsDatos.ConsultarBaseRemoto("execute sp_Movimiento_Sucursales_Movimientos_Sucursales @id_Sucursal=" & id_Sucursal & ", @FDesde='" & FDesde & "', @FHasta='" & FHasta & "'")
        Else
            ds = clsDatos.ConsultarBaseLocal("execute sp_Movimiento_Sucursales_Movimientos_Sucursales @id_Sucursal=" & id_Sucursal & ", @FDesde='" & FDesde & "', @FHasta='" & FHasta & "'")
        End If

        SetCeroToDBnull(ds)
        AddTotalColumn(ds, "Total")
        Return ds
    End Function

    'Obtener Movimientos Sucursales Envios
    Function ObtenerMovimientosSucursalesEnvios(ByVal id_Sucursal As Integer, ByVal FDesde As String, ByVal FHasta As String) As DataSet
        Dim ds As New DataSet
        If HayInternet Then
            ds = clsDatos.ConsultarBaseRemoto("execute sp_Movimiento_Sucursales_Envios @id_Sucursal=" & id_Sucursal & ", @FDesde='" & FDesde & "', @FHasta='" & FHasta & "'")
        Else
            ds = clsDatos.ConsultarBaseLocal("execute sp_Movimiento_Sucursales_Envios @id_Sucursal=" & id_Sucursal & ", @FDesde='" & FDesde & "', @FHasta='" & FHasta & "'")
        End If

        SetCeroToDBnull(ds)
        AddTotalColumn(ds, "Total")
        Return ds
    End Function

    'Obtener Movimientos Sucursales Recibos
    Function ObtenerMovimientosSucursalesRecibos(ByVal id_Sucursal As Integer, ByVal FDesde As String, ByVal FHasta As String) As DataSet
        Dim ds As New DataSet
        If HayInternet Then
            ds = clsDatos.ConsultarBaseRemoto("execute sp_Movimiento_Sucursales_Recibos @id_Sucursal=" & id_Sucursal & ", @FDesde='" & FDesde & "', @FHasta='" & FHasta & "'")
        Else
            ds = clsDatos.ConsultarBaseLocal("execute sp_Movimiento_Sucursales_Recibos @id_Sucursal=" & id_Sucursal & ", @FDesde='" & FDesde & "', @FHasta='" & FHasta & "'")
        End If

        SetCeroToDBnull(ds)
        AddTotalColumn(ds, "Total")
        Return ds
    End Function

    'Obtener Impuestos
    Function ObtenerImpuestos(ByVal id_Sucursal As Integer, ByVal FDesde As String, ByVal FHasta As String) As DataSet
        Dim ds As New DataSet
        If HayInternet Then
            ds = clsDatos.ConsultarBaseRemoto("execute sp_Movimiento_Sucursales_Impuestos @id_Sucursal=" & id_Sucursal & ", @FDesde='" & FDesde & "', @FHasta='" & FHasta & "'")
        Else
            ds = clsDatos.ConsultarBaseLocal("execute sp_Movimiento_Sucursales_Impuestos @id_Sucursal=" & id_Sucursal & ", @FDesde='" & FDesde & "', @FHasta='" & FHasta & "'")
        End If

        SetCeroToDBnull(ds)
        AddTotalColumn(ds, "Total")
        Return ds
    End Function

    'Obtener Gastos
    Function ObtenerGastos(ByVal id_Sucursal As Integer, ByVal FDesde As String, ByVal FHasta As String) As DataSet
        Dim ds As New DataSet
        If HayInternet Then
            ds = clsDatos.ConsultarBaseRemoto("execute sp_Movimiento_Sucursales_Gastos @id_Sucursal=" & id_Sucursal & ", @FDesde='" & FDesde & "', @FHasta='" & FHasta & "'")
        Else
            ds = clsDatos.ConsultarBaseLocal("execute sp_Movimiento_Sucursales_Gastos @id_Sucursal=" & id_Sucursal & ", @FDesde='" & FDesde & "', @FHasta='" & FHasta & "'")
        End If

        SetCeroToDBnull(ds)
        AddTotalColumn(ds, "Total")
        Return ds
    End Function

    'Obtener Indice Sueldo
    Function ObtenerIndiceSueldo(ByVal id_Sucursal As Integer, ByVal FDesde As String, ByVal FHasta As String) As DataSet
        Dim ds As New DataSet
        If HayInternet Then
            ds = clsDatos.ConsultarBaseRemoto("execute sp_Movimiento_Sucursales_Indice_Sueldo @id_Sucursal=" & id_Sucursal & ", @FDesde='" & FDesde & "', @FHasta='" & FHasta & "'")
        Else
            ds = clsDatos.ConsultarBaseLocal("execute sp_Movimiento_Sucursales_Indice_Sueldo @id_Sucursal=" & id_Sucursal & ", @FDesde='" & FDesde & "', @FHasta='" & FHasta & "'")
        End If

        SetCeroToDBnull(ds)
        CalculateIndex(ds, "Indice Sueldos / Ventas")
        Return ds
    End Function

    'Obtener Indice Mercaderia
    Function ObtenerIndiceMercaderia(ByVal id_Sucursal As Integer, ByVal FDesde As String, ByVal FHasta As String) As DataSet
        Dim ds As New DataSet
        If HayInternet Then
            ds = clsDatos.ConsultarBaseRemoto("execute sp_Movimiento_Sucursales_Indice_Mercaderia @id_Sucursal=" & id_Sucursal & ", @FDesde='" & FDesde & "', @FHasta='" & FHasta & "'")
        Else
            ds = clsDatos.ConsultarBaseLocal("execute sp_Movimiento_Sucursales_Indice_Mercaderia @id_Sucursal=" & id_Sucursal & ", @FDesde='" & FDesde & "', @FHasta='" & FHasta & "'")
        End If

        SetCeroToDBnull(ds)
        CalculateIndex(ds, "Indice Mercaderías / Ventas")
        Return ds
    End Function

    'Obtener Indice Alquiler
    Function ObtenerIndiceAlquiler(ByVal id_Sucursal As Integer, ByVal FDesde As String, ByVal FHasta As String) As DataSet
        Dim ds As New DataSet
        If HayInternet Then
            ds = clsDatos.ConsultarBaseRemoto("execute sp_Movimiento_Sucursales_Indice_Alquiler @id_Sucursal=" & id_Sucursal & ", @FDesde='" & FDesde & "', @FHasta='" & FHasta & "'")
        Else
            ds = clsDatos.ConsultarBaseLocal("execute sp_Movimiento_Sucursales_Indice_Alquiler @id_Sucursal=" & id_Sucursal & ", @FDesde='" & FDesde & "', @FHasta='" & FHasta & "'")
        End If

        SetCeroToDBnull(ds)
        CalculateIndex(ds, "Indice Alquiler / Ventas")
        Return ds
    End Function

    Sub SetCeroToDBnull(ds As DataSet)
        For Each row As DataRow In ds.Tables(0).Rows

            For Each col As DataColumn In ds.Tables(0).Columns

                If (IsDBNull(row(col))) Then
                    row(col) = 0
                End If
            Next
        Next
    End Sub

    Sub AddTotalColumn(ds As DataSet, descripcion As String)

        ds.Tables(0).Columns.Add(descripcion, System.Type.GetType("System.Double")).SetOrdinal(2)

        For Each row As DataRow In ds.Tables(0).Rows
            For i As Integer = 3 To ds.Tables(0).Columns.Count - 1
                If (IsDBNull(row(2))) Then
                    row(2) = 0
                End If
                row(2) += row(i)
            Next
        Next
    End Sub

    Sub CalculateIndex(ds As DataSet, descripcion As String)

        Dim index As DataRow = ds.Tables(0).NewRow()
        index(0) = descripcion
        index(1) = -1

        For i As Integer = 2 To ds.Tables(0).Columns.Count - 1
            If (IsDBNull(index(i))) Then
                index(i) = 0
            End If

            Dim dividendo = ds.Tables(0).Rows(0)(i)
            Dim divisor = ds.Tables(0).Rows(1)(i)

            If (divisor <> 0) Then
                index(i) = dividendo / divisor
            End If
        Next
        ds.Tables(0).Rows.Clear()
        ds.Tables(0).Rows.InsertAt(index, 0)
    End Sub


End Class
