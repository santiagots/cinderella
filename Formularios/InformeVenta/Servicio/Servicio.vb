Imports Common.Core.Interfaces
Imports Common.Data.Repository
Imports Ventas.Core.Interfaces
Imports Ventas.Core.Model.BaseAgreggate
Imports Ventas.Core.Model.InformeAggregate
Imports Common.Core.Model
Imports Ventas.Data
Imports Ventas.Data.Repository
Imports Common.Core.Enum

Namespace Formularios.InformeVenta
    Public Class Servicio

        Public Shared Function ObtenerSucursales() As IEnumerable(Of Sucursal)
            Using context As VentaContext = New VentaContext(False)
                Dim sucursalRepository As IRepository(Of Sucursal) = New Repository(Of Sucursal)(context)
                Return sucursalRepository.List()
            End Using
        End Function

        Public Shared Function ObtenerCategoria() As IEnumerable(Of Categoria)
            Using context As VentaContext = New VentaContext(False)
                Dim categiriaRepository As IRepository(Of Categoria) = New Repository(Of Categoria)(context)
                Return categiriaRepository.List()
            End Using
        End Function

        Public Shared Function ObtenerSubcategoria() As IEnumerable(Of SubCategoria)
            Using context As VentaContext = New VentaContext(False)
                Dim subcategoriaRepository As IRepository(Of SubCategoria) = New Repository(Of SubCategoria)(context)
                Return subcategoriaRepository.List()
            End Using
        End Function

        Friend Shared Function BuscarInformeVentaPorTipoVenta(idSucursales As IEnumerable(Of Integer), fechaDesde As DateTime, fechaHasta As DateTime) As IEnumerable(Of InformeVentaPorTipoVenta)
            Using context As VentaContext = New VentaContext(False)
                Dim informeVentaRepository As IInformeVentaRepository = New InformeVentaRepository(context)
                Return informeVentaRepository.InformeVentaPorTipoVenta(idSucursales, fechaDesde, fechaHasta)
            End Using
        End Function

        Friend Shared Function BuscarInformeVentaPorTipoPago(idSucursales As IEnumerable(Of Integer), fechaDesde As DateTime, fechaHasta As DateTime) As IEnumerable(Of InformeVentaPorTipoPago)
            Using context As VentaContext = New VentaContext(False)
                Dim informeVentaRepository As IInformeVentaRepository = New InformeVentaRepository(context)
                Return informeVentaRepository.InformeVentaPorTipoPago(idSucursales, fechaDesde, fechaHasta)
            End Using
        End Function

        Friend Shared Function BuscarInformeVentaPorFecha(idSucursales As IEnumerable(Of Integer), fechaDesde As DateTime, fechaHasta As DateTime, ordenadoPor As String, ordenadoDireccion As OrdenadoDireccion, itemsPorPagina As Integer, pagina As Integer, ByRef totalItems As Integer) As IEnumerable(Of InformeVentaPorFecha)
            Using context As VentaContext = New VentaContext(False)
                Dim informeVentaRepository As IInformeVentaRepository = New InformeVentaRepository(context)
                Return informeVentaRepository.InformeVentaPorFecha(idSucursales, fechaDesde, fechaHasta, ordenadoPor, ordenadoDireccion, itemsPorPagina, pagina, totalItems)
            End Using
        End Function

        Friend Shared Function BuscarInformeProductoPorFecha(idSucursales As IEnumerable(Of Integer), fechaDesde As DateTime, fechaHasta As DateTime, idProducto As Integer?, categoria As Categoria, subCategoria As SubCategoria, ordenadoPor As String, ordenadoDireccion As OrdenadoDireccion, itemsPorPagina As Integer, pagina As Integer, ByRef totalItems As Integer) As IEnumerable(Of InformeVentaPorProducto)
            Using context As VentaContext = New VentaContext(False)
                Dim informeVentaRepository As IInformeVentaRepository = New InformeVentaRepository(context)
                Return informeVentaRepository.InformeProductoPorFecha(idSucursales, fechaDesde, fechaHasta, idProducto, categoria, subCategoria, ordenadoPor, ordenadoDireccion, itemsPorPagina, pagina, totalItems)
            End Using
        End Function

        Friend Shared Function BuscarInformeProductoPorNombre(idSucursales As IEnumerable(Of Integer), fechaDesde As DateTime, fechaHasta As DateTime, idProducto As Integer?, categoria As Categoria, subCategoria As SubCategoria, ordenadoPor As String, ordenadoDireccion As OrdenadoDireccion, itemsPorPagina As Integer, pagina As Integer, ByRef totalItems As Integer) As IEnumerable(Of InformeVentaPorProducto)
            Using context As VentaContext = New VentaContext(False)
                Dim informeVentaRepository As IInformeVentaRepository = New InformeVentaRepository(context)
                Return informeVentaRepository.InformeProductoPorNombre(idSucursales, fechaDesde, fechaHasta, idProducto, categoria, subCategoria, ordenadoPor, ordenadoDireccion, itemsPorPagina, pagina, totalItems)
            End Using
        End Function

        Friend Shared Function BuscarInformeProductoPorCategoria(idSucursales As IEnumerable(Of Integer), fechaDesde As DateTime, fechaHasta As DateTime, idProducto As Integer?, categoria As Categoria, subCategoria As SubCategoria, ordenadoPor As String, ordenadoDireccion As OrdenadoDireccion, itemsPorPagina As Integer, pagina As Integer, ByRef totalItems As Integer) As IEnumerable(Of InformeVentaPorProducto)
            Using context As VentaContext = New VentaContext(False)
                Dim informeVentaRepository As IInformeVentaRepository = New InformeVentaRepository(context)
                Return informeVentaRepository.InformeProductoPorCategoria(idSucursales, fechaDesde, fechaHasta, idProducto, categoria, subCategoria, ordenadoPor, ordenadoDireccion, itemsPorPagina, pagina, totalItems)
            End Using
        End Function

        Friend Shared Function BuscarInformeProductoPorSubCategoria(idSucursales As IEnumerable(Of Integer), fechaDesde As DateTime, fechaHasta As DateTime, idProducto As Integer?, categoria As Categoria, subCategoria As SubCategoria, ordenadoPor As String, ordenadoDireccion As OrdenadoDireccion, itemsPorPagina As Integer, pagina As Integer, ByRef totalItems As Integer) As IEnumerable(Of InformeVentaPorProducto)
            Using context As VentaContext = New VentaContext(False)
                Dim informeVentaRepository As IInformeVentaRepository = New InformeVentaRepository(context)
                Return informeVentaRepository.InformeProductoPorSubCategoria(idSucursales, fechaDesde, fechaHasta, idProducto, categoria, subCategoria, ordenadoPor, ordenadoDireccion, itemsPorPagina, pagina, totalItems)
            End Using
        End Function

        Friend Shared Function BuscarInformGastos(idSucursales As IEnumerable(Of Integer), fechaDesde As DateTime, fechaHasta As DateTime) As IEnumerable(Of InformeVentaEgresos)
            Using context As VentaContext = New VentaContext(False)
                Dim informeVentaRepository As IInformeVentaRepository = New InformeVentaRepository(context)
                Return informeVentaRepository.InformeGastos(idSucursales, fechaDesde, fechaHasta)
            End Using
        End Function

        Friend Shared Function BuscarInformeCostos(idSucursales As IEnumerable(Of Integer), fechaDesde As DateTime, fechaHasta As DateTime) As IEnumerable(Of InformeVentaEgresos)
            Using context As VentaContext = New VentaContext(False)
                Dim informeVentaRepository As IInformeVentaRepository = New InformeVentaRepository(context)
                Return informeVentaRepository.InformeCostos(idSucursales, fechaDesde, fechaHasta)
            End Using
        End Function

        Friend Shared Function BuscarInformeMercaderia(idSucursales As IEnumerable(Of Integer), fechaDesde As DateTime, fechaHasta As DateTime, ordenadoPor As String, ordenadoDireccion As OrdenadoDireccion, itemsPorPagina As Integer, pagina As Integer, ByRef totalItems As Integer) As IEnumerable(Of InformeVentaEgresos)
            Using context As VentaContext = New VentaContext(False)
                Dim informeVentaRepository As IInformeVentaRepository = New InformeVentaRepository(context)
                Return informeVentaRepository.InformeMercaderia(idSucursales, fechaDesde, fechaHasta, ordenadoPor, ordenadoDireccion, itemsPorPagina, pagina, totalItems)
            End Using
        End Function

        Friend Shared Function ObtenerTotalVenta(idSucursales As IEnumerable(Of Integer), fechaDesde As DateTime, fechaHasta As DateTime) As Decimal
            Using context As VentaContext = New VentaContext(False)
                Dim informeVentaRepository As IInformeVentaRepository = New InformeVentaRepository(context)
                Return informeVentaRepository.TotalVenta(idSucursales, fechaDesde, fechaHasta)
            End Using
        End Function
        Friend Shared Function ObtenerTotalMercaderia(idSucursales As IEnumerable(Of Integer), fechaDesde As DateTime, fechaHasta As DateTime) As Decimal
            Using context As VentaContext = New VentaContext(False)
                Dim informeVentaRepository As IInformeVentaRepository = New InformeVentaRepository(context)
                Return informeVentaRepository.TotalMercaderia(idSucursales, fechaDesde, fechaHasta)
            End Using
        End Function
    End Class
End Namespace
