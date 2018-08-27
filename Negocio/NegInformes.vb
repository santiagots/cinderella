Imports System.Data.SqlClient
Imports Entidades

Public Class NegInformes
    Private Shared clsDatos As New Datos.Conexion

    Public Shared Function ObtenerVentas(id_Sucursales As List(Of Integer), FDesde As Date, FHasta As Date) As List(Of InformeVenta)
        'Declaro variables
        Dim cmd As New SqlCommand
        Dim dt As DataTable = New DataTable()

        'Cargo el listado de sucursales
        dt.Columns.Add("ID", Type.GetType("System.Int64"))
        For Each id As Integer In id_Sucursales
            dt.Rows.Add(id)
        Next

        cmd.Connection = clsDatos.ConectarRemoto()
        dt = InvocarSP(cmd, "sp_InformeVentas_Ventas", dt, FDesde, FHasta, 0, 0)
        clsDatos.DesconectarRemoto()

        Return dt.Rows.Cast(Of DataRow).Select(
            Function(x) New InformeVenta() With {
                .CantidadFacturar = x("CantidadFacturar").ToString(),
                .CantidadSinFacturar = x("CantidadSinFacturar").ToString(),
                .Facturado = x("Facturado").ToString(),
                .FormaPago = x("FormaPago").ToString(),
                .MontoFacturar = x("MontoFacturar").ToString(),
                .MontoSinFacturar = x("MontoSinFacturar").ToString(),
                .MontoTotal = x("MontoTotal").ToString(),
                .TipoCliente = x("TipoCliente").ToString(),
                .CantidadTotal = x("CantidadTotal").ToString()
                }).ToList()

    End Function

    Public Shared Function ObtenerCantidadCuotas(id_Sucursales As List(Of Integer), FDesde As Date, FHasta As Date) As List(Of InformeCuotas)
        'Declaro variables
        Dim cmd As New SqlCommand
        Dim dt As DataTable = New DataTable()

        'Cargo el listado de sucursales
        dt.Columns.Add("ID", Type.GetType("System.Int64"))
        For Each id As Integer In id_Sucursales
            dt.Rows.Add(id)
        Next

        cmd.Connection = clsDatos.ConectarRemoto()
        dt = InvocarSP(cmd, "sp_InformeVentas_CantidadCuotas", dt, FDesde, FHasta, 0, 0)
        clsDatos.DesconectarRemoto()

        Return dt.Rows.Cast(Of DataRow).Select(
            Function(x) New InformeCuotas() With {
                .Cantidad = x("Cantidad").ToString(),
                .NroCuota = x("NroCuota").ToString()
                }).ToList()

    End Function

    Public Shared Function ObtenerProductos(id_Sucursales As List(Of Integer), FDesde As Date, FHasta As Date, PaginaNumero As Integer, PaginaTamaño As Integer) As List(Of InformeProductos)
        'Declaro variables
        Dim cmd As New SqlCommand
        Dim dt As DataTable = New DataTable()

        'Cargo el listado de sucursales
        dt.Columns.Add("ID", Type.GetType("System.Int64"))
        For Each id As Integer In id_Sucursales
            dt.Rows.Add(id)
        Next

        cmd.Connection = clsDatos.ConectarRemoto()
        dt = InvocarSP(cmd, "sp_InformeVentas_Productos", dt, FDesde, FHasta, PaginaNumero, PaginaTamaño)
        clsDatos.DesconectarRemoto()

        Return dt.Rows.Cast(Of DataRow).Select(
            Function(x) New InformeProductos() With {
            .Monto = x("Monto"),
            .Nombre = x("Nombre"),
            .Cantidad = x("Cantidad")
                }).ToList()

    End Function

    Public Shared Function ObtenerSubcategorias(id_Sucursales As List(Of Integer), FDesde As Date, FHasta As Date, PaginaNumero As Integer, PaginaTamaño As Integer) As List(Of InformeSubcategoria)
        'Declaro variables
        Dim cmd As New SqlCommand
        Dim dt As DataTable = New DataTable()

        'Cargo el listado de sucursales
        dt.Columns.Add("ID", Type.GetType("System.Int64"))
        For Each id As Integer In id_Sucursales
            dt.Rows.Add(id)
        Next

        cmd.Connection = clsDatos.ConectarRemoto()
        dt = InvocarSP(cmd, "sp_InformeVentas_Subcategoria", dt, FDesde, FHasta, PaginaNumero, PaginaTamaño)
        clsDatos.DesconectarRemoto()

        Return dt.Rows.Cast(Of DataRow).Select(
            Function(x) New InformeSubcategoria() With {
            .Monto = x("Monto"),
            .Nombre = x("Nombre"),
            .Cantidad = x("Cantidad")
                }).ToList()

    End Function

    Private Shared Function InvocarSP(ByRef cmd As SqlCommand, sp As String, IdSucursales As DataTable, FDesde As Date, FHasta As Date, PaginaNumero As Integer, PaginaTamaño As Integer) As DataTable
        cmd.CommandType = CommandType.StoredProcedure
        cmd.CommandText = sp

        cmd.Parameters.AddWithValue("@FDesde", FDesde)
        cmd.Parameters.AddWithValue("@FHasta", FHasta)
        If PaginaNumero > 0 Then
            cmd.Parameters.AddWithValue("@PaginaNumero", PaginaNumero)
        End If

        If PaginaTamaño > 0 Then
            cmd.Parameters.AddWithValue("@PaginaTamaño", PaginaTamaño)
        End If

        'Declaro el tipo de dato para el detalle de la venta
        Dim param = cmd.Parameters.AddWithValue("@id_Sucursales", IdSucursales)
        param.SqlDbType = SqlDbType.Structured
        param.TypeName = "dbo.LISTA_ID_TYPE"

        cmd.ExecuteNonQuery()

        Dim adapter As SqlDataAdapter = New SqlDataAdapter(cmd)
        Dim dt As DataTable = New DataTable()
        adapter.Fill(dt)
        Return dt
    End Function

End Class
