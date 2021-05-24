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
        dt = InvocarSP(cmd, "sp_InformeVentas_Ventas", dt, FDesde, FHasta)
        clsDatos.DesconectarRemoto()

        Return dt.Rows.Cast(Of DataRow).Select(
            Function(x) New InformeVenta() With {
            .CantidadFacturar = x("CantidadFacturar"),
            .CantidadTotal = x("CantidadTotal"),
            .CantidadSinFacturar = x("CantidadSinFacturar"),
            .Facturado = x("Facturado"),
            .FormaPago = x("FormaPago"),
            .MontoFacturar = x("MontoFacturar"),
            .MontoSinFacturar = x("MontoSinFacturar"),
            .MontoTotal = x("MontoTotal"),
            .TipoCliente = x("TipoCliente")
                }).ToList()

    End Function

    Public Shared Function ObtenerCantidadCuotas(id_Sucursales As List(Of Integer), FDesde As Date, FHasta As Date) As DataTable
        'Declaro variables
        Dim cmd As New SqlCommand
        Dim dt As DataTable = New DataTable()

        'Cargo el listado de sucursales
        dt.Columns.Add("ID", Type.GetType("System.Int64"))
        For Each id As Integer In id_Sucursales
            dt.Rows.Add(id)
        Next

        cmd.Connection = clsDatos.ConectarRemoto()
        dt = InvocarSP(cmd, "sp_InformeVentas_CantidadCuotas", dt, FDesde, FHasta)
        clsDatos.DesconectarRemoto()

        Return dt
    End Function


    Public Shared Function ObtenerCostos(id_Sucursales As List(Of Integer), FDesde As Date, FHasta As Date) As DataTable
        'Declaro variables
        Dim cmd As New SqlCommand
        Dim dt As DataTable = New DataTable()

        'Cargo el listado de sucursales
        dt.Columns.Add("ID", Type.GetType("System.Int64"))
        For Each id As Integer In id_Sucursales
            dt.Rows.Add(id)
        Next

        cmd.Connection = clsDatos.ConectarRemoto()
        dt = InvocarSP(cmd, "sp_InformeVentas_Costo", dt, FDesde, FHasta)
        clsDatos.DesconectarRemoto()

        Return dt
    End Function


    Public Shared Function ObtenerGastos(id_Sucursales As List(Of Integer), FDesde As Date, FHasta As Date) As DataTable
        'Declaro variables
        Dim cmd As New SqlCommand
        Dim dt As DataTable = New DataTable()

        'Cargo el listado de sucursales
        dt.Columns.Add("ID", Type.GetType("System.Int64"))
        For Each id As Integer In id_Sucursales
            dt.Rows.Add(id)
        Next

        cmd.Connection = clsDatos.ConectarRemoto()
        dt = InvocarSP(cmd, "sp_InformeVentas_Gastos", dt, FDesde, FHasta)
        clsDatos.DesconectarRemoto()

        Return dt
    End Function

    Public Shared Function ObtenerSueldosPagos(id_Sucursales As List(Of Integer), FDesde As Date, FHasta As Date) As Double
        'Declaro variables
        Dim cmd As New SqlCommand
        Dim dt As DataTable = New DataTable()
        Dim SueldosPagos As Double = 0

        'Cargo el listado de sucursales
        dt.Columns.Add("ID", Type.GetType("System.Int64"))
        For Each id As Integer In id_Sucursales
            dt.Rows.Add(id)
        Next

        cmd.Connection = clsDatos.ConectarRemoto()
        SueldosPagos = ObtenerSueldosPagos(cmd, dt, FDesde, FHasta)
        clsDatos.DesconectarRemoto()

        Return SueldosPagos
    End Function

    Private Shared Function ObtenerSueldosPagos(ByRef cmd As SqlCommand, IdSucursales As DataTable, FDesde As Date, FHasta As Date) As Double
        cmd.CommandType = CommandType.StoredProcedure
        cmd.CommandText = "sp_InformeVentas_SueldoPagos"

        cmd.Parameters.AddWithValue("@FDesde", FDesde)
        cmd.Parameters.AddWithValue("@FHasta", FHasta)

        'Declaro el tipo de dato para el detalle de la venta
        Dim param = cmd.Parameters.AddWithValue("@id_Sucursales", IdSucursales)
        param.SqlDbType = SqlDbType.Structured
        param.TypeName = "dbo.LISTA_ID_TYPE"

        Dim Adelantos As New SqlParameter("@Adelantos", SqlDbType.Float)
        Adelantos.Direction = ParameterDirection.Output
        cmd.Parameters.Add(Adelantos)

        Dim Depositos As New SqlParameter("@Depositos", SqlDbType.Float)
        Depositos.Direction = ParameterDirection.Output
        cmd.Parameters.Add(Depositos)

        cmd.ExecuteNonQuery()

        Return Adelantos.Value + Depositos.Value
    End Function

    Public Shared Function ObtenerSueldosDevengados(id_Sucursales As List(Of Integer), FDesde As Date, FHasta As Date) As Double
        'Declaro variables
        Dim dt As DataTable = New DataTable()
        Dim SueldosDevengados As Double = 0

        'Cargo el listado de sucursales
        dt.Columns.Add("ID", Type.GetType("System.Int64"))
        For Each id As Integer In id_Sucursales
            dt.Rows.Add(id)
        Next

        Dim periodos As IList(Of Tuple(Of DateTime, DateTime)) = MesesEntre(FDesde, FHasta)

        For Each periodo As Tuple(Of DateTime, DateTime) In periodos

            Dim FDesdePresentismo As Date = New DateTime(periodo.Item1.Year, periodo.Item1.Month, 1)
            Dim FHastaPresentismo As Date = periodo.Item2
            Dim cmd As New SqlCommand
            cmd.Connection = clsDatos.ConectarRemoto()
            SueldosDevengados += ObtenerSueldosDevengados(cmd, dt, periodo.Item1, periodo.Item2, FDesdePresentismo, FHastaPresentismo)
            cmd.Connection = clsDatos.ConectarRemoto()
        Next

        clsDatos.DesconectarRemoto()

        Return SueldosDevengados
    End Function

    Private Shared Function ObtenerSueldosDevengados(ByRef cmd As SqlCommand, IdSucursales As DataTable, FDesde As Date, FHasta As Date, FDesdePresentismo As Date, FHastaPresentismo As Date) As Double
        cmd.CommandType = CommandType.StoredProcedure
        cmd.CommandText = "sp_InformeVentas_SueldosDevengado"

        cmd.Parameters.AddWithValue("@FDesde", FDesde)
        cmd.Parameters.AddWithValue("@FHasta", FHasta)
        cmd.Parameters.AddWithValue("@FDesdePresentismo", FDesdePresentismo)
        cmd.Parameters.AddWithValue("@FHastaPresentismo", FHastaPresentismo)

        'Declaro el tipo de dato para el detalle de la venta
        Dim param = cmd.Parameters.AddWithValue("@id_Sucursales", IdSucursales)
        param.SqlDbType = SqlDbType.Structured
        param.TypeName = "dbo.LISTA_ID_TYPE"

        Dim SueldoDiasFeriado As New SqlParameter("@SueldoDiasFeriado", SqlDbType.Float)
        SueldoDiasFeriado.Direction = ParameterDirection.Output
        cmd.Parameters.Add(SueldoDiasFeriado)

        Dim SueldoDiasNormal As New SqlParameter("@SueldoDiasNormal", SqlDbType.Float)
        SueldoDiasNormal.Direction = ParameterDirection.Output
        cmd.Parameters.Add(SueldoDiasNormal)

        Dim SueldoDiasTarde As New SqlParameter("@SueldoDiasTarde", SqlDbType.Float)
        SueldoDiasTarde.Direction = ParameterDirection.Output
        cmd.Parameters.Add(SueldoDiasTarde)

        Dim SueldoPresentismo As New SqlParameter("@SueldoPresentismo", SqlDbType.Float)
        SueldoPresentismo.Direction = ParameterDirection.Output
        cmd.Parameters.Add(SueldoPresentismo)

        Dim Adicionales As New SqlParameter("@Adicionales", SqlDbType.Float)
        Adicionales.Direction = ParameterDirection.Output
        cmd.Parameters.Add(Adicionales)

        Dim Comisiones As New SqlParameter("@Comisiones", SqlDbType.Float)
        Comisiones.Direction = ParameterDirection.Output
        cmd.Parameters.Add(Comisiones)

        cmd.ExecuteNonQuery()

        Return SueldoDiasFeriado.Value + SueldoDiasNormal.Value + SueldoDiasTarde.Value + SueldoPresentismo.Value + Adicionales.Value + Comisiones.Value
    End Function



    Public Shared Function ObtenerProductos(idProducto As String, idCategoria As String, idSubcategoria As String, id_Sucursales As List(Of Integer), FDesde As Date, FHasta As Date, PaginaNumero As Integer, PaginaTamaño As Integer, ordenadoPor As String, direccion As Integer, ByRef TotalElementos As Integer) As DataTable
        'Declaro variables
        Dim cmd As New SqlCommand
        Dim dt As DataTable = New DataTable()

        'Cargo el listado de sucursales
        dt.Columns.Add("ID", Type.GetType("System.Int64"))
        For Each id As Integer In id_Sucursales
            dt.Rows.Add(id)
        Next

        cmd.Connection = clsDatos.ConectarRemoto()
        dt = InvocarSPPaginadoConFiltro(cmd, "sp_InformeVentas_Productos", idProducto, idCategoria, idSubcategoria, dt, FDesde, FHasta, PaginaNumero, PaginaTamaño, ordenadoPor, direccion)
        clsDatos.DesconectarRemoto()

        TotalElementos = If(dt.Rows.Count > 0, dt(0)("TotalRegistros"), 0)

        Return dt
    End Function

    Public Shared Function ObtenerCategoria(idProducto As String, idCategoria As String, idSubcategoria As String, id_Sucursales As List(Of Integer), FDesde As Date, FHasta As Date, PaginaNumero As Integer, PaginaTamaño As Integer, ordenadoPor As String, direccion As Integer, ByRef TotalElementos As Integer) As DataTable
        'Declaro variables
        Dim cmd As New SqlCommand
        Dim dt As DataTable = New DataTable()

        'Cargo el listado de sucursales
        dt.Columns.Add("ID", Type.GetType("System.Int64"))
        For Each id As Integer In id_Sucursales
            dt.Rows.Add(id)
        Next

        cmd.Connection = clsDatos.ConectarRemoto()
        dt = InvocarSPPaginadoConFiltro(cmd, "sp_InformeVentas_Categoria", idProducto, idCategoria, idSubcategoria, dt, FDesde, FHasta, PaginaNumero, PaginaTamaño, ordenadoPor, direccion)
        clsDatos.DesconectarRemoto()

        TotalElementos = If(dt.Rows.Count > 0, dt(0)("TotalRegistros"), 0)

        Return dt
    End Function

    Public Shared Function ObtenerCategorias(idProducto As String, idCategoria As String, idSubcategoria As String, id_Sucursales As List(Of Integer), FDesde As Date, FHasta As Date, PaginaNumero As Integer, PaginaTamaño As Integer, ordenadoPor As String, direccion As SortOrder, ByRef TotalElementos As Integer) As DataTable
        'Declaro variables
        Dim cmd As New SqlCommand
        Dim dt As DataTable = New DataTable()

        'Cargo el listado de sucursales
        dt.Columns.Add("ID", Type.GetType("System.Int64"))
        For Each id As Integer In id_Sucursales
            dt.Rows.Add(id)
        Next

        cmd.Connection = clsDatos.ConectarRemoto()
        dt = InvocarSPPaginadoConFiltro(cmd, "sp_InformeVentas_Categoria", idProducto, idCategoria, idSubcategoria, dt, FDesde, FHasta, PaginaNumero, PaginaTamaño, ordenadoPor, direccion)
        clsDatos.DesconectarRemoto()

        TotalElementos = If(dt.Rows.Count > 0, dt(0)("TotalRegistros"), 0)

        Return dt
    End Function

    Public Shared Function ObtenerSubcategorias(idProducto As String, idCategoria As String, idSubcategoria As String, id_Sucursales As List(Of Integer), FDesde As Date, FHasta As Date, PaginaNumero As Integer, PaginaTamaño As Integer, ordenadoPor As String, direccion As SortOrder, ByRef TotalElementos As Integer) As DataTable
        'Declaro variables
        Dim cmd As New SqlCommand
        Dim dt As DataTable = New DataTable()

        'Cargo el listado de sucursales
        dt.Columns.Add("ID", Type.GetType("System.Int64"))
        For Each id As Integer In id_Sucursales
            dt.Rows.Add(id)
        Next

        cmd.Connection = clsDatos.ConectarRemoto()
        dt = InvocarSPPaginadoConFiltro(cmd, "sp_InformeVentas_Subcategoria", idProducto, idCategoria, idSubcategoria, dt, FDesde, FHasta, PaginaNumero, PaginaTamaño, ordenadoPor, direccion)
        clsDatos.DesconectarRemoto()

        TotalElementos = If(dt.Rows.Count > 0, dt(0)("TotalRegistros"), 0)

        Return dt
    End Function

    Public Shared Function ObtenerVentasDia(id_Sucursales As List(Of Integer), FDesde As Date, FHasta As Date, PaginaNumero As Integer, PaginaTamaño As Integer, ordenadoPor As String, direccion As SortOrder, ByRef TotalElementos As Integer) As DataTable
        Return ObtenerVentasDia(String.Empty, String.Empty, String.Empty, id_Sucursales, FDesde, FHasta, PaginaNumero, PaginaTamaño, ordenadoPor, direccion, TotalElementos)
    End Function

    Public Shared Function ObtenerVentasDia(idProducto As String, idCategoria As String, idSubcategoria As String, id_Sucursales As List(Of Integer), FDesde As Date, FHasta As Date, PaginaNumero As Integer, PaginaTamaño As Integer, ordenadoPor As String, direccion As SortOrder, ByRef TotalElementos As Integer) As DataTable
        'Declaro variables
        Dim cmd As New SqlCommand
        Dim dt As DataTable = New DataTable()

        'Cargo el listado de sucursales
        dt.Columns.Add("ID", Type.GetType("System.Int64"))
        For Each id As Integer In id_Sucursales
            dt.Rows.Add(id)
        Next

        cmd.Connection = clsDatos.ConectarRemoto()
        dt = InvocarSPPaginadoConFiltro(cmd, "sp_InformeVentas_VentasDia", idProducto, idCategoria, idSubcategoria, dt, FDesde, FHasta, PaginaNumero, PaginaTamaño, ordenadoPor, direccion)
        clsDatos.DesconectarRemoto()

        TotalElementos = If(dt.Rows.Count > 0, dt(0)("TotalRegistros"), 0)
        Return dt
    End Function

    Public Shared Function ObtenerMercaderíaRecibida(id_Sucursales As List(Of Integer), FDesde As Date, FHasta As Date, PaginaNumero As Integer, PaginaTamaño As Integer, ordenadoPor As String, direccion As SortOrder, ByRef TotalElementos As Integer) As DataTable
        'Declaro variables
        Dim cmd As New SqlCommand
        Dim dt As DataTable = New DataTable()

        'Cargo el listado de sucursales
        dt.Columns.Add("ID", Type.GetType("System.Int64"))
        For Each id As Integer In id_Sucursales
            dt.Rows.Add(id)
        Next

        cmd.Connection = clsDatos.ConectarRemoto()
        dt = InvocarSPPaginado(cmd, "sp_InformeVentas_MercaderíaRecibida", dt, FDesde, FHasta, PaginaNumero, PaginaTamaño, ordenadoPor, direccion)
        clsDatos.DesconectarRemoto()

        TotalElementos = If(dt.Rows.Count > 0, dt(0)("TotalRegistros"), 0)
        Return dt
    End Function

    Private Shared Function InvocarSPPaginado(ByRef cmd As SqlCommand, sp As String, IdSucursales As DataTable, FDesde As Date, FHasta As Date, PaginaNumero As Integer, PaginaTamaño As Integer, ordenadoPor As String, direccion As Integer) As DataTable
        cmd.CommandType = CommandType.StoredProcedure
        cmd.CommandText = sp

        cmd.Parameters.AddWithValue("@FDesde", FDesde)
        cmd.Parameters.AddWithValue("@FHasta", FHasta)
        cmd.Parameters.AddWithValue("@PaginaOrden", ordenadoPor.ToString())
        cmd.Parameters.AddWithValue("@PaginaDir", If(direccion = 1, "asc", "desc"))
        cmd.Parameters.AddWithValue("@PaginaNumero", PaginaNumero)
        cmd.Parameters.AddWithValue("@PaginaTamaño", PaginaTamaño)

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

    Private Shared Function InvocarSPPaginadoConFiltro(ByRef cmd As SqlCommand, sp As String, idProducto As String, idCategoria As String, idSubcategoria As String, IdSucursales As DataTable, FDesde As Date, FHasta As Date, PaginaNumero As Integer, PaginaTamaño As Integer, ordenadoPor As String, direccion As Integer) As DataTable
        cmd.CommandType = CommandType.StoredProcedure
        cmd.CommandText = sp

        cmd.Parameters.AddWithValue("@idProducto", If(String.IsNullOrEmpty(idProducto), DBNull.Value, idProducto))
        cmd.Parameters.AddWithValue("@idCategoria", If(String.IsNullOrEmpty(idCategoria), DBNull.Value, idCategoria))
        cmd.Parameters.AddWithValue("@idSubcategoria", If(String.IsNullOrEmpty(idSubcategoria), DBNull.Value, idSubcategoria))
        cmd.Parameters.AddWithValue("@FDesde", FDesde)
        cmd.Parameters.AddWithValue("@FHasta", FHasta)
        cmd.Parameters.AddWithValue("@PaginaOrden", ordenadoPor.ToString())
        cmd.Parameters.AddWithValue("@PaginaDir", If(direccion = 1, "asc", "desc"))
        cmd.Parameters.AddWithValue("@PaginaNumero", PaginaNumero)
        cmd.Parameters.AddWithValue("@PaginaTamaño", PaginaTamaño)

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

    Private Shared Function InvocarSP(ByRef cmd As SqlCommand, sp As String, IdSucursales As DataTable, FDesde As Date, FHasta As Date) As DataTable
        cmd.CommandType = CommandType.StoredProcedure
        cmd.CommandText = sp

        cmd.Parameters.AddWithValue("@FDesde", FDesde)
        cmd.Parameters.AddWithValue("@FHasta", FHasta)

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

    Private Shared Function MesesEntre(fechaInicio As DateTime, fechaHasta As DateTime) As IList(Of Tuple(Of DateTime, DateTime))
        Dim iterator As DateTime
        Dim limit As DateTime
        Dim result As IList(Of Tuple(Of DateTime, DateTime)) = New List(Of Tuple(Of DateTime, DateTime))

        If fechaHasta > fechaInicio Then
            iterator = fechaInicio
            limit = fechaHasta

        Else
            iterator = fechaHasta
            limit = fechaInicio
        End If


        While (iterator <= limit)
            Dim finMes = New DateTime(iterator.Year, iterator.Month, 1).AddMonths(1).AddDays(-1)
            If (limit < finMes) Then
                finMes = limit
            End If
            result.Add(New Tuple(Of Date, Date)(iterator, finMes))
            iterator = iterator.AddMonths(1)
            iterator = New DateTime(iterator.Year, iterator.Month, 1)
        End While

        Return result
    End Function

End Class
